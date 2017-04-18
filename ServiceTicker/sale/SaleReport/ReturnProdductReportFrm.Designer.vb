<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnProdductReportFrm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblemployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgReportRepairAll = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fix_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_all = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deline = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.return_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.return_note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtRRrowsALL = New System.Windows.Forms.TextBox()
        Me.txtmoneyALL = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPrintALL = New System.Windows.Forms.Button()
        Me.lblRRcashStatus = New System.Windows.Forms.Label()
        Me.cbbRRcashstatusAll = New System.Windows.Forms.ComboBox()
        Me.btnRRdisplayDataAll = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker2All = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1All = New System.Windows.Forms.DateTimePicker()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dgReportRepair = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.return_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bar_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discountbypro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.declinebypro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_all_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtRRrows = New System.Windows.Forms.TextBox()
        Me.txtmoney = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnRRdisplayData = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgReportRepairAll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dgReportRepair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblemployee, Me.btnHelp})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblemployee
        '
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(30, 17)
        Me.lblemployee.Text = "User"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(784, 539)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(776, 513)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "รายงานการคืนสินค้า รวม"
        Me.TabPage1.ToolTipText = "รายงานการคืนสินค้า รวม"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgReportRepairAll)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 57)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(770, 416)
        Me.Panel3.TabIndex = 2
        '
        'dgReportRepairAll
        '
        Me.dgReportRepairAll.AllowUserToAddRows = False
        Me.dgReportRepairAll.AllowUserToDeleteRows = False
        Me.dgReportRepairAll.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgReportRepairAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgReportRepairAll.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.sale_id, Me.fix_id, Me.customer_id, Me.customer_name, Me.total_all, Me.discount, Me.deline, Me.return_status, Me.return_note, Me.datetime_save, Me.employee})
        Me.dgReportRepairAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgReportRepairAll.Location = New System.Drawing.Point(0, 0)
        Me.dgReportRepairAll.Name = "dgReportRepairAll"
        Me.dgReportRepairAll.ReadOnly = True
        Me.dgReportRepairAll.RowHeadersVisible = False
        Me.dgReportRepairAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgReportRepairAll.Size = New System.Drawing.Size(770, 416)
        Me.dgReportRepairAll.TabIndex = 30
        '
        'no
        '
        Me.no.DataPropertyName = "no"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.no.DefaultCellStyle = DataGridViewCellStyle1
        Me.no.Frozen = True
        Me.no.HeaderText = "#"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.ToolTipText = "ลำดับ"
        Me.no.Width = 30
        '
        'sale_id
        '
        Me.sale_id.DataPropertyName = "sale_id"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.sale_id.DefaultCellStyle = DataGridViewCellStyle2
        Me.sale_id.Frozen = True
        Me.sale_id.HeaderText = "รหัสใบเบิก"
        Me.sale_id.Name = "sale_id"
        Me.sale_id.ReadOnly = True
        Me.sale_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.sale_id.ToolTipText = "รหัสใบเบิกสินค้า"
        Me.sale_id.Width = 120
        '
        'fix_id
        '
        Me.fix_id.DataPropertyName = "fix_id"
        Me.fix_id.HeaderText = "รหัสใบซ่อม"
        Me.fix_id.Name = "fix_id"
        Me.fix_id.ReadOnly = True
        Me.fix_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fix_id.ToolTipText = "รหัสใบรับซ่อม"
        Me.fix_id.Width = 120
        '
        'customer_id
        '
        Me.customer_id.DataPropertyName = "customer_id"
        Me.customer_id.HeaderText = "รหัสลูกค้า"
        Me.customer_id.Name = "customer_id"
        Me.customer_id.ReadOnly = True
        Me.customer_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.customer_id.ToolTipText = "รหัสลูกค้า"
        Me.customer_id.Width = 120
        '
        'customer_name
        '
        Me.customer_name.DataPropertyName = "customer_name"
        Me.customer_name.HeaderText = "ชื่อลูกค้า"
        Me.customer_name.Name = "customer_name"
        Me.customer_name.ReadOnly = True
        Me.customer_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.customer_name.ToolTipText = "ชื่อลูกค้า"
        Me.customer_name.Width = 130
        '
        'total_all
        '
        Me.total_all.DataPropertyName = "total_all"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.total_all.DefaultCellStyle = DataGridViewCellStyle3
        Me.total_all.HeaderText = "ราคา"
        Me.total_all.Name = "total_all"
        Me.total_all.ReadOnly = True
        Me.total_all.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_all.ToolTipText = "ราคา"
        Me.total_all.Width = 70
        '
        'discount
        '
        Me.discount.HeaderText = "ส่วนลด"
        Me.discount.Name = "discount"
        Me.discount.ReadOnly = True
        Me.discount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'deline
        '
        Me.deline.HeaderText = "ค่าเสื่อมราคา"
        Me.deline.Name = "deline"
        Me.deline.ReadOnly = True
        Me.deline.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'return_status
        '
        Me.return_status.DataPropertyName = "return_status"
        Me.return_status.HeaderText = "คืนเป็น"
        Me.return_status.Name = "return_status"
        Me.return_status.ReadOnly = True
        Me.return_status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.return_status.Width = 70
        '
        'return_note
        '
        Me.return_note.DataPropertyName = "return_note"
        Me.return_note.HeaderText = "เหตุผล"
        Me.return_note.Name = "return_note"
        Me.return_note.ReadOnly = True
        Me.return_note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.return_note.ToolTipText = "เหตุผลที่ตืนสินค้า"
        Me.return_note.Width = 150
        '
        'datetime_save
        '
        Me.datetime_save.DataPropertyName = "datetime_save"
        Me.datetime_save.HeaderText = "วันที่คืน"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        Me.datetime_save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.datetime_save.ToolTipText = "วันที่รับคืน"
        Me.datetime_save.Width = 120
        '
        'employee
        '
        Me.employee.DataPropertyName = "employee"
        Me.employee.HeaderText = "พนักงาน"
        Me.employee.Name = "employee"
        Me.employee.ReadOnly = True
        Me.employee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.employee.ToolTipText = "พนักงานรับคืน"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtRRrowsALL)
        Me.Panel2.Controls.Add(Me.txtmoneyALL)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 473)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(770, 37)
        Me.Panel2.TabIndex = 1
        '
        'txtRRrowsALL
        '
        Me.txtRRrowsALL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtRRrowsALL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRRrowsALL.Location = New System.Drawing.Point(4, 5)
        Me.txtRRrowsALL.Name = "txtRRrowsALL"
        Me.txtRRrowsALL.ReadOnly = True
        Me.txtRRrowsALL.Size = New System.Drawing.Size(308, 29)
        Me.txtRRrowsALL.TabIndex = 34
        Me.txtRRrowsALL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtmoneyALL
        '
        Me.txtmoneyALL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmoneyALL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtmoneyALL.Location = New System.Drawing.Point(318, 5)
        Me.txtmoneyALL.Name = "txtmoneyALL"
        Me.txtmoneyALL.ReadOnly = True
        Me.txtmoneyALL.Size = New System.Drawing.Size(446, 29)
        Me.txtmoneyALL.TabIndex = 33
        Me.txtmoneyALL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnPrintALL)
        Me.Panel1.Controls.Add(Me.lblRRcashStatus)
        Me.Panel1.Controls.Add(Me.cbbRRcashstatusAll)
        Me.Panel1.Controls.Add(Me.btnRRdisplayDataAll)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DateTimePicker2All)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DateTimePicker1All)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(770, 54)
        Me.Panel1.TabIndex = 0
        '
        'btnPrintALL
        '
        Me.btnPrintALL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintALL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPrintALL.Location = New System.Drawing.Point(648, 2)
        Me.btnPrintALL.Name = "btnPrintALL"
        Me.btnPrintALL.Size = New System.Drawing.Size(116, 42)
        Me.btnPrintALL.TabIndex = 43
        Me.btnPrintALL.Text = "พิมพ์"
        Me.btnPrintALL.UseVisualStyleBackColor = True
        '
        'lblRRcashStatus
        '
        Me.lblRRcashStatus.AutoSize = True
        Me.lblRRcashStatus.Location = New System.Drawing.Point(274, 6)
        Me.lblRRcashStatus.Name = "lblRRcashStatus"
        Me.lblRRcashStatus.Size = New System.Drawing.Size(38, 13)
        Me.lblRRcashStatus.TabIndex = 42
        Me.lblRRcashStatus.Text = "สถานะ"
        '
        'cbbRRcashstatusAll
        '
        Me.cbbRRcashstatusAll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbRRcashstatusAll.FormattingEnabled = True
        Me.cbbRRcashstatusAll.Location = New System.Drawing.Point(318, 2)
        Me.cbbRRcashstatusAll.Name = "cbbRRcashstatusAll"
        Me.cbbRRcashstatusAll.Size = New System.Drawing.Size(181, 21)
        Me.cbbRRcashstatusAll.TabIndex = 41
        '
        'btnRRdisplayDataAll
        '
        Me.btnRRdisplayDataAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRRdisplayDataAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRRdisplayDataAll.Location = New System.Drawing.Point(505, 2)
        Me.btnRRdisplayDataAll.Name = "btnRRdisplayDataAll"
        Me.btnRRdisplayDataAll.Size = New System.Drawing.Size(137, 42)
        Me.btnRRdisplayDataAll.TabIndex = 40
        Me.btnRRdisplayDataAll.Text = "แสดงผล"
        Me.btnRRdisplayDataAll.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "ถึงวันที่"
        '
        'DateTimePicker2All
        '
        Me.DateTimePicker2All.Location = New System.Drawing.Point(56, 29)
        Me.DateTimePicker2All.Name = "DateTimePicker2All"
        Me.DateTimePicker2All.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2All.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "จากวันที่"
        '
        'DateTimePicker1All
        '
        Me.DateTimePicker1All.Location = New System.Drawing.Point(56, 3)
        Me.DateTimePicker1All.Name = "DateTimePicker1All"
        Me.DateTimePicker1All.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1All.TabIndex = 36
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel6)
        Me.TabPage2.Controls.Add(Me.Panel5)
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(776, 513)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "รายงานคืนสินค้าแบบแสดงรายชื่อสินค้า"
        Me.TabPage2.ToolTipText = "รายงานคืนสินค้าแบบแสดงรายชื่อสินค้า"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.dgReportRepair)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 56)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(770, 416)
        Me.Panel6.TabIndex = 2
        '
        'dgReportRepair
        '
        Me.dgReportRepair.AllowUserToAddRows = False
        Me.dgReportRepair.AllowUserToDeleteRows = False
        Me.dgReportRepair.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgReportRepair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgReportRepair.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.return_id, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.bar_code, Me.name_pro, Me.total_pro, Me.price_buy, Me.discountbypro, Me.declinebypro, Me.total_all_buy, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.status})
        Me.dgReportRepair.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgReportRepair.Location = New System.Drawing.Point(0, 0)
        Me.dgReportRepair.Name = "dgReportRepair"
        Me.dgReportRepair.ReadOnly = True
        Me.dgReportRepair.RowHeadersVisible = False
        Me.dgReportRepair.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgReportRepair.Size = New System.Drawing.Size(770, 416)
        Me.dgReportRepair.TabIndex = 30
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "no"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn1.HeaderText = "#"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.ToolTipText = "ลำดับ"
        Me.DataGridViewTextBoxColumn1.Width = 30
        '
        'return_id
        '
        Me.return_id.DataPropertyName = "return_id"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        Me.return_id.DefaultCellStyle = DataGridViewCellStyle5
        Me.return_id.HeaderText = "เลขส่งคืน"
        Me.return_id.Name = "return_id"
        Me.return_id.ReadOnly = True
        Me.return_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.return_id.ToolTipText = "เลขใบส่งคืน"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "sale_id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "เลขใบขาย"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.ToolTipText = "เลขใบเบิก/ขาย"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fix_id"
        Me.DataGridViewTextBoxColumn3.HeaderText = "เลขใบซ่อม"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.ToolTipText = "เลขใบส่งซ่อม"
        '
        'bar_code
        '
        Me.bar_code.DataPropertyName = "bar_code"
        Me.bar_code.HeaderText = "บาร์โค๊ต"
        Me.bar_code.Name = "bar_code"
        Me.bar_code.ReadOnly = True
        Me.bar_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.bar_code.ToolTipText = "บาร์โค๊ต"
        '
        'name_pro
        '
        Me.name_pro.DataPropertyName = "name_pro"
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro.ToolTipText = "ชื่อสินค้า"
        Me.name_pro.Width = 200
        '
        'total_pro
        '
        Me.total_pro.DataPropertyName = "total_pro"
        DataGridViewCellStyle6.NullValue = "0"
        Me.total_pro.DefaultCellStyle = DataGridViewCellStyle6
        Me.total_pro.HeaderText = "จำนวน"
        Me.total_pro.Name = "total_pro"
        Me.total_pro.ReadOnly = True
        Me.total_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_pro.ToolTipText = "จำนวน"
        Me.total_pro.Width = 70
        '
        'price_buy
        '
        Me.price_buy.DataPropertyName = "price_buy"
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = "0"
        Me.price_buy.DefaultCellStyle = DataGridViewCellStyle7
        Me.price_buy.HeaderText = "ราคาขาย"
        Me.price_buy.Name = "price_buy"
        Me.price_buy.ReadOnly = True
        Me.price_buy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_buy.ToolTipText = "ราคาขาย"
        Me.price_buy.Width = 70
        '
        'discountbypro
        '
        Me.discountbypro.HeaderText = "ส่วนลด"
        Me.discountbypro.Name = "discountbypro"
        Me.discountbypro.ReadOnly = True
        Me.discountbypro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'declinebypro
        '
        Me.declinebypro.HeaderText = "เสื่อมราคา"
        Me.declinebypro.Name = "declinebypro"
        Me.declinebypro.ReadOnly = True
        Me.declinebypro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'total_all_buy
        '
        Me.total_all_buy.DataPropertyName = "total_all_buy"
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = "0"
        Me.total_all_buy.DefaultCellStyle = DataGridViewCellStyle8
        Me.total_all_buy.HeaderText = "รวมขาย"
        Me.total_all_buy.Name = "total_all_buy"
        Me.total_all_buy.ReadOnly = True
        Me.total_all_buy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_all_buy.ToolTipText = "รวมราคาขาย"
        Me.total_all_buy.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "datetime_save"
        Me.DataGridViewTextBoxColumn4.HeaderText = "วันที่"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.ToolTipText = "วันที่บันทึก"
        Me.DataGridViewTextBoxColumn4.Width = 120
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "พนักงาน"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'status
        '
        Me.status.HeaderText = "สถานะ"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.status.Width = 70
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtRRrows)
        Me.Panel5.Controls.Add(Me.txtmoney)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(3, 472)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(770, 38)
        Me.Panel5.TabIndex = 1
        '
        'txtRRrows
        '
        Me.txtRRrows.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtRRrows.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRRrows.Location = New System.Drawing.Point(5, 6)
        Me.txtRRrows.Name = "txtRRrows"
        Me.txtRRrows.ReadOnly = True
        Me.txtRRrows.Size = New System.Drawing.Size(257, 29)
        Me.txtRRrows.TabIndex = 34
        Me.txtRRrows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtmoney
        '
        Me.txtmoney.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtmoney.Location = New System.Drawing.Point(268, 6)
        Me.txtmoney.Name = "txtmoney"
        Me.txtmoney.ReadOnly = True
        Me.txtmoney.Size = New System.Drawing.Size(497, 29)
        Me.txtmoney.TabIndex = 33
        Me.txtmoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnPrint)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.ComboBox1)
        Me.Panel4.Controls.Add(Me.btnRRdisplayData)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.DateTimePicker2)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.DateTimePicker1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(770, 53)
        Me.Panel4.TabIndex = 0
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(630, 7)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(137, 42)
        Me.btnPrint.TabIndex = 43
        Me.btnPrint.Text = "พิมพ์"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(265, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "สถานะ"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(309, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(150, 21)
        Me.ComboBox1.TabIndex = 41
        '
        'btnRRdisplayData
        '
        Me.btnRRdisplayData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRRdisplayData.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRRdisplayData.Location = New System.Drawing.Point(487, 7)
        Me.btnRRdisplayData.Name = "btnRRdisplayData"
        Me.btnRRdisplayData.Size = New System.Drawing.Size(137, 42)
        Me.btnRRdisplayData.TabIndex = 40
        Me.btnRRdisplayData.Text = "แสดงผล"
        Me.btnRRdisplayData.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "ถึงวันที่"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(56, 29)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "จากวันที่"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(56, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 36
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
        'ReturnProdductReportFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "ReturnProdductReportFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายงานการคืนสินค้า"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgReportRepairAll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.dgReportRepair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblemployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtRRrowsALL As System.Windows.Forms.TextBox
    Friend WithEvents txtmoneyALL As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPrintALL As System.Windows.Forms.Button
    Friend WithEvents lblRRcashStatus As System.Windows.Forms.Label
    Friend WithEvents cbbRRcashstatusAll As System.Windows.Forms.ComboBox
    Friend WithEvents btnRRdisplayDataAll As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2All As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1All As System.Windows.Forms.DateTimePicker
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgReportRepairAll As System.Windows.Forms.DataGridView
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents dgReportRepair As System.Windows.Forms.DataGridView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtRRrows As System.Windows.Forms.TextBox
    Friend WithEvents txtmoney As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnRRdisplayData As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents return_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bar_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents discountbypro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents declinebypro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_all_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fix_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_all As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents discount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents deline As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents return_status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents return_note As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
