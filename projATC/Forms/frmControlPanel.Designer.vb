<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControlPanel))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdAbout = New System.Windows.Forms.Button()
        Me.cmdTerminate = New System.Windows.Forms.Button()
        Me.cmdReport = New System.Windows.Forms.Button()
        Me.cmdEmp = New System.Windows.Forms.Button()
        Me.cmdAcc = New System.Windows.Forms.Button()
        Me.cmdSettings = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.cmdAbout)
        Me.Panel1.Controls.Add(Me.cmdTerminate)
        Me.Panel1.Controls.Add(Me.cmdReport)
        Me.Panel1.Controls.Add(Me.cmdEmp)
        Me.Panel1.Controls.Add(Me.cmdAcc)
        Me.Panel1.Controls.Add(Me.cmdSettings)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(279, 375)
        Me.Panel1.TabIndex = 2
        '
        'cmdAbout
        '
        Me.cmdAbout.BackColor = System.Drawing.Color.White
        Me.cmdAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAbout.Image = CType(resources.GetObject("cmdAbout.Image"), System.Drawing.Image)
        Me.cmdAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAbout.Location = New System.Drawing.Point(6, 251)
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Size = New System.Drawing.Size(267, 55)
        Me.cmdAbout.TabIndex = 8
        Me.cmdAbout.Text = "About                  "
        Me.cmdAbout.UseVisualStyleBackColor = False
        '
        'cmdTerminate
        '
        Me.cmdTerminate.BackColor = System.Drawing.Color.White
        Me.cmdTerminate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdTerminate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTerminate.Image = CType(resources.GetObject("cmdTerminate.Image"), System.Drawing.Image)
        Me.cmdTerminate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdTerminate.Location = New System.Drawing.Point(6, 312)
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
        Me.cmdReport.Location = New System.Drawing.Point(6, 190)
        Me.cmdReport.Name = "cmdReport"
        Me.cmdReport.Size = New System.Drawing.Size(267, 55)
        Me.cmdReport.TabIndex = 6
        Me.cmdReport.Text = "       Logs Report              "
        Me.cmdReport.UseVisualStyleBackColor = False
        '
        'cmdEmp
        '
        Me.cmdEmp.BackColor = System.Drawing.Color.White
        Me.cmdEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEmp.Image = CType(resources.GetObject("cmdEmp.Image"), System.Drawing.Image)
        Me.cmdEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEmp.Location = New System.Drawing.Point(6, 129)
        Me.cmdEmp.Name = "cmdEmp"
        Me.cmdEmp.Size = New System.Drawing.Size(267, 55)
        Me.cmdEmp.TabIndex = 3
        Me.cmdEmp.Text = "      Employee Records   "
        Me.cmdEmp.UseVisualStyleBackColor = False
        '
        'cmdAcc
        '
        Me.cmdAcc.BackColor = System.Drawing.Color.White
        Me.cmdAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAcc.Image = CType(resources.GetObject("cmdAcc.Image"), System.Drawing.Image)
        Me.cmdAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAcc.Location = New System.Drawing.Point(6, 68)
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
        'frmControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(291, 388)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmControlPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Control Panel"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdAbout As System.Windows.Forms.Button
    Friend WithEvents cmdTerminate As System.Windows.Forms.Button
    Friend WithEvents cmdReport As System.Windows.Forms.Button
    Friend WithEvents cmdEmp As System.Windows.Forms.Button
    Friend WithEvents cmdAcc As System.Windows.Forms.Button
    Friend WithEvents cmdSettings As System.Windows.Forms.Button
End Class
