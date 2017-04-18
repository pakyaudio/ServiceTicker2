<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductDetailEditFrm
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnPSselectSection = New System.Windows.Forms.Button()
        Me.txtPDEsubsection = New System.Windows.Forms.TextBox()
        Me.txtPDEsection = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.RichTextProdetail = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPDgetCodepro = New System.Windows.Forms.Button()
        Me.btuPDaddSaleCompany = New System.Windows.Forms.Button()
        Me.lblPDnote = New System.Windows.Forms.Label()
        Me.txtPDnote = New System.Windows.Forms.TextBox()
        Me.cbbPDsalefor = New System.Windows.Forms.ComboBox()
        Me.lblPDsalefor = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnPDbp = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPDp_member = New System.Windows.Forms.TextBox()
        Me.txtPDp_loyel = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPDp_technician = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPDp_wholsale = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDprobuy = New System.Windows.Forms.TextBox()
        Me.lblPDprobuy = New System.Windows.Forms.Label()
        Me.lblPDprodepleted = New System.Windows.Forms.Label()
        Me.txtPDprodepleted = New System.Windows.Forms.TextBox()
        Me.lblPDstockbalance = New System.Windows.Forms.Label()
        Me.txtPDstockbalance = New System.Windows.Forms.TextBox()
        Me.lblPDproUnit = New System.Windows.Forms.Label()
        Me.cbbPDproUnit = New System.Windows.Forms.ComboBox()
        Me.lblPDproPice = New System.Windows.Forms.Label()
        Me.txtPDproPiceCost = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbPDvaruntee = New System.Windows.Forms.ComboBox()
        Me.lblPDproSection = New System.Windows.Forms.Label()
        Me.lblPDproName = New System.Windows.Forms.Label()
        Me.txtPDproName = New System.Windows.Forms.TextBox()
        Me.btnPDgetBarcode = New System.Windows.Forms.Button()
        Me.lblPDbarcode = New System.Windows.Forms.Label()
        Me.txtPDbarcode = New System.Windows.Forms.TextBox()
        Me.txtPDproID = New System.Windows.Forms.TextBox()
        Me.lblPDproID = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPDselectImage = New System.Windows.Forms.Button()
        Me.dgPDserial = New System.Windows.Forms.DataGridView()
        Me.serial_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnForward = New System.Windows.Forms.Button()
        Me.lblSNcount = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPDSerialSave = New System.Windows.Forms.Button()
        Me.txtPDAddSn = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DelSNContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DelSNToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelPicContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DelPicToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgPDserial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.DelSNContextMenu.SuspendLayout()
        Me.DelPicContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 447)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(750, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnPSselectSection)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPDEsubsection)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPDEsection)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSave)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RichTextProdetail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnPDgetCodepro)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btuPDaddSaleCompany)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPDnote)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPDnote)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbbPDsalefor)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPDsalefor)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnPDbp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPDp_member)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPDp_loyel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPDp_technician)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPDp_wholsale)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDprobuy)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPDprobuy)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPDprodepleted)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPDprodepleted)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPDstockbalance)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPDstockbalance)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPDproUnit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbbPDproUnit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPDproPice)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPDproPiceCost)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbPDvaruntee)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPDproSection)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPDproName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPDproName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnPDgetBarcode)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPDbarcode)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPDbarcode)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPDproID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPDproID)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(750, 447)
        Me.SplitContainer1.SplitterDistance = 375
        Me.SplitContainer1.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(115, 281)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(248, 17)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "สินค้าชนิดนี้เป็นสินค้าไม่มีตัวตน(เช่น ค่าบริการ)"
        Me.ToolTip1.SetToolTip(Me.CheckBox1, "เมื่อเลือกช่องนี้สินค้าชนิดนี้จะไม่ถูกนับรวมในรายงานสต็อกสินค้า")
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnPSselectSection
        '
        Me.btnPSselectSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPSselectSection.Location = New System.Drawing.Point(299, 91)
        Me.btnPSselectSection.Name = "btnPSselectSection"
        Me.btnPSselectSection.Size = New System.Drawing.Size(71, 46)
        Me.btnPSselectSection.TabIndex = 3
        Me.btnPSselectSection.Text = "<เลือก"
        Me.btnPSselectSection.UseVisualStyleBackColor = True
        '
        'txtPDEsubsection
        '
        Me.txtPDEsubsection.Location = New System.Drawing.Point(80, 117)
        Me.txtPDEsubsection.Name = "txtPDEsubsection"
        Me.txtPDEsubsection.ReadOnly = True
        Me.txtPDEsubsection.Size = New System.Drawing.Size(213, 20)
        Me.txtPDEsubsection.TabIndex = 33
        '
        'txtPDEsection
        '
        Me.txtPDEsection.BackColor = System.Drawing.SystemColors.Control
        Me.txtPDEsection.Location = New System.Drawing.Point(66, 91)
        Me.txtPDEsection.Name = "txtPDEsection"
        Me.txtPDEsection.ReadOnly = True
        Me.txtPDEsection.Size = New System.Drawing.Size(227, 20)
        Me.txtPDEsection.TabIndex = 24
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSave.Image = Global.ServiceTicker.My.Resources.Resources.save_16xLG
        Me.btnSave.Location = New System.Drawing.Point(299, 415)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(71, 23)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'RichTextProdetail
        '
        Me.RichTextProdetail.Location = New System.Drawing.Point(6, 301)
        Me.RichTextProdetail.Name = "RichTextProdetail"
        Me.RichTextProdetail.Size = New System.Drawing.Size(364, 51)
        Me.RichTextProdetail.TabIndex = 16
        Me.RichTextProdetail.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 199
        Me.Label1.Text = "ประเภทย่อย"
        '
        'btnPDgetCodepro
        '
        Me.btnPDgetCodepro.Location = New System.Drawing.Point(257, 7)
        Me.btnPDgetCodepro.Name = "btnPDgetCodepro"
        Me.btnPDgetCodepro.Size = New System.Drawing.Size(113, 23)
        Me.btnPDgetCodepro.TabIndex = 197
        Me.btnPDgetCodepro.Text = "<สร้างรหัสสินค้า"
        Me.btnPDgetCodepro.UseVisualStyleBackColor = True
        '
        'btuPDaddSaleCompany
        '
        Me.btuPDaddSaleCompany.Location = New System.Drawing.Point(318, 358)
        Me.btuPDaddSaleCompany.Name = "btuPDaddSaleCompany"
        Me.btuPDaddSaleCompany.Size = New System.Drawing.Size(52, 23)
        Me.btuPDaddSaleCompany.TabIndex = 18
        Me.btuPDaddSaleCompany.Text = "<add"
        Me.btuPDaddSaleCompany.UseVisualStyleBackColor = True
        '
        'lblPDnote
        '
        Me.lblPDnote.AutoSize = True
        Me.lblPDnote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPDnote.Location = New System.Drawing.Point(3, 390)
        Me.lblPDnote.Name = "lblPDnote"
        Me.lblPDnote.Size = New System.Drawing.Size(103, 16)
        Me.lblPDnote.TabIndex = 192
        Me.lblPDnote.Text = "หมายเหตุ/การใช้งาน"
        '
        'txtPDnote
        '
        Me.txtPDnote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPDnote.Location = New System.Drawing.Point(121, 387)
        Me.txtPDnote.Name = "txtPDnote"
        Me.txtPDnote.Size = New System.Drawing.Size(249, 22)
        Me.txtPDnote.TabIndex = 19
        Me.txtPDnote.Text = "-"
        '
        'cbbPDsalefor
        '
        Me.cbbPDsalefor.FormattingEnabled = True
        Me.cbbPDsalefor.Location = New System.Drawing.Point(66, 360)
        Me.cbbPDsalefor.Name = "cbbPDsalefor"
        Me.cbbPDsalefor.Size = New System.Drawing.Size(246, 21)
        Me.cbbPDsalefor.TabIndex = 17
        '
        'lblPDsalefor
        '
        Me.lblPDsalefor.AutoSize = True
        Me.lblPDsalefor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPDsalefor.Location = New System.Drawing.Point(3, 363)
        Me.lblPDsalefor.Name = "lblPDsalefor"
        Me.lblPDsalefor.Size = New System.Drawing.Size(60, 18)
        Me.lblPDsalefor.TabIndex = 189
        Me.lblPDsalefor.Text = "ชื้อมาจาก"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 282)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 181
        Me.Label10.Text = "รายละเอียดสินค้า"
        '
        'btnPDbp
        '
        Me.btnPDbp.Location = New System.Drawing.Point(232, 258)
        Me.btnPDbp.Name = "btnPDbp"
        Me.btnPDbp.Size = New System.Drawing.Size(139, 22)
        Me.btnPDbp.TabIndex = 14
        Me.btnPDbp.Text = "ปรับราคาให้เท่าราคาปลีก"
        Me.btnPDbp.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(232, 231)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 18)
        Me.Label9.TabIndex = 178
        Me.Label9.Text = "ราคาสมาชิก"
        '
        'txtPDp_member
        '
        Me.txtPDp_member.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPDp_member.Location = New System.Drawing.Point(309, 230)
        Me.txtPDp_member.MaxLength = 9
        Me.txtPDp_member.Name = "txtPDp_member"
        Me.txtPDp_member.ShortcutsEnabled = False
        Me.txtPDp_member.Size = New System.Drawing.Size(62, 22)
        Me.txtPDp_member.TabIndex = 13
        Me.txtPDp_member.Text = "0"
        Me.txtPDp_member.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPDp_loyel
        '
        Me.txtPDp_loyel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPDp_loyel.Location = New System.Drawing.Point(309, 209)
        Me.txtPDp_loyel.MaxLength = 9
        Me.txtPDp_loyel.Name = "txtPDp_loyel"
        Me.txtPDp_loyel.ShortcutsEnabled = False
        Me.txtPDp_loyel.Size = New System.Drawing.Size(62, 22)
        Me.txtPDp_loyel.TabIndex = 12
        Me.txtPDp_loyel.Text = "0"
        Me.txtPDp_loyel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(221, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 18)
        Me.Label8.TabIndex = 175
        Me.Label8.Text = "ราคาขาประจำ"
        '
        'txtPDp_technician
        '
        Me.txtPDp_technician.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPDp_technician.Location = New System.Drawing.Point(309, 188)
        Me.txtPDp_technician.MaxLength = 9
        Me.txtPDp_technician.Name = "txtPDp_technician"
        Me.txtPDp_technician.ShortcutsEnabled = False
        Me.txtPDp_technician.Size = New System.Drawing.Size(62, 22)
        Me.txtPDp_technician.TabIndex = 11
        Me.txtPDp_technician.Text = "0"
        Me.txtPDp_technician.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(251, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 18)
        Me.Label7.TabIndex = 173
        Me.Label7.Text = "ราคาช่าง"
        '
        'txtPDp_wholsale
        '
        Me.txtPDp_wholsale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPDp_wholsale.Location = New System.Drawing.Point(309, 167)
        Me.txtPDp_wholsale.MaxLength = 9
        Me.txtPDp_wholsale.Name = "txtPDp_wholsale"
        Me.txtPDp_wholsale.ShortcutsEnabled = False
        Me.txtPDp_wholsale.Size = New System.Drawing.Size(62, 22)
        Me.txtPDp_wholsale.TabIndex = 10
        Me.txtPDp_wholsale.Text = "0"
        Me.txtPDp_wholsale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(235, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 18)
        Me.Label6.TabIndex = 171
        Me.Label6.Text = "ราคาขายส่ง"
        '
        'txtDprobuy
        '
        Me.txtDprobuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDprobuy.Location = New System.Drawing.Point(309, 146)
        Me.txtDprobuy.MaxLength = 9
        Me.txtDprobuy.Name = "txtDprobuy"
        Me.txtDprobuy.ShortcutsEnabled = False
        Me.txtDprobuy.Size = New System.Drawing.Size(62, 22)
        Me.txtDprobuy.TabIndex = 9
        Me.txtDprobuy.Text = "0"
        Me.txtDprobuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPDprobuy
        '
        Me.lblPDprobuy.AutoSize = True
        Me.lblPDprobuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPDprobuy.Location = New System.Drawing.Point(225, 147)
        Me.lblPDprobuy.Name = "lblPDprobuy"
        Me.lblPDprobuy.Size = New System.Drawing.Size(81, 18)
        Me.lblPDprobuy.TabIndex = 169
        Me.lblPDprobuy.Text = "ราคาขายปลีก"
        '
        'lblPDprodepleted
        '
        Me.lblPDprodepleted.AutoSize = True
        Me.lblPDprodepleted.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPDprodepleted.Location = New System.Drawing.Point(25, 229)
        Me.lblPDprodepleted.Name = "lblPDprodepleted"
        Me.lblPDprodepleted.Size = New System.Drawing.Size(84, 18)
        Me.lblPDprodepleted.TabIndex = 168
        Me.lblPDprodepleted.Text = "เตือนเมื่อหมด"
        '
        'txtPDprodepleted
        '
        Me.txtPDprodepleted.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPDprodepleted.Location = New System.Drawing.Point(115, 228)
        Me.txtPDprodepleted.MaxLength = 9
        Me.txtPDprodepleted.Name = "txtPDprodepleted"
        Me.txtPDprodepleted.ShortcutsEnabled = False
        Me.txtPDprodepleted.Size = New System.Drawing.Size(102, 22)
        Me.txtPDprodepleted.TabIndex = 7
        Me.txtPDprodepleted.Text = "0"
        Me.txtPDprodepleted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPDstockbalance
        '
        Me.lblPDstockbalance.AutoSize = True
        Me.lblPDstockbalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPDstockbalance.Location = New System.Drawing.Point(51, 201)
        Me.lblPDstockbalance.Name = "lblPDstockbalance"
        Me.lblPDstockbalance.Size = New System.Drawing.Size(58, 18)
        Me.lblPDstockbalance.TabIndex = 166
        Me.lblPDstockbalance.Text = "สต๊อกที่มี"
        '
        'txtPDstockbalance
        '
        Me.txtPDstockbalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPDstockbalance.Location = New System.Drawing.Point(115, 200)
        Me.txtPDstockbalance.MaxLength = 9
        Me.txtPDstockbalance.Name = "txtPDstockbalance"
        Me.txtPDstockbalance.ShortcutsEnabled = False
        Me.txtPDstockbalance.Size = New System.Drawing.Size(102, 22)
        Me.txtPDstockbalance.TabIndex = 6
        Me.txtPDstockbalance.Text = "0"
        Me.txtPDstockbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPDproUnit
        '
        Me.lblPDproUnit.AutoSize = True
        Me.lblPDproUnit.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPDproUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPDproUnit.Location = New System.Drawing.Point(15, 145)
        Me.lblPDproUnit.Name = "lblPDproUnit"
        Me.lblPDproUnit.Size = New System.Drawing.Size(59, 18)
        Me.lblPDproUnit.TabIndex = 164
        Me.lblPDproUnit.Text = "หน่วยนับ"
        '
        'cbbPDproUnit
        '
        Me.cbbPDproUnit.FormattingEnabled = True
        Me.cbbPDproUnit.Location = New System.Drawing.Point(80, 146)
        Me.cbbPDproUnit.Name = "cbbPDproUnit"
        Me.cbbPDproUnit.Size = New System.Drawing.Size(137, 21)
        Me.cbbPDproUnit.TabIndex = 4
        '
        'lblPDproPice
        '
        Me.lblPDproPice.AutoSize = True
        Me.lblPDproPice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPDproPice.Location = New System.Drawing.Point(39, 257)
        Me.lblPDproPice.Name = "lblPDproPice"
        Me.lblPDproPice.Size = New System.Drawing.Size(70, 18)
        Me.lblPDproPice.TabIndex = 162
        Me.lblPDproPice.Text = "ราคาต้นทุน"
        '
        'txtPDproPiceCost
        '
        Me.txtPDproPiceCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPDproPiceCost.Location = New System.Drawing.Point(115, 256)
        Me.txtPDproPiceCost.MaxLength = 9
        Me.txtPDproPiceCost.Name = "txtPDproPiceCost"
        Me.txtPDproPiceCost.ShortcutsEnabled = False
        Me.txtPDproPiceCost.Size = New System.Drawing.Size(102, 22)
        Me.txtPDproPiceCost.TabIndex = 8
        Me.txtPDproPiceCost.Text = "0"
        Me.txtPDproPiceCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 18)
        Me.Label5.TabIndex = 160
        Me.Label5.Text = "ระยะเวลาประกัน"
        '
        'cbPDvaruntee
        '
        Me.cbPDvaruntee.FormattingEnabled = True
        Me.cbPDvaruntee.Location = New System.Drawing.Point(115, 173)
        Me.cbPDvaruntee.Name = "cbPDvaruntee"
        Me.cbPDvaruntee.Size = New System.Drawing.Size(102, 21)
        Me.cbPDvaruntee.TabIndex = 5
        '
        'lblPDproSection
        '
        Me.lblPDproSection.AutoSize = True
        Me.lblPDproSection.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPDproSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPDproSection.Location = New System.Drawing.Point(7, 91)
        Me.lblPDproSection.Name = "lblPDproSection"
        Me.lblPDproSection.Size = New System.Drawing.Size(53, 18)
        Me.lblPDproSection.TabIndex = 157
        Me.lblPDproSection.Text = "ประเภท"
        '
        'lblPDproName
        '
        Me.lblPDproName.AutoSize = True
        Me.lblPDproName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPDproName.Location = New System.Drawing.Point(5, 64)
        Me.lblPDproName.Name = "lblPDproName"
        Me.lblPDproName.Size = New System.Drawing.Size(55, 18)
        Me.lblPDproName.TabIndex = 156
        Me.lblPDproName.Text = "ชื่อสินค้า"
        '
        'txtPDproName
        '
        Me.txtPDproName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPDproName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPDproName.Location = New System.Drawing.Point(66, 63)
        Me.txtPDproName.Name = "txtPDproName"
        Me.txtPDproName.Size = New System.Drawing.Size(304, 22)
        Me.txtPDproName.TabIndex = 2
        '
        'btnPDgetBarcode
        '
        Me.btnPDgetBarcode.Location = New System.Drawing.Point(257, 35)
        Me.btnPDgetBarcode.Name = "btnPDgetBarcode"
        Me.btnPDgetBarcode.Size = New System.Drawing.Size(113, 23)
        Me.btnPDgetBarcode.TabIndex = 154
        Me.btnPDgetBarcode.Text = "<สร้างบาร์โค๊ด"
        Me.btnPDgetBarcode.UseVisualStyleBackColor = True
        '
        'lblPDbarcode
        '
        Me.lblPDbarcode.AutoSize = True
        Me.lblPDbarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPDbarcode.Location = New System.Drawing.Point(8, 36)
        Me.lblPDbarcode.Name = "lblPDbarcode"
        Me.lblPDbarcode.Size = New System.Drawing.Size(52, 18)
        Me.lblPDbarcode.TabIndex = 153
        Me.lblPDbarcode.Text = "บาร์โค๊ต"
        '
        'txtPDbarcode
        '
        Me.txtPDbarcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPDbarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPDbarcode.Location = New System.Drawing.Point(66, 35)
        Me.txtPDbarcode.Name = "txtPDbarcode"
        Me.txtPDbarcode.Size = New System.Drawing.Size(185, 22)
        Me.txtPDbarcode.TabIndex = 1
        Me.txtPDbarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPDproID
        '
        Me.txtPDproID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPDproID.Location = New System.Drawing.Point(66, 7)
        Me.txtPDproID.Name = "txtPDproID"
        Me.txtPDproID.Size = New System.Drawing.Size(185, 22)
        Me.txtPDproID.TabIndex = 0
        Me.txtPDproID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPDproID
        '
        Me.lblPDproID.AutoSize = True
        Me.lblPDproID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPDproID.Location = New System.Drawing.Point(-3, 8)
        Me.lblPDproID.Name = "lblPDproID"
        Me.lblPDproID.Size = New System.Drawing.Size(63, 18)
        Me.lblPDproID.TabIndex = 150
        Me.lblPDproID.Text = "รหัสสินค้า"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.ListView1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.dgPDserial)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer2.Size = New System.Drawing.Size(371, 447)
        Me.SplitContainer2.SplitterDistance = 238
        Me.SplitContainer2.TabIndex = 0
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(369, 201)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnPDselectImage)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 201)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(369, 35)
        Me.Panel2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 186
        Me.Label2.Text = "รูปสินค้า"
        '
        'btnPDselectImage
        '
        Me.btnPDselectImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPDselectImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPDselectImage.Enabled = False
        Me.btnPDselectImage.Image = Global.ServiceTicker.My.Resources.Resources.Camera_16xLG
        Me.btnPDselectImage.Location = New System.Drawing.Point(330, 3)
        Me.btnPDselectImage.Name = "btnPDselectImage"
        Me.btnPDselectImage.Size = New System.Drawing.Size(36, 27)
        Me.btnPDselectImage.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btnPDselectImage, "เลือกรูปภาพสินค้า")
        Me.btnPDselectImage.UseVisualStyleBackColor = True
        '
        'dgPDserial
        '
        Me.dgPDserial.AllowUserToAddRows = False
        Me.dgPDserial.AllowUserToDeleteRows = False
        Me.dgPDserial.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgPDserial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPDserial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.serial_pro, Me.datetime_save})
        Me.dgPDserial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPDserial.GridColor = System.Drawing.SystemColors.Control
        Me.dgPDserial.Location = New System.Drawing.Point(0, 31)
        Me.dgPDserial.MultiSelect = False
        Me.dgPDserial.Name = "dgPDserial"
        Me.dgPDserial.ReadOnly = True
        Me.dgPDserial.RowHeadersVisible = False
        Me.dgPDserial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPDserial.Size = New System.Drawing.Size(369, 142)
        Me.dgPDserial.TabIndex = 194
        '
        'serial_pro
        '
        Me.serial_pro.DataPropertyName = "serial_pro"
        Me.serial_pro.Frozen = True
        Me.serial_pro.HeaderText = "SN"
        Me.serial_pro.Name = "serial_pro"
        Me.serial_pro.ReadOnly = True
        Me.serial_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.serial_pro.ToolTipText = "หมายเลขประจำสินค้า"
        Me.serial_pro.Width = 130
        '
        'datetime_save
        '
        Me.datetime_save.HeaderText = "วันที่บันทึก"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        Me.datetime_save.Width = 150
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnForward)
        Me.Panel3.Controls.Add(Me.lblSNcount)
        Me.Panel3.Controls.Add(Me.NumericUpDown1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 173)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(369, 30)
        Me.Panel3.TabIndex = 195
        '
        'btnForward
        '
        Me.btnForward.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnForward.Enabled = False
        Me.btnForward.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnForward.Image = Global.ServiceTicker.My.Resources.Resources.AzureMySQLDatabase_color_16x
        Me.btnForward.Location = New System.Drawing.Point(261, 3)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(105, 26)
        Me.btnForward.TabIndex = 2
        Me.btnForward.Text = "โหลดข้อมูลเพิ่ม"
        Me.btnForward.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnForward.UseVisualStyleBackColor = True
        '
        'lblSNcount
        '
        Me.lblSNcount.AutoSize = True
        Me.lblSNcount.Location = New System.Drawing.Point(101, 7)
        Me.lblSNcount.Name = "lblSNcount"
        Me.lblSNcount.Size = New System.Drawing.Size(13, 13)
        Me.lblSNcount.TabIndex = 13
        Me.lblSNcount.Text = "0"
        Me.ToolTip1.SetToolTip(Me.lblSNcount, "จำนวแถวที่แสดง/จำนวนทั้งหมด")
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDown1.Location = New System.Drawing.Point(2, 3)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(93, 20)
        Me.NumericUpDown1.TabIndex = 1
        Me.NumericUpDown1.ThousandsSeparator = True
        Me.ToolTip1.SetToolTip(Me.NumericUpDown1, "ลิมิตในการโหลดข้อมูล(การกำหนดจำนวนมากอาจจะใช้เวลามากในการดึงข้อมูล)")
        Me.NumericUpDown1.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnPDSerialSave)
        Me.Panel1.Controls.Add(Me.txtPDAddSn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(369, 31)
        Me.Panel1.TabIndex = 0
        '
        'btnPDSerialSave
        '
        Me.btnPDSerialSave.Location = New System.Drawing.Point(307, 3)
        Me.btnPDSerialSave.Name = "btnPDSerialSave"
        Me.btnPDSerialSave.Size = New System.Drawing.Size(61, 26)
        Me.btnPDSerialSave.TabIndex = 1
        Me.btnPDSerialSave.Text = "บันทึก"
        Me.btnPDSerialSave.UseVisualStyleBackColor = True
        '
        'txtPDAddSn
        '
        Me.txtPDAddSn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPDAddSn.Location = New System.Drawing.Point(168, 3)
        Me.txtPDAddSn.Name = "txtPDAddSn"
        Me.txtPDAddSn.Size = New System.Drawing.Size(133, 26)
        Me.txtPDAddSn.TabIndex = 0
        '
        'DelSNContextMenu
        '
        Me.DelSNContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DelSNToolStripMenu})
        Me.DelSNContextMenu.Name = "DelSNContextMenu"
        Me.DelSNContextMenu.Size = New System.Drawing.Size(106, 26)
        '
        'DelSNToolStripMenu
        '
        Me.DelSNToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.action_Cancel_16xLG
        Me.DelSNToolStripMenu.Name = "DelSNToolStripMenu"
        Me.DelSNToolStripMenu.Size = New System.Drawing.Size(105, 22)
        Me.DelSNToolStripMenu.Text = "ลบ SN"
        '
        'DelPicContextMenu
        '
        Me.DelPicContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DelPicToolStripMenu})
        Me.DelPicContextMenu.Name = "DelPicContextMenu"
        Me.DelPicContextMenu.Size = New System.Drawing.Size(100, 26)
        '
        'DelPicToolStripMenu
        '
        Me.DelPicToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.VSO_RecycleBin_16x
        Me.DelPicToolStripMenu.Name = "DelPicToolStripMenu"
        Me.DelPicToolStripMenu.Size = New System.Drawing.Size(99, 22)
        Me.DelPicToolStripMenu.Text = "ลบรูป"
        '
        'ProductDetailEditFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 469)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "ProductDetailEditFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายละเอียดสินค้า"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgPDserial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.DelSNContextMenu.ResumeLayout(False)
        Me.DelPicContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPDgetCodepro As System.Windows.Forms.Button
    Friend WithEvents btuPDaddSaleCompany As System.Windows.Forms.Button
    Friend WithEvents lblPDnote As System.Windows.Forms.Label
    Friend WithEvents txtPDnote As System.Windows.Forms.TextBox
    Friend WithEvents cbbPDsalefor As System.Windows.Forms.ComboBox
    Friend WithEvents lblPDsalefor As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnPDbp As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPDp_member As System.Windows.Forms.TextBox
    Friend WithEvents txtPDp_loyel As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPDp_technician As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPDp_wholsale As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDprobuy As System.Windows.Forms.TextBox
    Friend WithEvents lblPDprobuy As System.Windows.Forms.Label
    Friend WithEvents lblPDprodepleted As System.Windows.Forms.Label
    Friend WithEvents txtPDprodepleted As System.Windows.Forms.TextBox
    Friend WithEvents lblPDstockbalance As System.Windows.Forms.Label
    Friend WithEvents txtPDstockbalance As System.Windows.Forms.TextBox
    Friend WithEvents lblPDproUnit As System.Windows.Forms.Label
    Friend WithEvents cbbPDproUnit As System.Windows.Forms.ComboBox
    Friend WithEvents lblPDproPice As System.Windows.Forms.Label
    Friend WithEvents txtPDproPiceCost As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbPDvaruntee As System.Windows.Forms.ComboBox
    Friend WithEvents lblPDproSection As System.Windows.Forms.Label
    Friend WithEvents lblPDproName As System.Windows.Forms.Label
    Friend WithEvents txtPDproName As System.Windows.Forms.TextBox
    Friend WithEvents btnPDgetBarcode As System.Windows.Forms.Button
    Friend WithEvents lblPDbarcode As System.Windows.Forms.Label
    Friend WithEvents txtPDbarcode As System.Windows.Forms.TextBox
    Friend WithEvents txtPDproID As System.Windows.Forms.TextBox
    Friend WithEvents lblPDproID As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnPDselectImage As System.Windows.Forms.Button
    Friend WithEvents dgPDserial As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPDSerialSave As System.Windows.Forms.Button
    Friend WithEvents txtPDAddSn As System.Windows.Forms.TextBox
    Friend WithEvents RichTextProdetail As System.Windows.Forms.RichTextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnPSselectSection As System.Windows.Forms.Button
    Friend WithEvents txtPDEsubsection As System.Windows.Forms.TextBox
    Friend WithEvents txtPDEsection As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents serial_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DelSNContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DelSNToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnForward As System.Windows.Forms.Button
    Friend WithEvents lblSNcount As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents DelPicContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DelPicToolStripMenu As System.Windows.Forms.ToolStripMenuItem
End Class
