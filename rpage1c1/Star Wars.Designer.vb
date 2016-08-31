<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStarWars
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblDarth = New System.Windows.Forms.Label()
        Me.lblTrooper = New System.Windows.Forms.Label()
        Me.picTrooper = New System.Windows.Forms.PictureBox()
        Me.picDarth = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picTrooper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDarth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDarth
        '
        Me.lblDarth.AutoSize = True
        Me.lblDarth.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDarth.Location = New System.Drawing.Point(86, 305)
        Me.lblDarth.Name = "lblDarth"
        Me.lblDarth.Size = New System.Drawing.Size(83, 37)
        Me.lblDarth.TabIndex = 2
        Me.lblDarth.Text = "Darth"
        '
        'lblTrooper
        '
        Me.lblTrooper.AutoSize = True
        Me.lblTrooper.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrooper.Location = New System.Drawing.Point(256, 305)
        Me.lblTrooper.Name = "lblTrooper"
        Me.lblTrooper.Size = New System.Drawing.Size(176, 37)
        Me.lblTrooper.TabIndex = 3
        Me.lblTrooper.Text = "Stormtrooper"
        '
        'picTrooper
        '
        Me.picTrooper.Image = Global.rpage1c1.My.Resources.Resources.Trooper
        Me.picTrooper.Location = New System.Drawing.Point(244, 24)
        Me.picTrooper.Name = "picTrooper"
        Me.picTrooper.Size = New System.Drawing.Size(200, 250)
        Me.picTrooper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTrooper.TabIndex = 1
        Me.picTrooper.TabStop = False
        '
        'picDarth
        '
        Me.picDarth.Image = Global.rpage1c1.My.Resources.Resources.Darth
        Me.picDarth.Location = New System.Drawing.Point(27, 24)
        Me.picDarth.Name = "picDarth"
        Me.picDarth.Size = New System.Drawing.Size(200, 250)
        Me.picDarth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDarth.TabIndex = 0
        Me.picDarth.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3000
        '
        'frmStarWars
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(466, 387)
        Me.Controls.Add(Me.lblTrooper)
        Me.Controls.Add(Me.lblDarth)
        Me.Controls.Add(Me.picTrooper)
        Me.Controls.Add(Me.picDarth)
        Me.Name = "frmStarWars"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Star Wars Characters"
        CType(Me.picTrooper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDarth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picDarth As PictureBox
    Friend WithEvents picTrooper As PictureBox
    Friend WithEvents lblDarth As Label
    Friend WithEvents lblTrooper As Label
    Friend WithEvents Timer1 As Timer
End Class
