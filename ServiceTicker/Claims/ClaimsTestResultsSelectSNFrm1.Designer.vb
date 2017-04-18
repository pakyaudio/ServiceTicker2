<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaimsTestResultsSelectSNFrm1
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgCTRS = New System.Windows.Forms.DataGridView()
        Me.claims_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serial_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgCTRS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(764, 25)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ดับเบิ้ลคลิ๊กเพื่อเลือก"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgCTRS)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(764, 250)
        Me.Panel2.TabIndex = 1
        '
        'dgCTRS
        '
        Me.dgCTRS.AllowUserToAddRows = False
        Me.dgCTRS.AllowUserToDeleteRows = False
        Me.dgCTRS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCTRS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCTRS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.claims_id, Me.customer_id, Me.customer_name, Me.serial_pro, Me.name_pro, Me.datetime_save})
        Me.dgCTRS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCTRS.Location = New System.Drawing.Point(0, 0)
        Me.dgCTRS.Name = "dgCTRS"
        Me.dgCTRS.ReadOnly = True
        Me.dgCTRS.RowHeadersVisible = False
        Me.dgCTRS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCTRS.Size = New System.Drawing.Size(764, 250)
        Me.dgCTRS.TabIndex = 1
        '
        'claims_id
        '
        Me.claims_id.Frozen = True
        Me.claims_id.HeaderText = "รหัสเคลม"
        Me.claims_id.Name = "claims_id"
        Me.claims_id.ReadOnly = True
        Me.claims_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'serial_pro
        '
        Me.serial_pro.HeaderText = "SN"
        Me.serial_pro.Name = "serial_pro"
        Me.serial_pro.ReadOnly = True
        Me.serial_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'name_pro
        '
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro.Width = 200
        '
        'datetime_save
        '
        Me.datetime_save.HeaderText = "วันที่รับเคลม"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        Me.datetime_save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.datetime_save.Width = 140
        '
        'ClaimsTestResultsSelectSNFrm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 275)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ClaimsTestResultsSelectSNFrm1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกรายการนำเข้าสินค้าเคลม"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgCTRS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgCTRS As System.Windows.Forms.DataGridView
    Friend WithEvents claims_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serial_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
