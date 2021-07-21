Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports ADODB
Public Class MainForm
    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Integer)
    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ViewConn()
        If conServer() = True Then
            txtDbStat.Text = "Connected"
            txtDbStat.ForeColor = Color.Blue

            viewCtrl()
            If ctrlCon() = True Then
                txtCtrlStat.Visible = False
                txtRuning.Visible = True
            Else
                txtCtrlStat.Text = "Disconnected"
                txtCtrlStat.ForeColor = Color.Red
            End If

            viewReaderSet()
            Dev1DisConnect()
            If Dev1Conn(frmDevConn.txtDev1IP.Text) = True Then
                txtDev1Stat.Text = "Connected"
                txtDev1Stat.ForeColor = Color.Blue
            Else
                txtDev1Stat.Text = "Disconnected"
                txtDev1Stat.ForeColor = Color.Red
            End If

            Dev2DisConnect()
            If Dev2Conn(frmDevConn.txtDev2IP.Text) = True Then
                txtDev2Stat.Text = "Connected"
                txtDev2Stat.ForeColor = Color.Blue
            Else
                txtDev2Stat.Text = "Disconnected"
                txtDev2Stat.ForeColor = Color.Red
            End If

            tmrClearStud.Interval = frmDevConn.txtDelay.Text
            tmrClearFetch.Interval = frmDevConn.txtDelay.Text
        Else
            txtDbStat.Text = "Disconnected"
            txtDbStat.ForeColor = Color.Red
            frmConDB.ShowDialog()
        End If

        Lstlist.Clear()
        header()

    End Sub

    Private Sub tmrTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTime.Tick
        txtDate.Text = Format(Now, "Long Date")
        txtTime.Text = Format(Now, "HH:mm:ss tt")
    End Sub

    Private Sub MainForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            frmLogin.ShowDialog()
        End If
    End Sub

    Public Sub header()
        Dim i As Integer = Lstlist.Width / 3
        Dim a As Integer = Lstlist.Width - i
        Lstlist.Columns.Add("Item Name", 185, HorizontalAlignment.Left)
        Lstlist.Columns.Add("Category", 100, HorizontalAlignment.Left)
        Lstlist.Columns.Add("Status", 120, HorizontalAlignment.Left)
        Lstlist.Columns.Add("", 0, HorizontalAlignment.Left)
    End Sub

    Function VerifyStud(ByVal AcNo As String) As Boolean
        If conServer() = False Then Return False

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSql.Execute("select * from tblstudinfo where ACnumber = '" & AcNo & "'")
            If rs.EOF = False Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function VerifyFetch(ByVal AcNo As String) As Boolean
        If conServer() = False Then Return False

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSql.Execute("select * from tblfetcher where ACnumber = '" & AcNo & "'")
            If rs.EOF = False Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Sub ShowStudInfo(ByVal id As String, ByVal evnt As String)
        If conServer() = False Then Exit Sub

        Try
            Dim rs = New Recordset

            rs = New Recordset
            rs = conSql.Execute("select * from tblStudInfo where AcNumber = '" & id & "'")
            If rs.EOF = False Then
                txtIDno.Text = rs("IdNumber").Value
                txtName.Text = rs("Name").Value
                txtGy.Text = rs("GradeYear").Value
                txtOras.Text = evnt & Format(Now, "yyyy-MM-dd HH:mm:ss tt")
                imgStud.Image = StudentPic(txtIDno.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Student information")
        End Try
    End Sub

    Function verFetcher(ByVal id As String) As Boolean
        If conServer() = False Then Return False
        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSql.Execute("select * from tblfetcherin where IDnumber = '" & id & "'")
            If rs.EOF = False Then
                Return True
            Else
                Return False
            End If
        Catch
            Return False
        End Try
    End Function

    Sub ShowFetchInfoByStud(ByVal id As String)
        If conServer() = False Then Exit Sub

        Try
            Dim rs = New Recordset
            Dim lup As Integer = 1

            rs = New Recordset
            rs = conSql.Execute("select * from tblFetcher where IDnumber = '" & id & "'")
            If rs.EOF = False Then
                F_AccNo = vbNullString
                F_StudID = vbNullString
                F_AccNo = id
                F_StudID = rs("IDnumber").Value
                For lup = 1 To rs.RecordCount
                    Sleep(10)
                    If lup = 1 Then
                        txtF1.Text = rs("FetcherName").Value
                        txtP1.Text = rs("Position").Value
                        imgF1.Image = FetcherPic(rs("ID").Value.ToString)
                        Sleep(10)
                    ElseIf lup = 2 Then
                        txtF2.Text = rs("FetcherName").Value
                        txtP2.Text = rs("Position").Value
                        imgF2.Image = FetcherPic(rs("ID").Value.ToString)
                        Sleep(10)
                    ElseIf lup = 3 Then
                        txtF3.Text = rs("FetcherName").Value
                        txtP3.Text = rs("Position").Value
                        imgF3.Image = FetcherPic(rs("ID").Value.ToString)
                        Sleep(10)
                    ElseIf lup = 4 Then
                        txtF4.Text = rs("FetcherName").Value
                        txtP4.Text = rs("Position").Value
                        imgF4.Image = FetcherPic(rs("ID").Value.ToString)
                        Sleep(10)
                    ElseIf lup = 5 Then
                        F_StudID = rs("IDnumber").Value
                        txtF5.Text = rs("FetcherName").Value
                        txtP5.Text = rs("Position").Value
                        imgF5.Image = FetcherPic(rs("ID").Value.ToString)
                        Sleep(10)
                    ElseIf lup = 6 Then
                        txtF6.Text = rs("FetcherName").Value
                        txtP6.Text = rs("Position").Value
                        imgF6.Image = FetcherPic(rs("ID").Value.ToString)
                        Sleep(10)
                    End If
                    rs.MoveNext()
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Fetcher information")
        End Try
    End Sub

    Sub ShowFetchInfo(ByVal id As String)
        If conServer() = False Then Exit Sub

        Try
            Dim rs = New Recordset
            Dim lup As Integer = 1

            rs = New Recordset
            rs = conSql.Execute("select * from tblFetcher where AcNumber = '" & id & "'")
            If rs.EOF = False Then
                F_AccNo = vbNullString
                F_StudID = vbNullString
                F_AccNo = id
                F_StudID = rs("IDnumber").Value
                For lup = 1 To rs.RecordCount
                    Sleep(10)
                    If lup = 1 Then
                        txtF1.Text = rs("FetcherName").Value
                        txtP1.Text = rs("Position").Value
                        imgF1.Image = FetcherPic(rs("ID").Value.ToString)
                        Sleep(10)
                    ElseIf lup = 2 Then
                        txtF2.Text = rs("FetcherName").Value
                        txtP2.Text = rs("Position").Value
                        imgF2.Image = FetcherPic(rs("ID").Value.ToString)
                        Sleep(10)
                    ElseIf lup = 3 Then
                        txtF3.Text = rs("FetcherName").Value
                        txtP3.Text = rs("Position").Value
                        imgF3.Image = FetcherPic(rs("ID").Value.ToString)
                        Sleep(10)
                    ElseIf lup = 4 Then
                        txtF4.Text = rs("FetcherName").Value
                        txtP4.Text = rs("Position").Value
                        imgF4.Image = FetcherPic(rs("ID").Value.ToString)
                        Sleep(10)
                    ElseIf lup = 5 Then
                        F_StudID = rs("IDnumber").Value
                        txtF5.Text = rs("FetcherName").Value
                        txtP5.Text = rs("Position").Value
                        imgF5.Image = FetcherPic(rs("ID").Value.ToString)
                        Sleep(10)
                    ElseIf lup = 6 Then
                        txtF6.Text = rs("FetcherName").Value
                        txtP6.Text = rs("Position").Value
                        imgF6.Image = FetcherPic(rs("ID").Value.ToString)
                        Sleep(10)
                    End If
                    rs.MoveNext()
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Fetcher information")
        End Try
    End Sub

    Sub clearStud()
        txtIDno.Text = "____________________"
        txtName.Text = "____________________"
        txtGy.Text = "____________________"
        txtOras.Text = "____________________"
        imgStud.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")

        Lstlist.Clear()
        header()
        txtCode.Text = vbNullString
        txtStat.Text = "---"
        txtStat.ForeColor = Color.Blue

        tmrRead.Enabled = False
        txtRuning.Enabled = False
    End Sub

    Sub Norec()
        txtIDno.Text = "Unknown"
        txtName.Text = "Unknown"
        txtGy.Text = "Unknown"
        txtOras.Text = "Unknown"
        imgStud.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")

        clearFetcher()

        Lstlist.Clear()
        header()
    End Sub

    Sub clearFetcher()
        txtF1.Text = "___________________"
        txtP1.Text = "__________________"
        imgF1.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")

        txtF2.Text = "___________________"
        txtP2.Text = "__________________"
        imgF2.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")

        txtF3.Text = "___________________"
        txtP3.Text = "__________________"
        imgF3.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")

        txtF4.Text = "___________________"
        txtP4.Text = "__________________"
        imgF4.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")

        txtF5.Text = "___________________"
        txtP5.Text = "__________________"
        imgF5.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")

        txtF6.Text = "___________________"
        txtP6.Text = "__________________"
        imgF6.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
    End Sub

    Function remIn(ByVal realTmr As String) As String
        On Error Resume Next

        realTmr = Format(CDate(realTmr), "HH:mm:ss")
        Dim CHLin As String = Format(CDate(My.Settings.LR_CHLin), "HH:mm:ss")
        Dim CHLout As String = Format(CDate(My.Settings.LR_CHLout), "HH:mm:ss")

        If realTmr >= CHLin And realTmr < CHLout Then
            Return "LATE"
        Else
            Return "ON TIME"
        End If

    End Function

    Function verAttrul() As Boolean
        If My.Settings.LR_CHLin = vbNullString And My.Settings.LR_CHLout = vbNullString Then
            Return True
        Else
            Return False
        End If
    End Function

    Function CheckIn(ByVal id As String) As Boolean
        Dim rs = New Recordset
        rs = New Recordset
        rs = conSql.Execute("select * from tbltimein where IDnumber = '" & id & "'")
        If rs.EOF = False Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub SaveIn()
        If conServer() = False Then Exit Sub
        Try
            Dim rs = New Recordset
            rs = New Recordset
            rs.Open("select * from tbltimein", conSql, 1, 2)
            rs.AddNew()
            rs("IDnumber").Value = txtIDno.Text
            rs("TimeIn").Value = Replace(txtOras.Text, "IN: ", vbNullString)
            rs("Status").Value = remIn(Now)
            rs.Update()
            If remIn(Now) = "ON TIME" Then
                txtStat.ForeColor = Color.Navy
            Else
                txtStat.ForeColor = Color.Red
            End If
            txtStat.Text = remIn(Now)
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Time In")
        End Try
    End Sub

    Sub saveFetchIn()
        If conServer() = False Then Exit Sub
        Try
            Dim rs = New Recordset
            rs = New Recordset
            rs.Open("select * from tblfetcherin", conSql, 1, 2)
            rs.AddNew()
            rs("AccNo").Value = F_AccNo
            rs("IDnumber").Value = F_StudID
            rs("TimeIn").Value = Now
            rs.Update()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Time In")
        End Try
    End Sub

    Private Sub Dev1_OnAttTransaction(ByVal sender As System.Object, ByVal e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent) Handles Dev1.OnAttTransaction

        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If

        If verAttrul() = True Then
            MsgBox("Please set late rules!    ", vbExclamation, "Late rules")
            frmAttRule.ShowDialog()
            Exit Sub
        End If

        If VerifyStud(e.enrollNumber) = True Then
            Lstlist.Clear()
            header()
            tmrClearStud.Enabled = False
            ShowStudInfo(e.enrollNumber, "IN: ")
            If My.Settings.PSb_Set = "OnPSB" Then
                If CheckIn(txtIDno.Text) = True Then
                    txtStat.Text = "ALREADY LOGIN"
                    tmrClearStud.Enabled = True
                    Exit Sub
                End If
                itmFlag = vbNullString
                itmFlag = "ENT"
                tmrRead.Enabled = True
                SaveIn()
                tmrClearStud.Enabled = True
            Else
                itmFlag = vbNullString
                itmFlag = "ENT"
                tmrRead.Enabled = True
                SaveIn()
                tmrClearStud.Enabled = True
            End If
        Else
            If VerifyFetch(e.enrollNumber) = True Then
                tmrClearFetch.Enabled = False
                Sleep(10)
                ShowFetchInfo(e.enrollNumber)
                saveFetchIn()
                tmrClearFetch.Enabled = True
            Else
                Norec()
                tmrClearStud.Enabled = True
            End If
        End If
    End Sub

    Private Sub tmrClearStud_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrClearStud.Tick
        clearStud()
        entry_auto_gate(Addr)
        tmrClearStud.Enabled = False
    End Sub

    Private Sub tmrClearFetch_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrClearFetch.Tick
        clearFetcher()
        entry_auto_gate(Addr)
        tmrClearFetch.Enabled = False
    End Sub

    Sub inOutSave(ByVal idno As String)
        Try
            Dim rs = New Recordset

            rs = New Recordset
            rs = conSql.Execute("select * from tbltimein where IDnumber = '" & idno & "'")
            If rs.EOF = False Then
                Dim rs2 As New Recordset
                rs2 = New Recordset
                rs2.Open("select * from tblinout", conSql, 1, 2)
                rs2.AddNew()
                rs2("IDnumber").Value = txtIDno.Text
                rs2("TimeIn").Value = rs("TimeIn").Value
                rs2("TimeOut").Value = Replace(txtOras.Text, "OUT: ", vbNullString)
                rs2("Status").Value = rs("Status").Value
                rs2.Update()
            End If
            txtStat.Text = "ID number: " & txtIDno.Text & " Logout.."
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Time Out")
        End Try
    End Sub

    Sub saveInOutFetch(ByVal idno As String)
        Try
            Dim rs = New Recordset

            rs = New Recordset
            rs = conSql.Execute("select * from tblfetcherin where IDnumber = '" & idno & "'")
            If rs.EOF = False Then
                Dim rs2 As New Recordset
                rs2 = New Recordset
                rs2.Open("select * from tblfetcherout", conSql, 1, 2)
                rs2.AddNew()
                rs2("AccNo").Value = rs("AccNo").Value
                rs2("IDnumber").Value = txtIDno.Text
                rs2("TimeIn").Value = rs("TimeIn").Value
                rs2("TimeOut").Value = Replace(txtOras.Text, "OUT: ", vbNullString)
                rs2.Update()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Time Out")
        End Try
    End Sub

    Sub delInLog(ByVal id As String)
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSql.Execute("Delete from tbltimeIn where IDnumber = '" & id & "'")
    End Sub

    Sub delInLogFetch(ByVal id As String)
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSql.Execute("Delete from tblfetcherIn where IDnumber = '" & id & "'")
    End Sub

    Private Sub Dev2_OnAttTransaction(ByVal sender As System.Object, ByVal e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent) Handles Dev2.OnAttTransaction
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If

        If VerifyStud(e.enrollNumber) = True Then
            Lstlist.Clear()
            header()
            itmFlag = vbNullString
            itmFlag = "EXT"
            tmrRead.Enabled = True
            tmrClearStud.Enabled = False
            ShowStudInfo(e.enrollNumber, "OUT: ")
            inOutSave(txtIDno.Text)
            If verFetcher(txtIDno.Text) = False Then
                delInLog(txtIDno.Text)
                tmrClearStud.Enabled = True
                Exit Sub
            End If
            tmrClearFetch.Enabled = False
            Sleep(10)
            ShowFetchInfoByStud(txtIDno.Text)
            saveInOutFetch(txtIDno.Text)
            delInLog(txtIDno.Text)
            delInLogFetch(txtIDno.Text)
            tmrClearStud.Enabled = True
            tmrClearFetch.Enabled = True
        Else
            If VerifyFetch(e.enrollNumber) = True Then
                tmrClearFetch.Enabled = False
                Sleep(10)
                ShowFetchInfo(e.enrollNumber)
                saveFetchIn()
                tmrClearFetch.Enabled = True
            Else
                Norec()
                tmrClearStud.Enabled = True
            End If
        End If
    End Sub

    Sub fillitem(ByVal iname As String, ByVal categ As String, ByVal stat As String, ByVal code As String)
        Lstlist.Refresh()
        Dim viewlst As New ListViewItem
        viewlst = Lstlist.Items.Add(iname)
        viewlst.SubItems.Add(categ)
        If stat = "WRONG ACCOUNTABILITY" Then
            viewlst.ForeColor = Color.Red
        Else
            viewlst.ForeColor = Color.Blue
        End If
        viewlst.SubItems.Add(stat)
        viewlst.SubItems.Add(code)
        Lstlist.Focus()
    End Sub

    Function CheckItemIn(ByVal code As String) As Boolean
        If conServer() = False Then Return False

        Try
            Dim rs As New Recordset
            rs = conSql.Execute("select * from tblitemin where Cardcode = '" & code & "'")
            If rs.EOF = False Then
                Return True
            Else
                Return False
            End If
        Catch
            Return False
        End Try
    End Function

    Sub saveItemIn(ByVal code As String, ByVal idNo As String, ByVal stat As String)
        If conServer() = False Then Exit Sub
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from tblitemin", conSql, 1, 2)
            rs.AddNew()
            rs("CardCode").Value = code
            rs("IDnumber").Value = idNo
            rs("TimeIn").Value = Now
            rs("Status").Value = stat
            rs.Update()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Item")
        End Try

    End Sub

    Sub saveItemInOut(ByVal code As String, ByVal idNo As String, ByVal stat As String)
        If conServer() = False Then Exit Sub

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSql.Execute("select * from tblitemin where CardCode = '" & code & "'")
            If rs.EOF = False Then
                Dim rs2 As New Recordset
                rs2 = New Recordset
                rs2.Open("select * from tbliteminout", conSql, 1, 2)
                rs2.AddNew()
                rs2("CardCode").Value = code
                rs2("IDnumber").Value = idNo
                rs2("TimeIn").Value = rs("TimeIn").Value
                rs2("TimeOut").Value = Now
                rs2("Status").Value = stat
                rs2.Update()
            End If
        
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Item")
        End Try

    End Sub

    Function CheckItemInOut(ByVal code As String) As Boolean
        If conServer() = False Then Return False

        Try
            Dim rs As New Recordset
            rs = conSql.Execute("select * from tbliteminout where Cardcode = '" & code & "' order by TimeOut desc")
            If rs.EOF = False Then
                Dim dt As String = Format(CDate(rs("TimeOut").Value), "yyyy-MM-dd")
                Dim dtnow As String = Format(Now, "yyyy-MM-dd")
                If dt = dtnow Then
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

    Function CheckItemOut(ByVal code As String) As Boolean
        If conServer() = False Then Return False

        Try
            Dim rs As New Recordset
            rs = conSql.Execute("select * from tblitemout where Cardcode = '" & code & "' order by TimeOut desc")
            If rs.EOF = False Then
                Dim dt As String = Format(CDate(rs("TimeOut").Value), "yyyy-MM-dd")
                Dim dtnow As String = Format(Now, "yyyy-MM-dd")
                If dt = dtnow Then
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

    Sub saveItemOut(ByVal code As String, ByVal studIDno As String, ByVal stat As String)

        If conServer() = False Then Exit Sub
        Try
            Dim rs2 As New Recordset
            rs2 = New Recordset
            rs2.Open("select * from tblitemout", conSql, 1, 2)
            rs2.AddNew()
            rs2("CardCode").Value = code
            rs2("IDnumber").Value = studIDno
            rs2("TimeOut").Value = Now
            rs2("Status").Value = stat
            rs2.Update()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Item")
        End Try

    End Sub

    Sub delitemin(ByVal code As String)
        If conServer() = False Then Exit Sub
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSql.Execute("delete from tblitemin where CardCode = '" & code & "'")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Item")
        End Try
    End Sub

    Sub ShowItemIn(ByVal code As String)
        If conServer() = False Then
            Exit Sub
        End If

        Dim rs As New Recordset
        Dim stat As String

        rs = New Recordset
        rs = conSql.Execute("select * from tblitems where CardCode = '" & code & "'")
        If rs.EOF = False Then
            Dim itemName As String = rs("ItemName").Value
            Dim Categ As String = rs("Category").Value
            Dim idnumber As String = rs("IDnumber").Value
            If txtIDno.Text = rs("IDnumber").Value Then

                stat = vbNullString
                stat = "OK"
                Lstlist.Refresh()
                Dim viewlst As New ListViewItem
                fillitem(itemName, Categ, stat, code)
                saveItemIn(code, txtIDno.Text, stat)
                txtCode.Text = code
                txtStat.ForeColor = Color.Navy
                txtStat.Text = "CARD CODE: " & code & " " & stat
            Else
                tmrClearStud.Enabled = False
                stat = vbNullString
                stat = "WRONG ACCOUNTABILITY"
                Lstlist.Refresh()
                Dim viewlst As New ListViewItem
                fillitem(itemName, Categ, stat, code)

                saveItemIn(code, txtIDno.Text, stat)

                txtCode.Text = code
                txtStat.ForeColor = Color.Red
                txtStat.Text = "CARD CODE: " & code & " " & "IS" & " " & stat
            End If
        End If
    End Sub

    Sub ShowItemOut(ByVal code As String)
        If conServer() = False Then
            Exit Sub
        End If

        Dim rs As New Recordset
        Dim stat As String

        rs = New Recordset
        rs = conSql.Execute("select * from tblitems where CardCode = '" & code & "'")
        If rs.EOF = False Then
            Dim itemName As String = rs("ItemName").Value
            Dim Categ As String = rs("Category").Value
            Dim idnumber As String = rs("IDnumber").Value

            If txtIDno.Text = idnumber Then
                If CheckItemIn(code) = True Then

                    stat = vbNullString
                    stat = "OK"
                    Lstlist.Refresh()
                    Dim viewlst As New ListViewItem
                    fillitem(itemName, Categ, stat, code)

                    saveItemInOut(code, txtIDno.Text, stat)
                    delitemin(code)

                    txtCode.Text = code
                    txtStat.ForeColor = Color.Navy
                    txtStat.Text = "CARD CODE: " & code & " " & stat
                Else

                    stat = vbNullString
                    stat = "ITEM DID NOT IN"
                    Lstlist.Refresh()
                    fillitem(itemName, Categ, stat, code)
                    saveItemOut(code, txtIDno.Text, stat)
                    txtCode.Text = code
                    txtStat.ForeColor = Color.Navy
                    txtStat.Text = "CARD CODE: " & code & " " & stat
                    Exit Sub
                End If
            Else
                tmrClearStud.Enabled = False
                If CheckItemIn(code) = False Then

                    stat = vbNullString
                    stat = "WRONG ACCOUNTABILITY"
                    Lstlist.Refresh()
                    Dim viewlst As New ListViewItem
                    fillitem(itemName, Categ, stat, code)

                    saveItemInOut(code, txtIDno.Text, stat)
                    delitemin(code)

                    txtCode.Text = code
                    txtStat.ForeColor = Color.Red
                    txtStat.Text = "CARD CODE: " & code & " " & "IS" & " " & stat
                Else
                    stat = vbNullString
                    stat = "WRONG ACCOUNTABILITY"

                    Lstlist.Refresh()
                    Dim viewlst As New ListViewItem
                    fillitem(itemName, Categ, stat, code)
                    saveItemOut(code, txtIDno.Text, stat)

                    txtCode.Text = code
                    txtStat.ForeColor = Color.Red
                    txtStat.Text = "CARD CODE: " & code & " " & "IS" & " " & stat
                End If
            End If
        End If
    End Sub

    Sub readIn()
        Dim ret As Integer
        Dim card As String
        Dim mCard As String
        Dim direct(1) As Byte
        Dim CardCode As String = vbNullString
        mCard = "00000000000"

        ret = query_statusB(Addr, mCard, direct(0)) 'query(Addr);

        If ret = 3 Then
            txtRuning.Enabled = False
            Exit Sub
        End If

        txtRuning.Enabled = True
        If ret = 1 Then 'read card
            card = VB.Left(mCard, InStr(mCard, Chr(0)) - 1)
            direct(0) = direct(0) And &H3F
            CardCode = cardCod(card)
            ShowItemIn(CardCode)
        End If
    End Sub

    Sub readOut()
        Dim ret As Integer
        Dim card As String
        Dim mCard As String
        Dim direct(1) As Byte
        Dim CardCode As String = vbNullString
        mCard = "00000000000"

        ret = query_statusB(Addr, mCard, direct(0)) 'query(Addr);

        If ret = 3 Then
            txtRuning.Enabled = False
            Exit Sub
        End If

        txtRuning.Enabled = True
        If ret = 1 Then 'read card
            card = VB.Left(mCard, InStr(mCard, Chr(0)) - 1)
            direct(0) = direct(0) And &H3F
            CardCode = cardCod(card)
            ShowItemOut(CardCode)
        End If
    End Sub

    Private Sub tmrRead_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRead.Tick
        If itmFlag = "ENT" Then
            readIn()
        Else
            readOut()
        End If
    End Sub

    Private Sub Lstlist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lstlist.SelectedIndexChanged
        Dim viewlst As New ListViewItem
        For Each viewlst In Lstlist.Items
            If viewlst.Selected = True Then
                txtCode.Text = viewlst.SubItems(3).Text
            End If
        Next
    End Sub
End Class