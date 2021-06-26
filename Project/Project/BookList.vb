Public Class BookList


    Private Sub BookList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet.tblBook' table. You can move, or remove it, as needed.
        Me.TblBookTableAdapter.Fill(Me.LibraryDataSet.tblBook)
        DataGridView1.Hide()

    End Sub

    Private Sub BTNREFRESH_Click(sender As Object, e As EventArgs) Handles BTNREFRESH.Click
        Me.TblBookTableAdapter.Fill(Me.LibraryDataSet.tblBook)
        DataGridView1.Refresh()
        DataGridView1.Show()
    End Sub

    Private Sub BTNADD_Click(sender As Object, e As EventArgs) Handles BTNADD.Click
        Me.Dispose()
        NewBook.ShowDialog()
    End Sub

    Private Sub searchData(sql As String, dtg As DataGridView)
        Try
            Conn.Open()

            With cmd
                .Connection = Conn
                .CommandText = sql
            End With
            With da
                .SelectCommand = cmd
                .Fill(dt)
            End With
            dtg.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Close()
            da.Dispose()
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Sql = "SELECT * FROM tblBook WHERE BookTitle LIKE '%" & txtSearch.Text & "%' OR Author LIKE '%" & txtSearch.Text & "%'"
        DataGridView1.Refresh()
        searchData(Sql, DataGridView1)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Me.Dispose()
        UpdateBook.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub
End Class