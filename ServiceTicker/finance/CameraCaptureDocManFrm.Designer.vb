<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CameraCaptureDocManFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CameraCaptureDocManFrm))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnScanner = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Button_Connect = New System.Windows.Forms.Button()
        Me.ComboBox_FrameSize = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Devices = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenImageFile = New System.Windows.Forms.OpenFileDialog()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.MinimumSize = New System.Drawing.Size(720, 560)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnScanner)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnOpen)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button_Save)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button_Connect)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ComboBox_FrameSize)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ComboBox_Devices)
        Me.SplitContainer1.Size = New System.Drawing.Size(784, 561)
        Me.SplitContainer1.SplitterDistance = 517
        Me.SplitContainer1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(784, 517)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnScanner
        '
        Me.btnScanner.Image = CType(resources.GetObject("btnScanner.Image"), System.Drawing.Image)
        Me.btnScanner.Location = New System.Drawing.Point(702, 3)
        Me.btnScanner.Name = "btnScanner"
        Me.btnScanner.Size = New System.Drawing.Size(37, 34)
        Me.btnScanner.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.btnScanner, "สแกนภาพจากอุปกรณ์สำหรับสแกนภาพ")
        Me.btnScanner.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.BackgroundImage = Global.ServiceTicker.My.Resources.Resources.ImageBrowser_24x
        Me.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnOpen.Location = New System.Drawing.Point(745, 4)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(36, 33)
        Me.btnOpen.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.btnOpen, "เลือกรูปที่บันทึกไว้")
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'Button_Save
        '
        Me.Button_Save.Location = New System.Drawing.Point(363, 4)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(75, 23)
        Me.Button_Save.TabIndex = 10
        Me.Button_Save.Text = "จับภาพ"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'Button_Connect
        '
        Me.Button_Connect.Location = New System.Drawing.Point(257, 4)
        Me.Button_Connect.Name = "Button_Connect"
        Me.Button_Connect.Size = New System.Drawing.Size(100, 23)
        Me.Button_Connect.TabIndex = 9
        Me.Button_Connect.Text = "เชื่อมต่อกล้อง"
        Me.Button_Connect.UseVisualStyleBackColor = True
        '
        'ComboBox_FrameSize
        '
        Me.ComboBox_FrameSize.FormattingEnabled = True
        Me.ComboBox_FrameSize.Location = New System.Drawing.Point(130, 4)
        Me.ComboBox_FrameSize.Name = "ComboBox_FrameSize"
        Me.ComboBox_FrameSize.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_FrameSize.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.ComboBox_FrameSize, "ขนาดรูปภาพ")
        '
        'ComboBox_Devices
        '
        Me.ComboBox_Devices.FormattingEnabled = True
        Me.ComboBox_Devices.Location = New System.Drawing.Point(3, 3)
        Me.ComboBox_Devices.Name = "ComboBox_Devices"
        Me.ComboBox_Devices.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Devices.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.ComboBox_Devices, "กล้องที่เชื่อมต่ออยู่")
        '
        'OpenImageFile
        '
        Me.OpenImageFile.Filter = "ไฟล์รูป(*.jpg,*.jpeg,*.png,*.bmp)|*.jpg;*.jpeg;*.png;*.bmp"
        Me.OpenImageFile.Multiselect = True
        Me.OpenImageFile.RestoreDirectory = True
        '
        'CameraCaptureDocManFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "CameraCaptureDocManFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "จับภาพ"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button_Save As System.Windows.Forms.Button
    Friend WithEvents Button_Connect As System.Windows.Forms.Button
    Friend WithEvents ComboBox_FrameSize As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_Devices As System.Windows.Forms.ComboBox
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents OpenImageFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnScanner As System.Windows.Forms.Button
End Class
