<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaimsFrm
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtCFprice_members = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtCFprice_loyal = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtCFprice_technician = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtCFprice_wholsale = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCFemployee_sale = New System.Windows.Forms.TextBox()
        Me.lblCFdate = New System.Windows.Forms.Label()
        Me.txtCFdatetime_sale = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCFunit = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCFtype = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCFprice_buy = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCFname_pro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCFbar_code = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCFcode_pro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCFserial_pro = New System.Windows.Forms.TextBox()
        Me.btnCdepositClaims = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnCFcancel = New System.Windows.Forms.Button()
        Me.btnCFsave = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCFnote = New System.Windows.Forms.TextBox()
        Me.btnCFloadaccessory = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCFaccessory = New System.Windows.Forms.TextBox()
        Me.btnCchangCustomer = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCFsyptom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCFcustomer_name = New System.Windows.Forms.TextBox()
        Me.txtCFcustomer_id = New System.Windows.Forms.TextBox()
        Me.txtCFsearchSN = New System.Windows.Forms.TextBox()
        Me.btnCFsearchSN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCFstatus = New System.Windows.Forms.TextBox()
        Me.dgClaims = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.claims_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serial_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bar_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_wholesale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_technician = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_loyel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_member = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.symptom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.accessory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCRefresh = New System.Windows.Forms.Button()
        Me.btnClaimsAll = New System.Windows.Forms.Button()
        Me.DelDgContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DelToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgClaims, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.DelDgContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.btnHelp})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 569)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(795, 22)
        Me.StatusStrip1.TabIndex = 0
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
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1MinSize = 250
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgClaims)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(795, 569)
        Me.SplitContainer1.SplitterDistance = 276
        Me.SplitContainer1.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 28)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(793, 246)
        Me.Panel4.TabIndex = 15
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GroupBox1)
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(787, 232)
        Me.Panel5.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel6)
        Me.GroupBox1.Controls.Add(Me.btnCdepositClaims)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.btnCFcancel)
        Me.GroupBox1.Controls.Add(Me.btnCFsave)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtCFnote)
        Me.GroupBox1.Controls.Add(Me.btnCFloadaccessory)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtCFaccessory)
        Me.GroupBox1.Controls.Add(Me.btnCchangCustomer)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtCFsyptom)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCFcustomer_name)
        Me.GroupBox1.Controls.Add(Me.txtCFcustomer_id)
        Me.GroupBox1.Controls.Add(Me.txtCFsearchSN)
        Me.GroupBox1.Controls.Add(Me.btnCFsearchSN)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(778, 223)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รับเคลมสินค้า"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label24)
        Me.Panel6.Controls.Add(Me.txtCFprice_members)
        Me.Panel6.Controls.Add(Me.Label23)
        Me.Panel6.Controls.Add(Me.txtCFprice_loyal)
        Me.Panel6.Controls.Add(Me.Label22)
        Me.Panel6.Controls.Add(Me.txtCFprice_technician)
        Me.Panel6.Controls.Add(Me.Label21)
        Me.Panel6.Controls.Add(Me.txtCFprice_wholsale)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Controls.Add(Me.txtCFemployee_sale)
        Me.Panel6.Controls.Add(Me.lblCFdate)
        Me.Panel6.Controls.Add(Me.txtCFdatetime_sale)
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.txtCFunit)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.txtCFtype)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Controls.Add(Me.txtCFprice_buy)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.txtCFname_pro)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.txtCFbar_code)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.txtCFcode_pro)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.txtCFserial_pro)
        Me.Panel6.Location = New System.Drawing.Point(5, 43)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(770, 92)
        Me.Panel6.TabIndex = 519
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(270, 48)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(62, 13)
        Me.Label24.TabIndex = 70
        Me.Label24.Text = "ราคาสมาชิก"
        '
        'txtCFprice_members
        '
        Me.txtCFprice_members.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFprice_members.Location = New System.Drawing.Point(267, 64)
        Me.txtCFprice_members.Name = "txtCFprice_members"
        Me.txtCFprice_members.ReadOnly = True
        Me.txtCFprice_members.Size = New System.Drawing.Size(65, 24)
        Me.txtCFprice_members.TabIndex = 69
        Me.txtCFprice_members.TabStop = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(177, 48)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(84, 13)
        Me.Label23.TabIndex = 68
        Me.Label23.Text = "ราคาลูกค้าประจำ"
        '
        'txtCFprice_loyal
        '
        Me.txtCFprice_loyal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFprice_loyal.Location = New System.Drawing.Point(180, 64)
        Me.txtCFprice_loyal.Name = "txtCFprice_loyal"
        Me.txtCFprice_loyal.ReadOnly = True
        Me.txtCFprice_loyal.Size = New System.Drawing.Size(81, 24)
        Me.txtCFprice_loyal.TabIndex = 67
        Me.txtCFprice_loyal.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(124, 48)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(47, 13)
        Me.Label22.TabIndex = 66
        Me.Label22.Text = "ราคาช่าง"
        '
        'txtCFprice_technician
        '
        Me.txtCFprice_technician.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFprice_technician.Location = New System.Drawing.Point(121, 64)
        Me.txtCFprice_technician.Name = "txtCFprice_technician"
        Me.txtCFprice_technician.ReadOnly = True
        Me.txtCFprice_technician.Size = New System.Drawing.Size(53, 24)
        Me.txtCFprice_technician.TabIndex = 65
        Me.txtCFprice_technician.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(59, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 13)
        Me.Label21.TabIndex = 64
        Me.Label21.Text = "ราคาขายส่ง"
        '
        'txtCFprice_wholsale
        '
        Me.txtCFprice_wholsale.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFprice_wholsale.Location = New System.Drawing.Point(62, 64)
        Me.txtCFprice_wholsale.Name = "txtCFprice_wholsale"
        Me.txtCFprice_wholsale.ReadOnly = True
        Me.txtCFprice_wholsale.Size = New System.Drawing.Size(53, 24)
        Me.txtCFprice_wholsale.TabIndex = 63
        Me.txtCFprice_wholsale.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(610, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 13)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "ผู้ขาย"
        '
        'txtCFemployee_sale
        '
        Me.txtCFemployee_sale.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFemployee_sale.Location = New System.Drawing.Point(613, 64)
        Me.txtCFemployee_sale.Name = "txtCFemployee_sale"
        Me.txtCFemployee_sale.ReadOnly = True
        Me.txtCFemployee_sale.Size = New System.Drawing.Size(152, 24)
        Me.txtCFemployee_sale.TabIndex = 61
        Me.txtCFemployee_sale.TabStop = False
        '
        'lblCFdate
        '
        Me.lblCFdate.AutoSize = True
        Me.lblCFdate.Location = New System.Drawing.Point(337, 48)
        Me.lblCFdate.Name = "lblCFdate"
        Me.lblCFdate.Size = New System.Drawing.Size(160, 13)
        Me.lblCFdate.TabIndex = 60
        Me.lblCFdate.Text = "วันที่ขายสินค้า(ปี/เดือน/วัน เวลา)"
        '
        'txtCFdatetime_sale
        '
        Me.txtCFdatetime_sale.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFdatetime_sale.Location = New System.Drawing.Point(340, 64)
        Me.txtCFdatetime_sale.Name = "txtCFdatetime_sale"
        Me.txtCFdatetime_sale.ReadOnly = True
        Me.txtCFdatetime_sale.Size = New System.Drawing.Size(267, 24)
        Me.txtCFdatetime_sale.TabIndex = 59
        Me.txtCFdatetime_sale.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(715, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 517
        Me.Label10.Text = "หน่วยนับ"
        '
        'txtCFunit
        '
        Me.txtCFunit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFunit.Location = New System.Drawing.Point(715, 21)
        Me.txtCFunit.Name = "txtCFunit"
        Me.txtCFunit.ReadOnly = True
        Me.txtCFunit.Size = New System.Drawing.Size(50, 24)
        Me.txtCFunit.TabIndex = 518
        Me.txtCFunit.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(639, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 515
        Me.Label9.Text = "ประเภทสินค้า"
        '
        'txtCFtype
        '
        Me.txtCFtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFtype.Location = New System.Drawing.Point(642, 22)
        Me.txtCFtype.Name = "txtCFtype"
        Me.txtCFtype.ReadOnly = True
        Me.txtCFtype.Size = New System.Drawing.Size(67, 24)
        Me.txtCFtype.TabIndex = 516
        Me.txtCFtype.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "ราคาปกติ"
        '
        'txtCFprice_buy
        '
        Me.txtCFprice_buy.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFprice_buy.Location = New System.Drawing.Point(3, 64)
        Me.txtCFprice_buy.Name = "txtCFprice_buy"
        Me.txtCFprice_buy.ReadOnly = True
        Me.txtCFprice_buy.Size = New System.Drawing.Size(53, 24)
        Me.txtCFprice_buy.TabIndex = 53
        Me.txtCFprice_buy.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(435, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 513
        Me.Label7.Text = "ชื่อสินค้า"
        '
        'txtCFname_pro
        '
        Me.txtCFname_pro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFname_pro.Location = New System.Drawing.Point(438, 21)
        Me.txtCFname_pro.Name = "txtCFname_pro"
        Me.txtCFname_pro.ReadOnly = True
        Me.txtCFname_pro.Size = New System.Drawing.Size(198, 24)
        Me.txtCFname_pro.TabIndex = 514
        Me.txtCFname_pro.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(290, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 511
        Me.Label6.Text = "บาร์โค๊ตสินค้า"
        '
        'txtCFbar_code
        '
        Me.txtCFbar_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFbar_code.Location = New System.Drawing.Point(293, 22)
        Me.txtCFbar_code.Name = "txtCFbar_code"
        Me.txtCFbar_code.ReadOnly = True
        Me.txtCFbar_code.Size = New System.Drawing.Size(139, 24)
        Me.txtCFbar_code.TabIndex = 512
        Me.txtCFbar_code.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(145, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 509
        Me.Label5.Text = "รหัสสินค้า"
        '
        'txtCFcode_pro
        '
        Me.txtCFcode_pro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFcode_pro.Location = New System.Drawing.Point(148, 21)
        Me.txtCFcode_pro.Name = "txtCFcode_pro"
        Me.txtCFcode_pro.ReadOnly = True
        Me.txtCFcode_pro.Size = New System.Drawing.Size(139, 24)
        Me.txtCFcode_pro.TabIndex = 510
        Me.txtCFcode_pro.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 507
        Me.Label4.Text = "Serial Number"
        '
        'txtCFserial_pro
        '
        Me.txtCFserial_pro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFserial_pro.Location = New System.Drawing.Point(3, 21)
        Me.txtCFserial_pro.Name = "txtCFserial_pro"
        Me.txtCFserial_pro.ReadOnly = True
        Me.txtCFserial_pro.Size = New System.Drawing.Size(139, 24)
        Me.txtCFserial_pro.TabIndex = 508
        Me.txtCFserial_pro.TabStop = False
        '
        'btnCdepositClaims
        '
        Me.btnCdepositClaims.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCdepositClaims.Location = New System.Drawing.Point(7, 183)
        Me.btnCdepositClaims.Name = "btnCdepositClaims"
        Me.btnCdepositClaims.Size = New System.Drawing.Size(89, 27)
        Me.btnCdepositClaims.TabIndex = 36
        Me.btnCdepositClaims.Text = "ฝากเคลม"
        Me.btnCdepositClaims.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.DarkRed
        Me.Label17.Location = New System.Drawing.Point(102, 183)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(452, 13)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "หากต้องการเช็คว่าลูกค้าซื้อสินค้าไปวันที่เท่าไหร่ ให้ป้อน SN สินค้าลงไปโดยไม่ต้อง" & _
    "กดบันทึกข้อมูล"
        '
        'btnCFcancel
        '
        Me.btnCFcancel.Enabled = False
        Me.btnCFcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCFcancel.Location = New System.Drawing.Point(686, 183)
        Me.btnCFcancel.Name = "btnCFcancel"
        Me.btnCFcancel.Size = New System.Drawing.Size(89, 37)
        Me.btnCFcancel.TabIndex = 35
        Me.btnCFcancel.Text = "ยกเลิก"
        Me.btnCFcancel.UseVisualStyleBackColor = True
        '
        'btnCFsave
        '
        Me.btnCFsave.Enabled = False
        Me.btnCFsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCFsave.Location = New System.Drawing.Point(591, 183)
        Me.btnCFsave.Name = "btnCFsave"
        Me.btnCFsave.Size = New System.Drawing.Size(89, 37)
        Me.btnCFsave.TabIndex = 5
        Me.btnCFsave.Text = "บันทึก"
        Me.btnCFsave.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(605, 137)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "หมายเหตุ"
        '
        'txtCFnote
        '
        Me.txtCFnote.Enabled = False
        Me.txtCFnote.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFnote.Location = New System.Drawing.Point(608, 153)
        Me.txtCFnote.Name = "txtCFnote"
        Me.txtCFnote.Size = New System.Drawing.Size(167, 24)
        Me.txtCFnote.TabIndex = 4
        '
        'btnCFloadaccessory
        '
        Me.btnCFloadaccessory.Enabled = False
        Me.btnCFloadaccessory.Location = New System.Drawing.Point(562, 155)
        Me.btnCFloadaccessory.Name = "btnCFloadaccessory"
        Me.btnCFloadaccessory.Size = New System.Drawing.Size(40, 24)
        Me.btnCFloadaccessory.TabIndex = 3
        Me.btnCFloadaccessory.TabStop = False
        Me.btnCFloadaccessory.Text = "เลือก"
        Me.btnCFloadaccessory.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(367, 138)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "อุปกรณ์ที่นำมาด้วย"
        '
        'txtCFaccessory
        '
        Me.txtCFaccessory.Enabled = False
        Me.txtCFaccessory.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFaccessory.Location = New System.Drawing.Point(370, 154)
        Me.txtCFaccessory.Name = "txtCFaccessory"
        Me.txtCFaccessory.Size = New System.Drawing.Size(186, 24)
        Me.txtCFaccessory.TabIndex = 2
        '
        'btnCchangCustomer
        '
        Me.btnCchangCustomer.Location = New System.Drawing.Point(685, 18)
        Me.btnCchangCustomer.Name = "btnCchangCustomer"
        Me.btnCchangCustomer.Size = New System.Drawing.Size(90, 24)
        Me.btnCchangCustomer.TabIndex = 506
        Me.btnCchangCustomer.TabStop = False
        Me.btnCchangCustomer.Text = "เปลี่ยนชื่อลูกค้า"
        Me.btnCchangCustomer.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(4, 138)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "อาการเสีย"
        '
        'txtCFsyptom
        '
        Me.txtCFsyptom.Enabled = False
        Me.txtCFsyptom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFsyptom.Location = New System.Drawing.Point(7, 154)
        Me.txtCFsyptom.Name = "txtCFsyptom"
        Me.txtCFsyptom.Size = New System.Drawing.Size(357, 24)
        Me.txtCFsyptom.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(489, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 504
        Me.Label3.Text = "ชื่อลูกค้า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(287, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 502
        Me.Label2.Text = "รหัสลูกค้า"
        '
        'txtCFcustomer_name
        '
        Me.txtCFcustomer_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFcustomer_name.Location = New System.Drawing.Point(540, 18)
        Me.txtCFcustomer_name.Name = "txtCFcustomer_name"
        Me.txtCFcustomer_name.ReadOnly = True
        Me.txtCFcustomer_name.Size = New System.Drawing.Size(139, 24)
        Me.txtCFcustomer_name.TabIndex = 505
        Me.txtCFcustomer_name.TabStop = False
        '
        'txtCFcustomer_id
        '
        Me.txtCFcustomer_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFcustomer_id.Location = New System.Drawing.Point(344, 18)
        Me.txtCFcustomer_id.Name = "txtCFcustomer_id"
        Me.txtCFcustomer_id.ReadOnly = True
        Me.txtCFcustomer_id.Size = New System.Drawing.Size(139, 24)
        Me.txtCFcustomer_id.TabIndex = 503
        Me.txtCFcustomer_id.TabStop = False
        '
        'txtCFsearchSN
        '
        Me.txtCFsearchSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFsearchSN.Location = New System.Drawing.Point(85, 19)
        Me.txtCFsearchSN.Name = "txtCFsearchSN"
        Me.txtCFsearchSN.Size = New System.Drawing.Size(139, 24)
        Me.txtCFsearchSN.TabIndex = 0
        '
        'btnCFsearchSN
        '
        Me.btnCFsearchSN.Location = New System.Drawing.Point(230, 19)
        Me.btnCFsearchSN.Name = "btnCFsearchSN"
        Me.btnCFsearchSN.Size = New System.Drawing.Size(51, 24)
        Me.btnCFsearchSN.TabIndex = 501
        Me.btnCFsearchSN.Text = "ค้นหา"
        Me.btnCFsearchSN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ป้อน SN สินค้า"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.txtCFstatus)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(793, 28)
        Me.Panel1.TabIndex = 14
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(462, 8)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(38, 13)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "สถานะ"
        '
        'txtCFstatus
        '
        Me.txtCFstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCFstatus.Location = New System.Drawing.Point(506, 3)
        Me.txtCFstatus.Name = "txtCFstatus"
        Me.txtCFstatus.ReadOnly = True
        Me.txtCFstatus.Size = New System.Drawing.Size(284, 21)
        Me.txtCFstatus.TabIndex = 20
        Me.txtCFstatus.TabStop = False
        '
        'dgClaims
        '
        Me.dgClaims.AllowUserToAddRows = False
        Me.dgClaims.AllowUserToDeleteRows = False
        Me.dgClaims.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgClaims.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgClaims.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.claims_id, Me.customer_id, Me.serial_pro, Me.code_pro, Me.bar_code, Me.name_pro, Me.price_buy, Me.price_wholesale, Me.price_technician, Me.price_loyel, Me.price_member, Me.type, Me.unit, Me.symptom, Me.accessory, Me.employee, Me.datetime_save})
        Me.dgClaims.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgClaims.Location = New System.Drawing.Point(0, 34)
        Me.dgClaims.MultiSelect = False
        Me.dgClaims.Name = "dgClaims"
        Me.dgClaims.ReadOnly = True
        Me.dgClaims.RowHeadersVisible = False
        Me.dgClaims.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgClaims.Size = New System.Drawing.Size(793, 210)
        Me.dgClaims.TabIndex = 500
        Me.dgClaims.TabStop = False
        '
        'no
        '
        Me.no.HeaderText = "#"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.Width = 30
        '
        'claims_id
        '
        Me.claims_id.HeaderText = "รหัสเคลม"
        Me.claims_id.Name = "claims_id"
        Me.claims_id.ReadOnly = True
        Me.claims_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'customer_id
        '
        Me.customer_id.HeaderText = "รหัสลูกค้า"
        Me.customer_id.Name = "customer_id"
        Me.customer_id.ReadOnly = True
        Me.customer_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'serial_pro
        '
        Me.serial_pro.HeaderText = "SN"
        Me.serial_pro.Name = "serial_pro"
        Me.serial_pro.ReadOnly = True
        Me.serial_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'code_pro
        '
        Me.code_pro.HeaderText = "รหัสสินค้า"
        Me.code_pro.Name = "code_pro"
        Me.code_pro.ReadOnly = True
        Me.code_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'bar_code
        '
        Me.bar_code.HeaderText = "บาร์โค๊ต"
        Me.bar_code.Name = "bar_code"
        Me.bar_code.ReadOnly = True
        Me.bar_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'name_pro
        '
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'price_buy
        '
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = "0"
        Me.price_buy.DefaultCellStyle = DataGridViewCellStyle11
        Me.price_buy.HeaderText = "ปกติ"
        Me.price_buy.Name = "price_buy"
        Me.price_buy.ReadOnly = True
        Me.price_buy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_buy.ToolTipText = "ราคาปกติ"
        Me.price_buy.Width = 50
        '
        'price_wholesale
        '
        DataGridViewCellStyle12.Format = "N2"
        DataGridViewCellStyle12.NullValue = "0"
        Me.price_wholesale.DefaultCellStyle = DataGridViewCellStyle12
        Me.price_wholesale.HeaderText = "ขายส่ง"
        Me.price_wholesale.Name = "price_wholesale"
        Me.price_wholesale.ReadOnly = True
        Me.price_wholesale.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_wholesale.ToolTipText = "ราคาขายส่ง"
        Me.price_wholesale.Width = 70
        '
        'price_technician
        '
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = "0"
        Me.price_technician.DefaultCellStyle = DataGridViewCellStyle13
        Me.price_technician.HeaderText = "ช่าง"
        Me.price_technician.Name = "price_technician"
        Me.price_technician.ReadOnly = True
        Me.price_technician.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_technician.ToolTipText = "ราคาช่าง"
        Me.price_technician.Width = 50
        '
        'price_loyel
        '
        DataGridViewCellStyle14.Format = "N2"
        DataGridViewCellStyle14.NullValue = "0"
        Me.price_loyel.DefaultCellStyle = DataGridViewCellStyle14
        Me.price_loyel.HeaderText = "ประจำ"
        Me.price_loyel.Name = "price_loyel"
        Me.price_loyel.ReadOnly = True
        Me.price_loyel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_loyel.ToolTipText = "ราคาลูกค้าประจำ"
        Me.price_loyel.Width = 50
        '
        'price_member
        '
        DataGridViewCellStyle15.Format = "N2"
        DataGridViewCellStyle15.NullValue = "0"
        Me.price_member.DefaultCellStyle = DataGridViewCellStyle15
        Me.price_member.HeaderText = "สมาชิก"
        Me.price_member.Name = "price_member"
        Me.price_member.ReadOnly = True
        Me.price_member.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_member.ToolTipText = "ราคาสมาชิก"
        '
        'type
        '
        Me.type.HeaderText = "ประเภท"
        Me.type.Name = "type"
        Me.type.ReadOnly = True
        Me.type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'unit
        '
        Me.unit.HeaderText = "หน่วย"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        Me.unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'symptom
        '
        Me.symptom.HeaderText = "อาการเสีย"
        Me.symptom.Name = "symptom"
        Me.symptom.ReadOnly = True
        '
        'accessory
        '
        Me.accessory.HeaderText = "อุปกรณ์ที่นำมาด้วย"
        Me.accessory.Name = "accessory"
        Me.accessory.ReadOnly = True
        Me.accessory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.accessory.Width = 150
        '
        'employee
        '
        Me.employee.HeaderText = "พนักงาน"
        Me.employee.Name = "employee"
        Me.employee.ReadOnly = True
        Me.employee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'datetime_save
        '
        Me.datetime_save.HeaderText = "เวลาบันทึก"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        Me.datetime_save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(793, 34)
        Me.Panel7.TabIndex = 501
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Label11)
        Me.Panel8.Location = New System.Drawing.Point(3, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(787, 28)
        Me.Panel8.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(326, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(146, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "รายการสินค้าที่รับเคลม"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnCRefresh)
        Me.Panel2.Controls.Add(Me.btnClaimsAll)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 244)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(793, 43)
        Me.Panel2.TabIndex = 0
        '
        'btnCRefresh
        '
        Me.btnCRefresh.Location = New System.Drawing.Point(3, 6)
        Me.btnCRefresh.Name = "btnCRefresh"
        Me.btnCRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnCRefresh.TabIndex = 37
        Me.btnCRefresh.TabStop = False
        Me.btnCRefresh.Text = "Refresh"
        Me.btnCRefresh.UseVisualStyleBackColor = True
        '
        'btnClaimsAll
        '
        Me.btnClaimsAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClaimsAll.Enabled = False
        Me.btnClaimsAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClaimsAll.Location = New System.Drawing.Point(577, 3)
        Me.btnClaimsAll.Name = "btnClaimsAll"
        Me.btnClaimsAll.Size = New System.Drawing.Size(213, 37)
        Me.btnClaimsAll.TabIndex = 6
        Me.btnClaimsAll.Text = "บันทึกทั้งหมด"
        Me.btnClaimsAll.UseVisualStyleBackColor = True
        '
        'DelDgContextMenu
        '
        Me.DelDgContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DelToolStripMenu, Me.ClearToolStripMenu})
        Me.DelDgContextMenu.Name = "DelDgContextMenu"
        Me.DelDgContextMenu.Size = New System.Drawing.Size(173, 48)
        '
        'DelToolStripMenu
        '
        Me.DelToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.action_Cancel_16xLG
        Me.DelToolStripMenu.Name = "DelToolStripMenu"
        Me.DelToolStripMenu.Size = New System.Drawing.Size(172, 22)
        Me.DelToolStripMenu.Text = "ลบข้อมูลเคลมนี้"
        '
        'ClearToolStripMenu
        '
        Me.ClearToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources._009_HighPriority_16x16_72
        Me.ClearToolStripMenu.Name = "ClearToolStripMenu"
        Me.ClearToolStripMenu.Size = New System.Drawing.Size(172, 22)
        Me.ClearToolStripMenu.Text = "ล้างข้อมูลเคลมทั้งหมด"
        '
        'ClaimsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 591)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.MaximumSize = New System.Drawing.Size(1000, 800)
        Me.MinimumSize = New System.Drawing.Size(400, 39)
        Me.Name = "ClaimsFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เคลมสินค้า/เช็ควันที่ซื้อ"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgClaims, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.DelDgContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgClaims As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnCRefresh As System.Windows.Forms.Button
    Friend WithEvents btnClaimsAll As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCdepositClaims As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnCFcancel As System.Windows.Forms.Button
    Friend WithEvents btnCFsave As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCFnote As System.Windows.Forms.TextBox
    Friend WithEvents btnCFloadaccessory As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCFaccessory As System.Windows.Forms.TextBox
    Friend WithEvents btnCchangCustomer As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCFsyptom As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCFcustomer_name As System.Windows.Forms.TextBox
    Friend WithEvents txtCFcustomer_id As System.Windows.Forms.TextBox
    Friend WithEvents txtCFsearchSN As System.Windows.Forms.TextBox
    Friend WithEvents btnCFsearchSN As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtCFstatus As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtCFprice_members As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtCFprice_loyal As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtCFprice_technician As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtCFprice_wholsale As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCFemployee_sale As System.Windows.Forms.TextBox
    Friend WithEvents lblCFdate As System.Windows.Forms.Label
    Friend WithEvents txtCFdatetime_sale As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCFunit As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCFtype As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCFprice_buy As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCFname_pro As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCFbar_code As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCFcode_pro As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCFserial_pro As System.Windows.Forms.TextBox
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents claims_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serial_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bar_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_wholesale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_technician As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_loyel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_member As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents symptom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents accessory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DelDgContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DelToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
