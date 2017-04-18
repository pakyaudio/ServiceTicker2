<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckStockFrm
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnloadOldDataCheckStock = New System.Windows.Forms.Button()
        Me.btnShowDontCheckSN = New System.Windows.Forms.Button()
        Me.txtDontCheck = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCSgetdata = New System.Windows.Forms.Button()
        Me.txtCSid = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnShowCheckedSN = New System.Windows.Forms.Button()
        Me.txtChecked = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCSsnLast = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCSSSNnow = New System.Windows.Forms.TextBox()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.btnHelp})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 217)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
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
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Size = New System.Drawing.Size(784, 217)
        Me.SplitContainer1.SplitterDistance = 383
        Me.SplitContainer1.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.txtDontCheck)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 89)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(381, 126)
        Me.Panel5.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnloadOldDataCheckStock)
        Me.Panel7.Controls.Add(Me.btnShowDontCheckSN)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 86)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(381, 40)
        Me.Panel7.TabIndex = 21
        '
        'btnloadOldDataCheckStock
        '
        Me.btnloadOldDataCheckStock.Location = New System.Drawing.Point(3, 3)
        Me.btnloadOldDataCheckStock.Name = "btnloadOldDataCheckStock"
        Me.btnloadOldDataCheckStock.Size = New System.Drawing.Size(239, 23)
        Me.btnloadOldDataCheckStock.TabIndex = 1
        Me.btnloadOldDataCheckStock.TabStop = False
        Me.btnloadOldDataCheckStock.Text = "โหลดข้อมูลตรวจสอบสต็อกที่ค้างการตรวจสอบ"
        Me.btnloadOldDataCheckStock.UseVisualStyleBackColor = True
        Me.btnloadOldDataCheckStock.Visible = False
        '
        'btnShowDontCheckSN
        '
        Me.btnShowDontCheckSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowDontCheckSN.Location = New System.Drawing.Point(290, 3)
        Me.btnShowDontCheckSN.Name = "btnShowDontCheckSN"
        Me.btnShowDontCheckSN.Size = New System.Drawing.Size(88, 23)
        Me.btnShowDontCheckSN.TabIndex = 0
        Me.btnShowDontCheckSN.Text = "ดูรายการ SN"
        Me.btnShowDontCheckSN.UseVisualStyleBackColor = True
        '
        'txtDontCheck
        '
        Me.txtDontCheck.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtDontCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDontCheck.Location = New System.Drawing.Point(0, 0)
        Me.txtDontCheck.Name = "txtDontCheck"
        Me.txtDontCheck.ReadOnly = True
        Me.txtDontCheck.Size = New System.Drawing.Size(381, 80)
        Me.txtDontCheck.TabIndex = 20
        Me.txtDontCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(381, 89)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.btnCSgetdata)
        Me.Panel2.Controls.Add(Me.txtCSid)
        Me.Panel2.Location = New System.Drawing.Point(3, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(375, 86)
        Me.Panel2.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(126, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "ยังไม่ได้ตรวจสอบ"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(126, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 31)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "เคลียร์ข้อมูลตรวจสอบสต็อก"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "ChackStock ID"
        '
        'btnCSgetdata
        '
        Me.btnCSgetdata.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCSgetdata.Location = New System.Drawing.Point(3, 31)
        Me.btnCSgetdata.Name = "btnCSgetdata"
        Me.btnCSgetdata.Size = New System.Drawing.Size(117, 31)
        Me.btnCSgetdata.TabIndex = 20
        Me.btnCSgetdata.Text = "เตรียมข้อมูล"
        Me.btnCSgetdata.UseVisualStyleBackColor = True
        '
        'txtCSid
        '
        Me.txtCSid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCSid.Location = New System.Drawing.Point(89, 3)
        Me.txtCSid.Name = "txtCSid"
        Me.txtCSid.ReadOnly = True
        Me.txtCSid.Size = New System.Drawing.Size(140, 22)
        Me.txtCSid.TabIndex = 19
        Me.txtCSid.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Controls.Add(Me.txtChecked)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 89)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(395, 126)
        Me.Panel6.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.btnShowCheckedSN)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 86)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(395, 40)
        Me.Panel8.TabIndex = 22
        '
        'btnShowCheckedSN
        '
        Me.btnShowCheckedSN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowCheckedSN.Location = New System.Drawing.Point(304, 3)
        Me.btnShowCheckedSN.Name = "btnShowCheckedSN"
        Me.btnShowCheckedSN.Size = New System.Drawing.Size(88, 23)
        Me.btnShowCheckedSN.TabIndex = 1
        Me.btnShowCheckedSN.Text = "ดูรายการ SN"
        Me.btnShowCheckedSN.UseVisualStyleBackColor = True
        '
        'txtChecked
        '
        Me.txtChecked.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtChecked.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtChecked.Location = New System.Drawing.Point(0, 0)
        Me.txtChecked.Name = "txtChecked"
        Me.txtChecked.ReadOnly = True
        Me.txtChecked.Size = New System.Drawing.Size(395, 80)
        Me.txtChecked.TabIndex = 21
        Me.txtChecked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(395, 89)
        Me.Panel3.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.txtCSsnLast)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.txtCSSSNnow)
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(389, 83)
        Me.Panel4.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(147, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "ตรวจสอบแล้ว"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "ล่าสุด"
        '
        'txtCSsnLast
        '
        Me.txtCSsnLast.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCSsnLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCSsnLast.ForeColor = System.Drawing.Color.Maroon
        Me.txtCSsnLast.Location = New System.Drawing.Point(51, 35)
        Me.txtCSsnLast.Name = "txtCSsnLast"
        Me.txtCSsnLast.ReadOnly = True
        Me.txtCSsnLast.Size = New System.Drawing.Size(335, 26)
        Me.txtCSsnLast.TabIndex = 16
        Me.txtCSsnLast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "ยิง Serial Number"
        '
        'txtCSSSNnow
        '
        Me.txtCSSSNnow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCSSSNnow.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtCSSSNnow.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtCSSSNnow.Location = New System.Drawing.Point(138, 3)
        Me.txtCSSSNnow.Name = "txtCSSSNnow"
        Me.txtCSSSNnow.Size = New System.Drawing.Size(248, 26)
        Me.txtCSSSNnow.TabIndex = 0
        Me.txtCSSSNnow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCSSSNnow.WordWrap = False
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
        'CheckStockFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 239)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CheckStockFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เช็คสต็อก Serial Number"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnCSgetdata As System.Windows.Forms.Button
    Friend WithEvents txtCSid As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCSsnLast As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCSSSNnow As System.Windows.Forms.TextBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents txtDontCheck As System.Windows.Forms.TextBox
    Friend WithEvents txtChecked As System.Windows.Forms.TextBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents btnShowDontCheckSN As System.Windows.Forms.Button
    Friend WithEvents btnShowCheckedSN As System.Windows.Forms.Button
    Friend WithEvents btnloadOldDataCheckStock As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
