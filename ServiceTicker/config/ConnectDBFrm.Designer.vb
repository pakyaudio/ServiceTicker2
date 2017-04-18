<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConnectDBFrm
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtDBCservername = New System.Windows.Forms.TextBox()
        Me.txtDBCusername = New System.Windows.Forms.TextBox()
        Me.txtDBCpassword = New System.Windows.Forms.TextBox()
        Me.txtDBCport = New System.Windows.Forms.TextBox()
        Me.btnDBCtest = New System.Windows.Forms.Button()
        Me.btnDBCsave = New System.Windows.Forms.Button()
        Me.btnInstallDB = New System.Windows.Forms.Button()
        Me.btnSearchComputer = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbbDataBaseName = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtDBCservername
        '
        Me.txtDBCservername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDBCservername.Location = New System.Drawing.Point(171, 6)
        Me.txtDBCservername.Name = "txtDBCservername"
        Me.txtDBCservername.Size = New System.Drawing.Size(215, 26)
        Me.txtDBCservername.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtDBCservername, "เครื่องแม่ข่าย เช่น localhost,192.168.1.1")
        '
        'txtDBCusername
        '
        Me.txtDBCusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDBCusername.Location = New System.Drawing.Point(171, 38)
        Me.txtDBCusername.Name = "txtDBCusername"
        Me.txtDBCusername.Size = New System.Drawing.Size(215, 26)
        Me.txtDBCusername.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtDBCusername, "ชื่อผู้ใช้ฐานข้อมูล เช่น root")
        '
        'txtDBCpassword
        '
        Me.txtDBCpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDBCpassword.Location = New System.Drawing.Point(171, 70)
        Me.txtDBCpassword.Name = "txtDBCpassword"
        Me.txtDBCpassword.Size = New System.Drawing.Size(215, 26)
        Me.txtDBCpassword.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtDBCpassword, "รหัสผ่านฐานข้อมูล")
        Me.txtDBCpassword.UseSystemPasswordChar = True
        '
        'txtDBCport
        '
        Me.txtDBCport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDBCport.Location = New System.Drawing.Point(171, 136)
        Me.txtDBCport.Name = "txtDBCport"
        Me.txtDBCport.Size = New System.Drawing.Size(76, 26)
        Me.txtDBCport.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtDBCport, "พอร์ตที่ใช้เชื่อมต่อ เช่น 3306")
        '
        'btnDBCtest
        '
        Me.btnDBCtest.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnDBCtest.Location = New System.Drawing.Point(452, 6)
        Me.btnDBCtest.Name = "btnDBCtest"
        Me.btnDBCtest.Size = New System.Drawing.Size(62, 40)
        Me.btnDBCtest.TabIndex = 6
        Me.btnDBCtest.Text = "ทดสอบ"
        Me.ToolTip1.SetToolTip(Me.btnDBCtest, "ทดสอบการเชื่อมต่อฐานข้อมูล")
        Me.btnDBCtest.UseVisualStyleBackColor = True
        '
        'btnDBCsave
        '
        Me.btnDBCsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnDBCsave.Location = New System.Drawing.Point(392, 52)
        Me.btnDBCsave.Name = "btnDBCsave"
        Me.btnDBCsave.Size = New System.Drawing.Size(122, 40)
        Me.btnDBCsave.TabIndex = 7
        Me.btnDBCsave.Text = "บันทึก"
        Me.ToolTip1.SetToolTip(Me.btnDBCsave, "บันทึกการเชื่อมต่อ")
        Me.btnDBCsave.UseVisualStyleBackColor = True
        '
        'btnInstallDB
        '
        Me.btnInstallDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInstallDB.Image = Global.ServiceTicker.My.Resources.Resources._109_AllAnnotations_Help_16x16_72
        Me.btnInstallDB.Location = New System.Drawing.Point(489, 139)
        Me.btnInstallDB.Name = "btnInstallDB"
        Me.btnInstallDB.Size = New System.Drawing.Size(25, 24)
        Me.btnInstallDB.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.btnInstallDB, "ติดตั้งข้อมูลใหม่ กรณีติดตั้งใหม่")
        Me.btnInstallDB.UseVisualStyleBackColor = True
        '
        'btnSearchComputer
        '
        Me.btnSearchComputer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSearchComputer.Image = Global.ServiceTicker.My.Resources.Resources.rsz_1rsz_1rsz_computer_search
        Me.btnSearchComputer.Location = New System.Drawing.Point(392, 6)
        Me.btnSearchComputer.Name = "btnSearchComputer"
        Me.btnSearchComputer.Size = New System.Drawing.Size(54, 40)
        Me.btnSearchComputer.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btnSearchComputer, "ค้นหาชื่อคอมพิวเตอร์ในเครือข่าย")
        Me.btnSearchComputer.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "DataBase UserName"
        Me.ToolTip1.SetToolTip(Me.Label3, "ชื่อผู้ใช้ฐานข้อมูล")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "DataBase Password"
        Me.ToolTip1.SetToolTip(Me.Label4, "รหัสผ่านฐานข้อมูล")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "DataBase Port"
        Me.ToolTip1.SetToolTip(Me.Label5, "พอร์ตเชื่อมต่อฐานข้อมูล ค่าปกติคือ 3306")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(122, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Host"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "DataBase Name"
        '
        'cbbDataBaseName
        '
        Me.cbbDataBaseName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbbDataBaseName.FormattingEnabled = True
        Me.cbbDataBaseName.Location = New System.Drawing.Point(171, 102)
        Me.cbbDataBaseName.Name = "cbbDataBaseName"
        Me.cbbDataBaseName.Size = New System.Drawing.Size(215, 28)
        Me.cbbDataBaseName.TabIndex = 4
        '
        'ConnectDBFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 170)
        Me.Controls.Add(Me.cbbDataBaseName)
        Me.Controls.Add(Me.btnSearchComputer)
        Me.Controls.Add(Me.btnInstallDB)
        Me.Controls.Add(Me.btnDBCsave)
        Me.Controls.Add(Me.btnDBCtest)
        Me.Controls.Add(Me.txtDBCport)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDBCpassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDBCusername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDBCservername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConnectDBFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เชื่อมต่อฐานข้อมูล"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtDBCservername As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDBCusername As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDBCpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDBCport As System.Windows.Forms.TextBox
    Friend WithEvents btnDBCtest As System.Windows.Forms.Button
    Friend WithEvents btnDBCsave As System.Windows.Forms.Button
    Friend WithEvents btnInstallDB As System.Windows.Forms.Button
    Friend WithEvents btnSearchComputer As System.Windows.Forms.Button
    Friend WithEvents cbbDataBaseName As System.Windows.Forms.ComboBox
End Class
