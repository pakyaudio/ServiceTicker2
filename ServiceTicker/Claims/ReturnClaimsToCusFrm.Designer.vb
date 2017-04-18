<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnClaimsToCusFrm
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRTCTrefresh = New System.Windows.Forms.Button()
        Me.btnRCTCsearchSN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRTCTsearchSN = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgRCTC = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.claims_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serial_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgRCTC, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Controls.Add(Me.btnRTCTrefresh)
        Me.Panel1.Controls.Add(Me.btnRCTCsearchSN)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtRTCTsearchSN)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 52)
        Me.Panel1.TabIndex = 1
        '
        'btnRTCTrefresh
        '
        Me.btnRTCTrefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRTCTrefresh.Location = New System.Drawing.Point(706, 26)
        Me.btnRTCTrefresh.Name = "btnRTCTrefresh"
        Me.btnRTCTrefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRTCTrefresh.TabIndex = 6
        Me.btnRTCTrefresh.Text = "รีเฟรส"
        Me.btnRTCTrefresh.UseVisualStyleBackColor = True
        '
        'btnRCTCsearchSN
        '
        Me.btnRCTCsearchSN.Location = New System.Drawing.Point(163, 23)
        Me.btnRCTCsearchSN.Name = "btnRCTCsearchSN"
        Me.btnRCTCsearchSN.Size = New System.Drawing.Size(75, 23)
        Me.btnRCTCsearchSN.TabIndex = 5
        Me.btnRCTCsearchSN.Text = "ค้นหา"
        Me.btnRCTCsearchSN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ใส่หมายเลข SN สินค้าเคลม"
        '
        'txtRTCTsearchSN
        '
        Me.txtRTCTsearchSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRTCTsearchSN.Location = New System.Drawing.Point(12, 23)
        Me.txtRTCTsearchSN.Name = "txtRTCTsearchSN"
        Me.txtRTCTsearchSN.Size = New System.Drawing.Size(145, 22)
        Me.txtRTCTsearchSN.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgRCTC)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 487)
        Me.Panel2.TabIndex = 2
        '
        'dgRCTC
        '
        Me.dgRCTC.AllowUserToAddRows = False
        Me.dgRCTC.AllowUserToDeleteRows = False
        Me.dgRCTC.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgRCTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRCTC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.claims_id, Me.customer_id, Me.customer_name, Me.serial_pro, Me.name_pro, Me.datetime_save})
        Me.dgRCTC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgRCTC.Location = New System.Drawing.Point(0, 0)
        Me.dgRCTC.MultiSelect = False
        Me.dgRCTC.Name = "dgRCTC"
        Me.dgRCTC.ReadOnly = True
        Me.dgRCTC.RowHeadersVisible = False
        Me.dgRCTC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRCTC.Size = New System.Drawing.Size(784, 487)
        Me.dgRCTC.TabIndex = 4
        '
        'no
        '
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.ToolTipText = "ลำดับ"
        Me.no.Width = 30
        '
        'claims_id
        '
        Me.claims_id.HeaderText = "หมายเลขเคลม"
        Me.claims_id.Name = "claims_id"
        Me.claims_id.ReadOnly = True
        Me.claims_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.claims_id.Width = 150
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
        Me.serial_pro.ToolTipText = "หมายเลขประจำตัวสินค้า"
        '
        'name_pro
        '
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro.Width = 220
        '
        'datetime_save
        '
        Me.datetime_save.HeaderText = "วันที่รับเคลม"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        Me.datetime_save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.datetime_save.Width = 150
        '
        'btnHelp
        '
        Me.btnHelp.AutoToolTip = True
        Me.btnHelp.Image = Global.ServiceTicker.My.Resources.Resources._109_AllAnnotations_Help_16x16_72
        Me.btnHelp.IsLink = True
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(16, 17)
        Me.btnHelp.ToolTipText = "Help"
        '
        'ReturnClaimsToCusFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "ReturnClaimsToCusFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "คืนสินค้าเคลม"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgRCTC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnRTCTrefresh As System.Windows.Forms.Button
    Friend WithEvents btnRCTCsearchSN As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRTCTsearchSN As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgRCTC As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents claims_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serial_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
