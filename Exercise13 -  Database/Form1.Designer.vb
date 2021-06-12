<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.load_btn = New System.Windows.Forms.Button()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.CustomerDataSet2 = New Exercise13____Database.CustomerDataSet2()
        Me.CustlistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustlistTableAdapter = New Exercise13____Database.CustomerDataSet2TableAdapters.CustlistTableAdapter()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustlistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'load_btn
        '
        Me.load_btn.Location = New System.Drawing.Point(331, 282)
        Me.load_btn.Name = "load_btn"
        Me.load_btn.Size = New System.Drawing.Size(151, 44)
        Me.load_btn.TabIndex = 1
        Me.load_btn.Text = "Load Data"
        Me.load_btn.UseVisualStyleBackColor = True
        '
        'add_btn
        '
        Me.add_btn.Location = New System.Drawing.Point(522, 282)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(151, 44)
        Me.add_btn.TabIndex = 2
        Me.add_btn.Text = "Add Data"
        Me.add_btn.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.PhoneNumDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.IncomeDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.CustlistBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(55, 64)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(645, 180)
        Me.DataGridView2.TabIndex = 3
        '
        'CustomerDataSet2
        '
        Me.CustomerDataSet2.DataSetName = "CustomerDataSet2"
        Me.CustomerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustlistBindingSource
        '
        Me.CustlistBindingSource.DataMember = "Custlist"
        Me.CustlistBindingSource.DataSource = Me.CustomerDataSet2
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 379)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.add_btn)
        Me.Controls.Add(Me.load_btn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustlistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents load_btn As Button
    Friend WithEvents add_btn As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents CustomerDataSet2 As CustomerDataSet2
    Friend WithEvents CustlistBindingSource As BindingSource
    Friend WithEvents CustlistTableAdapter As CustomerDataSet2TableAdapters.CustlistTableAdapter
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IncomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
