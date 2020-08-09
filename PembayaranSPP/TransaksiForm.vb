Imports MySql.Data.MySqlClient
Public Class TransaksiForm
    Private Sub TransaksiForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
        'Handle Combobox Petugas
        Try
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM petugas WHERE username='" & PageAdmin.username & "'", cn)
            dt = New DataTable
            dt.Load(cm.ExecuteReader())
            cmb_petugas.ValueMember = "id_petugas"
            cmb_petugas.DisplayMember = "nama_petugas"
            cmb_petugas.DataSource = dt
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString(), vbCritical)
        End Try
        'Handle Combobox NISN
        Try
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM siswa", cn)
            da = New MySqlDataAdapter(cm)
            dt = New DataTable
            da.Fill(dt)

            Dim autocompleted As New AutoCompleteStringCollection
            For i As Integer = 0 To dt.Rows.Count - 1
                autocompleted.Add(dt.Rows(i)("nisn"))
            Next
            cmb_nisn.AutoCompleteSource = AutoCompleteSource.CustomSource
            cmb_nisn.DataSource = dt
            cmb_nisn.AutoCompleteCustomSource = autocompleted
            cmb_nisn.AutoCompleteMode = AutoCompleteMode.Suggest

            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString(), vbCritical)
        End Try
        'Handle Combobox SPP
        Try
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM spp", cn)
            dt = New DataTable
            dt.Load(cm.ExecuteReader())
            cmb_spp.ValueMember = "id_spp"
            cmb_spp.DisplayMember = "tahun"
            cmb_spp.DataSource = dt
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString(), vbCritical)
        End Try
    End Sub
    Private Sub cmb_nisn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_nisn.SelectedIndexChanged
        Try
            Connection()
            cn.Open()
            cm = New MySqlCommand("SELECT nama FROM siswa WHERE nisn='" & cmb_nisn.SelectedValue & "'", cn)
            dt = New DataTable
            dt.Load(cm.ExecuteReader())
            lbl_nama_siswa.Text = dt.Rows(0)("nama")
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString(), vbCritical)
        End Try
    End Sub
    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        Connection()
        Try
            cn.Open()
            If Not String.IsNullOrEmpty(cmb_petugas.SelectedValue) And Not String.IsNullOrEmpty(cmb_nisn.SelectedValue) And Not String.IsNullOrEmpty(dtp_tanggal.Value) And Not String.IsNullOrEmpty(cmb_spp.SelectedValue) And Not String.IsNullOrEmpty(tb_jumlah_bayar.Text) Then
                Dim tanggal As String = dtp_tanggal.Value.ToString("yyyy-MM-dd")
                Dim bulan As Integer = dtp_tanggal.Value.Month
                Dim tahun As String = dtp_tanggal.Value.Year
                Dim id_spp As Integer = cmb_spp.SelectedValue
                Dim jumlah_bayar As Integer = tb_jumlah_bayar.Text
                cm = New MySqlCommand("SELECT nominal FROM spp WHERE id_spp='" & id_spp & "'", cn)
                Dim nominal As Integer = cm.ExecuteScalar()
                If jumlah_bayar >= nominal Then
                    cm = New MySqlCommand("SELECT Count(*) FROM pembayaran", cn)
                    Dim count As Integer = cm.ExecuteScalar()
                    cm = New MySqlCommand("INSERT INTO pembayaran VALUES ('" & count + 1 & "', '" & cmb_petugas.SelectedValue & "', '" & cmb_nisn.SelectedValue & "', '" & tanggal & "', '" & bulan & "', '" & tahun & "', '" & id_spp & "', '" & jumlah_bayar & "')", cn)
                    cm.ExecuteNonQuery()
                    MsgBox("Transaksi Berhasil Disimpan!", vbInformation)
                    ClearTextBox()
                Else
                    MsgBox("Jumlah bayar tidak boleh kurang dari " & nominal, vbCritical)
                End If
            Else
                MsgBox("Tolong isi box yang belum terisi!", vbCritical)
            End If
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString(), vbCritical)
        End Try
    End Sub

    Private Sub ClearTextBox()
        tb_jumlah_bayar.Text = ""
    End Sub

    Private Sub tb_jumlah_bayar_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_jumlah_bayar.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_create.PerformClick()
        End If
    End Sub
End Class