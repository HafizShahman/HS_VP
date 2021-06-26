<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateBook
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BTNSSAVE = New System.Windows.Forms.Button()
        Me.BTNDELETE = New System.Windows.Forms.Button()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtGerne = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtBookID = New System.Windows.Forms.TextBox()
        Me.txtBookTitle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TblBookTableAdapter = New Project.LibraryDataSetTableAdapters.tblBookTableAdapter()
        Me.LibraryDataSet = New Project.LibraryDataSet()
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.BTNCANCEL = New System.Windows.Forms.Button()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNSSAVE
        '
        Me.BTNSSAVE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSSAVE.Location = New System.Drawing.Point(712, 123)
        Me.BTNSSAVE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNSSAVE.Name = "BTNSSAVE"
        Me.BTNSSAVE.Size = New System.Drawing.Size(98, 39)
        Me.BTNSSAVE.TabIndex = 39
        Me.BTNSSAVE.Text = "SAVE"
        Me.BTNSSAVE.UseVisualStyleBackColor = True
        '
        'BTNDELETE
        '
        Me.BTNDELETE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNDELETE.Location = New System.Drawing.Point(712, 188)
        Me.BTNDELETE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNDELETE.Name = "BTNDELETE"
        Me.BTNDELETE.Size = New System.Drawing.Size(98, 40)
        Me.BTNDELETE.TabIndex = 38
        Me.BTNDELETE.Text = "DELETE"
        Me.BTNDELETE.UseVisualStyleBackColor = True
        '
        'txtYear
        '
        Me.txtYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Location = New System.Drawing.Point(282, 279)
        Me.txtYear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(306, 30)
        Me.txtYear.TabIndex = 36
        '
        'txtGerne
        '
        Me.txtGerne.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGerne.Location = New System.Drawing.Point(282, 236)
        Me.txtGerne.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGerne.Name = "txtGerne"
        Me.txtGerne.Size = New System.Drawing.Size(306, 30)
        Me.txtGerne.TabIndex = 35
        '
        'txtAuthor
        '
        Me.txtAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.Location = New System.Drawing.Point(282, 190)
        Me.txtAuthor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(306, 30)
        Me.txtAuthor.TabIndex = 34
        '
        'txtBookID
        '
        Me.txtBookID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookID.Location = New System.Drawing.Point(282, 97)
        Me.txtBookID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.Size = New System.Drawing.Size(306, 30)
        Me.txtBookID.TabIndex = 32
        '
        'txtBookTitle
        '
        Me.txtBookTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookTitle.Location = New System.Drawing.Point(282, 142)
        Me.txtBookTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBookTitle.Name = "txtBookTitle"
        Me.txtBookTitle.Size = New System.Drawing.Size(306, 30)
        Me.txtBookTitle.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(143, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 25)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Year :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(143, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 25)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Genre :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(143, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 25)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Author :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(143, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 25)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "BookTitle :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(143, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 25)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "BookID :"
        '
        'TblBookTableAdapter
        '
        Me.TblBookTableAdapter.ClearBeforeFill = True
        '
        'LibraryDataSet
        '
        Me.LibraryDataSet.DataSetName = "LibraryDataSet"
        Me.LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "tblBook"
        Me.BindingSource2.DataSource = Me.LibraryDataSet
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(529, 342)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(46, 45)
        Me.btnLast.TabIndex = 43
        Me.btnLast.Text = ">>"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(449, 342)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(46, 45)
        Me.btnNext.TabIndex = 42
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(369, 342)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(46, 45)
        Me.btnPrev.TabIndex = 41
        Me.btnPrev.Text = "<"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(291, 342)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(46, 45)
        Me.btnFirst.TabIndex = 40
        Me.btnFirst.Text = "<<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'BTNCANCEL
        '
        Me.BTNCANCEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCEL.Location = New System.Drawing.Point(712, 256)
        Me.BTNCANCEL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNCANCEL.Name = "BTNCANCEL"
        Me.BTNCANCEL.Size = New System.Drawing.Size(98, 40)
        Me.BTNCANCEL.TabIndex = 44
        Me.BTNCANCEL.Text = "CANCEL"
        Me.BTNCANCEL.UseVisualStyleBackColor = True
        '
        'UpdateBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(926, 427)
        Me.Controls.Add(Me.BTNCANCEL)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.BTNSSAVE)
        Me.Controls.Add(Me.BTNDELETE)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtGerne)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.txtBookID)
        Me.Controls.Add(Me.txtBookTitle)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UpdateBook"
        Me.Text = "UpdateBook"
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNSSAVE As Button
    Friend WithEvents BTNDELETE As Button
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtGerne As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtBookID As TextBox
    Friend WithEvents txtBookTitle As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TblBookTableAdapter As LibraryDataSetTableAdapters.tblBookTableAdapter
    Friend WithEvents LibraryDataSet As LibraryDataSet
    Friend WithEvents BindingSource2 As BindingSource
    Friend WithEvents btnLast As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents BTNCANCEL As Button
End Class
