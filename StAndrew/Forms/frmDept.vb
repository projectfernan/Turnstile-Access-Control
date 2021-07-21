Imports ADODB
Public Class frmDept
    Public id As String
    Private Sub frmDept_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LstDept.Clear()
        header()
        fill()
        txtDept.Enabled = False
        cmdDel.Enabled = False
        cmdAdd.Text = "&Add    "
    End Sub
    Sub slct()
        Dim viewlst As New ListViewItem
        For Each viewlst In LstDept.Items
            If viewlst.Selected = True Then
                id = viewlst.SubItems(0).Text
            End If
        Next
    End Sub
    Sub header()
        LstDept.Columns.Add("Id", 60, HorizontalAlignment.Left)
        LstDept.Columns.Add("Department", 300, HorizontalAlignment.Left)
    End Sub
    Sub fill()
        If PingMe(Ip) = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If
        'LstEmpRec.Clear()
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSql.Execute("select * from tblDept")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                LstDept.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstDept.Items.Add(rs("Id").Value, lup)
                viewlst.SubItems.Add(rs("Department").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If cmdAdd.Text = "&Add    " Then
            txtDept.Enabled = True
            txtDept.Focus()
            cmdAdd.Text = "&Save    "
            Exit Sub
        End If
        If cmdAdd.Text = "&Save    " Then
            If PingMe(Ip) = True Then
                Dim rs As New Recordset
                Dim ad As String
                rs = New Recordset
                rs.Open("select * from tblDept", conSql, 1, 2)
                ad = rs.RecordCount + 1
                rs.AddNew()
                rs("ID").Value = ad
                rs("Department").Value = txtDept.Text
                rs.Update()
                MsgBox("New Dapartment added!    ", vbInformation, "Department")
                txtDept.Text = vbNullString
                txtDept.Enabled = False
                cmdAdd.Text = "&Add    "
                LstDept.Clear()
                header()
                fill()
            Else
                MsgBox("Database disconnected!    ", vbExclamation, "Save")
                Exit Sub
            End If
        Else
            Exit Sub
        End If
    End Sub
    Sub search()
        If PingMe(Ip) = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If
        'LstEmpRec.Clear()
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSql.Execute("select * from tblDept where Department like '" & txtinput.Text & "%'")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                LstDept.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstDept.Items.Add(rs("Id").Value, lup)
                viewlst.SubItems.Add(rs("Department").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Private Sub txtinput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtinput.TextChanged
        LstDept.Clear()
        header()
        search()
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        If MsgBox("Are you sure do you want to delete this record?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Delete") = vbYes Then
            del()
            LstDept.Clear()
            header()
            fill()
            cmdDel.Enabled = False
            MsgBox("Department deleted!    ", vbInformation, "Delete")
        End If
    End Sub

    Private Sub LstDept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstDept.SelectedIndexChanged
        slct()
        cmdDel.Enabled = True
    End Sub
    Sub del()
        If PingMe(Ip) = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If
        Dim rs2 As New Recordset
        rs2 = New Recordset
        rs2 = conSql.Execute("delete from tblDept where id = '" & id & "'")
    End Sub
End Class