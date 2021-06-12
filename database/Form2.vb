Public Class Form2
    Public position As Integer = 0
    Public LastRow As Integer = 0

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomerDataSet.Custlist' table. You can move, or remove it, as needed.
        Me.CustlistTableAdapter.Fill(Me.CustomerDataSet.Custlist)

    End Sub

    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        Me.CustomerDataSet.Custlist.Rows(position)("Name") = txtCustName.Text
        Me.CustomerDataSet.Custlist.Rows(position)("PhoneNum") = MaskedTxtPhoneNum.Text
        Me.CustomerDataSet.Custlist.Rows(position)("State") = txtState.Text
        Me.CustomerDataSet.Custlist.Rows(position)("Income") = txtIncome.Text
        Me.CustlistTableAdapter.Update(Me.CustomerDataSet.Custlist)
        MessageBox.Show("Data Updated")
        Form2.ActiveForm.Close()
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        Me.CustlistTableAdapter.Insert(Name:=txtCustName.Text, PhoneNum:=MaskedTxtPhoneNum.Text, State:=txtState.Text, Income:=txtIncome.Text)
        Form2.ActiveForm.Close()
    End Sub

    Private Sub newbtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click, newbtn.Click
        txtCustName.Text = " "
        MaskedTxtPhoneNum.Text = " "
        txtState.Text = " "
        txtIncome.Text = " "
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click, newbtn.Click
        Me.CustomerDataSet.Custlist.Rows(position).Delete()
        Me.CustlistTableAdapter.Update(Me.CustomerDataSet.Custlist)
        MessageBox.Show("you have delete")
        Form2.ActiveForm.Close()
    End Sub
    Private Sub firstbtn_Click(sender As Object, e As EventArgs) Handles firstbtn.Click
        position = 0
        txtCustName.Text = Me.CustomerDataSet.Custlist.Rows(position)("Name").ToString()
        MaskedTxtPhoneNum.Text = Me.CustomerDataSet.Custlist.Rows(position)("PhoneNum").ToString()
        txtState.Text = Me.CustomerDataSet.Custlist.Rows(position)("State").ToString()
        txtIncome.Text = Me.CustomerDataSet.Custlist.Rows(position)("Income").ToString()
        MessageBox.Show("this is the first data")
    End Sub

    Private Sub prevbtn_Click(sender As Object, e As EventArgs) Handles prevbtn.Click
        position = position - 1
        If position < 0 Then
            MessageBox.Show("This is the first data")
        Else
            txtCustName.Text = Me.CustomerDataSet.Custlist.Rows(position)("Name").ToString()
            MaskedTxtPhoneNum.Text = Me.CustomerDataSet.Custlist.Rows(position)("PhoneNum").ToString()
            txtState.Text = Me.CustomerDataSet.Custlist.Rows(position)("State").ToString()
            txtIncome.Text = Me.CustomerDataSet.Custlist.Rows(position)("Income").ToString()
        End If
    End Sub

    Private Sub nextbtn_Click(sender As Object, e As EventArgs) Handles nextbtn.Click
        position = position + 1
        LastRow = Me.CustomerDataSet.Custlist.Rows.Count - 1
        If position > LastRow Then
            MessageBox.Show("This is last data")
        Else
            txtCustName.Text = Me.CustomerDataSet.Custlist.Rows(position)("Name").ToString()
            MaskedTxtPhoneNum.Text = Me.CustomerDataSet.Custlist.Rows(position)("PhoneNum").ToString()
            txtState.Text = Me.CustomerDataSet.Custlist.Rows(position)("State").ToString()
            txtIncome.Text = Me.CustomerDataSet.Custlist.Rows(position)("Income").ToString()
        End If
    End Sub

    Private Sub lastbtn_Click(sender As Object, e As EventArgs) Handles lastbtn.Click
        LastRow = Me.CustomerDataSet.Custlist.Rows.Count - 1
        position = LastRow
        txtCustName.Text = Me.CustomerDataSet.Custlist.Rows(position)("Name").ToString()
        MaskedTxtPhoneNum.Text = Me.CustomerDataSet.Custlist.Rows(position)("PhoneNum").ToString()
        txtState.Text = Me.CustomerDataSet.Custlist.Rows(position)("State").ToString()
        txtIncome.Text = Me.CustomerDataSet.Custlist.Rows(position)("Income").ToString()
    End Sub
End Class