<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VarunteeCheckFrm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtVCdetail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVCsearch = New System.Windows.Forms.Button()
        Me.txtVCsearch = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgVC = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fix_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.symptom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fixrepairnote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fixaccessory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.varuntee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_repair = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datecom_repair = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cproduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCHCviewpro = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgVC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtVCdetail)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnVCsearch)
        Me.Panel1.Controls.Add(Me.txtVCsearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 74)
        Me.Panel1.TabIndex = 0
        '
        'txtVCdetail
        '
        Me.txtVCdetail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVCdetail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVCdetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVCdetail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtVCdetail.Location = New System.Drawing.Point(175, 3)
        Me.txtVCdetail.Multiline = True
        Me.txtVCdetail.Name = "txtVCdetail"
        Me.txtVCdetail.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtVCdetail.Size = New System.Drawing.Size(606, 67)
        Me.txtVCdetail.TabIndex = 9
        Me.txtVCdetail.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ค้นหาจาก SN, ชื่อลูกค้า"
        '
        'btnVCsearch
        '
        Me.btnVCsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVCsearch.Image = Global.ServiceTicker.My.Resources.Resources.ZoomNeutral_16xlG
        Me.btnVCsearch.Location = New System.Drawing.Point(136, 17)
        Me.btnVCsearch.Name = "btnVCsearch"
        Me.btnVCsearch.Size = New System.Drawing.Size(33, 27)
        Me.btnVCsearch.TabIndex = 7
        Me.btnVCsearch.UseVisualStyleBackColor = True
        '
        'txtVCsearch
        '
        Me.txtVCsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVCsearch.Location = New System.Drawing.Point(3, 19)
        Me.txtVCsearch.Name = "txtVCsearch"
        Me.txtVCsearch.Size = New System.Drawing.Size(127, 22)
        Me.txtVCsearch.TabIndex = 6
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
        Me.Panel2.Controls.Add(Me.dgVC)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 440)
        Me.Panel2.TabIndex = 2
        '
        'dgVC
        '
        Me.dgVC.AllowUserToAddRows = False
        Me.dgVC.AllowUserToDeleteRows = False
        Me.dgVC.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgVC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.fix_id, Me.customer_id, Me.sn, Me.symptom, Me.fixrepairnote, Me.fixaccessory, Me.varuntee, Me.status, Me.user_repair, Me.datecom_repair, Me.cproduct})
        Me.dgVC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgVC.Location = New System.Drawing.Point(0, 0)
        Me.dgVC.Name = "dgVC"
        Me.dgVC.ReadOnly = True
        Me.dgVC.RowHeadersVisible = False
        Me.dgVC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVC.Size = New System.Drawing.Size(784, 440)
        Me.dgVC.TabIndex = 4
        '
        'no
        '
        Me.no.HeaderText = "#"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.Width = 30
        '
        'fix_id
        '
        Me.fix_id.HeaderText = "เลขที่ใบซ่อม"
        Me.fix_id.Name = "fix_id"
        Me.fix_id.ReadOnly = True
        Me.fix_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fix_id.Width = 120
        '
        'customer_id
        '
        Me.customer_id.HeaderText = "รหัสลูกค้า"
        Me.customer_id.Name = "customer_id"
        Me.customer_id.ReadOnly = True
        Me.customer_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'sn
        '
        Me.sn.HeaderText = "SN"
        Me.sn.Name = "sn"
        Me.sn.ReadOnly = True
        Me.sn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'symptom
        '
        Me.symptom.HeaderText = "อาการเสีย"
        Me.symptom.Name = "symptom"
        Me.symptom.ReadOnly = True
        '
        'fixrepairnote
        '
        Me.fixrepairnote.HeaderText = "การซ่อม"
        Me.fixrepairnote.Name = "fixrepairnote"
        Me.fixrepairnote.ReadOnly = True
        Me.fixrepairnote.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'fixaccessory
        '
        Me.fixaccessory.HeaderText = "อุปกรณ์ที่นำมาด้วย"
        Me.fixaccessory.Name = "fixaccessory"
        Me.fixaccessory.ReadOnly = True
        Me.fixaccessory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'varuntee
        '
        Me.varuntee.HeaderText = "ประกัน"
        Me.varuntee.Name = "varuntee"
        Me.varuntee.ReadOnly = True
        Me.varuntee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'status
        '
        Me.status.HeaderText = "สถานะ"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'user_repair
        '
        Me.user_repair.HeaderText = "ผู้ซ่อม"
        Me.user_repair.Name = "user_repair"
        Me.user_repair.ReadOnly = True
        Me.user_repair.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'datecom_repair
        '
        DataGridViewCellStyle1.Format = "G"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.datecom_repair.DefaultCellStyle = DataGridViewCellStyle1
        Me.datecom_repair.HeaderText = "วันที่ซ่อมเสร็จ"
        Me.datecom_repair.Name = "datecom_repair"
        Me.datecom_repair.ReadOnly = True
        Me.datecom_repair.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'cproduct
        '
        Me.cproduct.HeaderText = "รายการสินค้า"
        Me.cproduct.Name = "cproduct"
        Me.cproduct.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnCHCviewpro)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 514)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(784, 25)
        Me.Panel3.TabIndex = 3
        '
        'btnCHCviewpro
        '
        Me.btnCHCviewpro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCHCviewpro.Enabled = False
        Me.btnCHCviewpro.Location = New System.Drawing.Point(639, 2)
        Me.btnCHCviewpro.Name = "btnCHCviewpro"
        Me.btnCHCviewpro.Size = New System.Drawing.Size(142, 23)
        Me.btnCHCviewpro.TabIndex = 5
        Me.btnCHCviewpro.Text = "ดูรายการสินค้า/อะไหล่"
        Me.btnCHCviewpro.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Image = Global.ServiceTicker.My.Resources.Resources._109_AllAnnotations_Help_16x16_72
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(16, 17)
        '
        'VarunteeCheckFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "VarunteeCheckFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เช็คประกันงานซ่อม/เช็คประวัติงานซ่อม"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgVC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtVCdetail As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnVCsearch As System.Windows.Forms.Button
    Friend WithEvents txtVCsearch As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgVC As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnCHCviewpro As System.Windows.Forms.Button
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fix_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents symptom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fixrepairnote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fixaccessory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents varuntee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents user_repair As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datecom_repair As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cproduct As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
