<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportRepairFrm
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lblRRcashStatus = New System.Windows.Forms.Label()
        Me.cbbRRcashstatus = New System.Windows.Forms.ComboBox()
        Me.btnRRdisplayData = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgReportRepair = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fix_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_all = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRRttp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRRttd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRRviewProduct = New System.Windows.Forms.Button()
        Me.txtRRrows = New System.Windows.Forms.TextBox()
        Me.txtmoney = New System.Windows.Forms.TextBox()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgReportRepair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
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
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.lblRRcashStatus)
        Me.Panel1.Controls.Add(Me.cbbRRcashstatus)
        Me.Panel1.Controls.Add(Me.btnRRdisplayData)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 54)
        Me.Panel1.TabIndex = 0
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(666, 3)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(115, 42)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "พิมพ์"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'lblRRcashStatus
        '
        Me.lblRRcashStatus.AutoSize = True
        Me.lblRRcashStatus.Location = New System.Drawing.Point(278, 7)
        Me.lblRRcashStatus.Name = "lblRRcashStatus"
        Me.lblRRcashStatus.Size = New System.Drawing.Size(38, 13)
        Me.lblRRcashStatus.TabIndex = 29
        Me.lblRRcashStatus.Text = "สถานะ"
        '
        'cbbRRcashstatus
        '
        Me.cbbRRcashstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbRRcashstatus.FormattingEnabled = True
        Me.cbbRRcashstatus.Location = New System.Drawing.Point(322, 3)
        Me.cbbRRcashstatus.Name = "cbbRRcashstatus"
        Me.cbbRRcashstatus.Size = New System.Drawing.Size(227, 21)
        Me.cbbRRcashstatus.TabIndex = 2
        '
        'btnRRdisplayData
        '
        Me.btnRRdisplayData.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRRdisplayData.Location = New System.Drawing.Point(555, 3)
        Me.btnRRdisplayData.Name = "btnRRdisplayData"
        Me.btnRRdisplayData.Size = New System.Drawing.Size(105, 42)
        Me.btnRRdisplayData.TabIndex = 3
        Me.btnRRdisplayData.Text = "แสดงผล"
        Me.btnRRdisplayData.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "ถึงวันที่"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(60, 30)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "จากวันที่"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(60, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgReportRepair)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 430)
        Me.Panel2.TabIndex = 2
        '
        'dgReportRepair
        '
        Me.dgReportRepair.AllowUserToAddRows = False
        Me.dgReportRepair.AllowUserToDeleteRows = False
        Me.dgReportRepair.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgReportRepair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgReportRepair.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.sale_id, Me.fix_id, Me.customer_id, Me.customer_name, Me.total_all, Me.discount, Me.datetime_save})
        Me.dgReportRepair.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgReportRepair.Location = New System.Drawing.Point(0, 0)
        Me.dgReportRepair.Name = "dgReportRepair"
        Me.dgReportRepair.RowHeadersVisible = False
        Me.dgReportRepair.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgReportRepair.Size = New System.Drawing.Size(784, 430)
        Me.dgReportRepair.TabIndex = 8
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
        Me.sale_id.HeaderText = "เลขใบเบิก"
        Me.sale_id.Name = "sale_id"
        Me.sale_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.sale_id.ToolTipText = "เลขใบเบิกสินค้า"
        Me.sale_id.Width = 130
        '
        'fix_id
        '
        Me.fix_id.DataPropertyName = "fix_id"
        Me.fix_id.HeaderText = "เลขใบซ่อม"
        Me.fix_id.Name = "fix_id"
        Me.fix_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fix_id.ToolTipText = "เลขที่ใบรับซ่อม"
        Me.fix_id.Width = 130
        '
        'customer_id
        '
        Me.customer_id.DataPropertyName = "customer_id"
        Me.customer_id.HeaderText = "รหัสลูกค้า"
        Me.customer_id.Name = "customer_id"
        Me.customer_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.customer_id.ToolTipText = "รหัสลูกค้า"
        Me.customer_id.Width = 130
        '
        'customer_name
        '
        Me.customer_name.DataPropertyName = "customer_name"
        Me.customer_name.HeaderText = "ชื่อลูกค้า"
        Me.customer_name.Name = "customer_name"
        Me.customer_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.customer_name.ToolTipText = "ชื่อลูกค้า"
        Me.customer_name.Width = 150
        '
        'total_all
        '
        Me.total_all.DataPropertyName = "total_all"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.total_all.DefaultCellStyle = DataGridViewCellStyle3
        Me.total_all.HeaderText = "จำนวนเงิน"
        Me.total_all.Name = "total_all"
        Me.total_all.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_all.ToolTipText = "จำนวนเงิน"
        Me.total_all.Width = 70
        '
        'discount
        '
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.discount.DefaultCellStyle = DataGridViewCellStyle4
        Me.discount.HeaderText = "ลด"
        Me.discount.Name = "discount"
        Me.discount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.discount.ToolTipText = "ส่วนลดการขาย"
        Me.discount.Width = 50
        '
        'datetime_save
        '
        Me.datetime_save.DataPropertyName = "datetime_save"
        Me.datetime_save.HeaderText = "วันที่ทำรายการ"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.datetime_save.ToolTipText = "วันที่ทำรายการ"
        Me.datetime_save.Width = 130
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txtRRttp)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.txtRRttd)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.btnRRviewProduct)
        Me.Panel3.Controls.Add(Me.txtRRrows)
        Me.Panel3.Controls.Add(Me.txtmoney)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 484)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(784, 55)
        Me.Panel3.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(402, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "รวมยอดราคาสินค้า"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(560, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "รวมส่วนลด"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(514, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "-"
        '
        'txtRRttp
        '
        Me.txtRRttp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRRttp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRRttp.Location = New System.Drawing.Point(395, 6)
        Me.txtRRttp.Name = "txtRRttp"
        Me.txtRRttp.ReadOnly = True
        Me.txtRRttp.Size = New System.Drawing.Size(113, 29)
        Me.txtRRttp.TabIndex = 2
        Me.txtRRttp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(649, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "="
        '
        'txtRRttd
        '
        Me.txtRRttd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRRttd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRRttd.Location = New System.Drawing.Point(530, 6)
        Me.txtRRttd.Name = "txtRRttd"
        Me.txtRRttd.ReadOnly = True
        Me.txtRRttd.Size = New System.Drawing.Size(113, 29)
        Me.txtRRttd.TabIndex = 3
        Me.txtRRttd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(700, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "รวมทั้งหมด"
        '
        'btnRRviewProduct
        '
        Me.btnRRviewProduct.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRRviewProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRRviewProduct.Location = New System.Drawing.Point(3, 8)
        Me.btnRRviewProduct.Name = "btnRRviewProduct"
        Me.btnRRviewProduct.Size = New System.Drawing.Size(142, 29)
        Me.btnRRviewProduct.TabIndex = 0
        Me.btnRRviewProduct.Text = "ดูรายการสินค้า"
        Me.btnRRviewProduct.UseVisualStyleBackColor = True
        '
        'txtRRrows
        '
        Me.txtRRrows.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRRrows.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRRrows.Location = New System.Drawing.Point(205, 6)
        Me.txtRRrows.Name = "txtRRrows"
        Me.txtRRrows.ReadOnly = True
        Me.txtRRrows.Size = New System.Drawing.Size(175, 29)
        Me.txtRRrows.TabIndex = 1
        Me.txtRRrows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtmoney
        '
        Me.txtmoney.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtmoney.Location = New System.Drawing.Point(668, 6)
        Me.txtmoney.Name = "txtmoney"
        Me.txtmoney.ReadOnly = True
        Me.txtmoney.Size = New System.Drawing.Size(113, 29)
        Me.txtmoney.TabIndex = 4
        Me.txtmoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ReportRepairFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "ReportRepairFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายงานเบิกสินค้า(ตามวันที่)"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgReportRepair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents lblRRcashStatus As System.Windows.Forms.Label
    Friend WithEvents cbbRRcashstatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnRRdisplayData As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgReportRepair As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRRttp As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRRttd As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnRRviewProduct As System.Windows.Forms.Button
    Friend WithEvents txtRRrows As System.Windows.Forms.TextBox
    Friend WithEvents txtmoney As System.Windows.Forms.TextBox
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fix_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_all As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents discount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
