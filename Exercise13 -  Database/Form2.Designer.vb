<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.custName = New System.Windows.Forms.Label()
        Me.phoneNo = New System.Windows.Forms.Label()
        Me.state = New System.Windows.Forms.Label()
        Me.income = New System.Windows.Forms.Label()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.txtPhoneNo = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtIncome = New System.Windows.Forms.TextBox()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.CustomerDataSet11 = New Exercise13____Database.CustomerDataSet1()
        Me.CustlistTableAdapter1 = New Exercise13____Database.CustomerDataSet1TableAdapters.CustlistTableAdapter()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.CustomerDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'custName
        '
        Me.custName.AutoSize = True
        Me.custName.Location = New System.Drawing.Point(91, 70)
        Me.custName.Name = "custName"
        Me.custName.Size = New System.Drawing.Size(109, 17)
        Me.custName.TabIndex = 0
        Me.custName.Text = "Customer Name"
        '
        'phoneNo
        '
        Me.phoneNo.AutoSize = True
        Me.phoneNo.Location = New System.Drawing.Point(91, 127)
        Me.phoneNo.Name = "phoneNo"
        Me.phoneNo.Size = New System.Drawing.Size(71, 17)
        Me.phoneNo.TabIndex = 1
        Me.phoneNo.Text = "Phone No"
        '
        'state
        '
        Me.state.AutoSize = True
        Me.state.Location = New System.Drawing.Point(91, 187)
        Me.state.Name = "state"
        Me.state.Size = New System.Drawing.Size(41, 17)
        Me.state.TabIndex = 2
        Me.state.Text = "State"
        '
        'income
        '
        Me.income.AutoSize = True
        Me.income.Location = New System.Drawing.Point(91, 247)
        Me.income.Name = "income"
        Me.income.Size = New System.Drawing.Size(53, 17)
        Me.income.TabIndex = 3
        Me.income.Text = "Income"
        '
        'saveBtn
        '
        Me.saveBtn.Location = New System.Drawing.Point(585, 184)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(186, 42)
        Me.saveBtn.TabIndex = 4
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'txtCustName
        '
        Me.txtCustName.Location = New System.Drawing.Point(289, 67)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(238, 22)
        Me.txtCustName.TabIndex = 5
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.Location = New System.Drawing.Point(289, 124)
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(238, 22)
        Me.txtPhoneNo.TabIndex = 6
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(289, 184)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(238, 22)
        Me.txtState.TabIndex = 7
        '
        'txtIncome
        '
        Me.txtIncome.Location = New System.Drawing.Point(289, 244)
        Me.txtIncome.Name = "txtIncome"
        Me.txtIncome.Size = New System.Drawing.Size(238, 22)
        Me.txtIncome.TabIndex = 8
        '
        'updateBtn
        '
        Me.updateBtn.Location = New System.Drawing.Point(585, 114)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(186, 42)
        Me.updateBtn.TabIndex = 9
        Me.updateBtn.Text = "Update"
        Me.updateBtn.UseVisualStyleBackColor = True
        '
        'deleteBtn
        '
        Me.deleteBtn.Location = New System.Drawing.Point(585, 256)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(186, 42)
        Me.deleteBtn.TabIndex = 10
        Me.deleteBtn.Text = "Delete"
        Me.deleteBtn.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(210, 346)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(46, 45)
        Me.btnFirst.TabIndex = 11
        Me.btnFirst.Text = "<<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(288, 346)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(46, 45)
        Me.btnPrev.TabIndex = 12
        Me.btnPrev.Text = "<"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(368, 346)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(46, 45)
        Me.btnNext.TabIndex = 13
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(448, 346)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(46, 45)
        Me.btnLast.TabIndex = 14
        Me.btnLast.Text = ">>"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'CustomerDataSet11
        '
        Me.CustomerDataSet11.DataSetName = "CustomerDataSet1"
        Me.CustomerDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustlistTableAdapter1
        '
        Me.CustlistTableAdapter1.ClearBeforeFill = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Custlist"
        Me.BindingSource1.DataSource = Me.CustomerDataSet11
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.updateBtn)
        Me.Controls.Add(Me.txtIncome)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtPhoneNo)
        Me.Controls.Add(Me.txtCustName)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.income)
        Me.Controls.Add(Me.state)
        Me.Controls.Add(Me.phoneNo)
        Me.Controls.Add(Me.custName)
        Me.Name = "Form2"
        Me.Text = ">"
        CType(Me.CustomerDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents custName As Label
    Friend WithEvents phoneNo As Label
    Friend WithEvents state As Label
    Friend WithEvents income As Label
    Friend WithEvents saveBtn As Button
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents txtPhoneNo As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtIncome As TextBox
    Friend WithEvents updateBtn As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents CustomerDataSet11 As CustomerDataSet1
    Friend WithEvents CustlistTableAdapter1 As CustomerDataSet1TableAdapters.CustlistTableAdapter
    Friend WithEvents BindingSource1 As BindingSource
End Class
