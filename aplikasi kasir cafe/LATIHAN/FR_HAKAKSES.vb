Imports System.Data.SqlClient
Public Class fr_hakAkses
    Sub tampil_admin()
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter("select a.nik AS NIK,rtrim(b.nama) as NAMA,rtrim(a.type) as TYPE from tbl_admin as a inner join tbl_karyawan as b on a.nik=b.nik", CONN)
        Dim tbl As New DataTable
        da.Fill(tbl)
        dgAdmin.DataSource = tbl
    End Sub

    Sub tampil_akses(ByVal nik As String)
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter("select rtrim(id_menu) as ID_MENU,rtrim(nama_menu) as NAMA_MENU from tbl_menubar", CONN)
        Dim tbl As New DataTable
        da.Fill(tbl)

        Dim c_combo As New DataGridViewComboBoxColumn
        c_combo.HeaderText = "STATUS"
        c_combo.Items.AddRange(New String() {"AKTIF", "TIDAK AKTIF"})


        With dgakses
            .DataSource = Nothing
            .Columns.Clear()
            .DataSource = tbl
            .Columns.Add(c_combo)
            .Columns(0).Name = "c_idmenu"
            .Columns(1).Name = "c_namamenu"
            .Columns(2).Name = "c_status"
            For Each drow As DataGridViewRow In .Rows
                drow.Cells("c_status").Value = "TIDAK AKTIF"
            Next
            .ReadOnly = False
            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
            .AllowUserToAddRows = False
            .AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
            .EditMode = DataGridViewEditMode.EditOnEnter
        End With

        Dim str As String = "SELECT RTRIM(B.ID_MENU) AS ID_MENU,RTRIM(B.NAMA_MENU) AS NAMA_MENU,RTRIM(A.STATUS) AS STATUS FROM TBL_HAKAKSES" &
                              " AS A INNER JOIN TBL_MENUBAR AS B ON A.ID_MENU=B.ID_MENU WHERE A.NIK='" & nik & "'"
        Dim tbl_data As New DataTable
        da = New SqlDataAdapter(str, CONN)
        da.Fill(tbl_data)

        'If tbl.Rows.Count <= 0 Then Exit Sub

        Dim find_row() As DataRow
        For Each drow As DataGridViewRow In dgakses.Rows
            find_row = tbl_data.Select("ID_MENU='" & drow.Cells("c_idmenu").Value.ToString & "'")
            If find_row.Length > 0 Then
                drow.Cells("c_status").Value = RTrim(find_row(0).Item("STATUS").ToString)
            Else 'jika menu baru dan user blm setting menu
                drow.Cells("c_status").Value = "TIDAK AKTIF"
            End If
        Next
    End Sub

    Private Sub FR_HAKAKSES_Load(sender As Object, e As EventArgs) Handles Me.Load
        tampil_admin()
    End Sub

    Private Sub DGADMIN_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgAdmin.CellClick
        tampil_akses(DGADMIN.Item("NIK", e.RowIndex).Value)
    End Sub

    Private Sub BTNSIMPAN_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim cmd As SqlCommand
        cmd = New SqlCommand("delete from tbl_hakakses where rtrim(nik)='" & dgAdmin.Item("NIK", dgAdmin.CurrentRow.Index).Value & "'", CONN)
        cmd.ExecuteNonQuery()

        For Each drow As DataGridViewRow In dgakses.Rows
            cmd = New SqlCommand("insert into tbl_hakakses values ('" & dgAdmin.Item("NIK", dgAdmin.CurrentRow.Index).Value &
                                                                   "','" & drow.Cells("c_idmenu").Value.ToString & "','" &
                                                                           drow.Cells("c_status").Value.ToString & "')", CONN)
            cmd.ExecuteNonQuery()
        Next


        MsgBox("DATA TERSIMPAN...!", vbInformation)
    End Sub

End Class