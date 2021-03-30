Public Class Form1
    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click

        Dim n1, n2 As Integer

        n1 = Num1.Text
        n2 = Num2.Text
        txtAns.Text = n1 + n2



    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        Dim n1, n2 As Integer

        n1 = Num1.Text
        n2 = Num2.Text
        txtAns.Text = n1 - n2


    End Sub

    Private Sub btnMul_Click(sender As Object, e As EventArgs) Handles btnMul.Click
        Dim n1, n2 As Integer

        n1 = Num1.Text
        n2 = Num2.Text
        txtAns.Text = n1 * n2

    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        Dim n1, n2 As Integer

        n1 = Num1.Text
        n2 = Num2.Text
        txtAns.Text = n1 / n2

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Num1.Text = ""
        Num2.Text = ""
        txtAns.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
