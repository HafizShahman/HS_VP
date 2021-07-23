Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim MyString As String = "Kuala Terengganu"
        Label1.Text = UCase(MyString)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim StrName As String = ”KT Drawbridge”
        Label2.Text = StrName.Remove(0, 3)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim MyString As String = "Politeknik PSMZA"
        Dim substring As String = MyString.Substring(11, 5)
        Label3.Text = substring

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim myStr As String = "Sultan Fateh"
        Label4.Text = myStr.Insert(7, "Al-")
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim strText1 As String = "Please take the cool bag!"
        Label5.Text = Replace(strText1, "cool", "wool")

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim str As String
        Dim pad As Char
        str = "forty-two"
        pad = "."c
        Label6.Text = str.PadLeft(15, pad).ToString

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim str As String
        Dim pad As Char
        str = "forty-two"
        pad = "."c
        Label7.Text = str.PadRight(15, pad).ToString

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String
        str = "VB.NET TOP 10 BOOKS"
        If str.Contains("TOP") = True Then
            MsgBox("The string Contains() 'TOP' ")
        Else
            MsgBox("The String does not Contains() 'TOP'")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim A, B As Integer
        B = 0
        For A = 9 To 2 Step -1
            If A Mod 2 = 0 Then
                B = B + A
            End If
        Next

        MessageBox.Show(B)

    End Sub


End Class
