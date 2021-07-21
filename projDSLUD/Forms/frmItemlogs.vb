Imports ADODB
Public Class frmItemlogs
    Public rsPRS As New Recordset
    Public rsIO As New Recordset
    Private Sub frmItemlogs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LstEmpRec.Clear()
        EntHead()
    End Sub

    Sub EntHead()
        LstEmpRec.Columns.Clear()
        LstEmpRec.Columns.Add("Id", 120, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("CardCode", 150, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("TimeIn", 250, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Status", 200, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("", 0, HorizontalAlignment.Left)
    End Sub

    Sub AttHead()
        LstEmpRec.Columns.Clear()
        LstEmpRec.Columns.Add("Id", 100, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("CardCode", 130, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("TimeIn", 200, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("TimeOut", 200, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Status", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("", 0, HorizontalAlignment.Left)
    End Sub

    Sub unable()
        cmdPrint.Enabled = False
        Button1.Enabled = False
        txtKeyword.Enabled = False
        cboCategory.Enabled = False
    End Sub

    Private Sub cboCateg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCateg.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboCateg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCateg.SelectedIndexChanged
        Select Case cboCateg.Text
            Case "Time In"
                LstEmpRec.Clear()
                EntHead()
                imgStud.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
            Case "Logs Report"
                LstEmpRec.Clear()
                AttHead()
                imgStud.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
        End Select
    End Sub

    Private Sub cboCategory_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCategory.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategory.SelectedIndexChanged
        If cboCategory.Text = "By date" Then
            txtKeyword.Enabled = False
        Else
            txtKeyword.Enabled = True
        End If
    End Sub

    Sub EntSrchDT()
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Dim lup As Short
        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
        TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")

        rsPRS = New Recordset
        rsPRS = conSql.Execute("select * from vwecompitemin where TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
        If rsPRS.EOF = False Then
            For lup = 1 To rsPRS.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rsPRS("ID").Value, lup)
                viewlst.SubItems.Add(rsPRS("CardCode").Value)
                viewlst.SubItems.Add(rsPRS("TimeIn").Value)
                viewlst.SubItems.Add(rsPRS("Status").Value)
                viewlst.SubItems.Add(rsPRS("IDnumber").Value)
                rsPRS.MoveNext()
            Next
        End If
    End Sub

    Sub EntSrch()
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Dim lup As Short
        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
        TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")

        rsPRS = New Recordset
        rsPRS = conSql.Execute("select * from vwecompitemin where " & cboCategory.Text & " like '" & txtKeyword.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
        If rsPRS.EOF = False Then
            For lup = 1 To rsPRS.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rsPRS("ID").Value, lup)
                viewlst.SubItems.Add(rsPRS("CardCode").Value)
                viewlst.SubItems.Add(rsPRS("TimeIn").Value)
                viewlst.SubItems.Add(rsPRS("Status").Value)
                viewlst.SubItems.Add(rsPRS("IDnumber").Value)
                rsPRS.MoveNext()
            Next
        End If
    End Sub

    Sub InOutSrchDT()
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Dim lup As Short
        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
        TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")

        rsIO = New Recordset
        rsIO = conSql.Execute("select * from vwecompitemInOut where TimeOut >= '" & TmeInFrm & "' and TimeOut <= '" & TmeInTo & "'")
        If rsIO.EOF = False Then
            For lup = 1 To rsIO.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rsIO("ID").Value, lup)
                viewlst.SubItems.Add(rsIO("CardCode").Value)
                viewlst.SubItems.Add(rsIO("TimeIn").Value)
                viewlst.SubItems.Add(rsIO("TimeOut").Value)
                viewlst.SubItems.Add(rsIO("Status").Value)
                viewlst.SubItems.Add(rsIO("IDnumber").Value)
                rsIO.MoveNext()
            Next
        End If
    End Sub

    Sub InOutSrch()
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Dim lup As Short
        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtDateFrm.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Value), "HH:mm:ss tt")
        TmeInTo = Format(CDate(dtDateTo.Value), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Value), "HH:mm:ss tt")

        rsIO = New Recordset
        rsIO = conSql.Execute("select * from vwecompitemInOut where " & cboCategory.Text & " like '" & txtKeyword.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <= '" & TmeInTo & "'")
        If rsIO.EOF = False Then
            For lup = 1 To rsIO.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rsIO("ID").Value, lup)
                viewlst.SubItems.Add(rsIO("CardCode").Value)
                viewlst.SubItems.Add(rsIO("TimeIn").Value)
                viewlst.SubItems.Add(rsIO("TimeOut").Value)
                viewlst.SubItems.Add(rsIO("Status").Value)
                viewlst.SubItems.Add(rsIO("IDnumber").Value)
                rsIO.MoveNext()
            Next
        End If
    End Sub

    Sub clearData()
        txtIDno.Text = "____________________"
        txtName.Text = "____________________"
        txtGy.Text = "____________________"
        txtSec.Text = "____________________"
        txtGuardian.Text = "____________________"
        txtContact.Text = "____________________"
        imgStud.Image = Image.FromFile(Application.StartupPath & "\Nopic.jpg")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        clearData()
        Select Case cboCateg.Text
            Case "Time In"
                If cboCategory.Text = "By date" Then
                    LstEmpRec.Clear()
                    EntHead()
                    EntSrchDT()
                    Exit Sub
                End If
                LstEmpRec.Clear()
                EntHead()
                EntSrch()
            Case "Logs Report"
                If cboCategory.Text = "By date" Then
                    LstEmpRec.Clear()
                    AttHead()
                    InOutSrchDT()
                    Exit Sub
                End If
                LstEmpRec.Clear()
                AttHead()
                InOutSrch()
        End Select
    End Sub

    Sub viewStud(ByVal studId As String)
        If conServer() = False Then Exit Sub
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSql.Execute("select * from tblStudinfo where IDnumber = '" & studId & "'")
            If rs.EOF = False Then
                txtIDno.Text = rs("IDnumber").Value
                txtName.Text = rs("Name").Value
                txtGy.Text = rs("GradeYear").Value
                txtSec.Text = rs("Section").Value
                txtGuardian.Text = rs("Guardian").Value
                txtContact.Text = rs("ContactNo").Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Student Items")
        End Try
    End Sub

    Private Sub LstEmpRec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstEmpRec.SelectedIndexChanged
        Dim viewlst As New ListViewItem
        For Each viewlst In LstEmpRec.Items
            If viewlst.Selected = True Then
                If cboCateg.Text = "Time In" Then
                    imgStud.Image = StudentPic(viewlst.SubItems(4).Text)
                    viewStud(viewlst.SubItems(4).Text)
                Else
                    imgStud.Image = StudentPic(viewlst.SubItems(5).Text)
                    viewStud(viewlst.SubItems(5).Text)
                End If
            End If
        Next
    End Sub

    Sub Prstprint()
        Dim ReportPath As String = Application.StartupPath & "\Report\CrtItemIn.rpt"
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

    Sub IOPrint()
        Dim ReportPath As String = Application.StartupPath & "\Report\CrtItemInOut.rpt"
        If Not IO.File.Exists(ReportPath) Then
            MsgBox("Cannot load Report file!    ", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Report.Load(ReportPath)
        Report.SetDataSource(rsIO)
        frmReportLogs.CRViewer.ReportSource = Report
        frmReportLogs.ShowDialog()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Select Case cboCateg.Text
            Case "Time In"
                Prstprint()
            Case "Logs Report"
                IOPrint()
        End Select
    End Sub
End Class