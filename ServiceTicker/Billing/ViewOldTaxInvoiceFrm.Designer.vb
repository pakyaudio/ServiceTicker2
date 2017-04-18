<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewOldTaxInvoiceFrm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnForward = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnVOTIdel = New System.Windows.Forms.Button()
        Me.btnVOTIsearch = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.dgVOTI = New System.Windows.Forms.DataGridView()
        Me.taxinvoice_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.taxvoice_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.dgVOTI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnForward)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.btnVOTIdel)
        Me.Panel1.Controls.Add(Me.btnVOTIsearch)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 53)
        Me.Panel1.TabIndex = 0
        '
        'btnForward
        '
        Me.btnForward.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnForward.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnForward.Image = Global.ServiceTicker.My.Resources.Resources.AzureMySQLDatabase_color_16x
        Me.btnForward.Location = New System.Drawing.Point(447, 30)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(105, 22)
        Me.btnForward.TabIndex = 12
        Me.btnForward.Text = "โหลดข้อมูลเพิ่ม"
        Me.btnForward.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnForward.UseVisualStyleBackColor = True
        Me.btnForward.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(637, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 46)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "เลือก"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Image = Global.ServiceTicker.My.Resources.Resources.VSO_Search_16x
        Me.btnSearch.Location = New System.Drawing.Point(559, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(27, 26)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(404, 3)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(148, 26)
        Me.txtSearch.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtSearch, "ค้นหาจากชื่อลูกค้า, ชนิดบิล, ชื่อสินค้า")
        '
        'btnVOTIdel
        '
        Me.btnVOTIdel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnVOTIdel.Image = Global.ServiceTicker.My.Resources.Resources.VSO_RecycleBin_16x
        Me.btnVOTIdel.Location = New System.Drawing.Point(330, 3)
        Me.btnVOTIdel.Name = "btnVOTIdel"
        Me.btnVOTIdel.Size = New System.Drawing.Size(68, 46)
        Me.btnVOTIdel.TabIndex = 9
        Me.btnVOTIdel.Text = "ลบ"
        Me.btnVOTIdel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVOTIdel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVOTIdel.UseVisualStyleBackColor = True
        '
        'btnVOTIsearch
        '
        Me.btnVOTIsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnVOTIsearch.Image = Global.ServiceTicker.My.Resources.Resources.VSO_Search_16x
        Me.btnVOTIsearch.Location = New System.Drawing.Point(240, 3)
        Me.btnVOTIsearch.Name = "btnVOTIsearch"
        Me.btnVOTIsearch.Size = New System.Drawing.Size(84, 46)
        Me.btnVOTIsearch.TabIndex = 8
        Me.btnVOTIsearch.Text = "ค้นหา"
        Me.btnVOTIsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVOTIsearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnVOTIsearch, "ค้นหาจากวันที่")
        Me.btnVOTIsearch.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ถึง"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "จาก"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(34, 29)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 5
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(34, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'dgVOTI
        '
        Me.dgVOTI.AllowUserToAddRows = False
        Me.dgVOTI.AllowUserToDeleteRows = False
        Me.dgVOTI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVOTI.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.taxinvoice_id, Me.taxvoice_type, Me.customer_id, Me.customer_name, Me.code_pro, Me.name_pro, Me.total, Me.unit, Me.price_buy, Me.datetime_save})
        Me.dgVOTI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgVOTI.Location = New System.Drawing.Point(0, 53)
        Me.dgVOTI.MultiSelect = False
        Me.dgVOTI.Name = "dgVOTI"
        Me.dgVOTI.ReadOnly = True
        Me.dgVOTI.RowHeadersVisible = False
        Me.dgVOTI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVOTI.Size = New System.Drawing.Size(784, 508)
        Me.dgVOTI.TabIndex = 6
        '
        'taxinvoice_id
        '
        Me.taxinvoice_id.DataPropertyName = "taxinvoice_id"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.taxinvoice_id.DefaultCellStyle = DataGridViewCellStyle1
        Me.taxinvoice_id.Frozen = True
        Me.taxinvoice_id.HeaderText = "เลขที่"
        Me.taxinvoice_id.Name = "taxinvoice_id"
        Me.taxinvoice_id.ReadOnly = True
        Me.taxinvoice_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.taxinvoice_id.ToolTipText = "เลขที่ใบเสร็จ"
        Me.taxinvoice_id.Width = 130
        '
        'taxvoice_type
        '
        Me.taxvoice_type.DataPropertyName = "taxvoice_type"
        Me.taxvoice_type.HeaderText = "ชนิดใบเสร็จ"
        Me.taxvoice_type.Name = "taxvoice_type"
        Me.taxvoice_type.ReadOnly = True
        Me.taxvoice_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'customer_id
        '
        Me.customer_id.DataPropertyName = "customer_id"
        Me.customer_id.HeaderText = "รหัสลูกค้า"
        Me.customer_id.Name = "customer_id"
        Me.customer_id.ReadOnly = True
        Me.customer_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'customer_name
        '
        Me.customer_name.DataPropertyName = "customer_name"
        Me.customer_name.HeaderText = "ชื่อลูกค้า"
        Me.customer_name.Name = "customer_name"
        Me.customer_name.ReadOnly = True
        Me.customer_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'code_pro
        '
        Me.code_pro.DataPropertyName = "code_pro"
        Me.code_pro.HeaderText = "รหัสสินค้า"
        Me.code_pro.Name = "code_pro"
        Me.code_pro.ReadOnly = True
        Me.code_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'name_pro
        '
        Me.name_pro.DataPropertyName = "name_pro"
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro.Width = 150
        '
        'total
        '
        Me.total.DataPropertyName = "total"
        Me.total.HeaderText = "จำนวน"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total.Width = 50
        '
        'unit
        '
        Me.unit.DataPropertyName = "unit"
        Me.unit.HeaderText = "หน่วย"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        Me.unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.unit.Width = 50
        '
        'price_buy
        '
        Me.price_buy.DataPropertyName = "price_buy"
        Me.price_buy.HeaderText = "ราคา"
        Me.price_buy.Name = "price_buy"
        Me.price_buy.ReadOnly = True
        Me.price_buy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_buy.Width = 50
        '
        'datetime_save
        '
        Me.datetime_save.DataPropertyName = "datetime_save"
        Me.datetime_save.HeaderText = "วันที่"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        Me.datetime_save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'ViewOldTaxInvoiceFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.dgVOTI)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ViewOldTaxInvoiceFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ค้นหาเอกสาร"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgVOTI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnVOTIdel As System.Windows.Forms.Button
    Friend WithEvents btnVOTIsearch As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgVOTI As System.Windows.Forms.DataGridView
    Friend WithEvents taxinvoice_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents taxvoice_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnForward As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
