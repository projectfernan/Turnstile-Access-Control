Imports ADODB
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports WG3000_COMM.Core
Imports System.Collections

Imports System.IO
Imports System.IO.Path
Imports System.Threading

Imports System.Text.RegularExpressions

Public Class controlDev
    Public decCode As String = vbNullString

    Public Structure DEv_Control
        Public DevC_Name As String
        Public DevC_Ip As String
        Public DevC_Frame As String
        Public DevC_lane As String
        Public DevC_Stat As String
        Public DevC_Delay As Long
    End Structure

    Dim DevC_Structure As New DEv_Control

    Public controlDevice As New wgMjController
    Public controlDevice2 As New wgMjController

    Public watching As New wgWatchingService
    Public Event EventHandler(ByVal message As String)
    Public receivedPktCount As New Integer
    Public QueRecText As New Queue

    Private Delegate Sub txtInfoHaveNewInfo()
    Shared dealingTxt As Integer = 0
    Shared infoRowsCount As Integer = 0
    Dim seventhandler As OnEventHandler

    Public Delegate Sub CtrlDevOntrans(ByVal crdCode As Long, ByVal PintoStat As String)
    Dim ccCode As String = vbNullString

    Public ctrlNode As String
    Public ctrlSN As String
    Public ctrlPort As String
    Public ctrlIP As String

    Public ctrlMAC As String
    Public ctrlMask As String
    Public ctrlSubNet As String
    Public ctrlGateway As String
    Public ctrlPCip As String


    Public ctrlCamIP As String
    Public ctrlCamUID As String
    Public ctrlCamPWD As String
    Public ctrlCamPort As Integer

    Public ctrlCam1 As Integer
    Public ctrlCap1 As Integer

    Public ctrlCam2 As Integer
    Public ctrlCap2 As Integer

    Public C_Code As String
    Public C_Plate As String
    Public C_Name As String


    Public C_Code2 As String
    Public C_Plate2 As String
    Public C_Name2 As String

    Public Sub updateControllerStatus()

        If watching Is Nothing Then

        Else
            Dim conRunInfo As wgMjControllerRunInformation = Nothing
            Dim commStatus As Integer
            commStatus = watching.CheckControllerCommStatus(CInt(ctrlSN), conRunInfo)

            If commStatus = -1 Then
                txtCtrl.Text = ctrlNode
                txtStatus.ForeColor = Color.Pink
                txtStatus.Text = "Disconnected"
            ElseIf commStatus = 1 Then
                txtCtrl.Text = ctrlNode
                txtStatus.ForeColor = Color.Blue
                txtStatus.Text = "Connected"
            End If
        End If

    End Sub

    Private Sub txtInfoHaveNewInfoEntry()
        If dealingTxt > 0 Then
            Exit Sub
        End If
        If watching.WatchingController Is Nothing Then
            '2010-8-1 08:27:15 没有选中监控的就退出
            Exit Sub
        End If
        System.Threading.Interlocked.Exchange(dealingTxt, 1)
        Dim dealt As Integer = 0
        Dim obj As Object
        Dim startTicks As Long = DateTime.Now.Ticks
        ' Date.Now.Ticks  'us
        Dim updateSpan As Long = 2000 * 1000 * 10
        Dim endTicks As Long = startTicks + updateSpan
        ' '100毫微秒的倍数  '一个Ticks＝10亿分之一秒，一毫秒＝10000Ticks
        While QueRecText.Count > 0
            SyncLock QueRecText.SyncRoot
                '取出
                obj = QueRecText.Dequeue()
            End SyncLock
            txtInfoUpdateEntry(obj)
            infoRowsCount += 1
            dealt += 1
            If DateTime.Now.Ticks > endTicks Then
                endTicks = DateTime.Now.Ticks + updateSpan
                If watching.WatchingController Is Nothing Then
                    Exit While
                End If
            End If
        End While
        Application.DoEvents()
        '显示
        System.Threading.Interlocked.Exchange(dealingTxt, 0)
    End Sub

    'Function ViewIn(ByVal Ccode As String) As Boolean
    '    If subsqlloc() = False Then Return False

    '    Try
    '        Dim rs As New Recordset
    '        rs = New Recordset
    '        rs = Conn.Execute("select * from vweinfo where CardCode = '" & Ccode & "'")
    '        If rs.EOF = False Then
    '            C_Code = rs("CardCode").Value
    '            C_Plate = rs("PlateNo").Value
    '            C_Name = rs("Name").Value

    '            Return True
    '        Else
    '            Return False
    '        End If
    '    Catch ex As Exception
    '        Return False
    '    End Try
    'End Function

    'Function ViewOut(ByVal Ccode As String) As Boolean
    '    If subsqlloc() = False Then Return False

    '    Try
    '        Dim rs As New Recordset
    '        rs = New Recordset
    '        rs = Conn.Execute("select * from vweinfo where CardCode = '" & Ccode & "'")
    '        If rs.EOF = False Then
    '            C_Code2 = rs("CardCode").Value
    '            C_Plate2 = rs("PlateNo").Value
    '            C_Name2 = rs("Name").Value
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    Catch ex As Exception
    '        Return False
    '    End Try
    'End Function

    'Function DateExp(ByVal Ccode As String) As Boolean
    '    If subsqlloc() = False Then Return False

    '    Try
    '        Dim rs As New Recordset
    '        rs = New Recordset
    '        rs = Conn.Execute("select * from tblcards where CardCode = '" & Ccode & "'")
    '        If rs.EOF = False Then
    '            Dim dtNow As Date = Now
    '            Dim dtExp As Date = rs("DateExpired").Value
    '            If dtNow >= dtExp Then
    '                Return True
    '            Else
    '                Return False
    '            End If
    '        Else
    '            Return False
    '        End If
    '    Catch ex As Exception
    '        Return False
    '    End Try
    'End Function

    'Function chkTimeLogs(ByVal Ccode As String) As Boolean
    '    If subsqlloc() = False Then Return False

    '    Try
    '        Dim rs As New Recordset
    '        rs = New Recordset

    '        rs = Conn.Execute("select * from tbltimein where CardCode = '" & Ccode & "'")
    '        If rs.EOF = False Then
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    Catch ex As Exception
    '        Return False
    '    End Try
    'End Function

    'Sub saveIn()
    '    If subsqlloc() = False Then
    '        frmSystemMain.txtMsg.Text = "Server disconnected"
    '        Exit Sub
    '    End If

    '    Try
    '        Dim rs As New Recordset
    '        rs.Open("select * from tbltimein", Conn, 1, 2)
    '        rs.AddNew()
    '        rs("CardCode").Value = C_Code
    '        rs("Plate").Value = C_Plate
    '        rs("Location").Value = txtCtrl.Text
    '        rs("TimeIn").Value = Now

    '        If Get_ImageName() <> Nothing Then
    '            Dim strem As New Stream
    '            strem.Type = StreamTypeEnum.adTypeBinary
    '            strem.Open()
    '            strem.LoadFromFile(Get_ImageName)

    '            rs("PicIn").Value = strem.Read
    '        End If
    '        rs.Update()

    '        frmSystemMain.fillLogs(C_Code, C_Plate, Now, "In")
    '    Catch ex As Exception
    '        frmSystemMain.txtMsg.Text = ex.Message
    '    End Try
    'End Sub

    'Sub saveOut()
    '    If subsqlloc() = False Then
    '        frmSystemMain.txtMsg.Text = "Server disconnected"
    '        Exit Sub
    '    End If

    '    Try
    '        Dim rs As New Recordset
    '        rs.Open("select * from tbltimeOut", Conn, 1, 2)
    '        rs.AddNew()
    '        rs("CardCode").Value = C_Code2
    '        rs("Plate").Value = C_Plate2
    '        rs("Location").Value = txtCtrl.Text
    '        rs("TimeOut").Value = Now

    '        If Get_ImageName() <> Nothing Then
    '            Dim strem As New Stream
    '            strem.Type = StreamTypeEnum.adTypeBinary
    '            strem.Open()
    '            strem.LoadFromFile(Get_ImageName)
    '            rs("PicOut").Value = strem.Read
    '        End If
    '        rs.Update()

    '        frmSystemMain.fillLogs(C_Code2, C_Plate2, Now, "Out")
    '    Catch ex As Exception
    '        frmSystemMain.txtMsg.Text = ex.Message
    '    End Try
    'End Sub

    'Sub saveInOut(ByVal Ccode As String)
    '    If subsqlloc() = False Then
    '        frmSystemMain.txtMsg.Text = "Server disconnected"
    '        Exit Sub
    '    End If

    '    Try
    '        Dim rs1 As New Recordset
    '        rs1 = New Recordset
    '        rs1 = Conn.Execute("select * from tbltimein where CardCode = '" & Ccode & "'")
    '        If rs1.EOF = False Then
    '            Dim rs As New Recordset
    '            rs.Open("select * from tblinout", Conn, 1, 2)
    '            rs.AddNew()
    '            rs("CardCode").Value = C_Code2
    '            rs("Plate").Value = C_Plate2
    '            rs("Location").Value = txtCtrl.Text
    '            rs("TimeIn").Value = rs1("TimeIn").Value
    '            rs("PicIn").Value = rs1("PicIn").Value
    '            rs("TimeOut").Value = Now
    '            If Get_ImageName() <> Nothing Then
    '                Dim strem As New Stream
    '                strem.Type = StreamTypeEnum.adTypeBinary
    '                strem.Open()
    '                strem.LoadFromFile(Get_ImageName)
    '                rs("PicOut").Value = strem.Read
    '            End If
    '            rs.Update()

    '            frmSystemMain.fillLogs(C_Code2, C_Plate2, Now, "Out")
    '        End If
    '    Catch ex As Exception
    '        frmSystemMain.txtMsg.Text = ex.Message
    '    End Try
    'End Sub

    'Sub delTimein(ByVal Ccode As String)
    '    If subsqlloc() = False Then Exit Sub

    '    Try
    '        Dim rs As New Recordset
    '        rs = New Recordset
    '        rs = Conn.Execute("delete from tbltimein where CardCode = '" & Ccode & "'")
    '    Catch ex As Exception
    '        frmSystemMain.txtMsg.Text = ex.Message
    '    End Try
    'End Sub

    Function Get_EntryLog(ByVal idNo As String) As Boolean

        ' If subSQl() = False Then Return False

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSql.Execute("select IDnumber,Timein from tbltimein where IDnumber = '" & idNo & "' limit 1;")
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

    Sub EntSave(ByVal IDno As String, ByVal Entin As Date, ByVal strLane As String)
        Try
            Dim strEntIn As String = Format(Entin, "yyyy-MM-dd HH:mm:ss")
            Dim rs As New Recordset
            rs = New Recordset

            conSql.Execute("insert into tbltimein(IDnumber,Timein,Lane)VALUES('" & IDno & "','" & strEntIn & "','" & strLane & "')")

        Catch ex As Exception
            atcMain.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub ExtSave(ByVal IDno As String, ByVal Extout As Date, ByVal strLane As String)
        Try
            Dim strEntIn As String = Format(Extout, "yyyy-MM-dd HH:mm:ss")
            Dim rs As New Recordset
            rs = New Recordset

            conSql.Execute("insert into tbltimeout(IDnumber,Timeout,Lane)VALUES('" & IDno & "','" & strEntIn & "','" & strLane & "')")

        Catch ex As Exception
            atcMain.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub InOutSave(ByVal IDno As String, ByVal EntIn As Date, ByVal Extout As Date, ByVal strLane As String)
        Try
            Dim strEntIn As String = Format(EntIn, "yyyy-MM-dd HH:mm:ss")
            Dim strExtOut As String = Format(Extout, "yyyy-MM-dd HH:mm:ss")
            Dim rs As New Recordset
            rs = New Recordset

            conSql.Execute("insert into tblinout(IDnumber,Timein,Timeout,Lane)VALUES('" & IDno & "','" & strEntIn & "','" & strExtOut & "','" & strLane & "')")

        Catch ex As Exception
            atcMain.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub delEntryData(ByVal idno As String)
        If subSQl() = False Then Exit Sub

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSql.Execute("delete from tbltimein where IDnumber = '" & idno & "'")
        Catch ex As Exception
            atcMain.txtSystemErr.Text = ex.Message
        End Try

    End Sub

    Function entInfo(ByVal EntCcode As String, ByVal tmeIN As Date) As Boolean
        If subSQl() = False Then Return False
        Try
            With atcMain
                Dim rs = New Recordset

                rs = New Recordset
                rs = conSql.Execute("select IDnumber,Name,Title,AccessStatus from vweempinfo where CardCode = '" & EntCcode & "' limit 1;")
                If rs.EOF = False Then

                    If rs("AccessStatus").Value = 0 Then
                        .fillEntryLogs(rs("IDnumber").Value, rs("Name").Value, "CARD IS BLOCKED", Format(tmeIN, "yyyy-MM-dd HH:mm:ss"), DevC_Structure.DevC_lane)
                        .EntryImg.Image = Get_PicEmp(rs("IDnumber").Value.ToString)
                        .txtSystemErr.Text = "CARD IS BLOCKED"
                        Return False
                    End If

                    If My.Settings.PSb_Set = True Then
                        If Get_EntryLog(rs("IDnumber").Value) = True Then
                            .fillEntryLogs(rs("IDnumber").Value, rs("Name").Value, "ALREADY LOGIN", Format(tmeIN, "yyyy-MM-dd HH:mm:ss"), DevC_Structure.DevC_lane)
                            .EntryImg.Image = Get_PicEmp(rs("IDnumber").Value.ToString)
                            .txtSystemErr.Text = "ALREADY LOGIN"
                            Return False
                        End If
                    End If

                    EntSave(rs("IDnumber").Value, tmeIN, DevC_Structure.DevC_lane)

                    .fillEntryLogs(rs("IDnumber").Value, rs("Name").Value, rs("Title").Value, Format(tmeIN, "yyyy-MM-dd HH:mm:ss"), DevC_Structure.DevC_lane)
                    .EntryImg.Image = Get_PicEmp(rs("IDnumber").Value.ToString)
                    Return True
                Else
                    .fillEntryLogs(EntCcode, decCode, "UNKNOWN", Format(tmeIN, "yyyy-MM-dd HH:mm:ss"), DevC_Structure.DevC_lane)
                    .EntryImg.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                    Return False
                End If
            End With
        Catch ex As Exception
            atcMain.txtSystemErr.Text = ex.Message
            Return False
        End Try
    End Function

    Function extInfo(ByVal EntCcode As String, ByVal tmeOut As Date) As Boolean
        If subSQl() = False Then Return False
        Try
            With atcMain
                Dim rs = New Recordset

                rs = New Recordset
                rs = conSql.Execute("select IDnumber,Name,Title,AccessStatus from vweempinfo where CardCode = '" & EntCcode & "' limit 1;")
                If rs.EOF = False Then

                    If rs("AccessStatus").Value = 0 Then
                        .fillExitLogs(rs("IDnumber").Value, rs("Name").Value, "CARD IS BLOCKED", Format(tmeOut, "yyyy-MM-dd HH:mm:ss"), DevC_Structure.DevC_lane)
                        .ExitImg.Image = Get_PicEmp(rs("IDnumber").Value.ToString)
                        .txtSystemErr.Text = "CARD IS BLOCKED"
                        Return False
                    End If

                    If My.Settings.PSb_Set = True Then
                        If Get_EntryLog(rs("IDnumber").Value) = False Then
                            .fillExitLogs(rs("IDnumber").Value, rs("Name").Value, "LOGIN FIRST", Format(tmeOut, "yyyy-MM-dd HH:mm:ss"), DevC_Structure.DevC_lane)
                            .ExitImg.Image = Get_PicEmp(rs("IDnumber").Value.ToString)
                            .txtSystemErr.Text = "LOGIN FIRST"
                            Return False
                        Else
                            InOutSave(rs("IDnumber").Value, strEntData.Ent_Timein, Format(tmeOut, "yyyy-MM-dd HH:mm:ss"), DevC_Structure.DevC_lane)
                            .fillExitLogs(rs("IDnumber").Value, rs("Name").Value, rs("Title").Value, Format(tmeOut, "yyyy-MM-dd HH:mm:ss"), DevC_Structure.DevC_lane)
                            .ExitImg.Image = Get_PicEmp(rs("IDnumber").Value.ToString)
                            delEntryData(rs("IDnumber").Value)
                            Return True
                        End If
                    Else
                        If Get_EntryLog(rs("IDnumber").Value) = True Then
                            InOutSave(rs("IDnumber").Value, strEntData.Ent_Timein, Format(tmeOut, "yyyy-MM-dd HH:mm:ss"), DevC_Structure.DevC_lane)
                            .fillExitLogs(rs("IDnumber").Value, rs("Name").Value, rs("Title").Value, Format(tmeOut, "yyyy-MM-dd HH:mm:ss"), DevC_Structure.DevC_lane)
                            .ExitImg.Image = Get_PicEmp(rs("IDnumber").Value.ToString)
                            delEntryData(rs("IDnumber").Value)
                            Return True
                        Else
                            ExtSave(rs("IDnumber").Value, Format(tmeOut, "yyyy-MM-dd HH:mm:ss"), DevC_Structure.DevC_lane)
                            .fillExitLogs(rs("IDnumber").Value, rs("Name").Value, rs("Title").Value, Format(tmeOut, "yyyy-MM-dd HH:mm:ss"), DevC_Structure.DevC_lane)
                            .ExitImg.Image = Get_PicEmp(rs("IDnumber").Value.ToString)
                            Return True
                        End If
                    End If
                Else
                    .fillExitLogs(EntCcode, decCode, "UNKNOWN", Format(tmeOut, "yyyy-MM-dd HH:mm:ss"), DevC_Structure.DevC_lane)
                    .ExitImg.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                    Return False
                End If
            End With
        Catch ex As Exception
            atcMain.txtSystemErr.Text = ex.Message
            Return False
        End Try
    End Function

    Sub ctrlOntrans(ByVal cardCod As Long, ByVal DoorStat As String)
        decCode = cardCod
        If (InvokeRequired) Then
            Try
                Invoke(New CtrlDevOntrans(AddressOf ctrlOntrans), cardCod, DoorStat)
            Catch ex As Exception

            End Try
        Else
            If subSQl() = False Then Exit Sub

            Dim cardCodLen As Integer = Len(cardCod.ToString)

            If cardCodLen < 0 Or cardCodLen < 10 And cardCodLen > 8 Then
                ccCode = 4294967296.0# + cardCod

            ElseIf cardCodLen <= 8 Then
                If cardCodLen = 6 Then
                    Dim a As String = Mid(cardCod, 1, 1)
                    Dim a1 As String = Hex(a)
                    Dim b As String = Mid(cardCod, 2)
                    Dim b1 As String = Hex(b)

                    If Len(a1) <= 0 Then
                        a1 = "00"
                    ElseIf Len(a1) = 1 Then
                        a1 = "0" & a1
                    End If

                    If Len(b1) = 3 Then
                        b1 = "0" & b1
                    ElseIf Len(b1) = 2 Then
                        b1 = "00" & b1
                    ElseIf Len(b1) = 1 Then
                        b1 = "000" & b1
                    End If

                    ccCode = a1 & b1
                End If
                If cardCodLen = 7 Then
                    Dim a As String = Mid(cardCod, 1, 2)
                    Dim a1 As String = Hex(a)
                    Dim b As String = Mid(cardCod, 3)
                    Dim b1 As String = Hex(b)

                    If Len(a1) <= 0 Then
                        a1 = "00"
                    ElseIf Len(a1) = 1 Then
                        a1 = "0" & a1
                    End If

                    If Len(b1) = 3 Then
                        b1 = "0" & b1
                    ElseIf Len(b1) = 2 Then
                        b1 = "00" & b1
                    ElseIf Len(b1) = 1 Then
                        b1 = "000" & b1
                    End If

                    ccCode = a1 & b1
                End If
                If cardCodLen = 8 Then
                    Dim a8 As String = Mid(cardCod, 1, 3)
                    Dim a18 As String = Hex(a8)
                    Dim b As String = Mid(cardCod, 4)
                    Dim b1 As String = Hex(b)

                    If Len(a18) <= 0 Then
                        a18 = "00"
                    ElseIf Len(a18) = 1 Then
                        a18 = "0" & a18
                    ElseIf Len(a18) = 2 Then
                        a18 = a18
                    End If

                    If Len(b1) = 3 Then
                        b1 = "0" & b1
                    ElseIf Len(b1) = 2 Then
                        b1 = "00" & b1
                    ElseIf Len(b1) = 1 Then
                        b1 = "000" & b1
                    End If

                    ccCode = a18 & b1
                End If
            Else
                ccCode = cardCod
            End If

                If Directory.Exists(My.Settings.EmpImgPath) = False Then
                    atcMain.txtSystemErr.Text = "Please set Employee Image Designate Path!"
                    Exit Sub
                End If

                Try

                    With atcMain
                        Select Case DoorStat
                            Case "In"

                                If entInfo(ccCode, Now) = True Then
                                    Dim doorNo As Integer = 1
                                    If controlDevice2.RemoteOpenDoorIP(doorNo) > 0 Then
                                        atcMain.txtSystemErr.Text = "ACCESSED"
                                        tmeRead.Enabled = True
                                    End If
                                End If
                                .fillReviewEnt()
                            Case "Out"

                                If extInfo(ccCode, Now) = True Then
                                    Dim doorNo As Integer = 2
                                    If controlDevice2.RemoteOpenDoorIP(doorNo) > 0 Then
                                        atcMain.txtSystemErr.Text = "ACCESSED"
                                        tmeRead.Enabled = True
                                    End If
                                End If
                                .fillReviewExt()
                        End Select
                    End With

                    txtHandler.Text = vbNullString
                    txtCardCode.Text = vbNullString
                    txtDoor.Text = vbNullString

                Catch ex As Exception

                End Try
        End If
    End Sub

    Private Sub txtInfoUpdateEntry(ByVal info As Object)
        Dim mjrec As New wgMjControllerSwipeRecord(TryCast(info, String))
        If mjrec.ControllerSN > 0 Then
            Try
                If Not watching.WatchingController.ContainsKey(CInt(mjrec.ControllerSN)) Then
                    Return
                End If
            Catch generatedExceptionName As Exception
                Return
            End Try

            Delete_Image()
            txtHandler.Text = vbNullString
            txtCardCode.Text = vbNullString
            txtDoor.Text = vbNullString
            'txtMsg.Text = "---"

            txtHandler.AppendText(mjrec.ToDisplaySimpleInfo(True))

            'TextBox1.Text = Replace(TextBox1.Text, " ", vbNullString)
            Dim reRep As String = Mid(txtHandler.Text, 10, 10)

            txtCardCode.Text = Regex.Replace(reRep, "[^0-9]", "")
            Dim CcodeL As Long = Len(txtCardCode.Text)
            Dim LtobeAdd As Long = 8 - CcodeL

            Dim DoorS As Long = 33 - LtobeAdd

            txtDoor.Text = Mid(txtHandler.Text, DoorS, 5)
            txtDoor.Text = Mid(txtDoor.Text, 2)

            txtDoor.Text = Replace(txtDoor.Text, "[", vbNullString)
            txtDoor.Text = Replace(txtDoor.Text, "]", vbNullString)
            'Timer1.Interval = 5000
            tmeRead.Enabled = False

            Dim strDoor As String = Trim(txtDoor.Text)

            If txtCardCode.Text = vbNullString Then Exit Sub
            If txtCardCode.Text = "" Then Exit Sub
            If Len(txtCardCode.Text) < 6 Then Exit Sub

            Try
                Dim th As New Thread(New ThreadStart(Sub() ctrlOntrans(txtCardCode.Text, strDoor)))
                th.Start()
            Catch ex As Exception

            End Try


        End If
    End Sub

    Private Sub evtNewInfoCallBack(ByVal text As String)
        System.Diagnostics.Debug.WriteLine("Got text through callback! {0}", text)
        receivedPktCount += 1
        SyncLock QueRecText.SyncRoot
            QueRecText.Enqueue(text)
        End SyncLock
    End Sub

    Sub StartSwipe()

        If watching IsNot Nothing Then
            watching = New wgWatchingService
            AddHandler watching.EventHandler, New OnEventHandler(AddressOf evtNewInfoCallBack)
        End If

        Dim SNno As Integer = ctrlSN
        Dim IPAdd As String = ctrlIP
        Dim Port As String = ctrlPort

        Dim selectedControllers As New Dictionary(Of Integer, wgMjController)()

        'Dim config As New wgMjController
        Dim wgMjControllerWatching As New wgMjController
        'Create New 
        wgMjControllerWatching.ControllerSN = SNno
        wgMjControllerWatching.IP = IPAdd
        wgMjControllerWatching.PORT = Port

        selectedControllers.Add(wgMjControllerWatching.ControllerSN, wgMjControllerWatching)

        If selectedControllers.Count > 0 Then

            System.Diagnostics.Debug.WriteLine("selectedControllers.Count=" + selectedControllers.Count.ToString())
            watching.WatchingController = selectedControllers
            tmeRead.Interval = 300
            tmeRead.Enabled = True
        Else
            System.Diagnostics.Debug.WriteLine("selectedControllers.Count=" + selectedControllers.Count.ToString())
            watching.WatchingController = Nothing
            tmeRead.Enabled = False
        End If

    End Sub

    Private Sub tmeRead_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmeRead.Tick
        tmeRead.Enabled = False
        If watching IsNot Nothing Then
            updateControllerStatus()
            If QueRecText.Count > 0 Then
                Me.Invoke(New txtInfoHaveNewInfo(AddressOf txtInfoHaveNewInfoEntry))
            End If
            Application.DoEvents()
            tmeRead.Enabled = True
        End If
    End Sub

    Public Sub Cam_Exit1()
        'With NetVid1
        '    .Logout()
        '    .ClearOCX()
        'End With
    End Sub

    Public Function Cam_Connect1(ByVal strIP As String, ByVal IntPort As Integer, ByVal strUID As String, ByVal strPWD As String, ByVal CamID As Integer) As Boolean
        'With NetVid1
        '    Cam_Exit1()
        '    If PingMe(strIP) = False Then Return False
        '    Cam_ID = .Login(strIP, IntPort, strUID, strPWD)
        '    If Cam_ID < 0 Then
        '        Return False
        '    Else
        '        .StartRealPlay(CamID, 0, 0)
        '        Return True
        '    End If
        'End With
    End Function

    Public Function Cam_Capture1() As Boolean
        'Delete_Image()
        'With NetVid1
        '    Dim Cap As Integer = ctrlCap1
        '    If .JPEGCapturePicture(Cap, 0, 0, Application.StartupPath & "\Capture") = True Then
        '        Return True
        '    Else
        '        Return False
        '    End If
        'End With
    End Function



    Private Sub controller_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If ctrlNode = vbNullString Then
            ctrlNode = ctrl_Node
            ctrlSN = ctrl_SN
            ctrlIP = ctrl_IP
            ctrlPort = ctrl_Port
            ctrlIP = ctrl_IP
            ctrlMAC = ctrl_MAC
            ctrlSubNet = ctrl_SubNet
            ctrlGateway = ctrl_Gateway
            ctrlPCip = ctrl_PCip
            DevC_Structure.DevC_lane = DevStructure.Dev_Lane
            'ctrlCamIP = ctrl_CamIP
            'ctrlCamUID = ctrl_CamUID
            'ctrlCamPWD = ctrl_CamPWD
            'ctrlCamPort = ctrl_CamPort
            'ctrlCam1 = ctrl_Cam1
            'ctrlCap1 = ctrl_Cap1

            controlDevice2.ControllerSN = CInt(ctrlSN)
            controlDevice2.IP = ctrlIP
            controlDevice2.PORT = ctrlPort

            ''Camera
            'Cam_Connect1(ctrlCamIP, ctrlCamPort, ctrlCamUID, ctrl_CamPWD, ctrlCam1)

            StartSwipe()
            tmeRead.Enabled = True

        End If
    End Sub

    Private Sub ConnectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        StartSwipe()
        tmeRead.Enabled = True
        ' txtStatus.ForeColor = Color.Blue
        ' txtStatus.Text = "Connected"

    End Sub

    Private Sub RefreshCam1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If watching IsNot Nothing Then
            watching.WatchingController = Nothing
            tmeRead.Enabled = False
        End If
        System.Threading.Interlocked.Exchange(dealingTxt, 0)

        txtStatus.ForeColor = Color.Pink
        txtStatus.Text = "Disconnected"
    End Sub

    Private Sub DisconnectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Cam_Connect1(ctrlCamIP, ctrlCamPort, ctrlCamUID, ctrl_CamPWD, ctrlCam1) = True Then
        '    MsgBox("Camera is active! ", vbInformation, "Refresh Camera 1")
        'Else
        '    MsgBox("Failed to connect in Camera 1! ", vbExclamation, "Refresh Camera 1")
        'End If
    End Sub

    Private Sub ConnectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TestTriggerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



        If controlDevice2.RemoteOpenDoorIP(1) > 0 Then
            MsgBox("Barrier 1 Successfully triggered!", vbInformation)
        Else
            MsgBox("Fail to triggered!", vbExclamation)
        End If

        If controlDevice2.RemoteOpenDoorIP(2) > 0 Then
            MsgBox("Barrier 2 Successfully triggered!", vbInformation)
        Else
            MsgBox("Fail to triggered!", vbExclamation)
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        StartSwipe()
        tmeRead.Enabled = True
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        If watching IsNot Nothing Then
            watching.WatchingController = Nothing
            tmeRead.Enabled = False
        End If
        System.Threading.Interlocked.Exchange(dealingTxt, 0)

        txtStatus.ForeColor = Color.Pink
        txtStatus.Text = "Disconnected"
    End Sub

    Private Sub TrggerOpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrggerOpenToolStripMenuItem.Click
        If controlDevice2.RemoteOpenDoorIP(1) > 0 Then
            MsgBox("Barrier Successfully triggered!", vbInformation)
        Else
            MsgBox("Fail to triggered!", vbExclamation)
        End If

     
    End Sub

    Private Sub NormallyOpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NormallyOpenToolStripMenuItem.Click
        Dim controlConfigure As New wgMjControllerConfigure


        controlConfigure.DoorControlSet(1, 1)
        controlConfigure.DoorControlSet(2, 1)

        'controlConfigure.DoorControlSet(1, 0)
        'controlConfigure.DoorControlSet(2, 0)

        If controlDevice2.UpdateConfigureIP(controlConfigure) > 0 Then
            'With frmSystemMain
            '    saveAudiUpdate(.UserAcc.Text, .SystemTag.Text, "Barriers normally open in : " & txtCtrl.Text & " Controller")
            'End With
            MsgBox("Both Barriers Normally Open!", vbInformation, "Normally Open")

        Else
            MsgBox("Failed to Normally Open!", vbExclamation, "Normally Open")
        End If
    End Sub

    Private Sub NormallyClosedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NormallyClosedToolStripMenuItem.Click
        Dim controlConfigure As New wgMjControllerConfigure

        'controlConfigure.DoorControlSet(1, 2)
        'controlConfigure.DoorControlSet(2, 2)

        controlConfigure.DoorControlSet(1, 3)
        controlConfigure.DoorControlSet(2, 3)

        controlConfigure.DoorDelaySet(1, My.Settings.TriggerDelay)
        controlConfigure.DoorDelaySet(2, My.Settings.TriggerDelay)

        If controlDevice2.UpdateConfigureIP(controlConfigure) > 0 Then
            'With frmSystemMain
            '    saveAudiUpdate(.UserAcc.Text, .SystemTag.Text, "Barriers normally close in : " & txtCtrl.Text & " Controller")
            'End With

            MsgBox("Both Barriers Normally Close!", vbInformation, "Normally Close")
        Else
            MsgBox("Failed to Normally Close!", vbExclamation, "Normally Close")
        End If
    End Sub

    Private Sub ContextMenuStrip1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ContextMenuStrip1.MouseUp

    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub controlDev_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(Me, e.Location)
        End If
    End Sub

    Private Sub txtCtrl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCtrl.Click

    End Sub

    Private Sub txtCtrl_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtCtrl.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(Me, e.Location)
        End If
    End Sub

    Private Sub txtStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStatus.Click

    End Sub

    Private Sub txtStatus_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtStatus.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(Me, e.Location)
        End If
    End Sub

    Private Sub DevPiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevPiv.Click

    End Sub

    Private Sub DevPiv_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DevPiv.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(Me, e.Location)
        End If
    End Sub

    Private Sub SetParameterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetParameterToolStripMenuItem.Click
        Dim controlConfigure As New wgMjControllerConfigure

        controlConfigure.DoorControlSet(1, 3)
        controlConfigure.DoorControlSet(2, 3)

        controlConfigure.DoorDelaySet(1, My.Settings.TriggerDelay)
        controlConfigure.DoorDelaySet(2, My.Settings.TriggerDelay)

        If controler.UpdateConfigureIP(controlConfigure) > 0 Then
            MsgBox("Parameter successfully set! ", vbInformation, "Set Parameter")
        Else
            MsgBox("Failed to set parameter! ", vbExclamation, "Set Parameter")
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        If controlDevice2.RemoteOpenDoorIP(2) > 0 Then
            MsgBox("Barrier 2 Successfully triggered!", vbInformation)
        Else
            MsgBox("Fail to triggered!", vbExclamation)
        End If
    End Sub
End Class
