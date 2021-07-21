Public Class frmLogsHistory

    Private Sub frmLogsHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header()
        fill()
    End Sub
    Sub header()
        LstDept.Columns.Add("Username", 130, HorizontalAlignment.Left)
        LstDept.Columns.Add("Name", 200, HorizontalAlignment.Left)
        LstDept.Columns.Add("Designation", 100, HorizontalAlignment.Left)
        LstDept.Columns.Add("LogType", 80, HorizontalAlignment.Left)
        LstDept.Columns.Add("LogsHistory", 200, HorizontalAlignment.Left)
        'LstDept.Columns.Add("Designation", 150, HorizontalAlignment.Left)
    End Sub
    Sub fill()
        On Error Resume Next
        If frmMain.StatDB.Text = "Disconnected" Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If
        'LstEmpRec.Clear()
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSql.Execute("select * from tblAccHistory")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                LstDept.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstDept.Items.Add(rs("Username").Value, lup)
                viewlst.SubItems.Add(rs("Name").Value)
                viewlst.SubItems.Add(rs("Designation").Value)
                viewlst.SubItems.Add(rs("LogType").Value)
                viewlst.SubItems.Add(rs("LogsHistory").Value)
                'viewlst.SubItems.Add(rs("Designation").Value)
                rs.MoveNext()
            Next
        End If
    End Sub
    Sub sirch()
        On Error Resume Next
        If frmMain.StatDB.Text = "Disconnected" Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If
        'LstEmpRec.Clear()
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSql.Execute("select * from tblAccHistory where " & cboCateg.Text & " like '" & txtInput.Text & "%'")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                LstDept.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstDept.Items.Add(rs("Username").Value, lup)
                viewlst.SubItems.Add(rs("Name").Value)
                viewlst.SubItems.Add(rs("Designation").Value)
                viewlst.SubItems.Add(rs("LogType").Value)
                viewlst.SubItems.Add(rs("LogsHistory").Value)
                'viewlst.SubItems.Add(rs("Designation").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Private Sub txtInput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInput.TextChanged
        LstDept.Clear()
        header()
        sirch()
    End Sub

    Private Sub cboCateg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCateg.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
            cboCateg.Focus()
        End If
    End Sub

    Private Sub cboCateg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCateg.SelectedIndexChanged

    End Sub
End Class