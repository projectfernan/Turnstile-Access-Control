Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports WG3000_COMM.Core
Imports ADODB

Public Class frmFindControler

    Sub Header()
        lstList.Columns.Clear()
        lstList.Columns.Add("Serial Number", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("IP Address", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("Mask", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("Gateway", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("Port", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("MAC Address", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("PC IP", 180, HorizontalAlignment.Left)
    End Sub

    Sub FindController()
        Dim Clist As New ArrayList
        controler = New wgMjController
        controler.SearchControlers(Clist)

        lstList.Clear()
        Header()

        If Clist.Count <> 0 Then
            Dim conf As New wgMjControllerConfigure
            Dim cnt As Integer
            For cnt = 0 To Clist.Count - 1
                conf = Clist.Item(cnt)
                If chkController(conf.controllerSN.ToString) = False Then
                    lstList.Refresh()
                    Dim viewlst As New ListViewItem
                    viewlst = lstList.Items.Add(conf.controllerSN.ToString)
                    viewlst.SubItems.Add(conf.ip.ToString)
                    viewlst.SubItems.Add(conf.mask.ToString)
                    viewlst.SubItems.Add(conf.gateway.ToString)
                    viewlst.SubItems.Add(conf.port.ToString)
                    viewlst.SubItems.Add(conf.MACAddr)
                    viewlst.SubItems.Add(conf.pcIPAddr)
                    txtStat.Text = "Controller found!"
                Else
                    txtStat.Text = "No controller found!"
                End If
            Next cnt

        Else
            txtStat.Text = "No Controller found!"
        End If
    End Sub

    Function chkController(ByVal sn As String) As Boolean
        If subsqlloc() = False Then Return False

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("select * from tblcontroler where SN = '" & sn & "'")
            If rs.EOF = False Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        txtStat.Text = "Please wait for about 5 seconds..."
        FindController()
    End Sub

    Private Sub frmFindControler_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lstList.Clear()
        Header()
        txtStat.Text = "Please wait for about 5 seconds..."
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        frmAddController.Text = "Add Controller"
        frmAddController.chkAuto.Checked = False
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                With frmAddController
                    .txtNodeName.Text = vbNullString
                    .txtSN.Text = viewlst.SubItems(0).Text
                    .txtIP.Text = viewlst.SubItems(1).Text

                    .txtSubnet.Text = viewlst.SubItems(2).Text
                    .txtGateway.Text = viewlst.SubItems(3).Text
                    .txtPort.Text = viewlst.SubItems(4).Text
                    .txtMack.Text = viewlst.SubItems(5).Text
                    PCip = viewlst.SubItems(6).Text
                    .txtNodeName.Focus()
                    .ShowDialog()
                    Me.Close()
                End With
            End If
        Next
    End Sub
End Class