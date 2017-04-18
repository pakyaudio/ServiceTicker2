<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerSNFrm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRename_proSN = New System.Windows.Forms.Button()
        Me.btndontBysn = New System.Windows.Forms.Button()
        Me.btnMoveCodePro = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.dgMSN = New System.Windows.Forms.DataGridView()
        Me.selectSN = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.code_proSN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Serial_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_proSN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_inSN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnForward = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgMSN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 579)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(669, 22)
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
        Me.Panel1.Controls.Add(Me.btnRename_proSN)
        Me.Panel1.Controls.Add(Me.btndontBysn)
        Me.Panel1.Controls.Add(Me.btnMoveCodePro)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(457, 29)
        Me.Panel1.TabIndex = 1
        '
        'btnRename_proSN
        '
        Me.btnRename_proSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRename_proSN.Enabled = False
        Me.btnRename_proSN.Location = New System.Drawing.Point(221, 3)
        Me.btnRename_proSN.Name = "btnRename_proSN"
        Me.btnRename_proSN.Size = New System.Drawing.Size(127, 23)
        Me.btnRename_proSN.TabIndex = 4
        Me.btnRename_proSN.Text = "เปลี่ยนชื่อสินค้าของ SN"
        Me.btnRename_proSN.UseVisualStyleBackColor = True
        '
        'btndontBysn
        '
        Me.btndontBysn.Location = New System.Drawing.Point(3, 3)
        Me.btndontBysn.Name = "btndontBysn"
        Me.btndontBysn.Size = New System.Drawing.Size(125, 23)
        Me.btndontBysn.TabIndex = 3
        Me.btndontBysn.Text = "SN ที่ไม่มีหมวดหมู่"
        Me.btndontBysn.UseVisualStyleBackColor = True
        '
        'btnMoveCodePro
        '
        Me.btnMoveCodePro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMoveCodePro.Enabled = False
        Me.btnMoveCodePro.Location = New System.Drawing.Point(354, 3)
        Me.btnMoveCodePro.Name = "btnMoveCodePro"
        Me.btnMoveCodePro.Size = New System.Drawing.Size(100, 23)
        Me.btnMoveCodePro.TabIndex = 2
        Me.btnMoveCodePro.Text = "ย้ายหมวดหมู่"
        Me.btnMoveCodePro.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(134, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "0"
        Me.ToolTip1.SetToolTip(Me.Label2, "จำนวแถวที่แสดง/จำนวนทั้งหมด")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Limit"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDown1.Location = New System.Drawing.Point(35, 6)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(93, 20)
        Me.NumericUpDown1.TabIndex = 4
        Me.NumericUpDown1.ThousandsSeparator = True
        Me.ToolTip1.SetToolTip(Me.NumericUpDown1, "ลิมิตในการโหลดข้อมูล(การกำหนดจำนวนมากอาจจะใช้เวลามากในการดึงข้อมูล)")
        Me.NumericUpDown1.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgMSN)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(669, 579)
        Me.SplitContainer1.SplitterDistance = 206
        Me.SplitContainer1.TabIndex = 2
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(204, 577)
        Me.TreeView1.TabIndex = 0
        '
        'dgMSN
        '
        Me.dgMSN.AllowUserToAddRows = False
        Me.dgMSN.AllowUserToDeleteRows = False
        Me.dgMSN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgMSN.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgMSN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMSN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.selectSN, Me.code_proSN, Me.Serial_pro, Me.name_proSN, Me.date_inSN})
        Me.dgMSN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMSN.Location = New System.Drawing.Point(0, 29)
        Me.dgMSN.MultiSelect = False
        Me.dgMSN.Name = "dgMSN"
        Me.dgMSN.RowHeadersVisible = False
        Me.dgMSN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMSN.Size = New System.Drawing.Size(457, 515)
        Me.dgMSN.TabIndex = 1
        '
        'selectSN
        '
        Me.selectSN.FillWeight = 35.0!
        Me.selectSN.HeaderText = ""
        Me.selectSN.Name = "selectSN"
        Me.selectSN.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'code_proSN
        '
        Me.code_proSN.HeaderText = "รหัสสินค้า"
        Me.code_proSN.Name = "code_proSN"
        Me.code_proSN.ReadOnly = True
        '
        'Serial_pro
        '
        Me.Serial_pro.HeaderText = "SN"
        Me.Serial_pro.Name = "Serial_pro"
        Me.Serial_pro.ReadOnly = True
        '
        'name_proSN
        '
        Me.name_proSN.HeaderText = "ชื่อสินค้า"
        Me.name_proSN.Name = "name_proSN"
        Me.name_proSN.ReadOnly = True
        '
        'date_inSN
        '
        Me.date_inSN.HeaderText = "วันที่"
        Me.date_inSN.Name = "date_inSN"
        Me.date_inSN.ReadOnly = True
        Me.date_inSN.ToolTipText = "วันที่บันทึก"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnForward)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.NumericUpDown1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 544)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(457, 33)
        Me.Panel2.TabIndex = 2
        '
        'btnForward
        '
        Me.btnForward.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnForward.Enabled = False
        Me.btnForward.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnForward.Image = Global.ServiceTicker.My.Resources.Resources.AzureMySQLDatabase_color_16x
        Me.btnForward.Location = New System.Drawing.Point(332, 3)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(122, 27)
        Me.btnForward.TabIndex = 7
        Me.btnForward.Text = "โหลดข้อมูลเพิ่ม"
        Me.btnForward.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnForward.UseVisualStyleBackColor = True
        '
        'ManagerSNFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 601)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "ManagerSNFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "จัดการสินค้า Serial Number"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgMSN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnMoveCodePro As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CodeproDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SerialproDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameproDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StopDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btndontBysn As System.Windows.Forms.Button
    Friend WithEvents dgMSN As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnForward As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents selectSN As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents code_proSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Serial_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_proSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_inSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnRename_proSN As System.Windows.Forms.Button
End Class
