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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblEven = New System.Windows.Forms.Label()
        Me.btnPretestFor = New System.Windows.Forms.Button()
        Me.btnPosttestLoopUntil = New System.Windows.Forms.Button()
        Me.btnPosttestLoopWhile = New System.Windows.Forms.Button()
        Me.btnPretestDoUntil = New System.Windows.Forms.Button()
        Me.btnPretestDoWhile = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtList = New System.Windows.Forms.TextBox()
        Me.btnSumForNext = New System.Windows.Forms.Button()
        Me.btnSumLoopUntil = New System.Windows.Forms.Button()
        Me.btnSumDoWhile = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblEven)
        Me.GroupBox1.Controls.Add(Me.btnPretestFor)
        Me.GroupBox1.Controls.Add(Me.btnPosttestLoopUntil)
        Me.GroupBox1.Controls.Add(Me.btnPosttestLoopWhile)
        Me.GroupBox1.Controls.Add(Me.btnPretestDoUntil)
        Me.GroupBox1.Controls.Add(Me.btnPretestDoWhile)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 17)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(320, 314)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "p347 #13 Loop 2-20"
        '
        'lblEven
        '
        Me.lblEven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEven.Location = New System.Drawing.Point(7, 26)
        Me.lblEven.Name = "lblEven"
        Me.lblEven.Size = New System.Drawing.Size(142, 275)
        Me.lblEven.TabIndex = 6
        '
        'btnPretestFor
        '
        Me.btnPretestFor.Location = New System.Drawing.Point(155, 254)
        Me.btnPretestFor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPretestFor.Name = "btnPretestFor"
        Me.btnPretestFor.Size = New System.Drawing.Size(159, 47)
        Me.btnPretestFor.TabIndex = 5
        Me.btnPretestFor.Text = "Pretest: For"
        Me.btnPretestFor.UseVisualStyleBackColor = True
        '
        'btnPosttestLoopUntil
        '
        Me.btnPosttestLoopUntil.Location = New System.Drawing.Point(155, 197)
        Me.btnPosttestLoopUntil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPosttestLoopUntil.Name = "btnPosttestLoopUntil"
        Me.btnPosttestLoopUntil.Size = New System.Drawing.Size(159, 47)
        Me.btnPosttestLoopUntil.TabIndex = 4
        Me.btnPosttestLoopUntil.Text = "Posttest: Loop Until"
        Me.btnPosttestLoopUntil.UseVisualStyleBackColor = True
        '
        'btnPosttestLoopWhile
        '
        Me.btnPosttestLoopWhile.Location = New System.Drawing.Point(155, 140)
        Me.btnPosttestLoopWhile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPosttestLoopWhile.Name = "btnPosttestLoopWhile"
        Me.btnPosttestLoopWhile.Size = New System.Drawing.Size(159, 47)
        Me.btnPosttestLoopWhile.TabIndex = 3
        Me.btnPosttestLoopWhile.Text = "Posttest: Loop While"
        Me.btnPosttestLoopWhile.UseVisualStyleBackColor = True
        '
        'btnPretestDoUntil
        '
        Me.btnPretestDoUntil.Location = New System.Drawing.Point(155, 83)
        Me.btnPretestDoUntil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPretestDoUntil.Name = "btnPretestDoUntil"
        Me.btnPretestDoUntil.Size = New System.Drawing.Size(159, 47)
        Me.btnPretestDoUntil.TabIndex = 2
        Me.btnPretestDoUntil.Text = "Pretest: Do Until"
        Me.btnPretestDoUntil.UseVisualStyleBackColor = True
        '
        'btnPretestDoWhile
        '
        Me.btnPretestDoWhile.Location = New System.Drawing.Point(155, 26)
        Me.btnPretestDoWhile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPretestDoWhile.Name = "btnPretestDoWhile"
        Me.btnPretestDoWhile.Size = New System.Drawing.Size(159, 47)
        Me.btnPretestDoWhile.TabIndex = 1
        Me.btnPretestDoWhile.Text = "Pretest: Do While"
        Me.btnPretestDoWhile.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtList)
        Me.GroupBox2.Controls.Add(Me.btnSumForNext)
        Me.GroupBox2.Controls.Add(Me.btnSumLoopUntil)
        Me.GroupBox2.Controls.Add(Me.btnSumDoWhile)
        Me.GroupBox2.Controls.Add(Me.lblCount)
        Me.GroupBox2.Controls.Add(Me.lblAvg)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(340, 17)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(320, 244)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "p332_348 # 22_Addition"
        '
        'txtList
        '
        Me.txtList.Location = New System.Drawing.Point(7, 36)
        Me.txtList.Multiline = True
        Me.txtList.Name = "txtList"
        Me.txtList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtList.Size = New System.Drawing.Size(149, 190)
        Me.txtList.TabIndex = 8
        '
        'btnSumForNext
        '
        Me.btnSumForNext.Location = New System.Drawing.Point(162, 190)
        Me.btnSumForNext.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSumForNext.Name = "btnSumForNext"
        Me.btnSumForNext.Size = New System.Drawing.Size(150, 36)
        Me.btnSumForNext.TabIndex = 7
        Me.btnSumForNext.Text = "Sum, For Next"
        Me.btnSumForNext.UseVisualStyleBackColor = True
        '
        'btnSumLoopUntil
        '
        Me.btnSumLoopUntil.Location = New System.Drawing.Point(162, 144)
        Me.btnSumLoopUntil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSumLoopUntil.Name = "btnSumLoopUntil"
        Me.btnSumLoopUntil.Size = New System.Drawing.Size(150, 36)
        Me.btnSumLoopUntil.TabIndex = 6
        Me.btnSumLoopUntil.Text = "Sum, Loop Until"
        Me.btnSumLoopUntil.UseVisualStyleBackColor = True
        '
        'btnSumDoWhile
        '
        Me.btnSumDoWhile.Location = New System.Drawing.Point(162, 98)
        Me.btnSumDoWhile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSumDoWhile.Name = "btnSumDoWhile"
        Me.btnSumDoWhile.Size = New System.Drawing.Size(150, 36)
        Me.btnSumDoWhile.TabIndex = 5
        Me.btnSumDoWhile.Text = "Sum, Do While"
        Me.btnSumDoWhile.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCount.Location = New System.Drawing.Point(243, 49)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(69, 36)
        Me.lblCount.TabIndex = 4
        '
        'lblAvg
        '
        Me.lblAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvg.Location = New System.Drawing.Point(162, 49)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(69, 36)
        Me.lblAvg.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(243, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Count:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(162, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Average:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 340)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.Text = "`a"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblEven As Label
    Friend WithEvents btnPretestFor As Button
    Friend WithEvents btnPosttestLoopUntil As Button
    Friend WithEvents btnPosttestLoopWhile As Button
    Friend WithEvents btnPretestDoUntil As Button
    Friend WithEvents btnPretestDoWhile As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSumForNext As Button
    Friend WithEvents btnSumLoopUntil As Button
    Friend WithEvents btnSumDoWhile As Button
    Friend WithEvents lblCount As Label
    Friend WithEvents lblAvg As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtList As TextBox
End Class
