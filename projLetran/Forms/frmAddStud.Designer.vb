<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddStud
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddStud))
        Me.OpenPath = New System.Windows.Forms.OpenFileDialog()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGuardian = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAC = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtBdate = New System.Windows.Forms.DateTimePicker()
        Me.txtGy = New System.Windows.Forms.ComboBox()
        Me.txtSec = New System.Windows.Forms.ComboBox()
        Me.cmdCon = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboEduLv = New System.Windows.Forms.ComboBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtYearEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tmeRead = New System.Windows.Forms.Timer(Me.components)
        Me.cmdUpdateCard = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenPath
        '
        Me.OpenPath.FileName = "OpenFileDialog1"
        '
        'txtId
        '
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtId.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(151, 51)
        Me.txtId.MaxLength = 30
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(229, 23)
        Me.txtId.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(67, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 16)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "ID Number"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(151, 121)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(229, 23)
        Me.txtName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(42, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 16)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Student Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(58, 364)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 16)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "Grade/Year"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(30, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 16)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Contact Number"
        '
        'txtGuardian
        '
        Me.txtGuardian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGuardian.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuardian.Location = New System.Drawing.Point(151, 289)
        Me.txtGuardian.MaxLength = 50
        Me.txtGuardian.Name = "txtGuardian"
        Me.txtGuardian.Size = New System.Drawing.Size(229, 23)
        Me.txtGuardian.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(87, 400)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "Section"
        '
        'txtContact
        '
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContact.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(151, 254)
        Me.txtContact.MaxLength = 40
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(229, 23)
        Me.txtContact.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(32, 292)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 16)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "Guardian Name"
        '
        'txtAdd
        '
        Me.txtAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdd.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd.Location = New System.Drawing.Point(151, 219)
        Me.txtAdd.MaxLength = 150
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(229, 23)
        Me.txtAdd.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(81, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "Address"
        '
        'txtAC
        '
        Me.txtAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAC.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAC.Location = New System.Drawing.Point(152, 17)
        Me.txtAC.MaxLength = 8
        Me.txtAC.Name = "txtAC"
        Me.txtAC.Size = New System.Drawing.Size(186, 23)
        Me.txtAC.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(64, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 16)
        Me.Label8.TabIndex = 100
        Me.Label8.Text = "AC Number"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(72, 189)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 16)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "Birth Date"
        '
        'dtBdate
        '
        Me.dtBdate.CustomFormat = "MM-dd-yyyy"
        Me.dtBdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtBdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtBdate.Location = New System.Drawing.Point(151, 186)
        Me.dtBdate.Name = "dtBdate"
        Me.dtBdate.Size = New System.Drawing.Size(229, 22)
        Me.dtBdate.TabIndex = 5
        '
        'txtGy
        '
        Me.txtGy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGy.FormattingEnabled = True
        Me.txtGy.Location = New System.Drawing.Point(151, 361)
        Me.txtGy.Name = "txtGy"
        Me.txtGy.Size = New System.Drawing.Size(229, 24)
        Me.txtGy.TabIndex = 10
        '
        'txtSec
        '
        Me.txtSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSec.FormattingEnabled = True
        Me.txtSec.Location = New System.Drawing.Point(151, 397)
        Me.txtSec.Name = "txtSec"
        Me.txtSec.Size = New System.Drawing.Size(229, 24)
        Me.txtSec.TabIndex = 11
        '
        'cmdCon
        '
        Me.cmdCon.BackColor = System.Drawing.Color.White
        Me.cmdCon.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCon.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCon.Image = CType(resources.GetObject("cmdCon.Image"), System.Drawing.Image)
        Me.cmdCon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCon.Location = New System.Drawing.Point(271, 461)
        Me.cmdCon.Name = "cmdCon"
        Me.cmdCon.Size = New System.Drawing.Size(111, 34)
        Me.cmdCon.TabIndex = 13
        Me.cmdCon.Text = "&Save     "
        Me.cmdCon.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCon.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(87, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 16)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "Gender"
        '
        'txtGender
        '
        Me.txtGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.FormattingEnabled = True
        Me.txtGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.txtGender.Location = New System.Drawing.Point(151, 153)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(230, 24)
        Me.txtGender.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(28, 328)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 16)
        Me.Label11.TabIndex = 108
        Me.Label11.Text = "Education Level"
        '
        'cboEduLv
        '
        Me.cboEduLv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEduLv.FormattingEnabled = True
        Me.cboEduLv.Location = New System.Drawing.Point(151, 325)
        Me.cboEduLv.Name = "cboEduLv"
        Me.cboEduLv.Size = New System.Drawing.Size(229, 24)
        Me.cboEduLv.TabIndex = 9
        '
        'txtCourse
        '
        Me.txtCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCourse.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse.Location = New System.Drawing.Point(151, 86)
        Me.txtCourse.MaxLength = 50
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(229, 23)
        Me.txtCourse.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(90, 88)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 16)
        Me.Label12.TabIndex = 110
        Me.Label12.Text = "Course"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.cmdUpdateCard)
        Me.Panel1.Controls.Add(Me.dtYearEnd)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtCourse)
        Me.Panel1.Controls.Add(Me.cboEduLv)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtGender)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.cmdCon)
        Me.Panel1.Controls.Add(Me.txtSec)
        Me.Panel1.Controls.Add(Me.txtGy)
        Me.Panel1.Controls.Add(Me.dtBdate)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtAC)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtAdd)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtContact)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtGuardian)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtId)
        Me.Panel1.Location = New System.Drawing.Point(7, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(407, 507)
        Me.Panel1.TabIndex = 0
        '
        'dtYearEnd
        '
        Me.dtYearEnd.CustomFormat = "MM-dd-yyyy"
        Me.dtYearEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtYearEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtYearEnd.Location = New System.Drawing.Point(151, 431)
        Me.dtYearEnd.Name = "dtYearEnd"
        Me.dtYearEnd.Size = New System.Drawing.Size(229, 22)
        Me.dtYearEnd.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(75, 434)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 16)
        Me.Label13.TabIndex = 112
        Me.Label13.Text = "Year End"
        '
        'tmeRead
        '
        '
        'cmdUpdateCard
        '
        Me.cmdUpdateCard.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdUpdateCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdUpdateCard.Image = CType(resources.GetObject("cmdUpdateCard.Image"), System.Drawing.Image)
        Me.cmdUpdateCard.Location = New System.Drawing.Point(345, 13)
        Me.cmdUpdateCard.Name = "cmdUpdateCard"
        Me.cmdUpdateCard.Size = New System.Drawing.Size(35, 31)
        Me.cmdUpdateCard.TabIndex = 152
        Me.cmdUpdateCard.UseVisualStyleBackColor = False
        '
        'frmAddStud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(422, 522)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddStud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " New Student"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenPath As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtGuardian As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAC As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtBdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtGy As System.Windows.Forms.ComboBox
    Friend WithEvents txtSec As System.Windows.Forms.ComboBox
    Friend WithEvents cmdCon As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboEduLv As System.Windows.Forms.ComboBox
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtYearEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tmeRead As System.Windows.Forms.Timer
    Friend WithEvents cmdUpdateCard As System.Windows.Forms.Button
End Class
