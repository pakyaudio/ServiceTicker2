<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class logsFrm
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cbbYear = New System.Windows.Forms.ComboBox()
        Me.cbbMonth = New System.Windows.Forms.ComboBox()
        Me.dgLOGSdata = New System.Windows.Forms.DataGridView()
        Me.user_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_usernamelogin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_in = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgLOGSdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(694, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblEmployee
        '
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(35, 17)
        Me.lblEmployee.Text = "Users"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnHelp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSearch)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbbYear)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbbMonth)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgLOGSdata)
        Me.SplitContainer1.Size = New System.Drawing.Size(694, 539)
        Me.SplitContainer1.SplitterDistance = 32
        Me.SplitContainer1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "เดือน"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(177, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ปี"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(288, 9)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "แสดงผล"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cbbYear
        '
        Me.cbbYear.FormattingEnabled = True
        Me.cbbYear.Location = New System.Drawing.Point(201, 11)
        Me.cbbYear.Name = "cbbYear"
        Me.cbbYear.Size = New System.Drawing.Size(81, 21)
        Me.cbbYear.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cbbYear, "เลือกปี")
        '
        'cbbMonth
        '
        Me.cbbMonth.FormattingEnabled = True
        Me.cbbMonth.Location = New System.Drawing.Point(50, 11)
        Me.cbbMonth.Name = "cbbMonth"
        Me.cbbMonth.Size = New System.Drawing.Size(121, 21)
        Me.cbbMonth.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.cbbMonth, "เลือกเดือน")
        '
        'dgLOGSdata
        '
        Me.dgLOGSdata.AllowUserToAddRows = False
        Me.dgLOGSdata.AllowUserToDeleteRows = False
        Me.dgLOGSdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgLOGSdata.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgLOGSdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLOGSdata.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.user_id, Me.user_name, Me.user_usernamelogin, Me.note, Me.date_in})
        Me.dgLOGSdata.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgLOGSdata.Location = New System.Drawing.Point(0, 0)
        Me.dgLOGSdata.Name = "dgLOGSdata"
        Me.dgLOGSdata.ReadOnly = True
        Me.dgLOGSdata.RowHeadersWidth = 20
        Me.dgLOGSdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgLOGSdata.Size = New System.Drawing.Size(694, 503)
        Me.dgLOGSdata.TabIndex = 0
        '
        'user_id
        '
        Me.user_id.HeaderText = "รหัสผู้ใช้"
        Me.user_id.Name = "user_id"
        Me.user_id.ReadOnly = True
        Me.user_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'user_name
        '
        Me.user_name.HeaderText = "ชื่อ"
        Me.user_name.Name = "user_name"
        Me.user_name.ReadOnly = True
        Me.user_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'user_usernamelogin
        '
        Me.user_usernamelogin.HeaderText = "ชื่อสำหรับเข้าระบบ"
        Me.user_usernamelogin.Name = "user_usernamelogin"
        Me.user_usernamelogin.ReadOnly = True
        Me.user_usernamelogin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'note
        '
        Me.note.HeaderText = "เมนู"
        Me.note.Name = "note"
        Me.note.ReadOnly = True
        Me.note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'date_in
        '
        Me.date_in.HeaderText = "วันที่เข้าระบบ"
        Me.date_in.Name = "date_in"
        Me.date_in.ReadOnly = True
        Me.date_in.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.Image = Global.ServiceTicker.My.Resources.Resources._109_AllAnnotations_Help_16x16_72
        Me.btnHelp.Location = New System.Drawing.Point(667, 3)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(24, 26)
        Me.btnHelp.TabIndex = 5
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'logsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 561)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "logsFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "บันทึกการเข้าใช้งาน"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgLOGSdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cbbYear As System.Windows.Forms.ComboBox
    Friend WithEvents cbbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents dgLOGSdata As System.Windows.Forms.DataGridView
    Friend WithEvents user_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents user_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents user_usernamelogin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents note As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_in As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.Button
End Class
