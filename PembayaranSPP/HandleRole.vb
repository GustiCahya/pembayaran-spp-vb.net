Module HandleRole

    Public Sub OnOffMenu(
        ByVal File As Boolean,
        ByVal GantiPassword As Boolean,
        ByVal Logout As Boolean,
        ByVal Keluar As Boolean,
        ByVal Master As Boolean,
        ByVal Petugas As Boolean,
        ByVal Kelas As Boolean,
        ByVal SPP As Boolean,
        ByVal Siswa As Boolean,
        ByVal Transaksi As Boolean,
        ByVal Pembayaran As Boolean,
        ByVal Laporan As Boolean,
        ByVal Histori As Boolean,
        ByVal Rekapitulasi As Boolean,
        ByVal Pengaturan As Boolean,
        ByVal Server As Boolean,
        ByVal Sistem As Boolean,
        ByVal Tentang As Boolean
    )
        MenuUtama.FileToolStripMenuItem.Visible = File
        MenuUtama.GantiPasswordToolStripMenuItem.Visible = GantiPassword
        MenuUtama.LogoutToolStripMenuItem.Visible = Logout
        MenuUtama.KeluarToolStripMenuItem.Visible = Keluar

        MenuUtama.MasterToolStripMenuItem.Visible = Master
        MenuUtama.PetugasToolStripMenuItem.Visible = Petugas
        MenuUtama.KelasToolStripMenuItem.Visible = Kelas
        MenuUtama.SPPToolStripMenuItem.Visible = SPP
        MenuUtama.SiswaToolStripMenuItem.Visible = Siswa

        MenuUtama.TransaksiToolStripMenuItem.Visible = Transaksi
        MenuUtama.PembayaranToolStripMenuItem.Visible = Pembayaran

        MenuUtama.LaporanToolStripMenuItem.Visible = Laporan
        MenuUtama.HistoriPembayaranToolStripMenuItem.Visible = Histori
        MenuUtama.RekapitulasiPembayaranToolStripMenuItem.Visible = Rekapitulasi

        MenuUtama.PengaturanToolStripMenuItem.Visible = Pengaturan
        MenuUtama.KonfigurasiServerToolStripMenuItem.Visible = Server
        MenuUtama.KonfigurasiSistemToolStripMenuItem.Visible = Sistem
        MenuUtama.TentangAplikasiToolStripMenuItem.Visible = Tentang
    End Sub

End Module
