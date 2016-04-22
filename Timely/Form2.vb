Public Class EmployeeView

    Dim _e, maxemps As Integer
    Public employees(20) As employee

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

    Private Function getday() As day
        Dim temp As New day
        Dim s(10) As shifts
        temp.s = s
        For index As Integer = 0 To 10
            temp.s(index) = getshift()
            temp.s(index).self = index
        Next
        temp.shiftnum = 0
        Return temp
    End Function

    Private Function getshift() As shifts
        Dim temp As shifts
        temp.Finish = 9999
        temp.start = 9999
        temp.filled = False
        Return temp
    End Function
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

    Public Structure shifts
        Dim start, Finish, self As Int32
        Dim filled As Boolean
    End Structure

    Public Structure day
        Dim top, shiftnum, numofshifts As Integer
        Dim start() As Integer
        Dim s() As shifts

    End Structure

    Public Structure availability
        Dim start(), finish(), top As Integer
    End Structure

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainMenu.Show()
        Me.Hide()
    End Sub

    Public Sub New(ByVal empnum As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _e = empnum
    End Sub

    Public Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs)
        Me.Visible = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'Panel8.Visible = True
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        ' Panel8.Visible = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim lol As New Form4(0)
        lol.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form5.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Form8.Show()
    End Sub

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