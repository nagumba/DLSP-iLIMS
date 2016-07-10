Public Class frmAliquoting
    Dim db As New iLabDataContext
    Dim objarchives As New clsManageArchives
    Dim objSpecimen As New clsManageSpecimen
    '  Dim frm As New Aliquoting
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not txtAliq1.Text = "" Then
            Try
                db.manage_aliquots(sLabref, sBarcode, txtAliq1.Text, "0", "0", "Active", nudVol.Value, Cuser, 1)
                objarchives.loadAliquots(Me)
                txtAliq1.Clear()
            Catch EX As Exception
                msgError(EX.Message)
            End Try
        Else
            msgError("Please Enter the UniqueID for this aliquot")
        End If
    End Sub


    Private Sub Aliquoting_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBarcode.Text = sBarcode
        txtSampleType.Text = sSampleType
        grpArchiving.Left = 16
        grpArchiving.Top = 311
        grp_Shipping.Left = 16
        grp_Shipping.Top = 311

        Try
            objarchives.loadAliquots(Me)
        Catch EX As Exception
            msgError(EX.Message)

        End Try

        '    dtpColdt.Value = sColldate
    End Sub
    Private Sub cb_freezer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_freezer.SelectedIndexChanged
        ' objSpecimen.populateShelves(Me)
        objarchives.Fillshelf(Me.cb_freezer.Text.Trim, Me)
    End Sub
    Private Sub btn_archive_Click(sender As Object, e As EventArgs) Handles btn_archive.Click
        objarchives.saveArchive(Me)
        db.manage_aliquots(sLabref, sBarcode, txtAliq1.Text, cb_Box.Text.Trim, nud_pos.Value, "", "", Cuser, 4)
        objarchives.loadAliquots(Me)
        txtAliq1.Clear()
        grp_Shipping.Visible = False
        grpArchiving.Visible = False
    End Sub


    Private Sub cb_shelf_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cb_shelf.SelectedIndexChanged
        objarchives.FillRack(Me.cb_shelf.Text.Trim.ToString, Me)
    End Sub

    Private Sub cb_rack_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_rack.SelectedIndexChanged
        objarchives.fillbox(Me.cb_rack.Text.Trim.ToString, Me)
    End Sub
    Private Sub cmdGBox_Click(sender As Object, e As EventArgs) Handles cmdGBox.Click
        BoxView.ShowDialog()
    End Sub

    Private Sub dgvAliquots_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAliquots.CellContentClick



        txtAliq1.Text = Me.dgvAliquots.CurrentRow.Cells("UniqueID").Value
        Dim sboxid As Integer = Me.dgvAliquots.CurrentRow.Cells("BoxID").Value

    End Sub
    Private Sub Form_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvAliquots.MouseClick
        If (e.Button = Windows.Forms.MouseButtons.Right) Then
            ' ctxMenu.Show()
            dgvAliquots.ContextMenuStrip = ctxMenu
        End If
    End Sub




    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtAliq1_TextChanged(sender As Object, e As EventArgs) Handles txtAliq1.TextChanged

    End Sub

    Private Sub ArchiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArchiveToolStripMenuItem.Click
        grpArchiving.Visible = True

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        grp_Shipping.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            db.manage_Shipping(0, sBarcode, txtAliq1.Text.Trim, cb_origin.Text.Trim, cb_destination.Text.Trim, dtpsenddate.Value, "1900-01-01", txtAddressee.Text.Trim, "", Cuser, "NO", "NO", 1)
            db.manage_aliquots(sLabref, sBarcode, txtAliq1.Text, "0", "0", "SHIPPED -" & cb_destination.Text.Trim, nudVol.Value, Cuser, 4)
            objarchives.loadAliquots(Me)
            txtAliq1.Clear()
            grpArchiving.Visible = False
            grp_Shipping.Visible = False
        Catch Err As Exception
            MsgBox(Err.Message)
        End Try


    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If Not txtAliq1.Text.Trim = "" Then
            If MsgBox("Are you sure you want to delete this aliquot", vbYesNo, MsgBoxStyle.Critical) = vbYes Then
                '   objarchives.saveArchive(Me)
                db.manage_aliquots(0, 0, txtAliq1.Text, 0, 0, 0, 0, 0, 3)
                objarchives.loadAliquots(Me)
                txtAliq1.Clear()
                msgSuccess("The sample has succefully been deleted")
                grpArchiving.Visible = False
                grp_Shipping.Visible = False
            End If
        Else
            msgError("You must select an aliquot to delete")
        End If
    End Sub
End Class