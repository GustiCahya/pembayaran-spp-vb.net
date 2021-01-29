Imports MySql.Data.MySqlClient
Public Class RiwayatForm
    Private currentId As String
    Private Sub RiwayatForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MenuUtama.role <> "admin" Then
            DataGridView1.Size = New System.Drawing.Size(584, 275)
            DataGridView1.Location = New System.Drawing.Point(0, 86)
            btn_laporan.Visible = False
        End If
        btn_delete.Visible = False
        LoadTable()
    End Sub
    Private Sub LoadTable()
        Select Case MenuUtama.role
            Case "petugas"
                cn.Open()
                da = New MySqlDataAdapter(
                    "SELECT pembayaran.*, petugas.nama_petugas, siswa.nama FROM pembayaran 
                    INNER JOIN petugas ON pembayaran.id_petugas=petugas.id_petugas 
                    INNER JOIN siswa ON pembayaran.nisn = siswa.nisn 
                    WHERE pembayaran.id_petugas='" & MenuUtama.currentId & "' ", cn)
                CustomizeTable()
                cn.Close()
            Case "siswa"
                cn.Open()
                da = New MySqlDataAdapter(
                    "SELECT pembayaran.*, petugas.nama_petugas, siswa.nama 
                    FROM pembayaran INNER JOIN petugas ON pembayaran.id_petugas=petugas.id_petugas 
                    INNER JOIN siswa ON pembayaran.nisn = siswa.nisn 
                    WHERE pembayaran.nisn='" & MenuUtama.currentId & "'", cn)
                CustomizeTable()
                cn.Close()
            Case "admin"
                cn.Open()
                da = New MySqlDataAdapter(
                    "SELECT pembayaran.*, petugas.nama_petugas, siswa.nama 
                    FROM pembayaran INNER JOIN petugas ON pembayaran.id_petugas=petugas.id_petugas 
                    INNER JOIN siswa ON pembayaran.nisn = siswa.nisn", cn)
                CustomizeTable()
                cn.Close()
        End Select
    End Sub
    Private Sub CustomizeTable()
        Dim daftarBulan As String() = {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"}
        ds = New DataSet()
        da.Fill(ds, "pembayaran")
        DataGridView1.DataSource = ds.Tables("pembayaran")
        DataGridView1.Columns(6).Visible = False
        DataGridView1.Columns(8).HeaderText = "nama_petugas"
        DataGridView1.Columns(8).DisplayIndex = 2
        DataGridView1.Columns(9).HeaderText = "nama_siswa"
        DataGridView1.Columns(9).DisplayIndex = 4
        Dim indexBulan As Integer
        Dim tanggal As Date
        For i = 0 To DataGridView1.Rows.Count - 1
            indexBulan = DataGridView1.Rows(i).Cells(4).Value - 1
            DataGridView1.Rows(i).Cells(4).Value = daftarBulan(indexBulan)
            tanggal = DataGridView1.Rows(i).Cells(3).Value
            DataGridView1.Rows(i).Cells(3).Value = tanggal
        Next
    End Sub
    Private Sub btn_laporan_Click(sender As Object, e As EventArgs) Handles btn_laporan.Click
        Laporan.Show()
    End Sub
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Select Case MsgBox("Yakin ID Pembayaran " & currentId & " mau dihapus ?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                Try
                    cn.Open()
                    cm = New MySqlCommand("DELETE FROM pembayaran WHERE id_pembayaran = @id_pembayaran", cn)
                    cm.Parameters.AddWithValue("@id_pembayaran", currentId)
                    cm.ExecuteNonQuery()
                    cn.Close()
                    btn_delete.Visible = False
                    LoadTable()
                Catch ex As Exception
                    cn.Close()
                    MsgBox(ex.ToString(), vbCritical)
                End Try
        End Select
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        btn_delete.Visible = True
        currentId = DataGridView1.Item(0, e.RowIndex).Value
        If MenuUtama.role <> "admin" Then
            btn_delete.Location = New System.Drawing.Point(487, 51)
        End If
    End Sub
End Class