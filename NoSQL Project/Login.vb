Imports System.Data.SqlClient

Public Class Login

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles signUpBtn.Click
        SignUp.Show();
        Me.Hide()

    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Close()
    End Sub

    Private Sub signInBtn_Click(sender As Object, e As EventArgs) Handles signInBtn.Click
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM users WHERE username = '" & TextBox1.Text & "' AND password = '" & TextBox2.Text & "' ", connection.con)
        connection.con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        If (dr.Read() = True) Then
            Main.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub
End Class