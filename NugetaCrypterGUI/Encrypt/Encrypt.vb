Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Imports MONSTERMC.MONSTERMCCrypterGUI.Encrypt
Imports MONSTERMC.MONSTERMCCrypterGUI

Namespace MONSTERMCCrypterGUI.Encrypt
    Friend Class Encrypt
        Public Shared Function Encryptor(ByVal data As Byte(), ByVal key As Byte(), ByVal iv As Byte()) As Byte()
            Using aes = Cryptography.Aes.Create()
                aes.KeySize = 128
                aes.BlockSize = 128
                aes.Padding = PaddingMode.Zeros

                aes.Key = key
                aes.IV = iv

                Using lEncryptor = aes.CreateEncryptor(aes.Key, aes.IV)
                    Return PerformCryptography(data, lEncryptor)
                End Using
            End Using
        End Function

        Private Shared Function PerformCryptography(ByVal data As Byte(), ByVal cryptoTransform As ICryptoTransform) As Byte()
            Using ms = New MemoryStream()
                Using cryptoStream = New CryptoStream(ms, cryptoTransform, CryptoStreamMode.Write)
                    cryptoStream.Write(data, 0, data.Length)
                    cryptoStream.FlushFinalBlock()

                    Return ms.ToArray()
                End Using
            End Using
        End Function
    End Class
End Namespace
