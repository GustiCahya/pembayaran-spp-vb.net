Imports MySql.Data.MySqlClient
Imports BCrypt.Net.BCrypt
Public Class PetugasForm
    Private currentId As String

    Private Sub SppForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
    End Sub

    Private Sub ClearTextBox()
        tb_username.Text = ""
        tb_password.Text = ""
        tb_nama_petugas.Text = ""
        cmb_level.Text = ""
    End Sub

    Private Sub LoadTable()
        da = New MySqlDataAdapter("SELECT id_petugas, username, nama_petugas, level FROM petugas", cn)
        ds = New DataSet()
        da.Fill(ds, "petugas")
        DataGridView1.DataSource = ds.Tables("petugas")
        tb_id_petugas.Text = DataGridView1.RowCount + 1
        tb_id_petugas.ReadOnly = True
        tb_id_petugas.Cursor = System.Windows.Forms.Cursors.No
    End Sub

    Private Sub cmb_level_KeyDown(sender As Object, e As KeyEventArgs)
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

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        ClearTextBox()
        currentId = ""
        tb_username.Width = 180
        lbl_password.Visible = True
        tb_password.Visible = True
        LoadTable()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Select Case MsgBox("Yakin mau dihapus ?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                Try
                    cn.Open()
                    cm = New MySqlCommand("DELETE FROM petugas WHERE id_petugas = @id_petugas", cn)
                    cm.Parameters.AddWithValue("@id_petugas", currentId)
                    cm.ExecuteNonQuery()
                    cn.Close()
                    btn_back.PerformClick()
                Catch ex As Exception
                    cn.Close()
                    MsgBox(ex.Message.ToString(), vbCritical)
                End Try
        End Select
    End Sub

    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        If (Not String.IsNullOrEmpty(currentId)) Then
            Try
                cn.Open()
                If Not String.IsNullOrEmpty(tb_username.Text) And Not String.IsNullOrEmpty(tb_nama_petugas.Text) And Not String.IsNullOrEmpty(cmb_level.SelectedItem) Then
                    cm = New MySqlCommand("UPDATE petugas SET id_petugas=@id_petugas, username=@username, nama_petugas=@nama_petugas, level=@level WHERE id_petugas=@id_petugas ", cn)
                    With cm.Parameters
                        .AddWithValue("@id_petugas", tb_id_petugas.Text)
                        .AddWithValue("@username", tb_username.Text)
                        .AddWithValue("@nama_petugas", tb_nama_petugas.Text)
                        .AddWithValue("@level", cmb_level.SelectedItem)
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
                If Not String.IsNullOrEmpty(tb_username.Text) And Not String.IsNullOrEmpty(tb_password.Text) And Not String.IsNullOrEmpty(tb_nama_petugas.Text) And Not String.IsNullOrEmpty(cmb_level.SelectedItem) Then
                    Dim password_hashed As String = BCrypt.Net.BCrypt.HashPassword(tb_password.Text, BCrypt.Net.BCrypt.GenerateSalt())
                    cm = New MySqlCommand("INSERT INTO petugas VALUES (@id_petugas, @username, @password_hashed, @nama_petugas, @level)", cn)
                    With cm.Parameters
                        .AddWithValue("@id_petugas", tb_id_petugas.Text)
                        .AddWithValue("@username", tb_username.Text)
                        .AddWithValue("@password_hashed", password_hashed)
                        .AddWithValue("@nama_petugas", tb_nama_petugas.Text)
                        .AddWithValue("@level", cmb_level.SelectedItem)
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

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        With DataGridView1
            tb_id_petugas.Text = currentId
            tb_username.Text = .Item(1, .CurrentRow.Index).Value
            tb_username.Width = 325
            lbl_password.Visible = False
            tb_password.Visible = False
            tb_nama_petugas.Text = .Item(2, .CurrentRow.Index).Value
            cmb_level.Text = .Item(3, .CurrentRow.Index).Value
        End With
        tb_id_petugas.ReadOnly = False
        tb_id_petugas.Cursor = System.Windows.Forms.Cursors.IBeam
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