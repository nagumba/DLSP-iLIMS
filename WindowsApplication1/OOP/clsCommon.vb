Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.Form
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Data.Linq
Imports System.Collections.Generic
Imports System.Text
'Imports System.Data.Objects
Imports System.IO

Public Class clsCommonMethods
    Private sql As String = Nothing
    Private lstVw As ListView
    Dim db As New iLabDataContext
    Private dssID As String = Nothing
    Private frmMode As String = Nothing
    Dim objSQLLibrary As New clsSQLQueryLibrary
    Private dob As Date = Nothing
    Private visitID As Integer = Nothing
    Private myTble As String = Nothing
    Private mySchema As String = Nothing
    Private myValidateStatus As String
    Private myTabControl As TabControl
    Private myCheckedListBox As CheckedListBox
    Private myColumn As String = Nothing
    Private myDataList As New List(Of String)
    Private myForm As Form
    Public REC_DATE_edit As Date
    Public nmresp As String
    Public c_age As Integer


    Public Property GetMyFormToLoad As Form

        Get
            Return myForm
        End Get
        Set(ByVal value As Form)
            myForm = value
        End Set
    End Property

    Public Property GetMyListview As ListView
        Get
            Return lstVw
        End Get
        Set(ByVal value As ListView)
            lstVw = value
        End Set
    End Property

    Public Property setMyQuery As String
        Get
            Return sql
        End Get
        Set(ByVal value As String)
            sql = value
        End Set
    End Property
    Public Property setIndividID As String
        Get
            Return dssID
        End Get
        Set(ByVal value As String)
            dssID = value
        End Set
    End Property

    Public Property SetCurrentFormMode As String

        Get
            Return frmMode
        End Get
        Set(ByVal value As String)
            frmMode = value
        End Set
    End Property

    Public Property GetDoB As String
        Get
            Return dob
        End Get
        Set(ByVal value As String)
            dob = value
        End Set
    End Property

    Public Property GetMyPatientID As Integer
        Get
            Return visitID
        End Get
        Set(ByVal value As Integer)
            visitID = value
        End Set
    End Property

    Public Property GetMyTable As String
        Get
            Return myTble
        End Get
        Set(ByVal value As String)
            myTble = value
        End Set
    End Property

    Public Property GetMySchema As String
        Get
            Return mySchema
        End Get
        Set(ByVal value As String)
            mySchema = value
        End Set
    End Property

    Public Property GetMyFormValidStatus As String
        Get
            Return myValidateStatus
        End Get
        Set(ByVal value As String)
            myValidateStatus = value
        End Set
    End Property
    Public Property GetMyTabControl
        Get
            Return myTabControl
        End Get
        Set(ByVal value)
            myTabControl = value
        End Set
    End Property

    Public Property GetMyColumnValue As String
        Get
            Return myColumn
        End Get
        Set(ByVal value As String)
            myColumn = value
        End Set
    End Property

    Public Property GetMyCheckedkedListBox As CheckedListBox
        Get
            Return myCheckedListBox
        End Get
        Set(ByVal value As CheckedListBox)
            myCheckedListBox = value
        End Set
    End Property

    Public Property GetMydataListValues As List(Of String)
        Get
            Return myDataList
        End Get
        Set(ByVal value As List(Of String))
            myDataList = value
        End Set
    End Property



    Public Sub FillListview()
        Select Case QLocation
            Case "lwak"

                lstVw.Columns.Add("DSSID", 80, HorizontalAlignment.Left)
                lstVw.Columns.Add("visit code", 90, HorizontalAlignment.Left)
                lstVw.Columns.Add("date / time ", 165, HorizontalAlignment.Left)
                lstVw.Columns.Add("category", 80, HorizontalAlignment.Left)
                lstVw.Columns.Add("juok name", 120, HorizontalAlignment.Left)
                lstVw.Columns.Add("last name", 120, HorizontalAlignment.Left)
                lstVw.Columns.Add("SEX", 80, HorizontalAlignment.Left)

            Case "kibera"
                lstVw.Columns.Add("DSSID", 80, HorizontalAlignment.Left)
                lstVw.Columns.Add("visit code", 90, HorizontalAlignment.Left)
                lstVw.Columns.Add("date / time ", 165, HorizontalAlignment.Left)
                lstVw.Columns.Add("category", 80, HorizontalAlignment.Left)
                lstVw.Columns.Add("NAME", 250, HorizontalAlignment.Left)
                lstVw.Columns.Add("Sex", 80, HorizontalAlignment.Left)
        End Select
    End Sub

    Public Sub GenericPatientListViewLoad(ByVal myLstvw As ListView, ByRef myQuery As String)

        GetMyListview = myLstvw

        setMyQuery = myQuery
        lstVw.Clear()

        FillListview()

        db.Connection.Open()
        Try
            Dim myDA As New SqlDataAdapter(setMyQuery, Qconn)
            Dim myDS As New DataSet()
            Dim myDT As New DataTable("queue")
            myDT.Clear()
            myDA.Fill(myDT)
            If myDT.Rows.Count > 0 Then
                Rec_Found = True
                lstVw.Items.Clear()
                Dim dr As DataRow
                Records = myDT.Rows.Count
                For Each dr In myDT.Rows
                    Dim lv As New ListViewItem
                    lv = lstVw.Items.Add(dr("INDIVIDID"))
                    lv.SubItems.Add(dr("visit").ToString)
                    lv.SubItems.Add(DateTime.Parse(dr("tdate").ToString))
                    lv.SubItems.Add(dr("cat").ToString)

                    Select Case QLocation
                        Case "lwak"
                            lv.SubItems.Add(dr("fname").ToString)
                            lv.SubItems.Add(dr("LName").ToString)
                        Case "kibera"
                            '  lv.SubItems.Add(dr("fname").ToString)
                            lv.SubItems.Add(dr("NAME").ToString)
                    End Select
                    lv.SubItems.Add(dr("SEX").ToString)
                    ' lv.SubItems.Add(dr("FNAME"))
                Next
            Else
                Rec_Found = False
                msgSuccess("No records avaialble!")
                Exit Sub
                Return
            End If

        Catch ex As Exception
            msgError("system error in building the patient queue to grid " + ex.Message)
            Exit Sub
            Return
        Finally
            db.Connection.Close()
        End Try

    End Sub

    Public Sub GetPatientsInQueuetoListView(ByVal myLstvw As ListView, ByVal crTb As String, ByVal ctlTb As String, ByVal crOptn As String, ByVal ctrlOptn As String)

        GetMyListview = myLstvw

        setMyQuery = objSQLLibrary.GetPatientLoadQuery(frmMode, crTb, ctlTb, crOptn, ctrlOptn)
        lstVw.Clear()

        FillListview()

        db.Connection.Open()
        Try
            Dim myDA As New SqlDataAdapter(sql, Qconn)
            Dim myDS As New DataSet()
            Dim myDT As New DataTable("queue")
            myDT.Clear()
            myDA.Fill(myDT)

            If myDT.Rows.Count > 0 Then
                Rec_Found = True
                lstVw.Items.Clear()
                Dim dr As DataRow
                Records = myDT.Rows.Count
                For Each dr In myDT.Rows
                    Dim lv As New ListViewItem
                    lv = lstVw.Items.Add(dr("INDIVIDID"))
                    lv.SubItems.Add(dr("visit").ToString)
                    lv.SubItems.Add(DateTime.Parse(dr("tdate").ToString))
                    lv.SubItems.Add(dr("cat").ToString)

                    Select Case QLocation
                        Case "lwak"
                            lv.SubItems.Add(dr("fname").ToString)
                            lv.SubItems.Add(dr("LName").ToString)
                        Case "kibera"
                            '  lv.SubItems.Add(dr("fname").ToString)
                            lv.SubItems.Add(dr("NAME").ToString)
                    End Select
                    lv.SubItems.Add(dr("clerk").ToString)
                    ' lv.SubItems.Add(dr("FNAME"))
                Next
            Else
                Rec_Found = False
                msgSuccess("No records available!")
            End If

        Catch ex As Exception
            msgError("system error in building the patient queue to grid " + ex.Message)
            Exit Sub
            Return
        Finally
            db.Connection.Close()
        End Try

    End Sub
    Public Sub GetPatientsInQueueXraySampleandLab(ByVal myLstvw As ListView, ByVal frmMode As String, ByVal mytbl As String, ByVal mydr As String, ByVal myschem As String)

        GetMyListview = myLstvw

        setMyQuery = objSQLLibrary.GetXrayQueueFormQueueTable(frmMode, mytbl, mydr, myschem)
        lstVw.Clear()
        FillListview()

        db.Connection.Open()
        Try
            Dim myDA As New SqlDataAdapter(sql, Qconn)
            Dim myDS As New DataSet()
            Dim myDT As New DataTable("queue")
            myDT.Clear()
            myDA.Fill(myDT)
            If myDT.Rows.Count > 0 Then
                Rec_Found = True
                lstVw.Items.Clear()
                Dim dr As DataRow
                Records = myDT.Rows.Count
                For Each dr In myDT.Rows
                    Dim lv As New ListViewItem
                    lv = lstVw.Items.Add(dr("INDIVIDID"))
                    lv.SubItems.Add(dr("visit").ToString)
                    lv.SubItems.Add(DateTime.Parse(dr("tdate").ToString))
                    lv.SubItems.Add(dr("cat").ToString)

                    Select Case QLocation
                        Case "lwak"
                            lv.SubItems.Add(dr("fname").ToString)
                            lv.SubItems.Add(dr("LName").ToString)
                        Case "kibera"
                            '  lv.SubItems.Add(dr("fname").ToString)
                            lv.SubItems.Add(dr("NAME").ToString)
                    End Select
                    lv.SubItems.Add(dr("clerk").ToString)
                    ' lv.SubItems.Add(dr("FNAME"))
                Next
            Else
                Rec_Found = False
                msgSuccess("No records avaialble!")
            End If

        Catch ex As Exception
            msgError("system error in building the patient queue to grid " + ex.Message)
            Exit Sub
            Return
        Finally
            db.Connection.Close()
        End Try

    End Sub



    'Public Sub GetPatientsInQueuetoListViewAdultExam(ByVal myLstvw As ListView, ByVal crTb As String, ByVal ctlTb As String, ByVal crOptn As String, ByVal ctrlOptn As String)

    '    GetMyListview = myLstvw

    '    setMyQuery = objSQLLibrary.GetPatientLoadQueryADULT(frmMode, crTb, ctlTb, crOptn, ctrlOptn)
    '    lstVw.Clear()

    '    FillListview()
    '    db.Connection.Open()
    '    Try
    '        Dim myDA As New SqlDataAdapter(sql, Qconn)
    '        Dim myDS As New DataSet()
    '        Dim myDT As New DataTable("queue")
    '        myDT.Clear()
    '        myDA.Fill(myDT)
    '        If myDT.Rows.Count > 0 Then
    '            Rec_Found = True
    '            lstVw.Items.Clear()
    '            Dim dr As DataRow
    '            Records = myDT.Rows.Count
    '            For Each dr In myDT.Rows
    '                Dim lv As New ListViewItem
    '                lv = lstVw.Items.Add(dr("INDIVIDID"))
    '                lv.SubItems.Add(dr("visit").ToString)
    '                lv.SubItems.Add(DateTime.Parse(dr("tdate").ToString))
    '                lv.SubItems.Add(dr("cat").ToString)
    '                lv.SubItems.Add(dr("fname").ToString)
    '                lv.SubItems.Add(dr("lname").ToString)
    '                lv.SubItems.Add(dr("clerk").ToString)
    '            Next
    '        Else
    '            Rec_Found = False
    '            msgSuccess("No records available!")
    '        End If

    '    Catch ex As Exception
    '        msgError("system error in building the patient queue to grid " + ex.Message)
    '        Exit Sub
    '        Return
    '    Finally
    '        db.Connection.Close()
    '    End Try

    'End Sub
    Public Sub GetPatientsInQueuetoListViewChildExam(ByVal myLstvw As ListView, ByVal crTb As String, ByVal ctlTb As String, ByVal crOptn As String, ByVal ctrlOptn As String)

        GetMyListview = myLstvw

        setMyQuery = objSQLLibrary.GetPatientLoadQueryCHILD(frmMode, crTb, ctlTb, crOptn, ctrlOptn)
        lstVw.Clear()

        FillListview()

        db.Connection.Open()
        Try
            Dim myDA As New SqlDataAdapter(sql, Qconn)
            Dim myDS As New DataSet()
            Dim myDT As New DataTable("queue")
            myDT.Clear()
            myDA.Fill(myDT)
            If myDT.Rows.Count > 0 Then
                Rec_Found = True
                lstVw.Items.Clear()
                Dim dr As DataRow
                Records = myDT.Rows.Count
                For Each dr In myDT.Rows
                    Dim lv As New ListViewItem
                    lv = lstVw.Items.Add(dr("INDIVIDID"))
                    lv.SubItems.Add(dr("visit").ToString)
                    lv.SubItems.Add(DateTime.Parse(dr("tdate").ToString))
                    lv.SubItems.Add(dr("cat").ToString)

                    Select Case QLocation
                        Case "lwak"
                            lv.SubItems.Add(dr("fname").ToString)
                            lv.SubItems.Add(dr("LName").ToString)
                        Case "kibera"
                            '  lv.SubItems.Add(dr("fname").ToString)
                            lv.SubItems.Add(dr("NAME").ToString)
                    End Select
                    lv.SubItems.Add(dr("clerk").ToString)
                    ' lv.SubItems.Add(dr("FNAME"))
                Next
            Else
                Rec_Found = False
                msgSuccess("No records available!")
            End If

        Catch ex As Exception
            msgError("system error in building the patient queue to grid " + ex.Message)
            Exit Sub
            Return
        Finally
            db.Connection.Close()
        End Try

    End Sub
    Public Sub GetPatientsInQueuetoListViewDoctorSpecific(ByVal myLstvw As ListView, ByVal crTb As String, ByVal ctlTb As String, ByVal crOptn As String, ByVal ctrlOptn As String)

        GetMyListview = myLstvw

        setMyQuery = objSQLLibrary.GetPatientLoadQuerySpecificToDoctor(frmMode, crTb, ctlTb, crOptn, ctrlOptn)
        lstVw.Clear()
        FillListview()

        db.Connection.Open()
        Try
            Dim myDA As New SqlDataAdapter(sql, Qconn)
            Dim myDS As New DataSet()
            Dim myDT As New DataTable("queue")
            myDT.Clear()
            myDA.Fill(myDT)
            If myDT.Rows.Count > 0 Then
                Rec_Found = True
                lstVw.Items.Clear()
                Dim dr As DataRow
                Records = myDT.Rows.Count
                For Each dr In myDT.Rows
                    Dim lv As New ListViewItem
                    lv = lstVw.Items.Add(dr("INDIVIDID"))
                    lv.SubItems.Add(dr("visit").ToString)
                    lv.SubItems.Add(DateTime.Parse(dr("tdate").ToString))
                    lv.SubItems.Add(dr("cat").ToString)

                    Select Case QLocation
                        Case "lwak"
                            lv.SubItems.Add(dr("fname").ToString)
                            lv.SubItems.Add(dr("LName").ToString)
                        Case "kibera"
                            '  lv.SubItems.Add(dr("fname").ToString)
                            lv.SubItems.Add(dr("NAME").ToString)
                    End Select
                    lv.SubItems.Add(dr("clerk").ToString)
                    ' lv.SubItems.Add(dr("FNAME"))
                Next
            Else
                Rec_Found = False
                msgSuccess("No records available!")
            End If

        Catch ex As Exception
            msgError("system error in building the patient queue to grid " + ex.Message)
            Exit Sub
            Return
        Finally
            db.Connection.Close()
        End Try

    End Sub
    Public Sub GetPatientsInQueuetoListViewDoctorSpecificPool(ByVal myLstvw As ListView, ByVal crTb As String, ByVal ctlTb As String, ByVal crOptn As String, ByVal ctrlOptn As String)

        GetMyListview = myLstvw

        setMyQuery = objSQLLibrary.GetPatientLoadQuerySpecificToDoctorCommon(frmMode, crTb, ctlTb, crOptn, ctrlOptn)
        lstVw.Clear()
        FillListview()

        db.Connection.Open()
        Try
            Dim myDA As New SqlDataAdapter(sql, Qconn)
            Dim myDS As New DataSet()
            Dim myDT As New DataTable("queue")
            myDT.Clear()
            myDA.Fill(myDT)
            If myDT.Rows.Count > 0 Then
                Rec_Found = True
                lstVw.Items.Clear()
                Dim dr As DataRow
                Records = myDT.Rows.Count
                For Each dr In myDT.Rows
                    Dim lv As New ListViewItem
                    lv = lstVw.Items.Add(dr("INDIVIDID"))
                    lv.SubItems.Add(dr("visit").ToString)
                    lv.SubItems.Add(DateTime.Parse(dr("tdate").ToString))
                    lv.SubItems.Add(dr("cat").ToString)

                    Select Case QLocation
                        Case "lwak"
                            lv.SubItems.Add(dr("fname").ToString)
                            lv.SubItems.Add(dr("LName").ToString)
                        Case "kibera"
                            '  lv.SubItems.Add(dr("fname").ToString)
                            lv.SubItems.Add(dr("NAME").ToString)
                    End Select
                    lv.SubItems.Add(dr("clerk").ToString)
                    ' lv.SubItems.Add(dr("FNAME"))
                Next
            Else
                Rec_Found = False
                msgSuccess("No records available!")
            End If

        Catch ex As Exception
            msgError("system error in building the patient queue to grid " + ex.Message)
            Exit Sub
            Return
        Finally
            db.Connection.Close()
        End Try

    End Sub
    Public Sub GetPatientsInQueuetoListViewQueueTables(ByVal myLstvw As ListView, ByVal crTb As String, ByVal ctlTb As String, ByVal crOptn As String)

        GetMyListview = myLstvw

        setMyQuery = objSQLLibrary.GetPatientLoadQuerySpecificQueueTable(frmMode, crTb, ctlTb, crOptn)
        lstVw.Clear()
        FillListview()

        db.Connection.Open()
        Try
            Dim myDA As New SqlDataAdapter(sql, Qconn)
            Dim myDS As New DataSet()
            Dim myDT As New DataTable("queue")
            myDT.Clear()
            myDA.Fill(myDT)
            If myDT.Rows.Count > 0 Then
                Rec_Found = True
                lstVw.Items.Clear()
                Dim dr As DataRow
                Records = myDT.Rows.Count
                For Each dr In myDT.Rows
                    Dim lv As New ListViewItem
                    lv = lstVw.Items.Add(dr("INDIVIDID"))
                    lv.SubItems.Add(dr("visit").ToString)
                    lv.SubItems.Add(DateTime.Parse(dr("tdate").ToString))
                    lv.SubItems.Add(dr("cat").ToString)

                    Select Case QLocation
                        Case "lwak"
                            lv.SubItems.Add(dr("fname").ToString)
                            lv.SubItems.Add(dr("LName").ToString)
                        Case "kibera"
                            '  lv.SubItems.Add(dr("fname").ToString)
                            lv.SubItems.Add(dr("NAME").ToString)
                    End Select
                    lv.SubItems.Add(dr("clerk").ToString)
                    ' lv.SubItems.Add(dr("FNAME"))
                Next
            Else
                Rec_Found = False
                msgSuccess("No records available!")
            End If

        Catch ex As Exception
            msgError("system error in building the patient queue to grid " + ex.Message)
            Exit Sub
            Return
        Finally
            db.Connection.Close()
        End Try

    End Sub
    Public Sub GetDoctorsLabResultsQueue(ByVal myLstvw As ListView, ByVal fdate As Date, ByVal myDr As String)

        GetMyListview = myLstvw

        setMyQuery = objSQLLibrary.GetLabResultsQueue(fdate, myDr)
        lstVw.Clear()
        FillListview()

        db.Connection.Open()
        Try
            Dim myDA As New SqlDataAdapter(sql, Qconn)
            Dim myDS As New DataSet()
            Dim myDT As New DataTable("queue")
            myDT.Clear()
            myDA.Fill(myDT)
            If myDT.Rows.Count > 0 Then
                Rec_Found = True
                lstVw.Items.Clear()
                Dim dr As DataRow
                Records = myDT.Rows.Count
                For Each dr In myDT.Rows
                    Dim lv As New ListViewItem
                    Select Case QLocation
                        Case "lwak"
                            lv = lstVw.Items.Add(dr("INDIVIDID"))
                            lv.SubItems.Add(dr("visit").ToString)
                            lv.SubItems.Add(DateTime.Parse(dr("tdate").ToString))
                            lv.SubItems.Add(dr("cat").ToString)
                            lv.SubItems.Add(dr("fname").ToString)
                            lv.SubItems.Add(dr("lname").ToString)
                            lv.SubItems.Add(dr("SEX").ToString)
                        Case "kibera"
                            lv = lstVw.Items.Add(dr("INDIVIDID"))
                            lv.SubItems.Add(dr("visit").ToString)
                            lv.SubItems.Add(DateTime.Parse(dr("tdate").ToString))
                            lv.SubItems.Add(dr("cat").ToString)
                            lv.SubItems.Add(dr("NAME").ToString)
                            lv.SubItems.Add(dr("SEX").ToString)
                    End Select
                Next
            Else
                Rec_Found = False
                msgSuccess("No records available!")
            End If

        Catch ex As Exception
            msgError("system error in building the patient queue to grid " + ex.Message)
            Exit Sub
            Return
        Finally
            db.Connection.Close()
        End Try

    End Sub
    Public Sub GetDoctorSpecificXrayQueue(ByVal myLstvw As ListView, ByVal fdate As Date, ByVal myDr As String)
        GetMyListview = myLstvw

        setMyQuery = objSQLLibrary.GetXrayQueue(fdate, myDr)
        lstVw.Clear()

        FillListview()

        db.Connection.Open()
        Try
            Dim myDA As New SqlDataAdapter(sql, Qconn)
            Dim myDS As New DataSet()
            Dim myDT As New DataTable("queue")
            myDT.Clear()
            myDA.Fill(myDT)
            If myDT.Rows.Count > 0 Then
                Rec_Found = True
                lstVw.Items.Clear()
                Dim dr As DataRow
                Records = myDT.Rows.Count
                For Each dr In myDT.Rows
                    Dim lv As New ListViewItem
                    lv = lstVw.Items.Add(dr("INDIVIDID"))
                    lv.SubItems.Add(dr("visit").ToString)
                    lv.SubItems.Add(DateTime.Parse(dr("tdate").ToString))
                    lv.SubItems.Add(dr("cat").ToString)

                    Select Case QLocation
                        Case "lwak"
                            lv.SubItems.Add(dr("fname").ToString)
                            lv.SubItems.Add(dr("LName").ToString)
                        Case "kibera"
                            '  lv.SubItems.Add(dr("fname").ToString)
                            lv.SubItems.Add(dr("NAME").ToString)
                    End Select
                    lv.SubItems.Add(dr("clerk").ToString)
                    ' lv.SubItems.Add(dr("FNAME"))
                Next
            Else
                Rec_Found = False
                msgSuccess("No records available!")
            End If

        Catch ex As Exception
            msgError("system error in building the patient queue to grid " + ex.Message)
            Exit Sub
            Return
        Finally
            db.Connection.Close()
        End Try

    End Sub

    Public Sub GetDoctorsWorkLoadQueue(ByVal myLstvw As ListView, ByVal myQry As String, ByVal PID As String, ByVal tbl As String)

        GetMyListview = myLstvw
        setIndividID = PID

        'setMyQuery = objWorkLoad.WorkLoadQuery(PID, tbl)
        lstVw.Clear()

        FillListview()

        db.Connection.Open()
        Try
            Dim myDA As New SqlDataAdapter(sql, Qconn)
            Dim myDS As New DataSet()
            Dim myDT As New DataTable("queue")
            myDT.Clear()
            myDA.Fill(myDT)
            If myDT.Rows.Count > 0 Then
                Rec_Found = True
                lstVw.Items.Clear()
                Dim dr As DataRow
                Records = myDT.Rows.Count
                For Each dr In myDT.Rows
                    Dim lv As New ListViewItem
                    lv = lstVw.Items.Add(dr("INDIVIDID"))
                    lv.SubItems.Add(dr("visit").ToString)
                    lv.SubItems.Add(DateTime.Parse(dr("tdate").ToString))
                    lv.SubItems.Add(dr("cat").ToString)

                    Select Case QLocation
                        Case "lwak"
                            lv.SubItems.Add(dr("fname").ToString)
                            lv.SubItems.Add(dr("LName").ToString)
                        Case "kibera"
                            '  lv.SubItems.Add(dr("fname").ToString)
                            lv.SubItems.Add(dr("NAME").ToString)
                    End Select
                    lv.SubItems.Add(dr("clerk").ToString)
                    ' lv.SubItems.Add(dr("FNAME"))
                Next
            Else
                Rec_Found = False
                msgSuccess("No records avaialble!")
            End If
        Catch ex As Exception
            msgError("system error in building the patient queue to grid " + ex.Message)
            Exit Sub
            Return
        Finally
            db.Connection.Close()
        End Try

    End Sub

    Public Sub GetGenericPatientQueueUsingQueryMode(ByVal myLstvw As ListView, ByVal mymod As String)

        GetMyListview = myLstvw
        SetCurrentFormMode = mymod
        setMyQuery = objSQLLibrary.GetXSampleToBarcodeQueueTable(SetCurrentFormMode)
        lstVw.Clear()

        FillListview()

        db.Connection.Open()
        Try
            Dim myDA As New SqlDataAdapter(sql, Qconn)
            Dim myDS As New DataSet()
            Dim myDT As New DataTable("queue")
            myDT.Clear()
            myDA.Fill(myDT)
            If myDT.Rows.Count > 0 Then
                Rec_Found = True
                lstVw.Items.Clear()
                Dim dr As DataRow
                Records = myDT.Rows.Count
                For Each dr In myDT.Rows
                    Dim lv As New ListViewItem
                    lv = lstVw.Items.Add(dr("INDIVIDID"))
                    lv.SubItems.Add(dr("visit").ToString)
                    lv.SubItems.Add(DateTime.Parse(dr("tdate").ToString))
                    lv.SubItems.Add(dr("cat").ToString)

                    Select Case QLocation
                        Case "lwak"
                            lv.SubItems.Add(dr("fname").ToString)
                            lv.SubItems.Add(dr("LName").ToString)
                        Case "kibera"
                            '  lv.SubItems.Add(dr("fname").ToString)
                            lv.SubItems.Add(dr("NAME").ToString)
                    End Select
                    lv.SubItems.Add(dr("clerk").ToString)
                    ' lv.SubItems.Add(dr("FNAME"))
                Next
            Else
                Rec_Found = False
                msgSuccess("No records avaialble!")
            End If

        Catch ex As Exception
            msgError("system error in building the patient queue to grid " + ex.Message)
            Exit Sub
            Return
        Finally
            db.Connection.Close()
        End Try

    End Sub
    Public Sub GetDiagnosisPatientQueue(ByVal myLstvw As ListView, ByVal mymod As String)

        GetMyListview = myLstvw
        SetCurrentFormMode = mymod
        setMyQuery = objSQLLibrary.GetPatientQueueDiagnosis(SetCurrentFormMode)
        lstVw.Clear()

        FillListview()

        db.Connection.Open()
        Try
            Dim myDA As New SqlDataAdapter(sql, Qconn)
            Dim myDS As New DataSet()
            Dim myDT As New DataTable("queue")
            myDT.Clear()
            myDA.Fill(myDT)
            If myDT.Rows.Count > 0 Then
                Rec_Found = True
                lstVw.Items.Clear()
                Dim dr As DataRow
                Records = myDT.Rows.Count
                For Each dr In myDT.Rows
                    Dim lv As New ListViewItem
                    lv = lstVw.Items.Add(dr("INDIVIDID"))
                    lv.SubItems.Add(dr("visit").ToString)
                    lv.SubItems.Add(DateTime.Parse(dr("tdate").ToString))
                    lv.SubItems.Add(dr("cat").ToString)

                    Select Case QLocation
                        Case "lwak"
                            lv.SubItems.Add(dr("fname").ToString)
                            lv.SubItems.Add(dr("LName").ToString)
                        Case "kibera"
                            '  lv.SubItems.Add(dr("fname").ToString)
                            lv.SubItems.Add(dr("NAME").ToString)
                    End Select
                    lv.SubItems.Add(dr("clerk").ToString)
                    ' lv.SubItems.Add(dr("FNAME"))
                Next
            Else
                Rec_Found = False
                msgSuccess("No records avaialble!")
            End If

        Catch ex As Exception
            msgError("system error in building the patient queue to grid " + ex.Message)
            Exit Sub
            Return
        Finally
            db.Connection.Close()
        End Try

    End Sub
    Public Sub GetDiagnosisPatientLaboratoryQueue(ByVal myLstvw As ListView, ByVal mymod As String)

        GetMyListview = myLstvw
        SetCurrentFormMode = mymod
        setMyQuery = objSQLLibrary.GetPatientQueueLaboratory(SetCurrentFormMode)
        lstVw.Clear()
        FillListview()

        db.Connection.Open()
        Try
            Dim myDA As New SqlDataAdapter(sql, Qconn)
            Dim myDS As New DataSet()
            Dim myDT As New DataTable("queue")
            myDT.Clear()
            myDA.Fill(myDT)
            If myDT.Rows.Count > 0 Then
                Rec_Found = True
                lstVw.Items.Clear()
                Dim dr As DataRow
                Records = myDT.Rows.Count
                For Each dr In myDT.Rows
                    Dim lv As New ListViewItem
                    lv = lstVw.Items.Add(dr("INDIVIDID"))
                    lv.SubItems.Add(dr("visit").ToString)
                    lv.SubItems.Add(DateTime.Parse(dr("tdate").ToString))
                    lv.SubItems.Add(dr("cat").ToString)

                    Select Case QLocation
                        Case "lwak"
                            lv.SubItems.Add(dr("fname").ToString)
                            lv.SubItems.Add(dr("LName").ToString)
                        Case "kibera"
                            '  lv.SubItems.Add(dr("fname").ToString)
                            lv.SubItems.Add(dr("NAME").ToString)
                    End Select
                    lv.SubItems.Add(dr("clerk").ToString)
                    ' lv.SubItems.Add(dr("FNAME"))
                Next
            Else
                Rec_Found = False
                msgSuccess("No records available!")
            End If

        Catch ex As Exception
            msgError("System error in building the patient queue to grid " + ex.Message)
            Exit Sub
            Return
        Finally
            db.Connection.Close()
        End Try

    End Sub
    Public Sub GetDiagnosisPatientLaboratoryNurseQueue(ByVal myLstvw As ListView, ByVal mymod As String)

        GetMyListview = myLstvw
        SetCurrentFormMode = mymod
        setMyQuery = objSQLLibrary.GetPatientLoadSamplesQuery(SetCurrentFormMode)
        lstVw.Clear()

        FillListview()

        db.Connection.Open()
        Try
            Dim myDA As New SqlDataAdapter(sql, Qconn)
            Dim myDS As New DataSet()
            Dim myDT As New DataTable("queue")
            myDT.Clear()
            myDA.Fill(myDT)
            If myDT.Rows.Count > 0 Then
                Rec_Found = True
                lstVw.Items.Clear()
                Dim dr As DataRow
                Records = myDT.Rows.Count
                For Each dr In myDT.Rows
                    Dim lv As New ListViewItem
                    lv = lstVw.Items.Add(dr("INDIVIDID"))
                    lv.SubItems.Add(dr("visit").ToString)
                    lv.SubItems.Add(DateTime.Parse(dr("tdate").ToString))
                    lv.SubItems.Add(dr("cat").ToString)

                    Select Case QLocation
                        Case "lwak"
                            lv.SubItems.Add(dr("fname").ToString)
                            lv.SubItems.Add(dr("LName").ToString)
                        Case "kibera"
                            '  lv.SubItems.Add(dr("fname").ToString)
                            lv.SubItems.Add(dr("NAME").ToString)
                    End Select
                    lv.SubItems.Add(dr("clerk").ToString)
                    ' lv.SubItems.Add(dr("FNAME"))
                Next
            Else
                Rec_Found = False
                msgSuccess("No records avaialble!")
            End If

        Catch ex As Exception
            msgError("system error in building the patient queue to grid " + ex.Message)
            Exit Sub
            Return
        Finally
            db.Connection.Close()
        End Try

    End Sub
    Public Sub GetCurrentPatientStatus(ByRef dob As Date)

        GetDoB = dob
        Dim age = getAge(dob) 'calculate the patients age
        If age >= 5 Then 'identify if child or adult
            patient = "ADULT"
        Else
            patient = "CHILD"
        End If

    End Sub
    Public Sub GetCurrentPatientStatusKibera(ByRef dob As Date)

        GetDoB = dob
        Dim age = getAge(dob) 'calculate the patients age
        If age >= 5 Then 'identify if child or adult
            patient = "ADULT"
        Else
            patient = "CHILD"
        End If

    End Sub

    Public Sub GetPatientStatusUsingDSSID(ByVal dssid As String)

        Dim DoB As Date = Get_Birth_Date(dssid)
        GetDoB = DoB
        Dim age = getAge(DoB) 'calculate the patients age
        If age >= 5 Then 'identify if child or adult
            patient = "ADULT"
        Else
            patient = "CHILD"
        End If
    End Sub

    Public Sub DeletePatientRecords(ByVal vsID As Integer, ByVal tbl As String, ByVal schema As String)

        GetMyPatientID = vsID
        GetMyTable = tbl
        GetMySchema = schema

        Cursor.Current = Cursors.WaitCursor
        db.Connection.Open()
        Dim dbTrans = db.Connection.BeginTransaction

        Select Case MsgBox("Are you sure you want to delete this record " & visitID, MsgBoxStyle.YesNo, "")
            Case MsgBoxResult.Yes
                Try
                    '    db.manage_Freezers(1, 2, 2, "", 2, 2, 2, 21)
                    db.DeletePatientRecord(visitID, "settings", mySchema)
                    '  db.DeletePatientRecord(visitID, myTble, mySchema)
                    '   db.DeletePatientRecord(visitID, myTble, mySchema)

                    db.SubmitChanges() ' save changes to the database
                    dbTrans.Commit() ' commit saved changes to database
                    msgSuccess("Patient's risk factors details successfully deleted!")
                Catch ex As Exception
                    msgError("internal application error deleteing patient's risk factors records! " + ex.Message)
                    dbTrans.Rollback()
                    Exit Sub
                    Return
                Finally
                    db.Connection.Close()
                End Try
                Cursor.Current = Cursors.Default
            Case MsgBoxResult.No
                Exit Sub
        End Select
    End Sub

    Public Sub updateMyJobQueue(ByVal vsID As Integer, ByRef sectn As String)
        GetMyPatientID = vsID
        '  Cursor.Current = Cursors.WaitCursor
        Cursor.Current = Cursors.WaitCursor
        db.Connection.Open()
        Dim dbTrans = db.Connection.BeginTransaction
        Try

            db.JobQueueupdateManager(GetMyPatientID, "" + sectn + "")
            'db.SaveChanges()
            db.SubmitChanges()
            'db.Transaction.Commit()
            'db.ObjectTrackingEnabled
            dbTrans.Commit()

        Catch ex As Exception
            msgError("internal application error in updating patient's jobqueue management information! " + ex.Message)
            dbTrans.Rollback()
            Return
        Finally
            db.Connection.Close()
        End Try
        Cursor.Current = Cursors.Default

    End Sub

    Public Sub updateMyTableRecords(ByVal mytbl As String, ByVal myschema As String, ByVal myclmn As String, ByVal myvalue As String, ByVal vsID As Integer)
        GetMyPatientID = vsID
        Cursor.Current = Cursors.WaitCursor

        Try
            openConn()
            Dim mysql As String = "UPDATE [PCS].[" + myschema + "].[" + mytbl + "] SET " + myclmn + "='" + myvalue + "' WHERE status='NO' AND Visit_ID=" & GetMyPatientID
            Dim mycmd As New SqlCommand(mysql, Qconn)
            Dim k As Integer = mycmd.ExecuteNonQuery
            If k > 0 Then
                msgSuccess("Patient table updated successfully !")
            End If
        Catch ex As Exception
            msgError("error in updating table information! " + ex.Message)
            Exit Sub
            'Return
        Finally
            'closeConn()
        End Try
        Cursor.Current = Cursors.Default
    End Sub

    Public Function validateControlsOnTabControl(ByVal tbc As TabControl)
        Dim nud As NumericUpDown
        Dim chlstBox As CheckedListBox
        Dim cbo As ComboBox
        GetMyTabControl = tbc
        GetMyFormValidStatus = "valid"
        For Each tab As TabPage In GetMyTabControl.TabPages

            For Each ctrl As Control In tab.Controls
                If ctrl.Enabled = True And ctrl.Visible Then

                    If (TypeOf ctrl Is GroupBox) Then

                        GetMyFormValidStatus = validateFormsInGroupBox(ctrl)
                        Select Case GetMyFormValidStatus
                            Case "invalid"
                                ctrl.Focus()
                                Exit For
                        End Select
                    End If
                    If (TypeOf ctrl Is TextBox) Then
                        If ctrl.Text.Trim = "" Or ctrl.Text.Trim = Nothing Then
                            msgError("Please provide " + ctrl.Name + " values before save")
                            ctrl.Focus()
                            ctrl.BackColor = Color.Red
                            GetMyFormValidStatus = "invalid"
                            ctrl.Focus()
                            Exit For
                        End If
                    End If
                    If (TypeOf ctrl Is ComboBox) Then
                        cbo = ctrl
                        If cbo.Text.Trim = "" Or ctrl.Text.Trim = "NULL" Then
                            GetMyFormValidStatus = "invalid"
                            ctrl.Focus()
                            ctrl.BackColor = Color.Red
                            ctrl.Select()
                            ctrl.Focus()
                            msgError("Please provide " + ctrl.Name + " values before save")
                            Exit For
                        End If
                    End If
                    If (TypeOf ctrl Is NumericUpDown) Then
                        nud = ctrl
                        If (nud.Value = 0 Or nud.Value = Nothing) Then
                            GetMyFormValidStatus = "invalid"
                            ctrl.Focus()
                            ctrl.BackColor = Color.Red
                            msgError("Please provide " + ctrl.Name + " values before save")
                            Exit For
                        End If
                    End If
                    If (TypeOf ctrl Is CheckedListBox) Then
                        chlstBox = ctrl
                        If chlstBox.CheckedItems.Count < 0 Then
                            GetMyFormValidStatus = "invalid"
                            ctrl.Focus()
                            ctrl.BackColor = Color.Red
                            msgError("Atleast one (1) option must be checked for " + ctrl.Name + " values before save")
                            Exit For
                        End If
                    End If

                End If
            Next
        Next
        Return GetMyFormValidStatus
    End Function

    Public Function validateFormsInGroupBox(ByVal grpBox As GroupBox)
        Dim nud As NumericUpDown
        Dim chlstBox As CheckedListBox
        Dim cbo As ComboBox
        Dim ctrl As Control
        For Each ctrl In grpBox.Controls
            If ctrl.Enabled = True Then
                If (TypeOf ctrl Is TextBox) Then
                    If ctrl.Text = "" Then
                        GetMyFormValidStatus = "invalid"
                        ctrl.Focus()
                        ctrl.BackColor = Color.Red
                        msgError("Please provide " + ctrl.Name + " values before save")
                        Exit For
                    End If
                End If
                If (TypeOf ctrl Is ComboBox) Then
                    cbo = ctrl
                    If cbo.Text = "" Or ctrl.Text = "NULL" Then
                        GetMyFormValidStatus = "invalid"
                        ctrl.Focus()
                        ctrl.BackColor = Color.Red
                        msgError("Please provide " + ctrl.Name + " values before save")
                        Exit For
                    End If
                End If
                If (TypeOf ctrl Is NumericUpDown) Then
                    nud = ctrl
                    If (nud.Value = 0 Or nud.Value = Nothing) Then
                        GetMyFormValidStatus = "invalid"
                        ctrl.Focus()
                        ctrl.BackColor = Color.Red
                        msgError("Please provide " + ctrl.Name + " values before save")
                        Exit For
                    End If
                End If
                If (TypeOf ctrl Is CheckedListBox) Then
                    chlstBox = ctrl
                    If chlstBox.CheckedItems.Count < 0 Then
                        GetMyFormValidStatus = "invalid"
                        ctrl.Focus()
                        ctrl.BackColor = Color.Red
                        msgError("Atleast one (1) option must be checked for " + ctrl.Name + " values before save")
                        Exit For
                    End If
                End If
            End If
        Next
        Return GetMyFormValidStatus
    End Function

    Public Sub GetMyDataTableValues(ByVal tbl As String, ByVal schma As String, ByVal clm As String, ByVal chlb As CheckedListBox, ByVal vsID As Integer)

        GetMyTable = tbl
        GetMySchema = schma
        GetMyCheckedkedListBox = chlb
        GetMyPatientID = vsID
        GetMyColumnValue = clm
        Dim drValue As String = Nothing
        Dim ListCount As Integer = 0

        Try
            openConn()
            Dim myQuery As String = "SELECT " + GetMyColumnValue + " FROM [elab].[" + GetMySchema + "].[" + GetMyTable + "] WHERE Visit_ID=" & GetMyPatientID
            Dim mycmd As New SqlCommand(myQuery, Qconn)
            Dim mydr As SqlDataReader = mycmd.ExecuteReader
            If mydr.HasRows Then
                While mydr.Read
                    GetMydataListValues.Add(mydr.Item("" + GetMyColumnValue + ""))
                End While
                mydr.Close()
            Else
                msgWarn("No patient records to retrieve!")
            End If
        Catch ex As Exception
            msgError("system error in mining patient data " + ex.Message)
            Exit Sub
            Return
        Finally
            closeConn()
        End Try

        uncheckList(GetMyCheckedkedListBox) ' Reset the checkListBox control

        For i As Integer = 0 To GetMydataListValues.Count - 1
            For j As Integer = 0 To GetMyCheckedkedListBox.Items.Count - 1
                ListCount = InStr("" & GetMydataListValues(i), "" & GetMyCheckedkedListBox.Items(j), CompareMethod.Text)
                If ListCount > 0 Then
                    GetMyCheckedkedListBox.SetItemCheckState(j, CheckState.Checked)
                End If
            Next j
        Next i

    End Sub

    Public Sub ClearControlsInGroupBox(ByVal grpBox As GroupBox)

        Dim nud As NumericUpDown
        Dim chlstBox As CheckedListBox
        Dim cbo As ComboBox
        Dim ctrl As Control
        Dim tbox As TextBox

        For Each ctrl In grpBox.Controls

            If (TypeOf ctrl Is TextBox) Then
                tbox = ctrl
                tbox.Clear()
            End If
            If (TypeOf ctrl Is ComboBox) Then
                cbo = ctrl
                cbo.DataSource = Nothing
            End If
            If (TypeOf ctrl Is NumericUpDown) Then
                nud = ctrl
                nud.Value = 0
            End If
            If (TypeOf ctrl Is CheckedListBox) Then
                chlstBox = ctrl
                chlstBox.ClearSelected()
            End If

        Next

    End Sub

    Public Function GetMyCountsWorkLoadSchedule(ByVal category As String, ByVal myDay As String)

        Dim myCount As Integer = 0
        Dim myQuery As String = Nothing

        Try
            openConn()
            Select Case category
                Case "pending"
                    Select Case myDay

                        Case "today"
                            myQuery = "SELECT *  FROM [PCS].[settings].[workLoadSchedule] WHERE Rec_Date like' " + Date.Today.Date + "%' AND job_status='pending' AND doctor='" + Cuser + "'"
                        Case "all"
                            myQuery = "SELECT *  FROM [PCS].[settings].[workLoadSchedule] WHERE Rec_Date<>'" + Date.Today + "' AND job_status='pending' AND doctor='" + Cuser + "'"
                    End Select
                Case "complete"
                    Select Case myDay
                        Case "today"
                            myQuery = "SELECT *  FROM [PCS].[settings].[workLoadSchedule] WHERE Rec_Date like '" + Date.Today + "%' AND job_status='complete' AND doctor='" + Cuser + "'"
                        Case "all"
                            myQuery = "SELECT *  FROM [PCS].[settings].[workLoadSchedule] WHERE  doctor='" + Cuser + "'"
                    End Select
            End Select
            Dim DA As New SqlDataAdapter(myQuery, Qconn)
            Dim DS As New DataSet()
            Dim DT As New DataTable("jobCount")
            DT.Clear()
            DA.Fill(DT)
            If DT.Rows.Count > 0 Then
                myCount = DT.Rows.Count
            End If
        Catch ex As Exception
            msgError("application error in counting lab/xray/samples record statistics " + ex.Message)

        Finally
            closeConn()
        End Try
        Return myCount

    End Function

    Public Function GetMyCounts(ByVal tbl As String, ByVal schm As String, ByVal clmn As String, ByVal cond As String)

        Dim myCount As Integer = 0
        Dim myQuery As String = Nothing

        Try
            openConn()

            myQuery = "SELECT * FROM [PCS].[" + schm + "].[" + tbl + "] WHERE " + clmn + "='" + cond + "' AND officer='" + Cuser + "'"
            Dim DA As New SqlDataAdapter(myQuery, Qconn)
            Dim DS As New DataSet()
            Dim DT As New DataTable("jobCount")
            DT.Clear()
            DA.Fill(DT)
            If DT.Rows.Count > 0 Then
                myCount = DT.Rows.Count
            End If
        Catch ex As Exception
            msgError("application error in counting doctor record statistics " + ex.Message)
        Finally
            closeConn()
        End Try
        Return myCount

    End Function
    Public Function GetMyTreeViewCounts()

        Dim myCount As Integer = 0
        Dim myQuery As String = Nothing

        Try
            openConn()

            myQuery = objSQLLibrary.GetPatientLoadQuerySpecificToDoctorCommon("examination", "examination", "riskfactors", "NO", "YES")
            Dim DA As New SqlDataAdapter(myQuery, Qconn)
            Dim DS As New DataSet()
            Dim DT As New DataTable("jobCount")
            DT.Clear()
            DA.Fill(DT)
            If DT.Rows.Count > 0 Then
                myCount = DT.Rows.Count
            End If
        Catch ex As Exception
            msgError("application error in counting doctor record statistics " + ex.Message)

        Finally
            closeConn()
        End Try
        Return myCount

    End Function
    Public Function CheckEmptyControls(ByVal container As Control) As Boolean
        Dim returnvalue As Boolean = True
        For Each cntrl As Control In container.Controls
            If cntrl.Enabled = True And cntrl.Text = "Null" And cntrl.Visible = True Then
                'MessageBox.Show("Some Information is missing! ", "IEIP-PCS: Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cntrl.BackColor = Color.Red
                returnvalue = False
                Return returnvalue
            ElseIf cntrl.Enabled = True And cntrl.Text = "NULL" And cntrl.Visible Then
                cntrl.BackColor = Color.Red
                returnvalue = False
                Return returnvalue
            ElseIf cntrl.Enabled = True And cntrl.Text = "" And cntrl.Visible Then
                'MessageBox.Show("Some Information is missing! ", "IEIP-PCS: Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cntrl.BackColor = Color.Red
                returnvalue = False
                Return returnvalue
            Else
                returnvalue = True
                cntrl.BackColor = Color.White
            End If
        Next
        Return returnvalue
    End Function

    Public Sub ShowPCSMode(ByVal frm As Form)
        mdiLIMS.lblilabMode.Text = ilab_Mode
        Select Case ilab_Mode
            Case "Add"
                frm.BackColor = Color.DimGray
                mdiLIMS.lblilabMode.Text = "ADD"
                mdiLIMS.lblilabMode.BackColor = Color.LightGreen
            Case "Edit"
                frm.BackColor = Color.LightPink
                mdiLIMS.lblilabMode.Text = "EDIT Mode"
                mdiLIMS.lblilabMode.BackColor = Color.Red
        End Select
    End Sub

    Private Sub load_dgv(frm As frmResults)
        db = New iLabDataContext
        db.Connection.Open()
        Dim query
        Try
            query = db.Proc_select_Results()

            frm.DataGridView2.DataSource = query
            db.Connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            db.Connection.Close()
        End Try
    End Sub
End Class
