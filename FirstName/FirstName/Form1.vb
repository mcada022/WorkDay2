Option Strict On

Public Class Form1


    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click

        Dim fullname As String
        ' read the input from the user
        fullname = txtFullName.Text
        Dim fullnametrimmed As String
        fullnametrimmed = fullname.Trim()

        'find the first space
        Dim idxSpace As Integer
        idxSpace = fullnametrimmed.IndexOf(" ")
        ' extract the first name
        Dim firstname As String
        firstname = fullnametrimmed.Substring(0, idxSpace)

        txtfirstname.Text = firstname

        ' display the result to the user









    End Sub
End Class
