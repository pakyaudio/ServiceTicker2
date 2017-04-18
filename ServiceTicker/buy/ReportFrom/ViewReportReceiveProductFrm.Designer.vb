<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewReportReceiveProductFrm
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtVSRPemployee = New System.Windows.Forms.TextBox()
        Me.txtVSRPdatetim_save = New System.Windows.Forms.TextBox()
        Me.txtVSRPsale_company_name = New System.Windows.Forms.TextBox()
        Me.txtVSRPsale_company_id = New System.Windows.Forms.TextBox()
        Me.txtVSRPbuy_id = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtVSRtotalBuy = New System.Windows.Forms.TextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgVSRP = New System.Windows.Forms.DataGridView()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bar_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.count_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.AddContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditPictureContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DelToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgVSRP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddContextMenu.SuspendLayout()
        Me.EditPictureContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 36)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtVSRPemployee)
        Me.Panel2.Controls.Add(Me.txtVSRPdatetim_save)
        Me.Panel2.Controls.Add(Me.txtVSRPsale_company_name)
        Me.Panel2.Controls.Add(Me.txtVSRPsale_company_id)
        Me.Panel2.Controls.Add(Me.txtVSRPbuy_id)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(778, 30)
        Me.Panel2.TabIndex = 1
        '
        'txtVSRPemployee
        '
        Me.txtVSRPemployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVSRPemployee.Location = New System.Drawing.Point(651, 3)
        Me.txtVSRPemployee.Name = "txtVSRPemployee"
        Me.txtVSRPemployee.Size = New System.Drawing.Size(97, 24)
        Me.txtVSRPemployee.TabIndex = 4
        Me.txtVSRPemployee.TabStop = False
        '
        'txtVSRPdatetim_save
        '
        Me.txtVSRPdatetim_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVSRPdatetim_save.Location = New System.Drawing.Point(471, 3)
        Me.txtVSRPdatetim_save.Name = "txtVSRPdatetim_save"
        Me.txtVSRPdatetim_save.Size = New System.Drawing.Size(181, 24)
        Me.txtVSRPdatetim_save.TabIndex = 3
        Me.txtVSRPdatetim_save.TabStop = False
        '
        'txtVSRPsale_company_name
        '
        Me.txtVSRPsale_company_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVSRPsale_company_name.Location = New System.Drawing.Point(245, 3)
        Me.txtVSRPsale_company_name.Name = "txtVSRPsale_company_name"
        Me.txtVSRPsale_company_name.Size = New System.Drawing.Size(227, 24)
        Me.txtVSRPsale_company_name.TabIndex = 2
        Me.txtVSRPsale_company_name.TabStop = False
        '
        'txtVSRPsale_company_id
        '
        Me.txtVSRPsale_company_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVSRPsale_company_id.Location = New System.Drawing.Point(177, 3)
        Me.txtVSRPsale_company_id.Name = "txtVSRPsale_company_id"
        Me.txtVSRPsale_company_id.Size = New System.Drawing.Size(69, 24)
        Me.txtVSRPsale_company_id.TabIndex = 1
        Me.txtVSRPsale_company_id.TabStop = False
        '
        'txtVSRPbuy_id
        '
        Me.txtVSRPbuy_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVSRPbuy_id.Location = New System.Drawing.Point(22, 3)
        Me.txtVSRPbuy_id.Name = "txtVSRPbuy_id"
        Me.txtVSRPbuy_id.Size = New System.Drawing.Size(157, 24)
        Me.txtVSRPbuy_id.TabIndex = 0
        Me.txtVSRPbuy_id.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txtVSRtotalBuy)
        Me.Panel3.Controls.Add(Me.btnPrint)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 532)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(784, 29)
        Me.Panel3.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(578, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "รวมราคา"
        '
        'txtVSRtotalBuy
        '
        Me.txtVSRtotalBuy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVSRtotalBuy.Location = New System.Drawing.Point(633, 3)
        Me.txtVSRtotalBuy.Name = "txtVSRtotalBuy"
        Me.txtVSRtotalBuy.ReadOnly = True
        Me.txtVSRtotalBuy.Size = New System.Drawing.Size(148, 20)
        Me.txtVSRtotalBuy.TabIndex = 1
        Me.txtVSRtotalBuy.TabStop = False
        Me.txtVSRtotalBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(3, 3)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(185, 23)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.Text = "พิมพ์รายการ"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.SplitContainer1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 36)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(784, 496)
        Me.Panel4.TabIndex = 2
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgVSRP)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ListView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(784, 496)
        Me.SplitContainer1.SplitterDistance = 225
        Me.SplitContainer1.TabIndex = 2
        '
        'dgVSRP
        '
        Me.dgVSRP.AllowUserToAddRows = False
        Me.dgVSRP.AllowUserToDeleteRows = False
        Me.dgVSRP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgVSRP.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgVSRP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVSRP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.code_pro, Me.bar_code, Me.name_pro, Me.price_cost, Me.count_num, Me.total})
        Me.dgVSRP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgVSRP.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgVSRP.Location = New System.Drawing.Point(0, 0)
        Me.dgVSRP.MultiSelect = False
        Me.dgVSRP.Name = "dgVSRP"
        Me.dgVSRP.ReadOnly = True
        Me.dgVSRP.RowHeadersVisible = False
        Me.dgVSRP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVSRP.Size = New System.Drawing.Size(784, 225)
        Me.dgVSRP.TabIndex = 0
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
        'price_cost
        '
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.price_cost.DefaultCellStyle = DataGridViewCellStyle4
        Me.price_cost.HeaderText = "ราคาทุน"
        Me.price_cost.Name = "price_cost"
        Me.price_cost.ReadOnly = True
        Me.price_cost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'count_num
        '
        DataGridViewCellStyle5.NullValue = "0"
        Me.count_num.DefaultCellStyle = DataGridViewCellStyle5
        Me.count_num.HeaderText = "จำนวน"
        Me.count_num.Name = "count_num"
        Me.count_num.ReadOnly = True
        Me.count_num.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.count_num.ToolTipText = "จำนวนชิ้น"
        '
        'total
        '
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0"
        Me.total.DefaultCellStyle = DataGridViewCellStyle6
        Me.total.HeaderText = "รวมราคา"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total.ToolTipText = "รวมราคา"
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(784, 267)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'AddContextMenu
        '
        Me.AddContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenu})
        Me.AddContextMenu.Name = "EditPictureContextMenu"
        Me.AddContextMenu.Size = New System.Drawing.Size(125, 26)
        '
        'AddToolStripMenu
        '
        Me.AddToolStripMenu.Name = "AddToolStripMenu"
        Me.AddToolStripMenu.Size = New System.Drawing.Size(124, 22)
        Me.AddToolStripMenu.Text = "เพิ่มเอกสาร"
        '
        'EditPictureContextMenu
        '
        Me.EditPictureContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZoomToolStripMenu, Me.PrintToolStripMenu, Me.DelToolStripMenu})
        Me.EditPictureContextMenu.Name = "EditPictureContextMenu"
        Me.EditPictureContextMenu.Size = New System.Drawing.Size(153, 92)
        '
        'DelToolStripMenu
        '
        Me.DelToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.VSO_RecycleBin_16x
        Me.DelToolStripMenu.Name = "DelToolStripMenu"
        Me.DelToolStripMenu.Size = New System.Drawing.Size(152, 22)
        Me.DelToolStripMenu.Text = "ลบเอกสาร"
        '
        'PrintToolStripMenu
        '
        Me.PrintToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.PrintStatusBar2_16x
        Me.PrintToolStripMenu.Name = "PrintToolStripMenu"
        Me.PrintToolStripMenu.Size = New System.Drawing.Size(152, 22)
        Me.PrintToolStripMenu.Text = "พิมพ์"
        '
        'ZoomToolStripMenu
        '
        Me.ZoomToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.Zoom_5442
        Me.ZoomToolStripMenu.Name = "ZoomToolStripMenu"
        Me.ZoomToolStripMenu.Size = New System.Drawing.Size(152, 22)
        Me.ZoomToolStripMenu.Text = "ขยาย"
        '
        'ViewReportReceiveProductFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ViewReportReceiveProductFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายการสินค้าตามใบสั่งซื้อ"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgVSRP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddContextMenu.ResumeLayout(False)
        Me.EditPictureContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtVSRPemployee As System.Windows.Forms.TextBox
    Friend WithEvents txtVSRPdatetim_save As System.Windows.Forms.TextBox
    Friend WithEvents txtVSRPsale_company_name As System.Windows.Forms.TextBox
    Friend WithEvents txtVSRPsale_company_id As System.Windows.Forms.TextBox
    Friend WithEvents txtVSRPbuy_id As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtVSRtotalBuy As System.Windows.Forms.TextBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents dgVSRP As System.Windows.Forms.DataGridView
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bar_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price_cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents count_num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents AddContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditPictureContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DelToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZoomToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenu As System.Windows.Forms.ToolStripMenuItem
End Class
