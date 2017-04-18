<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashFrm
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgCash = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_all = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCcreditTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCashpledgeID = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCashCusID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnCashSave = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnSelectDetail = New System.Windows.Forms.Button()
        Me.lblCashDTP = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCashBack = New System.Windows.Forms.TextBox()
        Me.lblCashSelectPayment = New System.Windows.Forms.Label()
        Me.lblCashSelectPaymentlbl = New System.Windows.Forms.Label()
        Me.txtCashByselectPayment = New System.Windows.Forms.TextBox()
        Me.cbbCashSelectPayment = New System.Windows.Forms.ComboBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtCashCusPrice = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCashLowerCash = New System.Windows.Forms.TextBox()
        Me.txtCashPercen = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtCashCash = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtCashFixID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgCash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 439)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(669, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblEmployee
        '
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(30, 17)
        Me.lblEmployee.Text = "User"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel9)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel8)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel4)
        Me.SplitContainer1.Size = New System.Drawing.Size(669, 439)
        Me.SplitContainer1.SplitterDistance = 299
        Me.SplitContainer1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgCash)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 28)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(297, 349)
        Me.Panel3.TabIndex = 2
        '
        'dgCash
        '
        Me.dgCash.AllowUserToAddRows = False
        Me.dgCash.AllowUserToDeleteRows = False
        Me.dgCash.AllowUserToOrderColumns = True
        Me.dgCash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCash.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.sale_id, Me.datetime_save, Me.total_all})
        Me.dgCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCash.Location = New System.Drawing.Point(0, 0)
        Me.dgCash.MultiSelect = False
        Me.dgCash.Name = "dgCash"
        Me.dgCash.ReadOnly = True
        Me.dgCash.RowHeadersVisible = False
        Me.dgCash.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCash.Size = New System.Drawing.Size(297, 349)
        Me.dgCash.TabIndex = 8
        '
        'no
        '
        Me.no.Frozen = True
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 30
        '
        'sale_id
        '
        Me.sale_id.Frozen = True
        Me.sale_id.HeaderText = "เลขเอกสาร"
        Me.sale_id.Name = "sale_id"
        Me.sale_id.ReadOnly = True
        Me.sale_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.sale_id.ToolTipText = "เลขเอกสารบิลเบิก/ใบลดหนี้"
        Me.sale_id.Width = 110
        '
        'datetime_save
        '
        Me.datetime_save.HeaderText = "วันที่"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        Me.datetime_save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.datetime_save.Width = 70
        '
        'total_all
        '
        Me.total_all.HeaderText = "ยอด"
        Me.total_all.Name = "total_all"
        Me.total_all.ReadOnly = True
        Me.total_all.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_all.Width = 70
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtCcreditTotal)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtCashpledgeID)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 377)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(297, 60)
        Me.Panel2.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 18)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "ยอดรวมค้างชำระ"
        '
        'txtCcreditTotal
        '
        Me.txtCcreditTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCcreditTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCcreditTotal.Location = New System.Drawing.Point(112, 3)
        Me.txtCcreditTotal.Name = "txtCcreditTotal"
        Me.txtCcreditTotal.ReadOnly = True
        Me.txtCcreditTotal.Size = New System.Drawing.Size(183, 26)
        Me.txtCcreditTotal.TabIndex = 29
        Me.txtCcreditTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "เลขบิลมัดจำ"
        '
        'txtCashpledgeID
        '
        Me.txtCashpledgeID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCashpledgeID.Location = New System.Drawing.Point(71, 35)
        Me.txtCashpledgeID.Name = "txtCashpledgeID"
        Me.txtCashpledgeID.ReadOnly = True
        Me.txtCashpledgeID.Size = New System.Drawing.Size(224, 20)
        Me.txtCashpledgeID.TabIndex = 27
        Me.txtCashpledgeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtCashCusID)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(297, 28)
        Me.Panel1.TabIndex = 0
        '
        'txtCashCusID
        '
        Me.txtCashCusID.Location = New System.Drawing.Point(156, 3)
        Me.txtCashCusID.Name = "txtCashCusID"
        Me.txtCashCusID.ReadOnly = True
        Me.txtCashCusID.Size = New System.Drawing.Size(139, 20)
        Me.txtCashCusID.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "ยอดค้างชำระ"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.btnCashSave)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 377)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(364, 60)
        Me.Panel9.TabIndex = 5
        '
        'btnCashSave
        '
        Me.btnCashSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCashSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCashSave.Location = New System.Drawing.Point(0, 0)
        Me.btnCashSave.Name = "btnCashSave"
        Me.btnCashSave.Size = New System.Drawing.Size(364, 60)
        Me.btnCashSave.TabIndex = 6
        Me.btnCashSave.Text = "บันทึกจ่ายเงิน"
        Me.btnCashSave.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.btnSelectDetail)
        Me.Panel8.Controls.Add(Me.lblCashDTP)
        Me.Panel8.Controls.Add(Me.DateTimePicker1)
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Controls.Add(Me.txtCashBack)
        Me.Panel8.Controls.Add(Me.lblCashSelectPayment)
        Me.Panel8.Controls.Add(Me.lblCashSelectPaymentlbl)
        Me.Panel8.Controls.Add(Me.txtCashByselectPayment)
        Me.Panel8.Controls.Add(Me.cbbCashSelectPayment)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 268)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(364, 109)
        Me.Panel8.TabIndex = 4
        '
        'btnSelectDetail
        '
        Me.btnSelectDetail.Enabled = False
        Me.btnSelectDetail.Location = New System.Drawing.Point(147, 77)
        Me.btnSelectDetail.Name = "btnSelectDetail"
        Me.btnSelectDetail.Size = New System.Drawing.Size(214, 23)
        Me.btnSelectDetail.TabIndex = 66
        Me.btnSelectDetail.Text = "เลือกรายละเอียดการชำระเงิน"
        Me.btnSelectDetail.UseVisualStyleBackColor = True
        '
        'lblCashDTP
        '
        Me.lblCashDTP.AutoSize = True
        Me.lblCashDTP.Location = New System.Drawing.Point(250, 61)
        Me.lblCashDTP.Name = "lblCashDTP"
        Me.lblCashDTP.Size = New System.Drawing.Size(22, 13)
        Me.lblCashDTP.TabIndex = 65
        Me.lblCashDTP.Text = "....."
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(250, 38)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(105, 20)
        Me.DateTimePicker1.TabIndex = 64
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(9, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 25)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "เงินทอน"
        '
        'txtCashBack
        '
        Me.txtCashBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCashBack.ForeColor = System.Drawing.Color.Maroon
        Me.txtCashBack.Location = New System.Drawing.Point(91, 0)
        Me.txtCashBack.Name = "txtCashBack"
        Me.txtCashBack.ReadOnly = True
        Me.txtCashBack.Size = New System.Drawing.Size(264, 31)
        Me.txtCashBack.TabIndex = 62
        Me.txtCashBack.Text = "0"
        Me.txtCashBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCashSelectPayment
        '
        Me.lblCashSelectPayment.AutoSize = True
        Me.lblCashSelectPayment.Location = New System.Drawing.Point(138, 61)
        Me.lblCashSelectPayment.Name = "lblCashSelectPayment"
        Me.lblCashSelectPayment.Size = New System.Drawing.Size(22, 13)
        Me.lblCashSelectPayment.TabIndex = 61
        Me.lblCashSelectPayment.Text = "....."
        '
        'lblCashSelectPaymentlbl
        '
        Me.lblCashSelectPaymentlbl.AutoSize = True
        Me.lblCashSelectPaymentlbl.Location = New System.Drawing.Point(23, 61)
        Me.lblCashSelectPaymentlbl.Name = "lblCashSelectPaymentlbl"
        Me.lblCashSelectPaymentlbl.Size = New System.Drawing.Size(101, 13)
        Me.lblCashSelectPaymentlbl.TabIndex = 60
        Me.lblCashSelectPaymentlbl.Text = "รูปแบบการชำระเงิน"
        '
        'txtCashByselectPayment
        '
        Me.txtCashByselectPayment.Location = New System.Drawing.Point(130, 38)
        Me.txtCashByselectPayment.Name = "txtCashByselectPayment"
        Me.txtCashByselectPayment.Size = New System.Drawing.Size(114, 20)
        Me.txtCashByselectPayment.TabIndex = 59
        '
        'cbbCashSelectPayment
        '
        Me.cbbCashSelectPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbCashSelectPayment.FormattingEnabled = True
        Me.cbbCashSelectPayment.Location = New System.Drawing.Point(3, 37)
        Me.cbbCashSelectPayment.Name = "cbbCashSelectPayment"
        Me.cbbCashSelectPayment.Size = New System.Drawing.Size(121, 21)
        Me.cbbCashSelectPayment.TabIndex = 58
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.txtCashCusPrice)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 185)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(364, 83)
        Me.Panel7.TabIndex = 3
        '
        'txtCashCusPrice
        '
        Me.txtCashCusPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCashCusPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCashCusPrice.Location = New System.Drawing.Point(0, 0)
        Me.txtCashCusPrice.Name = "txtCashCusPrice"
        Me.txtCashCusPrice.Size = New System.Drawing.Size(364, 80)
        Me.txtCashCusPrice.TabIndex = 1
        Me.txtCashCusPrice.Text = "0"
        Me.txtCashCusPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.txtCashLowerCash)
        Me.Panel6.Controls.Add(Me.txtCashPercen)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 111)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(364, 74)
        Me.Panel6.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "จำนวนที่ชำระ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(221, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "ส่วนลด เป็นจำนวนเงิน"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ส่วนลด คิดเป็น %"
        '
        'txtCashLowerCash
        '
        Me.txtCashLowerCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCashLowerCash.Location = New System.Drawing.Point(188, 3)
        Me.txtCashLowerCash.Name = "txtCashLowerCash"
        Me.txtCashLowerCash.Size = New System.Drawing.Size(167, 29)
        Me.txtCashLowerCash.TabIndex = 6
        Me.txtCashLowerCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCashPercen
        '
        Me.txtCashPercen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCashPercen.Location = New System.Drawing.Point(9, 3)
        Me.txtCashPercen.Name = "txtCashPercen"
        Me.txtCashPercen.Size = New System.Drawing.Size(173, 29)
        Me.txtCashPercen.TabIndex = 5
        Me.txtCashPercen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtCashCash)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 28)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(364, 83)
        Me.Panel5.TabIndex = 1
        '
        'txtCashCash
        '
        Me.txtCashCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCashCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCashCash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCashCash.Location = New System.Drawing.Point(0, 0)
        Me.txtCashCash.Name = "txtCashCash"
        Me.txtCashCash.ReadOnly = True
        Me.txtCashCash.Size = New System.Drawing.Size(364, 80)
        Me.txtCashCash.TabIndex = 21
        Me.txtCashCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtCashFixID)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(364, 28)
        Me.Panel4.TabIndex = 0
        '
        'txtCashFixID
        '
        Me.txtCashFixID.Location = New System.Drawing.Point(3, 3)
        Me.txtCashFixID.Name = "txtCashFixID"
        Me.txtCashFixID.ReadOnly = True
        Me.txtCashFixID.Size = New System.Drawing.Size(150, 20)
        Me.txtCashFixID.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(279, -2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 25)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "ยอดเงิน"
        '
        'CashFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 461)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(685, 500)
        Me.Name = "CashFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ชำระเงิน"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgCash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgCash As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_all As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCcreditTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCashpledgeID As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtCashCusID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents btnCashSave As System.Windows.Forms.Button
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents lblCashDTP As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCashBack As System.Windows.Forms.TextBox
    Friend WithEvents lblCashSelectPayment As System.Windows.Forms.Label
    Friend WithEvents lblCashSelectPaymentlbl As System.Windows.Forms.Label
    Friend WithEvents txtCashByselectPayment As System.Windows.Forms.TextBox
    Friend WithEvents cbbCashSelectPayment As System.Windows.Forms.ComboBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents txtCashCusPrice As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCashLowerCash As System.Windows.Forms.TextBox
    Friend WithEvents txtCashPercen As System.Windows.Forms.TextBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtCashCash As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtCashFixID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnSelectDetail As System.Windows.Forms.Button
End Class
