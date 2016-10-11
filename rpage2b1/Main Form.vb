'Name:          Cranston Berries Project
'Purpose:       Calculate projected sale
'Programmer:    Robert Page on 10/10/2016

Option Strict On
Option Explicit On
Option Infer Off


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

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'lblStraw.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtStraw.Text), "currency")
        'lblBlue.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtBlue.Text), "currency")
        'lblRasp.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtRasp.Text), "currency")

        Dim dblProjIncrease As Double
        Dim dblStraw As Double
        Dim dblBlue As Double
        Dim dblRasp As Double
        Dim decStraw As Decimal = 0.0D
        Dim decBlue As Decimal = 0.0D
        Dim decRasp As Decimal = 0.0D

        Double.TryParse(txtProjIncrease.Text, dblProjIncrease)
        Double.TryParse(txtStraw.Text, dblStraw)
        Double.TryParse(txtBlue.Text, dblBlue)
        Double.TryParse(txtRasp.Text, dblRasp)

        decStraw = CDec((1 + dblProjIncrease) * dblStraw)
        decBlue = CDec((1 + dblProjIncrease) * dblBlue)
        decRasp = CDec((1 + dblProjIncrease) * dblRasp)

        lblStraw.Text = decStraw.ToString("C2")
        lblBlue.Text = decBlue.ToString("C2")
        lblRasp.Text = decRasp.ToString("C2")



    End Sub

    Private Sub btnRetirementForm_Click(sender As Object, e As EventArgs) Handles btnRetirementForm.Click

        frmRetirement.Show()

    End Sub
End Class
