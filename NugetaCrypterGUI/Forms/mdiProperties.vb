Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports MONSTERMC.MONSTERMCCrypterGUI.Forms

Namespace MONSTERMCCrypterGUI.Forms
	Public Module mdiProperties
		<DllImport("user32.dll")>
		Private Function GetWindowLong(ByVal hWnd As IntPtr, ByVal nIndex As Integer) As Integer
		End Function

		<DllImport("user32.dll")>
		Private Function SetWindowLong(ByVal hWnd As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
		End Function

		<DllImport("user32.dll")>
		Private Function SetWindowPos(ByVal hWnd As IntPtr, ByVal hWndInsertAfter As IntPtr, ByVal x As Integer, ByVal Y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal uFlags As UInteger) As Integer
		End Function

		Private Const GWL_EXYSTYLE As Integer = -20
		Private Const WS_EX_CLIENTEDGE As Integer = &H200
		Private Const SWP_NOSIZE As UInteger = &H1
		Private Const SWP_NOMOVE As UInteger = &H2
		Private Const SWP_NOZORDER As UInteger = &H4
		Private Const SWO_NOACTIVATE As UInteger = &H10
		Private Const SWP_FRAMECHANGED As UInteger = &H20
		Private Const SWO_NOOWNERZORDER As UInteger = &H200

		<System.Runtime.CompilerServices.Extension>
		Public Function SetBevel(ByVal form As Form, ByVal show As Boolean) As Boolean
			For Each c As Control In form.Controls
				Dim client As MdiClient = TryCast(c, MdiClient)
				If client IsNot Nothing Then
					Dim windowLong As Integer = GetWindowLong(c.Handle, GWL_EXYSTYLE)
					If show Then
						windowLong = windowLong Or WS_EX_CLIENTEDGE
					Else
						windowLong = windowLong And WS_EX_CLIENTEDGE
					End If
					SetWindowLong(c.Handle, GWL_EXYSTYLE, windowLong)
					SetWindowPos(client.Handle, IntPtr.Zero, 0, 0, 0, 0, SWO_NOACTIVATE Or SWP_NOMOVE Or SWP_NOSIZE Or SWP_NOZORDER Or SWO_NOOWNERZORDER Or SWP_FRAMECHANGED)
					Return True
				End If
			Next c
			Return False
		End Function
	End Module
End Namespace