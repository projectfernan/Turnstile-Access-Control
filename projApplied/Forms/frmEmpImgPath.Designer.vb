<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpImgPath
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpImgPath))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdFP = New System.Windows.Forms.Button()
        Me.txtpath = New System.Windows.Forms.TextBox()
        Me.FBD = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(11, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 18)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Designate Path :"
        '
        'cmdFP
        '
        Me.cmdFP.BackColor = System.Drawing.Color.White
        Me.cmdFP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdFP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFP.ForeColor = System.Drawing.Color.Black
        Me.cmdFP.Image = CType(resources.GetObject("cmdFP.Image"), System.Drawing.Image)
        Me.cmdFP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFP.Location = New System.Drawing.Point(360, 6)
        Me.cmdFP.Name = "cmdFP"
        Me.cmdFP.Size = New System.Drawing.Size(33, 34)
        Me.cmdFP.TabIndex = 44
        Me.cmdFP.UseVisualStyleBackColor = False
        '
        'txtpath
        '
        Me.txtpath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpath.Location = New System.Drawing.Point(145, 13)
        Me.txtpath.MaxLength = 150
        Me.txtpath.Name = "txtpath"
        Me.txtpath.Size = New System.Drawing.Size(206, 22)
        Me.txtpath.TabIndex = 43
        '
        'frmEmpImgPath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(400, 46)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdFP)
        Me.Controls.Add(Me.txtpath)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmpImgPath"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Employee Image Designate Path"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdFP As System.Windows.Forms.Button
    Friend WithEvents txtpath As System.Windows.Forms.TextBox
    Friend WithEvents FBD As System.Windows.Forms.FolderBrowserDialog
End Class
