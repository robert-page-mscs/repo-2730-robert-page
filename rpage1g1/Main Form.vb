'Name:          Average Project
'Purpose:       Display the average of 3 test score
'Programmer:    Robert Page on 9/15/2016

Option Strict On

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Calculating average Score

        lblTestAverage.Text = Format((Val(txtScore1.Text) + Val(txtScore2.Text) + Val(txtScore3.Text)) / 3, "Fixed")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clearing the text boxes

        txtScore1.Text = String.Empty
        txtScore2.Text = String.Empty
        txtScore3.Text = String.Empty
        lblTestAverage.Text = String.Empty

        'Setting focuse to test score 1 text box

        txtScore1.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
