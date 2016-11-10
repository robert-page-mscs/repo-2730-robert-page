' Name:         Marshall Sales Commission
' Purpose:      Display Total Commission
' Programmer:   Robert Page on 11-09-2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub txtSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSales.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back AndAlso
            e.KeyChar <> "." Then
            ' cancel the key
            e.Handled = True
        End If
    End Sub

    Private Sub btnThen_Click(sender As Object, e As EventArgs) Handles btnThen.Click
        lblCom.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCom.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCom As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalCom As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK)
        End If

        If boolSalesOK AndAlso dblSales < 1.0 Then
            dblCom = 0.0
        End If

        If boolSalesOK AndAlso dblSales >= 1.0 AndAlso dblSales < 6000.0 Then
            dblCom = dblSales * 1
        End If

        If boolSalesOK AndAlso dblSales >= 6000.0 AndAlso dblSales < 30000.0 Then
            dblCom = 120.0 + (dblSales - 6000.0) * 0.13
        End If

        If boolSalesOK AndAlso dblSales >= 30000.0 Then
            dblCom = 3120.0 + (dblSales - 30000.0) * 0.14
        End If

        If chkTenYears.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTraveling.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotalCom = dblCom + dblAdditional

        If boolSalesOK Then
            lblCom.Text = dblCom.ToString("c2")
            lblAdditional.Text = dblAdditional.ToString("c2")
            lblTotalCom.Text = dblTotalCom.ToString("c2")
        End If

        txtSales.Focus()

    End Sub

    Private Sub btnNested_Click(sender As Object, e As EventArgs) Handles btnNested.Click
        lblCom.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCom.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCom As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalCom As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK)
        End If

        If boolSalesOK AndAlso dblSales > 30000.0 Then
            dblCom = 3120.0 + (dblSales - 30000.0) * 0.14
        Else
            If dblSales > 6000.0 Then
                dblCom = 120.0 + (dblSales - 6000.0) * 0.13
            Else
                If dblSales > 1.0 Then
                    dblCom = dblSales * 1
                Else
                    If dblSales > 0.0 Then
                        dblCom = 0.0
                    End If
                End If
            End If
        End If


        If chkTenYears.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTraveling.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotalCom = dblCom + dblAdditional

        lblCom.Text = dblCom.ToString("c2")
        lblAdditional.Text = dblAdditional.ToString("c2")
        lblTotalCom.Text = dblTotalCom.ToString("c2")

        txtSales.Focus()

    End Sub

    Private Sub btnElself_Click(sender As Object, e As EventArgs) Handles btnElself.Click
        lblCom.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCom.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCom As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalCom As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK)
        End If

        If boolSalesOK Then
            Select Case dblSales
                Case Is > 30000.0
                    dblCom = 3120.0 + (dblSales - 30000.0) * 0.14
                Case Is >= 6000.0
                    dblCom = 120.0 + (dblSales - 6000.0) * 0.13
                Case Is >= 1
                    dblCom = dblSales * 1
                Case Is > 0
                    dblCom = 0.0
            End Select
        End If

        If chkTenYears.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTraveling.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotalCom = dblCom + dblAdditional

        lblCom.Text = dblCom.ToString("c2")
        lblAdditional.Text = dblAdditional.ToString("c2")
        lblTotalCom.Text = dblTotalCom.ToString("c2")


        txtSales.Focus()

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        lblCom.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCom.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCom As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalCom As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK)
        End If

        If boolSalesOK AndAlso dblSales < 1.0 Then
            dblCom = 0.0
        End If

        If boolSalesOK AndAlso dblSales >= 1.0 AndAlso dblSales < 6000.0 Then
            dblCom = dblSales * 1
        End If

        If boolSalesOK AndAlso dblSales >= 6000.0 AndAlso dblSales < 30000.0 Then
            dblCom = 120.0 + (dblSales - 6000.0) * 0.13
        End If

        If boolSalesOK AndAlso dblSales >= 30000.0 Then
            dblCom = 3120.0 + (dblSales - 30000.0) * 0.14
        End If

        If chkTenYears.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTraveling.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotalCom = dblCom + dblAdditional

        If boolSalesOK Then
            lblCom.Text = dblCom.ToString("c2")
            lblAdditional.Text = dblAdditional.ToString("c2")
            lblTotalCom.Text = dblTotalCom.ToString("c2")
        End If

        txtSales.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtSales_Enter(sender As Object, e As EventArgs) Handles txtSales.Enter
        txtSales.SelectAll()
    End Sub

    Private Sub ClearCommission(sender As Object, e As EventArgs) Handles txtSales.TextChanged, chkTenYears.CheckedChanged, chkTraveling.CheckedChanged
        lblCom.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCom.Text = String.Empty

    End Sub
End Class
