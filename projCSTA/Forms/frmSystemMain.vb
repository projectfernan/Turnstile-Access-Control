Public Class frmSystemMain

    Private Sub frmSystemMain_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            frmLogin.ShowDialog()
        End If
    End Sub

    Sub header()
        ' Dim w As Integer = Lstlist.Width / 4
        ' Dim w2 As Integer = w / 6
        ' Dim w3 As Integer = w + w2
        ' Dim w4 As Integer = w - w2
        ' Dim wN As Integer = (w + w) '- w2
        ' Lstlist.Columns.Add("Idnumber", w4, HorizontalAlignment.Left)
        ' Lstlist.Columns.Add("Name", wN, HorizontalAlignment.Left)
        ' Lstlist.Columns.Add("Logged In Time", w3, HorizontalAlignment.Left)
    End Sub

    Sub fill()
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Try
            Dim rs As New Recordset
            Dim lup As Short
            rs = New Recordset
            rs = conSql.Execute("select * from vwetimein")
            If rs.EOF = False Then
                For lup = 1 To rs.RecordCount
                    'Lstlist.Refresh()
                    Dim viewlst As New ListViewItem
                    'viewlst = Lstlist.Items.Add(rs("IDnumber").Value, lup)
                    viewlst.SubItems.Add(rs("Name").Value)
                    viewlst.SubItems.Add(Format(CDate(rs("TimeIn").Value), "yyyy-MM-dd HH:mm:ss"))
                    rs.MoveNext()
                Next
            End If
        Catch ex As Exception
            txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        txtTimeDate.Text = Format(Now, "long date") & "    " & Format(Now, "HH:mm:ss tt")
    End Sub

    Private Sub frmSystemMain_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

        ViewConn()

        If conServer() = True Then
            If frmLogo.chk = False Then
                Pic2Sa.Image = Logo_Image()
            End If
        End If

        If ConPath() = True Then

        End If

        tbldevcon()

        t1devcon1(frmConDev.T1DevIp1.Text)
        t1devcon2(frmConDev.T1DevIp2.Text)

        t2devcon1(frmConDev.T2DevIp1.Text)
        t2devcon2(frmConDev.T2DevIp2.Text)

        t3devcon1(frmConDev.T3DevIp1.Text)
        t3devcon2(frmConDev.T3DevIp2.Text)

        t4devcon1(frmConDev.T4DevIp1.Text)
        t4devcon2(frmConDev.T4DevIp2.Text)
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
            txtSystemErr.Text = ex.Message
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
            txtSystemErr.Text = ex.Message
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
            txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub ShowStudInfo1(ByVal id As String)
        If conServer() = False Then Exit Sub

        Try
            Dim rs = New Recordset
            rs = New Recordset
            rs = conSql.Execute("select * from tblStudInfo where AcNumber = '" & id & "'")
            If rs.EOF = False Then
                '    idPicno = rs("IdNumber").Value
                T1IdNo.Text = rs("IdNumber").Value
                T1Name.Text = rs("Name").Value
                T1Gy.Text = rs("Course").Value
                T1InOut.Text = Now
            Else
                T1IdNo.Text = "Unregistered Card"
                T1Name.Text = "Unregistered Card"
                T1Gy.Text = "Unregistered Card"
                T1InOut.Text = Now
                t1pic.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
            End If
        Catch ex As Exception
            txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub ShowStudInfo2(ByVal id As String)
        If conServer() = False Then Exit Sub

        Try
            Dim rs = New Recordset
            rs = New Recordset
            rs = conSql.Execute("select * from tblStudInfo where AcNumber = '" & id & "'")
            If rs.EOF = False Then
                '  idPicno = rs("IdNumber").Value
                T2IdNo.Text = rs("IdNumber").Value
                T2Name.Text = rs("Name").Value
                T2Gy.Text = rs("Course").Value
                T2InOut.Text = Now
            Else
                T2IdNo.Text = "Unregistered Card"
                T2Name.Text = "Unregistered Card"
                T2Gy.Text = "Unregistered Card"
                T2InOut.Text = Now
                t2Pic.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
            End If
        Catch ex As Exception
            txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub ShowStudInfo3(ByVal id As String)
        If conServer() = False Then Exit Sub

        Try
            Dim rs = New Recordset
            rs = New Recordset
            rs = conSql.Execute("select * from tblStudInfo where AcNumber = '" & id & "'")
            If rs.EOF = False Then
                '     idPicno = rs("IdNumber").Value
                T3IdNo.Text = rs("IdNumber").Value
                T3Name.Text = rs("Name").Value
                T3Gy.Text = rs("Course").Value
                T3InOut.Text = Now
            Else
                T3IdNo.Text = "Unregistered Card"
                T3Name.Text = "Unregistered Card"
                T3Gy.Text = "Unregistered Card"
                T3InOut.Text = Now
                t3Pic.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
            End If
        Catch ex As Exception
            txtSystemErr.Text = ex.Message
        End Try
    End Sub


    Sub ShowStudInfo4(ByVal id As String)
        If conServer() = False Then Exit Sub

        Try
            Dim rs = New Recordset
            rs = New Recordset
            rs = conSql.Execute("select * from tblStudInfo where AcNumber = '" & id & "'")
            If rs.EOF = False Then
                '  idPicno = rs("IdNumber").Value
                T4IdNo.Text = rs("IdNumber").Value
                T4Name.Text = rs("Name").Value
                T4Gy.Text = rs("Course").Value
                T4InOut.Text = Now
            Else
                T4IdNo.Text = "Unregistered Card"
                T4Name.Text = "Unregistered Card"
                T4Gy.Text = "Unregistered Card"
                T4InOut.Text = Now
                t4Pic.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
            End If
        Catch ex As Exception
            txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Private Sub Dev1_OnAttTransaction(sender As System.Object, e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent) Handles Dev1.OnAttTransaction
        If conServer() = False Then Exit Sub

        tmeClear1.Enabled = False
        tmeClear1.Enabled = True

        T1lblTime.Top = 139
        T1lblTime.Left = 46
        T1lblTime.Text = "Time In :"
        ShowStudInfo1(e.enrollNumber)
        '  t1pic.Image = StudentPic(idPicno)
        If CheckIn(T1IdNo.Text) = True Then
            Exit Sub
        End If

        SaveIn(T1IdNo.Text, Now)
        Dev1.RegEvent(1, 32767)
    End Sub

    Private Sub Dev2_OnAttTransaction(sender As System.Object, e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent) Handles Dev2.OnAttTransaction
        If conServer() = False Then Exit Sub

        tmeClear1.Enabled = False
        tmeClear1.Enabled = True

        T1lblTime.Top = 139
        T1lblTime.Left = 33
        T1lblTime.Text = "Time Out :"
        ShowStudInfo1(e.enrollNumber)
        ' t1pic.Image = StudentPic(idPicno)
        If CheckIn(T1IdNo.Text) = False Then
            Exit Sub
        End If

        inOutSave(T1IdNo.Text)
        delIn(T1IdNo.Text)
        Dev2.RegEvent(1, 32767)
    End Sub

    Private Sub Dev3_OnAttTransaction(sender As System.Object, e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent) Handles Dev3.OnAttTransaction
        If conServer() = False Then Exit Sub

        tmeClear2.Enabled = False
        tmeClear2.Enabled = True

        T2lblTime.Top = 139
        T2lblTime.Left = 46
        T2lblTime.Text = "Time In :"
        ShowStudInfo2(e.enrollNumber)
        ' t2Pic.Image = StudentPic(idPicno)
        If CheckIn(T2IdNo.Text) = True Then
            Exit Sub
        End If

        SaveIn(T2IdNo.Text, Now)
        Dev3.RegEvent(1, 32767)
    End Sub

    Private Sub Dev4_OnAttTransaction(sender As System.Object, e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent) Handles Dev4.OnAttTransaction
        If conServer() = False Then Exit Sub

        tmeClear2.Enabled = False
        tmeClear2.Enabled = True

        T2lblTime.Top = 139
        T2lblTime.Left = 33
        T2lblTime.Text = "Time Out :"
        ShowStudInfo2(e.enrollNumber)
        '   t2Pic.Image = StudentPic(idPicno)
        If CheckIn(T2IdNo.Text) = False Then
            Exit Sub
        End If

        inOutSave(T2IdNo.Text)
        delIn(T2IdNo.Text)
        Dev4.RegEvent(1, 32767)
    End Sub

    Private Sub Dev5_OnAttTransaction(sender As System.Object, e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent) Handles Dev5.OnAttTransaction
        If conServer() = False Then Exit Sub

        tmeClear3.Enabled = False
        tmeClear3.Enabled = True

        T3lblTime.Top = 139
        T3lblTime.Left = 46
        T3lblTime.Text = "Time In :"
        ShowStudInfo3(e.enrollNumber)
        '  t3Pic.Image = StudentPic(idPicno)
        If CheckIn(T3IdNo.Text) = True Then
            Exit Sub
        End If

        SaveIn(T3IdNo.Text, Now)
        Dev5.RegEvent(1, 32767)
    End Sub

    Private Sub Dev6_OnAttTransaction(sender As System.Object, e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent) Handles Dev6.OnAttTransaction
        If conServer() = False Then Exit Sub

        tmeClear3.Enabled = False
        tmeClear3.Enabled = True

        T3lblTime.Top = 139
        T3lblTime.Left = 33
        T3lblTime.Text = "Time Out :"
        ShowStudInfo3(e.enrollNumber)
        '  t3Pic.Image = StudentPic(idPicno)
        If CheckIn(T3IdNo.Text) = False Then
            Exit Sub
        End If

        inOutSave(T3IdNo.Text)
        delIn(T3IdNo.Text)
        Dev6.RegEvent(1, 32767)
    End Sub

    Private Sub Dev7_OnAttTransaction(sender As System.Object, e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent) Handles Dev7.OnAttTransaction
        If conServer() = False Then Exit Sub

        tmeClear4.Enabled = False
        tmeClear4.Enabled = True

        T4lblTime.Top = 139
        T4lblTime.Left = 46
        T4lblTime.Text = "Time In :"
        ShowStudInfo4(e.enrollNumber)
        ' t4Pic.Image = StudentPic(idPicno)
        If CheckIn(T4IdNo.Text) = True Then
            Exit Sub
        End If

        SaveIn(T4IdNo.Text, Now)
        Dev7.RegEvent(1, 32767)
    End Sub

    Private Sub Dev8_OnAttTransaction(sender As System.Object, e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent) Handles Dev8.OnAttTransaction
        If conServer() = False Then Exit Sub

        tmeClear4.Enabled = False
        tmeClear4.Enabled = True

        T4lblTime.Top = 139
        T4lblTime.Left = 33
        T4lblTime.Text = "Time Out :"
        ShowStudInfo4(e.enrollNumber)
        '  t4Pic.Image = StudentPic(idPicno)
        If CheckIn(T4IdNo.Text) = False Then
            Exit Sub
        End If

        inOutSave(T4IdNo.Text)
        delIn(T4IdNo.Text)
        Dev8.RegEvent(1, 32767)
    End Sub

    Private Sub tmeClear1_Tick(sender As System.Object, e As System.EventArgs) Handles tmeClear1.Tick
        T1IdNo.Text = "____________________"
        T1Name.Text = "____________________"
        T1Gy.Text = "____________________"
        T1InOut.Text = "____________________"
        t1pic.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
        tmeClear1.Enabled = False
    End Sub

    Private Sub tmeClear2_Tick(sender As System.Object, e As System.EventArgs) Handles tmeClear2.Tick
        T2IdNo.Text = "____________________"
        T2Name.Text = "____________________"
        T2Gy.Text = "____________________"
        T2InOut.Text = "____________________"
        t2Pic.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
        tmeClear2.Enabled = False
    End Sub

    Private Sub tmeClear3_Tick(sender As System.Object, e As System.EventArgs) Handles tmeClear3.Tick
        T3IdNo.Text = "____________________"
        T3Name.Text = "____________________"
        T3Gy.Text = "____________________"
        T3InOut.Text = "____________________"
        t3Pic.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
        tmeClear3.Enabled = False
    End Sub

    Private Sub tmeClear4_Tick(sender As System.Object, e As System.EventArgs) Handles tmeClear4.Tick
        T4IdNo.Text = "____________________"
        T4Name.Text = "____________________"
        T4Gy.Text = "____________________"
        T4InOut.Text = "____________________"
        t4Pic.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
        tmeClear4.Enabled = False
    End Sub

    Private Sub tmrRef_Tick(sender As System.Object, e As System.EventArgs) Handles tmrRef1.Tick
        If BGWrd1.IsBusy Then
        Else
            BGWrd1.RunWorkerAsync()
        End If
        If BGWrd1.IsBusy Then
        Else
            BGWrd1.RunWorkerAsync()
        End If
        If BGWrd2.IsBusy Then
        Else
            BGWrd2.RunWorkerAsync()
        End If

        If BGWrd3.IsBusy Then
        Else
            BGWrd3.RunWorkerAsync()
        End If

        If BGWrd4.IsBusy Then
        Else
            BGWrd4.RunWorkerAsync()
        End If

        If BGWrd5.IsBusy Then
        Else
            BGWrd5.RunWorkerAsync()
        End If

        If BGWrd6.IsBusy Then
        Else
            BGWrd6.RunWorkerAsync()
        End If

        If BGWrd7.IsBusy Then
        Else
            BGWrd7.RunWorkerAsync()
        End If

        If BGWrd8.IsBusy Then
        Else
            BGWrd8.RunWorkerAsync()
        End If
    End Sub

    Private Sub BGWrd_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGWrd1.DoWork

        If PingMe(My.Settings.T1Dev1) = True Then
            Dev1Stat.Text = "Connected"
            Dev1Stat.ForeColor = Color.Blue
            Dev1.BeginInit()
            Dev1.RegEvent(1, 32767)
        Else
            Dev1Stat.Text = "Disconnected"
            Dev1Stat.ForeColor = Color.Red
        End If
    End Sub

    Private Sub BGWrd2_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGWrd2.DoWork
        If PingMe(My.Settings.T1Dev2) = True Then
            Dev2Stat.Text = "Connected"
            Dev2Stat.ForeColor = Color.Blue
            Dev2.BeginInit()
            Dev2.RegEvent(1, 32767)
        Else
            Dev2Stat.Text = "Disconnected"
            Dev2Stat.ForeColor = Color.Red
        End If
    End Sub

    Private Sub BGWrd3_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGWrd3.DoWork
        If PingMe(My.Settings.T2Dev1) = True Then
            Dev3Stat.Text = "Connected"
            Dev3Stat.ForeColor = Color.Blue
            Dev3.BeginInit()
            Dev3.RegEvent(1, 32767)
        Else
            Dev3Stat.Text = "Disconnected"
            Dev3Stat.ForeColor = Color.Red
        End If
    End Sub

    Private Sub BGWrd4_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGWrd4.DoWork
        If PingMe(My.Settings.T2Dev2) = True Then
            Dev4Stat.Text = "Connected"
            Dev4Stat.ForeColor = Color.Blue
            Dev4.BeginInit()
            Dev4.RegEvent(1, 32767)
        Else
            Dev4Stat.Text = "Disconnected"
            Dev4Stat.ForeColor = Color.Red
        End If
    End Sub

    Private Sub BGWrd5_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGWrd5.DoWork
        If PingMe(My.Settings.T3Dev1) = True Then
            Dev5Stat.Text = "Connected"
            Dev5Stat.ForeColor = Color.Blue
            Dev5.BeginInit()
            Dev5.RegEvent(1, 32767)
        Else
            Dev5Stat.Text = "Disconnected"
            Dev5Stat.ForeColor = Color.Red
        End If
    End Sub

    Private Sub BGWrd6_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGWrd6.DoWork
        If PingMe(My.Settings.T3Dev2) = True Then
            Dev6Stat.Text = "Connected"
            Dev6Stat.ForeColor = Color.Blue
            Dev6.BeginInit()
            Dev6.RegEvent(1, 32767)
        Else
            Dev6Stat.Text = "Disconnected"
            Dev6Stat.ForeColor = Color.Red
        End If
    End Sub

    Private Sub BGWrd7_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGWrd7.DoWork
        If PingMe(My.Settings.T4Dev1) = True Then
            Dev7Stat.Text = "Connected"
            Dev7Stat.ForeColor = Color.Blue
            Dev7.BeginInit()
            Dev7.RegEvent(1, 32767)
        Else
            Dev7Stat.Text = "Disconnected"
            Dev7Stat.ForeColor = Color.Red
        End If
    End Sub

    Private Sub BGWrd8_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGWrd8.DoWork
        If PingMe(My.Settings.T4Dev2) = True Then
            Dev8Stat.Text = "Connected"
            Dev8Stat.ForeColor = Color.Blue
            Dev8.BeginInit()
            Dev8.RegEvent(1, 32767)
        Else
            Dev8Stat.Text = "Disconnected"
            Dev8Stat.ForeColor = Color.Red
        End If
    End Sub
End Class