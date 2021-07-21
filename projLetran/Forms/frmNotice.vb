Public Class frmNotice

    Private Sub frmNotice_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        LstDept.Clear()
        header()
        fill()
    End Sub

    Sub header()
        Dim w As Integer = LstDept.Width / 4
        LstDept.Columns.Add("ACnumber", w, HorizontalAlignment.Left)
        LstDept.Columns.Add("IDnumber", w, HorizontalAlignment.Left)
        LstDept.Columns.Add("Name", w, HorizontalAlignment.Left)
        LstDept.Columns.Add("Notice", w, HorizontalAlignment.Left)
    End Sub

    Sub fill()
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If

        ' On Error Resume Next

        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSql.Execute("select * from vwenotice order by IDnumber;")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                LstDept.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstDept.Items.Add(rs("ACnumber").Value, lup)
                viewlst.SubItems.Add(rs("IDnumber").Value)
                viewlst.SubItems.Add(rs("Name").Value)
                viewlst.SubItems.Add(rs("Notice").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Private Sub cmdAdd_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdd.Click
        Select Case cmdAdd.Text
            Case "&Add"
                EnableObj()
                frmAddStudList.ShowDialog()
                Me.Close()
            Case "&Save"
                saveNoti()
                LstDept.Clear()
                header()
                fill()

                Contclear()
                cmdAdd.Text = "&Add"
        End Select

    End Sub

    Private Sub cmdEdit_Click(sender As System.Object, e As System.EventArgs) Handles cmdEdit.Click
        Select Case cmdEdit.Text
            Case "&Edit"
                If txtAC.Text = vbNullString Then Exit Sub
                EnableObj()
                cmdEdit.Text = "&Update"
                txtNotice.Focus()
            Case "&Update"
                updateNoti(txtAC.Text)
                LstDept.Clear()
                header()
                fill()

                Contclear()
                cmdEdit.Text = "&Edit"
        End Select
    End Sub

    Sub DElNoti(Acn As String)
        If conServer() = False Then Exit Sub

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSql.Execute("delete from tblnotice where ACnumber = '" & Acn & "'")
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Delete")
        End Try
    End Sub

    Private Sub cmdDel_Click(sender As System.Object, e As System.EventArgs) Handles cmdDel.Click
        If MsgBox("Are you sure do you want to delete this record? ", vbYesNo + vbDefaultButton2 + vbQuestion, "Delete") = vbYes Then
            DElNoti(txtAC.Text)

            LstDept.Clear()
            header()
            fill()
        End If
    End Sub

    Sub Contclear()
        txtAC.Text = vbNullString
        txtIDno.Text = vbNullString
        txtName.Text = vbNullString
        txtNotice.Text = vbNullString
    End Sub

    Sub DisableObj()
        txtAC.Enabled = False
        txtIDno.Enabled = False
        txtName.Enabled = False
        txtNotice.Enabled = False
    End Sub

    Sub EnableObj()
        txtAC.Enabled = True
        txtIDno.Enabled = True
        txtName.Enabled = True
        txtNotice.Enabled = True
    End Sub

    Sub saveNoti()
        If conServer() = False Then Exit Sub

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs.Open("select * from tblnotice where 1=0;", conSql, 1, 2)
            rs.AddNew()
            rs("ACnumber").Value = txtAC.Text
            rs("Notice").Value = txtNotice.Text
            rs.Update()
            MsgBox("Student notification successfully saved! ", vbInformation, "Save")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Save")
        End Try
    End Sub

    Sub updateNoti(ACn As String)
        If conServer() = False Then Exit Sub

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSql.Execute("update tblnotice set Notice = '" & txtNotice.Text & "' where ACnumber = '" & ACn & "';")
            MsgBox("Student notification successfully updated! ", vbInformation, "Update")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Save")
        End Try
    End Sub

    Sub selectVwe()
        DisableObj()
        Dim viewlst As New ListViewItem
        For Each viewlst In LstDept.Items
            If viewlst.Selected = True Then
                txtAC.Text = viewlst.SubItems(0).Text
                txtIDno.Text = viewlst.SubItems(1).Text
                txtName.Text = viewlst.SubItems(2).Text
                txtNotice.Text = viewlst.SubItems(3).Text
                ' txtNotice.Focus()
            End If
        Next
    End Sub

    Private Sub LstDept_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles LstDept.SelectedIndexChanged
        selectVwe()
    End Sub

    Private Sub cmdCancel_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancel.Click
        LstDept.Clear()
        header()
        fill()

        Contclear()
        cmdAdd.Text = "&Add"
        cmdEdit.Text = "&Edit"
        txtNotice.Focus()
    End Sub

    Private Sub txtNotice_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNotice.TextChanged

    End Sub

    Private Sub frmNotice_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class