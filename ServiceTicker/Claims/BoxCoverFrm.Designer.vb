<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BoxCoverFrm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbbPaper = New System.Windows.Forms.ComboBox()
        Me.txtCScom_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCScom_address = New System.Windows.Forms.TextBox()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.txtCScom_addressZip = New System.Windows.Forms.TextBox()
        Me.RefreshReport = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCScom_addressJJ = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCScom_contect = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCScom_addressAOM = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBCwarning = New System.Windows.Forms.TextBox()
        Me.txtCScom_id = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RefreshReport1 = New System.Windows.Forms.Button()
        Me.txtYourTel = New System.Windows.Forms.TextBox()
        Me.txtYourAddress = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtYourName = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.btnHelp})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(734, 22)
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
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(734, 153)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(728, 147)
        Me.Panel2.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(728, 147)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.cbbPaper)
        Me.TabPage1.Controls.Add(Me.txtCScom_name)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtCScom_address)
        Me.TabPage1.Controls.Add(Me.txtNote)
        Me.TabPage1.Controls.Add(Me.txtCScom_addressZip)
        Me.TabPage1.Controls.Add(Me.RefreshReport)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtCScom_addressJJ)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txtCScom_contect)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtCScom_addressAOM)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtBCwarning)
        Me.TabPage1.Controls.Add(Me.txtCScom_id)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(720, 121)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ที่อยู่ผู้รับ"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(392, 93)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 13)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "ขนาดกระดาษ"
        '
        'cbbPaper
        '
        Me.cbbPaper.FormattingEnabled = True
        Me.cbbPaper.Location = New System.Drawing.Point(469, 90)
        Me.cbbPaper.Name = "cbbPaper"
        Me.cbbPaper.Size = New System.Drawing.Size(112, 21)
        Me.cbbPaper.TabIndex = 37
        '
        'txtCScom_name
        '
        Me.txtCScom_name.Location = New System.Drawing.Point(105, 24)
        Me.txtCScom_name.Name = "txtCScom_name"
        Me.txtCScom_name.Size = New System.Drawing.Size(193, 20)
        Me.txtCScom_name.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Note"
        '
        'txtCScom_address
        '
        Me.txtCScom_address.Location = New System.Drawing.Point(304, 24)
        Me.txtCScom_address.Name = "txtCScom_address"
        Me.txtCScom_address.Size = New System.Drawing.Size(193, 20)
        Me.txtCScom_address.TabIndex = 20
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(54, 89)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(244, 20)
        Me.txtNote.TabIndex = 35
        Me.txtNote.Text = "-"
        '
        'txtCScom_addressZip
        '
        Me.txtCScom_addressZip.Location = New System.Drawing.Point(503, 63)
        Me.txtCScom_addressZip.Name = "txtCScom_addressZip"
        Me.txtCScom_addressZip.Size = New System.Drawing.Size(78, 20)
        Me.txtCScom_addressZip.TabIndex = 33
        '
        'RefreshReport
        '
        Me.RefreshReport.Location = New System.Drawing.Point(587, 89)
        Me.RefreshReport.Name = "RefreshReport"
        Me.RefreshReport.Size = New System.Drawing.Size(109, 20)
        Me.RefreshReport.TabIndex = 34
        Me.RefreshReport.Text = "ปรับปรุงรีพอร์ต"
        Me.RefreshReport.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "ป้ายคำเตือน"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(304, 89)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 20)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "ค้นหา"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(105, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "ชื่อบริษัท/ชื่อบุคคล"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(500, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "อำเภอ/เขต"
        '
        'txtCScom_addressJJ
        '
        Me.txtCScom_addressJJ.Location = New System.Drawing.Point(304, 63)
        Me.txtCScom_addressJJ.Name = "txtCScom_addressJJ"
        Me.txtCScom_addressJJ.Size = New System.Drawing.Size(193, 20)
        Me.txtCScom_addressJJ.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "หมายเลขบริษัท"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(500, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "รหัสไปรษณีย์"
        '
        'txtCScom_contect
        '
        Me.txtCScom_contect.Location = New System.Drawing.Point(587, 63)
        Me.txtCScom_contect.Name = "txtCScom_contect"
        Me.txtCScom_contect.Size = New System.Drawing.Size(109, 20)
        Me.txtCScom_contect.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(304, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "ที่อยู่บริษัท ตำบล/แขวง"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(304, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "จังหวัด"
        '
        'txtCScom_addressAOM
        '
        Me.txtCScom_addressAOM.Location = New System.Drawing.Point(503, 24)
        Me.txtCScom_addressAOM.Name = "txtCScom_addressAOM"
        Me.txtCScom_addressAOM.Size = New System.Drawing.Size(193, 20)
        Me.txtCScom_addressAOM.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(584, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "เบอร์โทรศัพท์"
        '
        'txtBCwarning
        '
        Me.txtBCwarning.Location = New System.Drawing.Point(21, 63)
        Me.txtBCwarning.Name = "txtBCwarning"
        Me.txtBCwarning.Size = New System.Drawing.Size(277, 20)
        Me.txtBCwarning.TabIndex = 31
        Me.txtBCwarning.Text = "ระวังแตก ห้ามโยน"
        '
        'txtCScom_id
        '
        Me.txtCScom_id.Location = New System.Drawing.Point(21, 24)
        Me.txtCScom_id.Name = "txtCScom_id"
        Me.txtCScom_id.ReadOnly = True
        Me.txtCScom_id.Size = New System.Drawing.Size(78, 20)
        Me.txtCScom_id.TabIndex = 18
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.RefreshReport1)
        Me.TabPage2.Controls.Add(Me.txtYourTel)
        Me.TabPage2.Controls.Add(Me.txtYourAddress)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txtYourName)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(720, 121)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ที่อยู่ผู้ส่ง"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 20)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "เบอร์โทรศัพท์"
        '
        'RefreshReport1
        '
        Me.RefreshReport1.Location = New System.Drawing.Point(521, 84)
        Me.RefreshReport1.Name = "RefreshReport1"
        Me.RefreshReport1.Size = New System.Drawing.Size(193, 26)
        Me.RefreshReport1.TabIndex = 35
        Me.RefreshReport1.Text = "ปรับปรุงรีพอร์ต"
        Me.RefreshReport1.UseVisualStyleBackColor = True
        '
        'txtYourTel
        '
        Me.txtYourTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtYourTel.Location = New System.Drawing.Point(105, 84)
        Me.txtYourTel.Name = "txtYourTel"
        Me.txtYourTel.Size = New System.Drawing.Size(410, 26)
        Me.txtYourTel.TabIndex = 4
        '
        'txtYourAddress
        '
        Me.txtYourAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtYourAddress.Location = New System.Drawing.Point(58, 52)
        Me.txtYourAddress.Name = "txtYourAddress"
        Me.txtYourAddress.Size = New System.Drawing.Size(656, 26)
        Me.txtYourAddress.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 20)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "ที่อยู่"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "ชื่อ"
        '
        'txtYourName
        '
        Me.txtYourName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtYourName.Location = New System.Drawing.Point(58, 20)
        Me.txtYourName.Name = "txtYourName"
        Me.txtYourName.Size = New System.Drawing.Size(656, 26)
        Me.txtYourName.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.Controls.Add(Me.ReportViewer1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 153)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(734, 386)
        Me.Panel3.TabIndex = 2
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(734, 386)
        Me.ReportViewer1.TabIndex = 0
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
        'BoxCoverFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 561)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "BoxCoverFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "พิมพ์ใบปะหน้ากล่อง"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCScom_contect As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCScom_id As System.Windows.Forms.TextBox
    Friend WithEvents txtBCwarning As System.Windows.Forms.TextBox
    Friend WithEvents txtCScom_addressAOM As System.Windows.Forms.TextBox
    Friend WithEvents txtCScom_name As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCScom_addressJJ As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCScom_addressZip As System.Windows.Forms.TextBox
    Friend WithEvents txtCScom_address As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents RefreshReport As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cbbPaper As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents RefreshReport1 As System.Windows.Forms.Button
    Friend WithEvents txtYourTel As System.Windows.Forms.TextBox
    Friend WithEvents txtYourAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtYourName As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
