Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.Form
Imports System.Security.Cryptography
Imports System.Text


Module eLABModulle
    '******************************************************************************************************************
    '************************************  my public variables  ********************************************
    '******************************************************************************************************************

    Dim con As String = My.MySettings.Default.eLabConnectionString

    Public interFormID As String = Nothing
    Public interDate As Date = Nothing
    Public Cuser As String = "" '******** holdds the currently logged user
    Public Ccode As String = "" '******** holds the username code
    Public Cgrp As String = "" '******** holds the group of the currently logged user
    Public Cstatus As String = "" '******** holds users status either child or adult
    Public Records As Integer = 0
    Public Rnew As String = "" '******** keeps status of either edit or add new record
    Public pogramDirectory As String
    Public patient As String = ""
    Public C_patient As String = ""
    Public Rec_Found As Boolean = False
    Public Qconn As New SqlConnection(con)
    Public QLocation As String = "lwak"
    Public diagnosis As String = ""
    Public medication As String = ""
    Public tempID As String = "" '******** holdds the temp id of the selectd non-surve patient from the treeview
    Public c_age As String = "" '******** holdds the temp id of the selectd non-surve patient from the treeview
    'only applies to samples certification


    Public RECDATE_edit As Date
    Public sBarcode As String
    Public sUniqueID As String
    Public sLocation As String
    Public sAliquot As Integer
    Public sColl_Location As String
    Public sLabref As String
    Public sSampleType As String
    Public sSTudy As String
    Public sColldate As Date
    Public sReceiveDate As Date
    Public sGroup As String
    Public Timestamps As DateTime
    '*********************************************************************************************************************
    '********************************** End of public variables declaration **********************************************
    '*********************************************************************************************************************
    ' makes the loading form a child of the MDI

    Public Sub LoadMyForms(ByVal frm As Form)
        Dim childForm As New Form
        Dim pcs As New Form
        'make it a childform of this MDI
        childForm.MdiParent = mdiLIMS
        Dim m_ChildFormNumber As Integer = +1
        childForm.Text = "Window " & m_ChildFormNumber
        frm.Show()
    End Sub

    'open connection
    Public Sub openConn()
        If Qconn.State = ConnectionState.Closed Then
            Qconn.Open()
        End If
    End Sub

    'close connection
    Public Sub closeConn()
        If Qconn.State = ConnectionState.Open Then
            Qconn.Close()
        End If

    End Sub

    Public Sub FillMyGrid(ByVal gridName As DataGridView, ByVal sql As String)
        'open Connection
        openConn()
        Try
            Dim grdDA As New SqlDataAdapter(sql, Qconn)
            Dim grdDT As New DataTable
            grdDA.Fill(grdDT)
            gridName.DataSource = grdDT
            gridName.Refresh()
        Catch ex As Exception
            msgError("ERROR Description: " & ex.Message)
            Exit Sub
        Finally
            closeConn()
        End Try

        With gridName
            .RowsDefaultCellStyle.BackColor = Color.Snow
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
        End With

    End Sub

    ' populate the list view grid
    Public Sub LstView(ByVal lst As ListView, ByVal Qsql As String, ByVal fld As String)

        Try
            'open DB conn
            openConn()

            Dim Qcmd As New SqlCommand(Qsql, Qconn)
            Dim Qdr As SqlDataReader = Qcmd.ExecuteReader
            lst.Clear()
            While Qdr.Read
                lst.Items.Add(Qdr.Item(fld))
            End While
            Qdr.Close()
        Catch ex As Exception
            msgError("Error: " + ex.Message)
            Exit Sub
        Finally
            closeConn()

        End Try
    End Sub

    'gets the list view checked item

    Public Function getItems(ByVal lst As ListView) As String
        Dim str As String = ""
        If lst.CheckedItems.Count > 0 Then
            str = "'" + lst.CheckedItems(0).Text + "'"
        End If
        Return str
    End Function
    ' hide my controls

    Public Sub hideControls(ByVal grp As GroupBox)
        Dim ctrl As Control
        If grp.Name <> "" Then
            For Each ctrl In grp.Controls
                If (TypeOf ctrl Is RichTextBox) Or (TypeOf ctrl Is TextBox) Or (TypeOf ctrl Is ComboBox) Then
                    ctrl.Enabled = False
                End If
            Next
        End If
    End Sub
    ' this is the module to load the searched individual
    Public Sub searchEngine(ByVal sql As String)

    End Sub

    ' Patient-Doctor assignment module
    Public Sub patientDoctor(ByVal sql As String)

    End Sub
    ' error messages feedback
    Public Sub msgError(ByVal msg As String)
        MsgBox(msg, MsgBoxStyle.Critical, "iLIMS")
    End Sub
    ' error messages feedback
    Public Sub msgWarn(ByVal msg As String)
        MsgBox(msg, MsgBoxStyle.Exclamation, "iLIMS")
    End Sub
    'message box success
    Public Sub msgSuccess(ByVal msg1 As String)
        MsgBox(msg1, MsgBoxStyle.Information, "iLIMS")
    End Sub
    ' message box yes no
    Public Sub msgYesNo(ByVal msg2 As String)
        MsgBox(msg2, MsgBoxStyle.OkCancel, "iLIMS")
    End Sub

    Public Sub loadCombo(ByVal cbo As ComboBox, ByVal sql As String, ByVal fldDsp As String, ByVal fldVal As String)
        Try
            'open DB Connection
            openConn()
            Dim cboDS As New DataTable
            Dim cboAD As SqlDataAdapter
            Dim cboCMD As New SqlCommand(sql, Qconn)
            cboAD = New SqlDataAdapter(sql, Qconn)
            cboAD.Fill(cboDS)
            cbo.Items.Clear()
            cbo.SelectedIndex = -1

            'cbo.Dispose()

            With cbo
                .Refresh()
                .Items.Clear()
                .DataSource = Nothing
                .Text = fldDsp
                .DataSource = (cboDS)
                .DisplayMember = fldDsp
                .ValueMember = fldVal
            End With


        Catch ex As Exception
            msgError("ERROR:Failed Loading Values  " + ex.Message)
            Exit Sub
        Finally
            closeConn()
        End Try
    End Sub

    Public Sub loadListBox(ByVal lst As CheckedListBox, ByVal sql As String, ByVal fldDsp As String, ByVal fldVal As String)
        Try
            'open DB Connection
            openConn()
            Dim lstDS As New DataTable
            Dim lstAD As SqlDataAdapter
            Dim cboCMD As New SqlCommand(sql, Qconn)
            lstAD = New SqlDataAdapter(sql, Qconn)
            lstAD.Fill(lstDS)
            lst.Items.Clear()
            lst.SelectedIndex = -1
            With lst
                .Items.Clear()
                .DataSource = Nothing
                .Text = fldDsp
                .DataSource = lstDS
                .DisplayMember = fldDsp
                .ValueMember = fldVal
            End With
        Catch ex As Exception
            msgError("ERROR:Failed Loading Values  " + ex.Message)
            Exit Sub
        Finally
            closeConn()
        End Try
    End Sub

    Public Sub loadComboDefault(ByVal cbo As ComboBox, ByVal sql As String, ByVal fldDsp As String, ByVal fldVal As String, ByVal dflt As String)
        Try
            'open DB connection
            openConn()
            cbo.DataSource = Nothing
            Dim cboDS As New DataTable
            Dim cboAD As SqlDataAdapter
            Dim cboCMD As New SqlCommand(sql, Qconn)
            cboAD = New SqlDataAdapter(sql, Qconn)
            cboAD.Fill(cboDS)
            cbo.Items.Clear()
            cbo.SelectedIndex = -1
            With cbo
                .Items.Clear()
                .DataSource = Nothing
                .DataSource = cboDS
                .DisplayMember = fldDsp
                .Text = "" & dflt
                .ValueMember = fldVal
            End With
        Catch ex As Exception
            msgError("ERROR:Failed Loading Values  " + ex.Message)
            Exit Sub
        Finally
            closeConn()
        End Try
    End Sub
    ' loads the demographic information of the patients
    Public Sub loadDemograghy(ByVal dssid As String, ByVal fnm As TextBox, ByVal mnm As TextBox, ByVal lnm As TextBox, ByVal dob As TextBox, ByVal sex As TextBox, ByVal txtdssid As TextBox)
        Try
            openConn()
            Dim sql As String = "SELECT * FROM " & tableIndividual & " WHERE  " & [INDIVIDID] & "='" & dssid & "'"
            Dim cmd As New SqlCommand(sql, Qconn)
            Dim Idr As SqlDataReader = cmd.ExecuteReader()
            While Idr.Read
                fnm.Text = Idr.Item("NAME").ToString.Trim
                mnm.Text = Idr.Item("MNAME").ToString.Trim
                lnm.Text = Idr.Item("LNAME").ToString.Trim
                dob.Text = Idr.Item("BIRTH_DATE")
                sex.Text = Idr.Item("GENDER").ToString.Trim
            End While
            Idr.Close()
        Catch ex As Exception
            msgError("FAILED LOADING PATIENT INFO :" + ex.Message)
            Exit Sub
        Finally
            closeConn()
        End Try
    End Sub
    'read the checked values from a checkedlistbox

    Public Function getCheckedItems(ByVal chk As CheckedListBox) As String
        Dim items As String = ""
        If chk.CheckedItems.Count > 0 Then
            items = "" & chk.CheckedItems(0) & ""
            'check if the checked items are more than 1
            If chk.CheckedItems.Count > 1 Then
                For i As Integer = 1 To chk.CheckedItems.Count - 1
                    items = items & "," & chk.CheckedItems(i) & ""
                Next
            End If
        End If
        Return items
    End Function

    'get the age differences given the DOB
    Public Function getAge(ByVal dob As Date)
        Dim dDiff As Decimal
        Dim dtA As Date
        Dim ts As TimeSpan
        dtA = (dob) '(this is the date to subtract the current date from)
        ts = Now.Subtract(dtA)
        dDiff = Convert.ToDecimal(ts.TotalDays) \ 365.25
        Dim dtMonth As Integer = DateDiff(DateInterval.Month, dob, Date.Today)
        'msgError("my months are :- " & dtMonth)
        'msgError("dDiff in years:- " & dDiff & "ageMonths : - " & ageMonths)
        c_age = dDiff
        Return dDiff
    End Function

    ' encrypt users passwords on insert
    Public Function encrypt(ByVal pass As String) As String
        'Private Function GenerateHash(ByVal SourceText As String) As String
        'Create an encoding object to ensure the encoding standard for the source text
        Dim Ue As New UnicodeEncoding()
        'Retrieve a byte array based on the source text
        Dim ByteSourceText() As Byte = Ue.GetBytes(pass)
        'Instantiate an MD5 Provider object
        Dim Md5 As New MD5CryptoServiceProvider()
        'Compute the hash value from the source
        Dim ByteHash() As Byte = Md5.ComputeHash(ByteSourceText)
        'And convert it to String format for return
        Return Convert.ToBase64String(ByteHash)
    End Function

    'public function get group name.
    Public Function getGroup(ByVal id As Integer) As String
        Dim grp As String = ""
        Try

            'open DB connection
            openConn()

            Dim sql As String = "SELECT * FROM dbo.groups WHERE groupID='" & id & "'"
            Dim cmds As New SqlCommand(sql, Qconn)
            Dim drs As SqlDataReader = cmds.ExecuteReader()
            While drs.Read
                grp = drs.Item("group").ToString.Trim
            End While
            drs.Close()
        Catch ex As Exception
            msgError("FAILED LOADING GROUP NAMES " + ex.Message)
            'Exit Function
        Finally
            closeConn()
        End Try
        Return grp
    End Function

    ' This sub-module will check and validate the user logging in the system
    Public Sub Auth_User_login(ByVal usr As String, ByVal pwd As String, ByVal conn As SqlConnection)
        Try

            'open DB connection
            openConn()

            Dim sql As String = "SELECT * FROM [elab].[settings].[users] WHERE username='" + usr + "' AND password='" + pwd + "'"
            Dim cmd As New SqlCommand(sql, Qconn)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            While dr.Read()
                Dim DBuser As String = dr.Item("username").Trim.ToString.ToLower
                Dim DBpass As String = dr.Item("password").Trim.ToString
                Dim userID As Integer = dr.Item("userID")
                Dim logd As Integer = dr.Item("logged")
                Cgrp = dr.Item("groupID")
                'DSS = dr.Item("code")
                If DBuser = usr And DBpass = pwd Then
                    Cuser = DBuser
                    Ccode = userID
                    ' Cgrp = dr.Item("groupID").ToString
                    mdiLIMS.Show()
                    frmlogin.txtuser.Text = ""
                    frmlogin.txtpwd.Text = ""
                    frmlogin.Hide()
                End If
            End While
            If Cuser = "" Then
                msgError("Access Denied,Contact Systems Administrator")
            End If
            dr.Close()

            If Cuser <> "" Then
                Dim sqlup As String = "UPDATE [elab].[settings].[users] SET logged='1' WHERE username='" + Cuser + "'"
                Dim cmds As New SqlCommand(sqlup, Qconn)
                Dim u_dr As SqlDataReader = cmds.ExecuteReader()
                u_dr.Close()
            End If

        Catch ex As Exception
            msgError(" user authentication failed " & ex.Message)
            frmlogin.txtpwd.Clear()
            Exit Sub
        Finally
            closeConn()
        End Try
        loadGroup(Cuser)
    End Sub

    Public Sub loadGroup(ByVal user As String)
        Try
            'open DB connection
            openConn()

            Dim sql As String = "SELECT * FROM [elab].[settings].[groups] WHERE groupID='" + Ccode + "'"
            Dim cmd As New SqlCommand(sql, Qconn)
            Dim Udr As SqlDataReader = cmd.ExecuteReader()
            While Udr.Read
                Cgrp = Udr.Item("name").ToString.Trim
            End While
            Udr.Close()
        Catch ex As Exception
            msgError("ERROR: " + ex.Message + Ccode)
            Exit Sub
        Finally

            'close connection
            closeConn()
        End Try
    End Sub

    Public Sub userLogout()
        Try
            'close connection
            openConn()

            Dim Sql = "UPDATE [elab].[settings].[users] SET logged='0' WHERE username='" + Cuser + "'"
            Dim cmd As New SqlCommand(Sql, Qconn)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            dr.Close()
            Cuser = ""
            msgSuccess("user logged out successfully on PCS!")
            mdiLIMS.Hide()
            frmlogin.Show()
        Catch ex As Exception
            msgError("USER LOGOUT PROCESS FAILED " + ex.Message)
            Exit Sub
        Finally

            'close connection
            closeConn()

        End Try

    End Sub
    ' public sub to load for doctor

    Public Sub loadDoctor(ByVal txt As TextBox, ByVal id As String, ByVal tbnm As String)
        Try
            'open DB connection
            openConn()

            Dim sql As String = "SELECT * FROM dbo." & tbnm & " WHERE status='NO' AND dssID='" & id & "'"
            Dim cmd As New SqlCommand(sql, Qconn)
            Dim sqlDR As SqlDataReader = cmd.ExecuteReader()
            While sqlDR.Read
                txt.Clear()
                txt.Text = sqlDR.Item("officer").ToString.Trim
            End While
            sqlDR.Close()
        Catch ex As Exception
            msgError("FAILED LOADING DOCTOR " & ex.Message)
            Exit Sub
        Finally
            'close connection
            closeConn()
        End Try
    End Sub
    ' public sub to load for doctor

    Public Sub loadDoctorYES(ByVal txt As TextBox, ByVal id As String, ByVal tbnm As String, ByVal status As String)

        Try

            'open DB connection
            openConn()

            Dim sql As String = "SELECT * FROM dbo." & tbnm & " WHERE status='" & status & "' AND dssID='" & id & "'"
            Dim cmd As New SqlCommand(sql, Qconn)
            Dim sqlDR As SqlDataReader = cmd.ExecuteReader()

            While sqlDR.Read
                txt.Clear()
                txt.Text = sqlDR.Item("officer").ToString.Trim
            End While
            sqlDR.Close()

        Catch ex As Exception
            msgError("FAILED LOADING DOCTOR " & ex.Message)
            Exit Sub
        Finally

            'close DB connection
            closeConn()
        End Try
    End Sub
    Public Sub deleteRecord(ByVal sql As String, ByVal Q As SqlConnection)

        Select Case (MsgBox("Are you sure you want to delete this record ?", MsgBoxStyle.YesNo))
            Case MsgBoxResult.Yes
                Try

                    'open DB connection
                    openConn()

                    Dim cmd As New SqlCommand(sql, Q)
                    Dim r As Integer
                    r = cmd.ExecuteNonQuery
                    If r > 0 Then
                        msgSuccess("Record deleted successfully")
                    End If
                Catch ex As Exception
                    msgError("Error in deleting records " & ex.Message)
                    Exit Sub
                Finally
                    closeConn()
                End Try
            Case MsgBoxResult.No
                msgSuccess("Record operation delete aborted by user")
                Exit Sub
        End Select

    End Sub
    Public Sub uncheckList(ByVal chk As CheckedListBox)
        For i As Integer = 0 To chk.Items.Count - 1
            chk.SetItemCheckState(i, CheckState.Unchecked)
        Next i
    End Sub


    Public Sub checkList(ByVal chk As CheckedListBox)
        For i As Integer = 0 To chk.Items.Count - 1
            chk.SetItemCheckState(i, CheckState.Checked)
        Next i
    End Sub

    Public Function checkStatus(ByVal ID As String) As Integer

        Dim lock As Integer
        Try
            'open DB connection
            openConn()

            Dim sql As String = "SELECT * FROM dbo.examination WHERE dssID='" + ID + "'"
            Dim cmd As New SqlCommand(sql, Qconn)
            Dim cDR As SqlDataReader = cmd.ExecuteReader

            While cDR.Read
                lock = cDR.Item("lock")
            End While
            cDR.Close()

        Catch ex As Exception
            msgError("Failed reading patient lock status" + ex.Message)
            Exit Function
        Finally

            'close DB connection
            closeConn()
        End Try
        Return lock
    End Function

    Public Sub lst_Pop_queue_View(ByVal lstview As ListView, ByVal dssID As String)
        Try

            'open DB conn
            openConn()

            Dim sql As String = "SELECT * FROM [elab].[dbo].[individual] WHERE  " & [INDIVIDID] & "='" + dssID + "'"
            Dim DA As New SqlDataAdapter(sql, Qconn)
            Dim DS As New DataSet()

            Dim DT As New DataTable("summary")

            'fill the datatable
            DT.Clear()
            DA.Fill(DT)

            'check if there are rows fetched
            If DT.Rows.Count > 0 Then

                lstview.Items.Clear()
                Dim dr As DataRow
                'Me.lblcount.Text = DT.Rows.Count

                For Each dr In DT.Rows
                    Dim lv As New ListViewItem
                    lv = lstview.Items.Add(dr("INDIVIDID"))
                    lv.SubItems.Add(dr("village").ToString)
                    lv.SubItems.Add(dr("NAME").ToString)
                    lv.SubItems.Add(dr("MNAME").ToString)
                    lv.SubItems.Add(dr("LNAME").ToString)
                    lv.SubItems.Add(dr("GENDER").ToString)
                    lv.SubItems.Add(dr("" & DOB & "").ToString)
                    ' lv.SubItems.Add(dr("FNAME"))
                Next

            Else
                msgSuccess("No records avaialble!")

            End If

        Catch ex As Exception
            msgError("error in retrieving job summary " + ex.Message)
            Exit Sub
        Finally
            closeConn()
        End Try
    End Sub
    Public Sub lst_view_queue(ByVal lstview As ListView, ByVal query As String)
        Try

            'open DB conn
            openConn()

            Dim DA As New SqlDataAdapter(query, Qconn)
            Dim DS As New DataSet()
            Dim DT As New DataTable("summary")
            'fill the datatable
            DT.Clear()
            DA.Fill(DT)

            'check if there are rows fetched
            If DT.Rows.Count > 0 Then

                Rec_Found = True

                lstview.Items.Clear()
                Dim dr As DataRow
                Records = DT.Rows.Count

                For Each dr In DT.Rows
                    Dim lv As New ListViewItem
                    Select Case QLocation
                        Case "lwak"
                            lv = lstview.Items.Add(dr("INDIVIDID"))
                            lv.SubItems.Add(dr("village").ToString)
                            lv.SubItems.Add(dr("NAME").ToString)
                            lv.SubItems.Add(dr("MNAME").ToString)
                            lv.SubItems.Add(dr("LNAME").ToString)
                            lv.SubItems.Add(dr("" & Gen & "").ToString)
                            lv.SubItems.Add(dr("" & DOB & "").ToString)

                        Case "kibera"
                            lv = lstview.Items.Add(dr("IndUniqID"))
                            lv.SubItems.Add(dr("Cluster").ToString)
                            lv.SubItems.Add(dr("ResID").ToString)
                            lv.SubItems.Add(dr("Name").ToString)
                            lv.SubItems.Add(dr("Sex").ToString)
                            lv.SubItems.Add(dr("DOB").ToString)

                    End Select




                    'lv.SubItems.Add(dr("" & Gen & "").ToString)
                    'lv.SubItems.Add(dr("" & DOB & "").ToString)
                    ' lv.SubItems.Add(dr("FNAME"))
                Next

            Else
                Rec_Found = False
                msgSuccess("No records avaialble!")

            End If

        Catch ex As Exception
            msgError("error in retrieving job summary " + ex.Message)
            Exit Sub
        Finally
            closeConn()
        End Try
    End Sub
    Public Sub lstVewWorkLoadshdule(ByVal lstview As ListView, ByVal query As String)
        Try

            'open DB conn
            openConn()

            Dim DA As New SqlDataAdapter(query, Qconn)
            Dim DS As New DataSet()
            Dim DT As New DataTable("summary")
            'fill the datatable
            DT.Clear()
            DA.Fill(DT)

            'check if there are rows fetched
            If DT.Rows.Count > 0 Then

                Rec_Found = True

                lstview.Items.Clear()
                Dim dr As DataRow
                Records = DT.Rows.Count

                For Each dr In DT.Rows
                    Dim lv As New ListViewItem

                    lv = lstview.Items.Add(dr("DSSID"))
                    lv.SubItems.Add(dr("visit").ToString)
                    lv.SubItems.Add(dr("tdate").ToString)
                    lv.SubItems.Add(dr("cat").ToString)
                    Select Case QLocation
                        Case "kibera"
                            lv.SubItems.Add(dr("NAME").ToString)
                            lv.SubItems.Add(dr("sex").ToString)
                            lv.SubItems.Add(dr("dob").ToString)
                        Case "lwak"
                            lv.SubItems.Add(dr("fname").ToString)
                            lv.SubItems.Add(dr("lname").ToString)
                            lv.SubItems.Add(dr("sex").ToString)
                            lv.SubItems.Add(dr("dob").ToString)
                    End Select
                Next

            Else
                Rec_Found = False
                msgSuccess("No records avaialble!")

            End If

        Catch ex As Exception
            msgError("error in retrieving job summary " + ex.Message)
            Exit Sub
        Finally
            closeConn()
        End Try
    End Sub
    Public Sub lstVewNonSurvePatientData(ByVal lstview As ListView, ByVal query As String)
        Try

            'open DB conn
            openConn()

            Dim DA As New SqlDataAdapter(query, Qconn)
            Dim DS As New DataSet()
            Dim DT As New DataTable("summary")
            'fill the datatable
            DT.Clear()
            DA.Fill(DT)

            'check if there are rows fetched
            If DT.Rows.Count > 0 Then

                Rec_Found = True

                lstview.Items.Clear()
                Dim dr As DataRow
                Records = DT.Rows.Count

                For Each dr In DT.Rows
                    Dim lv As New ListViewItem

                    lv = lstview.Items.Add(dr("TemporaryID"))
                    lv.SubItems.Add(dr("visit").ToString)
                    lv.SubItems.Add(dr("tdate").ToString)
                    lv.SubItems.Add(dr("cat").ToString)
                    lv.SubItems.Add(dr("Names").ToString)
                    lv.SubItems.Add(dr("sex").ToString)
                Next

            Else
                Rec_Found = False
                msgSuccess("No records avaialble!")

            End If

        Catch ex As Exception
            msgError("error in retrieving job summary " + ex.Message)
            Exit Sub
        Finally
            closeConn()
        End Try
    End Sub
    'Public Sub lstVewWorkLoadshdule_Kibera(ByVal lstview As ListView, ByVal query As String)
    '    Try

    '        'open DB conn
    '        openConn()

    '        Dim DA As New SqlDataAdapter(query, Qconn)
    '        Dim DS As New DataSet()
    '        Dim DT As New DataTable("summary")
    '        'fill the datatable
    '        DT.Clear()
    '        DA.Fill(DT)

    '        'check if there are rows fetched
    '        If DT.Rows.Count > 0 Then

    '            Rec_Found = True

    '            lstview.Items.Clear()
    '            Dim dr As DataRow
    '            Records = DT.Rows.Count

    '            For Each dr In DT.Rows
    '                Dim lv As New ListViewItem
    '                lv = lstview.Items.Add(dr("INDIVIDID"))
    '                lv.SubItems.Add(dr("visit").ToString)
    '                lv.SubItems.Add(dr("ResID").ToString)
    '                lv.SubItems.Add(DateTime.Parse(dr("tdate").ToString))
    '                lv.SubItems.Add(dr("cat").ToString)
    '                lv.SubItems.Add(dr("names").ToString)
    '                lv.SubItems.Add(dr("clerk").ToString)
    '            Next

    '        Else
    '            Rec_Found = False
    '            msgSuccess("No records avaialble!")

    '        End If

    '    Catch ex As Exception
    '        msgError("error in retrieving job summary " + ex.Message)
    '    Finally
    '        closeConn()
    '    End Try
    'End Sub

    Public Function Get_Birth_Date(ByVal permID As String)

        Dim dob As Date
        Try

            'open conn
            openConn()
            Dim sql As String = ""
            Select Case QLocation
                Case "lwak"
                    sql = "SELECT BIRTH_DATE FROM " & tableIndividual & " WHERE  " & [INDIVIDID] & "='" + permID + "'"
                Case "kibera"
                    sql = "SELECT DOB FROM " & tableIndividual & " WHERE  " & [INDIVIDID] & "='" + permID + "'"
            End Select


            Dim cmd As New SqlCommand(sql, Qconn)
            Dim Ddr As SqlDataReader = cmd.ExecuteReader

            If Ddr.HasRows = True Then

                While Ddr.Read
                    Select Case QLocation
                        Case "lwak"
                            dob = Ddr.Item("BIRTH_DATE")
                        Case "kibera"
                            dob = Ddr.Item("DOB")
                    End Select

                End While
                Ddr.Close()
            Else
                msgSuccess("Birth date records not found for the patient!")
            End If
            Ddr.Close()
        Catch ex As Exception
            msgError("system malfunction error in fetching Birth Date " & ex.Message)
            ' Exit Function
        Finally

            'close con
            closeConn()

        End Try

        Return dob

    End Function

    Public Function Get_Birth_DateKibera(ByVal permID As String)

        Dim dob As Date
        Try

            'open conn
            openConn()

            Dim sql As String = "SELECT DOB FROM " & tableIndividual & " WHERE  " & [INDIVIDID] & "='" + permID + "'"
            Dim cmd As New SqlCommand(sql, Qconn)
            Dim Ddr As SqlDataReader = cmd.ExecuteReader

            If Ddr.HasRows = True Then

                While Ddr.Read
                    dob = Ddr.Item("DOB")
                End While
                Ddr.Close()
            Else
                msgSuccess("Birth date records not found for the patient!")
            End If
            Ddr.Close()
        Catch ex As Exception
            msgError("system malfunction error in fetching Birth Date " & ex.Message)
            '   Exit Function
        Finally

            'close con
            closeConn()

        End Try

        Return dob

    End Function
    Public Sub lst_view_compounds(ByVal lstview As ListView, ByVal query As String)
        Try

            'open DB conn
            openConn()

            Dim DA As New SqlDataAdapter(query, Qconn)
            Dim DS As New DataSet()

            Dim DT As New DataTable("summary")

            'fill the datatable
            DT.Clear()
            DA.Fill(DT)

            'check if there are rows fetched
            If DT.Rows.Count > 0 Then

                lstview.Items.Clear()
                Dim dr As DataRow
                'Me.lblcount.Text = DT.Rows.Count

                For Each dr In DT.Rows

                    Dim lv As New ListViewItem

                    lv = lstview.Items.Add(dr("COMPOUNDID"))
                    lv.SubItems.Add(dr("CFNAME").ToString)
                    lv.SubItems.Add(dr("CJNAME").ToString)
                    lv.SubItems.Add(dr("CLNAME").ToString)

                Next

            Else
                msgSuccess("No records avaialble!")

            End If

        Catch ex As Exception
            msgError("error in retrieving job summary " + ex.Message)
            Exit Sub
        Finally
            closeConn()
        End Try
    End Sub

    'function to comapte Current ID
    Public Function compare_ID(ByVal lst_view As ListView)

        If lst_view.SelectedItems.Item(0).Text <> Nothing Then
            Dim Curr_ID As String = lst_view.SelectedItems.Item(0).Text
            If Curr_ID <> C_patient Then
                C_patient = Curr_ID
            End If
        End If
        Return C_patient

    End Function

    Public Sub ResetControls(ByVal grpbox As GroupBox)
        Dim ctrl As Control 'declares an object of type control'
        For Each ctrl In grpbox.Controls 'loops through all the controls found'
            If (TypeOf ctrl Is ComboBox) Or (TypeOf ctrl Is TextBox) Then 'checks control type
                ctrl.Text = ""
                '.Enabled = True 'enable the control minus the group combobox
            End If
        Next
    End Sub

    Public Function validateForms(ByVal grpBox As GroupBox)

        Dim valid As Boolean = False
        Dim nud As NumericUpDown
        Dim chlstBox As CheckedListBox
        Dim cbo As ComboBox
        Dim ctrl As Control
        For Each ctrl In grpBox.Controls
            If ctrl.Enabled = True Then
                If (TypeOf ctrl Is TextBox) Then
                    If ctrl.Text = "" Then
                        msgError("Please provide " + ctrl.Name + " values before save")
                        ctrl.Focus()
                        valid = True
                        Exit For
                    End If
                End If
                If (TypeOf ctrl Is ComboBox) Then
                    cbo = ctrl
                    If cbo.Text = "" Or ctrl.Text = "NULL" Then
                        msgError("Please provide " + ctrl.Name + " values before save")
                        ctrl.Focus()
                        valid = True
                        Exit For
                    End If
                End If
                If (TypeOf ctrl Is NumericUpDown) Then
                    nud = ctrl
                    If (nud.Value = 0 Or nud.Value = Nothing) Then
                        msgError("Please provide " + ctrl.Name + " values before save")
                        ctrl.Focus()
                        valid = True
                        Exit For
                    End If
                End If
                If (TypeOf ctrl Is CheckedListBox) Then
                    chlstBox = ctrl
                    If chlstBox.CheckedItems.Count < 0 Then
                        msgError("Atleast one (1) option must be checked for " + ctrl.Name + " values before save")
                        ctrl.Focus()
                        valid = True
                        Exit For
                    End If
                End If
            End If
        Next
        Return valid
    End Function
    Public Function validateTabOnForms(ByVal frm As Form)

        Dim valid As Boolean = False
        Dim nud As NumericUpDown
        Dim chlstBox As CheckedListBox
        Dim cbo As ComboBox
        Dim ctrl As Control

        For Each ctrl In frm.Controls
            'For Each ctrl In tbctrl.Controls
            If ctrl.Enabled = True Then

                If (TypeOf ctrl Is TextBox) Then
                    If ctrl.Text = "" Then
                        msgError("Please provide " + ctrl.Name + " values before save")
                        ctrl.Focus()
                        valid = True
                        Exit For
                    End If
                End If

                If (TypeOf ctrl Is ComboBox) Then
                    cbo = ctrl
                    If cbo.Text = "" Or ctrl.Text = "NULL" Then
                        msgError("Please provide " + ctrl.Name + " values before save")
                        ctrl.Focus()
                        valid = True
                        Exit For
                    End If
                End If

                If (TypeOf ctrl Is NumericUpDown) Then
                    nud = ctrl
                    If (nud.Value = 0 Or nud.Value = Nothing) Then
                        msgError("Please provide " + ctrl.Name + " values before save")
                        ctrl.Focus()
                        valid = True
                        Exit For
                    End If
                End If

                If (TypeOf ctrl Is CheckedListBox) Then
                    chlstBox = ctrl
                    If chlstBox.CheckedItems.Count < 0 Then
                        msgError("Atleast one (1) option must be checked for " + ctrl.Name + " values before save")
                        ctrl.Focus()
                        valid = True
                        Exit For
                    End If
                End If
            End If
        Next
        Return valid
    End Function
    Public Function validateControlsOnTabControl(ByVal tbc As TabControl)

        Dim valid As Boolean = False
        Dim nud As NumericUpDown
        Dim chlstBox As CheckedListBox
        Dim cbo As ComboBox
        'Dim ctrl As Control
        ' Dim tab As TabPage

        For Each tab As TabPage In tbc.TabPages

            For Each ctrl As Control In tab.Controls
                If ctrl.Enabled = True Then
                    If (TypeOf ctrl Is TextBox) Then
                        If ctrl.Text = "" Then
                            msgError("Please provide " + ctrl.Name + " values before save")
                            ctrl.Focus()
                            valid = True
                            Exit For
                        End If
                    End If
                    If (TypeOf ctrl Is ComboBox) Then
                        cbo = ctrl
                        If cbo.Text = "" Or ctrl.Text = "NULL" Then
                            msgError("Please provide " + ctrl.Name + " values before save")
                            ctrl.Focus()
                            valid = True
                            Exit For
                        End If
                    End If
                    If (TypeOf ctrl Is NumericUpDown) Then
                        nud = ctrl
                        If (nud.Value = 0 Or nud.Value = Nothing) Then
                            msgError("Please provide " + ctrl.Name + " values before save")
                            ctrl.Focus()
                            valid = True
                            Exit For
                        End If
                    End If
                    If (TypeOf ctrl Is CheckedListBox) Then
                        chlstBox = ctrl
                        If chlstBox.CheckedItems.Count < 0 Then
                            msgError("Atleast one (1) option must be checked for " + ctrl.Name + " values before save")
                            ctrl.Focus()
                            valid = True
                            Exit For
                        End If
                    End If
                End If
            Next
        Next
        Return valid
    End Function


    Public Sub setPatientDetails(ByVal lstview As ListView)
        'call the patient ID compare function
        Dim id As String = compare_ID(lstview)

        'set current patient ID
        C_patient = id

        Dim DoB As Date = Get_Birth_Date(C_patient)
        Dim age = getAge(DoB)

        If age <= 5 Then
            patient = "CHILD"
        Else
            patient = "ADULT"
        End If
    End Sub

    Public Sub disableButtonsAfterSave(ByVal cmdsave As Button, ByVal cmddelete As Button)
        cmdsave.Enabled = False
        cmddelete.Enabled = False
    End Sub

    Public Sub getPersonalisedPatientQueue(ByVal lstview As ListView)


        lstview.Clear()
        'setup listview for queue
        Select Case QLocation
            Case "lwak"
                lstview.Columns.Add("patient code", 120, HorizontalAlignment.Left)
                lstview.Columns.Add("village", 80, HorizontalAlignment.Left)
                lstview.Columns.Add("first name", 120, HorizontalAlignment.Left)
                lstview.Columns.Add("juok name", 120, HorizontalAlignment.Left)
                lstview.Columns.Add("last name", 120, HorizontalAlignment.Left)
                lstview.Columns.Add("gender", 120, HorizontalAlignment.Left)
                lstview.Columns.Add("date of birth", 120, HorizontalAlignment.Left)
            Case "kibera"
                lstview.Columns.Add("patient code", 120, HorizontalAlignment.Left)
                lstview.Columns.Add("Cluster", 80, HorizontalAlignment.Left)
                lstview.Columns.Add("NAME", 220, HorizontalAlignment.Left)
                lstview.Columns.Add("gender", 120, HorizontalAlignment.Left)
                lstview.Columns.Add("date of birth", 120, HorizontalAlignment.Left)
        End Select

        Dim sq As String = Nothing
        If Rnew = "YES" Then
            sq = "SELECT * FROM [PCS].[dbo].[individual] INNER JOIN [dbo].[queue] ON [dbo].[queue].dssID=[dbo].[individual] ." & [INDIVIDID] & " " &
               "WHERE [dbo].[queue].examination='NO' AND [dbo].[queue].riskfactors='YES' AND [dbo].[queue].[diagnosis]='NO' AND [dbo].[queue].[category]='ADULT' AND " &
               " " & [INDIVIDID] & " IN(SELECT dssID FROM[PCS].[dbo].[workLoadSchedule] WHERE doctor='" + Cuser + "') ORDER BY date ASC"
        Else
            sq = "SELECT * FROM [PCS].[dbo].[individual] INNER JOIN [dbo].[queue] ON [dbo].[queue].dssID=[dbo].[individual] ." & [INDIVIDID] & " " &
               "WHERE [dbo].[queue].examination='YES' AND [dbo].[queue].riskfactors='YES' AND diagnosis='NO' AND [dbo].[queue].[category]='ADULT' AND " &
               " " & [INDIVIDID] & " IN(SELECT dssID FROM[PCS].[dbo].[workLoadSchedule] WHERE doctor='" + Cuser + "') ORDER BY date ASC"
        End If

        lstview.Items.Clear()
        lst_view_queue(lstview, sq)


    End Sub

    Public Function checkQueuedPatient(ByVal dssID As String)
        Dim ptStatus As Boolean = False

        Try

            'open DB conn
            openConn()

            Dim query As String = "SELECT * FROM [PCS].[settings].[queue_manager] WHERE dssID='" + dssID + "' AND disposition='NO'"
            Dim DA As New SqlDataAdapter(query, Qconn)
            Dim DS As New DataSet()

            Dim DT As New DataTable("patientQueue")

            'fill the datatable
            DT.Clear()
            DA.Fill(DT)

            'check if there are rows fetched
            If DT.Rows.Count > 0 Then
                ptStatus = True
            Else
                ptStatus = False

            End If
        Catch ex As Exception
            msgError("error in checking patient queue details " + ex.Message)
        Finally
            closeConn()
        End Try

        Return ptStatus
    End Function
End Module
