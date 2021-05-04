Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myArray(4) As Integer


        myArray(0) = 0
        myArray(1) = 1
        myArray(2) = 2
        myArray(3) = 3
        myArray(4) = 4

        For i = 0 To 4
            ListBox1.Items.Add(myArray(i))
        Next i
    End Sub
End Class