<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaimsTestResultsFrm
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCTRsearchSN = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgCTR = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.claims_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serial_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestProClaimsContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TestToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgCTR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TestProClaimsContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.btnHelp})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 419)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(736, 22)
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
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtCTRsearchSN)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(736, 32)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Location = New System.Drawing.Point(156, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 24)
        Me.Button1.TabIndex = 113
        Me.Button1.Text = "ค้นหา"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "SN"
        '
        'txtCTRsearchSN
        '
        Me.txtCTRsearchSN.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCTRsearchSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCTRsearchSN.Location = New System.Drawing.Point(31, 3)
        Me.txtCTRsearchSN.Name = "txtCTRsearchSN"
        Me.txtCTRsearchSN.Size = New System.Drawing.Size(119, 24)
        Me.txtCTRsearchSN.TabIndex = 112
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgCTR)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(736, 387)
        Me.Panel2.TabIndex = 2
        '
        'dgCTR
        '
        Me.dgCTR.AllowUserToAddRows = False
        Me.dgCTR.AllowUserToDeleteRows = False
        Me.dgCTR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgCTR.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCTR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCTR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.claims_id, Me.customer_id, Me.customer_name, Me.serial_pro, Me.name_pro, Me.datetime_save})
        Me.dgCTR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCTR.Location = New System.Drawing.Point(0, 0)
        Me.dgCTR.MultiSelect = False
        Me.dgCTR.Name = "dgCTR"
        Me.dgCTR.ReadOnly = True
        Me.dgCTR.RowHeadersVisible = False
        Me.dgCTR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCTR.Size = New System.Drawing.Size(736, 387)
        Me.dgCTR.TabIndex = 0
        '
        'no
        '
        Me.no.FillWeight = 30.0!
        Me.no.HeaderText = "#"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'claims_id
        '
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
        '
        'datetime_save
        '
        Me.datetime_save.HeaderText = "วันที่รับเคลม"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        Me.datetime_save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'TestProClaimsContextMenu
        '
        Me.TestProClaimsContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenu})
        Me.TestProClaimsContextMenu.Name = "TestProClaimsContextMenu"
        Me.TestProClaimsContextMenu.Size = New System.Drawing.Size(140, 26)
        '
        'TestToolStripMenu
        '
        Me.TestToolStripMenu.Name = "TestToolStripMenu"
        Me.TestToolStripMenu.Size = New System.Drawing.Size(139, 22)
        Me.TestToolStripMenu.Text = "ทดสอบสินค้านี้"
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
        'ClaimsTestResultsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 441)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "ClaimsTestResultsFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ทดสอบสินค้าเคลม"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgCTR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TestProClaimsContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCTRsearchSN As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgCTR As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents claims_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serial_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TestProClaimsContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TestToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
