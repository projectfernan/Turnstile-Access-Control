<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPsb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPsb))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OffAntiPsb = New System.Windows.Forms.RadioButton()
        Me.OnAntiPsb = New System.Windows.Forms.RadioButton()
        Me.cmdSubmit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.OffAntiPsb)
        Me.Panel1.Controls.Add(Me.OnAntiPsb)
        Me.Panel1.Controls.Add(Me.cmdSubmit)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(260, 166)
        Me.Panel1.TabIndex = 0
        '
        'OffAntiPsb
        '
        Me.OffAntiPsb.AutoSize = True
        Me.OffAntiPsb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OffAntiPsb.Location = New System.Drawing.Point(39, 63)
        Me.OffAntiPsb.Name = "OffAntiPsb"
        Me.OffAntiPsb.Size = New System.Drawing.Size(183, 20)
        Me.OffAntiPsb.TabIndex = 118
        Me.OffAntiPsb.TabStop = True
        Me.OffAntiPsb.Text = "Disable Anti Passback"
        Me.OffAntiPsb.UseVisualStyleBackColor = True
        '
        'OnAntiPsb
        '
        Me.OnAntiPsb.AutoSize = True
        Me.OnAntiPsb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OnAntiPsb.Location = New System.Drawing.Point(39, 33)
        Me.OnAntiPsb.Name = "OnAntiPsb"
        Me.OnAntiPsb.Size = New System.Drawing.Size(178, 20)
        Me.OnAntiPsb.TabIndex = 117
        Me.OnAntiPsb.TabStop = True
        Me.OnAntiPsb.Text = "Enable Anti Passback"
        Me.OnAntiPsb.UseVisualStyleBackColor = True
        '
        'cmdSubmit
        '
        Me.cmdSubmit.BackColor = System.Drawing.Color.White
        Me.cmdSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSubmit.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSubmit.Image = CType(resources.GetObject("cmdSubmit.Image"), System.Drawing.Image)
        Me.cmdSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSubmit.Location = New System.Drawing.Point(77, 99)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(111, 34)
        Me.cmdSubmit.TabIndex = 116
        Me.cmdSubmit.Text = "&Save     "
        Me.cmdSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSubmit.UseVisualStyleBackColor = False
        '
        'frmPsb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(272, 179)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPsb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anti Passback Settings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents OffAntiPsb As System.Windows.Forms.RadioButton
    Friend WithEvents OnAntiPsb As System.Windows.Forms.RadioButton
    Friend WithEvents cmdSubmit As System.Windows.Forms.Button
End Class
