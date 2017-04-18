<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpimizeDBFrm
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnOpt = New System.Windows.Forms.Button()
        Me.btnRepair = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgData = New System.Windows.Forms.DataGridView()
        Me.lblDetail = New System.Windows.Forms.Label()
        Me.table_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.table_row = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data_length = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.index_length = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 424)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(748, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblEmployee
        '
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(35, 17)
        Me.lblEmployee.Text = "Users"
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Transparent
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRefresh.Image = Global.ServiceTicker.My.Resources.Resources.Refresh_grey_20x21
        Me.btnRefresh.Location = New System.Drawing.Point(3, 3)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(49, 29)
        Me.btnRefresh.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btnRefresh, "Refresh")
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnOpt
        '
        Me.btnOpt.BackColor = System.Drawing.Color.Transparent
        Me.btnOpt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnOpt.Location = New System.Drawing.Point(58, 3)
        Me.btnOpt.Name = "btnOpt"
        Me.btnOpt.Size = New System.Drawing.Size(144, 29)
        Me.btnOpt.TabIndex = 1
        Me.btnOpt.Text = "เพิ่มประสิทธิภาพฐานข้อมูล"
        Me.ToolTip1.SetToolTip(Me.btnOpt, "Refresh")
        Me.btnOpt.UseVisualStyleBackColor = False
        '
        'btnRepair
        '
        Me.btnRepair.BackColor = System.Drawing.Color.Transparent
        Me.btnRepair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRepair.Location = New System.Drawing.Point(208, 2)
        Me.btnRepair.Name = "btnRepair"
        Me.btnRepair.Size = New System.Drawing.Size(144, 29)
        Me.btnRepair.TabIndex = 2
        Me.btnRepair.Text = "ซ่อมแซมฐานข้อมูล"
        Me.ToolTip1.SetToolTip(Me.btnRepair, "Refresh")
        Me.btnRepair.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.BackColor = System.Drawing.Color.Transparent
        Me.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnHelp.Image = Global.ServiceTicker.My.Resources.Resources._109_AllAnnotations_Help_16x16_72
        Me.btnHelp.Location = New System.Drawing.Point(719, 3)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(26, 28)
        Me.btnHelp.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btnHelp, "Refresh")
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgData)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnHelp)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblDetail)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnRepair)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnOpt)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnRefresh)
        Me.SplitContainer1.Size = New System.Drawing.Size(748, 424)
        Me.SplitContainer1.SplitterDistance = 385
        Me.SplitContainer1.TabIndex = 1
        '
        'dgData
        '
        Me.dgData.AllowUserToAddRows = False
        Me.dgData.AllowUserToDeleteRows = False
        Me.dgData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgData.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.table_name, Me.table_row, Me.data_length, Me.index_length, Me.status})
        Me.dgData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgData.Location = New System.Drawing.Point(0, 0)
        Me.dgData.MultiSelect = False
        Me.dgData.Name = "dgData"
        Me.dgData.ReadOnly = True
        Me.dgData.RowHeadersWidth = 20
        Me.dgData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgData.Size = New System.Drawing.Size(748, 385)
        Me.dgData.TabIndex = 0
        '
        'lblDetail
        '
        Me.lblDetail.AutoSize = True
        Me.lblDetail.Location = New System.Drawing.Point(364, 10)
        Me.lblDetail.Name = "lblDetail"
        Me.lblDetail.Size = New System.Drawing.Size(34, 13)
        Me.lblDetail.TabIndex = 3
        Me.lblDetail.Text = "Detail"
        '
        'table_name
        '
        Me.table_name.HeaderText = "ชื่อตาราง"
        Me.table_name.Name = "table_name"
        Me.table_name.ReadOnly = True
        Me.table_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'table_row
        '
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = "0"
        Me.table_row.DefaultCellStyle = DataGridViewCellStyle1
        Me.table_row.HeaderText = "จำนวนตาราง"
        Me.table_row.Name = "table_row"
        Me.table_row.ReadOnly = True
        Me.table_row.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.table_row.ToolTipText = "จำนวนตารางในฐานข้อมูล"
        '
        'data_length
        '
        DataGridViewCellStyle2.Format = "N5"
        DataGridViewCellStyle2.NullValue = "0"
        Me.data_length.DefaultCellStyle = DataGridViewCellStyle2
        Me.data_length.HeaderText = "ขนาดข้อมูล(MB)"
        Me.data_length.Name = "data_length"
        Me.data_length.ReadOnly = True
        Me.data_length.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'index_length
        '
        DataGridViewCellStyle3.Format = "N5"
        DataGridViewCellStyle3.NullValue = "0"
        Me.index_length.DefaultCellStyle = DataGridViewCellStyle3
        Me.index_length.HeaderText = "ขนาดอินเด็ก(MB)"
        Me.index_length.Name = "index_length"
        Me.index_length.ReadOnly = True
        Me.index_length.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'status
        '
        Me.status.HeaderText = "สถานะ"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.status.ToolTipText = "เช็คสถานะตาราง"
        '
        'OpimizeDBFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 446)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.MinimumSize = New System.Drawing.Size(700, 400)
        Me.Name = "OpimizeDBFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ปรับปรงฐานข้อมูล"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgData As System.Windows.Forms.DataGridView
    Friend WithEvents btnRepair As System.Windows.Forms.Button
    Friend WithEvents btnOpt As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents lblDetail As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents table_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents table_row As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents data_length As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents index_length As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
