Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer = 0
        Dim val As Integer
        val = TextBox1.Text

        Do
            ListBox1.Items.Add("Hello World")
            i = i + 1
        Loop Until i >= val
    End Sub
End Class