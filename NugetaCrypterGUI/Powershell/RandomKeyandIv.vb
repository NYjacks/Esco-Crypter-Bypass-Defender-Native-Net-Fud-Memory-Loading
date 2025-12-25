Imports System.Security.Cryptography

Namespace MONSTERMCCrypterGUI.Powershell
    Friend Class RandomKeyandIv
        Public Shared Function GenerateRandomBytes(ByVal length As Integer) As Byte()
            Dim bytes = New Byte(length - 1) {}
            Using rng = New RNGCryptoServiceProvider()
                rng.GetBytes(bytes)
            End Using
            Return bytes
        End Function
    End Class
End Namespace
