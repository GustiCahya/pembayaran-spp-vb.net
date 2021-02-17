Public Class RekapitulasiForm
    Private Data As DataTable
    Private tahun As String
    Private Sub RekapitulasiForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        nbTahun.Value = Now().Year
        LoadTable()
    End Sub
    Public Sub LoadTable()
        tahun = nbTahun.Value

        Data = EksekusiSQL(
           "SELECT b.nama AS Nama_Siswa,
            c.nama_kelas AS Kelas,
            SUM(IF(a.bulan_dibayar = 1, a.jumlah_bayar, 0)) AS Januari_" & tahun & ",
            SUM(IF(a.bulan_dibayar = 2, a.jumlah_bayar, 0)) AS Februari_" & tahun & ",
            SUM(IF(a.bulan_dibayar = 3, a.jumlah_bayar, 0)) AS Maret_" & tahun & ",
            SUM(IF(a.bulan_dibayar = 4, a.jumlah_bayar, 0)) AS April_" & tahun & ",
            SUM(IF(a.bulan_dibayar = 5, a.jumlah_bayar, 0)) AS Mei_" & tahun & ",
            SUM(IF(a.bulan_dibayar = 6, a.jumlah_bayar, 0)) AS Juni_" & tahun & ",
            SUM(IF(a.bulan_dibayar = 7, a.jumlah_bayar, 0)) AS Juli_" & tahun & ",
            SUM(IF(a.bulan_dibayar = 8, a.jumlah_bayar, 0)) AS Agustus_" & tahun & ",
            SUM(IF(a.bulan_dibayar = 9, a.jumlah_bayar, 0)) AS September_" & tahun & ",
            SUM(IF(a.bulan_dibayar = 10, a.jumlah_bayar, 0)) AS Oktober_" & tahun & ",
            SUM(IF(a.bulan_dibayar = 11, a.jumlah_bayar, 0)) AS November_" & tahun & ",
            SUM(IF(a.bulan_dibayar = 12, a.jumlah_bayar, 0)) AS Desember_" & tahun & ",
            SUM(a.jumlah_bayar) AS Total_Pembayaran
            FROM pembayaran a 
            LEFT JOIN siswa b ON a.nisn = b.nisn
            LEFT JOIN kelas c ON b.id_kelas = c.id_kelas
            WHERE a.tahun_dibayar='" & tahun & "'
            GROUP BY b.nisn;")
        DataGridView1.DataSource = Data

    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        LoadTable()
    End Sub

    Private Sub nbTahun_ValueChanged(sender As Object, e As EventArgs) Handles nbTahun.ValueChanged
        LoadTable()
    End Sub

    Private Sub btn_tutup_Click(sender As Object, e As EventArgs) Handles btn_tutup.Click
        Me.Close()
    End Sub

    Private Sub btn_cetak_Click(sender As Object, e As EventArgs) Handles btn_cetak.Click
        CetakRekapitulasiPembayaran(Data, tahun)
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        btnCari.PerformClick()
    End Sub

    Private Sub RekapitulasiForm_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.F5
                btn_back.PerformClick()
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub
End Class