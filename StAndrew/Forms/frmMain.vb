Imports ADODB
Imports System.IO
Public Class frmMain
    Public rema As String
    Public pangalan As String
    Public IdNo As String
    Public extpath As String
    Public CopPic As String
    Public CopPicExt As String

    Public tmin As String
    'Public Ent As String
    Public inOut As String
    Public tmeNw As String
    Public clr As String
    Public Outst As String

    Public infoStat As String

    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        If MsgBox("Are you sure do you want to exit?    ", vbYesNo + vbQuestion + vbDefaultButton2, "Exit") = vbYes Then
            t1devDisCon()
            t2devDisCon()
            t3devDisCon()
            t4devDisCon()
            'CAM_CLOSE()
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

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
        'outsve()
    End Sub

    Private Sub frmMain_InputLanguageChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.InputLanguageChangingEventArgs) Handles Me.InputLanguageChanging

    End Sub

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Return Then
            If Access = True Then
                Dim a As New frmLogin
                a.ShowDialog()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub frmMain_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If unlock() = True Then
            If Asc(e.KeyChar) = 13 Then
                frmLogin.ShowDialog()
            End If
        End If
    End Sub
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Reader
        tbldevcon()

        't1devDisCon()
        't2devDisCon()
        't3devDisCon()
        't4devDisCon()

        't1devcon1(frmConDev.T1DevIp1.Text)
        't1devcon2(frmConDev.T1DevIp2.Text)

        't2devcon1(frmConDev.T2DevIp1.Text)
        't2devcon2(frmConDev.T2DevIp2.Text)

        't3devcon1(frmConDev.T3DevIp1.Text)
        't3devcon2(frmConDev.T3DevIp2.Text)

        't4devcon1(frmConDev.T4DevIp1.Text)
        't4devcon2(frmConDev.T4DevIp2.Text)

        'Server
        setcon()
        If PingMe(Ip) = True Then
            subSQl()
        Else
            frmConDB.ShowDialog()
        End If
        lock()

        viewPath()
        sysMsg.Text = My.Settings.Sys_Msg

        If verAttrul() = True Then
            frmAttRule.ShowDialog()
        End If

        If psb() = True Then
            frmPassBack.ShowDialog()
        End If

        'frmAutoCon.ShowDialog()

    End Sub
    Function verNull() As Boolean
        If frmConDev.T1DevIp1.Text = vbNullString Or frmConDev.T1DevIp2.Text = vbNullString Or frmConDev.T2DevIp1.Text = vbNullString Or frmConDev.T2DevIp2.Text = vbNullString Or frmConDev.T3DevIp1.Text = vbNullString Or frmConDev.T3DevIp2.Text = vbNullString Or frmConDev.T4DevIp1.Text = vbNullString Or frmConDev.T4DevIp2.Text = vbNullString Then
            Return True
        Else
            Return False
        End If
    End Function
    Function psb() As Boolean
        If My.Settings.PSb_Set = vbNullString Then
            Return True
        Else
            Return False
        End If
    End Function
    Sub svpsb()
        With My.Settings
            .PSb_Set = "OnPSB"
            .Save()
        End With
    End Sub
    Function verAttrul() As Boolean
        If My.Settings.LR_CHLin = vbNullString And My.Settings.LR_CHLout = vbNullString Then
            Return True
        Else
            Return False
        End If
    End Function
    
    Sub head()
        'LstTimeIn.Columns.Add("ID Number", 130, HorizontalAlignment.Left)
        'LstTimeIn.Columns.Add("Name", 410, HorizontalAlignment.Left)
        'LstTimeIn.Columns.Add("TimeIn", 150, HorizontalAlignment.Left)
    End Sub
    Sub fill()
        If StatDB.Text = "Disconnected" Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If
        'LstTimeIn.Clear()
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSql.Execute("select * from tblTimeIn")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                'LstTimeIn.Refresh()
                Dim viewlst As New ListViewItem
                'viewlst = LstTimeIn.Items.Add(rs("Idnumber").Value, lup)
                viewlst.SubItems.Add(rs("Name").Value)
                viewlst.SubItems.Add(rs("TimeIn").Value)
                rs.MoveNext()
            Next
        End If
    End Sub
    Sub fillout()
        If StatDB.Text = "Disconnected" Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If
        'LstTimeIn.Clear()
        head()
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSql.Execute("select * from tblTimeIn order by IdLog desc")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                'LstTimeIn.Refresh()
                Dim viewlst As New ListViewItem
                'viewlst = LstTimeIn.Items.Add(rs("Idnumber").Value, lup)
                viewlst.SubItems.Add(rs("Name").Value)
                viewlst.SubItems.Add(rs("TimeIn").Value)
                rs.MoveNext()
            Next
        End If
    End Sub
    Sub filllist()
        If StatDB.Text = "Disconnected" Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If
        'LstTimeIn.Clear()
        'LstTimeIn.Clear()
        head()
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSql.Execute("select * from tblTimeIn order by TimeIn desc")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                Dim CDin As String = Format(CDate(rs("TimeIn").Value), "HH:mm:ss tt")
                'LstTimeIn.Refresh()
                Dim viewlst As New ListViewItem
                'viewlst = LstTimeIn.Items.Add(rs("Idnumber").Value, lup)
                viewlst.SubItems.Add(rs("Name").Value)
                viewlst.SubItems.Add(CDin)
                rs.MoveNext()
            Next
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim lup As Long
        For lup = 1 To 50
            Pic1Sa.Left = Pic1Sa.Left + 1
            Pic2Sa.Left = Pic2Sa.Left + 1
            lup = lup + 1

            If Pic2Sa.Left = 3 Then
                Pic1Sa.Left = -952
                lup = 0
            End If

            If Pic1Sa.Left = 3 Then
                Pic2Sa.Left = -952
            End If
        Next
        'lblDate.Text = Format(Now, "long date")
        StatTime.Text = Format(Now, "General Date")

        'serverping()
    End Sub

    Private Sub ToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        't1devDisCon()
        'tmrPingT1.Enabled = False
        'StatDev1.Text = "Disconnected"
        'StatDev1.ForeColor = Color.Maroon
        'tmrPingDev2.Enabled = False
        'StatDev2.Text = "Disconnected"
        'StatDev2.ForeColor = Color.Maroon
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
            MsgBox(ex.Message, vbCritical, "Access Control System")
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
            MsgBox(ex.Message, vbCritical, "Access Control System")
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
            'tmrPingServer.Enabled = False
        End If
    End Sub
    Sub devPingT1(ByVal ipAdd1 As String, ByVal ipAdd2 As String)
        If PingMe(ipAdd1) = False Then
            T1Dev1Stat.Text = "Disconnected"
            T1Dev1Stat.ForeColor = Color.Red
            T1Dev1.EndInit()
        Else
            T1Dev1Stat.Text = "Connected"
            T1Dev1Stat.ForeColor = Color.Blue
            T1Dev1.BeginInit()
            T1Dev1.BASE64 = 0
            T1Dev1.RegEvent(1, 32767)
        End If

        If PingMe(ipAdd2) = False Then
            T1Dev2Stat.Text = "Disconnected"
            T1Dev2Stat.ForeColor = Color.Red
            T1Dev2.EndInit()
        Else
            T1Dev2Stat.Text = "Connected"
            T1Dev2Stat.ForeColor = Color.Blue
            T1Dev2.BeginInit()
            T1Dev2.BASE64 = 0
            T1Dev2.RegEvent(1, 32767)
        End If
    End Sub
    Sub devPingT2(ByVal ipAdd1 As String, ByVal ipAdd2 As String)
        If PingMe(ipAdd2) = False Then
            T2Dev1Stat.Text = "Disconnected"
            T2Dev1Stat.ForeColor = Color.Red
            T2Dev1.EndInit()
        Else
            T2Dev1Stat.Text = "Connected"
            T2Dev1Stat.ForeColor = Color.Blue
            T2Dev1.BeginInit()
            T2Dev1.BASE64 = 0
            T2Dev1.RegEvent(1, 32767)
        End If

        If PingMe(ipAdd2) = False Then
            T2Dev2Stat.Text = "Disconnected"
            T2Dev2Stat.ForeColor = Color.Red
            T2Dev2.EndInit()
        Else
            T2Dev2Stat.Text = "Connected"
            T2Dev2Stat.ForeColor = Color.Blue
            T2Dev2.BeginInit()
            T2Dev2.BASE64 = 0
            T2Dev2.RegEvent(1, 32767)
        End If
    End Sub

    Sub devPingT3(ByVal ipAdd1 As String, ByVal ipAdd2 As String)
        If PingMe(ipAdd2) = False Then
            T3Dev1Stat.Text = "Disconnected"
            T3Dev1Stat.ForeColor = Color.Red
            T3Dev1.EndInit()
        Else
            T3Dev1Stat.Text = "Connected"
            T3Dev1Stat.ForeColor = Color.Blue
            T3Dev1.BeginInit()
            T3Dev1.BASE64 = 0
            T3Dev1.RegEvent(1, 32767)
        End If

        If PingMe(ipAdd2) = False Then
            T3Dev2Stat.Text = "Disconnected"
            T3Dev2Stat.ForeColor = Color.Red
            T3Dev2.EndInit()
        Else
            T3Dev2Stat.Text = "Connected"
            T3Dev2Stat.ForeColor = Color.Blue
            T3Dev2.BeginInit()
            T3Dev2.BASE64 = 0
            T3Dev2.RegEvent(1, 32767)
        End If
    End Sub
    Sub devPingT4(ByVal ipAdd1 As String, ByVal ipAdd2 As String)
        If PingMe(ipAdd2) = False Then
            T4Dev1Stat.Text = "Disconnected"
            T4Dev1Stat.ForeColor = Color.Red
            T4Dev1.EndInit()
        Else
            T4Dev1Stat.Text = "Connected"
            T4Dev1Stat.ForeColor = Color.Blue
            T4Dev1.BeginInit()
            T4Dev1.BASE64 = 0
            T4Dev1.RegEvent(1, 32767)
        End If

        If PingMe(ipAdd2) = False Then
            T4Dev2Stat.Text = "Disconnected"
            T4Dev2Stat.ForeColor = Color.Red
            T4Dev2.EndInit()
        Else
            T4Dev2Stat.Text = "Connected"
            T4Dev2Stat.ForeColor = Color.Blue
            T4Dev2.BeginInit()
            T4Dev2.BASE64 = 0
            T4Dev2.RegEvent(1, 32767)
        End If
    End Sub

    Sub devping2()

        If PingMe(My.Settings.DEV2_IP) = False Then
            Do While PingMe(My.Settings.DEV2_IP) = False
                'StatDev2.Text = "Disconnected"
                'StatDev2.ForeColor = Color.Maroon
                T1Dev2.EndInit()
                'Dev2.Disconnect()
                'tmrPingDev2.Enabled = False
                Exit Sub
            Loop
        Else
            'StatDev2.Text = "Connected"
            'StatDev2.ForeColor = Color.Blue
            T1Dev2.BeginInit()
            T1Dev2.BASE64 = 0
            T1Dev2.RegEvent(devNo2, 32767)
        End If

    End Sub
    Sub remIn(ByVal realTmr As String)
        On Error Resume Next
        rema = vbNullString
        realTmr = Format(CDate(realTmr), "HH:mm:ss")
        Dim CHLin As String = Format(CDate(My.Settings.LR_CHLin), "HH:mm:ss")
        Dim CHLout As String = Format(CDate(My.Settings.LR_CHLout), "HH:mm:ss")
        'Dim CHDin As String = Format(CDate(My.Settings.LR_CHDin), "HH:mm:ss")
        'Dim CHDout As String = Format(CDate(My.Settings.LR_CHDout), "HH:mm:ss")
        'Dim CHin As String = Format(CDate(My.Settings.LR_CHin), "HH:mm:ss tt")
        'Dim CDin As String = Format(CDate(My.Settings.LR_CDin), "HH:mm:ss tt")
        If realTmr >= CHLin And realTmr < CHLout Then
            rema = "LATE!"
            'lblRealTime.Text = CHin
        Else
            rema = "On time"
        End If
        'If realTmr >= CHDin And realTmr < CHDout Then
        'rema = "Half Day"
        ' lblRealTime.Text = CDin
        'ElseIf realTmr > CHDout Then
        'rema = "Over Late"
        'End If
    End Sub
    Sub entInfo(ByVal id As String)
        Dim rs = New Recordset
        Dim petsa As String
        'dim tme As String
        petsa = Format(Now, "yyyy-MM-dd")
        'tme = Format(Now, "HH:mm:ss")
        rs = New Recordset
        rs.Open("select * from UserInfo where BadgeNumber = '" & id & "'", PathConn, 1, 2)
        If rs.EOF = False Then
            On Error Resume Next
            T1IdNo.Text = rs("BadgeNumber").Value
            T1Name.Text = rs("Name").Value
            T1Gy.Text = rs("Title").Value
            T1Sec.Text = rs("Gender").Value
            T1StudPic.Image = Get_ImageDB(id)
            'lblRealTime.Text = lblTime.Text
            'lblRealDate.Text = petsa
        Else
            T1IdNo.Text = id
            T1Name.Text = "Not Encoded"
            T1Gy.Text = "Not Encoded"
            T1Sec.Text = "Not Encoded"
            T1StudPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            'lblRealTime.Text = lblTime.Text
            'lblRealDate.Text = petsa
        End If
    End Sub
    Sub T1Info(ByVal id As String)
        Dim rs = New Recordset
        'Dim petsa As String
        Dim tme As String
        'petsa = Format(Now, "yyyy-MM-dd")
        tme = vbNullString
        tme = Format(Now, "general date")
        rs = New Recordset
        rs.Open("select * from tblStudInfo where AcNumber = '" & id & "'", conSql, 1, 2)
        If rs.EOF = False Then
            lblPos1.Text = "Grade/Year :"
            lblPos1.Top = 88
            lblPos1.Left = 3
            lblDept1.Text = "Section :"
            lblDept1.Top = 126
            lblDept1.Left = 38

            T1IdNo.Text = rs("IdNumber").Value
            T1Name.Text = rs("Name").Value
            T1Gy.Text = rs("GradeYear").Value
            T1Sec.Text = rs("Section").Value
            'T1Stat.Text = rema
            T1InOut.Text = tme
            Try
                T1StudPic.Image = Image.FromFile(frmPicPath.txtpath.Text & "\" & (id) & ".Jpg")
            Catch
                T1StudPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            End Try
            infoStat = vbNullString
            infoStat = "Stud"
            'lblRealDate.Text = petsa
        ElseIf rs.EOF = True Then
            Dim rs2 As New Recordset
            rs2 = New Recordset
            rs2 = conSql.Execute("select * from tblEmp where ACnumber = '" & id & "'")
            If rs2.EOF = False Then
                lblPos1.Text = "Position :"
                lblPos1.Top = 88
                lblPos1.Left = 34
                lblDept1.Text = "Department :"
                lblDept1.Top = 126
                lblDept1.Left = 3

                T1IdNo.Text = rs2("IdNumber").Value
                T1Name.Text = rs2("Name").Value
                T1Gy.Text = rs2("Position").Value
                T1Sec.Text = rs2("Department").Value
                T1InOut.Text = tme

                Try
                    T1StudPic.Image = Image.FromFile(frmPicPath.txtpath.Text & "\" & (id) & ".Jpg")
                Catch
                    T1StudPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                End Try
            Else
                T1IdNo.Text = id
                T1Name.Text = "Not Encoded"
                T1Gy.Text = "Not Encoded"
                T1Sec.Text = "Not Encoded"
                T1StudPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                T1InOut.Text = tme
            End If
            infoStat = vbNullString
            infoStat = "Emp"
        Else
            T1IdNo.Text = id
            T1Name.Text = "Not Encoded"
            T1Gy.Text = "Not Encoded"
            T1Sec.Text = "Not Encoded"
            T1StudPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            T1InOut.Text = tme
            'lblRealTime.Text = lblTime.Text
            'lblRealDate.Text = petsa
        End If

    End Sub
    Sub T2Info(ByVal id As String)
        Dim rs = New Recordset
        'Dim petsa As String
        Dim tme As String
        'petsa = Format(Now, "yyyy-MM-dd")
        tme = vbNullString
        tme = Format(Now, "general date")
        rs = New Recordset
        rs.Open("select * from tblStudInfo where AcNumber = '" & id & "'", conSql, 1, 2)
        If rs.EOF = False Then
            lblPos2.Text = "Grade/Year :"
            lblPos2.Top = 88
            lblPos2.Left = 3
            lblDept2.Text = "Section :"
            lblDept2.Top = 126
            lblDept2.Left = 38

            T2IdNo.Text = rs("IdNumber").Value
            T2Name.Text = rs("Name").Value
            T2Gy.Text = rs("GradeYear").Value
            T2Sec.Text = rs("Section").Value
            'T1Stat.Text = rema
            T2InOut.Text = tme
            Try
                T2StudPic.Image = Image.FromFile(frmPicPath.txtpath.Text & "\" & (id) & ".Jpg")
            Catch
                T2StudPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            End Try
            infoStat = vbNullString
            infoStat = "Stud"
            'lblRealDate.Text = petsa
        ElseIf rs.EOF = True Then
            Dim rs2 As New Recordset
            rs2 = New Recordset
            rs2 = conSql.Execute("select * from tblEmp where ACnumber = '" & id & "'")
            If rs2.EOF = False Then
                lblPos2.Text = "Position :"
                lblPos2.Top = 88
                lblPos2.Left = 34
                lblDept2.Text = "Department :"
                lblDept2.Top = 126
                lblDept2.Left = 3

                T2IdNo.Text = rs2("IdNumber").Value
                T2Name.Text = rs2("Name").Value
                T2Gy.Text = rs2("Position").Value
                T2Sec.Text = rs2("Department").Value
                T2InOut.Text = tme

                Try
                    T2StudPic.Image = Image.FromFile(frmPicPath.txtpath.Text & "\" & (id) & ".Jpg")
                Catch
                    T2StudPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                End Try
            Else
                T2IdNo.Text = id
                T2Name.Text = "Not Encoded"
                T2Gy.Text = "Not Encoded"
                T2Sec.Text = "Not Encoded"
                T2StudPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                T2InOut.Text = tme
            End If
            infoStat = vbNullString
            infoStat = "Emp"
        Else
            T2IdNo.Text = id
            T2Name.Text = "Not Encoded"
            T2Gy.Text = "Not Encoded"
            T2Sec.Text = "Not Encoded"
            T2StudPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            T2InOut.Text = tme
            'lblRealTime.Text = lblTime.Text
            'lblRealDate.Text = petsa
        End If

    End Sub
    Sub T3Info(ByVal id As String)
        Dim rs = New Recordset
        'Dim petsa As String
        Dim tme As String
        'petsa = Format(Now, "yyyy-MM-dd")
        tme = vbNullString
        tme = Format(Now, "general date")
        rs = New Recordset
        rs.Open("select * from tblStudInfo where AcNumber = '" & id & "'", conSql, 1, 2)
        If rs.EOF = False Then
            lblPos3.Text = "Grade/Year :"
            lblPos3.Top = 88
            lblPos3.Left = 3
            lblDept3.Text = "Section :"
            lblDept3.Top = 126
            lblDept3.Left = 38

            T3IdNo.Text = rs("IdNumber").Value
            T3Name.Text = rs("Name").Value
            T3Gy.Text = rs("GradeYear").Value
            T3Sec.Text = rs("Section").Value
            'T1Stat.Text = rema
            T3InOut.Text = tme
            Try
                T3StudPic.Image = Image.FromFile(frmPicPath.txtpath.Text & "\" & (id) & ".Jpg")
            Catch
                T3StudPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            End Try
            infoStat = vbNullString
            infoStat = "Stud"
            'lblRealDate.Text = petsa
        ElseIf rs.EOF = True Then
            Dim rs2 As New Recordset
            rs2 = New Recordset
            rs2 = conSql.Execute("select * from tblEmp where ACnumber = '" & id & "'")
            If rs2.EOF = False Then
                lblPos3.Text = "Position :"
                lblPos3.Top = 88
                lblPos3.Left = 34
                lblDept3.Text = "Department :"
                lblDept3.Top = 126
                lblDept3.Left = 3

                T3IdNo.Text = rs2("IdNumber").Value
                T3Name.Text = rs2("Name").Value
                T3Gy.Text = rs2("Position").Value
                T3Sec.Text = rs2("Department").Value
                T3InOut.Text = tme

                Try
                    T3StudPic.Image = Image.FromFile(frmPicPath.txtpath.Text & "\" & (id) & ".Jpg")
                Catch
                    T3StudPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                End Try
            Else
                T3IdNo.Text = id
                T3Name.Text = "Not Encoded"
                T3Gy.Text = "Not Encoded"
                T3Sec.Text = "Not Encoded"
                T3StudPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                T3InOut.Text = tme
            End If
            infoStat = vbNullString
            infoStat = "Emp"
        Else
            T3IdNo.Text = id
            T3Name.Text = "Not Encoded"
            T3Gy.Text = "Not Encoded"
            T3Sec.Text = "Not Encoded"
            T3StudPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            T3InOut.Text = tme
            'lblRealTime.Text = lblTime.Text
            'lblRealDate.Text = petsa
        End If

    End Sub
    

    Sub T4Info(ByVal id As String)
        Dim rs = New Recordset
        'Dim petsa As String
        Dim tme As String
        'petsa = Format(Now, "yyyy-MM-dd")
        tme = vbNullString
        tme = Format(Now, "general date")
        rs = New Recordset
        rs.Open("select * from tblStudInfo where AcNumber = '" & id & "'", conSql, 1, 2)
        If rs.EOF = False Then
            lblPos4.Text = "Grade/Year :"
            lblPos4.Top = 88
            lblPos4.Left = 3
            lblDept4.Text = "Section :"
            lblDept4.Top = 126
            lblDept4.Left = 38

            T4IdNO.Text = rs("IdNumber").Value
            T4Name.Text = rs("Name").Value
            T4Gy.Text = rs("GradeYear").Value
            T4Sec.Text = rs("Section").Value
            'T1Stat.Text = rema
            T4InOut.Text = tme
            Try
                T4StudPic.Image = Image.FromFile(frmPicPath.txtpath.Text & "\" & (id) & ".Jpg")
            Catch
                T4StudPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            End Try
            infoStat = vbNullString
            infoStat = "Stud"
            'lblRealDate.Text = petsa
        ElseIf rs.EOF = True Then
            Dim rs2 As New Recordset
            rs2 = New Recordset
            rs2 = conSql.Execute("select * from tblEmp where ACnumber = '" & id & "'")
            If rs2.EOF = False Then
                lblPos4.Text = "Position :"
                lblPos4.Top = 88
                lblPos4.Left = 34
                lblDept4.Text = "Department :"
                lblDept4.Top = 126
                lblDept4.Left = 3

                T4IdNO.Text = rs2("IdNumber").Value
                T4Name.Text = rs2("Name").Value
                T4Gy.Text = rs2("Position").Value
                T4Sec.Text = rs2("Department").Value
                T4InOut.Text = tme

                Try
                    T4StudPic.Image = Image.FromFile(frmPicPath.txtpath.Text & "\" & (id) & ".Jpg")
                Catch
                    T4StudPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                End Try
            Else
                T4IdNO.Text = id
                T4Name.Text = "Not Encoded"
                T4Gy.Text = "Not Encoded"
                T4Sec.Text = "Not Encoded"
                T4StudPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                T4InOut.Text = tme
            End If
            infoStat = vbNullString
            infoStat = "Emp"
        Else
            T4IdNO.Text = id
            T4Name.Text = "Not Encoded"
            T4Gy.Text = "Not Encoded"
            T4Sec.Text = "Not Encoded"
            T4StudPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            T4InOut.Text = tme
            'lblRealTime.Text = lblTime.Text
            'lblRealDate.Text = petsa
        End If
    End Sub

    Sub inCapture()
        'Dim pathEnt As String
        Dim orgCAp As String
        ' CamEntry.JPEGCapturePicture(My.Settings.CAM_ChannelCap1, 0, 0, Application.StartupPath & "\EntCapture")
        orgCAp = Dir(Application.StartupPath & "\EntCapture\JPEGCapture\*.jpeg")
        CopPic = (Application.StartupPath & "\EntCapture\JPEGCapture\" & orgCAp & "")
        'CapPic(CopPic)
    End Sub
    Sub outCapture()
        Dim orgCAp As String
        'Dim CopPicExt As String
        'CamExit.JPEGCapturePicture(My.Settings.CAM_ChannelCap2, 0, 0, Application.StartupPath & "\EntCapture")
        orgCAp = Dir(Application.StartupPath & "\EntCapture\JPEGCapture\*.jpeg")
        CopPicExt = (Application.StartupPath & "\EntCapture\JPEGCapture\" & orgCAp & "")
        'CapPicOut(CopPic)
        'extpath = StrPicFile
    End Sub
    Sub T1InSave()
        Try
            Dim rs = New Recordset
            rs = New Recordset
            rs.Open("select * from tbltimein", conSql, 1, 2)
            'idLog = rs.RecordCount + 1
            rs.AddNew()
            rs("IDlog").Value = idLog
            rs("IDnumber").Value = T1IdNo.Text
            rs("Name").Value = T1Name.Text
            rs("GradeYr").Value = T1Gy.Text
            rs("Section").Value = T1Sec.Text
            rs("TimeIn").Value = T1InOut.Text
            rs("Status").Value = T1Stat.Text
            rs.Update()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Time In")
        End Try
    End Sub
    Sub T1EmpInSave()
        Try
            Dim rs = New Recordset
            rs = New Recordset
            rs.Open("select * from tblEmptimein", conSql, 1, 2)
            'idLog = rs.RecordCount + 1
            rs.AddNew()
            rs("IDlog").Value = idLog
            rs("IDnumber").Value = T1IdNo.Text
            rs("Name").Value = T1Name.Text
            rs("TimeIn").Value = T1InOut.Text
            rs("Status").Value = T1Stat.Text
            rs.Update()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Time In")
        End Try
    End Sub
    Sub T2InSave()
        Try
            Dim rs = New Recordset
            rs = New Recordset
            rs.Open("select * from tbltimein", conSql, 1, 2)
            'idLog = rs.RecordCount + 1
            rs.AddNew()
            rs("IDlog").Value = idLog
            rs("IDnumber").Value = T2IdNo.Text
            rs("Name").Value = T2Name.Text
            rs("GradeYr").Value = T2Gy.Text
            rs("Section").Value = T2Sec.Text
            rs("TimeIn").Value = T2InOut.Text
            rs("Status").Value = T2Stat.Text
            rs.Update()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Time In")
        End Try
    End Sub
    Sub T2EmpInSave()
        Try
            Dim rs = New Recordset
            rs = New Recordset
            rs.Open("select * from tblEmptimein", conSql, 1, 2)
            'idLog = rs.RecordCount + 1
            rs.AddNew()
            rs("IDlog").Value = idLog
            rs("IDnumber").Value = T2IdNo.Text
            rs("Name").Value = T2Name.Text
            'rs("Position").Value = T2Gy.Text
            rs("TimeIn").Value = T2InOut.Text
            rs("Status").Value = T2Stat.Text
            rs.Update()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Time In")
        End Try
    End Sub
    Sub T3InSave()
        Try
            Dim rs = New Recordset
            rs = New Recordset
            rs.Open("select * from tbltimein", conSql, 1, 2)
            'idLog = rs.RecordCount + 1
            rs.AddNew()
            rs("IDlog").Value = idLog
            rs("IDnumber").Value = T3IdNo.Text
            rs("Name").Value = T3Name.Text
            rs("GradeYr").Value = T3Gy.Text
            rs("Section").Value = T3Sec.Text
            rs("TimeIn").Value = T3InOut.Text
            rs("Status").Value = T3Stat.Text
            rs.Update()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Time In")
        End Try
    End Sub
    Sub T3EmpInSave()
        Try
            Dim rs = New Recordset
            rs = New Recordset
            rs.Open("select * from tblEmptimein", conSql, 1, 2)
            'idLog = rs.RecordCount + 1
            rs.AddNew()
            rs("IDlog").Value = idLog
            rs("IDnumber").Value = T3IdNo.Text
            rs("Name").Value = T3Name.Text
            ' rs("Position").Value = T3Gy.Text
            rs("TimeIn").Value = T3InOut.Text
            rs("Status").Value = T3Stat.Text
            rs.Update()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Time In")
        End Try
    End Sub
    Sub T4InSave()
        Try
            Dim rs = New Recordset
            rs = New Recordset
            rs.Open("select * from tbltimein", conSql, 1, 2)
            'idLog = rs.RecordCount + 1
            rs.AddNew()
            rs("IDlog").Value = idLog
            rs("IDnumber").Value = T4IdNO.Text
            rs("Name").Value = T4Name.Text
            rs("GradeYr").Value = T4Gy.Text
            rs("Section").Value = T4Sec.Text
            rs("TimeIn").Value = T4InOut.Text
            rs("Status").Value = T4Stat.Text
            rs.Update()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Time In")
        End Try
    End Sub

    Sub T4EmpInSave()
        Try
            Dim rs = New Recordset
            rs = New Recordset
            rs.Open("select * from tblEmptimein", conSql, 1, 2)
            'idLog = rs.RecordCount + 1
            rs.AddNew()
            rs("IDlog").Value = idLog
            rs("IDnumber").Value = T4IdNO.Text
            rs("Name").Value = T4Name.Text
            'rs("Position").Value = T4Gy.Text
            rs("TimeIn").Value = T4InOut.Text
            rs("Status").Value = T4Stat.Text
            rs.Update()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Time In")
        End Try
    End Sub

    Function OutVer(ByVal id) As Boolean
        Dim rs = New Recordset
        rs = New Recordset
        rs = conSql.Execute("select * from tbltimein where IDnumber = '" & id & "'")
        If rs.EOF = True Then
            'MsgBox("Login first!    ", vbExclamation, "Time Out")
            Return True
        Else
            Return False
        End If
    End Function
    Function OutVer2(ByVal id) As Boolean
        Dim rs = New Recordset
        rs = New Recordset
        rs = conSql.Execute("select * from tblEmptimein where IDnumber = '" & id & "'")
        If rs.EOF = True Then
            'MsgBox("Login first!    ", vbExclamation, "Time Out")
            Return True
        Else
            Return False
        End If
    End Function
    Function InVer(ByVal id As String) As Boolean
        Dim rs = New Recordset
        rs = New Recordset
        rs = conSql.Execute("select * from tbltimein where IDnumber = '" & id & "'")
        If rs.EOF = False Then
            Return True
        Else
            Return False
        End If
    End Function
    Function InVer2(ByVal id As String) As Boolean
        Dim rs = New Recordset
        rs = New Recordset
        rs = conSql.Execute("select * from tblEmptimeIn where IDnumber = '" & id & "'")
        If rs.EOF = False Then
            Return True
        Else
            Return False
        End If
    End Function
    Sub t1OutSave(ByVal id As String)
        Try
            Dim rs = New Recordset
            inOut = Format(Now, "general date")

            rs = New Recordset
            rs = conSql.Execute("select * from tbltimein where IDnumber = '" & id & "'")
            If rs.EOF = False Then
                tmin = rs("TimeIn").Value

                Dim rs2 As New Recordset
                rs2 = New Recordset
                rs2.Open("select * from tblinout", conSql, 1, 2)
                rs2.AddNew()
                rs2("InOutID").Value = idLog2
                rs2("IDnumber").Value = T1IdNo.Text
                rs2("Name").Value = T1Name.Text
                rs2("GradeYr").Value = T1Gy.Text
                rs2("Section").Value = T1Sec.Text
                rs2("TimeIn").Value = tmin
                rs2("TimeOut").Value = inOut
                rs2("Status").Value = rs("Status")
                rs2.Update()
            End If
            T1Stat.Text = rs("Status").Value
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Time Out")
        End Try
    End Sub
    Sub t1EmpOutSave(ByVal id As String)
        Try
            Dim rs = New Recordset
            inOut = Format(Now, "general date")

            rs = New Recordset
            rs = conSql.Execute("select * from tblEmptimein where IDnumber = '" & id & "'")
            If rs.EOF = False Then
                tmin = rs("TimeIn").Value

                Dim rs2 As New Recordset
                rs2 = New Recordset
                rs2.Open("select * from tblEmpinout", conSql, 1, 2)
                rs2.AddNew()
                rs2("IdLog").Value = idLog2
                rs2("IDnumber").Value = T1IdNo.Text
                rs2("Name").Value = T1Name.Text
                rs2("TimeIn").Value = tmin
                rs2("TimeOut").Value = inOut
                rs2("Status").Value = rs("Status")
                rs2.Update()
            End If
            T1Stat.Text = rs("Status").Value
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Time Out")
        End Try
    End Sub
    Sub t2OutSave(ByVal id As String)
        Try
            Dim rs = New Recordset
            inOut = Format(Now, "general date")

            rs = New Recordset
            rs = conSql.Execute("select * from tbltimein where IDnumber = '" & id & "'")
            If rs.EOF = False Then
                tmin = rs("TimeIn").Value

                Dim rs2 As New Recordset
                rs2 = New Recordset
                rs2.Open("select * from tblinout", conSql, 1, 2)
                rs2.AddNew()
                rs2("InOutID").Value = idLog2
                rs2("IDnumber").Value = T2IdNo.Text
                rs2("Name").Value = T2Name.Text
                rs2("GradeYr").Value = T2Gy.Text
                rs2("Section").Value = T2Sec.Text
                rs2("TimeIn").Value = tmin
                rs2("TimeOut").Value = inOut
                rs2("Status").Value = rs("Status")
                rs2.Update()
            End If
            T2Stat.Text = rs("Status").Value
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Time Out")
        End Try
    End Sub
    Sub t2EmpOutSave(ByVal id As String)
        Try
            Dim rs = New Recordset
            inOut = Format(Now, "general date")

            rs = New Recordset
            rs = conSql.Execute("select * from tblEmptimein where IDnumber = '" & id & "'")
            If rs.EOF = False Then
                tmin = rs("TimeIn").Value

                Dim rs2 As New Recordset
                rs2 = New Recordset
                rs2.Open("select * from tblEmpinout", conSql, 1, 2)
                rs2.AddNew()
                rs2("IdLog").Value = idLog2
                rs2("IDnumber").Value = T2IdNo.Text
                rs2("Name").Value = T2Name.Text
                rs2("TimeIn").Value = tmin
                rs2("TimeOut").Value = inOut
                rs2("Status").Value = rs("Status")
                rs2.Update()
            End If
            T2Stat.Text = rs("Status").Value
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Time Out")
        End Try
    End Sub
    Sub t3OutSave(ByVal id As String)
        Try
            Dim rs = New Recordset
            inOut = Format(Now, "general date")

            rs = New Recordset
            rs = conSql.Execute("select * from tbltimein where IDnumber = '" & id & "'")
            If rs.EOF = False Then
                tmin = rs("TimeIn").Value

                Dim rs2 As New Recordset
                rs2 = New Recordset
                rs2.Open("select * from tblinout", conSql, 1, 2)
                rs2.AddNew()
                rs2("InOutID").Value = idLog2
                rs2("IDnumber").Value = T3IdNo.Text
                rs2("Name").Value = T3Name.Text
                rs2("GradeYr").Value = T3Gy.Text
                rs2("Section").Value = T3Sec.Text
                rs2("TimeIn").Value = tmin
                rs2("TimeOut").Value = inOut
                rs2("Status").Value = rs("Status")
                rs2.Update()
            End If
            T3Stat.Text = rs("Status").Value
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Time Out")
        End Try
    End Sub
    Sub t3EmpOutSave(ByVal id As String)
        Try
            Dim rs = New Recordset
            inOut = Format(Now, "general date")

            rs = New Recordset
            rs = conSql.Execute("select * from tblEmptimein where IDnumber = '" & id & "'")
            If rs.EOF = False Then
                tmin = rs("TimeIn").Value

                Dim rs2 As New Recordset
                rs2 = New Recordset
                rs2.Open("select * from tblEmpinout", conSql, 1, 2)
                rs2.AddNew()
                rs2("IdLog").Value = idLog2
                rs2("IDnumber").Value = T3IdNo.Text
                rs2("Name").Value = T3Name.Text
                rs2("TimeIn").Value = tmin
                rs2("TimeOut").Value = inOut
                rs2("Status").Value = rs("Status")
                rs2.Update()
            End If
            T3Stat.Text = rs("Status").Value
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Time Out")
        End Try
    End Sub
    Sub t4OutSave(ByVal id As String)
        Try
            Dim rs = New Recordset
            inOut = Format(Now, "general date")

            rs = New Recordset
            rs = conSql.Execute("select * from tbltimein where IDnumber = '" & id & "'")
            If rs.EOF = False Then
                tmin = rs("TimeIn").Value

                Dim rs2 As New Recordset
                rs2 = New Recordset
                rs2.Open("select * from tblinout", conSql, 1, 2)
                rs2.AddNew()
                rs2("InOutID").Value = idLog2
                rs2("IDnumber").Value = T4IdNO.Text
                rs2("Name").Value = T4Name.Text
                rs2("GradeYr").Value = T4Gy.Text
                rs2("Section").Value = T4Sec.Text
                rs2("TimeIn").Value = tmin
                rs2("TimeOut").Value = inOut
                rs2("Status").Value = rs("Status")
                rs2.Update()
            End If
            T4Stat.Text = rs("Status").Value
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Time Out")
        End Try
    End Sub

    Sub t4EmpOutSave(ByVal id As String)
        Try
            Dim rs = New Recordset
            inOut = Format(Now, "general date")

            rs = New Recordset
            rs = conSql.Execute("select * from tblEmptimein where IDnumber = '" & id & "'")
            If rs.EOF = False Then
                tmin = rs("TimeIn").Value

                Dim rs2 As New Recordset
                rs2 = New Recordset
                rs2.Open("select * from tblEmpinout", conSql, 1, 2)
                rs2.AddNew()
                rs2("IdLog").Value = idLog2
                rs2("IDnumber").Value = T4IdNO.Text
                rs2("Name").Value = T4Name.Text
                rs2("TimeIn").Value = tmin
                rs2("TimeOut").Value = inOut
                rs2("Status").Value = rs("Status")
                rs2.Update()
            End If
            T4Stat.Text = rs("Status").Value
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Time Out")
        End Try
    End Sub
    Sub delInLog(ByVal id As String)
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSql.Execute("Delete from tbltimeIn where IDnumber = '" & id & "'")
    End Sub
    Sub delInLog2(ByVal id As String)
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSql.Execute("Delete from tblEmptimeIn where IDnumber = '" & id & "'")
    End Sub
    Sub getIDlog()
        Dim rs = New Recordset
        rs = New Recordset
        rs = conSql.Execute("select * from tbltimein")
        idLog = rs.RecordCount + 1
    End Sub
    Sub getIDlogEmp()
        Dim rs = New Recordset
        rs = New Recordset
        rs = conSql.Execute("select * from tblEmptimein")
        idLog = rs.RecordCount + 1
    End Sub
    Sub getIDlogOut()
        Dim rs = New Recordset
        rs = New Recordset
        rs = conSql.Execute("select * from tblinout")
        idLog2 = rs.RecordCount + 1
    End Sub
    Sub getIDlogOut2()
        Dim rs = New Recordset
        rs = New Recordset
        rs = conSql.Execute("select * from tblEmpinout")
        idLog2 = rs.RecordCount + 1
    End Sub
    Private Sub Dev2_OnAttTransaction(ByVal sender As System.Object, ByVal e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent)

    End Sub

    Private Sub tmrClear_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrClear.Tick
        clr1()
    End Sub
    Sub clr1()
        ' Dim lup As Integer
        ''lup = 0
        'For lup = 0 To lup = 1000
        'If lup = 1000 Then
        T1IdNo.Text = "____________________"
        T1Name.Text = "____________________"
        T1Gy.Text = "____________________"
        T1Sec.Text = "____________________"
        T1StudPic.Image = Nothing
        T1InOut.Text = "____________________"
        T1Stat.Text = "____________________"
        sysMsg.Text = My.Settings.Sys_Msg
        tmrClear.Enabled = False
        ' End If
        ' Next
        'End If
        'lup = lup + 1
        ' Next
    End Sub
    Sub clr2()

        'Dim lup As Long
        'lup = 0
        ' For lup = 0 To lup = 500
        'If lup = 500 Then
        T2IdNo.Text = "____________________"
        T2Name.Text = "____________________"
        T2Gy.Text = "____________________"
        T2Sec.Text = "____________________"
        T2StudPic.Image = Nothing
        T2InOut.Text = "____________________"
        T2Stat.Text = "____________________"
        sysMsg.Text = My.Settings.Sys_Msg
        tmrClear2.Enabled = False
        'End If
        ' lup = lup + 1
        ' Next
    End Sub
    Sub clr3()
        'Dim lup As Long
        '  lup = 0
        '  For lup = 0 To lup = 500
        'If lup = 500 Then
        T3IdNo.Text = "____________________"
        T3Name.Text = "____________________"
        T3Gy.Text = "____________________"
        T3Sec.Text = "____________________"
        T3StudPic.Image = Nothing
        T3InOut.Text = "____________________"
        T3Stat.Text = "____________________"
        sysMsg.Text = My.Settings.Sys_Msg
        tmrClear3.Enabled = False
        '  End If
        '  lup = lup + 1
        ' Next
    End Sub
    Sub clr4()
        ' Dim lup As Long
        ' lup = 0
        ' For lup = 0 To lup = 500
        'If lup = 500 Then
        T4IdNO.Text = "____________________"
        T4Name.Text = "____________________"
        T4Gy.Text = "____________________"
        T4Sec.Text = "____________________"
        T4StudPic.Image = Nothing
        T4InOut.Text = "____________________"
        T4Stat.Text = "____________________"
        sysMsg.Text = My.Settings.Sys_Msg
        tmrClear4.Enabled = False
        ' End If
        ' lup = lup + 1
        ' Next
    End Sub

    Private Sub tmrPing3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub tmrPingDev1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        devPingT1(frmConDev.T1DevIp1.Text, frmConDev.T1DevIp2.Text)
    End Sub
    Private Sub tmrPingDev2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        devPingT2(frmConDev.T2DevIp1.Text, frmConDev.T2DevIp2.Text)
    End Sub
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        frmLogin.ShowDialog()
        frmLogin.txtUser.Focus()
    End Sub
    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click

    End Sub

    Private Sub ReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsToolStripMenuItem.Click

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        logout()
        lock()
        'If txtAdmin.Text = "fernan" Then
        Exit Sub
        ' End If
        'outsve()
        'txtAdmin.Text = vbNullString
        Access = vbNullString
    End Sub
    Sub outsve()
        Dim rs As New Recordset
        Dim rs2 As New Recordset
        rs = New Recordset
        'rs = conSql.Execute("Select * from tblUserAcc where Username = '" & txtAdmin.Text & "'")
        If rs.EOF = False Then

            'Dim ad As String
            rs2 = New Recordset
            rs2.Open("select * from tblAccHistory", conSql, 1, 2)
            'ad = rs.RecordCount + 1
            rs2.AddNew()
            rs2("Username").Value = rs("Username").Value
            rs2("Name").Value = rs("Name").Value
            rs2("Designation").Value = rs("Designation").Value
            rs2("LogType").Value = "Out"
            rs2("LogsHistory").Value = Format(Now, "General Date")
            rs2.Update()
        End If

    End Sub

    Private Sub AttendanceRuleToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AttendanceRecordToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub Dev1_OnAttTransaction_1(ByVal sender As System.Object, ByVal e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent)
        If VerPathCon() = False Then
            frmDBPathCon.ShowDialog()
            Exit Sub
        End If
        T1lblTime.Text = "Time In :"
        T1lblTime.Left = 306
        T1lblTime.Top = 181
        frmmsgIn.Close()
        frmMsgOut.Close()

        entInfo(e.enrollNumber)
        If InVer(T1IdNo.Text) = True Then
            tmrClear.Enabled = False
            tmrClear.Enabled = True
            frmmsgIn.ShowDialog()
            Exit Sub
        End If
        'remIn(lblRealTime.Text)
        getIDlog()
        inCapture()
        'realInSave()

        'EntCap.Visible = True
        'EntCap.Image = Get_ImageIn(idLog)

        Delete_Image()
        'LstTimeIn.Clear()
        filllist()
        tmrClear.Enabled = False
        tmrClear.Enabled = True
        ' If StatDev2.Text = "Disconnected" Then
        Exit Sub
        'End If
        T1Dev2.EnableUser(1, e.enrollNumber, 1, e.verifyMethod, True)
        T1Dev1.EnableUser(1, e.enrollNumber, 1, e.verifyMethod, False)
    End Sub

    Private Sub Dev2_OnAttTransaction_1(ByVal sender As System.Object, ByVal e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent)
        If VerPathCon() = False Then
            frmConDB.ShowDialog()
            Exit Sub
        End If
        T1lblTime.Text = "Time Out :"
        T1lblTime.Left = 292
        T1lblTime.Top = 181
        frmmsgIn.Close()
        frmMsgOut.Close()

        entInfo(e.enrollNumber)
        If OutVer(T1IdNo.Text) = True Then
            tmrClear.Enabled = False
            tmrClear.Enabled = True
            frmMsgOut.ShowDialog()
            Exit Sub
        End If
        getIDlogOut()
        outCapture()
        'realOutSave()
        Delete_Image()

        'EntCap.Visible = True
        'EntCap.Image = Get_PicEnt(idLog)

        'ExtCap.Visible = True
        'ExtCap.Image = Get_PicExt(idLog)

        ' delInLog()
        filllist()
        tmrClear.Enabled = False
        tmrClear.Enabled = True
        'If StatDev1.Text = "Disconnected" Then
        'Exit Sub
        'End If
        T1Dev1.EnableUser(1, e.enrollNumber, 1, e.verifyMethod, True)
        T1Dev2.EnableUser(1, e.enrollNumber, 1, e.verifyMethod, False)
    End Sub

    Private Sub ByDateAndTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByDateAndTimeToolStripMenuItem.Click
        If PingMe(Ip) = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If
        frmLogs.ShowDialog()
    End Sub


    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub ToolStripStatusLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AccLogsHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccLogsHistoryToolStripMenuItem.Click
        frmLogsHistory.ShowDialog()
    End Sub

    Private Sub EntCap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Pic2Sa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel7_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub


    Private Sub DatabaseConnectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatabaseConnectionToolStripMenuItem.Click
        frmConDB.ShowDialog()
    End Sub
    Sub cnv()
        tmeNw = vbNullString
        tmeNw = Format(Now, "HH:mm:ss")
    End Sub
    Sub stOut(ByVal id As String)
        Dim rs As New Recordset
        rs = conSql.Execute("select * from tblTimeIn where IDNumber '" & id & "'")
        If rs.EOF = False Then
            Outst = rs("Status").Value
        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub CmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub cmdLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        frmStudent.ShowDialog()
    End Sub

    Private Sub DesignatePicturePathToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesignatePicturePathToolStripMenuItem.Click
        frmPicPath.ShowDialog()
    End Sub

    Private Sub SystemMessageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemMessageToolStripMenuItem.Click
        frmMsg.ShowDialog()
    End Sub

    Private Sub AttendanceRuleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttendanceRuleToolStripMenuItem.Click
        frmAttRule.ShowDialog()
    End Sub

    Private Sub tmrEvent_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEvent.Tick
        T1Dev1.BASE64 = 0
        T1Dev1.RegEvent(1, 32767)

        T1Dev2.BASE64 = 0
        T1Dev2.RegEvent(1, 32767)

        T2Dev1.BASE64 = 0
        T2Dev1.RegEvent(devNo, 32767)

        T2Dev2.BASE64 = 0
        T2Dev2.RegEvent(1, 32767)

        T3Dev1.BASE64 = 0
        T3Dev1.RegEvent(1, 32767)

        T3Dev2.BASE64 = 0
        T3Dev2.RegEvent(devNo, 32767)

        T4Dev1.BASE64 = 0
        T4Dev1.RegEvent(1, 32767)

        T4Dev2.BASE64 = 0
        T4Dev2.RegEvent(1, 32767)
    End Sub

    Private Sub tmrClear2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrClear2.Tick
        clr2()
        ' sysMsg.Text = My.Settings.Sys_Msg
    End Sub

    Private Sub tmrClear3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrClear3.Tick
        clr3()
        ' sysMsg.Text = My.Settings.Sys_Msg
    End Sub

    Private Sub tmrClear4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrClear4.Tick
        clr4()
        'sysMsg.Text = My.Settings.Sys_Msg
    End Sub

    Private Sub Panel7_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub
    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub
    Sub antipsb1(ByVal enroler As Integer, ByVal veri As Integer)
        If T1Dev2Stat.Text = "Connected" Then
            T1Dev2.EnableUser(1, enroler, 1, veri, True)
            T1Dev1.EnableUser(1, enroler, 1, veri, False)
        Else

        End If

        If T2Dev2Stat.Text = "Connected" Then
            T2Dev2.EnableUser(1, enroler, 1, veri, True)
            T2Dev1.EnableUser(1, enroler, 1, veri, False)
        Else

        End If

        If T3Dev2Stat.Text = "Connected" Then
            T3Dev2.EnableUser(1, enroler, 1, veri, True)
            T3Dev1.EnableUser(1, enroler, 1, veri, False)
        Else

        End If

        If T4Dev2Stat.Text = "Connected" Then
            T4Dev2.EnableUser(1, enroler, 1, veri, True)
            T4Dev1.EnableUser(1, enroler, 1, veri, False)
        Else

        End If
    End Sub
    Sub antipsb11(ByVal enroler As Integer, ByVal veri As Integer)
        If T4Dev2Stat.Text = "Connected" Then
            T4Dev2.EnableUser(1, enroler, 1, veri, True)
            T4Dev1.EnableUser(1, enroler, 1, veri, False)
        Else

        End If

        If T3Dev2Stat.Text = "Connected" Then
            T3Dev2.EnableUser(1, enroler, 1, veri, True)
            T3Dev1.EnableUser(1, enroler, 1, veri, False)
        Else

        End If

        If T2Dev2Stat.Text = "Connected" Then
            T2Dev2.EnableUser(1, enroler, 1, veri, True)
            T2Dev1.EnableUser(1, enroler, 1, veri, False)
        Else

        End If

        If T1Dev2Stat.Text = "Connected" Then
            T1Dev2.EnableUser(1, enroler, 1, veri, True)
            T1Dev1.EnableUser(1, enroler, 1, veri, False)
        Else

        End If
    End Sub
    Sub Nopsb1(ByVal enroler As Integer, ByVal veri As Integer)
        If T1Dev2Stat.Text = "Connected" Then
            T1Dev2.EnableUser(1, enroler, 1, veri, True)
            T1Dev1.EnableUser(1, enroler, 1, veri, True)
        Else

        End If

        If T2Dev2Stat.Text = "Connected" Then
            T2Dev2.EnableUser(1, enroler, 1, veri, True)
            T2Dev1.EnableUser(1, enroler, 1, veri, True)
        Else

        End If

        If T3Dev2Stat.Text = "Connected" Then
            T3Dev2.EnableUser(1, enroler, 1, veri, True)
            T3Dev1.EnableUser(1, enroler, 1, veri, True)
        Else

        End If

        If T4Dev2Stat.Text = "Connected" Then
            T4Dev2.EnableUser(1, enroler, 1, veri, True)
            T4Dev1.EnableUser(1, enroler, 1, veri, True)
        Else

        End If
    End Sub
    Sub Nopsb11(ByVal enroler As Integer, ByVal veri As Integer)
        If T4Dev2Stat.Text = "Connected" Then
            T4Dev2.EnableUser(1, enroler, 1, veri, True)
            T4Dev1.EnableUser(1, enroler, 1, veri, True)
        Else

        End If
        If T3Dev2Stat.Text = "Connected" Then
            T3Dev2.EnableUser(1, enroler, 1, veri, True)
            T3Dev1.EnableUser(1, enroler, 1, veri, True)
        Else

        End If

        If T2Dev2Stat.Text = "Connected" Then
            T2Dev2.EnableUser(1, enroler, 1, veri, True)
            T2Dev1.EnableUser(1, enroler, 1, veri, True)
        Else

        End If

        If T1Dev2Stat.Text = "Connected" Then
            T1Dev2.EnableUser(1, enroler, 1, veri, True)
            T1Dev1.EnableUser(1, enroler, 1, veri, True)
        Else

        End If
    End Sub
    Sub antipsb2(ByVal enroler As Integer, ByVal veri As Integer)

        If T1Dev1Stat.Text = "Connected" Then
            T1Dev1.EnableUser(1, enroler, 1, veri, True)
            T1Dev2.EnableUser(1, enroler, 1, veri, False)
        Else

        End If

        If T2Dev1Stat.Text = "Connected" Then
            T2Dev1.EnableUser(1, enroler, 1, veri, True)
            T2Dev2.EnableUser(1, enroler, 1, veri, False)
        Else

        End If

        If T3Dev1Stat.Text = "Connected" Then
            T3Dev1.EnableUser(1, enroler, 1, veri, True)
            T3Dev2.EnableUser(1, enroler, 1, veri, False)
        Else

        End If

        If T4Dev1Stat.Text = "Connected" Then
            T4Dev1.EnableUser(1, enroler, 1, veri, True)
            T4Dev2.EnableUser(1, enroler, 1, veri, False)
        Else

        End If
    End Sub
    Sub antipsb22(ByVal enroler As Integer, ByVal veri As Integer)
        If T4Dev1Stat.Text = "Connected" Then
            T4Dev1.EnableUser(1, enroler, 1, veri, True)
            T4Dev2.EnableUser(1, enroler, 1, veri, False)
        Else

        End If

        If T3Dev1Stat.Text = "Connected" Then
            T3Dev1.EnableUser(1, enroler, 1, veri, True)
            T3Dev2.EnableUser(1, enroler, 1, veri, False)
        Else

        End If

        If T2Dev1Stat.Text = "Connected" Then
            T2Dev1.EnableUser(1, enroler, 1, veri, True)
            T2Dev2.EnableUser(1, enroler, 1, veri, False)
        Else

        End If

        If T1Dev1Stat.Text = "Connected" Then
            T1Dev1.EnableUser(1, enroler, 1, veri, True)
            T1Dev2.EnableUser(1, enroler, 1, veri, False)
        Else

        End If
    End Sub
    Sub Nopsb2(ByVal enroler As Integer, ByVal veri As Integer)
        If T1Dev1Stat.Text = "Connected" Then
            T1Dev1.EnableUser(1, enroler, 1, veri, True)
            T1Dev2.EnableUser(1, enroler, 1, veri, True)
        Else

        End If

        If T2Dev1Stat.Text = "Connected" Then
            T2Dev1.EnableUser(1, enroler, 1, veri, True)
            T2Dev2.EnableUser(1, enroler, 1, veri, True)
        Else

        End If

        If T3Dev1Stat.Text = "Connected" Then
            T3Dev1.EnableUser(1, enroler, 1, veri, True)
            T3Dev2.EnableUser(1, enroler, 1, veri, True)
        Else

        End If

        If T4Dev1Stat.Text = "Connected" Then
            T4Dev1.EnableUser(1, enroler, 1, veri, True)
            T4Dev2.EnableUser(1, enroler, 1, veri, True)
        Else

        End If
    End Sub
    Sub Nopsb22(ByVal enroler As Integer, ByVal veri As Integer)
        If T4Dev1Stat.Text = "Connected" Then
            T4Dev1.EnableUser(1, enroler, 1, veri, True)
            T4Dev2.EnableUser(1, enroler, 1, veri, True)
        Else

        End If

        If T3Dev1Stat.Text = "Connected" Then
            T3Dev1.EnableUser(1, enroler, 1, veri, True)
            T3Dev2.EnableUser(1, enroler, 1, veri, True)
        Else

        End If

        If T2Dev1Stat.Text = "Connected" Then
            T2Dev1.EnableUser(1, enroler, 1, veri, True)
            T2Dev2.EnableUser(1, enroler, 1, veri, True)
        Else

        End If

        If T1Dev1Stat.Text = "Connected" Then
            T1Dev1.EnableUser(1, enroler, 1, veri, True)
            T1Dev2.EnableUser(1, enroler, 1, veri, True)
        Else

        End If
    End Sub
    Private Sub CmdLogin_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLogin.Click
        frmLogin.ShowDialog()
        frmLogin.txtUser.Focus()
    End Sub

    Private Sub cmdLogOut_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogOut.Click
        logout()
        lock()
        'If txtAdmin.Text = "fernan" Then
        Exit Sub
        ' End If
        'outsve()
        'txtAdmin.Text = vbNullString
        Access = vbNullString
    End Sub

    Private Sub ToolStripButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        If MsgBox("Are you sure do you want to exit?    ", vbYesNo + vbQuestion + vbDefaultButton2, "Exit") = vbYes Then
            t1devDisCon()
            t2devDisCon()
            t3devDisCon()
            t4devDisCon()
            'CAM_CLOSE()
            Application.Exit()
        End If
    End Sub




    Private Sub T1StudPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel10_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        frmPassBack.ShowDialog()
    End Sub

    Private Sub T1Dev1_OnAttTransaction_3(ByVal sender As System.Object, ByVal e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent) Handles T1Dev1.OnAttTransaction
        If PingMe(Ip) = False Then
            frmConDB.ShowDialog()
            Exit Sub
        End If

        If verAttrul() = True Then
            MsgBox("Please set attendance rule!    ", vbExclamation, "Attendance Rule")
            frmAttRule.ShowDialog()
            Exit Sub
        End If

        If psb() = True Then
            frmPassBack.ShowDialog()
            MsgBox("Please set Anti Passback settings!    ", vbExclamation, "Anti Passback")
            Exit Sub
        End If

        sysMsg.Text = My.Settings.Sys_Msg

        T1lblTime.Text = "Time In :"
        T1lblTime.Left = 35
        T1lblTime.Top = 164

        cnv()
        remIn(tmeNw)
        T1Stat.Text = rema

        T1Info(e.enrollNumber)
        If infoStat = "Emp" Then
            If InVer2(T1IdNo.Text) = True Then
                tmrClear.Enabled = False
                tmrClear.Enabled = True
                sysMsg.Text = "USER ALREADY LOGIN!"
                Exit Sub
            End If
        Else
            If InVer(T1IdNo.Text) = True Then
                tmrClear.Enabled = False
                tmrClear.Enabled = True
                sysMsg.Text = "USER ALREADY LOGIN!"
                Exit Sub
            End If
        End If
        If infoStat = "Emp" Then
            idLog = vbNullString
            getIDlogEmp()
            T1EmpInSave()
        Else
            idLog = vbNullString
            getIDlog()
            T1InSave()
        End If
        tmrClear.Enabled = False
        tmrClear.Enabled = True

        If My.Settings.PSb_Set = "OnPSB" Then
            antipsb1(e.enrollNumber, e.verifyMethod)
            'antipsb11(e.enrollNumber, e.verifyMethod)
            Exit Sub
        Else
            Nopsb1(e.enrollNumber, e.verifyMethod)
            'Nopsb11(e.enrollNumber, e.verifyMethod)
        End If
    End Sub

    Private Sub T1Dev2_OnAttTransaction(ByVal sender As System.Object, ByVal e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent) Handles T1Dev2.OnAttTransaction
        If PingMe(Ip) = False Then
            frmConDB.ShowDialog()
            Exit Sub
        End If

        If psb() = True Then
            frmPassBack.ShowDialog()
            MsgBox("Please set Anti Passback settings!    ", vbExclamation, "Anti Passback")
            Exit Sub
        End If

        sysMsg.Text = My.Settings.Sys_Msg

        T1lblTime.Text = "Time Out :"
        T1lblTime.Left = 21
        T1lblTime.Top = 164

        T1Info(e.enrollNumber)

        If infoStat = "Emp" Then
            If OutVer2(T1IdNo.Text) = True Then
                tmrClear.Enabled = False
                tmrClear.Enabled = True
                sysMsg.Text = "LOGIN FIRST!"
                Exit Sub
            End If
        Else
            If OutVer(T1IdNo.Text) = True Then
                tmrClear.Enabled = False
                tmrClear.Enabled = True
                sysMsg.Text = "LOGIN FIRST!"
                Exit Sub
            End If
        End If

        If infoStat = "Emp" Then
            idLog2 = vbNullString
            getIDlogOut2()
            t1EmpOutSave(T1IdNo.Text)
            delInLog2(T1IdNo.Text)
        Else
            idLog2 = vbNullString
            getIDlogOut()
            t1OutSave(T1IdNo.Text)
            delInLog(T1IdNo.Text)
        End If

        tmrClear.Enabled = False
        tmrClear.Enabled = True

        If My.Settings.PSb_Set = "OnPSB" Then
            antipsb2(e.enrollNumber, e.verifyMethod)
            'antipsb22(e.enrollNumber, e.verifyMethod
            Exit Sub
        Else
            Nopsb2(e.enrollNumber, e.verifyMethod)
            '(e.enrollNumber, e.verifyMethod)
        End If
    End Sub

    Private Sub T2Dev1_OnAttTransaction_3(ByVal sender As System.Object, ByVal e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent) Handles T2Dev1.OnAttTransaction
        If PingMe(Ip) = False Then
            frmConDB.ShowDialog()
            Exit Sub
        End If

        If verAttrul() = True Then
            MsgBox("Please set attendance rule!    ", vbExclamation, "Attendance Rule")
            frmAttRule.ShowDialog()
            Exit Sub
        End If

        If psb() = True Then
            frmPassBack.ShowDialog()
            MsgBox("Please set Anti Passback settings!    ", vbExclamation, "Anti Passback")
            Exit Sub
        End If

        sysMsg.Text = My.Settings.Sys_Msg

        T2lblTime.Text = "Time In :"
        T2lblTime.Left = 35
        T2lblTime.Top = 164

        cnv()
        remIn(tmeNw)
        T2Stat.Text = rema

        T2Info(e.enrollNumber)
        If infoStat = "Emp" Then
            If InVer2(T2IdNo.Text) = True Then
                tmrClear2.Enabled = False
                tmrClear2.Enabled = True
                sysMsg.Text = "USER ALREADY LOGIN!"
                Exit Sub
            End If
        Else
            If InVer(T2IdNo.Text) = True Then
                tmrClear2.Enabled = False
                tmrClear2.Enabled = True
                sysMsg.Text = "USER ALREADY LOGIN!"
                Exit Sub
            End If
        End If

        If infoStat = "Emp" Then
            idLog = vbNullString
            getIDlogEmp()
            T2EmpInSave()
        Else
            idLog = vbNullString
            getIDlog()
            T2InSave()
        End If
        tmrClear2.Enabled = False
        tmrClear2.Enabled = True

        If My.Settings.PSb_Set = "OnPSB" Then
            antipsb1(e.enrollNumber, e.verifyMethod)
            'antipsb11(e.enrollNumber, e.verifyMethod)
            Exit Sub
        Else
            Nopsb1(e.enrollNumber, e.verifyMethod)
            'Nopsb11(e.enrollNumber, e.verifyMethod)
        End If
    End Sub

    Private Sub T2Dev2_OnAttTransaction_3(ByVal sender As System.Object, ByVal e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent) Handles T2Dev2.OnAttTransaction
        If PingMe(Ip) = False Then
            frmConDB.ShowDialog()
            Exit Sub
        End If

        If psb() = True Then
            frmPassBack.ShowDialog()
            MsgBox("Please set Anti Passback settings!    ", vbExclamation, "Anti Passback")
            Exit Sub
        End If

        sysMsg.Text = My.Settings.Sys_Msg

        T2lblTime.Text = "Time Out :"
        T2lblTime.Left = 21
        T2lblTime.Top = 164

        T2Info(e.enrollNumber)
        If infoStat = "Emp" Then
            If OutVer2(T2IdNo.Text) = True Then
                tmrClear2.Enabled = False
                tmrClear2.Enabled = True
                sysMsg.Text = "LOGIN FIRST!"
                Exit Sub
            End If
        Else
            If OutVer(T2IdNo.Text) = True Then
                tmrClear2.Enabled = False
                tmrClear2.Enabled = True
                sysMsg.Text = "LOGIN FIRST!"
                Exit Sub
            End If
        End If

        If infoStat = "Emp" Then
            idLog2 = vbNullString
            getIDlogOut2()
            t2EmpOutSave(T2IdNo.Text)
            delInLog2(T2IdNo.Text)
        Else
            idLog2 = vbNullString
            getIDlogOut()
            t2OutSave(T2IdNo.Text)
            delInLog(T2IdNo.Text)
        End If
        tmrClear2.Enabled = False
        tmrClear2.Enabled = True

        If My.Settings.PSb_Set = "OnPSB" Then
            antipsb2(e.enrollNumber, e.verifyMethod)
            'antipsb22(e.enrollNumber, e.verifyMethod)
            Exit Sub
        Else
            Nopsb2(e.enrollNumber, e.verifyMethod)
            'Nopsb22(e.enrollNumber, e.verifyMethod)
        End If
    End Sub
    Private Sub T2Dev2_OnAttTransaction_2(ByVal sender As System.Object, ByVal e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent)
        If PingMe(Ip) = False Then
            frmConDB.ShowDialog()
            Exit Sub
        End If

        If psb() = True Then
            frmPassBack.ShowDialog()
            MsgBox("Please set Anti Passback settings!    ", vbExclamation, "Anti Passback")
            Exit Sub
        End If

        sysMsg.Text = My.Settings.Sys_Msg

        T2lblTime.Text = "Time Out :"
        T2lblTime.Left = 21
        T2lblTime.Top = 164

        T2Info(e.enrollNumber)

        If OutVer(T2IdNo.Text) = True Then
            tmrClear2.Enabled = False
            tmrClear2.Enabled = True
            sysMsg.Text = "LOGIN FIRST!"
            Exit Sub
        End If
        idLog2 = vbNullString
        getIDlogOut()
        t2OutSave(T2IdNo.Text)
        delInLog(T2IdNo.Text)

        tmrClear2.Enabled = False
        tmrClear2.Enabled = True

        If My.Settings.PSb_Set = "OnPSB" Then
            antipsb2(e.enrollNumber, e.verifyMethod)
            'antipsb22(e.enrollNumber, e.verifyMethod)
            Exit Sub
        Else
            Nopsb2(e.enrollNumber, e.verifyMethod)
            ' Nopsb22(e.enrollNumber, e.verifyMethod)
        End If
    End Sub

    Private Sub T3Dev1_OnAttTransaction_3(ByVal sender As System.Object, ByVal e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent) Handles T3Dev1.OnAttTransaction
        If PingMe(Ip) = False Then
            frmConDB.ShowDialog()
            Exit Sub
        End If

        If verAttrul() = True Then
            MsgBox("Please set attendance rule!    ", vbExclamation, "Attendance Rule")
            frmAttRule.ShowDialog()
            Exit Sub
        End If

        If psb() = True Then
            frmPassBack.ShowDialog()
            MsgBox("Please set Anti Passback settings!    ", vbExclamation, "Anti Passback")
            Exit Sub
        End If

        sysMsg.Text = My.Settings.Sys_Msg

        T3lblTime.Text = "Time In :"
        T3lblTime.Left = 35
        T3lblTime.Top = 164

        cnv()
        remIn(tmeNw)
        T3Stat.Text = rema

        T3Info(e.enrollNumber)
        If infoStat = "Emp" Then
            If InVer2(T3IdNo.Text) = True Then
                tmrClear3.Enabled = False
                tmrClear3.Enabled = True
                sysMsg.Text = "USER ALREADY LOGIN!"
                Exit Sub
            End If
        Else
            If InVer(T3IdNo.Text) = True Then
                tmrClear3.Enabled = False
                tmrClear3.Enabled = True
                sysMsg.Text = "USER ALREADY LOGIN!"
                Exit Sub
            End If
        End If

        If infoStat = "Emp" Then
            idLog = vbNullString
            getIDlogEmp()
            T3EmpInSave()
        Else
            idLog = vbNullString
            getIDlog()
            T3InSave()
        End If
        tmrClear3.Enabled = False
        tmrClear3.Enabled = True

        If My.Settings.PSb_Set = "OnPSB" Then
            antipsb1(e.enrollNumber, e.verifyMethod)
            'antipsb11(e.enrollNumber, e.verifyMethod)
            Exit Sub
        Else
            Nopsb1(e.enrollNumber, e.verifyMethod)
            'Nopsb11(e.enrollNumber, e.verifyMethod)
        End If
    End Sub

    Private Sub T3Dev2_OnAttTransaction_2(ByVal sender As System.Object, ByVal e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent) Handles T3Dev2.OnAttTransaction
        If PingMe(Ip) = False Then
            frmConDB.ShowDialog()
            Exit Sub
        End If

        If psb() = True Then
            frmPassBack.ShowDialog()
            MsgBox("Please set Anti Passback settings!    ", vbExclamation, "Anti Passback")
            Exit Sub
        End If

        sysMsg.Text = My.Settings.Sys_Msg

        T3lblTime.Text = "Time Out :"
        T3lblTime.Left = 21
        T3lblTime.Top = 164

        T3Info(e.enrollNumber)
        If infoStat = "Emp" Then
            If OutVer2(T3IdNo.Text) = True Then
                tmrClear3.Enabled = False
                tmrClear3.Enabled = True
                sysMsg.Text = "LOGIN FIRST!"
                Exit Sub
            End If
        Else
            If OutVer(T3IdNo.Text) = True Then
                tmrClear3.Enabled = False
                tmrClear3.Enabled = True
                sysMsg.Text = "LOGIN FIRST!"
                Exit Sub
            End If
        End If

        If infoStat = "Emp" Then
            idLog2 = vbNullString
            getIDlogOut2()
            t3EmpOutSave(T3IdNo.Text)
            delInLog2(T3IdNo.Text)
        Else
            idLog2 = vbNullString
            getIDlogOut()
            t3OutSave(T3IdNo.Text)
            delInLog(T3IdNo.Text)
        End If

        tmrClear3.Enabled = False
        tmrClear3.Enabled = True

        If My.Settings.PSb_Set = "OnPSB" Then
            antipsb2(e.enrollNumber, e.verifyMethod)
            'antipsb22(e.enrollNumber, e.verifyMethod)
            Exit Sub
        Else
            Nopsb2(e.enrollNumber, e.verifyMethod)
            ' Nopsb22(e.enrollNumber, e.verifyMethod)
        End If
    End Sub

    Private Sub T4Dev1_OnAttTransaction_2(ByVal sender As System.Object, ByVal e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent) Handles T4Dev1.OnAttTransaction
        If PingMe(Ip) = False Then
            frmConDB.ShowDialog()
            Exit Sub
        End If

        If verAttrul() = True Then
            MsgBox("Please set attendance rule!    ", vbExclamation, "Attendance Rule")
            frmAttRule.ShowDialog()
            Exit Sub
        End If

        If psb() = True Then
            frmPassBack.ShowDialog()
            MsgBox("Please set Anti Passback settings!    ", vbExclamation, "Anti Passback")
            Exit Sub
        End If

        sysMsg.Text = My.Settings.Sys_Msg

        T4lblTime.Text = "Time In :"
        T4lblTime.Left = 35
        T4lblTime.Top = 164

        cnv()
        remIn(tmeNw)
        T4Stat.Text = rema

        T4Info(e.enrollNumber)
        If infoStat = "Emp" Then
            If InVer2(T4IdNO.Text) = True Then
                tmrClear4.Enabled = False
                tmrClear4.Enabled = True
                sysMsg.Text = "USER ALREADY LOGIN!"
                Exit Sub
            End If
        Else
            If InVer(T4IdNO.Text) = True Then
                tmrClear4.Enabled = False
                tmrClear4.Enabled = True
                sysMsg.Text = "USER ALREADY LOGIN!"
                Exit Sub
            End If
        End If

        If infoStat = "Emp" Then
            idLog = vbNullString
            getIDlogEmp()
            T4EmpInSave()
        Else
            idLog = vbNullString
            getIDlog()
            T4InSave()
        End If
        tmrClear4.Enabled = False
        tmrClear4.Enabled = True

        If My.Settings.PSb_Set = "OnPSB" Then
            antipsb1(e.enrollNumber, e.verifyMethod)
            Exit Sub
            'antipsb11(e.enrollNumber, e.verifyMethod)
        Else
            Nopsb1(e.enrollNumber, e.verifyMethod)
            ' Nopsb11(e.enrollNumber, e.verifyMethod)
        End If
    End Sub

    Private Sub T4Dev2_OnAttTransaction_2(ByVal sender As System.Object, ByVal e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent) Handles T4Dev2.OnAttTransaction
        If PingMe(Ip) = False Then
            frmConDB.ShowDialog()
            Exit Sub
        End If

        If psb() = True Then
            frmPassBack.ShowDialog()
            MsgBox("Please set Anti Passback settings!    ", vbExclamation, "Anti Passback")
            Exit Sub
        End If

        sysMsg.Text = My.Settings.Sys_Msg

        T4lblTime.Text = "Time Out :"
        T4lblTime.Left = 21
        T4lblTime.Top = 164

        T4Info(e.enrollNumber)

        If infoStat = "Emp" Then
            If OutVer2(T4IdNO.Text) = True Then
                tmrClear4.Enabled = False
                tmrClear4.Enabled = True
                sysMsg.Text = "LOGIN FIRST!"
                Exit Sub
            End If
        Else
            If OutVer(T4IdNO.Text) = True Then
                tmrClear4.Enabled = False
                tmrClear4.Enabled = True
                sysMsg.Text = "LOGIN FIRST!"
                Exit Sub
            End If
        End If

        If infoStat = "Emp" Then
            idLog2 = vbNullString
            getIDlogOut2()
            t4EmpOutSave(T4IdNO.Text)
            delInLog2(T4IdNO.Text)
        Else
            idLog2 = vbNullString
            getIDlogOut()
            t4OutSave(T4IdNO.Text)
            delInLog(T4IdNO.Text)
        End If
        tmrClear4.Enabled = False
        tmrClear4.Enabled = True

        If My.Settings.PSb_Set = "OnPSB" Then
            antipsb2(e.enrollNumber, e.verifyMethod)
            'antipsb22(e.enrollNumber, e.verifyMethod)
            Exit Sub
        Else
            Nopsb2(e.enrollNumber, e.verifyMethod)
            'Nopsb22(e.enrollNumber, e.verifyMethod)
        End If
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        frmEmp.ShowDialog()
    End Sub

    Private Sub EmployeeLogsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeLogsToolStripMenuItem.Click
        frmEmpLogs.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        If File.Exists(Application.StartupPath & "\prjAbout.exe") Then
            Shell(Application.StartupPath & "\prjAbout.exe", AppWinStyle.NormalFocus)
        End If
    End Sub
End Class
