Public Class PageAdmin

    Public username As String
    Public role As String
    Public currentId As String

    Public Sub FormPanel(ByVal CurrentForm As Object)
        If Me.PanelShow.Controls.Count > 0 Then
            Me.PanelShow.Controls.RemoveAt(0)
        End If
        Dim cf As Form = TryCast(CurrentForm, Form)
        cf.TopLevel = False
        cf.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        cf.Dock = DockStyle.Fill
        cf.BackColor = Color.White
        Me.PanelShow.Controls.Add(cf)
        Me.PanelShow.Tag = cf
        cf.Show()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_siswa_Click(sender As Object, e As EventArgs) Handles btn_siswa.Click
        FormPanel(SiswaForm)
    End Sub

    Private Sub btn_petugas_Click(sender As Object, e As EventArgs) Handles btn_petugas.Click
        FormPanel(PetugasForm)
    End Sub

    Private Sub btn_kelas_Click(sender As Object, e As EventArgs) Handles btn_kelas.Click
        FormPanel(KelasForm)
    End Sub

    Private Sub btn_spp_Click(sender As Object, e As EventArgs) Handles btn_spp.Click
        FormPanel(SppForm)
    End Sub

    Private Sub btn_transaksi_Click(sender As Object, e As EventArgs) Handles btn_transaksi.Click
        FormPanel(TransaksiForm)
    End Sub

    Private Sub btn_riwayat_Click(sender As Object, e As EventArgs) Handles btn_riwayat.Click
        FormPanel(RiwayatForm)
    End Sub

    Private Sub PageAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_transaksi.Select()
        lbl_name.Text = Capitalize(username)
        lbl_role.Text = "Role: " & role
        Select Case role
            Case "admin"
                FormPanel(New TransaksiForm)
            Case "petugas"
                FormPanel(New TransaksiForm)
                btn_siswa.Visible = False
                btn_petugas.Visible = False
                btn_kelas.Visible = False
                btn_spp.Visible = False
            Case Else
                FormPanel(New RiwayatForm)
                btn_siswa.Visible = False
                btn_petugas.Visible = False
                btn_kelas.Visible = False
                btn_spp.Visible = False
                btn_transaksi.Visible = False
                btn_riwayat.Location = New System.Drawing.Point(0, 115)
        End Select
    End Sub

    Private Function Capitalize(ByVal Text As String) As String
        If Text.Length > 1 Then
            Return Text.Substring(0, 1).ToUpper() + Text.Substring(1)
        ElseIf Text.Length = 1 Then
            Return Text.ToUpper()
        End If
    End Function

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Login.Show()
        Me.Close()
        Me.username = ""
        Me.role = ""
    End Sub

    Private Sub PanelShow_Paint(sender As Object, e As PaintEventArgs) Handles PanelShow.Paint

    End Sub
End Class