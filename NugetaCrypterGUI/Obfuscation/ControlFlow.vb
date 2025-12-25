Imports dnlib.DotNet
Imports dnlib.DotNet.Emit
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports MONSTERMC.MONSTERMCCrypterGUI.Obfuscation

Namespace MONSTERMCCrypterGUI.Obfuscation
    Friend Class ControlFlow
    End Class
    Public Class Block
        Public Sub New()
            Instructions = New List(Of Instruction)()
        End Sub

        Public Property Instructions As List(Of Instruction)

        Public Property Number As Integer
    End Class


    Public Class BlockParser
        Public Shared Function ParseMethod(ByVal meth As MethodDef) As List(Of Block)
            Dim blocks = New List(Of Block)()
            Dim block = New Block()
            Dim id = 0
            Dim usage = 0
            block.Number = id
            block.Instructions.Add(Instruction.Create(OpCodes.Nop))
            blocks.Add(block)
            block = New Block()
            Dim handlers = New Stack(Of ExceptionHandler)()

            Dim stacks As Integer = Nothing, pops As Integer = Nothing
            For Each instruction In meth.Body.Instructions
                For Each eh In meth.Body.ExceptionHandlers
                    If eh.HandlerStart Is instruction OrElse eh.TryStart Is instruction OrElse eh.FilterStart Is instruction Then handlers.Push(eh)
                Next
                For Each eh In meth.Body.ExceptionHandlers
                    If eh.HandlerEnd Is instruction OrElse eh.TryEnd Is instruction Then handlers.Pop()
                Next

                instruction.CalculateStackUsage(stacks, pops)
                block.Instructions.Add(instruction)
                usage += stacks - pops
                If stacks = 0 Then
                    If instruction.OpCode IsNot OpCodes.Nop Then
                        If (usage = 0 OrElse instruction.OpCode Is OpCodes.Ret) AndAlso handlers.Count = 0 Then
                            block.Number = Threading.Interlocked.Increment(id)
                            blocks.Add(block)
                            block = New Block()
                        End If
                    End If
                End If
            Next
            Return blocks
        End Function
    End Class

    Friend Class ControlFlowObfuscation
        Public Shared Sub Execute(ByVal md As ModuleDefMD)
            For Each type In md.Types
                If type Is md.GlobalType Then Continue For
                For Each meth In type.Methods
                    If meth.Name.StartsWith("get_") OrElse meth.Name.StartsWith("set_") Then Continue For
                    If Not meth.HasBody OrElse meth.IsConstructor Then Continue For
                    meth.Body.SimplifyBranches()
                    ExecuteMethod(meth)
                Next
            Next
        End Sub

        Private Shared Sub ExecuteMethod(ByVal meth As MethodDef)
            meth.Body.SimplifyMacros(meth.Parameters)
            Dim blocks = BlockParser.ParseMethod(meth)
            blocks = Randomize(blocks)
            meth.Body.Instructions.Clear()
            Dim local = New Local(meth.Module.CorLibTypes.Int32)
            meth.Body.Variables.Add(local)
            Dim target = Instruction.Create(OpCodes.Nop)
            Dim instr = Instruction.Create(OpCodes.Br, target)
            For Each instruction In Calc(0)
                meth.Body.Instructions.Add(instruction)
            Next
            meth.Body.Instructions.Add(Instruction.Create(OpCodes.Stloc, local))
            meth.Body.Instructions.Add(Instruction.Create(OpCodes.Br, instr))
            meth.Body.Instructions.Add(target)
            Dim predicate As Func(Of Block, Boolean) = Function(block) block IsNot blocks.[Single](Function(x) x.Number = blocks.Count - 1)

            For Each block In blocks.Where(predicate:=predicate)
                meth.Body.Instructions.Add(Instruction.Create(OpCodes.Ldloc, local))
                For Each instruction In Calc(block.Number)
                    meth.Body.Instructions.Add(instruction)
                Next
                meth.Body.Instructions.Add(Instruction.Create(OpCodes.Ceq))
                Dim instruction4 = Instruction.Create(OpCodes.Nop)
                meth.Body.Instructions.Add(Instruction.Create(OpCodes.Brfalse, instruction4))

                For Each instruction In block.Instructions
                    meth.Body.Instructions.Add(instruction)
                Next

                For Each instruction In Calc(block.Number + 1)
                    meth.Body.Instructions.Add(instruction)
                Next

                meth.Body.Instructions.Add(Instruction.Create(OpCodes.Stloc, local))
                meth.Body.Instructions.Add(instruction4)
            Next
            meth.Body.Instructions.Add(Instruction.Create(OpCodes.Ldloc, local))
            For Each instruction In Calc(blocks.Count - 1)
                meth.Body.Instructions.Add(instruction)
            Next
            meth.Body.Instructions.Add(Instruction.Create(OpCodes.Ceq))
            meth.Body.Instructions.Add(Instruction.Create(OpCodes.Brfalse, instr))
            meth.Body.Instructions.Add(Instruction.Create(OpCodes.Br, Enumerable.Single(blocks, Function(x) x.Number = blocks.Count - 1).Instructions(0)))
            meth.Body.Instructions.Add(instr)

            For Each lastBlock In Enumerable.Single(blocks, Function(x) x.Number = blocks.Count - 1).Instructions
                meth.Body.Instructions.Add(lastBlock)
            Next
        End Sub

        Private Shared ReadOnly Rnd As Random = New Random()

        Private Shared Function Randomize(ByVal input As List(Of Block)) As List(Of Block)
            Dim ret = New List(Of Block)()
            For Each group In input
                ret.Insert(Rnd.Next(0, ret.Count), group)
            Next
            Return ret
        End Function

        Private Shared Function Calc(ByVal value As Integer) As List(Of Instruction)
            Dim instructions = New List(Of Instruction) From {
                Instruction.Create(OpCodes.Ldc_I4, value)
            }
            Return instructions
        End Function

        Public Sub AddJump(ByVal instrs As IList(Of Instruction), ByVal target As Instruction)
            instrs.Add(Instruction.Create(OpCodes.Br, target))
        End Sub
    End Class

    Public Module JumpCFlow
        Public Sub Execute(ByVal [module] As ModuleDefMD)
            For Each type In [module].Types
                For Each meth In type.Methods.ToArray()
                    If Not meth.HasBody OrElse Not meth.Body.HasInstructions OrElse meth.Body.HasExceptionHandlers Then Continue For
                    For i = 0 To meth.Body.Instructions.Count - 2 - 1
                        Dim inst = meth.Body.Instructions(i + 1)
                        meth.Body.Instructions.Insert(i + 1, Instruction.Create(OpCodes.Ldstr, RenamerPhase.GenerateString(RenamerPhase.RenameMode.Ascii)))
                        meth.Body.Instructions.Insert(i + 1, Instruction.Create(OpCodes.Br_S, inst))
                        i += 2
                    Next
                Next
            Next
        End Sub
    End Module
End Namespace
