Imports MySql.Data.MySqlClient
Module db_mysql
    Function EksekusiSQL(ByVal PerintahSQL As String)
        Dim Koneksi As New MySqlConnection(My.Settings.Alamat)
        Dim Eksekusi As New MySqlDataAdapter(PerintahSQL, Koneksi)
        Dim Tampung As New DataTable
        Eksekusi.Fill(Tampung)
        Return Tampung
    End Function
End Module
