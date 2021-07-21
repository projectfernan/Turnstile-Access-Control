Imports ADODB
Public Class frmItemsRec

    Private Sub frmItemsRec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clearData()
        lstItem.Clear()
        header(lstItem)
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If
        fill(lstItem)
    End Sub

    Public Sub header(ByVal lst As ListView)
        lst.Columns.Add("ID", 90, HorizontalAlignment.Left)
        lst.Columns.Add("CardCode", 150, HorizontalAlignment.Left)
        lst.Columns.Add("ItemName", 200, HorizontalAlignment.Left)
        lst.Columns.Add("SerialNo", 150, HorizontalAlignment.Left)
        lst.Columns.Add("Model", 150, HorizontalAlignment.Left)
        lst.Columns.Add("Category", 150, HorizontalAlignment.Left)
        lst.Columns.Add("IDnumber", 150, HorizontalAlignment.Left)
    End Sub

    Public Sub fill(ByVal lst As ListView)
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If
        'LstEmpRec.Clear()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSql.Execute("select * from tblitems")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lst.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lst.Items.Add(rs("ID").Value, lup)
                viewlst.SubItems.Add(rs("CardCode").Value)
                viewlst.SubItems.Add(rs("ItemName").Value)
                viewlst.SubItems.Add(rs("SerialNo").Value)
                viewlst.SubItems.Add(rs("Model").Value)
                viewlst.SubItems.Add(rs("Category").Value)
                viewlst.SubItems.Add(rs("Idnumber").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Public Sub fillFind(ByVal lst As ListView)
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If
        'LstEmpRec.Clear()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSql.Execute("select * from tblitems where " & cboCateg.Text & " like '" & txtInput.Text & "%'")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lst.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lst.Items.Add(rs("ID").Value, lup)
                viewlst.SubItems.Add(rs("CardCode").Value)
                viewlst.SubItems.Add(rs("ItemName").Value)
                viewlst.SubItems.Add(rs("SerialNo").Value)
                viewlst.SubItems.Add(rs("Model").Value)
                viewlst.SubItems.Add(rs("Category").Value)
                viewlst.SubItems.Add(rs("Idnumber").Value)
                rs.MoveNext()
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

    Private Sub lstItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstItem.SelectedIndexChanged
        Dim viewlst As New ListViewItem
        For Each viewlst In lstItem.Items
            If viewlst.Selected = True Then
                imgStud.Image = StudentPic(viewlst.SubItems(6).Text)
                viewStud(viewlst.SubItems(6).Text)
            End If
        Next
    End Sub

    Private Sub cboCateg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCateg.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
            cboCateg.Focus()
        End If
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        clearData()
        lstItem.Clear()
        header(lstItem)
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If
        fill(lstItem)
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        lstItem.Clear()
        header(lstItem)
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If
        fillFind(lstItem)
    End Sub

    Private Sub txtInput_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInput.GotFocus
        clearData()
    End Sub

    Private Sub txtInput_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdSearch_Click(sender, New System.EventArgs)
        End If
    End Sub

End Class