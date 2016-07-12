Imports System.Data.SqlClient

Public Class clsManageSpecimen
    Dim db As New iLabDataContext

    Public Sub populateComboOptions(ByVal frm As frmSamples)
        Dim sql1 As String = "SELECT Facility FROM [eLab].[settings].[Locations] order by sortorder, facility" 'load locations
        Dim gndr As String = "SELECT options from settings.options where code =5 order by sortorder" 'load GENDER
        Dim sql2 As String = "SELECT sampletype FROM [eLab].[dbo].optsampletypes order by sortorder, sampletype" 'load sampltypes
        Dim sql3 As String = "SELECT GroupName FROM [eLab].[dbo].optSampleGroups order by sortorder" 'load groups
        Dim sql4 As String = "SELECT options from settings.options where code = 2 order by sortorder" 'load demo
        Dim stud As String = "SELECT studyname from settings.studies order by sortorder, STUDYNAME" 'load study
        Dim fr As String = "SELECT distinct cast(fr_no as integer) from settings.freezers" 'load shelf


        '    Dim shelf As String = "SELECT shelf_ID from dbo.shelves where " 'load rack
        '  Dim rack As String = "SELECT studyname from settings.studies order by sortorder, STUDYNAME" 'load box

        frm.cb_Location.DataSource = Nothing
        frm.cb_Group.DataSource = Nothing
        frm.cb_SampleType.DataSource = Nothing
        frm.cb_gender.DataSource = Nothing
        frm.chk_Demo.CheckState = Nothing
        ' frm.lst_Study.DataSource = Nothing
        ' frm.cb_freezer.DataSource = Nothing

        loadCombo(frm.cb_Location, sql1, "Location", "facility")
        loadCombo(frm.cb_SampleType, sql2, "sampleTypes", "sampletype")
        loadCombo(frm.cb_Group, sql3, "SampleGroups", "GroupName")
        loadCombo(frm.cb_gender, gndr, "options", "options")
        '  loadCombo(frm.cb_gender, gndr, "options", "options")
        loadCombo(frm.cb_study, stud, "Studies", "STUDYNAME")

    End Sub

    Public Sub populateSTudies(ByVal frm As frmSamples)
        Dim sql1 As String = "Select symptom FROM [eLab].[dbo].[symptom] "
        frm.lst_symptoms.DataSource = Nothing
        loadListBox(frm.lst_symptoms, sql1, "symptom", "symptom")
    End Sub

    Public Sub populateSymptomsList(ByVal frm As frmSamples)
        Dim sql As String = "SELECT symptom FROM [eLab].[dbo].[symptom] order by symptom" 'load locations
        frm.lst_symptoms.DataSource = Nothing
        loadCombo(frm.cb_SampleType, sql, "symptom", "symptom")
    End Sub


    'Public Sub populateRacks(ByVal frm As frmSamples)
    '    Dim sql1 As String = "Select rack_ID FROM [eLab].[dbo].[Racks] where shelf_ID = '" & frm.cb_shelf.Text.Trim & "'" 'load locations
    '    frm.cb_rack.DataSource = Nothing
    '    loadCombo(frm.cb_rack, sql1, "Racks", "Rack_ID")
    'End Sub


    Public Sub populateSymptoms(ByVal frm As frmSamples)
        Dim sql1 As String = "Select symptom FROM [eLab].[dbo].[optsymptom] "
        frm.lst_symptoms.DataSource = Nothing
        loadListBox(frm.lst_symptoms, sql1, "symptom", "symptom")
    End Sub


    Public Sub getData(frm As frmSamples)

        Try
            openConn()

            Dim sql As String = "Select  ISNULL([LabREf],'NULL')[LabREf],ISNULL([SPecimenID],'NULL')[SPecimenID], ISNULL([Location],'NULL')[Location], ISNULL([SampleType],'NULL')[SampleType],ISNULL([sampleGroup],'NULL')[sampleGroup], ISNULL([receive_date],'NULL')[receive_date], ISNULL([coll_date],'NULL')[coll_date], ISNULL([entry_date],'NULL')[entry_date], ISNULL([Officer], 'NULL')[Officer] FROM eLab.dbo.Specimen where labref = '" & sLabref & "'"

            Dim cmd As New SqlCommand(sql, Qconn)
            Dim rDR As SqlDataReader = cmd.ExecuteReader

            While rDR.Read
                ' frm.txtBarcode.Text = rDR.Item("[LabREf]")
                frm.txtBarcode.Text = rDR.Item("SPecimenID")
                frm.cb_Location.Text = rDR.Item("Location")
                frm.cb_SampleType.Text = rDR.Item("SampleType")
                frm.cb_Group.Text = rDR.Item("sampleGroup")
                frm.dtpReceiveDate.Text = rDR.Item("receive_date")
                frm.dtpColldate.Value = rDR.Item("coll_date")
                'frm.lblSampleType.Text = rDR.Item("SampleType")
                'frm.lblGroup.Text = rDR.Item("sampleGroup")
                frm.cb_Location.Text = rDR.Item("Location")

            End While

            rDR.Close()

        Catch ex As Exception
            msgError("error in fetching SavedSample Data " + ex.Message)
            Return
        Finally
            closeConn()
        End Try

    End Sub

End Class
