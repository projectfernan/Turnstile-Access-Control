Public Class frmVehicle

    Sub header()
        lstList.Columns.Add("Vehicle Type", 275, HorizontalAlignment.Left)
    End Sub

    Sub fill()
        If subSQl() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If

        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSql.Execute("select * from tblvehicletype")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("VehicleType").Value, lup)
                rs.MoveNext()
            Next
        End If
    End Sub

    Function chkRS(ByVal id As String) As Boolean
        Dim rs As New Recordset
        rs = conSql.Execute("select * from tblvehicletype where VehicleType = '" & id & "'")
        If rs.EOF = False Then
            Return False
        Else
            Return True
        End If
    End Function

    Sub save()
        If subSQl() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If

        If chkRS(txtVehicle.Text) = False Then
            MsgBox("Vehicle type already exist!    ", vbExclamation, "Add")
            txtVehicle.Text = vbNullString
            txtVehicle.Focus()
            Exit Sub
        End If

        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblvehicletype", conSql, 1, 2)
        rs.AddNew()
        rs("VehicleType").Value = txtVehicle.Text
        rs.Update()
    End Sub

    Sub del(ByVal id As String)
        If subSQl() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If

        Dim rs As New Recordset
        rs = conSql.Execute("delete from tblvehicletype where VehicleType = '" & id & "'")
        MsgBox("Record successfully deleted!", vbInformation, "Delete")
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If txtVehicle.Text = vbNullString Then
            MsgBox("Please fill the blank!    ", vbExclamation, "Add")
            txtVehicle.Focus()
            Exit Sub
        End If

        If chkRS(txtVehicle.Text) = False Then
            MsgBox("Vehicle Type already exist!    ", vbExclamation, "Add")
            txtVehicle.Text = vbNullString
            txtVehicle.Focus()
            Exit Sub
        End If

        save()
        lstList.Clear()
        header()
        fill()
        txtVehicle.Text = vbNullString
    End Sub

    Private Sub frmVehicle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If subSQl() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If

        lstList.Clear()
        header()
        fill()
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                If MsgBox("Are you sure do you want to delete this record?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Delete") = vbYes Then
                    del(viewlst.SubItems(0).Text)
                    lstList.Clear()
                    header()
                    fill()
                End If
            End If
        Next
    End Sub

    Private Sub txtVehicle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVehicle.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdAdd_Click(sender, New System.EventArgs)
        End If
    End Sub

    Private Sub txtVehicle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVehicle.TextChanged

    End Sub
End Class