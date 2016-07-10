
Public Class frmSamples
    Dim objCommon As New clsCommonMethods
    Dim db As New iLabDataContext
    Dim objSpecimen As New clsManageSpecimen
    Dim objarchives As New clsManageArchives

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If chk_Demo.CheckState = CheckState.Checked Then
                db.manage_Demographics(txtName.Text.Trim, txtName.Text.Trim, txtIdentifier2.Text.Trim, nud_P_Age.Value, txtBarcode.Text.Trim, txtBarcode.Text, txtBarcode.Text, Cuser, 1)
            End If

            db.manage_Specimen(txtBarcode.Text, cb_Location.Text, cb_SampleType.Text.Trim, cb_Group.Text.Trim, dtpColldate.Value, dtpReceiveDate.Value, Now().Date, Cuser, 1)
            '      db.manage_Specimen(ignore, txt)
            If MsgBox("Specimen received succesfully. Receive next sample?", vbYesNo, "Receive Sample") = MsgBoxResult.Yes Then
                'clear controls
            Else
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmSamples_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objSpecimen.populateComboOptions(Me)
        objSpecimen.populateSymptoms(Me)
        objSpecimen.getData(Me)
    End Sub

    Private Sub chk_Demo_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Demo.CheckedChanged
        If chk_Demo.CheckState = CheckState.Checked Then
            grpDemo.Enabled = True
        Else
            grpDemo.Enabled = False
        End If
    End Sub

    Private Sub cb_freezer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_freezer.SelectedIndexChanged
        ' objSpecimen.populateShelves(Me)
        objarchives.Fillshelf(Me.cb_freezer.Text.Trim, Me)
    End Sub



    Private Sub cb_SampleType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_SampleType.SelectedIndexChanged
        If cb_SampleType.Text.Trim = "Blood Culture" Then
            lblBactec.Visible = True
            txtBactec.Visible = True
        Else
            lblBactec.Visible = False
            txtBactec.Visible = False
            txtBactec.Text = ""
        End If

        If cb_SampleType.Text.Trim = "Stool" Then
            grpEnterics.Visible = True
            txtBactec.Visible = True
        Else
            grpEnterics.Visible = False
            cb_appearance.Text = "NULL"
            cb_sufficient.Text = "NULL"
            '  txtBactec.Text = ""
        End If
    End Sub



    Private Sub cb_shelf_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cb_shelf.SelectedIndexChanged
        objarchives.FillRack(Me.cb_shelf.Text.Trim.ToString, Me)
    End Sub

    Private Sub cb_rack_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_rack.SelectedIndexChanged
        objarchives.fillbox(Me.cb_rack.Text.Trim.ToString, Me)
    End Sub
    Private Sub cmdGBox_Click(sender As Object, e As EventArgs) Handles cmdGBox.Click
        BoxView.ShowDialog()
    End Sub
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If validateForms(grpDemo) = True Then
            objSpecimen.saveArchive(Me)
        End If
    End Sub

End Class