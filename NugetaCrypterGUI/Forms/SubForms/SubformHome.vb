Imports System
Imports System.Windows.Forms

Namespace NugetaCrypterGUI.Forms.SubForms
    Public Partial Class SubformHome
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub SubformHome_Load(ByVal sender As Object, ByVal e As EventArgs)
            ControlBox = False
        End Sub
    End Class
End Namespace
