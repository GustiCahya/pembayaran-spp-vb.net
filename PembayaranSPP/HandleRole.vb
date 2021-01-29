Module HandleRole

    Public Sub OnOffMenu(
        Optional ByVal File As Boolean = False,
        Optional ByVal GantiPassword As Boolean = False,
        Optional ByVal Logout As Boolean = False,
        Optional ByVal Keluar As Boolean = False,
        Optional ByVal Master As Boolean = False,
        Optional ByVal Petugas As Boolean = False,
        Optional ByVal Kelas As Boolean = False,
        Optional ByVal SPP As Boolean = False,
        Optional ByVal Siswa As Boolean = False,
        Optional ByVal Transaksi As Boolean = False,
        Optional ByVal Pembayaran As Boolean = False,
        Optional ByVal Laporan As Boolean = False,
        Optional ByVal Histori As Boolean = False,
        Optional ByVal Rekapitulasi As Boolean = False,
        Optional ByVal Pengaturan As Boolean = False,
        Optional ByVal Server As Boolean = False,
        Optional ByVal Sistem As Boolean = False,
        Optional ByVal Tentang As Boolean = False
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
