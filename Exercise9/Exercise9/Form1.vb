Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim l, A As Double

        l = TextBox1.Text
        A = l * 4

        TextBox2.Text = A

        ListBox1.Items.Add("The area of the square is : " & A)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim w, h, A As Double

        w = TextBox3.Text
        h = TextBox4.Text
        A = w * h

        TextBox5.Text = A

        ListBox1.Items.Add("The area of the rectangle is : " & A)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim b, h, A As Double

        b = TextBox6.Text
        h = TextBox7.Text
        A = 0.5 * b * h

        TextBox8.Text = A

        ListBox1.Items.Add("The area of the triangle is : " & A)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        ListBox1.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class
