<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LetranMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LetranMain))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtLongDate = New System.Windows.Forms.Label()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNotice = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCourse = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStudent = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StudPic = New System.Windows.Forms.PictureBox()
        Me.PanelDev = New System.Windows.Forms.TableLayoutPanel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.StudPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Navy
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1049, 515)
        Me.SplitContainer1.SplitterDistance = 66
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.PictureBox1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer2.Size = New System.Drawing.Size(1049, 66)
        Me.SplitContainer2.SplitterDistance = 83
        Me.SplitContainer2.TabIndex = 566
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.SplitContainer4.Size = New System.Drawing.Size(962, 66)
        Me.SplitContainer4.SplitterDistance = 571
        Me.SplitContainer4.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(2, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ID MONITORING SYSTEM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Old English Text MT", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-2, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(475, 42)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Colegio De San Juan Letran"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.97416!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.02584!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtLongDate, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(387, 66)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'txtLongDate
        '
        Me.txtLongDate.AutoSize = True
        Me.txtLongDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLongDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLongDate.ForeColor = System.Drawing.Color.Yellow
        Me.txtLongDate.Location = New System.Drawing.Point(118, 33)
        Me.txtLongDate.Name = "txtLongDate"
        Me.txtLongDate.Size = New System.Drawing.Size(266, 33)
        Me.txtLongDate.TabIndex = 0
        Me.txtLongDate.Text = "Date"
        Me.txtLongDate.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.BackColor = System.Drawing.Color.Gray
        Me.SplitContainer3.Panel1.Controls.Add(Me.SplitContainer5)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.BackColor = System.Drawing.Color.Gray
        Me.SplitContainer3.Panel2.Controls.Add(Me.PanelDev)
        Me.SplitContainer3.Size = New System.Drawing.Size(1049, 445)
        Me.SplitContainer3.SplitterDistance = 415
        Me.SplitContainer3.TabIndex = 0
        '
        'SplitContainer5
        '
        Me.SplitContainer5.BackColor = System.Drawing.Color.DimGray
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer5.Name = "SplitContainer5"
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.TableLayoutPanel1)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.StudPic)
        Me.SplitContainer5.Size = New System.Drawing.Size(1049, 415)
        Me.SplitContainer5.SplitterDistance = 593
        Me.SplitContainer5.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.10703!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.89297!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNotice, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtYear, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCourse, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtStudent, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.90196!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.09804!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(593, 415)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 224)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(184, 160)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "NOTICE :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNotice
        '
        Me.txtNotice.AutoSize = True
        Me.txtNotice.BackColor = System.Drawing.Color.DimGray
        Me.txtNotice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNotice.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotice.ForeColor = System.Drawing.Color.Red
        Me.txtNotice.Location = New System.Drawing.Point(193, 224)
        Me.txtNotice.Name = "txtNotice"
        Me.txtNotice.Size = New System.Drawing.Size(397, 160)
        Me.txtNotice.TabIndex = 6
        Me.txtNotice.Text = "-"
        '
        'txtYear
        '
        Me.txtYear.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtYear.AutoSize = True
        Me.txtYear.BackColor = System.Drawing.Color.DimGray
        Me.txtYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtYear.Location = New System.Drawing.Point(193, 135)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(397, 89)
        Me.txtYear.TabIndex = 4
        Me.txtYear.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 89)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "YEAR :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCourse
        '
        Me.txtCourse.AutoSize = True
        Me.txtCourse.BackColor = System.Drawing.Color.DimGray
        Me.txtCourse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtCourse.Location = New System.Drawing.Point(193, 74)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(397, 61)
        Me.txtCourse.TabIndex = 3
        Me.txtCourse.Text = "-"
        Me.txtCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 61)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "COURSE :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStudent
        '
        Me.txtStudent.AutoSize = True
        Me.txtStudent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtStudent.Location = New System.Drawing.Point(193, 0)
        Me.txtStudent.Name = "txtStudent"
        Me.txtStudent.Size = New System.Drawing.Size(397, 74)
        Me.txtStudent.TabIndex = 1
        Me.txtStudent.Text = "-"
        Me.txtStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 74)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "STUDENT NAME :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StudPic
        '
        Me.StudPic.BackColor = System.Drawing.Color.Transparent
        Me.StudPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StudPic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StudPic.Image = CType(resources.GetObject("StudPic.Image"), System.Drawing.Image)
        Me.StudPic.Location = New System.Drawing.Point(0, 0)
        Me.StudPic.Name = "StudPic"
        Me.StudPic.Size = New System.Drawing.Size(452, 415)
        Me.StudPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.StudPic.TabIndex = 75
        Me.StudPic.TabStop = False
        '
        'PanelDev
        '
        Me.PanelDev.AutoScroll = True
        Me.PanelDev.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelDev.ColumnCount = 11
        Me.PanelDev.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelDev.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelDev.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelDev.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelDev.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelDev.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelDev.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelDev.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelDev.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelDev.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelDev.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelDev.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelDev.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PanelDev.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDev.Location = New System.Drawing.Point(0, 0)
        Me.PanelDev.Name = "PanelDev"
        Me.PanelDev.RowCount = 8
        Me.PanelDev.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PanelDev.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PanelDev.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PanelDev.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PanelDev.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PanelDev.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PanelDev.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PanelDev.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PanelDev.Size = New System.Drawing.Size(1049, 26)
        Me.PanelDev.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'LetranMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1049, 515)
        Me.Controls.Add(Me.SplitContainer1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "LetranMain"
        Me.Text = " Letran Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.PerformLayout()
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.StudPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents PanelDev As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtYear As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCourse As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtStudent As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNotice As System.Windows.Forms.Label
    Friend WithEvents StudPic As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtLongDate As System.Windows.Forms.Label
End Class
