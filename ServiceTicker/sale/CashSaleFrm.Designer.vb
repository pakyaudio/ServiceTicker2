<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashSaleFrm
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgCash = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_all = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCStotal = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnCashSave = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnSelectDetail = New System.Windows.Forms.Button()
        Me.lblCashDTP = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblCashSelectPayment = New System.Windows.Forms.Label()
        Me.lblCashSelectPaymentlbl = New System.Windows.Forms.Label()
        Me.txtCashByselectPayment = New System.Windows.Forms.TextBox()
        Me.cbbCashSelectPayment = New System.Windows.Forms.ComboBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCashBack = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtCashCusPrice = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtCScashID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCStotalmoney = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCSdiscount = New System.Windows.Forms.TextBox()
        Me.txtCashCash = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblPWbillNum = New System.Windows.Forms.Label()
        Me.txtCSsale_id = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgCash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgCash)
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Size = New System.Drawing.Size(610, 482)
        Me.SplitContainer1.SplitterDistance = 263
        Me.SplitContainer1.TabIndex = 0
        '
        'dgCash
        '
        Me.dgCash.AllowUserToAddRows = False
        Me.dgCash.AllowUserToDeleteRows = False
        Me.dgCash.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgCash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCash.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.sale_id, Me.datetime_save, Me.total_all})
        Me.dgCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCash.Location = New System.Drawing.Point(0, 27)
        Me.dgCash.MultiSelect = False
        Me.dgCash.Name = "dgCash"
        Me.dgCash.ReadOnly = True
        Me.dgCash.RowHeadersVisible = False
        Me.dgCash.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCash.Size = New System.Drawing.Size(261, 420)
        Me.dgCash.TabIndex = 35
        '
        'no
        '
        Me.no.FillWeight = 30.0!
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        '
        'sale_id
        '
        Me.sale_id.HeaderText = "เลขเอกสาร"
        Me.sale_id.Name = "sale_id"
        Me.sale_id.ReadOnly = True
        Me.sale_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.sale_id.ToolTipText = "เลขเอกสารบิลเบิก/ใบลดหนี้"
        '
        'datetime_save
        '
        Me.datetime_save.HeaderText = "วันที่"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        Me.datetime_save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'total_all
        '
        Me.total_all.HeaderText = "ยอด"
        Me.total_all.Name = "total_all"
        Me.total_all.ReadOnly = True
        Me.total_all.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtCStotal)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 447)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(261, 33)
        Me.Panel2.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 20)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "ยอดรวมค้างชำระ"
        '
        'txtCStotal
        '
        Me.txtCStotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCStotal.ForeColor = System.Drawing.Color.Red
        Me.txtCStotal.Location = New System.Drawing.Point(131, 3)
        Me.txtCStotal.Name = "txtCStotal"
        Me.txtCStotal.ReadOnly = True
        Me.txtCStotal.Size = New System.Drawing.Size(127, 26)
        Me.txtCStotal.TabIndex = 50
        Me.txtCStotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(261, 27)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 20)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "รายการค้างชำระ"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.btnCashSave)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 420)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(341, 60)
        Me.Panel9.TabIndex = 50
        '
        'btnCashSave
        '
        Me.btnCashSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnCashSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCashSave.Enabled = False
        Me.btnCashSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCashSave.Location = New System.Drawing.Point(0, 0)
        Me.btnCashSave.Name = "btnCashSave"
        Me.btnCashSave.Size = New System.Drawing.Size(341, 60)
        Me.btnCashSave.TabIndex = 33
        Me.btnCashSave.Text = "บันทึกจ่ายเงิน (F10)"
        Me.btnCashSave.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.btnSelectDetail)
        Me.Panel8.Controls.Add(Me.lblCashDTP)
        Me.Panel8.Controls.Add(Me.DateTimePicker1)
        Me.Panel8.Controls.Add(Me.lblCashSelectPayment)
        Me.Panel8.Controls.Add(Me.lblCashSelectPaymentlbl)
        Me.Panel8.Controls.Add(Me.txtCashByselectPayment)
        Me.Panel8.Controls.Add(Me.cbbCashSelectPayment)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 333)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(341, 81)
        Me.Panel8.TabIndex = 49
        '
        'btnSelectDetail
        '
        Me.btnSelectDetail.Enabled = False
        Me.btnSelectDetail.Location = New System.Drawing.Point(124, 45)
        Me.btnSelectDetail.Name = "btnSelectDetail"
        Me.btnSelectDetail.Size = New System.Drawing.Size(214, 23)
        Me.btnSelectDetail.TabIndex = 61
        Me.btnSelectDetail.Text = "เลือกรายละเอียดการชำระเงิน"
        Me.btnSelectDetail.UseVisualStyleBackColor = True
        '
        'lblCashDTP
        '
        Me.lblCashDTP.AutoSize = True
        Me.lblCashDTP.Location = New System.Drawing.Point(230, 29)
        Me.lblCashDTP.Name = "lblCashDTP"
        Me.lblCashDTP.Size = New System.Drawing.Size(22, 13)
        Me.lblCashDTP.TabIndex = 60
        Me.lblCashDTP.Text = "....."
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(233, 6)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(105, 20)
        Me.DateTimePicker1.TabIndex = 59
        '
        'lblCashSelectPayment
        '
        Me.lblCashSelectPayment.AutoSize = True
        Me.lblCashSelectPayment.Location = New System.Drawing.Point(113, 29)
        Me.lblCashSelectPayment.Name = "lblCashSelectPayment"
        Me.lblCashSelectPayment.Size = New System.Drawing.Size(22, 13)
        Me.lblCashSelectPayment.TabIndex = 58
        Me.lblCashSelectPayment.Text = "....."
        '
        'lblCashSelectPaymentlbl
        '
        Me.lblCashSelectPaymentlbl.AutoSize = True
        Me.lblCashSelectPaymentlbl.Location = New System.Drawing.Point(6, 29)
        Me.lblCashSelectPaymentlbl.Name = "lblCashSelectPaymentlbl"
        Me.lblCashSelectPaymentlbl.Size = New System.Drawing.Size(101, 13)
        Me.lblCashSelectPaymentlbl.TabIndex = 57
        Me.lblCashSelectPaymentlbl.Text = "รูปแบบการชำระเงิน"
        '
        'txtCashByselectPayment
        '
        Me.txtCashByselectPayment.Enabled = False
        Me.txtCashByselectPayment.Location = New System.Drawing.Point(124, 6)
        Me.txtCashByselectPayment.Name = "txtCashByselectPayment"
        Me.txtCashByselectPayment.Size = New System.Drawing.Size(103, 20)
        Me.txtCashByselectPayment.TabIndex = 56
        '
        'cbbCashSelectPayment
        '
        Me.cbbCashSelectPayment.Enabled = False
        Me.cbbCashSelectPayment.FormattingEnabled = True
        Me.cbbCashSelectPayment.Location = New System.Drawing.Point(3, 5)
        Me.cbbCashSelectPayment.Name = "cbbCashSelectPayment"
        Me.cbbCashSelectPayment.Size = New System.Drawing.Size(115, 21)
        Me.cbbCashSelectPayment.TabIndex = 55
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.txtCashBack)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 294)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(341, 39)
        Me.Panel7.TabIndex = 48
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(3, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 25)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "เงินทอน"
        '
        'txtCashBack
        '
        Me.txtCashBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCashBack.ForeColor = System.Drawing.Color.DarkRed
        Me.txtCashBack.Location = New System.Drawing.Point(85, 3)
        Me.txtCashBack.Name = "txtCashBack"
        Me.txtCashBack.ReadOnly = True
        Me.txtCashBack.Size = New System.Drawing.Size(253, 31)
        Me.txtCashBack.TabIndex = 43
        Me.txtCashBack.Text = "0"
        Me.txtCashBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.txtCashCusPrice)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 211)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(341, 83)
        Me.Panel6.TabIndex = 47
        '
        'txtCashCusPrice
        '
        Me.txtCashCusPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCashCusPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCashCusPrice.Location = New System.Drawing.Point(0, 0)
        Me.txtCashCusPrice.Name = "txtCashCusPrice"
        Me.txtCashCusPrice.Size = New System.Drawing.Size(341, 80)
        Me.txtCashCusPrice.TabIndex = 26
        Me.txtCashCusPrice.Text = "0.00"
        Me.txtCashCusPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtCScashID)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 182)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(341, 29)
        Me.Panel5.TabIndex = 46
        '
        'txtCScashID
        '
        Me.txtCScashID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCScashID.Location = New System.Drawing.Point(166, 2)
        Me.txtCScashID.Name = "txtCScashID"
        Me.txtCScashID.ReadOnly = True
        Me.txtCScashID.Size = New System.Drawing.Size(176, 26)
        Me.txtCScashID.TabIndex = 53
        Me.txtCScashID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 25)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "จำนวนที่ชำระ (F5)"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.txtCStotalmoney)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.txtCSdiscount)
        Me.Panel4.Controls.Add(Me.txtCashCash)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 27)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(341, 155)
        Me.Panel4.TabIndex = 45
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 25)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "รวมสุทธิ"
        '
        'txtCStotalmoney
        '
        Me.txtCStotalmoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCStotalmoney.Location = New System.Drawing.Point(84, 111)
        Me.txtCStotalmoney.Name = "txtCStotalmoney"
        Me.txtCStotalmoney.ReadOnly = True
        Me.txtCStotalmoney.Size = New System.Drawing.Size(253, 38)
        Me.txtCStotalmoney.TabIndex = 60
        Me.txtCStotalmoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 25)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "ยอดค่าสินค้า/บริการ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 25)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "ส่วนลด"
        '
        'txtCSdiscount
        '
        Me.txtCSdiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCSdiscount.Location = New System.Drawing.Point(84, 74)
        Me.txtCSdiscount.Name = "txtCSdiscount"
        Me.txtCSdiscount.ReadOnly = True
        Me.txtCSdiscount.Size = New System.Drawing.Size(253, 38)
        Me.txtCSdiscount.TabIndex = 54
        Me.txtCSdiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCashCash
        '
        Me.txtCashCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCashCash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCashCash.Location = New System.Drawing.Point(2, 30)
        Me.txtCashCash.Name = "txtCashCash"
        Me.txtCashCash.ReadOnly = True
        Me.txtCashCash.Size = New System.Drawing.Size(335, 38)
        Me.txtCashCash.TabIndex = 44
        Me.txtCashCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblPWbillNum)
        Me.Panel3.Controls.Add(Me.txtCSsale_id)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(341, 27)
        Me.Panel3.TabIndex = 0
        '
        'lblPWbillNum
        '
        Me.lblPWbillNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPWbillNum.AutoSize = True
        Me.lblPWbillNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPWbillNum.Location = New System.Drawing.Point(3, 4)
        Me.lblPWbillNum.Name = "lblPWbillNum"
        Me.lblPWbillNum.Size = New System.Drawing.Size(83, 20)
        Me.lblPWbillNum.TabIndex = 111
        Me.lblPWbillNum.Text = "เลขที่บิลขาย"
        '
        'txtCSsale_id
        '
        Me.txtCSsale_id.Location = New System.Drawing.Point(92, 3)
        Me.txtCSsale_id.Name = "txtCSsale_id"
        Me.txtCSsale_id.ReadOnly = True
        Me.txtCSsale_id.Size = New System.Drawing.Size(246, 20)
        Me.txtCSsale_id.TabIndex = 58
        Me.txtCSsale_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 482)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(610, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblEmployee
        '
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(30, 17)
        Me.lblEmployee.Text = "User"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'CashSaleFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 504)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CashSaleFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ชำระเงิน"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
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
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgCash As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_all As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCStotal As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents btnCashSave As System.Windows.Forms.Button
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents lblCashDTP As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCashSelectPayment As System.Windows.Forms.Label
    Friend WithEvents lblCashSelectPaymentlbl As System.Windows.Forms.Label
    Friend WithEvents txtCashByselectPayment As System.Windows.Forms.TextBox
    Friend WithEvents cbbCashSelectPayment As System.Windows.Forms.ComboBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCashBack As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents txtCashCusPrice As System.Windows.Forms.TextBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtCScashID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtCashCash As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtCSsale_id As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCStotalmoney As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCSdiscount As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblPWbillNum As System.Windows.Forms.Label
    Friend WithEvents btnSelectDetail As System.Windows.Forms.Button
End Class
