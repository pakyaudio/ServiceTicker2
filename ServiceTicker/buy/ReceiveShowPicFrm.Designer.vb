<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceiveShowPicFrm
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
        Me.EditPictureContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DelToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditPictureContextMenu.SuspendLayout()
        Me.AddContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(528, 416)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'EditPictureContextMenu
        '
        Me.EditPictureContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DelToolStripMenu})
        Me.EditPictureContextMenu.Name = "EditPictureContextMenu"
        Me.EditPictureContextMenu.Size = New System.Drawing.Size(120, 26)
        '
        'DelToolStripMenu
        '
        Me.DelToolStripMenu.Name = "DelToolStripMenu"
        Me.DelToolStripMenu.Size = New System.Drawing.Size(119, 22)
        Me.DelToolStripMenu.Text = "ลบเอกสาร"
        '
        'AddContextMenu
        '
        Me.AddContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenu})
        Me.AddContextMenu.Name = "EditPictureContextMenu"
        Me.AddContextMenu.Size = New System.Drawing.Size(153, 48)
        '
        'AddToolStripMenu
        '
        Me.AddToolStripMenu.Name = "AddToolStripMenu"
        Me.AddToolStripMenu.Size = New System.Drawing.Size(152, 22)
        Me.AddToolStripMenu.Text = "เพิ่มเอกสาร"
        '
        'ReceiveShowPicFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 416)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "ReceiveShowPicFrm"
        Me.Text = "แสดงเอกสารแนบ"
        Me.EditPictureContextMenu.ResumeLayout(False)
        Me.AddContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents EditPictureContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DelToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddToolStripMenu As System.Windows.Forms.ToolStripMenuItem
End Class
