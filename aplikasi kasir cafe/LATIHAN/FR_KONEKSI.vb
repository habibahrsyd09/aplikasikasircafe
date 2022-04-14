Public Class FR_KONEKSI

    Private Sub FR_KONEKSI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTNKELUAR_Click(sender As Object, e As EventArgs) Handles BTNKELUAR.Click
        End
    End Sub

    Private Sub BTNKONEK_Click(sender As Object, e As EventArgs) Handles BTNKONEK.Click
        If TXTSERVER.Text = "" Or TXTUSER.Text = "" Or TXTPASSWORD.Text = "" Or TXTDATA.Text = "" Then
            MsgBox("DATA TIDAK LENGKAP..")
        Else
            With My.Settings
                .SERVER = TXTSERVER.Text
                .USER = TXTUSER.Text
                .PASSWORD = TXTPASSWORD.Text
                .DATABASE = TXTDATA.Text
                .Save()
            End With

            KONEKAN()

            Dim FR As New FR_LOGIN
            FR.Show()
            Me.Close()
        End If
    End Sub

End Class