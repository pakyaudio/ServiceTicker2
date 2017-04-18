<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartAddNewUserFrm
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
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.txtUserPasswordC = New System.Windows.Forms.TextBox()
        Me.txtUserTel = New System.Windows.Forms.TextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUserAddress = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtUsernamelogin = New System.Windows.Forms.TextBox()
        Me.lblUserPassword = New System.Windows.Forms.Label()
        Me.lblUserTel = New System.Windows.Forms.Label()
        Me.txtUserAddress = New System.Windows.Forms.TextBox()
        Me.txtUserPassword = New System.Windows.Forms.TextBox()
        Me.lblUserNameLogin = New System.Windows.Forms.Label()
        Me.lblUserEmail = New System.Windows.Forms.Label()
        Me.txtUserEmail = New System.Windows.Forms.TextBox()
        Me.PicUsers = New System.Windows.Forms.PictureBox()
        Me.btnselectImage = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PicUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUserID
        '
        Me.txtUserID.Enabled = False
        Me.txtUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(217, 24)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Size = New System.Drawing.Size(92, 26)
        Me.txtUserID.TabIndex = 17
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(214, 6)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(19, 15)
        Me.lblUserID.TabIndex = 25
        Me.lblUserID.Text = "ID"
        '
        'txtUserPasswordC
        '
        Me.txtUserPasswordC.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtUserPasswordC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUserPasswordC.Location = New System.Drawing.Point(560, 118)
        Me.txtUserPasswordC.Name = "txtUserPasswordC"
        Me.txtUserPasswordC.Size = New System.Drawing.Size(200, 26)
        Me.txtUserPasswordC.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txtUserPasswordC, "ยืนยันรหัสผ่านสำหรับเข้าระบบ")
        Me.txtUserPasswordC.UseSystemPasswordChar = True
        '
        'txtUserTel
        '
        Me.txtUserTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUserTel.Location = New System.Drawing.Point(217, 118)
        Me.txtUserTel.Name = "txtUserTel"
        Me.txtUserTel.Size = New System.Drawing.Size(163, 26)
        Me.txtUserTel.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtUserTel, "เบอร์โทรศัพท์ผู้ใช้งาน")
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(312, 6)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(37, 15)
        Me.lblUserName.TabIndex = 26
        Me.lblUserName.Text = "ชื่อจริง"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(557, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "ยืนยันรหัสผ่าน"
        '
        'lblUserAddress
        '
        Me.lblUserAddress.AutoSize = True
        Me.lblUserAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUserAddress.Location = New System.Drawing.Point(217, 53)
        Me.lblUserAddress.Name = "lblUserAddress"
        Me.lblUserAddress.Size = New System.Drawing.Size(27, 15)
        Me.lblUserAddress.TabIndex = 27
        Me.lblUserAddress.Text = "ที่อยู่"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(315, 24)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(234, 26)
        Me.txtUsername.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtUsername, "ชื่อจริง - นามสกุล")
        '
        'txtUsernamelogin
        '
        Me.txtUsernamelogin.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtUsernamelogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUsernamelogin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUsernamelogin.Location = New System.Drawing.Point(560, 24)
        Me.txtUsernamelogin.Name = "txtUsernamelogin"
        Me.txtUsernamelogin.Size = New System.Drawing.Size(200, 26)
        Me.txtUsernamelogin.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.txtUsernamelogin, "ชื่อสำหรับเข้าระบบ ภาษาอังกฤษเท่านั้น")
        '
        'lblUserPassword
        '
        Me.lblUserPassword.AutoSize = True
        Me.lblUserPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUserPassword.Location = New System.Drawing.Point(557, 53)
        Me.lblUserPassword.Name = "lblUserPassword"
        Me.lblUserPassword.Size = New System.Drawing.Size(46, 15)
        Me.lblUserPassword.TabIndex = 31
        Me.lblUserPassword.Text = "รหัสผ่าน"
        '
        'lblUserTel
        '
        Me.lblUserTel.AutoSize = True
        Me.lblUserTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUserTel.Location = New System.Drawing.Point(214, 100)
        Me.lblUserTel.Name = "lblUserTel"
        Me.lblUserTel.Size = New System.Drawing.Size(72, 15)
        Me.lblUserTel.TabIndex = 28
        Me.lblUserTel.Text = "เบอร์โทรศัพท์"
        '
        'txtUserAddress
        '
        Me.txtUserAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUserAddress.Location = New System.Drawing.Point(217, 71)
        Me.txtUserAddress.Name = "txtUserAddress"
        Me.txtUserAddress.Size = New System.Drawing.Size(332, 26)
        Me.txtUserAddress.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtUserAddress, "ที่อยู่ผู้ใช้งาน")
        '
        'txtUserPassword
        '
        Me.txtUserPassword.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtUserPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUserPassword.Location = New System.Drawing.Point(560, 71)
        Me.txtUserPassword.Name = "txtUserPassword"
        Me.txtUserPassword.Size = New System.Drawing.Size(200, 26)
        Me.txtUserPassword.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtUserPassword, "รหัสผ่านสำหรับเข้าระบบ")
        Me.txtUserPassword.UseSystemPasswordChar = True
        '
        'lblUserNameLogin
        '
        Me.lblUserNameLogin.AutoSize = True
        Me.lblUserNameLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUserNameLogin.Location = New System.Drawing.Point(557, 6)
        Me.lblUserNameLogin.Name = "lblUserNameLogin"
        Me.lblUserNameLogin.Size = New System.Drawing.Size(134, 15)
        Me.lblUserNameLogin.TabIndex = 30
        Me.lblUserNameLogin.Text = "ชื่อสำหรับเข้าระบบ(อังกฤษ)"
        '
        'lblUserEmail
        '
        Me.lblUserEmail.AutoSize = True
        Me.lblUserEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblUserEmail.Location = New System.Drawing.Point(386, 100)
        Me.lblUserEmail.Name = "lblUserEmail"
        Me.lblUserEmail.Size = New System.Drawing.Size(31, 15)
        Me.lblUserEmail.TabIndex = 29
        Me.lblUserEmail.Text = "อีเมล์"
        '
        'txtUserEmail
        '
        Me.txtUserEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUserEmail.Location = New System.Drawing.Point(386, 118)
        Me.txtUserEmail.Name = "txtUserEmail"
        Me.txtUserEmail.Size = New System.Drawing.Size(163, 26)
        Me.txtUserEmail.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtUserEmail, "อีเมล์")
        '
        'PicUsers
        '
        Me.PicUsers.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PicUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicUsers.Location = New System.Drawing.Point(12, 6)
        Me.PicUsers.MinimumSize = New System.Drawing.Size(108, 115)
        Me.PicUsers.Name = "PicUsers"
        Me.PicUsers.Size = New System.Drawing.Size(196, 159)
        Me.PicUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicUsers.TabIndex = 33
        Me.PicUsers.TabStop = False
        '
        'btnselectImage
        '
        Me.btnselectImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnselectImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnselectImage.Image = Global.ServiceTicker.My.Resources.Resources.Camera_16xLG
        Me.btnselectImage.Location = New System.Drawing.Point(164, 171)
        Me.btnselectImage.Name = "btnselectImage"
        Me.btnselectImage.Size = New System.Drawing.Size(44, 27)
        Me.btnselectImage.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.btnselectImage, "เลือกรูปภาพประจำตัวผู้ใช้งาน")
        Me.btnselectImage.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSave.Location = New System.Drawing.Point(659, 166)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(101, 32)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "บันทึก"
        Me.ToolTip1.SetToolTip(Me.btnSave, "บันทึกผู้ใช้งาน")
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'StartAddNewUserFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 200)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnselectImage)
        Me.Controls.Add(Me.PicUsers)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.txtUserPasswordC)
        Me.Controls.Add(Me.txtUserTel)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUserAddress)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtUsernamelogin)
        Me.Controls.Add(Me.lblUserPassword)
        Me.Controls.Add(Me.lblUserTel)
        Me.Controls.Add(Me.txtUserAddress)
        Me.Controls.Add(Me.txtUserPassword)
        Me.Controls.Add(Me.lblUserNameLogin)
        Me.Controls.Add(Me.lblUserEmail)
        Me.Controls.Add(Me.txtUserEmail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StartAddNewUserFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เริ่มต้นโปรแกรม สร้างผู้ดูแลระบบ"
        CType(Me.PicUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents txtUserPasswordC As System.Windows.Forms.TextBox
    Friend WithEvents txtUserTel As System.Windows.Forms.TextBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblUserAddress As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtUsernamelogin As System.Windows.Forms.TextBox
    Friend WithEvents lblUserPassword As System.Windows.Forms.Label
    Friend WithEvents lblUserTel As System.Windows.Forms.Label
    Friend WithEvents txtUserAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtUserPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblUserNameLogin As System.Windows.Forms.Label
    Friend WithEvents lblUserEmail As System.Windows.Forms.Label
    Friend WithEvents txtUserEmail As System.Windows.Forms.TextBox
    Friend WithEvents PicUsers As System.Windows.Forms.PictureBox
    Friend WithEvents btnselectImage As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
