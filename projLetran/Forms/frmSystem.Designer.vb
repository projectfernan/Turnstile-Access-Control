<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSystem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSystem))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdSetSchool = New System.Windows.Forms.Button()
        Me.cmdTerminate = New System.Windows.Forms.Button()
        Me.cmdReport = New System.Windows.Forms.Button()
        Me.cmdStudent = New System.Windows.Forms.Button()
        Me.cmdAcc = New System.Windows.Forms.Button()
        Me.cmdSettings = New System.Windows.Forms.Button()
        Me.cmdNotice = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.cmdNotice)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.cmdSetSchool)
        Me.Panel1.Controls.Add(Me.cmdTerminate)
        Me.Panel1.Controls.Add(Me.cmdReport)
        Me.Panel1.Controls.Add(Me.cmdStudent)
        Me.Panel1.Controls.Add(Me.cmdAcc)
        Me.Panel1.Controls.Add(Me.cmdSettings)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(279, 474)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(6, 355)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(267, 55)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "About                  "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmdSetSchool
        '
        Me.cmdSetSchool.BackColor = System.Drawing.Color.White
        Me.cmdSetSchool.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSetSchool.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetSchool.Image = CType(resources.GetObject("cmdSetSchool.Image"), System.Drawing.Image)
        Me.cmdSetSchool.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSetSchool.Location = New System.Drawing.Point(6, 123)
        Me.cmdSetSchool.Name = "cmdSetSchool"
        Me.cmdSetSchool.Size = New System.Drawing.Size(267, 55)
        Me.cmdSetSchool.TabIndex = 2
        Me.cmdSetSchool.Text = "      Set School               "
        Me.cmdSetSchool.UseVisualStyleBackColor = False
        '
        'cmdTerminate
        '
        Me.cmdTerminate.BackColor = System.Drawing.Color.White
        Me.cmdTerminate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdTerminate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTerminate.Image = CType(resources.GetObject("cmdTerminate.Image"), System.Drawing.Image)
        Me.cmdTerminate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdTerminate.Location = New System.Drawing.Point(6, 413)
        Me.cmdTerminate.Name = "cmdTerminate"
        Me.cmdTerminate.Size = New System.Drawing.Size(267, 55)
        Me.cmdTerminate.TabIndex = 7
        Me.cmdTerminate.Text = "      Terminate System    "
        Me.cmdTerminate.UseVisualStyleBackColor = False
        '
        'cmdReport
        '
        Me.cmdReport.BackColor = System.Drawing.Color.White
        Me.cmdReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReport.Image = CType(resources.GetObject("cmdReport.Image"), System.Drawing.Image)
        Me.cmdReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdReport.Location = New System.Drawing.Point(6, 297)
        Me.cmdReport.Name = "cmdReport"
        Me.cmdReport.Size = New System.Drawing.Size(267, 55)
        Me.cmdReport.TabIndex = 6
        Me.cmdReport.Text = "      Logs Report              "
        Me.cmdReport.UseVisualStyleBackColor = False
        '
        'cmdStudent
        '
        Me.cmdStudent.BackColor = System.Drawing.Color.White
        Me.cmdStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStudent.Image = CType(resources.GetObject("cmdStudent.Image"), System.Drawing.Image)
        Me.cmdStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdStudent.Location = New System.Drawing.Point(6, 181)
        Me.cmdStudent.Name = "cmdStudent"
        Me.cmdStudent.Size = New System.Drawing.Size(267, 55)
        Me.cmdStudent.TabIndex = 3
        Me.cmdStudent.Text = "      Student Records      "
        Me.cmdStudent.UseVisualStyleBackColor = False
        '
        'cmdAcc
        '
        Me.cmdAcc.BackColor = System.Drawing.Color.White
        Me.cmdAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAcc.Image = CType(resources.GetObject("cmdAcc.Image"), System.Drawing.Image)
        Me.cmdAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAcc.Location = New System.Drawing.Point(6, 65)
        Me.cmdAcc.Name = "cmdAcc"
        Me.cmdAcc.Size = New System.Drawing.Size(267, 55)
        Me.cmdAcc.TabIndex = 1
        Me.cmdAcc.Text = "        System Accounts       "
        Me.cmdAcc.UseVisualStyleBackColor = False
        '
        'cmdSettings
        '
        Me.cmdSettings.BackColor = System.Drawing.Color.White
        Me.cmdSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSettings.Image = CType(resources.GetObject("cmdSettings.Image"), System.Drawing.Image)
        Me.cmdSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSettings.Location = New System.Drawing.Point(6, 7)
        Me.cmdSettings.Name = "cmdSettings"
        Me.cmdSettings.Size = New System.Drawing.Size(267, 55)
        Me.cmdSettings.TabIndex = 0
        Me.cmdSettings.Text = "     System Settings      "
        Me.cmdSettings.UseVisualStyleBackColor = False
        '
        'cmdNotice
        '
        Me.cmdNotice.BackColor = System.Drawing.Color.White
        Me.cmdNotice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdNotice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNotice.Image = CType(resources.GetObject("cmdNotice.Image"), System.Drawing.Image)
        Me.cmdNotice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNotice.Location = New System.Drawing.Point(6, 239)
        Me.cmdNotice.Name = "cmdNotice"
        Me.cmdNotice.Size = New System.Drawing.Size(267, 55)
        Me.cmdNotice.TabIndex = 9
        Me.cmdNotice.Text = " Notice                  "
        Me.cmdNotice.UseVisualStyleBackColor = False
        '
        'frmSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(291, 486)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSystem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " System"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdSettings As System.Windows.Forms.Button
    Friend WithEvents cmdAcc As System.Windows.Forms.Button
    Friend WithEvents cmdStudent As System.Windows.Forms.Button
    Friend WithEvents cmdTerminate As System.Windows.Forms.Button
    Friend WithEvents cmdReport As System.Windows.Forms.Button
    Friend WithEvents cmdSetSchool As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdNotice As System.Windows.Forms.Button
End Class
