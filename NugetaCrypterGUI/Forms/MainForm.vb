Imports MONSTERMC.MONSTERMCCrypterGUI.Forms
Imports MONSTERMC.MONSTERMCCrypterGUI.Forms.SubForms
Imports MONSTERMC.NugetaCrypterGUI.Forms.SubForms
Imports System
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms

Namespace NugetaCrypterGUI.Forms
    Public Partial Class MainForm
        Inherits Form
        Friend Structure SubForms
            Public Shared subhome As SubformHome
            Public Shared suboptions As SubOptions
            Public Shared subbuild As SubBuild
        End Structure
        Public Sub New()
            InitializeComponent()
            mdiProp()
        End Sub
        Private Sub mdiProp()
            SetBevel(False)
            Enumerable.FirstOrDefault(Controls.OfType(Of MdiClient)).BackColor = Color.FromArgb(44, 49, 58)
        End Sub

        'Private Sub guna2ImageButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
        '    sidebarTransistion.Start()
        'End Sub
        'Private sidebarExpand As Boolean = True
        'Private Sub sidebarTransistion_Tick(ByVal sender As Object, ByVal e As EventArgs)
        '    If sidebarExpand Then
        '        sidePnl.Width -= 10
        '        If sidePnl.Width <= 64 Then
        '            sidebarExpand = False
        '            sidebarTransistion.Stop()
        '        End If
        '    Else
        '        sidePnl.Width += 10
        '        If sidePnl.Width >= 202 Then
        '            sidebarExpand = True
        '            sidebarTransistion.Stop()
        '        End If
        '    End If
        'End Sub

        Private Sub homeBtn_Click(ByVal sender As Object, ByVal e As EventArgs)
            If SubForms.subhome Is Nothing Then
                SubForms.subhome = New SubformHome()
                AddHandler SubForms.subhome.FormClosed, AddressOf subHome_FormClosed
                SubForms.subhome.MdiParent = Me
                SubForms.subhome.Dock = DockStyle.Fill
                Call SubForms.subhome.Show()
            Else
                Try
                    Try
                        Call SubForms.subhome.Activate()
                    Catch
                    End Try

                Catch
                End Try
            End If
        End Sub
        Private Sub subHome_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
            SubForms.subhome = Nothing
        End Sub

        Private Sub OptionsBtn_Click(ByVal sender As Object, ByVal e As EventArgs)
            Try
                If SubForms.suboptions Is Nothing Then
                    SubForms.suboptions = New SubOptions()
                    AddHandler SubForms.suboptions.FormClosed, AddressOf subOptions_FormClosed
                    SubForms.suboptions.MdiParent = Me
                    SubForms.suboptions.Dock = DockStyle.Fill
                    Call SubForms.suboptions.Show()
                Else
                    Call SubForms.suboptions.Activate()
                End If
            Catch lE As Exception
                Console.WriteLine(lE.Message)
            End Try
        End Sub
        Private Sub subOptions_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
            SubForms.suboptions = Nothing
        End Sub

        Private Sub BuildBtn_Click(ByVal sender As Object, ByVal e As EventArgs)
            If SubForms.subbuild Is Nothing Then
                SubForms.subbuild = New SubBuild()
                AddHandler SubForms.subbuild.FormClosed, AddressOf subBuild_FormClosed
                SubForms.subbuild.MdiParent = Me
                SubForms.subbuild.Dock = DockStyle.Fill
                Call SubForms.subbuild.Show()
            Else
                Try
                    Call SubForms.subbuild.Activate()
                Catch
                End Try
            End If
        End Sub
        Private Sub subBuild_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
            SubForms.suboptions = Nothing
        End Sub

    End Class
End Namespace
