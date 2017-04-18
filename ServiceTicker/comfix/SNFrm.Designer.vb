<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SNFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SNFrm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbSNautoSN = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSN = New System.Windows.Forms.Label()
        Me.cbbP_color = New System.Windows.Forms.ComboBox()
        Me.cbbP_model = New System.Windows.Forms.ComboBox()
        Me.cbbP_Name = New System.Windows.Forms.ComboBox()
        Me.cbbP_Type = New System.Windows.Forms.ComboBox()
        Me.txtSNNumber = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SearchToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.SearchToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ShowAllToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EditToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CancelToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.DelToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BackToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.NextToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.dgSN = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Snum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.startdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SendToMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SendToComfixToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgSN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SendToMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.btnHelp})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 415)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(588, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblEmployee
        '
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(35, 17)
        Me.lblEmployee.Text = "Users"
        '
        'btnHelp
        '
        Me.btnHelp.Image = Global.ServiceTicker.My.Resources.Resources._109_AllAnnotations_Help_16x16_72
        Me.btnHelp.IsLink = True
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(16, 17)
        Me.btnHelp.ToolTipText = "Help"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbSNautoSN)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblSN)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbbP_color)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbbP_model)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbbP_Name)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbbP_Type)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSNNumber)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Panel1MinSize = 100
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgSN)
        Me.SplitContainer1.Panel2MinSize = 100
        Me.SplitContainer1.Size = New System.Drawing.Size(588, 415)
        Me.SplitContainer1.SplitterDistance = 100
        Me.SplitContainer1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(482, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "สี"
        '
        'cbSNautoSN
        '
        Me.cbSNautoSN.AutoSize = True
        Me.cbSNautoSN.Location = New System.Drawing.Point(11, 74)
        Me.cbSNautoSN.Name = "cbSNautoSN"
        Me.cbSNautoSN.Size = New System.Drawing.Size(66, 17)
        Me.cbSNautoSN.TabIndex = 51
        Me.cbSNautoSN.Text = "สร้าง SN"
        Me.cbSNautoSN.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(372, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "รุ่น"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(242, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "ยี่ห้อ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "ประเภทสินค้า"
        '
        'lblSN
        '
        Me.lblSN.AutoSize = True
        Me.lblSN.Location = New System.Drawing.Point(8, 31)
        Me.lblSN.Name = "lblSN"
        Me.lblSN.Size = New System.Drawing.Size(70, 13)
        Me.lblSN.TabIndex = 32
        Me.lblSN.Text = "รหัสสินค้า SN"
        '
        'cbbP_color
        '
        Me.cbbP_color.BackColor = System.Drawing.SystemColors.Window
        Me.cbbP_color.FormattingEnabled = True
        Me.cbbP_color.Location = New System.Drawing.Point(485, 47)
        Me.cbbP_color.Name = "cbbP_color"
        Me.cbbP_color.Size = New System.Drawing.Size(95, 21)
        Me.cbbP_color.TabIndex = 4
        '
        'cbbP_model
        '
        Me.cbbP_model.BackColor = System.Drawing.SystemColors.Window
        Me.cbbP_model.FormattingEnabled = True
        Me.cbbP_model.Location = New System.Drawing.Point(372, 47)
        Me.cbbP_model.Name = "cbbP_model"
        Me.cbbP_model.Size = New System.Drawing.Size(107, 21)
        Me.cbbP_model.TabIndex = 3
        '
        'cbbP_Name
        '
        Me.cbbP_Name.BackColor = System.Drawing.SystemColors.Window
        Me.cbbP_Name.FormattingEnabled = True
        Me.cbbP_Name.Location = New System.Drawing.Point(245, 47)
        Me.cbbP_Name.Name = "cbbP_Name"
        Me.cbbP_Name.Size = New System.Drawing.Size(121, 21)
        Me.cbbP_Name.TabIndex = 2
        '
        'cbbP_Type
        '
        Me.cbbP_Type.BackColor = System.Drawing.SystemColors.Window
        Me.cbbP_Type.FormattingEnabled = True
        Me.cbbP_Type.Location = New System.Drawing.Point(118, 47)
        Me.cbbP_Type.Name = "cbbP_Type"
        Me.cbbP_Type.Size = New System.Drawing.Size(121, 21)
        Me.cbbP_Type.TabIndex = 1
        '
        'txtSNNumber
        '
        Me.txtSNNumber.BackColor = System.Drawing.SystemColors.Window
        Me.txtSNNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSNNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSNNumber.ForeColor = System.Drawing.Color.Black
        Me.txtSNNumber.Location = New System.Drawing.Point(11, 47)
        Me.txtSNNumber.Name = "txtSNNumber"
        Me.txtSNNumber.Size = New System.Drawing.Size(100, 21)
        Me.txtSNNumber.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripTextBox, Me.SearchToolStripButton, Me.ShowAllToolStripButton, Me.ToolStripSeparator2, Me.NewToolStripButton, Me.EditToolStripButton, Me.SaveToolStripButton, Me.CancelToolStripButton, Me.toolStripSeparator, Me.DelToolStripButton, Me.toolStripSeparator1, Me.BackToolStripButton, Me.NextToolStripButton, Me.toolStripSeparator4, Me.ToolStripComboBox1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(586, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'SearchToolStripTextBox
        '
        Me.SearchToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchToolStripTextBox.Name = "SearchToolStripTextBox"
        Me.SearchToolStripTextBox.Size = New System.Drawing.Size(200, 25)
        Me.SearchToolStripTextBox.ToolTipText = "ค้นหา"
        '
        'SearchToolStripButton
        '
        Me.SearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SearchToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.ZoomNeutral_16xlG
        Me.SearchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SearchToolStripButton.Name = "SearchToolStripButton"
        Me.SearchToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SearchToolStripButton.Text = "ค้นหา"
        '
        'ShowAllToolStripButton
        '
        Me.ShowAllToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ShowAllToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.list_16xLG
        Me.ShowAllToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ShowAllToolStripButton.Name = "ShowAllToolStripButton"
        Me.ShowAllToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ShowAllToolStripButton.Text = "แสดงทั้งหมด"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "เพิ่ม"
        '
        'EditToolStripButton
        '
        Me.EditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.PencilAngled_16xLG_color
        Me.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditToolStripButton.Name = "EditToolStripButton"
        Me.EditToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.EditToolStripButton.Text = "แก้ไข"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "บันทึก"
        '
        'CancelToolStripButton
        '
        Me.CancelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CancelToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.Undo_16x
        Me.CancelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelToolStripButton.Name = "CancelToolStripButton"
        Me.CancelToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CancelToolStripButton.Text = "ยกเลิก"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'DelToolStripButton
        '
        Me.DelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DelToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.action_Cancel_16xLG
        Me.DelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DelToolStripButton.Name = "DelToolStripButton"
        Me.DelToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.DelToolStripButton.Text = "ลบ"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BackToolStripButton
        '
        Me.BackToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BackToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.arrow_back_color_16xLG
        Me.BackToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BackToolStripButton.Name = "BackToolStripButton"
        Me.BackToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.BackToolStripButton.Text = "ก่อนหน้า"
        '
        'NextToolStripButton
        '
        Me.NextToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NextToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.arrow_Forward_color_16xLG
        Me.NextToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NextToolStripButton.Name = "NextToolStripButton"
        Me.NextToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NextToolStripButton.Text = "ถัดไป"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"10", "100", "1000", "10000", "100000", "1000000", "10000000", "100000000", "1000000000"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(110, 25)
        Me.ToolStripComboBox1.ToolTipText = "จำนวนการแสดงผลค้นหา"
        '
        'dgSN
        '
        Me.dgSN.AllowUserToAddRows = False
        Me.dgSN.AllowUserToDeleteRows = False
        Me.dgSN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgSN.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSN.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgSN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.Snum, Me.p_type, Me.p_name, Me.model, Me.color, Me.startdate})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgSN.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgSN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSN.Location = New System.Drawing.Point(0, 0)
        Me.dgSN.Name = "dgSN"
        Me.dgSN.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSN.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgSN.RowHeadersVisible = False
        Me.dgSN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSN.Size = New System.Drawing.Size(586, 309)
        Me.dgSN.TabIndex = 40
        '
        'no
        '
        Me.no.DataPropertyName = "no"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.no.DefaultCellStyle = DataGridViewCellStyle2
        Me.no.FillWeight = 35.0!
        Me.no.HeaderText = "#"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.ToolTipText = "ลำดับ"
        '
        'Snum
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        Me.Snum.DefaultCellStyle = DataGridViewCellStyle3
        Me.Snum.HeaderText = "SN"
        Me.Snum.Name = "Snum"
        Me.Snum.ReadOnly = True
        Me.Snum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Snum.ToolTipText = "หมายเลขประจำเครื่อง"
        '
        'p_type
        '
        Me.p_type.DataPropertyName = "p_type"
        Me.p_type.HeaderText = "ประเภท"
        Me.p_type.Name = "p_type"
        Me.p_type.ReadOnly = True
        Me.p_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.p_type.ToolTipText = "ประเภทสินค้า"
        '
        'p_name
        '
        Me.p_name.DataPropertyName = "p_name"
        Me.p_name.HeaderText = "ยี่ห้อ"
        Me.p_name.Name = "p_name"
        Me.p_name.ReadOnly = True
        Me.p_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.p_name.ToolTipText = "ยี่ห้อสินค้า"
        '
        'model
        '
        Me.model.DataPropertyName = "model"
        Me.model.HeaderText = "รุ่น"
        Me.model.Name = "model"
        Me.model.ReadOnly = True
        Me.model.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.model.ToolTipText = "รุ่นสินค้า"
        '
        'color
        '
        Me.color.DataPropertyName = "color"
        Me.color.HeaderText = "สี"
        Me.color.Name = "color"
        Me.color.ReadOnly = True
        Me.color.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.color.ToolTipText = "สีตัวเครื่อง"
        '
        'startdate
        '
        Me.startdate.DataPropertyName = "startdate"
        Me.startdate.HeaderText = "วันที่บันทึก"
        Me.startdate.Name = "startdate"
        Me.startdate.ReadOnly = True
        Me.startdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.startdate.ToolTipText = "วันที่บันทึก"
        '
        'Timer1
        '
        Me.Timer1.Interval = 6000
        '
        'SendToMenu
        '
        Me.SendToMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SendToComfixToolStripMenu})
        Me.SendToMenu.Name = "SendToMenu"
        Me.SendToMenu.Size = New System.Drawing.Size(164, 26)
        '
        'SendToComfixToolStripMenu
        '
        Me.SendToComfixToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.WorkItem_16x
        Me.SendToComfixToolStripMenu.Name = "SendToComfixToolStripMenu"
        Me.SendToComfixToolStripMenu.Size = New System.Drawing.Size(163, 22)
        Me.SendToComfixToolStripMenu.Text = "ส่งไปหน้ารับงานซ่อม"
        '
        'SNFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 437)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "SNFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รหัสประจำเครื่อง (SN)"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgSN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SendToMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents cbbP_color As System.Windows.Forms.ComboBox
    Friend WithEvents cbbP_model As System.Windows.Forms.ComboBox
    Friend WithEvents cbbP_Name As System.Windows.Forms.ComboBox
    Friend WithEvents cbbP_Type As System.Windows.Forms.ComboBox
    Friend WithEvents txtSNNumber As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents SearchToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SearchToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ShowAllToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CancelToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DelToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BackToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents NextToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbSNautoSN As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSN As System.Windows.Forms.Label
    Friend WithEvents dgSN As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents SendToMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SendToComfixToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Snum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents p_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents p_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents model As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents color As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents startdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
