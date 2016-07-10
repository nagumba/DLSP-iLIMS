

Public Class clsManageResults
    Public db As New iLabDataContext
    Public frm As New frmSamples
    Dim test, test1, tests2, results As String
    Public Sub populateComboOptions(ByVal frm As frmResults)

        Dim testtype As String = "SELECT distinct rtrim(ltrim(tests)) as tests  FROM [eLab].[dbo].[opttests] " 'load tetstypes
        '  Dim test1 As String = "SELECT distinct rtrim(ltrim(test1)) as test  FROM [eLab].[dbo].[tests] where test = '" & frm.cb_testname.Text.Trim & "'" 'load tetstypes
        '  Dim testname As String = "SELECT distinct testname FROM [eLab].[dbo].[Atests]" 'load testname
        Dim result As String = "SELECT distinct testname FROM [eLab].[dbo].optresults where testtype = '" & frm.cb_iTest.Text.Trim & "'" 'load results
        Dim result1 As String = "SELECT distinct testname FROM [eLab].[dbo].optresults" 'load results
        Dim drug As String = "SELECT distinct drug FROM [dbo].[optsensitivitydrugs]" 'load results
        Dim sensitivity As String = "SELECT options FROM [settings].[options] where code = 4 order by sortorder" 'load results
        'clear boxes

        'frm.cb_test.DataSource = Nothing
        '' frm.cb_test.DataSource = Nothing
        '' frm.cb_testname.DataSource = Nothing
        '' frm.cb_testname.Items.Clear()
        'frm.cb_result.Items.Clear()
        'frm.cb_drugs.DataSource = Nothing
        'frm.cb_result.Items.Clear()
        'frm.cb_sensistivity.DataSource = Nothing

        loadCombo(frm.cb_iTest, testtype, "tests", "test")
        loadCombo(frm.cb_iResult, result1, "tests", "testname")
        '  loadCombo(frm.cb_testname, testname, "tests", "test1")
        loadCombo(frm.cb_PCRresult, result, "optresults", "testname")
        loadCombo(frm.cb_drugs, drug, "sensitivitydrugs", "drug")
        loadCombo(frm.cb_sensistivity, sensitivity, "options", "options")



    End Sub
    Public Sub FillCultureResult(testtype As String, frm As frmResults)
        'Dim con As New SqlConnection(strConn)
        Dim cmd As New SqlClient.SqlCommand()
        cmd.Connection = db.Connection
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT distinct rtrim(ltrim(testname)) as testname FROM  optResults where TestType = '" & frm.cb_iTest.Text.Trim & "'"
        Dim objDs As New DataSet()
        Dim dAdapter As New SqlClient.SqlDataAdapter()
        dAdapter.SelectCommand = cmd
        db.Connection.Open()
        dAdapter.Fill(objDs)
        db.Connection.Close()
        frm.cb_iResult.ValueMember = "testname"
        frm.cb_iResult.DisplayMember = "testname"
        frm.cb_iResult.DataSource = objDs.Tables(0)
    End Sub
    Public Sub populateresults(ByVal frm As frmResults)
        Dim test1 As String = "SELECT distinct rtrim(ltrim(test1)) as test1  FROM [eLab].[dbo].[opttests] where test = '" & frm.cb_iTest.Text.Trim & "'" 'load tetstypes


        'If frm.txtSampleType.Text = "BloodCulture" Then

        'End If
    End Sub


    'Public Sub txtSearchResults(frm As frmSamples)
    '    '    Dim conn As New SqlConnection(myConnection)
    '    Dim db As New iLabDataContext
    '    Dim cmd As String = "select SubjectID  FROM [PRESURV].[PRESURV].[ENR_Physicalexamination] where Meetinclusion ='1' and  Consented = '1' and  Delivery = '0'"
    '    Dim ds As New DataSet
    '    Dim da As New SqlDataAdapter(cmd)
    '    da.Fill(ds, "list")
    '    Dim col As New AutoCompleteStringCollection
    '    Dim i As Integer
    '    For i = 0 To ds.Tables(0).Rows.Count - 1
    '        col.Add(ds.Tables(0).Rows(i)("SubjectID").ToString())
    '    Next
    '    txtStudyID.AutoCompleteSource = AutoCompleteSource.CustomSource
    '    txtStudyID.AutoCompleteCustomSource = col
    '    txtStudyID.AutoCompleteMode = AutoCompleteMode.Suggest
    'End Sub

    'Public Sub txtSearch()
    '    Dim conn As New SqlConnection(myConnection)
    '    Dim cmd As New SqlCommand("select SubjectID  FROM [PRESURV].[PRESURV].[ENR_Physicalexamination] where Meetinclusion ='1' and  Consented = '1' and  Delivery = '0'", conn)
    '    Dim ds As New DataSet
    '    Dim da As New SqlDataAdapter(cmd)
    '    da.Fill(ds, "list")
    '    Dim col As New AutoCompleteStringCollection
    '    Dim i As Integer
    '    For i = 0 To ds.Tables(0).Rows.Count - 1
    '        col.Add(ds.Tables(0).Rows(i)("SubjectID").ToString())
    '    Next
    '    txtStudyID.AutoCompleteSource = AutoCompleteSource.CustomSource
    '    txtStudyID.AutoCompleteCustomSource = col
    '    txtStudyID.AutoCompleteMode = AutoCompleteMode.Suggest
    'End Sub

    Public Sub Filltest(test As String, frm As frmResults)
        'Dim con As New SqlConnection(strConn)
        Dim cmd As New SqlClient.SqlCommand()
        cmd.Connection = db.Connection
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT distinct rtrim(ltrim(results)) as results FROM  opttests where tests = '" & frm.cb_iTest.Text.Trim & "'"
        Dim objDs As New DataSet()
        Dim dAdapter As New SqlClient.SqlDataAdapter()
        dAdapter.SelectCommand = cmd
        db.Connection.Open()
        dAdapter.Fill(objDs)
        db.Connection.Close()
        'frm.cb_testname.ValueMember = "results"
        'frm.cb_testname.DisplayMember = "results"
        'frm.cb_testname.DataSource = objDs.Tables(0)
    End Sub



    Public Sub Filltestresult1(test As String, frm As frmResults)
        'Dim con As New SqlConnection(strConn)
        Dim cmd As New SqlClient.SqlCommand()
        cmd.Connection = db.Connection
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT distinct rtrim(ltrim(test1)) as test1 FROM  optTestResults where test = '" & frm.cb_iTest.Text.Trim & "'"
        Dim objDs As New DataSet()
        Dim dAdapter As New SqlClient.SqlDataAdapter()
        dAdapter.SelectCommand = cmd
        db.Connection.Open()
        dAdapter.Fill(objDs)
        db.Connection.Close()

        'frm.cb_results1.ValueMember = "test1"
        'frm.cb_results1.DisplayMember = "test1"
        'frm.cb_results1.DataSource = objDs.Tables(0)
    End Sub




    Public Sub Filltestdrugsensitivity(frm As frmResults)
        'Dim con As New SqlConnection(strConn)
        Dim cmd As New SqlClient.SqlCommand()
        cmd.Connection = db.Connection
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT distinct rtrim(ltrim(drug)) as drug FROM  optsensitivitydrugs"
        Dim objDs As New DataSet()
        Dim dAdapter As New SqlClient.SqlDataAdapter()
        dAdapter.SelectCommand = cmd
        db.Connection.Open()
        dAdapter.Fill(objDs)
        db.Connection.Close()

        frm.cb_drugs.ValueMember = "drug"
        frm.cb_drugs.DisplayMember = "drug"
        frm.cb_drugs.DataSource = objDs.Tables(0)
    End Sub


    'Private Sub cmbCountry_SelectedIndexChanged(sender As Object, e As EventArgs)

    '    If cmbCountry.SelectedValue.ToString() <> "" Then

    '        Dim CountryID As Integer = Convert.ToInt32(cmbCountry.SelectedValue.ToString())

    '        FillStates(CountryID)

    '        cmbCity.SelectedIndex = 0

    '    End If

    'End Sub



    'Private Sub FillStates(countryID As Integer)
    '    Dim con As New SqlConnection(strConn)
    '    Dim cmd As New SqlCommand()
    '    cmd.Connection = con
    '    cmd.CommandType = CommandType.Text
    '    cmd.CommandText = "SELECT StateID, StateName FROM State WHERE CountryID =@CountryID"
    '    cmd.Parameters.AddWithValue("@CountryID", countryID)
    '    Dim objDs As New DataSet()
    '    Dim dAdapter As New SqlDataAdapter()
    '    dAdapter.SelectCommand = cmd
    '    con.Open()
    '    dAdapter.Fill(objDs)
    '    con.Close()
    '    If objDs.Tables(0).Rows.Count > 0 Then
    '        cmbState.ValueMember = "StateID"
    '        cmbState.DisplayMember = "StateName"
    '        cmbState.DataSource = objDs.Tables(0)
    '    End If

    'End Sub



    'Private Sub cmbState_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    Dim StateID As Integer = Convert.ToInt32(cmbState.SelectedValue.ToString())
    '    FillCities(StateID)
    'End Sub

    'Private Sub FillCities(stateID As Integer)
    '    Dim con As New SqlConnection(strConn)
    '    Dim cmd As New SqlCommand()
    '    cmd.Connection = con
    '    cmd.CommandType = CommandType.Text
    '    cmd.CommandText = "SELECT CityID, CityName FROM City WHERE StateID =@StateID"
    '    cmd.Parameters.AddWithValue("@StateID", stateID)
    '    Dim objDs As New DataSet()
    '    Dim dAdapter As New SqlDataAdapter()
    '    dAdapter.SelectCommand = cmd
    '    con.Open()
    '    dAdapter.Fill(objDs)
    '    con.Close()
    '    If objDs.Tables(0).Rows.Count > 0 Then
    '        cmbCity.DataSource = objDs.Tables(0)
    '        cmbCity.DisplayMember = "CityName"
    '        cmbCity.ValueMember = "CItyID"
    '    End If
    'End Sub

End Class
