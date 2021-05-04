Public Class Form1
    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        Dim Num As Integer
        Num = txtInput.Text

        Select Case Num
            Case < 40
                MsgBox("Your gred is F", MsgBoxStyle.OkOnly, "Your gred")
            Case 40 To 49
                MsgBox("Your gred is E", MsgBoxStyle.OkOnly, "Your gred")
            Case 50 To 59
                MsgBox("Your gred is C", MsgBoxStyle.OkOnly, "Your gred")
            Case 60 To 69
                MsgBox("Your gred is B", MsgBoxStyle.OkOnly, "Your gred")
            Case 70 To 100
                MsgBox("Your gred is A", MsgBoxStyle.OkOnly, "Your gred")
        End Select
    End Sub

    Private Sub btnOkay2_Click(sender As Object, e As EventArgs) Handles btnOkay2.Click
        Dim A As Integer = 0
        Dim val As Integer
        val = txtInput2.Text

        Do While val <= A
            val = val + 1
        Loop
    End Sub
End Class
