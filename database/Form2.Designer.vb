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
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtIncome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.firstbtn = New System.Windows.Forms.Button()
        Me.prevbtn = New System.Windows.Forms.Button()
        Me.nextbtn = New System.Windows.Forms.Button()
        Me.lastbtn = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerDataSet = New database.CustomerDataSet()
        Me.CustlistTableAdapter = New database.CustomerDataSetTableAdapters.CustlistTableAdapter()
        Me.newbtn = New System.Windows.Forms.Button()
        Me.MaskedTxtPhoneNum = New System.Windows.Forms.MaskedTextBox()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'updatebtn
        '
        Me.updatebtn.Location = New System.Drawing.Point(670, 69)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(75, 34)
        Me.updatebtn.TabIndex = 0
        Me.updatebtn.Text = "UPDATE"
        Me.updatebtn.UseVisualStyleBackColor = True
        '
        'savebtn
        '
        Me.savebtn.Location = New System.Drawing.Point(670, 153)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(75, 34)
        Me.savebtn.TabIndex = 1
        Me.savebtn.Text = "SAVE"
        Me.savebtn.UseVisualStyleBackColor = True
        '
        'deletebtn
        '
        Me.deletebtn.Location = New System.Drawing.Point(670, 233)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(75, 34)
        Me.deletebtn.TabIndex = 2
        Me.deletebtn.Text = "DELETE"
        Me.deletebtn.UseVisualStyleBackColor = True
        '
        'txtCustName
        '
        Me.txtCustName.Location = New System.Drawing.Point(196, 69)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(288, 22)
        Me.txtCustName.TabIndex = 3
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(196, 180)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(288, 22)
        Me.txtState.TabIndex = 3
        '
        'txtIncome
        '
        Me.txtIncome.Location = New System.Drawing.Point(196, 233)
        Me.txtIncome.Name = "txtIncome"
        Me.txtIncome.Size = New System.Drawing.Size(288, 22)
        Me.txtIncome.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Customer Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Phone Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "State"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Income"
        '
        'firstbtn
        '
        Me.firstbtn.Location = New System.Drawing.Point(196, 342)
        Me.firstbtn.Name = "firstbtn"
        Me.firstbtn.Size = New System.Drawing.Size(47, 37)
        Me.firstbtn.TabIndex = 5
        Me.firstbtn.Text = "<<"
        Me.firstbtn.UseVisualStyleBackColor = True
        '
        'prevbtn
        '
        Me.prevbtn.Location = New System.Drawing.Point(277, 342)
        Me.prevbtn.Name = "prevbtn"
        Me.prevbtn.Size = New System.Drawing.Size(47, 37)
        Me.prevbtn.TabIndex = 5
        Me.prevbtn.Text = "<"
        Me.prevbtn.UseVisualStyleBackColor = True
        '
        'nextbtn
        '
        Me.nextbtn.Location = New System.Drawing.Point(362, 342)
        Me.nextbtn.Name = "nextbtn"
        Me.nextbtn.Size = New System.Drawing.Size(47, 37)
        Me.nextbtn.TabIndex = 5
        Me.nextbtn.Text = ">"
        Me.nextbtn.UseVisualStyleBackColor = True
        '
        'lastbtn
        '
        Me.lastbtn.Location = New System.Drawing.Point(437, 342)
        Me.lastbtn.Name = "lastbtn"
        Me.lastbtn.Size = New System.Drawing.Size(47, 37)
        Me.lastbtn.TabIndex = 5
        Me.lastbtn.Text = ">>"
        Me.lastbtn.UseVisualStyleBackColor = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Custlist"
        Me.BindingSource1.DataSource = Me.CustomerDataSet
        '
        'CustomerDataSet
        '
        Me.CustomerDataSet.DataSetName = "CustomerDataSet"
        Me.CustomerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustlistTableAdapter
        '
        Me.CustlistTableAdapter.ClearBeforeFill = True
        '
        'newbtn
        '
        Me.newbtn.Location = New System.Drawing.Point(670, 298)
        Me.newbtn.Name = "newbtn"
        Me.newbtn.Size = New System.Drawing.Size(75, 34)
        Me.newbtn.TabIndex = 2
        Me.newbtn.Text = "NEW"
        Me.newbtn.UseVisualStyleBackColor = True
        '
        'MaskedTxtPhoneNum
        '
        Me.MaskedTxtPhoneNum.Location = New System.Drawing.Point(196, 125)
        Me.MaskedTxtPhoneNum.Mask = "+60 10-000 0000"
        Me.MaskedTxtPhoneNum.Name = "MaskedTxtPhoneNum"
        Me.MaskedTxtPhoneNum.Size = New System.Drawing.Size(288, 22)
        Me.MaskedTxtPhoneNum.TabIndex = 6
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MaskedTxtPhoneNum)
        Me.Controls.Add(Me.lastbtn)
        Me.Controls.Add(Me.nextbtn)
        Me.Controls.Add(Me.prevbtn)
        Me.Controls.Add(Me.firstbtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIncome)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCustName)
        Me.Controls.Add(Me.newbtn)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.updatebtn)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents updatebtn As Button
    Friend WithEvents savebtn As Button
    Friend WithEvents deletebtn As Button
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtIncome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents firstbtn As Button
    Friend WithEvents prevbtn As Button
    Friend WithEvents nextbtn As Button
    Friend WithEvents lastbtn As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents CustomerDataSet As CustomerDataSet
    Friend WithEvents CustlistTableAdapter As CustomerDataSetTableAdapters.CustlistTableAdapter
    Friend WithEvents newbtn As Button
    Friend WithEvents MaskedTxtPhoneNum As MaskedTextBox
End Class
