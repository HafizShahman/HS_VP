Public Class Form2
    Public position As Integer = 0
    Public LastRow As Integer = 0

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomerDataSet11.Custlist' table. You can move, or remove it, as needed.
        Me.CustlistTableAdapter1.Fill(Me.CustomerDataSet11.Custlist)
        'TODO: This line of code loads data into the 'CustomerDataSet.customer' table. You can move, or remove it, as needed.
        Me.CustlistTableAdapter1.Fill(Me.CustomerDataSet11.Custlist)
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        Me.CustomerDataSet11.Custlist.Rows(position)("Name") = txtCustName.Text
        Me.CustomerDataSet11.Custlist.Rows(position)("PhoneNum") = txtPhoneNo.Text
        Me.CustomerDataSet11.Custlist.Rows(position)("State") = txtState.Text
        Me.CustomerDataSet11.Custlist.Rows(position)("Income") = txtIncome.Text
        Me.CustlistTableAdapter1.Update(Me.CustomerDataSet11.Custlist)
        MessageBox.Show("Data Updated")
        Form2.ActiveForm.Close()

    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Me.CustomerDataSet11.Custlist.Rows(position).Delete()
        Me.CustlistTableAdapter1.Update(Me.CustomerDataSet11.Custlist)
        MessageBox.Show("you have delete")
        Form2.ActiveForm.Close()

    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Me.CustlistTableAdapter1.Insert(CustName:=txtCustName.Text, PhoneNum:=txtPhoneNo.Text, State:=txtState.Text, Income:=txtIncome.Text)
        Form2.ActiveForm.Close()
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        position = 0
        txtCustName.Text = Me.CustomerDataSet11.Custlist.Rows(position)("CustName").ToString()
        txtPhoneNo.Text = Me.CustomerDataSet11.Custlist.Rows(position)("PhoneNum").ToString()
        txtState.Text = Me.CustomerDataSet11.Custlist.Rows(position)("State").ToString()
        txtIncome.Text = Me.CustomerDataSet11.Custlist.Rows(position)("Income").ToString()
        MessageBox.Show("this is the first data")
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        position = position - 1
        If position < 0 Then
            MessageBox.Show("This is the first data")
        Else
            txtCustName.Text = Me.CustomerDataSet11.Custlist.Rows(position)("CustName").ToString()
            txtPhoneNo.Text = Me.CustomerDataSet11.Custlist.Rows(position)("PhoneNum").ToString()
            txtState.Text = Me.CustomerDataSet11.Custlist.Rows(position)("State").ToString()
            txtIncome.Text = Me.CustomerDataSet11.Custlist.Rows(position)("Income").ToString()
        End If

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        position = position + 1
        LastRow = Me.CustomerDataSet11.Custlist.Rows.Count - 1
        If position > LastRow Then
            MessageBox.Show("This is last data")
        Else
            txtCustName.Text = Me.CustomerDataSet11.Custlist.Rows(position)("CustName").ToString()
            txtPhoneNo.Text = Me.CustomerDataSet11.Custlist.Rows(position)("PhoneNum").ToString()
            txtState.Text = Me.CustomerDataSet11.Custlist.Rows(position)("State").ToString()
            txtIncome.Text = Me.CustomerDataSet11.Custlist.Rows(position)("Income").ToString()
        End If

    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        LastRow = Me.CustomerDataSet11.Custlist.Rows.Count - 1
        position = LastRow
        txtCustName.Text = Me.CustomerDataSet11.Custlist.Rows(position)("CustName").ToString()
        txtPhoneNo.Text = Me.CustomerDataSet11.Custlist.Rows(position)("PhoneNum").ToString()
        txtState.Text = Me.CustomerDataSet11.Custlist.Rows(position)("State").ToString()
        txtIncome.Text = Me.CustomerDataSet11.Custlist.Rows(position)("Income").ToString()

    End Sub
End Class