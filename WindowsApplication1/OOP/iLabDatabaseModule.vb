
Public Module iLabDatabaseModule

    Dim pcsPage As String = Nothing
    Dim myQuery As String = Nothing

    Public Village As String = ""
    Public Compoundtable As String = ""
    Public CompoundID As String = ""
    Public tableIndividual = ""
    Public DOB As String = ""
    Public INDIVIDID As String = ""
    Public Gen As String = ""
    Public Names As String = ""
    Public compoundwhere As String = ""
    Public compoundgroup As String = ""
    'Variables commonlu used 

    Public ilab_Mode As String

    Public Function GetAppropriateQueryToExecute()

        Return myQuery
    End Function


    Public Sub checkDatabaseFields(ByVal qLocation As String)
        ' QLocation = QLocation
        Select Case qLocation
            Case "kibera"
                Village = "[settings].[Village]"
                CompoundID = "SUBSTRING([ResID],0,10) as [RESID]"
                compoundgroup = "SUBSTRING([ResID],0,10)"
                compoundwhere = "RESID "
                Compoundtable = "[PCS].[Kibera].[Structures]"
                tableIndividual = "[PCS].[Kibera].[Individual]"
                INDIVIDID = "IndUniqID "
                DOB = "DOB"
                Gen = "SEX"
                Names = "Name"
            Case "lwak"
                Village = "[settings].[Village]"
                CompoundID = "COMPOUND"
                compoundgroup = "COMPOUND"
                compoundwhere = "COMPOUND "
                Compoundtable = "[PCS].[settings].[Compound]"
                tableIndividual = "[PCS].[settings].[Individual]"
                INDIVIDID = " INDIVIDID "
                DOB = "BIRTH_DATE"
                Gen = "GENDER"
                Names = "Name as fname,lname as lname"
        End Select



    End Sub


End Module