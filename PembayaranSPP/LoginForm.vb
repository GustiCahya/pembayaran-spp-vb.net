Imports BCrypt.Net.BCrypt
Public Class Login
    Private isSiswa As Boolean

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        isSiswa = False
        tb_username.Focus()
    End Sub

    Private Sub cb_showpassword_CheckedChanged(sender As Object, e As EventArgs) Handles cb_showpassword.CheckedChanged
        If tb_password.UseSystemPasswordChar = True Then
            tb_password.UseSystemPasswordChar = False
            tb_password.PasswordChar = ""
        Else
            tb_password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub tb_password_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_login.PerformClick()
        End If
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If Not isSiswa Then
            Dim username As String = tb_username.Text
            Dim password As String = tb_password.Text
            Try
                Dim Data = EksekusiSQL("SELECT * FROM petugas WHERE username = '" & tb_username.Text & "' ")
                If Data.Rows.Count >= 1 Then
                    Dim output_id_petugas As String = Data.Rows(0).Item(0).ToString()
                    Dim output_username As String = Data.Rows(0).Item(1).ToString()
                    Dim output_password As String = Data.Rows(0).Item(2).ToString()
                    Dim output_role As String = Data.Rows(0).Item(4).ToString()
                    Dim isPasswordValid As Boolean = BCrypt.Net.BCrypt.Verify(password, output_password)
                    If isPasswordValid Then
                        My.Settings.CurrentId = output_id_petugas
                        My.Settings.Username = output_username
                        My.Settings.Role = output_role
                        Clear()
                        MenuUtama.Show()
                        Me.Close()
                    Else
                        MsgBox("Username atau Password Salah!", vbCritical)
                    End If
                Else
                    tb_username.Select()
                    MsgBox("Username dan Password Salah! ", vbCritical)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                If MessageBox.Show("Koneksi ke Server Gagal, Tekan Yes untuk Konfigurasi Server",
                   "Koneksi Ke Server Gagal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    KonfigurasiServer.ShowDialog()
                End If
            End Try
        Else
            Dim nisn As String = tb_username.Text
            Dim nis As String = tb_password.Text
            Try
                Dim Data = EksekusiSQL("SELECT * FROM siswa WHERE nisn = '" & nisn & "' AND nis = '" & nis & "' ")
                If Data.Rows.Count >= 1 Then
                    Dim output_nisn As String = Data.Rows(0).Item(0).ToString()
                    Dim output_nis As String = Data.Rows(0).Item(1).ToString()
                    Dim output_nama As String = Data.Rows(0).Item(2).ToString()
                    If nisn.Equals(output_nisn) And nis.Equals(output_nis) Then
                        My.Settings.CurrentId = output_nisn
                        My.Settings.Username = output_nama
                        My.Settings.Role = "siswa"
                        Clear()
                        MenuUtama.Show()
                        Me.Close()
                    Else
                        MsgBox("NISN atau NIS Salah!", vbCritical)
                    End If
                Else
                    tb_username.Select()
                    MsgBox("NISN dan NIS Salah! ", vbCritical)
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString())
            End Try
        End If

    End Sub

    Private Sub Clear()
        tb_username.Text = ""
        tb_password.Text = ""
    End Sub

    Private Sub lbl_login_siswa_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_login_siswa.LinkClicked
        If Not isSiswa Then
            isSiswa = True
            lbl_username.Text = "NISN"
            lbl_password.Text = "NIS"
            lbl_role.Text = "SISWA"
            lbl_login_siswa.Text = "Login Sebagai Petugas"
            Clear()
        Else
            isSiswa = False
            lbl_username.Text = "Username"
            lbl_password.Text = "Password"
            lbl_role.Text = "PETUGAS"
            lbl_login_siswa.Text = "Login Sebagai Siswa"
            Clear()
        End If
    End Sub

    Private Sub Login_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
            Case Keys.Enter
                btn_login.PerformClick()
        End Select
    End Sub
End Class
