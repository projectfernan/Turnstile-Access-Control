
Module Controller_Function
    Public com As Integer
    Public Const SUCCEED As Integer = 1
    Public Const FAILED As Integer = 0
    Public Const ENTRY_EXIT_RECORD_SIZE As Short = 10
    Public language As Byte
    Public bQuery As Boolean
    Public iniFile As String
    Public Addr As Byte

    'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    Public Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    Public Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

    Declare Function open_com Lib "OfflinePark.dll" (ByVal nPort As Integer, ByVal wait_ms As Integer, ByVal dataSize As Integer) As Integer
    Declare Function close_com Lib "OfflinePark.dll" () As Integer
    Declare Function GetCommErrID Lib "OfflinePark.dll" () As Integer
    Declare Function com_is_open Lib "OfflinePark.dll" () As Integer
    Declare Function get_status Lib "OfflinePark.dll" () As Integer
    Declare Function set_controller_address Lib "OfflinePark.dll" (ByVal Addr As Byte, ByVal language As Byte, ByRef sn As Byte) As Byte
    Declare Function entry_auto_gate Lib "OfflinePark.dll" (ByVal Addr As Byte) As Integer
    Declare Function entry_open_gate Lib "OfflinePark.dll" (ByVal Addr As Byte) As Integer
    Declare Function entry_close_gate Lib "OfflinePark.dll" (ByVal Addr As Byte) As Integer
    Declare Function exit_auto_gate Lib "OfflinePark.dll" (ByVal Addr As Byte) As Integer
    Declare Function exit_open_gate Lib "OfflinePark.dll" (ByVal Addr As Byte) As Integer
    Declare Function exit_close_gate Lib "OfflinePark.dll" (ByVal Addr As Byte) As Integer
    Declare Function check_time Lib "OfflinePark.dll" (ByVal Addr As Byte, ByVal sel_led As Byte) As Integer
    'UPGRADE_NOTE: str was upgraded to str_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
    Declare Function show_main_ledB Lib "OfflinePark.dll" (ByVal Addr As Byte, ByVal sel_led As Byte, ByVal str_Renamed As String) As Integer
    'UPGRADE_NOTE: str was upgraded to str_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
    Declare Function ImmediateB Lib "OfflinePark.dll" (ByVal Addr As Byte, ByVal sel_led As Byte, ByVal str_Renamed As String) As Integer
    Declare Function ImmediateBak Lib "OfflinePark.dll" (ByVal Addr As Byte, ByVal sel_led As Byte, ByVal sel_option As Integer) As Integer
    Declare Function ClearAllMem Lib "OfflinePark.dll" (ByVal Addr As Byte, ByVal Led_addr As Byte) As Integer
    Declare Function query_statusB Lib "OfflinePark.dll" (ByVal Addr As Byte, ByVal card_number As String, ByRef direct As Byte) As Integer
    Declare Function play_voice_id Lib "OfflinePark.dll" (ByVal Addr As Byte, ByVal direct As Byte, ByVal voice_id As Byte, ByVal v1 As Byte, ByVal v2 As Byte, ByVal v3 As Byte) As Integer
    Declare Function poll_collect_record Lib "OfflinePark.dll" (ByVal Addr As Byte) As Integer
    Declare Function get_data Lib "OfflinePark.dll" (ByRef buf As Byte) As Integer
    Declare Sub ack_collect Lib "OfflinePark.dll" (ByVal Addr As Byte, ByVal uid As Byte, ByVal nums As Byte)
    Declare Sub Ack Lib "OfflinePark.dll" (ByVal Addr As Byte, ByVal id As Integer)
    Declare Function down_user_card_info Lib "OfflinePark.dll" (ByVal Addr As Byte, ByRef buf As Byte, ByVal page As Short, ByVal bFlag As Byte) As Integer

    Public Function ctrlCon() As Boolean
        Try
            Dim sn(3) As Byte
            Dim iSn As Integer

            iSn = Val("&H" & My.Settings.CR_SRno)
            sn(0) = iSn / 16777216
            sn(1) = (iSn / 65536) And &HFF
            sn(2) = (iSn / 256) And &HFF
            sn(3) = iSn And &HFF
            language = 1
            Addr = sn(3)

            If open_com(My.Settings.CR_SRport + 1, 200, 2) = 1 Then
                Addr = sn(3)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub viewCtrl()

        With My.Settings
            If .CR_SRport = vbNullString Then Exit Sub
            frmControler.txtControlSN.Text = .CR_SRno
            com = .CR_SRport
            frmControler.ComboPort.Text = .CR_Com
        End With
    End Sub

End Module
