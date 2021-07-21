<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControler
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControler))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboPort = New System.Windows.Forms.ComboBox()
        Me.txtControlSN = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdCon = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmdCon)
        Me.GroupBox1.Controls.Add(Me.ComboPort)
        Me.GroupBox1.Controls.Add(Me.txtControlSN)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 174)
        Me.GroupBox1.TabIndex = 92
        Me.GroupBox1.TabStop = False
        '
        'ComboPort
        '
        Me.ComboPort.BackColor = System.Drawing.SystemColors.Window
        Me.ComboPort.Cursor = System.Windows.Forms.Cursors.Default
        Me.ComboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboPort.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboPort.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ComboPort.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4"})
        Me.ComboPort.Location = New System.Drawing.Point(177, 63)
        Me.ComboPort.Name = "ComboPort"
        Me.ComboPort.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboPort.Size = New System.Drawing.Size(139, 26)
        Me.ComboPort.TabIndex = 140
        '
        'txtControlSN
        '
        Me.txtControlSN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtControlSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtControlSN.Location = New System.Drawing.Point(178, 21)
        Me.txtControlSN.MaxLength = 8
        Me.txtControlSN.Name = "txtControlSN"
        Me.txtControlSN.Size = New System.Drawing.Size(135, 24)
        Me.txtControlSN.TabIndex = 131
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 19)
        Me.Label5.TabIndex = 119
        Me.Label5.Text = "Serial Number :"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(61, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 19)
        Me.Label7.TabIndex = 120
        Me.Label7.Text = "Serial Port :"
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.White
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCancel.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
        Me.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancel.Location = New System.Drawing.Point(188, 120)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(111, 34)
        Me.cmdCancel.TabIndex = 142
        Me.cmdCancel.Text = "&Cancel   "
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdCon
        '
        Me.cmdCon.BackColor = System.Drawing.Color.White
        Me.cmdCon.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCon.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCon.Image = CType(resources.GetObject("cmdCon.Image"), System.Drawing.Image)
        Me.cmdCon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCon.Location = New System.Drawing.Point(76, 120)
        Me.cmdCon.Name = "cmdCon"
        Me.cmdCon.Size = New System.Drawing.Size(111, 34)
        Me.cmdCon.TabIndex = 141
        Me.cmdCon.Text = "&Save     "
        Me.cmdCon.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCon.UseVisualStyleBackColor = False
        '
        'frmControler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(386, 189)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmControler"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Controller Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents ComboPort As System.Windows.Forms.ComboBox
    Friend WithEvents txtControlSN As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdCon As System.Windows.Forms.Button
End Class
