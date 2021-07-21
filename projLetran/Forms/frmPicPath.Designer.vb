﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPicPath
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPicPath))
        Me.OpenPath = New System.Windows.Forms.OpenFileDialog()
        Me.SavePath = New System.Windows.Forms.SaveFileDialog()
        Me.FBD = New System.Windows.Forms.FolderBrowserDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpath = New System.Windows.Forms.TextBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.cmdSubmit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenPath
        '
        Me.OpenPath.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtpath)
        Me.Panel1.Controls.Add(Me.cmdBrowse)
        Me.Panel1.Controls.Add(Me.cmdSubmit)
        Me.Panel1.Location = New System.Drawing.Point(5, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(396, 123)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(23, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 16)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Designate Path :"
        '
        'txtpath
        '
        Me.txtpath.BackColor = System.Drawing.Color.White
        Me.txtpath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpath.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpath.Location = New System.Drawing.Point(146, 32)
        Me.txtpath.Name = "txtpath"
        Me.txtpath.ReadOnly = True
        Me.txtpath.Size = New System.Drawing.Size(220, 23)
        Me.txtpath.TabIndex = 110
        '
        'cmdBrowse
        '
        Me.cmdBrowse.BackColor = System.Drawing.Color.White
        Me.cmdBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBrowse.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBrowse.Image = CType(resources.GetObject("cmdBrowse.Image"), System.Drawing.Image)
        Me.cmdBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBrowse.Location = New System.Drawing.Point(147, 65)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(111, 34)
        Me.cmdBrowse.TabIndex = 108
        Me.cmdBrowse.Text = "&Browse "
        Me.cmdBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdBrowse.UseVisualStyleBackColor = False
        '
        'cmdSubmit
        '
        Me.cmdSubmit.BackColor = System.Drawing.Color.White
        Me.cmdSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSubmit.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSubmit.Image = CType(resources.GetObject("cmdSubmit.Image"), System.Drawing.Image)
        Me.cmdSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSubmit.Location = New System.Drawing.Point(147, 65)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(111, 34)
        Me.cmdSubmit.TabIndex = 109
        Me.cmdSubmit.Text = "&Save     "
        Me.cmdSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSubmit.UseVisualStyleBackColor = False
        Me.cmdSubmit.Visible = False
        '
        'frmPicPath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(407, 135)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPicPath"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Image Designate Path"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenPath As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SavePath As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FBD As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtpath As System.Windows.Forms.TextBox
    Friend WithEvents cmdBrowse As System.Windows.Forms.Button
    Friend WithEvents cmdSubmit As System.Windows.Forms.Button
End Class
