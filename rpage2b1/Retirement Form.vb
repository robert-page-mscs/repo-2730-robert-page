'Name:          Retirement Project
'Purpose:       Calculate projected Retirement
'Programmer:    Robert Page on 10/10/2016

Option Strict On
Option Explicit On
Option Infer Off



Public Class frmRetirement
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub bthCalc_Click(sender As Object, e As EventArgs) Handles bthCalc.Click
        ' caculate Retirement

        Const intYearly As Integer = 52

        Dim intWklyGross As Integer
        Dim dblEmployeeRate As Double
        Dim dblEmployerRate As Double
        Dim decEmployeeAC As Decimal
        Dim decEmployerAC As Decimal
        Dim decTotalAC As Decimal

        Integer.TryParse(txtWklyGross.Text, intWklyGross)
        Double.TryParse(txtEmployeeRate.Text, dblEmployeeRate)
        Double.TryParse(txtEmployerRate.Text, dblEmployerRate)

        decEmployeeAC = CDec(intYearly * intWklyGross * dblEmployeeRate)
        decEmployerAC = CDec(intYearly * intWklyGross * dblEmployerRate)

        decTotalAC = decEmployeeAC + decEmployerAC

        lblEmployeeAC.Text = decEmployeeAC.ToString("C2")
        lblEmployerAC.Text = decEmployerAC.ToString("C2")
        lblTotalAC.Text = decTotalAC.ToString("C2")


    End Sub
End Class