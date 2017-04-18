<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductRichTextDetailFrm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRedu = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrackBarZoom = New System.Windows.Forms.TrackBar()
        Me.btnFontDialog = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnColorBlack = New System.Windows.Forms.Button()
        Me.btnFontUline = New System.Windows.Forms.Button()
        Me.btnColorBlue = New System.Windows.Forms.Button()
        Me.btnFontU = New System.Windows.Forms.Button()
        Me.btnColorGreen = New System.Windows.Forms.Button()
        Me.btnColorYallow = New System.Windows.Forms.Button()
        Me.btnFontI = New System.Windows.Forms.Button()
        Me.btnColorRed = New System.Windows.Forms.Button()
        Me.btnFontB = New System.Windows.Forms.Button()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.TrackBarZoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnRedu)
        Me.Panel1.Controls.Add(Me.btnUndo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TrackBarZoom)
        Me.Panel1.Controls.Add(Me.btnFontDialog)
        Me.Panel1.Controls.Add(Me.btnApply)
        Me.Panel1.Controls.Add(Me.btnColorBlack)
        Me.Panel1.Controls.Add(Me.btnFontUline)
        Me.Panel1.Controls.Add(Me.btnColorBlue)
        Me.Panel1.Controls.Add(Me.btnFontU)
        Me.Panel1.Controls.Add(Me.btnColorGreen)
        Me.Panel1.Controls.Add(Me.btnColorYallow)
        Me.Panel1.Controls.Add(Me.btnFontI)
        Me.Panel1.Controls.Add(Me.btnColorRed)
        Me.Panel1.Controls.Add(Me.btnFontB)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 34)
        Me.Panel1.TabIndex = 0
        '
        'btnRedu
        '
        Me.btnRedu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRedu.Image = Global.ServiceTicker.My.Resources.Resources.Redo_16x
        Me.btnRedu.Location = New System.Drawing.Point(381, 3)
        Me.btnRedu.Name = "btnRedu"
        Me.btnRedu.Size = New System.Drawing.Size(24, 23)
        Me.btnRedu.TabIndex = 19
        Me.btnRedu.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnRedu, "ทำซ้ำ (Redo) (Ctrl + Y)")
        Me.btnRedu.UseVisualStyleBackColor = True
        '
        'btnUndo
        '
        Me.btnUndo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnUndo.Image = Global.ServiceTicker.My.Resources.Resources.Undo_16x
        Me.btnUndo.Location = New System.Drawing.Point(351, 3)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(24, 23)
        Me.btnUndo.TabIndex = 18
        Me.btnUndo.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnUndo, "ย้อนกลับ (Undo) (Ctrl +Z)")
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(646, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Label1"
        '
        'TrackBarZoom
        '
        Me.TrackBarZoom.Location = New System.Drawing.Point(423, 3)
        Me.TrackBarZoom.Name = "TrackBarZoom"
        Me.TrackBarZoom.Size = New System.Drawing.Size(217, 45)
        Me.TrackBarZoom.TabIndex = 16
        Me.TrackBarZoom.TabStop = False
        Me.ToolTip1.SetToolTip(Me.TrackBarZoom, "ขยาย")
        '
        'btnFontDialog
        '
        Me.btnFontDialog.Location = New System.Drawing.Point(270, 3)
        Me.btnFontDialog.Name = "btnFontDialog"
        Me.btnFontDialog.Size = New System.Drawing.Size(75, 23)
        Me.btnFontDialog.TabIndex = 1
        Me.btnFontDialog.TabStop = False
        Me.btnFontDialog.Text = "แบบอักษร"
        Me.btnFontDialog.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApply.Location = New System.Drawing.Point(706, 3)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 1
        Me.btnApply.TabStop = False
        Me.btnApply.Text = "นำไปใช้"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnColorBlack
        '
        Me.btnColorBlack.BackColor = System.Drawing.Color.Black
        Me.btnColorBlack.Location = New System.Drawing.Point(125, 3)
        Me.btnColorBlack.Name = "btnColorBlack"
        Me.btnColorBlack.Size = New System.Drawing.Size(23, 23)
        Me.btnColorBlack.TabIndex = 15
        Me.btnColorBlack.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnColorBlack, "อักษรสีดำ")
        Me.btnColorBlack.UseVisualStyleBackColor = False
        '
        'btnFontUline
        '
        Me.btnFontUline.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnFontUline.Location = New System.Drawing.Point(93, 3)
        Me.btnFontUline.Name = "btnFontUline"
        Me.btnFontUline.Size = New System.Drawing.Size(24, 23)
        Me.btnFontUline.TabIndex = 1
        Me.btnFontUline.TabStop = False
        Me.btnFontUline.Text = "U"
        Me.ToolTip1.SetToolTip(Me.btnFontUline, "ขีดฆ่าตัวอักษร")
        Me.btnFontUline.UseVisualStyleBackColor = True
        '
        'btnColorBlue
        '
        Me.btnColorBlue.BackColor = System.Drawing.Color.Blue
        Me.btnColorBlue.Location = New System.Drawing.Point(154, 3)
        Me.btnColorBlue.Name = "btnColorBlue"
        Me.btnColorBlue.Size = New System.Drawing.Size(23, 23)
        Me.btnColorBlue.TabIndex = 14
        Me.btnColorBlue.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnColorBlue, "อักษรสีน้ำเงิน")
        Me.btnColorBlue.UseVisualStyleBackColor = False
        '
        'btnFontU
        '
        Me.btnFontU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnFontU.Location = New System.Drawing.Point(63, 3)
        Me.btnFontU.Name = "btnFontU"
        Me.btnFontU.Size = New System.Drawing.Size(24, 23)
        Me.btnFontU.TabIndex = 1
        Me.btnFontU.TabStop = False
        Me.btnFontU.Text = "U"
        Me.ToolTip1.SetToolTip(Me.btnFontU, "ขีดเส้นใต้ตัวอักษร (Ctrl + U)")
        Me.btnFontU.UseVisualStyleBackColor = True
        '
        'btnColorGreen
        '
        Me.btnColorGreen.BackColor = System.Drawing.Color.Green
        Me.btnColorGreen.Location = New System.Drawing.Point(183, 3)
        Me.btnColorGreen.Name = "btnColorGreen"
        Me.btnColorGreen.Size = New System.Drawing.Size(23, 23)
        Me.btnColorGreen.TabIndex = 13
        Me.btnColorGreen.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnColorGreen, "อักษรสีเขียว")
        Me.btnColorGreen.UseVisualStyleBackColor = False
        '
        'btnColorYallow
        '
        Me.btnColorYallow.BackColor = System.Drawing.Color.Yellow
        Me.btnColorYallow.Location = New System.Drawing.Point(212, 3)
        Me.btnColorYallow.Name = "btnColorYallow"
        Me.btnColorYallow.Size = New System.Drawing.Size(23, 23)
        Me.btnColorYallow.TabIndex = 12
        Me.btnColorYallow.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnColorYallow, "อักษรสีเหลือง")
        Me.btnColorYallow.UseVisualStyleBackColor = False
        '
        'btnFontI
        '
        Me.btnFontI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnFontI.Location = New System.Drawing.Point(33, 3)
        Me.btnFontI.Name = "btnFontI"
        Me.btnFontI.Size = New System.Drawing.Size(24, 23)
        Me.btnFontI.TabIndex = 1
        Me.btnFontI.TabStop = False
        Me.btnFontI.Text = "I"
        Me.ToolTip1.SetToolTip(Me.btnFontI, "ตัวอักษรเอียง (Ctrl + I)")
        Me.btnFontI.UseVisualStyleBackColor = True
        '
        'btnColorRed
        '
        Me.btnColorRed.BackColor = System.Drawing.Color.Red
        Me.btnColorRed.Location = New System.Drawing.Point(241, 3)
        Me.btnColorRed.Name = "btnColorRed"
        Me.btnColorRed.Size = New System.Drawing.Size(23, 23)
        Me.btnColorRed.TabIndex = 11
        Me.btnColorRed.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnColorRed, "อักษรสีแดง")
        Me.btnColorRed.UseVisualStyleBackColor = False
        '
        'btnFontB
        '
        Me.btnFontB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnFontB.Location = New System.Drawing.Point(3, 3)
        Me.btnFontB.Name = "btnFontB"
        Me.btnFontB.Size = New System.Drawing.Size(24, 23)
        Me.btnFontB.TabIndex = 0
        Me.btnFontB.TabStop = False
        Me.btnFontB.Text = "B"
        Me.ToolTip1.SetToolTip(Me.btnFontB, "ตัวอักษรหนา (Ctrl + B)")
        Me.btnFontB.UseVisualStyleBackColor = True
        '
        'FontDialog1
        '
        Me.FontDialog1.ScriptsOnly = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 34)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(784, 527)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'ProductRichTextDetailFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "ProductRichTextDetailFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายละเอียดสินค้า"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TrackBarZoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnFontDialog As System.Windows.Forms.Button
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents btnColorBlack As System.Windows.Forms.Button
    Friend WithEvents btnFontUline As System.Windows.Forms.Button
    Friend WithEvents btnColorBlue As System.Windows.Forms.Button
    Friend WithEvents btnFontU As System.Windows.Forms.Button
    Friend WithEvents btnColorGreen As System.Windows.Forms.Button
    Friend WithEvents btnColorYallow As System.Windows.Forms.Button
    Friend WithEvents btnFontI As System.Windows.Forms.Button
    Friend WithEvents btnColorRed As System.Windows.Forms.Button
    Friend WithEvents btnFontB As System.Windows.Forms.Button
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents TrackBarZoom As System.Windows.Forms.TrackBar
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRedu As System.Windows.Forms.Button
    Friend WithEvents btnUndo As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
