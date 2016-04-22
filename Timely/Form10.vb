Public Class Form10
    Public Structure employee
        Dim name As String
        Dim max, current, sshift() As Integer
        Dim isin() As Boolean
        Dim days() As availability
        Dim id As Integer
        Dim position As String
        Dim address As String
        Dim email As String
        Dim phone As String
    End Structure

    Public Structure availability
        Dim start(), finish(), top As Integer
    End Structure

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Show()
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Label12.Text = Form3.employees(0).phone
        Label11.Text = Form3.employees(0).address
        Label10.Text = Form3.employees(0).lname
        Label9.Text = Form3.employees(0).fname
        Label8.Text = Form3.employees(0).id
        Label13.Text = Form3.employees(0).email
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel2.Show()
        Panel1.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel3.Show()
        Panel2.Visible = False
        Panel1.Visible = False
        Panel4.Visible = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        MsgBox("Are you sure?")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel4.Show()
        Panel2.Visible = False
        Panel1.Visible = False
        Panel3.Visible = False
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class