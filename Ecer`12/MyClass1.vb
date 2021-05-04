Public Class MyClass1
    Public Function BMI(ByVal height As Single, ByVal weight As Single)
        BMI = Format((weight) / (height ^ 2), "0.00")
    End Function
End Class
