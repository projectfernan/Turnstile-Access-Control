﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectDb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelectDb))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdReader = New System.Windows.Forms.Button()
        Me.cmdConn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cmdReader)
        Me.Panel1.Controls.Add(Me.cmdConn)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(268, 129)
        Me.Panel1.TabIndex = 1
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
        Me.cmdReader.Size = New System.Drawing.Size(256, 55)
        Me.cmdReader.TabIndex = 3
        Me.cmdReader.Text = "        MS Access Settings"
        Me.cmdReader.UseVisualStyleBackColor = False
        '
        'cmdConn
        '
        Me.cmdConn.BackColor = System.Drawing.Color.White
        Me.cmdConn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdConn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConn.Image = CType(resources.GetObject("cmdConn.Image"), System.Drawing.Image)
        Me.cmdConn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdConn.Location = New System.Drawing.Point(6, 7)
        Me.cmdConn.Name = "cmdConn"
        Me.cmdConn.Size = New System.Drawing.Size(256, 55)
        Me.cmdConn.TabIndex = 2
        Me.cmdConn.Text = "  MySQL Settings"
        Me.cmdConn.UseVisualStyleBackColor = False
        '
        'frmSelectDb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(279, 141)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelectDb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Database Settings"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdConn As System.Windows.Forms.Button
    Friend WithEvents cmdReader As System.Windows.Forms.Button
End Class