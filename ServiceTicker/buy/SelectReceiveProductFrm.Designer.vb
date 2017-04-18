<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectReceiveProductFrm
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
        Me.btnSRPviewPro = New System.Windows.Forms.Button()
        Me.btnSRPselect = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbbSRPbuyCompany = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgSRP = New System.Windows.Forms.DataGridView()
        Me.buy_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgSRP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSRPviewPro)
        Me.Panel1.Controls.Add(Me.btnSRPselect)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 516)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 45)
        Me.Panel1.TabIndex = 0
        '
        'btnSRPviewPro
        '
        Me.btnSRPviewPro.AutoSize = True
        Me.btnSRPviewPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSRPviewPro.Location = New System.Drawing.Point(3, 3)
        Me.btnSRPviewPro.Name = "btnSRPviewPro"
        Me.btnSRPviewPro.Size = New System.Drawing.Size(193, 39)
        Me.btnSRPviewPro.TabIndex = 9
        Me.btnSRPviewPro.Text = "ดูรายการสินค้า"
        Me.btnSRPviewPro.UseVisualStyleBackColor = True
        '
        'btnSRPselect
        '
        Me.btnSRPselect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSRPselect.AutoSize = True
        Me.btnSRPselect.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSRPselect.Location = New System.Drawing.Point(556, 3)
        Me.btnSRPselect.Name = "btnSRPselect"
        Me.btnSRPselect.Size = New System.Drawing.Size(225, 39)
        Me.btnSRPselect.TabIndex = 8
        Me.btnSRPselect.Text = "เลือกไปหน้ารับเข้าสินค้า"
        Me.btnSRPselect.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cbbSRPbuyCompany)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 31)
        Me.Panel2.TabIndex = 1
        '
        'cbbSRPbuyCompany
        '
        Me.cbbSRPbuyCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbbSRPbuyCompany.FormattingEnabled = True
        Me.cbbSRPbuyCompany.Location = New System.Drawing.Point(3, 3)
        Me.cbbSRPbuyCompany.Name = "cbbSRPbuyCompany"
        Me.cbbSRPbuyCompany.Size = New System.Drawing.Size(412, 24)
        Me.cbbSRPbuyCompany.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgSRP)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 31)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(784, 485)
        Me.Panel3.TabIndex = 2
        '
        'dgSRP
        '
        Me.dgSRP.AllowUserToAddRows = False
        Me.dgSRP.AllowUserToDeleteRows = False
        Me.dgSRP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgSRP.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgSRP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSRP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.buy_id, Me.sale_company_id, Me.sale_company_name, Me.datetime_save, Me.employee, Me.total, Me.status})
        Me.dgSRP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSRP.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgSRP.Location = New System.Drawing.Point(0, 0)
        Me.dgSRP.MultiSelect = False
        Me.dgSRP.Name = "dgSRP"
        Me.dgSRP.ReadOnly = True
        Me.dgSRP.RowHeadersVisible = False
        Me.dgSRP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSRP.Size = New System.Drawing.Size(784, 485)
        Me.dgSRP.TabIndex = 4
        '
        'buy_id
        '
        Me.buy_id.HeaderText = "รหัสใบจัดซื้อ"
        Me.buy_id.Name = "buy_id"
        Me.buy_id.ReadOnly = True
        '
        'sale_company_id
        '
        Me.sale_company_id.HeaderText = "รหัสบริษัท"
        Me.sale_company_id.Name = "sale_company_id"
        Me.sale_company_id.ReadOnly = True
        '
        'sale_company_name
        '
        Me.sale_company_name.HeaderText = "ชื่อบริษัท"
        Me.sale_company_name.Name = "sale_company_name"
        Me.sale_company_name.ReadOnly = True
        '
        'datetime_save
        '
        Me.datetime_save.HeaderText = "วันที่ทำรายการ"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        '
        'employee
        '
        Me.employee.HeaderText = "พนักงาน"
        Me.employee.Name = "employee"
        Me.employee.ReadOnly = True
        '
        'total
        '
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.total.DefaultCellStyle = DataGridViewCellStyle1
        Me.total.HeaderText = "รวมราคา"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'status
        '
        Me.status.HeaderText = "สถานะ"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'SelectReceiveProductFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SelectReceiveProductFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายการใบสั่งซื้อสินค้า"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgSRP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSRPviewPro As System.Windows.Forms.Button
    Friend WithEvents btnSRPselect As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cbbSRPbuyCompany As System.Windows.Forms.ComboBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgSRP As System.Windows.Forms.DataGridView
    Friend WithEvents buy_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
