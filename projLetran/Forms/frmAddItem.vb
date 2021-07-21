Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports ADODB
Public Class frmAddItem
    Sub saveItm()
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Save")
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs.Open("select * from tblitems", conSql, 1, 2)
            rs.AddNew()
            rs("CardCode").Value = txtCardCode.Text
            rs("ItemName").Value = txtItemName.Text
            rs("SerialNo").Value = txtSerial.Text
            rs("Model").Value = txtModel.Text
            rs("Category").Value = cboCateg.Text
            rs("Idnumber").Value = frmNewStud.txtId.Text
            rs.Update()
            MsgBox("New item Added!    ", vbInformation, "Save")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Save")
        End Try
    End Sub

    Sub UpdateItm(ByVal cod As String)
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, "Save")
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs.Open("select * from tblitems where CardCode = '" & cod & "'", conSql, 1, 2)
            rs("ItemName").Value = txtItemName.Text
            rs("SerialNo").Value = txtSerial.Text
            rs("Model").Value = txtModel.Text
            rs("Category").Value = cboCateg.Text
            rs("Idnumber").Value = frmNewStud.txtId.Text
            rs.Update()
            MsgBox("Item updated!    ", vbInformation, "Save")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Update")
        End Try
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        With frmNewStud
            Select Case Me.Text
                Case "Add Item"
                    saveItm()
                    .lstItem.Clear()
                    headerItm(.lstItem)
                    fillItems(.lstItem, .txtId.Text)
                    Me.Close()
                Case "Update Item"
                    UpdateItm(txtCardCode.Text)
                    .lstItem.Clear()
                    headerItm(.lstItem)
                    fillItems(.lstItem, .txtId.Text)
                    Me.Close()
            End Select
        End With
    End Sub

    Sub ItemCateg(ByVal cbo As ComboBox)

        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, Me.Text)
            frmConDB.ShowDialog()
            Exit Sub
        End If

        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = conSql.Execute("SELECT * from tblitemcateg")

        If rs.EOF = True Then
            MsgBox("Please set section!    ", vbExclamation, Me.Text)
            frmEduLevel.ShowDialog()
            Exit Sub
        End If

        While rs.EOF = False
            cbo.Items.Add(rs("ItemCateg").Value)
            rs.MoveNext()
        End While
    End Sub

    Private Sub frmAddItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conServer() = False Then
            MsgBox("Please connect to server!    ", vbExclamation, Me.Text)
            frmConDB.ShowDialog()
            Exit Sub
        End If

        ItemCateg(cboCateg)
    End Sub

    Private Sub cboCateg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCateg.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Sub read()
        Dim ret As Integer
        Dim card As String
        Dim mCard As String
        Dim direct(1) As Byte
        mCard = "00000000000"

        ret = query_statusB(Addr, mCard, direct(0)) 'query(Addr);

        If ret = 3 Then
            'tmrRid.Enabled = False
            Exit Sub
        End If

        If ret = 1 Then 'read card
            card = VB.Left(mCard, InStr(mCard, Chr(0)) - 1)
            direct(0) = direct(0) And &H3F
            txtCardCode.Text = cardCod(card)
        End If
    End Sub

    Private Sub tmrRid_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRid.Tick
        read()
    End Sub

    Private Sub cboCateg_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCateg.SelectedIndexChanged

    End Sub
End Class