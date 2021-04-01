Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim quote1, quote2, quote As String

        quote1 = "The ballgame isn't over, "
        quote2 = "until it's over."
        quote = quote1 & quote2
        lblOutput.Text = quote & " Yogi Berra"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MsgResult
        Dim str1, str2, str As String

        str1 = "Welcome"
        str2 = " PMS."
        str = str1 & str2

        MsgResult = MessageBox.Show(str)
    End Sub

    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        Dim n1, n2, n3 As Integer

        n1 = txtPrice.Text
        n2 = txtCost.Text
        n3 = txtUnit.Text
        txtProfit.Text = (n1 - n2) * n3
    End Sub

    Private Sub btnCal2_Click(sender As Object, e As EventArgs) Handles btnCal2.Click
        Dim n4, n5 As Integer

        n4 = txtDis.Text
        n5 = txtTime.Text
        txtSpeed.Text = (n4 / n5)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim n6 As Integer

        n6 = txtFahr.Text
        txtCel.Text = (5 / 5) * (n6 - 32)

    End Sub

    Private Sub btnCalParcel_Click(sender As Object, e As EventArgs) Handles btnCalParcel.Click
        Dim n7, n8, n9 As Integer

        n7 = txtDist.Text
        n8 = txtCos.Text
        n9 = txtWeight.Text
        txtCDel.Text = n7 * n8 + n9
    End Sub

End Class
