Imports System.Threading
Imports System.IO
Imports System.IO.File
Imports System.Diagnostics
Imports ADODB
Module AddPic

    Public StrPicFolder As String = Application.StartupPath & "\EmpPic"
    Public StrCapFolder As String = Application.StartupPath & "\EntryCap"
    Public StrCapExtFolder As String = Application.StartupPath & "\ExtCap"
    Public EntPicOutFolder As String = Application.StartupPath & "\EntPicOut"
    Public PicBackUp As String = Application.StartupPath & "\PicUp"
    Public noimage As String
    Public StrPicFile As String
    Public picpath As String
    Public IDNumber As String
    Public idLog As String
    Public idLog2 As String
    Public EmpPath As String

    Public Function getpic(ByVal path As String) As Boolean
        Try
            If Not Directory.Exists(StrPicFolder) Then
                Directory.CreateDirectory(StrPicFolder)
            End If
            If Not Directory.Exists(PicBackUp) Then
                Directory.CreateDirectory(PicBackUp)
            End If
            If System.IO.File.Exists(path) Then
                StrPicFile = Application.StartupPath & "\EmpPic\" & (IDNumber) & ".Jpg"
                'If System.IO.File.Exists(StrPicFile) Then
                'Thread.Sleep(0)
                'System.IO.File.Delete(StrPicFile)
                'System.IO.File.Copy(path, StrPicFile)
                ' Else
                'System.IO.File.Copy(path, StrPicFile)
                'End If
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            Return False
        End Try
    End Function

    Public Function CapPic(ByVal path As String) As Boolean
        Try
            If Not Directory.Exists(StrCapFolder) Then
                Directory.CreateDirectory(StrCapFolder)
            End If
            If System.IO.File.Exists(path) Then
                StrPicFile = Application.StartupPath & "\EntryCap\" & idLog & ".Jpg"
                If System.IO.File.Exists(StrPicFile) Then
                    'System.IO.File.Delete(StrPicFile)
                    'System.IO.File.Copy(path, StrPicFile)
                Else
                    System.IO.File.Copy(path, StrPicFile)
                End If
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            Return False
        End Try
    End Function

    Public Function CapPicOut(ByVal path As String) As Boolean
        Try
            If Not Directory.Exists(StrCapExtFolder) Then
                Directory.CreateDirectory(StrCapExtFolder)
            End If
            If System.IO.File.Exists(path) Then
                StrPicFile = Application.StartupPath & "\ExtCap\" & idLog & ".Jpg"
                If System.IO.File.Exists(StrPicFile) Then
                    'System.IO.File.Delete(StrPicFile)
                    'System.IO.File.Copy(path, StrPicFile)
                    'FileCopy(path, StrPicFile)
                Else
                    System.IO.File.Copy(path, StrPicFile)
                End If
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            Return False
        End Try
    End Function

    Public Sub Delete_Image()
        If Directory.Exists(Application.StartupPath & "\EntCapture") = True Then
            Directory.Delete(Application.StartupPath & "\EntCapture", True)
        End If
    End Sub

    Public Sub Delete_ImageIn(ByVal Foldername As String)
        If Directory.Exists(My.Settings.CapImgPath & "\" & Foldername) = True Then
            Directory.Delete(My.Settings.CapImgPath & "\" & Foldername, True)
        End If
    End Sub

    Public Sub Delete_ImageInLogs(ByVal iDnumLog As String, ByVal Foldername As String)
        If Directory.Exists(My.Settings.CapImgPath & "\" & iDnumLog & "\" & Foldername) = True Then
            Directory.Delete(My.Settings.CapImgPath & "\" & iDnumLog & "\" & Foldername, True)
        End If
    End Sub

    Public Sub Delete_ImageExt()
        If Directory.Exists(Application.StartupPath & "\ExtCapture") = True Then
            Directory.Delete(Application.StartupPath & "\ExtCapture", True)
        End If
    End Sub

    Public Sub Delete_EntImage(ByVal entpath As String)
        On Error Resume Next
        frmEmployee.EmpPic.Image = Nothing
        frmEmployee.EmpPic.Dispose()
        ' Try
        If File.Exists(entpath) = True Then
            Kill(entpath)
        End If
        ' Catch
        ' Thread.Sleep(0)
        ' File.Delete(entpath)
        ' End Try
    End Sub

    Public Function EntPicOut(ByVal path As String) As Boolean
        Try
            If Not Directory.Exists(EntPicOutFolder) Then
                Directory.CreateDirectory(EntPicOutFolder)
            End If
            If System.IO.File.Exists(path) Then
                StrPicFile = Application.StartupPath & "\EntPicOut\Ent" & idLog & ".Jpg"
                If System.IO.File.Exists(StrPicFile) Then
                Else
                    System.IO.File.Copy(path, StrPicFile)
                End If
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            Return False
        End Try
    End Function

    Public Function Get_ImageIn(ByRef Acnumber As String) As Bitmap
        Try
            Dim rs As New Recordset
            rs = conSql.Execute("select PicPath from tblTimeIN where idlog = '" & Acnumber & "'")
            If rs.EOF = False Then
                Dim imgByteArray() As Byte
                Try
                    imgByteArray = CType(rs("PicPath").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    stream.Close()
                    Return bmp
                Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                    Return Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                End Try
            Else
                Return Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            End If
        Catch ex As Exception
            Return Image.FromFile(Application.StartupPath & "\noimage.jpeg")
        End Try
    End Function

    Public Function Get_ImageIn2(ByRef Acnumber As String) As Bitmap
        Try
            Dim rs As New Recordset
            rs = conSql.Execute("select PicPath from tblTimeIN where IdNumber = '" & Acnumber & "'")
            If rs.EOF = False Then
                Dim imgByteArray() As Byte
                Try
                    imgByteArray = CType(rs("PicPath").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    stream.Close()
                    Return bmp
                Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                    frmLogs.EmpPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                    Return Nothing
                End Try
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function Get_PicEnt(ByRef Acnumber As String) As Bitmap
        Try
            Dim rs As New Recordset
            rs = conSql.Execute("select PicEnt from tblInOut where InOutId = '" & Acnumber & "'")
            If rs.EOF = False Then
                Dim imgByteArray() As Byte
                Try
                    imgByteArray = CType(rs("PicEnt").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    stream.Close()
                    Return bmp
                Catch ex As Exception
                    Return Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                End Try
            Else
                Return Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            End If
        Catch ex As Exception
            Return Image.FromFile(Application.StartupPath & "\noimage.jpeg")
        End Try
    End Function

    Public Function Get_PicEmp(ByRef Acnumber As String) As Bitmap
  
        Try
            Dim rs As New Recordset
            rs = conSql.Execute("select PicPath from tblemp where IDnumber = '" & Acnumber & "' limit 1;")
            If rs.EOF = False Then
                Dim imgByteArray() As Byte
                Try
                    imgByteArray = CType(rs("PicPath").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    stream.Close()
                    Return bmp
                Catch ex As Exception
                    Try
                        Return Image.FromFile(My.Settings.EmpImgPath & "\" & Acnumber & ".jpeg")
                    Catch ex2 As Exception
                        Try
                            Return Image.FromFile(My.Settings.EmpImgPath & "\" & Acnumber & ".jpg")
                        Catch ex3 As Exception
                            Return Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                        End Try
                    End Try
                End Try
            Else
                Return Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            End If
        Catch ex As Exception
            'frmMain.txtSystemErr.Text = ex.Message
            Return Image.FromFile(Application.StartupPath & "\noimage.jpeg")
        End Try
    End Function

    Public Function Get_PicExt(ByRef Acnumber As String) As Bitmap
        Try
            Dim rs As New Recordset
            rs = conSql.Execute("select PicExt from tblInOut where InOutID = '" & Acnumber & "'")
            If rs.EOF = False Then
                Dim imgByteArray() As Byte
                Try
                    imgByteArray = CType(rs("PicExt").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    stream.Close()
                    Return bmp
                Catch ex As Exception
                  Return Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                End Try
            Else
                Return Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            End If
        Catch ex As Exception
            Return Image.FromFile(Application.StartupPath & "\noimage.jpeg")
        End Try
    End Function
    Public Function Get_ImageDB(ByRef Acnumber As String) As Bitmap
        Try
            Dim rs As New Recordset
            rs = PathConn.Execute("SELECT Photo FROM USERINFO WHERE BadgeNumber='" & Acnumber & "'")
            If rs.EOF = False Then
                Dim imgByteArray() As Byte
                Try
                    imgByteArray = CType(rs("Photo").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    stream.Close()
                    Return bmp
                Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                    Return Nothing
                End Try
            Else
                Return Nothing
            End If

        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Public Sub picEnt()
        If frmMain.StatDB.Text = "Disconnected" Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If
        Try
            frmMain.EntCap.Image = Get_ImageIn(idLog)
        Catch
            frmMain.EntCap.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
        End Try
    End Sub

    Public Sub picInOutView()
        If frmMain.StatDB.Text = "Disconnected" Then
            MsgBox("Please connect to server!    ", vbExclamation, "Server")
            frmConDB.ShowDialog()
            Exit Sub
        End If
        Try
            frmMain.ExtCap.Image = Get_PicExt(idLog)
        Catch
            frmMain.ExtCap.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
        End Try
    End Sub

End Module
