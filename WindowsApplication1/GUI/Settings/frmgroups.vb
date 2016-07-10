Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.Form
Imports System.Security.Cryptography
Imports System.Text
Public Class frmGroups

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdedit.Click
        Rnew = "NO"
        Me.cmdsave.Enabled = True
        Me.cmddelete.Enabled = True

    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        'disable & clear

        'validation before save
        If Me.txtgroup.Text = "" Then
            msgError("Please define the desired group name")
            Exit Sub
        End If
        If Me.txtdescrp.Text = "" Then
            msgError("please provide group description")
        End If

        ' save to the groups table
        Try
            If Qconn.State <> ConnectionState.Open Then
                Qconn.Open()
            End If
            Dim sql As String = ""
            'Dim sqlparams(30) As SqlParameter
            If Rnew = "YES" Then
                sql = "INSERT INTO [PCS].[settings].[groups]([group],description,date,status,officer)" &
                                    "VALUES(@group,@description,@date,@status,@officer)"
            ElseIf Rnew = "NO" Then
                sql = "UPDATE [PCS].[settings].[groups] SET [group]=@group,description=@description WHERE [group]='" + Me.dtggroups.CurrentRow.Cells("group").FormattedValue + "'"
            End If

            Dim cmd As New SqlCommand
            Dim r As Integer
            With cmd
                .Connection = Qconn
                .CommandText = sql
                .Parameters.Clear()

                .Parameters.AddWithValue("@group", Me.txtgroup.Text.ToUpper)
                .Parameters.AddWithValue("@description", Me.txtdescrp.Text)
                .Parameters.AddWithValue("@date", Today.Date)
                .Parameters.AddWithValue("@status", "NO")
                .Parameters.AddWithValue("@officer", "coder")
                r = cmd.ExecuteNonQuery()

                If r > 0 Then

                    If Rnew = "YES" Then
                        msgSuccess("New group added successfully in the system")
                    ElseIf Rnew = "NO" Then
                        msgSuccess("Existing system group edited successfully in the system")
                        Me.txtdescrp.Clear()
                        Me.txtgroup.Clear()
                    End If

                    ' load my grid
                    FillMyGrid(Me.dtggroups, "SELECT [group],description,date,status,officer FROM settings.groups")
                End If

            End With

        Catch ex As Exception

            If Rnew = "YES" Then
                msgError("error in defining a new user group." + ex.Message)
            ElseIf Rnew = "NO" Then
                msgError("error in editing a new user group." + ex.Message)
            End If

        Finally
            Qconn.Close()
        End Try
    End Sub

    Private Sub frmGroups_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'disable edit control
        Me.cmddelete.Enabled = False
        Me.cmdsave.Enabled = False

        ' load my grid
        FillMyGrid(Me.dtggroups, "SELECT [group],description,date,status,officer FROM settings.groups")

    End Sub

    Private Sub cbogrpedit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        Rnew = "YES"
        Me.cmdsave.Enabled = True
        Me.cmddelete.Enabled = False
    End Sub

    Private Sub dtggroups_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtggroups.CellContentClick

    End Sub

    Private Sub dtggroups_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtggroups.Click

        ' pre-populate the controls

        If Rnew = "NO" Then
            Try

                'open DB connection
                openConn()

                Dim sql As String = "SELECT * FROM [PCS].[settings].[groups] WHERE [group]='" + Me.dtggroups.CurrentRow.Cells("group").FormattedValue + "'"
                Dim cmd As New SqlCommand

                With cmd
                    .CommandText = sql
                    .Connection = Qconn

                End With

                Dim Gdr As SqlDataReader = cmd.ExecuteReader

                If Gdr.HasRows Then

                    While Gdr.Read

                        Me.txtgroup.Clear()
                        Me.txtdescrp.Clear()

                        Me.txtgroup.Text = Gdr.Item("group")
                        Me.txtdescrp.Text = Gdr.Item("description")

                    End While
                    Gdr.Close()
                Else
                    msgSuccess("No records available to show")
                End If

            Catch ex As Exception
                msgError("Error in retrieving system group information" + ex.Message)
            Finally

                'close DB connection
                closeConn()
            End Try
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Select Case MsgBox("Are you sure you want to close ?", MsgBoxStyle.YesNo, "Patient care System | IEIP")

            Case MsgBoxResult.Yes
                Me.Close()
            Case MsgBoxResult.No
                Exit Sub
        End Select
    End Sub
End Class