' Name:         Robert Page
' Purpose:      Display counts of sales people commissions
' Programmer:   Robert Page on 12/08/2016

Option Explicit On
Option Strict On
Option Infer Off



Public Class frmMain
    Private intCommission() As Integer = {300, 500, 200, 150, 600, 750, 900,
        150, 100, 200, 250, 650, 300, 750, 800, 350, 250, 100, 100, 300}

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayCommissions()
        cboSearchValue.SelectedIndex = 0
        'cboSearchValue.SelectedIndex = 0
    End Sub

    Private Sub DisplayCommissions()

        For intDisplay As Integer = 0 To UBound(intCommission)

            lblCommission.Text &= intCommission(intDisplay).ToString & ", "

        Next intDisplay

        If lblCommission.Text.EndsWith(", ") Then
            lblCommission.Text = lblCommission.Text.Substring(0, lblCommission.Text.Length - 2)
        End If


    End Sub

    Private Sub cboSearchValue_TextChanged(sender As Object, e As EventArgs) Handles cboSearchValue.TextChanged
        Dim intValue As Integer
        Int32.TryParse(cboSearchValue.Text, intValue)
        Const strMsg As String = "Invalid Entry"

        If intValue < 1000 Then
            lblValueCount.Text = CountValue(0).ToString()
        Else
            MessageBox.Show(strMsg, "Value must be from 0 to 1000", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
        End If

    End Sub

    Private Function CountValue(intSearchValue As Integer) As Integer
        Dim intValue As Integer
        Int32.TryParse(cboSearchValue.Text, intValue)
        Dim intCount As Integer = 0

        For intSearchValue = LBound(intCommission) To UBound(intCommission)

            If intCommission(intSearchValue) = intValue Then
                intCount += 1
            Else
                intCount += 0
            End If

        Next intSearchValue

        Return intCount


    End Function

    Private Function CountRange(intSearchMin As Integer, intSearchMax As Integer) As Integer
        Dim intRange As Integer = 0


        For intSearchRange As Integer = LBound(intCommission) To UBound(intCommission)
            If intCommission(intSearchRange) >= intSearchMin AndAlso intCommission(intSearchRange) <= intSearchMax Then

                intRange += 1
            Else
                intRange += 0
            End If

        Next intSearchRange

        Return intRange

    End Function

    Private Sub cboSearchRange_TextChanged(sender As Object, e As EventArgs) Handles cboSearchRange.TextChanged
        lblRangeCount.Text = String.Empty
        Dim intSearchMin As Integer = 0
        Dim intSearchMax As Integer = 0
        Dim intHyphenIndex As Integer = cboSearchRange.Text.IndexOf("-")
        If intHyphenIndex >= 0 AndAlso cboSearchRange.Text.Length > intHyphenIndex + 1 Then
            Dim strSearchMin As String =
                cboSearchRange.Text.Substring(0, intHyphenIndex).Trim()
            Dim strSearchMax As String =
                cboSearchRange.Text.Substring(intHyphenIndex + 1).Trim()
            Int32.TryParse(strSearchMin, intSearchMin)
            Int32.TryParse(strSearchMax, intSearchMax)
            If intSearchMax >= intSearchMin Then
                lblRangeCount.Text = CountRange(intSearchMin, intSearchMax).ToString
            End If
        End If
    End Sub
End Class
