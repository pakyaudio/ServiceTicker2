<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceiveProductFrm
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblPercen = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAttactBill = New System.Windows.Forms.LinkLabel()
        Me.btnAttactBill = New System.Windows.Forms.Button()
        Me.txtRPsale_company_id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRPselectOrder = New System.Windows.Forms.Button()
        Me.txtRSorderID = New System.Windows.Forms.TextBox()
        Me.cbRPstatus = New System.Windows.Forms.ComboBox()
        Me.lblRPStatus = New System.Windows.Forms.Label()
        Me.txtRPbillID = New System.Windows.Forms.TextBox()
        Me.lblRPbillID = New System.Windows.Forms.Label()
        Me.txtRPbuy_id = New System.Windows.Forms.TextBox()
        Me.txtRPsale_company_name = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRPid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRPclear = New System.Windows.Forms.Button()
        Me.btnRPsave = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRPsumMoney = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgRPorderPro = New System.Windows.Forms.DataGridView()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.count_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.จำนวนรับSN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_all = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnRPdelBarcode = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRPaddBCnum = New System.Windows.Forms.Button()
        Me.txtRPbarcode = New System.Windows.Forms.TextBox()
        Me.btnRPaddBarcode = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtsumSN = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtsumBuy = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtsumBC = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtRPnamePro = New System.Windows.Forms.TextBox()
        Me.dgRPsn = New System.Windows.Forms.DataGridView()
        Me.serial_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namepro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codepro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnRPdelSN = New System.Windows.Forms.Button()
        Me.btnRPaddSN = New System.Windows.Forms.Button()
        Me.txtRPserialPro = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Picture_allTableAdapter1 = New ServiceTicker.Picture_allDataSetTableAdapters.picture_allTableAdapter()
        Me.Picture_allDataSet1 = New ServiceTicker.Picture_allDataSet()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgRPorderPro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgRPsn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.Picture_allDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.btnHelp, Me.ProgressBar1, Me.lblPercen})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.TabIndex = 202
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblEmployee
        '
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(30, 17)
        Me.lblEmployee.Text = "User"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(500, 16)
        '
        'lblPercen
        '
        Me.lblPercen.Name = "lblPercen"
        Me.lblPercen.Size = New System.Drawing.Size(0, 17)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblAttactBill)
        Me.Panel1.Controls.Add(Me.btnAttactBill)
        Me.Panel1.Controls.Add(Me.txtRPsale_company_id)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnRPselectOrder)
        Me.Panel1.Controls.Add(Me.txtRSorderID)
        Me.Panel1.Controls.Add(Me.cbRPstatus)
        Me.Panel1.Controls.Add(Me.lblRPStatus)
        Me.Panel1.Controls.Add(Me.txtRPbillID)
        Me.Panel1.Controls.Add(Me.lblRPbillID)
        Me.Panel1.Controls.Add(Me.txtRPbuy_id)
        Me.Panel1.Controls.Add(Me.txtRPsale_company_name)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtRPid)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 80)
        Me.Panel1.TabIndex = 0
        '
        'lblAttactBill
        '
        Me.lblAttactBill.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAttactBill.AutoSize = True
        Me.lblAttactBill.Location = New System.Drawing.Point(592, 53)
        Me.lblAttactBill.Name = "lblAttactBill"
        Me.lblAttactBill.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAttactBill.Size = New System.Drawing.Size(101, 13)
        Me.lblAttactBill.TabIndex = 5
        Me.lblAttactBill.TabStop = True
        Me.lblAttactBill.Text = "รายการเอกสารแนบ"
        Me.lblAttactBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAttactBill
        '
        Me.btnAttactBill.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAttactBill.Enabled = False
        Me.btnAttactBill.Location = New System.Drawing.Point(698, 28)
        Me.btnAttactBill.Name = "btnAttactBill"
        Me.btnAttactBill.Size = New System.Drawing.Size(82, 23)
        Me.btnAttactBill.TabIndex = 4
        Me.btnAttactBill.Text = "แนบเอกสาร"
        Me.ToolTip1.SetToolTip(Me.btnAttactBill, "แนบรูปเอกสารใบเสร็จการซื้อสินค้า (ถ้ามี)")
        Me.btnAttactBill.UseVisualStyleBackColor = True
        '
        'txtRPsale_company_id
        '
        Me.txtRPsale_company_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRPsale_company_id.Location = New System.Drawing.Point(78, 53)
        Me.txtRPsale_company_id.Name = "txtRPsale_company_id"
        Me.txtRPsale_company_id.ReadOnly = True
        Me.txtRPsale_company_id.Size = New System.Drawing.Size(76, 22)
        Me.txtRPsale_company_id.TabIndex = 38
        Me.txtRPsale_company_id.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "เลขที่ใบสั่งซื้อ"
        '
        'btnRPselectOrder
        '
        Me.btnRPselectOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRPselectOrder.Location = New System.Drawing.Point(699, 2)
        Me.btnRPselectOrder.Name = "btnRPselectOrder"
        Me.btnRPselectOrder.Size = New System.Drawing.Size(82, 23)
        Me.btnRPselectOrder.TabIndex = 0
        Me.btnRPselectOrder.Text = "เลือกใบสั่งซื้อ"
        Me.ToolTip1.SetToolTip(Me.btnRPselectOrder, "ค้นหาใบสั่งซื้อ")
        Me.btnRPselectOrder.UseVisualStyleBackColor = True
        '
        'txtRSorderID
        '
        Me.txtRSorderID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRSorderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRSorderID.Location = New System.Drawing.Point(562, 2)
        Me.txtRSorderID.Name = "txtRSorderID"
        Me.txtRSorderID.Size = New System.Drawing.Size(131, 22)
        Me.txtRSorderID.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtRSorderID, "ใส่เลขที่ใบสั่งซื้อ กด enter")
        '
        'cbRPstatus
        '
        Me.cbRPstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbRPstatus.FormattingEnabled = True
        Me.cbRPstatus.Location = New System.Drawing.Point(435, 3)
        Me.cbRPstatus.Name = "cbRPstatus"
        Me.cbRPstatus.Size = New System.Drawing.Size(121, 21)
        Me.cbRPstatus.TabIndex = 2
        Me.cbRPstatus.TabStop = False
        Me.ToolTip1.SetToolTip(Me.cbRPstatus, "เลือกสถานะสินค้าที่นำเข้า")
        '
        'lblRPStatus
        '
        Me.lblRPStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRPStatus.AutoSize = True
        Me.lblRPStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblRPStatus.Location = New System.Drawing.Point(390, 4)
        Me.lblRPStatus.Name = "lblRPStatus"
        Me.lblRPStatus.Size = New System.Drawing.Size(39, 16)
        Me.lblRPStatus.TabIndex = 33
        Me.lblRPStatus.Text = "สถานะ"
        '
        'txtRPbillID
        '
        Me.txtRPbillID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRPbillID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRPbillID.Location = New System.Drawing.Point(435, 28)
        Me.txtRPbillID.Name = "txtRPbillID"
        Me.txtRPbillID.Size = New System.Drawing.Size(258, 22)
        Me.txtRPbillID.TabIndex = 3
        Me.txtRPbillID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtRPbillID, "เลขที่ใบเสร็จ ใบวางบิล ใบส่งของ ของบริษัทที่สั่งซื้อ")
        '
        'lblRPbillID
        '
        Me.lblRPbillID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRPbillID.AutoSize = True
        Me.lblRPbillID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblRPbillID.Location = New System.Drawing.Point(336, 31)
        Me.lblRPbillID.Name = "lblRPbillID"
        Me.lblRPbillID.Size = New System.Drawing.Size(93, 16)
        Me.lblRPbillID.TabIndex = 31
        Me.lblRPbillID.Text = "เลขที่เอกสารรับเข้า"
        '
        'txtRPbuy_id
        '
        Me.txtRPbuy_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRPbuy_id.Location = New System.Drawing.Point(79, 3)
        Me.txtRPbuy_id.Name = "txtRPbuy_id"
        Me.txtRPbuy_id.ReadOnly = True
        Me.txtRPbuy_id.Size = New System.Drawing.Size(178, 22)
        Me.txtRPbuy_id.TabIndex = 30
        Me.txtRPbuy_id.TabStop = False
        '
        'txtRPsale_company_name
        '
        Me.txtRPsale_company_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRPsale_company_name.Location = New System.Drawing.Point(160, 53)
        Me.txtRPsale_company_name.Name = "txtRPsale_company_name"
        Me.txtRPsale_company_name.ReadOnly = True
        Me.txtRPsale_company_name.Size = New System.Drawing.Size(269, 22)
        Me.txtRPsale_company_name.TabIndex = 28
        Me.txtRPsale_company_name.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 16)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "ซื้อมาจาก"
        '
        'txtRPid
        '
        Me.txtRPid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRPid.Location = New System.Drawing.Point(79, 28)
        Me.txtRPid.Name = "txtRPid"
        Me.txtRPid.ReadOnly = True
        Me.txtRPid.Size = New System.Drawing.Size(178, 22)
        Me.txtRPid.TabIndex = 26
        Me.txtRPid.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "เลขที่รับเข้า"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnRPclear)
        Me.Panel2.Controls.Add(Me.btnRPsave)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtRPsumMoney)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 487)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 52)
        Me.Panel2.TabIndex = 203
        '
        'btnRPclear
        '
        Me.btnRPclear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRPclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRPclear.Location = New System.Drawing.Point(339, 6)
        Me.btnRPclear.Name = "btnRPclear"
        Me.btnRPclear.Size = New System.Drawing.Size(105, 43)
        Me.btnRPclear.TabIndex = 25
        Me.btnRPclear.TabStop = False
        Me.btnRPclear.Text = "ล้างรายการ"
        Me.ToolTip1.SetToolTip(Me.btnRPclear, "ล้างรายการนำเข้าทั้งหมด")
        Me.btnRPclear.UseVisualStyleBackColor = True
        '
        'btnRPsave
        '
        Me.btnRPsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRPsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRPsave.Location = New System.Drawing.Point(445, 6)
        Me.btnRPsave.Name = "btnRPsave"
        Me.btnRPsave.Size = New System.Drawing.Size(336, 43)
        Me.btnRPsave.TabIndex = 6
        Me.btnRPsave.Text = "บันทึก"
        Me.ToolTip1.SetToolTip(Me.btnRPsave, "บันทึกการนำเข้าสินค้า")
        Me.btnRPsave.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(121, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 16)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "รวมยอดสั่งซื้อทั้งหมด"
        '
        'txtRPsumMoney
        '
        Me.txtRPsumMoney.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRPsumMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRPsumMoney.Location = New System.Drawing.Point(234, 6)
        Me.txtRPsumMoney.Name = "txtRPsumMoney"
        Me.txtRPsumMoney.ReadOnly = True
        Me.txtRPsumMoney.Size = New System.Drawing.Size(99, 24)
        Me.txtRPsumMoney.TabIndex = 18
        Me.txtRPsumMoney.TabStop = False
        Me.txtRPsumMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 80)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgRPorderPro)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgRPsn)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel4)
        Me.SplitContainer1.Size = New System.Drawing.Size(784, 407)
        Me.SplitContainer1.SplitterDistance = 496
        Me.SplitContainer1.TabIndex = 3
        '
        'dgRPorderPro
        '
        Me.dgRPorderPro.AllowUserToAddRows = False
        Me.dgRPorderPro.AllowUserToDeleteRows = False
        Me.dgRPorderPro.AllowUserToResizeColumns = False
        Me.dgRPorderPro.AllowUserToResizeRows = False
        Me.dgRPorderPro.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgRPorderPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRPorderPro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.code_pro, Me.name_pro, Me.price_cost, Me.price_buy, Me.count_num, Me.จำนวนรับSN, Me.SN, Me.unit, Me.total_all})
        Me.dgRPorderPro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgRPorderPro.Location = New System.Drawing.Point(0, 59)
        Me.dgRPorderPro.MultiSelect = False
        Me.dgRPorderPro.Name = "dgRPorderPro"
        Me.dgRPorderPro.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Brown
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgRPorderPro.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgRPorderPro.RowHeadersVisible = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgRPorderPro.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgRPorderPro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRPorderPro.Size = New System.Drawing.Size(494, 312)
        Me.dgRPorderPro.TabIndex = 0
        Me.dgRPorderPro.TabStop = False
        '
        'code_pro
        '
        Me.code_pro.DataPropertyName = "code_pro"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.code_pro.DefaultCellStyle = DataGridViewCellStyle1
        Me.code_pro.Frozen = True
        Me.code_pro.HeaderText = "รหัสสินค้า"
        Me.code_pro.MaxInputLength = 30
        Me.code_pro.Name = "code_pro"
        Me.code_pro.ReadOnly = True
        Me.code_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.code_pro.ToolTipText = "รหัสสินค้า"
        '
        'name_pro
        '
        Me.name_pro.DataPropertyName = "name_pro"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.name_pro.DefaultCellStyle = DataGridViewCellStyle2
        Me.name_pro.FillWeight = 250.0!
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.MaxInputLength = 3000
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro.ToolTipText = "ชื่อสินค้า"
        Me.name_pro.Width = 200
        '
        'price_cost
        '
        Me.price_cost.DataPropertyName = "price_cost"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.price_cost.DefaultCellStyle = DataGridViewCellStyle3
        Me.price_cost.FillWeight = 70.0!
        Me.price_cost.HeaderText = "ราคาทุน"
        Me.price_cost.Name = "price_cost"
        Me.price_cost.ReadOnly = True
        Me.price_cost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_cost.ToolTipText = "ต้นทุนที่ซื้อสินค้ามา"
        Me.price_cost.Width = 70
        '
        'price_buy
        '
        Me.price_buy.DataPropertyName = "price_buy"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.price_buy.DefaultCellStyle = DataGridViewCellStyle4
        Me.price_buy.FillWeight = 70.0!
        Me.price_buy.HeaderText = "ราคาขาย"
        Me.price_buy.Name = "price_buy"
        Me.price_buy.ReadOnly = True
        Me.price_buy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_buy.ToolTipText = "ราคาที่ตั้งขายหน้าร้าน"
        Me.price_buy.Width = 70
        '
        'count_num
        '
        Me.count_num.DataPropertyName = "count_num"
        Me.count_num.FillWeight = 50.0!
        Me.count_num.HeaderText = "จำนวนสั่ง"
        Me.count_num.Name = "count_num"
        Me.count_num.ReadOnly = True
        Me.count_num.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.count_num.ToolTipText = "จำนวนสินค้าที่สั่งซื้อ"
        Me.count_num.Width = 50
        '
        'จำนวนรับSN
        '
        Me.จำนวนรับSN.DataPropertyName = "bar_code"
        Me.จำนวนรับSN.FillWeight = 50.0!
        Me.จำนวนรับSN.HeaderText = "จำนวนรับบาร์โค๊ต"
        Me.จำนวนรับSN.Name = "จำนวนรับSN"
        Me.จำนวนรับSN.ReadOnly = True
        Me.จำนวนรับSN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.จำนวนรับSN.ToolTipText = "จำนวนสินค้าที่รับเข้าบาร์โค๊ต"
        Me.จำนวนรับSN.Width = 70
        '
        'SN
        '
        Me.SN.DataPropertyName = "SN"
        Me.SN.FillWeight = 50.0!
        Me.SN.HeaderText = "จำนวนรับSN"
        Me.SN.Name = "SN"
        Me.SN.ReadOnly = True
        Me.SN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SN.ToolTipText = "จำนวนรับสินค้าที่เป็น Serial Number"
        Me.SN.Width = 70
        '
        'unit
        '
        Me.unit.DataPropertyName = "unit"
        Me.unit.FillWeight = 50.0!
        Me.unit.HeaderText = "หน่วย"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        Me.unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.unit.ToolTipText = "หน่วย"
        Me.unit.Width = 50
        '
        'total_all
        '
        Me.total_all.DataPropertyName = "total_all"
        Me.total_all.FillWeight = 70.0!
        Me.total_all.HeaderText = "รวมทุน"
        Me.total_all.Name = "total_all"
        Me.total_all.ReadOnly = True
        Me.total_all.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_all.ToolTipText = "ราคาทุน x จำนวนที่สั่งซื้อ"
        Me.total_all.Width = 70
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnRPdelBarcode)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.btnRPaddBCnum)
        Me.Panel6.Controls.Add(Me.txtRPbarcode)
        Me.Panel6.Controls.Add(Me.btnRPaddBarcode)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.NumericUpDown1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 31)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(494, 28)
        Me.Panel6.TabIndex = 209
        '
        'btnRPdelBarcode
        '
        Me.btnRPdelBarcode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRPdelBarcode.Location = New System.Drawing.Point(457, 3)
        Me.btnRPdelBarcode.Name = "btnRPdelBarcode"
        Me.btnRPdelBarcode.Size = New System.Drawing.Size(34, 23)
        Me.btnRPdelBarcode.TabIndex = 2
        Me.btnRPdelBarcode.TabStop = False
        Me.btnRPdelBarcode.Text = "ลบ"
        Me.ToolTip1.SetToolTip(Me.btnRPdelBarcode, "ลบจำนวนสินค้าบาร์โค๊ต")
        Me.btnRPdelBarcode.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "จำนวนBC"
        '
        'btnRPaddBCnum
        '
        Me.btnRPaddBCnum.Location = New System.Drawing.Point(137, 2)
        Me.btnRPaddBCnum.Name = "btnRPaddBCnum"
        Me.btnRPaddBCnum.Size = New System.Drawing.Size(41, 23)
        Me.btnRPaddBCnum.TabIndex = 43
        Me.btnRPaddBCnum.TabStop = False
        Me.btnRPaddBCnum.Text = "เพิ่ม"
        Me.ToolTip1.SetToolTip(Me.btnRPaddBCnum, "เพิ่มจำนวนสินค้าบาร์โค๊ต โดยกำหนดจำนวน")
        Me.btnRPaddBCnum.UseVisualStyleBackColor = True
        '
        'txtRPbarcode
        '
        Me.txtRPbarcode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRPbarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRPbarcode.Location = New System.Drawing.Point(303, 3)
        Me.txtRPbarcode.Name = "txtRPbarcode"
        Me.txtRPbarcode.Size = New System.Drawing.Size(104, 22)
        Me.txtRPbarcode.TabIndex = 0
        '
        'btnRPaddBarcode
        '
        Me.btnRPaddBarcode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRPaddBarcode.Location = New System.Drawing.Point(413, 3)
        Me.btnRPaddBarcode.Name = "btnRPaddBarcode"
        Me.btnRPaddBarcode.Size = New System.Drawing.Size(41, 23)
        Me.btnRPaddBarcode.TabIndex = 1
        Me.btnRPaddBarcode.TabStop = False
        Me.btnRPaddBarcode.Text = "เพิ่ม"
        Me.ToolTip1.SetToolTip(Me.btnRPaddBarcode, "เพิ่มจำนวนสินค้าบาร์โค๊ต")
        Me.btnRPaddBarcode.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(249, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "BarCode"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(63, 3)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(68, 20)
        Me.NumericUpDown1.TabIndex = 3
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.txtsumSN)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.txtsumBuy)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.txtsumBC)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 371)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(494, 34)
        Me.Panel5.TabIndex = 208
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(367, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 16)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "จำนวน SN"
        '
        'txtsumSN
        '
        Me.txtsumSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsumSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtsumSN.Location = New System.Drawing.Point(434, 5)
        Me.txtsumSN.Name = "txtsumSN"
        Me.txtsumSN.ReadOnly = True
        Me.txtsumSN.Size = New System.Drawing.Size(57, 24)
        Me.txtsumSN.TabIndex = 26
        Me.txtsumSN.TabStop = False
        Me.txtsumSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtsumSN, "จำนวน SN ที่นำเข้า")
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(100, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 16)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "จำนวนสั่งซื้อ"
        '
        'txtsumBuy
        '
        Me.txtsumBuy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsumBuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtsumBuy.ForeColor = System.Drawing.Color.Maroon
        Me.txtsumBuy.Location = New System.Drawing.Point(171, 5)
        Me.txtsumBuy.Name = "txtsumBuy"
        Me.txtsumBuy.ReadOnly = True
        Me.txtsumBuy.Size = New System.Drawing.Size(54, 24)
        Me.txtsumBuy.TabIndex = 22
        Me.txtsumBuy.TabStop = False
        Me.txtsumBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Green
        Me.Label8.Location = New System.Drawing.Point(231, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "จำนวนนำเข้า"
        '
        'txtsumBC
        '
        Me.txtsumBC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsumBC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtsumBC.ForeColor = System.Drawing.Color.Green
        Me.txtsumBC.Location = New System.Drawing.Point(303, 5)
        Me.txtsumBC.Name = "txtsumBC"
        Me.txtsumBC.ReadOnly = True
        Me.txtsumBC.Size = New System.Drawing.Size(58, 24)
        Me.txtsumBC.TabIndex = 20
        Me.txtsumBC.TabStop = False
        Me.txtsumBC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtRPnamePro)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(494, 31)
        Me.Panel3.TabIndex = 2
        '
        'txtRPnamePro
        '
        Me.txtRPnamePro.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRPnamePro.BackColor = System.Drawing.Color.Black
        Me.txtRPnamePro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRPnamePro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRPnamePro.ForeColor = System.Drawing.Color.White
        Me.txtRPnamePro.Location = New System.Drawing.Point(3, 3)
        Me.txtRPnamePro.Name = "txtRPnamePro"
        Me.txtRPnamePro.ReadOnly = True
        Me.txtRPnamePro.Size = New System.Drawing.Size(488, 24)
        Me.txtRPnamePro.TabIndex = 30
        Me.txtRPnamePro.TabStop = False
        Me.txtRPnamePro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgRPsn
        '
        Me.dgRPsn.AllowUserToAddRows = False
        Me.dgRPsn.AllowUserToDeleteRows = False
        Me.dgRPsn.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgRPsn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRPsn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.serial_pro, Me.namepro, Me.codepro})
        Me.dgRPsn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgRPsn.Location = New System.Drawing.Point(0, 27)
        Me.dgRPsn.MultiSelect = False
        Me.dgRPsn.Name = "dgRPsn"
        Me.dgRPsn.ReadOnly = True
        Me.dgRPsn.RowHeadersVisible = False
        Me.dgRPsn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRPsn.Size = New System.Drawing.Size(282, 378)
        Me.dgRPsn.TabIndex = 0
        Me.dgRPsn.TabStop = False
        '
        'serial_pro
        '
        Me.serial_pro.DataPropertyName = "serial_pro"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        Me.serial_pro.DefaultCellStyle = DataGridViewCellStyle7
        Me.serial_pro.Frozen = True
        Me.serial_pro.HeaderText = "SerialNumber"
        Me.serial_pro.Name = "serial_pro"
        Me.serial_pro.ReadOnly = True
        Me.serial_pro.ToolTipText = "หมายเลขประจำตัวสินค้า"
        Me.serial_pro.Width = 80
        '
        'namepro
        '
        Me.namepro.DataPropertyName = "name_pro"
        Me.namepro.HeaderText = "ชื่อสินค้า"
        Me.namepro.Name = "namepro"
        Me.namepro.ReadOnly = True
        Me.namepro.Width = 200
        '
        'codepro
        '
        Me.codepro.DataPropertyName = "code_pro"
        Me.codepro.HeaderText = "รหัสสินค้า"
        Me.codepro.Name = "codepro"
        Me.codepro.ReadOnly = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.btnRPdelSN)
        Me.Panel4.Controls.Add(Me.btnRPaddSN)
        Me.Panel4.Controls.Add(Me.txtRPserialPro)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(282, 27)
        Me.Panel4.TabIndex = 206
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 16)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "SN"
        '
        'btnRPdelSN
        '
        Me.btnRPdelSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRPdelSN.Location = New System.Drawing.Point(245, 3)
        Me.btnRPdelSN.Name = "btnRPdelSN"
        Me.btnRPdelSN.Size = New System.Drawing.Size(34, 23)
        Me.btnRPdelSN.TabIndex = 2
        Me.btnRPdelSN.TabStop = False
        Me.btnRPdelSN.Text = "ลบ"
        Me.ToolTip1.SetToolTip(Me.btnRPdelSN, "ลบสินค้าแบบ SN")
        Me.btnRPdelSN.UseVisualStyleBackColor = True
        '
        'btnRPaddSN
        '
        Me.btnRPaddSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRPaddSN.Location = New System.Drawing.Point(198, 3)
        Me.btnRPaddSN.Name = "btnRPaddSN"
        Me.btnRPaddSN.Size = New System.Drawing.Size(41, 23)
        Me.btnRPaddSN.TabIndex = 1
        Me.btnRPaddSN.TabStop = False
        Me.btnRPaddSN.Text = "เพิ่ม"
        Me.ToolTip1.SetToolTip(Me.btnRPaddSN, "เพิ่มสินค้าแบบ SN")
        Me.btnRPaddSN.UseVisualStyleBackColor = True
        '
        'txtRPserialPro
        '
        Me.txtRPserialPro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRPserialPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRPserialPro.Location = New System.Drawing.Point(70, 3)
        Me.txtRPserialPro.Name = "txtRPserialPro"
        Me.txtRPserialPro.Size = New System.Drawing.Size(122, 22)
        Me.txtRPserialPro.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Timer2
        '
        Me.Timer2.Interval = 5000
        '
        'Picture_allTableAdapter1
        '
        Me.Picture_allTableAdapter1.ClearBeforeFill = True
        '
        'Picture_allDataSet1
        '
        Me.Picture_allDataSet1.DataSetName = "Picture_allDataSet"
        Me.Picture_allDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnHelp
        '
        Me.btnHelp.AutoToolTip = True
        Me.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnHelp.Image = Global.ServiceTicker.My.Resources.Resources._109_AllAnnotations_Help_16x16_72
        Me.btnHelp.IsLink = True
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(16, 17)
        Me.btnHelp.ToolTipText = "Help"
        '
        'ReceiveProductFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.MinimumSize = New System.Drawing.Size(400, 400)
        Me.Name = "ReceiveProductFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รับสินค้าเข้าระบบ"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgRPorderPro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgRPsn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.Picture_allDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRPselectOrder As System.Windows.Forms.Button
    Friend WithEvents txtRSorderID As System.Windows.Forms.TextBox
    Friend WithEvents cbRPstatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblRPStatus As System.Windows.Forms.Label
    Friend WithEvents txtRPbillID As System.Windows.Forms.TextBox
    Friend WithEvents lblRPbillID As System.Windows.Forms.Label
    Friend WithEvents txtRPbuy_id As System.Windows.Forms.TextBox
    Friend WithEvents txtRPsale_company_name As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRPid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnRPclear As System.Windows.Forms.Button
    Friend WithEvents btnRPsave As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgRPorderPro As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtRPnamePro As System.Windows.Forms.TextBox
    Friend WithEvents dgRPsn As System.Windows.Forms.DataGridView
    Friend WithEvents serial_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namepro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codepro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnRPaddBCnum As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnRPdelBarcode As System.Windows.Forms.Button
    Friend WithEvents btnRPaddBarcode As System.Windows.Forms.Button
    Friend WithEvents txtRPbarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnRPdelSN As System.Windows.Forms.Button
    Friend WithEvents btnRPaddSN As System.Windows.Forms.Button
    Friend WithEvents txtRPserialPro As System.Windows.Forms.TextBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtRPsumMoney As System.Windows.Forms.TextBox
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents count_num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents จำนวนรับSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_all As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtRPsale_company_id As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtsumBuy As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtsumBC As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtsumSN As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents lblPercen As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents btnAttactBill As System.Windows.Forms.Button
    Friend WithEvents lblAttactBill As System.Windows.Forms.LinkLabel
    Friend WithEvents Picture_allTableAdapter1 As ServiceTicker.Picture_allDataSetTableAdapters.picture_allTableAdapter
    Friend WithEvents Picture_allDataSet1 As ServiceTicker.Picture_allDataSet
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
