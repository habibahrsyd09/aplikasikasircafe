Imports System.Data.SqlClient
Public Class FR_KARYAWAN

    Sub TAMPIL()
        Dim STR As String = "SELECT NIK,RTRIM(NAMA) AS NAMA,RTRIM(ASAL) AS ASAL," & _
            " TGL,JK,RTRIM(ALAMAT) AS ALAMAT,RTRIM(NOHP) AS NOHP FROM TBL_KARYAWAN WHERE NAMA LIKE '%" & _
            TXTCARI.Text & "%'"
        Dim DA As SqlDataAdapter
        DA = New SqlDataAdapter(STR, CONN)
        Dim TBL As New DataTable
        DA.Fill(TBL)
        DGTAMPILAN.DataSource = TBL
    End Sub


    Private Sub FR_KARYAWAN_Load(sender As Object, e As EventArgs) Handles Me.Load
        TAMPIL()
        TXTNIK.Text = AUTONIK()
        TXTNAMA.Select()
    End Sub

    Private Sub TXTCARI_TextChanged(sender As Object, e As EventArgs) Handles TXTCARI.TextChanged
        TAMPIL()
    End Sub

    Private Function AUTONIK() As String
        Dim NIK_AWAL As String = Format(Date.Now, "yyyyMM")
        Dim NIK_AKHIR As String = ""
        Dim STR As String = "SELECT MAX(NIK) AS NIK FROM TBL_KARYAWAN"
        Dim CMD As SqlCommand
        CMD = New SqlCommand(STR, CONN)
        Dim RD As SqlDataReader
        RD = CMD.ExecuteReader
        RD.Read()
        If Not IsDBNull(RD.Item("NIK")) Then
            Dim NIK As Integer = Mid(RD.Item("NIK"), 7, 6) + 1
            RD.Close()
            AUTONIK = NIK_AWAL & Format(NIK, "000000")
        Else
            RD.Close()
            AUTONIK = NIK_AWAL & Format(1, "000000")
        End If
        RD.Close()
    End Function

    Private Sub BTNBARU_Click(sender As Object, e As EventArgs) Handles BTNBARU.Click
        TXTNIK.Text = AUTONIK()
    End Sub

    Private Sub TXTNIK_TextChanged(sender As Object, e As EventArgs) Handles TXTNIK.TextChanged
        Dim STR As String = "SELECT * FROM TBL_KARYAWAN WHERE NIK='" & TXTNIK.Text & "'"
        Dim CMD As New SqlCommand(STR, CONN)
        Dim RD As SqlDataReader
        RD = CMD.ExecuteReader
        If RD.HasRows Then
            RD.Read()
            TXTNAMA.Text = RD.Item("NAMA").ToString.Trim
            TXTASAL.Text = RD.Item("ASAL").ToString.Trim
            TGL.Value = RD.Item("TGL")
            If RD.Item("JK") = "L" Then
                CBJK.Text = "LAKI-LAKI"
            ElseIf RD.Item("JK") = "P" Then
                CBJK.Text = "PEREMPUAN"
            End If
            TXTALAMAT.Text = RD.Item("ALAMAT").ToString.Trim
            TXTNO.Text = RD.Item("NOHP").ToString.Trim
            RD.Close()
        Else
            RD.Close()
            TXTNAMA.Clear()
            TXTASAL.Clear()
            TXTALAMAT.Clear()
            TXTNO.Clear()
        End If
        RD.Close()
    End Sub

    Private Sub BTNSIMPAN_Click(sender As Object, e As EventArgs) Handles BTNSIMPAN.Click
        If TXTNIK.Text = "" Or TXTNAMA.Text = "" Then
            MsgBox("DATA TIDAK LENGKAP...")
        Else
            Dim jk As String = ""
            If CBJK.Text = "LAKI-LAKI" Then
                jk = "L"
            ElseIf CBJK.Text = "PEREMPUAN" Then
                jk = "P"
            End If
            Dim STR As String = "SELECT * FROM TBL_KARYAWAN WHERE NIK='" & TXTNIK.Text & "'"
            Dim CMD As SqlCommand
            CMD = New SqlCommand(STR, CONN)
            Dim RD As SqlDataReader
            RD = CMD.ExecuteReader
            If RD.HasRows Then
                RD.Close()
                STR = "UPDATE TBL_KARYAWAN SET NAMA='" & TXTNAMA.Text & "',ASAL='" & _
                    TXTASAL.Text & "',TGL='" & Format(TGL.Value, "MM/dd/yyyy") & "',JK='" & jk & _
                    "',ALAMAT='" & TXTALAMAT.Text & "',NOHP='" & TXTNO.Text & "' WHERE NIK='" & TXTNIK.Text & "'"
            Else
                RD.Close()
                STR = "INSERT INTO TBL_KARYAWAN VALUES ('" & TXTNIK.Text & "','" & TXTNAMA.Text & "','" & _
                    TXTASAL.Text & "','" & Format(TGL.Value, "MM/dd/yyyy") & "','" & jk & "','" & _
                    TXTALAMAT.Text & "','" & TXTNO.Text & "')"
            End If
            CMD = New SqlCommand(STR, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data tersimpan...")
            TXTNIK.Text = AUTONIK()
            TAMPIL()
        End If
    End Sub

    Private Sub DGTAMPILAN_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTAMPILAN.CellClick
        TXTNIK.Text = DGTAMPILAN.Item("NIK", e.RowIndex).Value
    End Sub

    Private Sub BTNHAPUS_Click(sender As Object, e As EventArgs) Handles BTNHAPUS.Click
        If TXTNIK.Text = "" Then
            MsgBox("NIK KOSONG...")
        Else
            If MsgBox("YAKIN MENGHAPUS...???", vbYesNo) = vbYes Then
                Dim STR As String = "DELETE FROM TBL_KARYAWAN WHERE NIK='" & TXTNIK.Text & "'"
                Dim CMD As New SqlCommand(STR, CONN)
                CMD.ExecuteNonQuery()
                TAMPIL()
                TXTNIK.Text = AUTONIK()
            End If
        End If
    End Sub

    Private Sub TXTNAMA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTNAMA.KeyPress
        If e.KeyChar = Chr(13) Then
            TXTASAL.Select()
        End If
    End Sub

    Private Sub TXTASAL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTASAL.KeyPress
        If e.KeyChar = Chr(13) Then
            TGL.Select()
        End If
    End Sub

    Private Sub TGL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TGL.KeyPress
        If e.KeyChar = Chr(13) Then
            CBJK.Select()
        End If
    End Sub

    Private Sub CBJK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CBJK.KeyPress
        If e.KeyChar = Chr(13) Then
            TXTALAMAT.Select()
        End If
    End Sub

    Private Sub TXTALAMAT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTALAMAT.KeyPress
        If e.KeyChar = Chr(13) Then
            TXTNO.Select()
        End If
    End Sub

    Private Sub TXTNO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTNO.KeyPress
        If e.KeyChar = Chr(13) Then
            BTNSIMPAN.Select()
        End If
    End Sub

    Private Sub DGTAMPILAN_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGTAMPILAN.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If DGTAMPILAN.Rows.Count > 0 AndAlso e.RowIndex > -1 Then
                klik_kanan.Show(Cursor.Position.X, Cursor.Position.Y)
            End If
        End If
    End Sub

  
    Private Sub JadikanUserAdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JadikanUserAdminToolStripMenuItem.Click
        Dim fr As New FR_ADMIN
        With fr
            .LBNIK.Text = DGTAMPILAN.Item("NIK", DGTAMPILAN.CurrentRow.Index).Value
            .LBNAMA.Text = DGTAMPILAN.Item("NAMA", DGTAMPILAN.CurrentRow.Index).Value
            .ShowDialog()
        End With
    End Sub
End Class

