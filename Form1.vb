Public Class Form1
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        If TextBoxUsername.Text = "" Or TextBoxPassword.Text = "" Then
            MsgBox("Username / Password kosong")
        ElseIf TextBoxUsername.Text = "admin" And TextBoxPassword.Text = "pass" Then
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Usename dan Password salah")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBoxPassword.UseSystemPasswordChar = True
        Else
            TextBoxPassword.UseSystemPasswordChar = False
        End If
    End Sub
End Class
