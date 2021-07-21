<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpload
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpload))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdUpload = New System.Windows.Forms.Button
        Me.txtLoadStat = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Progbar = New System.Windows.Forms.ProgressBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdClose = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.cmdUpload)
        Me.Panel1.Controls.Add(Me.txtLoadStat)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Progbar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmdClose)
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(335, 185)
        Me.Panel1.TabIndex = 1
        '
        'cmdUpload
        '
        Me.cmdUpload.BackColor = System.Drawing.Color.White
        Me.cmdUpload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpload.ForeColor = System.Drawing.Color.Black
        Me.cmdUpload.Image = CType(resources.GetObject("cmdUpload.Image"), System.Drawing.Image)
        Me.cmdUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdUpload.Location = New System.Drawing.Point(222, 143)
        Me.cmdUpload.Name = "cmdUpload"
        Me.cmdUpload.Size = New System.Drawing.Size(105, 33)
        Me.cmdUpload.TabIndex = 17
        Me.cmdUpload.Text = "    &Upload"
        Me.cmdUpload.UseVisualStyleBackColor = False
        '
        'txtLoadStat
        '
        Me.txtLoadStat.AutoSize = True
        Me.txtLoadStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoadStat.ForeColor = System.Drawing.Color.Yellow
        Me.txtLoadStat.Location = New System.Drawing.Point(128, 72)
        Me.txtLoadStat.Name = "txtLoadStat"
        Me.txtLoadStat.Size = New System.Drawing.Size(51, 18)
        Me.txtLoadStat.TabIndex = 14
        Me.txtLoadStat.Text = "0  /  0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 18)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Upload Status :"
        '
        'Progbar
        '
        Me.Progbar.BackColor = System.Drawing.Color.Gray
        Me.Progbar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Progbar.ForeColor = System.Drawing.Color.Lime
        Me.Progbar.Location = New System.Drawing.Point(8, 103)
        Me.Progbar.Name = "Progbar"
        Me.Progbar.Size = New System.Drawing.Size(319, 33)
        Me.Progbar.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(256, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 18)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(11, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(248, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Total record to be downloaded :"
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.White
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.Black
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.Location = New System.Drawing.Point(222, 143)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(105, 33)
        Me.cmdClose.TabIndex = 18
        Me.cmdClose.Text = "    &Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'frmUpload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 197)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpload"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Upload Cards"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdUpload As System.Windows.Forms.Button
    Friend WithEvents txtLoadStat As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Progbar As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
End Class
