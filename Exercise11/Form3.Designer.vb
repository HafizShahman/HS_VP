<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.txtExam1 = New System.Windows.Forms.TextBox()
        Me.txtExam2 = New System.Windows.Forms.TextBox()
        Me.txtExam3 = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GetMarks = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtExam1
        '
        Me.txtExam1.Location = New System.Drawing.Point(326, 125)
        Me.txtExam1.Name = "txtExam1"
        Me.txtExam1.Size = New System.Drawing.Size(178, 22)
        Me.txtExam1.TabIndex = 0
        '
        'txtExam2
        '
        Me.txtExam2.Location = New System.Drawing.Point(326, 173)
        Me.txtExam2.Name = "txtExam2"
        Me.txtExam2.Size = New System.Drawing.Size(178, 22)
        Me.txtExam2.TabIndex = 1
        '
        'txtExam3
        '
        Me.txtExam3.Location = New System.Drawing.Point(326, 219)
        Me.txtExam3.Name = "txtExam3"
        Me.txtExam3.Size = New System.Drawing.Size(178, 22)
        Me.txtExam3.TabIndex = 2
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(326, 335)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(178, 22)
        Me.txtTotal.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(227, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Exam 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Exam 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(227, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Exam 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(230, 339)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Total"
        '
        'GetMarks
        '
        Me.GetMarks.Location = New System.Drawing.Point(326, 268)
        Me.GetMarks.Name = "GetMarks"
        Me.GetMarks.Size = New System.Drawing.Size(178, 51)
        Me.GetMarks.TabIndex = 8
        Me.GetMarks.Text = "Get Mark"
        Me.GetMarks.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GetMarks)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtExam3)
        Me.Controls.Add(Me.txtExam2)
        Me.Controls.Add(Me.txtExam1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtExam1 As TextBox
    Friend WithEvents txtExam2 As TextBox
    Friend WithEvents txtExam3 As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GetMarks As Button
End Class
