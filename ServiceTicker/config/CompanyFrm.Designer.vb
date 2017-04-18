<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompanyFrm
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCompanyAddress = New System.Windows.Forms.TextBox()
        Me.txtCompanyTel = New System.Windows.Forms.TextBox()
        Me.txtCompanyFax = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCompanyTax = New System.Windows.Forms.TextBox()
        Me.txtCompanyLine = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCompanyFacebook = New System.Windows.Forms.TextBox()
        Me.txtCompanyEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCompanyWebsite = New System.Windows.Forms.TextBox()
        Me.btnCompanyEdit = New System.Windows.Forms.Button()
        Me.btnCompanyCancel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSelectLogo = New System.Windows.Forms.Button()
        Me.OpenLogo = New System.Windows.Forms.OpenFileDialog()
        Me.txtFaxLabel = New System.Windows.Forms.TextBox()
        Me.txtTelLable = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.btnHelp})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 333)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(544, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 21
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblEmployee
        '
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(30, 17)
        Me.lblEmployee.Text = "User"
        '
        'btnHelp
        '
        Me.btnHelp.Image = Global.ServiceTicker.My.Resources.Resources._109_AllAnnotations_Help_16x16_72
        Me.btnHelp.IsLink = True
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(16, 17)
        Me.btnHelp.ToolTipText = "Help"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ชื่อสถานประกอบการ"
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCompanyName.Location = New System.Drawing.Point(15, 30)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(345, 24)
        Me.txtCompanyName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 18)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ที่อยู่"
        '
        'txtCompanyAddress
        '
        Me.txtCompanyAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCompanyAddress.Location = New System.Drawing.Point(15, 78)
        Me.txtCompanyAddress.Name = "txtCompanyAddress"
        Me.txtCompanyAddress.Size = New System.Drawing.Size(345, 24)
        Me.txtCompanyAddress.TabIndex = 1
        '
        'txtCompanyTel
        '
        Me.txtCompanyTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCompanyTel.Location = New System.Drawing.Point(15, 126)
        Me.txtCompanyTel.Name = "txtCompanyTel"
        Me.txtCompanyTel.Size = New System.Drawing.Size(171, 24)
        Me.txtCompanyTel.TabIndex = 2
        '
        'txtCompanyFax
        '
        Me.txtCompanyFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCompanyFax.Location = New System.Drawing.Point(191, 126)
        Me.txtCompanyFax.Name = "txtCompanyFax"
        Me.txtCompanyFax.Size = New System.Drawing.Size(169, 24)
        Me.txtCompanyFax.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 18)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "หมายเลขผู้เสียภาษี"
        '
        'txtCompanyTax
        '
        Me.txtCompanyTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCompanyTax.Location = New System.Drawing.Point(15, 174)
        Me.txtCompanyTax.Name = "txtCompanyTax"
        Me.txtCompanyTax.Size = New System.Drawing.Size(171, 24)
        Me.txtCompanyTax.TabIndex = 4
        '
        'txtCompanyLine
        '
        Me.txtCompanyLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCompanyLine.Location = New System.Drawing.Point(191, 174)
        Me.txtCompanyLine.Name = "txtCompanyLine"
        Me.txtCompanyLine.Size = New System.Drawing.Size(169, 24)
        Me.txtCompanyLine.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(188, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 18)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "LineID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 18)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "FaceBook"
        '
        'txtCompanyFacebook
        '
        Me.txtCompanyFacebook.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCompanyFacebook.Location = New System.Drawing.Point(15, 222)
        Me.txtCompanyFacebook.Name = "txtCompanyFacebook"
        Me.txtCompanyFacebook.Size = New System.Drawing.Size(171, 24)
        Me.txtCompanyFacebook.TabIndex = 6
        '
        'txtCompanyEmail
        '
        Me.txtCompanyEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCompanyEmail.Location = New System.Drawing.Point(191, 222)
        Me.txtCompanyEmail.Name = "txtCompanyEmail"
        Me.txtCompanyEmail.Size = New System.Drawing.Size(169, 24)
        Me.txtCompanyEmail.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(188, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 18)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "อีเมล์"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 249)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 18)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "WebSite"
        '
        'txtCompanyWebsite
        '
        Me.txtCompanyWebsite.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCompanyWebsite.Location = New System.Drawing.Point(15, 270)
        Me.txtCompanyWebsite.Name = "txtCompanyWebsite"
        Me.txtCompanyWebsite.Size = New System.Drawing.Size(343, 24)
        Me.txtCompanyWebsite.TabIndex = 8
        '
        'btnCompanyEdit
        '
        Me.btnCompanyEdit.Location = New System.Drawing.Point(285, 300)
        Me.btnCompanyEdit.Name = "btnCompanyEdit"
        Me.btnCompanyEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnCompanyEdit.TabIndex = 10
        Me.btnCompanyEdit.Text = "แก้ไข"
        Me.btnCompanyEdit.UseVisualStyleBackColor = True
        '
        'btnCompanyCancel
        '
        Me.btnCompanyCancel.Location = New System.Drawing.Point(204, 300)
        Me.btnCompanyCancel.Name = "btnCompanyCancel"
        Me.btnCompanyCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCompanyCancel.TabIndex = 11
        Me.btnCompanyCancel.Text = "ยกเลิก"
        Me.btnCompanyCancel.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox1.Location = New System.Drawing.Point(381, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(147, 138)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'btnSelectLogo
        '
        Me.btnSelectLogo.Location = New System.Drawing.Point(421, 174)
        Me.btnSelectLogo.Name = "btnSelectLogo"
        Me.btnSelectLogo.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectLogo.TabIndex = 9
        Me.btnSelectLogo.Text = "เลือกโลโก้"
        Me.btnSelectLogo.UseVisualStyleBackColor = True
        '
        'OpenLogo
        '
        Me.OpenLogo.Filter = "ไฟล์รูป(*.jpg,*.jpeg,*.png,*.bmp)|*.jpg;*.jpeg;*.png;*.bmp"
        Me.OpenLogo.RestoreDirectory = True
        '
        'txtFaxLabel
        '
        Me.txtFaxLabel.Location = New System.Drawing.Point(191, 107)
        Me.txtFaxLabel.Name = "txtFaxLabel"
        Me.txtFaxLabel.Size = New System.Drawing.Size(98, 20)
        Me.txtFaxLabel.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.txtFaxLabel, "ป้ายแสดงชื่อ (มีผลกับหน้ารายงานต่าง ๆ ที่จะพิมพ์)")
        '
        'txtTelLable
        '
        Me.txtTelLable.Location = New System.Drawing.Point(15, 107)
        Me.txtTelLable.Name = "txtTelLable"
        Me.txtTelLable.Size = New System.Drawing.Size(98, 20)
        Me.txtTelLable.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.txtTelLable, "ป้ายแสดงชื่อ (มีผลกับหน้ารายงานต่าง ๆ ที่จะพิมพ์)")
        '
        'CompanyFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 355)
        Me.Controls.Add(Me.txtTelLable)
        Me.Controls.Add(Me.txtFaxLabel)
        Me.Controls.Add(Me.btnSelectLogo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCompanyCancel)
        Me.Controls.Add(Me.btnCompanyEdit)
        Me.Controls.Add(Me.txtCompanyWebsite)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCompanyEmail)
        Me.Controls.Add(Me.txtCompanyFacebook)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCompanyLine)
        Me.Controls.Add(Me.txtCompanyTax)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCompanyFax)
        Me.Controls.Add(Me.txtCompanyTel)
        Me.Controls.Add(Me.txtCompanyAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCompanyName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CompanyFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ข้อมูลสถานประกอบการ"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCompanyAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCompanyTel As System.Windows.Forms.TextBox
    Friend WithEvents txtCompanyFax As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCompanyTax As System.Windows.Forms.TextBox
    Friend WithEvents txtCompanyLine As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCompanyFacebook As System.Windows.Forms.TextBox
    Friend WithEvents txtCompanyEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCompanyWebsite As System.Windows.Forms.TextBox
    Friend WithEvents btnCompanyEdit As System.Windows.Forms.Button
    Friend WithEvents btnCompanyCancel As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSelectLogo As System.Windows.Forms.Button
    Friend WithEvents OpenLogo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtFaxLabel As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtTelLable As System.Windows.Forms.TextBox
End Class
