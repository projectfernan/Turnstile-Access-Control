Imports ADODB
Public Class frmLogs
    Public id As String
    Public categ As String
    Public rsPRS As New Recordset
    Public rsIn As New Recordset
    Public rsIO As Recordset
    Public rsInOut As Recordset
    Public rsNem As Recordset
    Private Sub cboDept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub EntHead()
        LstEmpRec.Columns.Clear()
        LstEmpRec.Columns.Add("IdLog", 100, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("IdNumber", 100, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Name", 350, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Section", 170, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("TimeIn", 170, HorizontalAlignment.Left)
    End Sub

    Sub AttHead()
        LstEmpRec.Columns.Clear()
        LstEmpRec.Columns.Add("IdLog", 90, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("IdNumber", 90, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Name", 200, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Section", 170, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("TimeIn", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("TimeOut", 180, HorizontalAlignment.Left)
    End Sub

    Private Sub frmLogs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LstEmpRec.Clear()
        EntHead()
        EmpPic.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
        unable()
        cboCateg.Text = vbNullString
    End Sub

    Sub sec()
        Try
            Dim rs As New ADODB.Recordset
            Dim rs2 As New ADODB.Recordset

            rs = New Recordset
            rs = conSql.Execute("select Section from tblInOut")

            Do While rs.EOF = False
                rs2 = New Recordset
                rs2.Open("select * from tblcbosec", conSql, 1, 2)
                rs2.AddNew()
                rs2("Sec").Value = rs("Section")
                rs2.Save()
                rs.MoveNext()
            Loop
        Catch ex As Exception
            frmSystemMain.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub tocbo()
        Try
            Dim rs3 As New ADODB.Recordset
            rs3 = New Recordset
            rs3 = conSql.Execute("select * from tblcboSec")
            Do While rs3.EOF = False
                ' cboSec.Items.Add(rs3("Sec").Value)
                rs3.MoveNext()
            Loop
        Catch ex As Exception
            frmSystemMain.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub slct()
        Dim viewlst As New ListViewItem
        Idno = vbNullString
        For Each viewlst In LstEmpRec.Items
            If viewlst.Selected = True Then
                Idno = viewlst.SubItems(1).Text
            End If
        Next
    End Sub

    Sub slctAc()
        Try
            Dim rs As New Recordset
            id = vbNullString
            rs = conSql.Execute("select * from tblStudInfo where IDnumber = '" & Idno & "'")
            If rs.EOF = False Then
                id = rs("Acnumber").Value
            End If
        Catch ex As Exception
            frmSystemMain.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub able()
        cmdEdit.Enabled = True
        cmdDel.Enabled = True
        cmdPrint.Enabled = True
        'Button1.Enabled = True
    End Sub
    Sub unable()
        cmdEdit.Enabled = False
        cmdDel.Enabled = False
        cmdPrint.Enabled = False
        Button1.Enabled = False

        'dtDateFrm.Enabled = False
        'dtDateTo.Enabled = False
        'dtTmeFrm.Enabled = False
        'dtTmeTo.Enabled = False
        'txtInput.Enabled = False
        txtKeyword.Enabled = False

        cboDeptCateg.Enabled = False
        cboCategory.Enabled = False
        'cboRem.Enabled = False
        cboSec.Enabled = False
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Sub Entall()
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Try
            Dim lup As Short
            rsPRS = New Recordset
            rsPRS = conSql.Execute("select * from tblTImein")
            If rsPRS.EOF = False Then
                For lup = 1 To rsPRS.RecordCount
                    LstEmpRec.Refresh()
                    Dim viewlst As New ListViewItem
                    viewlst = LstEmpRec.Items.Add(rsPRS("IDLog").Value, lup)
                    viewlst.SubItems.Add(rsPRS("IDnumber").Value)
                    viewlst.SubItems.Add(rsPRS("Name").Value)
                    viewlst.SubItems.Add(rsPRS("Section").Value)
                    viewlst.SubItems.Add(rsPRS("TimeIn").Value)
                    rsPRS.MoveNext()
                Next
            End If
        Catch ex As Exception
            frmSystemMain.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub EntSrch()
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Try
            Dim lup As Short
            Dim TmeInTo As String
            Dim TmeInFrm As String

            TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
            TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")

            rsPRS = New Recordset
            rsPRS = conSql.Execute("select * from vweTimein where GradeYear like '" & cboCategory.Text & "%' and Section like '" & cboSec.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
            If rsPRS.EOF = False Then
                For lup = 1 To rsPRS.RecordCount
                    LstEmpRec.Refresh()
                    Dim viewlst As New ListViewItem
                    viewlst = LstEmpRec.Items.Add(rsPRS("IDLog").Value, lup)
                    viewlst.SubItems.Add(rsPRS("IDnumber").Value)
                    viewlst.SubItems.Add(rsPRS("Name").Value)
                    viewlst.SubItems.Add(rsPRS("Section").Value)
                    viewlst.SubItems.Add(rsPRS("TimeIn").Value)
                    rsPRS.MoveNext()
                Next
            End If
        Catch ex As Exception
            frmSystemMain.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub EntIndi()

        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Try
            Dim lup As Short
            Dim TmeInTo As String
            Dim TmeInFrm As String

            TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
            TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")

            rsIn = New Recordset
            rsIn = conSql.Execute("select * from vweTimein where " & cboCategory.Text & " like '" & txtKeyword.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
            If rsIn.EOF = False Then
                For lup = 1 To rsIn.RecordCount
                    LstEmpRec.Refresh()
                    Dim viewlst As New ListViewItem
                    viewlst = LstEmpRec.Items.Add(rsIn("IDLog").Value, lup)
                    viewlst.SubItems.Add(rsIn("IDnumber").Value)
                    viewlst.SubItems.Add(rsIn("Name").Value)
                    viewlst.SubItems.Add(rsIn("Section").Value)
                    viewlst.SubItems.Add(rsIn("TimeIn").Value)
                    rsIn.MoveNext()
                Next
            End If
        Catch ex As Exception
            frmSystemMain.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub InOutSrch()
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Try
            Dim lup As Short
            Dim TmeInTo As String
            Dim TmeInFrm As String

            TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
            TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")

            rsIO = New Recordset
            rsIO = conSql.Execute("select * from vweInOut where GradeYear like '" & cboCategory.Text & "%' and Section like '" & cboSec.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <= '" & TmeInTo & "'")
            If rsIO.EOF = False Then
                For lup = 1 To rsIO.RecordCount
                    LstEmpRec.Refresh()
                    Dim viewlst As New ListViewItem
                    viewlst = LstEmpRec.Items.Add(rsIO("IDLog").Value, lup)
                    viewlst.SubItems.Add(rsIO("IDnumber").Value)
                    viewlst.SubItems.Add(rsIO("Name").Value)
                    viewlst.SubItems.Add(rsIO("Section").Value)
                    viewlst.SubItems.Add(rsIO("TimeIn").Value)
                    viewlst.SubItems.Add(rsIO("TimeOut").Value)
                    rsIO.MoveNext()
                Next
            End If
        Catch ex As Exception
            frmSystemMain.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub IndiInOut()
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Try
            Dim lup As Short
            Dim TmeInTo As String
            Dim TmeInFrm As String

            TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
            TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")

            rsInOut = New Recordset
            rsInOut = conSql.Execute("select * from vweInOut where " & cboCategory.Text & " like '" & txtKeyword.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <= '" & TmeInTo & "'")
            If rsInOut.EOF = False Then
                For lup = 1 To rsInOut.RecordCount
                    LstEmpRec.Refresh()
                    Dim viewlst As New ListViewItem
                    viewlst = LstEmpRec.Items.Add(rsInOut("IDLog").Value, lup)
                    viewlst.SubItems.Add(rsInOut("IDnumber").Value)
                    viewlst.SubItems.Add(rsInOut("Name").Value)
                    viewlst.SubItems.Add(rsInOut("Section").Value)
                    viewlst.SubItems.Add(rsInOut("TimeIn").Value)
                    viewlst.SubItems.Add(rsInOut("TimeOut").Value)
                    rsInOut.MoveNext()
                Next
            End If
        Catch ex As Exception
            frmSystemMain.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub InOutAll()
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Try
            Dim lup As Short
            rsIO = New Recordset
            rsIO = conSql.Execute("select * from vweinOut")
            If rsIO.EOF = False Then
                For lup = 1 To rsIO.RecordCount
                    LstEmpRec.Refresh()
                    Dim viewlst As New ListViewItem
                    viewlst = LstEmpRec.Items.Add(rsIO("IDLog").Value, lup)
                    viewlst.SubItems.Add(rsIO("IDnumber").Value)
                    viewlst.SubItems.Add(rsIO("Name").Value)
                    viewlst.SubItems.Add(rsIO("Section").Value)
                    viewlst.SubItems.Add(rsIO("TimeIn").Value)
                    viewlst.SubItems.Add(rsIO("TimeOut").Value)
                    rsIO.MoveNext()
                Next
            End If
        Catch ex As Exception
            frmSystemMain.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub picEntView()
        If frmMain.StatDB.Text = "Disconnected" Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Try
            EmpPic.Image = Get_ImageIn(id)
        Catch
            EmpPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
        End Try
    End Sub

    Sub picInOutView()
        If frmMain.StatDB.Text = "Disconnected" Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSql.Execute("select PicEnt,PicExt from tblInOut where inOutId = '" & id & "'")
            If rs.EOF = False Then
                EmpPic.Image = Get_PicEnt(id)
                'ExtPic.Image = Get_PicExt(id)
            End If
        Catch
            EmpPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            'ExtPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
        End Try
    End Sub

    Sub PresDel()
        Try
            If MsgBox("Are you sure do you want to delete this logs?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Delete") = vbYes Then
                If categ = "All" Then
                    Dim rs As New Recordset
                    rs = New Recordset
                    rs = conSql.Execute("Delete from tblTImein")
                ElseIf categ = "Search" Then
                    Dim TmeInTo As String
                    Dim TmeInFrm As String
                    TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
                    TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")
                    Dim rs2 As New Recordset
                    rs2 = New Recordset
                    rs2 = conSql.Execute("delete from tblTImein where GradeYr like '" & cboCategory.Text & "%' and Section like '" & cboSec.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
                End If
            End If
        Catch ex As Exception
            frmSystemMain.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub IndiPresDel()
        Try
            If MsgBox("Are you sure do you want to delete this logs?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Delete") = vbYes Then
                If categ = "All" Then
                    Dim rs As New Recordset
                    rs = New Recordset
                    rs = conSql.Execute("Delete from tblTImein")
                ElseIf categ = "Search" Then
                    Dim TmeInTo As String
                    Dim TmeInFrm As String
                    TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
                    TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")
                    Dim rs2 As New Recordset
                    rs2 = New Recordset
                    rs2 = conSql.Execute("delete from tblTImein where " & cboCategory.Text & " like '" & txtKeyword.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
                End If
            End If
        Catch ex As Exception
            frmSystemMain.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub AttDel()
        Try
            If MsgBox("Are you sure do you want to delete this logs?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Delete") = vbYes Then
                If categ = "All" Then
                    Dim rs As New Recordset
                    rs = New Recordset
                    rs = conSql.Execute("delete from tblinOut")
                ElseIf categ = "Search" Then
                    Dim TmeInTo As String
                    Dim TmeInFrm As String

                    TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
                    TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")

                    Dim rs2 As New Recordset
                    rs2 = New Recordset
                    rs2 = conSql.Execute("delete from tblInOut where GradeYr like '" & cboCategory.Text & "%' and Section like '" & cboSec.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <= '" & TmeInTo & "'")
                End If
            End If
        Catch ex As Exception
            frmSystemMain.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub IndiAttDel()
        Try
            If MsgBox("Are you sure do you want to delete this logs?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Delete") = vbYes Then
                If categ = "All" Then
                    Dim rs As New Recordset
                    rs = New Recordset
                    rs = conSql.Execute("delete from tblinOut")
                ElseIf categ = "Search" Then
                    Dim TmeInTo As String
                    Dim TmeInFrm As String

                    TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
                    TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")

                    Dim rs2 As New Recordset
                    rs2 = New Recordset
                    rs2 = conSql.Execute("delete from tblInOut where " & cboCategory.Text & " like '" & txtKeyword.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <= '" & TmeInTo & "'")
                End If
            End If
        Catch ex As Exception
            frmSystemMain.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub Prstprint()
        Try
            Dim ReportPath As String = Application.StartupPath & "\Report\Crtreport.rpt"
            If Not IO.File.Exists(ReportPath) Then
                MsgBox("Cannot load Report file", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Report.Load(ReportPath)
            Report.SetDataSource(rsPRS)
            frmReportLogs.CRViewer.ReportSource = Report
            frmReportLogs.ShowDialog()
        Catch ex As Exception
            frmSystemMain.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub InIndiPrnt()
        Try
            Dim ReportPath As String = Application.StartupPath & "\Report\Crtreport.rpt"
            If Not IO.File.Exists(ReportPath) Then
                MsgBox("Cannot load Report file", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Report.Load(ReportPath)
            Report.SetDataSource(rsIn)
            frmReportLogs.CRViewer.ReportSource = Report
            frmReportLogs.ShowDialog()
        Catch ex As Exception
            frmSystemMain.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub AttRecPrint()
        Try
            Dim ReportPath As String = Application.StartupPath & "\Report\CrtAttreport.rpt"
            If Not IO.File.Exists(ReportPath) Then
                MsgBox("Cannot load Report file!    ", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Report.Load(ReportPath)
            Report.SetDataSource(rsIO)
            frmReportLogs.CRViewer.ReportSource = Report
            frmReportLogs.ShowDialog()
            'Else
            ' MsgBox("No Record Found", MsgBoxStyle.Exclamation)
            'End If
        Catch ex As Exception
            frmSystemMain.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub IndiAttPrint()
        Try
            Dim ReportPath As String = Application.StartupPath & "\Report\CrtAttreport.rpt"
            If Not IO.File.Exists(ReportPath) Then
                MsgBox("Cannot load Report file!    ", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Report.Load(ReportPath)
            Report.SetDataSource(rsInOut)
            frmReportLogs.CRViewer.ReportSource = Report
            frmReportLogs.ShowDialog()
            'Else
            ' MsgBox("No Record Found", MsgBoxStyle.Exclamation)
            'End If
        Catch ex As Exception
            frmSystemMain.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub nemPrs()
        'Dim rs As New Recordset
        rsPRS = New Recordset

        'rsPRS = conSql.Execute("select * from tbltimein where Name like '" & txtInput.Text & "%'")
        For lup = 1 To rsPRS.RecordCount
            LstEmpRec.Refresh()
            Dim viewlst As New ListViewItem
            viewlst = LstEmpRec.Items.Add(rsPRS("IDLog").Value, lup)
            viewlst.SubItems.Add(rsPRS("IDnumber").Value)
            viewlst.SubItems.Add(rsPRS("Name").Value)
            viewlst.SubItems.Add(rsPRS("TimeIn").Value)
            'viewlst.SubItems.Add(rs("Date").Value)
            'viewlst.SubItems.Add(rs("Remarks").Value)
            rsPRS.MoveNext()
        Next
    End Sub

    Sub nematt()
        'Dim rs As New Recordset
        rsIO = New Recordset
        'rsIO = conSql.Execute("select * from tblinout where Name like '" & txtInput.Text & "%'")
        If rsIO.EOF = False Then
            For lup = 1 To rsIO.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rsIO("InOutID").Value, lup)
                viewlst.SubItems.Add(rsIO("IDnumber").Value)
                viewlst.SubItems.Add(rsIO("Name").Value)
                viewlst.SubItems.Add(rsIO("TimeIn").Value)
                viewlst.SubItems.Add(rsIO("TimeOut").Value)
                rsIO.MoveNext()
            Next
        End If
    End Sub

    Private Sub cboCateg_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCateg.SelectedIndexChanged
        Select Case cboCateg.Text
            Case "Time In"
                LstEmpRec.Clear()
                EntHead()
                able()
                cmdDel.Enabled = False
                cmdPrint.Enabled = False
                EmpPic.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
                cboDeptCateg.Enabled = True
                EduLv()
            Case "Logs Report"
                LstEmpRec.Clear()
                AttHead()
                able()
                cmdDel.Enabled = False
                cmdPrint.Enabled = False
                EmpPic.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
                cboDeptCateg.Enabled = True
                EduLv()
        End Select
    End Sub

    Private Sub cmdEdit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Select Case cboCateg.Text
            Case "Time In"
                LstEmpRec.Clear()
                EntHead()
                Entall()
                If desig = "User" Then
                    cmdDel.Enabled = False
                Else
                    cmdDel.Enabled = True
                End If
                cmdPrint.Enabled = True

            Case "Logs Report"
                LstEmpRec.Clear()
                AttHead()
                InOutAll()
                If desig = "User" Then
                    cmdDel.Enabled = False
                Else
                    cmdDel.Enabled = True
                End If
                cmdPrint.Enabled = True
        End Select
        categ = "All"
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cboCategory.Text = vbNullString Then
            If cboDeptCateg.Text = "All" Then

            Else
                MsgBox("Please select search category!    ", vbExclamation, "Search")
                cboCategory.Focus()
                Exit Sub
            End If
        End If

        Select Case cboCateg.Text
            Case "Time In"
                LstEmpRec.Clear()
                EntHead()
                If cboDeptCateg.Text = "Individual" Then
                    EntIndi()
                    If desig = "User" Then
                        cmdDel.Enabled = False
                    Else
                        cmdDel.Enabled = True
                    End If
                    cmdPrint.Enabled = True
                    categ = "Search"
                    Exit Sub
                End If
                EntSrch()
                If desig = "User" Then
                    cmdDel.Enabled = False
                Else
                    cmdDel.Enabled = True
                End If
                cmdPrint.Enabled = True
            Case "Logs Report"
                LstEmpRec.Clear()
                AttHead()
                If cboDeptCateg.Text = "Individual" Then
                    IndiInOut()
                    If desig = "User" Then
                        cmdDel.Enabled = False
                    Else
                        cmdDel.Enabled = True
                    End If
                    cmdPrint.Enabled = True
                    categ = "Search"
                    Exit Sub
                End If
                InOutSrch()
                If desig = "User" Then
                    cmdDel.Enabled = False
                Else
                    cmdDel.Enabled = True
                End If
                cmdPrint.Enabled = True
        End Select
        categ = "Search"
    End Sub

    Private Sub cmdPrint_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click

        Select Case cboCateg.Text
            Case "Time In"

                If cboDeptCateg.Text = "Individual" Then
                    InIndiPrnt()
                    Exit Sub
                End If
                Prstprint()
            Case "Logs Report"

                If cboDeptCateg.Text = "Individual" Then
                    IndiAttPrint()
                    Exit Sub
                End If
                AttRecPrint()
        End Select
    End Sub

    Private Sub cmdDel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        Select Case cboCateg.Text
            Case "Time In"
                If cboDeptCateg.Text = "Individual" Then
                    IndiPresDel()
                    LstEmpRec.Clear()
                    EntHead()
                    Entall()
                    ' frmMain.filllist()
                    Exit Sub
                End If
                PresDel()
                LstEmpRec.Clear()
                EntHead()
                Entall()
                'frmMain.filllist()
            Case "Logs Report"
                If cboDeptCateg.Text = "Individual" Then
                    IndiAttDel()
                    LstEmpRec.Clear()
                    AttHead()
                    InOutAll()
                    Exit Sub
                End If
                AttDel()
                LstEmpRec.Clear()
                AttHead()
                InOutAll()
        End Select
    End Sub

    Private Sub LstEmpRec_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstEmpRec.SelectedIndexChanged
        Dim viewlst As New ListViewItem
        For Each viewlst In LstEmpRec.Items
            If viewlst.Selected = True Then
                EmpPic.Image = StudentPic(viewlst.SubItems(1).Text)
            End If
        Next
    End Sub
    Function viewStud() As Boolean
        Dim rs As Recordset
        rs = conSql.Execute("select * from tblStudInfo where AcNumber = '" & id & "'")
        If rs.EOF = True Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub SirchCateg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDeptCateg.SelectedIndexChanged
        cboCategory.Items.Clear()
        cboCategory.Enabled = True
        Button1.Enabled = True
        If cboDeptCateg.Text = "All" Then
            cboCategory.Enabled = False
            cboSec.Enabled = False
            txtKeyword.Enabled = False

            cboCategory.Text = vbNullString
            cboSec.Text = vbNullString
            txtKeyword.Text = vbNullString
        End If

     
    End Sub

    Sub disdt()
        dtDateFrm.Enabled = False
        dtDateTo.Enabled = False
        dtTmeFrm.Enabled = False
        dtTmeTo.Enabled = False
    End Sub
    Sub abledt()
        dtDateFrm.Enabled = True
        dtDateTo.Enabled = True
        dtTmeFrm.Enabled = True
        dtTmeTo.Enabled = True
        Button1.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sec()
        tocbo()
    End Sub

    Sub Gy(ByVal Edulv As String)
        If conServer() = False Then Exit Sub
        Try
            Dim rs As New ADODB.Recordset
            rs = New Recordset
            rs = conSql.Execute("select * from tblGradeYear where EducationLevel = '" & Edulv & "'")
            cboCategory.Items.Clear()
            Do While rs.EOF = False
                cboCategory.Items.Add(rs("GradeYear").Value)
                rs.MoveNext()
            Loop
        Catch ex As Exception
            frmSystemMain.txtSystemErr.Text = ex.Message
        End Try

    End Sub

    Private Sub cboCategory_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCategory.GotFocus
        cboCategory.Items.Clear()
        If cboDeptCateg.Text = "All" Then
            cboCategory.Text = vbNullString
            cboSec.Text = vbNullString
            txtKeyword.Text = vbNullString
            cboCategory.Enabled = False
            cboSec.Enabled = False
            txtKeyword.Enabled = False
        ElseIf cboDeptCateg.Text = "Individual" Then
            cboCategory.Items.Add("Name")
            cboCategory.Items.Add("IDnumber")
            cboCategory.Text = vbNullString
            cboSec.Text = vbNullString
            txtKeyword.Text = vbNullString
            txtKeyword.Enabled = True
            cboCategory.Enabled = True
            cboSec.Enabled = False
        Else
            Gy(cboDeptCateg.Text)
            cboSec.Enabled = True
            cboSec.Text = vbNullString
            txtKeyword.Text = vbNullString
            txtKeyword.Enabled = False
            txtKeyword.Enabled = False
        End If
        Button1.Enabled = True

        If cboDeptCateg.Text = "Employee" Then
            cboCategory.Items.Clear()
            cboCategory.Items.Add("Employee")
        End If
        'If cboDeptCateg.Text = "Individual" Then
        'cboRem.Enabled = True
        'txtKeyword.Enabled = True
        'txtKeyword.Focus()
        'Exit Sub
        'End If
        'cboSec.Enabled = True
        'cboRem.Enabled = True
        txtKeyword.Text = vbNullString
    End Sub

    Sub sec(ByVal gy As String)
        Try
            Dim rs As New ADODB.Recordset
            rs = New Recordset
            rs = conSql.Execute("select * from tblSection where GradeYear = '" & gy & "'")
            cboSec.Items.Clear()
            Do While rs.EOF = False
                cboSec.Items.Add(rs("Section").Value)
                rs.MoveNext()
            Loop
        Catch ex As Exception
            frmSystemMain.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Private Sub cboSec_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSec.GotFocus
        sec(cboCategory.Text)
        txtKeyword.Text = vbNullString

        If cboCategory.Text = "Employee" Then
            cboSec.Items.Clear()
            cboSec.Items.Add("Employee")
        End If
    End Sub

    Private Sub cboRem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtKeyword.Text = vbNullString
    End Sub

    Sub EduLv()
        If conServer() = False Then Exit Sub
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSql.Execute("select * from tbledulevel")
            cboDeptCateg.Items.Clear()
            cboDeptCateg.Items.Add("All")
            cboDeptCateg.Items.Add("Individual")
            cboDeptCateg.Items.Add("Employee")
            Do While rs.EOF = False
                cboDeptCateg.Items.Add(rs("EducationLevel").Value)
                rs.MoveNext()
            Loop
        Catch ex As Exception
            frmSystemMain.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Sub deptcateg()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSql.Execute("select * from tblgradeyear where GradeYear = '" & cboCategory.Text & "'")
            cboSec.Items.Clear()
            Do While rs.EOF = False
                cboSec.Items.Add(rs("Section").Value)
                rs.MoveNext()
            Loop
        Catch ex As Exception
            frmSystemMain.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Private Sub cboCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategory.SelectedIndexChanged
  
    End Sub

    Private Sub cboSec_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboSec.SelectedIndexChanged

    End Sub
End Class