<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaimsComfixBackFrm
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.btnCCBsave = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCCBcus_tel = New System.Windows.Forms.TextBox()
        Me.txtCCBprice_fix = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbbCCBtel_to_cus = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCCBnote = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCCBaccessory = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCCBsyptom = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCCBemployee_sale = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCCBdatetime_sale = New System.Windows.Forms.TextBox()
        Me.txtCCBunit = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCCBtype = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCCBprice_buy = New System.Windows.Forms.TextBox()
        Me.txtCCBname_pro = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCCBbar_code = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCCBcode_pro = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCCBsn = New System.Windows.Forms.TextBox()
        Me.txtCCBcus_name = New System.Windows.Forms.TextBox()
        Me.txtCCBcus_id = New System.Windows.Forms.TextBox()
        Me.txtCCBclaims_id = New System.Windows.Forms.TextBox()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 296)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(422, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'btnCCBsave
        '
        Me.btnCCBsave.Location = New System.Drawing.Point(282, 273)
        Me.btnCCBsave.Name = "btnCCBsave"
        Me.btnCCBsave.Size = New System.Drawing.Size(133, 20)
        Me.btnCCBsave.TabIndex = 80
        Me.btnCCBsave.Text = "บันทึกเข้าระบบ"
        Me.btnCCBsave.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(214, 249)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(74, 13)
        Me.Label19.TabIndex = 79
        Me.Label19.Text = "เบอร์โทรลูกค้า"
        '
        'txtCCBcus_tel
        '
        Me.txtCCBcus_tel.Location = New System.Drawing.Point(292, 247)
        Me.txtCCBcus_tel.Name = "txtCCBcus_tel"
        Me.txtCCBcus_tel.ReadOnly = True
        Me.txtCCBcus_tel.Size = New System.Drawing.Size(123, 20)
        Me.txtCCBcus_tel.TabIndex = 78
        '
        'txtCCBprice_fix
        '
        Me.txtCCBprice_fix.Location = New System.Drawing.Point(111, 273)
        Me.txtCCBprice_fix.Name = "txtCCBprice_fix"
        Me.txtCCBprice_fix.ReadOnly = True
        Me.txtCCBprice_fix.Size = New System.Drawing.Size(100, 20)
        Me.txtCCBprice_fix.TabIndex = 77
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 276)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(97, 13)
        Me.Label18.TabIndex = 76
        Me.Label18.Text = "ราคาค่าซ่อม/อะไหล่"
        '
        'cbbCCBtel_to_cus
        '
        Me.cbbCCBtel_to_cus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbbCCBtel_to_cus.FormattingEnabled = True
        Me.cbbCCBtel_to_cus.Items.AddRange(New Object() {"ยังไม่ได้แจ้งลูกค้า", "แจ้งลูกค้าแล้ว"})
        Me.cbbCCBtel_to_cus.Location = New System.Drawing.Point(101, 246)
        Me.cbbCCBtel_to_cus.Name = "cbbCCBtel_to_cus"
        Me.cbbCCBtel_to_cus.Size = New System.Drawing.Size(110, 21)
        Me.cbbCCBtel_to_cus.TabIndex = 75
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 249)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 13)
        Me.Label17.TabIndex = 74
        Me.Label17.Text = "การโทรแจ้งลูกค้า"
        '
        'txtCCBnote
        '
        Me.txtCCBnote.Location = New System.Drawing.Point(88, 220)
        Me.txtCCBnote.Name = "txtCCBnote"
        Me.txtCCBnote.ReadOnly = True
        Me.txtCCBnote.Size = New System.Drawing.Size(326, 20)
        Me.txtCCBnote.TabIndex = 73
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 223)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 13)
        Me.Label16.TabIndex = 72
        Me.Label16.Text = "บันทึกการซ่อม"
        '
        'txtCCBaccessory
        '
        Me.txtCCBaccessory.Location = New System.Drawing.Point(108, 194)
        Me.txtCCBaccessory.Name = "txtCCBaccessory"
        Me.txtCCBaccessory.ReadOnly = True
        Me.txtCCBaccessory.Size = New System.Drawing.Size(306, 20)
        Me.txtCCBaccessory.TabIndex = 71
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 197)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 13)
        Me.Label15.TabIndex = 70
        Me.Label15.Text = "อุปกรณ์ที่นำมาด้วย"
        '
        'txtCCBsyptom
        '
        Me.txtCCBsyptom.Location = New System.Drawing.Point(65, 168)
        Me.txtCCBsyptom.Name = "txtCCBsyptom"
        Me.txtCCBsyptom.ReadOnly = True
        Me.txtCCBsyptom.Size = New System.Drawing.Size(349, 20)
        Me.txtCCBsyptom.TabIndex = 69
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 171)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 68
        Me.Label14.Text = "อาการเสีย"
        '
        'txtCCBemployee_sale
        '
        Me.txtCCBemployee_sale.Location = New System.Drawing.Point(276, 142)
        Me.txtCCBemployee_sale.Name = "txtCCBemployee_sale"
        Me.txtCCBemployee_sale.ReadOnly = True
        Me.txtCCBemployee_sale.Size = New System.Drawing.Size(138, 20)
        Me.txtCCBemployee_sale.TabIndex = 67
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(204, 145)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 13)
        Me.Label13.TabIndex = 66
        Me.Label13.Text = "พนักงานขาย"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 145)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "วันที่ขาย"
        '
        'txtCCBdatetime_sale
        '
        Me.txtCCBdatetime_sale.Location = New System.Drawing.Point(65, 142)
        Me.txtCCBdatetime_sale.Name = "txtCCBdatetime_sale"
        Me.txtCCBdatetime_sale.ReadOnly = True
        Me.txtCCBdatetime_sale.Size = New System.Drawing.Size(133, 20)
        Me.txtCCBdatetime_sale.TabIndex = 64
        '
        'txtCCBunit
        '
        Me.txtCCBunit.Location = New System.Drawing.Point(357, 116)
        Me.txtCCBunit.Name = "txtCCBunit"
        Me.txtCCBunit.ReadOnly = True
        Me.txtCCBunit.Size = New System.Drawing.Size(57, 20)
        Me.txtCCBunit.TabIndex = 63
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(301, 119)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "หน่วยนับ"
        '
        'txtCCBtype
        '
        Me.txtCCBtype.Location = New System.Drawing.Point(204, 116)
        Me.txtCCBtype.Name = "txtCCBtype"
        Me.txtCCBtype.ReadOnly = True
        Me.txtCCBtype.Size = New System.Drawing.Size(91, 20)
        Me.txtCCBtype.TabIndex = 61
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(128, 119)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "ประเภทสินค้า"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 119)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "ราคาสินค้า"
        '
        'txtCCBprice_buy
        '
        Me.txtCCBprice_buy.Location = New System.Drawing.Point(65, 116)
        Me.txtCCBprice_buy.Name = "txtCCBprice_buy"
        Me.txtCCBprice_buy.ReadOnly = True
        Me.txtCCBprice_buy.Size = New System.Drawing.Size(57, 20)
        Me.txtCCBprice_buy.TabIndex = 58
        '
        'txtCCBname_pro
        '
        Me.txtCCBname_pro.Location = New System.Drawing.Point(65, 90)
        Me.txtCCBname_pro.Name = "txtCCBname_pro"
        Me.txtCCBname_pro.ReadOnly = True
        Me.txtCCBname_pro.Size = New System.Drawing.Size(349, 20)
        Me.txtCCBname_pro.TabIndex = 57
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "ชื่อสินค้า"
        '
        'txtCCBbar_code
        '
        Me.txtCCBbar_code.Location = New System.Drawing.Point(268, 64)
        Me.txtCCBbar_code.Name = "txtCCBbar_code"
        Me.txtCCBbar_code.ReadOnly = True
        Me.txtCCBbar_code.Size = New System.Drawing.Size(146, 20)
        Me.txtCCBbar_code.TabIndex = 55
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(217, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "บาร์โค๊ต"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "รหัสสินค้า"
        '
        'txtCCBcode_pro
        '
        Me.txtCCBcode_pro.Location = New System.Drawing.Point(65, 64)
        Me.txtCCBcode_pro.Name = "txtCCBcode_pro"
        Me.txtCCBcode_pro.ReadOnly = True
        Me.txtCCBcode_pro.Size = New System.Drawing.Size(146, 20)
        Me.txtCCBcode_pro.TabIndex = 52
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(217, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "ชื่อลูกค้า"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "รหัสลูกค้า"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "รหัสเคลม"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(217, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "SN"
        '
        'txtCCBsn
        '
        Me.txtCCBsn.Location = New System.Drawing.Point(268, 12)
        Me.txtCCBsn.Name = "txtCCBsn"
        Me.txtCCBsn.ReadOnly = True
        Me.txtCCBsn.Size = New System.Drawing.Size(146, 20)
        Me.txtCCBsn.TabIndex = 47
        '
        'txtCCBcus_name
        '
        Me.txtCCBcus_name.Location = New System.Drawing.Point(268, 38)
        Me.txtCCBcus_name.Name = "txtCCBcus_name"
        Me.txtCCBcus_name.ReadOnly = True
        Me.txtCCBcus_name.Size = New System.Drawing.Size(146, 20)
        Me.txtCCBcus_name.TabIndex = 46
        '
        'txtCCBcus_id
        '
        Me.txtCCBcus_id.Location = New System.Drawing.Point(65, 38)
        Me.txtCCBcus_id.Name = "txtCCBcus_id"
        Me.txtCCBcus_id.ReadOnly = True
        Me.txtCCBcus_id.Size = New System.Drawing.Size(146, 20)
        Me.txtCCBcus_id.TabIndex = 45
        '
        'txtCCBclaims_id
        '
        Me.txtCCBclaims_id.Location = New System.Drawing.Point(65, 12)
        Me.txtCCBclaims_id.Name = "txtCCBclaims_id"
        Me.txtCCBclaims_id.ReadOnly = True
        Me.txtCCBclaims_id.Size = New System.Drawing.Size(146, 20)
        Me.txtCCBclaims_id.TabIndex = 44
        '
        'lblEmployee
        '
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(30, 17)
        Me.lblEmployee.Text = "User"
        '
        'ClaimsComfixBackFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 318)
        Me.Controls.Add(Me.btnCCBsave)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtCCBcus_tel)
        Me.Controls.Add(Me.txtCCBprice_fix)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.cbbCCBtel_to_cus)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtCCBnote)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtCCBaccessory)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtCCBsyptom)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtCCBemployee_sale)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtCCBdatetime_sale)
        Me.Controls.Add(Me.txtCCBunit)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtCCBtype)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCCBprice_buy)
        Me.Controls.Add(Me.txtCCBname_pro)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCCBbar_code)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCCBcode_pro)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCCBsn)
        Me.Controls.Add(Me.txtCCBcus_name)
        Me.Controls.Add(Me.txtCCBcus_id)
        Me.Controls.Add(Me.txtCCBclaims_id)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ClaimsComfixBackFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รับสินค้าจากงานช่างเข้าระบบเคลม"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents btnCCBsave As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtCCBcus_tel As System.Windows.Forms.TextBox
    Friend WithEvents txtCCBprice_fix As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cbbCCBtel_to_cus As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCCBnote As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCCBaccessory As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCCBsyptom As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCCBemployee_sale As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCCBdatetime_sale As System.Windows.Forms.TextBox
    Friend WithEvents txtCCBunit As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCCBtype As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCCBprice_buy As System.Windows.Forms.TextBox
    Friend WithEvents txtCCBname_pro As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCCBbar_code As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCCBcode_pro As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCCBsn As System.Windows.Forms.TextBox
    Friend WithEvents txtCCBcus_name As System.Windows.Forms.TextBox
    Friend WithEvents txtCCBcus_id As System.Windows.Forms.TextBox
    Friend WithEvents txtCCBclaims_id As System.Windows.Forms.TextBox
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
End Class
