<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PartsWithdrawalFrm
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtPWprobarcodeANDsn = New System.Windows.Forms.TextBox()
        Me.txtPWproname = New System.Windows.Forms.TextBox()
        Me.txtPWproprice = New System.Windows.Forms.TextBox()
        Me.lblPESerial = New System.Windows.Forms.Label()
        Me.txtPWproUnit = New System.Windows.Forms.TextBox()
        Me.txtPWprobarcode = New System.Windows.Forms.TextBox()
        Me.txtPWprop = New System.Windows.Forms.TextBox()
        Me.btnPWokTodg = New System.Windows.Forms.Button()
        Me.lblPWcodeORbarcode = New System.Windows.Forms.Label()
        Me.lblPWproName = New System.Windows.Forms.Label()
        Me.lblPWprice = New System.Windows.Forms.Label()
        Me.lblPWunit = New System.Windows.Forms.Label()
        Me.lblPwP = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbSmembers = New System.Windows.Forms.RadioButton()
        Me.rbSbuy = New System.Windows.Forms.RadioButton()
        Me.rbSloyal = New System.Windows.Forms.RadioButton()
        Me.rbSwholesale = New System.Windows.Forms.RadioButton()
        Me.rbStechnician = New System.Windows.Forms.RadioButton()
        Me.lblPWtotalXYZ = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPWrepairID = New System.Windows.Forms.TextBox()
        Me.txtPWcusTel = New System.Windows.Forms.TextBox()
        Me.txtPWcusName = New System.Windows.Forms.TextBox()
        Me.txtPWcusID = New System.Windows.Forms.TextBox()
        Me.lblPWdategetbill = New System.Windows.Forms.Label()
        Me.lblPWbillNum = New System.Windows.Forms.Label()
        Me.txtPWdateNow = New System.Windows.Forms.TextBox()
        Me.txtPWsaleID = New System.Windows.Forms.TextBox()
        Me.cbbPWgetProSection = New System.Windows.Forms.ComboBox()
        Me.txtPWproSearch = New System.Windows.Forms.TextBox()
        Me.dgPWProsearch = New System.Windows.Forms.DataGridView()
        Me.lblPWgetTotalPrice = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.dgPWproMEwSN = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgPWproMeNoSN = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnPWclose = New System.Windows.Forms.Button()
        Me.btnPWsave = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.mnuCellNosn = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteNoSNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCellSN = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteSNToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgPWProsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.dgPWproMEwSN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgPWproMeNoSN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.mnuCellNosn.SuspendLayout()
        Me.mnuCellSN.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.TabIndex = 303
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblEmployee
        '
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(30, 17)
        Me.lblEmployee.Text = "Uesr"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPWtotalXYZ)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPWrepairID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPWcusTel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPWcusName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPWcusID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPWdategetbill)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPWbillNum)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPWdateNow)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPWsaleID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbbPWgetProSection)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPWproSearch)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgPWProsearch)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPWgetTotalPrice)
        Me.SplitContainer1.Panel1MinSize = 300
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(784, 539)
        Me.SplitContainer1.SplitterDistance = 300
        Me.SplitContainer1.TabIndex = 300
        Me.SplitContainer1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtPWprobarcodeANDsn)
        Me.Panel3.Controls.Add(Me.txtPWproname)
        Me.Panel3.Controls.Add(Me.txtPWproprice)
        Me.Panel3.Controls.Add(Me.lblPESerial)
        Me.Panel3.Controls.Add(Me.txtPWproUnit)
        Me.Panel3.Controls.Add(Me.txtPWprobarcode)
        Me.Panel3.Controls.Add(Me.txtPWprop)
        Me.Panel3.Controls.Add(Me.btnPWokTodg)
        Me.Panel3.Controls.Add(Me.lblPWcodeORbarcode)
        Me.Panel3.Controls.Add(Me.lblPWproName)
        Me.Panel3.Controls.Add(Me.lblPWprice)
        Me.Panel3.Controls.Add(Me.lblPWunit)
        Me.Panel3.Controls.Add(Me.lblPwP)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 229)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(782, 69)
        Me.Panel3.TabIndex = 83
        '
        'txtPWprobarcodeANDsn
        '
        Me.txtPWprobarcodeANDsn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPWprobarcodeANDsn.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtPWprobarcodeANDsn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPWprobarcodeANDsn.Location = New System.Drawing.Point(3, 32)
        Me.txtPWprobarcodeANDsn.Name = "txtPWprobarcodeANDsn"
        Me.txtPWprobarcodeANDsn.Size = New System.Drawing.Size(120, 29)
        Me.txtPWprobarcodeANDsn.TabIndex = 0
        '
        'txtPWproname
        '
        Me.txtPWproname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPWproname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPWproname.Location = New System.Drawing.Point(237, 32)
        Me.txtPWproname.Name = "txtPWproname"
        Me.txtPWproname.ReadOnly = True
        Me.txtPWproname.Size = New System.Drawing.Size(186, 29)
        Me.txtPWproname.TabIndex = 146
        Me.txtPWproname.TabStop = False
        '
        'txtPWproprice
        '
        Me.txtPWproprice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPWproprice.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtPWproprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPWproprice.Location = New System.Drawing.Point(429, 32)
        Me.txtPWproprice.Name = "txtPWproprice"
        Me.txtPWproprice.Size = New System.Drawing.Size(94, 29)
        Me.txtPWproprice.TabIndex = 1
        '
        'lblPESerial
        '
        Me.lblPESerial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPESerial.AutoSize = True
        Me.lblPESerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPESerial.Location = New System.Drawing.Point(22, 10)
        Me.lblPESerial.Name = "lblPESerial"
        Me.lblPESerial.Size = New System.Drawing.Size(83, 20)
        Me.lblPESerial.TabIndex = 170
        Me.lblPESerial.Text = "SN/บาร์โค๊ต"
        '
        'txtPWproUnit
        '
        Me.txtPWproUnit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPWproUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPWproUnit.Location = New System.Drawing.Point(529, 32)
        Me.txtPWproUnit.Name = "txtPWproUnit"
        Me.txtPWproUnit.ReadOnly = True
        Me.txtPWproUnit.Size = New System.Drawing.Size(87, 29)
        Me.txtPWproUnit.TabIndex = 148
        Me.txtPWproUnit.TabStop = False
        '
        'txtPWprobarcode
        '
        Me.txtPWprobarcode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPWprobarcode.BackColor = System.Drawing.SystemColors.Control
        Me.txtPWprobarcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPWprobarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPWprobarcode.Location = New System.Drawing.Point(129, 32)
        Me.txtPWprobarcode.Name = "txtPWprobarcode"
        Me.txtPWprobarcode.ReadOnly = True
        Me.txtPWprobarcode.Size = New System.Drawing.Size(102, 29)
        Me.txtPWprobarcode.TabIndex = 169
        Me.txtPWprobarcode.TabStop = False
        '
        'txtPWprop
        '
        Me.txtPWprop.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPWprop.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtPWprop.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPWprop.Location = New System.Drawing.Point(622, 32)
        Me.txtPWprop.Name = "txtPWprop"
        Me.txtPWprop.Size = New System.Drawing.Size(85, 29)
        Me.txtPWprop.TabIndex = 2
        '
        'btnPWokTodg
        '
        Me.btnPWokTodg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPWokTodg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPWokTodg.Location = New System.Drawing.Point(711, 30)
        Me.btnPWokTodg.Name = "btnPWokTodg"
        Me.btnPWokTodg.Size = New System.Drawing.Size(68, 31)
        Me.btnPWokTodg.TabIndex = 3
        Me.btnPWokTodg.Text = "ตกลง"
        Me.btnPWokTodg.UseVisualStyleBackColor = True
        '
        'lblPWcodeORbarcode
        '
        Me.lblPWcodeORbarcode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPWcodeORbarcode.AutoSize = True
        Me.lblPWcodeORbarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPWcodeORbarcode.Location = New System.Drawing.Point(150, 10)
        Me.lblPWcodeORbarcode.Name = "lblPWcodeORbarcode"
        Me.lblPWcodeORbarcode.Size = New System.Drawing.Size(57, 20)
        Me.lblPWcodeORbarcode.TabIndex = 151
        Me.lblPWcodeORbarcode.Text = "บาร์โค๊ต"
        '
        'lblPWproName
        '
        Me.lblPWproName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPWproName.AutoSize = True
        Me.lblPWproName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPWproName.Location = New System.Drawing.Point(299, 9)
        Me.lblPWproName.Name = "lblPWproName"
        Me.lblPWproName.Size = New System.Drawing.Size(59, 20)
        Me.lblPWproName.TabIndex = 152
        Me.lblPWproName.Text = "ชื่อสินค้า"
        '
        'lblPWprice
        '
        Me.lblPWprice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPWprice.AutoSize = True
        Me.lblPWprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPWprice.Location = New System.Drawing.Point(458, 10)
        Me.lblPWprice.Name = "lblPWprice"
        Me.lblPWprice.Size = New System.Drawing.Size(39, 20)
        Me.lblPWprice.TabIndex = 153
        Me.lblPWprice.Text = "ราคา"
        '
        'lblPWunit
        '
        Me.lblPWunit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPWunit.AutoSize = True
        Me.lblPWunit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPWunit.Location = New System.Drawing.Point(550, 10)
        Me.lblPWunit.Name = "lblPWunit"
        Me.lblPWunit.Size = New System.Drawing.Size(42, 20)
        Me.lblPWunit.TabIndex = 154
        Me.lblPWunit.Text = "หน่วย"
        '
        'lblPwP
        '
        Me.lblPwP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPwP.AutoSize = True
        Me.lblPwP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPwP.Location = New System.Drawing.Point(637, 10)
        Me.lblPwP.Name = "lblPwP"
        Me.lblPwP.Size = New System.Drawing.Size(54, 20)
        Me.lblPwP.TabIndex = 155
        Me.lblPwP.Text = "ปริมาณ"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.rbSmembers)
        Me.GroupBox1.Controls.Add(Me.rbSbuy)
        Me.GroupBox1.Controls.Add(Me.rbSloyal)
        Me.GroupBox1.Controls.Add(Me.rbSwholesale)
        Me.GroupBox1.Controls.Add(Me.rbStechnician)
        Me.GroupBox1.Location = New System.Drawing.Point(476, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 37)
        Me.GroupBox1.TabIndex = 305
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ระดับราคา"
        Me.ToolTip1.SetToolTip(Me.GroupBox1, "กำหนดระดับราคา")
        '
        'rbSmembers
        '
        Me.rbSmembers.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbSmembers.AutoSize = True
        Me.rbSmembers.Location = New System.Drawing.Point(237, 15)
        Me.rbSmembers.Name = "rbSmembers"
        Me.rbSmembers.Size = New System.Drawing.Size(57, 17)
        Me.rbSmembers.TabIndex = 177
        Me.rbSmembers.Text = "สมาชิก"
        Me.ToolTip1.SetToolTip(Me.rbSmembers, "ราคาขายสำหรับสมาชิก")
        Me.rbSmembers.UseVisualStyleBackColor = True
        '
        'rbSbuy
        '
        Me.rbSbuy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbSbuy.AutoSize = True
        Me.rbSbuy.Checked = True
        Me.rbSbuy.Location = New System.Drawing.Point(17, 15)
        Me.rbSbuy.Name = "rbSbuy"
        Me.rbSbuy.Size = New System.Drawing.Size(46, 17)
        Me.rbSbuy.TabIndex = 173
        Me.rbSbuy.TabStop = True
        Me.rbSbuy.Text = "ปกติ"
        Me.ToolTip1.SetToolTip(Me.rbSbuy, "ราคาขายปกติ")
        Me.rbSbuy.UseVisualStyleBackColor = True
        '
        'rbSloyal
        '
        Me.rbSloyal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbSloyal.AutoSize = True
        Me.rbSloyal.Location = New System.Drawing.Point(177, 15)
        Me.rbSloyal.Name = "rbSloyal"
        Me.rbSloyal.Size = New System.Drawing.Size(54, 17)
        Me.rbSloyal.TabIndex = 176
        Me.rbSloyal.Text = "ประจำ"
        Me.ToolTip1.SetToolTip(Me.rbSloyal, "ราคาขายสำหรับขาประจำ")
        Me.rbSloyal.UseVisualStyleBackColor = True
        '
        'rbSwholesale
        '
        Me.rbSwholesale.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbSwholesale.AutoSize = True
        Me.rbSwholesale.Location = New System.Drawing.Point(69, 15)
        Me.rbSwholesale.Name = "rbSwholesale"
        Me.rbSwholesale.Size = New System.Drawing.Size(54, 17)
        Me.rbSwholesale.TabIndex = 174
        Me.rbSwholesale.Text = "ขายส่ง"
        Me.ToolTip1.SetToolTip(Me.rbSwholesale, "ราคาขายส่ง")
        Me.rbSwholesale.UseVisualStyleBackColor = True
        '
        'rbStechnician
        '
        Me.rbStechnician.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbStechnician.AutoSize = True
        Me.rbStechnician.Location = New System.Drawing.Point(129, 15)
        Me.rbStechnician.Name = "rbStechnician"
        Me.rbStechnician.Size = New System.Drawing.Size(42, 17)
        Me.rbStechnician.TabIndex = 175
        Me.rbStechnician.Text = "ช่าง"
        Me.ToolTip1.SetToolTip(Me.rbStechnician, "ราคาขายสำหรับช่าง")
        Me.rbStechnician.UseVisualStyleBackColor = True
        '
        'lblPWtotalXYZ
        '
        Me.lblPWtotalXYZ.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPWtotalXYZ.BackColor = System.Drawing.Color.DarkBlue
        Me.lblPWtotalXYZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPWtotalXYZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPWtotalXYZ.ForeColor = System.Drawing.Color.Gold
        Me.lblPWtotalXYZ.Location = New System.Drawing.Point(475, 203)
        Me.lblPWtotalXYZ.Name = "lblPWtotalXYZ"
        Me.lblPWtotalXYZ.Size = New System.Drawing.Size(296, 23)
        Me.lblPWtotalXYZ.TabIndex = 171
        Me.lblPWtotalXYZ.Text = "----------------"
        Me.lblPWtotalXYZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblPWtotalXYZ, "จำนวน รายการ/สินค้า")
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(476, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 168
        Me.Label5.Text = "รหัสใบส่งซ่อม"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(533, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 167
        Me.Label4.Text = "เบอร์โทร"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(562, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 166
        Me.Label3.Text = "ชื่อ"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(534, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 165
        Me.Label2.Text = "รหัสลูกค้า"
        '
        'txtPWrepairID
        '
        Me.txtPWrepairID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPWrepairID.Enabled = False
        Me.txtPWrepairID.Location = New System.Drawing.Point(554, 63)
        Me.txtPWrepairID.Name = "txtPWrepairID"
        Me.txtPWrepairID.ReadOnly = True
        Me.txtPWrepairID.Size = New System.Drawing.Size(217, 20)
        Me.txtPWrepairID.TabIndex = 164
        Me.txtPWrepairID.TabStop = False
        '
        'txtPWcusTel
        '
        Me.txtPWcusTel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPWcusTel.Enabled = False
        Me.txtPWcusTel.Location = New System.Drawing.Point(588, 44)
        Me.txtPWcusTel.Name = "txtPWcusTel"
        Me.txtPWcusTel.ReadOnly = True
        Me.txtPWcusTel.Size = New System.Drawing.Size(183, 20)
        Me.txtPWcusTel.TabIndex = 163
        Me.txtPWcusTel.TabStop = False
        '
        'txtPWcusName
        '
        Me.txtPWcusName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPWcusName.Enabled = False
        Me.txtPWcusName.Location = New System.Drawing.Point(588, 25)
        Me.txtPWcusName.Name = "txtPWcusName"
        Me.txtPWcusName.ReadOnly = True
        Me.txtPWcusName.Size = New System.Drawing.Size(183, 20)
        Me.txtPWcusName.TabIndex = 162
        Me.txtPWcusName.TabStop = False
        '
        'txtPWcusID
        '
        Me.txtPWcusID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPWcusID.Enabled = False
        Me.txtPWcusID.Location = New System.Drawing.Point(588, 6)
        Me.txtPWcusID.Name = "txtPWcusID"
        Me.txtPWcusID.ReadOnly = True
        Me.txtPWcusID.Size = New System.Drawing.Size(183, 20)
        Me.txtPWcusID.TabIndex = 161
        Me.txtPWcusID.TabStop = False
        '
        'lblPWdategetbill
        '
        Me.lblPWdategetbill.AutoSize = True
        Me.lblPWdategetbill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPWdategetbill.Location = New System.Drawing.Point(237, 9)
        Me.lblPWdategetbill.Name = "lblPWdategetbill"
        Me.lblPWdategetbill.Size = New System.Drawing.Size(76, 13)
        Me.lblPWdategetbill.TabIndex = 160
        Me.lblPWdategetbill.Text = "วันที่ทำรายการ"
        '
        'lblPWbillNum
        '
        Me.lblPWbillNum.AutoSize = True
        Me.lblPWbillNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPWbillNum.Location = New System.Drawing.Point(11, 8)
        Me.lblPWbillNum.Name = "lblPWbillNum"
        Me.lblPWbillNum.Size = New System.Drawing.Size(44, 13)
        Me.lblPWbillNum.TabIndex = 159
        Me.lblPWbillNum.Text = "เลขที่บิล"
        '
        'txtPWdateNow
        '
        Me.txtPWdateNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPWdateNow.ForeColor = System.Drawing.Color.DarkRed
        Me.txtPWdateNow.Location = New System.Drawing.Point(317, 3)
        Me.txtPWdateNow.Name = "txtPWdateNow"
        Me.txtPWdateNow.ReadOnly = True
        Me.txtPWdateNow.Size = New System.Drawing.Size(170, 21)
        Me.txtPWdateNow.TabIndex = 158
        Me.txtPWdateNow.TabStop = False
        Me.txtPWdateNow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtPWdateNow, "วันที่ทำรายการ")
        '
        'txtPWsaleID
        '
        Me.txtPWsaleID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPWsaleID.ForeColor = System.Drawing.Color.Blue
        Me.txtPWsaleID.Location = New System.Drawing.Point(61, 4)
        Me.txtPWsaleID.Name = "txtPWsaleID"
        Me.txtPWsaleID.ReadOnly = True
        Me.txtPWsaleID.Size = New System.Drawing.Size(170, 21)
        Me.txtPWsaleID.TabIndex = 157
        Me.txtPWsaleID.TabStop = False
        Me.txtPWsaleID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtPWsaleID, "เลขที่เบิกอะไหล่/สินค้า")
        '
        'cbbPWgetProSection
        '
        Me.cbbPWgetProSection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbPWgetProSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbbPWgetProSection.Location = New System.Drawing.Point(135, 27)
        Me.cbbPWgetProSection.Name = "cbbPWgetProSection"
        Me.cbbPWgetProSection.Size = New System.Drawing.Size(335, 32)
        Me.cbbPWgetProSection.TabIndex = 145
        Me.cbbPWgetProSection.TabStop = False
        Me.ToolTip1.SetToolTip(Me.cbbPWgetProSection, "รายการประเภทสินค้า")
        '
        'txtPWproSearch
        '
        Me.txtPWproSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPWproSearch.Location = New System.Drawing.Point(10, 28)
        Me.txtPWproSearch.Name = "txtPWproSearch"
        Me.txtPWproSearch.Size = New System.Drawing.Size(119, 31)
        Me.txtPWproSearch.TabIndex = 144
        Me.txtPWproSearch.TabStop = False
        Me.ToolTip1.SetToolTip(Me.txtPWproSearch, "พิมพ์ค้นหาแล้วกด enter")
        '
        'dgPWProsearch
        '
        Me.dgPWProsearch.AllowUserToAddRows = False
        Me.dgPWProsearch.AllowUserToDeleteRows = False
        Me.dgPWProsearch.AllowUserToOrderColumns = True
        Me.dgPWProsearch.AllowUserToResizeRows = False
        Me.dgPWProsearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPWProsearch.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgPWProsearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPWProsearch.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgPWProsearch.Location = New System.Drawing.Point(11, 65)
        Me.dgPWProsearch.Name = "dgPWProsearch"
        Me.dgPWProsearch.ReadOnly = True
        Me.dgPWProsearch.RowHeadersVisible = False
        Me.dgPWProsearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPWProsearch.Size = New System.Drawing.Size(459, 161)
        Me.dgPWProsearch.TabIndex = 156
        Me.dgPWProsearch.TabStop = False
        Me.ToolTip1.SetToolTip(Me.dgPWProsearch, "รายการสินค้า")
        '
        'lblPWgetTotalPrice
        '
        Me.lblPWgetTotalPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPWgetTotalPrice.BackColor = System.Drawing.Color.DarkBlue
        Me.lblPWgetTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPWgetTotalPrice.ForeColor = System.Drawing.Color.Gold
        Me.lblPWgetTotalPrice.Location = New System.Drawing.Point(475, 129)
        Me.lblPWgetTotalPrice.Name = "lblPWgetTotalPrice"
        Me.lblPWgetTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPWgetTotalPrice.Size = New System.Drawing.Size(296, 74)
        Me.lblPWgetTotalPrice.TabIndex = 150
        Me.lblPWgetTotalPrice.Text = "-"
        Me.lblPWgetTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.lblPWgetTotalPrice, "รวมราคาทั้งหมด")
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.dgPWproMEwSN)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.dgPWproMeNoSN)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer2.Size = New System.Drawing.Size(784, 235)
        Me.SplitContainer2.SplitterDistance = 261
        Me.SplitContainer2.TabIndex = 301
        Me.SplitContainer2.TabStop = False
        '
        'dgPWproMEwSN
        '
        Me.dgPWproMEwSN.AllowUserToAddRows = False
        Me.dgPWproMEwSN.AllowUserToDeleteRows = False
        Me.dgPWproMEwSN.AllowUserToOrderColumns = True
        Me.dgPWproMEwSN.AllowUserToResizeRows = False
        Me.dgPWproMEwSN.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgPWproMEwSN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPWproMEwSN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPWproMEwSN.Location = New System.Drawing.Point(0, 0)
        Me.dgPWproMEwSN.Name = "dgPWproMEwSN"
        Me.dgPWproMEwSN.ReadOnly = True
        Me.dgPWproMEwSN.RowHeadersVisible = False
        Me.dgPWproMEwSN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPWproMEwSN.Size = New System.Drawing.Size(259, 190)
        Me.dgPWproMEwSN.TabIndex = 47
        Me.dgPWproMEwSN.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 190)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(259, 43)
        Me.Panel1.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "*คลิ๊กขวาเพื่อลบ"
        '
        'dgPWproMeNoSN
        '
        Me.dgPWproMeNoSN.AllowUserToAddRows = False
        Me.dgPWproMeNoSN.AllowUserToDeleteRows = False
        Me.dgPWproMeNoSN.AllowUserToOrderColumns = True
        Me.dgPWproMeNoSN.AllowUserToResizeRows = False
        Me.dgPWproMeNoSN.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgPWproMeNoSN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPWproMeNoSN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPWproMeNoSN.GridColor = System.Drawing.SystemColors.Control
        Me.dgPWproMeNoSN.Location = New System.Drawing.Point(0, 0)
        Me.dgPWproMeNoSN.MultiSelect = False
        Me.dgPWproMeNoSN.Name = "dgPWproMeNoSN"
        Me.dgPWproMeNoSN.RowHeadersVisible = False
        Me.dgPWproMeNoSN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPWproMeNoSN.Size = New System.Drawing.Size(517, 190)
        Me.dgPWproMeNoSN.TabIndex = 82
        Me.dgPWproMeNoSN.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnPWclose)
        Me.Panel2.Controls.Add(Me.btnPWsave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 190)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(517, 43)
        Me.Panel2.TabIndex = 49
        '
        'btnPWclose
        '
        Me.btnPWclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPWclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPWclose.Location = New System.Drawing.Point(411, 3)
        Me.btnPWclose.Name = "btnPWclose"
        Me.btnPWclose.Size = New System.Drawing.Size(101, 37)
        Me.btnPWclose.TabIndex = 6
        Me.btnPWclose.Text = "ปิด"
        Me.btnPWclose.UseVisualStyleBackColor = True
        '
        'btnPWsave
        '
        Me.btnPWsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPWsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPWsave.Location = New System.Drawing.Point(304, 3)
        Me.btnPWsave.Name = "btnPWsave"
        Me.btnPWsave.Size = New System.Drawing.Size(101, 37)
        Me.btnPWsave.TabIndex = 4
        Me.btnPWsave.Text = "บันทึก"
        Me.ToolTip1.SetToolTip(Me.btnPWsave, "บันทึกการรายการ เบิกอะไหล่/ค้าบริการ")
        Me.btnPWsave.UseVisualStyleBackColor = True
        '
        'mnuCellNosn
        '
        Me.mnuCellNosn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteNoSNToolStripMenuItem})
        Me.mnuCellNosn.Name = "mnuCell"
        Me.mnuCellNosn.ShowImageMargin = False
        Me.mnuCellNosn.Size = New System.Drawing.Size(83, 26)
        '
        'DeleteNoSNToolStripMenuItem
        '
        Me.DeleteNoSNToolStripMenuItem.Name = "DeleteNoSNToolStripMenuItem"
        Me.DeleteNoSNToolStripMenuItem.Size = New System.Drawing.Size(82, 22)
        Me.DeleteNoSNToolStripMenuItem.Text = "Delete"
        '
        'mnuCellSN
        '
        Me.mnuCellSN.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteSNToolStripMenu})
        Me.mnuCellSN.Name = "mnuCell1"
        Me.mnuCellSN.ShowImageMargin = False
        Me.mnuCellSN.Size = New System.Drawing.Size(83, 26)
        '
        'DeleteSNToolStripMenu
        '
        Me.DeleteSNToolStripMenu.Name = "DeleteSNToolStripMenu"
        Me.DeleteSNToolStripMenu.Size = New System.Drawing.Size(82, 22)
        Me.DeleteSNToolStripMenu.Text = "Delete"
        '
        'PartsWithdrawalFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.MinimumSize = New System.Drawing.Size(800, 400)
        Me.Name = "PartsWithdrawalFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เบิกอะไหล่/ค่าบริการ"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgPWProsearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.dgPWproMEwSN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgPWproMeNoSN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.mnuCellNosn.ResumeLayout(False)
        Me.mnuCellSN.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbSmembers As System.Windows.Forms.RadioButton
    Friend WithEvents rbSbuy As System.Windows.Forms.RadioButton
    Friend WithEvents rbSloyal As System.Windows.Forms.RadioButton
    Friend WithEvents rbSwholesale As System.Windows.Forms.RadioButton
    Friend WithEvents rbStechnician As System.Windows.Forms.RadioButton
    Friend WithEvents lblPWtotalXYZ As System.Windows.Forms.Label
    Friend WithEvents lblPESerial As System.Windows.Forms.Label
    Friend WithEvents txtPWprobarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPWrepairID As System.Windows.Forms.TextBox
    Friend WithEvents txtPWcusTel As System.Windows.Forms.TextBox
    Friend WithEvents txtPWcusName As System.Windows.Forms.TextBox
    Friend WithEvents txtPWcusID As System.Windows.Forms.TextBox
    Friend WithEvents lblPWdategetbill As System.Windows.Forms.Label
    Friend WithEvents lblPWbillNum As System.Windows.Forms.Label
    Friend WithEvents txtPWdateNow As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtPWsaleID As System.Windows.Forms.TextBox
    Friend WithEvents cbbPWgetProSection As System.Windows.Forms.ComboBox
    Friend WithEvents txtPWproSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgPWProsearch As System.Windows.Forms.DataGridView
    Friend WithEvents lblPwP As System.Windows.Forms.Label
    Friend WithEvents lblPWunit As System.Windows.Forms.Label
    Friend WithEvents lblPWprice As System.Windows.Forms.Label
    Friend WithEvents lblPWproName As System.Windows.Forms.Label
    Friend WithEvents lblPWcodeORbarcode As System.Windows.Forms.Label
    Friend WithEvents lblPWgetTotalPrice As System.Windows.Forms.Label
    Friend WithEvents btnPWokTodg As System.Windows.Forms.Button
    Friend WithEvents txtPWprop As System.Windows.Forms.TextBox
    Friend WithEvents txtPWproUnit As System.Windows.Forms.TextBox
    Friend WithEvents txtPWproprice As System.Windows.Forms.TextBox
    Friend WithEvents txtPWproname As System.Windows.Forms.TextBox
    Friend WithEvents txtPWprobarcodeANDsn As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgPWproMEwSN As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgPWproMeNoSN As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnPWclose As System.Windows.Forms.Button
    Friend WithEvents btnPWsave As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents mnuCellNosn As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteNoSNToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCellSN As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteSNToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
