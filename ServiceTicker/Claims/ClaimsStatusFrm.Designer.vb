<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaimsStatusFrm
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCSeditteltocus = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearchStatus = New System.Windows.Forms.TextBox()
        Me.cbbCSclaimsStatus = New System.Windows.Forms.ComboBox()
        Me.btnCSshowAll = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgCS = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.claims_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.symptom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tel_to_cus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.note2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgCS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.btnHelp})
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnCSeditteltocus)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 512)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 27)
        Me.Panel1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(3, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(382, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "* กรอกหมายเลข SN ในช่องด้านบน หรือ ดับเบิ้ลคลิ๊กเพื่อเปลี่ยนแปลงสถานะเคลม"
        '
        'btnCSeditteltocus
        '
        Me.btnCSeditteltocus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCSeditteltocus.Enabled = False
        Me.btnCSeditteltocus.Location = New System.Drawing.Point(584, 3)
        Me.btnCSeditteltocus.Name = "btnCSeditteltocus"
        Me.btnCSeditteltocus.Size = New System.Drawing.Size(197, 21)
        Me.btnCSeditteltocus.TabIndex = 10
        Me.btnCSeditteltocus.Text = "แก้ไขสถานะการโทรแจ้งลูกค้า"
        Me.btnCSeditteltocus.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtSearchStatus)
        Me.Panel2.Controls.Add(Me.cbbCSclaimsStatus)
        Me.Panel2.Controls.Add(Me.btnCSshowAll)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 30)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "SN"
        '
        'txtSearchStatus
        '
        Me.txtSearchStatus.Location = New System.Drawing.Point(31, 5)
        Me.txtSearchStatus.Name = "txtSearchStatus"
        Me.txtSearchStatus.Size = New System.Drawing.Size(149, 20)
        Me.txtSearchStatus.TabIndex = 0
        '
        'cbbCSclaimsStatus
        '
        Me.cbbCSclaimsStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbCSclaimsStatus.FormattingEnabled = True
        Me.cbbCSclaimsStatus.Location = New System.Drawing.Point(594, 5)
        Me.cbbCSclaimsStatus.Name = "cbbCSclaimsStatus"
        Me.cbbCSclaimsStatus.Size = New System.Drawing.Size(187, 21)
        Me.cbbCSclaimsStatus.TabIndex = 12
        Me.cbbCSclaimsStatus.TabStop = False
        '
        'btnCSshowAll
        '
        Me.btnCSshowAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCSshowAll.Location = New System.Drawing.Point(489, 5)
        Me.btnCSshowAll.Name = "btnCSshowAll"
        Me.btnCSshowAll.Size = New System.Drawing.Size(99, 21)
        Me.btnCSshowAll.TabIndex = 11
        Me.btnCSshowAll.TabStop = False
        Me.btnCSshowAll.Text = "แสดงทั้งหมด"
        Me.btnCSshowAll.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgCS)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(784, 482)
        Me.Panel3.TabIndex = 3
        '
        'dgCS
        '
        Me.dgCS.AllowUserToAddRows = False
        Me.dgCS.AllowUserToDeleteRows = False
        Me.dgCS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.claims_id, Me.customer_id, Me.customer_name, Me.SN, Me.name_pro, Me.symptom, Me.status, Me.tel_to_cus, Me.datetime_save, Me.note2, Me.note})
        Me.dgCS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCS.Location = New System.Drawing.Point(0, 0)
        Me.dgCS.Name = "dgCS"
        Me.dgCS.ReadOnly = True
        Me.dgCS.RowHeadersVisible = False
        Me.dgCS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCS.Size = New System.Drawing.Size(784, 482)
        Me.dgCS.TabIndex = 6
        Me.dgCS.TabStop = False
        '
        'No
        '
        Me.No.HeaderText = "#"
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.No.ToolTipText = "ลำดับ"
        Me.No.Width = 30
        '
        'claims_id
        '
        Me.claims_id.HeaderText = "หมายเลขเคลม"
        Me.claims_id.Name = "claims_id"
        Me.claims_id.ReadOnly = True
        Me.claims_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.claims_id.ToolTipText = "หมายเลขเคลม"
        Me.claims_id.Width = 130
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
        Me.customer_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.customer_name.ToolTipText = "ชื่อลูกค้า"
        '
        'SN
        '
        Me.SN.HeaderText = "SN"
        Me.SN.Name = "SN"
        Me.SN.ReadOnly = True
        Me.SN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SN.ToolTipText = "Serial Number"
        '
        'name_pro
        '
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro.ToolTipText = "ชื่อสินค้า"
        Me.name_pro.Width = 150
        '
        'symptom
        '
        Me.symptom.HeaderText = "อาการเสีย"
        Me.symptom.Name = "symptom"
        Me.symptom.ReadOnly = True
        Me.symptom.ToolTipText = "อาการเสีย"
        Me.symptom.Width = 120
        '
        'status
        '
        Me.status.HeaderText = "สถานะ"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.status.ToolTipText = "สถานะ"
        Me.status.Width = 80
        '
        'tel_to_cus
        '
        Me.tel_to_cus.HeaderText = "โทรแจ้ง"
        Me.tel_to_cus.Name = "tel_to_cus"
        Me.tel_to_cus.ReadOnly = True
        Me.tel_to_cus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.tel_to_cus.ToolTipText = "การโทรแจ้งลูกค้า"
        Me.tel_to_cus.Width = 80
        '
        'datetime_save
        '
        Me.datetime_save.HeaderText = "วันที่นำเข้าระบบ"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        Me.datetime_save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.datetime_save.ToolTipText = "วันที่นำเข้าระบบ"
        Me.datetime_save.Width = 130
        '
        'note2
        '
        Me.note2.HeaderText = "ส่งไป"
        Me.note2.Name = "note2"
        Me.note2.ReadOnly = True
        '
        'note
        '
        Me.note.HeaderText = "หมายเหตุ"
        Me.note.Name = "note"
        Me.note.ReadOnly = True
        Me.note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.note.ToolTipText = "หมายเหตุ"
        Me.note.Width = 80
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
        'ClaimsStatusFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "ClaimsStatusFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ติดตามสถานะเคลม"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgCS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblEmployee As ToolStripStatusLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCSeditteltocus As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cbbCSclaimsStatus As ComboBox
    Friend WithEvents btnCSshowAll As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgCS As DataGridView
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents claims_id As DataGridViewTextBoxColumn
    Friend WithEvents customer_id As DataGridViewTextBoxColumn
    Friend WithEvents customer_name As DataGridViewTextBoxColumn
    Friend WithEvents SN As DataGridViewTextBoxColumn
    Friend WithEvents name_pro As DataGridViewTextBoxColumn
    Friend WithEvents symptom As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents tel_to_cus As DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As DataGridViewTextBoxColumn
    Friend WithEvents note2 As DataGridViewTextBoxColumn
    Friend WithEvents note As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearchStatus As System.Windows.Forms.TextBox
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
