Public Class frmAddEmp

    Private Sub frmAddEmp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtip.Text = My.Settings.Dev_Enrol2
        lblFlag.Visible = False
        lblFill.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        devconn()
    End Sub
    Sub devconn()
        If txtip.Text = vbNullString Then
            MsgBox("Please enter device IP address!    ", vbExclamation, "Connection")
            Exit Sub
        End If
        If Button1.Text = "&Connect" Then
            DevEnroller.Disconnect()
            DevEnroller.BeginInit()
            If PingMe(txtip.Text) = True Then
                If DevEnroller.Connect_Net(txtip.Text, 4370) Then
                    MsgBox("Device connected!    ", vbInformation, "Connection")
                    txtip.ReadOnly = True
                    My.Settings.Dev_Enrol2 = txtip.Text
                    My.Settings.Save()
                    'tmrRegEvent.Enabled = True
                    DevEnroller.RegEvent(1, 32767)
                    Button1.Text = "&Disconnect"
                    'lblFlag.ForeColor = Color.Green
                    'lblFlag.Visible = True
                    txtAC.Focus()
                Else
                    MsgBox("Failed to connect!    ", vbExclamation, "Connection")
                End If
            Else
                MsgBox("Failed to connect!    ", vbExclamation, "Connection")
            End If
        ElseIf Button1.Text = "&Disconnect" Then
            DevEnroller.EndInit()
            DevEnroller.Disconnect()
            Button1.Text = "&Connect"
            txtip.ReadOnly = False
            'lblFlag.Visible = False
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub DevEnroller_OnAttTransaction(ByVal sender As System.Object, ByVal e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent) Handles DevEnroller.OnAttTransaction
        If scan(e.enrollNumber) = True Then
            Exit Sub
        End If
        txtAC.Text = e.enrollNumber
        enableTxt(Me)
        lblFlag.Visible = False
        lblFill.Visible = True
        cmdBrowse.Enabled = True
        cmdSubmit.Enabled = True
        txtId.Focus()
        'cboDep()
    End Sub
    Function scan(ByVal idNO As String) As Boolean
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSql.Execute("select * from tblStudInfo where idnumber = '" & idNO & "'")
        If rs.EOF = False Then
            MsgBox("ID number already exist!    ", vbCritical, "ID Number")
            Return True
        Else
            Return False
        End If
        Exit Function
    End Function

    Private Sub cmdSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubmit.Click
        If scn() = True Then
            MsgBox("Please fill up the blanks!    ", vbExclamation, "Employee")
            Exit Sub
        End If
        IDNumber = txtAC.Text
        If flag = "Save" Then
            save()
        ElseIf flag = "Edit" Then
            edit()
        End If
    End Sub
    Function scn() As Boolean
        If txtAC.Text = vbNullString Or txtId.Text = vbNullString Or txtName.Text = vbNullString Or txtPosition.Text = vbNullString Or txtDept.Text = vbNullString Or txtAdd.Text = vbNullString Or txtContact.Text = vbNullString Then
            Return True
        Else
            Return False
        End If
    End Function
    Sub save()
        If MsgBox("Are you sure your entries are correct?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Save") = vbYes Then
            EmpPic.Image = Nothing
            If frmPicPath.txtpath.Text = vbNullString Then
                MsgBox("Please set designate picture path!    ", vbExclamation, "Save")
                frmPicPath.ShowDialog()
                Exit Sub
            End If

            If getpic(EmpPath) = True Then
            End If

            If PingMe(Ip) = True Then
                Dim rs As New Recordset
                rs = New Recordset
                rs.Open("select * from tblEmp", conSql, 1, 2)
                rs.AddNew()
                rs("ACnumber").Value = txtAC.Text
                rs("IDnumber").Value = txtId.Text
                rs("Name").Value = txtName.Text
                rs("Position").Value = txtPosition.Text
                rs("Department").Value = txtDept.Text
                rs("Address").Value = txtAdd.Text
                rs("ContactNo").Value = txtContact.Text
                rs.Update()
                
                MsgBox("New record save!    ", vbInformation, "Save")
                Me.Close()

            Else
                MsgBox("Database disconnected!    ", vbExclamation, "Save")
                frmConDB.ShowDialog()
                Exit Sub
            End If
        End If
    End Sub
    Sub edit()
        If MsgBox("Are you sure do you want to save changes?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Update") = vbYes Then
            'If picpath = vbNullString Then
            'MsgBox("Please browse a picture!", vbExclamation, "Save")
            'Exit Sub
            'End If
            EmpPic.Image = Nothing
            If frmPicPath.txtpath.Text = vbNullString Then
                MsgBox("Please set designate picture path!    ", vbExclamation, "Update")
                frmPicPath.ShowDialog()
                Exit Sub
            End If
            If getpic(EmpPath) = True Then
            End If

            If PingMe(Ip) = True Then
                Dim rs As New Recordset
                rs = New Recordset
                rs.Open("select * from tblEmp where ACnumber = '" & txtAC.Text & "'", conSql, 1, 2)
                rs("IDnumber").Value = txtId.Text
                rs("Name").Value = txtName.Text
                rs("Position").Value = txtPosition.Text
                rs("Department").Value = txtDept.Text
                rs("Address").Value = txtAdd.Text
                rs("ContactNo").Value = txtContact.Text
                rs.Update()

                MsgBox("Updated successfully!    ", vbInformation, "Update")
                txtAC.ReadOnly = False
                Me.Close()
            Else
                MsgBox("Database disconnected!    ", vbExclamation, "Update")
                frmConDB.ShowDialog()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click
        EmpPic.Image = Nothing
        OpenPath.Filter = "JPEG Images (*.jpg,*.jpeg)|*.jpg;*.jpeg"
        OpenPath.InitialDirectory = "C:\"
        OpenPath.FileName = vbNullString

        If OpenPath.ShowDialog = Windows.Forms.DialogResult.OK Then
            EmpPath = OpenPath.FileName
        End If
        On Error Resume Next
        EmpPic.Image = Image.FromFile(EmpPath)
    End Sub

    Private Sub txtContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact.KeyPress
        If Asc(e.KeyChar) >= 58 Then
            e.KeyChar = vbNullString
        End If
        If Asc(e.KeyChar) = 13 Then
            IDNumber = txtId.Text
            If flag = "Save" Then
                save()
            ElseIf flag = "Edit" Then
                edit()
            End If
        End If
    End Sub

    Private Sub txtAC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAC.KeyPress
        If Asc(e.KeyChar) = 45 And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = vbNullString
        End If
        If Asc(e.KeyChar) >= 58 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = vbNullString
        End If
        If Asc(e.KeyChar) <= 47 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub txtAC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAC.TextChanged

    End Sub

    Private Sub txtContact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContact.TextChanged

    End Sub
End Class