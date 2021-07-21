<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewStud
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewStud))
        Me.EmpPic = New System.Windows.Forms.PictureBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSubmit = New System.Windows.Forms.Button()
        Me.OpenPath = New System.Windows.Forms.OpenFileDialog()
        Me.DevEnroller = New Axzkemkeeper.AxCZKEM()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtip = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tmrRegEvent = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdDelItm = New System.Windows.Forms.Button()
        Me.cmdEditItm = New System.Windows.Forms.Button()
        Me.cmdAddItm = New System.Windows.Forms.Button()
        Me.lstItem = New System.Windows.Forms.ListView()
        Me.txtSec = New System.Windows.Forms.ComboBox()
        Me.txtGy = New System.Windows.Forms.ComboBox()
        Me.dtBdate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GPfetch = New System.Windows.Forms.GroupBox()
        Me.imgFetch = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFetchAC = New System.Windows.Forms.TextBox()
        Me.cmdDel = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.LstFetcher = New System.Windows.Forms.ListView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAC = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtGuardian = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        CType(Me.EmpPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DevEnroller, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GPfetch.SuspendLayout()
        CType(Me.imgFetch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmpPic
        '
        Me.EmpPic.BackColor = System.Drawing.Color.SteelBlue
        Me.EmpPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmpPic.Image = CType(resources.GetObject("EmpPic.Image"), System.Drawing.Image)
        Me.EmpPic.Location = New System.Drawing.Point(742, 17)
        Me.EmpPic.Name = "EmpPic"
        Me.EmpPic.Size = New System.Drawing.Size(268, 223)
        Me.EmpPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EmpPic.TabIndex = 50
        Me.EmpPic.TabStop = False
        '
        'cmdBrowse
        '
        Me.cmdBrowse.BackColor = System.Drawing.Color.White
        Me.cmdBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBrowse.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBrowse.Image = CType(resources.GetObject("cmdBrowse.Image"), System.Drawing.Image)
        Me.cmdBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBrowse.Location = New System.Drawing.Point(828, 246)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(111, 34)
        Me.cmdBrowse.TabIndex = 51
        Me.cmdBrowse.Text = "&Browse "
        Me.cmdBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdBrowse.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 16)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Grade/Year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 16)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Student Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 16)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "ID Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(65, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Section"
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.White
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCancel.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
        Me.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancel.Location = New System.Drawing.Point(873, 627)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(111, 34)
        Me.cmdCancel.TabIndex = 71
        Me.cmdCancel.Text = "&Cancel   "
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdSubmit
        '
        Me.cmdSubmit.BackColor = System.Drawing.Color.White
        Me.cmdSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSubmit.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSubmit.Image = CType(resources.GetObject("cmdSubmit.Image"), System.Drawing.Image)
        Me.cmdSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSubmit.Location = New System.Drawing.Point(761, 627)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(111, 34)
        Me.cmdSubmit.TabIndex = 70
        Me.cmdSubmit.Text = "&Save     "
        Me.cmdSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSubmit.UseVisualStyleBackColor = False
        '
        'OpenPath
        '
        Me.OpenPath.FileName = "OpenFileDialog1"
        '
        'DevEnroller
        '
        Me.DevEnroller.Enabled = True
        Me.DevEnroller.Location = New System.Drawing.Point(6, 80)
        Me.DevEnroller.Name = "DevEnroller"
        Me.DevEnroller.OcxState = CType(resources.GetObject("DevEnroller.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DevEnroller.Size = New System.Drawing.Size(25, 20)
        Me.DevEnroller.TabIndex = 73
        Me.DevEnroller.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.DevEnroller)
        Me.GroupBox1.Controls.Add(Me.txtip)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(740, 438)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 106)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FingerPrint and Id Manage"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(151, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 28)
        Me.Button1.TabIndex = 71
        Me.Button1.Text = "&Connect"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtip
        '
        Me.txtip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtip.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtip.Location = New System.Drawing.Point(90, 30)
        Me.txtip.MaxLength = 30
        Me.txtip.Name = "txtip"
        Me.txtip.Size = New System.Drawing.Size(172, 22)
        Me.txtip.TabIndex = 70
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 16)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Device IP :"
        '
        'tmrRegEvent
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.txtSec)
        Me.Panel1.Controls.Add(Me.txtGy)
        Me.Panel1.Controls.Add(Me.dtBdate)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.GPfetch)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.cmdSubmit)
        Me.Panel1.Controls.Add(Me.txtAC)
        Me.Panel1.Controls.Add(Me.cmdCancel)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtAdd)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtContact)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtGuardian)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtId)
        Me.Panel1.Controls.Add(Me.cmdBrowse)
        Me.Panel1.Controls.Add(Me.EmpPic)
        Me.Panel1.Location = New System.Drawing.Point(6, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1032, 686)
        Me.Panel1.TabIndex = 77
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox2.Controls.Add(Me.cmdDelItm)
        Me.GroupBox2.Controls.Add(Me.cmdEditItm)
        Me.GroupBox2.Controls.Add(Me.cmdAddItm)
        Me.GroupBox2.Controls.Add(Me.lstItem)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(17, 191)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(703, 235)
        Me.GroupBox2.TabIndex = 90
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Student Items"
        '
        'cmdDelItm
        '
        Me.cmdDelItm.BackColor = System.Drawing.Color.White
        Me.cmdDelItm.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDelItm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDelItm.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelItm.Image = CType(resources.GetObject("cmdDelItm.Image"), System.Drawing.Image)
        Me.cmdDelItm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDelItm.Location = New System.Drawing.Point(245, 191)
        Me.cmdDelItm.Name = "cmdDelItm"
        Me.cmdDelItm.Size = New System.Drawing.Size(111, 34)
        Me.cmdDelItm.TabIndex = 84
        Me.cmdDelItm.Text = "&Delete  "
        Me.cmdDelItm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdDelItm.UseVisualStyleBackColor = False
        '
        'cmdEditItm
        '
        Me.cmdEditItm.BackColor = System.Drawing.Color.White
        Me.cmdEditItm.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEditItm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEditItm.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEditItm.Image = CType(resources.GetObject("cmdEditItm.Image"), System.Drawing.Image)
        Me.cmdEditItm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEditItm.Location = New System.Drawing.Point(128, 191)
        Me.cmdEditItm.Name = "cmdEditItm"
        Me.cmdEditItm.Size = New System.Drawing.Size(111, 34)
        Me.cmdEditItm.TabIndex = 83
        Me.cmdEditItm.Text = "&Edit   "
        Me.cmdEditItm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdEditItm.UseVisualStyleBackColor = False
        '
        'cmdAddItm
        '
        Me.cmdAddItm.BackColor = System.Drawing.Color.White
        Me.cmdAddItm.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAddItm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAddItm.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddItm.Image = CType(resources.GetObject("cmdAddItm.Image"), System.Drawing.Image)
        Me.cmdAddItm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAddItm.Location = New System.Drawing.Point(11, 191)
        Me.cmdAddItm.Name = "cmdAddItm"
        Me.cmdAddItm.Size = New System.Drawing.Size(111, 34)
        Me.cmdAddItm.TabIndex = 82
        Me.cmdAddItm.Text = "&Add    "
        Me.cmdAddItm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAddItm.UseVisualStyleBackColor = False
        '
        'lstItem
        '
        Me.lstItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstItem.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstItem.FullRowSelect = True
        Me.lstItem.GridLines = True
        Me.lstItem.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstItem.Location = New System.Drawing.Point(11, 20)
        Me.lstItem.MultiSelect = False
        Me.lstItem.Name = "lstItem"
        Me.lstItem.Size = New System.Drawing.Size(680, 162)
        Me.lstItem.TabIndex = 76
        Me.lstItem.UseCompatibleStateImageBehavior = False
        Me.lstItem.View = System.Windows.Forms.View.Details
        '
        'txtSec
        '
        Me.txtSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSec.FormattingEnabled = True
        Me.txtSec.Items.AddRange(New Object() {"ACnumber", "IDnumber", "Name", "GradeYear", "Section", "Address", "Guardian", "ContactNo"})
        Me.txtSec.Location = New System.Drawing.Point(129, 151)
        Me.txtSec.Name = "txtSec"
        Me.txtSec.Size = New System.Drawing.Size(229, 24)
        Me.txtSec.TabIndex = 4
        '
        'txtGy
        '
        Me.txtGy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGy.FormattingEnabled = True
        Me.txtGy.Items.AddRange(New Object() {"ACnumber", "IDnumber", "Name", "GradeYear", "Section", "Address", "Guardian", "ContactNo"})
        Me.txtGy.Location = New System.Drawing.Point(129, 117)
        Me.txtGy.Name = "txtGy"
        Me.txtGy.Size = New System.Drawing.Size(229, 24)
        Me.txtGy.TabIndex = 3
        '
        'dtBdate
        '
        Me.dtBdate.CustomFormat = "MM-dd-yyyy"
        Me.dtBdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtBdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtBdate.Location = New System.Drawing.Point(493, 18)
        Me.dtBdate.Name = "dtBdate"
        Me.dtBdate.Size = New System.Drawing.Size(125, 22)
        Me.dtBdate.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(412, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 16)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "Birth Date"
        '
        'GPfetch
        '
        Me.GPfetch.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GPfetch.Controls.Add(Me.imgFetch)
        Me.GPfetch.Controls.Add(Me.Label11)
        Me.GPfetch.Controls.Add(Me.txtFetchAC)
        Me.GPfetch.Controls.Add(Me.cmdDel)
        Me.GPfetch.Controls.Add(Me.cmdEdit)
        Me.GPfetch.Controls.Add(Me.cmdAdd)
        Me.GPfetch.Controls.Add(Me.LstFetcher)
        Me.GPfetch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GPfetch.Location = New System.Drawing.Point(17, 437)
        Me.GPfetch.Name = "GPfetch"
        Me.GPfetch.Size = New System.Drawing.Size(703, 233)
        Me.GPfetch.TabIndex = 81
        Me.GPfetch.TabStop = False
        Me.GPfetch.Text = "Fetcher"
        '
        'imgFetch
        '
        Me.imgFetch.BackColor = System.Drawing.Color.SteelBlue
        Me.imgFetch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgFetch.Image = CType(resources.GetObject("imgFetch.Image"), System.Drawing.Image)
        Me.imgFetch.Location = New System.Drawing.Point(11, 21)
        Me.imgFetch.Name = "imgFetch"
        Me.imgFetch.Size = New System.Drawing.Size(198, 160)
        Me.imgFetch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFetch.TabIndex = 84
        Me.imgFetch.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 16)
        Me.Label11.TabIndex = 83
        Me.Label11.Text = "AC Number"
        '
        'txtFetchAC
        '
        Me.txtFetchAC.BackColor = System.Drawing.Color.White
        Me.txtFetchAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFetchAC.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFetchAC.Location = New System.Drawing.Point(105, 197)
        Me.txtFetchAC.MaxLength = 8
        Me.txtFetchAC.Name = "txtFetchAC"
        Me.txtFetchAC.ReadOnly = True
        Me.txtFetchAC.Size = New System.Drawing.Size(104, 23)
        Me.txtFetchAC.TabIndex = 82
        '
        'cmdDel
        '
        Me.cmdDel.BackColor = System.Drawing.Color.White
        Me.cmdDel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDel.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDel.Image = CType(resources.GetObject("cmdDel.Image"), System.Drawing.Image)
        Me.cmdDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDel.Location = New System.Drawing.Point(457, 190)
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.Size = New System.Drawing.Size(111, 34)
        Me.cmdDel.TabIndex = 81
        Me.cmdDel.Text = "&Delete  "
        Me.cmdDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdDel.UseVisualStyleBackColor = False
        '
        'cmdEdit
        '
        Me.cmdEdit.BackColor = System.Drawing.Color.White
        Me.cmdEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEdit.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEdit.Location = New System.Drawing.Point(340, 190)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(111, 34)
        Me.cmdEdit.TabIndex = 80
        Me.cmdEdit.Text = "&Edit   "
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdEdit.UseVisualStyleBackColor = False
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.Color.White
        Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAdd.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
        Me.cmdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAdd.Location = New System.Drawing.Point(223, 190)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(111, 34)
        Me.cmdAdd.TabIndex = 79
        Me.cmdAdd.Text = "&Add    "
        Me.cmdAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAdd.UseVisualStyleBackColor = False
        '
        'LstFetcher
        '
        Me.LstFetcher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstFetcher.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstFetcher.FullRowSelect = True
        Me.LstFetcher.GridLines = True
        Me.LstFetcher.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LstFetcher.Location = New System.Drawing.Point(223, 21)
        Me.LstFetcher.MultiSelect = False
        Me.LstFetcher.Name = "LstFetcher"
        Me.LstFetcher.Size = New System.Drawing.Size(467, 160)
        Me.LstFetcher.TabIndex = 76
        Me.LstFetcher.UseCompatibleStateImageBehavior = False
        Me.LstFetcher.View = System.Windows.Forms.View.Details
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(40, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 16)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "AC Number"
        '
        'txtAC
        '
        Me.txtAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAC.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAC.Location = New System.Drawing.Point(129, 17)
        Me.txtAC.MaxLength = 8
        Me.txtAC.Name = "txtAC"
        Me.txtAC.Size = New System.Drawing.Size(229, 23)
        Me.txtAC.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(422, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Address"
        '
        'txtAdd
        '
        Me.txtAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdd.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd.Location = New System.Drawing.Point(492, 49)
        Me.txtAdd.MaxLength = 150
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(229, 23)
        Me.txtAdd.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(373, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 16)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Guardian Name"
        '
        'txtContact
        '
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContact.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(492, 117)
        Me.txtContact.MaxLength = 40
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(229, 23)
        Me.txtContact.TabIndex = 8
        '
        'txtGuardian
        '
        Me.txtGuardian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGuardian.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuardian.Location = New System.Drawing.Point(492, 82)
        Me.txtGuardian.MaxLength = 50
        Me.txtGuardian.Name = "txtGuardian"
        Me.txtGuardian.Size = New System.Drawing.Size(229, 23)
        Me.txtGuardian.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(370, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 16)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Contact Number"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(129, 83)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(229, 23)
        Me.txtName.TabIndex = 2
        '
        'txtId
        '
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtId.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(129, 50)
        Me.txtId.MaxLength = 8
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(229, 23)
        Me.txtId.TabIndex = 1
        '
        'frmNewStud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1045, 702)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewStud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " New Student"
        CType(Me.EmpPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DevEnroller, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GPfetch.ResumeLayout(False)
        Me.GPfetch.PerformLayout()
        CType(Me.imgFetch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EmpPic As System.Windows.Forms.PictureBox
    Friend WithEvents cmdBrowse As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdSubmit As System.Windows.Forms.Button
    Friend WithEvents OpenPath As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DevEnroller As Axzkemkeeper.AxCZKEM
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtip As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tmrRegEvent As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GPfetch As System.Windows.Forms.GroupBox
    Friend WithEvents LstFetcher As System.Windows.Forms.ListView
    Friend WithEvents cmdDel As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtFetchAC As System.Windows.Forms.TextBox
    Friend WithEvents txtSec As System.Windows.Forms.ComboBox
    Friend WithEvents txtGy As System.Windows.Forms.ComboBox
    Friend WithEvents dtBdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAC As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents txtGuardian As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents imgFetch As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lstItem As System.Windows.Forms.ListView
    Friend WithEvents cmdDelItm As System.Windows.Forms.Button
    Friend WithEvents cmdEditItm As System.Windows.Forms.Button
    Friend WithEvents cmdAddItm As System.Windows.Forms.Button
End Class
