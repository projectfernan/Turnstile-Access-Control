Imports ADODB
Public Class frmAdminAcc
    Public id As String
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmAdminAcc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If
        LstDept.Clear()
        header()
        fill()
        disable()
        cmddisable()
        cmdAdd.Enabled = True
        cboCateg.Enabled = False
    End Sub

    Sub header()
        LstDept.Columns.Add("Username", 150, HorizontalAlignment.Left)
        LstDept.Columns.Add("Name", 300, HorizontalAlignment.Left)
        LstDept.Columns.Add("Designation", 100, HorizontalAlignment.Left)
        'LstDept.Columns.Add("Designation", 150, HorizontalAlignment.Left)
    End Sub

    Sub slct()
        Dim viewlst As New ListViewItem
        For Each viewlst In LstDept.Items
            If viewlst.Selected = True Then
                id = viewlst.SubItems(0).Text
            End If
        Next
    End Sub

    Sub fill()
        On Error Resume Next
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If
        'LstEmpRec.Clear()
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSql.Execute("select * from tblUserAcc")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                LstDept.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstDept.Items.Add(rs("Username").Value, lup)
                viewlst.SubItems.Add(rs("Name").Value)
                viewlst.SubItems.Add(rs("Designation").Value)
                'viewlst.SubItems.Add(rs("Designation").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub save()
        If conServer() = True Then
            Dim rs As New Recordset
            'Dim ad As String
            rs = New Recordset
            rs.Open("select * from tblUserAcc", conSql, 1, 2)
            'ad = rs.RecordCount + 1
            rs.AddNew()
            rs("Username").Value = txtuid.Text
            rs("Password").Value = txtpwd.Text
            rs("Name").Value = txtName.Text
            rs("Designation").Value = cboCateg.Text
            'rs("Designation").Value = cboDesig.Text
            rs.Update()
            MsgBox("New Account created!    ", vbInformation, "Admin")
            LstDept.Clear()
            header()
            fill()
            Exit Sub
        Else
            MsgBox("Database disconnected!    ", vbExclamation, "Save")
            Exit Sub
        End If
   
    End Sub
    Function confirm() As Boolean
        If txtpwd.Text = txtConfirm.Text Then
            
            Return True
        Else
            Return False
        End If
    End Function
    Function usercheck() As Boolean
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSql.Execute("select * from tblUserAcc where Username = '" & txtuid.Text & "'")
        If rs.EOF = False Then
            'MsgBox("Username already exist!    ", vbExclamation)
            Return True
        Else
            Return False
        End If
    End Function
    Function scan() As Boolean
        If txtuid.Text = vbNullString Or txtpwd.Text = vbNullString Or txtConfirm.Text = vbNullString Or txtName.Text = vbNullString Then
            'MsgBox("Please fill up the blanks!    ", vbExclamation)
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub cmdSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubmit.Click
        If scan() = True Then
            MsgBox("Please fill up the blanks!    ", vbExclamation)
            txtuid.Focus()
            Exit Sub
        End If
        If testadmin() = True Then
            MsgBox("Username already exist!    ", vbExclamation)
            clear()
            txtuid.Focus()
            Exit Sub
        End If
        If usercheck() = True Then
            MsgBox("Username already exist!    ", vbExclamation)
            clear()
            txtuid.Focus()
            Exit Sub
        End If
        If confirm() = False Then
            MsgBox("Password mismatch!    ", vbExclamation)
            txtpwd.Text = vbNullString
            txtConfirm.Text = vbNullString
            txtpwd.Focus()
            Exit Sub
        End If
        save()
        clear()
        disable()
        cboCateg.Enabled = False
        cmdAdd.Enabled = True
        cmdSubmit.Enabled = False
    End Sub
    Sub enable()
        txtuid.Enabled = True
        txtpwd.Enabled = True
        txtConfirm.Enabled = True
        txtName.Enabled = True
    End Sub
    Sub disable()
        txtuid.Enabled = False
        txtpwd.Enabled = False
        txtConfirm.Enabled = False
        txtName.Enabled = False
    End Sub
    Sub clear()
        txtuid.Text = vbNullString
        txtpwd.Text = vbNullString
        txtConfirm.Text = vbNullString
        txtName.Text = vbNullString
    End Sub
    Sub cmdable()
        cmdSubmit.Enabled = True
        cmdDel.Enabled = True
    End Sub
    Sub cmddisable()
        cmdSubmit.Enabled = False
        cmdDel.Enabled = False
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        enable()
        cmdSubmit.Enabled = True
        cmdAdd.Enabled = False
        cmdDel.Enabled = False
        cboCateg.Enabled = True
        clear()
        txtuid.Focus()
    End Sub

    Private Sub LstDept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstDept.SelectedIndexChanged
        slct()
        view(id)
        disable()
        cmdDel.Enabled = True
        cmdSubmit.Enabled = False
        cmdAdd.Enabled = True
    End Sub
    Sub view(ByVal uid As String)
        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblUserAcc where Username = '" & uid & "'", conSql, 1, 2)
        txtuid.Text = rs("Username").Value
        txtpwd.Text = rs("Password").Value()
        txtName.Text = rs("Name").Value
        cboCateg.Text = rs("Designation").Value
    End Sub
    Sub del(ByVal Uid As String)
        If MsgBox("Are you sure do you want to delete this account?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Delete") = vbYes Then
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("delete from tblUserAcc where Username = '" & Uid & "'", conSql, 1, 2)
            LstDept.Clear()
            header()
            fill()
            MsgBox("Account successfully deleted!    ", vbInformation, "Admin")
        End If
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        del(id)
        clear()
        cmdDel.Enabled = False
        cmdAdd.Enabled = True
    End Sub
    Function testadmin() As Boolean
        If txtuid.Text = "fernan" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub txtuid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtuid.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtpwd.Focus()
        End If
    End Sub

    Private Sub txtuid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuid.TextChanged

    End Sub

    Private Sub txtpwd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpwd.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtConfirm.Focus()
        End If
    End Sub

    Private Sub txtpwd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpwd.TextChanged

    End Sub

    Private Sub txtConfirm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConfirm.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtName.Focus()
        End If
    End Sub

    Private Sub txtConfirm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConfirm.TextChanged

    End Sub

    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cboCateg.Focus()
        End If
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub cboCateg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCateg.KeyPress
        If Asc(e.KeyChar) > 1 And Asc(e.KeyChar) <> 13 Then
            e.KeyChar = vbNullString
            cboCateg.Focus()
        End If
        If Asc(e.KeyChar) = 13 Then
            If scan() = True Then
                MsgBox("Please fill up the blanks!    ", vbExclamation)
                txtuid.Focus()
                Exit Sub
            End If
            If testadmin() = True Then
                MsgBox("Username already exist!    ", vbExclamation)
                clear()
                txtuid.Focus()
                Exit Sub
            End If
            If usercheck() = True Then
                MsgBox("Username already exist!    ", vbExclamation)
                clear()
                txtuid.Focus()
                Exit Sub
            End If
            If confirm() = False Then
                MsgBox("Password mismatch!    ", vbExclamation)
                txtpwd.Text = vbNullString
                txtConfirm.Text = vbNullString
                txtpwd.Focus()
                Exit Sub
            End If
            save()
            clear()
            cboCateg.Enabled = False
            disable()
            cmdAdd.Enabled = True
            cmdSubmit.Enabled = False
        End If
    End Sub

    Private Sub cboCateg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCateg.SelectedIndexChanged

    End Sub

    Private Sub tmrConn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrConn.Tick

    End Sub
End Class