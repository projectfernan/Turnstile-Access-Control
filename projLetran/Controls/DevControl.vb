Imports ADODB

Imports System
Imports Microsoft.VisualBasic

Imports System.IO
Imports System.IO.Path

Imports System.Drawing.Imaging
Imports System.Threading

Public Class DevControl
    Public DevC_Name As String
    Public DevC_Ip As String
    Public DevC_Frame As String
    Public DevC_Stat As String
    Public DevC_Delay As Long

    Public DvrC_IP As String
    Public DvrC_UID As String
    Public DvrC_PWD As String
    Public DvrC_Port As String
    Public DvrC_Cam_Chan As String
    Public DvrC_Cam_Capture As String

    Public Cam_ID As Integer

    Public idPicno As String

    Dim ccCode As String = vbNullString
    Public Delegate Function DevConnect(ByVal ip As String)
    Public Delegate Sub DevRegEvent()
    Public Delegate Sub DevAccessControl(ByVal Acno As Integer)
    Public Delegate Sub DevUnlocked()

    Public Delegate Sub Delreconn()
    Public KeepAliveDelegate As Threading.TimerCallback
    Public KeepAliveTimer As System.Threading.Timer

    Dim tmeClrReset As Boolean
    Public Delegate Sub DelClearSub()
    Public KeepAliveDelegateClr As Threading.TimerCallback
    Public KeepAliveTimerClr As System.Threading.Timer

    Public Delegate Sub DevOntrans(ByVal crdCode As Long)


    Public Structure DEv_Control
        Public DevC_Name As String
        Public DevC_Ip As String
        Public DevC_Frame As String
        Public DevC_lane As String
        Public DevC_Stat As String
        Public DevC_Delay As Integer
    End Structure

    Dim DevC_Structure As New DEv_Control

    Sub SubUnlocked()
        If (InvokeRequired) Then
            Invoke(New DevUnlocked(AddressOf SubUnlocked))
        Else
            Dev1.ACUnlock(1, My.Settings.LockDelay)
            Dev1.RegEvent(1, 32767)
        End If
    End Sub

    Private Sub KeepAliveTimerHandler(ByVal state As Object)
        Dim th As New Thread(New ThreadStart(Sub() Reconn()))
        th.Start()
    End Sub

    Private Sub KeepAliveTimerClrHandler(ByVal state As Object)
        Dim thc As New Thread(New ThreadStart(Sub() clearSub()))
        thc.Start()
    End Sub

    Private Sub Reconn()
        If (InvokeRequired) Then
            Invoke(New Delreconn(AddressOf Reconn))
        Else
            Try
                KeepAliveTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite)

                If PingMe(DevC_Structure.DevC_Ip) = False Then
                    ConnDevCnt = 0

                    DevStat.Text = "Disconnected"
                    DevStat.ForeColor = Color.Pink

                    KeepAliveTimer = New System.Threading.Timer(KeepAliveDelegate, Nothing, My.Settings.AutoConnDel, My.Settings.AutoConnDel)
                    KeepAliveTimer.Change(My.Settings.AutoConnDel, My.Settings.AutoConnDel)
                    Exit Sub
                Else
                    ConnDevCnt = ConnDevCnt + 1
                    If My.Settings.AutoReg = True Then
                        Dev1.RegEvent(1, 32767)
                    End If
                End If

                If ConnDevCnt <= 1 Then
                    Dev1.BeginInit()
                    Dev1.RegEvent(1, 32767)

                    DevStat.Text = "Connected"
                    DevStat.ForeColor = Color.Cyan
                End If

                KeepAliveTimer = New System.Threading.Timer(KeepAliveDelegate, Nothing, My.Settings.AutoConnDel, My.Settings.AutoConnDel)
                KeepAliveTimer.Change(My.Settings.AutoConnDel, My.Settings.AutoConnDel)
            Catch ex As Exception
                LetranMain.txtNotice.Text = ex.Message
            End Try
        End If
    End Sub

    Private Sub clearSub()
        If (InvokeRequired) Then
            Invoke(New DelClearSub(AddressOf clearSub))
        Else
            KeepAliveTimerClr.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite)
            tmeClrReset = True
            Try
                With LetranMain
                    .txtStudent.Text = "-"
                    .txtCourse.Text = "-"
                    .txtYear.Text = "-"
                    .txtNotice.Text = "-"
                    .StudPic.Image = Image.FromFile(Application.StartupPath & "\LetranIcod.jpg")
                End With

                'KeepAliveTimer = New System.Threading.Timer(KeepAliveDelegate, Nothing, DevC_Structure.DevC_Delay, DevC_Structure.DevC_Delay)
                'KeepAliveTimer.Change(DevC_Structure.DevC_Delay, DevC_Structure.DevC_Delay)
            Catch ex As Exception
                LetranMain.txtNotice.Text = ex.Message
            End Try
        End If
    End Sub

    Sub Msg(studID As String, stat As Short)
        Dim rs As New Recordset
        Dim rs2 As New Recordset

        rs = New Recordset
        rs = conSql.Execute("select IDnumber,Name,ContactNo from tblstudinfo where IDnumber = '" & studID & "'")
        If rs.EOF = False Then
            'On Error Resume Next
            Try
                rs2 = New Recordset
                rs2.Open("select * from tblMsg", conSql, 1, 2)
                rs2.AddNew()
                rs2("IDnumber").Value = rs("IDnumber").Value
                rs2("Name").Value = rs("Name").Value
                rs2("ContactNo").Value = rs("ContactNo").Value
                rs2("TimeIn").Value = Now
                rs2("Stat").Value = stat
                'rs2("Pic").Value = rs("PHOTO").Value
                rs2.Update()
            Catch ex As Exception
                ' MainSystem.txtSystemErr.Text = ex.Message
            End Try

        End If
    End Sub


    Function inCapture() As String
        Try

            Dim orgCAp As String = Dir(Application.StartupPath & "\EntCapture\JPEGCapture\*.jpeg")
            Return (Application.StartupPath & "\EntCapture\JPEGCapture\" & orgCAp & "")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Function outCapture() As String
        Try
            'CamExit.JPEGCapturePicture(My.Settings.CAM_ChannelCap2, 0, 0, Application.StartupPath & "\EntCapture")
            Dim orgCAp As String = Dir(Application.StartupPath & "\EntCapture\JPEGCapture\*.jpeg")
            Return (Application.StartupPath & "\EntCapture\JPEGCapture\" & orgCAp & "")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Function getIDlog() As String
        If conServer() = False Then Return Nothing

        Try
            Dim rs = New Recordset
            rs = New Recordset
            rs = conSql.Execute("select * from tbltimein order by idlog desc")
            Return rs("idlog").Value.ToString
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Function getIDlogOut() As String
        If conServer() = False Then Return Nothing

        Try
            Dim rs = New Recordset
            rs = New Recordset
            rs = conSql.Execute("select * from tblinout order by InOutID desc")
            Return rs("InOutID").Value
        Catch ex As Exception
            Return Nothing
        End Try
       
    End Function


    Public Function devcon1(ByVal ipAdd As String) As Boolean
        If (InvokeRequired) Then
            Invoke(New DevConnect(AddressOf devcon1), ipAdd)
        Else
            If PingMe(ipAdd) = True Then
                DevStat.Text = "Connected"
                DevStat.ForeColor = Color.Cyan

                Dev1.BeginInit()
                Dev1.Connect_Net(ipAdd, 4370)
                Dev1.BASE64 = 0

                Dev1.RegEvent(1, 32767)

                If My.Settings.AutoPing = True Then
                    KeepAliveTimer = New System.Threading.Timer(KeepAliveDelegate, Nothing, My.Settings.AutoConnDel, My.Settings.AutoConnDel)
                    KeepAliveTimer.Change(My.Settings.AutoConnDel, My.Settings.AutoConnDel)
                End If

                Return True
            Else
                DevStat.Text = "Disconnected"
                DevStat.ForeColor = Color.Pink
                Timer1.Enabled = False
                Return False
            End If
        End If
    End Function

    Private Sub DevControl_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Me.ContextMenuStrip = ContextMenuStrip1
        tmeClrReset = True
        KeepAliveDelegateClr = AddressOf KeepAliveTimerClrHandler
        KeepAliveDelegate = AddressOf KeepAliveTimerHandler


        If DevC_Structure.DevC_Ip = vbNullString Then
            DevC_Structure.DevC_Name = DevStructure.Dev_Name
            DevC_Structure.DevC_Ip = DevStructure.Dev_Ip
            DevC_Structure.DevC_Stat = DevStructure.Dev_Stat
            DevC_Structure.DevC_Delay = DevStructure.Dev_Delay

            txtDevName.Text = DevC_Structure.DevC_Name
            DevStat.Text = DevC_Structure.DevC_Stat

            Dim th As New Thread(New ThreadStart(Function() devcon1(DevC_Structure.DevC_Ip)))
            th.Start()
        End If

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs)
        If MainSystem.txtSystemUser.Text = "Lock" Then
            MsgBox("Please login first! ", vbExclamation, "System")
            Exit Sub
        End If

        Timer1.Enabled = True

        If devcon1(DevC_Ip) = True Then
            MsgBox("Successfully connected! ", vbInformation, "Device")
        Else
            MsgBox("Failed to connect! ", vbInformation, "Device")
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs)
        If MainSystem.txtSystemUser.Text = "Lock" Then
            MsgBox("Please login first! ", vbExclamation, "System")
            Exit Sub
        End If

        If MsgBox("Are you sure do you want to disconnect this reader? ", vbYesNo + vbQuestion + vbDefaultButton2, "Disconnect") = vbYes Then
            Dev1.EndInit()
            Dev1.Disconnect()

            DevStat.Text = "Disconnected"
            DevStat.ForeColor = Color.Pink

            Timer1.Enabled = False

            MsgBox("Reader successfully disconnected! ", vbInformation, "Disconnect")
        End If
    End Sub

    Sub ShowStudInfo1(ByVal id As String)
        If conServer() = False Then Exit Sub

        Try
            With MainControl
                Dim rs = New Recordset
                rs = New Recordset
                rs = conSql.Execute("select * from tblStudInfo where AcNumber = '" & id & "'")
                If rs.EOF = False Then
                    idPicno = rs("IdNumber").Value
                    .T1IdNo.Text = rs("IdNumber").Value
                    .T1Name.Text = rs("Name").Value
                    .T1Gy.Text = rs("Course").Value
                    .T1InOut.Text = Now
                Else
                    .T1IdNo.Text = "Unregistered Card"
                    .T1Name.Text = "Unregistered Card"
                    .T1Gy.Text = "Unregistered Card"
                    .T1InOut.Text = Now
                    .t1pic.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
                End If
            End With
           
        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub ShowStudInfo2(ByVal id As String)
        If conServer() = False Then Exit Sub

        Try
            With MainControl
                Dim rs = New Recordset
                rs = New Recordset
                rs = conSql.Execute("select * from tblStudInfo where AcNumber = '" & id & "'")
                If rs.EOF = False Then
                    idPicno = rs("IdNumber").Value
                    .T2IdNo.Text = rs("IdNumber").Value
                    .T2Name.Text = rs("Name").Value
                    .T2Gy.Text = rs("Course").Value
                    .T2InOut.Text = Now
                Else
                    .T2IdNo.Text = "Unregistered Card"
                    .T2Name.Text = "Unregistered Card"
                    .T2Gy.Text = "Unregistered Card"
                    .T2InOut.Text = Now
                    .t2pic.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
                End If
            End With
          
        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub ShowStudInfo3(ByVal id As String)
        If conServer() = False Then Exit Sub

        Try
            With MainSystem
                Dim rs = New Recordset
                rs = New Recordset
                rs = conSql.Execute("select * from tblStudInfo where AcNumber = '" & id & "'")
                If rs.EOF = False Then
                    idPicno = rs("IdNumber").Value
                    .T3IdNo.Text = rs("IdNumber").Value
                    .T3Name.Text = rs("Name").Value
                    .T3Gy.Text = rs("Course").Value
                    .T3InOut.Text = Now
                Else
                    .T3IdNo.Text = "Unregistered Card"
                    .T3Name.Text = "Unregistered Card"
                    .T3Gy.Text = "Unregistered Card"
                    .T3InOut.Text = Now
                    .t3pic.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
                End If
            End With
           
        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
        End Try
    End Sub


    Sub ShowStudInfo4(ByVal id As String)
        If conServer() = False Then Exit Sub

        Try
            With MainSystem
                Dim rs = New Recordset
                rs = New Recordset
                rs = conSql.Execute("select * from tblStudInfo where AcNumber = '" & id & "'")
                If rs.EOF = False Then
                    idPicno = rs("IdNumber").Value
                    .T4IdNo.Text = rs("IdNumber").Value
                    .T4Name.Text = rs("Name").Value
                    .T4Gy.Text = rs("Course").Value
                    .T4InOut.Text = Now
                Else
                    .T4IdNo.Text = "Unregistered Card"
                    .T4Name.Text = "Unregistered Card"
                    .T4Gy.Text = "Unregistered Card"
                    .T4InOut.Text = Now
                    .t4pic.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
                End If
            End With
           
        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Function buffCapEnt() As String
        If conServer() = False Then Return Nothing

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs.Open("select PicEntCnt from tblentbuffer order by PicEntCnt desc;", conSql, 1, 2)
            If rs.EOF = False Then
                Dim cntNow As String = CInt(rs("PicEntCnt").Value) + 1
                rs("PicEntCnt").Value = cntNow
                rs.Update()
                Return cntNow
            Else
                rs.AddNew()
                rs("PicEntCnt").Value = 1
                rs.Update()
                Return "1"
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Function buffCapExt() As String
        If conServer() = False Then Return Nothing

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs.Open("select * from tblextbuffer order by PicExtCnt desc;", conSql, 1, 2)
            If rs.EOF = False Then
                Dim cntNow As String = CInt(rs("PicExtCnt").Value) + 1
                rs("PicExtCnt").Value = cntNow
                rs.Update()
                Return cntNow
            Else
                rs.AddNew()
                rs("PicExtCnt").Value = 1
                rs.Update()
                Return "1"
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Function t1InCapture(ByVal CapIDno As String, ByVal LogsID As String) As String
        Try
            Dim orgCAp As String
            If Directory.Exists(My.Settings.CapImgPath & "\" & CapIDno) = True Then
            Else
                Directory.CreateDirectory(My.Settings.CapImgPath & "\" & CapIDno)
            End If

            Dim locCapPath As String = My.Settings.CapImgPath & "\" & CapIDno & "\t1EntCapture" & LogsID
            'CamEntry.JPEGCapturePicture(DvrC_Cam_Capture, 0, 0, locCapPath)
            orgCAp = Dir(locCapPath & "\JPEGCapture\*.jpeg")
            With MainControl.EntCap
                .ImageLocation = locCapPath & "\JPEGCapture\" & orgCAp  'Get_ImageName()
                .Load()
            End With
            Return "t1EntCapture" & LogsID
        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
            Return vbNullString
        End Try
    End Function

    Function t2extCapture(ByVal LogsID As String) As String
        Try
            Dim orgCAp As String

            'CamExit.JPEGCapturePicture(DvrC_Cam_Capture, 0, 0, My.Settings.CapImgPath & "\t2ExtCapture" & LogsID & "\")
            orgCAp = Dir(My.Settings.CapImgPath & "\t2ExtCapture" & LogsID & "\JPEGCapture\*.jpeg")
            With MainControl.EntCap2
                .ImageLocation = My.Settings.CapImgPath & "\t2ExtCapture" & LogsID & "\JPEGCapture\" & orgCAp & "" 'Get_ImageNameExt()
                .Load()
            End With
            Return "t2ExtCapture" & LogsID
        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
            Return vbNullString
        End Try
    End Function

    Sub SaveIn(idNo As String, inTime As Date, LogStat As String)
        ' If conServer() = False Then Exit Sub
        Try
            Dim rs = New Recordset
            rs = New Recordset
            rs = conSql.Execute("insert into tbltimein(IDnumber,TimeIn,Status)VALUES('" & idNo & "','" & inTime & "','" & LogStat & "')")   
        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub SaveInWimg(idNo As String, inTime As Date)
        If conServer() = False Then Exit Sub
        Try
            Dim strImg As String = t1InCapture(idNo, buffCapEnt)

            Dim strPetsa As String = Format(inTime, "yyyy-MM-dd HH:mm:ss")
            Dim rs = New Recordset
            rs = New Recordset
            rs = conSql.Execute("insert into tbltimein(IDnumber,TimeIn,FolderName)values('" & idNo & "','" & strPetsa & "','" & strImg & "')")


        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub inOutSaveWimg(ByVal idno As String)
        If conServer() = False Then Exit Sub
        Try
            Dim strImg As String = t2extCapture(buffCapExt)

            Dim rs = New Recordset
            rs = New Recordset
            rs = conSql.Execute("select * from tbltimein where IDnumber = '" & idno & "'")
            Dim strINtime As String = Format(CDate(rs("TimeIn").Value), "yyyy-MM-dd HH:mm:ss")
            Dim strOUTtime As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
            If rs.EOF = False Then
                Dim rs2 As New Recordset
                rs2 = New Recordset
                rs2 = conSql.Execute("insert into tblinout(IDnumber,TimeIn,TimeOut,FolderName)values('" & idno & "','" & strINtime & "','" & strOUTtime & "','" & strImg & "')")
            End If
        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub inOutSave(ByVal idno As String)
        ' If conServer() = False Then Exit Sub
        Try
            Dim rs = New Recordset
            rs = New Recordset
            rs = conSql.Execute("select * from tbltimein where IDnumber = '" & idno & "'")
            If rs.EOF = False Then
                Dim rs2 As New Recordset
                rs2 = New Recordset
                rs2.Open("select * from tblinout where 1=0", conSql, 1, 2)
                rs2.AddNew()
                rs2("IDnumber").Value = idno
                rs2("TimeIn").Value = rs("TimeIn").Value
                rs2("TimeOut").Value = Now
                rs2.Update()
            End If
        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Function CheckIn(ByVal id As String) As Boolean
        If conServer() = False Then Return False
        Dim rs = New Recordset
        rs = New Recordset
        rs = conSql.Execute("select * from tbltimein where IDnumber = '" & id & "'")
        If rs.EOF = False Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub delIn(ByVal idNo As String)
        ' If conServer() = False Then Exit Sub

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSql.Execute("delete from tbltimein where IDnumber = '" & idNo & "'")
        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Private Sub tmeClear1_Tick(sender As System.Object, e As System.EventArgs) Handles tmeClear1.Tick
        With MainSystem
            .T1IdNo.Text = "____________________"
            .T1Name.Text = "____________________"
            .T1Gy.Text = "____________________"
            .T1InOut.Text = "____________________"
            .t1pic.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
            tmeClear1.Enabled = False
        End With
    End Sub

    Private Sub tmeClear2_Tick(sender As System.Object, e As System.EventArgs) Handles tmeClear2.Tick
        With MainSystem
            .T2IdNo.Text = "____________________"
            .T2Name.Text = "____________________"
            .T2Gy.Text = "____________________"
            .T2InOut.Text = "____________________"
            .t2pic.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
            tmeClear2.Enabled = False
        End With
    End Sub

    Private Sub tmeClear3_Tick(sender As System.Object, e As System.EventArgs) Handles tmeClear3.Tick
        With MainSystem
            .T3IdNo.Text = "____________________"
            .T3Name.Text = "____________________"
            .T3Gy.Text = "____________________"
            .T3InOut.Text = "____________________"
            .t3pic.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
            tmeClear3.Enabled = False
        End With
    End Sub

    Private Sub tmeClear4_Tick(sender As System.Object, e As System.EventArgs) Handles tmeClear4.Tick
        With MainSystem
            .T4IdNo.Text = "____________________"
            .T4Name.Text = "____________________"
            .T4Gy.Text = "____________________"
            .T4InOut.Text = "____________________"
            .t4pic.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
            tmeClear4.Enabled = False
        End With
    End Sub

    Private Sub bgwR1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwR1.DoWork
        Try
            Timer1.Enabled = False
            If PingMe(DevC_Ip) = False Then
                ' Dev1.EndInit()
                ' Dev1.Disconnect()
                ConnDevCnt = 0
                e.Result = False
                Exit Sub
            Else
                ConnDevCnt = 1
                e.Result = True
            End If

            If ConnDevCnt < 1 Then
                Dev1.BeginInit()
                e.Result = Dev1.Connect_Net(DevC_Ip, 4370)
                Dev1.RegEvent(1, 1)
            End If
        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Private Sub bgwR1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwR1.RunWorkerCompleted
        Dim p As Boolean = e.Result
        If p = False Then
            MainSystem.txtSystemErr.Text = Now & " Device Disconnected @ " & DevC_Name
            DevStat.Text = "Disconnected"
            DevStat.ForeColor = Color.Pink
            Timer1.Enabled = True
        Else
            MainSystem.txtSystemErr.Text = "---"
            DevStat.Text = "Connected"
            DevStat.ForeColor = Color.Cyan
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If bgwR1.IsBusy = False Then bgwR1.RunWorkerAsync()
        Timer1.Interval = My.Settings.AutoConnDel
    End Sub

    Private Sub RefreshCameraToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'If Camera_Connect1() = True And Camera_Connect2() = True Then
        '    MsgBox("Camera successfully connected! ", vbInformation, "Refresh")
        'Else
        '    MsgBox("Failed to connect camera! ", vbExclamation, "Refresh")
        'End If

    End Sub

    Function Get_EntryLog(ByVal idNo As String) As Boolean

        ' If subSQl() = False Then Return False
        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSql.Execute("select IDnumber,Timein from tbltimein where IDnumber = '" & idNo & "'")
            If rs.EOF = False Then
                strEntData.Ent_IdNumber = rs("IDnumber").Value
                strEntData.Ent_Timein = rs("Timein").Value
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function

    Function GetNotice(IDno As String) As String

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSql.Execute("select Notice from vwenotice where IDnumber = '" & IDno & "' order by ID desc;")
            If rs.EOF = False Then
                Return rs("Notice").Value
            Else
                Return vbNullString
            End If
        Catch ex As Exception
            Return vbNullString
        End Try
    End Function

    Function studInfo(ByVal Ccode As String) As Boolean
        If conServer() = False Then Return False

        Try
            With LetranMain
                Dim Path As String

                Dim rs = New Recordset
                rs = New Recordset
                rs = conSql.Execute("select IDnumber,Name,Course,GradeYear,YearEnd,CardStatus from tblstudinfo where ACnumber = '" & Ccode & "' order by YearEnd desc;")
                If rs.EOF = False Then
                    If My.Settings.AutoClear = True Then
                        If tmeClrReset = False Then
                            KeepAliveTimerClr.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite)
                            tmeClrReset = True
                        End If
                        KeepAliveTimerClr = New System.Threading.Timer(KeepAliveDelegateClr, Nothing, DevC_Structure.DevC_Delay, DevC_Structure.DevC_Delay)
                        KeepAliveTimerClr.Change(DevC_Structure.DevC_Delay, DevC_Structure.DevC_Delay)
                        tmeClrReset = False
                    End If
                  
                    Path = StudentPicStr(rs("IDnumber").Value.ToString & "p")
                    .StudPic.ImageLocation = Path
                    .StudPic.Load()

                    If CLng(rs("CardStatus").Value) = 0 Then
                        .txtStudent.Text = rs("Name").Value
                        .txtCourse.Text = rs("Course").Value
                        .txtYear.Text = rs("GradeYear").Value
                        .txtNotice.Text = "CARD IS BLOCKED" & vbNewLine & GetNotice(rs("IDnumber").Value.ToString)
                        Return False
                    End If

                    Dim tmeNow As Date = Format(Now, "yyyy-MM-dd HH:mm:ss")
                    Dim dtnow As Date = Format(Now, "yyyy-MM-dd")
                    Dim Dtend As Date = Format(CDate(rs("YearEnd").Value), "yyyy-MM-dd")

                    If dtnow >= Dtend Then
                        .txtStudent.Text = rs("Name").Value
                        .txtCourse.Text = rs("Course").Value
                        .txtYear.Text = rs("GradeYear").Value
                        .txtNotice.Text = "(CARD IS EXPIRED)" & vbNewLine & GetNotice(rs("IDnumber").Value.ToString)
                        Return False
                    End If

                    'Select Case DevC_Structure.DevC_Stat
                    '    Case "In"
                    '        If Get_EntryLog(rs("IDnumber").Value.ToString) = True Then
                    '            .txtStudent.Text = rs("Name").Value
                    '            .txtCourse.Text = rs("Course").Value
                    '            .txtYear.Text = rs("GradeYear").Value
                    '            .txtNotice.Text = "(ALREADY LOGIN)" '& vbNewLine & GetNotice(rs("IDnumber").Value.ToString)
                    '            Return False
                    '        End If
                    '    Case "Out"
                    '        If Get_EntryLog(rs("IDnumber").Value.ToString) = False Then
                    '            .txtStudent.Text = rs("Name").Value
                    '            .txtCourse.Text = rs("Course").Value
                    '            .txtYear.Text = rs("GradeYear").Value
                    '            .txtNotice.Text = "(LOGIN FIRST)" '& vbNewLine & GetNotice(rs("IDnumber").Value.ToString)
                    '            Return False
                    '        End If
                    'End Select

                    Select Case DevC_Structure.DevC_Stat
                        Case "In"
                            SaveIn(rs("IDnumber").Value.ToString, tmeNow, "In")
                            Msg(rs("IDnumber").Value.ToString, 1)
                        Case "Out"
                            SaveIn(rs("IDnumber").Value.ToString, tmeNow, "Out")
                            Msg(rs("IDnumber").Value.ToString, 0)
                    End Select

                    .txtStudent.Text = rs("Name").Value
                    .txtCourse.Text = rs("Course").Value
                    .txtYear.Text = rs("GradeYear").Value
                    .txtNotice.Text = GetNotice(rs("IDnumber").Value.ToString)
                    Return True
                Else
                    If My.Settings.AutoClear = True Then
                        If tmeClrReset = False Then
                            KeepAliveTimerClr.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite)
                            tmeClrReset = True
                        End If

                        KeepAliveTimerClr = New System.Threading.Timer(KeepAliveDelegateClr, Nothing, DevC_Structure.DevC_Delay, DevC_Structure.DevC_Delay)
                        KeepAliveTimerClr.Change(DevC_Structure.DevC_Delay, DevC_Structure.DevC_Delay)
                        tmeClrReset = False
                    End If

                    .txtStudent.Text = "UNKNOWN"
                    .txtCourse.Text = "UNKNOWN"
                    .txtYear.Text = "UNKNOWN"
                    .StudPic.Image = Image.FromFile(Application.StartupPath & "\LetranIcod.jpg")
                    .txtNotice.Text = vbNullString
                    Return False
                End If

            End With
        Catch ex As Exception
            'MsgBox(ex.Message, vbCritical)
            Return False
        End Try

    End Function

    Sub Ontrans(ByVal cardCod As Long)

        If (InvokeRequired) Then
            Invoke(New DevOntrans(AddressOf Ontrans), cardCod)
        Else
            ' If conSql() = False Then Exit Sub

            Dim cardCodLen As Integer = Len(cardCod.ToString)

            If cardCod < 0 Or cardCodLen < 10 Then
                ccCode = 4294967296.0# + cardCod
            Else
                ccCode = cardCod
            End If

            If Directory.Exists(My.Settings.PicPath) = False Then
                LetranMain.txtNotice.Text = "Please set student Image designate Path!"
                Exit Sub
            End If

            Try

                With LetranMain
                    If studInfo(ccCode) = True Then
                        Dim thr As New Thread(New ThreadStart(Sub() SubUnlocked()))
                        thr.Start()
                    End If
                End With

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Dev1_OnHIDNum(sender As Object, e As Axzkemkeeper._IZKEMEvents_OnHIDNumEvent) Handles Dev1.OnHIDNum
        Dim th As New Thread(New ThreadStart(Sub() Ontrans(e.cardNumber)))
        th.Start()
    End Sub
End Class
