Imports MySql.Data.MySqlClient
Public Class TransaksiForm
    Private currentRowIndex As String
    Private Sub TransaksiForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
        handle_lbl_minimum()
        'Handle Combobox Petugas
        Try
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM petugas WHERE username = @username", cn)
            cm.Parameters.AddWithValue("@username", PageAdmin.username)
            dt = New DataTable
            dt.Load(cm.ExecuteReader())
            cmb_petugas.ValueMember = "id_petugas"
            cmb_petugas.DisplayMember = "nama_petugas"
            cmb_petugas.DataSource = dt
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message.ToString(), vbCritical)
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
            MsgBox(ex.Message.ToString(), vbCritical)
        End Try
    End Sub
    Private Sub dtp_tanggal_ValueChanged(sender As Object, e As EventArgs) Handles dtp_tanggal.ValueChanged
        handle_lbl_minimum()
    End Sub
    Private Sub handle_lbl_minimum()
        'Handle lbl_minimum jumlah bayar
        Try
            cn.Open()
            Dim get_tahun As String = dtp_tanggal.Value.Year
            cm = New MySqlCommand("SELECT nominal FROM spp WHERE tahun=@tahun", cn)
            cm.Parameters.AddWithValue("@tahun", get_tahun)
            lbl_minimum.Text = "Minimum: " & cm.ExecuteScalar()
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
            cm = New MySqlCommand("SELECT nama FROM siswa WHERE nisn=@nisn", cn)
            cm.Parameters.AddWithValue("@nisn", cmb_nisn.SelectedValue)
            dt = New DataTable
            dt.Load(cm.ExecuteReader())
            lbl_nama_siswa.Text = dt.Rows(0)("nama")
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message.ToString(), vbCritical)
        End Try
    End Sub
    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Connection()
        Try
            cn.Open()
            If Not String.IsNullOrEmpty(cmb_petugas.SelectedValue) And Not String.IsNullOrEmpty(cmb_nisn.SelectedValue) And Not String.IsNullOrEmpty(dtp_tanggal.Value) And Not String.IsNullOrEmpty(tb_jumlah_bayar.Text) Then

                Dim id_pembayaran As Integer
                If DataGridView1.RowCount < 1 Then
                    cm = New MySqlCommand("SELECT Count(*) FROM pembayaran", cn)
                    Dim count As Integer = cm.ExecuteScalar()
                    id_pembayaran = count + 1
                Else
                    id_pembayaran = DataGridView1.Rows(DataGridView1.RowCount - 1).Cells(1).Value + 1
                End If

                Dim id_petugas As String = cmb_petugas.SelectedValue
                Dim nisn As String = cmb_nisn.SelectedValue
                Dim tanggal As String = dtp_tanggal.Value.ToString("yyyy-MM-dd")
                Dim bulan As Integer = dtp_tanggal.Value.Month
                Dim tahun As String = dtp_tanggal.Value.Year

                Dim id_spp As Integer
                Try
                    cm = New MySqlCommand("SELECT id_spp FROM spp WHERE tahun=@tahun", cn)
                    cm.Parameters.AddWithValue("@tahun", tahun)
                    id_spp = cm.ExecuteScalar()
                Catch ex As Exception
                    MsgBox(ex.Message.ToString(), vbCritical)
                End Try

                Dim jumlah_bayar As Integer = tb_jumlah_bayar.Text
                cm = New MySqlCommand("SELECT nominal FROM spp WHERE id_spp=@id_spp", cn)
                cm.Parameters.AddWithValue("@id_spp", id_spp)
                Dim nominal As Integer = cm.ExecuteScalar()
                If jumlah_bayar >= nominal Then
                    With DataGridView1
                        Dim index As Integer = .RowCount
                        .Rows.Add()
                        .Rows(index).Cells(0).Value = .RowCount
                        .Rows(index).Cells(1).Value = id_pembayaran
                        .Rows(index).Cells(2).Value = id_petugas
                        .Rows(index).Cells(3).Value = nisn
                        .Rows(index).Cells(4).Value = tanggal
                        .Rows(index).Cells(5).Value = bulan
                        .Rows(index).Cells(6).Value = tahun
                        .Rows(index).Cells(7).Value = id_spp
                        .Rows(index).Cells(8).Value = jumlah_bayar
                    End With
                Else
                    MsgBox("Jumlah bayar tidak boleh kurang dari " & nominal, vbCritical)
                End If
            Else
                MsgBox("Tolong isi box yang belum terisi!", vbCritical)
            End If
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message.ToString(), vbCritical)
        End Try

    End Sub

    Private Sub ClearTextBox()
        tb_jumlah_bayar.Text = ""
    End Sub

    Private Sub tb_jumlah_bayar_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_jumlah_bayar.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_add.PerformClick()
        End If
    End Sub

    Private Sub btn_send_Click(sender As Object, e As EventArgs) Handles btn_send.Click
        Connection()
        Try
            cn.Open()
            If DataGridView1.RowCount > 0 Then
                For i = 0 To DataGridView1.RowCount - 1
                    Try
                        cm = New MySqlCommand("INSERT INTO pembayaran VALUES (@id_pembayaran, @id_petugas, @nisn, @tanggal, @bulan, @tahun, @id_spp, @jumlah_bayar)", cn)
                        With cm.Parameters
                            .AddWithValue("@id_pembayaran", DataGridView1.Rows(i).Cells(1).Value)
                            .AddWithValue("@id_petugas", DataGridView1.Rows(i).Cells(2).Value)
                            .AddWithValue("@nisn", DataGridView1.Rows(i).Cells(3).Value)
                            .AddWithValue("@tanggal", DataGridView1.Rows(i).Cells(4).Value)
                            .AddWithValue("@bulan", DataGridView1.Rows(i).Cells(5).Value)
                            .AddWithValue("@tahun", DataGridView1.Rows(i).Cells(6).Value)
                            .AddWithValue("@id_spp", DataGridView1.Rows(i).Cells(7).Value)
                            .AddWithValue("@jumlah_bayar", DataGridView1.Rows(i).Cells(8).Value)
                        End With
                        cm.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message.ToString(), vbCritical)
                    End Try
                Next
                MsgBox("Data Berhasil Dimasukkan!", vbInformation)
                DataGridView1.Rows.Clear()
                DataGridView1.Refresh()
            End If
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        currentRowIndex = e.RowIndex
        btn_delete.Visible = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        DataGridView1.Rows.RemoveAt(currentRowIndex)
        btn_delete.Visible = False
    End Sub
End Class