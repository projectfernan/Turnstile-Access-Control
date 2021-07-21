Imports ADODB

Public Class frmAddStudList

    Sub header()
        Dim w As Integer = LstEmpRec.Width / 3
        LstEmpRec.Columns.Add("", 0, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("AC Number", w, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("ID Number", w, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("StudentName", w, HorizontalAlignment.Left)
    End Sub

    Private Sub AddStudList_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        LstEmpRec.Clear()
        header()
    End Sub

    Sub fill()
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Database")
            Exit Sub
        End If

        Dim rs As New Recordset
        Dim rs2 As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSql.Execute("select ID,ACnumber,IDnumber,Name from tblstudinfo order by ID")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                ' On Error Resume Next
                LstEmpRec.Refresh()
                ''rs2 = New Recordset
                ''rs2 = conSql.Execute("select ACnumber from tblnotice where ACnumber = '" & rs("ACnumber").Value & "' order by ID;")
                ''If rs2.EOF = True Then
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rs("ID").Value, lup)
                viewlst.SubItems.Add(rs("ACnumber").Value)
                viewlst.SubItems.Add(rs("IDnumber").Value)
                viewlst.SubItems.Add(rs("Name").Value)
                'End If
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub find()
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Database")
            Exit Sub
        End If

        Dim rs As New Recordset
        Dim rs2 As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSql.Execute("select * from tblstudinfo where " & cboCateg.Text & " like '" & txtInput.Text & "%' order by ID")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                On Error Resume Next
                LstEmpRec.Refresh()
                rs2 = New Recordset
                rs2 = conSql.Execute("select ID,ACnumber,IDnumber,Name from tblnotice where ACnumber = '" & rs("ACnumber").Value & "' order by ID;")
                If rs2.EOF = True Then
                    Dim viewlst As New ListViewItem
                    viewlst = LstEmpRec.Items.Add(rs("ID").Value, lup)
                    viewlst.SubItems.Add(rs("ACnumber").Value)
                    viewlst.SubItems.Add(rs("IDnumber").Value)
                    viewlst.SubItems.Add(rs("Name").Value)
                End If
                rs.MoveNext()
            Next
        End If
    End Sub

    Private Sub cmdRefresh_Click(sender As System.Object, e As System.EventArgs) Handles cmdRefresh.Click
        LstEmpRec.Clear()
        header()
        fill()
    End Sub

    Private Sub cmdSearch_Click(sender As System.Object, e As System.EventArgs) Handles cmdSearch.Click
        LstEmpRec.Clear()
        header()
        find()
    End Sub

    Private Sub cboCateg_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cboCateg.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Sub AddNoticeInfo()

        Dim viewlst As New ListViewItem
        For Each viewlst In LstEmpRec.Items
            If viewlst.Selected = True Then
                flag = "Save"
                ' On Error Resume Next
                With frmNotice
                    .txtAC.Text = viewlst.SubItems(1).Text
                    .txtIDno.Text = viewlst.SubItems(2).Text
                    .txtName.Text = viewlst.SubItems(3).Text
                    .cmdAdd.Text = "&Save"
                    '.txtNotice.Focus()
                    Me.Visible = False
                    Me.Close()
                    frmNotice.ShowDialog()
                End With
            End If
        Next
    End Sub

    Private Sub cmdAdd_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdd.Click
        AddNoticeInfo()
    End Sub

End Class