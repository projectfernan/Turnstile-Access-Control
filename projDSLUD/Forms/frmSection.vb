﻿Public Class frmSection

    Private Sub frmSection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Gy(cboGy)
        lstList.Clear()
        header()
        fill()
    End Sub

    Sub Gy(ByVal cbo As ComboBox)

        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, Me.Text)
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = conSql.Execute("SELECT * from tblgradeyear")

        If rs.EOF = True Then
            MsgBox("Please set grade/year level!    ", vbExclamation, Me.Text)
            frmEduLevel.ShowDialog()
            Exit Sub
        End If

        While rs.EOF = False
            cbo.Items.Add(rs("GradeYear").Value)
            rs.MoveNext()
        End While
    End Sub

    Sub header()
        lstList.Columns.Add("Section", 150, HorizontalAlignment.Left)
        lstList.Columns.Add("Grade/Year", 190, HorizontalAlignment.Left)
    End Sub

    Sub fill()
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If

        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSql.Execute("select * from tblSection")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("Section").Value, lup)
                viewlst.SubItems.Add(rs("GradeYear").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Function chkRS(ByVal id As String) As Boolean
        Dim rs As New Recordset
        rs = conSql.Execute("select * from tblSection where Section = '" & id & "'")
        If rs.EOF = False Then
            Return False
        Else
            Return True
        End If
    End Function

    Sub save()
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If

        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblSection", conSql, 1, 2)
        rs.AddNew()
        rs("Section").Value = txtSec.Text
        rs("GradeYear").Value = cboGy.Text
        rs.Update()
    End Sub

    Sub del(ByVal id As String)
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            Exit Sub
        End If

        Dim rs As New Recordset
        rs = conSql.Execute("delete from tblSection where Section = '" & id & "'")
        MsgBox("Record successfully deleted!", vbInformation, "Delete")
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If cboGy.Text = vbNullString Or txtSec.Text = vbNullString Then
            MsgBox("Please fill up the blanks!    ", vbExclamation)
            Exit Sub
        End If

        If chkRS(txtSec.Text) = False Then
            MsgBox("Section already exist!    ", vbExclamation, "Add")
            txtSec.Text = vbNullString
            txtSec.Focus()
            Exit Sub
        End If

        save()
        lstList.Clear()
        header()
        fill()
        cboGy.Text = vbNullString
        txtSec.Text = vbNullString
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

    Private Sub txtSec_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSec.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cboGy.Text = vbNullString Or txtSec.Text = vbNullString Then
                MsgBox("Please fill up the blanks!    ", vbExclamation)
                Exit Sub
            End If

            If chkRS(txtSec.Text) = False Then
                MsgBox("Section already exist!    ", vbExclamation, "Add")
                txtSec.Text = vbNullString
                txtSec.Focus()
                Exit Sub
            End If

            save()
            lstList.Clear()
            header()
            fill()
            cboGy.Text = vbNullString
            txtSec.Text = vbNullString
        End If
    End Sub

End Class