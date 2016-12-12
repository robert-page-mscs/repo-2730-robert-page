<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblCommission = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboSearchValue = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboSearchRange = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblValueCount = New System.Windows.Forms.Label()
        Me.lblRangeCount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Commission values:"
        '
        'lblCommission
        '
        Me.lblCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommission.Location = New System.Drawing.Point(127, 8)
        Me.lblCommission.Name = "lblCommission"
        Me.lblCommission.Size = New System.Drawing.Size(319, 109)
        Me.lblCommission.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Search for value:"
        '
        'cboSearchValue
        '
        Me.cboSearchValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboSearchValue.FormattingEnabled = True
        Me.cboSearchValue.Items.AddRange(New Object() {"50", "100", "300", "900"})
        Me.cboSearchValue.Location = New System.Drawing.Point(127, 159)
        Me.cboSearchValue.Name = "cboSearchValue"
        Me.cboSearchValue.Size = New System.Drawing.Size(121, 105)
        Me.cboSearchValue.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Search for range:"
        '
        'cboSearchRange
        '
        Me.cboSearchRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboSearchRange.FormattingEnabled = True
        Me.cboSearchRange.Items.AddRange(New Object() {"    0 - 200", "100 - 300", "700 - 800"})
        Me.cboSearchRange.Location = New System.Drawing.Point(127, 280)
        Me.cboSearchRange.Name = "cboSearchRange"
        Me.cboSearchRange.Size = New System.Drawing.Size(121, 128)
        Me.cboSearchRange.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(287, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Count:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(287, 287)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Count:"
        '
        'lblValueCount
        '
        Me.lblValueCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblValueCount.Location = New System.Drawing.Point(346, 159)
        Me.lblValueCount.Name = "lblValueCount"
        Me.lblValueCount.Size = New System.Drawing.Size(100, 23)
        Me.lblValueCount.TabIndex = 8
        '
        'lblRangeCount
        '
        Me.lblRangeCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRangeCount.Location = New System.Drawing.Point(346, 287)
        Me.lblRangeCount.Name = "lblRangeCount"
        Me.lblRangeCount.Size = New System.Drawing.Size(100, 23)
        Me.lblRangeCount.TabIndex = 9
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 423)
        Me.Controls.Add(Me.lblRangeCount)
        Me.Controls.Add(Me.lblValueCount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboSearchRange)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboSearchValue)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCommission)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.Text = "rlpage3e1 Arrays, Functions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblCommission As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboSearchValue As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboSearchRange As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblValueCount As Label
    Friend WithEvents lblRangeCount As Label
End Class
