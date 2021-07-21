<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItems))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdItemRec = New System.Windows.Forms.Button()
        Me.cmdItemCateg = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cmdItemRec)
        Me.Panel1.Controls.Add(Me.cmdItemCateg)
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(268, 129)
        Me.Panel1.TabIndex = 1
        '
        'cmdItemRec
        '
        Me.cmdItemRec.BackColor = System.Drawing.Color.White
        Me.cmdItemRec.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdItemRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdItemRec.Image = CType(resources.GetObject("cmdItemRec.Image"), System.Drawing.Image)
        Me.cmdItemRec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdItemRec.Location = New System.Drawing.Point(6, 67)
        Me.cmdItemRec.Name = "cmdItemRec"
        Me.cmdItemRec.Size = New System.Drawing.Size(256, 55)
        Me.cmdItemRec.TabIndex = 1
        Me.cmdItemRec.Text = "Item Records    "
        Me.cmdItemRec.UseVisualStyleBackColor = False
        '
        'cmdItemCateg
        '
        Me.cmdItemCateg.BackColor = System.Drawing.Color.White
        Me.cmdItemCateg.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdItemCateg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdItemCateg.Image = CType(resources.GetObject("cmdItemCateg.Image"), System.Drawing.Image)
        Me.cmdItemCateg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdItemCateg.Location = New System.Drawing.Point(6, 6)
        Me.cmdItemCateg.Name = "cmdItemCateg"
        Me.cmdItemCateg.Size = New System.Drawing.Size(256, 55)
        Me.cmdItemCateg.TabIndex = 0
        Me.cmdItemCateg.Text = "Item Category   "
        Me.cmdItemCateg.UseVisualStyleBackColor = False
        '
        'frmItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(278, 140)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Student Items"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdItemRec As System.Windows.Forms.Button
    Friend WithEvents cmdItemCateg As System.Windows.Forms.Button
End Class
