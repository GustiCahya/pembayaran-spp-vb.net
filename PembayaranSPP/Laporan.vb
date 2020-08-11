Public Class Laporan
    Private laporan_ds As LaporanDataSet
    Private pembayaran As LaporanDataSetTableAdapters.pembayaranTableAdapter
    Private petugas As LaporanDataSetTableAdapters.petugasTableAdapter
    Private siswa As LaporanDataSetTableAdapters.siswaTableAdapter
    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim laporan_rpt As New CrystalReport1
        Try
            laporan_ds = New LaporanDataSet
            pembayaran = New LaporanDataSetTableAdapters.pembayaranTableAdapter
            petugas = New LaporanDataSetTableAdapters.petugasTableAdapter
            siswa = New LaporanDataSetTableAdapters.siswaTableAdapter

            pembayaran.Fill(laporan_ds.pembayaran)
            petugas.Fill(laporan_ds.petugas)
            siswa.Fill(laporan_ds.siswa)

            laporan_rpt.SetDataSource(laporan_ds)
            CrystalReportViewer1.ReportSource = laporan_rpt
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
        Me.CrystalReportViewer1.Refresh()
    End Sub
End Class