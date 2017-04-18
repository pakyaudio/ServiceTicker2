<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintSaveDatafixSendRepairFrm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgPSDF = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fix_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_get = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datesend = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ptype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.symptom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.managerd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fixrepairnote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fixaccessory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fixnote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.btnPSDFprint = New System.Windows.Forms.Button()
        Me.btnPSDFrefresh = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgPSDF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 28)
        Me.Panel1.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(224, 1)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(48, 23)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ค้นหา"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(43, 3)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(175, 20)
        Me.txtSearch.TabIndex = 0
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
        'btnHelp
        '
        Me.btnHelp.Image = Global.ServiceTicker.My.Resources.Resources._109_AllAnnotations_Help_16x16_72
        Me.btnHelp.IsLink = True
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(16, 17)
        Me.btnHelp.ToolTipText = "Help"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgPSDF)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 481)
        Me.Panel2.TabIndex = 2
        '
        'dgPSDF
        '
        Me.dgPSDF.AllowUserToAddRows = False
        Me.dgPSDF.AllowUserToDeleteRows = False
        Me.dgPSDF.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgPSDF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPSDF.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.fix_id, Me.date_get, Me.datesend, Me.customer_id, Me.customer_name, Me.customer_tel, Me.sn, Me.ptype, Me.pname, Me.model, Me.color, Me.symptom, Me.managerd, Me.fixrepairnote, Me.fixaccessory, Me.employee, Me.fixnote, Me.status})
        Me.dgPSDF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPSDF.Location = New System.Drawing.Point(0, 0)
        Me.dgPSDF.MultiSelect = False
        Me.dgPSDF.Name = "dgPSDF"
        Me.dgPSDF.RowHeadersVisible = False
        Me.dgPSDF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPSDF.Size = New System.Drawing.Size(784, 481)
        Me.dgPSDF.TabIndex = 0
        '
        'no
        '
        Me.no.HeaderText = "#"
        Me.no.Name = "no"
        Me.no.Width = 30
        '
        'fix_id
        '
        Me.fix_id.HeaderText = "หมายเลขใบซ่อม"
        Me.fix_id.Name = "fix_id"
        Me.fix_id.Width = 120
        '
        'date_get
        '
        Me.date_get.HeaderText = "วันที่รับ"
        Me.date_get.Name = "date_get"
        Me.date_get.ToolTipText = "วันทีรับสินค้าเข้าระบบ"
        '
        'datesend
        '
        Me.datesend.HeaderText = "วันที่นัดคืน"
        Me.datesend.Name = "datesend"
        Me.datesend.ToolTipText = "วันที่นัดคืนสินค้า"
        '
        'customer_id
        '
        Me.customer_id.HeaderText = "รหัสสมาชิก"
        Me.customer_id.Name = "customer_id"
        '
        'customer_name
        '
        Me.customer_name.HeaderText = "ชื่อลูกค้า"
        Me.customer_name.Name = "customer_name"
        '
        'customer_tel
        '
        Me.customer_tel.HeaderText = "เบอร์โทร"
        Me.customer_tel.Name = "customer_tel"
        '
        'sn
        '
        Me.sn.HeaderText = "SN"
        Me.sn.Name = "sn"
        '
        'ptype
        '
        Me.ptype.HeaderText = "ประเภท"
        Me.ptype.Name = "ptype"
        '
        'pname
        '
        Me.pname.HeaderText = "ยี่ห้อ"
        Me.pname.Name = "pname"
        '
        'model
        '
        Me.model.HeaderText = "รุ่น"
        Me.model.Name = "model"
        '
        'color
        '
        Me.color.HeaderText = "สี"
        Me.color.Name = "color"
        '
        'symptom
        '
        Me.symptom.HeaderText = "อาการเสีย"
        Me.symptom.Name = "symptom"
        Me.symptom.Width = 150
        '
        'managerd
        '
        Me.managerd.HeaderText = "จัดการข้อมูล"
        Me.managerd.Name = "managerd"
        '
        'fixrepairnote
        '
        Me.fixrepairnote.HeaderText = "เพิ่มเติม"
        Me.fixrepairnote.Name = "fixrepairnote"
        '
        'fixaccessory
        '
        Me.fixaccessory.HeaderText = "อุปกรณ์ที่นำมาด้วย"
        Me.fixaccessory.Name = "fixaccessory"
        Me.fixaccessory.Width = 150
        '
        'employee
        '
        Me.employee.HeaderText = "พนักงาน"
        Me.employee.Name = "employee"
        '
        'fixnote
        '
        Me.fixnote.HeaderText = "หมายเหตุ"
        Me.fixnote.Name = "fixnote"
        '
        'status
        '
        Me.status.HeaderText = "สถานะ"
        Me.status.Name = "status"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.NumericUpDown1)
        Me.Panel3.Controls.Add(Me.btnPSDFprint)
        Me.Panel3.Controls.Add(Me.btnPSDFrefresh)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 509)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(784, 30)
        Me.Panel3.TabIndex = 3
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDown1.Location = New System.Drawing.Point(3, 7)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(76, 20)
        Me.NumericUpDown1.TabIndex = 0
        Me.NumericUpDown1.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'btnPSDFprint
        '
        Me.btnPSDFprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPSDFprint.Location = New System.Drawing.Point(687, 4)
        Me.btnPSDFprint.Name = "btnPSDFprint"
        Me.btnPSDFprint.Size = New System.Drawing.Size(94, 23)
        Me.btnPSDFprint.TabIndex = 2
        Me.btnPSDFprint.Text = "พิมพ์"
        Me.btnPSDFprint.UseVisualStyleBackColor = True
        '
        'btnPSDFrefresh
        '
        Me.btnPSDFrefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPSDFrefresh.Location = New System.Drawing.Point(85, 4)
        Me.btnPSDFrefresh.Name = "btnPSDFrefresh"
        Me.btnPSDFrefresh.Size = New System.Drawing.Size(94, 23)
        Me.btnPSDFrefresh.TabIndex = 1
        Me.btnPSDFrefresh.Text = "Refresh"
        Me.btnPSDFrefresh.UseVisualStyleBackColor = True
        '
        'PrintSaveDatafixSendRepairFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "PrintSaveDatafixSendRepairFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "พิมพ์ใบรับซ่อม/ใบส่งคืนย้อมหลัง"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgPSDF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgPSDF As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fix_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_get As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datesend As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ptype As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents model As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents color As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents symptom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents managerd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fixrepairnote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fixaccessory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fixnote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnPSDFprint As System.Windows.Forms.Button
    Friend WithEvents btnPSDFrefresh As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
