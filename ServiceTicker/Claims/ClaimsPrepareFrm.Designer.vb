<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaimsPrepareFrm
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCPclamCompanyID = New System.Windows.Forms.TextBox()
        Me.txtCPclaimCompanyName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCPsearchSN = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCPsave = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCPtotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCPlastSN = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgCP = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.claims_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cus_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bar_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DelContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DelToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgCP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DelContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtCPclamCompanyID)
        Me.Panel1.Controls.Add(Me.txtCPclaimCompanyName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtCPsearchSN)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 27)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(369, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "บริษัทที่ส่งเคลม"
        '
        'txtCPclamCompanyID
        '
        Me.txtCPclamCompanyID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCPclamCompanyID.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtCPclamCompanyID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtCPclamCompanyID.Location = New System.Drawing.Point(453, 3)
        Me.txtCPclamCompanyID.Name = "txtCPclamCompanyID"
        Me.txtCPclamCompanyID.ReadOnly = True
        Me.txtCPclamCompanyID.Size = New System.Drawing.Size(113, 20)
        Me.txtCPclamCompanyID.TabIndex = 15
        Me.txtCPclamCompanyID.TabStop = False
        '
        'txtCPclaimCompanyName
        '
        Me.txtCPclaimCompanyName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCPclaimCompanyName.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtCPclaimCompanyName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtCPclaimCompanyName.Location = New System.Drawing.Point(572, 3)
        Me.txtCPclaimCompanyName.Name = "txtCPclaimCompanyName"
        Me.txtCPclaimCompanyName.ReadOnly = True
        Me.txtCPclaimCompanyName.Size = New System.Drawing.Size(209, 20)
        Me.txtCPclaimCompanyName.TabIndex = 14
        Me.txtCPclaimCompanyName.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "SN"
        '
        'txtCPsearchSN
        '
        Me.txtCPsearchSN.Location = New System.Drawing.Point(33, 3)
        Me.txtCPsearchSN.Name = "txtCPsearchSN"
        Me.txtCPsearchSN.Size = New System.Drawing.Size(142, 20)
        Me.txtCPsearchSN.TabIndex = 0
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
        Me.Panel2.Controls.Add(Me.btnCPsave)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtCPtotal)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtCPlastSN)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 501)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 38)
        Me.Panel2.TabIndex = 2
        '
        'btnCPsave
        '
        Me.btnCPsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCPsave.Enabled = False
        Me.btnCPsave.Location = New System.Drawing.Point(620, 3)
        Me.btnCPsave.Name = "btnCPsave"
        Me.btnCPsave.Size = New System.Drawing.Size(161, 31)
        Me.btnCPsave.TabIndex = 13
        Me.btnCPsave.Text = "บันทึก"
        Me.btnCPsave.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "จำนวนชิ้น"
        '
        'txtCPtotal
        '
        Me.txtCPtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCPtotal.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtCPtotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtCPtotal.Location = New System.Drawing.Point(66, 15)
        Me.txtCPtotal.Name = "txtCPtotal"
        Me.txtCPtotal.ReadOnly = True
        Me.txtCPtotal.Size = New System.Drawing.Size(130, 20)
        Me.txtCPtotal.TabIndex = 10
        Me.txtCPtotal.TabStop = False
        Me.txtCPtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(216, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "SN ล่าสุด"
        '
        'txtCPlastSN
        '
        Me.txtCPlastSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCPlastSN.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtCPlastSN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtCPlastSN.Location = New System.Drawing.Point(271, 15)
        Me.txtCPlastSN.Name = "txtCPlastSN"
        Me.txtCPlastSN.ReadOnly = True
        Me.txtCPlastSN.Size = New System.Drawing.Size(149, 20)
        Me.txtCPlastSN.TabIndex = 9
        Me.txtCPlastSN.TabStop = False
        Me.txtCPlastSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgCP)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 27)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(784, 474)
        Me.Panel3.TabIndex = 3
        '
        'dgCP
        '
        Me.dgCP.AllowUserToAddRows = False
        Me.dgCP.AllowUserToDeleteRows = False
        Me.dgCP.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.claims_id, Me.cus_id, Me.code_pro, Me.bar_code, Me.sn, Me.name_pro, Me.type, Me.unit, Me.datetime_save})
        Me.dgCP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCP.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgCP.Location = New System.Drawing.Point(0, 0)
        Me.dgCP.Name = "dgCP"
        Me.dgCP.ReadOnly = True
        Me.dgCP.RowHeadersVisible = False
        Me.dgCP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCP.Size = New System.Drawing.Size(784, 474)
        Me.dgCP.TabIndex = 3
        Me.dgCP.TabStop = False
        '
        'no
        '
        Me.no.HeaderText = "#"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'sn
        '
        Me.sn.HeaderText = "SN"
        Me.sn.Name = "sn"
        Me.sn.ReadOnly = True
        Me.sn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        Me.DelToolStripMenu.Text = "ลบข้อมูล"
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
        'ClaimsPrepareFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ClaimsPrepareFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เตรียมสินค้าเคลม"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgCP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DelContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCPclamCompanyID As System.Windows.Forms.TextBox
    Friend WithEvents txtCPclaimCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCPsearchSN As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnCPsave As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCPtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCPlastSN As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgCP As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents claims_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cus_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bar_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DelContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DelToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
