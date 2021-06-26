
Public Class UpdateBook
    Public position As Integer = 0
    Public LastRow As Integer = 0
    Private Sub UpdateBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TblBookTableAdapter.Fill(Me.LibraryDataSet.tblBook)
    End Sub
    Private Sub BTNSSAVE_Click(sender As Object, e As EventArgs) Handles BTNSSAVE.Click

        Me.LibraryDataSet.tblBook.Rows(position)("BookID") = txtBookID.Text
        Me.LibraryDataSet.tblBook.Rows(position)("BookTitle") = txtBookTitle.Text
        Me.LibraryDataSet.tblBook.Rows(position)("Author") = txtAuthor.Text
        Me.LibraryDataSet.tblBook.Rows(position)("Genre") = txtGerne.Text
        Me.LibraryDataSet.tblBook.Rows(position)("Year") = txtYear.Text
        Me.TblBookTableAdapter.Update(Me.LibraryDataSet.tblBook)
        MessageBox.Show("Data Updated")
        Me.Dispose()
        BookList.ShowDialog()

    End Sub

    Private Sub BTNDELETE_Click(sender As Object, e As EventArgs) Handles BTNDELETE.Click
        Me.LibraryDataSet.tblBook.Rows(position).Delete()
        Me.TblBookTableAdapter.Update(Me.LibraryDataSet.tblBook)
        MessageBox.Show("You have delete")
        Me.Dispose()
        BookList.ShowDialog()
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        position = 0
        txtBookID.Text = Me.LibraryDataSet.tblBook.Rows(position)("BookID").ToString()
        txtBookTitle.Text = Me.LibraryDataSet.tblBook.Rows(position)("BookTitle").ToString()
        txtAuthor.Text = Me.LibraryDataSet.tblBook.Rows(position)("Author").ToString()
        txtGerne.Text = Me.LibraryDataSet.tblBook.Rows(position)("Genre").ToString()
        txtYear.Text = Me.LibraryDataSet.tblBook.Rows(position)("Year").ToString()
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        position = position - 1
        If position = 0 Then
            MessageBox.Show("This is the first data")
        Else
            txtBookID.Text = Me.LibraryDataSet.tblBook.Rows(position)("BookID").ToString()
            txtBookTitle.Text = Me.LibraryDataSet.tblBook.Rows(position)("BookTitle").ToString()
            txtAuthor.Text = Me.LibraryDataSet.tblBook.Rows(position)("Author").ToString()
            txtGerne.Text = Me.LibraryDataSet.tblBook.Rows(position)("Genre").ToString()
            txtYear.Text = Me.LibraryDataSet.tblBook.Rows(position)("Year").ToString()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        position = position + 1
        LastRow = Me.LibraryDataSet.tblBook.Rows.Count - 1

        If position > LastRow Then
            MessageBox.Show("This is the last data")
        Else
            txtBookID.Text = Me.LibraryDataSet.tblBook.Rows(position)("BookID").ToString()
            txtBookTitle.Text = Me.LibraryDataSet.tblBook.Rows(position)("BookTitle").ToString()
            txtAuthor.Text = Me.LibraryDataSet.tblBook.Rows(position)("Author").ToString()
            txtGerne.Text = Me.LibraryDataSet.tblBook.Rows(position)("Genre").ToString()
            txtYear.Text = Me.LibraryDataSet.tblBook.Rows(position)("Year").ToString()
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        LastRow = Me.LibraryDataSet.tblBook.Rows.Count - 1
        position = LastRow
        txtBookID.Text = Me.LibraryDataSet.tblBook.Rows(position)("BookID").ToString()
        txtBookTitle.Text = Me.LibraryDataSet.tblBook.Rows(position)("BookTitle").ToString()
        txtAuthor.Text = Me.LibraryDataSet.tblBook.Rows(position)("Author").ToString()
        txtGerne.Text = Me.LibraryDataSet.tblBook.Rows(position)("Genre").ToString()
        txtYear.Text = Me.LibraryDataSet.tblBook.Rows(position)("Year").ToString()
    End Sub

    Private Sub BTNCANCEL_Click(sender As Object, e As EventArgs) Handles BTNCANCEL.Click
        Me.Dispose()
        BookList.ShowDialog()
    End Sub


End Class