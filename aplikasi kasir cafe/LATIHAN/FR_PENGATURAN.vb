
Imports System.Drawing.Printing
Public Class FR_PENGATURAN

    Sub isi_list_printer()
        cbprinter.Items.Clear()
        For Each nama_printer As String In PrinterSettings.InstalledPrinters
            cbprinter.Items.Add(nama_printer)
        Next
    End Sub


    Private Sub FR_PENGATURAN_Load(sender As Object, e As EventArgs) Handles Me.Load
        isi_list_printer()
        ambil_data()
        txtcafe.Text = nama_cafe
        txtalamat.Text = alamat_cafe
        txtno.Text = no_cafe
        cbprinter.Text = printer_nota
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        masuk_data(txtcafe.Text, txtalamat.Text, txtno.Text, cbprinter.Text)
        MsgBox("Data Sudah Tersimpan<3")
    End Sub
End Class