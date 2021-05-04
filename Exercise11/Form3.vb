Public Class Form3
    Private Sub GetMarks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetMarks.Click
        txtTotal.Text = CalcAverage(txtExam1.Text, txtExam2.Text, txtExam3.Text)
    End Sub

    Function CalcAverage(ByVal Num1 As Integer, ByVal Num2 As Integer, ByVal Num3 As Integer) As Integer
        Dim Total As Double
        Dim DisplayAverage As Double

        Total = Num1 + Num2 + Num3
        DisplayAverage = Total / 3

        CalcAverage = DisplayAverage

    End Function
End Class