Public Class Form4
    Dim employees(20) As employee
    Dim maxemps, _e As Integer
    Public Structure employee
        Dim fname, lname As String
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
    Public Function getavail() As availability
        Dim temp As New availability
        Dim t(10) As Integer
        Dim k(10) As Integer
        t(0) = 0
        k(0) = 1440
        temp.start = t
        temp.finish = k
        For index As Integer = 1 To 10
            temp.start(index) = 9999
            temp.finish(index) = 9999
        Next index
        temp.start(0) = 0
        temp.finish(0) = 1440
        temp.top = 0
        Return temp
    End Function
    Private Function setavail(ByRef a As availability, ByVal _s As Integer, ByVal _e As Integer)
        Dim temp As Integer
        For i As Integer = 0 To 10
            If ((_s >= a.start(i)) And (_s < a.finish(i))) Then
                temp = a.finish(i)
                a.finish(i) = _s
                a.top += 1
                If (_e < temp) Then
                    a.start(a.top) = _e
                    a.finish(a.top) = temp
                End If
            End If
        Next
    End Function
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        maxemps = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel1.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel2.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel3.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel1.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel2.Visible = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Panel3.Visible = True
    End Sub

    Public Sub New(ByVal empnum As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _e = empnum
    End Sub

    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim s, f As Integer
        Dim j As New availability
        j = getavail()
        s = 9999
        f = 9999
        If ComboBox1.SelectedIndex >= 0 And ComboBox1.SelectedIndex <= 13 Then
            If ComboBox2.SelectedIndex >= 0 And ComboBox2.SelectedIndex <= 13 Then
                s = (ComboBox1.SelectedIndex * 60 + 360)
                f = (ComboBox2.SelectedIndex * 60 + 360)
                setavail(j, s, f)
            End If
        End If
        If ComboBox4.SelectedIndex >= 0 And ComboBox4.SelectedIndex <= 13 Then
            If ComboBox3.SelectedIndex >= 0 And ComboBox3.SelectedIndex <= 13 Then
                s = (ComboBox4.SelectedIndex * 60 + 360)
                f = (ComboBox3.SelectedIndex * 60 + 360)
                setavail(j, s, f)
            End If
        End If
        If ComboBox5.SelectedIndex >= 0 And ComboBox5.SelectedIndex <= 13 Then
            If ComboBox6.SelectedIndex >= 0 And ComboBox6.SelectedIndex <= 13 Then
                s = (ComboBox6.SelectedIndex * 60 + 360)
                f = (ComboBox5.SelectedIndex * 60 + 360)
                setavail(j, s, f)
            End If
        End If
        If ComboBox7.SelectedIndex >= 0 And ComboBox7.SelectedIndex <= 13 Then
            If ComboBox8.SelectedIndex >= 0 And ComboBox8.SelectedIndex <= 13 Then
                s = (ComboBox8.SelectedIndex * 60 + 360)
                f = (ComboBox7.SelectedIndex * 60 + 360)
                setavail(j, s, f)
            End If
        End If
        Label4.Text = j.start(1)
        'employees(_e).days(DateTimePicker1.Value.DayOfWeek) = j
    End Sub
    Public Function getemp(ByVal _n As String) As employee
        Dim temp As New employee
        Dim d(7) As availability
        Dim b(7) As Boolean
        Dim i(7) As Integer
        temp.max = 2400
        temp.current = 0
        temp.days = d
        temp.isin = b
        temp.sshift = i
        For index As Integer = 0 To 7
            temp.days(index) = getavail()
            temp.isin(index) = False
            temp.sshift(index) = 9
        Next index
        temp.fname = _n
        Return temp
    End Function

    Private Function reload()
        maxemps = 0
        FileOpen(1, "input.txt", OpenMode.Input)
        Dim k As Integer = 0
        For i As Integer = 0 To 19
            employees(i) = getemp("temp")
        Next i
        Dim file As String
        Dim fileArray() As String
        Do While Not EOF(1)
            maxemps += 1
            file = LineInput(1)
            fileArray = file.Split(", ")
            employees(k).fname = fileArray(0)
            employees(k).lname = fileArray(1)
            employees(k).id = fileArray(2)
            employees(k).position = fileArray(3)
            employees(k).address = fileArray(4)
            employees(k).phone = fileArray(5)
            employees(k).email = fileArray(6)
            employees(k).max = fileArray(7)

            For j As Integer = 0 To 6
                file = LineInput(1)
                fileArray = file.Split(", ")
                For m As Integer = 0 To 9
                    employees(k).days(j).start(m) = CInt(fileArray(m))

                Next
                file = LineInput(1)
                fileArray = file.Split(", ")
                For m As Integer = 0 To 9
                    employees(k).days(j).finish(m) = CInt(fileArray(m))

                Next
                file = LineInput(1)
                fileArray = file.Split(", ")

                employees(k).days(j).top = CInt(fileArray(0))

            Next
            k = k + 1
        Loop
    End Function

    Public Function rewrite()
        System.IO.File.WriteAllText("input.txt", "")
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("input.txt", True)
        For k As Integer = 0 To maxemps
            file.WriteLine(employees(k).fname & ", " & employees(k).lname & ", " & employees(k).id & ", " & employees(k).position & ", " & employees(k).address & ", " & employees(k).phone & ", " & employees(k).email & ", " & employees(k).max)
            For d As Integer = 0 To 6
                For a As Integer = 0 To 9
                    file.Write(employees(k).days(d).start(a) & ", ")
                Next
                file.Write(vbNewLine)
                For a As Integer = 0 To 9
                    file.Write(employees(k).days(d).finish(a) & ", ")
                Next
                file.Write(vbNewLine)
                file.Write(employees(k).days(d).top & ", " & vbNewLine)
            Next
        Next
    End Function
End Class