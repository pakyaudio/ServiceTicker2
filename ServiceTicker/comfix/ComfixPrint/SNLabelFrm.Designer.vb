<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SNLabelFrm
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
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbLable = New System.Windows.Forms.CheckBox()
        Me.rbRanDom = New System.Windows.Forms.RadioButton()
        Me.rbCount = New System.Windows.Forms.RadioButton()
        Me.rbOneNum = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.cbbRandom = New System.Windows.Forms.ComboBox()
        Me.txtCountEnd = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCountStart = New System.Windows.Forms.TextBox()
        Me.txtOneNum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFrontNum = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SnLabelDataSet1 = New ServiceTicker.snLabelDataSet()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SnLabelDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.btnHelp})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.TabIndex = 2
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cbLable)
        Me.Panel1.Controls.Add(Me.rbRanDom)
        Me.Panel1.Controls.Add(Me.rbCount)
        Me.Panel1.Controls.Add(Me.rbOneNum)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.NumericUpDown2)
        Me.Panel1.Controls.Add(Me.cbbRandom)
        Me.Panel1.Controls.Add(Me.txtCountEnd)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtCountStart)
        Me.Panel1.Controls.Add(Me.txtOneNum)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtFrontNum)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.NumericUpDown1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 69)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(261, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(254, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "จำนวนบาร์โค๊ตสูงสุด 10 ตัว (รหัสนำหหน้า + รหัสอื่น ๆ)"
        '
        'cbLable
        '
        Me.cbLable.AutoSize = True
        Me.cbLable.Checked = True
        Me.cbLable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbLable.Location = New System.Drawing.Point(168, 17)
        Me.cbLable.Name = "cbLable"
        Me.cbLable.Size = New System.Drawing.Size(71, 17)
        Me.cbLable.TabIndex = 22
        Me.cbLable.Text = "ป้ายฉลาก"
        Me.cbLable.UseVisualStyleBackColor = True
        '
        'rbRanDom
        '
        Me.rbRanDom.AutoSize = True
        Me.rbRanDom.Checked = True
        Me.rbRanDom.Location = New System.Drawing.Point(494, 41)
        Me.rbRanDom.Name = "rbRanDom"
        Me.rbRanDom.Size = New System.Drawing.Size(38, 17)
        Me.rbRanDom.TabIndex = 21
        Me.rbRanDom.TabStop = True
        Me.rbRanDom.Text = "สุ่ม"
        Me.rbRanDom.UseVisualStyleBackColor = True
        '
        'rbCount
        '
        Me.rbCount.AutoSize = True
        Me.rbCount.Location = New System.Drawing.Point(226, 43)
        Me.rbCount.Name = "rbCount"
        Me.rbCount.Size = New System.Drawing.Size(73, 17)
        Me.rbCount.TabIndex = 20
        Me.rbCount.TabStop = True
        Me.rbCount.Text = "เรียงลำดับ"
        Me.rbCount.UseVisualStyleBackColor = True
        '
        'rbOneNum
        '
        Me.rbOneNum.AutoSize = True
        Me.rbOneNum.Location = New System.Drawing.Point(3, 43)
        Me.rbOneNum.Name = "rbOneNum"
        Me.rbOneNum.Size = New System.Drawing.Size(106, 17)
        Me.rbOneNum.TabIndex = 19
        Me.rbOneNum.TabStop = True
        Me.rbOneNum.Text = "เหมือนกันทั้งหมด"
        Me.rbOneNum.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(657, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "จำนวน"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(703, 41)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(72, 20)
        Me.NumericUpDown2.TabIndex = 17
        Me.NumericUpDown2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cbbRandom
        '
        Me.cbbRandom.FormattingEnabled = True
        Me.cbbRandom.Location = New System.Drawing.Point(538, 40)
        Me.cbbRandom.Name = "cbbRandom"
        Me.cbbRandom.Size = New System.Drawing.Size(113, 21)
        Me.cbbRandom.TabIndex = 16
        '
        'txtCountEnd
        '
        Me.txtCountEnd.Location = New System.Drawing.Point(422, 40)
        Me.txtCountEnd.MaxLength = 10
        Me.txtCountEnd.Name = "txtCountEnd"
        Me.txtCountEnd.Size = New System.Drawing.Size(56, 20)
        Me.txtCountEnd.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(397, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "ถึง"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(304, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "เริ่ม"
        '
        'txtCountStart
        '
        Me.txtCountStart.Location = New System.Drawing.Point(335, 40)
        Me.txtCountStart.MaxLength = 10
        Me.txtCountStart.Name = "txtCountStart"
        Me.txtCountStart.Size = New System.Drawing.Size(56, 20)
        Me.txtCountStart.TabIndex = 11
        '
        'txtOneNum
        '
        Me.txtOneNum.Location = New System.Drawing.Point(116, 40)
        Me.txtOneNum.MaxLength = 10
        Me.txtOneNum.Name = "txtOneNum"
        Me.txtOneNum.Size = New System.Drawing.Size(100, 20)
        Me.txtOneNum.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(368, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "รหัสนำหน้า"
        '
        'txtFrontNum
        '
        Me.txtFrontNum.Location = New System.Drawing.Point(433, 13)
        Me.txtFrontNum.MaxLength = 6
        Me.txtFrontNum.Name = "txtFrontNum"
        Me.txtFrontNum.Size = New System.Drawing.Size(71, 20)
        Me.txtFrontNum.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(673, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "พิมพ์"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(245, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(117, 20)
        Me.TextBox1.TabIndex = 1
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {4, 0, 0, 0})
        Me.NumericUpDown1.Location = New System.Drawing.Point(75, 16)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(87, 20)
        Me.NumericUpDown1.TabIndex = 0
        Me.NumericUpDown1.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "จำนวนฉลาก"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(510, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "แสดงตัวอย่าง"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ขนาด 72 ดวง ต่อ 1 หน้า กระดาษขนาด A4 (4*18 ดวง)"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 69)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowCopyButton = False
        Me.CrystalReportViewer1.ShowExportButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowParameterPanelButton = False
        Me.CrystalReportViewer1.ShowPrintButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(784, 457)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 526)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(784, 13)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 3
        Me.ProgressBar1.Visible = False
        '
        'SnLabelDataSet1
        '
        Me.SnLabelDataSet1.DataSetName = "snLabelDataSet"
        Me.SnLabelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SNLabelFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "SNLabelFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "พิมพ์ฉลาก SN"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SnLabelDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbbRandom As System.Windows.Forms.ComboBox
    Friend WithEvents txtCountEnd As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCountStart As System.Windows.Forms.TextBox
    Friend WithEvents txtOneNum As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFrontNum As System.Windows.Forms.TextBox
    Friend WithEvents rbRanDom As System.Windows.Forms.RadioButton
    Friend WithEvents rbCount As System.Windows.Forms.RadioButton
    Friend WithEvents rbOneNum As System.Windows.Forms.RadioButton
    Friend WithEvents SnLabelDataSet1 As ServiceTicker.snLabelDataSet
    Friend WithEvents cbLable As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
