Option Explicit On
Public Class fm220api
    Function FP_Diagnose(ByVal hConnect As Integer) As Integer
        Return _FP_Diagnose(hConnect)
    End Function
    Function FP_Snap(ByVal hConnect As Integer) As Integer
        Return _FP_Snap(hConnect)
    End Function
    Function FP_CreateCaptureHandle(ByVal hConnect As Integer) As Integer
        Return _FP_CreateCaptureHandle(hConnect)
    End Function
    Function FP_Capture(ByVal hConnect As Integer, ByVal hFPCapture As Integer) As Integer
        Return _FP_Capture(hConnect, hFPCapture)
    End Function
    Function FP_DestroyCaptureHandle(ByVal hConnect As Integer, ByVal hFPCapture As Integer) As Integer
        Return _FP_DestroyCaptureHandle(hConnect, hFPCapture)
    End Function
    Function FP_GetPrimaryCode(ByVal hConnect As Integer, ByRef p_code As Byte) As Integer
        Return _FP_GetPrimaryCode(hConnect, p_code)
    End Function
    Function FP_CreateImageHandle(ByVal hConnect As Integer, ByVal mode As Byte, ByVal wSize As Short) As Integer
        Return _FP_CreateImageHandle(hConnect, mode, wSize)
    End Function
    Function FP_GetImage(ByVal hConnect As Integer, ByVal hFPImage As Integer) As Integer
        Return _FP_GetImage(hConnect, hFPImage)
    End Function
    Function FP_DestroyImageHandle(ByVal hConnect As Integer, ByVal hFPImage As Integer) As Integer
        Return _FP_DestroyImageHandle(hConnect, hFPImage)
    End Function
    Function FP_CreateEnrollHandle(ByVal hConnect As Integer, ByVal mode As Integer) As Integer
        Return _FP_CreateEnrollHandle(hConnect, mode)
    End Function
    Function FP_Enroll(ByVal hConnect As Integer, ByVal hFPEnroll As Integer, ByRef p_code As Byte, ByRef fp_code As Byte) As Integer
        Return _FP_Enroll(hConnect, hFPEnroll, p_code, fp_code)
    End Function
    Function FP_DestroyEnrollHandle(ByVal hConnect As Integer, ByVal hFPEnroll As Integer) As Integer
        Return _FP_DestroyEnrollHandle(hConnect, hFPEnroll)
    End Function
    Function FP_ImageMatch(ByVal hConnect As Integer, ByRef fp_code As Byte, ByVal nSecurity As Integer) As Integer
        Return _FP_ImageMatch(hConnect, fp_code, nSecurity)
    End Function
    Function FP_CodeMatch(ByVal hConnect As Integer, ByRef p_code As Byte, ByRef fp_code As Byte, ByVal nSecurity As Integer) As Integer
        Return _FP_CodeMatch(hConnect, p_code, fp_code, nSecurity)
    End Function
    Function FP_ImageMatchEx(ByVal hConnect As Integer, ByRef fp_code As Byte, ByVal security As Integer, ByRef nScore As Integer) As Integer
        Return _FP_ImageMatchEx(hConnect, fp_code, security, nScore)
    End Function
    Function FP_CodeMatchEx(ByVal hConnect As Integer, ByRef p_code As Byte, ByRef fp_code As Byte, ByVal nSecurity As Integer, ByRef nScore As Integer) As Integer
        Return _FP_CodeMatchEx(hConnect, p_code, fp_code, nSecurity, nScore)
    End Function
    Function FP_CheckBlank(ByVal hConnect As Integer) As Integer
        Return _FP_CheckBlank(hConnect)
    End Function
    Function FP_SaveImage(ByVal hConnect As Integer, ByVal hFPImage As Integer, ByVal FileType As Integer, ByVal szFilename As String) As Integer
        Return _FP_SaveImage(hConnect, hFPImage, FileType, szFilename)
    End Function
    Function FP_DisplayImage(ByVal hConnect As Integer, ByVal hDC As Integer, ByVal hFPImage As Integer, ByVal nStartX As Integer, ByVal nStartY As Integer, ByVal nDestWidth As Integer, ByVal nDestHeight As Integer) As Integer
        Return _FP_DisplayImage(hConnect, hDC, hFPImage, nStartX, nStartY, nDestWidth, nDestHeight)
    End Function
    Function FP_ConnectCaptureDriver(ByVal reserved As Integer) As Integer
        Return _FP_ConnectCaptureDriver(reserved)
    End Function
    Sub FP_DisconnectCaptureDriver(ByVal hConnect As Integer)
        _FP_DisconnectCaptureDriver(hConnect)
    End Sub

    'ISO 19794-2 New Func
    Function FP_GetTemplate(ByVal hConnect As Integer, ByRef minu_code As Byte, ByVal mode As Integer, ByVal reserved As Integer) As Integer
        Return _FP_GetTemplate(hConnect, minu_code, mode, reserved)
    End Function
    Function FP_EnrollEx(ByVal hConnect As Integer, ByVal hFPEnroll As Integer, ByRef p_code As Byte, ByRef fp_code As Byte, ByVal mode As Integer) As Integer
        Return _FP_EnrollEx(hConnect, hFPEnroll, p_code, fp_code, mode)
    End Function

    '20101103 add
    Function FP_SaveISOminutia(ByVal hConnect As Integer, ByRef Filename As Byte, ByRef minu_code As Byte) As Integer
        Return _FP_SaveISOminutia(hConnect, Filename, minu_code)
    End Function
    Function FP_SaveM1minutia(ByVal hConnect As Integer, ByRef Filename As Byte, ByRef minu_code As Byte) As Integer
        Return _FP_SaveM1minutia(hConnect, Filename, minu_code)
    End Function
    '    Function FP_GetTemplate_KID(ByVal hConnect As Integer, ByRef minu_code As Byte, ByVal mode As Integer, ByVal reserved As Integer, ByVal scale_lv As Integer) As Integer
    '    Return _FP_GetTemplate_KID(hConnect, minu_code, mode, reserved, scale_lv)
    'End Function
    Function FP_LoadISOminutia(ByVal hConnect As Integer, ByRef Filename As Byte, ByRef minu_code As Byte) As Integer
        Return _FP_LoadISOminutia(hConnect, Filename, minu_code)
    End Function
    Function FP_LoadM1minutia(ByVal hConnect As Integer, ByRef Filename As Byte, ByRef minu_code As Byte) As Integer
        Return _FP_LoadM1minutia(hConnect, Filename, minu_code)
    End Function


    'WSQ
    Function FP_SaveWsqFile(ByVal hConnect As Integer, ByRef filename As Byte, ByVal comp_ratio As Integer) As Integer
        Return _FP_SaveWsqFile(hConnect, filename, comp_ratio)
    End Function
    Function FP_GetWsqData(ByVal hConnect As Integer, ByRef olen As Integer, ByVal comp_ratio As Integer) As Byte
        Return _FP_GetWsqData(hConnect, olen, comp_ratio)
    End Function
    Function FP_SaveWsqFileFromData(ByVal hConnect As Integer, ByRef filename As Byte, ByRef wsq_data As Byte, ByVal olen As Integer) As Integer
        Return FP_SaveWsqFileFromData(hConnect, filename, wsq_data, olen)
    End Function

End Class
