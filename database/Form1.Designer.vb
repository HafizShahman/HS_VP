<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CustomerDataSet = New database.CustomerDataSet()
        Me.CustlistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustlistTableAdapter = New database.CustomerDataSetTableAdapters.CustlistTableAdapter()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.loadbtn = New System.Windows.Forms.Button()
        Me.addbtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustlistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.PhoneNumDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.IncomeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustlistBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(135, 81)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(565, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'CustomerDataSet
        '
        Me.CustomerDataSet.DataSetName = "CustomerDataSet"
        Me.CustomerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustlistBindingSource
        '
        Me.CustlistBindingSource.DataMember = "Custlist"
        Me.CustlistBindingSource.DataSource = Me.CustomerDataSet
        '
        'CustlistTableAdapter
        '
        Me.CustlistTableAdapter.ClearBeforeFill = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.Width = 125
        '
        'PhoneNumDataGridViewTextBoxColumn
        '
        Me.PhoneNumDataGridViewTextBoxColumn.DataPropertyName = "PhoneNum"
        Me.PhoneNumDataGridViewTextBoxColumn.HeaderText = "PhoneNum"
        Me.PhoneNumDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PhoneNumDataGridViewTextBoxColumn.Name = "PhoneNumDataGridViewTextBoxColumn"
        Me.PhoneNumDataGridViewTextBoxColumn.Width = 125
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        Me.StateDataGridViewTextBoxColumn.Width = 125
        '
        'IncomeDataGridViewTextBoxColumn
        '
        Me.IncomeDataGridViewTextBoxColumn.DataPropertyName = "Income"
        Me.IncomeDataGridViewTextBoxColumn.HeaderText = "Income"
        Me.IncomeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IncomeDataGridViewTextBoxColumn.Name = "IncomeDataGridViewTextBoxColumn"
        Me.IncomeDataGridViewTextBoxColumn.Width = 125
        '
        'loadbtn
        '
        Me.loadbtn.Location = New System.Drawing.Point(135, 367)
        Me.loadbtn.Name = "loadbtn"
        Me.loadbtn.Size = New System.Drawing.Size(133, 47)
        Me.loadbtn.TabIndex = 1
        Me.loadbtn.Text = "LOAD"
        Me.loadbtn.UseVisualStyleBackColor = True
        '
        'addbtn
        '
        Me.addbtn.Location = New System.Drawing.Point(567, 367)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(133, 47)
        Me.addbtn.TabIndex = 2
        Me.addbtn.Text = "ADD"
        Me.addbtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 503)
        Me.Controls.Add(Me.addbtn)
        Me.Controls.Add(Me.loadbtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustlistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CustomerDataSet As CustomerDataSet
    Friend WithEvents CustlistBindingSource As BindingSource
    Friend WithEvents CustlistTableAdapter As CustomerDataSetTableAdapters.CustlistTableAdapter
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IncomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents loadbtn As Button
    Friend WithEvents addbtn As Button
End Class
