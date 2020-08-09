Imports MySql.Data.MySqlClient
Public Class RiwayatForm
    Private currentId As String
    Private bitmap As Bitmap
    Private Sub RiwayatForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If PageAdmin.role <> "admin" Then
            DataGridView1.Size = New System.Drawing.Size(584, 275)
            DataGridView1.Location = New System.Drawing.Point(0, 86)
            btn_laporan.Visible = False
        End If
        btn_delete.Visible = False
        LoadTable()
    End Sub
    Private Sub LoadTable()
        Select Case PageAdmin.role
            Case "petugas"
                cn.Open()
                da = New MySqlDataAdapter(
                    "SELECT pembayaran.*, petugas.nama_petugas, siswa.nama FROM pembayaran 
                    INNER JOIN petugas ON pembayaran.id_petugas=petugas.id_petugas 
                    INNER JOIN siswa ON pembayaran.nisn = siswa.nisn 
                    WHERE pembayaran.id_petugas='" & PageAdmin.currentId & "' ", cn)
                CustomizeTable()
                cn.Close()
            Case "siswa"
                cn.Open()
                da = New MySqlDataAdapter(
                    "SELECT pembayaran.*, petugas.nama_petugas, siswa.nama 
                    FROM pembayaran INNER JOIN petugas ON pembayaran.id_petugas=petugas.id_petugas 
                    INNER JOIN siswa ON pembayaran.nisn = siswa.nisn 
                    WHERE pembayaran.nisn='" & PageAdmin.currentId & "'", cn)
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
        DataGridView1.Columns(1).Visible = False
        DataGridView1.Columns(8).HeaderText = "petugas"
        DataGridView1.Columns(8).DisplayIndex = 1
        DataGridView1.Columns(9).HeaderText = "siswa"
        DataGridView1.Columns(9).DisplayIndex = 4
        Dim indexBulan As Integer
        Dim tanggal As Date
        For i = 0 To DataGridView1.Rows.Count - 1
            indexBulan = DataGridView1.Rows(i).Cells(4).Value - 1
            DataGridView1.Rows(i).Cells(4).Value = daftarBulan(indexBulan)
            tanggal = DataGridView1.Rows(i).Cells(3).Value
            DataGridView1.Rows(i).Cells(3).Value = tanggal.ToString("dd/MM/yyyy")
        Next
    End Sub

    Private Sub btn_laporan_Click(sender As Object, e As EventArgs) Handles btn_laporan.Click
        Dim height As Integer = DataGridView1.Height
        DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height
        bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        With PrintPreviewDialog1
            .Document = PrintDocument1
            .PrintPreviewControl.Zoom = 1
            .ShowDialog()
        End With
        DataGridView1.Height = height
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)
        Dim rectPrint As RectangleF = e.PageSettings.PrintableArea
        If Me.DataGridView1.Height - rectPrint.Height > 0 Then e.HasMorePages = True
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Select Case MsgBox("Yakin ID Pembayaran " & currentId & " mau dihapus ?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                Try
                    cn.Open()
                    cm = New MySqlCommand("DELETE FROM pembayaran WHERE id_pembayaran = '" & currentId & "'", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()
                    btn_delete.Visible = False
                Catch ex As Exception
                    cn.Close()
                    MsgBox(ex.ToString(), vbCritical)
                End Try
        End Select
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        btn_delete.Visible = True
        currentId = DataGridView1.Item(0, e.RowIndex).Value
        If PageAdmin.role <> "admin" Then
            btn_delete.Location = New System.Drawing.Point(487, 51)
        End If
    End Sub
End Class