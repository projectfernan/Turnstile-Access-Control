Module Controls
    Public read As String
    Public flag As String

    Public EnrolNumber As String = vbNullString
    Public desig As String
    Public Sub ClearTextBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearTextBox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl
    End Sub
    Public Sub scan(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            scan(ctrl)
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                If ctrl.Text = vbNullString Then
                    read = "on"
                End If
            End If
        Next ctrl
    End Sub
    Public Sub DisableTxt(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            DisableTxt(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Enabled = False
            End If
            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).Enabled = False
            End If
        Next ctrl
    End Sub
    Public Sub enableTxt(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            enableTxt(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Enabled = True
            End If
            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).Enabled = True
            End If
        Next ctrl
    End Sub

    Public Sub enableCmd(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            enableCmd(ctrl)
            If TypeOf ctrl Is Button Then
                CType(ctrl, Button).Enabled = True
            End If
        Next ctrl
    End Sub
    Public Sub disableCmd(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            enableCmd(ctrl)
            If TypeOf ctrl Is Button Then
                CType(ctrl, Button).Enabled = False
            End If
        Next ctrl
    End Sub

    Public Sub lock()
        With MainSystem
            .ManagementToolStripMenuItem.Enabled = False
            'frmMain.AttendanceToolStripMenuItem.Enabled = False
            .SettingsToolStripMenuItem.Enabled = False
            .ReportsToolStripMenuItem.Enabled = False
            .LogoutToolStripMenuItem.Enabled = False
        End With
    End Sub
    Public Sub unlock()
        With MainSystem
            .ManagementToolStripMenuItem.Enabled = True
            'frmMain.AttendanceToolStripMenuItem.Enabled = True
            .SettingsToolStripMenuItem.Enabled = True
            .ReportsToolStripMenuItem.Enabled = True
            .LogoutToolStripMenuItem.Enabled = True
        End With
    End Sub

    Public Sub login()
        MainSystem.ToolStripMenuItem2.Enabled = False
    End Sub

    Public Sub logout()
        MainSystem.ToolStripMenuItem2.Enabled = True
    End Sub

    Public Sub SystemLocked()
        moraytaMain.PanelDev.Enabled = False
    End Sub

    Public Sub SysAdmin()
        moraytaMain.PanelDev.Enabled = True
        With frmControlPanel
            .cmdSettings.Enabled = True
            .cmdAcc.Enabled = True
            .cmdEmp.Enabled = True
            .cmdReport.Enabled = True
            .cmdAbout.Enabled = True
            .cmdTerminate.Enabled = True
        End With
    End Sub

    Public Sub SysUser()
        moraytaMain.PanelDev.Enabled = True
        With frmControlPanel
            .cmdSettings.Enabled = False
            .cmdAcc.Enabled = False
            .cmdEmp.Enabled = True
            .cmdReport.Enabled = True
            .cmdAbout.Enabled = True
            .cmdTerminate.Enabled = False
        End With
    End Sub

    Public Sub saveAudiUpdate(ByVal sysUser As String, ByVal SysPosi As String, ByVal modi As String)

        Dim dtngaun As String = Format(Now, "yyyy-MM-dd HH:mm:ss")

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("insert into tblauditlogs(Username,Designation,DateModified,Actions)values('" & sysUser & "','" & SysPosi & "','" & dtngaun & "','" & modi & "')")
        Catch ex As Exception
            'frmMain.txtSystemErr.Text = ex.Message
        End Try
    End Sub

End Module
