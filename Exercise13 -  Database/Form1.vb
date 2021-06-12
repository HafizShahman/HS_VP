Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomerDataSet1.Customer' table. You can move, or remove it, as needed.
        Me.CustlistTableAdapter.Fill(Me.CustomerDataSet2.Custlist)
        DataGridView2.Hide()

    End Sub


    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        Form2.ShowDialog()
    End Sub

    Private Sub load_btn_Click(sender As Object, e As EventArgs) Handles load_btn.Click
        Me.CustlistTableAdapter.Fill(Me.CustomerDataSet2.Custlist)
        DataGridView2.Show()
    End Sub

End Class
