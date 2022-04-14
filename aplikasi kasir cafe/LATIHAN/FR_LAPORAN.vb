Imports System.Data.SqlClient
Public Class FR_LAPORAN

    Dim tbl As New DataTable
    Dim tbl2 As New DataTable


    Sub tampil()

        Dim str As String = "select tgl,kode,(select rtrim(barang) from tbl_barang" & _
                    " where kode=tbl_transaksi.kode) as barang,jumlah,harga from tbl_transaksi where SATUAN=TBL_TRANSAKSI.SATUAN and tgl >= '" & Format(tglmulai.Value, "MM/dd/yyyy") & "' and tgl <='" & Format(tglsampai.Value, "MM/dd/yyyy") & "'"

        Dim da As New SqlDataAdapter(str, CONN)
        tbl.Clear()
        da.Fill(tbl)
        dgtampilan.DataSource = tbl
        dgtampilan.Columns("harga").DefaultCellStyle.Format = "N0"
        dgtampilan.Columns("harga").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub


    Private Sub btntampil_Click(sender As Object, e As EventArgs) Handles btntampil.Click
            tampil()
    End Sub

    Private Sub btncetak_Click(sender As Object, e As EventArgs) Handles btncetak.Click
        If dgtampilan.Rows.Count > 0 Then
            Dim rpt As New RPT_MASUK
            With rpt
                .SetDataSource(tbl)
                .SetParameterValue("tgl_mulai", tglmulai.Value)
                .SetParameterValue("tgl_sampai", tglsampai.Value)
            End With

            Dim FR As New FR_PREVIEW
            With FR
                .CRV.ReportSource = rpt
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub TAMPILNAMA_Click(sender As Object, e As EventArgs) Handles TAMPILNAMA.Click
        Dim STR As String = "SELECT TBL_ADMIN.USERNAME AS NAMA, TBL_TRANSAKSI.TGL, TBL_TRANSAKSI.KODE, TBL_BARANG.BARANG, TBL_TRANSAKSI.JUMLAH, TBL_TRANSAKSI.HARGA FROM TBL_ADMIN INNER JOIN TBL_TRANSAKSI ON TBL_ADMIN.NIK = TBL_TRANSAKSI.KASIR INNER JOIN TBL_BARANG ON TBL_TRANSAKSI.KODE = TBL_BARANG.KODE WHERE USERNAME LIKE '%" & TXTNAMA.Text & "%'"
        Dim DA As New SqlDataAdapter(STR, CONN)
        tbl2.Clear()
        DA.Fill(tbl2)
        dgtampilan.DataSource = tbl2
    End Sub
End Class