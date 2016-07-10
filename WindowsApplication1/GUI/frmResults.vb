Public Class frmResults
    Dim objCommon As New clsCommonMethods
    Dim db As New iLabDataContext
    Dim objResults As New clsManageResults
    Private Sub frmResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        txtBarcode.Text = sBarcode
        txtSampleType.Text = sSampleType
        tc_Results.TabPages.Clear()
        objResults.populateComboOptions(Me)

        If sSampleType = "BloodCulture" Then
            grpBC.Visible = True
            grp_tests.Top = 5
            grp_tests.Left = 400
        Else
            grpBC.Visible = False
            grp_tests.Top = 5
            grp_tests.Left = 5
        End If

        If sSampleType = "Urine" Then
            objResults.populateComboOptions(Me)
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '  db.manage_s
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        validateControlsOnTabControl(tc_Results)


        Try

            If cb_iTest.Text = "Binax" Then
                db.manage_Sample_Results(sBarcode, sBarcode, txtUniqueID.Text.Trim, cb_iTest.Text.Trim, "NULL", "NULL", cb_iResult.Text.Trim, Cuser, Now.Date, Cuser, 10.2, "NQ", 1)
                msgSuccess("Binax Results saved succesfully")
            End If

            If cb_iTest.Text = "PCR" Then
                db.manage_Sample_Results(sBarcode, sBarcode, txtUniqueID.Text.Trim, "PCR", "NULL", cb_PCRTarget.Text.Trim, cb_PCRresult.Text.Trim, Cuser, "1900-01-01", Cuser, 0.00, "NQ", 1)
                db.manage_OD_CTvalues(sBarcode, sBarcode, txtUniqueID.Text.Trim, nud_PCR_OD.Text, 0.00, 0.00, Cuser, 1)
                msgSuccess("PCR_REsults saved succesfully")
            End If

            If cb_iTest.Text = "ELISA" Then
                db.manage_Sample_Results(sBarcode, sBarcode, txtUniqueID.Text.Trim, "ELISA", cb_Kits.Text.Trim, cb_ElisaTarget.Text.Trim, cb_ElisaResults.Text.Trim, Cuser, "1900-01-01", Cuser, 0.00, "NQ", 1)
                db.manage_OD_CTvalues(sBarcode, sBarcode, txtUniqueID.Text.Trim, txtElisaOD.Text, txtELISAmean.Text.Trim, txtElisaCut.Text.Trim, Cuser, 1)
                msgSuccess("ELISA REsults saved succesfully")
            End If


            If cb_iTest.Text = "Culture" Then
                db.manage_Sample_Results(sBarcode, sBarcode, txtUniqueID.Text.Trim, "Culture", "NA", cb_iResult.Text.Trim, cb_organism.Text.Trim, Cuser, "1900-01-01", Cuser, 0.00, "NQ", 1)
                db.manage_OD_CTvalues(sBarcode, sBarcode, txtUniqueID.Text.Trim, txtElisaOD.Text, txtELISAmean.Text.Trim, txtElisaCut.Text.Trim, Cuser, 1)
                msgSuccess("Culture Results saved succesfully")
            End If


            If rdoYes.Checked = True Then
                db.manage_testing(Now.Date, 0, txtBarcode.Text.Trim, txtUniqueID.Text.Trim, "Tested", cb_iTest.Text.Trim, cb_Notest.Text.Trim, "", Cuser, 1)
                '  msgSuccess("Sample results saved successfully")
            ElseIf rdoNo.Checked = True Then
                db.manage_testing(Now.Date, 0, txtBarcode.Text.Trim, txtUniqueID.Text.Trim, "Not tested", cb_iTest.Text.Trim, cb_Notest.Text.Trim, "", Cuser, 1)
                '   msgSuccess("Sample NOT tested saved successfully")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub nud_CT_OD_KeyPress(sender As System.Object, e As KeyPressEventArgs) Handles nud_PCR_OD.KeyPress
        If (Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar)) And Not Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("This field does not accept letters. Try again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub nud_CT_OD_TextChanged(sender As Object, e As EventArgs) Handles nud_PCR_OD.TextChanged
    End Sub

    Private Sub cb_test_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_iTest.SelectedIndexChanged, cb_BactecResults.SelectedIndexChanged, cb_gmastain.SelectedIndexChanged, cb_iResult.SelectedIndexChanged, cb_PCRTarget.SelectedIndexChanged, cb_organism.SelectedIndexChanged


        objResults.FillCultureResult(cb_iTest.Text.Trim, Me)


        GroupBox3.Top = 170
        GroupBox3.Left = 5
        'objResults.Filltest(Me.cb_iTest.Text.Trim, Me)
        'objResults.populateComboOptions(Me)
        If cb_iTest.Text.Trim = "PCR" Then
            grp_PCR.Visible = True
            grp_PCR.Top = 70
            grp_PCR.Left = 5
        Else
            grp_PCR.Visible = False
        End If
        If cb_iTest.Text.Trim = "ELISA" Then
            grp_Elisa.Visible = True
            grp_Elisa.Top = 70
            grp_Elisa.Left = 5
        Else
            grp_Elisa.Visible = False
        End If

        If cb_iTest.Text.Trim = "Culture" Then
            Label32.Visible = True
            cb_organism.Visible = True
        Else
            Label32.Visible = False
            cb_organism.Visible = False
        End If


        If cb_iTest.Text.Trim = "Binax" Or cb_iTest.Text.Trim = "Culture" Then
            cb_iResult.Visible = True
        Else
            cb_iResult.Visible = False
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs)
        'objResults.populateresults(Me)
        objResults.Filltest(Me.cb_iTest.Text.Trim, Me)
    End Sub
    Private Sub cb_testname_SelectedIndexChanged(sender As Object, e As EventArgs)
        'If cb_testname.Text.Trim = "Positive" Or cb_testname.Text.Trim = "Growth" Then
        '    objResults.Filltestresult1(Me.cb_Target.Text.Trim, Me)
        '    cb_results1.Enabled = True
        'Else
        '    cb_results1.Enabled = False
        '    cb_results1.SelectedIndex = -1
        'End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdoYes.CheckedChanged
        If rdoYes.Checked = True Then
            tc_Results.TabPages.Clear()
            tc_Results.TabPages.Insert(0, tpResults)

            If sBarcode = "BloodCulture" Then
                tc_Results.TabPages.Insert(0, tpSen)
            End If
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNo.CheckedChanged
        If rdoNo.Checked = True Then
            tc_Results.TabPages.Clear()
            tc_Results.TabPages.Insert(0, tbNoTest)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '   Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub cb_drugs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_drugs.SelectedIndexChanged

    End Sub

    Private Sub cb_sensistivity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_sensistivity.SelectedIndexChanged
        objResults.Filltestdrugsensitivity(Me)
    End Sub
End Class