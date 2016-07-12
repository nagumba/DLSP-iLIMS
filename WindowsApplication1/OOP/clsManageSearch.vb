Imports System.Data.SqlClient

Public Class clsManageSearch
    Dim db As New iLabDataContext
    Dim ref As String
    Dim f As frmResultsQC

    Public Sub loadSamples(frm As frmResultsQC)
        Dim sql As String = "Select * FROM SearchSamples"
        FillMyGrid(frm.dgvRecords, sql)
    End Sub

    Public Sub loadResultsQC(frm As frmSearch2)
        '  Dim sql As String = ""
        If frm.cbResult.Text.Trim = "PCR" Then
            FillMyGrid(frm.dgvRecords, "Select * FROM PCR_Results")
        ElseIf frm.cbResult.Text.Trim = "Elisa"
            FillMyGrid(frm.dgvRecords, "Select * FROM ELISA_Results")
        ElseIf frm.cbResult.Text.Trim = "Binax"
            FillMyGrid(frm.dgvRecords, "Select * FROM Binax_Results")
        ElseIf frm.cbResult.Text.Trim = "Culture"
            FillMyGrid(frm.dgvRecords, "Select * FROM Culture_Results")
        End If



    End Sub

End Class
