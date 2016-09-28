'Name:          Photo Workshop Payroll
'Purpose:       Dislay the gross pay, FWT, FICA, state income tax, and net pay.
'Programmer:    Robert Page on 9/27/2016

Option Strict On

Public Class frmMain

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Calculating gross pay, FWT, FICA, state income tax, and net pay.

        lblGross.Text = Format(Val(txtHours.Text) * Val(txtPayRate.Text), "fixed")
        lblFWT.Text = Format(Val(lblGross.Text) * 0.2, "fixed")
        lblFICA.Text = Format(Val(lblGross.Text) * 0.08, "fixed")
        lblState.Text = Format(Val(lblGross.Text) * 0.03, "fixed")
        lblNet.Text = Format(Val(lblGross.Text) - (Val(lblFWT.Text) + Val(lblFWT.Text) + Val(lblState.Text)), "fixed")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all Text and Label boxes

        txtName.Text = String.Empty
        txtHours.Text = "0.00"
        txtPayRate.Text = "0.00"
        lblGross.Text = String.Empty
        lblFWT.Text = String.Empty
        lblState.Text = String.Empty
        lblNet.Text = String.Empty

        'Setting focus on Name text box

        txtName.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
