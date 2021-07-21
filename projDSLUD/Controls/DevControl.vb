Imports ADODB
Public Class DevControl
    Public DevC_Name As String
    Public DevC_Ip As String
    Public DevC_Frame As String
    Public DevC_Stat As String
    Public DevC_Delay As Long

    Public idPicno As String

    Sub Msg(studID As String, stat As Short)
        Dim rs As New Recordset
        Dim rs2 As New Recordset

        rs = New Recordset
        rs.Open("select * from tblstudinfo where IDnumber = '" & studID & "'", conSql, 1, 2)
        If rs.EOF = False Then
            'On Error Resume Next
            Try
                rs2 = New Recordset
                rs2.Open("select * from tblMsg", conSql, 1, 2)
                rs2.AddNew()
                rs2("IDnumber").Value = rs("IDnumber").Value
                rs2("Name").Value = rs("Name").Value
                rs2("ContactNo").Value = rs("ContactNo").Value
                rs2("Gender").Value = rs("Gender").Value
                rs2("TimeIn").Value = Now
                rs2("Stat").Value = stat
                'rs2("Pic").Value = rs("PHOTO").Value
                rs2.Update()
            Catch ex As Exception
                MainSystem.txtSystemErr.Text = ex.Message
            End Try

        Else
            Try
                rs2 = New Recordset
                rs2.Open("select * from tblMsg", conSql, 1, 2)
                rs2.AddNew()
                rs2("IDnumber").Value = studID
                rs2("Name").Value = "Not Encoded"
                rs2("ContactNo").Value = "Not Encoded"
                rs2("Gender").Value = "Not Encoded"
                rs2("TimeIn").Value = Now
                rs2("Stat").Value = stat
                rs2.Update()
            Catch ex As Exception
                MainSystem.txtSystemErr.Text = ex.Message
            End Try
        End If
    End Sub

    Private Sub Dev1_OnAttTransaction(sender As System.Object, e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent) Handles Dev1.OnAttTransaction
        If conServer() = False Then Exit Sub
        idPicno = vbNullString

        With MainSystem
            Select Case DevC_Frame
                Case "Frame1"
                    tmeClear1.Interval = DevC_Delay
                    tmeClear1.Enabled = False
                    tmeClear1.Enabled = True

                    If DevC_Stat = "In" Then
                        .T1lblTime.Top = 171
                        .T1lblTime.Left = 41
                        .T1lblTime.Text = "Time In :"
                        ShowStudInfo1(e.enrollNumber)
                        .t1pic.Image = StudentPic(idPicno)

                        If CheckIn(.T1IdNo.Text) = True Then
                            Exit Sub
                        End If

                        SaveIn(.T1IdNo.Text, Now)
                        'Msg(.T1IdNo.Text, 1)
                        Dev1.RegEvent(1, 32767)
                    Else
                        .T1lblTime.Top = 171
                        .T1lblTime.Left = 24
                        .T1lblTime.Text = "Time Out :"
                        ShowStudInfo1(e.enrollNumber)
                        .t1pic.Image = StudentPic(idPicno)
                        inOutSave(.T1IdNo.Text)
                        delIn(.T1IdNo.Text)
                        'Msg(.T1IdNo.Text, 0)
                        Dev1.RegEvent(1, 32767)
                    End If
                Case "Frame2"
                    tmeClear2.Interval = DevC_Delay
                    tmeClear2.Enabled = False
                    tmeClear2.Enabled = True

                    If DevC_Stat = "In" Then
                        .T2lblTime.Top = 171
                        .T2lblTime.Left = 41
                        .T2lblTime.Text = "Time In :"
                        ShowStudInfo2(e.enrollNumber)
                        .t2pic.Image = StudentPic(idPicno)

                        If CheckIn(.T2IdNo.Text) = True Then
                            Exit Sub
                        End If

                        SaveIn(.T2IdNo.Text, Now)
                        ' Msg(.T2IdNo.Text, 1)
                        Dev1.RegEvent(1, 32767)
                    Else
                        .T2lblTime.Top = 171
                        .T2lblTime.Left = 24
                        .T2lblTime.Text = "Time Out :"
                        ShowStudInfo2(e.enrollNumber)
                        .t2pic.Image = StudentPic(idPicno)

                        inOutSave(.T2IdNo.Text)
                        delIn(.T2IdNo.Text)
                        ' Msg(.T2IdNo.Text, 0)
                        Dev1.RegEvent(1, 32767)
                    End If
                Case "Frame3"
                    tmeClear3.Interval = DevC_Delay
                    tmeClear3.Enabled = False
                    tmeClear3.Enabled = True

                    If DevC_Stat = "In" Then
                        .T3lblTime.Top = 171
                        .T3lblTime.Left = 41
                        .T3lblTime.Text = "Time In :"
                        ShowStudInfo3(e.enrollNumber)
                        .t3pic.Image = StudentPic(idPicno)

                        If CheckIn(.T3IdNo.Text) = True Then
                            Exit Sub
                        End If

                        SaveIn(.T3IdNo.Text, Now)
                        '  Msg(.T3IdNo.Text, 1)
                        Dev1.RegEvent(1, 32767)
                    Else
                        .T3lblTime.Top = 171
                        .T3lblTime.Left = 24
                        .T3lblTime.Text = "Time Out :"
                        ShowStudInfo3(e.enrollNumber)
                        .t3pic.Image = StudentPic(idPicno)

                        inOutSave(.T3IdNo.Text)
                        delIn(.T3IdNo.Text)
                        'Msg(.T3IdNo.Text, 0)
                        Dev1.RegEvent(1, 32767)
                    End If
                Case "Frame4"
                    tmeClear4.Interval = DevC_Delay
                    tmeClear4.Enabled = False
                    tmeClear4.Enabled = True

                    If DevC_Stat = "In" Then
                        .T4lblTime.Top = 171
                        .T4lblTime.Left = 41
                        .T4lblTime.Text = "Time In :"
                        ShowStudInfo4(e.enrollNumber)
                        .t4pic.Image = StudentPic(idPicno)

                        If CheckIn(.T4IdNo.Text) = True Then
                            Exit Sub
                        End If

                        SaveIn(.T4IdNo.Text, Now)
                        ' Msg(.T4IdNo.Text, 1)
                        Dev1.RegEvent(1, 32767)
                    Else
                        .T4lblTime.Top = 171
                        .T4lblTime.Left = 24
                        .T4lblTime.Text = "Time Out :"
                        ShowStudInfo4(e.enrollNumber)
                        .t4pic.Image = StudentPic(idPicno)

                        inOutSave(.T4IdNo.Text)
                        delIn(.T4IdNo.Text)
                        '  Msg(.T4IdNo.Text, 0)
                        Dev1.RegEvent(1, 32767)
                    End If
            End Select
        End With
     
    End Sub

    Public Function devcon1(ByVal ipAdd As String) As Boolean

        If PingMe(ipAdd) = True Then
            DevStat.Text = "Connected"
            DevStat.ForeColor = Color.Cyan
            Dev1.BeginInit()
            Dev1.Connect_Net(ipAdd, 4370)
            Dev1.BASE64 = 0
            Dev1.RegEvent(1, 32767)
            Timer1.Enabled = True
            Return True
        Else
            DevStat.Text = "Disconnected"
            DevStat.ForeColor = Color.Pink
            Timer1.Enabled = False
            Return False
        End If
    End Function

    Private Sub DevControl_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ContextMenuStrip = ContextMenuStrip1

        If DevC_Ip = vbNullString Then
            DevC_Name = Dev_Name
            DevC_Ip = Dev_Ip
            DevC_Frame = Dev_Frame
            DevC_Stat = Dev_Stat
            DevC_Delay = Dev_Delay

            txtDevName.Text = DevC_Name
            DevStat.Text = DevC_Stat

            devcon1(DevC_Ip)
        End If
        
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem3.Click
        If MainSystem.txtSystemUser.Text = "Lock" Then
            MsgBox("Please login first! ", vbExclamation, "System")
            Exit Sub
        End If

        If devcon1(DevC_Ip) = True Then
            MsgBox("Successfully connected! ", vbInformation, "Device")
        Else
            MsgBox("Failed to connect! ", vbInformation, "Device")
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem2.Click
        If MainSystem.txtSystemUser.Text = "Lock" Then
            MsgBox("Please login first! ", vbExclamation, "System")
            Exit Sub
        End If

        If MsgBox("Are you sure do you want to disconnect this reader? ", vbYesNo + vbQuestion + vbDefaultButton2, "Disconnect") = vbYes Then
            Dev1.EndInit()
            Dev1.Disconnect()

            DevStat.Text = "Disconnected"
            DevStat.ForeColor = Color.Pink

            MsgBox("Reader successfully disconnected! ", vbInformation, "Disconnect")
        End If
    End Sub

    Sub ShowStudInfo1(ByVal id As String)
        If conServer() = False Then Exit Sub

        Try
            With MainSystem
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
            With MainSystem
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
                    .t2Pic.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
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

    Sub SaveIn(idNo As String, inTime As Date)
        If conServer() = False Then Exit Sub
        Try
            Dim rs = New Recordset
            rs = New Recordset
            rs.Open("select * from tbltimein where 1=0", conSql, 1, 2)
            rs.AddNew()
            rs("IDnumber").Value = idNo
            rs("TimeIn").Value = inTime
            rs.Update()
        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub inOutSave(ByVal idno As String)
        If conServer() = False Then Exit Sub
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
        If conServer() = False Then Exit Sub

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
End Class
