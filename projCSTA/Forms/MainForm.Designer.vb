<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dev1 = New Axzkemkeeper.AxCZKEM()
        Me.Dev2 = New Axzkemkeeper.AxCZKEM()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtTime = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtDate = New System.Windows.Forms.ToolStripLabel()
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtDesig = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtSystemUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtDbStat = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtDev1Stat = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel9 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtDev2Stat = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtCtrlStat = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtRuning = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmrRead = New System.Windows.Forms.Timer(Me.components)
        Me.tmrClearStud = New System.Windows.Forms.Timer(Me.components)
        Me.tmrClearFetch = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer6 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer7 = New System.Windows.Forms.SplitContainer()
        Me.imgStud = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtIDno = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtGy = New System.Windows.Forms.Label()
        Me.txtOras = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtInOut = New System.Windows.Forms.Label()
        Me.SplitContainer8 = New System.Windows.Forms.SplitContainer()
        Me.Lstlist = New System.Windows.Forms.ListView()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SplitContainer9 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer10 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer11 = New System.Windows.Forms.SplitContainer()
        Me.imgF1 = New System.Windows.Forms.PictureBox()
        Me.txtP1 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtF1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SplitContainer12 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer13 = New System.Windows.Forms.SplitContainer()
        Me.imgF2 = New System.Windows.Forms.PictureBox()
        Me.txtP2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtF2 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.SplitContainer14 = New System.Windows.Forms.SplitContainer()
        Me.imgF3 = New System.Windows.Forms.PictureBox()
        Me.txtP3 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtF3 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.SplitContainer15 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer16 = New System.Windows.Forms.SplitContainer()
        Me.imgF4 = New System.Windows.Forms.PictureBox()
        Me.txtP4 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtF4 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.SplitContainer17 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer18 = New System.Windows.Forms.SplitContainer()
        Me.imgF5 = New System.Windows.Forms.PictureBox()
        Me.txtP5 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtF5 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.SplitContainer19 = New System.Windows.Forms.SplitContainer()
        Me.imgF6 = New System.Windows.Forms.PictureBox()
        Me.txtP6 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtF6 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.SplitContainer20 = New System.Windows.Forms.SplitContainer()
        Me.txtStat = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.Dev1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dev2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        Me.SplitContainer6.Panel1.SuspendLayout()
        Me.SplitContainer6.Panel2.SuspendLayout()
        Me.SplitContainer6.SuspendLayout()
        Me.SplitContainer7.Panel1.SuspendLayout()
        Me.SplitContainer7.Panel2.SuspendLayout()
        Me.SplitContainer7.SuspendLayout()
        CType(Me.imgStud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SplitContainer8.Panel1.SuspendLayout()
        Me.SplitContainer8.Panel2.SuspendLayout()
        Me.SplitContainer8.SuspendLayout()
        Me.SplitContainer9.Panel1.SuspendLayout()
        Me.SplitContainer9.Panel2.SuspendLayout()
        Me.SplitContainer9.SuspendLayout()
        Me.SplitContainer10.Panel1.SuspendLayout()
        Me.SplitContainer10.Panel2.SuspendLayout()
        Me.SplitContainer10.SuspendLayout()
        Me.SplitContainer11.Panel1.SuspendLayout()
        Me.SplitContainer11.Panel2.SuspendLayout()
        Me.SplitContainer11.SuspendLayout()
        CType(Me.imgF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer12.Panel1.SuspendLayout()
        Me.SplitContainer12.Panel2.SuspendLayout()
        Me.SplitContainer12.SuspendLayout()
        Me.SplitContainer13.Panel1.SuspendLayout()
        Me.SplitContainer13.Panel2.SuspendLayout()
        Me.SplitContainer13.SuspendLayout()
        CType(Me.imgF2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer14.Panel1.SuspendLayout()
        Me.SplitContainer14.Panel2.SuspendLayout()
        Me.SplitContainer14.SuspendLayout()
        CType(Me.imgF3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer15.Panel1.SuspendLayout()
        Me.SplitContainer15.Panel2.SuspendLayout()
        Me.SplitContainer15.SuspendLayout()
        Me.SplitContainer16.Panel1.SuspendLayout()
        Me.SplitContainer16.Panel2.SuspendLayout()
        Me.SplitContainer16.SuspendLayout()
        CType(Me.imgF4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer17.Panel1.SuspendLayout()
        Me.SplitContainer17.Panel2.SuspendLayout()
        Me.SplitContainer17.SuspendLayout()
        Me.SplitContainer18.Panel1.SuspendLayout()
        Me.SplitContainer18.Panel2.SuspendLayout()
        Me.SplitContainer18.SuspendLayout()
        CType(Me.imgF5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer19.Panel1.SuspendLayout()
        Me.SplitContainer19.Panel2.SuspendLayout()
        Me.SplitContainer19.SuspendLayout()
        CType(Me.imgF6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer20.Panel1.SuspendLayout()
        Me.SplitContainer20.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1077, 84)
        Me.SplitContainer1.SplitterDistance = 96
        Me.SplitContainer1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Dev1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Dev2)
        Me.SplitContainer2.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer2.Size = New System.Drawing.Size(977, 84)
        Me.SplitContainer2.SplitterDistance = 474
        Me.SplitContainer2.TabIndex = 0
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
        Me.SplitContainer3.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer3.Size = New System.Drawing.Size(474, 84)
        Me.SplitContainer3.SplitterDistance = 52
        Me.SplitContainer3.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "XAVIER SCHOOL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ACCESS CONTROL SYSTEM"
        '
        'Dev1
        '
        Me.Dev1.Enabled = True
        Me.Dev1.Location = New System.Drawing.Point(113, 22)
        Me.Dev1.Name = "Dev1"
        Me.Dev1.OcxState = CType(resources.GetObject("Dev1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Dev1.Size = New System.Drawing.Size(39, 26)
        Me.Dev1.TabIndex = 111
        Me.Dev1.Visible = False
        '
        'Dev2
        '
        Me.Dev2.Enabled = True
        Me.Dev2.Location = New System.Drawing.Point(159, 22)
        Me.Dev2.Name = "Dev2"
        Me.Dev2.OcxState = CType(resources.GetObject("Dev2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Dev2.Size = New System.Drawing.Size(39, 26)
        Me.Dev2.TabIndex = 112
        Me.Dev2.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.txtTime, Me.ToolStripLabel1, Me.txtDate})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(499, 84)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(16, 81)
        Me.ToolStripLabel2.Text = "   "
        '
        'txtTime
        '
        Me.txtTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtTime.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTime.Image = CType(resources.GetObject("txtTime.Image"), System.Drawing.Image)
        Me.txtTime.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(111, 81)
        Me.txtTime.Text = "Time"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(16, 81)
        Me.ToolStripLabel1.Text = "   "
        '
        'txtDate
        '
        Me.txtDate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtDate.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtDate.Image = CType(resources.GetObject("txtDate.Image"), System.Drawing.Image)
        Me.txtDate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(110, 81)
        Me.txtDate.Text = "Date"
        '
        'tmrTime
        '
        Me.tmrTime.Enabled = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.txtDesig, Me.txtSystemUser, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.txtDbStat, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel6, Me.txtDev1Stat, Me.ToolStripStatusLabel8, Me.ToolStripStatusLabel9, Me.txtDev2Stat, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel7, Me.txtCtrlStat, Me.txtRuning})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 743)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1077, 37)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(10, 32)
        Me.ToolStripStatusLabel1.Text = " "
        '
        'txtDesig
        '
        Me.txtDesig.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesig.ForeColor = System.Drawing.Color.White
        Me.txtDesig.Image = CType(resources.GetObject("txtDesig.Image"), System.Drawing.Image)
        Me.txtDesig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.txtDesig.Name = "txtDesig"
        Me.txtDesig.Size = New System.Drawing.Size(97, 32)
        Me.txtDesig.Text = "System :"
        '
        'txtSystemUser
        '
        Me.txtSystemUser.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSystemUser.ForeColor = System.Drawing.Color.Yellow
        Me.txtSystemUser.Name = "txtSystemUser"
        Me.txtSystemUser.Size = New System.Drawing.Size(37, 32)
        Me.txtSystemUser.Text = "Lock"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(25, 32)
        Me.ToolStripStatusLabel3.Text = " | "
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel4.Image = CType(resources.GetObject("ToolStripStatusLabel4.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(111, 32)
        Me.ToolStripStatusLabel4.Text = "Database :"
        '
        'txtDbStat
        '
        Me.txtDbStat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDbStat.ForeColor = System.Drawing.Color.Red
        Me.txtDbStat.Name = "txtDbStat"
        Me.txtDbStat.Size = New System.Drawing.Size(95, 32)
        Me.txtDbStat.Text = "Disconnected"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(25, 32)
        Me.ToolStripStatusLabel5.Text = " | "
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel6.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel6.Image = CType(resources.GetObject("ToolStripStatusLabel6.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(108, 32)
        Me.ToolStripStatusLabel6.Text = "Reader 1 :"
        '
        'txtDev1Stat
        '
        Me.txtDev1Stat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDev1Stat.ForeColor = System.Drawing.Color.Red
        Me.txtDev1Stat.Name = "txtDev1Stat"
        Me.txtDev1Stat.Size = New System.Drawing.Size(95, 32)
        Me.txtDev1Stat.Text = "Disconnected"
        '
        'ToolStripStatusLabel8
        '
        Me.ToolStripStatusLabel8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(25, 32)
        Me.ToolStripStatusLabel8.Text = " | "
        '
        'ToolStripStatusLabel9
        '
        Me.ToolStripStatusLabel9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel9.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel9.Image = CType(resources.GetObject("ToolStripStatusLabel9.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripStatusLabel9.Name = "ToolStripStatusLabel9"
        Me.ToolStripStatusLabel9.Size = New System.Drawing.Size(108, 32)
        Me.ToolStripStatusLabel9.Text = "Reader 2 :"
        '
        'txtDev2Stat
        '
        Me.txtDev2Stat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDev2Stat.ForeColor = System.Drawing.Color.Red
        Me.txtDev2Stat.Name = "txtDev2Stat"
        Me.txtDev2Stat.Size = New System.Drawing.Size(95, 32)
        Me.txtDev2Stat.Text = "Disconnected"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(25, 32)
        Me.ToolStripStatusLabel2.Text = " | "
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel7.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel7.Image = CType(resources.GetObject("ToolStripStatusLabel7.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(113, 32)
        Me.ToolStripStatusLabel7.Text = "Controller :"
        '
        'txtCtrlStat
        '
        Me.txtCtrlStat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtrlStat.ForeColor = System.Drawing.Color.Red
        Me.txtCtrlStat.Name = "txtCtrlStat"
        Me.txtCtrlStat.Size = New System.Drawing.Size(95, 32)
        Me.txtCtrlStat.Text = "Disconnected"
        '
        'txtRuning
        '
        Me.txtRuning.BackColor = System.Drawing.Color.Transparent
        Me.txtRuning.Enabled = False
        Me.txtRuning.Image = CType(resources.GetObject("txtRuning.Image"), System.Drawing.Image)
        Me.txtRuning.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.txtRuning.Name = "txtRuning"
        Me.txtRuning.Size = New System.Drawing.Size(126, 22)
        Me.txtRuning.Visible = False
        '
        'tmrRead
        '
        Me.tmrRead.Interval = 800
        '
        'tmrClearStud
        '
        Me.tmrClearStud.Interval = 10000
        '
        'tmrClearFetch
        '
        Me.tmrClearFetch.Interval = 10000
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 84)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.SplitContainer5)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer4.Panel2.Controls.Add(Me.SplitContainer20)
        Me.SplitContainer4.Size = New System.Drawing.Size(1077, 659)
        Me.SplitContainer4.SplitterDistance = 624
        Me.SplitContainer4.TabIndex = 2
        '
        'SplitContainer5
        '
        Me.SplitContainer5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer5.Name = "SplitContainer5"
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.SplitContainer6)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.SplitContainer9)
        Me.SplitContainer5.Size = New System.Drawing.Size(1077, 624)
        Me.SplitContainer5.SplitterDistance = 331
        Me.SplitContainer5.TabIndex = 3
        '
        'SplitContainer6
        '
        Me.SplitContainer6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer6.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer6.Name = "SplitContainer6"
        Me.SplitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer6.Panel1
        '
        Me.SplitContainer6.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SplitContainer6.Panel1.Controls.Add(Me.SplitContainer7)
        '
        'SplitContainer6.Panel2
        '
        Me.SplitContainer6.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SplitContainer6.Panel2.Controls.Add(Me.SplitContainer8)
        Me.SplitContainer6.Size = New System.Drawing.Size(331, 624)
        Me.SplitContainer6.SplitterDistance = 405
        Me.SplitContainer6.TabIndex = 0
        '
        'SplitContainer7
        '
        Me.SplitContainer7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer7.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer7.Name = "SplitContainer7"
        Me.SplitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer7.Panel1
        '
        Me.SplitContainer7.Panel1.Controls.Add(Me.imgStud)
        '
        'SplitContainer7.Panel2
        '
        Me.SplitContainer7.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer7.Size = New System.Drawing.Size(329, 403)
        Me.SplitContainer7.SplitterDistance = 256
        Me.SplitContainer7.TabIndex = 0
        '
        'imgStud
        '
        Me.imgStud.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgStud.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.imgStud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgStud.Image = CType(resources.GetObject("imgStud.Image"), System.Drawing.Image)
        Me.imgStud.Location = New System.Drawing.Point(7, 6)
        Me.imgStud.Name = "imgStud"
        Me.imgStud.Size = New System.Drawing.Size(315, 247)
        Me.imgStud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgStud.TabIndex = 112
        Me.imgStud.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtIDno)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtGy)
        Me.Panel1.Controls.Add(Me.txtOras)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtInOut)
        Me.Panel1.Location = New System.Drawing.Point(6, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(317, 138)
        Me.Panel1.TabIndex = 0
        '
        'txtIDno
        '
        Me.txtIDno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtIDno.AutoSize = True
        Me.txtIDno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDno.ForeColor = System.Drawing.Color.Navy
        Me.txtIDno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtIDno.Location = New System.Drawing.Point(102, 14)
        Me.txtIDno.Name = "txtIDno"
        Me.txtIDno.Size = New System.Drawing.Size(188, 18)
        Me.txtIDno.TabIndex = 112
        Me.txtIDno.Text = "____________________"
        Me.txtIDno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(9, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 18)
        Me.Label9.TabIndex = 108
        Me.Label9.Text = "ID Number :"
        '
        'txtGy
        '
        Me.txtGy.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtGy.AutoSize = True
        Me.txtGy.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGy.ForeColor = System.Drawing.Color.Navy
        Me.txtGy.Location = New System.Drawing.Point(102, 70)
        Me.txtGy.Name = "txtGy"
        Me.txtGy.Size = New System.Drawing.Size(188, 18)
        Me.txtGy.TabIndex = 114
        Me.txtGy.Text = "____________________"
        Me.txtGy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOras
        '
        Me.txtOras.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtOras.AutoSize = True
        Me.txtOras.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOras.ForeColor = System.Drawing.Color.Navy
        Me.txtOras.Location = New System.Drawing.Point(102, 98)
        Me.txtOras.Name = "txtOras"
        Me.txtOras.Size = New System.Drawing.Size(188, 18)
        Me.txtOras.TabIndex = 115
        Me.txtOras.Text = "____________________"
        Me.txtOras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(3, 71)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 18)
        Me.Label12.TabIndex = 110
        Me.Label12.Text = "Grade/Year :"
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtName.AutoSize = True
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Navy
        Me.txtName.Location = New System.Drawing.Point(102, 42)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(188, 18)
        Me.txtName.TabIndex = 113
        Me.txtName.Text = "____________________"
        Me.txtName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(44, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 18)
        Me.Label10.TabIndex = 109
        Me.Label10.Text = "Name :"
        '
        'txtInOut
        '
        Me.txtInOut.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtInOut.AutoSize = True
        Me.txtInOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInOut.ForeColor = System.Drawing.Color.Black
        Me.txtInOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtInOut.Location = New System.Drawing.Point(51, 98)
        Me.txtInOut.Name = "txtInOut"
        Me.txtInOut.Size = New System.Drawing.Size(55, 18)
        Me.txtInOut.TabIndex = 111
        Me.txtInOut.Text = "Time :"
        '
        'SplitContainer8
        '
        Me.SplitContainer8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer8.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer8.Name = "SplitContainer8"
        Me.SplitContainer8.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer8.Panel1
        '
        Me.SplitContainer8.Panel1.Controls.Add(Me.Lstlist)
        '
        'SplitContainer8.Panel2
        '
        Me.SplitContainer8.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SplitContainer8.Panel2.Controls.Add(Me.txtCode)
        Me.SplitContainer8.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer8.Size = New System.Drawing.Size(329, 213)
        Me.SplitContainer8.SplitterDistance = 169
        Me.SplitContainer8.TabIndex = 0
        '
        'Lstlist
        '
        Me.Lstlist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lstlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lstlist.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lstlist.FullRowSelect = True
        Me.Lstlist.GridLines = True
        Me.Lstlist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.Lstlist.Location = New System.Drawing.Point(5, 6)
        Me.Lstlist.MultiSelect = False
        Me.Lstlist.Name = "Lstlist"
        Me.Lstlist.Size = New System.Drawing.Size(319, 160)
        Me.Lstlist.TabIndex = 77
        Me.Lstlist.UseCompatibleStateImageBehavior = False
        Me.Lstlist.View = System.Windows.Forms.View.Details
        '
        'txtCode
        '
        Me.txtCode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCode.BackColor = System.Drawing.Color.White
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(99, 11)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(221, 22)
        Me.txtCode.TabIndex = 114
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(1, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 18)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "Card Code :"
        '
        'SplitContainer9
        '
        Me.SplitContainer9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer9.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer9.Name = "SplitContainer9"
        Me.SplitContainer9.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer9.Panel1
        '
        Me.SplitContainer9.Panel1.Controls.Add(Me.SplitContainer10)
        '
        'SplitContainer9.Panel2
        '
        Me.SplitContainer9.Panel2.Controls.Add(Me.SplitContainer15)
        Me.SplitContainer9.Size = New System.Drawing.Size(742, 624)
        Me.SplitContainer9.SplitterDistance = 309
        Me.SplitContainer9.TabIndex = 1
        '
        'SplitContainer10
        '
        Me.SplitContainer10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer10.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer10.Name = "SplitContainer10"
        '
        'SplitContainer10.Panel1
        '
        Me.SplitContainer10.Panel1.Controls.Add(Me.SplitContainer11)
        '
        'SplitContainer10.Panel2
        '
        Me.SplitContainer10.Panel2.Controls.Add(Me.SplitContainer12)
        Me.SplitContainer10.Size = New System.Drawing.Size(742, 309)
        Me.SplitContainer10.SplitterDistance = 242
        Me.SplitContainer10.TabIndex = 0
        '
        'SplitContainer11
        '
        Me.SplitContainer11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer11.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer11.Name = "SplitContainer11"
        Me.SplitContainer11.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer11.Panel1
        '
        Me.SplitContainer11.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SplitContainer11.Panel1.Controls.Add(Me.imgF1)
        '
        'SplitContainer11.Panel2
        '
        Me.SplitContainer11.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SplitContainer11.Panel2.Controls.Add(Me.txtP1)
        Me.SplitContainer11.Panel2.Controls.Add(Me.Label28)
        Me.SplitContainer11.Panel2.Controls.Add(Me.txtF1)
        Me.SplitContainer11.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer11.Size = New System.Drawing.Size(240, 307)
        Me.SplitContainer11.SplitterDistance = 230
        Me.SplitContainer11.TabIndex = 0
        '
        'imgF1
        '
        Me.imgF1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgF1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.imgF1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgF1.Image = CType(resources.GetObject("imgF1.Image"), System.Drawing.Image)
        Me.imgF1.Location = New System.Drawing.Point(8, 9)
        Me.imgF1.Name = "imgF1"
        Me.imgF1.Size = New System.Drawing.Size(224, 211)
        Me.imgF1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgF1.TabIndex = 122
        Me.imgF1.TabStop = False
        '
        'txtP1
        '
        Me.txtP1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtP1.AutoSize = True
        Me.txtP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtP1.ForeColor = System.Drawing.Color.Navy
        Me.txtP1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtP1.Location = New System.Drawing.Point(81, 41)
        Me.txtP1.Name = "txtP1"
        Me.txtP1.Size = New System.Drawing.Size(152, 16)
        Me.txtP1.TabIndex = 107
        Me.txtP1.Text = "__________________"
        Me.txtP1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(5, 40)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(80, 18)
        Me.Label28.TabIndex = 106
        Me.Label28.Text = "Position :"
        '
        'txtF1
        '
        Me.txtF1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtF1.AutoSize = True
        Me.txtF1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtF1.ForeColor = System.Drawing.Color.Navy
        Me.txtF1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtF1.Location = New System.Drawing.Point(76, 15)
        Me.txtF1.Name = "txtF1"
        Me.txtF1.Size = New System.Drawing.Size(160, 16)
        Me.txtF1.TabIndex = 105
        Me.txtF1.Text = "___________________"
        Me.txtF1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(5, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 18)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "Fetcher :"
        '
        'SplitContainer12
        '
        Me.SplitContainer12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer12.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer12.Name = "SplitContainer12"
        '
        'SplitContainer12.Panel1
        '
        Me.SplitContainer12.Panel1.Controls.Add(Me.SplitContainer13)
        '
        'SplitContainer12.Panel2
        '
        Me.SplitContainer12.Panel2.Controls.Add(Me.SplitContainer14)
        Me.SplitContainer12.Size = New System.Drawing.Size(496, 309)
        Me.SplitContainer12.SplitterDistance = 245
        Me.SplitContainer12.TabIndex = 0
        '
        'SplitContainer13
        '
        Me.SplitContainer13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer13.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer13.Name = "SplitContainer13"
        Me.SplitContainer13.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer13.Panel1
        '
        Me.SplitContainer13.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SplitContainer13.Panel1.Controls.Add(Me.imgF2)
        '
        'SplitContainer13.Panel2
        '
        Me.SplitContainer13.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SplitContainer13.Panel2.Controls.Add(Me.txtP2)
        Me.SplitContainer13.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer13.Panel2.Controls.Add(Me.txtF2)
        Me.SplitContainer13.Panel2.Controls.Add(Me.Label20)
        Me.SplitContainer13.Size = New System.Drawing.Size(243, 307)
        Me.SplitContainer13.SplitterDistance = 230
        Me.SplitContainer13.TabIndex = 1
        '
        'imgF2
        '
        Me.imgF2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgF2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.imgF2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgF2.Image = CType(resources.GetObject("imgF2.Image"), System.Drawing.Image)
        Me.imgF2.Location = New System.Drawing.Point(8, 9)
        Me.imgF2.Name = "imgF2"
        Me.imgF2.Size = New System.Drawing.Size(227, 211)
        Me.imgF2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgF2.TabIndex = 122
        Me.imgF2.TabStop = False
        '
        'txtP2
        '
        Me.txtP2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtP2.AutoSize = True
        Me.txtP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtP2.ForeColor = System.Drawing.Color.Navy
        Me.txtP2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtP2.Location = New System.Drawing.Point(82, 41)
        Me.txtP2.Name = "txtP2"
        Me.txtP2.Size = New System.Drawing.Size(152, 16)
        Me.txtP2.TabIndex = 111
        Me.txtP2.Text = "__________________"
        Me.txtP2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(6, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 18)
        Me.Label8.TabIndex = 110
        Me.Label8.Text = "Position :"
        '
        'txtF2
        '
        Me.txtF2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtF2.AutoSize = True
        Me.txtF2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtF2.ForeColor = System.Drawing.Color.Navy
        Me.txtF2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtF2.Location = New System.Drawing.Point(77, 15)
        Me.txtF2.Name = "txtF2"
        Me.txtF2.Size = New System.Drawing.Size(160, 16)
        Me.txtF2.TabIndex = 109
        Me.txtF2.Text = "___________________"
        Me.txtF2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(6, 14)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 18)
        Me.Label20.TabIndex = 108
        Me.Label20.Text = "Fetcher :"
        '
        'SplitContainer14
        '
        Me.SplitContainer14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer14.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer14.Name = "SplitContainer14"
        Me.SplitContainer14.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer14.Panel1
        '
        Me.SplitContainer14.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SplitContainer14.Panel1.Controls.Add(Me.imgF3)
        '
        'SplitContainer14.Panel2
        '
        Me.SplitContainer14.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SplitContainer14.Panel2.Controls.Add(Me.txtP3)
        Me.SplitContainer14.Panel2.Controls.Add(Me.Label22)
        Me.SplitContainer14.Panel2.Controls.Add(Me.txtF3)
        Me.SplitContainer14.Panel2.Controls.Add(Me.Label24)
        Me.SplitContainer14.Size = New System.Drawing.Size(245, 307)
        Me.SplitContainer14.SplitterDistance = 230
        Me.SplitContainer14.TabIndex = 1
        '
        'imgF3
        '
        Me.imgF3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgF3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.imgF3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgF3.Image = CType(resources.GetObject("imgF3.Image"), System.Drawing.Image)
        Me.imgF3.Location = New System.Drawing.Point(8, 9)
        Me.imgF3.Name = "imgF3"
        Me.imgF3.Size = New System.Drawing.Size(229, 211)
        Me.imgF3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgF3.TabIndex = 122
        Me.imgF3.TabStop = False
        '
        'txtP3
        '
        Me.txtP3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtP3.AutoSize = True
        Me.txtP3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtP3.ForeColor = System.Drawing.Color.Navy
        Me.txtP3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtP3.Location = New System.Drawing.Point(83, 41)
        Me.txtP3.Name = "txtP3"
        Me.txtP3.Size = New System.Drawing.Size(152, 16)
        Me.txtP3.TabIndex = 111
        Me.txtP3.Text = "__________________"
        Me.txtP3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(7, 40)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 18)
        Me.Label22.TabIndex = 110
        Me.Label22.Text = "Position :"
        '
        'txtF3
        '
        Me.txtF3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtF3.AutoSize = True
        Me.txtF3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtF3.ForeColor = System.Drawing.Color.Navy
        Me.txtF3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtF3.Location = New System.Drawing.Point(78, 15)
        Me.txtF3.Name = "txtF3"
        Me.txtF3.Size = New System.Drawing.Size(160, 16)
        Me.txtF3.TabIndex = 109
        Me.txtF3.Text = "___________________"
        Me.txtF3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(7, 14)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(75, 18)
        Me.Label24.TabIndex = 108
        Me.Label24.Text = "Fetcher :"
        '
        'SplitContainer15
        '
        Me.SplitContainer15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer15.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer15.Name = "SplitContainer15"
        '
        'SplitContainer15.Panel1
        '
        Me.SplitContainer15.Panel1.Controls.Add(Me.SplitContainer16)
        '
        'SplitContainer15.Panel2
        '
        Me.SplitContainer15.Panel2.Controls.Add(Me.SplitContainer17)
        Me.SplitContainer15.Size = New System.Drawing.Size(742, 311)
        Me.SplitContainer15.SplitterDistance = 242
        Me.SplitContainer15.TabIndex = 0
        '
        'SplitContainer16
        '
        Me.SplitContainer16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer16.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer16.Name = "SplitContainer16"
        Me.SplitContainer16.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer16.Panel1
        '
        Me.SplitContainer16.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SplitContainer16.Panel1.Controls.Add(Me.imgF4)
        '
        'SplitContainer16.Panel2
        '
        Me.SplitContainer16.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SplitContainer16.Panel2.Controls.Add(Me.txtP4)
        Me.SplitContainer16.Panel2.Controls.Add(Me.Label26)
        Me.SplitContainer16.Panel2.Controls.Add(Me.txtF4)
        Me.SplitContainer16.Panel2.Controls.Add(Me.Label30)
        Me.SplitContainer16.Size = New System.Drawing.Size(240, 309)
        Me.SplitContainer16.SplitterDistance = 231
        Me.SplitContainer16.TabIndex = 1
        '
        'imgF4
        '
        Me.imgF4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgF4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.imgF4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgF4.Image = CType(resources.GetObject("imgF4.Image"), System.Drawing.Image)
        Me.imgF4.Location = New System.Drawing.Point(8, 9)
        Me.imgF4.Name = "imgF4"
        Me.imgF4.Size = New System.Drawing.Size(224, 212)
        Me.imgF4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgF4.TabIndex = 122
        Me.imgF4.TabStop = False
        '
        'txtP4
        '
        Me.txtP4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtP4.AutoSize = True
        Me.txtP4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtP4.ForeColor = System.Drawing.Color.Navy
        Me.txtP4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtP4.Location = New System.Drawing.Point(81, 42)
        Me.txtP4.Name = "txtP4"
        Me.txtP4.Size = New System.Drawing.Size(152, 16)
        Me.txtP4.TabIndex = 111
        Me.txtP4.Text = "__________________"
        Me.txtP4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(5, 41)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(80, 18)
        Me.Label26.TabIndex = 110
        Me.Label26.Text = "Position :"
        '
        'txtF4
        '
        Me.txtF4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtF4.AutoSize = True
        Me.txtF4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtF4.ForeColor = System.Drawing.Color.Navy
        Me.txtF4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtF4.Location = New System.Drawing.Point(76, 16)
        Me.txtF4.Name = "txtF4"
        Me.txtF4.Size = New System.Drawing.Size(160, 16)
        Me.txtF4.TabIndex = 109
        Me.txtF4.Text = "___________________"
        Me.txtF4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(5, 15)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(75, 18)
        Me.Label30.TabIndex = 108
        Me.Label30.Text = "Fetcher :"
        '
        'SplitContainer17
        '
        Me.SplitContainer17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer17.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer17.Name = "SplitContainer17"
        '
        'SplitContainer17.Panel1
        '
        Me.SplitContainer17.Panel1.Controls.Add(Me.SplitContainer18)
        '
        'SplitContainer17.Panel2
        '
        Me.SplitContainer17.Panel2.Controls.Add(Me.SplitContainer19)
        Me.SplitContainer17.Size = New System.Drawing.Size(496, 311)
        Me.SplitContainer17.SplitterDistance = 245
        Me.SplitContainer17.TabIndex = 0
        '
        'SplitContainer18
        '
        Me.SplitContainer18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer18.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer18.Name = "SplitContainer18"
        Me.SplitContainer18.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer18.Panel1
        '
        Me.SplitContainer18.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SplitContainer18.Panel1.Controls.Add(Me.imgF5)
        '
        'SplitContainer18.Panel2
        '
        Me.SplitContainer18.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SplitContainer18.Panel2.Controls.Add(Me.txtP5)
        Me.SplitContainer18.Panel2.Controls.Add(Me.Label32)
        Me.SplitContainer18.Panel2.Controls.Add(Me.txtF5)
        Me.SplitContainer18.Panel2.Controls.Add(Me.Label34)
        Me.SplitContainer18.Size = New System.Drawing.Size(243, 309)
        Me.SplitContainer18.SplitterDistance = 231
        Me.SplitContainer18.TabIndex = 1
        '
        'imgF5
        '
        Me.imgF5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgF5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.imgF5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgF5.Image = CType(resources.GetObject("imgF5.Image"), System.Drawing.Image)
        Me.imgF5.Location = New System.Drawing.Point(8, 9)
        Me.imgF5.Name = "imgF5"
        Me.imgF5.Size = New System.Drawing.Size(227, 212)
        Me.imgF5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgF5.TabIndex = 122
        Me.imgF5.TabStop = False
        '
        'txtP5
        '
        Me.txtP5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtP5.AutoSize = True
        Me.txtP5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtP5.ForeColor = System.Drawing.Color.Navy
        Me.txtP5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtP5.Location = New System.Drawing.Point(82, 42)
        Me.txtP5.Name = "txtP5"
        Me.txtP5.Size = New System.Drawing.Size(152, 16)
        Me.txtP5.TabIndex = 111
        Me.txtP5.Text = "__________________"
        Me.txtP5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(6, 41)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(80, 18)
        Me.Label32.TabIndex = 110
        Me.Label32.Text = "Position :"
        '
        'txtF5
        '
        Me.txtF5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtF5.AutoSize = True
        Me.txtF5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtF5.ForeColor = System.Drawing.Color.Navy
        Me.txtF5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtF5.Location = New System.Drawing.Point(77, 16)
        Me.txtF5.Name = "txtF5"
        Me.txtF5.Size = New System.Drawing.Size(160, 16)
        Me.txtF5.TabIndex = 109
        Me.txtF5.Text = "___________________"
        Me.txtF5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(6, 15)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(75, 18)
        Me.Label34.TabIndex = 108
        Me.Label34.Text = "Fetcher :"
        '
        'SplitContainer19
        '
        Me.SplitContainer19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer19.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer19.Name = "SplitContainer19"
        Me.SplitContainer19.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer19.Panel1
        '
        Me.SplitContainer19.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SplitContainer19.Panel1.Controls.Add(Me.imgF6)
        '
        'SplitContainer19.Panel2
        '
        Me.SplitContainer19.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SplitContainer19.Panel2.Controls.Add(Me.txtP6)
        Me.SplitContainer19.Panel2.Controls.Add(Me.Label36)
        Me.SplitContainer19.Panel2.Controls.Add(Me.txtF6)
        Me.SplitContainer19.Panel2.Controls.Add(Me.Label38)
        Me.SplitContainer19.Size = New System.Drawing.Size(245, 309)
        Me.SplitContainer19.SplitterDistance = 231
        Me.SplitContainer19.TabIndex = 1
        '
        'imgF6
        '
        Me.imgF6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgF6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.imgF6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgF6.Image = CType(resources.GetObject("imgF6.Image"), System.Drawing.Image)
        Me.imgF6.Location = New System.Drawing.Point(8, 9)
        Me.imgF6.Name = "imgF6"
        Me.imgF6.Size = New System.Drawing.Size(229, 212)
        Me.imgF6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgF6.TabIndex = 122
        Me.imgF6.TabStop = False
        '
        'txtP6
        '
        Me.txtP6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtP6.AutoSize = True
        Me.txtP6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtP6.ForeColor = System.Drawing.Color.Navy
        Me.txtP6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtP6.Location = New System.Drawing.Point(83, 42)
        Me.txtP6.Name = "txtP6"
        Me.txtP6.Size = New System.Drawing.Size(152, 16)
        Me.txtP6.TabIndex = 111
        Me.txtP6.Text = "__________________"
        Me.txtP6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label36
        '
        Me.Label36.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(7, 41)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(80, 18)
        Me.Label36.TabIndex = 110
        Me.Label36.Text = "Position :"
        '
        'txtF6
        '
        Me.txtF6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtF6.AutoSize = True
        Me.txtF6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtF6.ForeColor = System.Drawing.Color.Navy
        Me.txtF6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtF6.Location = New System.Drawing.Point(78, 16)
        Me.txtF6.Name = "txtF6"
        Me.txtF6.Size = New System.Drawing.Size(160, 16)
        Me.txtF6.TabIndex = 109
        Me.txtF6.Text = "___________________"
        Me.txtF6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label38
        '
        Me.Label38.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(7, 15)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(75, 18)
        Me.Label38.TabIndex = 108
        Me.Label38.Text = "Fetcher :"
        '
        'SplitContainer20
        '
        Me.SplitContainer20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer20.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer20.Name = "SplitContainer20"
        '
        'SplitContainer20.Panel1
        '
        Me.SplitContainer20.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SplitContainer20.Panel1.Controls.Add(Me.txtStat)
        Me.SplitContainer20.Panel1.Controls.Add(Me.Label3)
        '
        'SplitContainer20.Panel2
        '
        Me.SplitContainer20.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SplitContainer20.Panel2Collapsed = True
        Me.SplitContainer20.Size = New System.Drawing.Size(1077, 31)
        Me.SplitContainer20.SplitterDistance = 1047
        Me.SplitContainer20.TabIndex = 0
        '
        'txtStat
        '
        Me.txtStat.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtStat.AutoSize = True
        Me.txtStat.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat.ForeColor = System.Drawing.Color.Navy
        Me.txtStat.Location = New System.Drawing.Point(93, 4)
        Me.txtStat.Name = "txtStat"
        Me.txtStat.Size = New System.Drawing.Size(34, 23)
        Me.txtStat.TabIndex = 116
        Me.txtStat.Text = "---"
        Me.txtStat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(9, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 18)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "    Status :"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1077, 780)
        Me.Controls.Add(Me.SplitContainer4)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.Dev1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dev2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.ResumeLayout(False)
        Me.SplitContainer6.Panel1.ResumeLayout(False)
        Me.SplitContainer6.Panel2.ResumeLayout(False)
        Me.SplitContainer6.ResumeLayout(False)
        Me.SplitContainer7.Panel1.ResumeLayout(False)
        Me.SplitContainer7.Panel2.ResumeLayout(False)
        Me.SplitContainer7.ResumeLayout(False)
        CType(Me.imgStud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer8.Panel1.ResumeLayout(False)
        Me.SplitContainer8.Panel2.ResumeLayout(False)
        Me.SplitContainer8.Panel2.PerformLayout()
        Me.SplitContainer8.ResumeLayout(False)
        Me.SplitContainer9.Panel1.ResumeLayout(False)
        Me.SplitContainer9.Panel2.ResumeLayout(False)
        Me.SplitContainer9.ResumeLayout(False)
        Me.SplitContainer10.Panel1.ResumeLayout(False)
        Me.SplitContainer10.Panel2.ResumeLayout(False)
        Me.SplitContainer10.ResumeLayout(False)
        Me.SplitContainer11.Panel1.ResumeLayout(False)
        Me.SplitContainer11.Panel2.ResumeLayout(False)
        Me.SplitContainer11.Panel2.PerformLayout()
        Me.SplitContainer11.ResumeLayout(False)
        CType(Me.imgF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer12.Panel1.ResumeLayout(False)
        Me.SplitContainer12.Panel2.ResumeLayout(False)
        Me.SplitContainer12.ResumeLayout(False)
        Me.SplitContainer13.Panel1.ResumeLayout(False)
        Me.SplitContainer13.Panel2.ResumeLayout(False)
        Me.SplitContainer13.Panel2.PerformLayout()
        Me.SplitContainer13.ResumeLayout(False)
        CType(Me.imgF2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer14.Panel1.ResumeLayout(False)
        Me.SplitContainer14.Panel2.ResumeLayout(False)
        Me.SplitContainer14.Panel2.PerformLayout()
        Me.SplitContainer14.ResumeLayout(False)
        CType(Me.imgF3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer15.Panel1.ResumeLayout(False)
        Me.SplitContainer15.Panel2.ResumeLayout(False)
        Me.SplitContainer15.ResumeLayout(False)
        Me.SplitContainer16.Panel1.ResumeLayout(False)
        Me.SplitContainer16.Panel2.ResumeLayout(False)
        Me.SplitContainer16.Panel2.PerformLayout()
        Me.SplitContainer16.ResumeLayout(False)
        CType(Me.imgF4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer17.Panel1.ResumeLayout(False)
        Me.SplitContainer17.Panel2.ResumeLayout(False)
        Me.SplitContainer17.ResumeLayout(False)
        Me.SplitContainer18.Panel1.ResumeLayout(False)
        Me.SplitContainer18.Panel2.ResumeLayout(False)
        Me.SplitContainer18.Panel2.PerformLayout()
        Me.SplitContainer18.ResumeLayout(False)
        CType(Me.imgF5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer19.Panel1.ResumeLayout(False)
        Me.SplitContainer19.Panel2.ResumeLayout(False)
        Me.SplitContainer19.Panel2.PerformLayout()
        Me.SplitContainer19.ResumeLayout(False)
        CType(Me.imgF6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer20.Panel1.ResumeLayout(False)
        Me.SplitContainer20.Panel1.PerformLayout()
        Me.SplitContainer20.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtTime As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtDate As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tmrTime As System.Windows.Forms.Timer
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtDesig As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtSystemUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtDbStat As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtDev1Stat As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel9 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtDev2Stat As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Dev1 As Axzkemkeeper.AxCZKEM
    Friend WithEvents Dev2 As Axzkemkeeper.AxCZKEM
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtCtrlStat As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtRuning As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tmrRead As System.Windows.Forms.Timer
    Friend WithEvents tmrClearStud As System.Windows.Forms.Timer
    Friend WithEvents tmrClearFetch As System.Windows.Forms.Timer
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer6 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer7 As System.Windows.Forms.SplitContainer
    Friend WithEvents imgStud As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtIDno As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtGy As System.Windows.Forms.Label
    Friend WithEvents txtOras As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtInOut As System.Windows.Forms.Label
    Friend WithEvents SplitContainer8 As System.Windows.Forms.SplitContainer
    Friend WithEvents Lstlist As System.Windows.Forms.ListView
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer9 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer10 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer11 As System.Windows.Forms.SplitContainer
    Friend WithEvents imgF1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtP1 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtF1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer12 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer13 As System.Windows.Forms.SplitContainer
    Friend WithEvents imgF2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtP2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtF2 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer14 As System.Windows.Forms.SplitContainer
    Friend WithEvents imgF3 As System.Windows.Forms.PictureBox
    Friend WithEvents txtP3 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtF3 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer15 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer16 As System.Windows.Forms.SplitContainer
    Friend WithEvents imgF4 As System.Windows.Forms.PictureBox
    Friend WithEvents txtP4 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtF4 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer17 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer18 As System.Windows.Forms.SplitContainer
    Friend WithEvents imgF5 As System.Windows.Forms.PictureBox
    Friend WithEvents txtP5 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtF5 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer19 As System.Windows.Forms.SplitContainer
    Friend WithEvents imgF6 As System.Windows.Forms.PictureBox
    Friend WithEvents txtP6 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtF6 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer20 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtStat As System.Windows.Forms.Label
End Class
