Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomerDataSet.Custlist' table. You can move, or remove it, as needed.
        Me.CustlistTableAdapter.Fill(Me.CustomerDataSet.Custlist)
        DataGridView1.Hide()

    End Sub

    Private Sub loadbtn_Click(sender As Object, e As EventArgs) Handles loadbtn.Click
        Me.CustlistTableAdapter.Fill(Me.CustomerDataSet.Custlist)
        DataGridView1.Show()
    End Sub

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        Form2.ShowDialog()
    End Sub
End Class
