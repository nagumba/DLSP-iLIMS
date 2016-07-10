
Public Class frmFreezers

    Dim objCommon As New clsCommonMethods
    Dim db As New iLabDataContext
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        db.Connection.Open()
        db.Transaction = db.Connection.BeginTransaction

        Try
            db.manage_Freezers(nud_Fno.Value, txtFreezerLocation.Text.Trim, txtFreezerName.Text.Trim, dtpInstallDate.Value, nudFreezerShelves.Value, nudFreezerShelves.Value, NudFreezerRacks.Value, Cuser, 1)
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
        loadfreezer()

    End Sub

    Private Sub grpFreezers_Enter(sender As Object, e As EventArgs) Handles grpFreezers.Enter
        If grpFreezers.Enabled = True Then
            cmdSave.Enabled = True
        Else
            cmdSave.Enabled = False

        End If
    End Sub

    Private Sub dgvFreezers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFreezers.CellContentClick

    End Sub

    Private Sub cmdNewFreezer_Click(sender As Object, e As EventArgs) Handles cmdNewFreezer.Click

    End Sub


    Private Sub loadfreezer()
        Dim sql As String = "select * from elab.settings.freezers"
        FillMyGrid(dgvFreezers, sql)
    End Sub
    Private Sub frmFreezers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadfreezer()
    End Sub
End Class