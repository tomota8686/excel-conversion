Imports ClosedXML.Excel

Public Class Excel_Processing

    Private strInputfp As String
    Private strOutputfp As String
    Private strSheetNM As String
    Private intCnt As Integer
    Private dgv As DataGridView


    Sub New(Outputfp As String, sheetNM As String, dgv As DataGridView)
        strOutputfp = Outputfp
        strSheetNM = sheetNM
        Me.dgv = dgv
        intCnt = FrmMain.cellNumCnt()
    End Sub

    Public Function Start_pro() As Boolean
        Try
            For Each row As DataGridViewRow In dgv.Rows
                If row.Cells.Item(0).Value = True Then

                End If
            Next
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

End Class
