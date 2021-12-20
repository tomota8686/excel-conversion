Imports ClosedXML.Excel

Public Class Excel_Processing

    Private strInputfp As String
    Private strOutputfp As String
    Private strSheetNM As String
    Private intCnt As Integer


    Sub New(Inputfp As String, Outputfp As String, sheetnm As String)
        strInputfp = Inputfp
        strOutputfp = Outputfp
        strSheetNM = sheetnm
        intCnt = FrmMain.cellNumCnt()
    End Sub

End Class
