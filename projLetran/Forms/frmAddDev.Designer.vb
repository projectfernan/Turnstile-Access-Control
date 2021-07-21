<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddDev
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddDev))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDev = New System.Windows.Forms.TextBox()
        Me.txtDelay = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIp = New System.Windows.Forms.TextBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtDelay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.cmdSave)
        Me.Panel1.Location = New System.Drawing.Point(7, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(403, 257)
        Me.Panel1.TabIndex = 434
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDev)
        Me.GroupBox1.Controls.Add(Me.txtDelay)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtIp)
        Me.GroupBox1.Controls.Add(Me.cboStatus)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(14, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 191)
        Me.GroupBox1.TabIndex = 90
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reader Settings"
        '
        'txtDev
        '
        Me.txtDev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDev.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDev.Location = New System.Drawing.Point(126, 36)
        Me.txtDev.MaxLength = 30
        Me.txtDev.Name = "txtDev"
        Me.txtDev.Size = New System.Drawing.Size(229, 23)
        Me.txtDev.TabIndex = 0
        '
        'txtDelay
        '
        Me.txtDelay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDelay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelay.Location = New System.Drawing.Point(127, 141)
        Me.txtDelay.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.txtDelay.Name = "txtDelay"
        Me.txtDelay.Size = New System.Drawing.Size(229, 24)
        Me.txtDelay.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 16)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "IP"
        '
        'txtIp
        '
        Me.txtIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIp.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIp.Location = New System.Drawing.Point(126, 70)
        Me.txtIp.MaxLength = 30
        Me.txtIp.Name = "txtIp"
        Me.txtIp.Size = New System.Drawing.Size(229, 23)
        Me.txtIp.TabIndex = 1
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"In", "Out"})
        Me.cboStatus.Location = New System.Drawing.Point(127, 104)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(229, 24)
        Me.cboStatus.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 16)
        Me.Label8.TabIndex = 86
        Me.Label8.Text = "Device Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(71, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Delay"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(70, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Status"
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.White
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSave.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(280, 208)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(111, 34)
        Me.cmdSave.TabIndex = 4
        Me.cmdSave.Text = "&Save     "
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'frmAddDev
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(417, 270)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddDev"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " New Device"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtDelay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDev As System.Windows.Forms.TextBox
    Friend WithEvents txtIp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDelay As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
