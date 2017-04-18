<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsersFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsersFrm))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PicUsers = New System.Windows.Forms.PictureBox()
        Me.txtUserPasswordC = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtUsernamelogin = New System.Windows.Forms.TextBox()
        Me.txtUserPassword = New System.Windows.Forms.TextBox()
        Me.txtUserEmail = New System.Windows.Forms.TextBox()
        Me.txtUserTel = New System.Windows.Forms.TextBox()
        Me.txtUserAddress = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblUserAddress = New System.Windows.Forms.Label()
        Me.lblUserTel = New System.Windows.Forms.Label()
        Me.lblUserEmail = New System.Windows.Forms.Label()
        Me.lblUserNameLogin = New System.Windows.Forms.Label()
        Me.lblUserPassword = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgUser = New System.Windows.Forms.DataGridView()
        Me.number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_usrnamelogin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_leval = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnselectImage = New System.Windows.Forms.Button()
        Me.GBusers = New System.Windows.Forms.GroupBox()
        Me.RB3 = New System.Windows.Forms.RadioButton()
        Me.RB2 = New System.Windows.Forms.RadioButton()
        Me.RB1 = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EditToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CancelStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BackToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.NextToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ZoomStripButton = New System.Windows.Forms.ToolStripButton()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PicUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GBusers.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.btnHelp})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 484)
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
        'PicUsers
        '
        Me.PicUsers.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PicUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicUsers.Location = New System.Drawing.Point(0, 0)
        Me.PicUsers.MinimumSize = New System.Drawing.Size(108, 115)
        Me.PicUsers.Name = "PicUsers"
        Me.PicUsers.Size = New System.Drawing.Size(214, 159)
        Me.PicUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicUsers.TabIndex = 1
        Me.PicUsers.TabStop = False
        '
        'txtUserPasswordC
        '
        Me.txtUserPasswordC.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtUserPasswordC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUserPasswordC.Location = New System.Drawing.Point(352, 159)
        Me.txtUserPasswordC.Name = "txtUserPasswordC"
        Me.txtUserPasswordC.Size = New System.Drawing.Size(200, 26)
        Me.txtUserPasswordC.TabIndex = 7
        Me.txtUserPasswordC.UseSystemPasswordChar = True
        '
        'txtUserID
        '
        Me.txtUserID.Enabled = False
        Me.txtUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(9, 65)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Size = New System.Drawing.Size(92, 26)
        Me.txtUserID.TabIndex = 0
        '
        'txtUsernamelogin
        '
        Me.txtUsernamelogin.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtUsernamelogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUsernamelogin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUsernamelogin.Location = New System.Drawing.Point(352, 65)
        Me.txtUsernamelogin.Name = "txtUsernamelogin"
        Me.txtUsernamelogin.Size = New System.Drawing.Size(200, 26)
        Me.txtUsernamelogin.TabIndex = 5
        '
        'txtUserPassword
        '
        Me.txtUserPassword.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtUserPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUserPassword.Location = New System.Drawing.Point(352, 112)
        Me.txtUserPassword.Name = "txtUserPassword"
        Me.txtUserPassword.Size = New System.Drawing.Size(200, 26)
        Me.txtUserPassword.TabIndex = 6
        Me.txtUserPassword.UseSystemPasswordChar = True
        '
        'txtUserEmail
        '
        Me.txtUserEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUserEmail.Location = New System.Drawing.Point(178, 159)
        Me.txtUserEmail.Name = "txtUserEmail"
        Me.txtUserEmail.Size = New System.Drawing.Size(163, 26)
        Me.txtUserEmail.TabIndex = 4
        '
        'txtUserTel
        '
        Me.txtUserTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUserTel.Location = New System.Drawing.Point(9, 159)
        Me.txtUserTel.Name = "txtUserTel"
        Me.txtUserTel.Size = New System.Drawing.Size(163, 26)
        Me.txtUserTel.TabIndex = 3
        '
        'txtUserAddress
        '
        Me.txtUserAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUserAddress.Location = New System.Drawing.Point(9, 112)
        Me.txtUserAddress.Name = "txtUserAddress"
        Me.txtUserAddress.Size = New System.Drawing.Size(332, 26)
        Me.txtUserAddress.TabIndex = 2
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(107, 65)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(234, 26)
        Me.txtUsername.TabIndex = 1
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(6, 47)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(19, 15)
        Me.lblUserID.TabIndex = 9
        Me.lblUserID.Text = "ID"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(104, 47)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(37, 15)
        Me.lblUserName.TabIndex = 10
        Me.lblUserName.Text = "ชื่อจริง"
        '
        'lblUserAddress
        '
        Me.lblUserAddress.AutoSize = True
        Me.lblUserAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUserAddress.Location = New System.Drawing.Point(9, 94)
        Me.lblUserAddress.Name = "lblUserAddress"
        Me.lblUserAddress.Size = New System.Drawing.Size(27, 15)
        Me.lblUserAddress.TabIndex = 11
        Me.lblUserAddress.Text = "ที่อยู่"
        '
        'lblUserTel
        '
        Me.lblUserTel.AutoSize = True
        Me.lblUserTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUserTel.Location = New System.Drawing.Point(6, 141)
        Me.lblUserTel.Name = "lblUserTel"
        Me.lblUserTel.Size = New System.Drawing.Size(72, 15)
        Me.lblUserTel.TabIndex = 12
        Me.lblUserTel.Text = "เบอร์โทรศัพท์"
        '
        'lblUserEmail
        '
        Me.lblUserEmail.AutoSize = True
        Me.lblUserEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUserEmail.Location = New System.Drawing.Point(178, 141)
        Me.lblUserEmail.Name = "lblUserEmail"
        Me.lblUserEmail.Size = New System.Drawing.Size(31, 15)
        Me.lblUserEmail.TabIndex = 13
        Me.lblUserEmail.Text = "อีเมล์"
        '
        'lblUserNameLogin
        '
        Me.lblUserNameLogin.AutoSize = True
        Me.lblUserNameLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUserNameLogin.Location = New System.Drawing.Point(349, 47)
        Me.lblUserNameLogin.Name = "lblUserNameLogin"
        Me.lblUserNameLogin.Size = New System.Drawing.Size(134, 15)
        Me.lblUserNameLogin.TabIndex = 14
        Me.lblUserNameLogin.Text = "ชื่อสำหรับเข้าระบบ(อังกฤษ)"
        '
        'lblUserPassword
        '
        Me.lblUserPassword.AutoSize = True
        Me.lblUserPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUserPassword.Location = New System.Drawing.Point(349, 94)
        Me.lblUserPassword.Name = "lblUserPassword"
        Me.lblUserPassword.Size = New System.Drawing.Size(46, 15)
        Me.lblUserPassword.TabIndex = 15
        Me.lblUserPassword.Text = "รหัสผ่าน"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(349, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "ยืนยันรหัสผ่าน"
        '
        'dgUser
        '
        Me.dgUser.AllowUserToAddRows = False
        Me.dgUser.AllowUserToDeleteRows = False
        Me.dgUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgUser.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.number, Me.user_id, Me.user_name, Me.user_address, Me.user_tel, Me.user_email, Me.user_usrnamelogin, Me.user_leval})
        Me.dgUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgUser.Location = New System.Drawing.Point(0, 0)
        Me.dgUser.MultiSelect = False
        Me.dgUser.Name = "dgUser"
        Me.dgUser.ReadOnly = True
        Me.dgUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgUser.Size = New System.Drawing.Size(782, 259)
        Me.dgUser.TabIndex = 0
        '
        'number
        '
        Me.number.HeaderText = "#"
        Me.number.Name = "number"
        Me.number.ReadOnly = True
        Me.number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'user_id
        '
        Me.user_id.HeaderText = "ID"
        Me.user_id.Name = "user_id"
        Me.user_id.ReadOnly = True
        Me.user_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'user_name
        '
        Me.user_name.HeaderText = "ชื่อ-สกุล"
        Me.user_name.Name = "user_name"
        Me.user_name.ReadOnly = True
        Me.user_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'user_address
        '
        Me.user_address.HeaderText = "ที่อยู่"
        Me.user_address.Name = "user_address"
        Me.user_address.ReadOnly = True
        Me.user_address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'user_tel
        '
        Me.user_tel.HeaderText = "เบอร์โทรศัพท์"
        Me.user_tel.Name = "user_tel"
        Me.user_tel.ReadOnly = True
        Me.user_tel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'user_email
        '
        Me.user_email.HeaderText = "อีเมล์"
        Me.user_email.Name = "user_email"
        Me.user_email.ReadOnly = True
        Me.user_email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'user_usrnamelogin
        '
        Me.user_usrnamelogin.HeaderText = "ชื่อเข้าระบบ"
        Me.user_usrnamelogin.Name = "user_usrnamelogin"
        Me.user_usrnamelogin.ReadOnly = True
        Me.user_usrnamelogin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'user_leval
        '
        Me.user_leval.HeaderText = "ระดับ"
        Me.user_leval.Name = "user_leval"
        Me.user_leval.ReadOnly = True
        Me.user_leval.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgUser)
        Me.SplitContainer1.Size = New System.Drawing.Size(784, 484)
        Me.SplitContainer1.SplitterDistance = 219
        Me.SplitContainer1.TabIndex = 70
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.PicUsers)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtUserID)
        Me.SplitContainer2.Panel2.Controls.Add(Me.GBusers)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lblUserID)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtUserPasswordC)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtUserTel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lblUserName)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lblUserAddress)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtUsername)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtUsernamelogin)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lblUserPassword)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lblUserTel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtUserAddress)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtUserPassword)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lblUserNameLogin)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lblUserEmail)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtUserEmail)
        Me.SplitContainer2.Size = New System.Drawing.Size(784, 194)
        Me.SplitContainer2.SplitterDistance = 216
        Me.SplitContainer2.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnselectImage)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 159)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(214, 33)
        Me.Panel1.TabIndex = 0
        '
        'btnselectImage
        '
        Me.btnselectImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnselectImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnselectImage.Image = Global.ServiceTicker.My.Resources.Resources.Camera_16xLG
        Me.btnselectImage.Location = New System.Drawing.Point(167, 3)
        Me.btnselectImage.Name = "btnselectImage"
        Me.btnselectImage.Size = New System.Drawing.Size(44, 27)
        Me.btnselectImage.TabIndex = 0
        Me.btnselectImage.UseVisualStyleBackColor = True
        '
        'GBusers
        '
        Me.GBusers.Controls.Add(Me.RB3)
        Me.GBusers.Controls.Add(Me.RB2)
        Me.GBusers.Controls.Add(Me.RB1)
        Me.GBusers.Location = New System.Drawing.Point(3, 3)
        Me.GBusers.Name = "GBusers"
        Me.GBusers.Size = New System.Drawing.Size(283, 43)
        Me.GBusers.TabIndex = 8
        Me.GBusers.TabStop = False
        Me.GBusers.Text = "สิทธิการใช้งานระบบ"
        '
        'RB3
        '
        Me.RB3.AutoSize = True
        Me.RB3.Location = New System.Drawing.Point(199, 20)
        Me.RB3.Name = "RB3"
        Me.RB3.Size = New System.Drawing.Size(78, 17)
        Me.RB3.TabIndex = 2
        Me.RB3.TabStop = True
        Me.RB3.Text = "ผู้ดูแลระบบ"
        Me.RB3.UseVisualStyleBackColor = True
        '
        'RB2
        '
        Me.RB2.AutoSize = True
        Me.RB2.Location = New System.Drawing.Point(110, 20)
        Me.RB2.Name = "RB2"
        Me.RB2.Size = New System.Drawing.Size(58, 17)
        Me.RB2.TabIndex = 1
        Me.RB2.TabStop = True
        Me.RB2.Text = "หัวหน้า"
        Me.RB2.UseVisualStyleBackColor = True
        '
        'RB1
        '
        Me.RB1.AutoSize = True
        Me.RB1.Checked = True
        Me.RB1.Location = New System.Drawing.Point(6, 20)
        Me.RB1.Name = "RB1"
        Me.RB1.Size = New System.Drawing.Size(63, 17)
        Me.RB1.TabIndex = 0
        Me.RB1.TabStop = True
        Me.RB1.Text = "ผู้ใช้งาน"
        Me.RB1.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AllowMerge = False
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.EditToolStripButton, Me.SaveToolStripButton, Me.CancelStripButton, Me.ToolStripSeparator1, Me.DeleteToolStripButton, Me.toolStripSeparator, Me.BackToolStripButton, Me.NextToolStripButton, Me.ToolStripSeparator2, Me.ZoomStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(784, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "เพิ่ม"
        '
        'EditToolStripButton
        '
        Me.EditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.PencilAngled_16xLG_color
        Me.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditToolStripButton.Name = "EditToolStripButton"
        Me.EditToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.EditToolStripButton.Text = "แก้ไข"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "บันทึก"
        '
        'CancelStripButton
        '
        Me.CancelStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CancelStripButton.Image = Global.ServiceTicker.My.Resources.Resources.Undo_16x
        Me.CancelStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelStripButton.Name = "CancelStripButton"
        Me.CancelStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CancelStripButton.Text = "ยกเลิก"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'DeleteToolStripButton
        '
        Me.DeleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DeleteToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.action_Cancel_16xLG
        Me.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteToolStripButton.Name = "DeleteToolStripButton"
        Me.DeleteToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.DeleteToolStripButton.Text = "ลบ"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BackToolStripButton
        '
        Me.BackToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BackToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.arrow_back_color_16xLG
        Me.BackToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BackToolStripButton.Name = "BackToolStripButton"
        Me.BackToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.BackToolStripButton.Text = "ก่อนหน้า"
        '
        'NextToolStripButton
        '
        Me.NextToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NextToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.arrow_Forward_color_16xLG
        Me.NextToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NextToolStripButton.Name = "NextToolStripButton"
        Me.NextToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NextToolStripButton.Text = "ถัดไป"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ZoomStripButton
        '
        Me.ZoomStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ZoomStripButton.Image = Global.ServiceTicker.My.Resources.Resources.Zoom_5442
        Me.ZoomStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ZoomStripButton.Name = "ZoomStripButton"
        Me.ZoomStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ZoomStripButton.Text = "ZoomStripButton1"
        Me.ZoomStripButton.ToolTipText = "ดูรูปแบบขยาย"
        '
        'btnHelp
        '
        Me.btnHelp.Image = Global.ServiceTicker.My.Resources.Resources._109_AllAnnotations_Help_16x16_72
        Me.btnHelp.IsLink = True
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(16, 17)
        Me.btnHelp.ToolTipText = "Help"
        '
        'UsersFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 506)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.MinimumSize = New System.Drawing.Size(600, 500)
        Me.Name = "UsersFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ผู้ใช้งาน"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PicUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GBusers.ResumeLayout(False)
        Me.GBusers.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PicUsers As System.Windows.Forms.PictureBox
    Friend WithEvents txtUserPasswordC As System.Windows.Forms.TextBox
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents txtUsernamelogin As System.Windows.Forms.TextBox
    Friend WithEvents txtUserPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUserEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtUserTel As System.Windows.Forms.TextBox
    Friend WithEvents txtUserAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblUserAddress As System.Windows.Forms.Label
    Friend WithEvents lblUserTel As System.Windows.Forms.Label
    Friend WithEvents lblUserEmail As System.Windows.Forms.Label
    Friend WithEvents lblUserNameLogin As System.Windows.Forms.Label
    Friend WithEvents lblUserPassword As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgUser As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GBusers As System.Windows.Forms.GroupBox
    Friend WithEvents RB3 As System.Windows.Forms.RadioButton
    Friend WithEvents RB2 As System.Windows.Forms.RadioButton
    Friend WithEvents RB1 As System.Windows.Forms.RadioButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DeleteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BackToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents NextToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ZoomStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CancelStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents user_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents user_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents user_address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents user_tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents user_email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents user_usrnamelogin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents user_leval As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnselectImage As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
