
Option Strict On


Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' preparing for next projected increase percentage

        txtProjIncrease.Text = "0.05"
        txtStraw.Text = String.Empty
        txtBlue.Text = String.Empty
        txtRasp.Text = String.Empty
        lblStraw.Text = String.Empty
        lblBlue.Text = String.Empty
        lblRasp.Text = String.Empty

        ' send to focus to the Projected Increase Box

        txtProjIncrease.Focus()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' print projected increase results

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

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        lblStraw.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtStraw.Text), "currency")
        lblBlue.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtBlue.Text), "currency")
        lblRasp.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtRasp.Text), "currency")

    End Sub
End Class
