Public Class Form1
    Dim SecretNumber As Integer
    Dim Attempts As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyNumber As Integer
        Dim Tmp As String
        Tmp = InputBox("Enter a number between 1 and 100", "Guessing game")
        If IsNumeric(Tmp) Then
            MyNumber = Tmp
        Else
            MsgBox("you should enter a number")
            Exit Sub
        End If
        If MyNumber = SecretNumber Then
            MsgBox("You Guessed the correct number", MsgBoxStyle.OkOnly)
            Button1.Enabled = False
        ElseIf MyNumber > SecretNumber Then
            ListBox1.Items.Add("you should enter a lower number")
            MsgBox("your guess is wrong")
        Else
            ListBox1.Items.Add("you should enter a higher number")
            MsgBox("your guess is wrong")
        End If
        Attempts = Attempts + 1
        Label1.Text = "Attempts:" & Attempts.ToString
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Randomize()
        Button1.Enabled = True
        SecretNumber = Int(Rnd() * 100)
        Attempts = 0
        ListBox1.Items.Clear()
        Label1.Text = "Attempts:" & Attempts.ToString
    End Sub
End Class
