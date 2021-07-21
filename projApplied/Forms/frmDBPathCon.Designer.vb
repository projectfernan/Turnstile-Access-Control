<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDBPathCon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDBPathCon))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdTest = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpath = New System.Windows.Forms.TextBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.cmdSubmit = New System.Windows.Forms.Button()
        Me.OpenPath = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.cmdTest)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtpath)
        Me.Panel1.Controls.Add(Me.cmdBrowse)
        Me.Panel1.Controls.Add(Me.cmdSubmit)
        Me.Panel1.Location = New System.Drawing.Point(7, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(406, 153)
        Me.Panel1.TabIndex = 0
        '
        'cmdTest
        '
        Me.cmdTest.BackColor = System.Drawing.Color.White
        Me.cmdTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdTest.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTest.Image = CType(resources.GetObject("cmdTest.Image"), System.Drawing.Image)
        Me.cmdTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdTest.Location = New System.Drawing.Point(325, 34)
        Me.cmdTest.Name = "cmdTest"
        Me.cmdTest.Size = New System.Drawing.Size(34, 34)
        Me.cmdTest.TabIndex = 113
        Me.cmdTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdTest.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Path :"
        '
        'txtpath
        '
        Me.txtpath.BackColor = System.Drawing.Color.White
        Me.txtpath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpath.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpath.Location = New System.Drawing.Point(99, 40)
        Me.txtpath.Name = "txtpath"
        Me.txtpath.ReadOnly = True
        Me.txtpath.Size = New System.Drawing.Size(220, 23)
        Me.txtpath.TabIndex = 109
        '
        'cmdBrowse
        '
        Me.cmdBrowse.BackColor = System.Drawing.Color.White
        Me.cmdBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBrowse.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBrowse.Image = CType(resources.GetObject("cmdBrowse.Image"), System.Drawing.Image)
        Me.cmdBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBrowse.Location = New System.Drawing.Point(149, 81)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(111, 34)
        Me.cmdBrowse.TabIndex = 111
        Me.cmdBrowse.Text = "&Browse "
        Me.cmdBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdBrowse.UseVisualStyleBackColor = False
        '
        'cmdSubmit
        '
        Me.cmdSubmit.BackColor = System.Drawing.Color.White
        Me.cmdSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSubmit.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSubmit.Image = CType(resources.GetObject("cmdSubmit.Image"), System.Drawing.Image)
        Me.cmdSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSubmit.Location = New System.Drawing.Point(149, 81)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(111, 34)
        Me.cmdSubmit.TabIndex = 112
        Me.cmdSubmit.Text = "&Save     "
        Me.cmdSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSubmit.UseVisualStyleBackColor = False
        Me.cmdSubmit.Visible = False
        '
        'OpenPath
        '
        Me.OpenPath.FileName = "OpenFileDialog1"
        '
        'frmDBPathCon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(420, 168)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDBPathCon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ms Access Connection"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdTest As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtpath As System.Windows.Forms.TextBox
    Friend WithEvents cmdBrowse As System.Windows.Forms.Button
    Friend WithEvents cmdSubmit As System.Windows.Forms.Button
    Friend WithEvents OpenPath As System.Windows.Forms.OpenFileDialog
End Class
