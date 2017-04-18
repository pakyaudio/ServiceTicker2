<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DebtorShowProFrm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblShowText = New System.Windows.Forms.Label()
        Me.dgDSP = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_all = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgDSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblShowText)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(717, 26)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "แสดงรายการสินค้า ใบเบิกสินค้าที่"
        '
        'lblShowText
        '
        Me.lblShowText.AutoSize = True
        Me.lblShowText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblShowText.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblShowText.Location = New System.Drawing.Point(172, 9)
        Me.lblShowText.Name = "lblShowText"
        Me.lblShowText.Size = New System.Drawing.Size(45, 13)
        Me.lblShowText.TabIndex = 4
        Me.lblShowText.Text = "Label1"
        '
        'dgDSP
        '
        Me.dgDSP.AllowUserToAddRows = False
        Me.dgDSP.AllowUserToDeleteRows = False
        Me.dgDSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDSP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.code_pro, Me.name_pro, Me.total_pro, Me.price_buy, Me.unit, Me.total_all})
        Me.dgDSP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDSP.Location = New System.Drawing.Point(0, 26)
        Me.dgDSP.Name = "dgDSP"
        Me.dgDSP.ReadOnly = True
        Me.dgDSP.RowHeadersVisible = False
        Me.dgDSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDSP.Size = New System.Drawing.Size(717, 128)
        Me.dgDSP.TabIndex = 2
        '
        'no
        '
        Me.no.DataPropertyName = "no"
        Me.no.Frozen = True
        Me.no.HeaderText = "#"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.Width = 30
        '
        'code_pro
        '
        Me.code_pro.DataPropertyName = "code_pro"
        Me.code_pro.Frozen = True
        Me.code_pro.HeaderText = "รหัสสินค้า"
        Me.code_pro.Name = "code_pro"
        Me.code_pro.ReadOnly = True
        Me.code_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.code_pro.ToolTipText = "รหัสสินค้า"
        '
        'name_pro
        '
        Me.name_pro.DataPropertyName = "name_pro"
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro.ToolTipText = "ชื่อสินค้า"
        Me.name_pro.Width = 170
        '
        'total_pro
        '
        Me.total_pro.DataPropertyName = "total_pro"
        Me.total_pro.HeaderText = "จำนวน"
        Me.total_pro.Name = "total_pro"
        Me.total_pro.ReadOnly = True
        Me.total_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_pro.ToolTipText = "จำนวนสินค้า"
        '
        'price_buy
        '
        Me.price_buy.DataPropertyName = "price_buy"
        Me.price_buy.HeaderText = "ราคา"
        Me.price_buy.Name = "price_buy"
        Me.price_buy.ReadOnly = True
        '
        'unit
        '
        Me.unit.DataPropertyName = "unit"
        Me.unit.HeaderText = "หน่วย"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        Me.unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.unit.ToolTipText = "หน่วยนับสินค้า"
        '
        'total_all
        '
        Me.total_all.DataPropertyName = "total_all"
        Me.total_all.HeaderText = "รวม"
        Me.total_all.Name = "total_all"
        Me.total_all.ReadOnly = True
        Me.total_all.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DebtorShowProFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 154)
        Me.Controls.Add(Me.dgDSP)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DebtorShowProFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "แสดงรายการสินค้า"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgDSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblShowText As System.Windows.Forms.Label
    Friend WithEvents dgDSP As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_all As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
