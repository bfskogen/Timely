Public Class Form3
    Public employees(20) As employee

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileOpen(1, "input.txt", OpenMode.Input)
        Dim k As Integer = 0
        For i As Integer = 0 To 19
            employees(i) = getemp("temp")
        Next i
        Dim file As String
        Dim fileArray() As String
        Do While Not EOF(1)
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form6.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Form7.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form10.Show()
    End Sub
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




    Private Function dayassign(ByRef emp As employee, ByVal _s As Integer, ByRef week As day(), ByVal day As Integer)
        emp.isin(day) = True
        week(day).s(_s).filled = True
        emp.sshift(day) = _s
        emp.current += (week(day).s(_s).Finish - week(day).s(_s).start)
    End Function

    Private Function daysetshift(ByVal _s As Integer, ByVal _e As Integer, ByRef d As day)
        d.s(d.shiftnum).start = _s
        d.s(d.shiftnum).Finish = _e
        d.shiftnum += 1
        d.s(d.shiftnum).filled = False
    End Function

    Private Function availcheck(ByVal _s As Integer, ByVal _e As Integer, ByRef a As availability) As Boolean
        For index As Integer = 0 To 10
            If _s >= a.start(index) Then
                If _e <= a.finish(index) Then
                    Return True
                End If
            End If
        Next index
        Return False
    End Function

    Private Function empcheckmax(ByRef emp As employee, ByVal x As Integer) As Boolean
        If (emp.current + x) <= emp.max Then
            Return True
        End If
        Return False
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

    Private Function generate(ByRef emps As employee(), ByVal maxemps As Integer, ByRef week As day())
        For e As Integer = 0 To maxemps - 1
            For d As Integer = 0 To 6   'day loop
                If Not emps(e).isin(d) Then     'if employee already works that day
                    For s As Integer = 0 To 2
                        If Not emps(e).isin(d) Then
                            If (week(d).s(s).filled = False) Then     'if no one works this shift
                                If availcheck(week(d).s(s).start, week(d).s(s).Finish, emps(e).days(d)) Then
                                    If empcheckmax(emps(e), (week(d).s(s).Finish - week(d).s(s).start)) Then
                                        dayassign(emps(e), s, week, d)
                                    End If
                                End If
                            End If
                        End If
                    Next s
                End If
            Next d
        Next e
        For i As Integer = 0 To 4
        Next
    End Function

    Private Function recheck(ByRef emps As employee(), ByRef week As day())
        Dim used(10) As Integer
        Dim top As Integer
        top = 0
        For i As Integer = 0 To 10
            used(i) = 999
        Next i
        Dim wrong(7, 3) As Boolean
        For j As Integer = 0 To 6
            For k As Integer = 0 To 3
                wrong(j, k) = False
            Next k
        Next j
        For d As Integer = 0 To 6
            For s As Integer = 0 To 2
                If Not week(d).s(s).filled Then
                    find(week, emps, d, s, used, top)
                End If
            Next s
        Next d

    End Function

    Private Function find(ByRef week As day(), ByRef emps As employee(), ByVal d As Integer, ByVal s As Integer, ByVal used As Integer(), ByRef top As Integer)
        Dim temp As Boolean
        temp = False
        For k As Integer = 0 To 4
            temp = False
            For it As Integer = 0 To 10
                If k = used(it) Then
                    temp = True
                End If
            Next it
            If temp Then
                Continue For
            End If
            If availcheck(week(d).s(s).start, week(d).s(s).Finish, emps(k).days(d)) Then
                If empcheckmax(emps(k), (week(d).s(s).Finish - week(d).s(s).start)) Then
                    For u As Integer = 0 To 5
                        If emps(u).sshift(d) = s Then
                            emps(u).sshift(d) = Nothing
                            emps(u).isin(d) = False
                        End If
                    Next u
                    dayassign(emps(k), s, week, d)
                    Return True
                Else
                    For shif As Integer = 0 To 6
                        If Not emps(k).sshift(shif) = 9 Then 'checking to see if you can replace an existing shif to make room for the new one
                            If ((week(shif).s(emps(k).sshift(shif)).Finish - week(shif).s(emps(k).sshift(shif)).start + (emps(k).max - emps(k).current)) >= (week(d).s(s).Finish - week(d).s(s).start)) Then
                                used(top) = k
                                top += 1
                                If (find(week, emps, shif, emps(k).sshift(shif), used, top)) Then
                                    top -= 1
                                    dayassign(emps(k), s, week, d)
                                    Return True
                                End If
                            End If
                        End If
                    Next shif
                End If
            End If
        Next k
        Return False
    End Function

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim west, zach, ben, logan, john As New employee
    '    Dim emps(5) As employee
    '    west = getemp("west")
    '    zach = getemp("zach")
    '    ben = getemp("ben")
    '    logan = getemp("logan")
    '    john = getemp("john")
    '    Dim week(7) As day
    '    emps(0) = west
    '    emps(1) = zach
    '    emps(2) = ben
    '    emps(3) = logan
    '    emps(4) = john
    '    Dim j As New availability
    '    j = getavail()
    '    For index As Integer = 0 To 6
    '        week(index) = getday()
    '        daysetshift(480, 960, week(index))
    '        daysetshift(720, 1020, week(index))
    '        daysetshift(900, 1200, week(index))
    '        setavail(west.days(index), 1140, 1440)
    '        setavail(zach.days(index), 0, 900)
    '        setavail(logan.days(index), 0, 660)
    '        ' setavail(john.days(index), 480, 660)
    '    Next index

    '    generate(emps, 5, week)

    '    'Label1.Text = ""
    '    'Label2.Text = ""
    '    'Label3.Text = ""
    '    'Label4.Text = ""
    '    'For i As Integer = 0 To 4
    '    '    Label1.Text += (week(0).s(emps(i).sshift(0)).start & " " & week(0).s(emps(i).sshift(0)).Finish & vbNewLine)
    '    '    Label2.Text += (week(1).s(emps(i).sshift(1)).start & " " & week(1).s(emps(i).sshift(1)).Finish & vbNewLine)
    '    '    Label3.Text += (week(2).s(emps(i).sshift(2)).start & " " & week(2).s(emps(i).sshift(2)).Finish & vbNewLine)
    '    Label4.Text += (week(3).s(emps(i).sshift(3)).start & " " & week(3).s(emps(i).sshift(3)).Finish & vbNewLine)
    '    Label5.Text += (week(4).s(emps(i).sshift(4)).start & " " & week(4).s(emps(i).sshift(4)).Finish & vbNewLine)
    '    Label6.Text += (week(5).s(emps(i).sshift(5)).start & " " & week(5).s(emps(i).sshift(5)).Finish & vbNewLine)
    '    Label7.Text += (week(6).s(emps(i).sshift(6)).start & " " & week(6).s(emps(i).sshift(6)).Finish & vbNewLine)
    'Next i

    'Label1.Text += (vbNewLine)
    'Label2.Text += (vbNewLine)
    'Label3.Text += (vbNewLine)
    'Label4.Text += (vbNewLine)
    'Label5.Text += (vbNewLine)
    'Label6.Text += (vbNewLine)
    'Label7.Text += (vbNewLine)

    'recheck(emps, week)

    'For i As Integer = 0 To 4
    '    Label1.Text += (week(0).s(emps(i).sshift(0)).start & " " & week(0).s(emps(i).sshift(0)).Finish & vbNewLine)
    '    Label2.Text += (week(1).s(emps(i).sshift(1)).start & " " & week(1).s(emps(i).sshift(1)).Finish & vbNewLine)
    '    Label3.Text += (week(2).s(emps(i).sshift(2)).start & " " & week(2).s(emps(i).sshift(2)).Finish & vbNewLine)
    '    Label4.Text += (week(3).s(emps(i).sshift(3)).start & " " & week(3).s(emps(i).sshift(3)).Finish & vbNewLine)
    '    Label5.Text += (week(4).s(emps(i).sshift(4)).start & " " & week(4).s(emps(i).sshift(4)).Finish & vbNewLine)
    '    Label6.Text += (week(5).s(emps(i).sshift(5)).start & " " & week(5).s(emps(i).sshift(5)).Finish & vbNewLine)
    '    Label7.Text += (week(6).s(emps(i).sshift(6)).start & " " & week(6).s(emps(i).sshift(6)).Finish & vbNewLine)
    'Next i

    'End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim week(7) As day
        Dim box(7, 3) As RichTextBox
        For i As Integer = 0 To 6
            week(i) = getday()
            'daysetshift(480, 960, week(i))
            daysetshift(720, 1020, week(i))
            daysetshift(900, 1200, week(i))
        Next
        generate(employees, 5, week)
        recheck(employees, week)
        Dim py As Integer
        Dim px As Integer
        RichTextBox1.BringToFront()
        RichTextBox2.BringToFront()
        RichTextBox3.BringToFront()
        RichTextBox4.BringToFront()
        RichTextBox5.BringToFront()
        RichTextBox6.BringToFront()
        RichTextBox7.BringToFront()
        For d As Integer = 0 To 6
            px = 237 + (d * 113)
            For s As Integer = 0 To 2
                py = 102 + (s * 90)
                box(d, s) = New RichTextBox()

                box(d, s).Location = New Point(px, py)
                box(d, s).Visible = True
                box(d, s).Width = 110
                box(d, s).Height = 90
                box(d, s).BringToFront()
                Me.Controls.Add(box(d, s))
                box(d, s).BringToFront()
                For k As Integer = 0 To 5
                    If employees(k).sshift(d) = s Then
                        box(d, s).Text = (employees(k).fname & " " & employees(k).lname & vbNewLine & week(d).s(s).start & vbNewLine & week(d).s(s).Finish)
                    End If
                Next
                box(d, s).BackColor = Color.Green
            Next
        Next
        box(0, 0).Text = employees(0).sshift(0)
    End Sub
End Class