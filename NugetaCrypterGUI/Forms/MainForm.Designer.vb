Imports System

Namespace NugetaCrypterGUI.Forms
    Partial Class MainForm
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.topPnl = New System.Windows.Forms.Panel()
            Me.exitBtn = New Guna.UI2.WinForms.Guna2ControlBox()
            Me.titleLbl = New System.Windows.Forms.Label()
            Me.guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
            Me.sidePnl = New System.Windows.Forms.FlowLayoutPanel()
            Me.homeBtn = New Guna.UI2.WinForms.Guna2Button()
            Me.OptionsBtn = New Guna.UI2.WinForms.Guna2Button()
            Me.BuildBtn = New Guna.UI2.WinForms.Guna2Button()
            Me.sidebarTransistion = New System.Windows.Forms.Timer(Me.components)
            Me.MainDrag = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
            Me.Rounded = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
            Me.rightPanel = New Guna.UI2.WinForms.Guna2Panel()
            Me.topPnl.SuspendLayout()
            Me.sidePnl.SuspendLayout()
            Me.SuspendLayout()
            '
            'topPnl
            '
            Me.topPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
            Me.topPnl.Controls.Add(Me.exitBtn)
            Me.topPnl.Controls.Add(Me.titleLbl)
            Me.topPnl.Controls.Add(Me.guna2ImageButton1)
            Me.topPnl.Dock = System.Windows.Forms.DockStyle.Top
            Me.topPnl.Location = New System.Drawing.Point(202, 0)
            Me.topPnl.Name = "topPnl"
            Me.topPnl.Size = New System.Drawing.Size(649, 35)
            Me.topPnl.TabIndex = 4
            '
            'exitBtn
            '
            Me.exitBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.exitBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
            Me.exitBtn.IconColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
            Me.exitBtn.Location = New System.Drawing.Point(601, 0)
            Me.exitBtn.Name = "exitBtn"
            Me.exitBtn.Size = New System.Drawing.Size(48, 35)
            Me.exitBtn.TabIndex = 1
            '
            'titleLbl
            '
            Me.titleLbl.AutoSize = True
            Me.titleLbl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.titleLbl.ForeColor = System.Drawing.Color.White
            Me.titleLbl.Location = New System.Drawing.Point(46, 8)
            Me.titleLbl.Name = "titleLbl"
            Me.titleLbl.Size = New System.Drawing.Size(51, 17)
            Me.titleLbl.TabIndex = 1
            Me.titleLbl.Text = "Nugeta"
            '
            'guna2ImageButton1
            '
            Me.guna2ImageButton1.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
            Me.guna2ImageButton1.HoverState.ImageSize = New System.Drawing.Size(15, 15)
            Me.guna2ImageButton1.Image = CType(resources.GetObject("guna2ImageButton1.Image"), System.Drawing.Image)
            Me.guna2ImageButton1.ImageOffset = New System.Drawing.Point(0, 0)
            Me.guna2ImageButton1.ImageRotate = 0!
            Me.guna2ImageButton1.ImageSize = New System.Drawing.Size(15, 15)
            Me.guna2ImageButton1.Location = New System.Drawing.Point(2, 1)
            Me.guna2ImageButton1.Name = "guna2ImageButton1"
            Me.guna2ImageButton1.PressedState.ImageSize = New System.Drawing.Size(15, 15)
            Me.guna2ImageButton1.Size = New System.Drawing.Size(38, 33)
            Me.guna2ImageButton1.TabIndex = 1
            '
            'sidePnl
            '
            Me.sidePnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
            Me.sidePnl.Controls.Add(Me.homeBtn)
            Me.sidePnl.Controls.Add(Me.OptionsBtn)
            Me.sidePnl.Controls.Add(Me.BuildBtn)
            Me.sidePnl.Dock = System.Windows.Forms.DockStyle.Left
            Me.sidePnl.Location = New System.Drawing.Point(0, 0)
            Me.sidePnl.Name = "sidePnl"
            Me.sidePnl.Size = New System.Drawing.Size(202, 360)
            Me.sidePnl.TabIndex = 5
            '
            'homeBtn
            '
            Me.homeBtn.CustomImages.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
            Me.homeBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.homeBtn.CustomImages.ImageOffset = New System.Drawing.Point(8, 0)
            Me.homeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.homeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.homeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.homeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.homeBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
            Me.homeBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.homeBtn.ForeColor = System.Drawing.Color.White
            Me.homeBtn.Location = New System.Drawing.Point(3, 3)
            Me.homeBtn.Name = "homeBtn"
            Me.homeBtn.Size = New System.Drawing.Size(197, 47)
            Me.homeBtn.TabIndex = 2
            Me.homeBtn.Text = "Home"
            '
            'OptionsBtn
            '
            Me.OptionsBtn.CustomImages.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
            Me.OptionsBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.OptionsBtn.CustomImages.ImageOffset = New System.Drawing.Point(8, 0)
            Me.OptionsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.OptionsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.OptionsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.OptionsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.OptionsBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
            Me.OptionsBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.OptionsBtn.ForeColor = System.Drawing.Color.White
            Me.OptionsBtn.Location = New System.Drawing.Point(3, 56)
            Me.OptionsBtn.Name = "OptionsBtn"
            Me.OptionsBtn.Size = New System.Drawing.Size(197, 47)
            Me.OptionsBtn.TabIndex = 3
            Me.OptionsBtn.Text = "Options"
            '
            'BuildBtn
            '
            Me.BuildBtn.CustomImages.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
            Me.BuildBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.BuildBtn.CustomImages.ImageOffset = New System.Drawing.Point(8, 0)
            Me.BuildBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.BuildBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.BuildBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.BuildBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.BuildBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
            Me.BuildBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.BuildBtn.ForeColor = System.Drawing.Color.White
            Me.BuildBtn.Location = New System.Drawing.Point(3, 109)
            Me.BuildBtn.Name = "BuildBtn"
            Me.BuildBtn.Size = New System.Drawing.Size(197, 47)
            Me.BuildBtn.TabIndex = 4
            Me.BuildBtn.Text = "Build"
            '
            'sidebarTransistion
            '
            Me.sidebarTransistion.Interval = 10
            '
            'MainDrag
            '
            Me.MainDrag.DockIndicatorTransparencyValue = 0.6R
            Me.MainDrag.TargetControl = Me.topPnl
            Me.MainDrag.UseTransparentDrag = True
            '
            'Rounded
            '
            Me.Rounded.BorderRadius = 10
            Me.Rounded.TargetControl = Me
            '
            'rightPanel
            '
            Me.rightPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(43, Byte), Integer))
            Me.rightPanel.Location = New System.Drawing.Point(803, 34)
            Me.rightPanel.Name = "rightPanel"
            Me.rightPanel.Size = New System.Drawing.Size(48, 415)
            Me.rightPanel.TabIndex = 6
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(851, 360)
            Me.Controls.Add(Me.topPnl)
            Me.Controls.Add(Me.sidePnl)
            Me.Controls.Add(Me.rightPanel)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.IsMdiContainer = True
            Me.Name = "MainForm"
            Me.Text = "MainForm"
            Me.topPnl.ResumeLayout(False)
            Me.topPnl.PerformLayout()
            Me.sidePnl.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private topPnl As Windows.Forms.Panel
        Private exitBtn As Guna.UI2.WinForms.Guna2ControlBox
        Private titleLbl As Windows.Forms.Label
        Private guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
        Private sidePnl As Windows.Forms.FlowLayoutPanel
        Private homeBtn As Guna.UI2.WinForms.Guna2Button
        Private OptionsBtn As Guna.UI2.WinForms.Guna2Button
        Private BuildBtn As Guna.UI2.WinForms.Guna2Button
        Private sidebarTransistion As Windows.Forms.Timer
        Private MainDrag As Guna.UI2.WinForms.Guna2DragControl
        Private Rounded As Guna.UI2.WinForms.Guna2Elipse
        Private rightPanel As Guna.UI2.WinForms.Guna2Panel
    End Class
End Namespace
