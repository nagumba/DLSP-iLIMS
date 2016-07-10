Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.Form
Imports System.Security.Cryptography
Imports System.Text
Public Class frmmanagepassword

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmmanagepassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmdexit.Enabled = False
        'loadGroup(Cuser)
        If Cgrp <> "ADMIN" Then
            loadCombo(Me.cbouser, "SELECT * FROM [PCS].[settings].[users] WHERE username='" + Cuser + "'", "username", "username")
        Else
            loadCombo(Me.cbouser, "SELECT * FROM [PCS].[settings].[users] ", "username", "username")
        End If
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Dim pwd As String = Me.txtpwd.Text.Trim
        Dim pwd2 As String = Me.txtpwd2.Text.Trim
        If pwd = "" Then
            msgError("THE PASSWORD FIELD MUST BE FILLED")
            Me.txtpwd.Focus()
            Exit Sub
        End If
        If pwd2 = "" Then
            msgError("THE PASSWORD CONFIRMATION MUST BE FILLED")
            Exit Sub
        End If
        If pwd <> pwd2 Then
            msgError("THE TWO PASSWORDS DO NOT MATCH")
            Me.txtpwd2.Text = ""
            Me.txtpwd2.Focus()
            Exit Sub
        Else
            Try
                If Qconn.State <> ConnectionState.Open Then
                    Qconn.Open()
                End If
                '  Dim sql As String = "UPDATE dbo.users SET password='" + encrypt(pwd) + "' WHERE username='" + Me.cbouser.Text + "'"
                Dim us As String = "nagumba"
                Dim sql As String = "UPDATE [PCS].[settings].[users]  SET password='" + encrypt(pwd) + "' WHERE username='" + us + "'"
                'Dim sql As String = "UPDATE dbo.users SET password='" + encrypt("root") + "' WHERE username='sosewe'"
                Dim cmd As New SqlCommand(sql, Qconn)
                Dim r As Integer
                r = cmd.ExecuteNonQuery
                If r > 0 Then
                    msgSuccess("PASSWORD CHANGED SUCCESSFULLY")
                    Me.txtpwd.Text = ""
                    Me.txtpwd2.Text = ""
                    If Cgrp <> "ADMIN" Then
                        'pcsModulle.userLogout()
                    End If
                End If
            Catch ex As Exception
                msgError("PASSWORD CHANGE FAILED : " & ex.Message)
            End Try
        End If

    End Sub

    Private Sub cbouser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbouser.SelectedIndexChanged
        Me.txtpwd.Text = ""
        Me.txtpwd2.Text = ""
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Select Case MsgBox("Are you sure you want to close ?", MsgBoxStyle.YesNo, "Patient care System | IEIP")

            Case MsgBoxResult.Yes
                Me.Close()
            Case MsgBoxResult.No
                Exit Sub
        End Select
    End Sub
End Class