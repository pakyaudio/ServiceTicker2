<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportUserRepairFrm
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRURsearch = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbbRURselectUser = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRUprint = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRURdiscount = New System.Windows.Forms.TextBox()
        Me.txtRURrows = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblRURprofit = New System.Windows.Forms.Label()
        Me.lblRURbuy = New System.Windows.Forms.Label()
        Me.lblRURcost = New System.Windows.Forms.Label()
        Me.txtRURtotalProfit = New System.Windows.Forms.TextBox()
        Me.txtRURtotalBuy = New System.Windows.Forms.TextBox()
        Me.txtRURtotalCost = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgRUR = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fix_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgRUR, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnHelp.ToolTipText = "Help"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnRURsearch)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cbbRURselectUser)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 62)
        Me.Panel1.TabIndex = 0
        '
        'btnRURsearch
        '
        Me.btnRURsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRURsearch.Location = New System.Drawing.Point(602, 3)
        Me.btnRURsearch.Name = "btnRURsearch"
        Me.btnRURsearch.Size = New System.Drawing.Size(170, 47)
        Me.btnRURsearch.TabIndex = 3
        Me.btnRURsearch.Text = "ค้นหา"
        Me.btnRURsearch.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(388, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ชื่อผู้ซ่อม"
        '
        'cbbRURselectUser
        '
        Me.cbbRURselectUser.FormattingEnabled = True
        Me.cbbRURselectUser.Location = New System.Drawing.Point(441, 7)
        Me.cbbRURselectUser.Name = "cbbRURselectUser"
        Me.cbbRURselectUser.Size = New System.Drawing.Size(155, 21)
        Me.cbbRURselectUser.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ถึง"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "จาก"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker2.Location = New System.Drawing.Point(38, 38)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(282, 20)
        Me.DateTimePicker2.TabIndex = 1
        Me.DateTimePicker2.Value = New Date(2015, 1, 30, 0, 0, 0, 0)
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy MMMM dd"
        Me.DateTimePicker1.Location = New System.Drawing.Point(38, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(282, 20)
        Me.DateTimePicker1.TabIndex = 0
        Me.DateTimePicker1.Value = New Date(2015, 1, 30, 0, 0, 0, 0)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnRUprint)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtRURdiscount)
        Me.Panel2.Controls.Add(Me.txtRURrows)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.lblRURprofit)
        Me.Panel2.Controls.Add(Me.lblRURbuy)
        Me.Panel2.Controls.Add(Me.lblRURcost)
        Me.Panel2.Controls.Add(Me.txtRURtotalProfit)
        Me.Panel2.Controls.Add(Me.txtRURtotalBuy)
        Me.Panel2.Controls.Add(Me.txtRURtotalCost)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 450)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 89)
        Me.Panel2.TabIndex = 1
        '
        'btnRUprint
        '
        Me.btnRUprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRUprint.BackgroundImage = Global.ServiceTicker.My.Resources.Resources.PrintStatusBar2_16x
        Me.btnRUprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRUprint.Location = New System.Drawing.Point(718, 6)
        Me.btnRUprint.Name = "btnRUprint"
        Me.btnRUprint.Size = New System.Drawing.Size(55, 29)
        Me.btnRUprint.TabIndex = 5
        Me.btnRUprint.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(566, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "รวมส่วนลด"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(516, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "-"
        '
        'txtRURdiscount
        '
        Me.txtRURdiscount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRURdiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRURdiscount.Location = New System.Drawing.Point(532, 41)
        Me.txtRURdiscount.Name = "txtRURdiscount"
        Me.txtRURdiscount.ReadOnly = True
        Me.txtRURdiscount.Size = New System.Drawing.Size(108, 29)
        Me.txtRURdiscount.TabIndex = 3
        Me.txtRURdiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRURrows
        '
        Me.txtRURrows.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRURrows.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRURrows.Location = New System.Drawing.Point(9, 41)
        Me.txtRURrows.Name = "txtRURrows"
        Me.txtRURrows.ReadOnly = True
        Me.txtRURrows.Size = New System.Drawing.Size(237, 29)
        Me.txtRURrows.TabIndex = 0
        Me.txtRURrows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(386, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "-"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(646, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "="
        '
        'lblRURprofit
        '
        Me.lblRURprofit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRURprofit.AutoSize = True
        Me.lblRURprofit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblRURprofit.Location = New System.Drawing.Point(704, 72)
        Me.lblRURprofit.Name = "lblRURprofit"
        Me.lblRURprofit.Size = New System.Drawing.Size(35, 13)
        Me.lblRURprofit.TabIndex = 27
        Me.lblRURprofit.Text = "กำไร"
        '
        'lblRURbuy
        '
        Me.lblRURbuy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRURbuy.AutoSize = True
        Me.lblRURbuy.Location = New System.Drawing.Point(293, 72)
        Me.lblRURbuy.Name = "lblRURbuy"
        Me.lblRURbuy.Size = New System.Drawing.Size(67, 13)
        Me.lblRURbuy.TabIndex = 26
        Me.lblRURbuy.Text = "รวมราคาขาย"
        '
        'lblRURcost
        '
        Me.lblRURcost.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRURcost.AutoSize = True
        Me.lblRURcost.Location = New System.Drawing.Point(425, 72)
        Me.lblRURcost.Name = "lblRURcost"
        Me.lblRURcost.Size = New System.Drawing.Size(64, 13)
        Me.lblRURcost.TabIndex = 25
        Me.lblRURcost.Text = "รวมราคาทุน"
        '
        'txtRURtotalProfit
        '
        Me.txtRURtotalProfit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRURtotalProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRURtotalProfit.Location = New System.Drawing.Point(665, 41)
        Me.txtRURtotalProfit.Name = "txtRURtotalProfit"
        Me.txtRURtotalProfit.ReadOnly = True
        Me.txtRURtotalProfit.Size = New System.Drawing.Size(108, 29)
        Me.txtRURtotalProfit.TabIndex = 4
        Me.txtRURtotalProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRURtotalBuy
        '
        Me.txtRURtotalBuy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRURtotalBuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRURtotalBuy.Location = New System.Drawing.Point(272, 41)
        Me.txtRURtotalBuy.Name = "txtRURtotalBuy"
        Me.txtRURtotalBuy.ReadOnly = True
        Me.txtRURtotalBuy.Size = New System.Drawing.Size(108, 29)
        Me.txtRURtotalBuy.TabIndex = 1
        Me.txtRURtotalBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRURtotalCost
        '
        Me.txtRURtotalCost.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRURtotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRURtotalCost.Location = New System.Drawing.Point(402, 41)
        Me.txtRURtotalCost.Name = "txtRURtotalCost"
        Me.txtRURtotalCost.ReadOnly = True
        Me.txtRURtotalCost.Size = New System.Drawing.Size(108, 29)
        Me.txtRURtotalCost.TabIndex = 2
        Me.txtRURtotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgRUR)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 62)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(784, 388)
        Me.Panel3.TabIndex = 3
        '
        'dgRUR
        '
        Me.dgRUR.AllowUserToAddRows = False
        Me.dgRUR.AllowUserToDeleteRows = False
        Me.dgRUR.AllowUserToOrderColumns = True
        Me.dgRUR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgRUR.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgRUR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRUR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.fix_id, Me.customer_name, Me.code_pro, Me.name_pro, Me.total_pro, Me.price_cost, Me.price_buy, Me.discount, Me.total_cost, Me.total_buy, Me.datetime_save})
        Me.dgRUR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgRUR.Location = New System.Drawing.Point(0, 0)
        Me.dgRUR.Name = "dgRUR"
        Me.dgRUR.ReadOnly = True
        Me.dgRUR.RowHeadersVisible = False
        Me.dgRUR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRUR.Size = New System.Drawing.Size(784, 388)
        Me.dgRUR.TabIndex = 0
        '
        'no
        '
        Me.no.DataPropertyName = "no"
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        Me.no.DefaultCellStyle = DataGridViewCellStyle8
        Me.no.FillWeight = 30.0!
        Me.no.HeaderText = "#"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.ToolTipText = "ลำดับ"
        '
        'fix_id
        '
        Me.fix_id.DataPropertyName = "fix_id"
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        Me.fix_id.DefaultCellStyle = DataGridViewCellStyle9
        Me.fix_id.FillWeight = 90.51525!
        Me.fix_id.HeaderText = "รหัสใบซ่อม"
        Me.fix_id.Name = "fix_id"
        Me.fix_id.ReadOnly = True
        Me.fix_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fix_id.ToolTipText = "รหัสใบซ่อม"
        '
        'customer_name
        '
        Me.customer_name.DataPropertyName = "customer_name"
        Me.customer_name.FillWeight = 90.51525!
        Me.customer_name.HeaderText = "ชื่อลูกค้า"
        Me.customer_name.Name = "customer_name"
        Me.customer_name.ReadOnly = True
        Me.customer_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.customer_name.ToolTipText = "ชื่อลูกค้า"
        '
        'code_pro
        '
        Me.code_pro.DataPropertyName = "code_pro"
        Me.code_pro.FillWeight = 90.51525!
        Me.code_pro.HeaderText = "รหัสสินค้า"
        Me.code_pro.Name = "code_pro"
        Me.code_pro.ReadOnly = True
        Me.code_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.code_pro.ToolTipText = "รหัสสินค้า"
        '
        'name_pro
        '
        Me.name_pro.DataPropertyName = "name_pro"
        Me.name_pro.FillWeight = 90.51525!
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro.ToolTipText = "ชื่อสินค้า"
        '
        'total_pro
        '
        Me.total_pro.DataPropertyName = "total_pro"
        Me.total_pro.FillWeight = 90.51525!
        Me.total_pro.HeaderText = "จำนวน"
        Me.total_pro.Name = "total_pro"
        Me.total_pro.ReadOnly = True
        Me.total_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_pro.ToolTipText = "จำนวนสินค้าที่ขาย/เบิก"
        '
        'price_cost
        '
        Me.price_cost.DataPropertyName = "price_cost"
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = "0"
        Me.price_cost.DefaultCellStyle = DataGridViewCellStyle10
        Me.price_cost.FillWeight = 90.51525!
        Me.price_cost.HeaderText = "ทุน"
        Me.price_cost.Name = "price_cost"
        Me.price_cost.ReadOnly = True
        Me.price_cost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_cost.ToolTipText = "ราคาทุน"
        '
        'price_buy
        '
        Me.price_buy.DataPropertyName = "price_buy"
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = "0"
        Me.price_buy.DefaultCellStyle = DataGridViewCellStyle11
        Me.price_buy.FillWeight = 90.51525!
        Me.price_buy.HeaderText = "ขาย"
        Me.price_buy.Name = "price_buy"
        Me.price_buy.ReadOnly = True
        Me.price_buy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_buy.ToolTipText = "ราคาขาย"
        '
        'discount
        '
        DataGridViewCellStyle12.Format = "N2"
        DataGridViewCellStyle12.NullValue = "0"
        Me.discount.DefaultCellStyle = DataGridViewCellStyle12
        Me.discount.FillWeight = 90.51525!
        Me.discount.HeaderText = "ลด"
        Me.discount.Name = "discount"
        Me.discount.ReadOnly = True
        Me.discount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.discount.ToolTipText = "ส่วนลดสินค้า/บริการ"
        '
        'total_cost
        '
        Me.total_cost.DataPropertyName = "total_cost"
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = "0"
        Me.total_cost.DefaultCellStyle = DataGridViewCellStyle13
        Me.total_cost.FillWeight = 90.51525!
        Me.total_cost.HeaderText = "รวมทุน"
        Me.total_cost.Name = "total_cost"
        Me.total_cost.ReadOnly = True
        Me.total_cost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_cost.ToolTipText = "รวมราคาทุน"
        '
        'total_buy
        '
        Me.total_buy.DataPropertyName = "total_buy"
        DataGridViewCellStyle14.Format = "N2"
        DataGridViewCellStyle14.NullValue = "0"
        Me.total_buy.DefaultCellStyle = DataGridViewCellStyle14
        Me.total_buy.FillWeight = 90.51525!
        Me.total_buy.HeaderText = "รวมขาย"
        Me.total_buy.Name = "total_buy"
        Me.total_buy.ReadOnly = True
        Me.total_buy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_buy.ToolTipText = "รวมราคาขาย"
        '
        'datetime_save
        '
        Me.datetime_save.DataPropertyName = "datetime_save"
        Me.datetime_save.FillWeight = 90.51525!
        Me.datetime_save.HeaderText = "วันที่"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        Me.datetime_save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.datetime_save.ToolTipText = "วันที่ส่งคืนเครื่อง"
        '
        'ReportUserRepairFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "ReportUserRepairFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายงานการซ่อมตามชื่อผู้ซ่อม"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgRUR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnRURsearch As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbbRURselectUser As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnRUprint As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRURdiscount As System.Windows.Forms.TextBox
    Friend WithEvents txtRURrows As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblRURprofit As System.Windows.Forms.Label
    Friend WithEvents lblRURbuy As System.Windows.Forms.Label
    Friend WithEvents lblRURcost As System.Windows.Forms.Label
    Friend WithEvents txtRURtotalProfit As System.Windows.Forms.TextBox
    Friend WithEvents txtRURtotalBuy As System.Windows.Forms.TextBox
    Friend WithEvents txtRURtotalCost As System.Windows.Forms.TextBox
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgRUR As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fix_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents discount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
