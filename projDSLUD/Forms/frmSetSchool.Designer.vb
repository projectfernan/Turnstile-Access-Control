<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetSchool
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetSchool))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdSec = New System.Windows.Forms.Button()
        Me.cmdGy = New System.Windows.Forms.Button()
        Me.cmdEduLv = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cmdSec)
        Me.Panel1.Controls.Add(Me.cmdGy)
        Me.Panel1.Controls.Add(Me.cmdEduLv)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(260, 192)
        Me.Panel1.TabIndex = 1
        '
        'cmdSec
        '
        Me.cmdSec.BackColor = System.Drawing.Color.White
        Me.cmdSec.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSec.Image = CType(resources.GetObject("cmdSec.Image"), System.Drawing.Image)
        Me.cmdSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSec.Location = New System.Drawing.Point(6, 129)
        Me.cmdSec.Name = "cmdSec"
        Me.cmdSec.Size = New System.Drawing.Size(247, 55)
        Me.cmdSec.TabIndex = 2
        Me.cmdSec.Text = "        Set Sections            "
        Me.cmdSec.UseVisualStyleBackColor = False
        '
        'cmdGy
        '
        Me.cmdGy.BackColor = System.Drawing.Color.White
        Me.cmdGy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdGy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGy.Image = CType(resources.GetObject("cmdGy.Image"), System.Drawing.Image)
        Me.cmdGy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGy.Location = New System.Drawing.Point(6, 68)
        Me.cmdGy.Name = "cmdGy"
        Me.cmdGy.Size = New System.Drawing.Size(247, 55)
        Me.cmdGy.TabIndex = 1
        Me.cmdGy.Text = "        Set Grade/Year       "
        Me.cmdGy.UseVisualStyleBackColor = False
        '
        'cmdEduLv
        '
        Me.cmdEduLv.BackColor = System.Drawing.Color.White
        Me.cmdEduLv.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEduLv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEduLv.Image = CType(resources.GetObject("cmdEduLv.Image"), System.Drawing.Image)
        Me.cmdEduLv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEduLv.Location = New System.Drawing.Point(6, 7)
        Me.cmdEduLv.Name = "cmdEduLv"
        Me.cmdEduLv.Size = New System.Drawing.Size(247, 55)
        Me.cmdEduLv.TabIndex = 0
        Me.cmdEduLv.Text = "       Set Education Level"
        Me.cmdEduLv.UseVisualStyleBackColor = False
        '
        'frmSetSchool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(272, 205)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetSchool"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set School"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdSec As System.Windows.Forms.Button
    Friend WithEvents cmdGy As System.Windows.Forms.Button
    Friend WithEvents cmdEduLv As System.Windows.Forms.Button
End Class
