Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' prepare for next calculation 

        txtAssessed.Text = String.Empty
        lblTxt.Text = String.Empty

        ' send the focus to the Assessed box

        txtAssessed.Focus()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate the amount of tax

        lblTxt.Text = Val(txtAssessed.Text) * 0.015
        lblTxt.Text = Format(lblTxt.Text, "currency")

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' print the tax amount

        PrintForm1.Print()

        btnCalc.Visible = False
        btnClear.Visible = False
        btnExit.Visible = False
        btnPrint.Visible = False

        btnCalc.Visible = True
        btnClear.Visible = True
        btnExit.Visible = True
        btnPrint.Visible = True

    End Sub
End Class
