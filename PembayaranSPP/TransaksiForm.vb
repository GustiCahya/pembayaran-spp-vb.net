Public Class TransaksiForm
    Private currentRowIndex As String
    Private nisn_global As String
    Private Sub TransaksiForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtp_tanggal.Format = DateTimePickerFormat.Custom
        dtp_tanggal.CustomFormat = "MMMM yyyy"

        handle_lbl_minimum()
        'Handle Combobox Petugas
        Try
            Dim Data = EksekusiSQL("SELECT * FROM petugas WHERE username = '" & MenuUtama.username & "'")
            cmb_petugas.ValueMember = "id_petugas"
            cmb_petugas.DisplayMember = "nama_petugas"
            cmb_petugas.DataSource = Data
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), vbCritical)
        End Try
    End Sub
    Private Sub dtp_tanggal_ValueChanged(sender As Object, e As EventArgs) Handles dtp_tanggal.ValueChanged
        handle_lbl_minimum()
    End Sub
    Private Sub handle_lbl_minimum()
        'Handle lbl_minimum jumlah bayar
        Try
            Dim get_tahun As String = dtp_tanggal.Value.Year
            Dim Data = EksekusiSQL("SELECT nominal FROM spp WHERE tahun='" & get_tahun & "'").Rows(0)
            num_jumlah_bayar.Value = Data.Item(0)
        Catch ex As Exception
            MsgBox(ex.ToString(), vbCritical)
        End Try
    End Sub
    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            If Not String.IsNullOrEmpty(cmb_petugas.SelectedValue) And Not String.IsNullOrEmpty(nisn_global) And Not String.IsNullOrEmpty(dtp_tanggal.Value) And Not String.IsNullOrEmpty(num_jumlah_bayar.Value) Then

                Dim id_petugas As String = cmb_petugas.SelectedValue
                Dim nisn As String = nisn_global
                Dim tanggal As String = Date.Now().ToString("dd/MM/yyyy")
                Dim tahun As String = dtp_tanggal.Value.Year
                Dim bulan As Integer = dtp_tanggal.Value.Month

                Dim isExist = EksekusiSQL("SELECT id_pembayaran FROM pembayaran WHERE 
                                               nisn='" & nisn & "' And
                                               tahun_dibayar='" & tahun & "' And
                                               bulan_dibayar='" & bulan & "'").Rows

                If isExist.Count >= 1 Then
                    MsgBox("Siswa Tersebut Sudah Bayar dalam Bulan dan Tahun yang Anda Pilih", vbCritical)
                    Exit Sub
                End If

                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    Dim nisn_ditabel = DataGridView1.Rows(i).Cells("nisn").Value
                    Dim tahun_ditabel = DataGridView1.Rows(i).Cells("tahun_dibayar").Value
                    Dim bulan_ditabel = DataGridView1.Rows(i).Cells("bulan_dibayar").Value

                    If nisn = nisn_ditabel And tahun = tahun_ditabel And bulan = bulan_ditabel Then
                        MsgBox("Maaf Bulan dan Tahun tersebut sudah dimasukkan", vbCritical)
                        Exit Sub
                    End If

                Next

                dtp_tanggal.Value = dtp_tanggal.Value.AddMonths(1)

                Dim id_spp As Integer
                Dim jumlah_bayar As Integer
                Try
                    id_spp = EksekusiSQL("SELECT id_spp FROM spp WHERE tahun='" & tahun & "'").Rows(0).Item(0)
                    jumlah_bayar = EksekusiSQL("SELECT nominal FROM spp WHERE tahun='" & tahun & "'").Rows(0).Item(0)
                Catch ex As Exception
                    MsgBox(ex.Message.ToString(), vbCritical)
                End Try

                With DataGridView1
                    Dim index As Integer = .RowCount
                    .Rows.Add()
                    .Rows(index).Cells("no").Value = .RowCount
                    .Rows(index).Cells("id_petugas").Value = id_petugas
                    .Rows(index).Cells("nisn").Value = nisn
                    .Rows(index).Cells("tgl_bayar").Value = tanggal
                    .Rows(index).Cells("bulan_dibayar").Value = bulan
                    .Rows(index).Cells("tahun_dibayar").Value = tahun
                    .Rows(index).Cells("id_spp").Value = id_spp
                    .Rows(index).Cells("jumlah_bayar").Value = jumlah_bayar
                End With
            Else
                MsgBox("Tolong isi box yang belum terisi!", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), vbCritical)
        End Try

    End Sub

    Private Sub ClearTextBox()
        currentRowIndex = ""
        nisn_global = ""
        tb_nisn.Text = ""
        lbl_nama_siswa.Text = "Nama"
        lbl_nama_kelas.Text = "Kelas"
        dtp_tanggal.Value = Now()
    End Sub

    Private Sub btn_send_Click(sender As Object, e As EventArgs) Handles btn_send.Click
        Try
            If DataGridView1.RowCount > 0 Then
                For i = 0 To DataGridView1.RowCount - 1
                    Try
                        Dim id_petugas = DataGridView1.Rows(i).Cells("id_petugas").Value
                        Dim nisn = DataGridView1.Rows(i).Cells("nisn").Value
                        Dim tanggal = (DateTime.Parse(DataGridView1.Rows(i).Cells("tgl_bayar").Value).ToString("yyyy-MM-dd"))
                        Dim bulan = DataGridView1.Rows(i).Cells("bulan_dibayar").Value
                        Dim tahun = DataGridView1.Rows(i).Cells("tahun_dibayar").Value
                        Dim id_spp = DataGridView1.Rows(i).Cells("id_spp").Value
                        Dim jumlah_bayar = DataGridView1.Rows(i).Cells("jumlah_bayar").Value

                        EksekusiSQL("INSERT INTO pembayaran VALUES (
                                     '',
                                     '" & id_petugas & "',
                                     '" & nisn & "',
                                     '" & tanggal & "',
                                     '" & bulan & "',
                                     '" & tahun & "',
                                     '" & id_spp & "',
                                     '" & jumlah_bayar & "'
                                   )")
                    Catch ex As Exception
                        MsgBox(ex.Message.ToString(), vbCritical)
                    End Try
                Next
                MsgBox("Data Berhasil Dimasukkan!", vbInformation)
                DataGridView1.Rows.Clear()
                DataGridView1.Refresh()
            Else
                MsgBox("Tidak ada pembayaran yang akan dikirim", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        currentRowIndex = e.RowIndex
    End Sub

    Private Sub num_jumlah_bayar_KeyDown(sender As Object, e As KeyEventArgs) Handles num_jumlah_bayar.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_add.PerformClick()
        End If
    End Sub

    Private Sub btn_tutup_Click(sender As Object, e As EventArgs) Handles btn_tutup.Click
        Me.Close()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If String.IsNullOrEmpty(currentRowIndex) Then
            MsgBox("Harap pilih terlebih dahulu baris yang ingin dihapus", vbCritical)
            Exit Sub
        End If
        If Integer.Parse(currentRowIndex) >= 0 Then
            DataGridView1.Rows.RemoveAt(currentRowIndex)
            currentRowIndex -= 1
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Try
            Dim Data = EksekusiSQL("SELECT a.nisn, a.nama, b.nama_kelas FROM siswa a JOIN kelas b ON a.id_kelas=b.id_kelas WHERE nisn='" & tb_nisn.Text & "'")
            lbl_nama_siswa.Text = Data.Rows(0)("nama")
            lbl_nama_kelas.Text = Data.Rows(0)("nama_kelas")
            nisn_global = Data.Rows(0)("nisn")
            dtp_tanggal.Value = Now()
        Catch ex As Exception
            MsgBox("Harap memasukkan NISN dengan Benar", vbCritical)
            ClearTextBox()
        End Try
    End Sub

    Private Sub tb_nisn_TextChanged(sender As Object, e As EventArgs) Handles tb_nisn.TextChanged
        If tb_nisn.Text.Length > 9 Then
            btnCari.PerformClick()
        End If
        If tb_nisn.Text.Length <= 0 Then
            ClearTextBox()
        End If
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        ClearTextBox()
        DataGridView1.DataSource = vbNull
    End Sub
End Class