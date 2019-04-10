Module Module1

    Declare Function _FP_Diagnose Lib "fm220api.dll" Alias "FP_Diagnose" (ByVal hConnect As Integer) As Integer
    Declare Function _FP_Snap Lib "fm220api.dll" Alias "_FP_Snap" (ByVal hConnect As Integer) As Integer
    Declare Function _FP_CreateCaptureHandle Lib "fm220api.dll" Alias "FP_CreateCaptureHandle" (ByVal hConnect As Integer) As Integer
    Declare Function _FP_Capture Lib "fm220api.dll" Alias "FP_Capture" (ByVal hConnect As Integer, ByVal hFPCapture As Integer) As Integer
    Declare Function _FP_DestroyCaptureHandle Lib "fm220api.dll" Alias "FP_DestroyCaptureHandle" (ByVal hConnect As Integer, ByVal hFPCapture As Integer) As Integer
    Declare Function _FP_GetPrimaryCode Lib "fm220api.dll" Alias "FP_GetPrimaryCode" (ByVal hConnect As Integer, ByRef p_code As Byte) As Integer
    Declare Function _FP_CreateImageHandle Lib "fm220api.dll" Alias "FP_CreateImageHandle" (ByVal hConnect As Integer, ByVal mode As Byte, ByVal wSize As Short) As Integer
    Declare Function _FP_GetImage Lib "fm220api.dll" Alias "FP_GetImage" (ByVal hConnect As Integer, ByVal hFPImage As Integer) As Integer
    Declare Function _FP_DestroyImageHandle Lib "fm220api.dll" Alias "FP_DestroyImageHandle" (ByVal hConnect As Integer, ByVal hFPImage As Integer) As Integer
    Declare Function _FP_CreateEnrollHandle Lib "fm220api.dll" Alias "FP_CreateEnrollHandle" (ByVal hConnect As Integer, ByVal mode As Integer) As Integer
    Declare Function _FP_Enroll Lib "fm220api.dll" Alias "FP_Enroll" (ByVal hConnect As Integer, ByVal hFPEnroll As Integer, ByRef p_code As Byte, ByRef fp_code As Byte) As Integer
    Declare Function _FP_DestroyEnrollHandle Lib "fm220api.dll" Alias "FP_DestroyEnrollHandle" (ByVal hConnect As Integer, ByVal hFPEnroll As Integer) As Integer
    Declare Function _FP_ImageMatch Lib "fm220api.dll" Alias "FP_ImageMatch" (ByVal hConnect As Integer, ByRef fp_code As Byte, ByVal nSecurity As Integer) As Integer
    Declare Function _FP_CodeMatch Lib "fm220api.dll" Alias "FP_CodeMatch" (ByVal hConnect As Integer, ByRef p_code As Byte, ByRef fp_code As Byte, ByVal nSecurity As Integer) As Integer
    Declare Function _FP_ImageMatchEx Lib "fm220api.dll" Alias "FP_ImageMatchEx" (ByVal hConnect As Integer, ByRef fp_code As Byte, ByVal security As Integer, ByRef nScore As Integer) As Integer
    Declare Function _FP_CodeMatchEx Lib "fm220api.dll" Alias "FP_CodeMatchEx" (ByVal hConnect As Integer, ByRef p_code As Byte, ByRef fp_code As Byte, ByVal nSecurity As Integer, ByRef nScore As Integer) As Integer
    Declare Function _FP_CheckBlank Lib "fm220api.dll" Alias "FP_CheckBlank" (ByVal hConnect As Integer) As Integer
    Declare Function _FP_SaveImage Lib "fm220api.dll" Alias "FP_SaveImage" (ByVal hConnect As Integer, ByVal hFPImage As Integer, ByVal FileType As Integer, ByVal szFilename As String) As Integer
    Declare Function _FP_DisplayImage Lib "fm220api.dll" Alias "FP_DisplayImage" (ByVal hConnect As Integer, ByVal hDC As Integer, ByVal hFPImage As Integer, ByVal nStartX As Integer, ByVal nStartY As Integer, ByVal nDestWidth As Integer, ByVal nDestHeight As Integer) As Integer
    Declare Function _FP_ConnectCaptureDriver Lib "fm220api.dll" Alias "FP_ConnectCaptureDriver" (ByVal reserved As Integer) As Integer
    Declare Sub _FP_DisconnectCaptureDriver Lib "fm220api.dll" Alias "FP_DisconnectCaptureDriver" (ByVal hConnect As Integer)

    'ISO 19794-2 New Func
    Declare Function _FP_GetTemplate Lib "fm220api.dll" Alias "FP_GetTemplate" (ByVal hConnect As Integer, ByRef minu_code As Byte, ByVal mode As Integer, ByVal reserved As Integer) As Integer
    Declare Function _FP_EnrollEx Lib "fm220api.dll" Alias "FP_EnrollEx" (ByVal hConnect As Integer, ByVal hFPEnroll As Integer, ByRef p_code As Byte, ByRef fp_code As Byte, ByVal mode As Integer) As Integer

    '20101103 add
    Declare Function _FP_SaveISOminutia Lib "fm220api.dll" Alias "FP_SaveISOminutia" (ByVal hConnect As Integer, ByRef Filename As Byte, ByRef minu_code As Byte) As Integer
    Declare Function _FP_SaveM1minutia Lib "fm220api.dll" Alias "FP_SaveM1minutia" (ByVal hConnect As Integer, ByRef Filename As Byte, ByRef minu_code As Byte) As Integer
    Declare Function _FP_GetTemplate_KID Lib "fm220api.dll" Alias "FP_GetTemplate_KID" (ByVal hConnect As Integer, ByRef minu_code As Byte, ByVal mode As Integer, ByVal reserved As Integer, ByVal scale_lv As Integer) As Integer
    Declare Function _FP_LoadISOminutia Lib "fm220api.dll" Alias "FP_LoadISOminutia" (ByVal hConnect As Integer, ByRef Filename As Byte, ByRef minu_code As Byte) As Integer
    Declare Function _FP_LoadM1minutia Lib "fm220api.dll" Alias "FP_LoadM1minutia" (ByVal hConnect As Integer, ByRef Filename As Byte, ByRef minu_code As Byte) As Integer

    'WSQ    
    Declare Function _FP_SaveWsqFile Lib "fm220api.dll" Alias "FP_SaveWsqFile" (ByVal hConnect As Integer, ByRef filename As Byte, ByVal comp_ratio As Integer) As Integer
    Declare Function _FP_GetWsqData Lib "fm220api.dll" Alias "FP_GetWsqData" (ByVal hConnect As Integer, ByRef olen As Integer, ByVal comp_ratio As Integer) As Byte
    Declare Function _FP_SaveWsqFileFromData Lib "fm220api.dll" Alias "FP_SaveWsqFileFromData" (ByVal hConnect As Integer, ByRef filename As Byte, ByRef wsq_data As Byte, ByVal olen As Integer) As Integer

    'for local image to minutiea'
    Declare Function _FP_ConvertImageToTemplate Lib "fm220api.dll" Alias "FP_ConvertImageToTemplate" (ByVal hConnect As Integer, ByRef bRawData As Byte, ByVal nWidth As Integer, ByVal nHeight As Integer, ByRef minu_code As Byte, ByVal mode As Integer, ByVal key As Integer) As Integer

    'for minutiea to encrypted minutiea'
    Declare Function _FP_DecryptMinutiae Lib "fm220api.dll" Alias "FP_DecryptMinutiae" (ByVal hConnect As Integer, ByRef encrypted_minu_code As Byte, ByRef iv As Byte, ByRef encrypted_skey As Byte, ByRef decrypted_minu_code As Byte) As Integer
    Declare Function _FP_DecryptMinutiaeEx Lib "fm220api.dll" Alias "FP_DecryptMinutiaeEx" (ByVal hConnect As Integer, ByRef encrypted_minu_code As Byte, ByRef decrypted_minu_code As Byte) As Integer
    Declare Function _FP_EncryptMinutiae Lib "fm220api.dll" Alias "FP_EncryptMinutiae" (ByVal hConnect As Integer, ByRef minu_code As Byte, ByRef encrypted_minu_code As Byte, ByRef iv As Byte, ByRef encrypted_skey As Byte) As Integer
    Declare Function _FP_EncryptMinutiaeEx Lib "fm220api.dll" Alias "FP_EncryptMinutiaeEx" (ByVal hConnect As Integer, ByRef minu_code As Byte, ByRef encrypted_minu_code As Byte) As Integer

    'for startek product bio-service/re-direct use'
    Declare Function _FP_GetEncryptedTemplate Lib "fm220api.dll" Alias "FP_GetEncryptedTemplate" (ByVal hConnect As Integer, ByRef encrypted_minu_code As Byte, ByVal mode As Integer, ByVal key As Integer, ByRef iv As Byte, ByRef encrypted_skey As Byte) As Integer
    Declare Function _FP_EnrollEx_Encrypted Lib "fm220api.dll" Alias "FP_EnrollEx_Encrypted" (ByVal hConnect As Integer, ByVal hEnrlSet As Integer, ByRef encrypted_fpcode As Byte, ByVal mode As Integer, ByRef iv As Byte, ByRef encrypted_skey As Byte) As Integer
    Declare Function _FP_SetPublicKey Lib "fm220api.dll" Alias "FP_SetPublicKey" (ByVal hConnect As Integer, ByRef pPublicKey As Byte, ByVal KeyLen As Integer) As Integer
    Declare Function _FP_SetSessionKey Lib "fm220api.dll" Alias "FP_SetSessionKey" (ByVal hConnect As Integer, ByRef pSessionKey As Byte) As Integer
    Declare Function _FP_GetDeleteData Lib "fm220api.dll" Alias "FP_GetDeleteData" (ByVal hConnect As Integer, ByRef UserId As Byte, ByVal fpIndex As Integer, ByRef encDeleteData As Byte, ByRef p_enc_len As Integer) As Integer

    'for startek new match function use'
    Declare Function _FP_CodeMatchReaderInit Lib "fm220api.dll" Alias "FP_CodeMatchReaderInit" (ByVal hConnect As Integer) As Integer
    Declare Function _FP_CodeMatchReaderDeInit Lib "fm220api.dll" Alias "FP_CodeMatchReaderDeInit" (ByVal hConnect As Integer) As Integer
    Declare Function _FP_CodeMatchReader Lib "fm220api.dll" Alias "FP_CodeMatchReader" (ByVal hConnect As Integer, ByRef encrypted_minu_code As Byte, ByVal security As Integer, ByRef score As Integer) As Integer
    Declare Function _FP_EnrollEx_EncryptedEx Lib "fm220api.dll" Alias "FP_EnrollEx_EncryptedEx" (ByVal hConnect As Integer, ByVal hEnrlSet As Integer, ByRef encrypted_fpcode As Byte, ByVal mode As Integer) As Integer
    Declare Function _FP_GetEncryptedTemplateEx Lib "fm220api.dll" Alias "FP_GetEncryptedTemplateEx" (ByVal hConnect As Integer, ByRef encrypted_minu_code As Byte, ByVal mode As Integer, ByVal key As Integer) As Integer
End Module
