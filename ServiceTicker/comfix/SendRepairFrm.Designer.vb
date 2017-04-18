<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SendRepairFrm
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSRgetDataByFixID = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSRgetDataByFixID = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblSRcustomerDetail = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSRcusname = New System.Windows.Forms.Label()
        Me.txtSRsale_id = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtHideform = New System.Windows.Forms.TextBox()
        Me.txtSRstatus = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DateTimePickerSRR = New System.Windows.Forms.DateTimePicker()
        Me.btnSRsaveAndSend = New System.Windows.Forms.Button()
        Me.lblSRpayment = New System.Windows.Forms.Label()
        Me.cbbSRRcash_status = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtSRfixAccessory = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSRfixRepairNote = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSRfixPrice = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgSRsale_detail = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_all = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgSRsale_detail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.btnHelp})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 484)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(519, 22)
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
        Me.Panel1.Controls.Add(Me.btnSRgetDataByFixID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtSRgetDataByFixID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(519, 32)
        Me.Panel1.TabIndex = 0
        '
        'btnSRgetDataByFixID
        '
        Me.btnSRgetDataByFixID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSRgetDataByFixID.Location = New System.Drawing.Point(440, 4)
        Me.btnSRgetDataByFixID.Name = "btnSRgetDataByFixID"
        Me.btnSRgetDataByFixID.Size = New System.Drawing.Size(67, 26)
        Me.btnSRgetDataByFixID.TabIndex = 1
        Me.btnSRgetDataByFixID.Text = "ค้นหา"
        Me.btnSRgetDataByFixID.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "เลขใบรับซ่อม"
        '
        'txtSRgetDataByFixID
        '
        Me.txtSRgetDataByFixID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSRgetDataByFixID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSRgetDataByFixID.ForeColor = System.Drawing.Color.Navy
        Me.txtSRgetDataByFixID.Location = New System.Drawing.Point(107, 3)
        Me.txtSRgetDataByFixID.Name = "txtSRgetDataByFixID"
        Me.txtSRgetDataByFixID.Size = New System.Drawing.Size(327, 26)
        Me.txtSRgetDataByFixID.TabIndex = 0
        Me.txtSRgetDataByFixID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblSRcustomerDetail)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.lblSRcusname)
        Me.Panel2.Controls.Add(Me.txtSRsale_id)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(519, 93)
        Me.Panel2.TabIndex = 1
        '
        'lblSRcustomerDetail
        '
        Me.lblSRcustomerDetail.AutoSize = True
        Me.lblSRcustomerDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSRcustomerDetail.Location = New System.Drawing.Point(65, 2)
        Me.lblSRcustomerDetail.Name = "lblSRcustomerDetail"
        Me.lblSRcustomerDetail.Size = New System.Drawing.Size(12, 16)
        Me.lblSRcustomerDetail.TabIndex = 1
        Me.lblSRcustomerDetail.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(227, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "เลขที่ใบเบิกสินค้า"
        '
        'lblSRcusname
        '
        Me.lblSRcusname.AutoSize = True
        Me.lblSRcusname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSRcusname.ForeColor = System.Drawing.Color.Navy
        Me.lblSRcusname.Location = New System.Drawing.Point(14, 2)
        Me.lblSRcusname.Name = "lblSRcusname"
        Me.lblSRcusname.Size = New System.Drawing.Size(51, 16)
        Me.lblSRcusname.TabIndex = 0
        Me.lblSRcusname.Text = "ชื่อลูกค้า"
        '
        'txtSRsale_id
        '
        Me.txtSRsale_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSRsale_id.Location = New System.Drawing.Point(319, 68)
        Me.txtSRsale_id.Name = "txtSRsale_id"
        Me.txtSRsale_id.ReadOnly = True
        Me.txtSRsale_id.Size = New System.Drawing.Size(197, 22)
        Me.txtSRsale_id.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtHideform)
        Me.Panel3.Controls.Add(Me.txtSRstatus)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.DateTimePickerSRR)
        Me.Panel3.Controls.Add(Me.btnSRsaveAndSend)
        Me.Panel3.Controls.Add(Me.lblSRpayment)
        Me.Panel3.Controls.Add(Me.cbbSRRcash_status)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.txtSRfixAccessory)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.txtSRfixRepairNote)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.txtSRfixPrice)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 249)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(519, 235)
        Me.Panel3.TabIndex = 2
        '
        'txtHideform
        '
        Me.txtHideform.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtHideform.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtHideform.ForeColor = System.Drawing.Color.Navy
        Me.txtHideform.Location = New System.Drawing.Point(85, 3)
        Me.txtHideform.Name = "txtHideform"
        Me.txtHideform.ReadOnly = True
        Me.txtHideform.Size = New System.Drawing.Size(287, 26)
        Me.txtHideform.TabIndex = 0
        Me.txtHideform.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSRstatus
        '
        Me.txtSRstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSRstatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSRstatus.Location = New System.Drawing.Point(370, 3)
        Me.txtSRstatus.Name = "txtSRstatus"
        Me.txtSRstatus.ReadOnly = True
        Me.txtSRstatus.Size = New System.Drawing.Size(146, 26)
        Me.txtSRstatus.TabIndex = 1
        Me.txtSRstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.Location = New System.Drawing.Point(3, 189)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(105, 20)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "วันที่นัดชำระเงิน"
        '
        'DateTimePickerSRR
        '
        Me.DateTimePickerSRR.Location = New System.Drawing.Point(114, 189)
        Me.DateTimePickerSRR.Name = "DateTimePickerSRR"
        Me.DateTimePickerSRR.Size = New System.Drawing.Size(143, 20)
        Me.DateTimePickerSRR.TabIndex = 6
        '
        'btnSRsaveAndSend
        '
        Me.btnSRsaveAndSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSRsaveAndSend.Enabled = False
        Me.btnSRsaveAndSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSRsaveAndSend.Location = New System.Drawing.Point(263, 153)
        Me.btnSRsaveAndSend.Name = "btnSRsaveAndSend"
        Me.btnSRsaveAndSend.Size = New System.Drawing.Size(253, 56)
        Me.btnSRsaveAndSend.TabIndex = 7
        Me.btnSRsaveAndSend.Text = "คืนสินค้า"
        Me.btnSRsaveAndSend.UseVisualStyleBackColor = True
        '
        'lblSRpayment
        '
        Me.lblSRpayment.AutoSize = True
        Me.lblSRpayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSRpayment.Location = New System.Drawing.Point(3, 160)
        Me.lblSRpayment.Name = "lblSRpayment"
        Me.lblSRpayment.Size = New System.Drawing.Size(84, 20)
        Me.lblSRpayment.TabIndex = 11
        Me.lblSRpayment.Text = "การชำระเงิน"
        '
        'cbbSRRcash_status
        '
        Me.cbbSRRcash_status.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbbSRRcash_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbSRRcash_status.FormattingEnabled = True
        Me.cbbSRRcash_status.Location = New System.Drawing.Point(93, 162)
        Me.cbbSRRcash_status.Name = "cbbSRRcash_status"
        Me.cbbSRRcash_status.Size = New System.Drawing.Size(164, 21)
        Me.cbbSRRcash_status.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(3, 101)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(121, 20)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "อุปกรณ์ที่นำมาด้วย"
        '
        'txtSRfixAccessory
        '
        Me.txtSRfixAccessory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSRfixAccessory.Location = New System.Drawing.Point(130, 98)
        Me.txtSRfixAccessory.Name = "txtSRfixAccessory"
        Me.txtSRfixAccessory.ReadOnly = True
        Me.txtSRfixAccessory.Size = New System.Drawing.Size(386, 26)
        Me.txtSRfixAccessory.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 20)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "ผลการซ่อม"
        '
        'txtSRfixRepairNote
        '
        Me.txtSRfixRepairNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSRfixRepairNote.Location = New System.Drawing.Point(85, 28)
        Me.txtSRfixRepairNote.Multiline = True
        Me.txtSRfixRepairNote.Name = "txtSRfixRepairNote"
        Me.txtSRfixRepairNote.ReadOnly = True
        Me.txtSRfixRepairNote.Size = New System.Drawing.Size(431, 64)
        Me.txtSRfixRepairNote.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 133)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 20)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "ราคา"
        '
        'txtSRfixPrice
        '
        Me.txtSRfixPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSRfixPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSRfixPrice.Location = New System.Drawing.Point(48, 130)
        Me.txtSRfixPrice.Name = "txtSRfixPrice"
        Me.txtSRfixPrice.ReadOnly = True
        Me.txtSRfixPrice.Size = New System.Drawing.Size(209, 26)
        Me.txtSRfixPrice.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dgSRsale_detail)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 125)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(519, 124)
        Me.Panel4.TabIndex = 4
        '
        'dgSRsale_detail
        '
        Me.dgSRsale_detail.AllowUserToAddRows = False
        Me.dgSRsale_detail.AllowUserToDeleteRows = False
        Me.dgSRsale_detail.AllowUserToOrderColumns = True
        Me.dgSRsale_detail.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgSRsale_detail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgSRsale_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSRsale_detail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.code_pro, Me.name_pro, Me.total_pro, Me.unit, Me.price_buy, Me.total_all})
        Me.dgSRsale_detail.Cursor = System.Windows.Forms.Cursors.No
        Me.dgSRsale_detail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSRsale_detail.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgSRsale_detail.Location = New System.Drawing.Point(0, 0)
        Me.dgSRsale_detail.Name = "dgSRsale_detail"
        Me.dgSRsale_detail.ReadOnly = True
        Me.dgSRsale_detail.RowHeadersVisible = False
        Me.dgSRsale_detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSRsale_detail.Size = New System.Drawing.Size(519, 124)
        Me.dgSRsale_detail.TabIndex = 0
        '
        'no
        '
        Me.no.Frozen = True
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.Width = 30
        '
        'code_pro
        '
        Me.code_pro.DataPropertyName = "code_pro"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        Me.code_pro.DefaultCellStyle = DataGridViewCellStyle5
        Me.code_pro.Frozen = True
        Me.code_pro.HeaderText = "รหัสสินค้า"
        Me.code_pro.Name = "code_pro"
        Me.code_pro.ReadOnly = True
        Me.code_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.code_pro.ToolTipText = "รหัสสินค้า"
        Me.code_pro.Width = 80
        '
        'name_pro
        '
        Me.name_pro.DataPropertyName = "name_pro"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.name_pro.DefaultCellStyle = DataGridViewCellStyle6
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro.ToolTipText = "ชื่อสินค้า"
        Me.name_pro.Width = 170
        '
        'total_pro
        '
        Me.total_pro.DataPropertyName = "total_pro"
        Me.total_pro.HeaderText = "จำนวน"
        Me.total_pro.Name = "total_pro"
        Me.total_pro.ReadOnly = True
        Me.total_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_pro.ToolTipText = "จำนวนสินค้าที่เบิก"
        Me.total_pro.Width = 50
        '
        'unit
        '
        Me.unit.DataPropertyName = "unit"
        Me.unit.HeaderText = "หน่วย"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        Me.unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.unit.ToolTipText = "หน่วยนับสินค้า"
        Me.unit.Width = 50
        '
        'price_buy
        '
        Me.price_buy.DataPropertyName = "price_buy"
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = "0"
        Me.price_buy.DefaultCellStyle = DataGridViewCellStyle7
        Me.price_buy.HeaderText = "ราคา"
        Me.price_buy.Name = "price_buy"
        Me.price_buy.ReadOnly = True
        Me.price_buy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_buy.Width = 40
        '
        'total_all
        '
        Me.total_all.DataPropertyName = "total_all"
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = "0"
        Me.total_all.DefaultCellStyle = DataGridViewCellStyle8
        Me.total_all.HeaderText = "รวมราคา"
        Me.total_all.Name = "total_all"
        Me.total_all.ReadOnly = True
        Me.total_all.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_all.Width = 60
        '
        'SendRepairFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 506)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(535, 545)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(535, 545)
        Me.Name = "SendRepairFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ส่งคืนงานซ่อม"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgSRsale_detail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSRgetDataByFixID As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSRgetDataByFixID As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblSRcustomerDetail As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSRcusname As System.Windows.Forms.Label
    Friend WithEvents txtSRsale_id As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtHideform As System.Windows.Forms.TextBox
    Friend WithEvents txtSRstatus As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerSRR As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSRsaveAndSend As System.Windows.Forms.Button
    Friend WithEvents lblSRpayment As System.Windows.Forms.Label
    Friend WithEvents cbbSRRcash_status As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtSRfixAccessory As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtSRfixRepairNote As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtSRfixPrice As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents dgSRsale_detail As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_all As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
