Public Class frmlogin

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click

        If Cuser <> "" Then
            Select Case (MsgBox("Are you sure you want to exit the system?", MsgBoxStyle.YesNo, "DSS Query Tracking System"))
                Case MsgBoxResult.Yes
                    userLogout()
                    'set the logged variable to 0 to allow for login
                    'Application.Exit()
                Case MsgBoxResult.No
                    msgSuccess("System exit cancelled by the user")
                    Me.Show()
                    '   Exit Sub
            End Select
        Else
            Application.Exit()
        End If
    End Sub

    Private Sub cmdlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlogin.Click
        'validate fields
        If Me.txtuser.Text = "" Or Me.txtpwd.Text = "" Then
            msgError("PLEASE CHECK YOUR USERNAME AND / PASSWORD")
            Exit Sub
        End If

        ' call the user authentication module
        'Dim usrLogin As New clsuserLogin

        'usrLogin.userLogin(Me.txtuser.Text.ToLower, encrypt(Me.txtpwd.Text))

        Auth_User_login(Me.txtuser.Text.ToLower, encrypt(Me.txtpwd.Text), Qconn)
        'Auth_User_login(Me.txtuser.Text.ToLower, "GaKFQUS2Oo92F6byJQGbEg==", Qconn)

    End Sub
End Class