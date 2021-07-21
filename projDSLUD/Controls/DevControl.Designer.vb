<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DevControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevControl))
        Me.Dev1 = New Axzkemkeeper.AxCZKEM()
        Me.DevPiv = New System.Windows.Forms.PictureBox()
        Me.txtDevName = New System.Windows.Forms.Label()
        Me.DevStat = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmeClear1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmeClear2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmeClear3 = New System.Windows.Forms.Timer(Me.components)
        Me.tmeClear4 = New System.Windows.Forms.Timer(Me.components)
        Me.bgwR1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Dev1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevPiv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dev1
        '
        Me.Dev1.Enabled = True
        Me.Dev1.Location = New System.Drawing.Point(123, 1)
        Me.Dev1.Name = "Dev1"
        Me.Dev1.OcxState = CType(resources.GetObject("Dev1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Dev1.Size = New System.Drawing.Size(39, 38)
        Me.Dev1.TabIndex = 0
        Me.Dev1.Visible = False
        '
        'DevPiv
        '
        Me.DevPiv.Image = CType(resources.GetObject("DevPiv.Image"), System.Drawing.Image)
        Me.DevPiv.Location = New System.Drawing.Point(3, 2)
        Me.DevPiv.Name = "DevPiv"
        Me.DevPiv.Size = New System.Drawing.Size(35, 30)
        Me.DevPiv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DevPiv.TabIndex = 1
        Me.DevPiv.TabStop = False
        '
        'txtDevName
        '
        Me.txtDevName.AutoSize = True
        Me.txtDevName.ForeColor = System.Drawing.Color.White
        Me.txtDevName.Location = New System.Drawing.Point(41, 2)
        Me.txtDevName.Name = "txtDevName"
        Me.txtDevName.Size = New System.Drawing.Size(51, 13)
        Me.txtDevName.TabIndex = 2
        Me.txtDevName.Text = "Reader 1"
        '
        'DevStat
        '
        Me.DevStat.AutoSize = True
        Me.DevStat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DevStat.Location = New System.Drawing.Point(39, 18)
        Me.DevStat.Name = "DevStat"
        Me.DevStat.Size = New System.Drawing.Size(73, 13)
        Me.DevStat.TabIndex = 3
        Me.DevStat.Text = "Disconnected"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripMenuItem2})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(127, 48)
        Me.ContextMenuStrip1.Text = "Refresh"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(126, 22)
        Me.ToolStripMenuItem3.Text = "Connect"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(126, 22)
        Me.ToolStripMenuItem2.Text = "Disconnect"
        '
        'tmeClear1
        '
        Me.tmeClear1.Interval = 8000
        '
        'tmeClear2
        '
        Me.tmeClear2.Interval = 8000
        '
        'tmeClear3
        '
        Me.tmeClear3.Interval = 8000
        '
        'tmeClear4
        '
        Me.tmeClear4.Interval = 8000
        '
        'bgwR1
        '
        '
        'Timer1
        '
        '
        'DevControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.DevStat)
        Me.Controls.Add(Me.txtDevName)
        Me.Controls.Add(Me.DevPiv)
        Me.Controls.Add(Me.Dev1)
        Me.Name = "DevControl"
        Me.Size = New System.Drawing.Size(115, 35)
        CType(Me.Dev1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevPiv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dev1 As Axzkemkeeper.AxCZKEM
    Friend WithEvents DevPiv As System.Windows.Forms.PictureBox
    Friend WithEvents txtDevName As System.Windows.Forms.Label
    Friend WithEvents DevStat As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmeClear1 As System.Windows.Forms.Timer
    Friend WithEvents tmeClear2 As System.Windows.Forms.Timer
    Friend WithEvents tmeClear3 As System.Windows.Forms.Timer
    Friend WithEvents tmeClear4 As System.Windows.Forms.Timer
    Friend WithEvents bgwR1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
