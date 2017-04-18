<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuditFrm
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
        Me.lblADtime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtADdeliverEvening = New System.Windows.Forms.TextBox()
        Me.txtADdeliverNoon = New System.Windows.Forms.TextBox()
        Me.txtADtotalDeliver = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtADdeliverMorning = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtADlastFd = New System.Windows.Forms.TextBox()
        Me.nudAD1000 = New System.Windows.Forms.NumericUpDown()
        Me.nudAD500 = New System.Windows.Forms.NumericUpDown()
        Me.nudAD100 = New System.Windows.Forms.NumericUpDown()
        Me.nudAD50 = New System.Windows.Forms.NumericUpDown()
        Me.nudAD20 = New System.Windows.Forms.NumericUpDown()
        Me.nudAD10 = New System.Windows.Forms.NumericUpDown()
        Me.nudAD5 = New System.Windows.Forms.NumericUpDown()
        Me.nudAD2 = New System.Windows.Forms.NumericUpDown()
        Me.nudAD1 = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtADtotalAll = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblADdel = New System.Windows.Forms.Label()
        Me.lblADrefresh = New System.Windows.Forms.Label()
        Me.dgAD = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namewiden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.list = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.money = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnADsave = New System.Windows.Forms.Button()
        Me.txtADnote = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtADmoney = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtADlist = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtADnamewiden = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTipAD = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudAD1000, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAD500, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAD100, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAD50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAD20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAD10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAD5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAD2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAD1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgAD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.btnHelp, Me.lblADtime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 268)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(664, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblEmployee
        '
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(30, 17)
        Me.lblEmployee.Text = "User"
        '
        'lblADtime
        '
        Me.lblADtime.Name = "lblADtime"
        Me.lblADtime.Size = New System.Drawing.Size(34, 17)
        Me.lblADtime.Text = "Time"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(664, 268)
        Me.TabControl1.TabIndex = 30
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(656, 242)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ออดิสรายวัน"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.DarkRed
        Me.Label25.Location = New System.Drawing.Point(277, 211)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(352, 13)
        Me.Label25.TabIndex = 38
        Me.Label25.Text = "การบันทึกผลห้ามเกินเที่ยงคืน หากเกินเที่ยงคืน จะตัดยอดเป็นของวันถัดไป"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(396, 175)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(232, 33)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "บันทึกผล"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.txtADdeliverEvening)
        Me.GroupBox3.Controls.Add(Me.txtADdeliverNoon)
        Me.GroupBox3.Controls.Add(Me.txtADtotalDeliver)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txtADdeliverMorning)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 103)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(623, 65)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "เงินสดนำส่ง"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(402, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(27, 13)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = "เย็น"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(521, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(68, 13)
        Me.Label22.TabIndex = 30
        Me.Label22.Text = "รวมเงินนำส่ง"
        '
        'txtADdeliverEvening
        '
        Me.txtADdeliverEvening.Location = New System.Drawing.Point(352, 32)
        Me.txtADdeliverEvening.Name = "txtADdeliverEvening"
        Me.txtADdeliverEvening.Size = New System.Drawing.Size(128, 20)
        Me.txtADdeliverEvening.TabIndex = 31
        Me.txtADdeliverEvening.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtADdeliverNoon
        '
        Me.txtADdeliverNoon.Location = New System.Drawing.Point(274, 32)
        Me.txtADdeliverNoon.Name = "txtADdeliverNoon"
        Me.txtADdeliverNoon.Size = New System.Drawing.Size(73, 20)
        Me.txtADdeliverNoon.TabIndex = 31
        Me.txtADdeliverNoon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtADtotalDeliver
        '
        Me.txtADtotalDeliver.Location = New System.Drawing.Point(486, 32)
        Me.txtADtotalDeliver.Name = "txtADtotalDeliver"
        Me.txtADtotalDeliver.ReadOnly = True
        Me.txtADtotalDeliver.Size = New System.Drawing.Size(131, 20)
        Me.txtADtotalDeliver.TabIndex = 32
        Me.txtADtotalDeliver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(299, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(31, 13)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "เที่ยง"
        '
        'txtADdeliverMorning
        '
        Me.txtADdeliverMorning.Location = New System.Drawing.Point(195, 32)
        Me.txtADdeliverMorning.Name = "txtADdeliverMorning"
        Me.txtADdeliverMorning.Size = New System.Drawing.Size(73, 20)
        Me.txtADdeliverMorning.TabIndex = 30
        Me.txtADdeliverMorning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(221, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(25, 13)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "สาย"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.txtADlastFd)
        Me.GroupBox1.Controls.Add(Me.nudAD1000)
        Me.GroupBox1.Controls.Add(Me.nudAD500)
        Me.GroupBox1.Controls.Add(Me.nudAD100)
        Me.GroupBox1.Controls.Add(Me.nudAD50)
        Me.GroupBox1.Controls.Add(Me.nudAD20)
        Me.GroupBox1.Controls.Add(Me.nudAD10)
        Me.GroupBox1.Controls.Add(Me.nudAD5)
        Me.GroupBox1.Controls.Add(Me.nudAD2)
        Me.GroupBox1.Controls.Add(Me.nudAD1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtADtotalAll)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(623, 91)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เงินสดใช้ทอน ณ สิ้นวัน"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(481, 64)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(76, 13)
        Me.Label26.TabIndex = 33
        Me.Label26.Text = "ผลต่างเงินทอน"
        '
        'txtADlastFd
        '
        Me.txtADlastFd.Location = New System.Drawing.Point(563, 61)
        Me.txtADlastFd.Name = "txtADlastFd"
        Me.txtADlastFd.ReadOnly = True
        Me.txtADlastFd.Size = New System.Drawing.Size(51, 20)
        Me.txtADlastFd.TabIndex = 32
        Me.txtADlastFd.Text = "0"
        Me.txtADlastFd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nudAD1000
        '
        Me.nudAD1000.Location = New System.Drawing.Point(501, 36)
        Me.nudAD1000.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudAD1000.Name = "nudAD1000"
        Me.nudAD1000.Size = New System.Drawing.Size(56, 20)
        Me.nudAD1000.TabIndex = 30
        '
        'nudAD500
        '
        Me.nudAD500.Location = New System.Drawing.Point(439, 36)
        Me.nudAD500.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudAD500.Name = "nudAD500"
        Me.nudAD500.Size = New System.Drawing.Size(56, 20)
        Me.nudAD500.TabIndex = 30
        '
        'nudAD100
        '
        Me.nudAD100.Location = New System.Drawing.Point(377, 36)
        Me.nudAD100.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudAD100.Name = "nudAD100"
        Me.nudAD100.Size = New System.Drawing.Size(56, 20)
        Me.nudAD100.TabIndex = 30
        '
        'nudAD50
        '
        Me.nudAD50.Location = New System.Drawing.Point(315, 36)
        Me.nudAD50.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudAD50.Name = "nudAD50"
        Me.nudAD50.Size = New System.Drawing.Size(56, 20)
        Me.nudAD50.TabIndex = 31
        '
        'nudAD20
        '
        Me.nudAD20.Location = New System.Drawing.Point(253, 36)
        Me.nudAD20.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudAD20.Name = "nudAD20"
        Me.nudAD20.Size = New System.Drawing.Size(56, 20)
        Me.nudAD20.TabIndex = 30
        '
        'nudAD10
        '
        Me.nudAD10.Location = New System.Drawing.Point(191, 36)
        Me.nudAD10.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudAD10.Name = "nudAD10"
        Me.nudAD10.Size = New System.Drawing.Size(56, 20)
        Me.nudAD10.TabIndex = 30
        '
        'nudAD5
        '
        Me.nudAD5.Location = New System.Drawing.Point(129, 36)
        Me.nudAD5.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudAD5.Name = "nudAD5"
        Me.nudAD5.Size = New System.Drawing.Size(56, 20)
        Me.nudAD5.TabIndex = 30
        '
        'nudAD2
        '
        Me.nudAD2.Location = New System.Drawing.Point(67, 36)
        Me.nudAD2.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudAD2.Name = "nudAD2"
        Me.nudAD2.Size = New System.Drawing.Size(56, 20)
        Me.nudAD2.TabIndex = 23
        '
        'nudAD1
        '
        Me.nudAD1.Location = New System.Drawing.Point(4, 36)
        Me.nudAD1.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudAD1.Name = "nudAD1"
        Me.nudAD1.Size = New System.Drawing.Size(57, 20)
        Me.nudAD1.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(576, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "รวม"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(505, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "1,000"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(450, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "500"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(387, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "100"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(328, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "50"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(267, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "20"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(204, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "10"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(146, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "2"
        '
        'txtADtotalAll
        '
        Me.txtADtotalAll.Location = New System.Drawing.Point(563, 35)
        Me.txtADtotalAll.Name = "txtADtotalAll"
        Me.txtADtotalAll.ReadOnly = True
        Me.txtADtotalAll.Size = New System.Drawing.Size(51, 20)
        Me.txtADtotalAll.TabIndex = 11
        Me.txtADtotalAll.Text = "0"
        Me.txtADtotalAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "1"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblADdel)
        Me.TabPage2.Controls.Add(Me.lblADrefresh)
        Me.TabPage2.Controls.Add(Me.dgAD)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.btnADsave)
        Me.TabPage2.Controls.Add(Me.txtADnote)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.txtADmoney)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.txtADlist)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.txtADnamewiden)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(656, 242)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "บันทึกค่าใช้จ่ายรายวัน"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lblADdel
        '
        Me.lblADdel.AutoSize = True
        Me.lblADdel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblADdel.Location = New System.Drawing.Point(701, 246)
        Me.lblADdel.Name = "lblADdel"
        Me.lblADdel.Size = New System.Drawing.Size(45, 13)
        Me.lblADdel.TabIndex = 11
        Me.lblADdel.Text = "ลบข้อมูล"
        '
        'lblADrefresh
        '
        Me.lblADrefresh.AutoSize = True
        Me.lblADrefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblADrefresh.Location = New System.Drawing.Point(6, 246)
        Me.lblADrefresh.Name = "lblADrefresh"
        Me.lblADrefresh.Size = New System.Drawing.Size(97, 13)
        Me.lblADrefresh.TabIndex = 10
        Me.lblADrefresh.Text = "กดเพื่อดึงข้อมูลใหม่"
        '
        'dgAD
        '
        Me.dgAD.AllowUserToAddRows = False
        Me.dgAD.AllowUserToDeleteRows = False
        Me.dgAD.AllowUserToOrderColumns = True
        Me.dgAD.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAD.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.namewiden, Me.list, Me.money, Me.note})
        Me.dgAD.Location = New System.Drawing.Point(6, 45)
        Me.dgAD.MultiSelect = False
        Me.dgAD.Name = "dgAD"
        Me.dgAD.ReadOnly = True
        Me.dgAD.RowHeadersVisible = False
        Me.dgAD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgAD.Size = New System.Drawing.Size(623, 147)
        Me.dgAD.TabIndex = 9
        '
        'no
        '
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 30
        '
        'namewiden
        '
        Me.namewiden.HeaderText = "ชื่อผู้เบิก"
        Me.namewiden.Name = "namewiden"
        Me.namewiden.ReadOnly = True
        Me.namewiden.Width = 180
        '
        'list
        '
        Me.list.HeaderText = "รายการ"
        Me.list.Name = "list"
        Me.list.ReadOnly = True
        Me.list.Width = 250
        '
        'money
        '
        Me.money.HeaderText = "จำนวนเงิน"
        Me.money.Name = "money"
        Me.money.ReadOnly = True
        '
        'note
        '
        Me.note.HeaderText = "หมายเหตุ"
        Me.note.Name = "note"
        Me.note.ReadOnly = True
        Me.note.Width = 140
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(566, 3)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 13)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "หมายเหตุ"
        '
        'btnADsave
        '
        Me.btnADsave.Location = New System.Drawing.Point(575, 198)
        Me.btnADsave.Name = "btnADsave"
        Me.btnADsave.Size = New System.Drawing.Size(54, 23)
        Me.btnADsave.TabIndex = 7
        Me.btnADsave.Text = "บันทึก"
        Me.btnADsave.UseVisualStyleBackColor = True
        '
        'txtADnote
        '
        Me.txtADnote.Location = New System.Drawing.Point(543, 19)
        Me.txtADnote.Name = "txtADnote"
        Me.txtADnote.Size = New System.Drawing.Size(89, 20)
        Me.txtADnote.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(467, 3)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 13)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "จำนวน/บาท"
        '
        'txtADmoney
        '
        Me.txtADmoney.Location = New System.Drawing.Point(460, 19)
        Me.txtADmoney.Name = "txtADmoney"
        Me.txtADmoney.Size = New System.Drawing.Size(77, 20)
        Me.txtADmoney.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(277, 3)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "รายการ/ชำระค่า"
        '
        'txtADlist
        '
        Me.txtADlist.Location = New System.Drawing.Point(169, 19)
        Me.txtADlist.Name = "txtADlist"
        Me.txtADlist.Size = New System.Drawing.Size(285, 20)
        Me.txtADlist.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(62, 3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "ชื่อผู้เบิก"
        '
        'txtADnamewiden
        '
        Me.txtADnamewiden.Location = New System.Drawing.Point(9, 19)
        Me.txtADnamewiden.Name = "txtADnamewiden"
        Me.txtADnamewiden.Size = New System.Drawing.Size(154, 20)
        Me.txtADnamewiden.TabIndex = 0
        '
        'Timer1
        '
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
        'AuditFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 290)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "AuditFrm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ตรวจสอบบัญชี (Audit)"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudAD1000, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAD500, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAD100, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAD50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAD20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAD10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAD5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAD2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAD1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgAD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblADtime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtADdeliverEvening As System.Windows.Forms.TextBox
    Friend WithEvents txtADdeliverNoon As System.Windows.Forms.TextBox
    Friend WithEvents txtADtotalDeliver As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtADdeliverMorning As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtADlastFd As System.Windows.Forms.TextBox
    Friend WithEvents nudAD1000 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudAD500 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudAD100 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudAD50 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudAD20 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudAD10 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudAD5 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudAD2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudAD1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtADtotalAll As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lblADdel As System.Windows.Forms.Label
    Friend WithEvents lblADrefresh As System.Windows.Forms.Label
    Friend WithEvents dgAD As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namewiden As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents list As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents money As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents note As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnADsave As System.Windows.Forms.Button
    Friend WithEvents txtADnote As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtADmoney As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtADlist As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtADnamewiden As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolTipAD As System.Windows.Forms.ToolTip
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
