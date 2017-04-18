<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaimsreceiveGroupAddSNFrm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtoldSN = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtNewSN = New System.Windows.Forms.TextBox()
        Me.rbNewSN = New System.Windows.Forms.RadioButton()
        Me.rbOldSN = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtoldSN)
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Controls.Add(Me.txtNewSN)
        Me.Panel1.Controls.Add(Me.rbNewSN)
        Me.Panel1.Controls.Add(Me.rbOldSN)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(488, 71)
        Me.Panel1.TabIndex = 0
        '
        'txtoldSN
        '
        Me.txtoldSN.Enabled = False
        Me.txtoldSN.Location = New System.Drawing.Point(73, 25)
        Me.txtoldSN.Name = "txtoldSN"
        Me.txtoldSN.ReadOnly = True
        Me.txtoldSN.Size = New System.Drawing.Size(122, 20)
        Me.txtoldSN.TabIndex = 8
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(410, 23)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 7
        Me.btnOK.Text = "ตกลง"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtNewSN
        '
        Me.txtNewSN.Enabled = False
        Me.txtNewSN.Location = New System.Drawing.Point(270, 25)
        Me.txtNewSN.Name = "txtNewSN"
        Me.txtNewSN.Size = New System.Drawing.Size(134, 20)
        Me.txtNewSN.TabIndex = 6
        '
        'rbNewSN
        '
        Me.rbNewSN.AutoSize = True
        Me.rbNewSN.Location = New System.Drawing.Point(201, 26)
        Me.rbNewSN.Name = "rbNewSN"
        Me.rbNewSN.Size = New System.Drawing.Size(63, 17)
        Me.rbNewSN.TabIndex = 5
        Me.rbNewSN.TabStop = True
        Me.rbNewSN.Text = "SN ใหม่"
        Me.rbNewSN.UseVisualStyleBackColor = True
        '
        'rbOldSN
        '
        Me.rbOldSN.AutoSize = True
        Me.rbOldSN.Location = New System.Drawing.Point(7, 26)
        Me.rbOldSN.Name = "rbOldSN"
        Me.rbOldSN.Size = New System.Drawing.Size(60, 17)
        Me.rbOldSN.TabIndex = 4
        Me.rbOldSN.TabStop = True
        Me.rbOldSN.Text = "SN เก่า"
        Me.rbOldSN.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(479, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "หมายเหตุ บางกรณีบริษัทที่รับเคลมเปลี่ยนสินค้าตัวใหม่มาให้ ทำให้ SN ทำให้ SN ถูกเป" & _
    "ลี่ยนใหม่ไปด้วย"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "กรณุาระบุว่า SN (รหัสประจำตัวสินค้า) ได้เปลี่ยนใหม่หรือว่าเป็นตัวเดิมที่ส่งไป"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'ClaimsreceiveGroupAddSNFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(488, 71)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "ClaimsreceiveGroupAddSNFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เปลี่ยน SN สินค้า"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbOldSN As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtNewSN As System.Windows.Forms.TextBox
    Friend WithEvents rbNewSN As System.Windows.Forms.RadioButton
    Friend WithEvents txtoldSN As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
