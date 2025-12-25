Imports System
Imports MONSTERMC.MONSTERMCCrypterGUI.Forms.SubForms
Imports MONSTERMC.MONSTERMCCrypterGUI

Partial Class SubBuild
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(SubBuild))
            BuildGroupBox = New Guna.UI2.WinForms.Guna2GroupBox()
            StartBuildBtn = New Guna.UI2.WinForms.Guna2ImageButton()
            payloadText = New Guna.UI2.WinForms.Guna2TextBox()
            BuildGroupBox.SuspendLayout()
            SuspendLayout()
            ' 
            ' BuildGroupBox
            ' 
            BuildGroupBox.BorderColor = Drawing.Color.FromArgb(33, 37, 43)
            BuildGroupBox.BorderThickness = 2
            BuildGroupBox.Controls.Add(StartBuildBtn)
            BuildGroupBox.Controls.Add(payloadText)
            BuildGroupBox.CustomBorderColor = Drawing.Color.FromArgb(33, 37, 43)
            BuildGroupBox.CustomBorderThickness = New Windows.Forms.Padding(0, 40, 3, 3)
            BuildGroupBox.FillColor = Drawing.Color.FromArgb(44, 49, 58)
            BuildGroupBox.Font = New Drawing.Font("Segoe UI", 9.0F)
            BuildGroupBox.ForeColor = Drawing.Color.White
            BuildGroupBox.Location = New Drawing.Point(36, 83)
            BuildGroupBox.Name = "BuildGroupBox"
            BuildGroupBox.Size = New Drawing.Size(533, 157)
            BuildGroupBox.TabIndex = 4
            BuildGroupBox.Text = "Build"
            ' 
            ' StartBuildBtn
            ' 
            StartBuildBtn.CheckedState.ImageSize = New Drawing.Size(64, 64)
            StartBuildBtn.HoverState.ImageSize = New Drawing.Size(30, 30)
            StartBuildBtn.Image = CType(resources.GetObject("StartBuildBtn.Image"), Drawing.Image)
            StartBuildBtn.ImageOffset = New Drawing.Point(0, 0)
            StartBuildBtn.ImageRotate = 0F
            StartBuildBtn.ImageSize = New Drawing.Size(30, 30)
            StartBuildBtn.Location = New Drawing.Point(323, 76)
            StartBuildBtn.Name = "StartBuildBtn"
            StartBuildBtn.PressedState.ImageSize = New Drawing.Size(30, 30)
            StartBuildBtn.Size = New Drawing.Size(64, 54)
            StartBuildBtn.TabIndex = 8
            AddHandler StartBuildBtn.Click, New EventHandler(AddressOf StartBuildBtn_Click)
            ' 
            ' payloadText
            ' 
            payloadText.BorderColor = Drawing.Color.FromArgb(33, 37, 43)
            payloadText.Cursor = Windows.Forms.Cursors.IBeam
            payloadText.DefaultText = ""
            payloadText.DisabledState.BorderColor = Drawing.Color.FromArgb(208, 208, 208)
            payloadText.DisabledState.FillColor = Drawing.Color.FromArgb(226, 226, 226)
            payloadText.DisabledState.ForeColor = Drawing.Color.FromArgb(138, 138, 138)
            payloadText.DisabledState.PlaceholderForeColor = Drawing.Color.FromArgb(138, 138, 138)
            payloadText.FillColor = Drawing.Color.FromArgb(33, 37, 43)
            payloadText.FocusedState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            payloadText.Font = New Drawing.Font("Segoe UI", 9.0F)
            payloadText.ForeColor = Drawing.Color.White
            payloadText.HoverState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            payloadText.Location = New Drawing.Point(117, 88)
            payloadText.Name = "payloadText"
            payloadText.PasswordChar = Microsoft.VisualBasic.Strings.ChrW(0)
            payloadText.PlaceholderText = "Payload Name"
            payloadText.SelectedText = ""
            payloadText.Size = New Drawing.Size(200, 36)
            payloadText.TabIndex = 7
            ' 
            ' SubBuild
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6.0F, 13.0F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            BackColor = Drawing.Color.FromArgb(44, 49, 58)
            ClientSize = New Drawing.Size(605, 323)
            Controls.Add(BuildGroupBox)
            FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Name = "SubBuild"
            Text = "SubBuild"
            AddHandler Load, New EventHandler(AddressOf SubBuild_Load)
            BuildGroupBox.ResumeLayout(False)
            ResumeLayout(False)

        End Sub

#End Region

        Private BuildGroupBox As Guna.UI2.WinForms.Guna2GroupBox
        Private StartBuildBtn As Guna.UI2.WinForms.Guna2ImageButton
        Private payloadText As Guna.UI2.WinForms.Guna2TextBox
    End Class
End Namespace
