<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.cmdLogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(6, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 16)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(27, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Username"
        '
        'txtUser
        '
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUser.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(112, 55)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(262, 23)
        Me.txtUser.TabIndex = 89
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(30, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Password"
        '
        'txtPass
        '
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPass.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(112, 97)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(262, 23)
        Me.txtPass.TabIndex = 91
        '
        'cmdLogin
        '
        Me.cmdLogin.BackColor = System.Drawing.Color.White
        Me.cmdLogin.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdLogin.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogin.Image = CType(resources.GetObject("cmdLogin.Image"), System.Drawing.Image)
        Me.cmdLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLogin.Location = New System.Drawing.Point(263, 136)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(111, 34)
        Me.cmdLogin.TabIndex = 93
        Me.cmdLogin.Text = "&Login    "
        Me.cmdLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdLogin.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(55, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(300, 15)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "* Please enter your username and password *"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DimGray
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.cmdLogin)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.txtPass)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.txtUser)
        Me.Panel5.Location = New System.Drawing.Point(7, 23)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(398, 194)
        Me.Panel5.TabIndex = 100
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(412, 226)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents cmdLogin As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
End Class
