﻿Imports System.ComponentModel

Public Class SiswaForm
    Private isEdit As Boolean = False
    Private Sub LoadTable()
        Me.KeyPreview = True
        Dim Data = EksekusiSQL("SELECT siswa.*, kelas.nama_kelas, spp.tahun FROM siswa INNER JOIN kelas ON siswa.id_kelas=kelas.id_kelas INNER JOIN spp ON siswa.id_spp=spp.id_spp")
        DataGridView1.DataSource = Data
        DataGridView1.Columns(3).Visible = False 'Sembunyikan kolom id_kelas
        DataGridView1.Columns(6).Visible = False 'Sembunyikan kolom id_spp
        DataGridView1.Sort(DataGridView1.Columns(8), ListSortDirection.Descending)
        With DataGridView1
            .Columns("nisn").HeaderText = "NISN"
            .Columns("nis").HeaderText = "NIS"
            .Columns("nama").HeaderText = "Nama"
            .Columns("alamat").HeaderText = "Alamat"
            .Columns("no_telp").HeaderText = "No. Telepon"
        End With
        cmb_kelas.SelectedIndex = -1
        With DataGridView1.Columns("nama_kelas")
            .DisplayIndex = 3 'Ubah tampilan index nama_kelas menjadi index 3
            .HeaderText = "kelas"
        End With
        With DataGridView1.Columns("tahun")
            .DisplayIndex = 6 'Ubah tampilan index tahun_dibayar menjadi index 6
            .HeaderText = "tahun spp"
        End With
    End Sub

    Private Sub SiswaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Handle Combobox Kelas
        Try

            Dim Data = EksekusiSQL("SELECT * FROM kelas")
            cmb_kelas.ValueMember = "id_kelas"
            cmb_kelas.DisplayMember = "nama_kelas"
            cmb_kelas.DataSource = Data

        Catch ex As Exception

            MsgBox(ex.ToString(), vbCritical)
        End Try

        'Handle Combobox SPP
        Try

            Dim Data = EksekusiSQL("SELECT * FROM spp")
            cmb_spp.ValueMember = "id_spp"
            cmb_spp.DisplayMember = "tahun"
            cmb_spp.DataSource = Data
            For i As Integer = 0 To Data.Rows.Count - 1
                If Data.Rows(i).Item("tahun").Equals(Now.Year) Then
                    cmb_spp.SelectedIndex = i
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.ToString(), vbCritical)
        End Try

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
        isEdit = False
        cmb_kelas.SelectedIndex = -1
    End Sub

    Private Sub tb_alamat_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_alamat.KeyDown
        If e.KeyValue = Keys.Enter Then
            If Not String.IsNullOrEmpty(tb_nisn.Text) Then
                btn_update.PerformClick()
            Else
                btn_create.PerformClick()
            End If
        End If
    End Sub

    Private Sub btn_create_Click_1(sender As Object, e As EventArgs) Handles btn_create.Click

        If (Not String.IsNullOrEmpty(tb_nisn.Text) And isEdit) Then
            Try

                If Not String.IsNullOrEmpty(tb_nisn.Text) And Not String.IsNullOrEmpty(tb_nis.Text) And Not String.IsNullOrEmpty(tb_nama.Text) And Not String.IsNullOrEmpty(cmb_kelas.SelectedValue) And Not String.IsNullOrEmpty(tb_alamat.Text) And Not String.IsNullOrEmpty(tb_telepon.Text) And Not String.IsNullOrEmpty(cmb_spp.SelectedValue) Then
                    Dim Data = EksekusiSQL("UPDATE siswa SET 
                                nisn='" & tb_nisn.Text & "', 
                                nis='" & tb_nis.Text & "', 
                                nama='" & tb_nama.Text & "', 
                                id_kelas='" & cmb_kelas.SelectedValue & "', 
                                alamat='" & tb_alamat.Text & "', 
                                no_telp='" & tb_telepon.Text & "', 
                                id_spp='" & cmb_spp.SelectedValue & "' 
                               WHERE nisn='" & tb_nisn.Text & "'")
                    btn_back.PerformClick()
                Else
                    MsgBox("Tolong isi seluruh box yang masih kosong!", vbCritical)
                End If

            Catch ex As Exception
                MsgBox(ex.Message.ToString(), vbCritical)
            End Try
        Else
            Try

                If Not String.IsNullOrEmpty(tb_nis.Text) And Not String.IsNullOrEmpty(tb_nama.Text) And Not String.IsNullOrEmpty(cmb_kelas.SelectedValue) And Not String.IsNullOrEmpty(tb_alamat.Text) And Not String.IsNullOrEmpty(tb_telepon.Text) And Not String.IsNullOrEmpty(cmb_spp.SelectedValue) Then
                    Dim Data = EksekusiSQL("INSERT INTO siswa VALUES 
                                            ('" & tb_nisn.Text & "', 
                                             '" & tb_nis.Text & "', 
                                             '" & tb_nama.Text & "', 
                                             '" & cmb_kelas.SelectedValue & "', 
                                             '" & tb_alamat.Text & "', 
                                             '" & tb_telepon.Text & "', 
                                             '" & cmb_spp.SelectedValue & "')")
                    btn_back.PerformClick()
                Else
                    MsgBox("Tolong isi seluruh box yang masih kosong!", vbCritical)
                End If
            Catch ex As Exception

                MsgBox(ex.Message.ToString(), vbCritical)
            End Try
        End If

    End Sub

    Private Sub btn_back_Click_1(sender As Object, e As EventArgs) Handles btn_back.Click
        ClearTextBox()
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
                .ReadOnly = True
                .Cursor = System.Windows.Forms.Cursors.No
            End With
            isEdit = True
            tb_nisn.Text = .Item(0, .CurrentRow.Index).Value
            tb_nis.Text = .Item(1, .CurrentRow.Index).Value
            tb_nama.Text = .Item(2, .CurrentRow.Index).Value
            cmb_kelas.SelectedValue = .Item(3, .CurrentRow.Index).Value
            tb_alamat.Text = .Item(4, .CurrentRow.Index).Value
            tb_telepon.Text = .Item(5, .CurrentRow.Index).Value
            cmb_spp.SelectedValue = .Item(6, .CurrentRow.Index).Value
        End With
    End Sub

    Private Sub btn_delete_Click_1(sender As Object, e As EventArgs) Handles btn_delete.Click
        If String.IsNullOrEmpty(tb_nisn.Text) And Not isEdit Then
            MsgBox("Harap pilih baris yang akan dihapus lalu klik tombol ubah setelah itu tombol hapus", vbCritical)
            Exit Sub
        End If
        Select Case MsgBox("Yakin mau dihapus ?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                Try
                    Dim Data = EksekusiSQL("DELETE FROM siswa WHERE nisn = '" & tb_nisn.Text & "'")
                    btn_back.PerformClick()
                Catch ex As Exception
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
        Me.Close()
    End Sub

    Private Sub SiswaForm_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.F5
                btn_back.PerformClick()
            Case Keys.Escape
                Me.Close()
            Case Keys.Enter
                btn_create.PerformClick()
        End Select
    End Sub
End Class