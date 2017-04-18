<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PosonalDocFrm
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.AddContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefeshToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ZoomToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.AddContextMenu.SuspendLayout()
        Me.EditContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(784, 561)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblEmployee
        '
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(30, 17)
        Me.lblEmployee.Text = "User"
        '
        'AddContextMenu
        '
        Me.AddContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefeshToolStripMenu, Me.AddToolStripMenu})
        Me.AddContextMenu.Name = "AddContextMenu"
        Me.AddContextMenu.Size = New System.Drawing.Size(164, 48)
        '
        'RefeshToolStripMenu
        '
        Me.RefeshToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.Refresh_grey_16x
        Me.RefeshToolStripMenu.Name = "RefeshToolStripMenu"
        Me.RefeshToolStripMenu.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.RefeshToolStripMenu.Size = New System.Drawing.Size(163, 22)
        Me.RefeshToolStripMenu.Text = "ฟื้นฟู"
        '
        'AddToolStripMenu
        '
        Me.AddToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.add
        Me.AddToolStripMenu.Name = "AddToolStripMenu"
        Me.AddToolStripMenu.Size = New System.Drawing.Size(163, 22)
        Me.AddToolStripMenu.Text = "เพิ่มเอกสาร(ไฟล์รูป)"
        '
        'EditContextMenu
        '
        Me.EditContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZoomToolStripMenu, Me.PrintToolStripMenu, Me.ExportToolStripMenu, Me.DelToolStripMenu})
        Me.EditContextMenu.Name = "EditContextMenu"
        Me.EditContextMenu.Size = New System.Drawing.Size(137, 92)
        '
        'ZoomToolStripMenu
        '
        Me.ZoomToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.Zoom_5442
        Me.ZoomToolStripMenu.Name = "ZoomToolStripMenu"
        Me.ZoomToolStripMenu.Size = New System.Drawing.Size(136, 22)
        Me.ZoomToolStripMenu.Text = "ขยาย"
        '
        'PrintToolStripMenu
        '
        Me.PrintToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.PrintStatusBar2_16x
        Me.PrintToolStripMenu.Name = "PrintToolStripMenu"
        Me.PrintToolStripMenu.Size = New System.Drawing.Size(136, 22)
        Me.PrintToolStripMenu.Text = "พิมพ์"
        '
        'ExportToolStripMenu
        '
        Me.ExportToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.save_16xLG
        Me.ExportToolStripMenu.Name = "ExportToolStripMenu"
        Me.ExportToolStripMenu.Size = New System.Drawing.Size(136, 22)
        Me.ExportToolStripMenu.Text = "ส่งออกรูปภาพ"
        '
        'DelToolStripMenu
        '
        Me.DelToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.VSO_RecycleBin_16x
        Me.DelToolStripMenu.Name = "DelToolStripMenu"
        Me.DelToolStripMenu.Size = New System.Drawing.Size(136, 22)
        Me.DelToolStripMenu.Text = "ลบ"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Image = Global.ServiceTicker.My.Resources.Resources._109_AllAnnotations_Info_16x16_72
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(314, 17)
        Me.ToolStripStatusLabel1.Text = "ใช้เก็บเอกสารประกอบการค้า เช่น สำเนาบัตร ทะเบียนพานิขย์ อื่น ๆ "
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Image = Global.ServiceTicker.My.Resources.Resources._109_AllAnnotations_Help_16x16_72
        Me.ToolStripStatusLabel2.IsLink = True
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(16, 17)
        Me.ToolStripStatusLabel2.ToolTipText = "ช่วยเหลือ"
        '
        'PosonalDocFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ListView1)
        Me.KeyPreview = True
        Me.Name = "PosonalDocFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เอกสาร"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.AddContextMenu.ResumeLayout(False)
        Me.EditContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AddContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ZoomToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DelToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefeshToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
End Class
