<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewBook
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
        Me.BTNCANCEL = New System.Windows.Forms.Button()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtGerne = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtBookTitle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBookID = New System.Windows.Forms.TextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryDataSet = New Project.LibraryDataSet()
        Me.TblBookTableAdapter = New Project.LibraryDataSetTableAdapters.tblBookTableAdapter()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNSSAVE
        '
        Me.BTNSSAVE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSSAVE.Location = New System.Drawing.Point(701, 174)
        Me.BTNSSAVE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNSSAVE.Name = "BTNSSAVE"
        Me.BTNSSAVE.Size = New System.Drawing.Size(98, 39)
        Me.BTNSSAVE.TabIndex = 26
        Me.BTNSSAVE.Text = "SAVE"
        Me.BTNSSAVE.UseVisualStyleBackColor = True
        '
        'BTNCANCEL
        '
        Me.BTNCANCEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCEL.Location = New System.Drawing.Point(701, 239)
        Me.BTNCANCEL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNCANCEL.Name = "BTNCANCEL"
        Me.BTNCANCEL.Size = New System.Drawing.Size(98, 40)
        Me.BTNCANCEL.TabIndex = 25
        Me.BTNCANCEL.Text = "CANCEL"
        Me.BTNCANCEL.UseVisualStyleBackColor = True
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(274, 282)
        Me.txtYear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(306, 22)
        Me.txtYear.TabIndex = 22
        '
        'txtGerne
        '
        Me.txtGerne.Location = New System.Drawing.Point(274, 239)
        Me.txtGerne.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGerne.Name = "txtGerne"
        Me.txtGerne.Size = New System.Drawing.Size(306, 22)
        Me.txtGerne.TabIndex = 21
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(274, 193)
        Me.txtAuthor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(306, 22)
        Me.txtAuthor.TabIndex = 20
        '
        'txtBookTitle
        '
        Me.txtBookTitle.Location = New System.Drawing.Point(274, 145)
        Me.txtBookTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBookTitle.Name = "txtBookTitle"
        Me.txtBookTitle.Size = New System.Drawing.Size(306, 22)
        Me.txtBookTitle.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(135, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Year :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(135, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Genre :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(135, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Author :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "BookTitle :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(135, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "BookID :"
        '
        'txtBookID
        '
        Me.txtBookID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "BookID", True))
        Me.txtBookID.Location = New System.Drawing.Point(274, 100)
        Me.txtBookID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.Size = New System.Drawing.Size(306, 22)
        Me.txtBookID.TabIndex = 19
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "tblBook"
        Me.BindingSource1.DataSource = Me.LibraryDataSet
        '
        'LibraryDataSet
        '
        Me.LibraryDataSet.DataSetName = "LibraryDataSet"
        Me.LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblBookTableAdapter
        '
        Me.TblBookTableAdapter.ClearBeforeFill = True
        '
        'NewBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(925, 427)
        Me.Controls.Add(Me.BTNSSAVE)
        Me.Controls.Add(Me.BTNCANCEL)
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
        Me.Name = "NewBook"
        Me.Text = "NewBook"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNSSAVE As Button
    Friend WithEvents BTNCANCEL As Button
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtGerne As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtBookTitle As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBookID As TextBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents LibraryDataSet As LibraryDataSet
    Friend WithEvents TblBookTableAdapter As LibraryDataSetTableAdapters.tblBookTableAdapter
End Class
