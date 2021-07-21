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
        LstEmpRec.Columns.Add("Status", 100, HorizontalAlignment.Left)
        'LstEmpRec.Columns.Add("Date", 100, HorizontalAlignment.Left)
        'LstEmpRec.Columns.Add("Remarks", 120, HorizontalAlignment.Left)
    End Sub
    Sub AttHead()
        LstEmpRec.Columns.Clear()
        LstEmpRec.Columns.Add("IdLog", 90, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("IdNumber", 90, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Name", 200, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Section", 170, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("TimeIn", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("TimeOut", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Status", 100, HorizontalAlignment.Left)
        'LstEmpRec.Columns.Add("Remarks", 120, HorizontalAlignment.Left)
    End Sub

    Private Sub frmLogs_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'frmMain.tmrPingT1.Enabled = True
        'frmMain.tmrPingT2.Enabled = True
        'frmMain.tmrPingServer.Enabled = True
        'frmMain.Timer1.Enabled = True
    End Sub

    Private Sub frmLogs_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'frmMain.tmrPingDev1.Enabled = True
        'frmMain.tmrPingDev2.Enabled = True
        'frmMain.tmrPingServer.Enabled = True
    End Sub

    Private Sub frmLogs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LstEmpRec.Clear()
        EntHead()
        EmpPic.Image = Nothing
        'ExtPic.Image = Nothing
        unable()
        cboCateg.Text = vbNullString
        If PingMe(Ip) = True Then
            subSQl()
        End If
        'sec()
        'tocbo()
    End Sub
    Sub sec()
        Dim rs As New ADODB.Recordset
        Dim rs2 As New ADODB.Recordset

        rs = New Recordset
        rs = conSql.Execute("select Section from tblInOut")

        Do While rs.EOF = False
            On Error Resume Next
            rs2 = New Recordset
            rs2.Open("select * from tblcbosec", conSql, 1, 2)
            rs2.AddNew()
            rs2("Sec").Value = rs("Section")
            rs2.Save()
            rs.MoveNext()
        Loop

    End Sub
    Sub tocbo()
        Dim rs3 As New ADODB.Recordset
        rs3 = New Recordset
        rs3 = conSql.Execute("select * from tblcboSec")
        Do While rs3.EOF = False
            ' cboSec.Items.Add(rs3("Sec").Value)
            rs3.MoveNext()
        Loop
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
        Dim rs As New Recordset
        id = vbNullString
        rs = conSql.Execute("select * from tblStudInfo where IDnumber = '" & Idno & "'")
        If rs.EOF = False Then
            id = rs("Acnumber").Value
        End If
    End Sub
    Private Sub cboCateg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
        cboRem.Enabled = False
        cboSec.Enabled = False
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub Entall()
        If frmMain.StatDB.Text = "Disconnected" Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If
        'LstEmpRec.Clear()
        ' Dim rs As New Recordset
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
                viewlst.SubItems.Add(rsPRS("Status").Value)
                'viewlst.SubItems.Add(rs("Date").Value)
                'viewlst.SubItems.Add(rs("Remarks").Value)
                rsPRS.MoveNext()
            Next
        End If
    End Sub
    Sub EntSrch()
        If frmMain.StatDB.Text = "Disconnected" Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If
        'LstEmpRec.Clear()

        Dim lup As Short
        Dim TmeInTo As String
        Dim TmeInFrm As String
        'Dim DateInFrm As String
        'Dim DateInTo As String

        TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
        TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")
        'Dim rs As New Recordset
        rsPRS = New Recordset
        rsPRS = conSql.Execute("select * from tblTImein where GradeYr like '" & cboCategory.Text & "%' and Section like '" & cboSec.Text & "%' and Status like '" & cboRem.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
        If rsPRS.EOF = False Then
            For lup = 1 To rsPRS.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rsPRS("IDLog").Value, lup)
                viewlst.SubItems.Add(rsPRS("IDnumber").Value)
                viewlst.SubItems.Add(rsPRS("Name").Value)
                viewlst.SubItems.Add(rsPRS("Section").Value)
                viewlst.SubItems.Add(rsPRS("TimeIn").Value)
                viewlst.SubItems.Add(rsPRS("Status").Value)
                'viewlst.SubItems.Add(rs("Date").Value)
                'viewlst.SubItems.Add(rs("Remarks").Value)
                rsPRS.MoveNext()
            Next
        End If
    End Sub
    Sub EntIndi()

        If frmMain.StatDB.Text = "Disconnected" Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If
        'LstEmpRec.Clear()

        Dim lup As Short
        Dim TmeInTo As String
        Dim TmeInFrm As String
        'Dim DateInFrm As String
        'Dim DateInTo As String

        TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
        TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")
        'Dim rs As New Recordset
        rsIn = New Recordset
        rsIn = conSql.Execute("select * from tblTImein where " & cboCategory.Text & " like '" & txtKeyword.Text & "%' and Status like '" & cboRem.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
        If rsIn.EOF = False Then
            For lup = 1 To rsIn.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rsIn("IDLog").Value, lup)
                viewlst.SubItems.Add(rsIn("IDnumber").Value)
                viewlst.SubItems.Add(rsIn("Name").Value)
                viewlst.SubItems.Add(rsIn("Section").Value)
                viewlst.SubItems.Add(rsIn("TimeIn").Value)
                viewlst.SubItems.Add(rsIn("Status").Value)
                'viewlst.SubItems.Add(rs("Date").Value)
                'viewlst.SubItems.Add(rs("Remarks").Value)
                rsIn.MoveNext()
            Next
        End If
    End Sub

    Sub InOutSrch()
        If frmMain.StatDB.Text = "Disconnected" Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Dim lup As Short
        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
        TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")

        'Dim rs As New Recordset
        rsIO = New Recordset
        rsIO = conSql.Execute("select * from tblInOut where GradeYr like '" & cboCategory.Text & "%' and Section like '" & cboSec.Text & "%' and Status like '" & cboRem.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <= '" & TmeInTo & "'")
        If rsIO.EOF = False Then
            For lup = 1 To rsIO.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rsIO("InOutID").Value, lup)
                viewlst.SubItems.Add(rsIO("IDnumber").Value)
                viewlst.SubItems.Add(rsIO("Name").Value)
                viewlst.SubItems.Add(rsIO("Section").Value)
                viewlst.SubItems.Add(rsIO("TimeIn").Value)
                viewlst.SubItems.Add(rsIO("TimeOut").Value)
                viewlst.SubItems.Add(rsIO("Status").Value)
                'viewlst.SubItems.Add(rs("Remarks").Value)
                rsIO.MoveNext()
            Next
        End If
    End Sub
    Sub IndiInOut()
        If frmMain.StatDB.Text = "Disconnected" Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Dim lup As Short
        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
        TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")

        'Dim rs As New Recordset
        rsInOut = New Recordset
        rsInOut = conSql.Execute("select * from tblInOut where " & cboCategory.Text & " like '" & txtKeyword.Text & "%' and Status like '" & cboRem.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <= '" & TmeInTo & "'")
        If rsInOut.EOF = False Then
            For lup = 1 To rsInOut.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rsInOut("InOutID").Value, lup)
                viewlst.SubItems.Add(rsInOut("IDnumber").Value)
                viewlst.SubItems.Add(rsInOut("Name").Value)
                viewlst.SubItems.Add(rsInOut("Section").Value)
                viewlst.SubItems.Add(rsInOut("TimeIn").Value)
                viewlst.SubItems.Add(rsInOut("TimeOut").Value)
                viewlst.SubItems.Add(rsInOut("Status").Value)
                'viewlst.SubItems.Add(rs("Remarks").Value)
                rsInOut.MoveNext()
            Next
        End If
    End Sub
    Sub InOutAll()
        If frmMain.StatDB.Text = "Disconnected" Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If
        'LstEmpRec.Clear()
        'Dim rs As New Recordset
        Dim lup As Short
        rsIO = New Recordset
        rsIO = conSql.Execute("select * from tblinOut")
        If rsIO.EOF = False Then
            For lup = 1 To rsIO.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rsIO("InOutID").Value, lup)
                viewlst.SubItems.Add(rsIO("IDnumber").Value)
                viewlst.SubItems.Add(rsIO("Name").Value)
                viewlst.SubItems.Add(rsIO("Section").Value)
                viewlst.SubItems.Add(rsIO("TimeIn").Value)
                viewlst.SubItems.Add(rsIO("TimeOut").Value)
                viewlst.SubItems.Add(rsIO("Status").Value)
                'viewlst.SubItems.Add(rs("Remarks").Value)
                rsIO.MoveNext()
            Next
        End If
    End Sub

    Private Sub LstEmpRec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub PresDel()
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
                rs2 = conSql.Execute("delete from tblTImein where GradeYr like '" & cboCategory.Text & "%' and Section like '" & cboSec.Text & "%' and Status like '" & cboRem.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
            End If
        End If
    End Sub
    Sub IndiPresDel()
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
                rs2 = conSql.Execute("delete from tblTImein where " & cboCategory.Text & " like '" & txtKeyword.Text & "%' and Status like '" & cboRem.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
            End If
        End If
    End Sub
    Sub AttDel()
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
                rs2 = conSql.Execute("delete from tblInOut where GradeYr like '" & cboCategory.Text & "%' and Section like '" & cboSec.Text & "%' and Status like '" & cboRem.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <= '" & TmeInTo & "'")
            End If
        End If
    End Sub
    Sub IndiAttDel()
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
                rs2 = conSql.Execute("delete from tblInOut where " & cboCategory.Text & " like '" & txtKeyword.Text & "%' and Status like '" & cboRem.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <= '" & TmeInTo & "'")
            End If
        End If
    End Sub
    Sub Prstprint()
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
    End Sub
    Sub InIndiPrnt()
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
    End Sub
    Sub AttRecPrint()
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
    End Sub
    Sub IndiAttPrint()
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
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtInput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
                EmpPic.Image = Nothing
                cboDeptCateg.Enabled = True
                
            Case "Logs Report"
                LstEmpRec.Clear()
                AttHead()
                able()
                cmdDel.Enabled = False
                cmdPrint.Enabled = False
                EmpPic.Image = Nothing
                cboDeptCateg.Enabled = True
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
        frmMain.Timer1.Enabled = False
        Select Case cboCateg.Text
            Case "Time In"
                If PingMe(Ip) = True Then
                    subSQl()
                End If
                frmMain.Timer1.Enabled = False
                If cboDeptCateg.Text = "Individual" Then
                    InIndiPrnt()
                    Exit Sub
                End If
                Prstprint()
            Case "Logs Report"
                If PingMe(Ip) = True Then
                    subSQl()
                End If
                frmMain.Timer1.Enabled = False
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
        slct()
        slctAc()
        If viewStud() = True Then
            Try
                EmpPic.Image = Image.FromFile(frmPicPath.txtpath.Text & "\" & (id) & ".Jpg")
            Catch
                EmpPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            End Try
        Else
            EmpPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
        End If
        'picInOutView()

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

    Private Sub txtInput_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SirchCateg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDeptCateg.SelectedIndexChanged
        cboCategory.Items.Clear()
        Select Case cboDeptCateg.Text
            Case "All"
                cboCategory.Text = vbNullString
                cboSec.Text = vbNullString
                cboRem.Text = vbNullString
                txtKeyword.Text = vbNullString
                cboCategory.Enabled = False
                cboSec.Enabled = False
                cboRem.Enabled = True
                txtKeyword.Enabled = False
            Case "Individual"
                cboCategory.Items.Add("Name")
                cboCategory.Items.Add("IDnumber")
                cboRem.Enabled = False
                cboCategory.Text = vbNullString
                cboSec.Text = vbNullString
                cboRem.Text = vbNullString
                txtKeyword.Text = vbNullString
                cboCategory.Enabled = True
                cboSec.Enabled = False
            Case "Grade School"
                cboCategory.Items.Add("K1")
                cboCategory.Items.Add("K2")
                cboCategory.Items.Add("Grade 1")
                cboCategory.Items.Add("Grade 2")
                cboCategory.Items.Add("Grade 3")
                cboCategory.Items.Add("Grade 4")
                cboCategory.Items.Add("Grade 5")
                cboCategory.Items.Add("Grade 6")
                cboCategory.Enabled = True
                cboSec.Text = vbNullString
                cboRem.Text = vbNullString
                txtKeyword.Text = vbNullString
                cboCategory.Text = vbNullString
                txtKeyword.Enabled = False
                cboRem.Enabled = True
            Case "High School"
                cboCategory.Items.Add("Grade 7")
                cboCategory.Items.Add("2nd Year")
                cboCategory.Items.Add("3rd Year")
                cboCategory.Items.Add("4th Year")
                cboCategory.Enabled = True
                cboSec.Text = vbNullString
                cboRem.Text = vbNullString
                txtKeyword.Text = vbNullString
                cboCategory.Text = vbNullString
                txtKeyword.Enabled = False
                cboRem.Enabled = True
        End Select
        Button1.Enabled = True
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

    Private Sub cboSec_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cboSec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cboCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategory.SelectedIndexChanged
        Dim rs As New ADODB.Recordset
        rs = New Recordset
        rs = conSql.Execute("select * from tblcboSec where Gy = '" & cboCategory.Text & "'")
        cboSec.Items.Clear()
        Do While rs.EOF = False
            cboSec.Items.Add(rs("Sec").Value)
            rs.MoveNext()
        Loop
        If cboDeptCateg.Text = "Individual" Then
            cboRem.Enabled = True
            txtKeyword.Enabled = True
            txtKeyword.Focus()
            Exit Sub
        End If
        cboSec.Enabled = True
        cboRem.Enabled = True

        cboRem.Text = vbNullString
        txtKeyword.Text = vbNullString
    End Sub

    Private Sub cboSec_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSec.SelectedIndexChanged
        cboRem.Text = vbNullString
        txtKeyword.Text = vbNullString
    End Sub

    Private Sub cboRem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRem.SelectedIndexChanged
        txtKeyword.Text = vbNullString
    End Sub
End Class