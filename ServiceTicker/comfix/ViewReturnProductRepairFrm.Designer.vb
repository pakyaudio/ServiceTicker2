<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewReturnProductRepairFrm
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtVPRemployee = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtVPRtotal_all = New System.Windows.Forms.TextBox()
        Me.txtVPRcustomer_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtVPRdatetime_save = New System.Windows.Forms.TextBox()
        Me.txtVPRsale_id = New System.Windows.Forms.TextBox()
        Me.txtVPRcustomer_id = New System.Windows.Forms.TextBox()
        Me.txtVPRfix_id = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtVPRlistCount = New System.Windows.Forms.TextBox()
        Me.txtVPRtotalProduct = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ToolTipVPR = New System.Windows.Forms.ToolTip(Me.components)
        Me.dgVPR = New System.Windows.Forms.DataGridView()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_all = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgVPR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtVPRemployee)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtVPRtotal_all)
        Me.Panel1.Controls.Add(Me.txtVPRcustomer_name)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtVPRdatetime_save)
        Me.Panel1.Controls.Add(Me.txtVPRsale_id)
        Me.Panel1.Controls.Add(Me.txtVPRcustomer_id)
        Me.Panel1.Controls.Add(Me.txtVPRfix_id)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(606, 70)
        Me.Panel1.TabIndex = 0
        '
        'txtVPRemployee
        '
        Me.txtVPRemployee.Location = New System.Drawing.Point(503, 35)
        Me.txtVPRemployee.Name = "txtVPRemployee"
        Me.txtVPRemployee.ReadOnly = True
        Me.txtVPRemployee.Size = New System.Drawing.Size(96, 20)
        Me.txtVPRemployee.TabIndex = 24
        Me.ToolTipVPR.SetToolTip(Me.txtVPRemployee, "พนักงานผู้ทำรายการเบิก")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(449, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "พนักงาน"
        '
        'txtVPRtotal_all
        '
        Me.txtVPRtotal_all.Location = New System.Drawing.Point(294, 35)
        Me.txtVPRtotal_all.Name = "txtVPRtotal_all"
        Me.txtVPRtotal_all.ReadOnly = True
        Me.txtVPRtotal_all.Size = New System.Drawing.Size(147, 20)
        Me.txtVPRtotal_all.TabIndex = 22
        Me.ToolTipVPR.SetToolTip(Me.txtVPRtotal_all, "ยอดรวมราคาสินค้า/อะไหล่")
        '
        'txtVPRcustomer_name
        '
        Me.txtVPRcustomer_name.Location = New System.Drawing.Point(56, 35)
        Me.txtVPRcustomer_name.Name = "txtVPRcustomer_name"
        Me.txtVPRcustomer_name.ReadOnly = True
        Me.txtVPRcustomer_name.Size = New System.Drawing.Size(158, 20)
        Me.txtVPRcustomer_name.TabIndex = 21
        Me.ToolTipVPR.SetToolTip(Me.txtVPRcustomer_name, "ชื่อลูกค้า")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(220, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "ยอดรวมราคา"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "ชื่อ"
        '
        'txtVPRdatetime_save
        '
        Me.txtVPRdatetime_save.Location = New System.Drawing.Point(503, 12)
        Me.txtVPRdatetime_save.Name = "txtVPRdatetime_save"
        Me.txtVPRdatetime_save.ReadOnly = True
        Me.txtVPRdatetime_save.Size = New System.Drawing.Size(96, 20)
        Me.txtVPRdatetime_save.TabIndex = 18
        Me.ToolTipVPR.SetToolTip(Me.txtVPRdatetime_save, "วันที่ทำรายการเบิก")
        '
        'txtVPRsale_id
        '
        Me.txtVPRsale_id.Location = New System.Drawing.Point(339, 12)
        Me.txtVPRsale_id.Name = "txtVPRsale_id"
        Me.txtVPRsale_id.ReadOnly = True
        Me.txtVPRsale_id.Size = New System.Drawing.Size(158, 20)
        Me.txtVPRsale_id.TabIndex = 17
        Me.ToolTipVPR.SetToolTip(Me.txtVPRsale_id, "รหัสใบเบิกสินค้า/อะไหล่")
        '
        'txtVPRcustomer_id
        '
        Me.txtVPRcustomer_id.Location = New System.Drawing.Point(175, 12)
        Me.txtVPRcustomer_id.Name = "txtVPRcustomer_id"
        Me.txtVPRcustomer_id.ReadOnly = True
        Me.txtVPRcustomer_id.Size = New System.Drawing.Size(158, 20)
        Me.txtVPRcustomer_id.TabIndex = 16
        Me.ToolTipVPR.SetToolTip(Me.txtVPRcustomer_id, "รหัสลูกค้า")
        '
        'txtVPRfix_id
        '
        Me.txtVPRfix_id.Location = New System.Drawing.Point(11, 12)
        Me.txtVPRfix_id.Name = "txtVPRfix_id"
        Me.txtVPRfix_id.ReadOnly = True
        Me.txtVPRfix_id.Size = New System.Drawing.Size(158, 20)
        Me.txtVPRfix_id.TabIndex = 15
        Me.ToolTipVPR.SetToolTip(Me.txtVPRfix_id, "รหัสใบส่งซ่อม")
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtVPRlistCount)
        Me.Panel2.Controls.Add(Me.txtVPRtotalProduct)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 422)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(606, 34)
        Me.Panel2.TabIndex = 1
        '
        'txtVPRlistCount
        '
        Me.txtVPRlistCount.Location = New System.Drawing.Point(277, 3)
        Me.txtVPRlistCount.Name = "txtVPRlistCount"
        Me.txtVPRlistCount.ReadOnly = True
        Me.txtVPRlistCount.Size = New System.Drawing.Size(158, 20)
        Me.txtVPRlistCount.TabIndex = 18
        Me.txtVPRlistCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipVPR.SetToolTip(Me.txtVPRlistCount, "จำนวนรายการทั้งหมด")
        '
        'txtVPRtotalProduct
        '
        Me.txtVPRtotalProduct.Location = New System.Drawing.Point(441, 3)
        Me.txtVPRtotalProduct.Name = "txtVPRtotalProduct"
        Me.txtVPRtotalProduct.ReadOnly = True
        Me.txtVPRtotalProduct.Size = New System.Drawing.Size(158, 20)
        Me.txtVPRtotalProduct.TabIndex = 17
        Me.txtVPRtotalProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipVPR.SetToolTip(Me.txtVPRtotalProduct, "จำนวนสินค้าในรายการ")
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgVPR)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 70)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(606, 352)
        Me.Panel3.TabIndex = 2
        '
        'ToolTipVPR
        '
        Me.ToolTipVPR.AutoPopDelay = 5000
        Me.ToolTipVPR.InitialDelay = 300
        Me.ToolTipVPR.ReshowDelay = 300
        '
        'dgVPR
        '
        Me.dgVPR.AllowUserToAddRows = False
        Me.dgVPR.AllowUserToDeleteRows = False
        Me.dgVPR.AllowUserToOrderColumns = True
        Me.dgVPR.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgVPR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVPR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.code_pro, Me.name_pro, Me.total, Me.price_buy, Me.unit, Me.total_all})
        Me.dgVPR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgVPR.Location = New System.Drawing.Point(0, 0)
        Me.dgVPR.Name = "dgVPR"
        Me.dgVPR.ReadOnly = True
        Me.dgVPR.RowHeadersVisible = False
        Me.dgVPR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVPR.Size = New System.Drawing.Size(606, 352)
        Me.dgVPR.TabIndex = 18
        '
        'code_pro
        '
        Me.code_pro.DataPropertyName = "code_pro"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        Me.code_pro.DefaultCellStyle = DataGridViewCellStyle4
        Me.code_pro.Frozen = True
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
        Me.name_pro.Width = 250
        '
        'total
        '
        Me.total.DataPropertyName = "total"
        Me.total.HeaderText = "จำนวน"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'price_buy
        '
        Me.price_buy.DataPropertyName = "price_buy"
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.price_buy.DefaultCellStyle = DataGridViewCellStyle5
        Me.price_buy.HeaderText = "ราคา"
        Me.price_buy.Name = "price_buy"
        Me.price_buy.ReadOnly = True
        Me.price_buy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'total_all
        '
        Me.total_all.DataPropertyName = "total_all"
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0"
        Me.total_all.DefaultCellStyle = DataGridViewCellStyle6
        Me.total_all.HeaderText = "รวมราคา"
        Me.total_all.Name = "total_all"
        Me.total_all.ReadOnly = True
        Me.total_all.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ViewReturnProductRepairFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 456)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ViewReturnProductRepairFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายการคืนสินค้า"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgVPR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtVPRemployee As System.Windows.Forms.TextBox
    Friend WithEvents ToolTipVPR As System.Windows.Forms.ToolTip
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtVPRtotal_all As System.Windows.Forms.TextBox
    Friend WithEvents txtVPRcustomer_name As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtVPRdatetime_save As System.Windows.Forms.TextBox
    Friend WithEvents txtVPRsale_id As System.Windows.Forms.TextBox
    Friend WithEvents txtVPRcustomer_id As System.Windows.Forms.TextBox
    Friend WithEvents txtVPRfix_id As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtVPRlistCount As System.Windows.Forms.TextBox
    Friend WithEvents txtVPRtotalProduct As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgVPR As System.Windows.Forms.DataGridView
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_all As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
