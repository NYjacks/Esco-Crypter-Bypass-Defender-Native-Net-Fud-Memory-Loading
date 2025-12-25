Imports System
Imports System.Text
Imports System.Text.RegularExpressions
Imports MONSTERMC.MONSTERMCCrypterGUI.Forms
Namespace MONSTERMCCrypterGUI.Powershell.Obfuscate
    Friend Class Obfuscate
        Public Shared Function ObfuscatePowerShellCode(ByVal originalCode As String) As String
            ' Rename variables
            Dim variableRegex As Regex = New Regex("\$(\w+)")
            originalCode = variableRegex.Replace(originalCode, Function(match)
                                                                   Dim originalVariableName = match.Groups(1).Value
                                                                   Dim obfuscatedVariableName As String = GenerateObfuscatedName()
                                                                   Return "$" & obfuscatedVariableName
                                                               End Function)

            ' Rename functions
            Dim functionRegex As Regex = New Regex("function\s+(\w+)")
            originalCode = functionRegex.Replace(originalCode, Function(match)
                                                                   Dim originalFunctionName = match.Groups(1).Value
                                                                   Dim obfuscatedFunctionName As String = GenerateObfuscatedName()
                                                                   Return "function " & obfuscatedFunctionName
                                                               End Function)

            ' Randomize control flow
            Dim conditions = {"-eq", "-ne", "-gt", "-lt", "-ge", "-le", "-like", "-notlike", "-match", "-notmatch"}
            Dim conditionRegex As Regex = New Regex("(\s+-\w+\s+)(\$\w+)")
            originalCode = conditionRegex.Replace(originalCode, Function(match)
                                                                    Dim conditionOperator As String = conditions(New Random().Next(conditions.Length))
                                                                    Dim originalVariableName = match.Groups(2).Value
                                                                    Dim obfuscatedVariableName As String = GenerateObfuscatedName()
                                                                    Return match.Groups(1).Value & "$" & obfuscatedVariableName
                                                                End Function)

            Return originalCode
        End Function

        Private Shared Function GenerateObfuscatedName() As String
            ' Generate random obfuscated name
            Dim sb As StringBuilder = New StringBuilder()
            Dim random As Random = New Random()
            Dim characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
            Dim length = random.Next(5, 11) ' Generate random length between 5 and 10 characters
            For i = 0 To length - 1
                Dim index = random.Next(0, characters.Length)
                sb.Append(characters(index))
            Next
            Return sb.ToString()
        End Function
    End Class
End Namespace
