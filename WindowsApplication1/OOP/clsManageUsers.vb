Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.Form
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Data.Linq
Imports System.Collections.Generic
Imports System.Text

Public Class clsManageUsers
    Dim objCommon As New clsCommonMethods
    Dim db As New iLabDataContext
    Public Sub AddNewRecord(ByVal frm As frmusers)

        Select Case MsgBox("Are you sure you want to save the New username ? ", MsgBoxStyle.YesNo, "Patient Care System | PCS")

            Case MsgBoxResult.Yes
                Cursor.Current = Cursors.WaitCursor
                db.Connection.Open()
                Dim dbTrans = db.Connection.BeginTransaction
                Try
                    Dim k As Integer = 0
                    Dim pwds As String = encrypt(frm.pwd.Text)

                    Select Case frm.grp.Text

                        Case "ADMIN"
                            k = 1
                        Case "NURSES"
                            k = 2
                        Case "DOCTOR"
                            k = 3
                        Case "CLERK"
                            k = 4
                        Case "LAB STAFF"
                            k = 5
                        Case "PHARMACY"
                            k = 8

                    End Select
                    db.manageUsers(0, k, frm.fname.Text, frm.onames.Text, frm.initials.Text, frm.usrnm.Text, pwds, 0, frm.email.Text, Today.Date, "YES", Cuser, 1)
                    db.SubmitChanges()
                    dbTrans.Commit()
                    msgSuccess("New system user successfully added !")
                Catch ex As Exception
                    msgError("internal application error in creating a new system user! " + ex.Message)
                    dbTrans.Rollback()
                    Exit Sub
                    Return
                Finally
                    db.Connection.Close()
                End Try
                Cursor.Current = Cursors.Default
            Case MsgBoxResult.No
                msgWarn("new system user creation aborted by user!")
                Exit Sub
        End Select
    End Sub
    Public Sub EditOldRecord(ByVal frm As frmusers, ByVal usID As Integer)


        Select Case MsgBox("Are you sure you want to update user details ? ", MsgBoxStyle.YesNo, "Patient Care System | PCS")

            Case MsgBoxResult.Yes
                Cursor.Current = Cursors.WaitCursor
                db.Connection.Open()
                Dim dbTrans = db.Connection.BeginTransaction
                Try
                    db.manageUsers(usID, frm.grp.SelectedValue, frm.fname.Text, frm.onames.Text, frm.initials.Text, frm.usrnm.Text, encrypt(frm.pwd.Text), 0, frm.email.Text, Today.Date, "YES", Cuser, 2)
                    db.SubmitChanges()
                    dbTrans.Commit()
                    msgSuccess("system user details updated successfully !")
                Catch ex As Exception
                    msgError("internal application error in updating system user details! " + ex.Message)
                    dbTrans.Rollback()
                Finally
                    db.Connection.Close()
                End Try
                Cursor.Current = Cursors.Default
            Case MsgBoxResult.No
                msgWarn("new system user creation aborted by user!")
                Exit Sub
        End Select
    End Sub
    Public Sub FormSkipRulesController(ByVal frm As frmusers, ByRef myMode As String)

        objCommon.SetCurrentFormMode = myMode

        Select Case objCommon.SetCurrentFormMode

            Case "examination"
                frm.GroupBox1.Enabled = False
                frm.cmdsave.Enabled = False
                frm.cmddelete.Enabled = False
            Case "Add"
                frm.GroupBox1.Enabled = True
                frm.cmdaddnew.Enabled = True
                frm.cmdsave.Enabled = True
            Case "Edit"
                frm.GroupBox1.Enabled = True
                frm.cmdaddnew.Enabled = True
                frm.cmdedit.Enabled = True
                frm.cmdsave.Enabled = True
                frm.cmddelete.Enabled = True
                frm.pwd.Text = "XXX"
                frm.cpwd.Text = "XXX"
        End Select

    End Sub

End Class
