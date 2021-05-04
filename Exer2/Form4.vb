Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myArray(3) As Integer
        Dim i As Integer = 0

        myArray(0) = 1
        myArray(1) = 2
        myArray(2) = 3
        myArray(3) = 4

        For i = 0 To 3
            ListBox1.Items.Add(myArray(i))
        Next i

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myArray(3) As Integer
        Dim i As Integer = 0

        myArray(0) = 1
        myArray(1) = 2
        myArray(2) = 3
        myArray(3) = 4

        ReDim myArray(5)

        myArray(4) = 5
        myArray(5) = 6

        For i = 0 To 5
            ListBox2.Items.Add(myArray(i))
        Next i
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim myArray(3) As Integer
        Dim i As Integer = 0

        myArray(0) = 1
        myArray(1) = 2
        myArray(2) = 3
        myArray(3) = 4

        ReDim Preserve myArray(5)

        myArray(4) = 5
        myArray(5) = 6

        For i = 0 To 5
            ListBox3.Items.Add(myArray(i))
        Next i
    End Sub
End Class