Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2 As Double
        'If the user did the wrong thing, then message box
        If Not (IsNumeric(txtFirstNum.Text)) And (IsNumeric(txtSecondNum.Text)) Then
            'check if user types a number in first and second text box is a number
            MessageBox.Show("Error: Please input a number in the text box", "Error")
            Return
        End If
        'Remeber the end if if you do an If statement

        num1 = CDbl(txtFirstNum.Text)
        num2 = CDbl(txtSecondNum.Text)
        'Must use this before the zeros because you must read what is in the text box 

        If num1 < 0 Or num2 < 0 Then
            MessageBox.Show("Error: Please input a positive number into the text box", "Error")
            Return
        End If

        'Then do the computations
        
        If (num1 > num2) Then
            txtResult.Text = " Larger number is " & num1
        ElseIf (num2 > num1) Then
            txtResult.Text = "Larger number is " & num2
        Else
            txtResult.Text = "The two are equal"
        End If


    End Sub
End Class
