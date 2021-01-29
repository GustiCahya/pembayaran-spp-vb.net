Public Class MenuUtama

    Public username As String
    Public role As String
    Public currentId As String

    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Handle Window state
        Me.WindowState = WindowState.Maximized

        'btn_transaksi.Select()
        ToolStripStatusLabel2.Text = "Akses: " & role & " | Pengguna: " & username & ""
        Select Case role
            Case "admin"
                PembayaranToolStripMenuItem.PerformClick()
                OnOffMenu(True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True)
            Case "petugas"
                PembayaranToolStripMenuItem.PerformClick()
                OnOffMenu(True, True, True, True, False, False, False, False, False, True, True, True, True, True, False, False, False, False)
            Case Else
                HistoriPembayaranToolStripMenuItem.PerformClick()
                OnOffMenu(True, True, True, True, False, False, False, False, False, False, False, True, True, False, False, False, False, True)
        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel3.Text = "Jam " & Format(Now(), "HH:mm") & ", " & Format(Now(), "dddd, dd MMMM yyyy") & ""
    End Sub

    Private Sub PetugasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PetugasToolStripMenuItem.Click
        With PetugasForm
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub KelasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KelasToolStripMenuItem.Click
        With KelasForm
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub SPPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SPPToolStripMenuItem.Click
        With SppForm
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub SiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SiswaToolStripMenuItem.Click
        With SiswaForm
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub PembayaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembayaranToolStripMenuItem.Click
        With TransaksiForm
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub HistoriPembayaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoriPembayaranToolStripMenuItem.Click
        With RiwayatForm
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .LoadTable()
            .Show()
        End With
    End Sub

    Private Sub KonfigurasiServerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KonfigurasiServerToolStripMenuItem.Click
        With KonfigurasiServer
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Login.Show()
        Me.Close()
        Me.username = ""
        Me.role = ""
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Application.Exit()
    End Sub


End Class