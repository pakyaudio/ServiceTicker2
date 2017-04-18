<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaveDataFixFrm
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
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lblAutoNumber = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTakePicture = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSDFfixsave = New System.Windows.Forms.Button()
        Me.ProductModelLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.cbSDFGimportune = New System.Windows.Forms.CheckBox()
        Me.lblSDFimportune = New System.Windows.Forms.Label()
        Me.DateTimePickerfixsendcom = New System.Windows.Forms.DateTimePicker()
        Me.lblSDFdatesend = New System.Windows.Forms.Label()
        Me.txtSDFfixnote = New System.Windows.Forms.TextBox()
        Me.lblSDFnote = New System.Windows.Forms.Label()
        Me.btnSDFaccressory = New System.Windows.Forms.Button()
        Me.txtSDFfixaccessory = New System.Windows.Forms.TextBox()
        Me.AccessoryLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.txtSDFfixTprice = New System.Windows.Forms.TextBox()
        Me.lblSDFtprice = New System.Windows.Forms.Label()
        Me.txtSDFfixrepairNote = New System.Windows.Forms.TextBox()
        Me.lblSDFcomfixnote = New System.Windows.Forms.Label()
        Me.cbbSDFrepairData = New System.Windows.Forms.ComboBox()
        Me.ManagerDataLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.cbbSDFcolor = New System.Windows.Forms.ComboBox()
        Me.ProductColorLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.cbbSDFmodel = New System.Windows.Forms.ComboBox()
        Me.cbbSDFname = New System.Windows.Forms.ComboBox()
        Me.ProductNameLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.ProductTypeLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.cbbSDFtype = New System.Windows.Forms.ComboBox()
        Me.FixComLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.cbbSDFRepairType = New System.Windows.Forms.ComboBox()
        Me.lblSDFcheckSN = New System.Windows.Forms.Label()
        Me.btnSDFsearcdSN = New System.Windows.Forms.Button()
        Me.txtSDFfixSN = New System.Windows.Forms.TextBox()
        Me.lblSDFsn = New System.Windows.Forms.Label()
        Me.lblSDFfixDateadd = New System.Windows.Forms.Label()
        Me.DateTimePickerSDFadd = New System.Windows.Forms.DateTimePicker()
        Me.txtSDFCusID = New System.Windows.Forms.TextBox()
        Me.lblSDFcusid = New System.Windows.Forms.Label()
        Me.lblSDFCusName = New System.Windows.Forms.Label()
        Me.txtSDFcuszipcode = New System.Windows.Forms.TextBox()
        Me.lblSDFCusAddress = New System.Windows.Forms.Label()
        Me.lblSDFCusZip = New System.Windows.Forms.Label()
        Me.lblSDFCusTel = New System.Windows.Forms.Label()
        Me.txtSDFcusTel = New System.Windows.Forms.TextBox()
        Me.txtSDFcusname = New System.Windows.Forms.TextBox()
        Me.txtSDFcusaddress = New System.Windows.Forms.TextBox()
        Me.btnSDFSearcdcusID = New System.Windows.Forms.Button()
        Me.btnSDFsearchSN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSDFsearchSN = New System.Windows.Forms.TextBox()
        Me.dgSDFlistComfix = New System.Windows.Forms.DataGridView()
        Me.noC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_idC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fix_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ptype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pmodel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pcolor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.symptomC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.managerdataC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fixaccressoryC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSDFsaveAll = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DelComfixContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FixHitoryBySNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteComfixList = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DelPicContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DelPicToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgSDFlistComfix, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.DelComfixContextMenu.SuspendLayout()
        Me.DelPicContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.btnHelp})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(758, 22)
        Me.StatusStrip1.TabIndex = 1
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
        Me.SplitContainer1.MinimumSize = New System.Drawing.Size(758, 412)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblAutoNumber)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ProductModelLinkLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbSDFGimportune)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblSDFimportune)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTimePickerfixsendcom)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblSDFdatesend)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSDFfixnote)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblSDFnote)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSDFaccressory)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSDFfixaccessory)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AccessoryLinkLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSDFfixTprice)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblSDFtprice)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSDFfixrepairNote)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblSDFcomfixnote)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbbSDFrepairData)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ManagerDataLinkLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbbSDFcolor)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ProductColorLinkLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbbSDFmodel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbbSDFname)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ProductNameLinkLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ProductTypeLinkLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbbSDFtype)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FixComLinkLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbbSDFRepairType)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblSDFcheckSN)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSDFsearcdSN)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSDFfixSN)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblSDFsn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblSDFfixDateadd)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTimePickerSDFadd)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSDFCusID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblSDFcusid)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblSDFCusName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSDFcuszipcode)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblSDFCusAddress)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblSDFCusZip)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblSDFCusTel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSDFcusTel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSDFcusname)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSDFcusaddress)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSDFSearcdcusID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSDFsearchSN)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSDFsearchSN)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgSDFlistComfix)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel4)
        Me.SplitContainer1.Size = New System.Drawing.Size(758, 539)
        Me.SplitContainer1.SplitterDistance = 510
        Me.SplitContainer1.TabIndex = 0
        '
        'lblAutoNumber
        '
        Me.lblAutoNumber.AutoSize = True
        Me.lblAutoNumber.ForeColor = System.Drawing.Color.DarkRed
        Me.lblAutoNumber.Location = New System.Drawing.Point(103, 12)
        Me.lblAutoNumber.Name = "lblAutoNumber"
        Me.lblAutoNumber.Size = New System.Drawing.Size(0, 13)
        Me.lblAutoNumber.TabIndex = 140
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 139
        Me.Label3.Text = "หมายเลขใบรับซ่อม"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ListView1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 347)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(508, 119)
        Me.Panel3.TabIndex = 138
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(508, 119)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnTakePicture)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 466)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(508, 26)
        Me.Panel2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(423, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "รูปเครื่องรับซ่อม"
        '
        'btnTakePicture
        '
        Me.btnTakePicture.BackgroundImage = Global.ServiceTicker.My.Resources.Resources.TakeSnapshot_16x
        Me.btnTakePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTakePicture.Location = New System.Drawing.Point(3, 3)
        Me.btnTakePicture.Name = "btnTakePicture"
        Me.btnTakePicture.Size = New System.Drawing.Size(61, 21)
        Me.btnTakePicture.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btnTakePicture, "ภาพเครื่องรับซ่อม (เลือกภาพหรือบันทึกภาพจากกล้องเว็บแคม)")
        Me.btnTakePicture.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSDFfixsave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 492)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(508, 45)
        Me.Panel1.TabIndex = 1
        '
        'btnSDFfixsave
        '
        Me.btnSDFfixsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSDFfixsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSDFfixsave.Image = Global.ServiceTicker.My.Resources.Resources.Save_24x
        Me.btnSDFfixsave.Location = New System.Drawing.Point(343, 7)
        Me.btnSDFfixsave.Name = "btnSDFfixsave"
        Me.btnSDFfixsave.Size = New System.Drawing.Size(162, 36)
        Me.btnSDFfixsave.TabIndex = 0
        Me.btnSDFfixsave.Text = "^บันทึก "
        Me.btnSDFfixsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSDFfixsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnSDFfixsave, "บันทึกงานรับซ่อมนี้")
        Me.btnSDFfixsave.UseVisualStyleBackColor = True
        '
        'ProductModelLinkLabel
        '
        Me.ProductModelLinkLabel.AutoSize = True
        Me.ProductModelLinkLabel.Location = New System.Drawing.Point(303, 166)
        Me.ProductModelLinkLabel.Name = "ProductModelLinkLabel"
        Me.ProductModelLinkLabel.Size = New System.Drawing.Size(21, 13)
        Me.ProductModelLinkLabel.TabIndex = 135
        Me.ProductModelLinkLabel.TabStop = True
        Me.ProductModelLinkLabel.Text = "รุ่น"
        Me.ToolTip1.SetToolTip(Me.ProductModelLinkLabel, "เพิ่ม แก้ไข ลบ")
        '
        'cbSDFGimportune
        '
        Me.cbSDFGimportune.AutoSize = True
        Me.cbSDFGimportune.Location = New System.Drawing.Point(91, 327)
        Me.cbSDFGimportune.Name = "cbSDFGimportune"
        Me.cbSDFGimportune.Size = New System.Drawing.Size(103, 17)
        Me.cbSDFGimportune.TabIndex = 19
        Me.cbSDFGimportune.Text = "ต้องการซ่อมด่วน"
        Me.ToolTip1.SetToolTip(Me.cbSDFGimportune, "กำหนดความเร่งด่วนในการซ่อม (เช่น เสร็จภายในชั่วโมง สองชั่วโมง)")
        Me.cbSDFGimportune.UseVisualStyleBackColor = True
        '
        'lblSDFimportune
        '
        Me.lblSDFimportune.AutoSize = True
        Me.lblSDFimportune.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSDFimportune.Location = New System.Drawing.Point(14, 326)
        Me.lblSDFimportune.Name = "lblSDFimportune"
        Me.lblSDFimportune.Size = New System.Drawing.Size(68, 16)
        Me.lblSDFimportune.TabIndex = 128
        Me.lblSDFimportune.Text = "ความเร่งด่วน"
        '
        'DateTimePickerfixsendcom
        '
        Me.DateTimePickerfixsendcom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerfixsendcom.Location = New System.Drawing.Point(326, 301)
        Me.DateTimePickerfixsendcom.Name = "DateTimePickerfixsendcom"
        Me.DateTimePickerfixsendcom.Size = New System.Drawing.Size(177, 20)
        Me.DateTimePickerfixsendcom.TabIndex = 18
        Me.DateTimePickerfixsendcom.Value = New Date(2014, 11, 21, 15, 9, 1, 0)
        '
        'lblSDFdatesend
        '
        Me.lblSDFdatesend.AutoSize = True
        Me.lblSDFdatesend.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSDFdatesend.Location = New System.Drawing.Point(258, 302)
        Me.lblSDFdatesend.Name = "lblSDFdatesend"
        Me.lblSDFdatesend.Size = New System.Drawing.Size(62, 16)
        Me.lblSDFdatesend.TabIndex = 127
        Me.lblSDFdatesend.Text = "วันนัดรับคืน"
        '
        'txtSDFfixnote
        '
        Me.txtSDFfixnote.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSDFfixnote.Location = New System.Drawing.Point(72, 301)
        Me.txtSDFfixnote.Name = "txtSDFfixnote"
        Me.txtSDFfixnote.Size = New System.Drawing.Size(182, 20)
        Me.txtSDFfixnote.TabIndex = 17
        Me.txtSDFfixnote.Text = "-"
        '
        'lblSDFnote
        '
        Me.lblSDFnote.AutoSize = True
        Me.lblSDFnote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSDFnote.Location = New System.Drawing.Point(12, 301)
        Me.lblSDFnote.Name = "lblSDFnote"
        Me.lblSDFnote.Size = New System.Drawing.Size(52, 16)
        Me.lblSDFnote.TabIndex = 126
        Me.lblSDFnote.Text = "หมายเหตุ"
        '
        'btnSDFaccressory
        '
        Me.btnSDFaccressory.Location = New System.Drawing.Point(448, 273)
        Me.btnSDFaccressory.Name = "btnSDFaccressory"
        Me.btnSDFaccressory.Size = New System.Drawing.Size(52, 23)
        Me.btnSDFaccressory.TabIndex = 16
        Me.btnSDFaccressory.Text = "เลือก"
        Me.ToolTip1.SetToolTip(Me.btnSDFaccressory, "เลือกรายการอุปกรณ์ที่นำมาด้วย")
        Me.btnSDFaccressory.UseVisualStyleBackColor = True
        '
        'txtSDFfixaccessory
        '
        Me.txtSDFfixaccessory.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSDFfixaccessory.Location = New System.Drawing.Point(113, 275)
        Me.txtSDFfixaccessory.Name = "txtSDFfixaccessory"
        Me.txtSDFfixaccessory.Size = New System.Drawing.Size(329, 20)
        Me.txtSDFfixaccessory.TabIndex = 15
        '
        'AccessoryLinkLabel
        '
        Me.AccessoryLinkLabel.AutoSize = True
        Me.AccessoryLinkLabel.Location = New System.Drawing.Point(9, 278)
        Me.AccessoryLinkLabel.Name = "AccessoryLinkLabel"
        Me.AccessoryLinkLabel.Size = New System.Drawing.Size(94, 13)
        Me.AccessoryLinkLabel.TabIndex = 121
        Me.AccessoryLinkLabel.TabStop = True
        Me.AccessoryLinkLabel.Text = "อุปกรณ์ที่นำมาด้วย"
        Me.ToolTip1.SetToolTip(Me.AccessoryLinkLabel, "เพิ่ม แก้ไข ลบ")
        '
        'txtSDFfixTprice
        '
        Me.txtSDFfixTprice.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSDFfixTprice.Location = New System.Drawing.Point(405, 249)
        Me.txtSDFfixTprice.Name = "txtSDFfixTprice"
        Me.txtSDFfixTprice.Size = New System.Drawing.Size(95, 20)
        Me.txtSDFfixTprice.TabIndex = 14
        '
        'lblSDFtprice
        '
        Me.lblSDFtprice.AutoSize = True
        Me.lblSDFtprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSDFtprice.Location = New System.Drawing.Point(323, 250)
        Me.lblSDFtprice.Name = "lblSDFtprice"
        Me.lblSDFtprice.Size = New System.Drawing.Size(76, 16)
        Me.lblSDFtprice.TabIndex = 120
        Me.lblSDFtprice.Text = "ประเมินค่าซ่อม"
        '
        'txtSDFfixrepairNote
        '
        Me.txtSDFfixrepairNote.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSDFfixrepairNote.Location = New System.Drawing.Point(97, 249)
        Me.txtSDFfixrepairNote.Name = "txtSDFfixrepairNote"
        Me.txtSDFfixrepairNote.Size = New System.Drawing.Size(220, 20)
        Me.txtSDFfixrepairNote.TabIndex = 13
        Me.txtSDFfixrepairNote.Text = "-"
        '
        'lblSDFcomfixnote
        '
        Me.lblSDFcomfixnote.AutoSize = True
        Me.lblSDFcomfixnote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSDFcomfixnote.Location = New System.Drawing.Point(9, 250)
        Me.lblSDFcomfixnote.Name = "lblSDFcomfixnote"
        Me.lblSDFcomfixnote.Size = New System.Drawing.Size(87, 16)
        Me.lblSDFcomfixnote.TabIndex = 119
        Me.lblSDFcomfixnote.Text = "อาการเสียเพิ่มเติม"
        '
        'cbbSDFrepairData
        '
        Me.cbbSDFrepairData.BackColor = System.Drawing.Color.LemonChiffon
        Me.cbbSDFrepairData.FormattingEnabled = True
        Me.cbbSDFrepairData.Location = New System.Drawing.Point(257, 222)
        Me.cbbSDFrepairData.Name = "cbbSDFrepairData"
        Me.cbbSDFrepairData.Size = New System.Drawing.Size(243, 21)
        Me.cbbSDFrepairData.TabIndex = 12
        '
        'ManagerDataLinkLabel
        '
        Me.ManagerDataLinkLabel.AutoSize = True
        Me.ManagerDataLinkLabel.Location = New System.Drawing.Point(259, 206)
        Me.ManagerDataLinkLabel.Name = "ManagerDataLinkLabel"
        Me.ManagerDataLinkLabel.Size = New System.Drawing.Size(81, 13)
        Me.ManagerDataLinkLabel.TabIndex = 115
        Me.ManagerDataLinkLabel.TabStop = True
        Me.ManagerDataLinkLabel.Text = "การจัดการข้อมูล"
        Me.ToolTip1.SetToolTip(Me.ManagerDataLinkLabel, "เพิ่ม แก้ไข ลบ")
        '
        'cbbSDFcolor
        '
        Me.cbbSDFcolor.BackColor = System.Drawing.Color.LemonChiffon
        Me.cbbSDFcolor.FormattingEnabled = True
        Me.cbbSDFcolor.Location = New System.Drawing.Point(432, 182)
        Me.cbbSDFcolor.Name = "cbbSDFcolor"
        Me.cbbSDFcolor.Size = New System.Drawing.Size(69, 21)
        Me.cbbSDFcolor.TabIndex = 10
        '
        'ProductColorLinkLabel
        '
        Me.ProductColorLinkLabel.AutoSize = True
        Me.ProductColorLinkLabel.Location = New System.Drawing.Point(429, 166)
        Me.ProductColorLinkLabel.Name = "ProductColorLinkLabel"
        Me.ProductColorLinkLabel.Size = New System.Drawing.Size(13, 13)
        Me.ProductColorLinkLabel.TabIndex = 113
        Me.ProductColorLinkLabel.TabStop = True
        Me.ProductColorLinkLabel.Text = "สี"
        Me.ToolTip1.SetToolTip(Me.ProductColorLinkLabel, "เพิ่ม แก้ไข ลบ")
        '
        'cbbSDFmodel
        '
        Me.cbbSDFmodel.BackColor = System.Drawing.Color.LemonChiffon
        Me.cbbSDFmodel.FormattingEnabled = True
        Me.cbbSDFmodel.Location = New System.Drawing.Point(306, 182)
        Me.cbbSDFmodel.Name = "cbbSDFmodel"
        Me.cbbSDFmodel.Size = New System.Drawing.Size(120, 21)
        Me.cbbSDFmodel.TabIndex = 9
        '
        'cbbSDFname
        '
        Me.cbbSDFname.BackColor = System.Drawing.Color.LemonChiffon
        Me.cbbSDFname.FormattingEnabled = True
        Me.cbbSDFname.Location = New System.Drawing.Point(174, 182)
        Me.cbbSDFname.Name = "cbbSDFname"
        Me.cbbSDFname.Size = New System.Drawing.Size(126, 21)
        Me.cbbSDFname.TabIndex = 8
        '
        'ProductNameLinkLabel
        '
        Me.ProductNameLinkLabel.AutoSize = True
        Me.ProductNameLinkLabel.Location = New System.Drawing.Point(171, 166)
        Me.ProductNameLinkLabel.Name = "ProductNameLinkLabel"
        Me.ProductNameLinkLabel.Size = New System.Drawing.Size(27, 13)
        Me.ProductNameLinkLabel.TabIndex = 109
        Me.ProductNameLinkLabel.TabStop = True
        Me.ProductNameLinkLabel.Text = "ยี่ห้อ"
        Me.ToolTip1.SetToolTip(Me.ProductNameLinkLabel, "เพิ่ม แก้ไข ลบ")
        '
        'ProductTypeLinkLabel
        '
        Me.ProductTypeLinkLabel.AutoSize = True
        Me.ProductTypeLinkLabel.Location = New System.Drawing.Point(7, 166)
        Me.ProductTypeLinkLabel.Name = "ProductTypeLinkLabel"
        Me.ProductTypeLinkLabel.Size = New System.Drawing.Size(44, 13)
        Me.ProductTypeLinkLabel.TabIndex = 108
        Me.ProductTypeLinkLabel.TabStop = True
        Me.ProductTypeLinkLabel.Text = "ประเภท"
        Me.ToolTip1.SetToolTip(Me.ProductTypeLinkLabel, "เพิ่ม แก้ไข ลบ")
        '
        'cbbSDFtype
        '
        Me.cbbSDFtype.BackColor = System.Drawing.Color.LemonChiffon
        Me.cbbSDFtype.FormattingEnabled = True
        Me.cbbSDFtype.Location = New System.Drawing.Point(10, 182)
        Me.cbbSDFtype.Name = "cbbSDFtype"
        Me.cbbSDFtype.Size = New System.Drawing.Size(158, 21)
        Me.cbbSDFtype.TabIndex = 7
        '
        'FixComLinkLabel
        '
        Me.FixComLinkLabel.AutoSize = True
        Me.FixComLinkLabel.Location = New System.Drawing.Point(7, 206)
        Me.FixComLinkLabel.Name = "FixComLinkLabel"
        Me.FixComLinkLabel.Size = New System.Drawing.Size(54, 13)
        Me.FixComLinkLabel.TabIndex = 106
        Me.FixComLinkLabel.TabStop = True
        Me.FixComLinkLabel.Text = "อาการเสีย"
        Me.ToolTip1.SetToolTip(Me.FixComLinkLabel, "เพิ่ม แก้ไข ลบ")
        '
        'cbbSDFRepairType
        '
        Me.cbbSDFRepairType.BackColor = System.Drawing.Color.LemonChiffon
        Me.cbbSDFRepairType.FormattingEnabled = True
        Me.cbbSDFRepairType.Location = New System.Drawing.Point(10, 222)
        Me.cbbSDFRepairType.Name = "cbbSDFRepairType"
        Me.cbbSDFRepairType.Size = New System.Drawing.Size(241, 21)
        Me.cbbSDFRepairType.TabIndex = 11
        '
        'lblSDFcheckSN
        '
        Me.lblSDFcheckSN.AutoSize = True
        Me.lblSDFcheckSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSDFcheckSN.ForeColor = System.Drawing.Color.DimGray
        Me.lblSDFcheckSN.Location = New System.Drawing.Point(171, 128)
        Me.lblSDFcheckSN.Name = "lblSDFcheckSN"
        Me.lblSDFcheckSN.Size = New System.Drawing.Size(69, 13)
        Me.lblSDFcheckSN.TabIndex = 104
        Me.lblSDFcheckSN.Text = "ตรวจสอบ SN"
        '
        'btnSDFsearcdSN
        '
        Me.btnSDFsearcdSN.Location = New System.Drawing.Point(439, 142)
        Me.btnSDFsearcdSN.Name = "btnSDFsearcdSN"
        Me.btnSDFsearcdSN.Size = New System.Drawing.Size(61, 23)
        Me.btnSDFsearcdSN.TabIndex = 6
        Me.btnSDFsearcdSN.Text = "AutoSN"
        Me.ToolTip1.SetToolTip(Me.btnSDFsearcdSN, "สร้างหมายเลข SN อัตโนมัติ")
        Me.btnSDFsearcdSN.UseVisualStyleBackColor = True
        '
        'txtSDFfixSN
        '
        Me.txtSDFfixSN.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSDFfixSN.Location = New System.Drawing.Point(174, 144)
        Me.txtSDFfixSN.Name = "txtSDFfixSN"
        Me.txtSDFfixSN.Size = New System.Drawing.Size(259, 20)
        Me.txtSDFfixSN.TabIndex = 5
        '
        'lblSDFsn
        '
        Me.lblSDFsn.AutoSize = True
        Me.lblSDFsn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSDFsn.Location = New System.Drawing.Point(141, 145)
        Me.lblSDFsn.Name = "lblSDFsn"
        Me.lblSDFsn.Size = New System.Drawing.Size(27, 16)
        Me.lblSDFsn.TabIndex = 102
        Me.lblSDFsn.Text = "SN"
        '
        'lblSDFfixDateadd
        '
        Me.lblSDFfixDateadd.AutoSize = True
        Me.lblSDFfixDateadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSDFfixDateadd.Location = New System.Drawing.Point(11, 126)
        Me.lblSDFfixDateadd.Name = "lblSDFfixDateadd"
        Me.lblSDFfixDateadd.Size = New System.Drawing.Size(70, 16)
        Me.lblSDFfixDateadd.TabIndex = 101
        Me.lblSDFfixDateadd.Text = "วันที่รับเครื่อง"
        '
        'DateTimePickerSDFadd
        '
        Me.DateTimePickerSDFadd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerSDFadd.Location = New System.Drawing.Point(10, 144)
        Me.DateTimePickerSDFadd.Name = "DateTimePickerSDFadd"
        Me.DateTimePickerSDFadd.Size = New System.Drawing.Size(124, 20)
        Me.DateTimePickerSDFadd.TabIndex = 4
        Me.DateTimePickerSDFadd.Value = New Date(2016, 5, 9, 13, 54, 50, 0)
        '
        'txtSDFCusID
        '
        Me.txtSDFCusID.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSDFCusID.Location = New System.Drawing.Point(62, 61)
        Me.txtSDFCusID.Name = "txtSDFCusID"
        Me.txtSDFCusID.Size = New System.Drawing.Size(136, 20)
        Me.txtSDFCusID.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtSDFCusID, "ป้อนรหัสลูกค้า")
        '
        'lblSDFcusid
        '
        Me.lblSDFcusid.AutoSize = True
        Me.lblSDFcusid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSDFcusid.Location = New System.Drawing.Point(9, 62)
        Me.lblSDFcusid.Name = "lblSDFcusid"
        Me.lblSDFcusid.Size = New System.Drawing.Size(53, 16)
        Me.lblSDFcusid.TabIndex = 91
        Me.lblSDFcusid.Text = "รหัสลูกค้า"
        '
        'lblSDFCusName
        '
        Me.lblSDFCusName.AutoSize = True
        Me.lblSDFCusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSDFCusName.Location = New System.Drawing.Point(267, 62)
        Me.lblSDFCusName.Name = "lblSDFCusName"
        Me.lblSDFCusName.Size = New System.Drawing.Size(45, 16)
        Me.lblSDFCusName.TabIndex = 92
        Me.lblSDFCusName.Text = "ชื่อลูกค้า"
        '
        'txtSDFcuszipcode
        '
        Me.txtSDFcuszipcode.Location = New System.Drawing.Point(84, 105)
        Me.txtSDFcuszipcode.Name = "txtSDFcuszipcode"
        Me.txtSDFcuszipcode.ReadOnly = True
        Me.txtSDFcuszipcode.Size = New System.Drawing.Size(137, 20)
        Me.txtSDFcuszipcode.TabIndex = 89
        Me.txtSDFcuszipcode.TabStop = False
        '
        'lblSDFCusAddress
        '
        Me.lblSDFCusAddress.AutoSize = True
        Me.lblSDFCusAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSDFCusAddress.Location = New System.Drawing.Point(28, 84)
        Me.lblSDFCusAddress.Name = "lblSDFCusAddress"
        Me.lblSDFCusAddress.Size = New System.Drawing.Size(28, 16)
        Me.lblSDFCusAddress.TabIndex = 93
        Me.lblSDFCusAddress.Text = "ที่อยู่"
        '
        'lblSDFCusZip
        '
        Me.lblSDFCusZip.AutoSize = True
        Me.lblSDFCusZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSDFCusZip.Location = New System.Drawing.Point(9, 106)
        Me.lblSDFCusZip.Name = "lblSDFCusZip"
        Me.lblSDFCusZip.Size = New System.Drawing.Size(69, 16)
        Me.lblSDFCusZip.TabIndex = 97
        Me.lblSDFCusZip.Text = "รหัสไปรษณีย์"
        '
        'lblSDFCusTel
        '
        Me.lblSDFCusTel.AutoSize = True
        Me.lblSDFCusTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSDFCusTel.Location = New System.Drawing.Point(224, 106)
        Me.lblSDFCusTel.Name = "lblSDFCusTel"
        Me.lblSDFCusTel.Size = New System.Drawing.Size(27, 16)
        Me.lblSDFCusTel.TabIndex = 94
        Me.lblSDFCusTel.Text = "โทร"
        '
        'txtSDFcusTel
        '
        Me.txtSDFcusTel.Location = New System.Drawing.Point(257, 105)
        Me.txtSDFcusTel.Name = "txtSDFcusTel"
        Me.txtSDFcusTel.ReadOnly = True
        Me.txtSDFcusTel.Size = New System.Drawing.Size(243, 20)
        Me.txtSDFcusTel.TabIndex = 90
        Me.txtSDFcusTel.TabStop = False
        '
        'txtSDFcusname
        '
        Me.txtSDFcusname.Location = New System.Drawing.Point(318, 61)
        Me.txtSDFcusname.Name = "txtSDFcusname"
        Me.txtSDFcusname.ReadOnly = True
        Me.txtSDFcusname.Size = New System.Drawing.Size(182, 20)
        Me.txtSDFcusname.TabIndex = 87
        Me.txtSDFcusname.TabStop = False
        '
        'txtSDFcusaddress
        '
        Me.txtSDFcusaddress.Location = New System.Drawing.Point(62, 83)
        Me.txtSDFcusaddress.Name = "txtSDFcusaddress"
        Me.txtSDFcusaddress.ReadOnly = True
        Me.txtSDFcusaddress.Size = New System.Drawing.Size(438, 20)
        Me.txtSDFcusaddress.TabIndex = 88
        Me.txtSDFcusaddress.TabStop = False
        '
        'btnSDFSearcdcusID
        '
        Me.btnSDFSearcdcusID.Image = Global.ServiceTicker.My.Resources.Resources.Search_16xSM
        Me.btnSDFSearcdcusID.Location = New System.Drawing.Point(203, 58)
        Me.btnSDFSearcdcusID.Name = "btnSDFSearcdcusID"
        Me.btnSDFSearcdcusID.Size = New System.Drawing.Size(58, 23)
        Me.btnSDFSearcdcusID.TabIndex = 3
        Me.btnSDFSearcdcusID.Text = "ค้นหา"
        Me.btnSDFSearcdcusID.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnSDFSearcdcusID, "ค้นหารายชื่อลูกค้า")
        Me.btnSDFSearcdcusID.UseVisualStyleBackColor = True
        '
        'btnSDFsearchSN
        '
        Me.btnSDFsearchSN.Image = Global.ServiceTicker.My.Resources.Resources.Search_16xSM
        Me.btnSDFsearchSN.Location = New System.Drawing.Point(284, 33)
        Me.btnSDFsearchSN.Name = "btnSDFsearchSN"
        Me.btnSDFsearchSN.Size = New System.Drawing.Size(58, 23)
        Me.btnSDFsearchSN.TabIndex = 1
        Me.btnSDFsearchSN.Text = "ค้นหา"
        Me.btnSDFsearchSN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnSDFsearchSN, "ค้นหาประวัติจาก SN เครื่องซ่อม")
        Me.btnSDFsearchSN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "ค้นหา SN เครื่อง"
        '
        'txtSDFsearchSN
        '
        Me.txtSDFsearchSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSDFsearchSN.Location = New System.Drawing.Point(106, 31)
        Me.txtSDFsearchSN.Name = "txtSDFsearchSN"
        Me.txtSDFsearchSN.Size = New System.Drawing.Size(172, 24)
        Me.txtSDFsearchSN.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtSDFsearchSN, "ค้นหาประวัติจาก SN เครื่องซ่อม")
        '
        'dgSDFlistComfix
        '
        Me.dgSDFlistComfix.AllowUserToAddRows = False
        Me.dgSDFlistComfix.AllowUserToDeleteRows = False
        Me.dgSDFlistComfix.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgSDFlistComfix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSDFlistComfix.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.noC, Me.customer_idC, Me.fix_id, Me.DataGridViewTextBoxColumn1, Me.ptype, Me.pname, Me.pmodel, Me.pcolor, Me.symptomC, Me.managerdataC, Me.fixaccressoryC})
        Me.dgSDFlistComfix.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSDFlistComfix.Location = New System.Drawing.Point(0, 0)
        Me.dgSDFlistComfix.Name = "dgSDFlistComfix"
        Me.dgSDFlistComfix.ReadOnly = True
        Me.dgSDFlistComfix.RowHeadersVisible = False
        Me.dgSDFlistComfix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSDFlistComfix.Size = New System.Drawing.Size(242, 498)
        Me.dgSDFlistComfix.TabIndex = 0
        Me.dgSDFlistComfix.TabStop = False
        Me.ToolTip1.SetToolTip(Me.dgSDFlistComfix, "คลิ๊กขวาเพื่อลบรายการ")
        '
        'noC
        '
        Me.noC.HeaderText = "#"
        Me.noC.Name = "noC"
        Me.noC.ReadOnly = True
        Me.noC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.noC.Width = 30
        '
        'customer_idC
        '
        Me.customer_idC.HeaderText = "รหัสลูกค้า"
        Me.customer_idC.Name = "customer_idC"
        Me.customer_idC.ReadOnly = True
        Me.customer_idC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'fix_id
        '
        Me.fix_id.HeaderText = "รหัสงานซ่อม"
        Me.fix_id.Name = "fix_id"
        Me.fix_id.ReadOnly = True
        Me.fix_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fix_id.Width = 110
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "SN"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ptype
        '
        Me.ptype.HeaderText = "ประเภท"
        Me.ptype.Name = "ptype"
        Me.ptype.ReadOnly = True
        Me.ptype.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'pname
        '
        Me.pname.HeaderText = "ยี่ห้อ"
        Me.pname.Name = "pname"
        Me.pname.ReadOnly = True
        Me.pname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'pmodel
        '
        Me.pmodel.HeaderText = "รุ่น"
        Me.pmodel.Name = "pmodel"
        Me.pmodel.ReadOnly = True
        Me.pmodel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'pcolor
        '
        Me.pcolor.HeaderText = "สี"
        Me.pcolor.Name = "pcolor"
        Me.pcolor.ReadOnly = True
        Me.pcolor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'symptomC
        '
        Me.symptomC.HeaderText = "อาการเสีย"
        Me.symptomC.Name = "symptomC"
        Me.symptomC.ReadOnly = True
        Me.symptomC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'managerdataC
        '
        Me.managerdataC.HeaderText = "การจัดการข้อมูล"
        Me.managerdataC.Name = "managerdataC"
        Me.managerdataC.ReadOnly = True
        Me.managerdataC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.managerdataC.Width = 130
        '
        'fixaccressoryC
        '
        Me.fixaccressoryC.HeaderText = "อุปกรณ์ที่นำมาด้วย"
        Me.fixaccressoryC.Name = "fixaccressoryC"
        Me.fixaccressoryC.ReadOnly = True
        Me.fixaccressoryC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fixaccressoryC.Width = 150
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSDFsaveAll)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 498)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(242, 39)
        Me.Panel4.TabIndex = 1
        '
        'btnSDFsaveAll
        '
        Me.btnSDFsaveAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSDFsaveAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSDFsaveAll.Image = Global.ServiceTicker.My.Resources.Resources.SaveAll_16x
        Me.btnSDFsaveAll.Location = New System.Drawing.Point(0, 0)
        Me.btnSDFsaveAll.Name = "btnSDFsaveAll"
        Me.btnSDFsaveAll.Size = New System.Drawing.Size(242, 39)
        Me.btnSDFsaveAll.TabIndex = 0
        Me.btnSDFsaveAll.TabStop = False
        Me.btnSDFsaveAll.Text = "^บันทึกทั้งหมด "
        Me.btnSDFsaveAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSDFsaveAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnSDFsaveAll, "บันทึกรับงานซ่อมทั้งหมดในลิสต์ด้านขวา")
        Me.btnSDFsaveAll.UseVisualStyleBackColor = True
        '
        'DelComfixContextMenu
        '
        Me.DelComfixContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FixHitoryBySNToolStripMenuItem, Me.DeleteComfixList})
        Me.DelComfixContextMenu.Name = "DelComfixContextMenu"
        Me.DelComfixContextMenu.Size = New System.Drawing.Size(179, 48)
        '
        'FixHitoryBySNToolStripMenuItem
        '
        Me.FixHitoryBySNToolStripMenuItem.Image = Global.ServiceTicker.My.Resources.Resources.Property_20x
        Me.FixHitoryBySNToolStripMenuItem.Name = "FixHitoryBySNToolStripMenuItem"
        Me.FixHitoryBySNToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.FixHitoryBySNToolStripMenuItem.Text = "ดูประวัติการซ่อม"
        '
        'DeleteComfixList
        '
        Me.DeleteComfixList.Image = Global.ServiceTicker.My.Resources.Resources.action_Cancel_16xLG
        Me.DeleteComfixList.Name = "DeleteComfixList"
        Me.DeleteComfixList.Size = New System.Drawing.Size(178, 22)
        Me.DeleteComfixList.Text = "ลบรายการรับเครื่องซ่อม"
        '
        'Timer1
        '
        Me.Timer1.Interval = 4000
        '
        'DelPicContextMenu
        '
        Me.DelPicContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DelPicToolStripMenu})
        Me.DelPicContextMenu.Name = "DelPicContextMenu"
        Me.DelPicContextMenu.Size = New System.Drawing.Size(100, 26)
        '
        'DelPicToolStripMenu
        '
        Me.DelPicToolStripMenu.Name = "DelPicToolStripMenu"
        Me.DelPicToolStripMenu.Size = New System.Drawing.Size(99, 22)
        Me.DelPicToolStripMenu.Text = "ลบรูป"
        '
        'SaveDataFixFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 561)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "SaveDataFixFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รับงานซ่อม"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgSDFlistComfix, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.DelComfixContextMenu.ResumeLayout(False)
        Me.DelPicContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnSDFsaveAll As System.Windows.Forms.Button
    Friend WithEvents btnSDFfixsave As System.Windows.Forms.Button
    Friend WithEvents cbSDFGimportune As System.Windows.Forms.CheckBox
    Friend WithEvents lblSDFimportune As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerfixsendcom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSDFdatesend As System.Windows.Forms.Label
    Friend WithEvents txtSDFfixnote As System.Windows.Forms.TextBox
    Friend WithEvents lblSDFnote As System.Windows.Forms.Label
    Friend WithEvents btnSDFaccressory As System.Windows.Forms.Button
    Friend WithEvents txtSDFfixaccessory As System.Windows.Forms.TextBox
    Friend WithEvents AccessoryLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents txtSDFfixTprice As System.Windows.Forms.TextBox
    Friend WithEvents lblSDFtprice As System.Windows.Forms.Label
    Friend WithEvents txtSDFfixrepairNote As System.Windows.Forms.TextBox
    Friend WithEvents lblSDFcomfixnote As System.Windows.Forms.Label
    Friend WithEvents cbbSDFrepairData As System.Windows.Forms.ComboBox
    Friend WithEvents ManagerDataLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents cbbSDFcolor As System.Windows.Forms.ComboBox
    Friend WithEvents ProductColorLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents cbbSDFmodel As System.Windows.Forms.ComboBox
    Friend WithEvents cbbSDFname As System.Windows.Forms.ComboBox
    Friend WithEvents ProductNameLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents ProductTypeLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents cbbSDFtype As System.Windows.Forms.ComboBox
    Friend WithEvents FixComLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents cbbSDFRepairType As System.Windows.Forms.ComboBox
    Friend WithEvents lblSDFcheckSN As System.Windows.Forms.Label
    Friend WithEvents btnSDFsearcdSN As System.Windows.Forms.Button
    Friend WithEvents txtSDFfixSN As System.Windows.Forms.TextBox
    Friend WithEvents lblSDFsn As System.Windows.Forms.Label
    Friend WithEvents lblSDFfixDateadd As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerSDFadd As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtSDFCusID As System.Windows.Forms.TextBox
    Friend WithEvents lblSDFcusid As System.Windows.Forms.Label
    Friend WithEvents lblSDFCusName As System.Windows.Forms.Label
    Friend WithEvents txtSDFcuszipcode As System.Windows.Forms.TextBox
    Friend WithEvents lblSDFCusAddress As System.Windows.Forms.Label
    Friend WithEvents lblSDFCusZip As System.Windows.Forms.Label
    Friend WithEvents lblSDFCusTel As System.Windows.Forms.Label
    Friend WithEvents txtSDFcusTel As System.Windows.Forms.TextBox
    Friend WithEvents txtSDFcusname As System.Windows.Forms.TextBox
    Friend WithEvents txtSDFcusaddress As System.Windows.Forms.TextBox
    Friend WithEvents btnSDFSearcdcusID As System.Windows.Forms.Button
    Friend WithEvents btnSDFsearchSN As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSDFsearchSN As System.Windows.Forms.TextBox
    Friend WithEvents dgSDFlistComfix As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DelComfixContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DeleteComfixList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnTakePicture As System.Windows.Forms.Button
    Friend WithEvents ProductModelLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents FixHitoryBySNToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DelPicContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DelPicToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents noC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_idC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fix_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ptype As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pmodel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pcolor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents symptomC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents managerdataC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fixaccressoryC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblAutoNumber As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
