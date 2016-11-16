Option Strict On
Option Infer Off
Option Explicit On

Public Class frmMain
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        '#03: Insert
        Dim strWord As String = txt03.Text
        strWord = strWord.Remove(0, 1)
        strWord = strWord.Insert(0, "cr")
        lbl03.Text = strWord

        '#04: Substring
        Dim strItem As String = txt04.Text
        strItem = strItem.Substring(2, 4)
        lbl04.Text = strItem

        '#05a: Length
        Dim strMsg As Integer = txt05a.Text.Length
        lbl05a.Text = strMsg.ToString()

        '#05b: Trim
        Dim strState As String = txt05b.Text.Trim
        lbl05b.Text = strState

        '#05c: Remove/Insert
        Dim strWord2 As String = txt05c.Text
        strWord2 = strWord2.Remove(1, 1)
        strWord2 = strWord2.Insert(1, "rit")
        lbl05c.Text = strWord2

        '#05d: Insert
        Dim strWord3 As String = txt05d.Text
        strWord3 = strWord3.Insert(0, "Mon")
        lbl05d.Text = strWord3

        '#05e: Pad
        Dim strPay As String = txt05e.Text
        Dim decPay As Decimal
        Decimal.TryParse(txt05e.Text, decPay)
        strPay = decPay.ToString("N2")
        strPay = strPay.PadLeft(10, "*"c)
        lbl05e.Text = strPay

        '#06: Remove
        Dim strAmount As String = txt06.Text
        strAmount = strAmount.Remove(1, 1)
        strAmount = strAmount.Remove(4, 1)
        lbl06.Text = strAmount

        '#07: Contains
        Dim strAddress As String = txt07.Text
        Dim blnIsContained As Boolean =
            strAddress.ToUpper.Contains("JEFFERSON ST")
        If Not blnIsContained Then
            lbl07.Text = "Jeff St. Not Found"
        End If

        If blnIsContained Then
            lbl07.Text = "Jeff St. Found"
        End If

        '#012: Len/Remove
        Dim strPercent As String = txt12.Text
        Dim dblPercent As Double
        Double.TryParse(strPercent, dblPercent)

        strPercent = strPercent.Remove(3, 2)
        dblPercent = CDbl(strPercent) * 10
        lbl12.Text = dblPercent.ToString()

        '#013: Like
        Dim strZip As String = txt13.Text
        'Integer.TryParse(txt13.Text, intZip)
        If strZip Like "605##" Then
            lbl13.Text = "Shipping cost: $25"
        ElseIf strZip Like "606##" Then
            lbl13.Text = "Shipping cost: $30"
        ElseIf Not txt13.MaxLength = 5 Then
            lbl13.Text = "Invalid ZIP code"
        End If

    End Sub

    Private Sub txt13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt13.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            ' cancel the key
            e.Handled = True
        End If

    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles txt03.TextChanged, txt04.TextChanged, txt05a.TextChanged, txt05b.TextChanged,
            txt05c.TextChanged, txt05d.TextChanged, txt05e.TextChanged, txt06.TextChanged, txt06.TextChanged,
            txt07.TextChanged, txt12.TextChanged, txt13.TextChanged

        lbl03.Text = String.Empty
        lbl04.Text = String.Empty
        lbl05a.Text = String.Empty
        lbl05b.Text = String.Empty
        lbl05c.Text = String.Empty
        lbl05d.Text = String.Empty
        lbl05e.Text = String.Empty
        lbl06.Text = String.Empty
        lbl07.Text = String.Empty
        lbl12.Text = String.Empty
        lbl13.Text = String.Empty

    End Sub
End Class
