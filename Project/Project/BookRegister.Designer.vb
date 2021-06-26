<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Book
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
        Me.BTNGOLAST = New System.Windows.Forms.Button()
        Me.BTNNEXT = New System.Windows.Forms.Button()
        Me.BTNPREVIOUS = New System.Windows.Forms.Button()
        Me.BTNGOFIRST = New System.Windows.Forms.Button()
        Me.BTNSSAVE = New System.Windows.Forms.Button()
        Me.BTNDELETE = New System.Windows.Forms.Button()
        Me.BTNUPDATE = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTNGOLAST
        '
        Me.BTNGOLAST.Location = New System.Drawing.Point(618, 410)
        Me.BTNGOLAST.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNGOLAST.Name = "BTNGOLAST"
        Me.BTNGOLAST.Size = New System.Drawing.Size(72, 31)
        Me.BTNGOLAST.TabIndex = 34
        Me.BTNGOLAST.Text = ">>"
        Me.BTNGOLAST.UseVisualStyleBackColor = True
        '
        'BTNNEXT
        '
        Me.BTNNEXT.Location = New System.Drawing.Point(483, 410)
        Me.BTNNEXT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNNEXT.Name = "BTNNEXT"
        Me.BTNNEXT.Size = New System.Drawing.Size(68, 31)
        Me.BTNNEXT.TabIndex = 33
        Me.BTNNEXT.Text = ">"
        Me.BTNNEXT.UseVisualStyleBackColor = True
        '
        'BTNPREVIOUS
        '
        Me.BTNPREVIOUS.Location = New System.Drawing.Point(349, 410)
        Me.BTNPREVIOUS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNPREVIOUS.Name = "BTNPREVIOUS"
        Me.BTNPREVIOUS.Size = New System.Drawing.Size(68, 31)
        Me.BTNPREVIOUS.TabIndex = 32
        Me.BTNPREVIOUS.Text = "<"
        Me.BTNPREVIOUS.UseVisualStyleBackColor = True
        '
        'BTNGOFIRST
        '
        Me.BTNGOFIRST.Location = New System.Drawing.Point(210, 410)
        Me.BTNGOFIRST.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNGOFIRST.Name = "BTNGOFIRST"
        Me.BTNGOFIRST.Size = New System.Drawing.Size(70, 31)
        Me.BTNGOFIRST.TabIndex = 31
        Me.BTNGOFIRST.Text = "<<"
        Me.BTNGOFIRST.UseVisualStyleBackColor = True
        '
        'BTNSSAVE
        '
        Me.BTNSSAVE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSSAVE.Location = New System.Drawing.Point(716, 286)
        Me.BTNSSAVE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNSSAVE.Name = "BTNSSAVE"
        Me.BTNSSAVE.Size = New System.Drawing.Size(98, 23)
        Me.BTNSSAVE.TabIndex = 30
        Me.BTNSSAVE.Text = "SAVE"
        Me.BTNSSAVE.UseVisualStyleBackColor = True
        '
        'BTNDELETE
        '
        Me.BTNDELETE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNDELETE.Location = New System.Drawing.Point(716, 230)
        Me.BTNDELETE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNDELETE.Name = "BTNDELETE"
        Me.BTNDELETE.Size = New System.Drawing.Size(98, 24)
        Me.BTNDELETE.TabIndex = 29
        Me.BTNDELETE.Text = "DELETE"
        Me.BTNDELETE.UseVisualStyleBackColor = True
        '
        'BTNUPDATE
        '
        Me.BTNUPDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNUPDATE.Location = New System.Drawing.Point(716, 181)
        Me.BTNUPDATE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTNUPDATE.Name = "BTNUPDATE"
        Me.BTNUPDATE.Size = New System.Drawing.Size(98, 23)
        Me.BTNUPDATE.TabIndex = 28
        Me.BTNUPDATE.Text = "UPDATE"
        Me.BTNUPDATE.UseVisualStyleBackColor = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(303, 138)
        Me.MaskedTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaskedTextBox1.Mask = "00000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(306, 22)
        Me.MaskedTextBox1.TabIndex = 27
        Me.MaskedTextBox1.ValidatingType = GetType(Integer)
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(303, 324)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(306, 22)
        Me.TextBox5.TabIndex = 26
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(303, 273)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(306, 22)
        Me.TextBox4.TabIndex = 25
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(303, 226)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(306, 22)
        Me.TextBox3.TabIndex = 24
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(303, 183)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(306, 22)
        Me.TextBox2.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(164, 329)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Year :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(164, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Genre :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(164, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Author :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "BookTitle :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(164, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "BookID :"
        '
        'Book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(979, 578)
        Me.Controls.Add(Me.BTNGOLAST)
        Me.Controls.Add(Me.BTNNEXT)
        Me.Controls.Add(Me.BTNPREVIOUS)
        Me.Controls.Add(Me.BTNGOFIRST)
        Me.Controls.Add(Me.BTNSSAVE)
        Me.Controls.Add(Me.BTNDELETE)
        Me.Controls.Add(Me.BTNUPDATE)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Book"
        Me.Text = "BOOK"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNGOLAST As Button
    Friend WithEvents BTNNEXT As Button
    Friend WithEvents BTNPREVIOUS As Button
    Friend WithEvents BTNGOFIRST As Button
    Friend WithEvents BTNSSAVE As Button
    Friend WithEvents BTNDELETE As Button
    Friend WithEvents BTNUPDATE As Button
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
