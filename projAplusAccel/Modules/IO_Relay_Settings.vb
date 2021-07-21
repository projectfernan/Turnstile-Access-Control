
Module IO_Relay_Settings
    'function to access barrier
    Public Declare Function Inp Lib "inpout32.dll" _
    Alias "Inp32" (ByVal PortAddress As Integer) As Integer
    Public Declare Sub Out Lib "inpout32.dll" _
    Alias "Out32" (ByVal PortAddress As Integer, ByVal Value As Integer)

    'delay function
    Declare Sub Sleep Lib "kernel32" (ByVal MSmiliSeconds As Long)

    Public Sub triger()
        Try
            Dim padd As String
            padd = "&H" + frmBarrier.txtPortAdd.Text
            Out(padd, Val(frmBarrier.txtPort.Text))
            Sleep(Val(frmBarrier.txtDelay.Text))
            Out("&H" + frmBarrier.txtPortAdd.Text, 0)
        Catch ex As Exception
            ' frmMain.txtSystemErr.Text = ex.Message
        End Try

    End Sub

    Public Sub trigerExt()
        Try
            Dim padd As String
            padd = "&H" + frmBarrier.txtPortAdd.Text
            Out(padd, Val(frmBarrier.txtExtPort.Text))
            Sleep(Val(frmBarrier.txtDelay.Text))
            Out("&H" + frmBarrier.txtPortAdd.Text, 0)
        Catch ex As Exception
            ' frmMain.txtSystemErr.Text = ex.Message
        End Try

    End Sub

    Public Sub trigerOff()
        Try
            Out("&H" + frmBarrier.txtPortAdd.Text, 0)
        Catch ex As Exception
            ' frmMain.txtSystemErr.Text = ex.Message
        End Try
    End Sub

    Public Function Output(ByVal StatAdd As String) As String
        Try
            Return Inp("&H" + StatAdd)
        Catch ex As Exception
            ' frmMain.txtSystemErr.Text = ex.Message
            Return vbNullString
        End Try
    End Function

    Public Sub viewBarrierSet()
        With My.Settings
            frmBarrier.txtPortAdd.Text = .PortAdd
            frmBarrier.txtStatAdd.Text = .StatAdd
            frmBarrier.txtExtPort.Text = .Extport
            frmBarrier.txtPort.Value = .Port
            frmBarrier.txtDelay.Value = .Delay
            frmBarrier.txtLoop.Text = .LoopCode
        End With
    End Sub

End Module
