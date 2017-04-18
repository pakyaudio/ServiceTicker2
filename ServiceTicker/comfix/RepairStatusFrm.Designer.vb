<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepairStatusFrm
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnRSstatus7 = New System.Windows.Forms.Button()
        Me.btnRSstatus2 = New System.Windows.Forms.Button()
        Me.btnRSstatus6 = New System.Windows.Forms.Button()
        Me.btnRSstatus3 = New System.Windows.Forms.Button()
        Me.btnRSstatus5 = New System.Windows.Forms.Button()
        Me.btnRSstatus4 = New System.Windows.Forms.Button()
        Me.btnRSstatus1 = New System.Windows.Forms.Button()
        Me.dgRSstatus1 = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fix_idS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datatime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_idS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_nameS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.snS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.symptomS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.managerdataS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fixrepairnoteS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fixaccessoryS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fixnoteS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fixpriceS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_getS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fixuserS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.statusS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_repairS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.note_repairS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.teltocusS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datecom_repair = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importuneS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.storageS1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.varuntee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnForward = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnRSsend_to_claims = New System.Windows.Forms.Button()
        Me.btnRSPartsWithdrawal = New System.Windows.Forms.Button()
        Me.btnRSviewProduct = New System.Windows.Forms.Button()
        Me.btnSRsendRepair = New System.Windows.Forms.Button()
        Me.btnRSsave = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblSendFix = New System.Windows.Forms.LinkLabel()
        Me.lblAddNoteRapair = New System.Windows.Forms.LinkLabel()
        Me.ListView_note = New System.Windows.Forms.ListView()
        Me.btnAddPic = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbbRSstorage = New System.Windows.Forms.ComboBox()
        Me.llblRSshelf = New System.Windows.Forms.LinkLabel()
        Me.lblRSclaims = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblRSsaleDetail = New System.Windows.Forms.Label()
        Me.lblStatusText = New System.Windows.Forms.Label()
        Me.lblRSteltocus = New System.Windows.Forms.Label()
        Me.cbbRSteltocus = New System.Windows.Forms.ComboBox()
        Me.gbRSdetailIDedit = New System.Windows.Forms.GroupBox()
        Me.txtSN = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRScus_tel = New System.Windows.Forms.TextBox()
        Me.txtRScus_name = New System.Windows.Forms.TextBox()
        Me.txtRScus_id = New System.Windows.Forms.TextBox()
        Me.txtRSfix_id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRScusName = New System.Windows.Forms.Label()
        Me.lblRSfix_id = New System.Windows.Forms.Label()
        Me.lblRSrepairdetail = New System.Windows.Forms.Label()
        Me.lblRSvaruntee = New System.Windows.Forms.Label()
        Me.cbbRSvaruntee = New System.Windows.Forms.ComboBox()
        Me.cbbRSuser_repair = New System.Windows.Forms.ComboBox()
        Me.lblRSfixstatus = New System.Windows.Forms.Label()
        Me.cbbRSstatus = New System.Windows.Forms.ComboBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DelPicToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelPicContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgRSstatus1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRSdetailIDedit.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.DelPicContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 4000
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel1MinSize = 0
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.SplitContainer1.Panel2MinSize = 0
        Me.SplitContainer1.Size = New System.Drawing.Size(784, 552)
        Me.SplitContainer1.SplitterDistance = 215
        Me.SplitContainer1.TabIndex = 2
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer2.Panel1MinSize = 30
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.dgRSstatus1)
        Me.SplitContainer2.Panel2MinSize = 50
        Me.SplitContainer2.Size = New System.Drawing.Size(782, 213)
        Me.SplitContainer2.SplitterDistance = 40
        Me.SplitContainer2.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnRSstatus7, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRSstatus2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRSstatus6, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRSstatus3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRSstatus5, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRSstatus4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRSstatus1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(782, 40)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnRSstatus7
        '
        Me.btnRSstatus7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRSstatus7.Location = New System.Drawing.Point(669, 3)
        Me.btnRSstatus7.Name = "btnRSstatus7"
        Me.btnRSstatus7.Size = New System.Drawing.Size(110, 34)
        Me.btnRSstatus7.TabIndex = 6
        Me.btnRSstatus7.Text = "คืนเครื่องแล้ว"
        Me.btnRSstatus7.UseVisualStyleBackColor = True
        '
        'btnRSstatus2
        '
        Me.btnRSstatus2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRSstatus2.Location = New System.Drawing.Point(114, 3)
        Me.btnRSstatus2.Name = "btnRSstatus2"
        Me.btnRSstatus2.Size = New System.Drawing.Size(105, 34)
        Me.btnRSstatus2.TabIndex = 1
        Me.btnRSstatus2.Text = "กำลังซ่อม"
        Me.btnRSstatus2.UseVisualStyleBackColor = True
        '
        'btnRSstatus6
        '
        Me.btnRSstatus6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRSstatus6.Location = New System.Drawing.Point(558, 3)
        Me.btnRSstatus6.Name = "btnRSstatus6"
        Me.btnRSstatus6.Size = New System.Drawing.Size(105, 34)
        Me.btnRSstatus6.TabIndex = 5
        Me.btnRSstatus6.Text = "ยกเลิกซ่อม"
        Me.btnRSstatus6.UseVisualStyleBackColor = True
        '
        'btnRSstatus3
        '
        Me.btnRSstatus3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRSstatus3.Location = New System.Drawing.Point(225, 3)
        Me.btnRSstatus3.Name = "btnRSstatus3"
        Me.btnRSstatus3.Size = New System.Drawing.Size(105, 34)
        Me.btnRSstatus3.TabIndex = 2
        Me.btnRSstatus3.Text = "รออะไหล่/ส่งเคลม"
        Me.btnRSstatus3.UseVisualStyleBackColor = True
        '
        'btnRSstatus5
        '
        Me.btnRSstatus5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRSstatus5.Location = New System.Drawing.Point(447, 3)
        Me.btnRSstatus5.Name = "btnRSstatus5"
        Me.btnRSstatus5.Size = New System.Drawing.Size(105, 34)
        Me.btnRSstatus5.TabIndex = 4
        Me.btnRSstatus5.Text = "ซ่อมเสร็จ"
        Me.btnRSstatus5.UseVisualStyleBackColor = True
        '
        'btnRSstatus4
        '
        Me.btnRSstatus4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRSstatus4.Location = New System.Drawing.Point(336, 3)
        Me.btnRSstatus4.Name = "btnRSstatus4"
        Me.btnRSstatus4.Size = New System.Drawing.Size(105, 34)
        Me.btnRSstatus4.TabIndex = 3
        Me.btnRSstatus4.Text = "ซ่อมไม่ได้"
        Me.btnRSstatus4.UseVisualStyleBackColor = True
        '
        'btnRSstatus1
        '
        Me.btnRSstatus1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRSstatus1.Location = New System.Drawing.Point(3, 3)
        Me.btnRSstatus1.Name = "btnRSstatus1"
        Me.btnRSstatus1.Size = New System.Drawing.Size(105, 34)
        Me.btnRSstatus1.TabIndex = 0
        Me.btnRSstatus1.Text = "รอซ่อม"
        Me.btnRSstatus1.UseVisualStyleBackColor = True
        '
        'dgRSstatus1
        '
        Me.dgRSstatus1.AllowUserToAddRows = False
        Me.dgRSstatus1.AllowUserToDeleteRows = False
        Me.dgRSstatus1.AllowUserToResizeRows = False
        Me.dgRSstatus1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgRSstatus1.CausesValidation = False
        Me.dgRSstatus1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRSstatus1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.fix_idS1, Me.datatime_save, Me.customer_idS1, Me.customer_nameS1, Me.snS1, Me.p_type, Me.p_name, Me.model, Me.symptomS1, Me.managerdataS1, Me.fixrepairnoteS1, Me.fixaccessoryS1, Me.fixnoteS1, Me.fixpriceS1, Me.date_getS1, Me.fixuserS1, Me.statusS1, Me.user_repairS1, Me.note_repairS1, Me.teltocusS1, Me.datecom_repair, Me.importuneS1, Me.storageS1, Me.varuntee})
        Me.dgRSstatus1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgRSstatus1.Location = New System.Drawing.Point(0, 0)
        Me.dgRSstatus1.MultiSelect = False
        Me.dgRSstatus1.Name = "dgRSstatus1"
        Me.dgRSstatus1.ReadOnly = True
        Me.dgRSstatus1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgRSstatus1.RowHeadersVisible = False
        Me.dgRSstatus1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRSstatus1.Size = New System.Drawing.Size(782, 169)
        Me.dgRSstatus1.TabIndex = 0
        Me.dgRSstatus1.TabStop = False
        '
        'no
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.GreenYellow
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.no.DefaultCellStyle = DataGridViewCellStyle2
        Me.no.Frozen = True
        Me.no.HeaderText = "#"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 30
        '
        'fix_idS1
        '
        Me.fix_idS1.HeaderText = "เลขที่ใบซ่อม"
        Me.fix_idS1.Name = "fix_idS1"
        Me.fix_idS1.ReadOnly = True
        Me.fix_idS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fix_idS1.ToolTipText = "เลขที่ใบซ่อม"
        Me.fix_idS1.Width = 120
        '
        'datatime_save
        '
        Me.datatime_save.HeaderText = "วันที่รับซ่อม"
        Me.datatime_save.Name = "datatime_save"
        Me.datatime_save.ReadOnly = True
        Me.datatime_save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.datatime_save.ToolTipText = "วันที่รับซ่อมเครื่องซ่อม"
        Me.datatime_save.Width = 120
        '
        'customer_idS1
        '
        Me.customer_idS1.HeaderText = "รหัสลูกค้า"
        Me.customer_idS1.Name = "customer_idS1"
        Me.customer_idS1.ReadOnly = True
        Me.customer_idS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.customer_idS1.ToolTipText = "รหัสลูกค้า"
        Me.customer_idS1.Width = 120
        '
        'customer_nameS1
        '
        Me.customer_nameS1.HeaderText = "ชื่อลูกค้า"
        Me.customer_nameS1.Name = "customer_nameS1"
        Me.customer_nameS1.ReadOnly = True
        Me.customer_nameS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.customer_nameS1.ToolTipText = "ชื่อลูกค้า"
        Me.customer_nameS1.Width = 120
        '
        'snS1
        '
        Me.snS1.HeaderText = "SN"
        Me.snS1.Name = "snS1"
        Me.snS1.ReadOnly = True
        Me.snS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.snS1.ToolTipText = "SN"
        '
        'p_type
        '
        Me.p_type.HeaderText = "ประเภท"
        Me.p_type.Name = "p_type"
        Me.p_type.ReadOnly = True
        Me.p_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.p_type.ToolTipText = "ประเภท"
        '
        'p_name
        '
        Me.p_name.HeaderText = "ยี่ห้อ"
        Me.p_name.Name = "p_name"
        Me.p_name.ReadOnly = True
        Me.p_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.p_name.ToolTipText = "ยี่ห้อ"
        '
        'model
        '
        Me.model.HeaderText = "รุ่น"
        Me.model.Name = "model"
        Me.model.ReadOnly = True
        Me.model.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.model.ToolTipText = "รุ่น"
        '
        'symptomS1
        '
        Me.symptomS1.HeaderText = "อาการเสีย"
        Me.symptomS1.Name = "symptomS1"
        Me.symptomS1.ReadOnly = True
        Me.symptomS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.symptomS1.ToolTipText = "อาการเสีย"
        '
        'managerdataS1
        '
        Me.managerdataS1.HeaderText = "จัดการข้อมูล"
        Me.managerdataS1.Name = "managerdataS1"
        Me.managerdataS1.ReadOnly = True
        Me.managerdataS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.managerdataS1.ToolTipText = "จัดการข้อมูล"
        '
        'fixrepairnoteS1
        '
        Me.fixrepairnoteS1.HeaderText = "อาการเสียเพิ่มเติม"
        Me.fixrepairnoteS1.Name = "fixrepairnoteS1"
        Me.fixrepairnoteS1.ReadOnly = True
        Me.fixrepairnoteS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fixrepairnoteS1.ToolTipText = "อาการเสียเพิ่มเติม"
        Me.fixrepairnoteS1.Width = 120
        '
        'fixaccessoryS1
        '
        Me.fixaccessoryS1.HeaderText = "อุปกรณ์ที่นำมาด้วย"
        Me.fixaccessoryS1.Name = "fixaccessoryS1"
        Me.fixaccessoryS1.ReadOnly = True
        Me.fixaccessoryS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fixaccessoryS1.ToolTipText = "อุปกรณ์ที่นำมาด้วย"
        '
        'fixnoteS1
        '
        Me.fixnoteS1.HeaderText = "หมายเหตุ"
        Me.fixnoteS1.Name = "fixnoteS1"
        Me.fixnoteS1.ReadOnly = True
        Me.fixnoteS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fixnoteS1.ToolTipText = "หมายเหตุ"
        '
        'fixpriceS1
        '
        Me.fixpriceS1.HeaderText = "ประเมินราคาซ่อม"
        Me.fixpriceS1.Name = "fixpriceS1"
        Me.fixpriceS1.ReadOnly = True
        Me.fixpriceS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fixpriceS1.ToolTipText = "การประเมินราคาก่อนซ่อม"
        Me.fixpriceS1.Width = 120
        '
        'date_getS1
        '
        Me.date_getS1.HeaderText = "นัดรับ"
        Me.date_getS1.Name = "date_getS1"
        Me.date_getS1.ReadOnly = True
        Me.date_getS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.date_getS1.ToolTipText = "วันที่นัดรับเครื่องซ่อม"
        '
        'fixuserS1
        '
        Me.fixuserS1.HeaderText = "ผู้รับงาน"
        Me.fixuserS1.Name = "fixuserS1"
        Me.fixuserS1.ReadOnly = True
        Me.fixuserS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fixuserS1.ToolTipText = "ผู้รับงานซ่อม"
        '
        'statusS1
        '
        Me.statusS1.HeaderText = "สถานะ"
        Me.statusS1.Name = "statusS1"
        Me.statusS1.ReadOnly = True
        Me.statusS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.statusS1.ToolTipText = "สถานะงานซ่อม"
        '
        'user_repairS1
        '
        Me.user_repairS1.HeaderText = "ช่างซ่อม"
        Me.user_repairS1.Name = "user_repairS1"
        Me.user_repairS1.ReadOnly = True
        Me.user_repairS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.user_repairS1.ToolTipText = "ช่างผู้ซ่อม"
        '
        'note_repairS1
        '
        Me.note_repairS1.HeaderText = "รายละเอียดการซ่อม"
        Me.note_repairS1.Name = "note_repairS1"
        Me.note_repairS1.ReadOnly = True
        Me.note_repairS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.note_repairS1.ToolTipText = "รายละเอียดการซ่อม"
        Me.note_repairS1.Width = 120
        '
        'teltocusS1
        '
        Me.teltocusS1.HeaderText = "แจ้งลูกค้า"
        Me.teltocusS1.Name = "teltocusS1"
        Me.teltocusS1.ReadOnly = True
        Me.teltocusS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.teltocusS1.ToolTipText = "การติดต่อแจ้งลูกค้าเกี่ยวกับงานซ่อม"
        '
        'datecom_repair
        '
        Me.datecom_repair.HeaderText = "ซ่อมเสร็จ"
        Me.datecom_repair.Name = "datecom_repair"
        Me.datecom_repair.ReadOnly = True
        Me.datecom_repair.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.datecom_repair.ToolTipText = "วันที่ซ่อมเสร็จ"
        '
        'importuneS1
        '
        Me.importuneS1.HeaderText = "เร่งด่วน"
        Me.importuneS1.Name = "importuneS1"
        Me.importuneS1.ReadOnly = True
        Me.importuneS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.importuneS1.ToolTipText = "ความเร่งด่วนของงานซ่อม"
        '
        'storageS1
        '
        Me.storageS1.HeaderText = "ที่เก็บ"
        Me.storageS1.Name = "storageS1"
        Me.storageS1.ReadOnly = True
        Me.storageS1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.storageS1.ToolTipText = "ที่เก็บเครื่องซ่อม ชั้นวาง"
        '
        'varuntee
        '
        Me.varuntee.HeaderText = "รับประกัน"
        Me.varuntee.Name = "varuntee"
        Me.varuntee.ReadOnly = True
        Me.varuntee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.varuntee.ToolTipText = "การรับประกัน"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ListView1, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 230.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(782, 331)
        Me.TableLayoutPanel2.TabIndex = 101
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnForward)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel2.Controls.Add(Me.NumericUpDown1)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Controls.Add(Me.lblSendFix)
        Me.Panel2.Controls.Add(Me.lblAddNoteRapair)
        Me.Panel2.Controls.Add(Me.ListView_note)
        Me.Panel2.Controls.Add(Me.btnAddPic)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.cbbRSstorage)
        Me.Panel2.Controls.Add(Me.llblRSshelf)
        Me.Panel2.Controls.Add(Me.lblRSclaims)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.lblRSsaleDetail)
        Me.Panel2.Controls.Add(Me.lblStatusText)
        Me.Panel2.Controls.Add(Me.lblRSteltocus)
        Me.Panel2.Controls.Add(Me.cbbRSteltocus)
        Me.Panel2.Controls.Add(Me.gbRSdetailIDedit)
        Me.Panel2.Controls.Add(Me.lblRSrepairdetail)
        Me.Panel2.Controls.Add(Me.lblRSvaruntee)
        Me.Panel2.Controls.Add(Me.cbbRSvaruntee)
        Me.Panel2.Controls.Add(Me.cbbRSuser_repair)
        Me.Panel2.Controls.Add(Me.lblRSfixstatus)
        Me.Panel2.Controls.Add(Me.cbbRSstatus)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(776, 224)
        Me.Panel2.TabIndex = 100
        '
        'btnForward
        '
        Me.btnForward.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnForward.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnForward.Image = Global.ServiceTicker.My.Resources.Resources.AzureMySQLDatabase_color_16x
        Me.btnForward.Location = New System.Drawing.Point(468, 0)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(105, 26)
        Me.btnForward.TabIndex = 118
        Me.btnForward.Text = "โหลดข้อมูลเพิ่ม"
        Me.btnForward.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnForward.UseVisualStyleBackColor = True
        Me.btnForward.Visible = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnRSsend_to_claims, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnRSPartsWithdrawal, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnRSviewProduct, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnSRsendRepair, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnRSsave, 4, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 185)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(776, 39)
        Me.TableLayoutPanel3.TabIndex = 117
        '
        'btnRSsend_to_claims
        '
        Me.btnRSsend_to_claims.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRSsend_to_claims.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRSsend_to_claims.Location = New System.Drawing.Point(3, 3)
        Me.btnRSsend_to_claims.Name = "btnRSsend_to_claims"
        Me.btnRSsend_to_claims.Size = New System.Drawing.Size(149, 33)
        Me.btnRSsend_to_claims.TabIndex = 0
        Me.btnRSsend_to_claims.TabStop = False
        Me.btnRSsend_to_claims.Text = "ส่งกลับงานเคลม"
        Me.btnRSsend_to_claims.UseVisualStyleBackColor = True
        Me.btnRSsend_to_claims.Visible = False
        '
        'btnRSPartsWithdrawal
        '
        Me.btnRSPartsWithdrawal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRSPartsWithdrawal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRSPartsWithdrawal.Location = New System.Drawing.Point(158, 3)
        Me.btnRSPartsWithdrawal.Name = "btnRSPartsWithdrawal"
        Me.btnRSPartsWithdrawal.Size = New System.Drawing.Size(149, 33)
        Me.btnRSPartsWithdrawal.TabIndex = 1
        Me.btnRSPartsWithdrawal.TabStop = False
        Me.btnRSPartsWithdrawal.Text = "เบิกอะไหล่/ค่าซ่อม"
        Me.btnRSPartsWithdrawal.UseVisualStyleBackColor = True
        '
        'btnRSviewProduct
        '
        Me.btnRSviewProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRSviewProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRSviewProduct.Location = New System.Drawing.Point(313, 3)
        Me.btnRSviewProduct.Name = "btnRSviewProduct"
        Me.btnRSviewProduct.Size = New System.Drawing.Size(149, 33)
        Me.btnRSviewProduct.TabIndex = 2
        Me.btnRSviewProduct.TabStop = False
        Me.btnRSviewProduct.Text = "ดูรายการอะไหล่"
        Me.btnRSviewProduct.UseVisualStyleBackColor = True
        '
        'btnSRsendRepair
        '
        Me.btnSRsendRepair.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSRsendRepair.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSRsendRepair.Location = New System.Drawing.Point(468, 3)
        Me.btnSRsendRepair.Name = "btnSRsendRepair"
        Me.btnSRsendRepair.Size = New System.Drawing.Size(149, 33)
        Me.btnSRsendRepair.TabIndex = 3
        Me.btnSRsendRepair.TabStop = False
        Me.btnSRsendRepair.Text = "ส่งคืนงานซ่อม"
        Me.btnSRsendRepair.UseVisualStyleBackColor = True
        Me.btnSRsendRepair.Visible = False
        '
        'btnRSsave
        '
        Me.btnRSsave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRSsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRSsave.Location = New System.Drawing.Point(623, 3)
        Me.btnRSsave.Name = "btnRSsave"
        Me.btnRSsave.Size = New System.Drawing.Size(150, 33)
        Me.btnRSsave.TabIndex = 4
        Me.btnRSsave.TabStop = False
        Me.btnRSsave.Text = "บันทึก"
        Me.btnRSsave.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDown1.Location = New System.Drawing.Point(576, 1)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(76, 20)
        Me.NumericUpDown1.TabIndex = 116
        Me.ToolTip1.SetToolTip(Me.NumericUpDown1, "ลิมิตการแสดงผล (เมื่อข้อมูลมีจำนวนมาก)")
        Me.NumericUpDown1.Value = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDown1.Visible = False
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Image = Global.ServiceTicker.My.Resources.Resources.VSO_Search_16x
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch.Location = New System.Drawing.Point(724, 0)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(49, 23)
        Me.btnSearch.TabIndex = 115
        Me.ToolTip1.SetToolTip(Me.btnSearch, "ค้นหางานซ่อม")
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblSendFix
        '
        Me.lblSendFix.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSendFix.AutoSize = True
        Me.lblSendFix.Location = New System.Drawing.Point(371, 96)
        Me.lblSendFix.Name = "lblSendFix"
        Me.lblSendFix.Size = New System.Drawing.Size(96, 13)
        Me.lblSendFix.TabIndex = 6
        Me.lblSendFix.TabStop = True
        Me.lblSendFix.Text = "ระบุส่งซ่อมภายนอก"
        Me.ToolTip1.SetToolTip(Me.lblSendFix, "กรณีส่งไปให้ที่อื่นซ่อมให้")
        Me.lblSendFix.Visible = False
        '
        'lblAddNoteRapair
        '
        Me.lblAddNoteRapair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAddNoteRapair.AutoSize = True
        Me.lblAddNoteRapair.Location = New System.Drawing.Point(468, 96)
        Me.lblAddNoteRapair.Name = "lblAddNoteRapair"
        Me.lblAddNoteRapair.Size = New System.Drawing.Size(119, 13)
        Me.lblAddNoteRapair.TabIndex = 7
        Me.lblAddNoteRapair.TabStop = True
        Me.lblAddNoteRapair.Text = "เพิ่มรายละเอียดการซ่อม"
        '
        'ListView_note
        '
        Me.ListView_note.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView_note.FullRowSelect = True
        Me.ListView_note.Location = New System.Drawing.Point(211, 112)
        Me.ListView_note.Name = "ListView_note"
        Me.ListView_note.Size = New System.Drawing.Size(376, 67)
        Me.ListView_note.TabIndex = 8
        Me.ListView_note.UseCompatibleStateImageBehavior = False
        Me.ListView_note.View = System.Windows.Forms.View.Details
        '
        'btnAddPic
        '
        Me.btnAddPic.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddPic.Image = Global.ServiceTicker.My.Resources.Resources.Camera_16x
        Me.btnAddPic.Location = New System.Drawing.Point(658, 156)
        Me.btnAddPic.Name = "btnAddPic"
        Me.btnAddPic.Size = New System.Drawing.Size(115, 23)
        Me.btnAddPic.TabIndex = 5
        Me.btnAddPic.Text = "เพิ่มรูป"
        Me.btnAddPic.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddPic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddPic.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(598, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 18)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "ช่างซ่อม"
        '
        'cbbRSstorage
        '
        Me.cbbRSstorage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbRSstorage.FormattingEnabled = True
        Me.cbbRSstorage.Location = New System.Drawing.Point(658, 132)
        Me.cbbRSstorage.Name = "cbbRSstorage"
        Me.cbbRSstorage.Size = New System.Drawing.Size(115, 21)
        Me.cbbRSstorage.TabIndex = 4
        Me.cbbRSstorage.TabStop = False
        '
        'llblRSshelf
        '
        Me.llblRSshelf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblRSshelf.AutoSize = True
        Me.llblRSshelf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.llblRSshelf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.llblRSshelf.LinkColor = System.Drawing.Color.Blue
        Me.llblRSshelf.Location = New System.Drawing.Point(614, 132)
        Me.llblRSshelf.Name = "llblRSshelf"
        Me.llblRSshelf.Size = New System.Drawing.Size(38, 18)
        Me.llblRSshelf.TabIndex = 107
        Me.llblRSshelf.TabStop = True
        Me.llblRSshelf.Text = "ที่เก็บ"
        '
        'lblRSclaims
        '
        Me.lblRSclaims.AutoSize = True
        Me.lblRSclaims.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblRSclaims.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblRSclaims.Location = New System.Drawing.Point(215, 84)
        Me.lblRSclaims.Name = "lblRSclaims"
        Me.lblRSclaims.Size = New System.Drawing.Size(0, 25)
        Me.lblRSclaims.TabIndex = 103
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(317, 13)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "ดับเบิ้ลคลิ๊กที่รายชื่อเครื่องซ่อมเพื่อทำการเปลี่ยนแปลงข้อมูลงานซ่อม"
        '
        'lblRSsaleDetail
        '
        Me.lblRSsaleDetail.AutoSize = True
        Me.lblRSsaleDetail.Location = New System.Drawing.Point(216, 45)
        Me.lblRSsaleDetail.Name = "lblRSsaleDetail"
        Me.lblRSsaleDetail.Size = New System.Drawing.Size(58, 13)
        Me.lblRSsaleDetail.TabIndex = 99
        Me.lblRSsaleDetail.Text = "Sale Detail"
        '
        'lblStatusText
        '
        Me.lblStatusText.AutoSize = True
        Me.lblStatusText.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblStatusText.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblStatusText.Location = New System.Drawing.Point(3, 13)
        Me.lblStatusText.Name = "lblStatusText"
        Me.lblStatusText.Size = New System.Drawing.Size(80, 29)
        Me.lblStatusText.TabIndex = 98
        Me.lblStatusText.Text = "สถานะ"
        '
        'lblRSteltocus
        '
        Me.lblRSteltocus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRSteltocus.AutoSize = True
        Me.lblRSteltocus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblRSteltocus.ForeColor = System.Drawing.Color.Black
        Me.lblRSteltocus.Location = New System.Drawing.Point(593, 105)
        Me.lblRSteltocus.Name = "lblRSteltocus"
        Me.lblRSteltocus.Size = New System.Drawing.Size(59, 18)
        Me.lblRSteltocus.TabIndex = 96
        Me.lblRSteltocus.Text = "แจ้งลูกค้า"
        '
        'cbbRSteltocus
        '
        Me.cbbRSteltocus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbRSteltocus.FormattingEnabled = True
        Me.cbbRSteltocus.Items.AddRange(New Object() {"ยังไม่ได้แจ้งลูกค้า", "แจ้งลูกค้าแล้ว"})
        Me.cbbRSteltocus.Location = New System.Drawing.Point(658, 106)
        Me.cbbRSteltocus.Name = "cbbRSteltocus"
        Me.cbbRSteltocus.Size = New System.Drawing.Size(115, 21)
        Me.cbbRSteltocus.TabIndex = 3
        Me.cbbRSteltocus.TabStop = False
        '
        'gbRSdetailIDedit
        '
        Me.gbRSdetailIDedit.BackColor = System.Drawing.SystemColors.Control
        Me.gbRSdetailIDedit.Controls.Add(Me.txtSN)
        Me.gbRSdetailIDedit.Controls.Add(Me.Label5)
        Me.gbRSdetailIDedit.Controls.Add(Me.txtRScus_tel)
        Me.gbRSdetailIDedit.Controls.Add(Me.txtRScus_name)
        Me.gbRSdetailIDedit.Controls.Add(Me.txtRScus_id)
        Me.gbRSdetailIDedit.Controls.Add(Me.txtRSfix_id)
        Me.gbRSdetailIDedit.Controls.Add(Me.Label3)
        Me.gbRSdetailIDedit.Controls.Add(Me.Label2)
        Me.gbRSdetailIDedit.Controls.Add(Me.lblRScusName)
        Me.gbRSdetailIDedit.Controls.Add(Me.lblRSfix_id)
        Me.gbRSdetailIDedit.Location = New System.Drawing.Point(11, 45)
        Me.gbRSdetailIDedit.Name = "gbRSdetailIDedit"
        Me.gbRSdetailIDedit.Size = New System.Drawing.Size(197, 134)
        Me.gbRSdetailIDedit.TabIndex = 94
        Me.gbRSdetailIDedit.TabStop = False
        Me.gbRSdetailIDedit.Text = "ID งานที่กำลังเลือกอยู่ขณะนี้"
        '
        'txtSN
        '
        Me.txtSN.Location = New System.Drawing.Point(73, 109)
        Me.txtSN.Name = "txtSN"
        Me.txtSN.ReadOnly = True
        Me.txtSN.Size = New System.Drawing.Size(121, 20)
        Me.txtSN.TabIndex = 82
        Me.txtSN.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(40, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 16)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "SN"
        '
        'txtRScus_tel
        '
        Me.txtRScus_tel.Location = New System.Drawing.Point(73, 86)
        Me.txtRScus_tel.Name = "txtRScus_tel"
        Me.txtRScus_tel.ReadOnly = True
        Me.txtRScus_tel.Size = New System.Drawing.Size(121, 20)
        Me.txtRScus_tel.TabIndex = 80
        Me.txtRScus_tel.TabStop = False
        '
        'txtRScus_name
        '
        Me.txtRScus_name.Location = New System.Drawing.Point(73, 63)
        Me.txtRScus_name.Name = "txtRScus_name"
        Me.txtRScus_name.ReadOnly = True
        Me.txtRScus_name.Size = New System.Drawing.Size(121, 20)
        Me.txtRScus_name.TabIndex = 79
        Me.txtRScus_name.TabStop = False
        '
        'txtRScus_id
        '
        Me.txtRScus_id.Location = New System.Drawing.Point(73, 40)
        Me.txtRScus_id.Name = "txtRScus_id"
        Me.txtRScus_id.ReadOnly = True
        Me.txtRScus_id.Size = New System.Drawing.Size(121, 20)
        Me.txtRScus_id.TabIndex = 78
        Me.txtRScus_id.TabStop = False
        '
        'txtRSfix_id
        '
        Me.txtRSfix_id.Location = New System.Drawing.Point(73, 17)
        Me.txtRSfix_id.Name = "txtRSfix_id"
        Me.txtRSfix_id.ReadOnly = True
        Me.txtRSfix_id.Size = New System.Drawing.Size(121, 20)
        Me.txtRSfix_id.TabIndex = 78
        Me.txtRSfix_id.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(18, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "เบอร์โทร"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(14, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "รหัสลูกค้า"
        '
        'lblRScusName
        '
        Me.lblRScusName.AutoSize = True
        Me.lblRScusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblRScusName.ForeColor = System.Drawing.Color.Navy
        Me.lblRScusName.Location = New System.Drawing.Point(22, 64)
        Me.lblRScusName.Name = "lblRScusName"
        Me.lblRScusName.Size = New System.Drawing.Size(45, 16)
        Me.lblRScusName.TabIndex = 40
        Me.lblRScusName.Text = "ชื่อลูกค้า"
        '
        'lblRSfix_id
        '
        Me.lblRSfix_id.AutoSize = True
        Me.lblRSfix_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblRSfix_id.ForeColor = System.Drawing.Color.Navy
        Me.lblRSfix_id.Location = New System.Drawing.Point(0, 18)
        Me.lblRSfix_id.Name = "lblRSfix_id"
        Me.lblRSfix_id.Size = New System.Drawing.Size(67, 16)
        Me.lblRSfix_id.TabIndex = 3
        Me.lblRSfix_id.Text = "รหัสงานซ่อม"
        '
        'lblRSrepairdetail
        '
        Me.lblRSrepairdetail.AutoSize = True
        Me.lblRSrepairdetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblRSrepairdetail.ForeColor = System.Drawing.Color.Black
        Me.lblRSrepairdetail.Location = New System.Drawing.Point(211, 94)
        Me.lblRSrepairdetail.Name = "lblRSrepairdetail"
        Me.lblRSrepairdetail.Size = New System.Drawing.Size(99, 15)
        Me.lblRSrepairdetail.TabIndex = 91
        Me.lblRSrepairdetail.Text = "รายละเอียดการซ่อม"
        '
        'lblRSvaruntee
        '
        Me.lblRSvaruntee.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRSvaruntee.AutoSize = True
        Me.lblRSvaruntee.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblRSvaruntee.ForeColor = System.Drawing.Color.Black
        Me.lblRSvaruntee.Location = New System.Drawing.Point(588, 24)
        Me.lblRSvaruntee.Name = "lblRSvaruntee"
        Me.lblRSvaruntee.Size = New System.Drawing.Size(64, 18)
        Me.lblRSvaruntee.TabIndex = 89
        Me.lblRSvaruntee.Text = "รับประกัน"
        '
        'cbbRSvaruntee
        '
        Me.cbbRSvaruntee.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbRSvaruntee.FormattingEnabled = True
        Me.cbbRSvaruntee.Location = New System.Drawing.Point(658, 25)
        Me.cbbRSvaruntee.Name = "cbbRSvaruntee"
        Me.cbbRSvaruntee.Size = New System.Drawing.Size(115, 21)
        Me.cbbRSvaruntee.TabIndex = 0
        Me.cbbRSvaruntee.TabStop = False
        '
        'cbbRSuser_repair
        '
        Me.cbbRSuser_repair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbRSuser_repair.FormattingEnabled = True
        Me.cbbRSuser_repair.Location = New System.Drawing.Point(658, 79)
        Me.cbbRSuser_repair.Name = "cbbRSuser_repair"
        Me.cbbRSuser_repair.Size = New System.Drawing.Size(115, 21)
        Me.cbbRSuser_repair.TabIndex = 2
        Me.cbbRSuser_repair.TabStop = False
        '
        'lblRSfixstatus
        '
        Me.lblRSfixstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRSfixstatus.AutoSize = True
        Me.lblRSfixstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblRSfixstatus.ForeColor = System.Drawing.Color.Black
        Me.lblRSfixstatus.Location = New System.Drawing.Point(606, 51)
        Me.lblRSfixstatus.Name = "lblRSfixstatus"
        Me.lblRSfixstatus.Size = New System.Drawing.Size(46, 18)
        Me.lblRSfixstatus.TabIndex = 86
        Me.lblRSfixstatus.Text = "สถานะ"
        '
        'cbbRSstatus
        '
        Me.cbbRSstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbRSstatus.FormattingEnabled = True
        Me.cbbRSstatus.Location = New System.Drawing.Point(658, 52)
        Me.cbbRSstatus.Name = "cbbRSstatus"
        Me.cbbRSstatus.Size = New System.Drawing.Size(115, 21)
        Me.cbbRSstatus.TabIndex = 1
        Me.cbbRSstatus.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Location = New System.Drawing.Point(3, 233)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(776, 100)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.btnHelp})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 552)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.TabIndex = 3
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
        'DelPicToolStripMenu
        '
        Me.DelPicToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.VSO_RecycleBin_16x
        Me.DelPicToolStripMenu.Name = "DelPicToolStripMenu"
        Me.DelPicToolStripMenu.Size = New System.Drawing.Size(136, 22)
        Me.DelPicToolStripMenu.Text = "ลบรูป"
        '
        'DelPicContextMenu
        '
        Me.DelPicContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenu, Me.ZoomToolStripMenu, Me.ExportToolStripMenu, Me.PrintToolStripMenu, Me.DelPicToolStripMenu})
        Me.DelPicContextMenu.Name = "DelPicContextMenu"
        Me.DelPicContextMenu.Size = New System.Drawing.Size(137, 114)
        '
        'RefreshToolStripMenu
        '
        Me.RefreshToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.Refresh_grey_16x
        Me.RefreshToolStripMenu.Name = "RefreshToolStripMenu"
        Me.RefreshToolStripMenu.Size = New System.Drawing.Size(136, 22)
        Me.RefreshToolStripMenu.Text = "ฟื้นฟู"
        Me.RefreshToolStripMenu.ToolTipText = "Refresh"
        '
        'ZoomToolStripMenu
        '
        Me.ZoomToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.Zoom_5442
        Me.ZoomToolStripMenu.Name = "ZoomToolStripMenu"
        Me.ZoomToolStripMenu.Size = New System.Drawing.Size(136, 22)
        Me.ZoomToolStripMenu.Text = "ขยาย"
        Me.ZoomToolStripMenu.ToolTipText = "ดูรูปแบบขยาย"
        '
        'ExportToolStripMenu
        '
        Me.ExportToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.save_16xLG
        Me.ExportToolStripMenu.Name = "ExportToolStripMenu"
        Me.ExportToolStripMenu.Size = New System.Drawing.Size(136, 22)
        Me.ExportToolStripMenu.Text = "ส่งออกรูปภาพ"
        Me.ExportToolStripMenu.ToolTipText = "บันทึกรูปเป็นไฟล์"
        '
        'PrintToolStripMenu
        '
        Me.PrintToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.PrintStatusBar2_16x
        Me.PrintToolStripMenu.Name = "PrintToolStripMenu"
        Me.PrintToolStripMenu.Size = New System.Drawing.Size(136, 22)
        Me.PrintToolStripMenu.Text = "พิมพ์"
        Me.PrintToolStripMenu.ToolTipText = "พิมพ์รูปออกทางเครื่องพิมพ์"
        '
        'ToolTip2
        '
        Me.ToolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip2.ToolTipTitle = "จำนวนงานในสถานะ"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.AddExtension = False
        Me.SaveFileDialog1.CheckPathExists = False
        Me.SaveFileDialog1.Filter = "JPEG Image|*.jpg"
        Me.SaveFileDialog1.RestoreDirectory = True
        Me.SaveFileDialog1.Title = "บันทึกไฟล์รูป"
        '
        'RepairStatusFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 574)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "RepairStatusFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "สถานะงานซ่อม"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgRSstatus1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRSdetailIDedit.ResumeLayout(False)
        Me.gbRSdetailIDedit.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.DelPicContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnRSstatus1 As System.Windows.Forms.Button
    Friend WithEvents btnRSstatus2 As System.Windows.Forms.Button
    Friend WithEvents btnRSstatus7 As System.Windows.Forms.Button
    Friend WithEvents btnRSstatus3 As System.Windows.Forms.Button
    Friend WithEvents btnRSstatus6 As System.Windows.Forms.Button
    Friend WithEvents btnRSstatus4 As System.Windows.Forms.Button
    Friend WithEvents btnRSstatus5 As System.Windows.Forms.Button
    Friend WithEvents dgRSstatus1 As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fix_idS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datatime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_idS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_nameS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents snS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents p_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents p_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents model As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents symptomS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents managerdataS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fixrepairnoteS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fixaccessoryS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fixnoteS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fixpriceS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_getS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fixuserS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents statusS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents user_repairS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents note_repairS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents teltocusS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datecom_repair As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importuneS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents storageS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents varuntee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAddPic As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbbRSstorage As System.Windows.Forms.ComboBox
    Friend WithEvents llblRSshelf As System.Windows.Forms.LinkLabel
    Friend WithEvents btnSRsendRepair As System.Windows.Forms.Button
    Friend WithEvents lblRSclaims As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnRSsend_to_claims As System.Windows.Forms.Button
    Friend WithEvents btnRSviewProduct As System.Windows.Forms.Button
    Friend WithEvents lblRSsaleDetail As System.Windows.Forms.Label
    Friend WithEvents lblStatusText As System.Windows.Forms.Label
    Friend WithEvents btnRSPartsWithdrawal As System.Windows.Forms.Button
    Friend WithEvents lblRSteltocus As System.Windows.Forms.Label
    Friend WithEvents cbbRSteltocus As System.Windows.Forms.ComboBox
    Friend WithEvents gbRSdetailIDedit As System.Windows.Forms.GroupBox
    Friend WithEvents txtSN As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRScus_tel As System.Windows.Forms.TextBox
    Friend WithEvents txtRScus_name As System.Windows.Forms.TextBox
    Friend WithEvents txtRScus_id As System.Windows.Forms.TextBox
    Friend WithEvents txtRSfix_id As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblRScusName As System.Windows.Forms.Label
    Friend WithEvents lblRSfix_id As System.Windows.Forms.Label
    Friend WithEvents btnRSsave As System.Windows.Forms.Button
    Friend WithEvents lblRSrepairdetail As System.Windows.Forms.Label
    Friend WithEvents lblRSvaruntee As System.Windows.Forms.Label
    Friend WithEvents cbbRSvaruntee As System.Windows.Forms.ComboBox
    Friend WithEvents cbbRSuser_repair As System.Windows.Forms.ComboBox
    Friend WithEvents lblRSfixstatus As System.Windows.Forms.Label
    Friend WithEvents cbbRSstatus As System.Windows.Forms.ComboBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DelPicToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DelPicContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ListView_note As System.Windows.Forms.ListView
    Friend WithEvents lblAddNoteRapair As System.Windows.Forms.LinkLabel
    Friend WithEvents lblSendFix As System.Windows.Forms.LinkLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnForward As System.Windows.Forms.Button
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ExportToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZoomToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
