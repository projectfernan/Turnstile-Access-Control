Public Class frmLogin
    Sub pasok()
        Dim user As String
        Dim pass As String

        user = "fernan"
        pass = "s0bad3l1g3r"

        If Trim(txtUser.Text) = user Then
            If Trim(txtPass.Text) = pass Then
                txtUser.Text = vbNullString
                txtPass.Text = vbNullString
                With MainSystem
                    .txtSystemUser.Text = user
                    .txtDesig.Text = "Admin:"
                End With
                Me.Visible = False
                frmSystem.ShowDialog()
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
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Me.Close()
            frmConDB.ShowDialog()
            Exit Sub
        End If
        Dim rs As New Recordset

        rs = New Recordset
        rs = conSql.Execute("Select * from tblUserAcc where Username = '" & txtUser.Text & "'")
        If rs.EOF = False Then
            If Trim(txtPass.Text) = rs("Password").Value Then
                With MainSystem
                    .txtSystemUser.Text = rs("Name").Value
                    .txtDesig.Text = rs("Designation").Value & ":"
                    txtUser.Text = vbNullString
                    txtPass.Text = vbNullString
                    Me.Visible = False
                    frmSystem.ShowDialog()
                    Me.Close()
                End With
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

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmLogin_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If testadmin() = True Then
                pasok()
                Access = "Login"
                Exit Sub
            Else
                login2()
                Exit Sub
                Access = "Login"
            End If
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmLogin_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        txtUser.Text = vbNullString
        txtPass.Text = vbNullString
        txtUser.Focus()
    End Sub

    Private Sub frmLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class