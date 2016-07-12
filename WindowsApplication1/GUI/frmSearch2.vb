Public Class frmSearch2
    Dim objSearch As New clsManageSearch
    Dim db As New iLabDataContext

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        msgError("Only authorised persons can download data")
        Exit Sub

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        objSearch.loadResultsQC(Me)
    End Sub

    Private Sub chkResult_CheckedChanged(sender As Object, e As EventArgs) Handles chkResult.CheckedChanged
        If chkResult.CheckState = CheckState.Checked Then
            cbResult.Enabled = True
        Else
            cbResult.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        db.manage_Sample_Results(sLabref, sBarcode, sUniqueID, txtBarcode.Text.Trim, "", "", "", Cuser, Now.Date, Cuser, 0.0, "Approved", 2)
    End Sub

    Private Sub dgvRecords_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecords.CellContentClick

        sbarcode = Me.dgvRecords.CurrentRow.Cells("Barcode").Value
        TextBox1.Text = sBarcode
    End Sub
End Class