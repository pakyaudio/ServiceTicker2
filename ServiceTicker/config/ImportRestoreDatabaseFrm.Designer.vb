<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportRestoreDatabaseFrm
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
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnIRDBimport = New System.Windows.Forms.Button()
        Me.searchSQLfile = New System.Windows.Forms.Button()
        Me.txtIRDBpath = New System.Windows.Forms.TextBox()
        Me.OpenFileDB = New System.Windows.Forms.OpenFileDialog()
        Me.btnIRDBstop = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 88)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(511, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblEmployee
        '
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(35, 17)
        Me.lblEmployee.Text = "Users"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Image = Global.ServiceTicker.My.Resources.Resources._109_AllAnnotations_Help_16x16_72
        Me.ToolStripStatusLabel1.IsLink = True
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(16, 17)
        Me.ToolStripStatusLabel1.ToolTipText = "Help"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(9, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "เลือกไฟล์ฐานข้อมูลที่สำรองไว้ แล้ว นำเข้าฐานข้อมูล"
        '
        'btnIRDBimport
        '
        Me.btnIRDBimport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIRDBimport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnIRDBimport.Location = New System.Drawing.Point(249, 39)
        Me.btnIRDBimport.Name = "btnIRDBimport"
        Me.btnIRDBimport.Size = New System.Drawing.Size(179, 36)
        Me.btnIRDBimport.TabIndex = 2
        Me.btnIRDBimport.Text = "นำเข้าฐานข้อมูล"
        Me.btnIRDBimport.UseVisualStyleBackColor = True
        '
        'searchSQLfile
        '
        Me.searchSQLfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchSQLfile.BackgroundImage = Global.ServiceTicker.My.Resources.Resources.FolderOpen_24x
        Me.searchSQLfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.searchSQLfile.Location = New System.Drawing.Point(466, 6)
        Me.searchSQLfile.Name = "searchSQLfile"
        Me.searchSQLfile.Size = New System.Drawing.Size(33, 26)
        Me.searchSQLfile.TabIndex = 1
        Me.searchSQLfile.UseVisualStyleBackColor = True
        '
        'txtIRDBpath
        '
        Me.txtIRDBpath.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIRDBpath.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtIRDBpath.Location = New System.Drawing.Point(12, 6)
        Me.txtIRDBpath.Name = "txtIRDBpath"
        Me.txtIRDBpath.ReadOnly = True
        Me.txtIRDBpath.Size = New System.Drawing.Size(448, 26)
        Me.txtIRDBpath.TabIndex = 0
        '
        'OpenFileDB
        '
        Me.OpenFileDB.Filter = "SLQ File(*.sql)|*.sql"
        Me.OpenFileDB.RestoreDirectory = True
        '
        'btnIRDBstop
        '
        Me.btnIRDBstop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIRDBstop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnIRDBstop.Location = New System.Drawing.Point(434, 39)
        Me.btnIRDBstop.Name = "btnIRDBstop"
        Me.btnIRDBstop.Size = New System.Drawing.Size(65, 36)
        Me.btnIRDBstop.TabIndex = 5
        Me.btnIRDBstop.Text = "หยุด"
        Me.btnIRDBstop.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 78)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(511, 10)
        Me.ProgressBar1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "...."
        '
        'Timer1
        '
        '
        'ImportRestoreDatabaseFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 110)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnIRDBstop)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnIRDBimport)
        Me.Controls.Add(Me.searchSQLfile)
        Me.Controls.Add(Me.txtIRDBpath)
        Me.Controls.Add(Me.StatusStrip1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ImportRestoreDatabaseFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "นำเข้าฐานข้อมูล"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnIRDBimport As System.Windows.Forms.Button
    Friend WithEvents searchSQLfile As System.Windows.Forms.Button
    Friend WithEvents txtIRDBpath As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDB As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnIRDBstop As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
