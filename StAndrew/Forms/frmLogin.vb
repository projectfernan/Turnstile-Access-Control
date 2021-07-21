Public Class frmLogin
    Sub pasok()
        Dim user As String
        Dim pass As String

        user = "fernan"
        pass = "s0bad3l1g3r"

        If Trim(txtUser.Text) = user Then
            If Trim(txtPass.Text) = pass Then
                admin = txtUser.Text
                'frmMain.txtAdmin.Text = admin
                txtUser.Text = vbNullString
                txtPass.Text = vbNullString
                frmMain.AdministratorToolStripMenuItem.Enabled = True
                unlock()
                login()
                Me.Close()
                Exit Sub
            Else
                MsgBox("Unknown password!    ", vbExclamation, "Login")
                txtPass.Text = vbNullString
                txtPass.Focus()
            End If
        Else
            MsgBox("Unknown username!     ", vbExclamation, "Login")
            txtUser.Text = vbNullString
            txtPass.Text = vbNullString
            txtUser.Focus()
        End If
    End Sub
    Sub login2()
        If frmMain.StatDB.Text = "Disconnected" Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Me.Close()
            frmConDB.ShowDialog()
            Exit Sub
        End If
        Dim rs As New Recordset
        Dim nem As String

        rs = New Recordset
        rs = conSql.Execute("Select * from tblUserAcc where Username = '" & txtUser.Text & "'")
        If rs.EOF = False Then
            nem = rs("Name").Value
            desig = rs("Designation").Value

            'entsve(nem, desig)

            If desig = "User" Then
                frmMain.AdministratorToolStripMenuItem.Enabled = False
                frmMain.SystemMessageToolStripMenuItem.Enabled = False
            Else
                frmMain.AdministratorToolStripMenuItem.Enabled = True
                frmMain.SystemMessageToolStripMenuItem.Enabled = True
            End If

            If Trim(txtPass.Text) = rs("Password").Value Then
                admin = txtUser.Text
                'frmMain.txtAdmin.Text = admin
                txtUser.Text = vbNullString
                txtPass.Text = vbNullString
                unlock()
                login()
                Me.Close()
                Exit Sub
            Else
                MsgBox("Unknown password!    ", vbExclamation, "Login")
                txtPass.Text = vbNullString
                txtPass.Focus()
                Exit Sub
            End If
        Else
            MsgBox("Unknown username!     ", vbExclamation, "Login")
            txtUser.Text = vbNullString
            txtPass.Text = vbNullString
            txtUser.Focus()
            Exit Sub
        End If
    End Sub
    Sub entsve(ByVal nem As String, ByVal desig As String)
        Dim rs2 As New Recordset
        rs2 = New Recordset
        rs2.Open("select * from tblAccHistory", conSql, 1, 2)
        'ad = rs.RecordCount + 1
        rs2.AddNew()
        rs2("Username").Value = txtUser.Text
        rs2("Name").Value = nem
        rs2("Designation").Value = desig
        rs2("LogType").Value = "In"
        rs2("LogsHistory").Value = Format(Now, "General Date")
        rs2.Update()
    End Sub
    Function testadmin() As Boolean
        If txtUser.Text = "fernan" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub txtUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUser.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtPass.Focus()
        End If
    End Sub
    Private Sub txtPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPass.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If testadmin() = True Then
                pasok()
                Exit Sub
            Else
                login2()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        If testadmin() = True Then
            pasok()
            Access = "Login"
            Exit Sub
        Else
            login2()
            Exit Sub
            Access = "Login"
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub txtPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPass.TextChanged

    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    
End Class