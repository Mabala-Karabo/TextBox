Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtGreetMe_Click(sender As Object, e As EventArgs) Handles txtGreetMe.Click
        Dim strFirstName As String
        Dim strSurname As String
        Dim strGender As String

        strFirstName = txtFirstName.Text
        strSurname = txtSurname.Text
        strGender = txtGender.Text

        MsgBox("Hello " + strFirstName + " " + strSurname + " it is good to know that you are " + strGender)
    End Sub
End Class
