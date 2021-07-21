<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogs))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtKeyword = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboSec = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboDeptCateg = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdDel = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.LstEmpRec = New System.Windows.Forms.ListView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtDateFrm = New System.Windows.Forms.DateTimePicker()
        Me.dtDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtTmeTo = New System.Windows.Forms.DateTimePicker()
        Me.dtTmeFrm = New System.Windows.Forms.DateTimePicker()
        Me.EmpPic = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.EmpPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtKeyword)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.cboSec)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cboCategory)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cboDeptCateg)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmdDel)
        Me.Panel1.Controls.Add(Me.cmdPrint)
        Me.Panel1.Controls.Add(Me.LstEmpRec)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.cmdEdit)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtDateFrm)
        Me.Panel1.Controls.Add(Me.dtDateTo)
        Me.Panel1.Controls.Add(Me.dtTmeTo)
        Me.Panel1.Controls.Add(Me.dtTmeFrm)
        Me.Panel1.Controls.Add(Me.EmpPic)
        Me.Panel1.Location = New System.Drawing.Point(7, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1110, 657)
        Me.Panel1.TabIndex = 105
        '
        'txtKeyword
        '
        Me.txtKeyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKeyword.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeyword.Location = New System.Drawing.Point(149, 403)
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Size = New System.Drawing.Size(227, 23)
        Me.txtKeyword.TabIndex = 133
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(71, 405)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 16)
        Me.Label9.TabIndex = 132
        Me.Label9.Text = "Keyword :"
        '
        'cboSec
        '
        Me.cboSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSec.FormattingEnabled = True
        Me.cboSec.Location = New System.Drawing.Point(149, 364)
        Me.cboSec.Name = "cboSec"
        Me.cboSec.Size = New System.Drawing.Size(229, 24)
        Me.cboSec.TabIndex = 129
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(78, 367)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 128
        Me.Label5.Text = "Section :"
        '
        'cboCategory
        '
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(149, 326)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(229, 24)
        Me.cboCategory.TabIndex = 127
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(14, 329)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 16)
        Me.Label6.TabIndex = 126
        Me.Label6.Text = "Search Category :"
        '
        'cboDeptCateg
        '
        Me.cboDeptCateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDeptCateg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDeptCateg.FormattingEnabled = True
        Me.cboDeptCateg.Location = New System.Drawing.Point(149, 289)
        Me.cboDeptCateg.Name = "cboDeptCateg"
        Me.cboDeptCateg.Size = New System.Drawing.Size(229, 24)
        Me.cboDeptCateg.TabIndex = 124
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(26, 292)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "Dept. Category :"
        '
        'cmdDel
        '
        Me.cmdDel.BackColor = System.Drawing.Color.White
        Me.cmdDel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDel.Enabled = False
        Me.cmdDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDel.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDel.Image = CType(resources.GetObject("cmdDel.Image"), System.Drawing.Image)
        Me.cmdDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDel.Location = New System.Drawing.Point(200, 569)
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.Size = New System.Drawing.Size(111, 34)
        Me.cmdDel.TabIndex = 120
        Me.cmdDel.Text = "&Delete   "
        Me.cmdDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdDel.UseVisualStyleBackColor = False
        Me.cmdDel.Visible = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.Color.White
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Enabled = False
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPrint.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPrint.Location = New System.Drawing.Point(200, 533)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(111, 34)
        Me.cmdPrint.TabIndex = 119
        Me.cmdPrint.Text = "&Print    "
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'LstEmpRec
        '
        Me.LstEmpRec.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LstEmpRec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstEmpRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstEmpRec.FullRowSelect = True
        Me.LstEmpRec.GridLines = True
        Me.LstEmpRec.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LstEmpRec.Location = New System.Drawing.Point(393, 14)
        Me.LstEmpRec.MultiSelect = False
        Me.LstEmpRec.Name = "LstEmpRec"
        Me.LstEmpRec.Size = New System.Drawing.Size(703, 628)
        Me.LstEmpRec.TabIndex = 118
        Me.LstEmpRec.UseCompatibleStateImageBehavior = False
        Me.LstEmpRec.View = System.Windows.Forms.View.Details
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(88, 533)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 34)
        Me.Button1.TabIndex = 116
        Me.Button1.Text = "&Search   "
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmdEdit
        '
        Me.cmdEdit.BackColor = System.Drawing.Color.White
        Me.cmdEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEdit.Enabled = False
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEdit.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEdit.Location = New System.Drawing.Point(88, 569)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(111, 34)
        Me.cmdEdit.TabIndex = 115
        Me.cmdEdit.Text = "&View All  "
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdEdit.UseVisualStyleBackColor = False
        Me.cmdEdit.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(51, 489)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "Date to :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(34, 456)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "Date from :"
        '
        'dtDateFrm
        '
        Me.dtDateFrm.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateFrm.CustomFormat = "yyyy-MM-dd"
        Me.dtDateFrm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateFrm.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateFrm.Location = New System.Drawing.Point(119, 451)
        Me.dtDateFrm.Name = "dtDateFrm"
        Me.dtDateFrm.Size = New System.Drawing.Size(120, 24)
        Me.dtDateFrm.TabIndex = 112
        '
        'dtDateTo
        '
        Me.dtDateTo.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateTo.CustomFormat = "yyyy-MM-dd"
        Me.dtDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateTo.Location = New System.Drawing.Point(119, 485)
        Me.dtDateTo.Name = "dtDateTo"
        Me.dtDateTo.Size = New System.Drawing.Size(120, 24)
        Me.dtDateTo.TabIndex = 111
        '
        'dtTmeTo
        '
        Me.dtTmeTo.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTmeTo.CustomFormat = "HH:mm:ss tt"
        Me.dtTmeTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTmeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTmeTo.Location = New System.Drawing.Point(249, 485)
        Me.dtTmeTo.Name = "dtTmeTo"
        Me.dtTmeTo.ShowUpDown = True
        Me.dtTmeTo.Size = New System.Drawing.Size(118, 24)
        Me.dtTmeTo.TabIndex = 110
        Me.dtTmeTo.Value = New Date(2012, 6, 19, 23, 59, 0, 0)
        '
        'dtTmeFrm
        '
        Me.dtTmeFrm.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTmeFrm.CustomFormat = "HH:mm:ss tt"
        Me.dtTmeFrm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTmeFrm.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTmeFrm.Location = New System.Drawing.Point(249, 451)
        Me.dtTmeFrm.Name = "dtTmeFrm"
        Me.dtTmeFrm.ShowUpDown = True
        Me.dtTmeFrm.Size = New System.Drawing.Size(118, 24)
        Me.dtTmeFrm.TabIndex = 109
        Me.dtTmeFrm.Value = New Date(2012, 4, 13, 0, 0, 0, 0)
        '
        'EmpPic
        '
        Me.EmpPic.BackColor = System.Drawing.Color.SteelBlue
        Me.EmpPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmpPic.Image = CType(resources.GetObject("EmpPic.Image"), System.Drawing.Image)
        Me.EmpPic.Location = New System.Drawing.Point(68, 14)
        Me.EmpPic.Name = "EmpPic"
        Me.EmpPic.Size = New System.Drawing.Size(253, 213)
        Me.EmpPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EmpPic.TabIndex = 78
        Me.EmpPic.TabStop = False
        '
        'frmLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(1125, 674)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Logs"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.EmpPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdDel As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents LstEmpRec As System.Windows.Forms.ListView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtDateFrm As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtTmeTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtTmeFrm As System.Windows.Forms.DateTimePicker
    Friend WithEvents EmpPic As System.Windows.Forms.PictureBox
    Friend WithEvents cboDeptCateg As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboSec As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtKeyword As System.Windows.Forms.TextBox
End Class
