<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEduLevel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEduLevel))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtEduLv = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdDel = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.lstList = New System.Windows.Forms.ListView()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.txtEduLv)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmdDel)
        Me.Panel1.Controls.Add(Me.cmdAdd)
        Me.Panel1.Controls.Add(Me.lstList)
        Me.Panel1.Location = New System.Drawing.Point(6, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(302, 300)
        Me.Panel1.TabIndex = 2
        '
        'txtEduLv
        '
        Me.txtEduLv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEduLv.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEduLv.Location = New System.Drawing.Point(133, 21)
        Me.txtEduLv.MaxLength = 30
        Me.txtEduLv.Name = "txtEduLv"
        Me.txtEduLv.Size = New System.Drawing.Size(158, 23)
        Me.txtEduLv.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 16)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Education Level"
        '
        'cmdDel
        '
        Me.cmdDel.BackColor = System.Drawing.Color.White
        Me.cmdDel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDel.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDel.Image = CType(resources.GetObject("cmdDel.Image"), System.Drawing.Image)
        Me.cmdDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDel.Location = New System.Drawing.Point(155, 55)
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.Size = New System.Drawing.Size(111, 34)
        Me.cmdDel.TabIndex = 2
        Me.cmdDel.Text = "&Delete  "
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
        Me.cmdAdd.Location = New System.Drawing.Point(38, 55)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(111, 34)
        Me.cmdAdd.TabIndex = 1
        Me.cmdAdd.Text = "&Add    "
        Me.cmdAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAdd.UseVisualStyleBackColor = False
        '
        'lstList
        '
        Me.lstList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstList.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstList.FullRowSelect = True
        Me.lstList.GridLines = True
        Me.lstList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstList.Location = New System.Drawing.Point(13, 100)
        Me.lstList.MultiSelect = False
        Me.lstList.Name = "lstList"
        Me.lstList.Size = New System.Drawing.Size(276, 186)
        Me.lstList.TabIndex = 78
        Me.lstList.UseCompatibleStateImageBehavior = False
        Me.lstList.View = System.Windows.Forms.View.Details
        '
        'frmEduLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(314, 314)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEduLevel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Education Level"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtEduLv As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdDel As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents lstList As System.Windows.Forms.ListView
End Class
