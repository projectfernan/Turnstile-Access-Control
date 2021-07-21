<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployee))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DevLoad = New System.Windows.Forms.ProgressBar()
        Me.cmdInvertRec = New System.Windows.Forms.Button()
        Me.cmdSelectRec = New System.Windows.Forms.Button()
        Me.cmdAntiPSB = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.listStatus = New System.Windows.Forms.ListBox()
        Me.lstList = New System.Windows.Forms.ListView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtRecordCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.totalRecord = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Loadbar = New System.Windows.Forms.ToolStripProgressBar()
        Me.cmdExportExcel = New System.Windows.Forms.Button()
        Me.cmdUnblock = New System.Windows.Forms.Button()
        Me.cmdBlock = New System.Windows.Forms.Button()
        Me.cmdDel = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboCateg = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.LstEmpRec = New System.Windows.Forms.ListView()
        Me.EmpPic = New System.Windows.Forms.PictureBox()
        Me.cmdUpdExp = New System.Windows.Forms.Button()
        Me.Savefile = New System.Windows.Forms.SaveFileDialog()
        Me.Dev = New Axzkemkeeper.AxCZKEM()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.EmpPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dev, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DevLoad)
        Me.Panel1.Controls.Add(Me.cmdInvertRec)
        Me.Panel1.Controls.Add(Me.cmdSelectRec)
        Me.Panel1.Controls.Add(Me.cmdAntiPSB)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.listStatus)
        Me.Panel1.Controls.Add(Me.lstList)
        Me.Panel1.Controls.Add(Me.StatusStrip1)
        Me.Panel1.Controls.Add(Me.cmdExportExcel)
        Me.Panel1.Controls.Add(Me.cmdUnblock)
        Me.Panel1.Controls.Add(Me.cmdBlock)
        Me.Panel1.Controls.Add(Me.cmdDel)
        Me.Panel1.Controls.Add(Me.cmdAdd)
        Me.Panel1.Controls.Add(Me.cmdRefresh)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cboCateg)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtInput)
        Me.Panel1.Controls.Add(Me.cmdSearch)
        Me.Panel1.Controls.Add(Me.cmdEdit)
        Me.Panel1.Controls.Add(Me.LstEmpRec)
        Me.Panel1.Controls.Add(Me.EmpPic)
        Me.Panel1.Controls.Add(Me.cmdUpdExp)
        Me.Panel1.Location = New System.Drawing.Point(7, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1286, 495)
        Me.Panel1.TabIndex = 74
        '
        'DevLoad
        '
        Me.DevLoad.BackColor = System.Drawing.Color.White
        Me.DevLoad.Location = New System.Drawing.Point(980, 388)
        Me.DevLoad.Name = "DevLoad"
        Me.DevLoad.Size = New System.Drawing.Size(295, 20)
        Me.DevLoad.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.DevLoad.TabIndex = 149
        '
        'cmdInvertRec
        '
        Me.cmdInvertRec.BackColor = System.Drawing.Color.White
        Me.cmdInvertRec.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdInvertRec.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInvertRec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdInvertRec.Location = New System.Drawing.Point(276, 417)
        Me.cmdInvertRec.Name = "cmdInvertRec"
        Me.cmdInvertRec.Size = New System.Drawing.Size(145, 28)
        Me.cmdInvertRec.TabIndex = 148
        Me.cmdInvertRec.TabStop = False
        Me.cmdInvertRec.Text = "Invert All Records"
        Me.cmdInvertRec.UseVisualStyleBackColor = False
        '
        'cmdSelectRec
        '
        Me.cmdSelectRec.BackColor = System.Drawing.Color.White
        Me.cmdSelectRec.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSelectRec.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSelectRec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSelectRec.Location = New System.Drawing.Point(427, 417)
        Me.cmdSelectRec.Name = "cmdSelectRec"
        Me.cmdSelectRec.Size = New System.Drawing.Size(148, 28)
        Me.cmdSelectRec.TabIndex = 147
        Me.cmdSelectRec.TabStop = False
        Me.cmdSelectRec.Text = "Select All Records"
        Me.cmdSelectRec.UseVisualStyleBackColor = False
        '
        'cmdAntiPSB
        '
        Me.cmdAntiPSB.BackColor = System.Drawing.Color.White
        Me.cmdAntiPSB.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAntiPSB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAntiPSB.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAntiPSB.Image = CType(resources.GetObject("cmdAntiPSB.Image"), System.Drawing.Image)
        Me.cmdAntiPSB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAntiPSB.Location = New System.Drawing.Point(980, 414)
        Me.cmdAntiPSB.Name = "cmdAntiPSB"
        Me.cmdAntiPSB.Size = New System.Drawing.Size(296, 34)
        Me.cmdAntiPSB.TabIndex = 146
        Me.cmdAntiPSB.Text = "&Set Anti Passback Setting"
        Me.cmdAntiPSB.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(980, 243)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(145, 28)
        Me.Button2.TabIndex = 145
        Me.Button2.TabStop = False
        Me.Button2.Text = "Invert All"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1128, 243)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 28)
        Me.Button1.TabIndex = 144
        Me.Button1.TabStop = False
        Me.Button1.Text = "Select All"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'listStatus
        '
        Me.listStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listStatus.FormattingEnabled = True
        Me.listStatus.Location = New System.Drawing.Point(980, 276)
        Me.listStatus.Name = "listStatus"
        Me.listStatus.Size = New System.Drawing.Size(296, 106)
        Me.listStatus.TabIndex = 143
        '
        'lstList
        '
        Me.lstList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstList.CheckBoxes = True
        Me.lstList.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstList.FullRowSelect = True
        Me.lstList.GridLines = True
        Me.lstList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstList.Location = New System.Drawing.Point(980, 53)
        Me.lstList.MultiSelect = False
        Me.lstList.Name = "lstList"
        Me.lstList.Size = New System.Drawing.Size(296, 184)
        Me.lstList.TabIndex = 142
        Me.lstList.UseCompatibleStateImageBehavior = False
        Me.lstList.View = System.Windows.Forms.View.Details
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.txtRecordCount, Me.ToolStripStatusLabel2, Me.totalRecord, Me.Loadbar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 458)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1286, 37)
        Me.StatusStrip1.TabIndex = 104
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Image = CType(resources.GetObject("ToolStripStatusLabel1.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(141, 32)
        Me.ToolStripStatusLabel1.Text = " Record Count :"
        '
        'txtRecordCount
        '
        Me.txtRecordCount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecordCount.ForeColor = System.Drawing.Color.Aqua
        Me.txtRecordCount.Name = "txtRecordCount"
        Me.txtRecordCount.Size = New System.Drawing.Size(16, 32)
        Me.txtRecordCount.Text = "0"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.Aqua
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(16, 32)
        Me.ToolStripStatusLabel2.Text = "/"
        '
        'totalRecord
        '
        Me.totalRecord.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalRecord.ForeColor = System.Drawing.Color.Aqua
        Me.totalRecord.Name = "totalRecord"
        Me.totalRecord.Size = New System.Drawing.Size(16, 32)
        Me.totalRecord.Text = "0"
        '
        'Loadbar
        '
        Me.Loadbar.BackColor = System.Drawing.Color.White
        Me.Loadbar.ForeColor = System.Drawing.Color.Lime
        Me.Loadbar.Name = "Loadbar"
        Me.Loadbar.Size = New System.Drawing.Size(100, 31)
        Me.Loadbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'cmdExportExcel
        '
        Me.cmdExportExcel.BackColor = System.Drawing.Color.White
        Me.cmdExportExcel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdExportExcel.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExportExcel.Image = CType(resources.GetObject("cmdExportExcel.Image"), System.Drawing.Image)
        Me.cmdExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExportExcel.Location = New System.Drawing.Point(24, 414)
        Me.cmdExportExcel.Name = "cmdExportExcel"
        Me.cmdExportExcel.Size = New System.Drawing.Size(228, 34)
        Me.cmdExportExcel.TabIndex = 103
        Me.cmdExportExcel.Text = "&Export to Excel "
        Me.cmdExportExcel.UseVisualStyleBackColor = False
        Me.cmdExportExcel.Visible = False
        '
        'cmdUnblock
        '
        Me.cmdUnblock.BackColor = System.Drawing.Color.White
        Me.cmdUnblock.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdUnblock.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdUnblock.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUnblock.Image = CType(resources.GetObject("cmdUnblock.Image"), System.Drawing.Image)
        Me.cmdUnblock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdUnblock.Location = New System.Drawing.Point(24, 374)
        Me.cmdUnblock.Name = "cmdUnblock"
        Me.cmdUnblock.Size = New System.Drawing.Size(228, 34)
        Me.cmdUnblock.TabIndex = 101
        Me.cmdUnblock.Text = "&Unblock "
        Me.cmdUnblock.UseVisualStyleBackColor = False
        '
        'cmdBlock
        '
        Me.cmdBlock.BackColor = System.Drawing.Color.White
        Me.cmdBlock.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBlock.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBlock.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBlock.Image = CType(resources.GetObject("cmdBlock.Image"), System.Drawing.Image)
        Me.cmdBlock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBlock.Location = New System.Drawing.Point(141, 335)
        Me.cmdBlock.Name = "cmdBlock"
        Me.cmdBlock.Size = New System.Drawing.Size(111, 34)
        Me.cmdBlock.TabIndex = 100
        Me.cmdBlock.Text = "&Block  "
        Me.cmdBlock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdBlock.UseVisualStyleBackColor = False
        '
        'cmdDel
        '
        Me.cmdDel.BackColor = System.Drawing.Color.White
        Me.cmdDel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDel.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDel.Image = CType(resources.GetObject("cmdDel.Image"), System.Drawing.Image)
        Me.cmdDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDel.Location = New System.Drawing.Point(24, 335)
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.Size = New System.Drawing.Size(111, 34)
        Me.cmdDel.TabIndex = 99
        Me.cmdDel.Text = "&Delete "
        Me.cmdDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdDel.UseVisualStyleBackColor = False
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.Color.White
        Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAdd.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
        Me.cmdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAdd.Location = New System.Drawing.Point(24, 295)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(111, 34)
        Me.cmdAdd.TabIndex = 98
        Me.cmdAdd.Text = "&Add   "
        Me.cmdAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAdd.UseVisualStyleBackColor = False
        '
        'cmdRefresh
        '
        Me.cmdRefresh.BackColor = System.Drawing.Color.White
        Me.cmdRefresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdRefresh.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdRefresh.Location = New System.Drawing.Point(555, 12)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(111, 34)
        Me.cmdRefresh.TabIndex = 97
        Me.cmdRefresh.Text = "&Refresh  "
        Me.cmdRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdRefresh.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(893, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "Keyword :"
        '
        'cboCateg
        '
        Me.cboCateg.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboCateg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCateg.FormattingEnabled = True
        Me.cboCateg.Items.AddRange(New Object() {"ACno", "IDnumber", "Name", "Title", "Gender", "RoomNumber", "BedName"})
        Me.cboCateg.Location = New System.Drawing.Point(359, 17)
        Me.cboCateg.Name = "cboCateg"
        Me.cboCateg.Size = New System.Drawing.Size(179, 24)
        Me.cboCateg.TabIndex = 95
        Me.cboCateg.Text = "IDnumber"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(280, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 16)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Category :"
        '
        'txtInput
        '
        Me.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInput.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(968, 18)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(179, 23)
        Me.txtInput.TabIndex = 92
        '
        'cmdSearch
        '
        Me.cmdSearch.BackColor = System.Drawing.Color.White
        Me.cmdSearch.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSearch.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.Image = CType(resources.GetObject("cmdSearch.Image"), System.Drawing.Image)
        Me.cmdSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSearch.Location = New System.Drawing.Point(1165, 12)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(111, 34)
        Me.cmdSearch.TabIndex = 94
        Me.cmdSearch.Text = "&Search  "
        Me.cmdSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSearch.UseVisualStyleBackColor = False
        '
        'cmdEdit
        '
        Me.cmdEdit.BackColor = System.Drawing.Color.White
        Me.cmdEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEdit.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEdit.Location = New System.Drawing.Point(141, 295)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(111, 34)
        Me.cmdEdit.TabIndex = 89
        Me.cmdEdit.Text = "&Update "
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdEdit.UseVisualStyleBackColor = False
        '
        'LstEmpRec
        '
        Me.LstEmpRec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstEmpRec.CheckBoxes = True
        Me.LstEmpRec.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstEmpRec.FullRowSelect = True
        Me.LstEmpRec.GridLines = True
        Me.LstEmpRec.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LstEmpRec.Location = New System.Drawing.Point(276, 53)
        Me.LstEmpRec.Name = "LstEmpRec"
        Me.LstEmpRec.Size = New System.Drawing.Size(692, 355)
        Me.LstEmpRec.TabIndex = 87
        Me.LstEmpRec.UseCompatibleStateImageBehavior = False
        Me.LstEmpRec.View = System.Windows.Forms.View.Details
        '
        'EmpPic
        '
        Me.EmpPic.BackColor = System.Drawing.Color.RoyalBlue
        Me.EmpPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmpPic.Image = CType(resources.GetObject("EmpPic.Image"), System.Drawing.Image)
        Me.EmpPic.Location = New System.Drawing.Point(13, 53)
        Me.EmpPic.Name = "EmpPic"
        Me.EmpPic.Size = New System.Drawing.Size(251, 233)
        Me.EmpPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EmpPic.TabIndex = 86
        Me.EmpPic.TabStop = False
        '
        'cmdUpdExp
        '
        Me.cmdUpdExp.BackColor = System.Drawing.Color.White
        Me.cmdUpdExp.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdUpdExp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdUpdExp.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdExp.Image = CType(resources.GetObject("cmdUpdExp.Image"), System.Drawing.Image)
        Me.cmdUpdExp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdUpdExp.Location = New System.Drawing.Point(26, 374)
        Me.cmdUpdExp.Name = "cmdUpdExp"
        Me.cmdUpdExp.Size = New System.Drawing.Size(226, 34)
        Me.cmdUpdExp.TabIndex = 102
        Me.cmdUpdExp.Text = "&Update Expiration Date "
        Me.cmdUpdExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdUpdExp.UseVisualStyleBackColor = False
        Me.cmdUpdExp.Visible = False
        '
        'Dev
        '
        Me.Dev.Enabled = True
        Me.Dev.Location = New System.Drawing.Point(635, 424)
        Me.Dev.Name = "Dev"
        Me.Dev.OcxState = CType(resources.GetObject("Dev.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Dev.Size = New System.Drawing.Size(38, 34)
        Me.Dev.TabIndex = 144
        Me.Dev.Visible = False
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1300, 509)
        Me.Controls.Add(Me.Dev)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Manage Cards"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.EmpPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dev, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboCateg As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents LstEmpRec As System.Windows.Forms.ListView
    Friend WithEvents EmpPic As System.Windows.Forms.PictureBox
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdDel As System.Windows.Forms.Button
    Friend WithEvents cmdBlock As System.Windows.Forms.Button
    Friend WithEvents cmdUpdExp As System.Windows.Forms.Button
    Friend WithEvents cmdUnblock As System.Windows.Forms.Button
    Friend WithEvents cmdExportExcel As System.Windows.Forms.Button
    Friend WithEvents Savefile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtRecordCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents totalRecord As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Loadbar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents listStatus As System.Windows.Forms.ListBox
    Friend WithEvents lstList As System.Windows.Forms.ListView
    Friend WithEvents cmdAntiPSB As System.Windows.Forms.Button
    Friend WithEvents cmdInvertRec As System.Windows.Forms.Button
    Friend WithEvents cmdSelectRec As System.Windows.Forms.Button
    Friend WithEvents Dev As Axzkemkeeper.AxCZKEM
    Friend WithEvents DevLoad As System.Windows.Forms.ProgressBar
End Class
