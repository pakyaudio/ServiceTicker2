<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchRepairFrm
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnForward = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSRsearch = New System.Windows.Forms.Button()
        Me.cbbSRsearchAll = New System.Windows.Forms.ComboBox()
        Me.txtSRsearch = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgSRshowComfix = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fix_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.symptom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.managerdata = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_get = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.note_repair = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.teltocus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.dgSRdetail = New System.Windows.Forms.DataGridView()
        Me.title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.titleDetail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuDetailSale = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuSaleDetail = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuDetailCashSale = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuDeatilCashSale = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuReturnProduct = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuReturnProduct = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgSRshowComfix, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.dgSRdetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.ContextMenuDetailSale.SuspendLayout()
        Me.ContextMenuDetailCashSale.SuspendLayout()
        Me.ContextMenuReturnProduct.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.btnHelp})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
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
        Me.btnHelp.Image = Global.ServiceTicker.My.Resources.Resources._109_AllAnnotations_Help_16x16_72
        Me.btnHelp.IsLink = True
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(16, 17)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnForward)
        Me.Panel1.Controls.Add(Me.NumericUpDown1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnSRsearch)
        Me.Panel1.Controls.Add(Me.cbbSRsearchAll)
        Me.Panel1.Controls.Add(Me.txtSRsearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 34)
        Me.Panel1.TabIndex = 0
        '
        'btnForward
        '
        Me.btnForward.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnForward.Enabled = False
        Me.btnForward.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnForward.Image = Global.ServiceTicker.My.Resources.Resources.AzureMySQLDatabase_color_16x
        Me.btnForward.Location = New System.Drawing.Point(676, 4)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(105, 26)
        Me.btnForward.TabIndex = 5
        Me.btnForward.Text = "โหลดข้อมูลเพิ่ม"
        Me.btnForward.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnForward.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown1.Location = New System.Drawing.Point(524, 7)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(70, 20)
        Me.NumericUpDown1.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.NumericUpDown1, "ลิมิตการโหลดข้อมูล")
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(600, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "0"
        Me.ToolTip1.SetToolTip(Me.Label2, "จำนวแถวที่แสดง/จำนวนทั้งหมด")
        '
        'btnSRsearch
        '
        Me.btnSRsearch.BackgroundImage = Global.ServiceTicker.My.Resources.Resources.Search_32x
        Me.btnSRsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSRsearch.Location = New System.Drawing.Point(321, 3)
        Me.btnSRsearch.Name = "btnSRsearch"
        Me.btnSRsearch.Size = New System.Drawing.Size(27, 27)
        Me.btnSRsearch.TabIndex = 1
        Me.btnSRsearch.UseVisualStyleBackColor = True
        '
        'cbbSRsearchAll
        '
        Me.cbbSRsearchAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbSRsearchAll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbSRsearchAll.FormattingEnabled = True
        Me.cbbSRsearchAll.Location = New System.Drawing.Point(374, 6)
        Me.cbbSRsearchAll.Name = "cbbSRsearchAll"
        Me.cbbSRsearchAll.Size = New System.Drawing.Size(144, 21)
        Me.cbbSRsearchAll.TabIndex = 2
        '
        'txtSRsearch
        '
        Me.txtSRsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSRsearch.Location = New System.Drawing.Point(3, 3)
        Me.txtSRsearch.Name = "txtSRsearch"
        Me.txtSRsearch.Size = New System.Drawing.Size(312, 26)
        Me.txtSRsearch.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 34)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgSRshowComfix)
        Me.SplitContainer1.Panel1MinSize = 100
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2MinSize = 100
        Me.SplitContainer1.Size = New System.Drawing.Size(784, 505)
        Me.SplitContainer1.SplitterDistance = 174
        Me.SplitContainer1.TabIndex = 2
        '
        'dgSRshowComfix
        '
        Me.dgSRshowComfix.AllowUserToAddRows = False
        Me.dgSRshowComfix.AllowUserToDeleteRows = False
        Me.dgSRshowComfix.AllowUserToOrderColumns = True
        Me.dgSRshowComfix.AllowUserToResizeRows = False
        Me.dgSRshowComfix.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgSRshowComfix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSRshowComfix.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.fix_id, Me.customer_id, Me.customer_name, Me.SN, Me.symptom, Me.managerdata, Me.date_save, Me.date_get, Me.status, Me.note_repair, Me.teltocus})
        Me.dgSRshowComfix.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSRshowComfix.Location = New System.Drawing.Point(0, 0)
        Me.dgSRshowComfix.MultiSelect = False
        Me.dgSRshowComfix.Name = "dgSRshowComfix"
        Me.dgSRshowComfix.ReadOnly = True
        Me.dgSRshowComfix.RowHeadersVisible = False
        Me.dgSRshowComfix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSRshowComfix.Size = New System.Drawing.Size(782, 172)
        Me.dgSRshowComfix.TabIndex = 0
        '
        'no
        '
        Me.no.DataPropertyName = "no"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        Me.no.DefaultCellStyle = DataGridViewCellStyle3
        Me.no.Frozen = True
        Me.no.HeaderText = "#"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.ToolTipText = "ลำดับ"
        Me.no.Width = 30
        '
        'fix_id
        '
        Me.fix_id.DataPropertyName = "fix_id"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        Me.fix_id.DefaultCellStyle = DataGridViewCellStyle4
        Me.fix_id.Frozen = True
        Me.fix_id.HeaderText = "รหัสใบซ่อม"
        Me.fix_id.Name = "fix_id"
        Me.fix_id.ReadOnly = True
        Me.fix_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fix_id.Width = 120
        '
        'customer_id
        '
        Me.customer_id.DataPropertyName = "customer_id"
        Me.customer_id.HeaderText = "รหัสลูกค้า"
        Me.customer_id.Name = "customer_id"
        Me.customer_id.ReadOnly = True
        Me.customer_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.customer_id.Width = 120
        '
        'customer_name
        '
        Me.customer_name.DataPropertyName = "customer_name"
        Me.customer_name.HeaderText = "ชื่อลูกค้า"
        Me.customer_name.Name = "customer_name"
        Me.customer_name.ReadOnly = True
        Me.customer_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'SN
        '
        Me.SN.DataPropertyName = "SN"
        Me.SN.HeaderText = "SN"
        Me.SN.Name = "SN"
        Me.SN.ReadOnly = True
        Me.SN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SN.ToolTipText = "หมายเลขเครื่อง"
        '
        'symptom
        '
        Me.symptom.DataPropertyName = "symptom"
        Me.symptom.HeaderText = "อาการเสีย"
        Me.symptom.Name = "symptom"
        Me.symptom.ReadOnly = True
        Me.symptom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'managerdata
        '
        Me.managerdata.DataPropertyName = "managerdata"
        Me.managerdata.HeaderText = "การจัดการข้อมูล"
        Me.managerdata.Name = "managerdata"
        Me.managerdata.ReadOnly = True
        Me.managerdata.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'date_save
        '
        Me.date_save.DataPropertyName = "date_save"
        Me.date_save.HeaderText = "วันที่รับเครื่อง"
        Me.date_save.Name = "date_save"
        Me.date_save.ReadOnly = True
        Me.date_save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'date_get
        '
        Me.date_get.DataPropertyName = "date_get"
        Me.date_get.HeaderText = "นัดรับ"
        Me.date_get.Name = "date_get"
        Me.date_get.ReadOnly = True
        Me.date_get.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.date_get.ToolTipText = "วันที่นัดรับเครื่องซ่อม"
        '
        'status
        '
        Me.status.DataPropertyName = "status"
        Me.status.HeaderText = "สถานะ"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.status.Width = 70
        '
        'note_repair
        '
        Me.note_repair.DataPropertyName = "note_repair"
        Me.note_repair.HeaderText = "รายละเอียด"
        Me.note_repair.Name = "note_repair"
        Me.note_repair.ReadOnly = True
        Me.note_repair.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.note_repair.ToolTipText = "รายละเอียดที่ช่างได้ซ่อมอะไรไปบ้าง"
        '
        'teltocus
        '
        Me.teltocus.DataPropertyName = "teltocus"
        Me.teltocus.HeaderText = "โทรแจ้ง"
        Me.teltocus.Name = "teltocus"
        Me.teltocus.ReadOnly = True
        Me.teltocus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.teltocus.ToolTipText = "สถานะการโทรแจ้งลูกค้าให้ทราบ"
        Me.teltocus.Width = 80
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.dgSRdetail)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer2.Size = New System.Drawing.Size(784, 327)
        Me.SplitContainer2.SplitterDistance = 176
        Me.SplitContainer2.TabIndex = 33
        '
        'dgSRdetail
        '
        Me.dgSRdetail.AllowUserToAddRows = False
        Me.dgSRdetail.AllowUserToDeleteRows = False
        Me.dgSRdetail.AllowUserToOrderColumns = True
        Me.dgSRdetail.AllowUserToResizeRows = False
        Me.dgSRdetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgSRdetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgSRdetail.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgSRdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSRdetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.title, Me.titleDetail, Me.detail})
        Me.dgSRdetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSRdetail.Location = New System.Drawing.Point(0, 0)
        Me.dgSRdetail.MultiSelect = False
        Me.dgSRdetail.Name = "dgSRdetail"
        Me.dgSRdetail.RowHeadersVisible = False
        Me.dgSRdetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgSRdetail.Size = New System.Drawing.Size(782, 174)
        Me.dgSRdetail.TabIndex = 0
        '
        'title
        '
        Me.title.FillWeight = 200.0!
        Me.title.HeaderText = "หัวข้อ"
        Me.title.Name = "title"
        Me.title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'titleDetail
        '
        Me.titleDetail.FillWeight = 150.0!
        Me.titleDetail.HeaderText = "รายละเอียดหัวข้อ"
        Me.titleDetail.Name = "titleDetail"
        Me.titleDetail.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.titleDetail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'detail
        '
        Me.detail.FillWeight = 500.0!
        Me.detail.HeaderText = "รายละเอียด"
        Me.detail.Name = "detail"
        Me.detail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(388, 105)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 109)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(782, 36)
        Me.Panel2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(603, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "ส่งคืนสินค้า"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "* คลิ๊กขวาเพื่อแสดงรายละเอียด"
        '
        'ContextMenuDetailSale
        '
        Me.ContextMenuDetailSale.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuSaleDetail})
        Me.ContextMenuDetailSale.Name = "ContextMenuDetailSale"
        Me.ContextMenuDetailSale.Size = New System.Drawing.Size(157, 26)
        '
        'ToolStripMenuSaleDetail
        '
        Me.ToolStripMenuSaleDetail.Image = Global.ServiceTicker.My.Resources.Resources.WorkItem_16x
        Me.ToolStripMenuSaleDetail.Name = "ToolStripMenuSaleDetail"
        Me.ToolStripMenuSaleDetail.Size = New System.Drawing.Size(156, 22)
        Me.ToolStripMenuSaleDetail.Text = "ดูรายการเบิกสินค้า"
        '
        'ContextMenuDetailCashSale
        '
        Me.ContextMenuDetailCashSale.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuDeatilCashSale})
        Me.ContextMenuDetailCashSale.Name = "ContextMenuDetailSale"
        Me.ContextMenuDetailCashSale.Size = New System.Drawing.Size(157, 26)
        '
        'ToolStripMenuDeatilCashSale
        '
        Me.ToolStripMenuDeatilCashSale.Image = Global.ServiceTicker.My.Resources.Resources.WorkItem_16x
        Me.ToolStripMenuDeatilCashSale.Name = "ToolStripMenuDeatilCashSale"
        Me.ToolStripMenuDeatilCashSale.Size = New System.Drawing.Size(156, 22)
        Me.ToolStripMenuDeatilCashSale.Text = "ดูรายการเบิกสินค้า"
        '
        'ContextMenuReturnProduct
        '
        Me.ContextMenuReturnProduct.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuReturnProduct})
        Me.ContextMenuReturnProduct.Name = "ContextMenuDetailSale"
        Me.ContextMenuReturnProduct.Size = New System.Drawing.Size(154, 26)
        '
        'ToolStripMenuReturnProduct
        '
        Me.ToolStripMenuReturnProduct.Image = Global.ServiceTicker.My.Resources.Resources.WorkItem_16x
        Me.ToolStripMenuReturnProduct.Name = "ToolStripMenuReturnProduct"
        Me.ToolStripMenuReturnProduct.Size = New System.Drawing.Size(153, 22)
        Me.ToolStripMenuReturnProduct.Text = "ดูรายการสินค้าคืน"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.ListView1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.ListView2)
        Me.SplitContainer3.Size = New System.Drawing.Size(782, 109)
        Me.SplitContainer3.SplitterDistance = 392
        Me.SplitContainer3.TabIndex = 2
        '
        'ListView2
        '
        Me.ListView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView2.Location = New System.Drawing.Point(0, 0)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(382, 105)
        Me.ListView2.TabIndex = 0
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'SearchRepairFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.MinimumSize = New System.Drawing.Size(200, 100)
        Me.Name = "SearchRepairFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ค้นหางานซ่อม"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgSRshowComfix, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.dgSRdetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ContextMenuDetailSale.ResumeLayout(False)
        Me.ContextMenuDetailCashSale.ResumeLayout(False)
        Me.ContextMenuReturnProduct.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSRsearch As System.Windows.Forms.Button
    Friend WithEvents cbbSRsearchAll As System.Windows.Forms.ComboBox
    Friend WithEvents txtSRsearch As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgSRshowComfix As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fix_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents symptom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents managerdata As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_get As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents note_repair As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents teltocus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgSRdetail As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ContextMenuDetailSale As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuSaleDetail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuDetailCashSale As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuDeatilCashSale As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents title As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents titleDetail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents detail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuReturnProduct As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuReturnProduct As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnForward As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
End Class
