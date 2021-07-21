<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogsCateg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogsCateg))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdStudentLogs = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cmdStudentLogs)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 70)
        Me.Panel1.TabIndex = 1
        '
        'cmdStudentLogs
        '
        Me.cmdStudentLogs.BackColor = System.Drawing.Color.White
        Me.cmdStudentLogs.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdStudentLogs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStudentLogs.Image = CType(resources.GetObject("cmdStudentLogs.Image"), System.Drawing.Image)
        Me.cmdStudentLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdStudentLogs.Location = New System.Drawing.Point(7, 7)
        Me.cmdStudentLogs.Name = "cmdStudentLogs"
        Me.cmdStudentLogs.Size = New System.Drawing.Size(254, 55)
        Me.cmdStudentLogs.TabIndex = 6
        Me.cmdStudentLogs.Text = "Student Logs     "
        Me.cmdStudentLogs.UseVisualStyleBackColor = False
        '
        'frmLogsCateg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(279, 83)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogsCateg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Logs Report"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdStudentLogs As System.Windows.Forms.Button
End Class
