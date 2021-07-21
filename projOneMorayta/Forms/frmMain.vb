Imports ADODB
Imports System
Imports Microsoft.VisualBasic

Public Class frmMain

    Dim dev1conrol As New UserControl
    Public rema As String
    Public pangalan As String
    Public IdNo As String
    Public extpath As String
    Public CopPic As String
    Public CopPicExt As String

    Public OrasIn As String
    Public OrasOut As String

    Public dtExpired As String

    Public tmin As String
    'Public Ent As String
    Public inOut As String

    Public Activ As Boolean

    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        If MsgBox("Are you sure do you want to exit?    ", vbYesNo + vbQuestion + vbDefaultButton2, "Exit") = vbYes Then
            devDisCon()
            CAM_CLOSE()
            Application.Exit()
        End If
    End Sub
    Function unlock()
        If Access = "Login" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Return Then
            If Access = vbNullString Then
                Dim a As New frmLogin
                a.ShowDialog()
                Exit Sub
            End If
        End If
    End Sub

    Sub StartSystem()
        Access = vbNullString
        devDisCon()
        CAM_CLOSE()

        'BARRIER
        viewBarrierSet()
        trigerOff()

        'Reader
        tbldevcon()
        devcon1()
        devcon2()
        devcon3()
        devcon4()

        'Server
        setcon()
        If subSQl() = True Then
            If frmLogo.chk = False Then
                Pic2Sa.Image = Logo_Image()
            End If
        End If

        'msAccessDB
        ConPath()
        MachID(My.Settings.DEV1_IP)
        MachID2(My.Settings.DEV2_IP)

        'Camera
        camInfo()
        camEntrance()
        camExt()

        lock()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Function psb() As Boolean
        If My.Settings.PSb_Set = vbNullString Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub head()
        '  LstTimeIn.Columns.Add("AC no", 150, HorizontalAlignment.Left)
        '  LstTimeIn.Columns.Add("Name", 410, HorizontalAlignment.Left)
        '  LstTimeIn.Columns.Add("TimeIn", 160, HorizontalAlignment.Left)
    End Sub

    Sub fill()
        If StatDB.Text = "Disconnected" Then
            'MsgBox("Please connect to server!    ", vbExclamation, "Server")
            'frmConDB.ShowDialog()
            Exit Sub
        End If
        'LstTimeIn.Clear()
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSql.Execute("select * from tblTimeIn")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                ' LstTimeIn.Refresh()
                Dim viewlst As New ListViewItem
                ' viewlst = LstTimeIn.Items.Add(rs("Idnumber").Value, lup)
                viewlst.SubItems.Add(rs("Name").Value)
                viewlst.SubItems.Add(rs("TimeIn").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub fillout()
        If StatDB.Text = "Disconnected" Then
            'MsgBox("Please connect to server!    ", vbExclamation, "Server")
            'frmConDB.ShowDialog()
            Exit Sub
        End If
        ' LstTimeIn.Clear()
        head()
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSql.Execute("select * from tblTimeIn order by IdLog desc")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                '  LstTimeIn.Refresh()
                Dim viewlst As New ListViewItem
                ' viewlst = LstTimeIn.Items.Add(rs("Idnumber").Value, lup)
                viewlst.SubItems.Add(rs("Name").Value)
                viewlst.SubItems.Add(rs("TimeIn").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub filllist()
        If StatDB.Text = "Disconnected" Then
            Exit Sub
        End If
        On Error Resume Next

        'LstTimeIn.Clear()
        ' LstTimeIn.Clear()
        head()
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSql.Execute("select * from tblTimeIn order by TimeIn desc")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                Dim CDin As String = Format(CDate(rs("TimeIn").Value), "HH:mm:ss tt")
                '  LstTimeIn.Refresh()
                Dim viewlst As New ListViewItem
                ' viewlst = LstTimeIn.Items.Add(rs("Idnumber").Value, lup)
                viewlst.SubItems.Add(rs("Name").Value)
                viewlst.SubItems.Add(CDin)
                rs.MoveNext()
            Next
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        txtTimeDate.Text = Format(Now, "long date") & "    " & Format(Now, "HH:mm:ss tt")
    End Sub

    Private Sub ToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        devDisCon()
        StatDev1.Text = "Disconnected"
        StatDev1.ForeColor = Color.Maroon

        StatDev2.Text = "Disconnected"
        StatDev2.ForeColor = Color.Maroon

        StatDev3.Text = "Disconnected"
        StatDev3.ForeColor = Color.Maroon

        StatDev4.Text = "Disconnected"
        StatDev4.ForeColor = Color.Maroon
        frmConDev.ShowDialog()
    End Sub

    Private Sub CameraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CameraToolStripMenuItem.Click
        frmCamSettings.ShowDialog()
    End Sub
    Sub MachID(ByVal ip As String)
        Dim rs = New Recordset
        Try
            rs = New Recordset
            rs.Open("select * from Machines where Ip = '" & ip & "'", PathConn, 1, 2)
            If rs.EOF = False Then
                devNo = rs("MachineNumber").Value
            Else
                Exit Sub
            End If
        Catch ex As Exception
            ' MsgBox(ex.Message, vbCritical, "Access Control System")
        End Try
    End Sub
    Sub MachID2(ByVal ip As String)
        Dim rs = New Recordset
        Try
            rs = New Recordset
            rs.Open("select * from Machines where Ip = '" & ip & "'", PathConn, 1, 2)
            If rs.EOF = False Then
                devNo2 = rs("MachineNumber").Value
            Else
                Exit Sub
            End If
        Catch ex As Exception
            ' MsgBox(ex.Message, vbCritical, "Access Control System")
        End Try
    End Sub
    Sub serverping()
        'ConPath()
        'setcon()
        If PingMe(Ip) = True Then
            StatDB.Text = "Connected"
            StatDB.ForeColor = Color.Blue
        Else
            StatDB.Text = "Disconnected"
            StatDB.ForeColor = Color.Maroon
            tmrPingServer.Enabled = False
        End If
    End Sub
    Sub devPing1()
        'Dev1.Disconnect()
        'tmrPingDev1.Enabled = False

        'devcon1()
        If PingMe(My.Settings.DEV1_IP) = False Then
            Do While PingMe(My.Settings.DEV1_IP) = False
                StatDev1.Text = "Disconnected"
                StatDev1.ForeColor = Color.Maroon
                ' Dev1.EndInit()
                'Dev1.Disconnect()
                'tmrPingDev1.Enabled = False
                Exit Sub
            Loop
        Else
            'devcon1()
            StatDev1.Text = "Connected"
            StatDev1.ForeColor = Color.Blue
            ' Dev1.BeginInit()
            ' Dev1.BASE64 = 0
            ' Dev1.RegEvent(devNo, 32767)
        End If
    End Sub
    Sub devping2()

        If PingMe(My.Settings.DEV2_IP) = False Then
            Do While PingMe(My.Settings.DEV2_IP) = False
                StatDev2.Text = "Disconnected"
                StatDev2.ForeColor = Color.Maroon
                Dev2.EndInit()
                'Dev2.Disconnect()
                'tmrPingDev2.Enabled = False
                Exit Sub
            Loop
        Else
            StatDev2.Text = "Connected"
            StatDev2.ForeColor = Color.Blue
            Dev2.BeginInit()
            Dev2.BASE64 = 0
            Dev2.RegEvent(devNo2, 32767)
        End If

    End Sub

    Sub remIn(ByVal realTmr As String)
        On Error Resume Next
        realTmr = Format(CDate(realTmr), "HH:mm:ss")
        'Dim CHLin As String = Format(CDate(My.Settings.LR_CHLin), "HH:mm:ss")
        'Dim CHLout As String = Format(CDate(My.Settings.LR_CHLout), "HH:mm:ss")
        'Dim CHDin As String = Format(CDate(My.Settings.LR_CHDin), "HH:mm:ss")
        'Dim CHDout As String = Format(CDate(My.Settings.LR_CHDout), "HH:mm:ss")
        'Dim CHin As String = Format(CDate(My.Settings.LR_CHin), "HH:mm:ss tt")
        'Dim CDin As String = Format(CDate(My.Settings.LR_CDin), "HH:mm:ss tt")
        'If realTmr >= CHLin And realTmr < CHLout Then
        'rema = "1 Hour Late"
        'lblRealTime.Text = CHin
        'Else
        ' rema = "On time"
        'End If
        'If realTmr >= CHDin And realTmr < CHDout Then
        'rema = "Half Day"
        ' lblRealTime.Text = CDin
        'ElseIf realTmr > CHDout Then
        'rema = "Over Late"
        'End If
    End Sub

    Sub entInfo(ByVal id As String)
        If subSQl() = False Then Exit Sub
        Try
            Dim rs = New Recordset
            Dim petsa As String
            petsa = Format(Now, "yyyy-MM-dd HH:mm:ss")

            rs = New Recordset
            rs = conSql.Execute("select * from tblemp where ACno = '" & id & "'")
            If rs.EOF = False Then
                lblIdNum.Text = rs("IDnumber").Value
                lblName.Text = rs("Name").Value
                lblPosition.Text = rs("Title").Value
                lblGender.Text = rs("Gender").Value
                EmpPic.Image = Get_PicEmp(id)
                lblRealTime.Text = petsa
            Else
                lblIdNum.Text = id
                lblName.Text = "Not Registered"
                lblPosition.Text = "Not Registered"
                lblGender.Text = "Not Registered"
                EmpPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                lblRealTime.Text = petsa
            End If
        Catch ex As Exception
            txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub entInfo2(ByVal id As String)
        If subSQl() = False Then Exit Sub
        Try
            Dim rs = New Recordset
            Dim petsa As String
            petsa = Format(Now, "yyyy-MM-dd HH:mm:ss")

            rs = New Recordset
            rs = conSql.Execute("select * from tblemp where ACno = '" & id & "'")
            If rs.EOF = False Then
                txtIdNo.Text = rs("IDnumber").Value
                txtName.Text = rs("Name").Value
                txtPosi.Text = rs("Title").Value
                txtGender.Text = rs("Gender").Value
                EmpPic2.Image = Get_PicEmp(id)
                txtInOutTime.Text = petsa
            Else
                txtIdNo.Text = id
                txtName.Text = "Not Registered"
                txtPosi.Text = "Not Registered"
                txtGender.Text = "Not Registered"
                EmpPic2.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                txtInOutTime.Text = petsa
            End If
        Catch ex As Exception
            txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub inCapture()

        Dim orgCAp As String
        CopPic = vbNullString
        CamEntry.JPEGCapturePicture(My.Settings.CAM_ChannelCap1, 0, 0, Application.StartupPath & "\EntCapture")
        orgCAp = Dir(Application.StartupPath & "\EntCapture\JPEGCapture\*.jpeg")
        CopPic = (Application.StartupPath & "\EntCapture\JPEGCapture\" & orgCAp & "")

    End Sub

    Sub outCapture()
        Dim orgCAp As String
        CopPicExt = vbNullString
        'Dim CopPicExt As String
        CamExit.JPEGCapturePicture(My.Settings.CAM_ChannelCap2, 0, 0, Application.StartupPath & "\EntCapture")
        orgCAp = Dir(Application.StartupPath & "\EntCapture\JPEGCapture\*.jpeg")
        CopPicExt = (Application.StartupPath & "\EntCapture\JPEGCapture\" & orgCAp & "")
        'CapPicOut(CopPic)
        'extpath = StrPicFile
    End Sub

    Sub realInSave()
        'If subSQl() = False Then Exit Sub
        Try
            Dim rs = New Recordset

            rs = New Recordset
            rs.Open("select * from tbltimein where 1=0", conSql, 1, 2)

            rs.AddNew()
            rs("IDnumber").Value = lblIdNum.Text
            rs("Name").Value = lblName.Text
            rs("TimeIn").Value = Now

            Try
                Dim strem As New Stream
                strem.Type = StreamTypeEnum.adTypeBinary
                strem.Open()
                strem.LoadFromFile(CopPic)
                rs("PicPath").Value = strem.Read
                rs.Update()
            Catch ex As Exception
                rs = New Recordset
                rs.Open("select * from tbltimein where 1=0", conSql, 1, 2)
                rs.AddNew()
                rs("IDnumber").Value = lblIdNum.Text
                rs("Name").Value = lblName.Text
                rs("TimeIn").Value = Now
                rs.Update()
            End Try
        Catch ex As Exception
            txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub realInSave2()
        'If subSQl() = False Then Exit Sub
        Try
            Dim rs = New Recordset

            rs = New Recordset
            rs.Open("select * from tbltimein where 1=0", conSql, 1, 2)

            rs.AddNew()
            rs("IDnumber").Value = txtIdNo.Text
            rs("Name").Value = txtName.Text
            rs("TimeIn").Value = Now

            Try
                Dim strem As New Stream
                strem.Type = StreamTypeEnum.adTypeBinary
                strem.Open()
                strem.LoadFromFile(CopPic)
                rs("PicPath").Value = strem.Read
                rs.Update()
            Catch ex As Exception
                rs = New Recordset
                rs.Open("select * from tbltimein where 1=0", conSql, 1, 2)
                rs.AddNew()
                rs("IDnumber").Value = txtIdNo.Text
                rs("Name").Value = txtName.Text
                rs("TimeIn").Value = Now
                rs.Update()
            End Try
        Catch ex As Exception
            txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Function OutVer(ByVal petsa As String, idNum As String) As Boolean
        If subSQl() = False Then Return False

        Try
            Dim rs = New Recordset
            Dim qpetsa As String = Format(CDate(petsa), "yyyy-MM-dd")
            rs = New Recordset
            rs = conSql.Execute("select * from tbltimein where IDnumber = '" & idNum & "'")
            If rs.EOF = True Then
                Dim rs2 As New Recordset
                rs2 = conSql.Execute("select * from tblinout where TimeOut like '" & qpetsa & "%' order by TimeOut desc")
                If rs2.EOF = False Then
                    OrasOut = vbNullString
                    OrasOut = rs2("TimeOut").Value
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If

        Catch ex As Exception
            txtSystemErr.Text = ex.Message
            Return False
        End Try
    End Function

    Function InVer() As Boolean
        If subSQl() = False Then Return False
        Dim rs = New Recordset
        rs = New Recordset
        rs = conSql.Execute("select * from tbltimein where IDnumber = '" & lblIdNum.Text & "'")
        If rs.EOF = False Then
            OrasIn = vbNullString
            OrasIn = rs("TimeIn").Value
            Return True
        Else
            Return False
        End If
    End Function

    Sub realOutSave(idNum As String)
        If subSQl() = False Then Exit Sub

        Try
            Dim rs = New Recordset
            Dim rs2 As New Recordset

            rs = New Recordset
            rs = conSql.Execute("select * from tbltimein where IDnumber = '" & idNum & "'")
            If rs.EOF = False Then
                rs2 = New Recordset
                rs2.Open("select * from tblinout where 1=0", conSql, 1, 2)
                rs2.AddNew()
                rs2("IDnumber").Value = lblIdNum.Text
                rs2("Name").Value = lblName.Text
                rs2("TimeIn").Value = rs("TimeIn").Value
                rs2("TimeOut").Value = Now
                rs2("PicEnt").Value = rs("PicPath").Value
                Try
                    Dim strem As New Stream
                    strem.Type = StreamTypeEnum.adTypeBinary
                    strem.Open()
                    strem.LoadFromFile(CopPicExt)
                    rs2("PicExt").Value = strem.Read
                    rs2.Update()
                Catch
                    rs2 = New Recordset
                    rs2.Open("select * from tblinout where 1=0", conSql, 1, 2)
                    rs2.AddNew()
                    rs2("IDnumber").Value = lblIdNum.Text
                    rs2("Name").Value = lblName.Text
                    rs2("TimeIn").Value = rs("TimeIn").Value
                    rs2("TimeOut").Value = Now
                    rs2.Update()
                End Try
            Else
                rs2 = New Recordset
                rs2.Open("select * from tblinout where 1=0", conSql, 1, 2)
                rs2.AddNew()
                rs2("IDnumber").Value = lblIdNum.Text
                rs2("Name").Value = lblName.Text
                rs2("TimeIn").Value = Now
                rs2("TimeOut").Value = Now
                Try
                    Dim strem As New Stream
                    strem.Type = StreamTypeEnum.adTypeBinary
                    strem.Open()
                    strem.LoadFromFile(CopPicExt)
                    rs2("PicExt").Value = strem.Read
                    rs2.Update()
                Catch
                    rs2 = New Recordset
                    rs2.Open("select * from tblinout where 1=0", conSql, 1, 2)
                    rs2.AddNew()
                    rs2("IDnumber").Value = lblIdNum.Text
                    rs2("Name").Value = lblName.Text
                    rs2("TimeIn").Value = Now
                    rs2("TimeOut").Value = Now
                    rs2.Update()
                End Try
            End If

        Catch ex As Exception
            'SystemStat.Text = ex.Message
        End Try
    End Sub

    Sub realOutSave2(idNum As String)
        If subSQl() = False Then Exit Sub

        'On Error Resume Next
        Try
            Dim rs = New Recordset
            Dim rs2 As New Recordset

            rs = New Recordset
            rs = conSql.Execute("select * from tbltimein where IDnumber = '" & idNum & "'")
            If rs.EOF = False Then
                rs2 = New Recordset
                rs2.Open("select * from tblinout where 1=0", conSql, 1, 2)
                rs2.AddNew()
                rs2("IDnumber").Value = txtIdNo.Text
                rs2("Name").Value = txtName.Text
                rs2("TimeIn").Value = rs("TimeIn").Value
                rs2("TimeOut").Value = Now
                rs2("PicEnt").Value = rs("PicPath").Value
                Try
                    Dim strem As New Stream
                    strem.Type = StreamTypeEnum.adTypeBinary
                    strem.Open()
                    strem.LoadFromFile(CopPicExt)
                    rs2("PicExt").Value = strem.Read
                    rs2.Update()
                Catch
                    rs2 = New Recordset
                    rs2.Open("select * from tblinout where 1=0", conSql, 1, 2)
                    rs2.AddNew()
                    rs2("IDnumber").Value = txtIdNo.Text
                    rs2("Name").Value = txtName.Text
                    rs2("TimeIn").Value = rs("TimeIn").Value
                    rs2("TimeOut").Value = Now
                    rs2.Update()
                End Try
            Else
                rs2 = New Recordset
                rs2.Open("select * from tblinout where 1=0", conSql, 1, 2)
                rs2.AddNew()
                rs2("IDnumber").Value = txtIdNo.Text
                rs2("Name").Value = txtName.Text
                rs2("TimeIn").Value = Now
                rs2("TimeOut").Value = Now
                Try
                    Dim strem As New Stream
                    strem.Type = StreamTypeEnum.adTypeBinary
                    strem.Open()
                    strem.LoadFromFile(CopPicExt)
                    rs2("PicExt").Value = strem.Read
                    rs2.Update()
                Catch
                    rs2 = New Recordset
                    rs2.Open("select * from tblinout where 1=0", conSql, 1, 2)
                    rs2.AddNew()
                    rs2("IDnumber").Value = txtIdNo.Text
                    rs2("Name").Value = txtName.Text
                    rs2("TimeIn").Value = Now
                    rs2("TimeOut").Value = Now
                    rs2.Update()
                End Try
            End If

        Catch ex As Exception
            txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub delInLog(idnum As String)
        If subSQl() = False Then Exit Sub
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSql.Execute("Delete from tbltimeIn where IDnumber = '" & idnum & "'")
    End Sub

    Sub getIDlog()
        If subSQl() = False Then Exit Sub

        Try
            Dim rs = New Recordset
            rs = New Recordset
            rs = conSql.Execute("select * from tbltimein order by idlog desc")
            idLog = rs("idlog").Value.ToString
        Catch ex As Exception
            txtSystemErr.Text = ex.Message
        End Try
    End Sub
    Sub getIDlogOut()
        If subSQl() = False Then Exit Sub
        Dim rs = New Recordset
        rs = New Recordset
        rs = conSql.Execute("select * from tblinout order by InOutID desc")
        idLog2 = rs("InOutID").Value
    End Sub

    Private Sub tmrClear_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrClear.Tick

        lblIdNum.Text = "________"
        lblName.Text = "________"
        lblPosition.Text = "________"
        lblGender.Text = "________"
        EmpPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
        lblRealTime.Text = "________"

        EntCap.Visible = False
        tmrClear.Enabled = False
    End Sub

    Private Sub tmrPing3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPingServer.Tick

    End Sub

    Private Sub tmrPingDev1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPingDev1.Tick
        devPing1()
    End Sub

    Private Sub tmrPingDev2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPingDev2.Tick
        devping2()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        frmLogin.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        logout()
        lock()
        If txtAdmin.Text = "fernan" Then
            Exit Sub
        End If

        txtAdmin.Text = vbNullString
        Access = vbNullString

    End Sub

    Private Sub AdministratorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministratorToolStripMenuItem.Click
        frmAdminAcc.ShowDialog()
    End Sub

    Private Sub MySQLConnectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MySQLConnectionToolStripMenuItem.Click
        frmConDB.ShowDialog()
    End Sub

    Private Sub MSAccessConnectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSAccessConnectionToolStripMenuItem.Click
        frmDBPathCon.ShowDialog()
    End Sub

    Function ExpDt(ByVal Ac As String) As Boolean
        Dim rs As New Recordset
        Dim Petsa As String = Format(Now, "yyyy-MM-dd")
        Try
            rs = conSql.Execute("select * from tblemp where Acno = '" & Ac & "'")
            If rs.EOF = False Then
                If rs("Type").Value = "Employee" Then Return False
                If rs("DateExpired").Value <= Petsa Then
                    dtExpired = vbNullString
                    dtExpired = rs("DateExpired").Value
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Catch
            Return False
        End Try
    End Function

    Private Sub Dev1_OnAttTransaction_1(ByVal sender As System.Object, ByVal e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent)

        If subSQl() = False Then
            Exit Sub
        End If

        lblInOut.Text = "Time In :"
        lblInOut.Left = 22
        lblInOut.Top = 190

        EnrolNumber = e.enrollNumber

        entInfo(EnrolNumber)

        inCapture()
        If Not bgwSaveEnt.IsBusy Then
            bgwSaveEnt.RunWorkerAsync()
        End If

        idLog = vbNullString
        getIDlog()

        EntCap.Visible = True
        EntCap.Image = Get_ImageIn(idLog)
        Delete_Image()
        CopPic = vbNullString
        triger()

        tmrClear.Enabled = False
        tmrClear.Enabled = True
    End Sub

    Sub AntiPsb1(ByVal Eid As Integer, ByVal Vm As Integer)
        If StatDev2.Text = "Connected" Then
            Dev2.EnableUser(1, Eid, 1, Vm, True)
            ' Dev1.EnableUser(1, Eid, 1, Vm, False)
        End If
    End Sub

    Sub NoPsb1(ByVal Eid As Integer, ByVal Vm As Integer)
        If StatDev2.Text = "Connected" Then
            Dev2.EnableUser(1, Eid, 1, Vm, True)
            ' Dev1.EnableUser(1, Eid, 1, Vm, True)
        End If
    End Sub

    Sub AntiPsb2(ByVal Eid As Integer, ByVal Vm As Integer)
        If StatDev1.Text = "Connected" Then
            ' Dev1.EnableUser(1, Eid, 1, Vm, True)
            Dev2.EnableUser(1, Eid, 1, Vm, False)
        End If
    End Sub

    Sub NoPsb2(ByVal Eid As Integer, ByVal Vm As Integer)
        If StatDev1.Text = "Connected" Then
            '  Dev1.EnableUser(1, Eid, 1, Vm, True)
            Dev2.EnableUser(1, Eid, 1, Vm, True)
        End If
    End Sub

    Private Sub ByDateAndTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByDateAndTimeToolStripMenuItem.Click
        tmrPingDev1.Enabled = False
        tmrPingDev2.Enabled = False
        tmrPingServer.Enabled = False

        frmLogs.ShowDialog()
        'devDisCon()
    End Sub

    Private Sub AccLogsHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccLogsHistoryToolStripMenuItem.Click
        frmLogsHistory.ShowDialog()
    End Sub

    Sub OutSave()
        If subSQl() = False Then Exit Sub

        Try
            Dim rs = New Recordset

            rs = New Recordset
            rs.Open("select * from tbltimeout where 1=0", conSql, 1, 2)

            rs.AddNew()
            rs("IDnumber").Value = lblIdNum.Text
            rs("Name").Value = lblName.Text
            rs("TimeOut").Value = Now
            Try
                Dim strem As New Stream
                strem.Type = StreamTypeEnum.adTypeBinary
                strem.Open()
                strem.LoadFromFile(CopPicExt)
                rs("ExtPic").Value = strem.Read
                rs.Update()
            Catch ex As Exception
                Dim rs2 = New Recordset

                rs2 = New Recordset
                rs2.Open("select * from tbltimeout where 1=0", conSql, 1, 2)

                rs2.AddNew()
                rs2("IDnumber").Value = lblIdNum.Text
                rs2("Name").Value = lblName.Text
                rs2("TimeOut").Value = Now
                rs2.Update()
            End Try
        Catch ex As Exception
            txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub OutSave2()
        If subSQl() = False Then Exit Sub

        Try
            Dim rs = New Recordset

            rs = New Recordset
            rs.Open("select * from tbltimeout where 1=0", conSql, 1, 2)

            rs.AddNew()
            rs("IDnumber").Value = txtIdNo.Text
            rs("Name").Value = txtName.Text
            rs("TimeOut").Value = Now
            Try
                Dim strem As New Stream
                strem.Type = StreamTypeEnum.adTypeBinary
                strem.Open()
                strem.LoadFromFile(CopPicExt)
                rs("ExtPic").Value = strem.Read
                rs.Update()
            Catch ex As Exception
                Dim rs2 = New Recordset

                rs2 = New Recordset
                rs2.Open("select * from tbltimeout where 1=0", conSql, 1, 2)

                rs2.AddNew()
                rs2("IDnumber").Value = txtIdNo.Text
                rs2("Name").Value = txtName.Text
                rs2("TimeOut").Value = Now
                rs2.Update()
            End Try
        Catch ex As Exception
            txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Private Sub Dev2_OnAttTransaction_2(ByVal sender As System.Object, ByVal e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent) Handles Dev2.OnAttTransaction
        Try
            If subSQl() = False Then
                Exit Sub
            End If

            lblInOut.Text = "Time Out :"
            lblInOut.Left = 8
            lblInOut.Top = 190

            EnrolNumber = e.enrollNumber

            entInfo(EnrolNumber)

            If OutVer(Now, lblIdNum.Text) = True Then

                inCapture()
                OutSave()
                Delete_Image()
                CopPicExt = vbNullString
                idLog2 = vbNullString
                getIDlogOut()

                EntCap.Visible = True
                EntCap.Image = Get_PicExt(idLog2)
                trigerExt()

                delInLog(lblIdNum.Text)
                filllist()
                tmrClear.Enabled = False
                tmrClear.Enabled = True
                Exit Sub
            End If


            inCapture()
            realOutSave(lblIdNum.Text)
            Delete_Image()
            CopPicExt = vbNullString
            idLog2 = vbNullString
            getIDlogOut()

            EntCap.Visible = True
            EntCap.Image = Get_PicExt(idLog2)
            trigerExt()

            delInLog(lblIdNum.Text)
            tmrClear.Enabled = False
            tmrClear.Enabled = True
        Catch ex As Exception
            'log.AddRecord(ex.InnerException.ToString)
        End Try
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        frmPsb.ShowDialog()
    End Sub

    Private Sub EmployeeRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeRecordToolStripMenuItem.Click
        frmEmployee.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmVehicle.ShowDialog()
    End Sub

    Private Sub BarrierSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarrierSettingsToolStripMenuItem.Click
        frmBarrier.ShowDialog()
    End Sub

    Private Sub NotifyIcon_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Activ = False
        Me.Show()
    End Sub

    Private Sub Dev3_OnAttTransaction(sender As System.Object, e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent) Handles Dev3.OnAttTransaction
        Try
            If subSQl() = False Then
                Exit Sub
            End If

            lblInOut.Text = "Time In :"
            lblInOut.Left = 22
            lblInOut.Top = 190

            EnrolNumber = e.enrollNumber

            entInfo2(EnrolNumber)

            outCapture()
            realInSave2()
            idLog = vbNullString
            getIDlog()

            ExtCap.Visible = True
            ExtCap.Image = Get_ImageIn(idLog)
            Delete_Image()
            CopPic = vbNullString
            triger()

            tmrClear2.Enabled = False
            tmrClear2.Enabled = True
           
        Catch ex As Exception
            'log.AddRecord(ex.InnerException.ToString)
        End Try
    End Sub

    Private Sub Dev4_OnAttTransaction(sender As System.Object, e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent) Handles Dev4.OnAttTransaction
        Try
            If subSQl() = False Then
                Exit Sub
            End If

            txtLabel2.Text = "Time Out :"
            txtLabel2.Left = 8
            txtLabel2.Top = 191

            EnrolNumber = e.enrollNumber

            entInfo2(EnrolNumber)

            If OutVer(Now, txtIdNo.Text) = True Then
                outCapture()
                OutSave2()
                Delete_Image()
                CopPicExt = vbNullString
                idLog2 = vbNullString
                getIDlogOut()

                ExtCap.Visible = True
                ExtCap.Image = Get_PicExt(idLog2)
                trigerExt()

                delInLog(txtIdNo.Text)
                tmrClear2.Enabled = False
                tmrClear2.Enabled = True
                Exit Sub
            End If

            outCapture()
            realInSave2()
            Delete_Image()
            CopPicExt = vbNullString
            idLog2 = vbNullString
            getIDlogOut()

            ExtCap.Visible = True
            ExtCap.Image = Get_PicExt(idLog2)
            trigerExt()

            delInLog(txtIdNo.Text)
            tmrClear2.Enabled = False
            tmrClear2.Enabled = True
        Catch ex As Exception
            'log.AddRecord(ex.InnerException.ToString)
        End Try
    End Sub

    Private Sub tmrClear2_Tick(sender As System.Object, e As System.EventArgs) Handles tmrClear2.Tick
        txtIdNo.Text = "________"
        txtName.Text = "________"
        txtPosi.Text = "________"
        txtGender.Text = "________"
        EmpPic2.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
        txtInOutTime.Text = "________"

        ExtCap.Visible = False

        tmrClear2.Enabled = False
    End Sub

    Private Sub frmMain_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        StartSystem()
    End Sub

    Private Sub SetSystemLogoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SetSystemLogoToolStripMenuItem.Click
        frmLogo.ShowDialog()
    End Sub

    Private Sub bgwR1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwR1.DoWork
        Try

            Do While PingMe(My.Settings.DEV1_IP) = True
                'Dev1.RegEvent(1, 32767)
                StatDev1.ForeColor = Color.Blue
                StatDev1.Text = "Connected"
                'Dev1.BeginInit()
                'Sleep(1000)
            Loop
            'Dev1.EndInit()
            StatDev1.ForeColor = Color.Maroon
            StatDev1.Text = "Disconnected"
        Catch ex As Exception
            ''log.AddRecord(ex.InnerException.ToString)
        End Try


    End Sub

    Private Sub bgwR2_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwR2.DoWork
        Try
            Do While PingMe(My.Settings.DEV2_IP) = True
                StatDev2.ForeColor = Color.Blue
                StatDev2.Text = "Connected"
                'Dev2.BeginInit()
                'Dev2.RegEvent(1, 32767)
                ' Sleep(1000)
            Loop
            'Dev2.EndInit()
            StatDev2.ForeColor = Color.Maroon
            StatDev2.Text = "Disconnected"
        Catch ex As Exception
            'log.AddRecord(ex.InnerException.ToString)
        End Try
    End Sub

    Private Sub bgwR3_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwR3.DoWork
        Try
            Do While PingMe(My.Settings.DEV3_IP) = True
                StatDev3.ForeColor = Color.Blue
                StatDev3.Text = "Connected"
                'Sleep(1000)
                ' Dev3.BeginInit()
                'Dev3.RegEvent(1, 32767)
            Loop
            'Dev3.EndInit()
            StatDev3.ForeColor = Color.Maroon
            StatDev3.Text = "Disconnected"
        Catch ex As Exception
            'log.AddRecord(ex.InnerException.ToString)
        End Try
    End Sub

    Private Sub bgwR4_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwR4.DoWork
        Try
            Do While PingMe(My.Settings.DEV4_IP) = True
                StatDev4.ForeColor = Color.Blue
                StatDev4.Text = "Connected"
                'Sleep(1000)
                ' Dev4.BeginInit()
                ' Dev4.RegEvent(1, 32767)
            Loop
            'Dev4.EndInit()
            StatDev4.ForeColor = Color.Maroon
            StatDev4.Text = "Disconnected"
        Catch ex As Exception
            'log.AddRecord(ex.InnerException.ToString)
        End Try
    End Sub

    Private Sub tmrRef1_Tick(sender As System.Object, e As System.EventArgs) Handles tmrRef1.Tick
        Try
            Do While Not bgwR1.IsBusy
                bgwR1.RunWorkerAsync()
            Loop
        Catch ex As Exception
            'log.AddRecord(ex.InnerException.ToString)
        End Try
    End Sub

    Private Sub tmrRef2_Tick(sender As System.Object, e As System.EventArgs) Handles tmrRef2.Tick
        Try
            Do While Not bgwR2.IsBusy
                bgwR2.RunWorkerAsync()
            Loop
        Catch ex As Exception
            'log.AddRecord(ex.InnerException.ToString)
        End Try
    End Sub

    Private Sub tmrRef3_Tick(sender As System.Object, e As System.EventArgs) Handles tmrRef3.Tick
        Try
            Do While Not bgwR3.IsBusy
                bgwR3.RunWorkerAsync()
            Loop
        Catch ex As Exception
            'log.AddRecord(ex.InnerException.ToString)
        End Try
    End Sub

    Private Sub tmrRef4_Tick(sender As System.Object, e As System.EventArgs) Handles tmrRef4.Tick
        Try
            Do While Not bgwR4.IsBusy
                bgwR4.RunWorkerAsync()
            Loop
        Catch ex As Exception
            'log.AddRecord(ex.InnerException.ToString)
        End Try
    End Sub

    Private Sub bgwInfo1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwInfo1.DoWork
        entInfo(EnrolNumber)
    End Sub

    Private Sub bgwInfo2_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwInfo2.DoWork
        'entInfo2(EnrolNumber)
        '
        ' Try
        Dim rs = New Recordset
        Dim petsa As String
        petsa = Format(Now, "yyyy-MM-dd HH:mm:ss")

        rs = New Recordset
        rs = conSql.Execute("select * from tblemp where ACno = '" & EnrolNumber & "'")
        If rs.EOF = False Then
            txtIdNo.Text = rs("IDnumber").Value
            ' txtName.Text = rs("Name").Value
            '  txtPosi.Text = rs("Title").Value
            'txtGender.Text = rs("Gender").Value
            EmpPic2.Image = Get_PicEmp(EnrolNumber)
            ' txtInOutTime.Text = petsa
        Else
            txtIdNo.Text = EnrolNumber
            txtName.Text = "Not Registered"
            txtPosi.Text = "Not Registered"
            txtGender.Text = "Not Registered"
            EmpPic2.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            txtInOutTime.Text = petsa
        End If
        'Catch ex As Exception
        'txtSystemErr.Text = ex.Message
        'End Try
    End Sub


    Private Sub bgwSaveEnt_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwSaveEnt.DoWork
        realInSave()
        System.Threading.Thread.Sleep(1000)
    End Sub

    Private Sub bgwSaveOut_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwSaveOut.DoWork
        OutSave()
        System.Threading.Thread.Sleep(1000)
    End Sub

    Private Sub bgwSaveInout_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwSaveInout.DoWork
        realOutSave(lblIdNum.Text)
        System.Threading.Thread.Sleep(1000)
    End Sub

    Private Sub bgwSaveOut2_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwSaveOut2.DoWork
        OutSave2()
        System.Threading.Thread.Sleep(1000)
    End Sub

    Private Sub bgwSaveInOut2_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwSaveInOut2.DoWork
        realOutSave2(txtIdNo.Text)
        System.Threading.Thread.Sleep(1000)
    End Sub

    Private Sub bgwSaveEnt2_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwSaveEnt2.DoWork
        realInSave2()
        System.Threading.Thread.Sleep(1000)
    End Sub

    Private Sub Dev1_OnAttTransaction(sender As System.Object, e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent) Handles Dev1.OnAttTransaction
        Try
            If subSQl() = False Then
                Exit Sub
            End If

            lblInOut.Text = "Time In :"
            lblInOut.Left = 22
            lblInOut.Top = 190

            EnrolNumber = e.enrollNumber

            entInfo(EnrolNumber)

            inCapture()
            realInSave()
            idLog = vbNullString
            getIDlog()

            EntCap.Visible = True
            EntCap.Image = Get_ImageIn(idLog)
            Delete_Image()
            CopPic = vbNullString
            triger()

            tmrClear.Enabled = False
            tmrClear.Enabled = True
        Catch ex As Exception
            'log.AddRecord(ex.InnerException.ToString)
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub
End Class
