Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.Form
Imports System.Security.Cryptography
Imports System.Text
Public Class frmusers

    Public flag As String = "NO"
    Dim objCommon As New clsCommonMethods
    Dim objUsers As New clsManageUsers

    Private Sub frmusers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        objCommon.SetCurrentFormMode = "examination"
        objUsers.FormSkipRulesController(Me, objCommon.SetCurrentFormMode)
        loadCombo(Me.grp, "SELECT [group],groupID FROM [PCS].[settings].[groups] WHERE status='NO'", "group", "groupID")
        lstSystemusers(lst_users, "SELECT * FROM [PCS].[settings].[users]")

    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click

        'perform validation
        Dim validate_ok As Boolean = validate_users()
        If validate_ok Then
            Exit Sub
        End If


        Select Case objCommon.SetCurrentFormMode
            Case "Add"
                objUsers.AddNewRecord(Me)
                lstSystemusers(lst_users, "SELECT * FROM [PCS].[settings].[users]")
            Case "Edit"
                objUsers.EditOldRecord(Me, Val(lst_users.SelectedItems.Item(0).Text))
                lstSystemusers(lst_users, "SELECT * FROM [PCS].[settings].[users]")
        End Select
    End Sub

    Private Sub cmdedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdedit.Click
        objCommon.SetCurrentFormMode = "Edit"
        objUsers.FormSkipRulesController(Me, objCommon.SetCurrentFormMode)

    End Sub
    Private Sub cmdaddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaddnew.Click

        objCommon.SetCurrentFormMode = "Add"
        objUsers.FormSkipRulesController(Me, objCommon.SetCurrentFormMode)
        Me.grp.DataSource = Nothing
        ResetControls(GroupBox1)
        Me.grp.DataSource = Nothing
        loadCombo(Me.grp, "SELECT [group],groupID FROM settings.groups WHERE status='NO'", "group", "groupID")

    End Sub

    Private Sub dtgusers_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        msgError("cell content")
    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        Select Case MsgBox("Are you sure you want to close this window ?", MsgBoxStyle.YesNo, "Patient care System | IEIP")

            Case MsgBoxResult.Yes
                Me.Close()
            Case MsgBoxResult.No
                Exit Sub
        End Select
    End Sub
    Public Sub lst_view_users()

        Cursor.Current = Cursors.WaitCursor

        Try

            openConn() 'open db conn

            Dim mm_sql As String = "SELECT * FROM [PCS].[dbo].[users] WHERE userID=" & Val(Me.lst_users.SelectedItems.Item(0).Text)
            Dim mm_cmd As New SqlCommand(mm_sql, Qconn)
            Dim mm_dr As SqlDataReader = mm_cmd.ExecuteReader

            If mm_dr.HasRows Then

                While mm_dr.Read
                    fname.Text = mm_dr.Item("fname")
                    onames.Text = mm_dr.Item("onames")
                    initials.Text = mm_dr.Item("code")
                    usrnm.Text = mm_dr("username")
                    email.Text = mm_dr("email")

                End While
            Else
                msgWarn("No records available for fetching!")
            End If

        Catch ex As Exception
            msgError("error in executing user retrieval function " + ex.Message)
        Finally
            closeConn()
        End Try
    End Sub
    Public Function validate_users()

        Dim valid As Boolean = False
        Dim ctrl As Control
        For Each ctrl In Me.GroupBox1.Controls
            If (TypeOf ctrl Is TextBox) Then
                If (ctrl.Name = "txt_email") Then
                Else
                    If ctrl.Text = "" Then
                        msgError("Please provide " + ctrl.Name + " values before save")
                        ctrl.Focus()
                        valid = True

                        Exit For
                    End If
                End If
            End If
        Next

        If valid = False Then
            If pwd.Text.Trim <> cpwd.Text.Trim Then
                msgError("the two passwords do not match,please retry!")
                cpwd.Text = ""
                cpwd.Focus()
                valid = True
            End If
        End If
        Return valid
    End Function
    Public Sub lstSystemusers(ByVal lstview As ListView, ByVal query As String)


        Try

            lst_users.Clear()

            'Set up UpdateRowSource the listview
            lst_users.Columns.Add("user ID", 50, HorizontalAlignment.Left)
            lst_users.Columns.Add("First name", 100, HorizontalAlignment.Left)
            lst_users.Columns.Add("Other names", 150, HorizontalAlignment.Left)
            lst_users.Columns.Add("Code name", 70, HorizontalAlignment.Left)
            lst_users.Columns.Add("username", 80, HorizontalAlignment.Left)
            lst_users.Columns.Add("email", 160, HorizontalAlignment.Left)
            lst_users.Columns.Add("Status", 50, HorizontalAlignment.Left)

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
                Me.lblcount.Text = DT.Rows.Count

                For Each dr In DT.Rows
                    Dim lv As New ListViewItem
                    lv = lstview.Items.Add(dr("userID"))
                    lv.SubItems.Add(dr("fname").ToString)
                    lv.SubItems.Add(dr("onames").ToString)
                    lv.SubItems.Add(dr("code").ToString)
                    lv.SubItems.Add(dr("username").ToString)
                    lv.SubItems.Add(dr("email").ToString)
                    lv.SubItems.Add(dr("status").ToString)
                Next
            Else
                Rec_Found = False
                msgSuccess("No records avaialble to display!")
            End If
        Catch ex As Exception
            msgError("error in retrieving system users" + ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub lst_users_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lst_users.Click

        'pre-populate
        If flag = "YES" Then
            lst_view_users()
        End If
    End Sub

    Private Sub lst_users_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_users.SelectedIndexChanged

    End Sub
End Class