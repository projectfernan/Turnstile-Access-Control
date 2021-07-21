Imports ADODB
Public Class frmStudent
    Public id As String
    Public delPic As String
    Public delpath As String

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        flag = "Save"
        frmNewStud.Label9.Text = "New Student"
        ClearTextBox(frmNewStud)
        
        frmNewStud.GroupBox1.Enabled = True
        frmNewStud.cmdSubmit.Text = "&Save    "

        frmNewStud.txtip.Enabled = True
        frmNewStud.EmpPic.Image = Nothing
        frmNewStud.txtip.Focus()
        frmNewStud.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmEmployee_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        EmpPic.Image = Nothing
        LstEmpRec.Clear()
    End Sub

    Private Sub frmEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If PingMe(Ip) = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If
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
        LstEmpRec.Columns.Add("ID Number", 90, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Name", 200, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Grade/Year", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Section", 180, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Address", 120, HorizontalAlignment.Left)
        LstEmpRec.Columns.Add("Guardian", 140, HorizontalAlignment.Left)
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
        rs = conSql.Execute("select * from tblStudInfo")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rs("ACnumber").Value, lup)
                viewlst.SubItems.Add(rs("Idnumber").Value)
                viewlst.SubItems.Add(rs("Name").Value)
                viewlst.SubItems.Add(rs("GradeYear").Value)
                viewlst.SubItems.Add(rs("Section").Value)
                viewlst.SubItems.Add(rs("Address").Value)
                viewlst.SubItems.Add(rs("Guardian").Value)
                viewlst.SubItems.Add(rs("ContactNo").Value)
                rs.MoveNext()
            Next
        End If
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
        rs = conSql.Execute("select * from tblStudInfo where " & cboCateg.Text & " like '" & txtInput.Text & "%'")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                LstEmpRec.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = LstEmpRec.Items.Add(rs("ACnumber").Value, lup)
                viewlst.SubItems.Add(rs("Idnumber").Value)
                viewlst.SubItems.Add(rs("Name").Value)
                viewlst.SubItems.Add(rs("GradeYear").Value)
                viewlst.SubItems.Add(rs("Section").Value)
                viewlst.SubItems.Add(rs("Address").Value)
                viewlst.SubItems.Add(rs("Guardian").Value)
                viewlst.SubItems.Add(rs("ContactNo").Value)
                rs.MoveNext()
            Next
        End If
    End Sub
    Function picView() As Bitmap
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSql.Execute("select PicPath from tblEmp where idNumber = '" & id & "'")
            If rs.EOF = False Then
                Try
                    Dim Img As New IO.MemoryStream(CType(rs("PicPath").Value, Byte()))
                    Return Image.FromStream(Img)
                Catch ex As Exception
                    Return Nothing
                End Try
            Else
                Return Nothing
            End If
        Catch
            EmpPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            Return Nothing
        End Try
    End Function
    Sub slct()
        Dim viewlst As New ListViewItem
        For Each viewlst In LstEmpRec.Items
            If viewlst.Selected = True Then
                id = viewlst.SubItems(0).Text
            End If
        Next
    End Sub
    Private Sub LstEmpRec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstEmpRec.SelectedIndexChanged
        slct()
        Try
            EmpPic.Image = Image.FromFile(frmPicPath.txtpath.Text & "\" & (id) & ".Jpg")
            frmNewStud.EmpPic.Image = Image.FromFile(frmPicPath.txtpath.Text & "\" & (id) & ".Jpg")
        Catch
            EmpPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            frmNewStud.EmpPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
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

    Private Sub cboCateg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCateg.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
            cboCateg.Focus()
        End If
    End Sub

    Private Sub txtInput_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInput.GotFocus
        cmdEdit.Enabled = False
        cmdDel.Enabled = False
        EmpPic.Image = Nothing
    End Sub
    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        LstEmpRec.Clear()
        header()
        Findfill()
    End Sub

    Private Sub txtInput_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInput.KeyPress
        If Asc(e.KeyChar) = 13 Then
            LstEmpRec.Clear()
            header()
            Findfill()
        End If
    End Sub
   
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        flag = "Edit"
        frmNewStud.Label9.Text = "Update Student Information"
        EmpPic.Image = Nothing
        enableTxt(frmNewStud)
        'frmNewEmployee.txtip.Text = My.Settings.DEV_Enroller
        frmNewStud.cmdBrowse.Enabled = True
        frmNewStud.cmdSubmit.Enabled = True
        frmNewStud.cmdSubmit.Text = "&Update  "
        frmNewStud.GroupBox1.Enabled = False
        edit()
        frmNewStud.txtAC.ReadOnly = True
        'Me.Close()
    End Sub
    Sub edit()
        If PingMe(Ip) = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSql.Execute("select * from tblstudInfo where ACNumber = '" & id & "'")
        If rs.EOF = False Then
            frmNewStud.txtAC.Text = rs("ACnumber").Value
            frmNewStud.txtId.Text = rs("IDnumber").Value
            frmNewStud.txtName.Text = rs("Name").Value
            frmNewStud.txtGy.Text = rs("GradeYear").Value
            frmNewStud.txtSec.Text = rs("Section").Value
            frmNewStud.txtAdd.Text = rs("Address").Value
            frmNewStud.txtGuardian.Text = rs("Guardian").Value
            frmNewStud.txtContact.Text = rs("ContactNo").Value
        End If
        frmNewStud.ShowDialog()
    End Sub
    Sub del()
        If PingMe(Ip) = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If
        Dim rs2 As New Recordset
        rs2 = New Recordset
        rs2 = conSql.Execute("delete from tblStudInfo where AcNumber = '" & id & "'")
    End Sub
    Sub delEmpPic()
        If PingMe(Ip) = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If

        Dim rs As New Recordset
        rs = New Recordset
        rs = conSql.Execute("select * from tblEmp where idNumber = '" & id & "'")
        If rs.EOF = False Then
            'Try
            EmpPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            delPic = rs("PicPath").Value
            'Catch
            'End Try
        End If
    End Sub
    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        LstEmpRec.Clear()
        header()
        fill()
        cmdEdit.Enabled = False
        cmdDel.Enabled = False
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click

        If MsgBox("Are you sure do you want to delete this record?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Delete") = vbYes Then
            'pikpath()
            clear()
            Delete_EntImage(delpath)
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

    Sub pikpath()

    End Sub
  
    Private Sub cmdImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImport.Click
        frmImport.ShowDialog()
    End Sub
End Class