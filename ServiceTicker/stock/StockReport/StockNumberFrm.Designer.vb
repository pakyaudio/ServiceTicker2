<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockNumberFrm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbLowPro = New System.Windows.Forms.RadioButton()
        Me.rbAllpro = New System.Windows.Forms.RadioButton()
        Me.rbNoPro = New System.Windows.Forms.RadioButton()
        Me.rbMePro = New System.Windows.Forms.RadioButton()
        Me.cbbSale_company = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSNtotal_buy = New System.Windows.Forms.TextBox()
        Me.txtSNtotal_p = New System.Windows.Forms.TextBox()
        Me.txtSNtotal_costA = New System.Windows.Forms.TextBox()
        Me.btnSNprint = New System.Windows.Forms.Button()
        Me.btnSNgetsn = New System.Windows.Forms.Button()
        Me.dgSN = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bar_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.count_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgSN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.btnHelp})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
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
        Me.btnHelp.AutoToolTip = True
        Me.btnHelp.Image = Global.ServiceTicker.My.Resources.Resources._109_AllAnnotations_Help_16x16_72
        Me.btnHelp.IsLink = True
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(16, 17)
        Me.btnHelp.ToolTipText = "Help"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbLowPro)
        Me.Panel1.Controls.Add(Me.rbAllpro)
        Me.Panel1.Controls.Add(Me.rbNoPro)
        Me.Panel1.Controls.Add(Me.rbMePro)
        Me.Panel1.Controls.Add(Me.cbbSale_company)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(517, 55)
        Me.Panel1.TabIndex = 1
        '
        'rbLowPro
        '
        Me.rbLowPro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbLowPro.AutoSize = True
        Me.rbLowPro.Location = New System.Drawing.Point(94, 30)
        Me.rbLowPro.Name = "rbLowPro"
        Me.rbLowPro.Size = New System.Drawing.Size(132, 17)
        Me.rbLowPro.TabIndex = 4
        Me.rbLowPro.Text = "เฉพาะที่ต่ำกว่าจุดเตือน"
        Me.rbLowPro.UseVisualStyleBackColor = True
        '
        'rbAllpro
        '
        Me.rbAllpro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbAllpro.AutoSize = True
        Me.rbAllpro.Checked = True
        Me.rbAllpro.Location = New System.Drawing.Point(449, 30)
        Me.rbAllpro.Name = "rbAllpro"
        Me.rbAllpro.Size = New System.Drawing.Size(58, 17)
        Me.rbAllpro.TabIndex = 7
        Me.rbAllpro.TabStop = True
        Me.rbAllpro.Text = "ทั้งหมด"
        Me.rbAllpro.UseVisualStyleBackColor = True
        '
        'rbNoPro
        '
        Me.rbNoPro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbNoPro.AutoSize = True
        Me.rbNoPro.Location = New System.Drawing.Point(334, 30)
        Me.rbNoPro.Name = "rbNoPro"
        Me.rbNoPro.Size = New System.Drawing.Size(109, 17)
        Me.rbNoPro.TabIndex = 6
        Me.rbNoPro.Text = "เฉพาะที่ไม่มีสินค้า"
        Me.rbNoPro.UseVisualStyleBackColor = True
        '
        'rbMePro
        '
        Me.rbMePro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbMePro.AutoSize = True
        Me.rbMePro.Location = New System.Drawing.Point(232, 30)
        Me.rbMePro.Name = "rbMePro"
        Me.rbMePro.Size = New System.Drawing.Size(96, 17)
        Me.rbMePro.TabIndex = 5
        Me.rbMePro.Text = "เฉพาะที่มีสินค้า"
        Me.rbMePro.UseVisualStyleBackColor = True
        '
        'cbbSale_company
        '
        Me.cbbSale_company.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbSale_company.FormattingEnabled = True
        Me.cbbSale_company.Location = New System.Drawing.Point(239, 3)
        Me.cbbSale_company.Name = "cbbSale_company"
        Me.cbbSale_company.Size = New System.Drawing.Size(267, 21)
        Me.cbbSale_company.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtSNtotal_buy)
        Me.Panel2.Controls.Add(Me.txtSNtotal_p)
        Me.Panel2.Controls.Add(Me.txtSNtotal_costA)
        Me.Panel2.Controls.Add(Me.btnSNprint)
        Me.Panel2.Controls.Add(Me.btnSNgetsn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 480)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(517, 57)
        Me.Panel2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(295, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "รวมราคาขายปกติ"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(187, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "จำนวนทุนทั้งหมด"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "จำนวนสินค้าทั้งหมด"
        '
        'txtSNtotal_buy
        '
        Me.txtSNtotal_buy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSNtotal_buy.Location = New System.Drawing.Point(287, 31)
        Me.txtSNtotal_buy.Name = "txtSNtotal_buy"
        Me.txtSNtotal_buy.ReadOnly = True
        Me.txtSNtotal_buy.Size = New System.Drawing.Size(104, 20)
        Me.txtSNtotal_buy.TabIndex = 21
        Me.txtSNtotal_buy.TabStop = False
        Me.txtSNtotal_buy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSNtotal_p
        '
        Me.txtSNtotal_p.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSNtotal_p.Location = New System.Drawing.Point(67, 30)
        Me.txtSNtotal_p.Name = "txtSNtotal_p"
        Me.txtSNtotal_p.ReadOnly = True
        Me.txtSNtotal_p.Size = New System.Drawing.Size(104, 20)
        Me.txtSNtotal_p.TabIndex = 20
        Me.txtSNtotal_p.TabStop = False
        Me.txtSNtotal_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSNtotal_costA
        '
        Me.txtSNtotal_costA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSNtotal_costA.Location = New System.Drawing.Point(177, 31)
        Me.txtSNtotal_costA.Name = "txtSNtotal_costA"
        Me.txtSNtotal_costA.ReadOnly = True
        Me.txtSNtotal_costA.Size = New System.Drawing.Size(104, 20)
        Me.txtSNtotal_costA.TabIndex = 19
        Me.txtSNtotal_costA.TabStop = False
        Me.txtSNtotal_costA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSNprint
        '
        Me.btnSNprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSNprint.Enabled = False
        Me.btnSNprint.Image = Global.ServiceTicker.My.Resources.Resources.PrintStatusBar2_16x
        Me.btnSNprint.Location = New System.Drawing.Point(397, 3)
        Me.btnSNprint.Name = "btnSNprint"
        Me.btnSNprint.Size = New System.Drawing.Size(117, 23)
        Me.btnSNprint.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btnSNprint, "พิมพ์")
        Me.btnSNprint.UseVisualStyleBackColor = True
        '
        'btnSNgetsn
        '
        Me.btnSNgetsn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSNgetsn.Enabled = False
        Me.btnSNgetsn.Location = New System.Drawing.Point(397, 28)
        Me.btnSNgetsn.Name = "btnSNgetsn"
        Me.btnSNgetsn.Size = New System.Drawing.Size(117, 23)
        Me.btnSNgetsn.TabIndex = 1
        Me.btnSNgetsn.Text = "ดูรายการ SN"
        Me.btnSNgetsn.UseVisualStyleBackColor = True
        '
        'dgSN
        '
        Me.dgSN.AllowUserToAddRows = False
        Me.dgSN.AllowUserToDeleteRows = False
        Me.dgSN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.code_pro, Me.bar_code, Me.name_pro, Me.count_num, Me.sn, Me.cost, Me.buy, Me.total_cost, Me.total_buy})
        Me.dgSN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSN.Location = New System.Drawing.Point(0, 55)
        Me.dgSN.Name = "dgSN"
        Me.dgSN.ReadOnly = True
        Me.dgSN.RowHeadersVisible = False
        Me.dgSN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSN.Size = New System.Drawing.Size(517, 425)
        Me.dgSN.TabIndex = 3
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
        '
        'bar_code
        '
        Me.bar_code.HeaderText = "บาร์โค๊ต"
        Me.bar_code.Name = "bar_code"
        Me.bar_code.ReadOnly = True
        '
        'name_pro
        '
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        Me.name_pro.Width = 150
        '
        'count_num
        '
        Me.count_num.HeaderText = "จำนวนสินค้ารวม"
        Me.count_num.Name = "count_num"
        Me.count_num.ReadOnly = True
        Me.count_num.ToolTipText = "รวมจำนวนสินค้าที่มีในสต็อก"
        Me.count_num.Width = 120
        '
        'sn
        '
        Me.sn.HeaderText = "SN"
        Me.sn.Name = "sn"
        Me.sn.ReadOnly = True
        Me.sn.ToolTipText = "รวมจำนวนสินค้าแบบ SN ที่มีในระบบ"
        '
        'cost
        '
        Me.cost.HeaderText = "ทุน"
        Me.cost.Name = "cost"
        Me.cost.ReadOnly = True
        '
        'buy
        '
        Me.buy.HeaderText = "ขาย"
        Me.buy.Name = "buy"
        Me.buy.ReadOnly = True
        '
        'total_cost
        '
        Me.total_cost.HeaderText = "รวมทุน"
        Me.total_cost.Name = "total_cost"
        Me.total_cost.ReadOnly = True
        '
        'total_buy
        '
        Me.total_buy.HeaderText = "รวมขาย"
        Me.total_buy.Name = "total_buy"
        Me.total_buy.ReadOnly = True
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgSN)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(784, 539)
        Me.SplitContainer1.SplitterDistance = 261
        Me.SplitContainer1.TabIndex = 4
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(259, 537)
        Me.TreeView1.TabIndex = 0
        '
        'StockNumberFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "StockNumberFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายานยอดรวมสต็อก"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgSN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cbbSale_company As System.Windows.Forms.ComboBox
    Friend WithEvents rbLowPro As System.Windows.Forms.RadioButton
    Friend WithEvents rbAllpro As System.Windows.Forms.RadioButton
    Friend WithEvents rbNoPro As System.Windows.Forms.RadioButton
    Friend WithEvents rbMePro As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSNprint As System.Windows.Forms.Button
    Friend WithEvents btnSNgetsn As System.Windows.Forms.Button
    Friend WithEvents dgSN As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSNtotal_buy As System.Windows.Forms.TextBox
    Friend WithEvents txtSNtotal_p As System.Windows.Forms.TextBox
    Friend WithEvents txtSNtotal_costA As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bar_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents count_num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
End Class
