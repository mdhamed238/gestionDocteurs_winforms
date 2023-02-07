Imports System.Data.SqlClient

Public Class Form1
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim username As String = TextUsername.Text
        Dim password As String = TextPassword.Text
        Dim loginSuccessful As Boolean = Login(username, password)

        If loginSuccessful Then
            MessageBox.Show("Login successful")
            Dim form As New FormDocteur
            form.Show()
            Me.Hide()
        Else
            MessageBox.Show("Incorrect username or password")
        End If
    End Sub


    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        TextUsername.Clear()
        TextPassword.Clear()
        TextUsername.Focus()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Hide()
    End Sub

    Private Function Login(username As String, password As String) As Boolean
        Dim conn As SqlConnection = Database.GetConnection()
        conn.Open()
        Dim loginSuccessful As Boolean = False

        Dim command As New SqlCommand("SELECT password FROM Login WHERE username=@username AND password=@password", conn)
        command.Parameters.AddWithValue("@username", username)
        command.Parameters.AddWithValue("@password", password)
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            loginSuccessful = True
        End If

        reader.Close()
        conn.Close()
        Return loginSuccessful
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextPassword.PasswordChar = "*"c
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPassword.CheckedChanged
        If Not CheckPassword.Checked Then
            TextPassword.PasswordChar = "*"c
        Else
            TextPassword.PasswordChar = Char.MinValue
        End If
    End Sub
End Class
