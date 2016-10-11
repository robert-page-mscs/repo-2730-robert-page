<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetirement
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtWklyGross = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmployeeRate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmployerRate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblEmployeeAC = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblEmployerAC = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTotalAC = New System.Windows.Forms.Label()
        Me.bthCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Gross weekly pay:"
        '
        'txtWklyGross
        '
        Me.txtWklyGross.Location = New System.Drawing.Point(276, 16)
        Me.txtWklyGross.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWklyGross.Name = "txtWklyGross"
        Me.txtWklyGross.Size = New System.Drawing.Size(150, 25)
        Me.txtWklyGross.TabIndex = 1
        Me.txtWklyGross.Text = "1000"
        Me.txtWklyGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(282, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Employee contribution rate (decimal form):"
        '
        'txtEmployeeRate
        '
        Me.txtEmployeeRate.Location = New System.Drawing.Point(351, 59)
        Me.txtEmployeeRate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmployeeRate.Name = "txtEmployeeRate"
        Me.txtEmployeeRate.Size = New System.Drawing.Size(75, 25)
        Me.txtEmployeeRate.TabIndex = 3
        Me.txtEmployeeRate.Text = "0.05"
        Me.txtEmployeeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 106)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(279, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Employe&r contribution rate (decimal form):"
        '
        'txtEmployerRate
        '
        Me.txtEmployerRate.Location = New System.Drawing.Point(351, 102)
        Me.txtEmployerRate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmployerRate.Name = "txtEmployerRate"
        Me.txtEmployerRate.Size = New System.Drawing.Size(75, 25)
        Me.txtEmployerRate.TabIndex = 5
        Me.txtEmployerRate.Text = "0.07"
        Me.txtEmployerRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 149)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Employee annual contribtion:"
        '
        'lblEmployeeAC
        '
        Me.lblEmployeeAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeeAC.Location = New System.Drawing.Point(276, 145)
        Me.lblEmployeeAC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmployeeAC.Name = "lblEmployeeAC"
        Me.lblEmployeeAC.Size = New System.Drawing.Size(150, 25)
        Me.lblEmployeeAC.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 192)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(192, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Employer annual contribtion:"
        '
        'lblEmployerAC
        '
        Me.lblEmployerAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployerAC.Location = New System.Drawing.Point(276, 188)
        Me.lblEmployerAC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmployerAC.Name = "lblEmployerAC"
        Me.lblEmployerAC.Size = New System.Drawing.Size(150, 25)
        Me.lblEmployerAC.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 235)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Total annual contribtion:"
        '
        'lblTotalAC
        '
        Me.lblTotalAC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotalAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalAC.Location = New System.Drawing.Point(276, 231)
        Me.lblTotalAC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalAC.Name = "lblTotalAC"
        Me.lblTotalAC.Size = New System.Drawing.Size(150, 25)
        Me.lblTotalAC.TabIndex = 11
        '
        'bthCalc
        '
        Me.bthCalc.Location = New System.Drawing.Point(96, 292)
        Me.bthCalc.Margin = New System.Windows.Forms.Padding(4)
        Me.bthCalc.Name = "bthCalc"
        Me.bthCalc.Size = New System.Drawing.Size(112, 30)
        Me.bthCalc.TabIndex = 12
        Me.bthCalc.Text = "&Calculate"
        Me.bthCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(224, 292)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 30)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmRetirement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 339)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.bthCalc)
        Me.Controls.Add(Me.lblTotalAC)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblEmployerAC)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblEmployeeAC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEmployerRate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEmployeeRate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtWklyGross)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("SansSerif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRetirement"
        Me.Text = "Retirement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtWklyGross As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmployeeRate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmployerRate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblEmployeeAC As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblEmployerAC As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTotalAC As Label
    Friend WithEvents bthCalc As Button
    Friend WithEvents btnExit As Button
End Class
