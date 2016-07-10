Public Class frmShipping
    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim sql As String

        If DateTimePicker1.Checked = True Then
            sql = "select * from [eLab].[dbo].[Shipping] where shippin_date = '" & DateTimePicker1.Value.Date & "'"
        Else
            sql = "select * from [eLab].[dbo].[Shipping] "
        End If

        FillMyGrid(DataGridView1, Sql)
    End Sub
End Class