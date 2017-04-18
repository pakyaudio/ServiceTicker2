<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductDetailFrm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblPDnoteUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.dgPDprolist = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.count_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_edit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtPDprodetail = New System.Windows.Forms.TextBox()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.dgPDserial = New System.Windows.Forms.DataGridView()
        Me.serial_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_in = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnForward = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnManagerSN = New System.Windows.Forms.Button()
        Me.btnPDsearch = New System.Windows.Forms.Button()
        Me.btnPDadd = New System.Windows.Forms.Button()
        Me.btnPDedit = New System.Windows.Forms.Button()
        Me.btnPDdel = New System.Windows.Forms.Button()
        Me.ParentChildContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditParentChildToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveParentChildToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelParentChildToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChildContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddChildToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditChildToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelChildToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddChildRootNodesContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddRootToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataGridContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MoveSectionDGToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.dgPDprolist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.dgPDserial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ParentChildContextMenu.SuspendLayout()
        Me.ChildContextMenu.SuspendLayout()
        Me.AddChildRootNodesContextMenu.SuspendLayout()
        Me.DataGridContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.btnHelp, Me.lblPDnoteUser})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 536)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 25)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblEmployee
        '
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(30, 20)
        Me.lblEmployee.Text = "User"
        '
        'btnHelp
        '
        Me.btnHelp.AutoToolTip = True
        Me.btnHelp.Image = Global.ServiceTicker.My.Resources.Resources._109_AllAnnotations_Help_16x16_72
        Me.btnHelp.IsLink = True
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(16, 20)
        Me.btnHelp.ToolTipText = "Help"
        '
        'lblPDnoteUser
        '
        Me.lblPDnoteUser.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPDnoteUser.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblPDnoteUser.Image = Global.ServiceTicker.My.Resources.Resources._109_AllAnnotations_Warning_16x16_72
        Me.lblPDnoteUser.Name = "lblPDnoteUser"
        Me.lblPDnoteUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPDnoteUser.Size = New System.Drawing.Size(481, 20)
        Me.lblPDnoteUser.Text = "ควรจัดซื้อสินค้าเข้าตามระบบเพื่อเป็นการง่ายต่อการตรวจสอบและคำนวนทุน/กำไร"
        Me.lblPDnoteUser.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(784, 536)
        Me.SplitContainer1.SplitterDistance = 273
        Me.SplitContainer1.TabIndex = 1
        '
        'TreeView1
        '
        Me.TreeView1.AllowDrop = True
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TreeView1.Indent = 19
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(271, 534)
        Me.TreeView1.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.TreeView1, "คลิ๊กขวาเพื่อจัดการหมวดหมู่สินค้า")
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 41)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer4)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(507, 495)
        Me.SplitContainer2.SplitterDistance = 329
        Me.SplitContainer2.TabIndex = 1
        '
        'SplitContainer4
        '
        Me.SplitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.dgPDprolist)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.txtPDprodetail)
        Me.SplitContainer4.Size = New System.Drawing.Size(507, 329)
        Me.SplitContainer4.SplitterDistance = 258
        Me.SplitContainer4.TabIndex = 0
        '
        'dgPDprolist
        '
        Me.dgPDprolist.AllowUserToAddRows = False
        Me.dgPDprolist.AllowUserToDeleteRows = False
        Me.dgPDprolist.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgPDprolist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPDprolist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.code_pro, Me.name_pro, Me.count_num, Me.datetime_edit})
        Me.dgPDprolist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPDprolist.Location = New System.Drawing.Point(0, 0)
        Me.dgPDprolist.MultiSelect = False
        Me.dgPDprolist.Name = "dgPDprolist"
        Me.dgPDprolist.ReadOnly = True
        Me.dgPDprolist.RowHeadersVisible = False
        Me.dgPDprolist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPDprolist.Size = New System.Drawing.Size(505, 256)
        Me.dgPDprolist.TabIndex = 0
        '
        'no
        '
        Me.no.HeaderText = "#"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 30
        '
        'code_pro
        '
        Me.code_pro.HeaderText = "รหัสสินค้า"
        Me.code_pro.Name = "code_pro"
        Me.code_pro.ReadOnly = True
        Me.code_pro.Width = 90
        '
        'name_pro
        '
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        Me.name_pro.Width = 200
        '
        'count_num
        '
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = "0"
        Me.count_num.DefaultCellStyle = DataGridViewCellStyle1
        Me.count_num.HeaderText = "เหลือ"
        Me.count_num.Name = "count_num"
        Me.count_num.ReadOnly = True
        Me.count_num.Width = 50
        '
        'datetime_edit
        '
        Me.datetime_edit.HeaderText = "วันที่ปรับปรุง"
        Me.datetime_edit.Name = "datetime_edit"
        Me.datetime_edit.ReadOnly = True
        Me.datetime_edit.Width = 110
        '
        'txtPDprodetail
        '
        Me.txtPDprodetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPDprodetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPDprodetail.Location = New System.Drawing.Point(0, 0)
        Me.txtPDprodetail.Multiline = True
        Me.txtPDprodetail.Name = "txtPDprodetail"
        Me.txtPDprodetail.Size = New System.Drawing.Size(505, 65)
        Me.txtPDprodetail.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.ListView1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.dgPDserial)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer3.Size = New System.Drawing.Size(507, 162)
        Me.SplitContainer3.SplitterDistance = 180
        Me.SplitContainer3.TabIndex = 0
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(178, 160)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'dgPDserial
        '
        Me.dgPDserial.AllowUserToAddRows = False
        Me.dgPDserial.AllowUserToDeleteRows = False
        Me.dgPDserial.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgPDserial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPDserial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.serial_pro, Me.date_in})
        Me.dgPDserial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPDserial.GridColor = System.Drawing.SystemColors.Control
        Me.dgPDserial.Location = New System.Drawing.Point(0, 0)
        Me.dgPDserial.Name = "dgPDserial"
        Me.dgPDserial.ReadOnly = True
        Me.dgPDserial.RowHeadersVisible = False
        Me.dgPDserial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPDserial.Size = New System.Drawing.Size(321, 129)
        Me.dgPDserial.TabIndex = 89
        '
        'serial_pro
        '
        Me.serial_pro.DataPropertyName = "serial_pro"
        Me.serial_pro.HeaderText = "SN"
        Me.serial_pro.Name = "serial_pro"
        Me.serial_pro.ReadOnly = True
        Me.serial_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.serial_pro.ToolTipText = "หมายเลขประจำสินค้า"
        Me.serial_pro.Width = 120
        '
        'date_in
        '
        Me.date_in.DataPropertyName = "date_in"
        Me.date_in.HeaderText = "วันที่"
        Me.date_in.Name = "date_in"
        Me.date_in.ReadOnly = True
        Me.date_in.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.date_in.ToolTipText = "วันที่นำเข้า"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnForward)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.NumericUpDown1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 129)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(321, 31)
        Me.Panel2.TabIndex = 90
        '
        'btnForward
        '
        Me.btnForward.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnForward.Enabled = False
        Me.btnForward.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnForward.Image = Global.ServiceTicker.My.Resources.Resources.AzureMySQLDatabase_color_16x
        Me.btnForward.Location = New System.Drawing.Point(214, 3)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(105, 26)
        Me.btnForward.TabIndex = 11
        Me.btnForward.Text = "โหลดข้อมูลเพิ่ม"
        Me.btnForward.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnForward.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "0"
        Me.ToolTip1.SetToolTip(Me.Label2, "จำนวแถวที่แสดง/จำนวนทั้งหมด")
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDown1.Location = New System.Drawing.Point(3, 6)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(93, 20)
        Me.NumericUpDown1.TabIndex = 8
        Me.NumericUpDown1.ThousandsSeparator = True
        Me.ToolTip1.SetToolTip(Me.NumericUpDown1, "ลิมิตในการโหลดข้อมูล(การกำหนดจำนวนมากอาจจะใช้เวลามากในการดึงข้อมูล)")
        Me.NumericUpDown1.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnManagerSN)
        Me.Panel1.Controls.Add(Me.btnPDsearch)
        Me.Panel1.Controls.Add(Me.btnPDadd)
        Me.Panel1.Controls.Add(Me.btnPDedit)
        Me.Panel1.Controls.Add(Me.btnPDdel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(507, 41)
        Me.Panel1.TabIndex = 0
        '
        'btnManagerSN
        '
        Me.btnManagerSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnManagerSN.Image = Global.ServiceTicker.My.Resources.Resources.list_16xLG
        Me.btnManagerSN.Location = New System.Drawing.Point(246, 3)
        Me.btnManagerSN.Name = "btnManagerSN"
        Me.btnManagerSN.Size = New System.Drawing.Size(106, 32)
        Me.btnManagerSN.TabIndex = 4
        Me.btnManagerSN.Text = "จัดการ SN"
        Me.btnManagerSN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnManagerSN.UseVisualStyleBackColor = True
        '
        'btnPDsearch
        '
        Me.btnPDsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPDsearch.Image = Global.ServiceTicker.My.Resources.Resources.VSO_Search_16x
        Me.btnPDsearch.Location = New System.Drawing.Point(165, 3)
        Me.btnPDsearch.Name = "btnPDsearch"
        Me.btnPDsearch.Size = New System.Drawing.Size(75, 32)
        Me.btnPDsearch.TabIndex = 3
        Me.btnPDsearch.Text = "ค้นหา"
        Me.btnPDsearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPDsearch.UseVisualStyleBackColor = True
        '
        'btnPDadd
        '
        Me.btnPDadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPDadd.Image = Global.ServiceTicker.My.Resources.Resources.add
        Me.btnPDadd.Location = New System.Drawing.Point(3, 3)
        Me.btnPDadd.Name = "btnPDadd"
        Me.btnPDadd.Size = New System.Drawing.Size(75, 32)
        Me.btnPDadd.TabIndex = 2
        Me.btnPDadd.Text = "เพิ่ม"
        Me.btnPDadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPDadd.UseVisualStyleBackColor = True
        '
        'btnPDedit
        '
        Me.btnPDedit.Enabled = False
        Me.btnPDedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPDedit.Image = Global.ServiceTicker.My.Resources.Resources.PencilAngled_16xLG_color
        Me.btnPDedit.Location = New System.Drawing.Point(84, 3)
        Me.btnPDedit.Name = "btnPDedit"
        Me.btnPDedit.Size = New System.Drawing.Size(75, 32)
        Me.btnPDedit.TabIndex = 1
        Me.btnPDedit.Text = "แก้ไข"
        Me.btnPDedit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPDedit.UseVisualStyleBackColor = True
        '
        'btnPDdel
        '
        Me.btnPDdel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPDdel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPDdel.Image = Global.ServiceTicker.My.Resources.Resources.VSO_RecycleBin_16x
        Me.btnPDdel.Location = New System.Drawing.Point(429, 3)
        Me.btnPDdel.Name = "btnPDdel"
        Me.btnPDdel.Size = New System.Drawing.Size(63, 32)
        Me.btnPDdel.TabIndex = 0
        Me.btnPDdel.Text = "ลบ"
        Me.btnPDdel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPDdel.UseVisualStyleBackColor = True
        '
        'ParentChildContextMenu
        '
        Me.ParentChildContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditParentChildToolStripMenu, Me.MoveParentChildToolStripMenu, Me.DelParentChildToolStripMenu})
        Me.ParentChildContextMenu.Name = "ParentChildContextMenu"
        Me.ParentChildContextMenu.Size = New System.Drawing.Size(171, 70)
        '
        'EditParentChildToolStripMenu
        '
        Me.EditParentChildToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.PencilAngled_16xLG_color
        Me.EditParentChildToolStripMenu.Name = "EditParentChildToolStripMenu"
        Me.EditParentChildToolStripMenu.Size = New System.Drawing.Size(170, 22)
        Me.EditParentChildToolStripMenu.Text = "แก้ไขชื่อหมวดหมู่ย่อย"
        '
        'MoveParentChildToolStripMenu
        '
        Me.MoveParentChildToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.GotoNextRow_289
        Me.MoveParentChildToolStripMenu.Name = "MoveParentChildToolStripMenu"
        Me.MoveParentChildToolStripMenu.Size = New System.Drawing.Size(170, 22)
        Me.MoveParentChildToolStripMenu.Text = "ย้ายหมวดหมู่"
        '
        'DelParentChildToolStripMenu
        '
        Me.DelParentChildToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.action_Cancel_16xLG
        Me.DelParentChildToolStripMenu.Name = "DelParentChildToolStripMenu"
        Me.DelParentChildToolStripMenu.Size = New System.Drawing.Size(170, 22)
        Me.DelParentChildToolStripMenu.Text = "ลบหมวดหมู่ย่อยสินค้า"
        '
        'ChildContextMenu
        '
        Me.ChildContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddChildToolStripMenu, Me.EditChildToolStripMenu, Me.MoveToolStripMenu, Me.DelChildToolStripMenu})
        Me.ChildContextMenu.Name = "AddNodesContextMenu"
        Me.ChildContextMenu.Size = New System.Drawing.Size(178, 92)
        '
        'AddChildToolStripMenu
        '
        Me.AddChildToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.Add_16x
        Me.AddChildToolStripMenu.Name = "AddChildToolStripMenu"
        Me.AddChildToolStripMenu.Size = New System.Drawing.Size(177, 22)
        Me.AddChildToolStripMenu.Text = "เพิ่มหมวดหมู่ย่อยสินค้า"
        '
        'EditChildToolStripMenu
        '
        Me.EditChildToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.PencilAngled_16xLG_color
        Me.EditChildToolStripMenu.Name = "EditChildToolStripMenu"
        Me.EditChildToolStripMenu.Size = New System.Drawing.Size(177, 22)
        Me.EditChildToolStripMenu.Text = "แก้ไขชื่อหมวดหมู่สินค้า"
        '
        'MoveToolStripMenu
        '
        Me.MoveToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.GotoNextRow_289
        Me.MoveToolStripMenu.Name = "MoveToolStripMenu"
        Me.MoveToolStripMenu.Size = New System.Drawing.Size(177, 22)
        Me.MoveToolStripMenu.Text = "ย้ายหมวดหมู่ย่อย"
        '
        'DelChildToolStripMenu
        '
        Me.DelChildToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.action_Cancel_16xLG
        Me.DelChildToolStripMenu.Name = "DelChildToolStripMenu"
        Me.DelChildToolStripMenu.Size = New System.Drawing.Size(177, 22)
        Me.DelChildToolStripMenu.Text = "ลบหมวดหมู่สินค้า"
        '
        'AddChildRootNodesContextMenu
        '
        Me.AddChildRootNodesContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddRootToolStripMenu})
        Me.AddChildRootNodesContextMenu.Name = "AddNodesContextMenu"
        Me.AddChildRootNodesContextMenu.Size = New System.Drawing.Size(158, 26)
        '
        'AddRootToolStripMenu
        '
        Me.AddRootToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.Add_16x
        Me.AddRootToolStripMenu.Name = "AddRootToolStripMenu"
        Me.AddRootToolStripMenu.Size = New System.Drawing.Size(157, 22)
        Me.AddRootToolStripMenu.Text = "เพิ่มหมวดหมู่สินค้า"
        '
        'DataGridContextMenu
        '
        Me.DataGridContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoveSectionDGToolStripMenu})
        Me.DataGridContextMenu.Name = "AddNodesContextMenu"
        Me.DataGridContextMenu.Size = New System.Drawing.Size(157, 48)
        '
        'MoveSectionDGToolStripMenu
        '
        Me.MoveSectionDGToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.GotoNextRow_289
        Me.MoveSectionDGToolStripMenu.Name = "MoveSectionDGToolStripMenu"
        Me.MoveSectionDGToolStripMenu.Size = New System.Drawing.Size(156, 22)
        Me.MoveSectionDGToolStripMenu.Text = "ย้ายหมวดหมู่สินค้า"
        '
        'ProductDetailFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "ProductDetailFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายการสินค้า"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.Panel2.PerformLayout()
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.dgPDprolist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.dgPDserial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ParentChildContextMenu.ResumeLayout(False)
        Me.ChildContextMenu.ResumeLayout(False)
        Me.AddChildRootNodesContextMenu.ResumeLayout(False)
        Me.DataGridContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblPDnoteUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ParentChildContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditParentChildToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DelParentChildToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChildContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddChildToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditChildToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DelChildToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddChildRootNodesContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddRootToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgPDprolist As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgPDserial As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPDadd As System.Windows.Forms.Button
    Friend WithEvents btnPDedit As System.Windows.Forms.Button
    Friend WithEvents btnPDdel As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtPDprodetail As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnPDsearch As System.Windows.Forms.Button
    Friend WithEvents btnManagerSN As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnForward As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents serial_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_in As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents count_num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_edit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MoveToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoveParentChildToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MoveSectionDGToolStripMenu As System.Windows.Forms.ToolStripMenuItem
End Class
