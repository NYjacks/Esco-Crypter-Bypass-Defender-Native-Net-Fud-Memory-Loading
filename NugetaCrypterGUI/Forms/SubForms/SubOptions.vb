Imports System
Imports System.Windows.Forms

Namespace NugetaCrypterGUI.Forms.SubForms
    Friend Structure Path
        Public Shared FilePath As String
        Public Shared Extension As String
        Public Shared Batch As Boolean
        Public Shared Vbs As Boolean
    End Structure
    Public Partial Class SubOptions
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub SubOptions_Load(ByVal sender As Object, ByVal e As EventArgs)
            ControlBox = False
        End Sub

        Private Sub FileChooser_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim openFileDialog As OpenFileDialog = New OpenFileDialog()

            openFileDialog.Filter = "Executable Files|*.exe"


            Dim result As DialogResult = openFileDialog.ShowDialog()

            If result = DialogResult.OK Then
                Dim selectedFilePath = openFileDialog.FileName

                Path.FilePath = selectedFilePath
            Else
                MessageBox.Show("No file selected.")
            End If
        End Sub

        Private Sub ExtensionsDropDown_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Path.Extension = ExtensionsDropDown.Text.ToString()
            MessageBox.Show(Path.Extension)
        End Sub

        Private Sub browserCheck_Click(ByVal sender As Object, ByVal e As EventArgs)
            Path.Batch = batchCheck.Checked
        End Sub
    End Class
End Namespace
