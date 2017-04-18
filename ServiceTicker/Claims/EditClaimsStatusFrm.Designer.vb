<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditClaimsStatusFrm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnECSsave = New System.Windows.Forms.Button()
        Me.btnECScancel = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtECSclaimsID = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtECSsendMoney = New System.Windows.Forms.TextBox()
        Me.lblECSstatusSelect = New System.Windows.Forms.Label()
        Me.cbbECSclaimsStatus = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtECSemployee = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtECSstatus = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtECSaccessory = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtECSsymptom = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtECSunit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtECStype = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtECSprice_buy = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtECSname_pro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtECSbar_code = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtECScode_pro = New System.Windows.Forms.TextBox()
        Me.txtECSsn = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtECScus_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtECScus_id = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 250)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(766, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblEmployee
        '
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(30, 17)
        Me.lblEmployee.Text = "User"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.btnECSsave)
        Me.Panel1.Controls.Add(Me.btnECScancel)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(766, 250)
        Me.Panel1.TabIndex = 1
        '
        'btnECSsave
        '
        Me.btnECSsave.Enabled = False
        Me.btnECSsave.Location = New System.Drawing.Point(605, 178)
        Me.btnECSsave.Name = "btnECSsave"
        Me.btnECSsave.Size = New System.Drawing.Size(75, 23)
        Me.btnECSsave.TabIndex = 20
        Me.btnECSsave.Text = "บันทึก"
        Me.btnECSsave.UseVisualStyleBackColor = True
        '
        'btnECScancel
        '
        Me.btnECScancel.Location = New System.Drawing.Point(686, 178)
        Me.btnECScancel.Name = "btnECScancel"
        Me.btnECScancel.Size = New System.Drawing.Size(75, 23)
        Me.btnECScancel.TabIndex = 19
        Me.btnECScancel.Text = "ยกเลิก"
        Me.btnECScancel.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DarkRed
        Me.Label17.Location = New System.Drawing.Point(6, 230)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(390, 16)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "*สถานะ รอส่งลูกค้า สินค้าที่ดำเนินการซ่อมหรือเคลมมาเรียบร้อยแล้ว รอลูกค้ามารับคืน" &
    ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DarkRed
        Me.Label16.Location = New System.Drawing.Point(6, 198)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(558, 16)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "*สถานะ รอคืนเงิน คือ สินค้าที่ซ่อมไม่ได้ ซ่อมไม่ผ่าน หรือ ไม่มีสินค้าเคลมให้ลูกค้" &
    "าต้องการจะเป็นตัวสินค้าเป็นตัวเงินให้ลูกค้า"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkRed
        Me.Label15.Location = New System.Drawing.Point(6, 214)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(701, 16)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "*สถานะ ส่งซ่อม กรณีซ่อมได้เอง โปรแกรมจะส่งข้อมูลที่ไปที่งานช่าง ช่างสามารถเรียกดู" &
    "สถานะและกำหนดสถานะได้เองแล้วส่งข้อมูลกลับมาเมื่อซ่อมเสร็จแล้ว"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtECSclaimsID)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtECSsendMoney)
        Me.GroupBox1.Controls.Add(Me.lblECSstatusSelect)
        Me.GroupBox1.Controls.Add(Me.cbbECSclaimsStatus)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtECSemployee)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtECSstatus)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtECSaccessory)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtECSsymptom)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtECSunit)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtECStype)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtECSprice_buy)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtECSname_pro)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtECSbar_code)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtECScode_pro)
        Me.GroupBox1.Controls.Add(Me.txtECSsn)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtECScus_name)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtECScus_id)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(758, 169)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รายละเอียด"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 15)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "รหัสเคลม"
        '
        'txtECSclaimsID
        '
        Me.txtECSclaimsID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtECSclaimsID.Location = New System.Drawing.Point(6, 31)
        Me.txtECSclaimsID.Name = "txtECSclaimsID"
        Me.txtECSclaimsID.ReadOnly = True
        Me.txtECSclaimsID.Size = New System.Drawing.Size(129, 21)
        Me.txtECSclaimsID.TabIndex = 18
        Me.txtECSclaimsID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 144)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 13)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "สาเหตุการคืนเงิน"
        Me.Label14.Visible = False
        '
        'txtECSsendMoney
        '
        Me.txtECSsendMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtECSsendMoney.Location = New System.Drawing.Point(101, 139)
        Me.txtECSsendMoney.Name = "txtECSsendMoney"
        Me.txtECSsendMoney.Size = New System.Drawing.Size(386, 21)
        Me.txtECSsendMoney.TabIndex = 17
        Me.txtECSsendMoney.Visible = False
        '
        'lblECSstatusSelect
        '
        Me.lblECSstatusSelect.AutoSize = True
        Me.lblECSstatusSelect.Location = New System.Drawing.Point(493, 144)
        Me.lblECSstatusSelect.Name = "lblECSstatusSelect"
        Me.lblECSstatusSelect.Size = New System.Drawing.Size(72, 13)
        Me.lblECSstatusSelect.TabIndex = 13
        Me.lblECSstatusSelect.Text = "กำหนดสถานะ"
        '
        'cbbECSclaimsStatus
        '
        Me.cbbECSclaimsStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbbECSclaimsStatus.FormattingEnabled = True
        Me.cbbECSclaimsStatus.Location = New System.Drawing.Point(571, 137)
        Me.cbbECSclaimsStatus.Name = "cbbECSclaimsStatus"
        Me.cbbECSclaimsStatus.Size = New System.Drawing.Size(180, 26)
        Me.cbbECSclaimsStatus.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "ผู้รับเคลม"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(653, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "สถานะ"
        '
        'txtECSemployee
        '
        Me.txtECSemployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtECSemployee.Location = New System.Drawing.Point(9, 112)
        Me.txtECSemployee.Name = "txtECSemployee"
        Me.txtECSemployee.ReadOnly = True
        Me.txtECSemployee.Size = New System.Drawing.Size(184, 21)
        Me.txtECSemployee.TabIndex = 11
        Me.txtECSemployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(199, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "อุปกรณ์ที่นำมาด้วย"
        '
        'txtECSstatus
        '
        Me.txtECSstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtECSstatus.Location = New System.Drawing.Point(653, 112)
        Me.txtECSstatus.Name = "txtECSstatus"
        Me.txtECSstatus.ReadOnly = True
        Me.txtECSstatus.Size = New System.Drawing.Size(98, 21)
        Me.txtECSstatus.TabIndex = 11
        Me.txtECSstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(493, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "อาการเสีย"
        '
        'txtECSaccessory
        '
        Me.txtECSaccessory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtECSaccessory.Location = New System.Drawing.Point(199, 112)
        Me.txtECSaccessory.Name = "txtECSaccessory"
        Me.txtECSaccessory.ReadOnly = True
        Me.txtECSaccessory.Size = New System.Drawing.Size(448, 21)
        Me.txtECSaccessory.TabIndex = 11
        Me.txtECSaccessory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(437, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "หน่วยนับ"
        '
        'txtECSsymptom
        '
        Me.txtECSsymptom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtECSsymptom.Location = New System.Drawing.Point(493, 72)
        Me.txtECSsymptom.Name = "txtECSsymptom"
        Me.txtECSsymptom.ReadOnly = True
        Me.txtECSsymptom.Size = New System.Drawing.Size(258, 21)
        Me.txtECSsymptom.TabIndex = 11
        Me.txtECSsymptom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(361, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "ประเภทสินค้า"
        '
        'txtECSunit
        '
        Me.txtECSunit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtECSunit.Location = New System.Drawing.Point(437, 72)
        Me.txtECSunit.Name = "txtECSunit"
        Me.txtECSunit.ReadOnly = True
        Me.txtECSunit.Size = New System.Drawing.Size(50, 21)
        Me.txtECSunit.TabIndex = 9
        Me.txtECSunit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(299, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "ราคาสินค้า"
        '
        'txtECStype
        '
        Me.txtECStype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtECStype.Location = New System.Drawing.Point(361, 72)
        Me.txtECStype.Name = "txtECStype"
        Me.txtECStype.ReadOnly = True
        Me.txtECStype.Size = New System.Drawing.Size(70, 21)
        Me.txtECStype.TabIndex = 9
        Me.txtECStype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "ชื่อสินค้า"
        '
        'txtECSprice_buy
        '
        Me.txtECSprice_buy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtECSprice_buy.Location = New System.Drawing.Point(299, 72)
        Me.txtECSprice_buy.Name = "txtECSprice_buy"
        Me.txtECSprice_buy.ReadOnly = True
        Me.txtECSprice_buy.Size = New System.Drawing.Size(56, 21)
        Me.txtECSprice_buy.TabIndex = 9
        Me.txtECSprice_buy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(656, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "บาร์โค๊ต"
        '
        'txtECSname_pro
        '
        Me.txtECSname_pro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtECSname_pro.Location = New System.Drawing.Point(6, 72)
        Me.txtECSname_pro.Name = "txtECSname_pro"
        Me.txtECSname_pro.ReadOnly = True
        Me.txtECSname_pro.Size = New System.Drawing.Size(288, 21)
        Me.txtECSname_pro.TabIndex = 9
        Me.txtECSname_pro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(552, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "รหัสสินค้า"
        '
        'txtECSbar_code
        '
        Me.txtECSbar_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtECSbar_code.Location = New System.Drawing.Point(656, 31)
        Me.txtECSbar_code.Name = "txtECSbar_code"
        Me.txtECSbar_code.ReadOnly = True
        Me.txtECSbar_code.Size = New System.Drawing.Size(98, 21)
        Me.txtECSbar_code.TabIndex = 9
        Me.txtECSbar_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(417, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "SN"
        '
        'txtECScode_pro
        '
        Me.txtECScode_pro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtECScode_pro.Location = New System.Drawing.Point(552, 31)
        Me.txtECScode_pro.Name = "txtECScode_pro"
        Me.txtECScode_pro.ReadOnly = True
        Me.txtECScode_pro.Size = New System.Drawing.Size(98, 21)
        Me.txtECScode_pro.TabIndex = 7
        Me.txtECScode_pro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtECSsn
        '
        Me.txtECSsn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtECSsn.Location = New System.Drawing.Point(417, 31)
        Me.txtECSsn.Name = "txtECSsn"
        Me.txtECSsn.ReadOnly = True
        Me.txtECSsn.Size = New System.Drawing.Size(129, 21)
        Me.txtECSsn.TabIndex = 4
        Me.txtECSsn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(282, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ชื่อลูกค้า"
        '
        'txtECScus_name
        '
        Me.txtECScus_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtECScus_name.Location = New System.Drawing.Point(285, 31)
        Me.txtECScus_name.Name = "txtECScus_name"
        Me.txtECScus_name.ReadOnly = True
        Me.txtECScus_name.Size = New System.Drawing.Size(126, 21)
        Me.txtECScus_name.TabIndex = 3
        Me.txtECScus_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "รหัสลูกค้า"
        '
        'txtECScus_id
        '
        Me.txtECScus_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtECScus_id.Location = New System.Drawing.Point(141, 31)
        Me.txtECScus_id.Name = "txtECScus_id"
        Me.txtECScus_id.ReadOnly = True
        Me.txtECScus_id.Size = New System.Drawing.Size(138, 21)
        Me.txtECScus_id.TabIndex = 2
        Me.txtECScus_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'Timer2
        '
        Me.Timer2.Interval = 5000
        '
        'EditClaimsStatusFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 272)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditClaimsStatusFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ดำเนินการสถานะเคลม"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblEmployee As ToolStripStatusLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnECSsave As Button
    Friend WithEvents btnECScancel As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtECSsendMoney As TextBox
    Friend WithEvents lblECSstatusSelect As Label
    Friend WithEvents cbbECSclaimsStatus As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtECSemployee As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtECSstatus As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtECSaccessory As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtECSsymptom As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtECSunit As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtECStype As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtECSprice_buy As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtECSname_pro As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtECSbar_code As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtECScode_pro As TextBox
    Friend WithEvents txtECSsn As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtECScus_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtECScus_id As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtECSclaimsID As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
