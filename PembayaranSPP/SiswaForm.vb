Imports MySql.Data.MySqlClient
Public Class SiswaForm

    Private currentId

    Private Sub LoadTable()
        da = New MySqlDataAdapter("SELECT siswa.*, kelas.nama_kelas, spp.tahun FROM siswa INNER JOIN kelas ON siswa.id_kelas=kelas.id_kelas INNER JOIN spp ON siswa.id_spp=spp.id_spp", cn)
        ds = New DataSet()
        da.Fill(ds, "siswa")
        DataGridView1.DataSource = ds.Tables("siswa")
        DataGridView1.Columns(3).Visible = False 'Sembunyikan kolom id_kelas
        DataGridView1.Columns(6).Visible = False 'Sembunyikan kolom id_spp
        With DataGridView1.Columns(7)
            .DisplayIndex = 3 'Ubah tampilan index nama_kelas menjadi index 3
            .HeaderText = "kelas"
        End With
        With DataGridView1.Columns(8)
            .DisplayIndex = 6 'Ubah tampilan index tahun spp menjadi index 6
            .HeaderText = "tahun spp"
        End With
    End Sub

    Private Sub SiswaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Handle Combobox Kelas
        Try
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM kelas", cn)
            dt = New DataTable
            dt.Load(cm.ExecuteReader())
            cmb_kelas.ValueMember = "id_kelas"
            cmb_kelas.DisplayMember = "nama_kelas"
            cmb_kelas.DataSource = dt
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

        LoadTable()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        With DataGridView1
            currentId = .Item(0, .CurrentRow.Index).Value
            With tb_nisn
                .Text = currentId
                .ReadOnly = True
                .Cursor = System.Windows.Forms.Cursors.No
            End With
            tb_nis.Text = .Item(1, .CurrentRow.Index).Value
            With tb_nis
                .ReadOnly = True
                .Cursor = System.Windows.Forms.Cursors.No
            End With
            tb_nis.ReadOnly = True
            tb_nama.Text = .Item(2, .CurrentRow.Index).Value
            cmb_kelas.SelectedValue = .Item(3, .CurrentRow.Index).Value
            tb_alamat.Text = .Item(4, .CurrentRow.Index).Value
            tb_telepon.Text = .Item(5, .CurrentRow.Index).Value
            cmb_spp.SelectedValue = .Item(6, .CurrentRow.Index).Value
        End With
        btn_create.Visible = False
        btn_update.Visible = True
        btn_delete.Visible = True
        btn_back.Visible = True
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        ClearTextBox()
        currentId = ""
        With tb_nisn
            .ReadOnly = False
            .Cursor = System.Windows.Forms.Cursors.IBeam
        End With
        With tb_nis
            .ReadOnly = False
            .Cursor = System.Windows.Forms.Cursors.IBeam
        End With
        btn_create.Visible = True
        btn_update.Visible = False
        btn_delete.Visible = False
        btn_back.Visible = False
        LoadTable()
    End Sub

    Private Sub ClearTextBox()
        tb_nisn.Text = ""
        tb_nis.Text = ""
        tb_nama.Text = ""
        tb_alamat.Text = ""
        cmb_kelas.Text = ""
        tb_telepon.Text = ""
        cmb_spp.Text = ""
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Select Case MsgBox("Yakin mau dihapus ?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                Try
                    cn.Open()
                    cm = New MySqlCommand("DELETE FROM siswa WHERE nisn = '" & currentId & "'", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()
                    btn_back.PerformClick()
                Catch ex As Exception
                    cn.Close()
                    MsgBox(ex.ToString(), vbCritical)
                End Try
        End Select
    End Sub

    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        Try
            cn.Open()
            If Not String.IsNullOrEmpty(tb_nisn.Text) And Not String.IsNullOrEmpty(tb_nis.Text) And Not String.IsNullOrEmpty(tb_nama.Text) And Not String.IsNullOrEmpty(cmb_kelas.SelectedValue) And Not String.IsNullOrEmpty(tb_alamat.Text) And Not String.IsNullOrEmpty(tb_telepon.Text) And Not String.IsNullOrEmpty(cmb_spp.SelectedValue) Then
                cm = New MySqlCommand("INSERT INTO siswa VALUES ('" & tb_nisn.Text & "', '" & tb_nis.Text & "', '" & tb_nama.Text & "', '" & cmb_kelas.SelectedValue & "', '" & tb_alamat.Text & "', '" & tb_telepon.Text & "', '" & cmb_spp.SelectedValue & "')", cn)
                cm.ExecuteNonQuery()
                LoadTable()
                ClearTextBox()
            Else
                MsgBox("Tolong isi seluruh box yang masih kosong!", vbCritical)
            End If
            cn.Close()
            btn_back.PerformClick()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString(), vbCritical)
        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            cn.Open()
            If Not String.IsNullOrEmpty(tb_nisn.Text) And Not String.IsNullOrEmpty(tb_nis.Text) And Not String.IsNullOrEmpty(tb_nama.Text) And Not String.IsNullOrEmpty(cmb_kelas.SelectedValue) And Not String.IsNullOrEmpty(tb_alamat.Text) And Not String.IsNullOrEmpty(tb_telepon.Text) And Not String.IsNullOrEmpty(cmb_spp.SelectedValue) Then
                cm = New MySqlCommand("UPDATE siswa SET nisn='" & tb_nisn.Text & "', nis='" & tb_nis.Text & "', nama='" & tb_nama.Text & "', id_kelas='" & cmb_kelas.SelectedValue & "', alamat='" & tb_alamat.Text & "', no_telp='" & tb_telepon.Text & "', id_spp='" & cmb_spp.SelectedValue & "' WHERE nisn='" & currentId & "'", cn)
                cm.ExecuteNonQuery()
                btn_back.PerformClick()
            Else
                MsgBox("Tolong isi seluruh box yang masih kosong!", vbCritical)
            End If
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString(), vbCritical)
        End Try
    End Sub

    Private Sub tb_alamat_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_alamat.KeyDown
        If e.KeyValue = Keys.Enter Then
            If Not String.IsNullOrEmpty(currentId) Then
                btn_update.PerformClick()
            Else
                btn_create.PerformClick()
            End If
        End If
    End Sub
End Class