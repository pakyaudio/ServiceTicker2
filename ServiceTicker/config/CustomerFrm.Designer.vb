<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerFrm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnPicture = New System.Windows.Forms.Button()
        Me.cbAutoCusID = New System.Windows.Forms.CheckBox()
        Me.txtCustomerAddress = New System.Windows.Forms.TextBox()
        Me.lblCusCountNum = New System.Windows.Forms.Label()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.txtCustomerZipcode = New System.Windows.Forms.TextBox()
        Me.lblCustomerZipcode = New System.Windows.Forms.Label()
        Me.txtCustomerTel = New System.Windows.Forms.TextBox()
        Me.lblCustomerAddress = New System.Windows.Forms.Label()
        Me.txtCustomerNote = New System.Windows.Forms.TextBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.txtCustomerTAX = New System.Windows.Forms.TextBox()
        Me.lblCustomerTel = New System.Windows.Forms.Label()
        Me.lblCustomerTAX = New System.Windows.Forms.Label()
        Me.txtCustomerSection = New System.Windows.Forms.TextBox()
        Me.lblCustomerNote = New System.Windows.Forms.Label()
        Me.lblCustomerSection = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.MenuToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EditToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CancelToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BackToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.NextToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SearchToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.SearchToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ShowAllStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cbbCustomerPrice_leval = New System.Windows.Forms.ToolStripComboBox()
        Me.cbbCustomerCadit = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.dgCustomerSearch = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cus_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cus_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tex_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tax_sec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cus_address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cus_zip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cus_tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_leval = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cadit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cus_note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_edit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.MenuToolStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCustomerSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MenuToolStrip)
        Me.SplitContainer1.Panel1MinSize = 0
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgCustomerSearch)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 22)
        Me.SplitContainer1.Panel2MinSize = 0
        Me.SplitContainer1.Size = New System.Drawing.Size(784, 561)
        Me.SplitContainer1.SplitterDistance = 227
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.cbAutoCusID)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtCustomerAddress)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lblCusCountNum)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtCustomerID)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lblCustomerID)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtCustomerZipcode)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lblCustomerZipcode)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtCustomerTel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lblCustomerAddress)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtCustomerNote)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lblCustomerName)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtCustomerTAX)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lblCustomerTel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lblCustomerTAX)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtCustomerSection)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lblCustomerNote)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lblCustomerSection)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtCustomerName)
        Me.SplitContainer2.Size = New System.Drawing.Size(784, 202)
        Me.SplitContainer2.SplitterDistance = 286
        Me.SplitContainer2.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(284, 174)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnPicture)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 174)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(284, 26)
        Me.Panel2.TabIndex = 0
        '
        'btnPicture
        '
        Me.btnPicture.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPicture.Image = Global.ServiceTicker.My.Resources.Resources.Camera_16x
        Me.btnPicture.Location = New System.Drawing.Point(240, 1)
        Me.btnPicture.Name = "btnPicture"
        Me.btnPicture.Size = New System.Drawing.Size(41, 23)
        Me.btnPicture.TabIndex = 0
        Me.btnPicture.UseVisualStyleBackColor = True
        '
        'cbAutoCusID
        '
        Me.cbAutoCusID.AutoSize = True
        Me.cbAutoCusID.Location = New System.Drawing.Point(353, 7)
        Me.cbAutoCusID.Name = "cbAutoCusID"
        Me.cbAutoCusID.Size = New System.Drawing.Size(132, 17)
        Me.cbAutoCusID.TabIndex = 1
        Me.cbAutoCusID.Text = "สร้างรหัสลูกค้าอัตโนมัติ"
        Me.cbAutoCusID.UseVisualStyleBackColor = True
        '
        'txtCustomerAddress
        '
        Me.txtCustomerAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCustomerAddress.Location = New System.Drawing.Point(104, 81)
        Me.txtCustomerAddress.Name = "txtCustomerAddress"
        Me.txtCustomerAddress.Size = New System.Drawing.Size(375, 24)
        Me.txtCustomerAddress.TabIndex = 5
        '
        'lblCusCountNum
        '
        Me.lblCusCountNum.AutoSize = True
        Me.lblCusCountNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCusCountNum.Location = New System.Drawing.Point(332, 135)
        Me.lblCusCountNum.Name = "lblCusCountNum"
        Me.lblCusCountNum.Size = New System.Drawing.Size(10, 15)
        Me.lblCusCountNum.TabIndex = 16
        Me.lblCusCountNum.Text = "."
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Enabled = False
        Me.txtCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCustomerID.HideSelection = False
        Me.txtCustomerID.Location = New System.Drawing.Point(68, 3)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(279, 24)
        Me.txtCustomerID.TabIndex = 0
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCustomerID.Location = New System.Drawing.Point(4, 6)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(58, 15)
        Me.lblCustomerID.TabIndex = 9
        Me.lblCustomerID.Text = "รหัสสมาชิก"
        '
        'txtCustomerZipcode
        '
        Me.txtCustomerZipcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCustomerZipcode.Location = New System.Drawing.Point(104, 107)
        Me.txtCustomerZipcode.MaxLength = 5
        Me.txtCustomerZipcode.Name = "txtCustomerZipcode"
        Me.txtCustomerZipcode.Size = New System.Drawing.Size(108, 24)
        Me.txtCustomerZipcode.TabIndex = 6
        '
        'lblCustomerZipcode
        '
        Me.lblCustomerZipcode.AutoSize = True
        Me.lblCustomerZipcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCustomerZipcode.Location = New System.Drawing.Point(28, 109)
        Me.lblCustomerZipcode.Name = "lblCustomerZipcode"
        Me.lblCustomerZipcode.Size = New System.Drawing.Size(69, 15)
        Me.lblCustomerZipcode.TabIndex = 13
        Me.lblCustomerZipcode.Text = "รหัสไปรษณีย์"
        '
        'txtCustomerTel
        '
        Me.txtCustomerTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCustomerTel.Location = New System.Drawing.Point(104, 133)
        Me.txtCustomerTel.Name = "txtCustomerTel"
        Me.txtCustomerTel.Size = New System.Drawing.Size(223, 24)
        Me.txtCustomerTel.TabIndex = 7
        '
        'lblCustomerAddress
        '
        Me.lblCustomerAddress.AutoSize = True
        Me.lblCustomerAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCustomerAddress.Location = New System.Drawing.Point(70, 83)
        Me.lblCustomerAddress.Name = "lblCustomerAddress"
        Me.lblCustomerAddress.Size = New System.Drawing.Size(27, 15)
        Me.lblCustomerAddress.TabIndex = 12
        Me.lblCustomerAddress.Text = "ที่อยู่"
        '
        'txtCustomerNote
        '
        Me.txtCustomerNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCustomerNote.Location = New System.Drawing.Point(104, 159)
        Me.txtCustomerNote.Name = "txtCustomerNote"
        Me.txtCustomerNote.Size = New System.Drawing.Size(376, 24)
        Me.txtCustomerNote.TabIndex = 8
        Me.txtCustomerNote.Text = "-"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(53, 58)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(45, 15)
        Me.lblCustomerName.TabIndex = 11
        Me.lblCustomerName.Text = "ชื่อลูกค้า"
        '
        'txtCustomerTAX
        '
        Me.txtCustomerTAX.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCustomerTAX.Location = New System.Drawing.Point(104, 29)
        Me.txtCustomerTAX.MaxLength = 500
        Me.txtCustomerTAX.Name = "txtCustomerTAX"
        Me.txtCustomerTAX.Size = New System.Drawing.Size(118, 24)
        Me.txtCustomerTAX.TabIndex = 2
        Me.txtCustomerTAX.Text = "0000000000000"
        '
        'lblCustomerTel
        '
        Me.lblCustomerTel.AutoSize = True
        Me.lblCustomerTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCustomerTel.Location = New System.Drawing.Point(25, 135)
        Me.lblCustomerTel.Name = "lblCustomerTel"
        Me.lblCustomerTel.Size = New System.Drawing.Size(72, 15)
        Me.lblCustomerTel.TabIndex = 14
        Me.lblCustomerTel.Text = "เบอร์โทรศัพท์"
        '
        'lblCustomerTAX
        '
        Me.lblCustomerTAX.AutoSize = True
        Me.lblCustomerTAX.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCustomerTAX.Location = New System.Drawing.Point(3, 32)
        Me.lblCustomerTAX.Name = "lblCustomerTAX"
        Me.lblCustomerTAX.Size = New System.Drawing.Size(96, 15)
        Me.lblCustomerTAX.TabIndex = 10
        Me.lblCustomerTAX.Text = "หมายเลขผู้เสียภาษี"
        '
        'txtCustomerSection
        '
        Me.txtCustomerSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCustomerSection.Location = New System.Drawing.Point(264, 29)
        Me.txtCustomerSection.Name = "txtCustomerSection"
        Me.txtCustomerSection.Size = New System.Drawing.Size(157, 24)
        Me.txtCustomerSection.TabIndex = 3
        Me.txtCustomerSection.Text = "-"
        '
        'lblCustomerNote
        '
        Me.lblCustomerNote.AutoSize = True
        Me.lblCustomerNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCustomerNote.Location = New System.Drawing.Point(45, 161)
        Me.lblCustomerNote.Name = "lblCustomerNote"
        Me.lblCustomerNote.Size = New System.Drawing.Size(52, 15)
        Me.lblCustomerNote.TabIndex = 15
        Me.lblCustomerNote.Text = "หมายเหตุ"
        '
        'lblCustomerSection
        '
        Me.lblCustomerSection.AutoSize = True
        Me.lblCustomerSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCustomerSection.Location = New System.Drawing.Point(228, 32)
        Me.lblCustomerSection.Name = "lblCustomerSection"
        Me.lblCustomerSection.Size = New System.Drawing.Size(30, 15)
        Me.lblCustomerSection.TabIndex = 17
        Me.lblCustomerSection.Text = "สาขา"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(104, 55)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(375, 24)
        Me.txtCustomerName.TabIndex = 4
        '
        'MenuToolStrip
        '
        Me.MenuToolStrip.BackColor = System.Drawing.Color.Transparent
        Me.MenuToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.EditToolStripButton, Me.SaveToolStripButton, Me.CancelToolStripButton, Me.toolStripSeparator, Me.DeleteToolStripButton, Me.ToolStripSeparator2, Me.BackToolStripButton, Me.NextToolStripButton, Me.toolStripSeparator1, Me.SearchToolStripTextBox, Me.SearchToolStripButton, Me.ShowAllStripButton, Me.ToolStripSeparator3, Me.cbbCustomerPrice_leval, Me.cbbCustomerCadit, Me.ToolStripSeparator4})
        Me.MenuToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuToolStrip.Name = "MenuToolStrip"
        Me.MenuToolStrip.Size = New System.Drawing.Size(784, 25)
        Me.MenuToolStrip.TabIndex = 0
        Me.MenuToolStrip.Text = "ToolStrip1"
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
        'DeleteToolStripButton
        '
        Me.DeleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DeleteToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.action_Cancel_16xLG
        Me.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteToolStripButton.Name = "DeleteToolStripButton"
        Me.DeleteToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.DeleteToolStripButton.Text = "ลบ"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'SearchToolStripTextBox
        '
        Me.SearchToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchToolStripTextBox.Name = "SearchToolStripTextBox"
        Me.SearchToolStripTextBox.Size = New System.Drawing.Size(250, 25)
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
        'ShowAllStripButton
        '
        Me.ShowAllStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ShowAllStripButton.Image = Global.ServiceTicker.My.Resources.Resources.Team_16xLG
        Me.ShowAllStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ShowAllStripButton.Name = "ShowAllStripButton"
        Me.ShowAllStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ShowAllStripButton.Text = "แสดงรายชื่อทั้งหมด"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'cbbCustomerPrice_leval
        '
        Me.cbbCustomerPrice_leval.AutoToolTip = True
        Me.cbbCustomerPrice_leval.BackColor = System.Drawing.SystemColors.Window
        Me.cbbCustomerPrice_leval.Name = "cbbCustomerPrice_leval"
        Me.cbbCustomerPrice_leval.Size = New System.Drawing.Size(121, 25)
        Me.cbbCustomerPrice_leval.ToolTipText = "ระดับราคา"
        '
        'cbbCustomerCadit
        '
        Me.cbbCustomerCadit.AutoToolTip = True
        Me.cbbCustomerCadit.Name = "cbbCustomerCadit"
        Me.cbbCustomerCadit.Size = New System.Drawing.Size(121, 25)
        Me.cbbCustomerCadit.ToolTipText = "กำหนดเครดิต"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.NumericUpDown1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 280)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(782, 26)
        Me.Panel1.TabIndex = 1
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDown1.Location = New System.Drawing.Point(3, 3)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(74, 20)
        Me.NumericUpDown1.TabIndex = 0
        Me.NumericUpDown1.TabStop = False
        Me.NumericUpDown1.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'dgCustomerSearch
        '
        Me.dgCustomerSearch.AllowUserToAddRows = False
        Me.dgCustomerSearch.AllowUserToDeleteRows = False
        Me.dgCustomerSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgCustomerSearch.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCustomerSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgCustomerSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCustomerSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.cus_id, Me.cus_name, Me.tex_num, Me.tax_sec, Me.cus_address, Me.cus_zip, Me.cus_tel, Me.price_leval, Me.cadit, Me.cus_note, Me.date_edit, Me.date_save})
        Me.dgCustomerSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCustomerSearch.Location = New System.Drawing.Point(0, 0)
        Me.dgCustomerSearch.MultiSelect = False
        Me.dgCustomerSearch.Name = "dgCustomerSearch"
        Me.dgCustomerSearch.ReadOnly = True
        Me.dgCustomerSearch.RowHeadersVisible = False
        Me.dgCustomerSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgCustomerSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCustomerSearch.Size = New System.Drawing.Size(782, 306)
        Me.dgCustomerSearch.TabIndex = 0
        '
        'no
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.no.DefaultCellStyle = DataGridViewCellStyle1
        Me.no.FillWeight = 30.0!
        Me.no.HeaderText = "#"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'cus_id
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cus_id.DefaultCellStyle = DataGridViewCellStyle2
        Me.cus_id.FillWeight = 91.83587!
        Me.cus_id.HeaderText = "รหัสลูกค้า"
        Me.cus_id.Name = "cus_id"
        Me.cus_id.ReadOnly = True
        Me.cus_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'cus_name
        '
        Me.cus_name.FillWeight = 91.83587!
        Me.cus_name.HeaderText = "ชื่อลูกค้า"
        Me.cus_name.Name = "cus_name"
        Me.cus_name.ReadOnly = True
        Me.cus_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'tex_num
        '
        Me.tex_num.FillWeight = 91.83587!
        Me.tex_num.HeaderText = "เลขภาษี"
        Me.tex_num.Name = "tex_num"
        Me.tex_num.ReadOnly = True
        Me.tex_num.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.tex_num.ToolTipText = "หมายเลขผู้เสียภาษี"
        '
        'tax_sec
        '
        Me.tax_sec.FillWeight = 91.83587!
        Me.tax_sec.HeaderText = "สาขา"
        Me.tax_sec.Name = "tax_sec"
        Me.tax_sec.ReadOnly = True
        Me.tax_sec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'cus_address
        '
        Me.cus_address.FillWeight = 91.83587!
        Me.cus_address.HeaderText = "ที่อยู่"
        Me.cus_address.Name = "cus_address"
        Me.cus_address.ReadOnly = True
        Me.cus_address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'cus_zip
        '
        Me.cus_zip.FillWeight = 91.83587!
        Me.cus_zip.HeaderText = "รหัสไปรษณีย์"
        Me.cus_zip.Name = "cus_zip"
        Me.cus_zip.ReadOnly = True
        Me.cus_zip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'cus_tel
        '
        Me.cus_tel.FillWeight = 91.83587!
        Me.cus_tel.HeaderText = "เบอร์โทรศัพท์"
        Me.cus_tel.Name = "cus_tel"
        Me.cus_tel.ReadOnly = True
        Me.cus_tel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'price_leval
        '
        Me.price_leval.FillWeight = 91.83587!
        Me.price_leval.HeaderText = "ราคา"
        Me.price_leval.Name = "price_leval"
        Me.price_leval.ReadOnly = True
        Me.price_leval.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_leval.ToolTipText = "ระดับราคา"
        '
        'cadit
        '
        Me.cadit.FillWeight = 91.83587!
        Me.cadit.HeaderText = "เครดิต"
        Me.cadit.Name = "cadit"
        Me.cadit.ReadOnly = True
        Me.cadit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cadit.ToolTipText = "ระยะเวลาค้างจ่าย"
        '
        'cus_note
        '
        Me.cus_note.FillWeight = 91.83587!
        Me.cus_note.HeaderText = "หมายเหตุ"
        Me.cus_note.Name = "cus_note"
        Me.cus_note.ReadOnly = True
        Me.cus_note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'date_edit
        '
        Me.date_edit.FillWeight = 91.83587!
        Me.date_edit.HeaderText = "แก้ไข"
        Me.date_edit.Name = "date_edit"
        Me.date_edit.ReadOnly = True
        Me.date_edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.date_edit.ToolTipText = "วันที่แก้ไข"
        '
        'date_save
        '
        Me.date_save.FillWeight = 91.83587!
        Me.date_save.HeaderText = "บันทึก"
        Me.date_save.Name = "date_save"
        Me.date_save.ReadOnly = True
        Me.date_save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.date_save.ToolTipText = "วันที่บันทึก"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.btnHelp})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.TabIndex = 1
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
        'CustomerFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.DoubleBuffered = True
        Me.MinimumSize = New System.Drawing.Size(400, 200)
        Me.Name = "CustomerFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ข้อมูลลูกค้า"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.MenuToolStrip.ResumeLayout(False)
        Me.MenuToolStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCustomerSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents MenuToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CancelToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents BackToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents NextToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SearchToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SearchToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cbbCustomerPrice_leval As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents cbbCustomerCadit As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ShowAllStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgCustomerSearch As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cus_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cus_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tex_num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tax_sec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cus_address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cus_zip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cus_tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_leval As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cadit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cus_note As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_edit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cbAutoCusID As System.Windows.Forms.CheckBox
    Friend WithEvents txtCustomerAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblCusCountNum As System.Windows.Forms.Label
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerID As System.Windows.Forms.Label
    Friend WithEvents txtCustomerZipcode As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerZipcode As System.Windows.Forms.Label
    Friend WithEvents txtCustomerTel As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerAddress As System.Windows.Forms.Label
    Friend WithEvents txtCustomerNote As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents txtCustomerTAX As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerTel As System.Windows.Forms.Label
    Friend WithEvents lblCustomerTAX As System.Windows.Forms.Label
    Friend WithEvents txtCustomerSection As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerNote As System.Windows.Forms.Label
    Friend WithEvents lblCustomerSection As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnPicture As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
