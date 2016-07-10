Public Class frmResultsQC
    Dim db As New iLabDataContext
    Dim objSearch As New clsManageSearch
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        objSearch.loadSamples(Me)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chk_barcode.CheckedChanged

        If chk_barcode.CheckState = CheckState.Checked Then
            cbBarcode.Enabled = True
            txtBarcode.Enabled = True
            cb_barCar.Enabled = True
        Else
            cbBarcode.Enabled = False
            txtBarcode.Enabled = False
            cb_barCar.Enabled = False
        End If
    End Sub

    Private Sub chk_dates_CheckedChanged(sender As Object, e As EventArgs) Handles chk_dates.CheckedChanged

        If chk_dates.CheckState = CheckState.Checked Then
            dtspStartDAte.Enabled = True
            dtpEndDate.Enabled = True
            cb_DateCat.Enabled = True
        Else
            dtspStartDAte.Enabled = False
            dtpEndDate.Enabled = False
            cb_DateCat.Enabled = False
        End If
    End Sub

    Private Sub chkLocation_CheckedChanged(sender As Object, e As EventArgs) Handles chkLocation.CheckedChanged
        If chkLocation.CheckState = CheckState.Checked Then
            cb_location.Enabled = True
            cb_locCat.Enabled = True
            cb_Locaca.Enabled = True
        Else
            cb_location.Enabled = False
            cb_locCat.Enabled = False
            cb_Locaca.Enabled = False
        End If
    End Sub


    Private Sub chkSampleType_CheckedChanged(sender As Object, e As EventArgs) Handles chkSampleType.CheckedChanged

        If chkSampleType.Checked = True Then
            cb_typeD.Enabled = True
            cb_TypeCat.Enabled = True
            cbType.Enabled = True
        Else
            cb_typeD.Enabled = False
            cb_TypeCat.Enabled = False
            cbType.Enabled = True
        End If
    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        msgError("Only authorised persons can download data")
        Exit Sub
    End Sub
    Private Sub Form_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvRecords.MouseClick
        If (e.Button = Windows.Forms.MouseButtons.Right) Then
            ' ctxMenu.Show()
            dgvRecords.ContextMenuStrip = ctxMenu
        End If
    End Sub

    Private Sub ctxMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ctxMenu.Opening

    End Sub

    Private Sub tsm_Test_Click(sender As Object, e As EventArgs) Handles tsm_Test.Click

        Dim fload As New frmResults
        fload.MdiParent = mdiLIMS
        If Not sBarcode = "" Then


            fload.Show()
        Else
            msgError("Please make a selection")
        End If
    End Sub

    Private Sub tsm_Archive_Click(sender As Object, e As EventArgs) Handles tsm_Archive.Click

        Dim fload As New frmSamples
        fload.MdiParent = mdiLIMS
        If Not sBarcode = "" Then

            fload.Show()
        Else
            msgError("Please make a selection")
        End If
    End Sub

    Private Sub tsm_aliq_Click(sender As Object, e As EventArgs) Handles tsm_aliq.Click
        Dim fload As New frmAliquoting
        fload.MdiParent = mdiLIMS

        If Not sBarcode = "" Then

            fload.Show()
        Else
            msgError("Please make a selection")
        End If
    End Sub

    Private Sub dgvRecords_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecords.CellContentClick
        sBarcode = Me.dgvRecords.CurrentRow.Cells("SPecimenID").Value
        sSampleType = Me.dgvRecords.CurrentRow.Cells("SampleType").Value
        'sSTudy = Me.dgvRecords.CurrentRow.Cells("LabREf").Value
        'sAliquot = Me.dgvRecords.CurrentRow.Cells("LabREf").Value
    End Sub

    Private Sub frmResultsQC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  If 
    End Sub
End Class