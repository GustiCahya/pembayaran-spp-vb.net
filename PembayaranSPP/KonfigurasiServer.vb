﻿Imports MySql.Data.MySqlClient
Public Class KonfigurasiServer
    Private is_connect = False
    Private Sub KonfigurasiServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_server.Text = My.Settings.server
        tb_userid.Text = My.Settings.userid
        tb_password.Text = My.Settings.password
        tb_database.Text = My.Settings.database
        btn_connect.PerformClick()
    End Sub
    Private Sub btn_connect_Click(sender As Object, e As EventArgs) Handles btn_connect.Click
        Try
            Dim alamat = "server=" & tb_server.Text & "; user id=" & tb_userid.Text & "; password=" & tb_password.Text & "; database=" & tb_database.Text & ""
            Dim Koneksi As New MySqlConnection(alamat)
            If Koneksi.State = ConnectionState.Open Then
                Koneksi.Open()
            Else
                Koneksi.Open()
                Koneksi.Close()
            End If
            lbl_connect.ForeColor = Color.Lime
            lbl_connect.Text = "✓ Connected"
            is_connect = True
        Catch ex As Exception
            lbl_connect.ForeColor = Color.Salmon
            lbl_connect.Text = "✘ Not Connected"
            is_connect = False
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub btn_tutup_Click(sender As Object, e As EventArgs) Handles btn_tutup.Click
        Me.Close()
    End Sub
    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        btn_connect.PerformClick()
        If is_connect <> True Then
            MsgBox("Database Tidak Terkoneksi, Tidak Bisa Menyimpan Konfigurasi", vbCritical)
            Exit Sub
        End If
        My.Settings.alamat = "server = " & tb_server.Text & "; user id=" & tb_userid.Text & "; password = " & tb_password.Text & "; database = " & tb_database.Text
        My.Settings.server = tb_server.Text
        My.Settings.userid = tb_userid.Text
        My.Settings.password = tb_password.Text
        My.Settings.database = tb_database.Text
        My.Settings.Save()
        'Login.Show()
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class