<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaxInvoiceSelectProFrm
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnTISPselect = New System.Windows.Forms.Button()
        Me.cbbTISPpro = New System.Windows.Forms.ComboBox()
        Me.dgTISP = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bar_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_section = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgTISP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.btnTISPselect)
        Me.Panel1.Controls.Add(Me.cbbTISPpro)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(605, 28)
        Me.Panel1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(4, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(158, 20)
        Me.TextBox1.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.TextBox1, "ค้นหา")
        '
        'btnTISPselect
        '
        Me.btnTISPselect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTISPselect.Location = New System.Drawing.Point(527, 3)
        Me.btnTISPselect.Name = "btnTISPselect"
        Me.btnTISPselect.Size = New System.Drawing.Size(75, 23)
        Me.btnTISPselect.TabIndex = 4
        Me.btnTISPselect.Text = "เลือก"
        Me.btnTISPselect.UseVisualStyleBackColor = True
        '
        'cbbTISPpro
        '
        Me.cbbTISPpro.FormattingEnabled = True
        Me.cbbTISPpro.Location = New System.Drawing.Point(168, 3)
        Me.cbbTISPpro.Name = "cbbTISPpro"
        Me.cbbTISPpro.Size = New System.Drawing.Size(218, 21)
        Me.cbbTISPpro.TabIndex = 3
        '
        'dgTISP
        '
        Me.dgTISP.AllowUserToAddRows = False
        Me.dgTISP.AllowUserToDeleteRows = False
        Me.dgTISP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTISP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.code_pro, Me.bar_code, Me.name_pro, Me.type, Me.sub_section, Me.unit, Me.price_buy})
        Me.dgTISP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTISP.Location = New System.Drawing.Point(0, 28)
        Me.dgTISP.MultiSelect = False
        Me.dgTISP.Name = "dgTISP"
        Me.dgTISP.ReadOnly = True
        Me.dgTISP.RowHeadersVisible = False
        Me.dgTISP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTISP.Size = New System.Drawing.Size(605, 461)
        Me.dgTISP.TabIndex = 2
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
        'type
        '
        Me.type.HeaderText = "ประเภท"
        Me.type.Name = "type"
        Me.type.ReadOnly = True
        Me.type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'sub_section
        '
        Me.sub_section.HeaderText = "หมวดหมู่ย่อย"
        Me.sub_section.Name = "sub_section"
        Me.sub_section.ReadOnly = True
        Me.sub_section.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'unit
        '
        Me.unit.HeaderText = "หน่วย"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        Me.unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'price_buy
        '
        Me.price_buy.HeaderText = "ราคาปกติ"
        Me.price_buy.Name = "price_buy"
        Me.price_buy.ReadOnly = True
        Me.price_buy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'TaxInvoiceSelectProFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 489)
        Me.Controls.Add(Me.dgTISP)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "TaxInvoiceSelectProFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกสินค้า"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgTISP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnTISPselect As System.Windows.Forms.Button
    Friend WithEvents cbbTISPpro As System.Windows.Forms.ComboBox
    Friend WithEvents dgTISP As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bar_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sub_section As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_buy As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
