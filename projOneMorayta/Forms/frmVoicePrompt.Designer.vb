<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoicePrompt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVoicePrompt))
        Me.Ofd = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPlayAcGroup = New System.Windows.Forms.Button()
        Me.btnAcG = New System.Windows.Forms.Button()
        Me.btnPlayUnknown = New System.Windows.Forms.Button()
        Me.btnUnknown = New System.Windows.Forms.Button()
        Me.btnPlayExpired = New System.Windows.Forms.Button()
        Me.btnExpired = New System.Windows.Forms.Button()
        Me.btnPlayExitFirst = New System.Windows.Forms.Button()
        Me.btnPlayEntryFirst = New System.Windows.Forms.Button()
        Me.btnPlaySeeAdmin = New System.Windows.Forms.Button()
        Me.btnExtF = New System.Windows.Forms.Button()
        Me.btnOfdEF = New System.Windows.Forms.Button()
        Me.cmdTestDbloc = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAcGroup = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUnknown = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCardExp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtExitFirst = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEntryFirst = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSeeAdmin = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ofd
        '
        Me.Ofd.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnPlayAcGroup)
        Me.Panel1.Controls.Add(Me.btnAcG)
        Me.Panel1.Controls.Add(Me.btnPlayUnknown)
        Me.Panel1.Controls.Add(Me.btnUnknown)
        Me.Panel1.Controls.Add(Me.btnPlayExpired)
        Me.Panel1.Controls.Add(Me.btnExpired)
        Me.Panel1.Controls.Add(Me.btnPlayExitFirst)
        Me.Panel1.Controls.Add(Me.btnPlayEntryFirst)
        Me.Panel1.Controls.Add(Me.btnPlaySeeAdmin)
        Me.Panel1.Controls.Add(Me.btnExtF)
        Me.Panel1.Controls.Add(Me.btnOfdEF)
        Me.Panel1.Controls.Add(Me.cmdTestDbloc)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtAcGroup)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtUnknown)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtCardExp)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtExitFirst)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtEntryFirst)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtSeeAdmin)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(457, 290)
        Me.Panel1.TabIndex = 0
        '
        'btnPlayAcGroup
        '
        Me.btnPlayAcGroup.BackColor = System.Drawing.Color.White
        Me.btnPlayAcGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPlayAcGroup.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayAcGroup.Image = CType(resources.GetObject("btnPlayAcGroup.Image"), System.Drawing.Image)
        Me.btnPlayAcGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPlayAcGroup.Location = New System.Drawing.Point(403, 225)
        Me.btnPlayAcGroup.Name = "btnPlayAcGroup"
        Me.btnPlayAcGroup.Size = New System.Drawing.Size(34, 34)
        Me.btnPlayAcGroup.TabIndex = 17
        Me.btnPlayAcGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPlayAcGroup.UseVisualStyleBackColor = False
        '
        'btnAcG
        '
        Me.btnAcG.BackColor = System.Drawing.Color.White
        Me.btnAcG.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAcG.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcG.Image = CType(resources.GetObject("btnAcG.Image"), System.Drawing.Image)
        Me.btnAcG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAcG.Location = New System.Drawing.Point(363, 225)
        Me.btnAcG.Name = "btnAcG"
        Me.btnAcG.Size = New System.Drawing.Size(34, 34)
        Me.btnAcG.TabIndex = 16
        Me.btnAcG.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAcG.UseVisualStyleBackColor = False
        '
        'btnPlayUnknown
        '
        Me.btnPlayUnknown.BackColor = System.Drawing.Color.White
        Me.btnPlayUnknown.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPlayUnknown.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayUnknown.Image = CType(resources.GetObject("btnPlayUnknown.Image"), System.Drawing.Image)
        Me.btnPlayUnknown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPlayUnknown.Location = New System.Drawing.Point(403, 187)
        Me.btnPlayUnknown.Name = "btnPlayUnknown"
        Me.btnPlayUnknown.Size = New System.Drawing.Size(34, 34)
        Me.btnPlayUnknown.TabIndex = 14
        Me.btnPlayUnknown.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPlayUnknown.UseVisualStyleBackColor = False
        '
        'btnUnknown
        '
        Me.btnUnknown.BackColor = System.Drawing.Color.White
        Me.btnUnknown.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUnknown.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnknown.Image = CType(resources.GetObject("btnUnknown.Image"), System.Drawing.Image)
        Me.btnUnknown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUnknown.Location = New System.Drawing.Point(363, 187)
        Me.btnUnknown.Name = "btnUnknown"
        Me.btnUnknown.Size = New System.Drawing.Size(34, 34)
        Me.btnUnknown.TabIndex = 13
        Me.btnUnknown.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUnknown.UseVisualStyleBackColor = False
        '
        'btnPlayExpired
        '
        Me.btnPlayExpired.BackColor = System.Drawing.Color.White
        Me.btnPlayExpired.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPlayExpired.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayExpired.Image = CType(resources.GetObject("btnPlayExpired.Image"), System.Drawing.Image)
        Me.btnPlayExpired.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPlayExpired.Location = New System.Drawing.Point(403, 149)
        Me.btnPlayExpired.Name = "btnPlayExpired"
        Me.btnPlayExpired.Size = New System.Drawing.Size(34, 34)
        Me.btnPlayExpired.TabIndex = 11
        Me.btnPlayExpired.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPlayExpired.UseVisualStyleBackColor = False
        '
        'btnExpired
        '
        Me.btnExpired.BackColor = System.Drawing.Color.White
        Me.btnExpired.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExpired.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpired.Image = CType(resources.GetObject("btnExpired.Image"), System.Drawing.Image)
        Me.btnExpired.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExpired.Location = New System.Drawing.Point(363, 149)
        Me.btnExpired.Name = "btnExpired"
        Me.btnExpired.Size = New System.Drawing.Size(34, 34)
        Me.btnExpired.TabIndex = 10
        Me.btnExpired.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExpired.UseVisualStyleBackColor = False
        '
        'btnPlayExitFirst
        '
        Me.btnPlayExitFirst.BackColor = System.Drawing.Color.White
        Me.btnPlayExitFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPlayExitFirst.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayExitFirst.Image = CType(resources.GetObject("btnPlayExitFirst.Image"), System.Drawing.Image)
        Me.btnPlayExitFirst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPlayExitFirst.Location = New System.Drawing.Point(403, 110)
        Me.btnPlayExitFirst.Name = "btnPlayExitFirst"
        Me.btnPlayExitFirst.Size = New System.Drawing.Size(34, 34)
        Me.btnPlayExitFirst.TabIndex = 8
        Me.btnPlayExitFirst.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPlayExitFirst.UseVisualStyleBackColor = False
        '
        'btnPlayEntryFirst
        '
        Me.btnPlayEntryFirst.BackColor = System.Drawing.Color.White
        Me.btnPlayEntryFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPlayEntryFirst.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayEntryFirst.Image = CType(resources.GetObject("btnPlayEntryFirst.Image"), System.Drawing.Image)
        Me.btnPlayEntryFirst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPlayEntryFirst.Location = New System.Drawing.Point(403, 71)
        Me.btnPlayEntryFirst.Name = "btnPlayEntryFirst"
        Me.btnPlayEntryFirst.Size = New System.Drawing.Size(34, 34)
        Me.btnPlayEntryFirst.TabIndex = 5
        Me.btnPlayEntryFirst.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPlayEntryFirst.UseVisualStyleBackColor = False
        '
        'btnPlaySeeAdmin
        '
        Me.btnPlaySeeAdmin.BackColor = System.Drawing.Color.White
        Me.btnPlaySeeAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPlaySeeAdmin.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlaySeeAdmin.Image = CType(resources.GetObject("btnPlaySeeAdmin.Image"), System.Drawing.Image)
        Me.btnPlaySeeAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPlaySeeAdmin.Location = New System.Drawing.Point(403, 32)
        Me.btnPlaySeeAdmin.Name = "btnPlaySeeAdmin"
        Me.btnPlaySeeAdmin.Size = New System.Drawing.Size(34, 34)
        Me.btnPlaySeeAdmin.TabIndex = 2
        Me.btnPlaySeeAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPlaySeeAdmin.UseVisualStyleBackColor = False
        '
        'btnExtF
        '
        Me.btnExtF.BackColor = System.Drawing.Color.White
        Me.btnExtF.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExtF.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExtF.Image = CType(resources.GetObject("btnExtF.Image"), System.Drawing.Image)
        Me.btnExtF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExtF.Location = New System.Drawing.Point(363, 110)
        Me.btnExtF.Name = "btnExtF"
        Me.btnExtF.Size = New System.Drawing.Size(34, 34)
        Me.btnExtF.TabIndex = 7
        Me.btnExtF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExtF.UseVisualStyleBackColor = False
        '
        'btnOfdEF
        '
        Me.btnOfdEF.BackColor = System.Drawing.Color.White
        Me.btnOfdEF.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOfdEF.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOfdEF.Image = CType(resources.GetObject("btnOfdEF.Image"), System.Drawing.Image)
        Me.btnOfdEF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOfdEF.Location = New System.Drawing.Point(363, 71)
        Me.btnOfdEF.Name = "btnOfdEF"
        Me.btnOfdEF.Size = New System.Drawing.Size(34, 34)
        Me.btnOfdEF.TabIndex = 4
        Me.btnOfdEF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOfdEF.UseVisualStyleBackColor = False
        '
        'cmdTestDbloc
        '
        Me.cmdTestDbloc.BackColor = System.Drawing.Color.White
        Me.cmdTestDbloc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdTestDbloc.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTestDbloc.Image = CType(resources.GetObject("cmdTestDbloc.Image"), System.Drawing.Image)
        Me.cmdTestDbloc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdTestDbloc.Location = New System.Drawing.Point(363, 32)
        Me.cmdTestDbloc.Name = "cmdTestDbloc"
        Me.cmdTestDbloc.Size = New System.Drawing.Size(34, 34)
        Me.cmdTestDbloc.TabIndex = 1
        Me.cmdTestDbloc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdTestDbloc.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(17, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 16)
        Me.Label5.TabIndex = 112
        Me.Label5.Text = "Access Group"
        '
        'txtAcGroup
        '
        Me.txtAcGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAcGroup.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcGroup.Location = New System.Drawing.Point(128, 229)
        Me.txtAcGroup.MaxLength = 500
        Me.txtAcGroup.Name = "txtAcGroup"
        Me.txtAcGroup.Size = New System.Drawing.Size(229, 23)
        Me.txtAcGroup.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(23, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 16)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "Uknown Card"
        '
        'txtUnknown
        '
        Me.txtUnknown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnknown.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnknown.Location = New System.Drawing.Point(128, 192)
        Me.txtUnknown.MaxLength = 500
        Me.txtUnknown.Name = "txtUnknown"
        Me.txtUnknown.Size = New System.Drawing.Size(229, 23)
        Me.txtUnknown.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(24, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 16)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Card Expired"
        '
        'txtCardExp
        '
        Me.txtCardExp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCardExp.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardExp.Location = New System.Drawing.Point(128, 154)
        Me.txtCardExp.MaxLength = 500
        Me.txtCardExp.Name = "txtCardExp"
        Me.txtCardExp.Size = New System.Drawing.Size(229, 23)
        Me.txtCardExp.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(55, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "Exit First"
        '
        'txtExitFirst
        '
        Me.txtExitFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExitFirst.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExitFirst.Location = New System.Drawing.Point(128, 115)
        Me.txtExitFirst.MaxLength = 500
        Me.txtExitFirst.Name = "txtExitFirst"
        Me.txtExitFirst.Size = New System.Drawing.Size(229, 23)
        Me.txtExitFirst.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(45, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Entry First"
        '
        'txtEntryFirst
        '
        Me.txtEntryFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEntryFirst.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntryFirst.Location = New System.Drawing.Point(128, 76)
        Me.txtEntryFirst.MaxLength = 500
        Me.txtEntryFirst.Name = "txtEntryFirst"
        Me.txtEntryFirst.Size = New System.Drawing.Size(229, 23)
        Me.txtEntryFirst.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(39, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 16)
        Me.Label8.TabIndex = 102
        Me.Label8.Text = "See Admin"
        '
        'txtSeeAdmin
        '
        Me.txtSeeAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSeeAdmin.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeeAdmin.Location = New System.Drawing.Point(128, 38)
        Me.txtSeeAdmin.MaxLength = 500
        Me.txtSeeAdmin.Name = "txtSeeAdmin"
        Me.txtSeeAdmin.Size = New System.Drawing.Size(229, 23)
        Me.txtSeeAdmin.TabIndex = 0
        '
        'frmVoicePrompt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(469, 303)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVoicePrompt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Voice Prompt Settings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAcGroup As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUnknown As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCardExp As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtExitFirst As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEntryFirst As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSeeAdmin As System.Windows.Forms.TextBox
    Friend WithEvents btnPlayAcGroup As System.Windows.Forms.Button
    Friend WithEvents btnAcG As System.Windows.Forms.Button
    Friend WithEvents btnPlayUnknown As System.Windows.Forms.Button
    Friend WithEvents btnUnknown As System.Windows.Forms.Button
    Friend WithEvents btnPlayExpired As System.Windows.Forms.Button
    Friend WithEvents btnExpired As System.Windows.Forms.Button
    Friend WithEvents btnPlayExitFirst As System.Windows.Forms.Button
    Friend WithEvents btnPlayEntryFirst As System.Windows.Forms.Button
    Friend WithEvents btnPlaySeeAdmin As System.Windows.Forms.Button
    Friend WithEvents btnExtF As System.Windows.Forms.Button
    Friend WithEvents btnOfdEF As System.Windows.Forms.Button
    Friend WithEvents cmdTestDbloc As System.Windows.Forms.Button
End Class
