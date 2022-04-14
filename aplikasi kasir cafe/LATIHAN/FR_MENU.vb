Imports System.Data.SqlClient
Public Class FR_MENU

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim FR As New FR_LOGIN
        FR.Show()
        Me.Close()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Sub BUKA_FORM(ByVal FR As Form)
        For Each F As Form In Me.MdiChildren
            If F.Name = FR.Name Then
                MsgBox("FORM SUDAH TERBUKA...")
                Exit Sub
            End If
        Next
        FR.MdiParent = Me
        FR.Show()
    End Sub

    Private Sub DataKaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKaryawanToolStripMenuItem.Click
        BUKA_FORM(FR_KARYAWAN)
    End Sub

    Private Sub DataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBarangToolStripMenuItem.Click
        BUKA_FORM(FR_BARANG)
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        BUKA_FORM(FR_LAPORAN)
    End Sub

    Private Sub FR_MENU_Load(sender As Object, e As EventArgs) Handles Me.Load
        TXTTGL.Text = FormatDateTime(Date.Now, DateFormat.LongDate)
        TXTJAM.Text = TimeOfDay
        PEWAKTU.Enabled = True

        data_menu()

        If nikAdmin = "SuperUser" Then
            Exit Sub
        End If

        Dim cmd As New SqlCommand("select type from tbl_admin where rtrim(nik)='" & nikAdmin & "'", CONN)
        Dim rd As SqlDataReader
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            Dim adm As String = rd.Item("type").ToString.Trim
            rd.Close()

            If adm = "ADMIN" Then
                Exit Sub
            End If
        End If
        setAkses(nikAdmin)
    End Sub

    Private Sub PEWAKTU_Tick(sender As Object, e As EventArgs) Handles PEWAKTU.Tick
        TXTTGL.Text = FormatDateTime(Date.Now, DateFormat.LongDate)
        TXTJAM.Text = TimeOfDay
    End Sub

    Private Sub PengaturanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengaturanToolStripMenuItem.Click
        BUKA_FORM(FR_PENGATURAN)
    End Sub

    Sub data_menu()
        Dim cmd As SqlCommand
        cmd = New SqlCommand("delete from tbl_menubar", CONN)
        cmd.ExecuteNonQuery()

        For Each menu1 As ToolStripMenuItem In MenuStrip1.Items
            cmd = New SqlCommand("insert into tbl_menubar values ('" & menu1.Name & "','" & menu1.Text & "')", CONN)
            cmd.ExecuteNonQuery()
            For Each menu2 In menu1.DropDownItems
                If TypeOf menu2 Is ToolStripSeparator Then Continue For
                cmd = New SqlCommand("insert into tbl_menubar values ('" & menu2.Name & "','" & menu2.Text & "')", CONN)
                cmd.ExecuteNonQuery()
                For Each menu3 In menu2.DropDownItems
                    If TypeOf menu3 Is ToolStripSeparator Then Continue For
                    cmd = New SqlCommand("insert into tbl_menubar values ('" & menu3.Name & "','" & menu3.Text & "')", CONN)
                    cmd.ExecuteNonQuery()
                    For Each menu4 In menu3.DropDownItems
                        If TypeOf menu4 Is ToolStripSeparator Then Continue For
                        cmd = New SqlCommand("insert into tbl_menubar values ('" & menu4.Name & "','" & menu4.Text & "')", CONN)
                        cmd.ExecuteNonQuery()
                        For Each menu5 In menu4.DropDownItems
                            If TypeOf menu5 Is ToolStripSeparator Then Continue For
                            cmd = New SqlCommand("insert into tbl_menubar values ('" & menu5.Name & "','" & menu5.Text & "')", CONN)
                            cmd.ExecuteNonQuery()
                        Next
                    Next
                Next
            Next
        Next

        For Each menu As ToolStripItem In ToolStrip1.Items
            If TypeOf menu Is ToolStripSeparator Then Continue For
            cmd = New SqlCommand("insert into tbl_menubar values ('" & menu.Name & "','" & menu.Text & "')", CONN)
            cmd.ExecuteNonQuery()
        Next

        cmd = New SqlCommand("delete from tbl_hakakses where id_menu not in (select id_menu from tbl_menubar)", CONN)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub HakAksesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HakAksesToolStripMenuItem.Click
        BUKA_FORM(FR_HAKAKSES)
    End Sub

    Sub setAkses(ByVal nik As String)
        'jika ada menu baru dengan default Disabled
        Dim tbl_temp As New DataTable
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter("select rtrim(nik) as  nik from tbl_admin", CONN)
        da.Fill(tbl_temp)

        For N = 0 To tbl_temp.Rows.Count - 1
            Dim ADM As String = tbl_temp.Rows(N).Item("nik").ToString()
            Dim cmd As SqlCommand
            cmd = New SqlCommand("insert into tbl_hakakses select '" & ADM & "' as NIK,ID_MENU,'TIDAK AKTIF' AS STATUS from tbl_menubar where ID_MENU not in (select ID_MENU from tbl_hakakses where rtrim(nik)='" & ADM & "')", CONN)
            cmd.ExecuteNonQuery()
        Next

        Dim tbl As New DataTable
        da = New SqlDataAdapter("select rtrim(id_menu) as id_menu,rtrim(status) as status from tbl_hakakses where rtrim(nik)='" & nik & "'", CONN)
        da.Fill(tbl)

        If tbl.Rows.Count <= 0 Then
            MenuStrip1.Visible = False
            ToolStrip1.Visible = False
            Exit Sub
        End If

        'set untuk menu strip
        Dim findRow() As DataRow = Nothing
        For Each menu1 As ToolStripMenuItem In MenuStrip1.Items
            findRow = tbl.Select("id_menu='" & menu1.Name & "'")
            menu1.Visible = IIf(findRow(0).Item("status").ToString = "AKTIF", True, False)
            For Each menu2 In menu1.DropDownItems
                If TypeOf menu2 Is ToolStripSeparator Then Continue For
                findRow = tbl.Select("id_menu='" & menu2.Name & "'")
                menu2.Visible = IIf(findRow(0).Item("status").ToString = "AKTIF", True, False)
                For Each menu3 In menu2.DropDownItems
                    If TypeOf menu3 Is ToolStripSeparator Then Continue For
                    findRow = tbl.Select("id_menu='" & menu3.Name & "'")
                    menu3.Visible = IIf(findRow(0).Item("status").ToString = "AKTIF", True, False)
                    For Each menu4 In menu2.DropDownItems
                        If TypeOf menu4 Is ToolStripSeparator Then Continue For
                        findRow = tbl.Select("id_menu='" & menu4.Name & "'")
                        menu4.Visible = IIf(findRow(0).Item("status").ToString = "AKTIF", True, False)
                        For Each menu5 In menu2.DropDownItems
                            If TypeOf menu5 Is ToolStripSeparator Then Continue For
                            findRow = tbl.Select("id_menu='" & menu5.Name & "'")
                            menu5.Visible = IIf(findRow(0).Item("status").ToString = "AKTIF", True, False)
                        Next
                    Next
                Next
            Next
        Next

        'set untuk toolstrip
        For Each MenuItem As ToolStripItem In ToolStrip1.Items
            findRow = tbl.Select("id_menu='" & MenuItem.Name & "'")
            If findRow.Length > 0 Then MenuItem.Visible = IIf(findRow(0).Item("status").ToString = "AKTIF", True, False)
        Next


    End Sub

    Private Sub DataTransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataTransaksiToolStripMenuItem.Click
        Dim tr As New Fr_trAdmin
        tr.ShowDialog()
    End Sub

    Private Sub KasirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KasirToolStripMenuItem.Click
        'BUKA_FORM(FR_KELUAR)
        Dim fr As New FR_KELUAR
        fr.Show()
        Me.Hide()
    End Sub
End Class
