Imports MySql.Data.MySqlClient
Public Class SppForm

    Private currentId As String

    Private Sub SppForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
    End Sub

    Private Sub ClearTextBox()
        tb_tahun.Text = ""
        tb_nominal.Text = ""
    End Sub

    Private Sub LoadTable()
        da = New MySqlDataAdapter("SELECT * FROM spp", cn)
        ds = New DataSet()
        da.Fill(ds, "spp")
        DataGridView1.DataSource = ds.Tables("spp")
        tb_id_spp.Text = DataGridView1.RowCount + 1
        tb_id_spp.ReadOnly = True
        tb_id_spp.Cursor = System.Windows.Forms.Cursors.No
    End Sub

    Private Sub tb_nominal_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_nominal.KeyDown
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
            tb_id_spp.Text = currentId
            tb_tahun.Text = .Item(1, .CurrentRow.Index).Value
            tb_nominal.Text = .Item(2, .CurrentRow.Index).Value
        End With
        tb_id_spp.ReadOnly = False
        tb_id_spp.Cursor = System.Windows.Forms.Cursors.IBeam
        btn_create.Visible = False
        btn_update.Visible = True
        btn_delete.Visible = True
        btn_back.Visible = True
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        ClearTextBox()
        currentId = ""
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
                    cm = New MySqlCommand("DELETE FROM spp WHERE id_spp = @id_spp", cn)
                    cm.Parameters.AddWithValue("@id_spp", currentId)
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
        Try
            cn.Open()
            If Not String.IsNullOrEmpty(tb_tahun.Text) And Not String.IsNullOrEmpty(tb_nominal.Text) Then
                cm = New MySqlCommand("INSERT INTO spp VALUES (@id_spp, @tahun, @nominal)", cn)
                cm.Parameters.AddWithValue("@id_spp", tb_id_spp.Text)
                cm.Parameters.AddWithValue("@tahun", tb_tahun.Text)
                cm.Parameters.AddWithValue("@nominal", tb_nominal.Text)
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
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            cn.Open()
            If Not String.IsNullOrEmpty(tb_tahun.Text) And Not String.IsNullOrEmpty(tb_nominal.Text) Then
                cm = New MySqlCommand("UPDATE spp SET id_spp=@id_spp, tahun=@tahun, nominal=@nominal WHERE id_spp=@id_spp ", cn)
                cm.Parameters.AddWithValue("@id_spp", tb_id_spp.Text)
                cm.Parameters.AddWithValue("@tahun", tb_tahun.Text)
                cm.Parameters.AddWithValue("@nominal", tb_nominal.Text)
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
    End Sub
End Class