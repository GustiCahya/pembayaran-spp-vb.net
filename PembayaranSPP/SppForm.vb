Public Class SppForm

    Private Sub SppForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        num_tahun.Value = Now.Year
        LoadTable()
    End Sub

    Private Sub ClearTextBox()
        num_tahun.Value = 0
        num_nominal.Value = 0
    End Sub

    Private Sub LoadTable()
        Dim Data = EksekusiSQL("SELECT * FROM spp")
        DataGridView1.DataSource = Data
        With DataGridView1
            .Columns("id_spp").HeaderText = "Id SPP"
            .Columns("tahun").HeaderText = "Tahun"
            .Columns("nominal").HeaderText = "Nominal"
        End With

        tb_id_spp.ReadOnly = True
        tb_id_spp.Cursor = System.Windows.Forms.Cursors.No
    End Sub

    Private Sub num_nominal_KeyDown(sender As Object, e As KeyEventArgs) Handles num_nominal.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not String.IsNullOrEmpty(tb_id_spp.Text) Then
                btn_update.PerformClick()
            Else
                btn_create.PerformClick()
            End If
        End If
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
        If (Not String.IsNullOrEmpty(tb_id_spp.Text)) Then
            Try
                If Not String.IsNullOrEmpty(num_tahun.Value) And Not String.IsNullOrEmpty(num_nominal.Value) Then
                    EksekusiSQL("UPDATE spp SET id_spp='" & tb_id_spp.Text & "', tahun='" & num_tahun.Text & "', nominal='" & num_nominal.Text & "' WHERE id_spp='" & tb_id_spp.Text & "' ")
                    btn_back.PerformClick()
                Else
                    MsgBox("Tolong isi seluruh box yang masih kosong!", vbCritical)
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString())
            End Try
        Else
            Try
                If Not String.IsNullOrEmpty(num_tahun.Value) And Not String.IsNullOrEmpty(num_nominal.Value) Then
                    EksekusiSQL("INSERT INTO spp VALUES ('', '" & num_tahun.Value & "', '" & num_nominal.Value & "')")
                    LoadTable()
                    ClearTextBox()
                Else
                    MsgBox("Tolong isi seluruh box yang masih kosong!", vbCritical)
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString())
            End Try
        End If
    End Sub

    Private Sub btn_back_Click_1(sender As Object, e As EventArgs) Handles btn_back.Click
        ClearTextBox()
        tb_id_spp.Text = ""
        tb_id_spp.Text = ""
        LoadTable()
    End Sub

    Private Sub btn_update_Click_1(sender As Object, e As EventArgs) Handles btn_update.Click
        With DataGridView1
            tb_id_spp.Text = .Item(0, .CurrentRow.Index).Value
            num_tahun.Value = .Item(1, .CurrentRow.Index).Value
            num_nominal.Value = .Item(2, .CurrentRow.Index).Value
        End With
    End Sub

    Private Sub btn_delete_Click_1(sender As Object, e As EventArgs) Handles btn_delete.Click
        If String.IsNullOrEmpty(tb_id_spp.Text) Then
            MsgBox("Harap pilih baris yang akan dihapus lalu klik tombol ubah setelah itu tombol hapus", vbCritical)
            Exit Sub
        End If

        Select Case MsgBox("Yakin mau dihapus ?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                Try
                    EksekusiSQL("DELETE FROM spp WHERE id_spp = '" & tb_id_spp.Text & "'")
                    btn_back.PerformClick()
                Catch ex As Exception
                    MsgBox(ex.Message.ToString(), vbCritical)
                End Try
        End Select
    End Sub

    Private Sub SppForm_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
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