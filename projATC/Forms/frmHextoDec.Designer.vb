<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHextoDec
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHextoDec))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDecimal = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHexa = New System.Windows.Forms.TextBox()
        Me.cmdConvert = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.txtDecimal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.cmdConvert)
        Me.Panel1.Controls.Add(Me.txtHexa)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtDecimal)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(7, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(297, 145)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Decimal :"
        '
        'txtDecimal
        '
        Me.txtDecimal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDecimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDecimal.Location = New System.Drawing.Point(95, 23)
        Me.txtDecimal.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.txtDecimal.Name = "txtDecimal"
        Me.txtDecimal.Size = New System.Drawing.Size(186, 22)
        Me.txtDecimal.TabIndex = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Hexa :"
        '
        'txtHexa
        '
        Me.txtHexa.BackColor = System.Drawing.Color.White
        Me.txtHexa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHexa.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHexa.Location = New System.Drawing.Point(95, 63)
        Me.txtHexa.Name = "txtHexa"
        Me.txtHexa.ReadOnly = True
        Me.txtHexa.Size = New System.Drawing.Size(186, 23)
        Me.txtHexa.TabIndex = 102
        '
        'cmdConvert
        '
        Me.cmdConvert.BackColor = System.Drawing.Color.White
        Me.cmdConvert.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdConvert.Location = New System.Drawing.Point(202, 102)
        Me.cmdConvert.Name = "cmdConvert"
        Me.cmdConvert.Size = New System.Drawing.Size(79, 26)
        Me.cmdConvert.TabIndex = 103
        Me.cmdConvert.Text = "Convert"
        Me.cmdConvert.UseVisualStyleBackColor = False
        '
        'frmHextoDec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(311, 160)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHextoDec"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Decimal to Hexadecimal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtDecimal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDecimal As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdConvert As System.Windows.Forms.Button
    Friend WithEvents txtHexa As System.Windows.Forms.TextBox
End Class
