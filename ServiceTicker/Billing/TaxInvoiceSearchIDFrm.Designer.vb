<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaxInvoiceSearchIDFrm
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTISIDsearch = New System.Windows.Forms.Button()
        Me.cbbTISID = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.dgTISID = New System.Windows.Forms.DataGridView()
        Me.sale_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fix_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bar_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgTISID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnTISIDsearch)
        Me.Panel1.Controls.Add(Me.cbbTISID)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(651, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "ดับเบิ๊ลคลิ๊กตารางเพื่อเลือก"
        '
        'btnTISIDsearch
        '
        Me.btnTISIDsearch.Location = New System.Drawing.Point(473, 8)
        Me.btnTISIDsearch.Name = "btnTISIDsearch"
        Me.btnTISIDsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnTISIDsearch.TabIndex = 12
        Me.btnTISIDsearch.Text = "ค้นหา"
        Me.btnTISIDsearch.UseVisualStyleBackColor = True
        '
        'cbbTISID
        '
        Me.cbbTISID.FormattingEnabled = True
        Me.cbbTISID.Location = New System.Drawing.Point(263, 10)
        Me.cbbTISID.Name = "cbbTISID"
        Me.cbbTISID.Size = New System.Drawing.Size(191, 21)
        Me.cbbTISID.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ถึง"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "จาก"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(35, 29)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 8
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(35, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'dgTISID
        '
        Me.dgTISID.AllowUserToAddRows = False
        Me.dgTISID.AllowUserToDeleteRows = False
        Me.dgTISID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTISID.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sale_id, Me.fix_id, Me.customer_id, Me.customer_name, Me.code_pro, Me.bar_code, Me.name_pro, Me.total_pro, Me.unit, Me.price_buy, Me.discount, Me.price_total, Me.datetime_save})
        Me.dgTISID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTISID.Location = New System.Drawing.Point(0, 53)
        Me.dgTISID.Name = "dgTISID"
        Me.dgTISID.ReadOnly = True
        Me.dgTISID.RowHeadersVisible = False
        Me.dgTISID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTISID.Size = New System.Drawing.Size(784, 508)
        Me.dgTISID.TabIndex = 5
        '
        'sale_id
        '
        Me.sale_id.HeaderText = "เลขบิลเบิก"
        Me.sale_id.Name = "sale_id"
        Me.sale_id.ReadOnly = True
        Me.sale_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'fix_id
        '
        Me.fix_id.HeaderText = "เลขใบซ่อม"
        Me.fix_id.Name = "fix_id"
        Me.fix_id.ReadOnly = True
        Me.fix_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'name_pro
        '
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'total_pro
        '
        Me.total_pro.HeaderText = "จำนวน"
        Me.total_pro.Name = "total_pro"
        Me.total_pro.ReadOnly = True
        Me.total_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_pro.Width = 50
        '
        'unit
        '
        Me.unit.HeaderText = "หน่วย"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        Me.unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.unit.Width = 50
        '
        'price_buy
        '
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.price_buy.DefaultCellStyle = DataGridViewCellStyle1
        Me.price_buy.HeaderText = "ราคา"
        Me.price_buy.Name = "price_buy"
        Me.price_buy.ReadOnly = True
        Me.price_buy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_buy.Width = 50
        '
        'discount
        '
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.discount.DefaultCellStyle = DataGridViewCellStyle2
        Me.discount.HeaderText = "ลด"
        Me.discount.Name = "discount"
        Me.discount.ReadOnly = True
        Me.discount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'price_total
        '
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.price_total.DefaultCellStyle = DataGridViewCellStyle3
        Me.price_total.HeaderText = "รวมราคา"
        Me.price_total.Name = "price_total"
        Me.price_total.ReadOnly = True
        Me.price_total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price_total.Width = 70
        '
        'datetime_save
        '
        Me.datetime_save.HeaderText = "วันที่"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        Me.datetime_save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.datetime_save.ToolTipText = "วันที่บันทึก"
        '
        'TaxInvoiceSearchIDFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.dgTISID)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "TaxInvoiceSearchIDFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ค้นหาเอกสาร/บิลเบิก"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgTISID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnTISIDsearch As System.Windows.Forms.Button
    Friend WithEvents cbbTISID As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgTISID As System.Windows.Forms.DataGridView
    Friend WithEvents sale_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fix_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bar_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents discount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
