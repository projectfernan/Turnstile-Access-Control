Public Class frmAddDev

    Private Sub cmdSave_Click(sender As System.Object, e As System.EventArgs) Handles cmdSave.Click
        If Me.Text = "New Device" Then
            If ChkDevName(txtDev.Text) = True Then
                MsgBox("Device name already exist! ", vbExclamation, "Save")
                Exit Sub
            End If

            If MsgBox("Are you sure entries are correct? ", vbYesNo + vbDefaultButton2 + vbQuestion, "Save") = vbYes Then
                Save()
            End If
        ElseIf Me.Text = "Update Device" Then
            UpdateDev(txtDev.Text)
        End If
    End Sub

    Function ChkDevName(DevNem As String) As Boolean
        If conServer() = False Then
            Return False
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSql.Execute("select * from tbldevices where DeviceName = '" & DevNem & "' ")
            If rs.EOF = False Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Sub Save()
        If conServer() = False Then
            Exit Sub
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from tbldevices", conSql, 1, 2)
            rs.AddNew()
            rs("DeviceName").Value = txtDev.Text
            rs("Ip").Value = txtIp.Text
            rs("Frame").Value = cboFrame.Text
            rs("Status").Value = cboStatus.Text
            rs("Delay").Value = txtDelay.Value
            rs.Update()

            MsgBox("Successfully saved! ", vbInformation, "Save")
            Me.Close()
        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
        End Try

    End Sub

    Sub UpdateDev(DevName As String)
        If conServer() = False Then
            Exit Sub
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from tbldevices where DeviceName = '" & DevName & "'", conSql, 1, 2)
            rs("Ip").Value = txtIp.Text
            rs("Frame").Value = cboFrame.Text
            rs("Status").Value = cboStatus.Text
            rs("Delay").Value = txtDelay.Value
            rs.Update()
            MsgBox("Updated successfully! ", vbInformation, "Save")
            Me.Close()
        Catch ex As Exception
            MainSystem.txtSystemErr.Text = ex.Message
        End Try

    End Sub
End Class