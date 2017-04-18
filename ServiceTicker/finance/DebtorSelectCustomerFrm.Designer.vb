<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DebtorSelectCustomerFrm
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
        Me.btnDSCshowall = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDSCsearchCus = New System.Windows.Forms.Button()
        Me.txtDSCsearch = New System.Windows.Forms.TextBox()
        Me.dgDSC = New System.Windows.Forms.DataGridView()
        Me.cus_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cus_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cus_address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cus_tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cus_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgDSC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnDSCshowall)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnDSCsearchCus)
        Me.Panel1.Controls.Add(Me.txtDSCsearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(626, 29)
        Me.Panel1.TabIndex = 0
        '
        'btnDSCshowall
        '
        Me.btnDSCshowall.Location = New System.Drawing.Point(262, 3)
        Me.btnDSCshowall.Name = "btnDSCshowall"
        Me.btnDSCshowall.Size = New System.Drawing.Size(75, 23)
        Me.btnDSCshowall.TabIndex = 8
        Me.btnDSCshowall.Text = "แสดงทั้งหมด"
        Me.btnDSCshowall.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(521, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ดับเบิ้ลคลิ๊กเพื่อเลือก"
        '
        'btnDSCsearchCus
        '
        Me.btnDSCsearchCus.Location = New System.Drawing.Point(181, 3)
        Me.btnDSCsearchCus.Name = "btnDSCsearchCus"
        Me.btnDSCsearchCus.Size = New System.Drawing.Size(75, 23)
        Me.btnDSCsearchCus.TabIndex = 6
        Me.btnDSCsearchCus.Text = "ค้นหา"
        Me.btnDSCsearchCus.UseVisualStyleBackColor = True
        '
        'txtDSCsearch
        '
        Me.txtDSCsearch.Location = New System.Drawing.Point(4, 5)
        Me.txtDSCsearch.Name = "txtDSCsearch"
        Me.txtDSCsearch.Size = New System.Drawing.Size(171, 20)
        Me.txtDSCsearch.TabIndex = 5
        '
        'dgDSC
        '
        Me.dgDSC.AllowUserToAddRows = False
        Me.dgDSC.AllowUserToDeleteRows = False
        Me.dgDSC.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgDSC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDSC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cus_id, Me.cus_name, Me.cus_address, Me.cus_tel, Me.cus_date})
        Me.dgDSC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDSC.Location = New System.Drawing.Point(0, 29)
        Me.dgDSC.MultiSelect = False
        Me.dgDSC.Name = "dgDSC"
        Me.dgDSC.ReadOnly = True
        Me.dgDSC.RowHeadersVisible = False
        Me.dgDSC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDSC.Size = New System.Drawing.Size(626, 336)
        Me.dgDSC.TabIndex = 1
        '
        'cus_id
        '
        Me.cus_id.HeaderText = "รหัสลูกค้า"
        Me.cus_id.Name = "cus_id"
        Me.cus_id.ReadOnly = True
        '
        'cus_name
        '
        Me.cus_name.HeaderText = "ชื่อลูกค้า"
        Me.cus_name.Name = "cus_name"
        Me.cus_name.ReadOnly = True
        '
        'cus_address
        '
        Me.cus_address.HeaderText = "ที่อยู่"
        Me.cus_address.Name = "cus_address"
        Me.cus_address.ReadOnly = True
        Me.cus_address.Width = 150
        '
        'cus_tel
        '
        Me.cus_tel.HeaderText = "โทร"
        Me.cus_tel.Name = "cus_tel"
        Me.cus_tel.ReadOnly = True
        '
        'cus_date
        '
        Me.cus_date.HeaderText = "วันที่บันทึกข้อมูล"
        Me.cus_date.Name = "cus_date"
        Me.cus_date.ReadOnly = True
        Me.cus_date.Width = 120
        '
        'DebtorSelectCustomerFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 365)
        Me.Controls.Add(Me.dgDSC)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DebtorSelectCustomerFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกชื่อลูกค้า"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgDSC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnDSCshowall As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDSCsearchCus As System.Windows.Forms.Button
    Friend WithEvents txtDSCsearch As System.Windows.Forms.TextBox
    Friend WithEvents dgDSC As System.Windows.Forms.DataGridView
    Friend WithEvents cus_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cus_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cus_address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cus_tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cus_date As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
