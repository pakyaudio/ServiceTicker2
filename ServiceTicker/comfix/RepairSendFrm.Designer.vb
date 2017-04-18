<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepairSendFrm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgRSF = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.send_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.send_address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.send_contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgRSF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgRSF)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(569, 295)
        Me.Panel1.TabIndex = 0
        '
        'dgRSF
        '
        Me.dgRSF.AllowUserToAddRows = False
        Me.dgRSF.AllowUserToDeleteRows = False
        Me.dgRSF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRSF.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.send_name, Me.send_address, Me.send_contact})
        Me.dgRSF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgRSF.Location = New System.Drawing.Point(0, 0)
        Me.dgRSF.MultiSelect = False
        Me.dgRSF.Name = "dgRSF"
        Me.dgRSF.ReadOnly = True
        Me.dgRSF.RowHeadersVisible = False
        Me.dgRSF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRSF.Size = New System.Drawing.Size(569, 295)
        Me.dgRSF.TabIndex = 0
        '
        'no
        '
        Me.no.FillWeight = 30.0!
        Me.no.HeaderText = "#"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.Width = 30
        '
        'send_name
        '
        Me.send_name.FillWeight = 150.0!
        Me.send_name.HeaderText = "ชื่อร้าน/สถานที่"
        Me.send_name.Name = "send_name"
        Me.send_name.ReadOnly = True
        Me.send_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.send_name.Width = 150
        '
        'send_address
        '
        Me.send_address.FillWeight = 200.0!
        Me.send_address.HeaderText = "ที่อยู่"
        Me.send_address.Name = "send_address"
        Me.send_address.ReadOnly = True
        Me.send_address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.send_address.Width = 200
        '
        'send_contact
        '
        Me.send_contact.FillWeight = 120.0!
        Me.send_contact.HeaderText = "ติดต่อ"
        Me.send_contact.Name = "send_contact"
        Me.send_contact.ReadOnly = True
        Me.send_contact.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.send_contact.Width = 120
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnEdit)
        Me.Panel2.Controls.Add(Me.btnDel)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.btnSelect)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 295)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(569, 36)
        Me.Panel2.TabIndex = 1
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(79, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(70, 30)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = True
        Me.btnEdit.Visible = False
        '
        'btnDel
        '
        Me.btnDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnDel.Location = New System.Drawing.Point(155, 3)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(70, 30)
        Me.btnDel.TabIndex = 2
        Me.btnDel.Text = "ลบ"
        Me.btnDel.UseVisualStyleBackColor = True
        Me.btnDel.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(3, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(70, 30)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(429, 3)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(137, 30)
        Me.btnSelect.TabIndex = 0
        Me.btnSelect.Text = "เลือก"
        Me.btnSelect.UseVisualStyleBackColor = True
        Me.btnSelect.Visible = False
        '
        'RepairSendFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 331)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RepairSendFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกสถานที่ ที่ส่งซ่อม"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgRSF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgRSF As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents send_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents send_address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents send_contact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSelect As System.Windows.Forms.Button
End Class
