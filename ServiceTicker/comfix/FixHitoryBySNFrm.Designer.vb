<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FixHitoryBySNFrm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fix_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.symptom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.managerdata = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fixaccessory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_repair = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.note_repair = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.teltocus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datecom_repair = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_send = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.colum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.fix_id, Me.date_save, Me.customer_id, Me.customer_name, Me.sn, Me.p_type, Me.p_name, Me.p_model, Me.p_color, Me.symptom, Me.managerdata, Me.fixaccessory, Me.user_repair, Me.note_repair, Me.teltocus, Me.datecom_repair, Me.date_send})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(632, 303)
        Me.DataGridView1.TabIndex = 0
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
        Me.fix_id.HeaderText = "รหัสซ่อม"
        Me.fix_id.Name = "fix_id"
        Me.fix_id.ReadOnly = True
        Me.fix_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'date_save
        '
        Me.date_save.HeaderText = "วันที่รับ"
        Me.date_save.Name = "date_save"
        Me.date_save.ReadOnly = True
        Me.date_save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'customer_id
        '
        Me.customer_id.HeaderText = "รหัสลูกค้า"
        Me.customer_id.Name = "customer_id"
        Me.customer_id.ReadOnly = True
        Me.customer_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'customer_name
        '
        Me.customer_name.HeaderText = "ชื่อลูกค้า"
        Me.customer_name.Name = "customer_name"
        Me.customer_name.ReadOnly = True
        Me.customer_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'sn
        '
        Me.sn.HeaderText = "SN"
        Me.sn.Name = "sn"
        Me.sn.ReadOnly = True
        Me.sn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'p_type
        '
        Me.p_type.HeaderText = "ประเภท"
        Me.p_type.Name = "p_type"
        Me.p_type.ReadOnly = True
        Me.p_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'p_name
        '
        Me.p_name.HeaderText = "ยี่ห้อ"
        Me.p_name.Name = "p_name"
        Me.p_name.ReadOnly = True
        Me.p_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'p_model
        '
        Me.p_model.HeaderText = "รุ่น"
        Me.p_model.Name = "p_model"
        Me.p_model.ReadOnly = True
        Me.p_model.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'p_color
        '
        Me.p_color.HeaderText = "สี"
        Me.p_color.Name = "p_color"
        Me.p_color.ReadOnly = True
        Me.p_color.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'symptom
        '
        Me.symptom.HeaderText = "อาการเสีย"
        Me.symptom.Name = "symptom"
        Me.symptom.ReadOnly = True
        Me.symptom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'managerdata
        '
        Me.managerdata.HeaderText = "จัดการข้อมูล"
        Me.managerdata.Name = "managerdata"
        Me.managerdata.ReadOnly = True
        Me.managerdata.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'fixaccessory
        '
        Me.fixaccessory.HeaderText = "อุปกรณ์ที่นำมาด้วย"
        Me.fixaccessory.Name = "fixaccessory"
        Me.fixaccessory.ReadOnly = True
        Me.fixaccessory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fixaccessory.Width = 150
        '
        'user_repair
        '
        Me.user_repair.HeaderText = "ผู้ซ่อม"
        Me.user_repair.Name = "user_repair"
        Me.user_repair.ReadOnly = True
        Me.user_repair.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'note_repair
        '
        Me.note_repair.HeaderText = "บันทึการซ่อม"
        Me.note_repair.Name = "note_repair"
        Me.note_repair.ReadOnly = True
        Me.note_repair.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.note_repair.Width = 120
        '
        'teltocus
        '
        Me.teltocus.HeaderText = "แจ้งลูกค้า"
        Me.teltocus.Name = "teltocus"
        Me.teltocus.ReadOnly = True
        Me.teltocus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'datecom_repair
        '
        Me.datecom_repair.HeaderText = "วันที่ซ่อมเสร็จ"
        Me.datecom_repair.Name = "datecom_repair"
        Me.datecom_repair.ReadOnly = True
        Me.datecom_repair.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.datecom_repair.Width = 130
        '
        'date_send
        '
        Me.date_send.HeaderText = "วันที่ส่งคืน"
        Me.date_send.Name = "date_send"
        Me.date_send.ReadOnly = True
        Me.date_send.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(634, 611)
        Me.SplitContainer1.SplitterDistance = 305
        Me.SplitContainer1.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.PictureBox1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.DataGridView2)
        Me.SplitContainer2.Size = New System.Drawing.Size(632, 300)
        Me.SplitContainer2.SplitterDistance = 296
        Me.SplitContainer2.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.BackgroundImage = Global.ServiceTicker.My.Resources.Resources.Camera_32xMD
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.ErrorImage = Global.ServiceTicker.My.Resources.Resources.action_Cancel_16xLG
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(296, 300)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "รูป")
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colum, Me.data})
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(332, 300)
        Me.DataGridView2.TabIndex = 2
        '
        'colum
        '
        Me.colum.FillWeight = 53.29949!
        Me.colum.HeaderText = "หัวข้อ"
        Me.colum.Name = "colum"
        Me.colum.ReadOnly = True
        Me.colum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colum.Width = 117
        '
        'data
        '
        Me.data.FillWeight = 96.70051!
        Me.data.HeaderText = "ข้อมูลเครื่องซ่อม"
        Me.data.Name = "data"
        Me.data.ReadOnly = True
        Me.data.Width = 212
        '
        'FixHitoryBySNFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 611)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FixHitoryBySNFrm"
        Me.Text = "ดูประวัติงานซ่อมจาก SN"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fix_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents p_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents p_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents p_model As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents p_color As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents symptom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents managerdata As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fixaccessory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents user_repair As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents note_repair As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents teltocus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datecom_repair As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_send As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents colum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents data As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
