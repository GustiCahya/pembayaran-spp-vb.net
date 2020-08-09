Imports MySql.Data.MySqlClient
Module db_mysql
    Public cn As MySqlConnection
    Public cm As MySqlCommand
    Public dr As MySqlDataReader
    Public ds As DataSet
    Public da As MySqlDataAdapter
    Public dt As DataTable

    Sub Connection()
        cn = New MySqlConnection
        With cn
            .ConnectionString = "server = localhost; user id=root; password = ; database = db_spp"
        End With
    End Sub

End Module
