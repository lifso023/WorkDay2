Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click
        Dim fullName As String
        'Read the input from the user in the full name text box
        fullName = txtFullName.Text

        Dim fullNameTrimmed As String
        fullNameTrimmed = fullName.Trim()
        'trimmed full name

        Dim idxSpace As Integer
        idxSpace = fullNameTrimmed.IndexOf(" ")
        'Use indexof to find the space

        Dim firstname As String
        firstname = fullNameTrimmed.Substring(0, idxSpace)
        'pull first name from full name

        txtFirstName.Text = firstname
        'Display it back to the user
    End Sub
End Class
