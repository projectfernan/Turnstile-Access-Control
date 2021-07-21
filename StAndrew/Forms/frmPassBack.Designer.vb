<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPassBack
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPassBack))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OffAntiPsb = New System.Windows.Forms.RadioButton()
        Me.OnAntiPsb = New System.Windows.Forms.RadioButton()
        Me.cmdSubmit = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.OffAntiPsb)
        Me.Panel1.Controls.Add(Me.OnAntiPsb)
        Me.Panel1.Controls.Add(Me.cmdSubmit)
        Me.Panel1.Location = New System.Drawing.Point(5, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(252, 168)
        Me.Panel1.TabIndex = 0
        '
        'OffAntiPsb
        '
        Me.OffAntiPsb.AutoSize = True
        Me.OffAntiPsb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OffAntiPsb.Location = New System.Drawing.Point(33, 69)
        Me.OffAntiPsb.Name = "OffAntiPsb"
        Me.OffAntiPsb.Size = New System.Drawing.Size(183, 20)
        Me.OffAntiPsb.TabIndex = 112
        Me.OffAntiPsb.TabStop = True
        Me.OffAntiPsb.Text = "Disable Anti Passback"
        Me.OffAntiPsb.UseVisualStyleBackColor = True
        '
        'OnAntiPsb
        '
        Me.OnAntiPsb.AutoSize = True
        Me.OnAntiPsb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OnAntiPsb.Location = New System.Drawing.Point(33, 29)
        Me.OnAntiPsb.Name = "OnAntiPsb"
        Me.OnAntiPsb.Size = New System.Drawing.Size(178, 20)
        Me.OnAntiPsb.TabIndex = 111
        Me.OnAntiPsb.TabStop = True
        Me.OnAntiPsb.Text = "Enable Anti Passback"
        Me.OnAntiPsb.UseVisualStyleBackColor = True
        '
        'cmdSubmit
        '
        Me.cmdSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdSubmit.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSubmit.Image = CType(resources.GetObject("cmdSubmit.Image"), System.Drawing.Image)
        Me.cmdSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSubmit.Location = New System.Drawing.Point(71, 110)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(111, 34)
        Me.cmdSubmit.TabIndex = 110
        Me.cmdSubmit.Text = "&Save     "
        Me.cmdSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSubmit.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(5, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(167, 16)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Anti Passback Settings"
        '
        'frmPassBack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(262, 198)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPassBack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents OffAntiPsb As System.Windows.Forms.RadioButton
    Friend WithEvents OnAntiPsb As System.Windows.Forms.RadioButton
    Friend WithEvents cmdSubmit As System.Windows.Forms.Button
End Class
