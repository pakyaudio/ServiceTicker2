<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewReceiveFrm
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbbVRbuyCompany = New System.Windows.Forms.ComboBox()
        Me.cbbVRbuyStatus = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnEditCancel = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnVRcancelBillbuy = New System.Windows.Forms.Button()
        Me.btnVRPviewPro = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgVR = New System.Windows.Forms.DataGridView()
        Me.buy_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale_company_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgVR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.btnHelp})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblEmployee
        '
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(30, 17)
        Me.lblEmployee.Text = "User"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbbVRbuyCompany)
        Me.Panel1.Controls.Add(Me.cbbVRbuyStatus)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(778, 31)
        Me.Panel1.TabIndex = 1
        '
        'cbbVRbuyCompany
        '
        Me.cbbVRbuyCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbbVRbuyCompany.FormattingEnabled = True
        Me.cbbVRbuyCompany.Location = New System.Drawing.Point(384, 3)
        Me.cbbVRbuyCompany.Name = "cbbVRbuyCompany"
        Me.cbbVRbuyCompany.Size = New System.Drawing.Size(391, 24)
        Me.cbbVRbuyCompany.TabIndex = 1
        '
        'cbbVRbuyStatus
        '
        Me.cbbVRbuyStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbbVRbuyStatus.FormattingEnabled = True
        Me.cbbVRbuyStatus.Location = New System.Drawing.Point(3, 3)
        Me.cbbVRbuyStatus.Name = "cbbVRbuyStatus"
        Me.cbbVRbuyStatus.Size = New System.Drawing.Size(375, 24)
        Me.cbbVRbuyStatus.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 37)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnEditCancel)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.btnVRcancelBillbuy)
        Me.Panel3.Controls.Add(Me.btnVRPviewPro)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 494)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(784, 45)
        Me.Panel3.TabIndex = 1
        '
        'btnEditCancel
        '
        Me.btnEditCancel.AutoSize = True
        Me.btnEditCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnEditCancel.Location = New System.Drawing.Point(157, 3)
        Me.btnEditCancel.Name = "btnEditCancel"
        Me.btnEditCancel.Size = New System.Drawing.Size(148, 39)
        Me.btnEditCancel.TabIndex = 1
        Me.btnEditCancel.Text = "แก้ไขการยกเลิก"
        Me.btnEditCancel.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.AutoSize = True
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(389, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(193, 39)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "พิมพ์รายการสั่งซื้อ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnVRcancelBillbuy
        '
        Me.btnVRcancelBillbuy.AutoSize = True
        Me.btnVRcancelBillbuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnVRcancelBillbuy.Location = New System.Drawing.Point(3, 3)
        Me.btnVRcancelBillbuy.Name = "btnVRcancelBillbuy"
        Me.btnVRcancelBillbuy.Size = New System.Drawing.Size(148, 39)
        Me.btnVRcancelBillbuy.TabIndex = 0
        Me.btnVRcancelBillbuy.Text = "ยกเลิกใบสั่งซื้อนี้"
        Me.btnVRcancelBillbuy.UseVisualStyleBackColor = True
        '
        'btnVRPviewPro
        '
        Me.btnVRPviewPro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVRPviewPro.AutoSize = True
        Me.btnVRPviewPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnVRPviewPro.Location = New System.Drawing.Point(588, 3)
        Me.btnVRPviewPro.Name = "btnVRPviewPro"
        Me.btnVRPviewPro.Size = New System.Drawing.Size(193, 39)
        Me.btnVRPviewPro.TabIndex = 3
        Me.btnVRPviewPro.Text = "ดูรายการสินค้า"
        Me.btnVRPviewPro.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dgVR)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 37)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(784, 457)
        Me.Panel4.TabIndex = 4
        '
        'dgVR
        '
        Me.dgVR.AllowUserToAddRows = False
        Me.dgVR.AllowUserToDeleteRows = False
        Me.dgVR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgVR.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgVR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.buy_id, Me.sale_company_id, Me.sale_company_name, Me.datetime_save, Me.employee, Me.total, Me.status})
        Me.dgVR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgVR.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgVR.Location = New System.Drawing.Point(0, 0)
        Me.dgVR.MultiSelect = False
        Me.dgVR.Name = "dgVR"
        Me.dgVR.ReadOnly = True
        Me.dgVR.RowHeadersVisible = False
        Me.dgVR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVR.Size = New System.Drawing.Size(784, 457)
        Me.dgVR.TabIndex = 0
        '
        'buy_id
        '
        Me.buy_id.FillWeight = 112.0!
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
        Me.total.HeaderText = "ราคา"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'status
        '
        Me.status.HeaderText = "สถานะ"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'btnHelp
        '
        Me.btnHelp.Image = Global.ServiceTicker.My.Resources.Resources._109_AllAnnotations_Help_16x16_72
        Me.btnHelp.IsLink = True
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(16, 17)
        Me.btnHelp.ToolTipText = "Help"
        '
        'ViewReceiveFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "ViewReceiveFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายการสั่งซื้อสินค้า"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgVR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cbbVRbuyCompany As System.Windows.Forms.ComboBox
    Friend WithEvents cbbVRbuyStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnVRcancelBillbuy As System.Windows.Forms.Button
    Friend WithEvents btnVRPviewPro As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents dgVR As System.Windows.Forms.DataGridView
    Friend WithEvents buy_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnEditCancel As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
