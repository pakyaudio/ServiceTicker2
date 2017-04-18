<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchCustomerByBillingFrm
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SearchToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.SearchToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ShowCusAllToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AddCusToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.LimitToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtSearchCusShowTel = New System.Windows.Forms.TextBox()
        Me.btnSendtoSavedatafix = New System.Windows.Forms.Button()
        Me.dgSearchCustoSaveFix = New System.Windows.Forms.DataGridView()
        Me.customer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_zipcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        CType(Me.dgSearchCustoSaveFix, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.ToolStrip1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(535, 30)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripTextBox, Me.SearchToolStripButton, Me.ShowCusAllToolStripButton, Me.AddCusToolStripButton, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.LimitToolStripTextBox})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(466, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'SearchToolStripTextBox
        '
        Me.SearchToolStripTextBox.AutoToolTip = True
        Me.SearchToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchToolStripTextBox.Name = "SearchToolStripTextBox"
        Me.SearchToolStripTextBox.Size = New System.Drawing.Size(250, 25)
        Me.SearchToolStripTextBox.ToolTipText = "ค้นหาจากชื่อ เบอร์โทรศัพท์"
        '
        'SearchToolStripButton
        '
        Me.SearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SearchToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.ZoomNeutral_16xlG
        Me.SearchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SearchToolStripButton.Name = "SearchToolStripButton"
        Me.SearchToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SearchToolStripButton.Text = "ค้นหา"
        '
        'ShowCusAllToolStripButton
        '
        Me.ShowCusAllToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ShowCusAllToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.Team_16xLG
        Me.ShowCusAllToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ShowCusAllToolStripButton.Name = "ShowCusAllToolStripButton"
        Me.ShowCusAllToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ShowCusAllToolStripButton.Text = "แสดงทั้งหมด"
        '
        'AddCusToolStripButton
        '
        Me.AddCusToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddCusToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.UserWizard_16x
        Me.AddCusToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddCusToolStripButton.Name = "AddCusToolStripButton"
        Me.AddCusToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AddCusToolStripButton.Text = "เพิ่มลูกค้า"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(34, 22)
        Me.ToolStripLabel1.Text = "Limit"
        Me.ToolStripLabel1.ToolTipText = "จำนวนการแสดงผลข้อมูล"
        '
        'LimitToolStripTextBox
        '
        Me.LimitToolStripTextBox.Name = "LimitToolStripTextBox"
        Me.LimitToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        Me.LimitToolStripTextBox.Text = "1000"
        Me.LimitToolStripTextBox.ToolTipText = "จำนวนแสดงผลข้อมูล"
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.txtSearchCusShowTel)
        Me.FlowLayoutPanel3.Controls.Add(Me.btnSendtoSavedatafix)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 363)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(535, 98)
        Me.FlowLayoutPanel3.TabIndex = 2
        '
        'txtSearchCusShowTel
        '
        Me.txtSearchCusShowTel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearchCusShowTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSearchCusShowTel.ForeColor = System.Drawing.Color.Red
        Me.txtSearchCusShowTel.Location = New System.Drawing.Point(3, 3)
        Me.txtSearchCusShowTel.Name = "txtSearchCusShowTel"
        Me.txtSearchCusShowTel.ReadOnly = True
        Me.txtSearchCusShowTel.Size = New System.Drawing.Size(527, 40)
        Me.txtSearchCusShowTel.TabIndex = 11
        Me.txtSearchCusShowTel.TabStop = False
        Me.txtSearchCusShowTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSendtoSavedatafix
        '
        Me.btnSendtoSavedatafix.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSendtoSavedatafix.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSendtoSavedatafix.ForeColor = System.Drawing.Color.Maroon
        Me.btnSendtoSavedatafix.Location = New System.Drawing.Point(3, 49)
        Me.btnSendtoSavedatafix.Name = "btnSendtoSavedatafix"
        Me.btnSendtoSavedatafix.Size = New System.Drawing.Size(527, 42)
        Me.btnSendtoSavedatafix.TabIndex = 12
        Me.btnSendtoSavedatafix.Text = "เลือกชื่อลูกค้า"
        Me.btnSendtoSavedatafix.UseVisualStyleBackColor = True
        '
        'dgSearchCustoSaveFix
        '
        Me.dgSearchCustoSaveFix.AllowUserToAddRows = False
        Me.dgSearchCustoSaveFix.AllowUserToDeleteRows = False
        Me.dgSearchCustoSaveFix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgSearchCustoSaveFix.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgSearchCustoSaveFix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSearchCustoSaveFix.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.customer_id, Me.customer_name, Me.customer_address, Me.customer_zipcode, Me.customer_tel})
        Me.dgSearchCustoSaveFix.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSearchCustoSaveFix.Location = New System.Drawing.Point(0, 30)
        Me.dgSearchCustoSaveFix.Name = "dgSearchCustoSaveFix"
        Me.dgSearchCustoSaveFix.ReadOnly = True
        Me.dgSearchCustoSaveFix.RowHeadersVisible = False
        Me.dgSearchCustoSaveFix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSearchCustoSaveFix.Size = New System.Drawing.Size(535, 333)
        Me.dgSearchCustoSaveFix.TabIndex = 10
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
        Me.customer_name.HeaderText = "ชื่อ"
        Me.customer_name.Name = "customer_name"
        Me.customer_name.ReadOnly = True
        Me.customer_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'customer_address
        '
        Me.customer_address.HeaderText = "ที่อยู่"
        Me.customer_address.Name = "customer_address"
        Me.customer_address.ReadOnly = True
        Me.customer_address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'customer_zipcode
        '
        Me.customer_zipcode.HeaderText = "รหัสไปรษณีย์"
        Me.customer_zipcode.Name = "customer_zipcode"
        Me.customer_zipcode.ReadOnly = True
        Me.customer_zipcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'customer_tel
        '
        Me.customer_tel.HeaderText = "เบอร์โทร"
        Me.customer_tel.Name = "customer_tel"
        Me.customer_tel.ReadOnly = True
        Me.customer_tel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'SearchCustomerByBillingFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 461)
        Me.Controls.Add(Me.dgSearchCustoSaveFix)
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "SearchCustomerByBillingFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ค้นหารายชื่อลูกค้า"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        CType(Me.dgSearchCustoSaveFix, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents SearchToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents SearchToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ShowCusAllToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents AddCusToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtSearchCusShowTel As System.Windows.Forms.TextBox
    Friend WithEvents btnSendtoSavedatafix As System.Windows.Forms.Button
    Friend WithEvents dgSearchCustoSaveFix As System.Windows.Forms.DataGridView
    Friend WithEvents customer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_zipcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LimitToolStripTextBox As System.Windows.Forms.ToolStripTextBox
End Class
