Imports System

Namespace NugetaCrypterGUI.Forms.SubForms
    Partial Class SubformHome
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
            SuspendLayout()
            ' 
            ' SubformHome
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6.0F, 13.0F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            BackColor = Drawing.Color.FromArgb(44, 49, 58)
            ClientSize = New Drawing.Size(605, 323)
            FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Name = "SubformHome"
            Text = "SubformHome"
            AddHandler Load, New EventHandler(AddressOf SubformHome_Load)
            ResumeLayout(False)

        End Sub

#End Region
    End Class
End Namespace
