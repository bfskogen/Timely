Option Strict On
Imports System.IO
Public Class MainMenu
#Region "Functions"

    Private Function stringToMD5(ByRef Content As String) As String
        Dim MD5 As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim ByteString() As Byte = System.Text.Encoding.ASCII.GetBytes(Content)
        ByteString = MD5.ComputeHash(ByteString)
        Dim FinalString As String = Nothing

        For Each bt As Byte In ByteString
            FinalString &= bt.ToString("x2")
        Next

        Return FinalString.ToUpper()
    End Function

    Private Function createUser(ByVal user As String, ByVal password As String) As String
        'check to see if the hash value of the user exists
        If File.Exists(stringToMD5(user) & ".txt") = True Then
            Try
                'write MD5 hash value of user and password to file
                My.Computer.FileSystem.WriteAllText(stringToMD5(user) & ".txt", stringToMD5(user) & Chr(32) & stringToMD5(password), False)

                File.SetAttributes(stringToMD5(user) & ".txt", FileAttributes.Hidden)

                ' if it works then log them in
                MsgBox("New user created")
            Catch ex As Exception
                MsgBox("Something went wrong" & ex.Message)
            End Try

        Else
            MsgBox("username has already been taken")
        End If

        Return user
        Return password
    End Function
#End Region
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim empview As New EmployeeView(0)
        empview.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class
