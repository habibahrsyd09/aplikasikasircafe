Imports System.Data.SqlClient
Public Class Fr_trAdmin
    Sub tampil()
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter("select a.ID,a.TGL,a.KODE,rtrim(b.barang) as BARANG,a.JUMLAH,a.HARGA from tbl_transaksi as a inner join tbl_barang as b on a.kode=b.kode where kasir ='" & TXTNIK.Text & "' and tgl='" & Format(DTTGL.Value, "MM-dd-yyyy") & "'", CONN)
        Dim tbl As New DataTable
        da.Fill(tbl)
        dgtampilan.DataSource = tbl
        hitung_total()

    End Sub

    Private Sub TXTNIK_TextChanged(sender As Object, e As EventArgs) Handles TXTNIK.TextChanged
        Dim cmd As New SqlCommand("select rtrim(nama) as nama from tbl_karyawan where rtrim(nik)='" & TXTNIK.Text & "'", CONN)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            TXTNAMA.Text = rd.Item("nama").ToString
            rd.Close()
        Else
            rd.Close()
            TXTNAMA.Clear()
        End If
        tampil()
    End Sub

    Private Sub Fr_trAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXTNIK.Text = nikAdmin
    End Sub

    Sub hitung_total()
        Dim jlh As Long = 0
        For n = 0 To dgtampilan.Rows.Count - 1
            jlh = jlh + dgtampilan.Item("HARGA", n).Value

        Next
        TXTJUMLAH.Text = jlh

    End Sub

    Private Sub DTTGL_ValueChanged(sender As Object, e As EventArgs) Handles DTTGL.ValueChanged
        tampil()
    End Sub
End Class