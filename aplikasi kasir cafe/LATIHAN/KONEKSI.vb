Imports System.Data.SqlClient
Module KONEKSI

    Public CONN As SqlConnection
    Public nama_cafe As String
    Public alamat_cafe As String
    Public no_cafe As String
    Public printer_nota As String
    Public nikAdmin As String

    Public Sub masuk_data(ByVal cafe As String, ByVal alamat As String, ByVal no As String, ByVal prints As String)
        Call SaveSetting("cafe", "setting", "nama_cafe", cafe)
        Call SaveSetting("cafe", "setting", "alamat_cafe", alamat)
        Call SaveSetting("cafe", "setting", "no_cafe", no)
        Call SaveSetting("cafe", "setting", "print_nota", prints)
        ambil_data()
    End Sub

    Public Sub ambil_data()
        nama_cafe = GetSetting("cafe", "setting", "nama_cafe", "")
        alamat_cafe = GetSetting("cafe", "setting", "alamat_cafe", "")
        no_cafe = GetSetting("cafe", "setting", "no_cafe", "")
        printer_nota = GetSetting("cafe", "setting", "print_nota", "")
    End Sub

    Public Sub KONEKAN()
        'SERVER=NAMA SERVER;USER ID=USERID;PASWORD=PASWORD;DATABASE=DATABASE;'
        Dim STR As String = "SERVER=" & My.Settings.SERVER & ";USER ID=" & My.Settings.USER & ";PASSWORD=" & My.Settings.PASSWORD & ";DATABASE=" & My.Settings.DATABASE & ";"
        Try
            CONN = New SqlConnection(STR)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MsgBox("KONEKSI GAGAL")
            With My.Settings
                .SERVER = ""
                .USER = ""
                .PASSWORD = ""
                .DATABASE = ""
                .Save()
            End With
            End
        End Try
    End Sub


End Module
