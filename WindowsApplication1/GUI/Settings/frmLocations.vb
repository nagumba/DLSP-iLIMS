Imports System.Data.SqlClient

Public Class frmLocations
    Dim objCommon As New clsCommonMethods
    Dim db As New iLabDataContext
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        db.Connection.Open()
        db.Transaction = db.Connection.BeginTransaction

        Try
            db.manage_Locations(cb_Country.Text.Trim, cb_county.Text.Trim, Province.SelectedIndex, txtLocation.Text.Trim, Cuser, 1)
            db.SubmitChanges()
            db.Transaction.Commit()
            msgSuccess("Location details successfully Recorded!")

        Catch ex As Exception
            msgError("Internal application error in updating Locaion information! " + ex.Message)
            db.Transaction.Rollback()

            Exit Sub
            Return
        Finally
            db.Connection.Close()
        End Try
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub frmLocations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "select * from elab.settings.locations"
        FillMyGrid(dvgLocations8, query)
    End Sub
End Class