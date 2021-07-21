﻿Module Controls
    Public read As String
    Public flag As String

    Public desig As String
    Public Idno As String
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
        frmMain.ManagementToolStripMenuItem.Enabled = False
        'frmMain.AttendanceToolStripMenuItem.Enabled = False
        frmMain.SettingsToolStripMenuItem.Enabled = False
        frmMain.ReportsToolStripMenuItem.Enabled = False
        frmMain.LogoutToolStripMenuItem.Enabled = False
    End Sub
    Public Sub unlock()
        frmMain.ManagementToolStripMenuItem.Enabled = True
        'frmMain.AttendanceToolStripMenuItem.Enabled = True
        frmMain.SettingsToolStripMenuItem.Enabled = True
        frmMain.ReportsToolStripMenuItem.Enabled = True
        frmMain.LogoutToolStripMenuItem.Enabled = True
    End Sub
    Public Sub login()
        frmMain.ToolStripMenuItem2.Enabled = False
        frmMain.CmdLogin.Enabled = False
        frmMain.cmdLogOut.Enabled = True
    End Sub
    Public Sub logout()
        frmMain.ToolStripMenuItem2.Enabled = True
        frmMain.cmdLogOut.Enabled = False
        frmMain.CmdLogin.Enabled = True
    End Sub
    Sub viewPath()
        With My.Settings
            frmPicPath.txtpath.Text = .PicPath
        End With
    End Sub
End Module
