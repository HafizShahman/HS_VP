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
        Me.picboxDraw = New System.Windows.Forms.PictureBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.cbxSize = New System.Windows.Forms.ComboBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        CType(Me.picboxDraw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picboxDraw
        '
        Me.picboxDraw.BackColor = System.Drawing.Color.White
        Me.picboxDraw.Location = New System.Drawing.Point(199, 38)
        Me.picboxDraw.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picboxDraw.Name = "picboxDraw"
        Me.picboxDraw.Size = New System.Drawing.Size(424, 336)
        Me.picboxDraw.TabIndex = 0
        Me.picboxDraw.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(663, 106)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(79, 28)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(663, 173)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(79, 28)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnColor
        '
        Me.btnColor.Location = New System.Drawing.Point(54, 106)
        Me.btnColor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(94, 28)
        Me.btnColor.TabIndex = 3
        Me.btnColor.Text = "COLOR"
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'cbxSize
        '
        Me.cbxSize.AllowDrop = True
        Me.cbxSize.FormattingEnabled = True
        Me.cbxSize.Items.AddRange(New Object() {"2", "4", "6", "8", "10"})
        Me.cbxSize.Location = New System.Drawing.Point(54, 173)
        Me.cbxSize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxSize.Name = "cbxSize"
        Me.cbxSize.Size = New System.Drawing.Size(94, 24)
        Me.cbxSize.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 421)
        Me.Controls.Add(Me.cbxSize)
        Me.Controls.Add(Me.btnColor)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.picboxDraw)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picboxDraw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picboxDraw As PictureBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnColor As Button
    Friend WithEvents cbxSize As ComboBox
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
