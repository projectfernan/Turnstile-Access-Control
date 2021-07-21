<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dev1Control
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dev1Control))
        Me.Dev1 = New Axzkemkeeper.AxCZKEM()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevStat = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TrggerOpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtDevName = New System.Windows.Forms.Label()
        Me.DevPiv = New System.Windows.Forms.PictureBox()
        Me.CamEntry = New AxNETVIDEOACTIVEXLib.AxNetVideoActiveX()
        Me.CamExit = New AxNETVIDEOACTIVEXLib.AxNetVideoActiveX()
        Me.bgwR1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.Dev1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.DevPiv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CamEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CamExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dev1
        '
        Me.Dev1.Enabled = True
        Me.Dev1.Location = New System.Drawing.Point(3, 72)
        Me.Dev1.Name = "Dev1"
        Me.Dev1.OcxState = CType(resources.GetObject("Dev1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Dev1.Size = New System.Drawing.Size(39, 38)
        Me.Dev1.TabIndex = 4
        Me.Dev1.Visible = False
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(172, 22)
        Me.ToolStripMenuItem2.Text = "Disconnect Reader"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(172, 22)
        Me.ToolStripMenuItem3.Text = "Connect Reader"
        '
        'DevStat
        '
        Me.DevStat.AutoSize = True
        Me.DevStat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DevStat.Location = New System.Drawing.Point(37, 18)
        Me.DevStat.Name = "DevStat"
        Me.DevStat.Size = New System.Drawing.Size(73, 13)
        Me.DevStat.TabIndex = 7
        Me.DevStat.Text = "Disconnected"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripMenuItem2, Me.TrggerOpenToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(173, 70)
        Me.ContextMenuStrip1.Text = "Refresh"
        '
        'TrggerOpenToolStripMenuItem
        '
        Me.TrggerOpenToolStripMenuItem.Name = "TrggerOpenToolStripMenuItem"
        Me.TrggerOpenToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.TrggerOpenToolStripMenuItem.Text = "Test Trigger"
        '
        'txtDevName
        '
        Me.txtDevName.AutoSize = True
        Me.txtDevName.ForeColor = System.Drawing.Color.White
        Me.txtDevName.Location = New System.Drawing.Point(38, 2)
        Me.txtDevName.Name = "txtDevName"
        Me.txtDevName.Size = New System.Drawing.Size(51, 13)
        Me.txtDevName.TabIndex = 6
        Me.txtDevName.Text = "Reader 1"
        '
        'DevPiv
        '
        Me.DevPiv.Image = CType(resources.GetObject("DevPiv.Image"), System.Drawing.Image)
        Me.DevPiv.Location = New System.Drawing.Point(1, 2)
        Me.DevPiv.Name = "DevPiv"
        Me.DevPiv.Size = New System.Drawing.Size(35, 30)
        Me.DevPiv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DevPiv.TabIndex = 5
        Me.DevPiv.TabStop = False
        '
        'CamEntry
        '
        Me.CamEntry.Enabled = True
        Me.CamEntry.Location = New System.Drawing.Point(3, 38)
        Me.CamEntry.Name = "CamEntry"
        Me.CamEntry.OcxState = CType(resources.GetObject("CamEntry.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CamEntry.Size = New System.Drawing.Size(29, 28)
        Me.CamEntry.TabIndex = 46
        '
        'CamExit
        '
        Me.CamExit.Enabled = True
        Me.CamExit.Location = New System.Drawing.Point(39, 38)
        Me.CamExit.Name = "CamExit"
        Me.CamExit.OcxState = CType(resources.GetObject("CamExit.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CamExit.Size = New System.Drawing.Size(31, 28)
        Me.CamExit.TabIndex = 48
        '
        'bgwR1
        '
        '
        'Dev1Control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.CamExit)
        Me.Controls.Add(Me.CamEntry)
        Me.Controls.Add(Me.Dev1)
        Me.Controls.Add(Me.DevStat)
        Me.Controls.Add(Me.txtDevName)
        Me.Controls.Add(Me.DevPiv)
        Me.Name = "Dev1Control"
        Me.Size = New System.Drawing.Size(112, 33)
        CType(Me.Dev1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.DevPiv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CamEntry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CamExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dev1 As Axzkemkeeper.AxCZKEM
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DevStat As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents txtDevName As System.Windows.Forms.Label
    Friend WithEvents DevPiv As System.Windows.Forms.PictureBox
    Friend WithEvents CamEntry As AxNETVIDEOACTIVEXLib.AxNetVideoActiveX
    Friend WithEvents CamExit As AxNETVIDEOACTIVEXLib.AxNetVideoActiveX
    Friend WithEvents bgwR1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TrggerOpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
