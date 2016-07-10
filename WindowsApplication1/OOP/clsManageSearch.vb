Imports System.Data.SqlClient

Public Class clsManageSearch
    Dim db As New iLabDataContext
    Dim ref As String
    Dim f As frmResultsQC

    Public Sub loadSamples(frm As frmResultsQC)
        Dim sql As String = "Select * FROM SearchSamples"
        FillMyGrid(frm.dgvRecords, sql)
    End Sub

End Class
