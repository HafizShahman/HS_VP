Public Class Form1
    Private Sub BtinBMI_Click(sender As Object, e As EventArgs) Handles BtinBMI.Click
        Dim MyObject As Object
        Dim h, w As Single
        MyObject = New MyClass1()
        h = InputBox("What is your height in meter")
        w = InputBox("What is your weight in kg")
        MessageBox.Show(MyObject.BMI(h, w))
    End Sub

End Class
