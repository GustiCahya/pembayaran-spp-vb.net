Imports BCrypt.Net.BCrypt
Public Class GantiPasswordForm
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        With tb_userid
            .Text = My.Settings.CurrentId
            .ReadOnly = True
            .Cursor = Cursors.No
        End With
        With tb_username
            .Text = My.Settings.Username
            .ReadOnly = True
            .Cursor = Cursors.No
        End With
    End Sub

    Private Sub btn_tutup_Click(sender As Object, e As EventArgs) Handles btn_tutup.Click
        Me.Close()
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Try
            Dim Password = tb_password.Text
            Dim ConfirmPassword = tb_konfirmasipassword.Text
            Dim OldPassword = tb_passwordlama.Text
            Dim HashedPassword = HashPassword(tb_password.Text, GenerateSalt())
            Dim DbPassword = EksekusiSQL("SELECT password FROM petugas WHERE id_petugas='" & My.Settings.CurrentId & "'").Rows(0)("password")

            If String.IsNullOrEmpty(Password) Or String.IsNullOrEmpty(ConfirmPassword) Or String.IsNullOrEmpty(OldPassword) Then
                MsgBox("Harap isi form yang masih kosong !", vbCritical)
                Exit Sub
            End If

            If Not Verify(OldPassword, DbPassword) Then
                MsgBox("Password Lama Salah !", vbCritical)
                Exit Sub
            End If

            If Password = OldPassword Then
                MsgBox("Tidak Boleh Sama dengan Password Lama Anda !", vbCritical)
                Exit Sub
            End If

            If Password <> ConfirmPassword Then
                MsgBox("Password Baru dan Konfirmasi Password Baru Harus Sama !", vbCritical)
                Exit Sub
            End If

            EksekusiSQL("UPDATE petugas SET password='" & HashedPassword & "' WHERE id_petugas='" & My.Settings.CurrentId & "'")
            MsgBox("Selamat Password Berhasil Diganti !", vbInformation)
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub tb_konfirmasipassword_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_konfirmasipassword.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter
                btn_simpan.PerformClick()
        End Select
    End Sub
End Class