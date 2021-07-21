<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevConn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevConn))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdTest2 = New System.Windows.Forms.Button()
        Me.cmdTest1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDev2IP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDev1IP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDelay = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtDelay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtDelay)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.cmdTest2)
        Me.GroupBox1.Controls.Add(Me.cmdTest1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDev2IP)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDev1IP)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 212)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.White
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCancel.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
        Me.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancel.Location = New System.Drawing.Point(208, 159)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(111, 34)
        Me.cmdCancel.TabIndex = 5
        Me.cmdCancel.Text = "&Cancel   "
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.White
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSave.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(96, 159)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(111, 34)
        Me.cmdSave.TabIndex = 4
        Me.cmdSave.Text = "&Save     "
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'cmdTest2
        '
        Me.cmdTest2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdTest2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdTest2.Image = CType(resources.GetObject("cmdTest2.Image"), System.Drawing.Image)
        Me.cmdTest2.Location = New System.Drawing.Point(346, 68)
        Me.cmdTest2.Name = "cmdTest2"
        Me.cmdTest2.Size = New System.Drawing.Size(35, 30)
        Me.cmdTest2.TabIndex = 3
        Me.cmdTest2.UseVisualStyleBackColor = False
        '
        'cmdTest1
        '
        Me.cmdTest1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdTest1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdTest1.Image = CType(resources.GetObject("cmdTest1.Image"), System.Drawing.Image)
        Me.cmdTest1.Location = New System.Drawing.Point(346, 26)
        Me.cmdTest1.Name = "cmdTest1"
        Me.cmdTest1.Size = New System.Drawing.Size(35, 30)
        Me.cmdTest1.TabIndex = 1
        Me.cmdTest1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Reader2 IP"
        '
        'txtDev2IP
        '
        Me.txtDev2IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDev2IP.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDev2IP.Location = New System.Drawing.Point(143, 72)
        Me.txtDev2IP.Name = "txtDev2IP"
        Me.txtDev2IP.Size = New System.Drawing.Size(189, 23)
        Me.txtDev2IP.TabIndex = 2
        Me.txtDev2IP.Text = "192.168.1.201"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Reader1 IP"
        '
        'txtDev1IP
        '
        Me.txtDev1IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDev1IP.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDev1IP.Location = New System.Drawing.Point(143, 29)
        Me.txtDev1IP.Name = "txtDev1IP"
        Me.txtDev1IP.Size = New System.Drawing.Size(189, 23)
        Me.txtDev1IP.TabIndex = 0
        Me.txtDev1IP.Text = "192.168.1.201"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Clear Delay"
        '
        'txtDelay
        '
        Me.txtDelay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDelay.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelay.Location = New System.Drawing.Point(143, 115)
        Me.txtDelay.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtDelay.Name = "txtDelay"
        Me.txtDelay.Size = New System.Drawing.Size(189, 23)
        Me.txtDelay.TabIndex = 19
        Me.txtDelay.Value = New Decimal(New Integer() {10000, 0, 0, 0})
        '
        'frmDevConn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(429, 226)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDevConn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Reader Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtDelay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdTest2 As System.Windows.Forms.Button
    Friend WithEvents cmdTest1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDev2IP As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDev1IP As System.Windows.Forms.TextBox
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDelay As System.Windows.Forms.NumericUpDown
End Class
