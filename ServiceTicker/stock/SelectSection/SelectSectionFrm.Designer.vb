<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectSectionFrm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddChildRootNodesContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddRootToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChildContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddChildToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditChildToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelChildToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParentChildContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditParentChildToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelParentChildToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Panel1.SuspendLayout()
        Me.AddChildRootNodesContextMenu.SuspendLayout()
        Me.ChildContextMenu.SuspendLayout()
        Me.ParentChildContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 434)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 20)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "* ดับเบิ้ลคลิ๊กเพื่อเลือก คลิ๊กขวาเพื่อจัดการ"
        '
        'AddChildRootNodesContextMenu
        '
        Me.AddChildRootNodesContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddRootToolStripMenu})
        Me.AddChildRootNodesContextMenu.Name = "AddNodesContextMenu"
        Me.AddChildRootNodesContextMenu.Size = New System.Drawing.Size(158, 26)
        '
        'AddRootToolStripMenu
        '
        Me.AddRootToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.Add_16x
        Me.AddRootToolStripMenu.Name = "AddRootToolStripMenu"
        Me.AddRootToolStripMenu.Size = New System.Drawing.Size(157, 22)
        Me.AddRootToolStripMenu.Text = "เพิ่มหมวดหมู่สินค้า"
        '
        'ChildContextMenu
        '
        Me.ChildContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddChildToolStripMenu, Me.EditChildToolStripMenu, Me.DelChildToolStripMenu})
        Me.ChildContextMenu.Name = "AddNodesContextMenu"
        Me.ChildContextMenu.Size = New System.Drawing.Size(178, 70)
        '
        'AddChildToolStripMenu
        '
        Me.AddChildToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.Add_16x
        Me.AddChildToolStripMenu.Name = "AddChildToolStripMenu"
        Me.AddChildToolStripMenu.Size = New System.Drawing.Size(177, 22)
        Me.AddChildToolStripMenu.Text = "เพิ่มหมวดหมู่ย่อยสินค้า"
        '
        'EditChildToolStripMenu
        '
        Me.EditChildToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.PencilAngled_16xLG_color
        Me.EditChildToolStripMenu.Name = "EditChildToolStripMenu"
        Me.EditChildToolStripMenu.Size = New System.Drawing.Size(177, 22)
        Me.EditChildToolStripMenu.Text = "แก้ไขชื่อหมวดหมู่สินค้า"
        '
        'DelChildToolStripMenu
        '
        Me.DelChildToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.action_Cancel_16xLG
        Me.DelChildToolStripMenu.Name = "DelChildToolStripMenu"
        Me.DelChildToolStripMenu.Size = New System.Drawing.Size(177, 22)
        Me.DelChildToolStripMenu.Text = "ลบหมวดหมู่สินค้า"
        '
        'ParentChildContextMenu
        '
        Me.ParentChildContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditParentChildToolStripMenu, Me.DelParentChildToolStripMenu})
        Me.ParentChildContextMenu.Name = "ParentChildContextMenu"
        Me.ParentChildContextMenu.Size = New System.Drawing.Size(171, 48)
        '
        'EditParentChildToolStripMenu
        '
        Me.EditParentChildToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.PencilAngled_16xLG_color
        Me.EditParentChildToolStripMenu.Name = "EditParentChildToolStripMenu"
        Me.EditParentChildToolStripMenu.Size = New System.Drawing.Size(170, 22)
        Me.EditParentChildToolStripMenu.Text = "แก้ไขชื่อหมวดหมู่ย่อย"
        '
        'DelParentChildToolStripMenu
        '
        Me.DelParentChildToolStripMenu.Image = Global.ServiceTicker.My.Resources.Resources.action_Cancel_16xLG
        Me.DelParentChildToolStripMenu.Name = "DelParentChildToolStripMenu"
        Me.DelParentChildToolStripMenu.Size = New System.Drawing.Size(170, 22)
        Me.DelParentChildToolStripMenu.Text = "ลบหมวดหมู่ย่อยสินค้า"
        '
        'TreeView1
        '
        Me.TreeView1.AllowDrop = True
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TreeView1.Indent = 19
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(284, 434)
        Me.TreeView1.TabIndex = 3
        '
        'SelectSectionFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 454)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SelectSectionFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "หมวดหมู่สินค้า"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.AddChildRootNodesContextMenu.ResumeLayout(False)
        Me.ChildContextMenu.ResumeLayout(False)
        Me.ParentChildContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AddChildRootNodesContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddRootToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChildContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddChildToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditChildToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DelChildToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParentChildContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditParentChildToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DelParentChildToolStripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
End Class
