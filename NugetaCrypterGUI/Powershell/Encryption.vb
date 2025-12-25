Imports System.IO
Imports System.Security.Cryptography

Namespace MONSTERMCCrypterGUI.Powershell
    Friend Class Encryption

        Public Shared Function EncryptStringToBytes(ByVal plainText As String, ByVal key As Byte(), ByVal iv As Byte()) As Byte()
            Dim encrypted As Byte()
            Using aes As Aes = Aes.Create()
                aes.Key = key
                aes.IV = iv

                Dim encryptor = aes.CreateEncryptor(aes.Key, aes.IV)

                Using ms As MemoryStream = New MemoryStream()
                    Using cs As CryptoStream = New CryptoStream(ms, encryptor, CryptoStreamMode.Write)
                        Using sw As StreamWriter = New StreamWriter(cs)
                            sw.Write(plainText)
                        End Using
                        encrypted = ms.ToArray()
                    End Using
                End Using
            End Using

            Return encrypted
        End Function
    End Class
End Namespace
