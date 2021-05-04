Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox3.Text = AddTwoNum(TextBox1.Text, TextBox2.Text)
    End Sub

    Function AddTwoNum(ByVal Num1 As Integer, ByVal Num2 As Integer) As Integer
        Dim Total As Integer

        Total = Num1 + Num2

        AddTwoNum = Total

    End Function

End Class