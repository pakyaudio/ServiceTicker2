<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillingSelectPrintFrm
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPrintBilling = New System.Windows.Forms.Button()
        Me.dgDTshowAll = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.sale_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_all = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cash = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pledge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSdg = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgDTshowAll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtSdg)
        Me.Panel1.Controls.Add(Me.btnPrintBilling)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 271)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 32)
        Me.Panel1.TabIndex = 0
        '
        'btnPrintBilling
        '
        Me.btnPrintBilling.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintBilling.Location = New System.Drawing.Point(634, 3)
        Me.btnPrintBilling.Name = "btnPrintBilling"
        Me.btnPrintBilling.Size = New System.Drawing.Size(147, 23)
        Me.btnPrintBilling.TabIndex = 0
        Me.btnPrintBilling.Text = "พิมพ์ใบวางบิล"
        Me.btnPrintBilling.UseVisualStyleBackColor = True
        '
        'dgDTshowAll
        '
        Me.dgDTshowAll.AllowUserToAddRows = False
        Me.dgDTshowAll.AllowUserToDeleteRows = False
        Me.dgDTshowAll.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgDTshowAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDTshowAll.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.sale_id, Me.detail, Me.customer_id, Me.customer_name, Me.datetime_save, Me.total_all, Me.cash, Me.pledge, Me.balance})
        Me.dgDTshowAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDTshowAll.Location = New System.Drawing.Point(0, 0)
        Me.dgDTshowAll.MultiSelect = False
        Me.dgDTshowAll.Name = "dgDTshowAll"
        Me.dgDTshowAll.RowHeadersVisible = False
        Me.dgDTshowAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDTshowAll.Size = New System.Drawing.Size(784, 271)
        Me.dgDTshowAll.TabIndex = 19
        Me.dgDTshowAll.TabStop = False
        '
        'No
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.NullValue = False
        Me.No.DefaultCellStyle = DataGridViewCellStyle1
        Me.No.HeaderText = "เลือก"
        Me.No.Name = "No"
        Me.No.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.No.Width = 40
        '
        'sale_id
        '
        Me.sale_id.DataPropertyName = "sale_id"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.sale_id.DefaultCellStyle = DataGridViewCellStyle2
        Me.sale_id.HeaderText = "เลขที่เอกสาร"
        Me.sale_id.Name = "sale_id"
        Me.sale_id.ReadOnly = True
        Me.sale_id.Width = 120
        '
        'detail
        '
        Me.detail.DataPropertyName = "detail"
        Me.detail.HeaderText = "Detail"
        Me.detail.Name = "detail"
        Me.detail.ReadOnly = True
        Me.detail.Width = 120
        '
        'customer_id
        '
        Me.customer_id.DataPropertyName = "customer_id"
        Me.customer_id.HeaderText = "รหัสลูกค้า"
        Me.customer_id.Name = "customer_id"
        Me.customer_id.ReadOnly = True
        Me.customer_id.Width = 120
        '
        'customer_name
        '
        Me.customer_name.DataPropertyName = "customer_name"
        Me.customer_name.HeaderText = "ชื่อลูกค้า"
        Me.customer_name.Name = "customer_name"
        Me.customer_name.ReadOnly = True
        Me.customer_name.Width = 200
        '
        'datetime_save
        '
        Me.datetime_save.DataPropertyName = "datetime_save"
        Me.datetime_save.HeaderText = "วันที่เอกสาร"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        Me.datetime_save.Width = 110
        '
        'total_all
        '
        Me.total_all.DataPropertyName = "total_all"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.total_all.DefaultCellStyle = DataGridViewCellStyle3
        Me.total_all.HeaderText = "จำนวนเงิน"
        Me.total_all.Name = "total_all"
        Me.total_all.ReadOnly = True
        '
        'cash
        '
        Me.cash.DataPropertyName = "cash"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.cash.DefaultCellStyle = DataGridViewCellStyle4
        Me.cash.HeaderText = "ยอดชำระ"
        Me.cash.Name = "cash"
        Me.cash.ReadOnly = True
        Me.cash.Width = 80
        '
        'pledge
        '
        Me.pledge.DataPropertyName = "pledge"
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.pledge.DefaultCellStyle = DataGridViewCellStyle5
        Me.pledge.HeaderText = "มัดจำ"
        Me.pledge.Name = "pledge"
        Me.pledge.Width = 70
        '
        'balance
        '
        Me.balance.DataPropertyName = "balance"
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0"
        Me.balance.DefaultCellStyle = DataGridViewCellStyle6
        Me.balance.HeaderText = "ยอดคงเหลือ"
        Me.balance.Name = "balance"
        Me.balance.Width = 150
        '
        'txtSdg
        '
        Me.txtSdg.Location = New System.Drawing.Point(103, 3)
        Me.txtSdg.Name = "txtSdg"
        Me.txtSdg.Size = New System.Drawing.Size(112, 20)
        Me.txtSdg.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "รวมยอดที่ต้องชำระ"
        '
        'BillingSelectPrintFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 303)
        Me.Controls.Add(Me.dgDTshowAll)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "BillingSelectPrintFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกข้อมูลสำหรับพิมพ์ใบวางบิล"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgDTshowAll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgDTshowAll As System.Windows.Forms.DataGridView
    Friend WithEvents btnPrintBilling As System.Windows.Forms.Button
    Friend WithEvents No As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents sale_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents detail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_all As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cash As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pledge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents balance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSdg As System.Windows.Forms.TextBox
End Class
