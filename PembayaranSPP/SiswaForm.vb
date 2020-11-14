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
        currentId = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
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

    Private Sub tb_alamat_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_alamat.KeyDown
        If e.KeyValue = Keys.Enter Then
            If Not String.IsNullOrEmpty(currentId) Then
                btn_update.PerformClick()
            Else
                btn_create.PerformClick()
            End If
        End If
    End Sub

    Private Sub btn_create_Click_1(sender As Object, e As EventArgs) Handles btn_create.Click

        If (Not String.IsNullOrEmpty(currentId)) Then
            Try
                cn.Open()
                If Not String.IsNullOrEmpty(tb_nisn.Text) And Not String.IsNullOrEmpty(tb_nis.Text) And Not String.IsNullOrEmpty(tb_nama.Text) And Not String.IsNullOrEmpty(cmb_kelas.SelectedValue) And Not String.IsNullOrEmpty(tb_alamat.Text) And Not String.IsNullOrEmpty(tb_telepon.Text) And Not String.IsNullOrEmpty(cmb_spp.SelectedValue) Then
                    cm = New MySqlCommand("UPDATE siswa 
SET nisn=@nisn, nis=@nis, nama=@nama, id_kelas=@id_kelas, alamat=@alamat, no_telp=@telepon, id_spp=@id_spp WHERE nisn=@nisn", cn)
                    With cm.Parameters
                        .AddWithValue("@nisn", tb_nisn.Text)
                        .AddWithValue("@nis", tb_nis.Text)
                        .AddWithValue("@nama", tb_nama.Text)
                        .AddWithValue("@id_kelas", cmb_kelas.SelectedValue)
                        .AddWithValue("@alamat", tb_alamat.Text)
                        .AddWithValue("@telepon", tb_telepon.Text)
                        .AddWithValue("@id_spp", cmb_spp.SelectedValue)
                    End With
                    cm.ExecuteNonQuery()
                    btn_back.PerformClick()
                Else
                    MsgBox("Tolong isi seluruh box yang masih kosong!", vbCritical)
                End If
                cn.Close()
            Catch ex As Exception
                cn.Close()
                MsgBox(ex.Message.ToString(), vbCritical)
            End Try
        Else
            Try
                cn.Open()
                If Not String.IsNullOrEmpty(tb_nisn.Text) And Not String.IsNullOrEmpty(tb_nis.Text) And Not String.IsNullOrEmpty(tb_nama.Text) And Not String.IsNullOrEmpty(cmb_kelas.SelectedValue) And Not String.IsNullOrEmpty(tb_alamat.Text) And Not String.IsNullOrEmpty(tb_telepon.Text) And Not String.IsNullOrEmpty(cmb_spp.SelectedValue) Then
                    cm = New MySqlCommand("INSERT INTO siswa VALUES (@nisn, @nis, @nama, @id_kelas, @alamat, @telepon, @id_spp)", cn)
                    With cm.Parameters
                        .AddWithValue("@nisn", tb_nisn.Text)
                        .AddWithValue("@nis", tb_nis.Text)
                        .AddWithValue("@nama", tb_nama.Text)
                        .AddWithValue("@id_kelas", cmb_kelas.SelectedValue)
                        .AddWithValue("@alamat", tb_alamat.Text)
                        .AddWithValue("@telepon", tb_telepon.Text)
                        .AddWithValue("@id_spp", cmb_spp.SelectedValue)
                    End With
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
                MsgBox(ex.Message.ToString(), vbCritical)
            End Try
        End If

    End Sub

    Private Sub btn_back_Click_1(sender As Object, e As EventArgs) Handles btn_back.Click
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
        LoadTable()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        With DataGridView1
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
    End Sub

    Private Sub btn_delete_Click_1(sender As Object, e As EventArgs) Handles btn_delete.Click
        Select Case MsgBox("Yakin mau dihapus ?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                Try
                    cn.Open()
                    cm = New MySqlCommand("DELETE FROM siswa WHERE nisn = @nisn", cn)
                    cm.Parameters.AddWithValue("@nisn", currentId)
                    cm.ExecuteNonQuery()
                    cn.Close()
                    btn_back.PerformClick()
                Catch ex As Exception
                    cn.Close()
                    MsgBox(ex.Message.ToString(), vbCritical)
                End Try
        End Select
    End Sub

    Dim mRow As Integer = 0
    Dim newpage As Boolean = True
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        With DataGridView1
            Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
            fmt.LineAlignment = StringAlignment.Center
            fmt.Trimming = StringTrimming.EllipsisCharacter
            Dim y As Single = e.MarginBounds.Top
            Do While mRow < .RowCount
                Dim row As DataGridViewRow = .Rows(mRow)
                Dim x As Single = e.MarginBounds.Left
                Dim h As Single = 0
                For Each cell As DataGridViewCell In row.Cells
                    Dim rc As RectangleF = New RectangleF(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.DrawRectangle(Pens.Black, rc.Left, rc.Top, rc.Width, rc.Height)
                    If (newpage) Then
                        e.Graphics.DrawString(DataGridView1.Columns(cell.ColumnIndex).HeaderText, .Font, Brushes.Black, rc, fmt)
                    Else
                        e.Graphics.DrawString(DataGridView1.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString(), .Font, Brushes.Black, rc, fmt)
                    End If
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                Next
                newpage = False
                y += h
                mRow += 1
                If y + h > e.MarginBounds.Bottom Then
                    e.HasMorePages = True
                    mRow -= 1
                    newpage = True
                    Exit Sub
                End If
            Loop
            mRow = 0
        End With
    End Sub

    Private Sub btn_cetak_Click(sender As Object, e As EventArgs) Handles btn_cetak.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btn_tutup_Click(sender As Object, e As EventArgs) Handles btn_tutup.Click
        PageAdmin.FormPanel(TransaksiForm)
    End Sub
End Class