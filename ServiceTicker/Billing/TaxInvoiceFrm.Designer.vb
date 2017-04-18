<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaxInvoiceFrm
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnTIsearchOldBill = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnTIsearchBarcode = New System.Windows.Forms.Button()
        Me.txtTIsearchBarcode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTIbillID = New System.Windows.Forms.TextBox()
        Me.cbbTIselectbill = New System.Windows.Forms.ComboBox()
        Me.btnTIsearchCus = New System.Windows.Forms.Button()
        Me.btnTIserachBill = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTIsearchBillID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTIcustel = New System.Windows.Forms.TextBox()
        Me.txtTIcusaddress = New System.Windows.Forms.TextBox()
        Me.txtTIcusname = New System.Windows.Forms.TextBox()
        Me.txtTIcusid = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnTaxinEx = New System.Windows.Forms.Button()
        Me.txtRefer = New System.Windows.Forms.TextBox()
        Me.lblRefer = New System.Windows.Forms.Label()
        Me.lblDateCadit = New System.Windows.Forms.Label()
        Me.cbbDateCadit = New System.Windows.Forms.ComboBox()
        Me.cbDateSend = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.cbTIdiscount = New System.Windows.Forms.CheckBox()
        Me.cbTItexpro = New System.Windows.Forms.CheckBox()
        Me.cbTI = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cbbExDay = New System.Windows.Forms.ComboBox()
        Me.lblExDay = New System.Windows.Forms.Label()
        Me.lblTItaxpercen = New System.Windows.Forms.Label()
        Me.txtTItaxpercen = New System.Windows.Forms.TextBox()
        Me.rbTIuntax = New System.Windows.Forms.RadioButton()
        Me.rbTItotaltax = New System.Windows.Forms.RadioButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTItahitext = New System.Windows.Forms.TextBox()
        Me.txtTItotalAll = New System.Windows.Forms.TextBox()
        Me.txtTItotalTax = New System.Windows.Forms.TextBox()
        Me.txtTItotal = New System.Windows.Forms.TextBox()
        Me.txtTIdiscount1 = New System.Windows.Forms.TextBox()
        Me.txtTItotalPro = New System.Windows.Forms.TextBox()
        Me.cbTaxUpdate = New System.Windows.Forms.CheckBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnTIcancel = New System.Windows.Forms.Button()
        Me.btnTIsavePrint = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTItaxSection = New System.Windows.Forms.TextBox()
        Me.txtTItaxNumber = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTInote = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgTI = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_all = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgTI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.btnHelp})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.TabIndex = 3
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
        Me.btnHelp.AutoToolTip = True
        Me.btnHelp.Image = Global.ServiceTicker.My.Resources.Resources._109_AllAnnotations_Help_16x16_72
        Me.btnHelp.IsLink = True
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(16, 17)
        Me.btnHelp.ToolTipText = "Help"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnTIsearchOldBill)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.btnTIsearchBarcode)
        Me.Panel1.Controls.Add(Me.txtTIsearchBarcode)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtTIbillID)
        Me.Panel1.Controls.Add(Me.cbbTIselectbill)
        Me.Panel1.Controls.Add(Me.btnTIsearchCus)
        Me.Panel1.Controls.Add(Me.btnTIserachBill)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtTIsearchBillID)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtTIcustel)
        Me.Panel1.Controls.Add(Me.txtTIcusaddress)
        Me.Panel1.Controls.Add(Me.txtTIcusname)
        Me.Panel1.Controls.Add(Me.txtTIcusid)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 152)
        Me.Panel1.TabIndex = 1
        '
        'btnTIsearchOldBill
        '
        Me.btnTIsearchOldBill.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTIsearchOldBill.Location = New System.Drawing.Point(526, 67)
        Me.btnTIsearchOldBill.Name = "btnTIsearchOldBill"
        Me.btnTIsearchOldBill.Size = New System.Drawing.Size(255, 23)
        Me.btnTIsearchOldBill.TabIndex = 4
        Me.btnTIsearchOldBill.Text = "ค้นหาใบเสร็จ"
        Me.ToolTip1.SetToolTip(Me.btnTIsearchOldBill, "ค้นหาใบเสร็จที่เคยออกไปแล้ว")
        Me.btnTIsearchOldBill.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(614, 136)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(170, 16)
        Me.Label18.TabIndex = 67
        Me.Label18.Text = "ใช้ปุ่ม Delete เพื่อลบรายการสินค้า"
        '
        'btnTIsearchBarcode
        '
        Me.btnTIsearchBarcode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTIsearchBarcode.Location = New System.Drawing.Point(723, 95)
        Me.btnTIsearchBarcode.Name = "btnTIsearchBarcode"
        Me.btnTIsearchBarcode.Size = New System.Drawing.Size(58, 23)
        Me.btnTIsearchBarcode.TabIndex = 6
        Me.btnTIsearchBarcode.Text = "ค้นหา"
        Me.ToolTip1.SetToolTip(Me.btnTIsearchBarcode, "ค้นหารายการสินค้า")
        Me.btnTIsearchBarcode.UseVisualStyleBackColor = True
        '
        'txtTIsearchBarcode
        '
        Me.txtTIsearchBarcode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTIsearchBarcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTIsearchBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTIsearchBarcode.Location = New System.Drawing.Point(544, 94)
        Me.txtTIsearchBarcode.Name = "txtTIsearchBarcode"
        Me.txtTIsearchBarcode.Size = New System.Drawing.Size(173, 26)
        Me.txtTIsearchBarcode.TabIndex = 5
        Me.txtTIsearchBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtTIsearchBarcode, "ค้นหาชื่อสินค้าจากบาร์โค๊ตสินค้า")
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(422, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 20)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "ป้อนบาร์โค๊ตสินค้า"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(439, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "ชนิดใบเสร็จ"
        '
        'txtTIbillID
        '
        Me.txtTIbillID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTIbillID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTIbillID.Location = New System.Drawing.Point(526, 37)
        Me.txtTIbillID.Name = "txtTIbillID"
        Me.txtTIbillID.Size = New System.Drawing.Size(255, 26)
        Me.txtTIbillID.TabIndex = 61
        Me.txtTIbillID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbbTIselectbill
        '
        Me.cbbTIselectbill.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbTIselectbill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbTIselectbill.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbbTIselectbill.FormattingEnabled = True
        Me.cbbTIselectbill.Location = New System.Drawing.Point(526, 3)
        Me.cbbTIselectbill.Name = "cbbTIselectbill"
        Me.cbbTIselectbill.Size = New System.Drawing.Size(255, 28)
        Me.cbbTIselectbill.TabIndex = 3
        '
        'btnTIsearchCus
        '
        Me.btnTIsearchCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnTIsearchCus.Location = New System.Drawing.Point(2, 3)
        Me.btnTIsearchCus.Name = "btnTIsearchCus"
        Me.btnTIsearchCus.Size = New System.Drawing.Size(78, 23)
        Me.btnTIsearchCus.TabIndex = 0
        Me.btnTIsearchCus.Text = "รหัสลูกค้า"
        Me.ToolTip1.SetToolTip(Me.btnTIsearchCus, "ค้นหาข้อมูลชื่อที่อยู่ลูกค้า")
        Me.btnTIsearchCus.UseVisualStyleBackColor = True
        '
        'btnTIserachBill
        '
        Me.btnTIserachBill.Location = New System.Drawing.Point(323, 124)
        Me.btnTIserachBill.Name = "btnTIserachBill"
        Me.btnTIserachBill.Size = New System.Drawing.Size(93, 23)
        Me.btnTIserachBill.TabIndex = 2
        Me.btnTIserachBill.Text = "ค้นหา"
        Me.ToolTip1.SetToolTip(Me.btnTIserachBill, "ค้นหา การขาย เบิกอะไหล่")
        Me.btnTIserachBill.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 20)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "เลขที่เอกสาร"
        '
        'txtTIsearchBillID
        '
        Me.txtTIsearchBillID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTIsearchBillID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTIsearchBillID.Location = New System.Drawing.Point(105, 121)
        Me.txtTIsearchBillID.Name = "txtTIsearchBillID"
        Me.txtTIsearchBillID.Size = New System.Drawing.Size(212, 26)
        Me.txtTIsearchBillID.TabIndex = 1
        Me.txtTIsearchBillID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtTIsearchBillID, "ค้นหารายการสินค้าจากหมายเลขบิลขาย/เบิกอะไล่")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "เบอร์โทร"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "ที่อยู่"
        '
        'txtTIcustel
        '
        Me.txtTIcustel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTIcustel.Location = New System.Drawing.Point(80, 89)
        Me.txtTIcustel.Name = "txtTIcustel"
        Me.txtTIcustel.Size = New System.Drawing.Size(336, 26)
        Me.txtTIcustel.TabIndex = 53
        '
        'txtTIcusaddress
        '
        Me.txtTIcusaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTIcusaddress.Location = New System.Drawing.Point(80, 28)
        Me.txtTIcusaddress.Multiline = True
        Me.txtTIcusaddress.Name = "txtTIcusaddress"
        Me.txtTIcusaddress.Size = New System.Drawing.Size(336, 62)
        Me.txtTIcusaddress.TabIndex = 52
        '
        'txtTIcusname
        '
        Me.txtTIcusname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTIcusname.Location = New System.Drawing.Point(199, 3)
        Me.txtTIcusname.Name = "txtTIcusname"
        Me.txtTIcusname.Size = New System.Drawing.Size(217, 26)
        Me.txtTIcusname.TabIndex = 51
        '
        'txtTIcusid
        '
        Me.txtTIcusid.BackColor = System.Drawing.Color.Moccasin
        Me.txtTIcusid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTIcusid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTIcusid.Location = New System.Drawing.Point(80, 3)
        Me.txtTIcusid.Name = "txtTIcusid"
        Me.txtTIcusid.Size = New System.Drawing.Size(120, 26)
        Me.txtTIcusid.TabIndex = 50
        Me.txtTIcusid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnTaxinEx)
        Me.Panel2.Controls.Add(Me.txtRefer)
        Me.Panel2.Controls.Add(Me.lblRefer)
        Me.Panel2.Controls.Add(Me.lblDateCadit)
        Me.Panel2.Controls.Add(Me.cbbDateCadit)
        Me.Panel2.Controls.Add(Me.cbDateSend)
        Me.Panel2.Controls.Add(Me.DateTimePicker2)
        Me.Panel2.Controls.Add(Me.cbTIdiscount)
        Me.Panel2.Controls.Add(Me.cbTItexpro)
        Me.Panel2.Controls.Add(Me.cbTI)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.cbbExDay)
        Me.Panel2.Controls.Add(Me.lblExDay)
        Me.Panel2.Controls.Add(Me.lblTItaxpercen)
        Me.Panel2.Controls.Add(Me.txtTItaxpercen)
        Me.Panel2.Controls.Add(Me.rbTIuntax)
        Me.Panel2.Controls.Add(Me.rbTItotaltax)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtTItahitext)
        Me.Panel2.Controls.Add(Me.txtTItotalAll)
        Me.Panel2.Controls.Add(Me.txtTItotalTax)
        Me.Panel2.Controls.Add(Me.txtTItotal)
        Me.Panel2.Controls.Add(Me.txtTIdiscount1)
        Me.Panel2.Controls.Add(Me.txtTItotalPro)
        Me.Panel2.Controls.Add(Me.cbTaxUpdate)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.btnTIcancel)
        Me.Panel2.Controls.Add(Me.btnTIsavePrint)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.txtTItaxSection)
        Me.Panel2.Controls.Add(Me.txtTItaxNumber)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtTInote)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 359)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 180)
        Me.Panel2.TabIndex = 2
        '
        'btnTaxinEx
        '
        Me.btnTaxinEx.Location = New System.Drawing.Point(519, 26)
        Me.btnTaxinEx.Name = "btnTaxinEx"
        Me.btnTaxinEx.Size = New System.Drawing.Size(48, 23)
        Me.btnTaxinEx.TabIndex = 93
        Me.btnTaxinEx.Text = "นอก"
        Me.ToolTip1.SetToolTip(Me.btnTaxinEx, "คำนวนแบบภาษีภายนอกหรือใน")
        Me.btnTaxinEx.UseVisualStyleBackColor = True
        '
        'txtRefer
        '
        Me.txtRefer.Location = New System.Drawing.Point(55, 5)
        Me.txtRefer.Name = "txtRefer"
        Me.txtRefer.Size = New System.Drawing.Size(252, 20)
        Me.txtRefer.TabIndex = 92
        Me.txtRefer.Visible = False
        '
        'lblRefer
        '
        Me.lblRefer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRefer.AutoSize = True
        Me.lblRefer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblRefer.Location = New System.Drawing.Point(3, 3)
        Me.lblRefer.Name = "lblRefer"
        Me.lblRefer.Size = New System.Drawing.Size(46, 20)
        Me.lblRefer.TabIndex = 91
        Me.lblRefer.Text = "อ้างอิง"
        Me.lblRefer.Visible = False
        '
        'lblDateCadit
        '
        Me.lblDateCadit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDateCadit.AutoSize = True
        Me.lblDateCadit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblDateCadit.Location = New System.Drawing.Point(299, 105)
        Me.lblDateCadit.Name = "lblDateCadit"
        Me.lblDateCadit.Size = New System.Drawing.Size(105, 20)
        Me.lblDateCadit.TabIndex = 90
        Me.lblDateCadit.Text = "จำนวนวันเครดิต"
        Me.lblDateCadit.Visible = False
        '
        'cbbDateCadit
        '
        Me.cbbDateCadit.FormattingEnabled = True
        Me.cbbDateCadit.Items.AddRange(New Object() {"-", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "108", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "211", "212", "213", "214", "215", "216", "217", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242", "243", "244", "245", "246", "247", "248", "249", "250", "251", "252", "253", "254", "255", "256", "257", "258", "259", "260", "261", "262", "263", "264", "265", "266", "267", "268", "269", "270", "271", "272", "273", "274", "275", "276", "277", "278", "279", "280", "281", "282", "283", "284", "285", "286", "287", "288", "289", "290", "291", "292", "293", "294", "295", "296", "297", "298", "299", "300", "301", "302", "303", "304", "305", "306", "307", "308", "309", "310", "311", "312", "313", "314", "315", "316", "317", "318", "319", "320", "321", "322", "323", "324", "325", "326", "327", "328", "329", "330", "331", "332", "333", "334", "335", "336", "337", "338", "339", "340", "341", "342", "343", "344", "345", "346", "347", "348", "349", "350", "351", "352", "353", "354", "355", "356", "357", "358", "359", "360", "361", "362", "363", "364", "365"})
        Me.cbbDateCadit.Location = New System.Drawing.Point(410, 107)
        Me.cbbDateCadit.Name = "cbbDateCadit"
        Me.cbbDateCadit.Size = New System.Drawing.Size(121, 21)
        Me.cbbDateCadit.TabIndex = 89
        Me.cbbDateCadit.Visible = False
        '
        'cbDateSend
        '
        Me.cbDateSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbDateSend.AutoSize = True
        Me.cbDateSend.Location = New System.Drawing.Point(327, 49)
        Me.cbDateSend.Name = "cbDateSend"
        Me.cbDateSend.Size = New System.Drawing.Size(92, 17)
        Me.cbDateSend.TabIndex = 88
        Me.cbDateSend.Text = "วันที่กำหนดส่ง"
        Me.cbDateSend.UseVisualStyleBackColor = True
        Me.cbDateSend.Visible = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Location = New System.Drawing.Point(327, 72)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(240, 20)
        Me.DateTimePicker2.TabIndex = 87
        Me.DateTimePicker2.Visible = False
        '
        'cbTIdiscount
        '
        Me.cbTIdiscount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTIdiscount.AutoSize = True
        Me.cbTIdiscount.Checked = True
        Me.cbTIdiscount.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbTIdiscount.Location = New System.Drawing.Point(405, 3)
        Me.cbTIdiscount.Name = "cbTIdiscount"
        Me.cbTIdiscount.Size = New System.Drawing.Size(85, 17)
        Me.cbTIdiscount.TabIndex = 6
        Me.cbTIdiscount.Text = "แสดงส่วนลด"
        Me.cbTIdiscount.UseVisualStyleBackColor = True
        Me.cbTIdiscount.Visible = False
        '
        'cbTItexpro
        '
        Me.cbTItexpro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTItexpro.AutoSize = True
        Me.cbTItexpro.Location = New System.Drawing.Point(327, 3)
        Me.cbTItexpro.Name = "cbTItexpro"
        Me.cbTItexpro.Size = New System.Drawing.Size(72, 17)
        Me.cbTItexpro.TabIndex = 7
        Me.cbTItexpro.Text = "แสดงภาษี"
        Me.cbTItexpro.UseVisualStyleBackColor = True
        Me.cbTItexpro.Visible = False
        '
        'cbTI
        '
        Me.cbTI.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTI.AutoSize = True
        Me.cbTI.Checked = True
        Me.cbTI.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbTI.Location = New System.Drawing.Point(496, 3)
        Me.cbTI.Name = "cbTI"
        Me.cbTI.Size = New System.Drawing.Size(58, 17)
        Me.cbTI.TabIndex = 5
        Me.cbTI.Text = "ลงวันที่"
        Me.cbTI.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(560, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(221, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'cbbExDay
        '
        Me.cbbExDay.FormattingEnabled = True
        Me.cbbExDay.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "108", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "211", "212", "213", "214", "215", "216", "217", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242", "243", "244", "245", "246", "247", "248", "249", "250", "251", "252", "253", "254", "255", "256", "257", "258", "259", "260", "261", "262", "263", "264", "265", "266", "267", "268", "269", "270", "271", "272", "273", "274", "275", "276", "277", "278", "279", "280", "281", "282", "283", "284", "285", "286", "287", "288", "289", "290", "291", "292", "293", "294", "295", "296", "297", "298", "299", "300", "301", "302", "303", "304", "305", "306", "307", "308", "309", "310", "311", "312", "313", "314", "315", "316", "317", "318", "319", "320", "321", "322", "323", "324", "325", "326", "327", "328", "329", "330", "331", "332", "333", "334", "335", "336", "337", "338", "339", "340", "341", "342", "343", "344", "345", "346", "347", "348", "349", "350", "351", "352", "353", "354", "355", "356", "357", "358", "359", "360", "361", "362", "363", "364", "365"})
        Me.cbbExDay.Location = New System.Drawing.Point(135, 5)
        Me.cbbExDay.Name = "cbbExDay"
        Me.cbbExDay.Size = New System.Drawing.Size(121, 21)
        Me.cbbExDay.TabIndex = 86
        Me.cbbExDay.Visible = False
        '
        'lblExDay
        '
        Me.lblExDay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblExDay.AutoSize = True
        Me.lblExDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblExDay.Location = New System.Drawing.Point(3, 3)
        Me.lblExDay.Name = "lblExDay"
        Me.lblExDay.Size = New System.Drawing.Size(126, 20)
        Me.lblExDay.TabIndex = 85
        Me.lblExDay.Text = "ยื่นราคาภายใน(วัน) "
        Me.lblExDay.Visible = False
        '
        'lblTItaxpercen
        '
        Me.lblTItaxpercen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTItaxpercen.AutoSize = True
        Me.lblTItaxpercen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTItaxpercen.Location = New System.Drawing.Point(493, 26)
        Me.lblTItaxpercen.Name = "lblTItaxpercen"
        Me.lblTItaxpercen.Size = New System.Drawing.Size(23, 20)
        Me.lblTItaxpercen.TabIndex = 83
        Me.lblTItaxpercen.Text = "%"
        Me.lblTItaxpercen.Visible = False
        '
        'txtTItaxpercen
        '
        Me.txtTItaxpercen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTItaxpercen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTItaxpercen.Location = New System.Drawing.Point(449, 24)
        Me.txtTItaxpercen.Name = "txtTItaxpercen"
        Me.txtTItaxpercen.Size = New System.Drawing.Size(38, 24)
        Me.txtTItaxpercen.TabIndex = 11
        Me.txtTItaxpercen.Text = "0"
        Me.txtTItaxpercen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTItaxpercen.Visible = False
        '
        'rbTIuntax
        '
        Me.rbTIuntax.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbTIuntax.AutoSize = True
        Me.rbTIuntax.Checked = True
        Me.rbTIuntax.Location = New System.Drawing.Point(320, 29)
        Me.rbTIuntax.Name = "rbTIuntax"
        Me.rbTIuntax.Size = New System.Drawing.Size(65, 17)
        Me.rbTIuntax.TabIndex = 12
        Me.rbTIuntax.TabStop = True
        Me.rbTIuntax.Text = "ไม่มีภาษี"
        Me.rbTIuntax.UseVisualStyleBackColor = True
        Me.rbTIuntax.Visible = False
        '
        'rbTItotaltax
        '
        Me.rbTItotaltax.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbTItotaltax.AutoSize = True
        Me.rbTItotaltax.Location = New System.Drawing.Point(391, 29)
        Me.rbTItotaltax.Name = "rbTItotaltax"
        Me.rbTItotaltax.Size = New System.Drawing.Size(52, 17)
        Me.rbTItotaltax.TabIndex = 10
        Me.rbTItotaltax.Text = "มีภาษี"
        Me.rbTItotaltax.UseVisualStyleBackColor = True
        Me.rbTItotaltax.Visible = False
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(311, 127)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(101, 16)
        Me.Label16.TabIndex = 77
        Me.Label16.Text = "จำนวนเงิน(ตัวอักษร)"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(571, 127)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 20)
        Me.Label13.TabIndex = 76
        Me.Label13.Text = "ยอดสุทธิ"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(537, 102)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 20)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "ภาษีมูลค่าเพิ่ม"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(573, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 20)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "ยอดเงิน"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(581, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 20)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "ส่วนลด"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(573, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 20)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "ค่าสินค้า"
        '
        'txtTItahitext
        '
        Me.txtTItahitext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTItahitext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTItahitext.Location = New System.Drawing.Point(314, 149)
        Me.txtTItahitext.Name = "txtTItahitext"
        Me.txtTItahitext.ReadOnly = True
        Me.txtTItahitext.Size = New System.Drawing.Size(467, 26)
        Me.txtTItahitext.TabIndex = 71
        Me.txtTItahitext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTItotalAll
        '
        Me.txtTItotalAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTItotalAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTItotalAll.Location = New System.Drawing.Point(637, 124)
        Me.txtTItotalAll.Name = "txtTItotalAll"
        Me.txtTItotalAll.ReadOnly = True
        Me.txtTItotalAll.Size = New System.Drawing.Size(144, 26)
        Me.txtTItotalAll.TabIndex = 70
        Me.txtTItotalAll.Text = "0"
        Me.txtTItotalAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTItotalTax
        '
        Me.txtTItotalTax.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTItotalTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTItotalTax.Location = New System.Drawing.Point(637, 99)
        Me.txtTItotalTax.Name = "txtTItotalTax"
        Me.txtTItotalTax.ReadOnly = True
        Me.txtTItotalTax.Size = New System.Drawing.Size(144, 26)
        Me.txtTItotalTax.TabIndex = 69
        Me.txtTItotalTax.Text = "0"
        Me.txtTItotalTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTItotal
        '
        Me.txtTItotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTItotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTItotal.Location = New System.Drawing.Point(637, 74)
        Me.txtTItotal.Name = "txtTItotal"
        Me.txtTItotal.ReadOnly = True
        Me.txtTItotal.Size = New System.Drawing.Size(144, 26)
        Me.txtTItotal.TabIndex = 68
        Me.txtTItotal.Text = "0"
        Me.txtTItotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTIdiscount1
        '
        Me.txtTIdiscount1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTIdiscount1.BackColor = System.Drawing.SystemColors.Control
        Me.txtTIdiscount1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTIdiscount1.Location = New System.Drawing.Point(637, 49)
        Me.txtTIdiscount1.Name = "txtTIdiscount1"
        Me.txtTIdiscount1.ReadOnly = True
        Me.txtTIdiscount1.Size = New System.Drawing.Size(144, 26)
        Me.txtTIdiscount1.TabIndex = 67
        Me.txtTIdiscount1.Text = "0"
        Me.txtTIdiscount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTItotalPro
        '
        Me.txtTItotalPro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTItotalPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTItotalPro.Location = New System.Drawing.Point(637, 24)
        Me.txtTItotalPro.Name = "txtTItotalPro"
        Me.txtTItotalPro.ReadOnly = True
        Me.txtTItotalPro.Size = New System.Drawing.Size(144, 26)
        Me.txtTItotalPro.TabIndex = 66
        Me.txtTItotalPro.Text = "0"
        Me.txtTItotalPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbTaxUpdate
        '
        Me.cbTaxUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbTaxUpdate.AutoSize = True
        Me.cbTaxUpdate.Location = New System.Drawing.Point(102, 59)
        Me.cbTaxUpdate.Name = "cbTaxUpdate"
        Me.cbTaxUpdate.Size = New System.Drawing.Size(219, 17)
        Me.cbTaxUpdate.TabIndex = 4
        Me.cbTaxUpdate.Text = "บันทึกข้อมูลผู้เสียภาษีไปยังฐานข้อมูลลูกค้า"
        Me.ToolTip1.SetToolTip(Me.cbTaxUpdate, "กำหนดให้บันทึกแทนที่หมายเลขผู้เสียภาษีลงในฐานข้อมูลลูกค้า")
        Me.cbTaxUpdate.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(4, 109)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(224, 16)
        Me.Label17.TabIndex = 62
        Me.Label17.Text = "ขนาดเอกสาร A4 โปรดเตรียมกระดาษให้ถูกต้อง"
        '
        'btnTIcancel
        '
        Me.btnTIcancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTIcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnTIcancel.Location = New System.Drawing.Point(149, 139)
        Me.btnTIcancel.Name = "btnTIcancel"
        Me.btnTIcancel.Size = New System.Drawing.Size(140, 38)
        Me.btnTIcancel.TabIndex = 14
        Me.btnTIcancel.Text = "ยกเลิก"
        Me.btnTIcancel.UseVisualStyleBackColor = True
        '
        'btnTIsavePrint
        '
        Me.btnTIsavePrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTIsavePrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnTIsavePrint.Location = New System.Drawing.Point(3, 139)
        Me.btnTIsavePrint.Name = "btnTIsavePrint"
        Me.btnTIsavePrint.Size = New System.Drawing.Size(140, 38)
        Me.btnTIsavePrint.TabIndex = 13
        Me.btnTIsavePrint.Text = "บันทึก/พิมพ์"
        Me.btnTIsavePrint.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(2, 58)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 16)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = "เลขผู้เสียภาษี(ลูกค้า)"
        '
        'txtTItaxSection
        '
        Me.txtTItaxSection.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTItaxSection.BackColor = System.Drawing.Color.Moccasin
        Me.txtTItaxSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTItaxSection.Location = New System.Drawing.Point(169, 77)
        Me.txtTItaxSection.Name = "txtTItaxSection"
        Me.txtTItaxSection.Size = New System.Drawing.Size(138, 26)
        Me.txtTItaxSection.TabIndex = 3
        Me.txtTItaxSection.Text = "สำนักงานใหญ่"
        '
        'txtTItaxNumber
        '
        Me.txtTItaxNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTItaxNumber.BackColor = System.Drawing.Color.Moccasin
        Me.txtTItaxNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTItaxNumber.Location = New System.Drawing.Point(2, 77)
        Me.txtTItaxNumber.Name = "txtTItaxNumber"
        Me.txtTItaxNumber.Size = New System.Drawing.Size(168, 26)
        Me.txtTItaxNumber.TabIndex = 2
        Me.txtTItaxNumber.Text = "0"
        Me.txtTItaxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(-1, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 20)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "หมายเหตุ"
        '
        'txtTInote
        '
        Me.txtTInote.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTInote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTInote.Location = New System.Drawing.Point(72, 29)
        Me.txtTInote.Name = "txtTInote"
        Me.txtTInote.Size = New System.Drawing.Size(235, 26)
        Me.txtTInote.TabIndex = 1
        Me.txtTInote.Text = "-"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgTI)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 152)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(784, 207)
        Me.Panel3.TabIndex = 3
        '
        'dgTI
        '
        Me.dgTI.AllowUserToAddRows = False
        Me.dgTI.AllowUserToDeleteRows = False
        Me.dgTI.AllowUserToOrderColumns = True
        Me.dgTI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTI.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.code_pro, Me.name_pro, Me.total, Me.unit, Me.price_buy, Me.discount, Me.total_all})
        Me.dgTI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTI.Location = New System.Drawing.Point(0, 0)
        Me.dgTI.Name = "dgTI"
        Me.dgTI.RowHeadersVisible = False
        Me.dgTI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTI.Size = New System.Drawing.Size(784, 207)
        Me.dgTI.TabIndex = 0
        '
        'no
        '
        Me.no.DataPropertyName = "no"
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.White
        Me.no.DefaultCellStyle = DataGridViewCellStyle13
        Me.no.Frozen = True
        Me.no.HeaderText = "#"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.Width = 30
        '
        'code_pro
        '
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        Me.code_pro.DefaultCellStyle = DataGridViewCellStyle14
        Me.code_pro.Frozen = True
        Me.code_pro.HeaderText = "รหัสสินค้า"
        Me.code_pro.Name = "code_pro"
        Me.code_pro.ReadOnly = True
        Me.code_pro.Width = 140
        '
        'name_pro
        '
        Me.name_pro.DataPropertyName = "name_pro"
        Me.name_pro.HeaderText = "รายละเอียด"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro.Width = 300
        '
        'total
        '
        Me.total.DataPropertyName = "total"
        DataGridViewCellStyle15.Format = "N0"
        DataGridViewCellStyle15.NullValue = "0"
        Me.total.DefaultCellStyle = DataGridViewCellStyle15
        Me.total.HeaderText = "จำนวน"
        Me.total.Name = "total"
        Me.total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total.Width = 80
        '
        'unit
        '
        Me.unit.DataPropertyName = "unit"
        Me.unit.HeaderText = "หน่วยนับ"
        Me.unit.Name = "unit"
        Me.unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.unit.Width = 80
        '
        'price_buy
        '
        Me.price_buy.DataPropertyName = "price_buy"
        DataGridViewCellStyle16.Format = "N2"
        DataGridViewCellStyle16.NullValue = "0"
        Me.price_buy.DefaultCellStyle = DataGridViewCellStyle16
        Me.price_buy.HeaderText = "ราคา/หน่วย"
        Me.price_buy.Name = "price_buy"
        Me.price_buy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_buy.Width = 80
        '
        'discount
        '
        DataGridViewCellStyle17.Format = "N2"
        DataGridViewCellStyle17.NullValue = "0"
        Me.discount.DefaultCellStyle = DataGridViewCellStyle17
        Me.discount.HeaderText = "ส่วนลด"
        Me.discount.Name = "discount"
        Me.discount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'total_all
        '
        Me.total_all.DataPropertyName = "total_all"
        DataGridViewCellStyle18.Format = "N2"
        DataGridViewCellStyle18.NullValue = "0"
        Me.total_all.DefaultCellStyle = DataGridViewCellStyle18
        Me.total_all.HeaderText = "รวมเงิน"
        Me.total_all.Name = "total_all"
        Me.total_all.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_all.Width = 80
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(426, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 23)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "New Number >"
        Me.ToolTip1.SetToolTip(Me.Button1, "สร้างหมายเลขเอกสารใหม่")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TaxInvoiceFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "TaxInvoiceFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ออกใบกำกับภาษี/ใบส่งของ/ใบเสนอราคา"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgTI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnTIsearchOldBill As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnTIsearchBarcode As System.Windows.Forms.Button
    Friend WithEvents txtTIsearchBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTIbillID As System.Windows.Forms.TextBox
    Friend WithEvents cbbTIselectbill As System.Windows.Forms.ComboBox
    Friend WithEvents btnTIsearchCus As System.Windows.Forms.Button
    Friend WithEvents btnTIserachBill As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTIsearchBillID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTIcustel As System.Windows.Forms.TextBox
    Friend WithEvents txtTIcusaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtTIcusname As System.Windows.Forms.TextBox
    Friend WithEvents txtTIcusid As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cbTItexpro As System.Windows.Forms.CheckBox
    Friend WithEvents cbTIdiscount As System.Windows.Forms.CheckBox
    Friend WithEvents lblTItaxpercen As System.Windows.Forms.Label
    Friend WithEvents txtTItaxpercen As System.Windows.Forms.TextBox
    Friend WithEvents rbTIuntax As System.Windows.Forms.RadioButton
    Friend WithEvents rbTItotaltax As System.Windows.Forms.RadioButton
    Friend WithEvents cbTI As System.Windows.Forms.CheckBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTItahitext As System.Windows.Forms.TextBox
    Friend WithEvents txtTItotalAll As System.Windows.Forms.TextBox
    Friend WithEvents txtTItotalTax As System.Windows.Forms.TextBox
    Friend WithEvents txtTItotal As System.Windows.Forms.TextBox
    Friend WithEvents txtTIdiscount1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTItotalPro As System.Windows.Forms.TextBox
    Friend WithEvents cbTaxUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnTIcancel As System.Windows.Forms.Button
    Friend WithEvents btnTIsavePrint As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtTItaxSection As System.Windows.Forms.TextBox
    Friend WithEvents txtTItaxNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTInote As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgTI As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents discount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_all As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblExDay As System.Windows.Forms.Label
    Friend WithEvents cbbExDay As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbDateSend As System.Windows.Forms.CheckBox
    Friend WithEvents lblDateCadit As System.Windows.Forms.Label
    Friend WithEvents cbbDateCadit As System.Windows.Forms.ComboBox
    Friend WithEvents txtRefer As System.Windows.Forms.TextBox
    Friend WithEvents lblRefer As System.Windows.Forms.Label
    Friend WithEvents btnTaxinEx As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
