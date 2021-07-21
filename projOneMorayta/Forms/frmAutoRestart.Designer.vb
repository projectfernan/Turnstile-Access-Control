<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutoRestart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAutoRestart))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtRestart3 = New System.Windows.Forms.DateTimePicker()
        Me.dtRestart2 = New System.Windows.Forms.DateTimePicker()
        Me.dtRestart1 = New System.Windows.Forms.DateTimePicker()
        Me.chkEnable3 = New System.Windows.Forms.CheckBox()
        Me.chkEnable2 = New System.Windows.Forms.CheckBox()
        Me.chkEnable1 = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.dtRestart3)
        Me.Panel1.Controls.Add(Me.dtRestart2)
        Me.Panel1.Controls.Add(Me.dtRestart1)
        Me.Panel1.Controls.Add(Me.chkEnable3)
        Me.Panel1.Controls.Add(Me.chkEnable2)
        Me.Panel1.Controls.Add(Me.chkEnable1)
        Me.Panel1.Location = New System.Drawing.Point(7, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(245, 141)
        Me.Panel1.TabIndex = 0
        '
        'dtRestart3
        '
        Me.dtRestart3.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtRestart3.CustomFormat = "HH:mm:ss tt"
        Me.dtRestart3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtRestart3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtRestart3.Location = New System.Drawing.Point(65, 96)
        Me.dtRestart3.Name = "dtRestart3"
        Me.dtRestart3.ShowUpDown = True
        Me.dtRestart3.Size = New System.Drawing.Size(129, 24)
        Me.dtRestart3.TabIndex = 86
        Me.dtRestart3.Value = New Date(2012, 4, 13, 10, 13, 0, 0)
        '
        'dtRestart2
        '
        Me.dtRestart2.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtRestart2.CustomFormat = "HH:mm:ss tt"
        Me.dtRestart2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtRestart2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtRestart2.Location = New System.Drawing.Point(65, 57)
        Me.dtRestart2.Name = "dtRestart2"
        Me.dtRestart2.ShowUpDown = True
        Me.dtRestart2.Size = New System.Drawing.Size(129, 24)
        Me.dtRestart2.TabIndex = 85
        Me.dtRestart2.Value = New Date(2012, 4, 13, 10, 13, 0, 0)
        '
        'dtRestart1
        '
        Me.dtRestart1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtRestart1.CustomFormat = "HH:mm:ss tt"
        Me.dtRestart1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtRestart1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtRestart1.Location = New System.Drawing.Point(65, 19)
        Me.dtRestart1.Name = "dtRestart1"
        Me.dtRestart1.ShowUpDown = True
        Me.dtRestart1.Size = New System.Drawing.Size(129, 24)
        Me.dtRestart1.TabIndex = 84
        Me.dtRestart1.Value = New Date(2012, 4, 13, 10, 13, 0, 0)
        '
        'chkEnable3
        '
        Me.chkEnable3.AutoSize = True
        Me.chkEnable3.Location = New System.Drawing.Point(34, 102)
        Me.chkEnable3.Name = "chkEnable3"
        Me.chkEnable3.Size = New System.Drawing.Size(15, 14)
        Me.chkEnable3.TabIndex = 2
        Me.chkEnable3.UseVisualStyleBackColor = True
        '
        'chkEnable2
        '
        Me.chkEnable2.AutoSize = True
        Me.chkEnable2.Location = New System.Drawing.Point(34, 62)
        Me.chkEnable2.Name = "chkEnable2"
        Me.chkEnable2.Size = New System.Drawing.Size(15, 14)
        Me.chkEnable2.TabIndex = 1
        Me.chkEnable2.UseVisualStyleBackColor = True
        '
        'chkEnable1
        '
        Me.chkEnable1.AutoSize = True
        Me.chkEnable1.Location = New System.Drawing.Point(34, 25)
        Me.chkEnable1.Name = "chkEnable1"
        Me.chkEnable1.Size = New System.Drawing.Size(15, 14)
        Me.chkEnable1.TabIndex = 0
        Me.chkEnable1.UseVisualStyleBackColor = True
        '
        'frmAutoRestart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(260, 156)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAutoRestart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " System Auto Restart Settings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkEnable3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkEnable2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkEnable1 As System.Windows.Forms.CheckBox
    Friend WithEvents dtRestart3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtRestart2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtRestart1 As System.Windows.Forms.DateTimePicker
End Class
