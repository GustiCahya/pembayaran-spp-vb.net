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
        With DataGridView1
            currentId = .Item(0, .CurrentRow.Index).Value
            tb_username.Text = .Item(1, .CurrentRow.Index).Value
            tb_username.Width = 325
            lbl_password.Visible = False
            tb_password.Visible = False
            tb_nama_petugas.Text = .Item(2, .CurrentRow.Index).Value
            cmb_level.Text = .Item(3, .CurrentRow.Index).Value
        End With
        btn_create.Visible = False
        btn_update.Visible = True
        btn_delete.Visible = True
        btn_back.Visible = True
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        ClearTextBox()
        currentId = ""
        tb_username.Width = 180
        lbl_password.Visible = True
        tb_password.Visible = True
        btn_create.Visible = True
        btn_update.Visible = False
        btn_delete.Visible = False
        btn_back.Visible = False
        LoadTable()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Select Case MsgBox("Yakin mau dihapus ?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                Try
                    cn.Open()
                    cm = New MySqlCommand("DELETE FROM petugas WHERE id_petugas = '" & currentId & "'", cn)
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
            If Not String.IsNullOrEmpty(tb_username.Text) And Not String.IsNullOrEmpty(tb_password.Text) And Not String.IsNullOrEmpty(tb_nama_petugas.Text) And Not String.IsNullOrEmpty(cmb_level.SelectedItem) Then
                Dim password_hashed As String = BCrypt.Net.BCrypt.HashPassword(tb_password.Text, BCrypt.Net.BCrypt.GenerateSalt())
                cm = New MySqlCommand("INSERT INTO petugas VALUES ('" & DataGridView1.RowCount + 1 & "', '" & tb_username.Text & "','" & password_hashed & "', '" & tb_nama_petugas.Text & "', '" & cmb_level.SelectedItem & "')", cn)
                cm.ExecuteNonQuery()
                LoadTable()
                ClearTextBox()
            Else
                MsgBox("Tolong isi seluruh box yang masih kosong!", vbCritical)
            End If
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            cn.Open()
            If Not String.IsNullOrEmpty(tb_username.Text) And Not String.IsNullOrEmpty(tb_nama_petugas.Text) And Not String.IsNullOrEmpty(cmb_level.SelectedItem) Then
                cm = New MySqlCommand("UPDATE petugas SET username='" & tb_username.Text & "', nama_petugas='" & tb_nama_petugas.Text & "', level='" & cmb_level.SelectedItem & "' WHERE id_petugas='" & currentId & "' ", cn)
                cm.ExecuteNonQuery()
                btn_back.PerformClick()
            Else
                MsgBox("Tolong isi seluruh box yang masih kosong!", vbCritical)
            End If
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.ToString())
        End Try
    End Sub

End Class