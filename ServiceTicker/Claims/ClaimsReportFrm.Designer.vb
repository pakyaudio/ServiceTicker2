<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaimsReportFrm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbbCRstatus = New System.Windows.Forms.ComboBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCRsearchbydate = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnCSshowAll = New System.Windows.Forms.Button()
        Me.btnCSsearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCSsearch = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
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
        Me.Help = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgCS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cbbCRstatus)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnCRsearchbydate)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.btnCSshowAll)
        Me.Panel1.Controls.Add(Me.btnCSsearch)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtCSsearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 57)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(525, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "ตามสถานะ"
        '
        'cbbCRstatus
        '
        Me.cbbCRstatus.FormattingEnabled = True
        Me.cbbCRstatus.Location = New System.Drawing.Point(588, 4)
        Me.cbbCRstatus.Name = "cbbCRstatus"
        Me.cbbCRstatus.Size = New System.Drawing.Size(186, 21)
        Me.cbbCRstatus.TabIndex = 27
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(681, 30)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(93, 21)
        Me.btnPrint.TabIndex = 26
        Me.btnPrint.Text = "พิมพ์"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "ระหว่าง"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(260, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "ถึง"
        '
        'btnCRsearchbydate
        '
        Me.btnCRsearchbydate.Location = New System.Drawing.Point(491, 29)
        Me.btnCRsearchbydate.Name = "btnCRsearchbydate"
        Me.btnCRsearchbydate.Size = New System.Drawing.Size(47, 21)
        Me.btnCRsearchbydate.TabIndex = 23
        Me.btnCRsearchbydate.Text = "ค้นหา"
        Me.btnCRsearchbydate.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(285, 30)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 22
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(54, 31)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 21
        '
        'btnCSshowAll
        '
        Me.btnCSshowAll.Location = New System.Drawing.Point(255, 4)
        Me.btnCSshowAll.Name = "btnCSshowAll"
        Me.btnCSshowAll.Size = New System.Drawing.Size(99, 21)
        Me.btnCSshowAll.TabIndex = 20
        Me.btnCSshowAll.Text = "แสดงทั้งหมด"
        Me.btnCSshowAll.UseVisualStyleBackColor = True
        '
        'btnCSsearch
        '
        Me.btnCSsearch.Location = New System.Drawing.Point(202, 4)
        Me.btnCSsearch.Name = "btnCSsearch"
        Me.btnCSsearch.Size = New System.Drawing.Size(47, 21)
        Me.btnCSsearch.TabIndex = 19
        Me.btnCSsearch.Text = "ค้นหา"
        Me.btnCSsearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "ค้นหา"
        '
        'txtCSsearch
        '
        Me.txtCSsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCSsearch.Location = New System.Drawing.Point(54, 3)
        Me.txtCSsearch.Name = "txtCSsearch"
        Me.txtCSsearch.Size = New System.Drawing.Size(142, 21)
        Me.txtCSsearch.TabIndex = 17
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.Help})
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
        Me.Panel2.Controls.Add(Me.dgCS)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 482)
        Me.Panel2.TabIndex = 2
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
        'Help
        '
        Me.Help.AutoToolTip = True
        Me.Help.Image = Global.ServiceTicker.My.Resources.Resources._109_AllAnnotations_Help_16x16_72
        Me.Help.IsLink = True
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(16, 17)
        Me.Help.ToolTipText = "Help"
        '
        'ClaimsReportFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ClaimsReportFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายงานการเคลม"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgCS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbbCRstatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCRsearchbydate As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCSshowAll As System.Windows.Forms.Button
    Friend WithEvents btnCSsearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCSsearch As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgCS As System.Windows.Forms.DataGridView
    Friend WithEvents No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents claims_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents symptom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tel_to_cus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents note2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents note As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Help As System.Windows.Forms.ToolStripStatusLabel
End Class
