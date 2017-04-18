<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaimsreceiveGroupFrm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCRGsearchSN = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgCRG = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.claims_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cus_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bar_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.oldsn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.newsn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCRGtotal = New System.Windows.Forms.TextBox()
        Me.txtCRGlastSN = New System.Windows.Forms.TextBox()
        Me.btnCRGsave = New System.Windows.Forms.Button()
        Me.DelContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DelToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgCRG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.DelContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtCRGsearchSN)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 27)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.ServiceTicker.My.Resources.Resources.F12_Search_28x
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(179, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 24)
        Me.Button1.TabIndex = 54
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "SN"
        '
        'txtCRGsearchSN
        '
        Me.txtCRGsearchSN.Location = New System.Drawing.Point(31, 3)
        Me.txtCRGsearchSN.Name = "txtCRGsearchSN"
        Me.txtCRGsearchSN.Size = New System.Drawing.Size(142, 20)
        Me.txtCRGsearchSN.TabIndex = 52
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgCRG)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 475)
        Me.Panel2.TabIndex = 2
        '
        'dgCRG
        '
        Me.dgCRG.AllowUserToAddRows = False
        Me.dgCRG.AllowUserToDeleteRows = False
        Me.dgCRG.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCRG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCRG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.claims_id, Me.cus_id, Me.code_pro, Me.bar_code, Me.oldsn, Me.newsn, Me.name_pro, Me.type, Me.unit, Me.datetime_save})
        Me.dgCRG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCRG.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgCRG.Location = New System.Drawing.Point(0, 0)
        Me.dgCRG.Name = "dgCRG"
        Me.dgCRG.ReadOnly = True
        Me.dgCRG.RowHeadersVisible = False
        Me.dgCRG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCRG.Size = New System.Drawing.Size(784, 475)
        Me.dgCRG.TabIndex = 3
        '
        'no
        '
        Me.no.HeaderText = "#"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.ToolTipText = "ลำดับ"
        Me.no.Width = 30
        '
        'claims_id
        '
        Me.claims_id.HeaderText = "รหัสเคลม"
        Me.claims_id.Name = "claims_id"
        Me.claims_id.ReadOnly = True
        Me.claims_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.claims_id.Width = 120
        '
        'cus_id
        '
        Me.cus_id.HeaderText = "รหัสลูกค้า"
        Me.cus_id.Name = "cus_id"
        Me.cus_id.ReadOnly = True
        Me.cus_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'code_pro
        '
        Me.code_pro.HeaderText = "รหัสสินค้า"
        Me.code_pro.Name = "code_pro"
        Me.code_pro.ReadOnly = True
        Me.code_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'bar_code
        '
        Me.bar_code.HeaderText = "บาร์โค๊ต"
        Me.bar_code.Name = "bar_code"
        Me.bar_code.ReadOnly = True
        Me.bar_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'oldsn
        '
        Me.oldsn.HeaderText = "SN(เก่า)"
        Me.oldsn.Name = "oldsn"
        Me.oldsn.ReadOnly = True
        Me.oldsn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.oldsn.ToolTipText = "sn สินค้าเก่า"
        '
        'newsn
        '
        Me.newsn.HeaderText = "SN(ใหม่)"
        Me.newsn.Name = "newsn"
        Me.newsn.ReadOnly = True
        '
        'name_pro
        '
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro.Width = 200
        '
        'type
        '
        Me.type.HeaderText = "ประเภท"
        Me.type.Name = "type"
        Me.type.ReadOnly = True
        Me.type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.type.Width = 80
        '
        'unit
        '
        Me.unit.HeaderText = "หน่วย"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        Me.unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.unit.Width = 70
        '
        'datetime_save
        '
        Me.datetime_save.HeaderText = "วันที่"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        Me.datetime_save.ToolTipText = "วันที่รับเคลม"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtCRGtotal)
        Me.Panel3.Controls.Add(Me.txtCRGlastSN)
        Me.Panel3.Controls.Add(Me.btnCRGsave)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 502)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(784, 37)
        Me.Panel3.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "จำนวนชิ้น"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(213, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "SN ล่าสุด"
        '
        'txtCRGtotal
        '
        Me.txtCRGtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCRGtotal.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtCRGtotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtCRGtotal.Location = New System.Drawing.Point(63, 14)
        Me.txtCRGtotal.Name = "txtCRGtotal"
        Me.txtCRGtotal.ReadOnly = True
        Me.txtCRGtotal.Size = New System.Drawing.Size(130, 20)
        Me.txtCRGtotal.TabIndex = 11
        Me.txtCRGtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCRGlastSN
        '
        Me.txtCRGlastSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCRGlastSN.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtCRGlastSN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtCRGlastSN.Location = New System.Drawing.Point(268, 14)
        Me.txtCRGlastSN.Name = "txtCRGlastSN"
        Me.txtCRGlastSN.ReadOnly = True
        Me.txtCRGlastSN.Size = New System.Drawing.Size(149, 20)
        Me.txtCRGlastSN.TabIndex = 10
        Me.txtCRGlastSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCRGsave
        '
        Me.btnCRGsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCRGsave.Location = New System.Drawing.Point(620, 3)
        Me.btnCRGsave.Name = "btnCRGsave"
        Me.btnCRGsave.Size = New System.Drawing.Size(161, 31)
        Me.btnCRGsave.TabIndex = 9
        Me.btnCRGsave.Text = "บันทึก"
        Me.btnCRGsave.UseVisualStyleBackColor = True
        '
        'DelContextMenu
        '
        Me.DelContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DelToolStripMenu, Me.ClearToolStripMenu})
        Me.DelContextMenu.Name = "DelContextMenu"
        Me.DelContextMenu.Size = New System.Drawing.Size(147, 48)
        '
        'DelToolStripMenu
        '
        Me.DelToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.action_Cancel_16xLG
        Me.DelToolStripMenu.Name = "DelToolStripMenu"
        Me.DelToolStripMenu.Size = New System.Drawing.Size(146, 22)
        Me.DelToolStripMenu.Text = "ลบข้อมูลนี้"
        '
        'ClearToolStripMenu
        '
        Me.ClearToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources._009_HighPriority_16x16_72
        Me.ClearToolStripMenu.Name = "ClearToolStripMenu"
        Me.ClearToolStripMenu.Size = New System.Drawing.Size(146, 22)
        Me.ClearToolStripMenu.Text = "ลบข้อมูลทั้งหมด"
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
        'ClaimsreceiveGroupFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "ClaimsreceiveGroupFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รับเข้าสินค้าเคลม"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgCRG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.DelContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCRGsearchSN As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgCRG As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCRGtotal As System.Windows.Forms.TextBox
    Friend WithEvents txtCRGlastSN As System.Windows.Forms.TextBox
    Friend WithEvents btnCRGsave As System.Windows.Forms.Button
    Friend WithEvents DelContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DelToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents claims_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cus_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bar_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents oldsn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents newsn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
