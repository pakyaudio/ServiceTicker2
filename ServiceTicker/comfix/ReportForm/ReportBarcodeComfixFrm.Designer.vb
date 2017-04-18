<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportBarcodeComfixFrm
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
        Me.txtmoney = New System.Windows.Forms.TextBox()
        Me.txtRRrows = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgReportRepair = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bar_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_all_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_all_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgReportRepair, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(784, 63)
        Me.Panel1.TabIndex = 0
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(665, 3)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(116, 42)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "พิมพ์"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'lblRRcashStatus
        '
        Me.lblRRcashStatus.AutoSize = True
        Me.lblRRcashStatus.Location = New System.Drawing.Point(275, 16)
        Me.lblRRcashStatus.Name = "lblRRcashStatus"
        Me.lblRRcashStatus.Size = New System.Drawing.Size(38, 13)
        Me.lblRRcashStatus.TabIndex = 31
        Me.lblRRcashStatus.Text = "สถานะ"
        '
        'cbbRRcashstatus
        '
        Me.cbbRRcashstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbRRcashstatus.FormattingEnabled = True
        Me.cbbRRcashstatus.Location = New System.Drawing.Point(319, 12)
        Me.cbbRRcashstatus.Name = "cbbRRcashstatus"
        Me.cbbRRcashstatus.Size = New System.Drawing.Size(197, 21)
        Me.cbbRRcashstatus.TabIndex = 2
        '
        'btnRRdisplayData
        '
        Me.btnRRdisplayData.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRRdisplayData.Location = New System.Drawing.Point(522, 3)
        Me.btnRRdisplayData.Name = "btnRRdisplayData"
        Me.btnRRdisplayData.Size = New System.Drawing.Size(137, 42)
        Me.btnRRdisplayData.TabIndex = 3
        Me.btnRRdisplayData.Text = "แสดงผล"
        Me.btnRRdisplayData.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "ถึงวันที่"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(57, 39)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "จากวันที่"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(57, 13)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtmoney)
        Me.Panel2.Controls.Add(Me.txtRRrows)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 509)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 30)
        Me.Panel2.TabIndex = 2
        '
        'txtmoney
        '
        Me.txtmoney.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtmoney.Location = New System.Drawing.Point(281, 5)
        Me.txtmoney.Name = "txtmoney"
        Me.txtmoney.ReadOnly = True
        Me.txtmoney.Size = New System.Drawing.Size(500, 22)
        Me.txtmoney.TabIndex = 23
        Me.txtmoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRRrows
        '
        Me.txtRRrows.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtRRrows.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRRrows.Location = New System.Drawing.Point(3, 5)
        Me.txtRRrows.Name = "txtRRrows"
        Me.txtRRrows.ReadOnly = True
        Me.txtRRrows.Size = New System.Drawing.Size(272, 22)
        Me.txtRRrows.TabIndex = 22
        Me.txtRRrows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgReportRepair)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 63)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(784, 446)
        Me.Panel3.TabIndex = 3
        '
        'dgReportRepair
        '
        Me.dgReportRepair.AllowUserToAddRows = False
        Me.dgReportRepair.AllowUserToDeleteRows = False
        Me.dgReportRepair.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgReportRepair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgReportRepair.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.code_pro, Me.bar_code, Me.name_pro, Me.total_pro, Me.price_cost, Me.price_buy, Me.total_all_cost, Me.total_all_buy, Me.datetime_save})
        Me.dgReportRepair.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgReportRepair.Location = New System.Drawing.Point(0, 0)
        Me.dgReportRepair.Name = "dgReportRepair"
        Me.dgReportRepair.RowHeadersVisible = False
        Me.dgReportRepair.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgReportRepair.Size = New System.Drawing.Size(784, 446)
        Me.dgReportRepair.TabIndex = 19
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
        'code_pro
        '
        Me.code_pro.DataPropertyName = "code_pro"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.code_pro.DefaultCellStyle = DataGridViewCellStyle2
        Me.code_pro.Frozen = True
        Me.code_pro.HeaderText = "รหัสสินค้า"
        Me.code_pro.Name = "code_pro"
        Me.code_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.code_pro.ToolTipText = "รหัสสินค้า"
        '
        'bar_code
        '
        Me.bar_code.DataPropertyName = "bar_code"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        Me.bar_code.DefaultCellStyle = DataGridViewCellStyle3
        Me.bar_code.Frozen = True
        Me.bar_code.HeaderText = "บาร์โค๊ต"
        Me.bar_code.Name = "bar_code"
        Me.bar_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.bar_code.ToolTipText = "บาร์โค๊ต"
        '
        'name_pro
        '
        Me.name_pro.DataPropertyName = "name_pro"
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro.ToolTipText = "ชื่อสินค้า"
        Me.name_pro.Width = 200
        '
        'total_pro
        '
        Me.total_pro.DataPropertyName = "total_pro"
        Me.total_pro.HeaderText = "จำนวน"
        Me.total_pro.Name = "total_pro"
        Me.total_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_pro.ToolTipText = "จำนวน"
        Me.total_pro.Width = 70
        '
        'price_cost
        '
        Me.price_cost.DataPropertyName = "price_cost"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.price_cost.DefaultCellStyle = DataGridViewCellStyle4
        Me.price_cost.HeaderText = "ทุน"
        Me.price_cost.Name = "price_cost"
        Me.price_cost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_cost.ToolTipText = "ราคาทุน"
        Me.price_cost.Width = 70
        '
        'price_buy
        '
        Me.price_buy.DataPropertyName = "price_buy"
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.price_buy.DefaultCellStyle = DataGridViewCellStyle5
        Me.price_buy.HeaderText = "ขาย"
        Me.price_buy.Name = "price_buy"
        Me.price_buy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_buy.ToolTipText = "ราคาขาย"
        Me.price_buy.Width = 70
        '
        'total_all_cost
        '
        Me.total_all_cost.DataPropertyName = "total_all_cost"
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0"
        Me.total_all_cost.DefaultCellStyle = DataGridViewCellStyle6
        Me.total_all_cost.HeaderText = "รวมทุน"
        Me.total_all_cost.Name = "total_all_cost"
        Me.total_all_cost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_all_cost.ToolTipText = "รวมราคาทุน"
        Me.total_all_cost.Width = 70
        '
        'total_all_buy
        '
        Me.total_all_buy.DataPropertyName = "total_all_buy"
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = "0"
        Me.total_all_buy.DefaultCellStyle = DataGridViewCellStyle7
        Me.total_all_buy.HeaderText = "รวมขาย"
        Me.total_all_buy.Name = "total_all_buy"
        Me.total_all_buy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_all_buy.ToolTipText = "รวมราคาขาย"
        Me.total_all_buy.Width = 70
        '
        'datetime_save
        '
        Me.datetime_save.DataPropertyName = "datetime_save"
        Me.datetime_save.HeaderText = "วันที่"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.datetime_save.ToolTipText = "วันที่บันทึก"
        Me.datetime_save.Width = 120
        '
        'ReportBarcodeComfixFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "ReportBarcodeComfixFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายงานเบิกสินค้า แบบแสดงรายการสินค้า(เฉพาะงานช่าง(ไม่รวมงานขาย))"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgReportRepair, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtRRrows As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgReportRepair As System.Windows.Forms.DataGridView
    Friend WithEvents txtmoney As System.Windows.Forms.TextBox
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bar_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_all_cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_all_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
