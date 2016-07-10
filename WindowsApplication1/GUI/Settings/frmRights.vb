Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.Form
Imports System.Security.Cryptography
Imports System.Text
Public Class frmRights

    Private Sub frmRights_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'load groups for edit
        loadCombo(Me.grp, "SELECT [group],groupID FROM dbo.groups WHERE status='YES'", "group", "groupID")
        'load grid values
        'load the system modules
        loadCombo(Me.cbomod, "SELECT * FROM dbo.modulles WHERE status='YES'", "module", "modID")
        FillMyGrid(Me.dtgrights, "SELECT * FROM dbo.rights")

        ' disbale controls
        If Me.cbomod.Text = "" Then
            Me.grp.Enabled = False
            Me.cmdsave.Enabled = False
        Else
            Me.grp.Enabled = True
            Me.cmdsave.Enabled = True
        End If
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        If Qconn.State <> ConnectionState.Open Then
            Qconn.Open()
        End If
        Dim rsql As String = ""
        Try
            Dim sql As String = "SELECT * FROM dbo.rights WHERE groupID = '' AND modID= ''"
            Dim cmd As New SqlCommand(sql, Qconn)
            Dim r As Integer
            r = cmd.ExecuteNonQuery
            If r > 0 Then
                'update
                Dim k As Integer
                If Me.statusA.Checked = True Then
                    rsql = "UPDATE dbo.rights SET access='YES' WHERE groupID ='" & Me.grp.SelectedValue & "' AND modID='" & Me.cbomod.SelectedValue & "'"
                    k = cmd.ExecuteNonQuery()
                    If k > 0 Then
                        msgSuccess("System Rights Assigned successfully")
                    End If
                ElseIf Me.statusD.Checked = True Then
                    rsql = "UPDATE dbo.rights SET access='NO' WHERE groupID='" & Me.grp.SelectedValue & "' AND modID='" & Me.cbomod.SelectedValue & "'"
                    If k > 0 Then
                        msgSuccess("System Rights De-assigned successfully")
                    End If
                End If
            Else
                ' insert
                rsql = "INSERT INTO dbo.rights (groupID,modID,access,date,status,officer)VALUES(@groupID,@modID,@access,@date,@status,@officer)"
                With cmd
                    .Connection = Qconn
                    .CommandText = rsql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@groupID", Me.grp.SelectedValue)
                    .Parameters.AddWithValue("@modID", Me.cbomod.SelectedValue)
                    If Me.statusA.Checked = True Then
                        .Parameters.AddWithValue("@access", "YES")
                    Else
                        .Parameters.AddWithValue("@access", "NO")
                    End If
                    .Parameters.AddWithValue("@date", Today.Date)
                    If Me.status.Checked = True Then
                        .Parameters.AddWithValue("@status", "YES")
                    Else
                        .Parameters.AddWithValue("@status", "NO")
                    End If
                    .Parameters.AddWithValue("@officer", Cuser)
                    Dim g As Integer
                    g = cmd.ExecuteNonQuery
                    If g > 0 Then
                        'load grid values
                        FillMyGrid(Me.dtgrights, "SELECT * FROM dbo.rights")
                        msgSuccess("NEW SYSTEM RIGHT ASSIGNED SUCCESSFULLY TO " & Me.grp.Text)
                    End If
                End With
            End If
        Catch ex As Exception
            msgError("Failed saving system rights for the group" & ex.Message)
        Finally
            Qconn.Close()
        End Try
    End Sub

    Private Sub statusA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles statusA.CheckedChanged
        If Me.statusA.Checked = True Then
            Me.statusD.Checked = False
        End If
    End Sub

    Private Sub statusD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles statusD.CheckedChanged
        If Me.statusD.Checked = True Then
            Me.statusA.Checked = False
        End If
    End Sub

    Private Sub cbomod_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbomod.Click
        'update the checked rights as selected
        Try
            If Qconn.State <> ConnectionState.Open Then
                Qconn.Open()
            End If
            Dim sql As String = "SELECT * FROM dbo.rights WHERE groupID='" & Me.grp.SelectedValue & "' AND modID='" & Me.cbomod.SelectedValue & "' AND status='YES'"
            Dim cmd As New SqlCommand(sql, Qconn)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            While dr.Read
                If dr.Item("access") = "YES" Then
                    Me.statusA.Checked = True
                Else
                    Me.statusA.Checked = False
                End If
                If dr.Item("status") = "YES" Then
                    Me.status.Checked = True
                Else
                    Me.status.Checked = False
                End If
            End While
            dr.Close()
        Catch ex As Exception
            msgError("FAILED LOADING THE RIGHTS " & ex.Message)
        End Try
    End Sub

    Private Sub cbomod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbomod.SelectedIndexChanged

    End Sub

    Private Sub grp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grp.Click
        'load all the groups on click
        ' loadCombo(Me.grp, "SELECT [group],groupID FROM dbo.groups WHERE status='YES'", "group", "groupID")
    End Sub

    Private Sub grp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grp.SelectedIndexChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class