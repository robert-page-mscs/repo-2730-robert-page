' Name:         Chapter 6, loop, sum, and count
' Purpose:      asfasfw
' Programmer:   Robert Page on 11-26-2016



Public Class frmMain
    Private Sub btnPretestDoWhile_Click(sender As Object, e As EventArgs) Handles btnPretestDoWhile.Click
        lblEven.Text = "Pretest Do While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do While i <= 20
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop

    End Sub

    Private Sub btnPretestDoUntil_Click(sender As Object, e As EventArgs) Handles btnPretestDoUntil.Click
        lblEven.Text = "Pretest Do Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do Until i > 20
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop

    End Sub

    Private Sub btnPosttestLoopWhile_Click(sender As Object, e As EventArgs) Handles btnPosttestLoopWhile.Click
        lblEven.Text = "Posttest Do While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop While i <= 20
    End Sub

    Private Sub btnPosttestLoopUntil_Click(sender As Object, e As EventArgs) Handles btnPosttestLoopUntil.Click
        lblEven.Text = "Posttest Do Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop Until i > 20
    End Sub

    Private Sub btnPretestFor_Click(sender As Object, e As EventArgs) Handles btnPretestFor.Click
        lblEven.Text = "Pretest For" & ControlChars.NewLine
        Dim i As Integer = 2
        For i = 0 To 20 Step 2
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
        Next i
    End Sub

    Private Sub btnSumDoWhile_Click(sender As Object, e As EventArgs) Handles btnSumDoWhile.Click
        ' clear screen
        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        ' calculates average
        Const strPROMPT As String =
            "Enter a number. " &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end."
        Const strTITLE As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        ' get first sales amount

        strNum = InputBox(strPROMPT, strTITLE, "0")

        ' *** Begin loop here: repeat as long as input is not empty

        Do While strNum <> String.Empty

            ' convert the input to a number

            Int32.TryParse(strNum, intNum)

            ' display the input in the text box

            txtList.Text = txtList.Text &
                intNum.ToString & ControlChars.NewLine

            ' update the counter and accumulator
            intCount = intCount + 1
            intSum = intSum + intNum

            ' *** Update control variable

            strNum = InputBox(strPROMPT, strTITLE, "0")

            ' *** End loop here
        Loop

        lblCount.Text = intCount.ToString

        ' verify that the counter is greater than 0

        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")

        Else
            lblAvg.Text = "N/A"

        End If

    End Sub

    Private Sub btnSumLoopUntil_Click(sender As Object, e As EventArgs) Handles btnSumLoopUntil.Click
        ' clear screen
        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        ' calculates average
        Const strPROMPT As String =
            "Enter a number. " &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end."
        Const strTITLE As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        ' get first sales amount

        strNum = InputBox(strPROMPT, strTITLE, "0")

        ' *** Begin loop here: repeat as long as input is not empty

        Do
            ' convert the input to a number

            Int32.TryParse(strNum, intNum)

            ' display the input in the text box

            txtList.Text = txtList.Text &
                intNum.ToString & ControlChars.NewLine

            ' update the counter and accumulator
            intCount = intCount + 1
            intSum = intSum + intNum

            ' *** Update control variable

            strNum = InputBox(strPROMPT, strTITLE, "0")

            ' *** End loop here
        Loop Until strNum = strNum + strNum

        lblCount.Text = intCount.ToString

        ' verify that the counter is greater than 0

        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")

        Else
            lblAvg.Text = "N/A"

        End If

    End Sub

    Private Sub btnSumForNext_Click(sender As Object, e As EventArgs) Handles btnSumForNext.Click
        ' clear screen
        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        ' calculates average
        Const strPROMPT As String =
            "Enter a quanity of numbers. "
        Const strTITLE As String = "Number Entry"

        Dim strNum As String
        Dim strNum2 As String
        Dim intNum As Integer
        Dim intCntDwn As Integer
        Dim intNum2 As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        ' get first sales amount

        strNum = InputBox(strPROMPT, strTITLE, "0")
        strNum2 = InputBox("Enter #" & (intCount + 1).ToString, strTITLE, "0")

        ' *** Begin loop here: repeat as long as input is not empty
        If strNum2 <> String.Empty Then


            For intCntDwn = 1 To CInt(strNum) - 1

                ' convert the input to a number

                Int32.TryParse(strNum, intNum)
                Int32.TryParse(strNum2, intNum2)

                ' display the input in the text box
                txtList.Text = txtList.Text &
                intNum2.ToString & ControlChars.NewLine

                ' update the counter and accumulator
                intNum = (intNum - 1)
                strNum = intNum.ToString
                intCount = intCount + 1
                intSum = intSum + intNum2

                ' *** Update control variable

                strNum2 = InputBox("Enter #" & (intCount + 1).ToString, strTITLE, "0")

                ' *** End loop here


            Next intCntDwn

            Int32.TryParse(strNum, intNum)
            Int32.TryParse(strNum2, intNum2)
            txtList.Text = txtList.Text &
            intNum2.ToString & ControlChars.NewLine
            intCount = intCount + 1
            intSum = intSum + intNum2
            lblCount.Text = intCount.ToString

        Else
            strNum = String.Empty
            strNum2 = String.Empty


        End If

        ' verify that the counter is greater than 0

        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")

        Else
            lblAvg.Text = "N/A"

        End If

    End Sub
End Class
