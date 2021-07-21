<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class controlDev
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(controlDev))
        Me.tmeRead = New System.Windows.Forms.Timer(Me.components)
        Me.txtHandler = New System.Windows.Forms.TextBox()
        Me.txtCardCode = New System.Windows.Forms.TextBox()
        Me.txtDoor = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.Label()
        Me.txtCtrl = New System.Windows.Forms.Label()
        Me.DevPiv = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrggerOpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormallyOpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormallyClosedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetParameterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DevPiv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmeRead
        '
        Me.tmeRead.Interval = 300
        '
        'txtHandler
        '
        Me.txtHandler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHandler.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHandler.Location = New System.Drawing.Point(11, 362)
        Me.txtHandler.MaxLength = 30
        Me.txtHandler.Name = "txtHandler"
        Me.txtHandler.Size = New System.Drawing.Size(167, 22)
        Me.txtHandler.TabIndex = 30
        Me.txtHandler.Visible = False
        '
        'txtCardCode
        '
        Me.txtCardCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCardCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardCode.Location = New System.Drawing.Point(11, 306)
        Me.txtCardCode.MaxLength = 30
        Me.txtCardCode.Name = "txtCardCode"
        Me.txtCardCode.Size = New System.Drawing.Size(167, 22)
        Me.txtCardCode.TabIndex = 29
        Me.txtCardCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDoor
        '
        Me.txtDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDoor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoor.Location = New System.Drawing.Point(11, 334)
        Me.txtDoor.MaxLength = 30
        Me.txtDoor.Name = "txtDoor"
        Me.txtDoor.Size = New System.Drawing.Size(167, 22)
        Me.txtDoor.TabIndex = 31
        Me.txtDoor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStatus
        '
        Me.txtStatus.AutoSize = True
        Me.txtStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtStatus.Location = New System.Drawing.Point(39, 19)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(73, 13)
        Me.txtStatus.TabIndex = 34
        Me.txtStatus.Text = "Disconnected"
        '
        'txtCtrl
        '
        Me.txtCtrl.AutoSize = True
        Me.txtCtrl.ForeColor = System.Drawing.Color.White
        Me.txtCtrl.Location = New System.Drawing.Point(40, 3)
        Me.txtCtrl.Name = "txtCtrl"
        Me.txtCtrl.Size = New System.Drawing.Size(51, 13)
        Me.txtCtrl.TabIndex = 33
        Me.txtCtrl.Text = "Reader 1"
        '
        'DevPiv
        '
        Me.DevPiv.Image = CType(resources.GetObject("DevPiv.Image"), System.Drawing.Image)
        Me.DevPiv.Location = New System.Drawing.Point(3, 3)
        Me.DevPiv.Name = "DevPiv"
        Me.DevPiv.Size = New System.Drawing.Size(35, 30)
        Me.DevPiv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DevPiv.TabIndex = 32
        Me.DevPiv.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripMenuItem2, Me.TrggerOpenToolStripMenuItem, Me.ToolStripMenuItem1, Me.NormallyOpenToolStripMenuItem, Me.NormallyClosedToolStripMenuItem, Me.SetParameterToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(177, 180)
        Me.ContextMenuStrip1.Text = "Refresh"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(176, 22)
        Me.ToolStripMenuItem3.Text = "Connect Contoller"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(176, 22)
        Me.ToolStripMenuItem2.Text = "Disconnect Controller"
        '
        'TrggerOpenToolStripMenuItem
        '
        Me.TrggerOpenToolStripMenuItem.Name = "TrggerOpenToolStripMenuItem"
        Me.TrggerOpenToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.TrggerOpenToolStripMenuItem.Text = "Trigger Entry"
        '
        'NormallyOpenToolStripMenuItem
        '
        Me.NormallyOpenToolStripMenuItem.Name = "NormallyOpenToolStripMenuItem"
        Me.NormallyOpenToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.NormallyOpenToolStripMenuItem.Text = "Normally Open"
        Me.NormallyOpenToolStripMenuItem.Visible = False
        '
        'NormallyClosedToolStripMenuItem
        '
        Me.NormallyClosedToolStripMenuItem.Name = "NormallyClosedToolStripMenuItem"
        Me.NormallyClosedToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.NormallyClosedToolStripMenuItem.Text = "Normally Close"
        Me.NormallyClosedToolStripMenuItem.Visible = False
        '
        'SetParameterToolStripMenuItem
        '
        Me.SetParameterToolStripMenuItem.Name = "SetParameterToolStripMenuItem"
        Me.SetParameterToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SetParameterToolStripMenuItem.Text = "Set Parameter"
        Me.SetParameterToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(176, 22)
        Me.ToolStripMenuItem1.Text = "Trigger Exit"
        '
        'controlDev
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtCtrl)
        Me.Controls.Add(Me.DevPiv)
        Me.Controls.Add(Me.txtDoor)
        Me.Controls.Add(Me.txtHandler)
        Me.Controls.Add(Me.txtCardCode)
        Me.Name = "controlDev"
        Me.Size = New System.Drawing.Size(112, 36)
        CType(Me.DevPiv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmeRead As System.Windows.Forms.Timer
    Friend WithEvents txtHandler As System.Windows.Forms.TextBox
    Friend WithEvents txtCardCode As System.Windows.Forms.TextBox
    Friend WithEvents txtDoor As System.Windows.Forms.TextBox
    Friend WithEvents txtStatus As System.Windows.Forms.Label
    Friend WithEvents txtCtrl As System.Windows.Forms.Label
    Friend WithEvents DevPiv As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrggerOpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NormallyOpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NormallyClosedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetParameterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
