Public Class frmEmp
    Public id As String
    Private Sub frmEmp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If PingMe(Ip) = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If
        LstEmpRec.Clear()
        header()
        fill()
        disableCmd(Me)
        cmdSearch.Enabled = True
        cmdClose.Enabled = True
        cmdAdd.Enabled = True
        cmdRefresh.Enabled = True
    End Sub

    Sub header()
        LstEmpRec.Columns.Add("AC Number", 100, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("ID Number", 100, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Name", 200, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Position", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Department", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Address", 120, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("ContactNo", 145, HorizontalAlignment.Left)
    End Sub

    Sub fill()
        If PingMe(Ip) = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If
        'LstEmpRec.Clear()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSql.Execute("select * from tblEmp")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rs("ACnumber").Value, lup)
                viewlst.SubItems.Add(rs("Idnumber").Value)
                viewlst.SubItems.Add(rs("Name").Value)
                viewlst.SubItems.Add(rs("Position").Value)
                viewlst.SubItems.Add(rs("Department").Value)
                viewlst.SubItems.Add(rs("Address").Value)
                viewlst.SubItems.Add(rs("ContactNo").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        flag = "Save"
        frmAddEmp.Label9.Text = "New Employee"
        ClearTextBox(frmAddEmp)

        frmAddEmp.GroupBox1.Enabled = True
        frmAddEmp.cmdSubmit.Text = "&Save    "

        frmAddEmp.txtip.Enabled = True
        frmAddEmp.EmpPic.Image = Nothing
        frmAddEmp.txtip.Focus()
        frmAddEmp.txtAC.ReadOnly = False
        frmAddEmp.ShowDialog()
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        LstEmpRec.Clear()
        header()
        fill()
        cmdEdit.Enabled = False
        cmdDel.Enabled = False
    End Sub

    Private Sub LstEmpRec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstEmpRec.SelectedIndexChanged
        slct()
        Try
            EmpPic.Image = Image.FromFile(frmPicPath.txtpath.Text & "\" & (id) & ".Jpg")
            frmAddEmp.EmpPic.Image = Image.FromFile(frmPicPath.txtpath.Text & "\" & (id) & ".Jpg")
        Catch
            EmpPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            frmAddEmp.EmpPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
        End Try
        'frmPicPath.txtpath.Text & "\EmpPic\" & (IDNumber) & ".Jpg"
        'frmNewStud.EmpPic.Image = picView()
        enableCmd(Me)
        If desig = "User" Then
            cmdDel.Enabled = False
            cmdEdit.Enabled = False
        Else
            cmdDel.Enabled = True
            cmdEdit.Enabled = True
        End If
    End Sub
    Sub slct()
        Dim viewlst As New ListViewItem
        For Each viewlst In LstEmpRec.Items
            If viewlst.Selected = True Then
                id = viewlst.SubItems(0).Text
            End If
        Next
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        flag = "Edit"
        frmAddEmp.Label9.Text = "Update Employee Information"
        EmpPic.Image = Nothing
        enableTxt(frmAddEmp)
        'frmNewEmployee.txtip.Text = My.Settings.DEV_Enroller
        frmAddEmp.cmdBrowse.Enabled = True
        frmAddEmp.cmdSubmit.Enabled = True
        frmAddEmp.cmdSubmit.Text = "&Update  "
        frmAddEmp.GroupBox1.Enabled = False
        frmAddEmp.txtAC.ReadOnly = True
        edit()

    End Sub
    Sub edit()
        If PingMe(Ip) = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSql.Execute("select * from tblEmp where ACNumber = '" & id & "'")
        If rs.EOF = False Then
            frmAddEmp.txtAC.Text = rs("ACnumber").Value
            frmAddEmp.txtId.Text = rs("IDnumber").Value
            frmAddEmp.txtName.Text = rs("Name").Value
            frmAddEmp.txtPosition.Text = rs("Position").Value
            frmAddEmp.txtDept.Text = rs("Department").Value
            frmAddEmp.txtAdd.Text = rs("Address").Value
            frmAddEmp.txtContact.Text = rs("ContactNo").Value
        End If
        frmAddEmp.ShowDialog()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cboCateg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCateg.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
            cboCateg.Focus()
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        LstEmpRec.Clear()
        header()
        Findfill()
    End Sub
    Sub Findfill()
        If PingMe(Ip) = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If
        On Error Resume Next
        'LstEmpRec.Clear()
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSql.Execute("select * from tblEmp where " & cboCateg.Text & " like '" & txtInput.Text & "%'")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rs("ACnumber").Value, lup)
                viewlst.SubItems.Add(rs("Idnumber").Value)
                viewlst.SubItems.Add(rs("Name").Value)
                viewlst.SubItems.Add(rs("Position").Value)
                viewlst.SubItems.Add(rs("Department").Value)
                viewlst.SubItems.Add(rs("Address").Value)
                viewlst.SubItems.Add(rs("ContactNo").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Private Sub txtInput_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            LstEmpRec.Clear()
            header()
            Findfill()
        End If
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        If MsgBox("Are you sure do you want to delete this record?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Delete") = vbYes Then
            del()
            LstEmpRec.Clear()
            header()
            fill()
            cmdEdit.Enabled = False
            cmdDel.Enabled = False
            EmpPic.Image = Nothing
            frmNewStud.EmpPic.Image = Nothing
        End If
    End Sub

    Sub clear()
        frmNewStud.EmpPic.Image = Nothing
        EmpPic.Image = Nothing
    End Sub

    Sub del()
        If PingMe(Ip) = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If
        Dim rs2 As New Recordset
        rs2 = New Recordset
        rs2 = conSql.Execute("delete from tblEmp where AcNumber = '" & id & "'")
    End Sub
End Class