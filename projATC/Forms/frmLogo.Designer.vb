﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogo))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.OpenPath = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.PicLogo)
        Me.Panel1.Controls.Add(Me.cmdBrowse)
        Me.Panel1.Controls.Add(Me.cmdUpdate)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(545, 175)
        Me.Panel1.TabIndex = 10
        '
        'PicLogo
        '
        Me.PicLogo.BackColor = System.Drawing.Color.Blue
        Me.PicLogo.Location = New System.Drawing.Point(14, 14)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.Size = New System.Drawing.Size(518, 96)
        Me.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLogo.TabIndex = 118
        Me.PicLogo.TabStop = False
        '
        'cmdBrowse
        '
        Me.cmdBrowse.BackColor = System.Drawing.Color.White
        Me.cmdBrowse.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBrowse.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBrowse.Image = CType(resources.GetObject("cmdBrowse.Image"), System.Drawing.Image)
        Me.cmdBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBrowse.Location = New System.Drawing.Point(219, 125)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(112, 34)
        Me.cmdBrowse.TabIndex = 116
        Me.cmdBrowse.Text = "&Browse  "
        Me.cmdBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdBrowse.UseVisualStyleBackColor = False
        '
        'cmdUpdate
        '
        Me.cmdUpdate.BackColor = System.Drawing.Color.White
        Me.cmdUpdate.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdUpdate.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Image = CType(resources.GetObject("cmdUpdate.Image"), System.Drawing.Image)
        Me.cmdUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdUpdate.Location = New System.Drawing.Point(219, 125)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(112, 34)
        Me.cmdUpdate.TabIndex = 117
        Me.cmdUpdate.Text = "&Save    "
        Me.cmdUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdUpdate.UseVisualStyleBackColor = False
        Me.cmdUpdate.Visible = False
        '
        'OpenPath
        '
        Me.OpenPath.FileName = "OpenFileDialog1"
        '
        'frmLogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(558, 189)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Logo Settings"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PicLogo As System.Windows.Forms.PictureBox
    Friend WithEvents cmdBrowse As System.Windows.Forms.Button
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents OpenPath As System.Windows.Forms.OpenFileDialog
End Class
