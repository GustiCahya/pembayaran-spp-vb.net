Public Class CetakLaporan
    Public SourceHTML
    Private Sub CetakLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.DocumentText = SourceHTML
    End Sub

    Private Sub btn_tutup_Click(sender As Object, e As EventArgs) Handles btn_tutup.Click
        Me.Close()
    End Sub

    Private Sub btn_cetak_Click(sender As Object, e As EventArgs) Handles btn_cetak.Click
        WebBrowser1.ShowPrintPreviewDialog()
    End Sub
End Class