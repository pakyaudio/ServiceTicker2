<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaimsTestSaveFrm
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
        Me.btnCTRcancel = New System.Windows.Forms.Button()
        Me.btnCTRsave = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCTRtest_note = New System.Windows.Forms.TextBox()
        Me.rbCTRtestNoPass = New System.Windows.Forms.RadioButton()
        Me.rbCTRtestPass = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCTRclaims_correction = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCTRcus_name = New System.Windows.Forms.TextBox()
        Me.txtCTRcus_id = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCTRclaims_id = New System.Windows.Forms.TextBox()
        Me.lblCTRclaims_id = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCTRclaims_sn = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCTRclaims_datetime_send = New System.Windows.Forms.TextBox()
        Me.txtCTRclaims_code_pro = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCTRclaims_datetime_save = New System.Windows.Forms.TextBox()
        Me.txtCTR_claims_barcode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCTRclaims_sytom = New System.Windows.Forms.TextBox()
        Me.txtCTRclaims_namepro = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCTRcancel)
        Me.Panel1.Controls.Add(Me.btnCTRsave)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtCTRcus_name)
        Me.Panel1.Controls.Add(Me.txtCTRcus_id)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(599, 305)
        Me.Panel1.TabIndex = 0
        '
        'btnCTRcancel
        '
        Me.btnCTRcancel.Location = New System.Drawing.Point(386, 271)
        Me.btnCTRcancel.Name = "btnCTRcancel"
        Me.btnCTRcancel.Size = New System.Drawing.Size(75, 29)
        Me.btnCTRcancel.TabIndex = 115
        Me.btnCTRcancel.Text = "ยกเลิก"
        Me.btnCTRcancel.UseVisualStyleBackColor = True
        '
        'btnCTRsave
        '
        Me.btnCTRsave.Location = New System.Drawing.Point(467, 271)
        Me.btnCTRsave.Name = "btnCTRsave"
        Me.btnCTRsave.Size = New System.Drawing.Size(129, 29)
        Me.btnCTRsave.TabIndex = 114
        Me.btnCTRsave.Text = "บันทึก"
        Me.btnCTRsave.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCTRtest_note)
        Me.GroupBox2.Controls.Add(Me.rbCTRtestNoPass)
        Me.GroupBox2.Controls.Add(Me.rbCTRtestPass)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtCTRclaims_correction)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 177)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(593, 88)
        Me.GroupBox2.TabIndex = 109
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "รายละเอียดการเคลม"
        '
        'txtCTRtest_note
        '
        Me.txtCTRtest_note.BackColor = System.Drawing.SystemColors.Window
        Me.txtCTRtest_note.Enabled = False
        Me.txtCTRtest_note.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCTRtest_note.Location = New System.Drawing.Point(224, 49)
        Me.txtCTRtest_note.Name = "txtCTRtest_note"
        Me.txtCTRtest_note.Size = New System.Drawing.Size(355, 24)
        Me.txtCTRtest_note.TabIndex = 112
        '
        'rbCTRtestNoPass
        '
        Me.rbCTRtestNoPass.AutoSize = True
        Me.rbCTRtestNoPass.Location = New System.Drawing.Point(159, 54)
        Me.rbCTRtestNoPass.Name = "rbCTRtestNoPass"
        Me.rbCTRtestNoPass.Size = New System.Drawing.Size(58, 17)
        Me.rbCTRtestNoPass.TabIndex = 30
        Me.rbCTRtestNoPass.TabStop = True
        Me.rbCTRtestNoPass.Text = "ไม่ผ่าน"
        Me.rbCTRtestNoPass.UseVisualStyleBackColor = True
        '
        'rbCTRtestPass
        '
        Me.rbCTRtestPass.AutoSize = True
        Me.rbCTRtestPass.BackColor = System.Drawing.SystemColors.Control
        Me.rbCTRtestPass.ForeColor = System.Drawing.SystemColors.WindowText
        Me.rbCTRtestPass.Location = New System.Drawing.Point(108, 54)
        Me.rbCTRtestPass.Name = "rbCTRtestPass"
        Me.rbCTRtestPass.Size = New System.Drawing.Size(45, 17)
        Me.rbCTRtestPass.TabIndex = 29
        Me.rbCTRtestPass.TabStop = True
        Me.rbCTRtestPass.Text = "ผ่าน"
        Me.rbCTRtestPass.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 56)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "ผลการทดสอบ"
        '
        'txtCTRclaims_correction
        '
        Me.txtCTRclaims_correction.BackColor = System.Drawing.SystemColors.Window
        Me.txtCTRclaims_correction.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCTRclaims_correction.Location = New System.Drawing.Point(108, 19)
        Me.txtCTRclaims_correction.Name = "txtCTRclaims_correction"
        Me.txtCTRclaims_correction.Size = New System.Drawing.Size(471, 24)
        Me.txtCTRclaims_correction.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "การแก้ไขจากบริษัท"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "รหัสลูกค้า"
        '
        'txtCTRcus_name
        '
        Me.txtCTRcus_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCTRcus_name.Location = New System.Drawing.Point(244, 3)
        Me.txtCTRcus_name.Name = "txtCTRcus_name"
        Me.txtCTRcus_name.ReadOnly = True
        Me.txtCTRcus_name.Size = New System.Drawing.Size(160, 24)
        Me.txtCTRcus_name.TabIndex = 102
        '
        'txtCTRcus_id
        '
        Me.txtCTRcus_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCTRcus_id.Location = New System.Drawing.Point(60, 3)
        Me.txtCTRcus_id.Name = "txtCTRcus_id"
        Me.txtCTRcus_id.ReadOnly = True
        Me.txtCTRcus_id.Size = New System.Drawing.Size(131, 24)
        Me.txtCTRcus_id.TabIndex = 103
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(197, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "ชื่อลูกค้า"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCTRclaims_id)
        Me.GroupBox1.Controls.Add(Me.lblCTRclaims_id)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCTRclaims_sn)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCTRclaims_datetime_send)
        Me.GroupBox1.Controls.Add(Me.txtCTRclaims_code_pro)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCTRclaims_datetime_save)
        Me.GroupBox1.Controls.Add(Me.txtCTR_claims_barcode)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtCTRclaims_sytom)
        Me.GroupBox1.Controls.Add(Me.txtCTRclaims_namepro)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(593, 138)
        Me.GroupBox1.TabIndex = 100
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รายละเอียดสินค้า"
        '
        'txtCTRclaims_id
        '
        Me.txtCTRclaims_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCTRclaims_id.Location = New System.Drawing.Point(61, 19)
        Me.txtCTRclaims_id.Name = "txtCTRclaims_id"
        Me.txtCTRclaims_id.ReadOnly = True
        Me.txtCTRclaims_id.Size = New System.Drawing.Size(174, 24)
        Me.txtCTRclaims_id.TabIndex = 99
        '
        'lblCTRclaims_id
        '
        Me.lblCTRclaims_id.AutoSize = True
        Me.lblCTRclaims_id.Location = New System.Drawing.Point(4, 26)
        Me.lblCTRclaims_id.Name = "lblCTRclaims_id"
        Me.lblCTRclaims_id.Size = New System.Drawing.Size(51, 13)
        Me.lblCTRclaims_id.TabIndex = 99
        Me.lblCTRclaims_id.Text = "รหัสเคลม"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(241, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "SN"
        '
        'txtCTRclaims_sn
        '
        Me.txtCTRclaims_sn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCTRclaims_sn.Location = New System.Drawing.Point(269, 19)
        Me.txtCTRclaims_sn.Name = "txtCTRclaims_sn"
        Me.txtCTRclaims_sn.ReadOnly = True
        Me.txtCTRclaims_sn.Size = New System.Drawing.Size(131, 24)
        Me.txtCTRclaims_sn.TabIndex = 99
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(406, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "รหัสสินค้า"
        '
        'txtCTRclaims_datetime_send
        '
        Me.txtCTRclaims_datetime_send.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCTRclaims_datetime_send.Location = New System.Drawing.Point(399, 109)
        Me.txtCTRclaims_datetime_send.Name = "txtCTRclaims_datetime_send"
        Me.txtCTRclaims_datetime_send.ReadOnly = True
        Me.txtCTRclaims_datetime_send.Size = New System.Drawing.Size(180, 24)
        Me.txtCTRclaims_datetime_send.TabIndex = 99
        '
        'txtCTRclaims_code_pro
        '
        Me.txtCTRclaims_code_pro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCTRclaims_code_pro.Location = New System.Drawing.Point(464, 19)
        Me.txtCTRclaims_code_pro.Name = "txtCTRclaims_code_pro"
        Me.txtCTRclaims_code_pro.ReadOnly = True
        Me.txtCTRclaims_code_pro.Size = New System.Drawing.Size(115, 24)
        Me.txtCTRclaims_code_pro.TabIndex = 99
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(329, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 99
        Me.Label10.Text = "วันที่ส่งเคลม"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "บาร์โค๊ต"
        '
        'txtCTRclaims_datetime_save
        '
        Me.txtCTRclaims_datetime_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCTRclaims_datetime_save.Location = New System.Drawing.Point(399, 79)
        Me.txtCTRclaims_datetime_save.Name = "txtCTRclaims_datetime_save"
        Me.txtCTRclaims_datetime_save.ReadOnly = True
        Me.txtCTRclaims_datetime_save.Size = New System.Drawing.Size(180, 24)
        Me.txtCTRclaims_datetime_save.TabIndex = 99
        '
        'txtCTR_claims_barcode
        '
        Me.txtCTR_claims_barcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCTR_claims_barcode.Location = New System.Drawing.Point(54, 49)
        Me.txtCTR_claims_barcode.Name = "txtCTR_claims_barcode"
        Me.txtCTR_claims_barcode.ReadOnly = True
        Me.txtCTR_claims_barcode.Size = New System.Drawing.Size(120, 24)
        Me.txtCTR_claims_barcode.TabIndex = 99
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(327, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 99
        Me.Label9.Text = "วันที่รับเคลม"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(180, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "ชื่อสินค้า"
        '
        'txtCTRclaims_sytom
        '
        Me.txtCTRclaims_sytom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCTRclaims_sytom.Location = New System.Drawing.Point(64, 79)
        Me.txtCTRclaims_sytom.Name = "txtCTRclaims_sytom"
        Me.txtCTRclaims_sytom.ReadOnly = True
        Me.txtCTRclaims_sytom.Size = New System.Drawing.Size(259, 24)
        Me.txtCTRclaims_sytom.TabIndex = 99
        '
        'txtCTRclaims_namepro
        '
        Me.txtCTRclaims_namepro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCTRclaims_namepro.Location = New System.Drawing.Point(232, 49)
        Me.txtCTRclaims_namepro.Name = "txtCTRclaims_namepro"
        Me.txtCTRclaims_namepro.ReadOnly = True
        Me.txtCTRclaims_namepro.Size = New System.Drawing.Size(347, 24)
        Me.txtCTRclaims_namepro.TabIndex = 99
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "อาการเสีย"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Timer2
        '
        Me.Timer2.Interval = 500
        '
        'Timer3
        '
        Me.Timer3.Interval = 500
        '
        'ClaimsTestSaveFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 305)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ClaimsTestSaveFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "บันทึกผลการทดสอบ"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCTRcancel As System.Windows.Forms.Button
    Friend WithEvents btnCTRsave As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCTRtest_note As System.Windows.Forms.TextBox
    Friend WithEvents rbCTRtestNoPass As System.Windows.Forms.RadioButton
    Friend WithEvents rbCTRtestPass As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCTRclaims_correction As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCTRcus_name As System.Windows.Forms.TextBox
    Friend WithEvents txtCTRcus_id As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCTRclaims_id As System.Windows.Forms.TextBox
    Friend WithEvents lblCTRclaims_id As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCTRclaims_sn As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCTRclaims_datetime_send As System.Windows.Forms.TextBox
    Friend WithEvents txtCTRclaims_code_pro As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCTRclaims_datetime_save As System.Windows.Forms.TextBox
    Friend WithEvents txtCTR_claims_barcode As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCTRclaims_sytom As System.Windows.Forms.TextBox
    Friend WithEvents txtCTRclaims_namepro As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
End Class
