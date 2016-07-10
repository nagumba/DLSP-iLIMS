Public Class frmResultsQC
    Dim db As New iLabDataContext
    Dim objSearch As New clsManageSearch
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loadSamples()
    End Sub
    Private Sub loadSamples()
        Dim sql As String = "Select * FROM SearchSamples"
        FillMyGrid(dgvRecords, sql)
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


    Private Sub dgvRecords_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecords.CellContentClick

    End Sub

    Private Sub dgvRecords_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvRecords.CellMouseDoubleClick
        sLabref = Me.dgvRecords.CurrentRow.Cells("LabREf").Value
        frmSamples.Show()
    End Sub

    'Private Sub dgvRecords_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvRecords.MouseClick


    '    Me.txtIndexes.Text = Me.dgvCases.CurrentRow.Cells("index_cases").Value
    '    Me.txtCASEID.Text = Me.dgvCases.CurrentRow.Cells("CASEID").Value
    '    Me.numCASE_AGE.Value = Me.dgvCases.CurrentRow.Cells("CASE_AGE").Value
    '    Me.comCASE_GENDER.Text = Me.dgvCases.CurrentRow.Cells("CASE_GENDER").Value
    '    Me.txtDSS_ID.Text = Me.dgvCases.CurrentRow.Cells("DSS_ID").Value
    '    Me.dtpENROL_DATE.Value = Me.dgvCases.CurrentRow.Cells("ENROL_DATE").Value
    '    Me.dtpDob.Value = Me.dgvCases.CurrentRow.Cells("CASE_DOB").Value
    '    If Me.dgvCases.CurrentRow.Cells("photo").Value <> Nothing Then
    '        Me.comPhoto.Text = Me.dgvCases.CurrentRow.Cells("photo").Value.ToString.Trim
    '    End If
    '    If Me.dgvCases.CurrentRow.Cells("Card").Value <> Nothing Then
    '        Me.comCard.Text = Me.dgvCases.CurrentRow.Cells("Card").Value.ToString.Trim
    '    End If
    '    If Me.dgvCases.CurrentRow.Cells("followup").Value <> Nothing Then
    '        Me.comFollowup.Text = Me.dgvCases.CurrentRow.Cells("followup").Value.ToString.Trim
    '    End If
    '    Me.txtCase_motherID.Text = Me.dgvCases.CurrentRow.Cells("CASE_MOTHERID").Value
    '    Me.txtCase_fname.Text = Me.dgvCases.CurrentRow.Cells("CASE_FNAME").Value
    '    Me.txtCase_jname.Text = Me.dgvCases.CurrentRow.Cells("CASE_JNAME").Value
    '    Me.txtCase_lname.Text = Me.dgvCases.CurrentRow.Cells("CASE_LNAME").Value
    '    Me.txtCase_fatherID.Text = Me.dgvCases.CurrentRow.Cells("CASE_FATHERID").Value
    '    If Me.dgvCases.CurrentRow.Cells("m_aid").Value <> Nothing Then
    '        Me.comM_aid.Text = Me.dgvCases.CurrentRow.Cells("m_aid").Value.ToString.Trim
    '    End If
    ' End Sub
End Class