
Public Class clsManageArchives
    Public db As New iLabDataContext
    Public Sub Fillshelf(fr_id As Integer, frm As frmAliquoting)
        'Dim con As New SqlConnection(strConn)
        Dim cmd As New SqlClient.SqlCommand()
        cmd.Connection = db.Connection
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT distinct rtrim(ltrim(shelf_id)) as shelf_id FROM  shelves where fr_id = " & frm.cb_freezer.Text.Trim
        Dim objDs As New DataSet()
        Dim dAdapter As New SqlClient.SqlDataAdapter()
        dAdapter.SelectCommand = cmd
        db.Connection.Open()
        dAdapter.Fill(objDs)
        db.Connection.Close()
        frm.cb_shelf.ValueMember = "shelf_id"
        frm.cb_shelf.DisplayMember = "shelf_id"
        frm.cb_shelf.DataSource = objDs.Tables(0)
    End Sub


    Public Sub populateComboOptions(ByVal frm As frmAliquoting)
        Dim fr As String = "SELECT distinct cast(fr_no as integer) from settings.freezers" 'load shelf

        frm.cb_freezer.DataSource = Nothing

        loadCombo(frm.cb_freezer, fr, "settings.freezers", "fr_no")

    End Sub



    Public Sub FillRack(shelf_id As String, frm As frmAliquoting)
        'Dim con As New SqlConnection(strConn)
        Dim cmd As New SqlClient.SqlCommand()
        cmd.Connection = db.Connection
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT distinct rtrim(ltrim(rack_id)) as rack_id FROM  racks where shelf_id = '" & frm.cb_shelf.Text.Trim.ToString & "'"
        Dim objDs As New DataSet()
        Dim dAdapter As New SqlClient.SqlDataAdapter()
        dAdapter.SelectCommand = cmd
        db.Connection.Open()
        dAdapter.Fill(objDs)
        db.Connection.Close()
        frm.cb_rack.ValueMember = "rack_id"
        frm.cb_rack.DisplayMember = "rack_id"
        frm.cb_rack.DataSource = objDs.Tables(0)
    End Sub
    Public Sub fillbox(rack_id As String, frm As frmAliquoting)
        'Dim con As New SqlConnection(strConn)
        Dim cmd As New SqlClient.SqlCommand()
        cmd.Connection = db.Connection
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT distinct rtrim(ltrim(boxid)) as boxid FROM  boxes where rack_id = '" & frm.cb_rack.Text.Trim & "'"
        Dim objDs As New DataSet()
        Dim dAdapter As New SqlClient.SqlDataAdapter()
        dAdapter.SelectCommand = cmd
        db.Connection.Open()
        dAdapter.Fill(objDs)
        db.Connection.Close()
        frm.cb_Box.ValueMember = "boxid"
        frm.cb_Box.DisplayMember = "boxid"
        frm.cb_Box.DataSource = objDs.Tables(0)
    End Sub


    Public Sub Fillrr(frm As frmAliquoting)
        'Dim con As New SqlConnection(strConn)
        Dim cmd As New SqlClient.SqlCommand()
        cmd.Connection = db.Connection
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT distinct rtrim(ltrim(rack_id)) as rack_id FROM  racks where shelf_id = '" & frm.cb_shelf.Text.Trim & "'"
        Dim objDs As New DataSet()
        Dim dAdapter As New SqlClient.SqlDataAdapter()
        dAdapter.SelectCommand = cmd
        db.Connection.Open()
        dAdapter.Fill(objDs)
        db.Connection.Close()
        frm.cb_rack.ValueMember = "rack_id"
        frm.cb_rack.DisplayMember = "rack_id"
        frm.cb_rack.DataSource = objDs.Tables(0)
    End Sub
    Public Sub loadArchives(frm As frmAliquoting)
        Dim sql As String = "SELECT distinct b.barcode,b.UniqueID,a.[FR_No] ,a.[Shelf_ID] ,a.[Rack_ID] ,b.[BoxID],b.[Pos_Ref]  FROM [eLab].[dbo].[Positions*] a,Archivings b where b.BOXID = a.BoxID and Barcode = '" & frm.txtBarcode.Text.Trim & "'"
        ' FillMyGrid(frm.dgvArchives, sql)
    End Sub


    Public Sub loadAliquots(frm As frmAliquoting)
        Dim sql As String = "Select * FROM aliquots WHERE BARCODE = '" & frm.txtBarcode.Text & "'"
        FillMyGrid(frm.dgvAliquots, sql)
    End Sub




    Public Sub populateShelves(ByVal frm As frmSamples)
        Dim sql1 As String = "SELECT shelf_ID FROM [eLab].[dbo].[shelves] where FR_ID =  " & frm.cb_freezer.Text.Trim & " order by shelf_ID" 'load locations
        frm.cb_shelf.DataSource = Nothing
        loadCombo(frm.cb_shelf, sql1, "shelves", "shelf_ID")
    End Sub

    Public Sub populateBox(ByVal frm As frmSamples)
        Dim sql1 As String = "Select boxid FROM [eLab].[dbo].[boxes] where rack_ID = '" & frm.cb_rack.Text.Trim & "' order by boxid" 'load locations
        frm.cb_Box.DataSource = Nothing
        loadCombo(frm.cb_Box, sql1, "boxes", "boxid")
    End Sub

    Public Sub saveArchive(frm As frmAliquoting)
        Try
            db.manage_archives(1, frm.txtBarcode.Text.Trim, frm.txtAliq1.Text.Trim, frm.cb_Box.Text.Trim, frm.nud_pos.Value, 1, Now.Date, Cuser, 1)
            msgSuccess("Saved successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
