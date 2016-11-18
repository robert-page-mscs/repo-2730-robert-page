' Name:         Chapter 8, String functions, list boxes
' Purpose:      #2: Interprets color code
'               #5: Sets proper upper/lower case
'               #6: Interprets shipping code
' Programmer:   Robert Page on 11-17-2016

Option Strict On
Option Explicit On
Option Infer Off

Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ItemNumbers_TextChanged(sender As Object, e As EventArgs) _
            Handles txtItem1.TextChanged, txtItem2.TextChanged, txtItem3.TextChanged, txtItem4.TextChanged, txtItem5.TextChanged
        lstColors.Items.Clear()
    End Sub

    Private Sub btnDisplayColor_Click(sender As Object, e As EventArgs) Handles btnDisplayColor.Click
        DisplayColor(txtItem1.Text)
        DisplayColor(txtItem2.Text)
        DisplayColor(txtItem3.Text)
        DisplayColor(txtItem4.Text)
        DisplayColor(txtItem5.Text)
    End Sub

    Private Sub DisplayColor(ByVal itemNum As String)
        'lstColors.Items.Add(itemNum & ": Blue")
        If itemNum.Length = 7 AndAlso
           itemNum.ToUpper Like "???[B]???" Then
            lstColors.Items.Add(itemNum & ": Blue")
        ElseIf itemNum.ToUpper Like "???[G]???" Then
            lstColors.Items.Add(itemNum & ": Green")
        ElseIf itemNum.ToUpper Like "???[R]???" Then
            lstColors.Items.Add(itemNum & ": Red")
        ElseIf itemNum.ToUpper Like "???[W]???" Then
            lstColors.Items.Add(itemNum & ": White")
        Else lstColors.Items.Add("Invalid" & itemNum)

        End If

    End Sub

    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        txtName.SelectAll()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        lblName.Text = String.Empty
    End Sub

    Private Sub btnDisplayDelivery_Click(sender As Object, e As EventArgs) Handles btnDisplayDelivery.Click
        DisplayDelivery(txtPartNum1.Text)
        DisplayDelivery(txtPartNum2.Text)
        DisplayDelivery(txtPartNum3.Text)
        DisplayDelivery(txtPartNum4.Text)
        DisplayDelivery(txtPartNum5.Text)
        DisplayDelivery(txtPartNum6.Text)
    End Sub

    Private Sub DisplayDelivery(ByVal partNum As String)
        ' lstDelivery.Items.Add("Mail - Standard")
        If partNum.Length = (3 Or 4) Then
        ElseIf partNum.ToUpper Like "##[M][S]" Then
            lstDelivery.Items.Add("Mail - Standard")
        ElseIf partNum.ToUpper Like "##[M][P]" Then
            lstDelivery.Items.Add("Mail - Priority")
        ElseIf partNum.ToUpper Like "##[F][S]" Then
            lstDelivery.Items.Add("FedEx - Standard")
        ElseIf partNum.ToUpper Like "##[F][O]" Then
            lstDelivery.Items.Add("FedEx - Overnight")
        ElseIf partNum.ToUpper Like "##[U]" Then
            lstDelivery.Items.Add("UPS")
        Else
            lstDelivery.Items.Add("invalid" & partNum)
        End If

    End Sub

    Private Sub PartNum_TextChanged(sender As Object, e As EventArgs) _
            Handles txtPartNum1.TextChanged, txtPartNum2.TextChanged, txtPartNum3.TextChanged, txtPartNum4.TextChanged, txtPartNum5.TextChanged, txtPartNum6.TextChanged
        lstDelivery.Items.Clear()
    End Sub

    'btnProper_Click pseudocode:
    '1) Convert txtName to lower case, store in strName
    '2) Use strName.Substring() to get first character of strName, convert to upper case, store in strFirstChar
    '3) Remove first character of strName
    '4) Insert strFirstChar at beginning of strName
    '5) Use strName.IndexOf() to find the space character. Add 1 and store in index
    '6) Repeat steps 2 - 4 to remove/insert first letter of last name

    Private Sub btnProper_Click(sender As Object, e As EventArgs) Handles btnProper.Click
        Dim strName As String = txtName.Text
        Dim strFirstChar As String

        Dim strLastChar As String

        strName = strName.ToLower()
        strFirstChar = strName.Substring(0, 1)
        strFirstChar = strFirstChar.ToUpper
        strLastChar = strName.Substring(strName.IndexOf(" ") + 1, 1)

        strLastChar = strLastChar.ToUpper
        strName = strName.Remove(0, 1)
        strName = strName.Insert(0, strFirstChar)
        strName = strName.Remove(strName.IndexOf(" ") + 1, 1)
        strName = strName.Insert(strName.IndexOf(" ") + 1, strLastChar)

        lblName.Text = strName

    End Sub

End Class
