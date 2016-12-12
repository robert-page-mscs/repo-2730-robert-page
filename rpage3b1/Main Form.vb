' Name:         Multiplication Project
' Purpose:      Display a multiplication table that shows
'               the multiplicand, multiplier, and product
' Programmer:   Robert Page on 11/30/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        ' displays a multiplication table

        Dim number, product, count As Integer
        lstMultTable.Items.Clear()
        lstMultTable.Items.Add("For Loop: " & ControlChars.NewLine)
        Integer.TryParse(txtNumber.Text, number)
        'For Loop

        count = 1

        Do
            product = number * count
            Dim strOutput As String = "    " & number.ToString() & " * " & count.ToString() & " = " & product.ToString()
            ' Add strOutput to ListBox
            lstMultTable.Items.Add(strOutput & ControlChars.NewLine)
            count += 1

        Loop Until count > 9


    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        ' displays a multiplication table

        Dim number, product, count As Integer
        lstMultTable.Items.Clear()
        lstMultTable.Items.Add("For Loop: " & ControlChars.NewLine)
        Integer.TryParse(txtNumber.Text, number)
        'For Loop


        For count = 1 To 9 Step 1

            product = number * count

            Dim strOutput As String = "    " & number.ToString() & " * " & count.ToString() & " = " & product.ToString()
            ' Add strOutput to ListBox
            lstMultTable.Items.Add(strOutput & ControlChars.NewLine)


        Next count



    End Sub

    Private Sub txtNumber_Enter(sender As Object, e As EventArgs) Handles txtNumber.Enter
        txtNumber.SelectAll()
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        ' allows only numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        'lblTable.Text = String.Empty
        'Clear the list box
        lstMultTable.Items.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load ListBox with test Data:
        lstPrices.Items.Clear()
        Dim intIndex As Integer
        intIndex = 1

        For intIndex = 1 To 4 Step 1
            'intIndex += 1
            Dim strIndex As String = intIndex.ToString
            lstPrices.Items.Add(intIndex & ControlChars.NewLine)

        Next intIndex

        ' calculate pretax total:
        Dim dblPretaxTotal As Double = 0
        Dim intSelectItem As Integer
        Dim strSelectPrice As String
        Dim dblSelectPrice As Double


        For intSelectItem = 0 To lstPrices.Items.Count - 1
            lstPrices.SelectedIndex = 0
            Dim strSelectItem As String = intIndex.ToString()

            Double.TryParse(strSelectPrice, dblSelectPrice)


        Next



    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    End Sub
End Class
