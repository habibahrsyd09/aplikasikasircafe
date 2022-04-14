Imports System.Data.SqlClient
Public Class FR_BARANG

    Private Sub FR_BARANG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TAMPILAN()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TXTCARI.TextChanged
        TAMPILAN()
    End Sub

    Private Sub TXTHARGA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTHARGA.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(13) Then
            BTNSIMPAN.Select()
        End If
    End Sub

    Sub TAMPILAN()
        Dim STR As String = "SELECT RTRIM(KODE) AS KODE,RTRIM(BARANG) AS MENU," & _
            " RTRIM(SATUAN) AS SATUAN,HARGA_SATUAN FROM TBL_BARANG WHERE BARANG LIKE '%" & TXTCARI.Text & "%'"
        Dim DA As SqlDataAdapter
        DA = New SqlDataAdapter(STR, CONN)
        Dim TBL As New DataTable
        DA.Fill(TBL)
        DGTAMPILAN.DataSource = TBL
        DGTAMPILAN.Columns("HARGA_SATUAN").DefaultCellStyle.Format = "N0"
    End Sub

    Private Sub TXTKODE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTKODE.KeyPress
        If e.KeyChar = Chr(13) Then
            TXTBARANG.Select()
        End If
    End Sub

    Private Sub TXTBARANG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTBARANG.KeyPress
        If e.KeyChar = Chr(13) Then
            CBSATUAN.Select()
        End If
    End Sub

    Private Sub CBSATUAN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CBSATUAN.KeyPress
        If e.KeyChar = Chr(13) Then
            TXTHARGA.Select()
        End If
    End Sub

    Private Sub TXTKODE_TextChanged(sender As Object, e As EventArgs) Handles TXTKODE.TextChanged
        Dim STR As String = "SELECT * FROM TBL_BARANG WHERE RTRIM(KODE)='" & TXTKODE.Text & "'"
        Dim CMD As New SqlCommand(STR, CONN)
        Dim RD As SqlDataReader
        RD = CMD.ExecuteReader
        If RD.HasRows Then
            RD.Read()
            TXTBARANG.Text = RD.Item("BARANG").ToString.Trim
            CBSATUAN.Text = RD.Item("SATUAN").ToString.Trim
            TXTHARGA.Text = CInt(RD.Item("HARGA_SATUAN"))
            RD.Close()
        Else
            RD.Close()
            TXTBARANG.Clear()
            TXTHARGA.Clear()
        End If
        RD.Close()
    End Sub

    Private Sub BTNSIMPAN_Click(sender As Object, e As EventArgs) Handles BTNSIMPAN.Click
        If TXTKODE.Text = "" Or TXTBARANG.Text = "" Then
            MsgBox("DATA TIDAK LENGKAP...")
        Else
            Dim STR As String
            STR = "SELECT * FROM TBL_BARANG WHERE RTRIM(KODE)='" & TXTKODE.Text & "'"
            Dim CMD As SqlCommand
            CMD = New SqlCommand(STR, CONN)
            Dim RD As SqlDataReader
            RD = CMD.ExecuteReader
            If RD.HasRows Then
                RD.Close()
                STR = "UPDATE TBL_BARANG SET BARANG='" & TXTBARANG.Text & "',SATUAN='" & _
                    CBSATUAN.Text & "',HARGA_SATUAN='" & TXTHARGA.Text & _
                    "' WHERE RTRIM(KODE)='" & TXTKODE.Text & "'"
            Else
                RD.Close()
                STR = "INSERT INTO TBL_BARANG VALUES ('" & TXTKODE.Text & "','" & _
                    TXTBARANG.Text & "','" & CBSATUAN.Text & "','" & TXTHARGA.Text & "')"
            End If
            RD.Close()
            CMD = New SqlCommand(STR, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("DATA TERSIMPAN..")
            TAMPILAN()
        End If
    End Sub

    Private Sub HAPUSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HAPUSToolStripMenuItem.Click
        Dim STR As String = "DELETE FROM TBL_BARANG WHERE RTRIM(KODE)='" &
            DGTAMPILAN.Item("KODE", DGTAMPILAN.CurrentRow.Index).Value & "'"
        If MsgBox("YAKIN MENGHAPUS..???", vbYesNo) = vbYes Then
            Dim CMD As New SqlCommand(STR, CONN)
            CMD.ExecuteNonQuery()
            TAMPILAN()
        End If
    End Sub

    Private Sub DGTAMPILAN_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTAMPILAN.CellClick
        On Error Resume Next
        TXTKODE.Text = DGTAMPILAN.Item("KODE", e.RowIndex).Value
    End Sub

  
    Private Sub DGTAMPILAN_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGTAMPILAN.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If DGTAMPILAN.Rows.Count > 0 AndAlso e.RowIndex > -1 Then
                klik_kanan.Show(Cursor.Position.X, Cursor.Position.Y)
            End If
        End If
    End Sub
End Class