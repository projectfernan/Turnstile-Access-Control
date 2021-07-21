
Module D8U_FUNCTION
    Public rd As COMRD800Lib.RD800
    Public st As Integer
    Public CardCod As String
    Public snr As String

    '------------------------------------------------------ D8 CONFIG ---------------------------------------------------------'

    Public Function d8_conn() As Boolean
        rd = New COMRD800Lib.RD800
        st = rd.dc_init(100, 115200)
        If st < 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub d8_Beep()
        rd = New COMRD800Lib.RD800
        st = rd.dc_init(100, 115200)
        If st < 0 Then

        Else
            rd.dc_beep(10)
        End If
    End Sub

    Public Function d8_Card() As Boolean
        rd = New COMRD800Lib.RD800
        st = rd.dc_init(100, 115200)
        If st < 0 Then
            Return False
        Else
            st = rd.dc_card(0, snr)
            CardCod = snr
            If st = 0 Then
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Public Function d8_LoadpassOL() As Boolean
        rd.put_bstrSBuffer_asc = "FFFFFFFFFFFF" 'this is load key function
        st = rd.dc_load_key(0, CShort(0))
        If st < 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function d8_AuthenOL() As Boolean
        st = rd.dc_authentication(0, CShort(0)) 'this is to authentication
        If st < 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function d8_ReadOL() As String
        st = rd.dc_read(CShort(0)) 'this is how to read
        If st < 0 Then
            Return vbNullString
        Else
            System.Threading.Thread.Sleep(200)
            Return Trim(Mid(rd.get_bstrRBuffer_asc, 1, 8))
        End If
    End Function
End Module
