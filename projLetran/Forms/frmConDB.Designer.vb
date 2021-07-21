<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConDB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConDB))
        Me.txtIpAdd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdCon = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.cmdTest = New System.Windows.Forms.Button()
        Me.txtPort = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnTestLoc = New System.Windows.Forms.Button()
        Me.txtLocal = New System.Windows.Forms.TextBox()
        Me.txtUserLoc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPassLoc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdbLoc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        CType(Me.txtPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtIpAdd
        '
        Me.txtIpAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIpAdd.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIpAdd.Location = New System.Drawing.Point(113, 34)
        Me.txtIpAdd.MaxLength = 50
        Me.txtIpAdd.Name = "txtIpAdd"
        Me.txtIpAdd.Size = New System.Drawing.Size(229, 23)
        Me.txtIpAdd.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(46, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Server :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Username :"
        '
        'txtUser
        '
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUser.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(113, 76)
        Me.txtUser.MaxLength = 30
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(229, 23)
        Me.txtUser.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(24, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password :"
        '
        'txtPass
        '
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPass.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(113, 119)
        Me.txtPass.MaxLength = 30
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(204, 23)
        Me.txtPass.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-244, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Port :"
        Me.Label4.Visible = False
        '
        'cmdCon
        '
        Me.cmdCon.BackColor = System.Drawing.Color.White
        Me.cmdCon.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCon.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCon.Image = CType(resources.GetObject("cmdCon.Image"), System.Drawing.Image)
        Me.cmdCon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCon.Location = New System.Drawing.Point(275, 388)
        Me.cmdCon.Name = "cmdCon"
        Me.cmdCon.Size = New System.Drawing.Size(111, 34)
        Me.cmdCon.TabIndex = 9
        Me.cmdCon.Text = "&Save     "
        Me.cmdCon.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCon.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DimGray
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.GroupBox2)
        Me.Panel5.Controls.Add(Me.GroupBox1)
        Me.Panel5.Controls.Add(Me.txtPort)
        Me.Panel5.Controls.Add(Me.cmdCon)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(7, 7)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(397, 431)
        Me.Panel5.TabIndex = 104
        '
        'cmdTest
        '
        Me.cmdTest.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdTest.Image = CType(resources.GetObject("cmdTest.Image"), System.Drawing.Image)
        Me.cmdTest.Location = New System.Drawing.Point(323, 113)
        Me.cmdTest.Name = "cmdTest"
        Me.cmdTest.Size = New System.Drawing.Size(35, 30)
        Me.cmdTest.TabIndex = 3
        Me.cmdTest.UseVisualStyleBackColor = False
        '
        'txtPort
        '
        Me.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPort.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPort.Location = New System.Drawing.Point(-195, 171)
        Me.txtPort.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(184, 23)
        Me.txtPort.TabIndex = 3
        Me.txtPort.Value = New Decimal(New Integer() {3306, 0, 0, 0})
        Me.txtPort.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmdTest)
        Me.GroupBox1.Controls.Add(Me.txtIpAdd)
        Me.GroupBox1.Controls.Add(Me.txtUser)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPass)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(377, 166)
        Me.GroupBox1.TabIndex = 152
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Server Connection"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtdbLoc)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnTestLoc)
        Me.GroupBox2.Controls.Add(Me.txtLocal)
        Me.GroupBox2.Controls.Add(Me.txtUserLoc)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtPassLoc)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 176)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(377, 206)
        Me.GroupBox2.TabIndex = 153
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Local Connection"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(53, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Local :"
        '
        'btnTestLoc
        '
        Me.btnTestLoc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnTestLoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTestLoc.Image = CType(resources.GetObject("btnTestLoc.Image"), System.Drawing.Image)
        Me.btnTestLoc.Location = New System.Drawing.Point(323, 156)
        Me.btnTestLoc.Name = "btnTestLoc"
        Me.btnTestLoc.Size = New System.Drawing.Size(35, 30)
        Me.btnTestLoc.TabIndex = 8
        Me.btnTestLoc.UseVisualStyleBackColor = False
        '
        'txtLocal
        '
        Me.txtLocal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLocal.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocal.Location = New System.Drawing.Point(113, 34)
        Me.txtLocal.MaxLength = 50
        Me.txtLocal.Name = "txtLocal"
        Me.txtLocal.Size = New System.Drawing.Size(229, 23)
        Me.txtLocal.TabIndex = 4
        '
        'txtUserLoc
        '
        Me.txtUserLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserLoc.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserLoc.Location = New System.Drawing.Point(113, 76)
        Me.txtUserLoc.MaxLength = 30
        Me.txtUserLoc.Name = "txtUserLoc"
        Me.txtUserLoc.Size = New System.Drawing.Size(229, 23)
        Me.txtUserLoc.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(21, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Username :"
        '
        'txtPassLoc
        '
        Me.txtPassLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassLoc.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassLoc.Location = New System.Drawing.Point(113, 119)
        Me.txtPassLoc.MaxLength = 30
        Me.txtPassLoc.Name = "txtPassLoc"
        Me.txtPassLoc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassLoc.Size = New System.Drawing.Size(229, 23)
        Me.txtPassLoc.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(24, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Password :"
        '
        'txtdbLoc
        '
        Me.txtdbLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdbLoc.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdbLoc.Location = New System.Drawing.Point(113, 162)
        Me.txtdbLoc.MaxLength = 30
        Me.txtdbLoc.Name = "txtdbLoc"
        Me.txtdbLoc.Size = New System.Drawing.Size(204, 23)
        Me.txtdbLoc.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(24, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 16)
        Me.Label8.TabIndex = 153
        Me.Label8.Text = "Database :"
        '
        'frmConDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(412, 447)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConDB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Database Settings"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.txtPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIpAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdCon As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtPort As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdTest As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtdbLoc As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnTestLoc As Button
    Friend WithEvents txtLocal As TextBox
    Friend WithEvents txtUserLoc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPassLoc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
