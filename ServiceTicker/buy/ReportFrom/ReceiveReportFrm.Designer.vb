<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceiveReportFrm
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
        Me.btnRPshowAll = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbbVRbuyCompany = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtRRRrow = New System.Windows.Forms.TextBox()
        Me.txtRRRsum = New System.Windows.Forms.TextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnVRPviewPro = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgVR = New System.Windows.Forms.DataGridView()
        Me.buy_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.receive_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bill_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Panel1.Controls.Add(Me.btnRPshowAll)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cbbVRbuyCompany)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 31)
        Me.Panel1.TabIndex = 0
        '
        'btnRPshowAll
        '
        Me.btnRPshowAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRPshowAll.Location = New System.Drawing.Point(694, 5)
        Me.btnRPshowAll.Name = "btnRPshowAll"
        Me.btnRPshowAll.Size = New System.Drawing.Size(87, 23)
        Me.btnRPshowAll.TabIndex = 3
        Me.btnRPshowAll.Text = "รวบรวมข้อมูล"
        Me.btnRPshowAll.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(315, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "จาก"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(508, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "ถึง"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker2.Location = New System.Drawing.Point(533, 7)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(156, 20)
        Me.DateTimePicker2.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.Location = New System.Drawing.Point(346, 7)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(156, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "บริษัทที่จัดซื้อ"
        '
        'cbbVRbuyCompany
        '
        Me.cbbVRbuyCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbbVRbuyCompany.FormattingEnabled = True
        Me.cbbVRbuyCompany.Location = New System.Drawing.Point(79, 3)
        Me.cbbVRbuyCompany.Name = "cbbVRbuyCompany"
        Me.cbbVRbuyCompany.Size = New System.Drawing.Size(215, 24)
        Me.cbbVRbuyCompany.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtRRRrow)
        Me.Panel2.Controls.Add(Me.txtRRRsum)
        Me.Panel2.Controls.Add(Me.btnPrint)
        Me.Panel2.Controls.Add(Me.btnVRPviewPro)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 494)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 45)
        Me.Panel2.TabIndex = 2
        '
        'txtRRRrow
        '
        Me.txtRRRrow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRRRrow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRRRrow.Location = New System.Drawing.Point(387, 3)
        Me.txtRRRrow.Name = "txtRRRrow"
        Me.txtRRRrow.ReadOnly = True
        Me.txtRRRrow.Size = New System.Drawing.Size(194, 26)
        Me.txtRRRrow.TabIndex = 2
        '
        'txtRRRsum
        '
        Me.txtRRRsum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRRRsum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRRRsum.Location = New System.Drawing.Point(587, 3)
        Me.txtRRRsum.Name = "txtRRRsum"
        Me.txtRRRsum.ReadOnly = True
        Me.txtRRRsum.Size = New System.Drawing.Size(194, 26)
        Me.txtRRRsum.TabIndex = 3
        '
        'btnPrint
        '
        Me.btnPrint.Enabled = False
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(202, 3)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(95, 39)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "พิมพ์"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnVRPviewPro
        '
        Me.btnVRPviewPro.AutoSize = True
        Me.btnVRPviewPro.Enabled = False
        Me.btnVRPviewPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnVRPviewPro.Location = New System.Drawing.Point(3, 3)
        Me.btnVRPviewPro.Name = "btnVRPviewPro"
        Me.btnVRPviewPro.Size = New System.Drawing.Size(193, 39)
        Me.btnVRPviewPro.TabIndex = 0
        Me.btnVRPviewPro.Text = "ดูรายการสินค้า"
        Me.btnVRPviewPro.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgVR)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 31)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(784, 463)
        Me.Panel3.TabIndex = 3
        '
        'dgVR
        '
        Me.dgVR.AllowUserToAddRows = False
        Me.dgVR.AllowUserToDeleteRows = False
        Me.dgVR.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgVR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.buy_id, Me.receive_id, Me.bill_id, Me.sale_company_id, Me.sale_company_name, Me.datetime_save, Me.employee, Me.total, Me.status})
        Me.dgVR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgVR.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgVR.Location = New System.Drawing.Point(0, 0)
        Me.dgVR.MultiSelect = False
        Me.dgVR.Name = "dgVR"
        Me.dgVR.ReadOnly = True
        Me.dgVR.RowHeadersVisible = False
        Me.dgVR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVR.Size = New System.Drawing.Size(784, 463)
        Me.dgVR.TabIndex = 0
        '
        'buy_id
        '
        Me.buy_id.HeaderText = "เลขจัดซื้อ"
        Me.buy_id.Name = "buy_id"
        Me.buy_id.ReadOnly = True
        Me.buy_id.Width = 120
        '
        'receive_id
        '
        Me.receive_id.HeaderText = "เลขรับเข้า"
        Me.receive_id.Name = "receive_id"
        Me.receive_id.ReadOnly = True
        '
        'bill_id
        '
        Me.bill_id.HeaderText = "เลขที่เอกสารรับเข้า"
        Me.bill_id.Name = "bill_id"
        Me.bill_id.ReadOnly = True
        Me.bill_id.Width = 150
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
        Me.datetime_save.HeaderText = "วันที่ทำรายการจัดซื้อ"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        Me.datetime_save.Width = 150
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
        Me.total.HeaderText = "ราคารวม"
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
        'ReceiveReportFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "ReceiveReportFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายงานการรับสินค้า"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgVR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnRPshowAll As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbbVRbuyCompany As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtRRRrow As System.Windows.Forms.TextBox
    Friend WithEvents txtRRRsum As System.Windows.Forms.TextBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnVRPviewPro As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgVR As System.Windows.Forms.DataGridView
    Friend WithEvents buy_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents receive_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bill_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale_company_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents employee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
