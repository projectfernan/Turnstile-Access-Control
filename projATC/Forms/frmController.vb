Imports ADODB
Public Class frmController

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        frmFindControler.ShowDialog()
    End Sub

    Private Sub frmController_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkHex.Checked = My.Settings.HexRead
        lstList.Clear()
        Header()
        If subSQlLoc() = True Then
            fill()
        End If
    End Sub

    Sub Header()
        lstList.Columns.Clear()
        lstList.Columns.Add("ID", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("NodeName", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("Serial Number", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("IP Address", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("Port", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("MAC Address", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("Subnet Mask", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("Gateway", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("Lane", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("", 0, HorizontalAlignment.Left)
        lstList.Columns.Add("", 0, HorizontalAlignment.Left)

        'lstList.Columns.Add("CamIP", 180, HorizontalAlignment.Left)
        'lstList.Columns.Add("CamUID", 180, HorizontalAlignment.Left)
        'lstList.Columns.Add("", 0, HorizontalAlignment.Left)
        'lstList.Columns.Add("CamPort", 180, HorizontalAlignment.Left)
        'lstList.Columns.Add("Cam1", 180, HorizontalAlignment.Left)
        'lstList.Columns.Add("Capture1", 180, HorizontalAlignment.Left)
        'lstList.Columns.Add("Cam2", 180, HorizontalAlignment.Left)
        'lstList.Columns.Add("Capture2", 180, HorizontalAlignment.Left)

    End Sub

    Sub fill()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tblcontroler")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("Id").Value, lup)
                viewlst.SubItems.Add(rs("NodeName").Value)
                viewlst.SubItems.Add(rs("SN").Value)
                viewlst.SubItems.Add(rs("Ip").Value)
                viewlst.SubItems.Add(rs("Port").Value)
                viewlst.SubItems.Add(rs("MacAdd").Value)
                viewlst.SubItems.Add(rs("Subnet").Value)
                viewlst.SubItems.Add(rs("Gateway").Value)
                viewlst.SubItems.Add(rs("Lane").Value)
                viewlst.SubItems.Add(rs("PCip").Value)
                viewlst.SubItems.Add(rs("Stat").Value)

                'viewlst.SubItems.Add(rs("Cam_Ip").Value)
                'viewlst.SubItems.Add(rs("Cam_User").Value)
                'viewlst.SubItems.Add(rs("Cam_Pass").Value)
                'viewlst.SubItems.Add(rs("Cam_Port").Value)
                'viewlst.SubItems.Add(rs("Cam1").Value)
                'viewlst.SubItems.Add(rs("Cam_Cap1").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub find()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tblcontroler where " & cboCateg.Text & "like '%" & txtKeycode.Text & "'%")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("Id").Value, lup)
                viewlst.SubItems.Add(rs("NodeName").Value)
                viewlst.SubItems.Add(rs("SN").Value)
                viewlst.SubItems.Add(rs("Ip").Value)
                viewlst.SubItems.Add(rs("Port").Value)
                viewlst.SubItems.Add(rs("MacAdd").Value)
                viewlst.SubItems.Add(rs("Subnet").Value)
                viewlst.SubItems.Add(rs("Gateway").Value)
                viewlst.SubItems.Add(rs("Lane").Value)
                viewlst.SubItems.Add(rs("PCip").Value)
                viewlst.SubItems.Add(rs("Stat").Value)

                'viewlst.SubItems.Add(rs("Cam_Ip").Value)
                'viewlst.SubItems.Add(rs("Cam_User").Value)
                'viewlst.SubItems.Add(rs("Cam_Pass").Value)
                'viewlst.SubItems.Add(rs("Cam_Port").Value)
                'viewlst.SubItems.Add(rs("Cam1").Value)
                'viewlst.SubItems.Add(rs("Cam_Cap1").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        frmAddController.Text = "Update Controller"
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                With frmAddController
                    .txtNodeName.Text = viewlst.SubItems(1).Text
                    .txtSN.Text = viewlst.SubItems(2).Text
                    .txtIP.Text = viewlst.SubItems(3).Text
                    .txtPort.Text = viewlst.SubItems(4).Text
                    .txtMack.Text = viewlst.SubItems(5).Text
                    .txtSubnet.Text = viewlst.SubItems(6).Text
                    .cboLane.Text = viewlst.SubItems(8).Text
                    .txtGateway.Text = viewlst.SubItems(7).Text
                    PCip = viewlst.SubItems(9).Text

                    If viewlst.SubItems(10).Text = 1 Then
                        .chkAuto.Checked = True
                    Else
                        .chkAuto.Checked = False
                    End If
                    .txtNodeName.Focus()
                    .ShowDialog()
                End With
            End If
        Next
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                If MsgBox("Are you sure do you want to delete this controller? ", vbYesNo + vbQuestion + vbDefaultButton2, "Delete") = vbYes Then
                    delControler(viewlst.SubItems(2).Text)
                    lstList.Clear()
                    Header()
                    fill()
                End If
            End If
        Next
    End Sub

    Sub delControler(ByVal sn As String)
        If subsqlloc() = False Then Exit Sub

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("delete from tblcontroler where SN = '" & sn & "'")
            MsgBox("Controller successfully deleted! ", vbInformation, "Delete")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        lstList.Clear()
        Header()
        If subsqlloc() = True Then
            fill()
        End If
    End Sub

    Private Sub cmdUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpload.Click
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                uplod_SN = viewlst.SubItems(2).Text
                uplod_IP = viewlst.SubItems(3).Text
                uplod_Port = viewlst.SubItems(4).Text
                frmUpload.ShowDialog()
            End If
        Next
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        lstList.Clear()
        Header()
        If subsqlloc() = True Then
            find()
        End If
    End Sub

    Private Sub cboCateg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCateg.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub lstList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstList.SelectedIndexChanged
       
    End Sub

    Private Sub chkHex_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHex.CheckedChanged
        My.Settings.HexRead = chkHex.Checked
        My.Settings.Save()
    End Sub
End Class