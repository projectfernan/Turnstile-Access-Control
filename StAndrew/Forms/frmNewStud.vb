Imports ADODB
Public Class frmNewStud
    Private Sub cmdSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubmit.Click
        If scn() = True Then
            MsgBox("Please fill up the blanks!    ", vbExclamation, "Student")
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
        If txtAC.Text = vbNullString Or txtId.Text = vbNullString Or txtName.Text = vbNullString Or txtGy.Text = vbNullString Or txtSec.Text = vbNullString Or txtAdd.Text = vbNullString Or txtGuardian.Text = vbNullString Or txtContact.Text = vbNullString Then
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
                rs.Open("select * from tblStudInfo", conSql, 1, 2)
                rs.AddNew()
                rs("ACnumber").Value = txtAC.Text
                rs("IDnumber").Value = txtId.Text
                rs("Name").Value = txtName.Text
                rs("GradeYear").Value = txtGy.Text
                rs("Section").Value = txtSec.Text
                rs("Address").Value = txtAdd.Text
                rs("Guardian").Value = txtGuardian.Text
                rs("ContactNo").Value = txtContact.Text
                rs.Update()
                'On Error Resume Next
                Dim rs2 As New ADODB.Recordset
                rs2 = New Recordset
                rs2.Open("select * from tblcbosec", conSql, 1, 2)
                Try
                    rs2.AddNew()
                    rs2("Gy").Value = txtGy.Text
                    rs2("Sec").Value = txtSec.Text
                    rs2.Update()
                Catch
                End Try
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
                rs.Open("select * from tblStudInfo where ACnumber = '" & txtAC.Text & "'", conSql, 1, 2)
                rs("IDnumber").Value = txtId.Text
                rs("Name").Value = txtName.Text
                rs("GradeYear").Value = txtGy.Text
                rs("Section").Value = txtSec.Text
                rs("Address").Value = txtAdd.Text
                rs("Guardian").Value = txtGuardian.Text
                rs("ContactNo").Value = txtContact.Text
                rs.Update()

                'tblCboSec Update
                Dim rs2 As New ADODB.Recordset
                rs2 = New Recordset
                rs2.Open("select * from tblcbosec where Sec = '" & txtSec.Text & "'", conSql, 1, 2)
                Try
                    If rs2.EOF = False Then
                        rs2("Gy").Value = txtGy.Text
                        rs2.Update()
                    Else
                        rs2.AddNew()
                        rs2("Gy").Value = txtGy.Text
                        rs2("Sec").Value = txtSec.Text
                        rs2.Update()
                    End If
                Catch
                End Try

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
        cboDep()
    End Sub

    Private Sub tmrRegEvent_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRegEvent.Tick
        DevEnroller.RegEvent(1, 32767)
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
                    My.Settings.DEV_Enroller = txtip.Text
                    My.Settings.Save()
                    'tmrRegEvent.Enabled = True
                    DevEnroller.RegEvent(1, 32767)
                    Button1.Text = "&Disconnect"
                    'lblFlag.ForeColor = Color.Green
                    'lblFlag.Visible = True
                Else
                    MsgBox("Failed to connect!    ", vbExclamation, "Connection")
                End If
            Else
                MsgBox("Failed to connect!    ", vbExclamation, "Connection")
            End If
        ElseIf Button1.Text = "&Disconnect" Then
            DevEnroller.EndInit()
            DevEnroller.Disconnect()
            tmrRegEvent.Enabled = False
            Button1.Text = "&Connect"
            txtip.ReadOnly = False
            'lblFlag.Visible = False
        End If
    End Sub

    Private Sub frmNewEmployee_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmStudent.cmdEdit.Enabled = False
        frmStudent.cmdDel.Enabled = False
    End Sub

    Private Sub frmEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'stopread()
        'frmMain.StatDev1.Text = "Disconnected"
        '.StatDev1.ForeColor = Color.Maroon
        'frmMain.StatDev2.Text = "Disconnected"
        'frmMain.StatDev2.ForeColor = Color.Maroon
        txtip.Text = My.Settings.DEV_Enroller
        lblFlag.Visible = False
        lblFill.Visible = False
    End Sub

    Private Sub txtip_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtip.TextChanged

    End Sub
    Sub cboDep()
        Dim rs As New Recordset
        Dim str As String
        rs = New Recordset
        rs = conSql.Execute("SELECT Department from tblDept")
        While rs.EOF = False
            str = rs("Department").Value
            'cboDept.Items.Add(str)
            'txtName.Text = rs("OwnerName").Value
            rs.MoveNext()
        End While
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
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

    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtGy.Focus()
        End If
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub txtPosition_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGy.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtSec.Focus()
        End If
    End Sub

    Private Sub txtPosition_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGy.TextChanged

    End Sub

    Private Sub txtSec_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSec.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtAdd.Focus()
        End If
    End Sub

    Private Sub txtContact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSec.TextChanged

    End Sub

    Private Sub txtSSS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGuardian.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtContact.Focus()
        End If
    End Sub

    Private Sub txtGuardian_MarginChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGuardian.MarginChanged

    End Sub

    Private Sub txtSSS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGuardian.TextChanged

    End Sub

    Private Sub txtContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact.KeyPress
        If Len(txtContact.Text) = 0 And Asc(e.KeyChar) = 45 Then
            e.KeyChar = vbNullString
        End If
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

    Private Sub txtContact_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtContact.MouseClick

    End Sub

    Private Sub txtPhP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContact.TextChanged
        
    End Sub

    Private Sub txtTin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            'cboDept.Focus()
        End If
    End Sub

    Private Sub txtTin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cboDept_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then

        End If
    End Sub

    Private Sub cboDept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        IDNumber = txtId.Text
        If flag = "Save" Then
            save()
        ElseIf flag = "Edit" Then
            edit()
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtId.KeyPress
        If Len(txtContact.Text) = 0 And Asc(e.KeyChar) = 45 Then
            e.KeyChar = vbNullString
        End If
        If Asc(e.KeyChar) >= 58 Then
            e.KeyChar = vbNullString
        End If
        If Asc(e.KeyChar) = 13 Then
            txtName.Focus()
        End If
    End Sub

    Private Sub txtId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtId.TextChanged

    End Sub

    Private Sub txtAdd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAdd.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtGuardian.Focus()
        End If
    End Sub

    Private Sub txtAC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAC.KeyPress
        If Asc(e.KeyChar) >= 58 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = vbNullString
        End If
        If Asc(e.KeyChar) <= 47 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = vbNullString
        End If
        If Asc(e.KeyChar) = 13 Then
            txtId.Focus()
        End If
    End Sub

    Private Sub txtAC_MarginChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAC.MarginChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAC.TextChanged

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub
End Class