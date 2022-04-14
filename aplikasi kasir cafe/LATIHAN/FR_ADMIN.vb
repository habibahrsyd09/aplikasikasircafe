Imports System.Data.SqlClient
Public Class FR_ADMIN


    Private Sub BTNSIMPAN_Click(sender As Object, e As EventArgs) Handles BTNSIMPAN.Click
        If TXTUSER.Text = "" Or TXTPASS.Text = "" Or TXTPASS2.Text = "" Then
            MsgBox("Data Tidak Lengkap...")
        ElseIf TXTPASS.Text <> TXTPASS2.Text Then
            MsgBox("Ulangi penulisan password..")
        Else
            Dim str As String = ""
            str = "select nik from tbl_admin where nik='" & LBNIK.Text & "'"
            Dim cmd As SqlCommand
            Dim rd As SqlDataReader
            cmd = New SqlCommand(str, CONN)
            rd = cmd.ExecuteReader
            If rd.HasRows Then
                rd.Close()
                cmd = New SqlCommand("update tbl_admin set username='" & _
                                     TXTUSER.Text & "',password='" & TXTPASS2.Text & _
                                     "',type='" & CBTYPE.Text & "' where rtrim(nik)='" & _
                                     LBNIK.Text & "'", CONN)
                cmd.ExecuteNonQuery()
            Else
                rd.Close()
                cmd = New SqlCommand("insert into tbl_admin values ('" & _
                                   LBNIK.Text & "','" & TXTUSER.Text & "','" & _
                                   TXTPASS2.Text & "','" & CBTYPE.Text & "')", CONN)
                cmd.ExecuteNonQuery()
            End If
            MsgBox("Data Tersimpan...")
        End If
    End Sub
End Class