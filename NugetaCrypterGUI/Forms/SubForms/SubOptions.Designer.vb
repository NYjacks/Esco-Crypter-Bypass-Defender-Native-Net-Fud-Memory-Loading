Imports System

Namespace NugetaCrypterGUI.Forms.SubForms
    Partial Class SubOptions
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
            OptionsGroupBox = New Guna.UI2.WinForms.Guna2GroupBox()
            batchCheck = New Guna.UI2.WinForms.Guna2CustomCheckBox()
            label1 = New Windows.Forms.Label()
            FileChooser = New Guna.UI2.WinForms.Guna2Button()
            guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
            ExtensionsDropDown = New Guna.UI2.WinForms.Guna2ComboBox()
            OptionsGroupBox.SuspendLayout()
            guna2GroupBox1.SuspendLayout()
            SuspendLayout()
            ' 
            ' OptionsGroupBox
            ' 
            OptionsGroupBox.BorderColor = Drawing.Color.FromArgb(33, 37, 43)
            OptionsGroupBox.BorderThickness = 2
            OptionsGroupBox.Controls.Add(batchCheck)
            OptionsGroupBox.Controls.Add(label1)
            OptionsGroupBox.Controls.Add(FileChooser)
            OptionsGroupBox.CustomBorderColor = Drawing.Color.FromArgb(33, 37, 43)
            OptionsGroupBox.CustomBorderThickness = New Windows.Forms.Padding(0, 40, 3, 3)
            OptionsGroupBox.FillColor = Drawing.Color.FromArgb(44, 49, 58)
            OptionsGroupBox.Font = New Drawing.Font("Segoe UI", 9.0F)
            OptionsGroupBox.ForeColor = Drawing.Color.White
            OptionsGroupBox.Location = New Drawing.Point(34, 131)
            OptionsGroupBox.Name = "OptionsGroupBox"
            OptionsGroupBox.Size = New Drawing.Size(533, 159)
            OptionsGroupBox.TabIndex = 4
            OptionsGroupBox.Text = "Loader Settings"
            ' 
            ' batchCheck
            ' 
            batchCheck.CheckedState.BorderColor = Drawing.Color.White
            batchCheck.CheckedState.BorderRadius = 2
            batchCheck.CheckedState.BorderThickness = 0
            batchCheck.CheckedState.FillColor = Drawing.Color.White
            batchCheck.Location = New Drawing.Point(13, 53)
            batchCheck.Name = "batchCheck"
            batchCheck.Size = New Drawing.Size(25, 25)
            batchCheck.TabIndex = 7
            batchCheck.Text = "BatchCheck"
            batchCheck.UncheckedState.BorderColor = Drawing.Color.White
            batchCheck.UncheckedState.BorderRadius = 2
            batchCheck.UncheckedState.BorderThickness = 1
            batchCheck.UncheckedState.FillColor = Drawing.Color.FromArgb(33, 37, 43)
            AddHandler batchCheck.Click, New EventHandler(AddressOf browserCheck_Click)
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Font = New Drawing.Font("Verdana", 11.0F)
            label1.Location = New Drawing.Point(42, 56)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(94, 18)
            label1.TabIndex = 8
            label1.Text = ".Bat Loader"
            ' 
            ' FileChooser
            ' 
            FileChooser.BorderRadius = 8
            FileChooser.DisabledState.BorderColor = Drawing.Color.DarkGray
            FileChooser.DisabledState.CustomBorderColor = Drawing.Color.DarkGray
            FileChooser.DisabledState.FillColor = Drawing.Color.FromArgb(169, 169, 169)
            FileChooser.DisabledState.ForeColor = Drawing.Color.FromArgb(141, 141, 141)
            FileChooser.FillColor = Drawing.Color.FromArgb(33, 37, 43)
            FileChooser.Font = New Drawing.Font("Segoe UI", 9.0F)
            FileChooser.ForeColor = Drawing.Color.White
            FileChooser.Location = New Drawing.Point(206, 117)
            FileChooser.Name = "FileChooser"
            FileChooser.Size = New Drawing.Size(117, 31)
            FileChooser.TabIndex = 6
            FileChooser.Text = "..."
            AddHandler FileChooser.Click, New EventHandler(AddressOf FileChooser_Click)
            ' 
            ' guna2GroupBox1
            ' 
            guna2GroupBox1.BorderColor = Drawing.Color.FromArgb(33, 37, 43)
            guna2GroupBox1.BorderThickness = 2
            guna2GroupBox1.Controls.Add(ExtensionsDropDown)
            guna2GroupBox1.CustomBorderColor = Drawing.Color.FromArgb(33, 37, 43)
            guna2GroupBox1.CustomBorderThickness = New Windows.Forms.Padding(0, 40, 3, 3)
            guna2GroupBox1.FillColor = Drawing.Color.FromArgb(44, 49, 58)
            guna2GroupBox1.Font = New Drawing.Font("Segoe UI", 9.0F)
            guna2GroupBox1.ForeColor = Drawing.Color.White
            guna2GroupBox1.Location = New Drawing.Point(34, 12)
            guna2GroupBox1.Name = "guna2GroupBox1"
            guna2GroupBox1.Size = New Drawing.Size(533, 113)
            guna2GroupBox1.TabIndex = 9
            guna2GroupBox1.Text = "Extension Spoofer"
            ' 
            ' ExtensionsDropDown
            ' 
            ExtensionsDropDown.BackColor = Drawing.Color.Transparent
            ExtensionsDropDown.DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
            ExtensionsDropDown.DropDownStyle = Windows.Forms.ComboBoxStyle.DropDownList
            ExtensionsDropDown.FocusedColor = Drawing.Color.FromArgb(94, 148, 255)
            ExtensionsDropDown.FocusedState.BorderColor = Drawing.Color.FromArgb(94, 148, 255)
            ExtensionsDropDown.Font = New Drawing.Font("Segoe UI", 10.0F)
            ExtensionsDropDown.ForeColor = Drawing.Color.FromArgb(68, 88, 112)
            ExtensionsDropDown.ItemHeight = 30
            ExtensionsDropDown.Items.AddRange(New Object() {".sln", ".com", ".src", ".txt", ".rtf", ".exe"})
            ExtensionsDropDown.Location = New Drawing.Point(183, 59)
            ExtensionsDropDown.Name = "ExtensionsDropDown"
            ExtensionsDropDown.Size = New Drawing.Size(140, 36)
            ExtensionsDropDown.TabIndex = 9
            AddHandler ExtensionsDropDown.SelectedIndexChanged, New EventHandler(AddressOf ExtensionsDropDown_SelectedIndexChanged)
            ' 
            ' SubOptions
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6.0F, 13.0F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            BackColor = Drawing.Color.FromArgb(44, 49, 58)
            ClientSize = New Drawing.Size(605, 323)
            Controls.Add(guna2GroupBox1)
            Controls.Add(OptionsGroupBox)
            FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Name = "SubOptions"
            Text = "SubOptions"
            AddHandler Load, New EventHandler(AddressOf SubOptions_Load)
            OptionsGroupBox.ResumeLayout(False)
            OptionsGroupBox.PerformLayout()
            guna2GroupBox1.ResumeLayout(False)
            ResumeLayout(False)

        End Sub

#End Region

        Private OptionsGroupBox As Guna.UI2.WinForms.Guna2GroupBox
        Private FileChooser As Guna.UI2.WinForms.Guna2Button
        Public batchCheck As Guna.UI2.WinForms.Guna2CustomCheckBox
        Private label1 As Windows.Forms.Label
        Private guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
        Private ExtensionsDropDown As Guna.UI2.WinForms.Guna2ComboBox
    End Class
End Namespace
