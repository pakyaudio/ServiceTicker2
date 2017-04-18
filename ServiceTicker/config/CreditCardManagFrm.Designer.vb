<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreditCardManagFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreditCardManagFrm))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblEmployee = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewCaditToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EditCaditToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveCaditToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CancelCaditToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteCaditToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BackCaditToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.NextCaditToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.dgCCMcredit = New System.Windows.Forms.DataGridView()
        Me.credit_card = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCCMcredit = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.NewBankToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EditBankToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveBankToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CancelBankToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteBankToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BackBankToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.NextBankToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.dgCCMbank = New System.Windows.Forms.DataGridView()
        Me.bank_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCCMBbank = New System.Windows.Forms.TextBox()
        Me.btnHelp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgCCMcredit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dgCCMbank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblEmployee, Me.btnHelp})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 416)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(499, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblEmployee
        '
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(35, 17)
        Me.lblEmployee.Text = "Users"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Size = New System.Drawing.Size(499, 416)
        Me.SplitContainer1.SplitterDistance = 247
        Me.SplitContainer1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ToolStrip1)
        Me.GroupBox1.Controls.Add(Me.dgCCMcredit)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCCMcredit)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 393)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ชื่อบัตรเครดิต"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewCaditToolStripButton, Me.EditCaditToolStripButton, Me.SaveCaditToolStripButton, Me.CancelCaditToolStripButton, Me.toolStripSeparator, Me.DeleteCaditToolStripButton, Me.toolStripSeparator1, Me.BackCaditToolStripButton, Me.NextCaditToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(219, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewCaditToolStripButton
        '
        Me.NewCaditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewCaditToolStripButton.Image = CType(resources.GetObject("NewCaditToolStripButton.Image"), System.Drawing.Image)
        Me.NewCaditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewCaditToolStripButton.Name = "NewCaditToolStripButton"
        Me.NewCaditToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewCaditToolStripButton.Text = "เพิ่ม"
        '
        'EditCaditToolStripButton
        '
        Me.EditCaditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditCaditToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.PencilAngled_16xLG_color
        Me.EditCaditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditCaditToolStripButton.Name = "EditCaditToolStripButton"
        Me.EditCaditToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.EditCaditToolStripButton.Text = "แก้ไข"
        '
        'SaveCaditToolStripButton
        '
        Me.SaveCaditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveCaditToolStripButton.Image = CType(resources.GetObject("SaveCaditToolStripButton.Image"), System.Drawing.Image)
        Me.SaveCaditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveCaditToolStripButton.Name = "SaveCaditToolStripButton"
        Me.SaveCaditToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveCaditToolStripButton.Text = "บันทึก"
        '
        'CancelCaditToolStripButton
        '
        Me.CancelCaditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CancelCaditToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.Undo_16x
        Me.CancelCaditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelCaditToolStripButton.Name = "CancelCaditToolStripButton"
        Me.CancelCaditToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CancelCaditToolStripButton.Text = "ยกเลิก"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'DeleteCaditToolStripButton
        '
        Me.DeleteCaditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DeleteCaditToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.action_Cancel_16xLG
        Me.DeleteCaditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteCaditToolStripButton.Name = "DeleteCaditToolStripButton"
        Me.DeleteCaditToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.DeleteCaditToolStripButton.Text = "ลบ"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BackCaditToolStripButton
        '
        Me.BackCaditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BackCaditToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.arrow_back_color_16xLG
        Me.BackCaditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BackCaditToolStripButton.Name = "BackCaditToolStripButton"
        Me.BackCaditToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.BackCaditToolStripButton.Text = "ก่อนหน้า"
        '
        'NextCaditToolStripButton
        '
        Me.NextCaditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NextCaditToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.arrow_Forward_color_16xLG
        Me.NextCaditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NextCaditToolStripButton.Name = "NextCaditToolStripButton"
        Me.NextCaditToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NextCaditToolStripButton.Text = "ถัดไป"
        '
        'dgCCMcredit
        '
        Me.dgCCMcredit.AllowUserToAddRows = False
        Me.dgCCMcredit.AllowUserToDeleteRows = False
        Me.dgCCMcredit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgCCMcredit.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCCMcredit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCCMcredit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.credit_card})
        Me.dgCCMcredit.Location = New System.Drawing.Point(6, 82)
        Me.dgCCMcredit.Name = "dgCCMcredit"
        Me.dgCCMcredit.ReadOnly = True
        Me.dgCCMcredit.RowHeadersWidth = 22
        Me.dgCCMcredit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCCMcredit.Size = New System.Drawing.Size(212, 300)
        Me.dgCCMcredit.TabIndex = 2
        '
        'credit_card
        '
        Me.credit_card.HeaderText = "บัตรเครดิต"
        Me.credit_card.Name = "credit_card"
        Me.credit_card.ReadOnly = True
        Me.credit_card.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ชื่อ"
        '
        'txtCCMcredit
        '
        Me.txtCCMcredit.Location = New System.Drawing.Point(35, 56)
        Me.txtCCMcredit.Name = "txtCCMcredit"
        Me.txtCCMcredit.Size = New System.Drawing.Size(183, 20)
        Me.txtCCMcredit.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ToolStrip2)
        Me.GroupBox2.Controls.Add(Me.dgCCMbank)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtCCMBbank)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(225, 393)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ชื่อธนาคาร"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewBankToolStripButton, Me.EditBankToolStripButton, Me.SaveBankToolStripButton, Me.CancelBankToolStripButton, Me.ToolStripSeparator2, Me.DeleteBankToolStripButton, Me.ToolStripSeparator3, Me.BackBankToolStripButton, Me.NextBankToolStripButton})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip2.Size = New System.Drawing.Size(219, 25)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'NewBankToolStripButton
        '
        Me.NewBankToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewBankToolStripButton.Image = CType(resources.GetObject("NewBankToolStripButton.Image"), System.Drawing.Image)
        Me.NewBankToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewBankToolStripButton.Name = "NewBankToolStripButton"
        Me.NewBankToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewBankToolStripButton.Text = "เพิ่ม"
        '
        'EditBankToolStripButton
        '
        Me.EditBankToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditBankToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.PencilAngled_16xLG_color
        Me.EditBankToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditBankToolStripButton.Name = "EditBankToolStripButton"
        Me.EditBankToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.EditBankToolStripButton.Text = "แก้ไข"
        '
        'SaveBankToolStripButton
        '
        Me.SaveBankToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveBankToolStripButton.Image = CType(resources.GetObject("SaveBankToolStripButton.Image"), System.Drawing.Image)
        Me.SaveBankToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveBankToolStripButton.Name = "SaveBankToolStripButton"
        Me.SaveBankToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveBankToolStripButton.Text = "บันทึก"
        '
        'CancelBankToolStripButton
        '
        Me.CancelBankToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CancelBankToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.Undo_16x
        Me.CancelBankToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelBankToolStripButton.Name = "CancelBankToolStripButton"
        Me.CancelBankToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CancelBankToolStripButton.Text = "ยกเลิก"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'DeleteBankToolStripButton
        '
        Me.DeleteBankToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DeleteBankToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.action_Cancel_16xLG
        Me.DeleteBankToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteBankToolStripButton.Name = "DeleteBankToolStripButton"
        Me.DeleteBankToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.DeleteBankToolStripButton.Text = "ลบ"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BackBankToolStripButton
        '
        Me.BackBankToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BackBankToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.arrow_back_color_16xLG
        Me.BackBankToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BackBankToolStripButton.Name = "BackBankToolStripButton"
        Me.BackBankToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.BackBankToolStripButton.Text = "ก่อนหน้า"
        '
        'NextBankToolStripButton
        '
        Me.NextBankToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NextBankToolStripButton.Image = Global.ServiceTicker.My.Resources.Resources.arrow_Forward_color_16xLG
        Me.NextBankToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NextBankToolStripButton.Name = "NextBankToolStripButton"
        Me.NextBankToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NextBankToolStripButton.Text = "ถัดไป"
        '
        'dgCCMbank
        '
        Me.dgCCMbank.AllowUserToAddRows = False
        Me.dgCCMbank.AllowUserToDeleteRows = False
        Me.dgCCMbank.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgCCMbank.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCCMbank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCCMbank.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bank_name})
        Me.dgCCMbank.Location = New System.Drawing.Point(6, 82)
        Me.dgCCMbank.Name = "dgCCMbank"
        Me.dgCCMbank.ReadOnly = True
        Me.dgCCMbank.RowHeadersWidth = 22
        Me.dgCCMbank.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCCMbank.Size = New System.Drawing.Size(212, 300)
        Me.dgCCMbank.TabIndex = 2
        '
        'bank_name
        '
        Me.bank_name.HeaderText = "ชื่อธนาคาร"
        Me.bank_name.Name = "bank_name"
        Me.bank_name.ReadOnly = True
        Me.bank_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ชื่อ"
        '
        'txtCCMBbank
        '
        Me.txtCCMBbank.Location = New System.Drawing.Point(35, 56)
        Me.txtCCMBbank.Name = "txtCCMBbank"
        Me.txtCCMBbank.Size = New System.Drawing.Size(183, 20)
        Me.txtCCMBbank.TabIndex = 1
        '
        'btnHelp
        '
        Me.btnHelp.Image = Global.ServiceTicker.My.Resources.Resources._109_AllAnnotations_Help_16x16_72
        Me.btnHelp.IsLink = True
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(16, 17)
        Me.btnHelp.ToolTipText = "Help"
        '
        'CreditCardManagFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 438)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreditCardManagFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "จัดการบัตรเครดิต"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgCCMcredit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dgCCMbank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEmployee As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewCaditToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditCaditToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveCaditToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CancelCaditToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteCaditToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BackCaditToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents NextCaditToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgCCMcredit As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCCMcredit As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewBankToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditBankToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveBankToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CancelBankToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteBankToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BackBankToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents NextBankToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgCCMbank As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCCMBbank As System.Windows.Forms.TextBox
    Friend WithEvents credit_card As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bank_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
