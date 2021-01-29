Imports MySql.Data.MySqlClient
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
                Connection()
                cn.Open()
                cm = New MySqlCommand("SELECT * FROM petugas WHERE username = @username ", cn)
                cm.Parameters.AddWithValue("@username", tb_username.Text)
                dr = cm.ExecuteReader()
                dr.Read()
                If dr.HasRows() Then
                    Dim output_id_petugas As String = dr(0).ToString()
                    Dim output_username As String = dr(1).ToString()
                    Dim output_password As String = dr(2).ToString()
                    Dim output_role As String = dr(4).ToString()
                    Dim isPasswordValid As Boolean = BCrypt.Net.BCrypt.Verify(password, output_password)
                    If isPasswordValid Then
                        MenuUtama.currentId = output_id_petugas
                        MenuUtama.username = output_username
                        MenuUtama.role = output_role
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
                dr.Close()
                cn.Close()
            Catch ex As Exception
                cn.Close()
                MsgBox(ex.Message.ToString())
            End Try
        Else
            Dim nisn As String = tb_username.Text
            Dim nis As String = tb_password.Text
            Try
                Connection()
                cn.Open()
                cm = New MySqlCommand("SELECT * FROM siswa WHERE nisn = @nisn AND nis = @nis ", cn)
                cm.Parameters.AddWithValue("@nisn", nisn)
                cm.Parameters.AddWithValue("@nis", nis)
                dr = cm.ExecuteReader()
                dr.Read()
                If dr.HasRows() Then
                    Dim output_nisn As String = dr(0).ToString()
                    Dim output_nis As String = dr(1).ToString()
                    Dim output_nama As String = dr(2).ToString()
                    If nisn.Equals(output_nisn) And nis.Equals(output_nis) Then
                        MenuUtama.currentId = output_nisn
                        MenuUtama.username = output_nama
                        MenuUtama.role = "siswa"
                        Clear()
                        cn.Close()
                        MenuUtama.Show()
                        Me.Close()
                    Else
                        MsgBox("NISN atau NIS Salah!", vbCritical)
                    End If
                Else
                    tb_username.Select()
                    MsgBox("NISN dan NIS Salah! ", vbCritical)
                End If
                dr.Close()
                cn.Close()
            Catch ex As Exception
                cn.Close()
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
