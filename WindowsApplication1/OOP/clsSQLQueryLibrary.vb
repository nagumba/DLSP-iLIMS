Public Class clsSQLQueryLibrary
    Private tblName As String = Nothing
    Private fmMode As String = Nothing
    Private curTable As String = Nothing
    Private chkTable As String = Nothing
    Private curTableOption As String = Nothing
    Private chkTableOption As String = Nothing
    Private ptnstatus As String = Nothing
    Private dssID As String = Nothing

    Public Property GetTableName As String
        Get
            Return tblName
        End Get
        Set(ByVal value As String)
            tblName = value
        End Set
    End Property

    Public Property GetFormMode As String

        Get
            Return fmMode
        End Get
        Set(ByVal value As String)
            fmMode = value
        End Set
    End Property

    Public Property GetCurrentTable As String
        Get
            Return curTable
        End Get
        Set(ByVal value As String)
            curTable = value
        End Set
    End Property
    Public Property GetCheckTable As String

        Get
            Return chkTable
        End Get
        Set(ByVal value As String)
            chkTable = value
        End Set
    End Property
    Public Property GetCurrentTableOption As String
        Get
            Return curTableOption
        End Get
        Set(ByVal value As String)
            curTableOption = value
        End Set
    End Property
    Public Property GetCheckTableOption As String
        Get
            Return chkTableOption
        End Get
        Set(ByVal value As String)
            chkTableOption = value
        End Set
    End Property

    Public Function GetPatientLoadQuery(ByVal md As String, ByVal crTbl As String, ByVal CkTbl As String, ByVal crOption As String, ByVal ckOption As String)

        GetFormMode = md
        GetCurrentTable = crTbl
        GetCurrentTableOption = crOption
        GetCheckTable = CkTbl
        GetCheckTableOption = ckOption
        Dim currQuery As String = Nothing

        Select Case md

            Case "examination"
                currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                            "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                            "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                            "WHERE T1." + curTable + "='" + curTableOption + "' AND ( T1." + chkTable + " ='" + chkTableOption + "' or disposition='YES' )AND CAST(T1.Rec_Date AS DATE) = '" & RECDATE_edit & "' ORDER BY T1.Rec_Date ASC"
            Case "Add"
                currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID,T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                            "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                            "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                            "WHERE T1." + curTable + "='" + curTableOption + "' AND ( T1." + chkTable + " ='" + chkTableOption + "' or disposition='YES' ) AND CAST(T1.Rec_Date AS DATE) = '" & RECDATE_edit & "' ORDER BY T1.Rec_Date ASC"
            Case "Edit"
                currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                             "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                             "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                             "WHERE T1." + curTable + "='" + curTableOption + "' AND ( T1." + chkTable + " ='" + chkTableOption + "' or disposition='YES' ) AND CAST(T1.Rec_Date AS DATE) = '" & RECDATE_edit & "' ORDER BY T1.Rec_Date ASC"

            Case "ExamChild"
                currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                            "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                            "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                            "WHERE T1." + curTable + "='" + curTableOption + "' AND T1." + chkTable + " ='" + chkTableOption + "' AND disposition !='NO' ) AND CAST(T1.Rec_Date AS DATE) = '" & RECDATE_edit & "' T1.category='CHILD'  ORDER BY T1.Rec_Date ASC"
        End Select

        Return currQuery
    End Function

    Public Function GetPatientLoadTriageQuery(ByVal md As String, ByVal crTbl As String, ByVal CkTbl As String, ByVal crOption As String, ByVal ckOption As String)

        GetFormMode = md
        GetCurrentTable = crTbl
        GetCurrentTableOption = crOption
        GetCheckTable = CkTbl
        GetCheckTableOption = ckOption
        Dim currQuery As String = Nothing

        Select Case md

            Case "examination"

                currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                            "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                            "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                            "WHERE T1." + curTable + "='" + curTableOption + "' AND and T1.[status] = 'NO' and  T1." + chkTable + " ='" + chkTableOption + "' AND discharge='NO' ORDER BY T1.Rec_Date ASC"
            Case "Add"
                currQuery = "SELECT  " & [CompoundID] & ",min (T2.Visit_ID) FROM  " & tableIndividual & " T1 " &
                            "INNER JOIN [settings].[queue_manager] T2 " &
                            "ON " &
                            "T1 ." & [INDIVIDID] & " = T2.DSS_ID WHERE " &
                            "T2.DSS_ID IN(SELECT DSS_ID from [PCS].[settings].[queue_manager] WHERE T2." + crTbl + "='" + crOption + "' AND t2.[status] = 'NO' and T2." + CkTbl + "='" + ckOption + "') group by " & compoundgroup &
                 " Union all " &
                            "SELECT T1.ID, min (T2.Visit_ID) FROM  [PCS].[settings].nonsurvpatients T1 " &
                            "INNER JOIN [settings].[queue_manager] T2 " &
                            "ON " &
                            "T1.ID = T2.DSS_ID WHERE LEN(DSS_ID) = 7 and " &
                            "T2.DSS_ID IN(SELECT DSS_ID from [PCS].[settings].[queue_manager] WHERE T2." + crTbl + "='" + crOption + "' AND t2.[status] = 'no' and T2." + CkTbl + "='" + ckOption + "') group by ID ORDER BY min(visit_ID) ASC"
            Case "Edit"
                currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                             "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                             "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                             "WHERE T1." + curTable + "='" + curTableOption + "' AND T1." + chkTable + " ='" + chkTableOption + "'   ORDER BY T1.Rec_Date ASC"

                'Case "ExamChild"
                '    currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " & _
                '                "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " & _
                '                "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " & _
                '                "WHERE T1." + curTable + "='" + curTableOption + "' AND T1." + chkTable + " ='" + chkTableOption + "' AND discharge='NO' AND T1.category='CHILD'  ORDER BY T1.Rec_Date ASC"

        End Select

        Return currQuery

    End Function
    Public Function GetPatientLoadSamplesQuery(ByVal md As String)
        'loads compounds where there are eligible participants for samples


        Dim currQuery As String = Nothing

        Select Case md

            '    Case "examination"

            'currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " & _
            '            "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " & _
            '            "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " & _
            '            "WHERE T1." + curTable + "='" + curTableOption + "' AND T1." + chkTable + " ='" + chkTableOption + "' AND discharge='NO' ORDER BY T1.Rec_Date ASC"
            Case "Add"
                currQuery = "SELECT DISTINCT " & [CompoundID] & "  FROM  " & tableIndividual & " T1 " &
                            "INNER JOIN [settings].[queue_manager] T2 " &
                            "ON " &
                            "T1 ." & [INDIVIDID] & " = T2.DSS_ID WHERE " &
                            "T2.Visit_ID IN(SELECT Visit_ID FROM [PCS].[medical].[samplequeue] WHERE [status]='NO') " &
                               "AND T2.status = 'NO'"

                'Case "barcodes"
                '    currQuery = "SELECT DISTINCT " & [CompoundID] & "  FROM " & [CompoundID] &" " & tableIndividual & " T1 " & _
                '                "INNER JOIN [settings].[queue_manager] T2 " & _
                '                "ON " & _
                '                "T1 ." & [INDIVIDID] & " = T2.DSS_ID WHERE (T2.barcode='NO' AND T2.samples='YES' and T2.status = 'NO'" & _
                '                "AND T2.Visit_ID NOT IN(SELECT Visit_ID FROM [PCS].[medical].[sample_barcodes])" & _
                '                "AND T2.Visit_ID NOT IN(SELECT Visit_ID FROM [PCS].[medical].[sample_barcoding])" & _
                '                "AND T2.Visit_ID NOT IN(SELECT distinct Visit_ID FROM [PCS].[medical].sample_results)" & _
                '                "AND T2.Visit_ID NOT IN(SELECT Visit_ID FROM [PCS].[medical].sample_defition where sampleeligibility = 'none' or sampleeligibility = '' or sampleeligibility = 'blood slide'))"

            Case "LabQ"
                'Select Case QLocation

                '    Case "lwak"
                '        currQuery = "(SELECT DISTINCT " & [CompoundID] & "  FROM  " & tableIndividual & " T1 " & _
                '                    "INNER JOIN [settings].[queue_manager] T2 " & _
                '                    "ON " & _
                '                    "T1 ." & [INDIVIDID] & " = T2.DSS_ID WHERE T2.lab='NO' and t2.[status]='NO' AND T2.samples='YES'  " & _
                '                    "AND T2.Visit_ID  IN(SELECT Visit_ID FROM [PCS].[medical].[sample_defition] where bloodslide = 'YES')" & _
                '                    "AND T2.Visit_ID IN (SELECT Visit_ID FROM [PCS].[settings].[workLoadSchedule] WHERE doctor = '" & Cuser & "' and  [job_status]='pending')) "
                '    Case "kibera"

                currQuery = "(SELECT DISTINCT " & [CompoundID] & "  FROM  " & tableIndividual & " T1 " &
                            "INNER JOIN [settings].[queue_manager] T2 " &
                            "ON " &
                            "T1 ." & [INDIVIDID] & " = T2.DSS_ID WHERE T2.lab = 'NO'AND T2.samples='YES'   " &
                            "AND T2.Visit_ID  IN(SELECT Visit_ID FROM [PCS].[medical].[sample_defition] where bloodslide = 'YES')" &
                            "AND T2.Visit_ID IN (SELECT Visit_ID FROM [PCS].[settings].[workLoadSchedule] WHERE  [job_status]='pending' and doctor ='" & Cuser & "') ) "

                'End Select
                ' "AND T2.Visit_ID IN (SELECT Visit_ID FROM [PCS].[settings].[workLoadSchedule] WHERE  [job_status]='pending')) "
                '& _
                '   "AND T2.Visit_ID NOT IN(SELECT Visit_ID FROM [PCS].[medical].[samplequeue] WHERE [status]='YES') " & _


            Case "Edit"
                'currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " & _
                '             "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " & _
                '             "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " & _
                '             "WHERE T1." + curTable + "='" + curTableOption + "' AND T1." + chkTable + " ='" + chkTableOption + "' AND discharge='NO'  ORDER BY T1.Rec_Date ASC"

            Case "ExamChild"
                'currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " & _
                '            "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " & _
                '            "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " & _
                '            "WHERE T1." + curTable + "='" + curTableOption + "' AND T1." + chkTable + " ='" + chkTableOption + "' AND discharge='NO' AND T1.category='CHILD'  ORDER BY T1.Rec_Date ASC"
        End Select

        Return currQuery
    End Function

    Public Function GetPatientPharmacyQuery(ByVal md As String)
        'loads compounds where there are eligible participants for samples


        Dim currQuery As String = Nothing

        Select Case md

            '    Case "examination"

            'currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " & _
            '            "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " & _
            '            "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " & _
            '            "WHERE T1." + curTable + "='" + curTableOption + "' AND T1." + chkTable + " ='" + chkTableOption + "' AND discharge='NO' ORDER BY T1.Rec_Date ASC"
            Case "pharmacy"
                currQuery = "SELECT " & [CompoundID] & "  FROM  " & tableIndividual & " T1 " &
                            "INNER JOIN [settings].[queue_manager] T2 " &
                            "ON " &
                            "T1 ." & [INDIVIDID] & " = T2.DSS_ID WHERE " &
                            "T2.[MEDICATION]='YES' AND T2.PHARMACY = 'NO'  group by " & compoundgroup & "  ORDER BY min(visit_ID) ASC"

                'Case "barcodes"
                '    currQuery = "SELECT DISTINCT " & [CompoundID] & "  FROM " & [CompoundID] &" " & tableIndividual & " T1 " & _
                '                "INNER JOIN [settings].[queue_manager] T2 " & _
                '                "ON " & _
                '                "T1 ." & [INDIVIDID] & " = T2.DSS_ID WHERE (T2.barcode='NO' AND T2.samples='YES' and T2.status = 'NO'" & _
                '                "AND T2.Visit_ID NOT IN(SELECT Visit_ID FROM [PCS].[medical].[sample_barcodes])" & _
                '                "AND T2.Visit_ID NOT IN(SELECT Visit_ID FROM [PCS].[medical].[sample_barcoding])" & _
                '                "AND T2.Visit_ID NOT IN(SELECT distinct Visit_ID FROM [PCS].[medical].sample_results)" & _
                '                "AND T2.Visit_ID NOT IN(SELECT Visit_ID FROM [PCS].[medical].sample_defition where sampleeligibility = 'none' or sampleeligibility = '' or sampleeligibility = 'blood slide'))"

                'Case "LabQ"
                '    currQuery = "(SELECT DISTINCT " & [CompoundID] & "  FROM  " & tableIndividual & " T1 " & _
                '                "INNER JOIN [settings].[queue_manager] T2 " & _
                '                "ON " & _
                '                "T1 ." & [INDIVIDID] & " = T2.DSS_ID WHERE T2.lab='NO' AND T2.samples='YES'  " & _
                '                "AND T2.Visit_ID  IN(SELECT Visit_ID FROM [PCS].[medical].[sample_defition] where bloodslide = 'YES')" & _
                '                                "AND T2.Visit_ID IN (SELECT Visit_ID FROM [PCS].[settings].[workLoadSchedule] WHERE  [job_status]='pending')) "
                '    ' "AND T2.Visit_ID IN (SELECT Visit_ID FROM [PCS].[settings].[workLoadSchedule] WHERE  [job_status]='pending')) "

                '    '& _
                '    '   "AND T2.Visit_ID NOT IN(SELECT Visit_ID FROM [PCS].[medical].[samplequeue] WHERE [status]='YES') " & _


                'Case "Edit"
                '    'currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " & _
                '    '             "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " & _
                '    '             "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " & _
                '    '             "WHERE T1." + curTable + "='" + curTableOption + "' AND T1." + chkTable + " ='" + chkTableOption + "' AND discharge='NO'  ORDER BY T1.Rec_Date ASC"
                'Case "ExamChild"
                '    'currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " & _
                '    '            "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " & _
                '    '            "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " & _
                '            "WHERE T1." + curTable + "='" + curTableOption + "' AND T1." + chkTable + " ='" + chkTableOption + "' AND discharge='NO' AND T1.category='CHILD'  ORDER BY T1.Rec_Date ASC"
        End Select

        Return currQuery
    End Function



    Public Function GetPatientLoadQueryCHILD(ByVal md As String, ByVal crTbl As String, ByVal CkTbl As String, ByVal crOption As String, ByVal ckOption As String)

        GetFormMode = md
        GetCurrentTable = crTbl
        GetCurrentTableOption = crOption
        GetCheckTable = CkTbl
        GetCheckTableOption = ckOption
        Dim currQuery As String = Nothing

        Select Case md

            Case "examination"
                currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                                "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                                "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                                "WHERE T1." + curTable + "='" + curTableOption + "' AND T1." + chkTable + " ='" + chkTableOption + "' AND t1.[status]='NO' AND T1.category='CHILD'  ORDER BY T1.Rec_Date ASC"
            Case "Add"
                currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                                "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                                "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                                "WHERE T1." + curTable + "='" + curTableOption + "' AND T1." + chkTable + " ='" + chkTableOption + "' AND t1.[status]='NO' AND T1.category='CHILD'  ORDER BY T1.Rec_Date ASC"
            Case "Edit"
                currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                                "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                                "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                                "WHERE T1." + curTable + "='" + curTableOption + "' AND T1." + chkTable + " ='" + chkTableOption + "'  AND T1.category='CHILD'  ORDER BY T1.Rec_Date ASC"
        End Select

        Return currQuery
    End Function
    Public Function GetPatientLoadQueryADULT(ByVal md As String, ByVal crTbl As String, ByVal CkTbl As String, ByVal crOption As String, ByVal ckOption As String)

        GetFormMode = md
        GetCurrentTable = crTbl
        GetCurrentTableOption = crOption
        GetCheckTable = CkTbl
        GetCheckTableOption = ckOption
        Dim currQuery As String = Nothing

        Select Case md

            Case "examination"
                currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                                "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                                "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                                "WHERE T1." + curTable + "='" + curTableOption + "' AND T1." + chkTable + " ='" + chkTableOption + "' AND discharge='NO' AND T1.category='ADULT'  ORDER BY T1.Rec_Date ASC"
            Case "Add"
                currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                                "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                                "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                                "WHERE T1." + curTable + "='" + curTableOption + "' AND T1." + chkTable + " ='" + chkTableOption + "' AND discharge='NO' AND T1.category='ADULT'  ORDER BY T1.Rec_Date ASC"
            Case "Edit"
                currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                                "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                                "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                                "WHERE T1." + curTable + "='" + curTableOption + "' AND T1." + chkTable + " ='" + chkTableOption + "' AND discharge='NO' AND T1.category='ADULT'  ORDER BY T1.Rec_Date ASC"
        End Select

        Return currQuery
    End Function
    Public Function GetPatientLoadQuerySpecificToDoctor(ByVal md As String, ByVal crTbl As String, ByVal CkTbl As String, ByVal crOption As String, ByVal ckOption As String)

        GetFormMode = md
        GetCurrentTable = crTbl
        GetCurrentTableOption = crOption
        GetCheckTable = CkTbl
        GetCheckTableOption = ckOption
        Dim currQuery As String = Nothing

        Select Case md

            Case "examination"
                currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                            "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                            "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                            "WHERE T1." + curTable + "='" + curTableOption + "' AND T1." + chkTable + " ='" + chkTableOption + "' AND t1.[status]='NO' AND T1.category='CHILD' AND " &
                            " " & [INDIVIDID] & " IN(SELECT DSS_ID FROM [PCS].[settings].[workLoadSchedule] WHERE doctor='" + Cuser + "')  ORDER BY T1.Rec_Date ASC"
            Case "Add"
                currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                            "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                            "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                            "WHERE T1." + curTable + "='" + curTableOption + "' AND T1." + chkTable + " ='" + chkTableOption + "' AND t1.[status]='NO' AND T1.category='CHILD' AND " &
                            " " & [INDIVIDID] & " IN(SELECT DSS_ID FROM[PCS].[settings].[workLoadSchedule] WHERE doctor='" + Cuser + "')  ORDER BY T1.Rec_Date ASC"
                '  opened up for editing of past records

                'to be returned

            Case "Edit"
                currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                             "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                             "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                             "WHERE T1." + curTable + "='" + curTableOption + "' AND ( T1." + chkTable + " ='" + chkTableOption + "' or disposition='YES' ) AND CAST(T1.Rec_Date AS DATE) = '" & RECDATE_edit &
                 "' AND visit_id IN(SELECT VISIT_ID FROM[PCS].[settings].[workLoadSchedule] WHERE doctor='" + Cuser + "')  ORDER BY T1.Rec_Date ASC"

                'Case "Edit"
                '    currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " & _
                '                "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " & _
                '                "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " & _
                '                "WHERE T1." + curTable + "='" + curTableOption + "' AND T1." + chkTable + " ='" + chkTableOption + "' AND discharge='NO' AND T1.category='CHILD' AND " & _
                '                " " & [INDIVIDID] & " IN(SELECT DSS_ID FROM[PCS].[settings].[workLoadSchedule] WHERE doctor='" + Cuser + "')  ORDER BY T1.Rec_Date ASC"
        End Select

        Return currQuery
    End Function
    Public Function GetPatientLoadQuerySpecificToDoctorCommon(ByVal md As String, ByVal crTbl As String, ByVal CkTbl As String, ByVal crOption As String, ByVal ckOption As String)

        GetFormMode = md
        GetCurrentTable = crTbl
        GetCurrentTableOption = crOption
        GetCheckTable = CkTbl
        GetCheckTableOption = ckOption
        Dim currQuery As String = Nothing

        Select Case md

            Case "examination"
                currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                            "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                            "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                            "WHERE T1." + curTable + "='" + curTableOption + "' AND T1." + chkTable + " ='" + chkTableOption + "' AND t1.[status]='NO' AND " &
                            " " & [INDIVIDID] & " IN(SELECT DSS_ID FROM [PCS].[settings].[workLoadSchedule] WHERE doctor='" + Cuser + "')  ORDER BY T1.Rec_Date ASC"
            Case "Add"
                currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                            "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                            "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                            "WHERE T1." + curTable + "='" + curTableOption + "' AND T1." + chkTable + " ='" + chkTableOption + "' t1.[status]='NO' AND " &
                            " " & [INDIVIDID] & " IN(SELECT DSS_ID FROM[PCS].[settings].[workLoadSchedule] WHERE doctor='" + Cuser + "')  ORDER BY T1.Rec_Date ASC"
            Case "Edit"
                currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                            "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                            "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                            "WHERE T1." + curTable + "='" + curTableOption + "' AND T1." + chkTable + " ='" + chkTableOption + "' AND discharge='NO' AND " &
                            " " & [INDIVIDID] & " IN(SELECT DSS_ID FROM[PCS].[settings].[workLoadSchedule] WHERE doctor='" + Cuser + "')  ORDER BY T1.Rec_Date ASC"
        End Select

        Return currQuery
    End Function

    Public Function GetPatientLoadQuerySpecificToDoctorQueue(ByVal md As String, ByVal crTbl As String, ByVal CkTbl As String, ByVal crOption As String, ByVal ckOption As String)

        GetFormMode = md
        GetCurrentTable = crTbl
        GetCurrentTableOption = crOption
        GetCheckTable = CkTbl
        GetCheckTableOption = ckOption
        Dim currQuery As String = Nothing

        Select Case md

            Case "examination"
                currQuery = "SELECT " & [CompoundID] & "  FROM " & tableIndividual & " T1 " &
                            "INNER JOIN [settings].[queue_manager] T2 " &
                            "ON " &
                            "T1 ." & [INDIVIDID] & " = T2.DSS_ID " &
                            "WHERE T2.DSS_ID IN(SELECT DSS_ID FROM [PCS].[settings].[workLoadSchedule] WHERE job_status='pending' AND doctor='" + Cuser + "') AND " &
                            "T2.DSS_ID IN(SELECT DSS_ID from [PCS].[settings].[queue_manager] WHERE T2." + crTbl + "='" + crOption + "' AND T2." + CkTbl + "='" + ckOption + "') group by " & compoundgroup & "  ORDER BY min(visit_ID) ASC "
                'currQuery = "SELECT DISTINCT " & [CompoundID] & " FROM " & tableIndividual & " WHERE  " & [INDIVIDID] & " IN(SELECT DSS_ID from [PCS].[settings].[queue_manager] WHERE vitalsigns='YES' AND demographics='YES' AND symptoms='YES' AND riskfactors='YES' AND examination='NO' AND disposition='NO' AND course='NO' AND discharge='NO' AND medication='NO' AND status='NO') " & _
                '            " AND  " & [INDIVIDID] & " NOT IN(SELECT DSS_ID FROM [PCS].[settings].[workLoadSchedule]) ORDER BY " & Compoundwhere & " ASC"
            Case "Add"
                currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname,T2.lname as lname,T2." & Gen & " as sex,T2." & DOB & " as dob " &
                            "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                            "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                            "WHERE T1." + curTable + "='" + curTableOption + "' AND T1." + chkTable + " ='" + chkTableOption + "' AND t1.[status] = 'NO' AND " &
                            " " & [INDIVIDID] & " IN(SELECT DSS_ID FROM[PCS].[settings].[workLoadSchedule] WHERE doctor='" + Cuser + "')  ORDER BY T1.Rec_Date ASC"
            Case "Edit"
                currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname,T2.lnane as lname,T2." & Gen & " as sex,T2." & DOB & " as dob " &
                            "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                            "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                            "WHERE T1." + curTable + "='" + curTableOption + "' AND T1." + chkTable + " ='" + chkTableOption + "' AND discharge='NO' AND " &
                            " VISIT_id IN(SELECT VISIT_id FROM[PCS].[settings].[workLoadSchedule] WHERE doctor='" + Cuser + "')  ORDER BY T1.Rec_Date ASC"
        End Select

        Return currQuery
    End Function
    Public Function GetPatientLoadQuerySpecificQueueTable(ByVal md As String, ByVal crTbl As String, ByVal QueueTbl As String, ByVal crOption As String)

        GetFormMode = md
        GetCurrentTable = crTbl
        GetCurrentTableOption = crOption
        GetCheckTable = QueueTbl
        Dim currQuery As String = Nothing

        Select Case md

            Case "examination"
                currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                            "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                            "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                            "WHERE T1." + curTable + "='" + curTableOption + "' AND T1.Visit_ID NOT IN(SELECT Visit_ID FROM " + QueueTbl + ") ORDER BY T1.Rec_Date ASC "
            Case "Add"
                currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                            "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                            "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                            "WHERE T1." + curTable + "='" + curTableOption + "' AND T1.Visit_ID NOT IN(SELECT Visit_ID FROM " + QueueTbl + ") ORDER BY T1.Rec_Date ASC "
            Case "Edit"
                currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                            "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                            "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                            "WHERE T1." + curTable + "='" + curTableOption + "' AND T1.Visit_ID IN(SELECT Visit_ID FROM " + QueueTbl + ") ORDER BY T1.Rec_Date ASC "
        End Select

        Return currQuery
    End Function

    Public Function GetLabResultsQueue(ByVal fltrDate As Date, ByVal myDR As String)

        Dim currQuery As String = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                                  "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                                  "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                                  "WHERE T1.Visit_ID IN(SELECT Visit_ID FROM [PCS].[medical].[laboratory] T3 ) " &
                                  "and t1.disposition = 'NO'  AND T1.Visit_ID IN(SELECT Visit_ID FROM [settings].[workLoadSchedule] WHERE doctor='" + Cuser + "' AND job_status='pending' ) ORDER BY T1.Rec_Date ASC"

        '         "WHERE T1.Visit_ID IN(SELECT Visit_ID FROM [PCS].[medical].[laboratory] T3 WHERE T3.date='" + fltrDate + "') " & _
        Return currQuery

    End Function
    Public Function GetXrayQueue(ByVal fltrDate As Date, ByVal myDR As String)

        Dim currQuery As String = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                                  "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                                  "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " WHERE T1.xray='YES' AND T1.Rec_Date='" + fltrDate + "'  and t1.status = 'no'" &
                                  "AND T2 ." & [INDIVIDID] & " IN(SELECT DSS_ID FROM [settings].[workLoadSchedule] WHERE doctor='" + myDR + "') ORDER BY T1.Rec_Date ASC"
        Return currQuery

    End Function

    Public Function GetXrayQueueOnDocQueue()

        Dim currQuery As String = Nothing
        If Cgrp = 3 Then
            currQuery = "SELECT " & [CompoundID] & "  FROM " & tableIndividual & " T1 " &
                        "INNER JOIN [settings].[queue_manager] T2 " &
                        "ON " &
                        "T1 ." & [INDIVIDID] & " = T2.DSS_ID WHERE " &
                        "T2.examination='YES' AND T2.xray='NO' AND  t2.[status]='NO' and T2.Visit_ID IN(SELECT Visit_ID FROM [PCS].[settings].[xrayqueue] WHERE [status]='NO') " &
                        "AND T2.Visit_ID IN(SELECT Visit_ID FROM [PCS].[settings].[workLoadSchedule] WHERE doctor='" + Cuser + "' AND job_status='pending')  group by " & compoundgroup & "  ORDER BY min(visit_ID) ASC"

        ElseIf Cgrp = 1 Or Cgrp = 7 Then

            currQuery = "SELECT " & [CompoundID] & "  FROM  " & tableIndividual & " T1 " &
                        "INNER JOIN [settings].[queue_manager] T2 " &
                        "ON " &
                        "T1 ." & [INDIVIDID] & " = T2.DSS_ID WHERE " &
                        "T2.examination='YES' and  T2.[status]='NO' AND T2.xray='NO' AND T2.Visit_ID IN(SELECT Visit_ID FROM [PCS].[settings].[xrayqueue] WHERE [status]='NO') " &
                        "AND T2.Visit_ID IN(SELECT Visit_ID FROM [PCS].[settings].[workLoadSchedule] WHERE job_status='pending') group by " & compoundgroup & "  ORDER BY min(visit_ID) ASC"
        End If

        Return currQuery

    End Function

    Public Function GetXrayQueueFormQueueTable(ByVal frmMode As String, ByVal myqueueTable As String, ByVal myDR As String, ByVal myschema As String)

        Dim currQuery = Nothing
        Select Case frmMode

            Case "Add"
                currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                                          "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                                          "ON T1.DSS_ID=T2 ." & [INDIVIDID] & "  " &
                                          "AND T2 ." & [INDIVIDID] & " IN(SELECT DSS_ID FROM [PCS].[" + myschema + "].[" + myqueueTable + "] WHERE status='NO'') and t1.status='NO' ORDER BY T1.Rec_Date ASC"
            Case "Edit"
                currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                          "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                          "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                          "AND T2 ." & [INDIVIDID] & " IN(SELECT DSS_ID FROM [PCS].[" + myschema + "].[" + myqueueTable + "] WHERE status='YES')  ORDER BY T1.Rec_Date ASC"
        End Select

        Return currQuery

    End Function
    Public Function GetXSampleToBarcodeQueueTable(ByVal frmMode As String)

        Dim currQuery = Nothing
        Select Case frmMode

            Case "Add"
                currQuery = "SELECT T1 ." & [INDIVIDID] & " AS INDIVIDID, T2.Visit_ID as visit,T2.Rec_Date as tdate,T2.category as cat,T2.officer as clerk,T1.NAME as fname," & Names & ",T1." & Gen & " as sex,T1." & DOB & " as dob " &
                            "FROM [PCS].[settings].[queue_manager] T2 INNER JOIN " & tableIndividual & " T1 " &
                            "ON T2.DSS_ID=T1 ." & [INDIVIDID] & "  WHERE T2.barcode='NO' " &
                            "AND T2.Visit_ID NOT IN(SELECT Visit_ID FROM [PCS].[medical].[sample_barcodes]) " &
                            "AND T2.Visit_ID NOT IN(SELECT Visit_ID FROM [PCS].[medical].[samplequeue] WHERE [status]='YES') ORDER BY T2.Rec_Date ASC"
            Case "Edit"

                currQuery = "SELECT T1 ." & [INDIVIDID] & " AS INDIVIDID, T2.Visit_ID as visit,T2.Rec_Date as tdate,T2.category as cat,T2.officer as clerk,T1.NAME as fname," & Names & ",T1." & Gen & " as sex,T1." & DOB & " as dob " &
                            "FROM [PCS].[settings].[queue_manager] T2 INNER JOIN " & tableIndividual & " T1 " &
                            "ON T1.DSS_ID=T1 ." & [INDIVIDID] & "  WHERE T2.barcode='YES' " &
                            "AND T1 ." & [INDIVIDID] & " IN(SELECT DSS_ID FROM [PCS].[medical].[sample_results]) ORDER BY T1.Rec_Date ASC"
        End Select

        Return currQuery

    End Function
    Public Function GetPatientQueueDiagnosis(ByVal frmMode As String)

        Dim currQuery = Nothing
        Select Case frmMode

            Case "Add"
                currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                            "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                            "ON T1.DSS_ID=T2 ." & [INDIVIDID] & "  " &
                            "AND T1.examination='YES' AND T1.diagnosis='NO' AND T1.[status]='NO' " &
                            "AND T1.Visit_ID NOT IN(SELECT Visit_ID FROM [PCS].[settings].[xrayqueue] WHERE [status]='NO') " &
                             "AND T1.Visit_ID NOT IN(SELECT Visit_ID FROM [PCS].[medical].[samplequeue] WHERE [status]='NO') " &
                            "AND T2.Visit_ID NOT IN(SELECT Visit_ID FROM [PCS].[settings].[labqueue] WHERE [status]='NO') " &
                            "AND T1.Visit_ID NOT IN(SELECT Visit_ID FROM [PCS].[medical].[labqueue] WHERE [status]='NO') " &
                                "AND T1.Visit_ID IN(SELECT Visit_ID FROM settings .workLoadSchedule WHERE doctor ='" + Cuser + "') and t1.status='NO' ORDER BY T1.Rec_Date ASC"

            Case "Edit"
                currQuery = "SELECT T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                            "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                            "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                            "WHERE T1.examination='YES' AND T1.diagnosis='YES' AND T1.disposition='NO' " &
                            "AND T1.Visit_ID IN(SELECT Visit_ID FROM [PCS].[settings].[xrayqueue] WHERE [status]='YES') " &
                            "AND T1.Visit_ID IN(SELECT Visit_ID FROM [PCS].[medical].[samplequeue] WHERE [status]='YES') " &
                            "AND T1.Visit_ID IN(SELECT Visit_ID FROM [PCS].[medical].[labqueue] WHERE [status]='YES') " &
                            "AND T1.Visit_ID IN(SELECT Visit_ID FROM settings .workLoadSchedule WHERE doctor ='" + Cuser + "') group by " & CompoundID & "  ORDER BY min(visit_ID)"
            Case "AddQueue"
                currQuery = "SELECT  " & [CompoundID] & " FROM " & tableIndividual & " T1 " &
                            "INNER JOIN [settings].[queue_manager] T2 " &
                            "ON " &
                            "T1 ." & [INDIVIDID] & " = T2.DSS_ID  " &
                            "WHERE T2.examination='YES' AND samples='YES' AND T2.diagnosis='NO'  and  t2.status='NO' " &
                            "AND T2.Visit_ID NOT IN(SELECT Visit_ID FROM [PCS].[settings].[xrayqueue] WHERE [status]='NO') " &
                            "AND T2.Visit_ID IN(SELECT Visit_ID FROM [PCS].[medical].[samplequeue] WHERE [status]='YES' or [status]='NA') " &
                            "AND T2.Visit_ID NOT IN(SELECT Visit_ID FROM [PCS].[settings].[labqueue] WHERE [status]='NO') " &
                            "AND T2.Visit_ID IN(SELECT Visit_ID FROM [PCS].[settings].[workLoadSchedule] WHERE doctor ='" + Cuser + "' AND [job_status]='pending')" &
                            "  group by " & compoundgroup & "  ORDER BY min(visit_ID) ASC"

            Case "hcourse"
                currQuery = "SELECT  " & [CompoundID] & "  FROM " & tableIndividual & " T1 " &
                            "INNER JOIN [settings].[queue_manager] T2 " &
                            "ON " &
                            "T1 ." & [INDIVIDID] & " = T2.DSS_ID  " &
                            "WHERE T2.examination='YES' AND T2.diagnosis='YES' AND course ='NO' " &
                            "AND T2.Visit_ID IN(SELECT Visit_ID FROM [PCS].[medical].[disposition] where disposition = 'Admit Lwak') and t2.status = 'no' " &
                            "AND T2.Visit_ID NOT IN(SELECT Visit_ID FROM [PCS].[medical].[discharge]) " &
                            " group by " & compoundgroup & "  ORDER BY min(visit_ID) ASC"

            Case "medication"
                currQuery = "SELECT  " & [CompoundID] & " ,T2.Rec_Date FROM " & tableIndividual & " T1 " &
                            "INNER JOIN [settings].[queue_manager] T2 " &
                            "ON " &
                            "T1 ." & [INDIVIDID] & " = T2.DSS_ID  " &
                            "WHERE T2.diagnosis='YES' AND medication ='NO' " &
                            " AND T2.Visit_ID IN(SELECT Visit_ID FROM [PCS].[settings].[workLoadSchedule] WHERE doctor='" + Cuser + "' AND job_status='pending') ORDER BY " & compoundwhere & " ASC"

            Case "disposition"
                currQuery = "SELECT   " & [CompoundID] & " ,T2.Rec_Date FROM " & tableIndividual & " T1 " &
                            "INNER JOIN [settings].[queue_manager] T2 " &
                            "ON " &
                            "T1 ." & [INDIVIDID] & " = T2.DSS_ID  " &
                            "WHERE T2.medication='YES' AND t2.disposition ='NO' " &
                            " AND T2.Visit_ID IN(SELECT Visit_ID FROM [PCS].[settings].[workLoadSchedule] WHERE doctor='" + Cuser + "' AND job_status='pending') ORDER BY " & compoundwhere & " ASC"

            Case "HIV"
                currQuery = "SELECT  " & [CompoundID] & " , T2.Rec_Date FROM " & tableIndividual & " T1 " &
                            "INNER JOIN [settings].[queue_manager] T2 " &
                            "ON " &
                            "T1 ." & [INDIVIDID] & " = T2.DSS_ID  " &
                            "WHERE (T2.TB='YES' or T2.TB='NA') and T2.HIV='NO' and (T2.TB1='YES' or T2.TB1='NA') and (T2.TB2='YES' or T2.TB2='NA') and (T2.TB3='YES' or T2.TB3='NA') and (T2.TB4 = 'YES' or T2.TB4='NA')" &
                            " AND T2.Visit_ID IN(SELECT Visit_ID FROM [PCS].[settings].[workLoadSchedule] WHERE doctor='" + Cuser + "' AND job_status='pending') ORDER BY " & compoundwhere & " ASC"

            Case "TB"
                currQuery = "SELECT  " & [CompoundID] & " ,T2.Rec_Date FROM " & tableIndividual & " T1 " &
                            "INNER JOIN [settings].[queue_manager] T2 " &
                            "ON " &
                            "T1 ." & [INDIVIDID] & " = T2.DSS_ID  " &
                            "WHERE T2.TB='YES' and (T2.TB1='NO' or  T2.TB2='NO' or T2.TB3='NO' or T2.TB4='NO') AND (t2.[status] = 'NO' or t2.[Status] = 'TBQ')" &
                            "AND T2.Visit_ID IN(SELECT Visit_ID FROM [PCS].[settings].[workLoadSchedule] WHERE doctor='" + Cuser + "') ORDER BY " & compoundwhere & " ASC"

                'Case "TB"
                '    currQuery = "SELECT  " & [CompoundID] & " ,T2.Rec_Date FROM " & tableIndividual & " T1 " & _
                '                "INNER JOIN [settings].[queue_manager] T2 " & _
                '                "ON " & _
                '                "T1 ." & [INDIVIDID] & " = T2.DSS_ID  " & _
                '                "WHERE T2.TB='YES' and (T2.TB1='NO' or  T2.TB2='NO' or T2.TB3='NO' or T2.TB4='NO')  " & _
                '                "AND T2.Visit_ID IN(SELECT Visit_ID FROM [PCS].[settings].[workLoadSchedule] WHERE doctor='" + Cuser + "') ORDER BY " & compoundwhere & " ASC"


            Case "samples"
                currQuery = "SELECT DISTINCT " & [CompoundID] & " ,T2.Rec_Date FROM " & tableIndividual & " T1 " &
                            "INNER JOIN [settings].[queue_manager] T2 " &
                            "ON " &
                            "T1 ." & [INDIVIDID] & " = T2.DSS_ID  " &
                            "WHERE T2.examination='YES' AND disposition ='NO' and visit_id in (select Visit_ID from medical.examination) and visit_id not in (select visit_ID from medical.sample_defition)" &
                            "and (T2.TB='YES' or T2.TB='NA') and (T2.TB1='YES' or T2.TB1='NA') and (T2.TB2='YES' or T2.TB2='NA') and (T2.TB3='YES' or T2.TB3='NA') and (T2.TB4 = 'YES' or T2.TB4='NA') " &
                            "AND T2.Visit_ID IN(SELECT Visit_ID FROM [PCS].[settings].[workLoadSchedule] WHERE doctor='" + Cuser + "' AND job_status='pending') ORDER BY " & compoundwhere & " ASC"
        End Select

        Return currQuery
    End Function

    Public Function GetPatientQueueLaboratory(ByVal frmMode As String)

        Dim currQuery = Nothing
        Select Case frmMode

            Case "Add"
                currQuery = "SELECT distinct T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                            "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                            "ON T1.DSS_ID=T2 ." & [INDIVIDID] & "  " &
                            "AND T1.examination='YES' AND T1.diagnosis='NO' " &
                            "AND T1.Visit_ID IN(SELECT Visit_ID FROM [PCS].[settings].[labqueue] WHERE [status]='NO') and  [status]='NO' ORDER BY T1.Rec_Date ASC"
            Case "Edit"
                currQuery = "SELECT distinct T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                            "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                            "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                            "AND T1.examination='YES' AND T1.diagnosis='NO' " &
                            "AND T1.Visit_ID IN(SELECT Visit_ID FROM [PCS].[settings].[labqueue] WHERE [status]='YES') ORDER BY T1.Rec_Date ASC"
        End Select

        Return currQuery
    End Function

    Public Function GetPatientLoadQueryForBulkHistory(ByVal md As String, ByVal crTbl As String, ByVal crOption As String)

        GetFormMode = md
        GetCurrentTable = crTbl
        GetCurrentTableOption = crOption
        Dim currQuery As String = Nothing

        Select Case md

            Case "examination"
                currQuery = "SELECT distinct T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                            "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                            "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                            "WHERE T1." + curTable + "='" + curTableOption + "' AND " &
                            " " & [INDIVIDID] & " IN(SELECT DSS_ID FROM [PCS].[settings].[workLoadSchedule] WHERE doctor='" + Cuser + "')  ORDER BY T1.Rec_Date ASC"
            Case "Add"
                currQuery = "SELECT distinct T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                            "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                            "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                            "WHERE T1." + curTable + "='" + curTableOption + "' AND " &
                            " " & [INDIVIDID] & " IN(SELECT DSS_ID FROM[PCS].[settings].[workLoadSchedule] WHERE doctor='" + Cuser + "')  ORDER BY T1.Rec_Date ASC"
            Case "Edit"
                currQuery = "SELECT distinct T2 ." & [INDIVIDID] & " AS INDIVIDID, T1.Visit_ID as visit,T1.Rec_Date as tdate,T1.category as cat,T1.officer as clerk,T2.NAME as fname," & Names & ",T2." & Gen & " as sex,T2." & DOB & " as dob " &
                            "FROM [PCS].[settings].[queue_manager] T1 INNER JOIN " & tableIndividual & " T2 " &
                            "ON T1.DSS_ID=T2 ." & [INDIVIDID] & " " &
                            "WHERE T1." + curTable + "='" + curTableOption + "' AND " &
                            " " & [INDIVIDID] & " IN(SELECT DSS_ID FROM[PCS].[settings].[workLoadSchedule] WHERE doctor='" + Cuser + "')  ORDER BY T1.Rec_Date ASC"
        End Select

        Return currQuery
    End Function

End Class
