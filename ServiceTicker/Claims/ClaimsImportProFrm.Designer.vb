<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaimsImportProFrm
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCIPsearchSN = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgCIP = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.claims_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.old_sn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.new_sn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.test = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.symptom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.accessory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgCIP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.btnHelp})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 439)
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtCIPsearchSN)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 409)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 30)
        Me.Panel2.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(291, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(490, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "รายการสินค้าเคลมที่ทดสอบเสร็จแล้ว กรุณาใส่หมายเลข SN ในช่องเพื่อจัดการสินค้าเคลมไ" & _
    "ปยังส่วนต่าง ๆ "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "SN"
        '
        'txtCIPsearchSN
        '
        Me.txtCIPsearchSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCIPsearchSN.Location = New System.Drawing.Point(31, 3)
        Me.txtCIPsearchSN.Name = "txtCIPsearchSN"
        Me.txtCIPsearchSN.Size = New System.Drawing.Size(152, 22)
        Me.txtCIPsearchSN.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgCIP)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(784, 409)
        Me.Panel3.TabIndex = 3
        '
        'dgCIP
        '
        Me.dgCIP.AllowUserToAddRows = False
        Me.dgCIP.AllowUserToDeleteRows = False
        Me.dgCIP.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCIP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.claims_id, Me.customer_id, Me.old_sn, Me.new_sn, Me.test, Me.code_pro, Me.name_pro, Me.symptom, Me.accessory})
        Me.dgCIP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCIP.Location = New System.Drawing.Point(0, 0)
        Me.dgCIP.MultiSelect = False
        Me.dgCIP.Name = "dgCIP"
        Me.dgCIP.ReadOnly = True
        Me.dgCIP.RowHeadersVisible = False
        Me.dgCIP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCIP.Size = New System.Drawing.Size(784, 409)
        Me.dgCIP.TabIndex = 4
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
        'customer_id
        '
        Me.customer_id.HeaderText = "รหัสลูกค้า"
        Me.customer_id.Name = "customer_id"
        Me.customer_id.ReadOnly = True
        Me.customer_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.customer_id.Width = 120
        '
        'old_sn
        '
        Me.old_sn.HeaderText = "SN เก่า"
        Me.old_sn.Name = "old_sn"
        Me.old_sn.ReadOnly = True
        Me.old_sn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.old_sn.ToolTipText = "SN เก่าของตัวสินค้า"
        Me.old_sn.Width = 70
        '
        'new_sn
        '
        Me.new_sn.HeaderText = "SN ใหม่"
        Me.new_sn.Name = "new_sn"
        Me.new_sn.ReadOnly = True
        Me.new_sn.ToolTipText = "SN ใหม่ของตัวสินค้า"
        '
        'test
        '
        Me.test.HeaderText = "ทดสอบ"
        Me.test.Name = "test"
        Me.test.ReadOnly = True
        Me.test.ToolTipText = "ผลการทดสอบ"
        '
        'code_pro
        '
        Me.code_pro.HeaderText = "รหัสสินค้า"
        Me.code_pro.Name = "code_pro"
        Me.code_pro.ReadOnly = True
        Me.code_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'name_pro
        '
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'symptom
        '
        Me.symptom.HeaderText = "อาการเสีย"
        Me.symptom.Name = "symptom"
        Me.symptom.ReadOnly = True
        Me.symptom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'accessory
        '
        Me.accessory.HeaderText = "อุปกรณ์"
        Me.accessory.Name = "accessory"
        Me.accessory.ReadOnly = True
        Me.accessory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.accessory.ToolTipText = "อุปกรณ์ที่นำมาด้วย"
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
        'ClaimsImportProFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "ClaimsImportProFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "นำสินค้าเคลมเข้าระบบ"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgCIP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCIPsearchSN As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgCIP As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents claims_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents old_sn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents new_sn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents test As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents symptom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents accessory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
