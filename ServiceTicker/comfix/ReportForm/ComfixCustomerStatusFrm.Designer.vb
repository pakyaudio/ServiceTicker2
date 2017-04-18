<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComfixCustomerStatusFrm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnCCsearch = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnCCgetdata = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgCCcusStatus = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cus_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cus_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_comfix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgCCproHot = New System.Windows.Forms.DataGridView()
        Me.noph = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_buy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgCCcusStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgCCproHot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.btnCCsearch)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.btnCCgetdata)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(765, 31)
        Me.Panel1.TabIndex = 0
        '
        'btnPrint
        '
        Me.btnPrint.Image = Global.ServiceTicker.My.Resources.Resources.PrintStatusBar3_16x
        Me.btnPrint.Location = New System.Drawing.Point(681, 2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 26)
        Me.btnPrint.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnPrint, "พิมพ์รายงาน")
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnCCsearch
        '
        Me.btnCCsearch.Location = New System.Drawing.Point(513, 2)
        Me.btnCCsearch.Name = "btnCCsearch"
        Me.btnCCsearch.Size = New System.Drawing.Size(44, 26)
        Me.btnCCsearch.TabIndex = 3
        Me.btnCCsearch.Text = "ค้นหา"
        Me.ToolTip1.SetToolTip(Me.btnCCsearch, "ค้นหาชื่อลูกค้า")
        Me.btnCCsearch.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(5, 5)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox1.Size = New System.Drawing.Size(66, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "ตามวันที่"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(281, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ถึง"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = ""
        Me.DateTimePicker2.Location = New System.Drawing.Point(306, 3)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Location = New System.Drawing.Point(75, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 1
        Me.DateTimePicker1.Value = New Date(2015, 11, 2, 15, 44, 53, 0)
        '
        'btnCCgetdata
        '
        Me.btnCCgetdata.Location = New System.Drawing.Point(563, 2)
        Me.btnCCgetdata.Name = "btnCCgetdata"
        Me.btnCCgetdata.Size = New System.Drawing.Size(104, 26)
        Me.btnCCgetdata.TabIndex = 4
        Me.btnCCgetdata.Text = "รวบรวมข้อมูล"
        Me.btnCCgetdata.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.btnHelp})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(765, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblEmployee
        '
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(30, 17)
        Me.lblEmployee.Text = "User"
        '
        'btnHelp
        '
        Me.btnHelp.Image = Global.ServiceTicker.My.Resources.Resources._109_AllAnnotations_Help_16x16_72
        Me.btnHelp.IsLink = True
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(16, 17)
        Me.btnHelp.ToolTipText = "Help"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(765, 508)
        Me.Panel2.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(765, 508)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgCCcusStatus)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(757, 482)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "สถิติลูกค้า(ซ่อม)"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgCCcusStatus
        '
        Me.dgCCcusStatus.AllowUserToAddRows = False
        Me.dgCCcusStatus.AllowUserToDeleteRows = False
        Me.dgCCcusStatus.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCCcusStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCCcusStatus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.cus_id, Me.cus_name, Me.total_comfix, Me.total_price})
        Me.dgCCcusStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCCcusStatus.Location = New System.Drawing.Point(3, 3)
        Me.dgCCcusStatus.Name = "dgCCcusStatus"
        Me.dgCCcusStatus.RowHeadersVisible = False
        Me.dgCCcusStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCCcusStatus.Size = New System.Drawing.Size(751, 476)
        Me.dgCCcusStatus.TabIndex = 0
        '
        'no
        '
        Me.no.HeaderText = "#"
        Me.no.Name = "no"
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.Width = 30
        '
        'cus_id
        '
        Me.cus_id.HeaderText = "รหัสลูกค้า"
        Me.cus_id.Name = "cus_id"
        Me.cus_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cus_id.Width = 140
        '
        'cus_name
        '
        Me.cus_name.HeaderText = "ชื่อลูกค้า"
        Me.cus_name.Name = "cus_name"
        Me.cus_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cus_name.Width = 200
        '
        'total_comfix
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.total_comfix.DefaultCellStyle = DataGridViewCellStyle1
        Me.total_comfix.HeaderText = "จำนวนครังที่เข้ารับบริการ"
        Me.total_comfix.Name = "total_comfix"
        Me.total_comfix.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_comfix.Width = 150
        '
        'total_price
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.total_price.DefaultCellStyle = DataGridViewCellStyle2
        Me.total_price.HeaderText = "รวมราคาที่เข้าใช้บริการ"
        Me.total_price.Name = "total_price"
        Me.total_price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_price.Width = 150
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgCCproHot)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(757, 482)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "สถิติอะไหล่ขายดี"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgCCproHot
        '
        Me.dgCCproHot.AllowUserToAddRows = False
        Me.dgCCproHot.AllowUserToDeleteRows = False
        Me.dgCCproHot.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCCproHot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCCproHot.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.noph, Me.code_pro, Me.name_pro, Me.total_buy})
        Me.dgCCproHot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCCproHot.Location = New System.Drawing.Point(3, 3)
        Me.dgCCproHot.Name = "dgCCproHot"
        Me.dgCCproHot.RowHeadersVisible = False
        Me.dgCCproHot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCCproHot.Size = New System.Drawing.Size(751, 476)
        Me.dgCCproHot.TabIndex = 0
        '
        'noph
        '
        Me.noph.HeaderText = "#"
        Me.noph.Name = "noph"
        Me.noph.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.noph.Width = 30
        '
        'code_pro
        '
        Me.code_pro.HeaderText = "รหัสสินค้า"
        Me.code_pro.Name = "code_pro"
        Me.code_pro.Width = 150
        '
        'name_pro
        '
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro.Width = 250
        '
        'total_buy
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = "0"
        Me.total_buy.DefaultCellStyle = DataGridViewCellStyle3
        Me.total_buy.HeaderText = "จำนวนที่ขายได้"
        Me.total_buy.Name = "total_buy"
        Me.total_buy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_buy.Width = 150
        '
        'ComfixCustomerStatusFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 561)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ComfixCustomerStatusFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "สถิติงานช่าง"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgCCcusStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgCCproHot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnCCsearch As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCCgetdata As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgCCcusStatus As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cus_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cus_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_comfix As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgCCproHot As System.Windows.Forms.DataGridView
    Friend WithEvents noph As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents code_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_buy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
