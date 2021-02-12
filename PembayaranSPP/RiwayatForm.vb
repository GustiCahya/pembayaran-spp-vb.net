Public Class RiwayatForm
    Private currentId As String
    Private Sub RiwayatForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        LoadTable()
    End Sub
    Public Sub LoadTable()
        Dim date1 As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim date2 As String = DateTimePicker2.Value.ToString("yyyy-MM-dd")
        Select Case MenuUtama.role
            Case "petugas"

                Dim Data = EksekusiSQL(
                    "SELECT a.id_pembayaran, a.id_petugas, b.nama_petugas, 
                    a.nisn, c.nama, d.nama_kelas, a.bulan_dibayar, 
                    a.tahun_dibayar, a.jumlah_bayar, a.tgl_bayar FROM pembayaran a 
                    LEFT JOIN petugas b ON a.id_petugas=b.id_petugas 
                    LEFT JOIN siswa c ON a.nisn = c.nisn 
                    LEFT JOIN kelas d ON c.id_kelas = d.id_kelas
                    WHERE a.tgl_bayar BETWEEN '" & date1 & "' and '" & date2 & "' and
                    a.id_petugas='" & MenuUtama.currentId & "' ")
                CustomizeTable(Data)

            Case "siswa"

                Dim Data = EksekusiSQL(
                    "SELECT a.id_pembayaran, a.id_petugas, b.nama_petugas, 
                    a.nisn, c.nama, d.nama_kelas, a.bulan_dibayar, 
                    a.tahun_dibayar, a.jumlah_bayar, a.tgl_bayar FROM pembayaran a 
                    LEFT JOIN petugas b ON a.id_petugas=b.id_petugas 
                    LEFT JOIN siswa c ON a.nisn = c.nisn 
                    LEFT JOIN kelas d ON c.id_kelas = d.id_kelas
                    WHERE a.tgl_bayar BETWEEN '" & date1 & "' and '" & date2 & "' and
                    a.nisn='" & MenuUtama.currentId & "'")
                CustomizeTable(Data)

            Case "admin"

                Dim Data = EksekusiSQL(
                    "SELECT a.id_pembayaran, a.id_petugas, b.nama_petugas, 
                    a.nisn, c.nama, d.nama_kelas, a.bulan_dibayar, 
                    a.tahun_dibayar, a.jumlah_bayar, a.tgl_bayar FROM pembayaran a 
                    LEFT JOIN petugas b ON a.id_petugas=b.id_petugas 
                    LEFT JOIN siswa c ON a.nisn = c.nisn 
                    LEFT JOIN kelas d ON c.id_kelas = d.id_kelas
                    WHERE a.tgl_bayar BETWEEN '" & date1 & "' and '" & date2 & "' ")
                CustomizeTable(Data)

        End Select
    End Sub
    Private Sub CustomizeTable(ByVal Data As DataTable)
        Dim daftarBulan As String() = {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"}
        DataGridView1.DataSource = Data
        With DataGridView1
            .Columns("id_pembayaran").HeaderText = "ID Pembayaran"
            .Columns("id_petugas").HeaderText = "ID Petugas"
            .Columns("nama_petugas").HeaderText = "Petugas"
            .Columns("nisn").HeaderText = "NISN"
            .Columns("nama").HeaderText = "Siswa"
            .Columns("nama_kelas").HeaderText = "Kelas"
            .Columns("bulan_dibayar").HeaderText = "Bulan"
            .Columns("tahun_dibayar").HeaderText = "Tahun"
            .Columns("jumlah_bayar").HeaderText = "Jumlah Bayar"
            .Columns("tgl_bayar").HeaderText = "Tanggal Bayar"
        End With
        Dim indexBulan As Integer
        Dim tanggal As Date
        For i = 0 To DataGridView1.Rows.Count - 1
            indexBulan = DataGridView1.Rows(i).Cells("bulan_dibayar").Value - 1
            DataGridView1.Rows(i).Cells("bulan_dibayar").Value = daftarBulan(indexBulan)
            tanggal = DataGridView1.Rows(i).Cells("tgl_bayar").Value
            DataGridView1.Rows(i).Cells("tgl_bayar").Value = tanggal
        Next
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        currentId = DataGridView1.Item(0, e.RowIndex).Value
    End Sub

    Private Sub btn_tutup_Click(sender As Object, e As EventArgs) Handles btn_tutup.Click
        Me.Close()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        btnCari.PerformClick()
    End Sub

    Private Sub RiwayatForm_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.F5
                btn_back.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        LoadTable()
    End Sub
End Class