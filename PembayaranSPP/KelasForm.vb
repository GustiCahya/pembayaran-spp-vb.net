Imports MySql.Data.MySqlClient
Public Class KelasForm
    Private currentId As String

    Private Sub SppForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        LoadTable()
    End Sub

    Private Sub ClearTextBox()
        tb_nama_kelas.Text = ""
        cmb_kompetensi_keahlian.SelectedIndex = -1
    End Sub

    Private Sub LoadTable()
        da = New MySqlDataAdapter("SELECT * FROM kelas", cn)
        ds = New DataSet()
        da.Fill(ds, "kelas")
        DataGridView1.DataSource = ds.Tables("kelas")
        With DataGridView1
            .Columns("id_kelas").HeaderText = "Id Kelas"
            .Columns("nama_kelas").HeaderText = "Nama Kelas"
            .Columns("kompetensi_keahlian").HeaderText = "Kompetensi Keahlian"
        End With
        tb_id_kelas.Text = DataGridView1.RowCount + 1
        tb_id_kelas.ReadOnly = True
        tb_id_kelas.Cursor = System.Windows.Forms.Cursors.No
    End Sub

    Private Sub tb_kompetensi_keahlian_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If Not String.IsNullOrEmpty(currentId) Then
                btn_update.PerformClick()
            Else
                btn_create.PerformClick()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        currentId = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
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

    Private Sub btn_create_Click_1(sender As Object, e As EventArgs) Handles btn_create.Click
        If (Not String.IsNullOrEmpty(currentId)) Then
            Try
                cn.Open()
                If Not String.IsNullOrEmpty(tb_nama_kelas.Text) And Not String.IsNullOrEmpty(cmb_kompetensi_keahlian.SelectedValue) Then
                    cm = New MySqlCommand("UPDATE kelas SET id_kelas=@id_kelas, nama_kelas=@nama_kelas, kompetensi_keahlian=@kompentensi WHERE id_kelas=@id_kelas ", cn)
                    With cm.Parameters
                        .AddWithValue("@id_kelas", tb_id_kelas.Text)
                        .AddWithValue("@nama_kelas", tb_nama_kelas.Text)
                        .AddWithValue("@kompentensi", cmb_kompetensi_keahlian.SelectedValue)
                    End With
                    cm.ExecuteNonQuery()
                    btn_back.PerformClick()
                Else
                    MsgBox("Tolong isi seluruh box yang masih kosong!", vbCritical)
                End If
                cn.Close()
            Catch ex As Exception
                cn.Close()
                MsgBox(ex.Message.ToString())
            End Try
        Else
            Try
                cn.Open()
                If Not String.IsNullOrEmpty(tb_nama_kelas.Text) And Not String.IsNullOrEmpty(cmb_kompetensi_keahlian.SelectedValue) Then
                    cm = New MySqlCommand("INSERT INTO kelas VALUES (@id_kelas, @nama_kelas, @kompentensi)", cn)
                    With cm.Parameters
                        .AddWithValue("@id_kelas", tb_id_kelas.Text)
                        .AddWithValue("@nama_kelas", tb_nama_kelas.Text)
                        .AddWithValue("@kompentensi", cmb_kompetensi_keahlian.SelectedValue)
                    End With
                    cm.ExecuteNonQuery()
                    LoadTable()
                    ClearTextBox()
                Else
                    MsgBox("Tolong isi seluruh box yang masih kosong!", vbCritical)
                End If
                cn.Close()
            Catch ex As Exception
                cn.Close()
                MsgBox(ex.Message.ToString())
            End Try
        End If
    End Sub

    Private Sub btn_back_Click_1(sender As Object, e As EventArgs) Handles btn_back.Click
        ClearTextBox()
        currentId = ""
        LoadTable()
    End Sub

    Private Sub btn_update_Click_1(sender As Object, e As EventArgs) Handles btn_update.Click
        With DataGridView1
            tb_id_kelas.Text = currentId
            tb_nama_kelas.Text = .Item(1, .CurrentRow.Index).Value
            cmb_kompetensi_keahlian.SelectedValue = .Item(2, .CurrentRow.Index).Value
        End With
    End Sub

    Private Sub btn_delete_Click_1(sender As Object, e As EventArgs) Handles btn_delete.Click
        Select Case MsgBox("Yakin mau dihapus?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                Try
                    cn.Open()
                    cm = New MySqlCommand("DELETE FROM kelas WHERE id_kelas = @id_kelas", cn)
                    cm.Parameters.AddWithValue("@id_kelas", currentId)
                    cm.ExecuteNonQuery()
                    cn.Close()
                    btn_back.PerformClick()
                Catch ex As Exception
                    cn.Close()
                    MsgBox(ex.Message.ToString(), vbCritical)
                End Try
        End Select
    End Sub

    Private Sub cmb_kompetensi_keahlian_GotFocus(sender As Object, e As EventArgs) Handles cmb_kompetensi_keahlian.GotFocus
        Try
            cn.Open()
            cm = New MySqlCommand("SELECT DISTINCT(kompetensi_keahlian) FROM kelas", cn)
            dt = New DataTable
            dt.Load(cm.ExecuteReader())
            cmb_kompetensi_keahlian.ValueMember = "kompetensi_keahlian"
            cmb_kompetensi_keahlian.DisplayMember = "kompetensi_keahlian"
            cmb_kompetensi_keahlian.DataSource = dt
            cn.Close()
            btn_back.PerformClick()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message.ToString(), vbCritical)
        End Try
    End Sub

    Private Sub KelasForm_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
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