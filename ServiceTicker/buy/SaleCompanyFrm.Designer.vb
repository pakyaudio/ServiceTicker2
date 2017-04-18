<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaleCompanyFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SaleCompanyFrm))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSCgetallData = New System.Windows.Forms.Button()
        Me.btnSCsearch = New System.Windows.Forms.Button()
        Me.txtSCsearch = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NextToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.BackToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.UndoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EditToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSCtax = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSCwebsite = New System.Windows.Forms.TextBox()
        Me.txtSCemail = New System.Windows.Forms.TextBox()
        Me.txtSCfacebook = New System.Windows.Forms.TextBox()
        Me.txtSCline = New System.Windows.Forms.TextBox()
        Me.txtSCfax = New System.Windows.Forms.TextBox()
        Me.lblSCcontact = New System.Windows.Forms.Label()
        Me.lblSCtel = New System.Windows.Forms.Label()
        Me.lblSCaddress = New System.Windows.Forms.Label()
        Me.lblSCname = New System.Windows.Forms.Label()
        Me.lblSCid = New System.Windows.Forms.Label()
        Me.txtSCcontact = New System.Windows.Forms.TextBox()
        Me.txtSCtel = New System.Windows.Forms.TextBox()
        Me.txtSCaddress = New System.Windows.Forms.TextBox()
        Me.txtSCname = New System.Windows.Forms.TextBox()
        Me.txtSCid = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgSC = New System.Windows.Forms.DataGridView()
        Me.sale_company_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_fax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_line = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_facebook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_website = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_tax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgSC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.btnHelp})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 515)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(535, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblEmployee
        '
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(30, 17)
        Me.lblEmployee.Text = "User"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSCgetallData)
        Me.Panel1.Controls.Add(Me.btnSCsearch)
        Me.Panel1.Controls.Add(Me.txtSCsearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(535, 27)
        Me.Panel1.TabIndex = 0
        '
        'btnSCgetallData
        '
        Me.btnSCgetallData.Location = New System.Drawing.Point(276, 1)
        Me.btnSCgetallData.Name = "btnSCgetallData"
        Me.btnSCgetallData.Size = New System.Drawing.Size(75, 23)
        Me.btnSCgetallData.TabIndex = 2
        Me.btnSCgetallData.Text = "แสดงทั้งหมด"
        Me.btnSCgetallData.UseVisualStyleBackColor = True
        '
        'btnSCsearch
        '
        Me.btnSCsearch.Location = New System.Drawing.Point(195, 1)
        Me.btnSCsearch.Name = "btnSCsearch"
        Me.btnSCsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSCsearch.TabIndex = 1
        Me.btnSCsearch.Text = "ค้นหา"
        Me.btnSCsearch.UseVisualStyleBackColor = True
        '
        'txtSCsearch
        '
        Me.txtSCsearch.Location = New System.Drawing.Point(3, 3)
        Me.txtSCsearch.Name = "txtSCsearch"
        Me.txtSCsearch.Size = New System.Drawing.Size(186, 20)
        Me.txtSCsearch.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtSCtax)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtSCwebsite)
        Me.Panel2.Controls.Add(Me.txtSCemail)
        Me.Panel2.Controls.Add(Me.txtSCfacebook)
        Me.Panel2.Controls.Add(Me.txtSCline)
        Me.Panel2.Controls.Add(Me.txtSCfax)
        Me.Panel2.Controls.Add(Me.lblSCcontact)
        Me.Panel2.Controls.Add(Me.lblSCtel)
        Me.Panel2.Controls.Add(Me.lblSCaddress)
        Me.Panel2.Controls.Add(Me.lblSCname)
        Me.Panel2.Controls.Add(Me.lblSCid)
        Me.Panel2.Controls.Add(Me.txtSCcontact)
        Me.Panel2.Controls.Add(Me.txtSCtel)
        Me.Panel2.Controls.Add(Me.txtSCaddress)
        Me.Panel2.Controls.Add(Me.txtSCname)
        Me.Panel2.Controls.Add(Me.txtSCid)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 218)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(535, 297)
        Me.Panel2.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NextToolStripButton, Me.BackToolStripButton, Me.ToolStripSeparator2, Me.DeleteToolStripButton, Me.toolStripSeparator, Me.UndoToolStripButton, Me.toolStripSeparator1, Me.SaveToolStripButton, Me.EditToolStripButton, Me.NewToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStrip1.Size = New System.Drawing.Size(535, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NextToolStripButton
        '
        Me.NextToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NextToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.arrow_Forward_color_16xLG
        Me.NextToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NextToolStripButton.Name = "NextToolStripButton"
        Me.NextToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NextToolStripButton.Text = "ไปข้างหน้า"
        '
        'BackToolStripButton
        '
        Me.BackToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BackToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.arrow_back_color_16xLG
        Me.BackToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BackToolStripButton.Name = "BackToolStripButton"
        Me.BackToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.BackToolStripButton.Text = "ถอยหลัง"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'DeleteToolStripButton
        '
        Me.DeleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DeleteToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.action_Cancel_16xLG
        Me.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteToolStripButton.Name = "DeleteToolStripButton"
        Me.DeleteToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.DeleteToolStripButton.Text = "ลบรายการ"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'UndoToolStripButton
        '
        Me.UndoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UndoToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.Undo_16x
        Me.UndoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UndoToolStripButton.Name = "UndoToolStripButton"
        Me.UndoToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.UndoToolStripButton.Text = "ยกเลิก"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "บันทึกรายการ"
        '
        'EditToolStripButton
        '
        Me.EditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.PencilAngled_16xLG_color
        Me.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditToolStripButton.Name = "EditToolStripButton"
        Me.EditToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.EditToolStripButton.Text = "แก้ไขรายการ"
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(173, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "เลขผู้เสียภาษี"
        '
        'txtSCtax
        '
        Me.txtSCtax.Location = New System.Drawing.Point(248, 32)
        Me.txtSCtax.Name = "txtSCtax"
        Me.txtSCtax.Size = New System.Drawing.Size(107, 20)
        Me.txtSCtax.TabIndex = 2
        Me.txtSCtax.Text = "0000000000000"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "WebSite"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "FaceBook"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "LINE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "FAX"
        '
        'txtSCwebsite
        '
        Me.txtSCwebsite.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSCwebsite.Location = New System.Drawing.Point(68, 266)
        Me.txtSCwebsite.Name = "txtSCwebsite"
        Me.txtSCwebsite.Size = New System.Drawing.Size(455, 20)
        Me.txtSCwebsite.TabIndex = 11
        '
        'txtSCemail
        '
        Me.txtSCemail.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSCemail.Location = New System.Drawing.Point(68, 240)
        Me.txtSCemail.Name = "txtSCemail"
        Me.txtSCemail.Size = New System.Drawing.Size(455, 20)
        Me.txtSCemail.TabIndex = 10
        '
        'txtSCfacebook
        '
        Me.txtSCfacebook.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSCfacebook.Location = New System.Drawing.Point(68, 214)
        Me.txtSCfacebook.Name = "txtSCfacebook"
        Me.txtSCfacebook.Size = New System.Drawing.Size(455, 20)
        Me.txtSCfacebook.TabIndex = 9
        '
        'txtSCline
        '
        Me.txtSCline.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSCline.Location = New System.Drawing.Point(68, 188)
        Me.txtSCline.Name = "txtSCline"
        Me.txtSCline.Size = New System.Drawing.Size(455, 20)
        Me.txtSCline.TabIndex = 8
        '
        'txtSCfax
        '
        Me.txtSCfax.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSCfax.Location = New System.Drawing.Point(68, 162)
        Me.txtSCfax.Name = "txtSCfax"
        Me.txtSCfax.Size = New System.Drawing.Size(456, 20)
        Me.txtSCfax.TabIndex = 7
        '
        'lblSCcontact
        '
        Me.lblSCcontact.AutoSize = True
        Me.lblSCcontact.Location = New System.Drawing.Point(21, 113)
        Me.lblSCcontact.Name = "lblSCcontact"
        Me.lblSCcontact.Size = New System.Drawing.Size(41, 13)
        Me.lblSCcontact.TabIndex = 63
        Me.lblSCcontact.Text = "ผู้ติดต่อ"
        '
        'lblSCtel
        '
        Me.lblSCtel.AutoSize = True
        Me.lblSCtel.Location = New System.Drawing.Point(37, 139)
        Me.lblSCtel.Name = "lblSCtel"
        Me.lblSCtel.Size = New System.Drawing.Size(25, 13)
        Me.lblSCtel.TabIndex = 62
        Me.lblSCtel.Text = "โทร"
        '
        'lblSCaddress
        '
        Me.lblSCaddress.AutoSize = True
        Me.lblSCaddress.Location = New System.Drawing.Point(35, 87)
        Me.lblSCaddress.Name = "lblSCaddress"
        Me.lblSCaddress.Size = New System.Drawing.Size(27, 13)
        Me.lblSCaddress.TabIndex = 61
        Me.lblSCaddress.Text = "ที่อยู่"
        '
        'lblSCname
        '
        Me.lblSCname.AutoSize = True
        Me.lblSCname.Location = New System.Drawing.Point(14, 61)
        Me.lblSCname.Name = "lblSCname"
        Me.lblSCname.Size = New System.Drawing.Size(48, 13)
        Me.lblSCname.TabIndex = 60
        Me.lblSCname.Text = "ชื่อบริษัท"
        '
        'lblSCid
        '
        Me.lblSCid.AutoSize = True
        Me.lblSCid.Location = New System.Drawing.Point(36, 35)
        Me.lblSCid.Name = "lblSCid"
        Me.lblSCid.Size = New System.Drawing.Size(26, 13)
        Me.lblSCid.TabIndex = 59
        Me.lblSCid.Text = "รหัส"
        '
        'txtSCcontact
        '
        Me.txtSCcontact.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSCcontact.Location = New System.Drawing.Point(68, 110)
        Me.txtSCcontact.Name = "txtSCcontact"
        Me.txtSCcontact.Size = New System.Drawing.Size(455, 20)
        Me.txtSCcontact.TabIndex = 5
        '
        'txtSCtel
        '
        Me.txtSCtel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSCtel.Location = New System.Drawing.Point(68, 136)
        Me.txtSCtel.Name = "txtSCtel"
        Me.txtSCtel.Size = New System.Drawing.Size(455, 20)
        Me.txtSCtel.TabIndex = 6
        '
        'txtSCaddress
        '
        Me.txtSCaddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSCaddress.Location = New System.Drawing.Point(68, 84)
        Me.txtSCaddress.Name = "txtSCaddress"
        Me.txtSCaddress.Size = New System.Drawing.Size(455, 20)
        Me.txtSCaddress.TabIndex = 4
        '
        'txtSCname
        '
        Me.txtSCname.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSCname.Location = New System.Drawing.Point(68, 58)
        Me.txtSCname.Name = "txtSCname"
        Me.txtSCname.Size = New System.Drawing.Size(456, 20)
        Me.txtSCname.TabIndex = 3
        '
        'txtSCid
        '
        Me.txtSCid.Location = New System.Drawing.Point(68, 32)
        Me.txtSCid.Name = "txtSCid"
        Me.txtSCid.Size = New System.Drawing.Size(98, 20)
        Me.txtSCid.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgSC)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 27)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(535, 191)
        Me.Panel3.TabIndex = 3
        '
        'dgSC
        '
        Me.dgSC.AllowUserToAddRows = False
        Me.dgSC.AllowUserToDeleteRows = False
        Me.dgSC.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgSC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sale_company_id, Me.sale_company_name, Me.sale_company_address, Me.sale_company_tel, Me.sale_company_contact, Me.sale_company_fax, Me.sale_company_line, Me.sale_company_email, Me.sale_company_facebook, Me.sale_company_website, Me.sale_company_tax})
        Me.dgSC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSC.Location = New System.Drawing.Point(0, 0)
        Me.dgSC.Name = "dgSC"
        Me.dgSC.ReadOnly = True
        Me.dgSC.RowHeadersVisible = False
        Me.dgSC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSC.Size = New System.Drawing.Size(535, 191)
        Me.dgSC.TabIndex = 0
        '
        'sale_company_id
        '
        Me.sale_company_id.HeaderText = "รหัสบริษัท"
        Me.sale_company_id.Name = "sale_company_id"
        Me.sale_company_id.ReadOnly = True
        '
        'sale_company_name
        '
        Me.sale_company_name.HeaderText = "ชื่อบริษัท"
        Me.sale_company_name.Name = "sale_company_name"
        Me.sale_company_name.ReadOnly = True
        '
        'sale_company_address
        '
        Me.sale_company_address.HeaderText = "ที่อยู่"
        Me.sale_company_address.Name = "sale_company_address"
        Me.sale_company_address.ReadOnly = True
        '
        'sale_company_tel
        '
        Me.sale_company_tel.HeaderText = "เบอร์โทร"
        Me.sale_company_tel.Name = "sale_company_tel"
        Me.sale_company_tel.ReadOnly = True
        '
        'sale_company_contact
        '
        Me.sale_company_contact.HeaderText = "ผู้ติดต่อ"
        Me.sale_company_contact.Name = "sale_company_contact"
        Me.sale_company_contact.ReadOnly = True
        '
        'sale_company_fax
        '
        Me.sale_company_fax.HeaderText = "FAX"
        Me.sale_company_fax.Name = "sale_company_fax"
        Me.sale_company_fax.ReadOnly = True
        '
        'sale_company_line
        '
        Me.sale_company_line.HeaderText = "LINE"
        Me.sale_company_line.Name = "sale_company_line"
        Me.sale_company_line.ReadOnly = True
        '
        'sale_company_email
        '
        Me.sale_company_email.HeaderText = "E-Mail"
        Me.sale_company_email.Name = "sale_company_email"
        Me.sale_company_email.ReadOnly = True
        '
        'sale_company_facebook
        '
        Me.sale_company_facebook.HeaderText = "Facebook"
        Me.sale_company_facebook.Name = "sale_company_facebook"
        Me.sale_company_facebook.ReadOnly = True
        '
        'sale_company_website
        '
        Me.sale_company_website.HeaderText = "Web Site"
        Me.sale_company_website.Name = "sale_company_website"
        Me.sale_company_website.ReadOnly = True
        '
        'sale_company_tax
        '
        Me.sale_company_tax.HeaderText = "หมายเลขผู้เสียภาษี"
        Me.sale_company_tax.Name = "sale_company_tax"
        Me.sale_company_tax.ReadOnly = True
        Me.sale_company_tax.Width = 150
        '
        'btnHelp
        '
        Me.btnHelp.Image = Global.ServiceTicker.My.Resources.Resources._109_AllAnnotations_Help_16x16_72
        Me.btnHelp.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.btnHelp.IsLink = True
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(16, 17)
        Me.btnHelp.ToolTipText = "Help"
        '
        'SaleCompanyFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 537)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "SaleCompanyFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายชื่อบริษัทที่จัดซื้อสินค้า"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgSC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSCgetallData As System.Windows.Forms.Button
    Friend WithEvents btnSCsearch As System.Windows.Forms.Button
    Friend WithEvents txtSCsearch As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSCtax As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSCwebsite As System.Windows.Forms.TextBox
    Friend WithEvents txtSCemail As System.Windows.Forms.TextBox
    Friend WithEvents txtSCfacebook As System.Windows.Forms.TextBox
    Friend WithEvents txtSCline As System.Windows.Forms.TextBox
    Friend WithEvents txtSCfax As System.Windows.Forms.TextBox
    Friend WithEvents lblSCcontact As System.Windows.Forms.Label
    Friend WithEvents lblSCtel As System.Windows.Forms.Label
    Friend WithEvents lblSCaddress As System.Windows.Forms.Label
    Friend WithEvents lblSCname As System.Windows.Forms.Label
    Friend WithEvents lblSCid As System.Windows.Forms.Label
    Friend WithEvents txtSCcontact As System.Windows.Forms.TextBox
    Friend WithEvents txtSCtel As System.Windows.Forms.TextBox
    Friend WithEvents txtSCaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtSCname As System.Windows.Forms.TextBox
    Friend WithEvents txtSCid As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgSC As System.Windows.Forms.DataGridView
    Friend WithEvents sale_company_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_contact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_fax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_line As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_facebook As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_website As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_tax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NextToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents BackToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UndoToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
