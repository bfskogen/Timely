
Public Class Register
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Or TextBox2.Text <> "" Or TextBox3.Text <> "" Or TextBox4.Text <> "" Or TextBox4.Text <> "" Or TextBox4.Text <> "" Or TextBox4.Text <> "" Or TextBox4.Text <> "" Or TextBox4.Text <> "" Then
            Form3.Show()
            Me.Hide()
        Else
            Form9.Show()
        End If
    End Sub

End Class