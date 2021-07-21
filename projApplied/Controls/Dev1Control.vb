Imports ADODB
Imports System
Imports Microsoft.VisualBasic

Imports System.IO
Imports System.IO.Path

Imports System.Drawing.Imaging
Public Class Dev1Control

    Public DevC_Name As String
    Public DevC_Ip As String
    Public DevC_Frame As String
    Public DevC_Stat As String
    Public DevC_Delay As Long

    Public Cam_ID As Integer

    Public FolderINnem1 As String
    Public FolderINnem2 As String

    Public InLogId1 As String
    Public InLogId2 As String

    Dim buffin1 As Long = 0
    Dim buffOut1 As Long = 0

    Dim buffin2 As Long = 0
    Dim buffout2 As Long = 0



    Private Sub Dev1Control_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Timer1.Interval = My.Settings.AutoConnDel
        Me.ContextMenuStrip = ContextMenuStrip1

        If DevC_Ip = vbNullString Then
            DevC_Name = Dev_Name
            DevC_Ip = Dev_Ip
            DevC_Frame = Dev_Frame
            DevC_Stat = Dev_Stat
            DevC_Delay = Dev_Delay

            txtDevName.Text = DevC_Name
            DevStat.Text = DevC_Stat

            'Camera
            camInfo()
            Camera_Connect1()
            Camera_Connect2()

            'Device
            devcon1(DevC_Ip)
        End If

        ConnDevCnt = 0

    End Sub

    Public Function devcon1(ByVal ipAdd As String) As Boolean

        If PingMe(ipAdd) = True Then
            DevStat.Text = "Connected"
            DevStat.ForeColor = Color.Cyan
            ' Dev1.BASE64 = 0
            Dev1.BeginInit()
            Dev1.Connect_Net(ipAdd, 4370)
            Dev1.RegEvent(1, 1)
            Timer1.Enabled = True
            Return True
        Else
            DevStat.Text = "Disconnected"
            DevStat.ForeColor = Color.Pink
            Timer1.Enabled = False
            Return False
        End If
    End Function

    Sub entInfo(ByVal idInfo1 As String)
        If subSQl() = False Then Exit Sub
        Try
            With MainSystem
                Dim rs = New Recordset

                rs = New Recordset
                rs = conSql.Execute("select * from tblemp where ACno = '" & idInfo1 & "' limit 1;")
                If rs.EOF = False Then
                    .lblIdNum.Text = rs("IDnumber").Value
                    .lblName.Text = rs("Name").Value
                    .lblPosition.Text = rs("Title").Value
                    .lblGender.Text = rs("Gender").Value
                    .lblRealTime.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")
                    .EmpPic.Image = Get_PicEmp(.lblIdNum.Text)
                Else
                    .lblIdNum.Text = idInfo1
                    .lblName.Text = "Not Registered"
                    .lblPosition.Text = "Not Registered"
                    .lblGender.Text = "Not Registered"
                    .EmpPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                    .lblRealTime.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")
                End If
            End With
        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub entInfo2(ByVal idinfo2 As String)
        If subSQl() = False Then Exit Sub
        Try
            With MainSystem
                Dim rs = New Recordset

                rs = New Recordset
                rs = conSql.Execute("select * from tblemp where ACno = '" & idinfo2 & "' limit 1;")
                If rs.EOF = False Then
                    .txtIdNo.Text = rs("IDnumber").Value
                    .txtName.Text = rs("Name").Value
                    .txtPosi.Text = rs("Title").Value
                    .txtGender.Text = rs("Gender").Value
                    .txtInOutTime.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")
                    .EmpPic2.Image = Get_PicEmp(.txtIdNo.Text)
                Else
                    .txtIdNo.Text = idinfo2
                    .txtName.Text = "Not Registered"
                    .txtPosi.Text = "Not Registered"
                    .txtGender.Text = "Not Registered"
                    .EmpPic2.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                    .txtInOutTime.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")
                End If
            End With
        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Public Function Camera_Connect1() As Boolean
        With CamEntry
            Camera_EntDiscon()
            If PingMe(frmCamSettings.txtIp.Text) = False Then Return False
            Cam_ID = .Login(frmCamSettings.txtIp.Text, CInt(frmCamSettings.txtPort.Value), frmCamSettings.txtUser.Text, frmCamSettings.txtpass.Text)
            If Cam_ID < 0 Then
                Return False
            Else
                '.StartRealPlay(CInt(frmCamSettings ), 0, 0)
                Return True
            End If
        End With
    End Function

    Public Function Camera_Connect2() As Boolean
        With CamExit 
            Camera_ExtDiscon()
            If PingMe(frmCamSettings.txtIp.Text) = False Then Return False
            Cam_ID = .Login(frmCamSettings.txtIp.Text, CInt(frmCamSettings.txtPort.Value), frmCamSettings.txtUser.Text, frmCamSettings.txtpass.Text)
            If Cam_ID < 0 Then
                Return False
            Else
                '.StartRealPlay(CInt(frmCamSettings ), 0, 0)
                Return True
            End If
        End With
    End Function

    Public Function Get_ImageName(ByVal IdLog As String) As String
        Dim Name As String = Dir$(My.Settings.CapImgPath & "\EntCapture" & IdLog & "\JPEGCapture\*.jpeg")
        If Name = "" Then
            Return Nothing
        Else
            Return My.Settings.CapImgPath & "\EntCapture" & IdLog & "\JPEGCapture\" & Name
        End If
    End Function

    Public Function Get_ImageNameExt(ByVal IdLog As String) As String
        Dim Name As String = Dir$(My.Settings.CapImgPath & "\ExtCapture" & IdLog & "\JPEGCapture\*.jpeg")
        If Name = "" Then
            Return Nothing
        Else
            Return My.Settings.CapImgPath & "\ExtCapture" & IdLog & "\JPEGCapture\" & Name
        End If
    End Function

    Public Function ConvertBMP_TO_JPEG(ByVal BMPFullPath As String, ByVal imgFormat As ImageFormat) As Boolean

        Dim sNewFile As String

        Try
            'bitmap class in system.drawing.imaging
            Dim objBmp As New Bitmap(BMPFullPath)

            'below 2 functions in system.io.path
            sNewFile = GetDirectoryName(BMPFullPath)
            sNewFile &= "\" & GetFileNameWithoutExtension(BMPFullPath)

            sNewFile &= "." & imgFormat.ToString
            objBmp.Save(sNewFile, imgFormat)

            'SAVE JPEG PATH
            '  JPEGPicPath = vbNullString
            ' JPEGPicPath = sNewFile



            Return True 'return true on success
        Catch
            Return False 'return false on error
        End Try

    End Function

    Sub FolderIn(ByVal LogId As String, ByVal Foldernem As String)
        If subSQl() = False Then Exit Sub

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSql.Execute("update tbltimein set FolderName='" & Foldernem & "' where IDnumber = '" & LogId & "'")

        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub FolderOut(ByVal LogId As String, ByVal Foldernem As String)
        If subSQl() = False Then Exit Sub

        Try
            Dim IdOut As String = Replace(LogId, "Out", vbNullString)
            Dim rs As New Recordset
            rs = New Recordset

            rs.Open("select IdLog,FolderName from tbltimeout where IdLog = '" & IdOut & "' Limit 1;", conSql, 1, 2)
            rs("FolderName").Value = Foldernem
            rs.Update()

        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub FolderInOut(ByVal LogId As String, ByVal Foldernem As String)
        If subSQl() = False Then Exit Sub

        Try
            Dim IdInOut As String = Replace(LogId, "InOut", vbNullString)
            Dim rs As New Recordset
            rs = New Recordset

            rs.Open("select InOutId,FolderName from tblinout where InOutId = '" & IdInOut & "' Limit 1;", conSql, 1, 2)
            rs("FolderName").Value = Foldernem
            rs.Update()

        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Function t1extCapture(ByVal LogsID As String) As String
        Try
            Dim orgCAp As String

            CamEntry.JPEGCapturePicture(My.Settings.CAM_ChannelCap1, 0, 0, My.Settings.CapImgPath & "\t1ExtCapture" & LogsID & "\")
            orgCAp = Dir(My.Settings.CapImgPath & "\t1ExtCapture" & LogsID & "\JPEGCapture\*.jpeg")
            With MainSystem.EntCap
                .ImageLocation = My.Settings.CapImgPath & "\t1ExtCapture" & LogsID & "\JPEGCapture\" & orgCAp & "" 'Get_ImageName()
                .Load()
            End With
            Return "t1ExtCapture" & LogsID
        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
            Return vbNullString
        End Try
    End Function

    Function t1inExtCapture(ByVal LogsID As String) As String
        Try
            Dim orgCAp As String

            CamEntry.JPEGCapturePicture(My.Settings.CAM_ChannelCap1, 0, 0, My.Settings.CapImgPath & "\t1inExtCapture" & LogsID & "\")
            orgCAp = Dir(My.Settings.CapImgPath & "\t1inExtCapture" & LogsID & "\JPEGCapture\*.jpeg")
            With MainSystem.EntCap
                .ImageLocation = My.Settings.CapImgPath & "\t1inExtCapture" & LogsID & "\JPEGCapture\" & orgCAp & "" 'Get_ImageName()
                .Load()
            End With
            Return "t1inExtCapture" & LogsID
        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
            Return vbNullString
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
            CamEntry.JPEGCapturePicture(My.Settings.CAM_ChannelCap1, 0, 0, locCapPath)
            orgCAp = Dir(locCapPath & "\JPEGCapture\*.jpeg")
            With MainSystem.EntCap
                .ImageLocation = locCapPath & "\JPEGCapture\" & orgCAp & "" 'Get_ImageName()
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

            CamExit.JPEGCapturePicture(My.Settings.CAM_ChannelCap2, 0, 0, My.Settings.CapImgPath & "\t2ExtCapture" & LogsID & "\")
            orgCAp = Dir(My.Settings.CapImgPath & "\t2ExtCapture" & LogsID & "\JPEGCapture\*.jpeg")
            With MainSystem.EntCap2
                .ImageLocation = My.Settings.CapImgPath & "\t2ExtCapture" & LogsID & "\JPEGCapture\" & orgCAp & "" 'Get_ImageNameExt()
                .Load()
            End With
            Return "t2ExtCapture" & LogsID
        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
            Return vbNullString
        End Try
    End Function

    Function t2inExtCapture(ByVal LogsID As String) As String
        Try
            Dim orgCAp As String

            CamExit.JPEGCapturePicture(My.Settings.CAM_ChannelCap2, 0, 0, My.Settings.CapImgPath & "\t2inExtCapture" & LogsID & "\")
            orgCAp = Dir(My.Settings.CapImgPath & "\t2inExtCapture" & LogsID & "\JPEGCapture\*.jpeg")
            With MainSystem.EntCap2
                .ImageLocation = My.Settings.CapImgPath & "\t2inExtCapture" & LogsID & "\JPEGCapture\" & orgCAp & "" 'Get_ImageNameExt()
                .Load()
            End With
            Return "t2inExtCapture" & LogsID
        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
            Return vbNullString
        End Try
    End Function

    Function t2inCapture(ByVal CapIDno As String, ByVal LogsID As String) As String
        Try
            Dim orgCAp As String
            If Directory.Exists(My.Settings.CapImgPath & "\" & CapIDno) = True Then
            Else
                Directory.CreateDirectory(My.Settings.CapImgPath & "\" & CapIDno)
            End If

            Dim locCapPath As String = My.Settings.CapImgPath & "\" & CapIDno & "\t2EntCapture" & LogsID

            CamExit.JPEGCapturePicture(My.Settings.CAM_ChannelCap2, 0, 0, locCapPath)
            orgCAp = Dir(locCapPath & "\JPEGCapture\*.jpeg")
            With MainSystem.EntCap2
                .ImageLocation = locCapPath & "\JPEGCapture\" & orgCAp & "" 'Get_ImageNameExt()
                .Load()
            End With
            Return "t2EntCapture" & LogsID
        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
            Return vbNullString
        End Try
    End Function

    Public Function Camera_Capture1() As Boolean
        Delete_Image()
        With CamEntry
            Dim Cap As Integer = frmCamSettings.CaptureEnt.Value
            If .JPEGCapturePicture(Cap, 0, 0, Application.StartupPath & "\Capture") = True Then
                With MainSystem.EntCap
                    ' .ImageLocation = Get_ImageName()
                    '.Load()
                End With
                Return True
            Else
                With MainSystem.EntCap
                    .Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
                End With
                Return False
            End If
        End With
    End Function

    Public Function Camera_Capture2() As Boolean
        Delete_Image()
        With CamExit
            Dim Cap As Integer = frmCamSettings.CaptureExt.Value
            If .JPEGCapturePicture(Cap, 0, 0, Application.StartupPath & "\Capture") = True Then
                With MainSystem.EntCap2
                    '  .ImageLocation = Get_ImageName()
                    '  .Load()
                End With
                Return True
            Else
                With MainSystem.EntCap2
                    .Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
                End With
                Return False
            End If
        End With
    End Function

    Public Sub Camera_EntDiscon()
        With CamEntry
            .Logout()
            .ClearOCX()
        End With
    End Sub

    Public Sub Camera_ExtDiscon()
        With CamExit
            .Logout()
            .ClearOCX()
        End With
    End Sub

    Sub realInSave()
        If subSQl() = False Then Exit Sub

        With MainSystem
            Try
                Dim rs = New Recordset

                rs = New Recordset
                rs.Open("select * from tbltimein where 1=0", conSql, 1, 2)
                rs.AddNew()
                rs("IDnumber").Value = .lblIdNum.Text
                rs("Name").Value = .lblName.Text
                rs("TimeIn").Value = Now

                If My.Settings.SetCapture = True Then
                    rs("FolderName").Value = t1InCapture(.lblIdNum.Text, My.Settings.t1InCapID)
                End If

                rs.Update()
            Catch ex As Exception
                .txtSystemErr.Text = ex.Message
            End Try
        End With

    End Sub

    Sub realInSave2()
        If subSQl() = False Then Exit Sub

        With MainSystem
            Try
                Dim rs = New Recordset

                rs = New Recordset
                rs.Open("select * from tbltimein where 1=0", conSql, 1, 2)

                rs.AddNew()
                rs("IDnumber").Value = .txtIdNo.Text
                rs("Name").Value = .txtName.Text
                rs("TimeIn").Value = Now

                If My.Settings.SetCapture = True Then
                    rs("FolderName").Value = t2inCapture(.txtIdNo.Text, My.Settings.t2InCapID)
                End If

                rs.Update()
            Catch ex As Exception
                .txtSystemErr.Text = ex.Message
            End Try
        End With

    End Sub

    Function OutVer(ByVal petsa As String, idNum As String) As Boolean
        If subSQl() = False Then Return False

        Try
            Dim rs = New Recordset
            Dim qpetsa As String = Format(CDate(petsa), "yyyy-MM-dd")
            rs = New Recordset
            rs = conSql.Execute("select * from tbltimein where IDnumber = '" & idNum & "' limit 1;")
            If rs.EOF = True Then
                    Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
            Return False
        End Try
    End Function

    Function InVer() As Boolean
        If subSQl() = False Then Return False

        With MainSystem
            Try
                Dim rs = New Recordset
                rs = New Recordset
                rs = conSql.Execute("select * from tbltimein where IDnumber = '" & .lblIdNum.Text & "'")
                If rs.EOF = False Then
                    ' OrasIn = vbNullString
                    ' OrasIn = rs("TimeIn").Value
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                MainSystem.txtSystemErr.Text = ex.Message
                Return False
            End Try
        End With
    End Function

    Sub realOutSave(idNum As String)
        If subSQl() = False Then Exit Sub

        With MainSystem
            Try
                Dim rs = New Recordset
                Dim rs2 As New Recordset

                rs = New Recordset
                rs = conSql.Execute("select * from tbltimein where IDnumber = '" & idNum & "'")
                If rs.EOF = False Then
                    rs2 = New Recordset
                    rs2.Open("select * from tblinout where 1=0", conSql, 1, 2)
                    rs2.AddNew()
                    rs2("IDnumber").Value = .lblIdNum.Text
                    rs2("Name").Value = .lblName.Text
                    rs2("TimeIn").Value = rs("TimeIn").Value
                    rs2("TimeOut").Value = Now
                    rs2("PicEnt").Value = rs("PicPath").Value
                    'InLogId1 = rs("IdLog").Value
                    'If rs("FolderName").Value <> vbNullString Then
                    'FolderINnem1 = rs("FolderName").Value
                    'End If

                    If My.Settings.SetCapture = True Then
                        rs2("FolderName").Value = t1inExtCapture(My.Settings.t1InOutCapID)
                    End If

                    rs2.Update()
                End If

            Catch ex As Exception
                MainSystem.txtSystemErr.Text = ex.Message
            End Try
        End With
       
    End Sub

    Sub realOutSave2(idNum As String)
        If subSQl() = False Then Exit Sub

        With MainSystem
            Try
                Dim rs = New Recordset
                Dim rs2 As New Recordset

                rs = New Recordset
                rs = conSql.Execute("select * from tbltimein where IDnumber = '" & idNum & "'")
                If rs.EOF = False Then
                    rs2 = New Recordset
                    rs2.Open("select * from tblinout where 1=0", conSql, 1, 2)
                    rs2.AddNew()
                    rs2("IDnumber").Value = .txtIdNo.Text
                    rs2("Name").Value = .txtName.Text
                    rs2("TimeIn").Value = rs("TimeIn").Value
                    rs2("TimeOut").Value = Now
                    rs2("PicEnt").Value = rs("PicPath").Value
                    ' InLogId2 = rs("IdLog").Value
                    ' If rs("FolderName").Value <> vbNullString Then
                    'FolderINnem2 = rs("FolderName").Value
                    ' End If

                    If My.Settings.SetCapture = True Then
                        rs2("FolderName").Value = t2inExtCapture(My.Settings.t2InOutCapID)
                    End If

                    rs2.Update()
                End If

            Catch ex As Exception
                .txtSystemErr.Text = ex.Message
            End Try
        End With
    End Sub

    Sub OutSave()
        If subSQl() = False Then Exit Sub

        With MainSystem
            Try
                Dim rs = New Recordset

                rs = New Recordset
                rs.Open("select * from tbltimeout where 1=0", conSql, 1, 2)

                rs.AddNew()
                rs("IDnumber").Value = .lblIdNum.Text
                rs("Name").Value = .lblName.Text
                rs("TimeOut").Value = Now

                If My.Settings.SetCapture = True Then
                    rs("FolderName").Value = t1extCapture(My.Settings.t1OutCapID)
                End If

                rs.Update()
            Catch ex As Exception
                .txtSystemErr.Text = ex.Message
            End Try
        End With
      
    End Sub

    Sub OutSave2()
        If subSQl() = False Then Exit Sub

        With MainSystem
            Try
                Dim rs = New Recordset

                rs = New Recordset
                rs.Open("select * from tbltimeout where 1=0", conSql, 1, 2)

                rs.AddNew()
                rs("IDnumber").Value = .txtIdNo.Text
                rs("Name").Value = .txtName.Text
                rs("TimeOut").Value = Now

                If My.Settings.SetCapture = True Then
                    rs("FolderName").Value = t2extCapture(My.Settings.t2OutCapID)
                End If

                rs.Update()
            Catch ex As Exception
                .txtSystemErr.Text = ex.Message
            End Try
        End With
        
    End Sub

    Sub delInLog(idnum As String)
        If subSQl() = False Then Exit Sub

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSql.Execute("Delete from tbltimeIn where IDnumber = '" & idnum & "'")
        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
        End Try
        
    End Sub

    Sub getIDlog()
        If subSQl() = False Then Exit Sub

        Try
            Dim rs = New Recordset
            rs = New Recordset
            rs = conSql.Execute("select * from tbltimein order by idlog desc")
            idLog = rs("idlog").Value.ToString
        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub getIDlogOut()
        If subSQl() = False Then Exit Sub

        Try
            Dim rs = New Recordset
            rs = New Recordset
            rs = conSql.Execute("select * from tblinout order by InOutID desc")
            idLog2 = rs("InOutID").Value
        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
        End Try
      
    End Sub

    Function GetLastInLog(ByVal IdNo As String) As Long
        If subSQl() = False Then
            Return 0
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSql.Execute("select Idlog,IDnumber from tbltimein where IDnumber = '" & IdNo & "' order by Idlog desc limit 1;")
            If rs.EOF = False Then
                Return rs("IDnumber").Value
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Function GetLastOutLog(ByVal IdNo As String) As String
        If subSQl() = False Then
            Return 0
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSql.Execute("select Idlog from tbltimeout where IDnumber = '" & IdNo & "' order by Idlog desc limit 1;")
            If rs.EOF = False Then
                Return "Out" & rs("Idlog").Value
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Function GetLastInoutLog(ByVal IdNo As String) As String
        If subSQl() = False Then
            Return 0
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSql.Execute("select InOutID from tblinout where IDnumber = '" & IdNo & "' order by InOutID desc limit 1;")
            If rs.EOF = False Then
                Return "InOut" & rs("InOutID").Value
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Sub Dev1_OnAttTransaction(sender As System.Object, e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent) Handles Dev1.OnAttTransaction

        If subSQl() = False Then Exit Sub

        If Directory.Exists(My.Settings.CapImgPath) = False Then
            MainSystem.txtSystemErr.Text = "Please set Capture Image Designate Path!"
            Exit Sub
        End If

        Try
            With MainSystem
                Select Case DevC_Frame
                    Case "Frame1"
                        If DevC_Stat = "In" Then

                            If Erollin1 = e.enrollNumber Then
                                If Erollout1 = e.enrollNumber Then
                                    Erollout1 = "0"
                                End If

                                If Erollout2 = e.enrollNumber Then
                                    Erollout2 = "0"
                                End If
                                MainSystem.txtSystemErr.Text = "CARD ALREADY TAPPED!"
                                Exit Sub
                            End If

                            If My.Settings.SetAutoClear = True Then
                                tmeClear1.Interval = DevC_Delay
                                tmeClear1.Enabled = False
                            End If

                            .lblInOut.Text = "Time In :"
                            .lblInOut.Left = 21
                            .lblInOut.Top = 190

                            entInfo(e.enrollNumber)
                            realInSave()
                            With My.Settings
                                .t1InCapID = .t1InCapID + 1
                                .Save()
                            End With
                            'FolderIn(GetLastInLog(.lblIdNum.Text), inCapture(GetLastInLog(.lblIdNum.Text)))
                            If My.Settings.SetAutoClear = True Then
                                tmeClear1.Enabled = True
                            End If

                            If My.Settings.SetAutoReg = True Then
                                If buffin1 = My.Settings.ConnBuff Then
                                    Dev1.RegEvent(1, 1)
                                    buffin1 = 0
                                End If
                            End If

                            buffin1 = buffin1 + 1

                            Erollin1 = e.enrollNumber
                            If Erollout1 = e.enrollNumber Then
                                Erollout1 = "0"
                            End If

                            If Erollout2 = e.enrollNumber Then
                                Erollout2 = "0"
                            End If
                        Else
                            If Erollout1 = e.enrollNumber Then
                                If Erollin1 = e.enrollNumber Then
                                    Erollin1 = "0"
                                End If

                                If Erollin2 = e.enrollNumber Then
                                    Erollin2 = "0"
                                End If

                                MainSystem.txtSystemErr.Text = "CARD ALREADY TAPPED!"
                                Exit Sub
                            End If

                            If My.Settings.SetAutoClear = True Then
                                tmeClear1.Interval = DevC_Delay
                                tmeClear1.Enabled = False
                            End If

                            .lblInOut.Text = "Time Out :"
                            .lblInOut.Left = 8
                            .lblInOut.Top = 190

                            entInfo(e.enrollNumber)

                            If OutVer(Now, .lblIdNum.Text) = True Then

                                OutSave()
                                With My.Settings
                                    .t1OutCapID = .t1OutCapID + 1
                                    .Save()
                                End With
                                ' FolderOut(GetLastOutLog(.lblIdNum.Text), inCapture(GetLastOutLog(.lblIdNum.Text)))

                                If My.Settings.SetAutoClear = True Then
                                    tmeClear1.Enabled = True
                                End If

                                If My.Settings.SetAutoReg = True Then
                                    If buffOut1 = My.Settings.ConnBuff Then
                                        Dev1.RegEvent(1, 1)
                                        buffOut1 = 0
                                    End If
                                End If

                                buffOut1 = buffOut1 + 1

                                Erollout1 = e.enrollNumber
                                If Erollin1 = e.enrollNumber Then
                                    Erollin1 = "0"
                                End If

                                If Erollin2 = e.enrollNumber Then
                                    Erollin2 = "0"
                                End If

                                Exit Sub
                            End If


                            realOutSave(.lblIdNum.Text)
                            With My.Settings
                                .t1InOutCapID = .t1InOutCapID + 1
                                .Save()
                            End With
                            ' FolderInOut(GetLastInoutLog(.lblIdNum.Text), inCapture(GetLastInoutLog(.lblIdNum.Text)))

                            Delete_ImageIn(.lblIdNum.Text)

                            delInLog(.lblIdNum.Text)

                            If My.Settings.SetAutoClear = True Then
                                tmeClear1.Enabled = True
                            End If

                            If My.Settings.SetAutoReg = True Then
                                If buffOut1 = My.Settings.ConnBuff Then
                                    Dev1.RegEvent(1, 1)
                                    buffOut1 = 0
                                End If
                            End If

                            buffOut1 = buffOut1 + 1

                            Erollout1 = e.enrollNumber
                            If Erollin1 = e.enrollNumber Then
                                Erollin1 = "0"
                            End If

                            If Erollin2 = e.enrollNumber Then
                                Erollin2 = "0"
                            End If

                        End If
                    Case "Frame2"
                        If DevC_Stat = "In" Then

                            If Erollin2 = e.enrollNumber Then
                                If Erollout1 = e.enrollNumber Then
                                    Erollout1 = "0"
                                End If

                                If Erollout2 = e.enrollNumber Then
                                    Erollout2 = "0"
                                End If

                                MainSystem.txtSystemErr.Text = "CARD ALREADY TAPPED!"
                                Exit Sub
                            End If

                            If My.Settings.SetAutoClear = True Then
                                tmeClear1.Interval = DevC_Delay
                                tmeClear1.Enabled = False
                            End If

                            .txtLabel2.Text = "Time In :"
                            .txtLabel2.Left = 21
                            .txtLabel2.Top = 191

                            entInfo2(e.enrollNumber)

                            realInSave2()
                            With My.Settings
                                .t2InCapID = .t2InCapID + 1
                                .Save()
                            End With
                            'FolderIn(GetLastInLog(.txtIdNo.Text), outCapture(GetLastInLog(.txtIdNo.Text)))

                            If My.Settings.SetAutoClear = True Then
                                tmeClear2.Enabled = True
                            End If

                            If My.Settings.SetAutoReg = True Then
                                If buffin2 = My.Settings.ConnBuff Then
                                    Dev1.RegEvent(1, 1)
                                    buffin2 = 0
                                End If
                            End If

                            buffin2 = buffin2 + 1

                            Erollin2 = e.enrollNumber

                            If Erollout1 = e.enrollNumber Then
                                Erollout1 = "0"
                            End If

                            If Erollout2 = e.enrollNumber Then
                                Erollout2 = "0"
                            End If

                        Else

                            If Erollout2 = e.enrollNumber Then
                                If Erollin1 = e.enrollNumber Then
                                    Erollin1 = "0"
                                End If

                                If Erollin2 = e.enrollNumber Then
                                    Erollin2 = "0"
                                End If
                                MainSystem.txtSystemErr.Text = "CARD ALREADY TAPPED!"
                                Exit Sub
                            End If

                            If My.Settings.SetAutoClear = True Then
                                tmeClear1.Interval = DevC_Delay
                                tmeClear1.Enabled = False
                            End If

                            .txtLabel2.Text = "Time Out :"
                            .txtLabel2.Left = 8
                            .txtLabel2.Top = 190

                            entInfo2(e.enrollNumber)

                            If OutVer(Now, .txtIdNo.Text) = True Then
                                OutSave2()
                                With My.Settings
                                    .t2OutCapID = .t2OutCapID + 1
                                    .Save()
                                End With
                                'FolderOut(GetLastOutLog(.txtIdNo.Text), outCapture(GetLastOutLog(.txtIdNo.Text)))

                                If My.Settings.SetAutoClear = True Then
                                    tmeClear2.Enabled = True
                                End If

                                If My.Settings.SetAutoReg = True Then
                                    If buffout2 = My.Settings.ConnBuff Then
                                        Dev1.RegEvent(1, 1)
                                        buffout2 = 0
                                    End If
                                End If

                                buffout2 = buffout2 + 1

                                Erollout2 = e.enrollNumber
                                If Erollin1 = e.enrollNumber Then
                                    Erollin1 = "0"
                                End If

                                If Erollin2 = e.enrollNumber Then
                                    Erollin2 = "0"
                                End If

                                Exit Sub
                            End If

                            realOutSave2(.txtIdNo.Text)
                            With My.Settings
                                .t2InOutCapID = .t2InOutCapID + 1
                                .Save()
                            End With
                            'FolderInOut(GetLastInoutLog(.txtIdNo.Text), outCapture(GetLastInoutLog(.txtIdNo.Text)))

                            Delete_ImageIn(.txtIdNo.Text)

                            delInLog(.txtIdNo.Text)

                            If My.Settings.SetAutoClear = True Then
                                tmeClear2.Enabled = True
                            End If

                            If My.Settings.SetAutoReg = True Then
                                If buffout2 = My.Settings.ConnBuff Then
                                    Dev1.RegEvent(1, 1)
                                    buffout2 = 0
                                End If
                            End If

                            buffout2 = buffout2 + 1

                            Erollout2 = e.enrollNumber
                            If Erollin1 = e.enrollNumber Then
                                Erollin1 = "0"
                            End If

                            If Erollin2 = e.enrollNumber Then
                                Erollin2 = "0"
                            End If
                        End If
                End Select
            End With
        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem3.Click
        If MainSystem.txtAdmin.Text = vbNullString Then
            MsgBox("Please Login First! ", vbExclamation, "Connect")
            Exit Sub
        End If

        If devcon1(DevC_Ip) = True Then
            MsgBox("Successfully connected! ", vbInformation, "Device")
        Else
            MsgBox("Failed to connect! ", vbInformation, "Device")
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem2.Click
        If MainSystem.txtAdmin.Text = vbNullString Then
            MsgBox("Please Login First! ", vbExclamation, "Disconnect")
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

    Private Sub RefreshCameraToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RefreshCameraToolStripMenuItem.Click
        If MainSystem.txtAdmin.Text = vbNullString Then
            MsgBox("Please Login First! ", vbExclamation, "Connect")
            Exit Sub
        End If

        If Camera_Connect1() = True Then
            MsgBox("Camera 1 Refreshed!", vbInformation, "Refresh Camera 1")
        Else
            MsgBox("Failed to connect to camera 1! ", vbExclamation, "Refresh Camera 1")
        End If
    End Sub

    Private Sub RefreshCamera2ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RefreshCamera2ToolStripMenuItem.Click
        If MainSystem.txtAdmin.Text = vbNullString Then
            MsgBox("Please Login First! ", vbExclamation, "Connect")
            Exit Sub
        End If

        If Camera_Connect2() = True Then
            MsgBox("Camera 2 Refreshed!", vbInformation, "Refresh Camera 2")
        Else
            MsgBox("Failed to connect to camera 2! ", vbExclamation, "Refresh Camera 2")
        End If
    End Sub

    Private Sub tmeClear1_Tick(sender As System.Object, e As System.EventArgs) Handles tmeClear1.Tick
        With MainSystem
            .lblIdNum.Text = "________"
            .lblName.Text = "________"
            .lblPosition.Text = "________"
            .lblGender.Text = "________"
            .EmpPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            .lblRealTime.Text = "________"

            .EntCap.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
            tmeClear1.Enabled = False
        End With
    End Sub

    Private Sub tmeClear2_Tick(sender As System.Object, e As System.EventArgs) Handles tmeClear2.Tick
        With MainSystem
            .txtIdNo.Text = "________"
            .txtName.Text = "________"
            .txtPosi.Text = "________"
            .txtGender.Text = "________"
            .EmpPic2.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            .txtInOutTime.Text = "________"

            .EntCap2.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
            tmeClear2.Enabled = False
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

    Private Sub ContextMenuStrip1_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

End Class
