Imports BCrypt.Net.BCrypt
Public Class PetugasForm
    Private Sub SppForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        LoadTable()
    End Sub

    Private Sub ClearTextBox()
        tb_username.Text = ""
        tb_password.Text = ""
        tb_nama_petugas.Text = ""
        cmb_level.Text = ""
    End Sub

    Private Sub LoadTable()
        Dim Data = EksekusiSQL("SELECT id_petugas, username, nama_petugas, level FROM petugas")
        DataGridView1.DataSource = Data
        With DataGridView1
            .Columns("id_petugas").HeaderText = "Id Petugas"
            .Columns("username").HeaderText = "Username"
            .Columns("nama_petugas").HeaderText = "Nama Petugas"
            .Columns("level").HeaderText = "Level"
        End With
        tb_id_petugas.ReadOnly = True
        tb_id_petugas.Cursor = System.Windows.Forms.Cursors.No
    End Sub

    Private Sub cmb_level_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If Not String.IsNullOrEmpty(tb_id_petugas.Text) Then
                btn_update.PerformClick()
            Else
                btn_create.PerformClick()
            End If
        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        ClearTextBox()
        tb_id_petugas.Text = ""
        tb_username.Width = 180
        lbl_password.Visible = True
        tb_password.Visible = True
        cmb_level.SelectedIndex = -1
        LoadTable()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If String.IsNullOrEmpty(tb_id_petugas.Text) Then
            MsgBox("Harap pilih baris yang akan dihapus lalu klik tombol ubah setelah itu tombol hapus", vbCritical)
            Exit Sub
        End If

        Select Case MsgBox("Yakin mau dihapus ?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                Try
                    EksekusiSQL("DELETE FROM petugas WHERE id_petugas = '" & tb_id_petugas.Text & "'")
                    btn_back.PerformClick()
                Catch ex As Exception
                    MsgBox(ex.Message.ToString(), vbCritical)
                End Try
        End Select
    End Sub

    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        If (Not String.IsNullOrEmpty(tb_id_petugas.Text)) Then
            Try
                If Not String.IsNullOrEmpty(tb_username.Text) And Not String.IsNullOrEmpty(tb_nama_petugas.Text) And Not String.IsNullOrEmpty(cmb_level.SelectedItem) Then
                    EksekusiSQL("UPDATE petugas SET id_petugas='" & tb_id_petugas.Text & "', username='" & tb_username.Text & "', nama_petugas='" & tb_nama_petugas.Text & "', level='" & cmb_level.SelectedItem & "' WHERE id_petugas='" & tb_id_petugas.Text & "' ")
                    btn_back.PerformClick()
                Else
                    MsgBox("Tolong isi seluruh box yang masih kosong!", vbCritical)
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString())
            End Try
        Else
            Try
                If Not String.IsNullOrEmpty(tb_username.Text) And Not String.IsNullOrEmpty(tb_password.Text) And Not String.IsNullOrEmpty(tb_nama_petugas.Text) And Not String.IsNullOrEmpty(cmb_level.SelectedItem) Then
                    Dim password_hashed As String = HashPassword(tb_password.Text, GenerateSalt())
                    EksekusiSQL("INSERT INTO petugas VALUES ('', '" & tb_username.Text & "', '" & password_hashed & "', '" & tb_nama_petugas.Text & "', '" & cmb_level.SelectedItem & "')")
                    btn_back.PerformClick()
                    ClearTextBox()
                Else
                    MsgBox("Tolong isi seluruh box yang masih kosong!", vbCritical)
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString())
            End Try
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        With DataGridView1
            tb_id_petugas.Text = .Item(0, .CurrentRow.Index).Value
            tb_username.Text = .Item(1, .CurrentRow.Index).Value
            tb_username.Width = 325
            lbl_password.Visible = False
            tb_password.Visible = False
            tb_nama_petugas.Text = .Item(2, .CurrentRow.Index).Value
            cmb_level.Text = .Item(3, .CurrentRow.Index).Value
        End With
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

    Private Sub PetugasForm_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
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