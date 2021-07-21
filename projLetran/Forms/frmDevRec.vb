Imports ADODB
Public Class frmDevRec

    Private Sub frmDevRec_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        With My.Settings
            .AutoConnDel = txtPingDelay.Value
            .Save()
        End With
    End Sub

    Private Sub frmDevRec_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lstList.Clear()
        header()
        fill()
    End Sub

    Sub header()
        Dim w As Integer = lstList.Width / 4
        lstList.Columns.Add("", 0, HorizontalAlignment.Left)
        lstList.Columns.Add("DeviceName", w, HorizontalAlignment.Left)
        lstList.Columns.Add("IP", w, HorizontalAlignment.Left)
        'lstList.Columns.Add("Frame", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("Status", w, HorizontalAlignment.Left)
        lstList.Columns.Add("Delay", 180, HorizontalAlignment.Left)
    End Sub

    Sub fill()
        If ConnLocdb() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database")
            Exit Sub
        End If

        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tblDevices order by ID")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                On Error Resume Next
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("Id").Value, lup)
                viewlst.SubItems.Add(rs("DeviceName").Value)
                viewlst.SubItems.Add(rs("Ip").Value)
                'viewlst.SubItems.Add(rs("Frame").Value)
                viewlst.SubItems.Add(rs("Status").Value)
                viewlst.SubItems.Add(rs("Delay").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub Findfill()
        If ConnLocdb() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database")
            Exit Sub
        End If

        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tblDevices where " & cboCateg.Text & " like '" & txtInput.Text & "%' order by ID")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                On Error Resume Next
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("Id").Value, lup)
                viewlst.SubItems.Add(rs("DeviceName").Value)
                viewlst.SubItems.Add(rs("Ip").Value)
                ' viewlst.SubItems.Add(rs("Frame").Value)
                viewlst.SubItems.Add(rs("Status").Value)
                viewlst.SubItems.Add(rs("Delay").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Private Sub cmdSearch_Click(sender As System.Object, e As System.EventArgs) Handles cmdSearch.Click
        lstList.Clear()
        header()
        Findfill()
    End Sub

    Private Sub cmdRefresh_Click(sender As System.Object, e As System.EventArgs) Handles cmdRefresh.Click
        lstList.Clear()
        header()
        fill()

        With MainControl
            .PanelDev.Controls.Clear()
            .LoadDevList()
        End With
    End Sub

    Sub clearAddDev()
        With frmAddDev
            .txtDev.Text = vbNullString
            .txtIp.Text = vbNullString
            .txtDelay.Value = 0
            '.cboFrame.Text = vbNullString
            .cboStatus.Text = vbNullString
        End With
    End Sub

    Private Sub cmdAdd_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdd.Click
        frmAddDev.Text = "New Device"
        clearAddDev()
        frmAddDev.txtDev.Enabled = True
        frmAddDev.ShowDialog()
    End Sub

    Private Sub cboCateg_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cboCateg.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cmdEdit_Click(sender As System.Object, e As System.EventArgs) Handles cmdEdit.Click
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                With frmAddDev
                    .Text = "Update Device"
                    .txtDev.Text = viewlst.SubItems(1).Text
                    .txtDev.Enabled = False
                    .txtIp.Text = viewlst.SubItems(2).Text
                    '.cboFrame.Text = viewlst.SubItems(3).Text
                    .cboStatus.Text = viewlst.SubItems(3).Text
                    .txtDelay.Value = CInt(viewlst.SubItems(4).Text)
                
                    .ShowDialog()
                End With
            End If
        Next
    End Sub

    Sub Del(devnem As String)
        If ConnLocdb() = False Then
            Exit Sub
        End If
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("Delete from tbldevices where DeviceName = '" & devnem & "'")
            lstList.Clear()
            header()
            fill()
            MsgBox("Device successfully deleted! ", vbInformation, "Delete")
        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
        End Try

    End Sub

    Private Sub cmdDel_Click(sender As System.Object, e As System.EventArgs) Handles cmdDel.Click
        If MsgBox("Are you sure do you want to delete this device? ", vbQuestion + vbYesNo + vbDefaultButton2, "Save") = vbYes Then
            Dim viewlst As New ListViewItem
            For Each viewlst In lstList.Items
                If viewlst.Selected = True Then
                    Del(viewlst.SubItems(1).Text)
                End If
            Next
        End If
    End Sub

    Private Sub frmDevRec_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        With My.Settings
            txtPingDelay.Value = .AutoConnDel
            chkPing.Checked = .AutoPing
            chkAutoClear.Checked = .AutoClear
            chkRegEvent.Checked = .AutoReg
        End With
    End Sub

    Private Sub lstList_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstList.SelectedIndexChanged

    End Sub

    Private Sub cboCateg_Click(sender As System.Object, e As System.EventArgs) Handles cboCateg.Click

    End Sub

    Private Sub chkPing_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPing.CheckedChanged
        My.Settings.AutoPing = chkPing.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkAutoClear_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkAutoClear.CheckedChanged
        My.Settings.AutoClear = chkAutoClear.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkRegEvent_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkRegEvent.CheckedChanged
        My.Settings.AutoReg = chkRegEvent.Checked
        My.Settings.Save()
    End Sub
End Class