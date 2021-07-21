<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdAntiPsb = New System.Windows.Forms.Button()
        Me.cmdDesignatePath = New System.Windows.Forms.Button()
        Me.cmdAudit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdReader = New System.Windows.Forms.Button()
        Me.cmdConn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.cmdAntiPsb)
        Me.Panel1.Controls.Add(Me.cmdDesignatePath)
        Me.Panel1.Controls.Add(Me.cmdAudit)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.cmdReader)
        Me.Panel1.Controls.Add(Me.cmdConn)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(277, 313)
        Me.Panel1.TabIndex = 3
        '
        'cmdAntiPsb
        '
        Me.cmdAntiPsb.BackColor = System.Drawing.Color.White
        Me.cmdAntiPsb.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAntiPsb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAntiPsb.Image = CType(resources.GetObject("cmdAntiPsb.Image"), System.Drawing.Image)
        Me.cmdAntiPsb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAntiPsb.Location = New System.Drawing.Point(6, 128)
        Me.cmdAntiPsb.Name = "cmdAntiPsb"
        Me.cmdAntiPsb.Size = New System.Drawing.Size(265, 55)
        Me.cmdAntiPsb.TabIndex = 9
        Me.cmdAntiPsb.Text = "          Anti Passback Settings"
        Me.cmdAntiPsb.UseVisualStyleBackColor = False
        '
        'cmdDesignatePath
        '
        Me.cmdDesignatePath.BackColor = System.Drawing.Color.White
        Me.cmdDesignatePath.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDesignatePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDesignatePath.Image = CType(resources.GetObject("cmdDesignatePath.Image"), System.Drawing.Image)
        Me.cmdDesignatePath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDesignatePath.Location = New System.Drawing.Point(6, 250)
        Me.cmdDesignatePath.Name = "cmdDesignatePath"
        Me.cmdDesignatePath.Size = New System.Drawing.Size(265, 55)
        Me.cmdDesignatePath.TabIndex = 8
        Me.cmdDesignatePath.Text = "          Image Designate Path"
        Me.cmdDesignatePath.UseVisualStyleBackColor = False
        '
        'cmdAudit
        '
        Me.cmdAudit.BackColor = System.Drawing.Color.White
        Me.cmdAudit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAudit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAudit.Image = CType(resources.GetObject("cmdAudit.Image"), System.Drawing.Image)
        Me.cmdAudit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAudit.Location = New System.Drawing.Point(6, 319)
        Me.cmdAudit.Name = "cmdAudit"
        Me.cmdAudit.Size = New System.Drawing.Size(265, 55)
        Me.cmdAudit.TabIndex = 7
        Me.cmdAudit.Text = "   System Audit Logs"
        Me.cmdAudit.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(6, 189)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(265, 55)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "         Logo Settings             "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmdReader
        '
        Me.cmdReader.BackColor = System.Drawing.Color.White
        Me.cmdReader.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdReader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReader.Image = CType(resources.GetObject("cmdReader.Image"), System.Drawing.Image)
        Me.cmdReader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdReader.Location = New System.Drawing.Point(6, 67)
        Me.cmdReader.Name = "cmdReader"
        Me.cmdReader.Size = New System.Drawing.Size(265, 55)
        Me.cmdReader.TabIndex = 3
        Me.cmdReader.Text = "         Controller Settings       "
        Me.cmdReader.UseVisualStyleBackColor = False
        '
        'cmdConn
        '
        Me.cmdConn.BackColor = System.Drawing.Color.White
        Me.cmdConn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdConn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConn.Image = CType(resources.GetObject("cmdConn.Image"), System.Drawing.Image)
        Me.cmdConn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdConn.Location = New System.Drawing.Point(6, 6)
        Me.cmdConn.Name = "cmdConn"
        Me.cmdConn.Size = New System.Drawing.Size(265, 55)
        Me.cmdConn.TabIndex = 2
        Me.cmdConn.Text = "        MySQL Db Settings    "
        Me.cmdConn.UseVisualStyleBackColor = False
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(289, 325)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Settings"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdAudit As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdReader As System.Windows.Forms.Button
    Friend WithEvents cmdConn As System.Windows.Forms.Button
    Friend WithEvents cmdDesignatePath As System.Windows.Forms.Button
    Friend WithEvents cmdAntiPsb As System.Windows.Forms.Button
End Class
