<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DocumentManagerFrm
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
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSaleID = New System.Windows.Forms.Label()
        Me.cbbYear = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgDM = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fix_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cash_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_all = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cash_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cash_detail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.AddPicContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddPicToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelPicContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ZoomToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDocToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelPicToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgDM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddPicContextMenu.SuspendLayout()
        Me.DelPicContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.btnHelp, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblEmployee
        '
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(30, 17)
        Me.lblEmployee.Text = "User"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Image = Global.ServiceTicker.My.Resources.Resources._109_AllAnnotations_Info_16x16_72
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(230, 17)
        Me.ToolStripStatusLabel1.Text = "ดับเบิ้ลคลิ๊กตารางหรือคลิ๊กขวาที่เอกสารด้านขวา"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblSaleID)
        Me.Panel1.Controls.Add(Me.cbbYear)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 33)
        Me.Panel1.TabIndex = 1
        '
        'lblSaleID
        '
        Me.lblSaleID.AutoSize = True
        Me.lblSaleID.Location = New System.Drawing.Point(513, 18)
        Me.lblSaleID.Name = "lblSaleID"
        Me.lblSaleID.Size = New System.Drawing.Size(42, 13)
        Me.lblSaleID.TabIndex = 5
        Me.lblSaleID.Text = "Sale_id"
        '
        'cbbYear
        '
        Me.cbbYear.FormattingEnabled = True
        Me.cbbYear.Location = New System.Drawing.Point(3, 9)
        Me.cbbYear.Name = "cbbYear"
        Me.cbbYear.Size = New System.Drawing.Size(121, 21)
        Me.cbbYear.TabIndex = 4
        '
        'btnSearch
        '
        Me.btnSearch.Image = Global.ServiceTicker.My.Resources.Resources.ZoomNeutral_16xlG
        Me.btnSearch.Location = New System.Drawing.Point(130, 7)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(29, 23)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 33)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgDM)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ListView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(784, 506)
        Me.SplitContainer1.SplitterDistance = 511
        Me.SplitContainer1.TabIndex = 2
        '
        'dgDM
        '
        Me.dgDM.AllowUserToAddRows = False
        Me.dgDM.AllowUserToDeleteRows = False
        Me.dgDM.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.sale_id, Me.fix_id, Me.cash_id, Me.customer_id, Me.customer_name, Me.total_all, Me.datetime_save, Me.cash_status, Me.cash_detail, Me.employee})
        Me.dgDM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDM.Location = New System.Drawing.Point(0, 0)
        Me.dgDM.Name = "dgDM"
        Me.dgDM.ReadOnly = True
        Me.dgDM.RowHeadersVisible = False
        Me.dgDM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDM.Size = New System.Drawing.Size(509, 504)
        Me.dgDM.TabIndex = 0
        '
        'no
        '
        Me.no.FillWeight = 30.0!
        Me.no.HeaderText = "#"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 30
        '
        'sale_id
        '
        Me.sale_id.HeaderText = "รหัสขาย"
        Me.sale_id.Name = "sale_id"
        Me.sale_id.ReadOnly = True
        '
        'fix_id
        '
        Me.fix_id.HeaderText = "รหัสซ่อม"
        Me.fix_id.Name = "fix_id"
        Me.fix_id.ReadOnly = True
        '
        'cash_id
        '
        Me.cash_id.HeaderText = "รหัสชำระเงิน"
        Me.cash_id.Name = "cash_id"
        Me.cash_id.ReadOnly = True
        '
        'customer_id
        '
        Me.customer_id.HeaderText = "รหัสลูกค้า"
        Me.customer_id.Name = "customer_id"
        Me.customer_id.ReadOnly = True
        '
        'customer_name
        '
        Me.customer_name.HeaderText = "ชื่อลูกค้า"
        Me.customer_name.Name = "customer_name"
        Me.customer_name.ReadOnly = True
        '
        'total_all
        '
        Me.total_all.HeaderText = "รวมราคา"
        Me.total_all.Name = "total_all"
        Me.total_all.ReadOnly = True
        '
        'datetime_save
        '
        Me.datetime_save.HeaderText = "วันที่"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        '
        'cash_status
        '
        Me.cash_status.HeaderText = "สถานะ"
        Me.cash_status.Name = "cash_status"
        Me.cash_status.ReadOnly = True
        '
        'cash_detail
        '
        Me.cash_detail.HeaderText = "ชำระเป็น"
        Me.cash_detail.Name = "cash_detail"
        Me.cash_detail.ReadOnly = True
        '
        'employee
        '
        Me.employee.HeaderText = "พนักงาน"
        Me.employee.Name = "employee"
        Me.employee.ReadOnly = True
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Enabled = False
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(267, 504)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'AddPicContextMenu
        '
        Me.AddPicContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddPicToolStripMenu})
        Me.AddPicContextMenu.Name = "AddPicContextMenu"
        Me.AddPicContextMenu.Size = New System.Drawing.Size(125, 26)
        '
        'AddPicToolStripMenu
        '
        Me.AddPicToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.add
        Me.AddPicToolStripMenu.Name = "AddPicToolStripMenu"
        Me.AddPicToolStripMenu.Size = New System.Drawing.Size(124, 22)
        Me.AddPicToolStripMenu.Text = "เพิ่มเอกสาร"
        '
        'DelPicContextMenu
        '
        Me.DelPicContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZoomToolStripMenu, Me.PrintDocToolStripMenu, Me.DelPicToolStripMenu})
        Me.DelPicContextMenu.Name = "DelPicContextMenu"
        Me.DelPicContextMenu.Size = New System.Drawing.Size(120, 70)
        '
        'ZoomToolStripMenu
        '
        Me.ZoomToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.Zoom_5442
        Me.ZoomToolStripMenu.Name = "ZoomToolStripMenu"
        Me.ZoomToolStripMenu.Size = New System.Drawing.Size(119, 22)
        Me.ZoomToolStripMenu.Text = "ขยาย"
        '
        'PrintDocToolStripMenu
        '
        Me.PrintDocToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.PrintStatusBar2_16x
        Me.PrintDocToolStripMenu.Name = "PrintDocToolStripMenu"
        Me.PrintDocToolStripMenu.Size = New System.Drawing.Size(119, 22)
        Me.PrintDocToolStripMenu.Text = "พิมพ์"
        '
        'DelPicToolStripMenu
        '
        Me.DelPicToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.VSO_RecycleBin_16x
        Me.DelPicToolStripMenu.Name = "DelPicToolStripMenu"
        Me.DelPicToolStripMenu.Size = New System.Drawing.Size(119, 22)
        Me.DelPicToolStripMenu.Text = "ลบเอกสาร"
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
        'DocumentManagerFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "DocumentManagerFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบจัดเก็บเอกสาร"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgDM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddPicContextMenu.ResumeLayout(False)
        Me.DelPicContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cbbYear As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgDM As System.Windows.Forms.DataGridView
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fix_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cash_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_all As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cash_status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cash_detail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AddPicContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddPicToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DelPicContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DelPicToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblSaleID As System.Windows.Forms.Label
    Friend WithEvents ZoomToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintDocToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
