<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotice))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAC = New System.Windows.Forms.TextBox()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdDel = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIDno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNotice = New System.Windows.Forms.TextBox()
        Me.LstDept = New System.Windows.Forms.ListView()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtAC)
        Me.Panel1.Controls.Add(Me.cmdEdit)
        Me.Panel1.Controls.Add(Me.cmdCancel)
        Me.Panel1.Controls.Add(Me.cmdDel)
        Me.Panel1.Controls.Add(Me.cmdAdd)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtIDno)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtNotice)
        Me.Panel1.Controls.Add(Me.LstDept)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(873, 330)
        Me.Panel1.TabIndex = 3455
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(39, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 130
        Me.Label3.Text = "AC Number"
        '
        'txtAC
        '
        Me.txtAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAC.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAC.Location = New System.Drawing.Point(126, 27)
        Me.txtAC.MaxLength = 30
        Me.txtAC.Name = "txtAC"
        Me.txtAC.ReadOnly = True
        Me.txtAC.Size = New System.Drawing.Size(229, 23)
        Me.txtAC.TabIndex = 10
        '
        'cmdEdit
        '
        Me.cmdEdit.BackColor = System.Drawing.Color.White
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEdit.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEdit.Location = New System.Drawing.Point(243, 204)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(111, 34)
        Me.cmdEdit.TabIndex = 5
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdEdit.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.White
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCancel.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
        Me.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancel.Location = New System.Drawing.Point(243, 244)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(111, 34)
        Me.cmdCancel.TabIndex = 7
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdDel
        '
        Me.cmdDel.BackColor = System.Drawing.Color.White
        Me.cmdDel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDel.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDel.Image = CType(resources.GetObject("cmdDel.Image"), System.Drawing.Image)
        Me.cmdDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDel.Location = New System.Drawing.Point(126, 244)
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.Size = New System.Drawing.Size(111, 34)
        Me.cmdDel.TabIndex = 6
        Me.cmdDel.Text = "&Delete"
        Me.cmdDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdDel.UseVisualStyleBackColor = False
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.Color.White
        Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAdd.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
        Me.cmdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAdd.Location = New System.Drawing.Point(126, 204)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(111, 34)
        Me.cmdAdd.TabIndex = 4
        Me.cmdAdd.Text = "&Add"
        Me.cmdAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAdd.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(14, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 16)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "Student Name"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(126, 112)
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(229, 23)
        Me.txtName.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(39, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 16)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "ID Number"
        '
        'txtIDno
        '
        Me.txtIDno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIDno.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDno.Location = New System.Drawing.Point(126, 69)
        Me.txtIDno.MaxLength = 30
        Me.txtIDno.Name = "txtIDno"
        Me.txtIDno.ReadOnly = True
        Me.txtIDno.Size = New System.Drawing.Size(229, 23)
        Me.txtIDno.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(66, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Notice"
        '
        'txtNotice
        '
        Me.txtNotice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNotice.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotice.Location = New System.Drawing.Point(126, 155)
        Me.txtNotice.MaxLength = 30
        Me.txtNotice.Name = "txtNotice"
        Me.txtNotice.Size = New System.Drawing.Size(229, 23)
        Me.txtNotice.TabIndex = 0
        '
        'LstDept
        '
        Me.LstDept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstDept.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstDept.FullRowSelect = True
        Me.LstDept.GridLines = True
        Me.LstDept.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LstDept.Location = New System.Drawing.Point(376, 26)
        Me.LstDept.MultiSelect = False
        Me.LstDept.Name = "LstDept"
        Me.LstDept.Size = New System.Drawing.Size(476, 281)
        Me.LstDept.TabIndex = 120
        Me.LstDept.UseCompatibleStateImageBehavior = False
        Me.LstDept.View = System.Windows.Forms.View.Details
        '
        'frmNotice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(885, 343)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNotice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Student Notice"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdDel As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIDno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNotice As System.Windows.Forms.TextBox
    Friend WithEvents LstDept As System.Windows.Forms.ListView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAC As System.Windows.Forms.TextBox
End Class
