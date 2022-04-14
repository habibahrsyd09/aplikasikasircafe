Imports System.Data.SqlClient
Public Class FR_KELUAR


    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub TXTKODE_TextChanged(sender As Object, e As EventArgs) Handles TXTKODE.TextChanged
        Dim STR As String = "SELECT KODE,BARANG,SATUAN,HARGA_SATUAN FROM TBL_BARANG WHERE RTRIM(KODE)='" & TXTKODE.Text & "'"
        Dim CMD As New SqlCommand(STR, CONN)
        Dim RD As SqlDataReader
        RD = CMD.ExecuteReader
        If RD.HasRows Then
            RD.Read()
            TXTBARANG.Text = RD.Item("BARANG").ToString.Trim
            TXTSATUAN.Text = RD.Item("SATUAN").ToString.Trim
            TXTHARGA.Text = CInt(RD.Item("HARGA_SATUAN"))
            RD.Close()
            masuk_data()
            TXTKODE.Clear()
        Else
            RD.Close()
        End If
    End Sub

    Sub masuk_data()
        Dim QTY As Integer = 0
        Dim ADA_DATA As Boolean = False
        Dim BARIS_DATA As Integer = 0

        For N = 0 To dgtampilan.Rows.Count - 1
            Dim KODE As String = dgtampilan.Item("KODE", N).Value
            If KODE = TXTKODE.Text Then
                ADA_DATA = True
                BARIS_DATA = N
                Exit For
            End If
        Next

        If ADA_DATA = True Then
            dgtampilan.Rows(BARIS_DATA).Cells("QTY").Value = dgtampilan.Rows(BARIS_DATA).Cells("QTY").Value + 1
            dgtampilan.Rows(dgtampilan.Rows.Count - 1).Cells("TOTAL").Value =
                dgtampilan.Rows(BARIS_DATA).Cells("QTY").Value * dgtampilan.Rows(BARIS_DATA).Cells("HARGA").Value
        Else
            dgtampilan.Rows.Add()
            dgtampilan.Rows(dgtampilan.Rows.Count - 1).Cells("KODE").Value = TXTKODE.Text
            dgtampilan.Rows(dgtampilan.Rows.Count - 1).Cells("BARANG").Value = TXTBARANG.Text
            dgtampilan.Rows(dgtampilan.Rows.Count - 1).Cells("SATUAN").Value = TXTSATUAN.Text
            dgtampilan.Rows(dgtampilan.Rows.Count - 1).Cells("HARGA").Value = TXTHARGA.Text
            dgtampilan.Rows(dgtampilan.Rows.Count - 1).Cells("QTY").Value = "1"
            dgtampilan.Rows(dgtampilan.Rows.Count - 1).Cells("TOTAL").Value = TXTHARGA.Text

        End If

        total_harga()
    End Sub

    Private Sub dgtampilan_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgtampilan.CellEndEdit
        If e.ColumnIndex = 4 Then
            Dim QTY As String = ""
            QTY = dgtampilan.Item("QTY", e.RowIndex).Value
            If IsNumeric(QTY) Then
                dgtampilan.Item("TOTAL", e.RowIndex).Value = QTY * dgtampilan.Item("HARGA", e.RowIndex).Value
                total_harga()
            Else
                MsgBox("NILAI TIDAK VALID...")
                dgtampilan.Item("QTY", e.RowIndex).Value = QTY_LAMA
            End If
        End If
    End Sub

    Dim QTY_LAMA As Integer = 0
    Private Sub dgtampilan_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgtampilan.CellBeginEdit
        If e.ColumnIndex = 4 Then
            QTY_LAMA = dgtampilan.Item("QTY", e.RowIndex).Value
        End If
    End Sub

    Sub total_harga()
        Dim totharga As Integer = 0
        For n = 0 To dgtampilan.Rows.Count - 1
            totharga = totharga + dgtampilan.Item("TOTAL", n).Value
        Next
        lbtotal.Text = FormatCurrency(totharga, 0)
    End Sub

    Private Sub BTNCARI_Click(sender As Object, e As EventArgs) Handles BTNCARI.Click
        buka_cari()
    End Sub

    Private Sub TXTCARI_TextChanged(sender As Object, e As EventArgs) Handles TXTCARI.TextChanged
        Dim STR As String = "select TOP 10 rtrim(kode) as KODE,rtrim(barang) as BARANG,rtrim(satuan)" &
            " as SATUAN,HARGA_SATUAN from tbl_barang where barang like '%" & TXTCARI.Text & "%'"
        Dim da As New SqlDataAdapter(STR, CONN)
        Dim tbl As New DataTable
        da.Fill(tbl)
        DGCARI.DataSource = tbl
    End Sub

    Private Sub DGCARI_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCARI.CellDoubleClick
        TXTKODE.Text = DGCARI.Item("KODE", e.RowIndex).Value
        PNCARI.Visible = False

    End Sub

    Private Sub BTNKELUAR_Click(sender As Object, e As EventArgs) Handles BTNKELUAR.Click
        PNCARI.Visible = False
    End Sub

    Private Sub btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        Dim fr As New FR_MENU
        fr.Show()
        Me.Close()

    End Sub


    Private Sub FR_KELUAR_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                If PNCARI.Visible = False Then
                    buka_cari()
                Else
                    TUTUP_CARI()

                End If
                buka_cari()
            Case Keys.F2
                If PNBAYAR.Visible = False Then
                    buka_bayar()
                Else
                    TUTUP_BAYAR()
                End If
        End Select
    End Sub

    Sub buka_cari()
        PNBAYAR.Visible = False
        PNCARI.Visible = True
        TXTCARI.Clear()
        TXTCARI.Select()
    End Sub

    Sub buka_bayar()
        If CInt(lbtotal.Text) <= 0 Then Exit Sub
        dgtampilan.Enabled = False
        PNCARI.Visible = False
        PNBAYAR.Visible = True
        txtbayar.Text = CInt(lbtotal.Text)
        txttunai.Clear()
        txttunai.Select()
    End Sub
    Sub TUTUP_CARI()
        PNCARI.Visible = False
        TXTKODE.Select()
    End Sub

    Sub TUTUP_BAYAR()
        PNBAYAR.Visible = False
        dgtampilan.Enabled = True
        TXTKODE.Select()

    End Sub

    Private Sub btntutup_Click(sender As Object, e As EventArgs) Handles btntutup.Click
        TUTUP_BAYAR()
    End Sub

    Private Sub btnbayar_Click(sender As Object, e As EventArgs) Handles btnbayar.Click
        buka_bayar()
    End Sub

    Private Sub txttunai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttunai.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(13) Then
            If CInt(txtkembalian.Text) >= 0 Then
                masuk_database()
            Else
                MsgBox("PEMBAYARAN TIDAK MENCUKUPI...")
            End If
        End If
    End Sub

    Private Sub txttunai_TextChanged(sender As Object, e As EventArgs) Handles txttunai.TextChanged
        If txttunai.Text = "" Then Exit Sub
        txtkembalian.Text = txttunai.Text - txtbayar.Text
    End Sub

    Private Sub dgtampilan_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgtampilan.CellMouseClick
        If dgtampilan.Rows.Count >= 0 AndAlso e.RowIndex > -1 Then
            KLIK_KANAN.Show(Cursor.Position.X, Cursor.Position.Y)

        End If
    End Sub

    Private Sub HAPUSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HAPUSToolStripMenuItem.Click
        For Each ecell As DataGridViewCell In dgtampilan.SelectedCells
            dgtampilan.Rows.RemoveAt(ecell.RowIndex)
        Next
    End Sub

    Sub masuk_database()
        If dgtampilan.Rows.Count <= 0 Then Exit Sub
        For Each erow As DataGridViewRow In dgtampilan.Rows
            Dim kode As String = erow.Cells("KODE").Value
            Dim satuan As String = erow.Cells("SATUAN").Value
            Dim jumlah As Integer = erow.Cells("QTY").Value
            Dim harga As Integer = erow.Cells("TOTAL").Value

            Dim str As String = "insert into tbl_transaksi (kode,jumlah,satuan,harga,tgl,kasir) VALUES" & _
                "('" & kode & "','" & jumlah & "','" & satuan & "','" & harga & "','" & Format(Date.Now, "MM/dd/yyyy") & "','" & nikAdmin & "')"

            Dim cmd As New SqlCommand(str, CONN)
            cmd.ExecuteNonQuery()

        Next

        print_nota()
        TUTUP_BAYAR()
        dgtampilan.Rows.Clear()
        total_harga()
        TXTKODE.Select()
    End Sub

    Private Sub nota_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles nota.PrintPage
        Dim tinggi As Integer = 10
        e.Graphics.DrawString(nama_cafe, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString(no_cafe, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString(alamat_cafe, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 20
        e.Graphics.DrawString("------------------------------------", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Barang" & vbTab & vbTab & "Qty" & vbTab & "Total", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("------------------------------------", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        For Each erow As DataGridViewRow In dgtampilan.Rows
            tinggi = tinggi + 10
            e.Graphics.DrawString(erow.Cells("BARANG").Value, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

            tinggi = tinggi + 10
            e.Graphics.DrawString(vbTab & vbTab & erow.Cells("QTY").Value & vbTab & erow.Cells("TOTAL").Value, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)
        Next

        tinggi = tinggi + 10
        e.Graphics.DrawString("------------------------------------", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Total" & vbTab & vbTab & ": " & txtbayar.Text, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Tunai" & vbTab & vbTab & ": " & txttunai.Text, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Kembali" & vbTab & ": " & txtkembalian.Text, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("------------------------------------", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Terimakasih!!", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)
    End Sub

    Sub print_nota()
        nota.PrinterSettings.PrinterName = printer_nota
        nota.Print()
    End Sub

    
    Private Sub FR_KELUAR_Load(sender As Object, e As EventArgs) Handles Me.Load
        ambil_data()
    End Sub
End Class