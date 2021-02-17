<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GantiPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PetugasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KelasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SPPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembayaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoriPembayaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RekapitulasiPembayaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengaturanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KonfigurasiServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KonfigurasiSistemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangAplikasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.PengaturanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1022, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GantiPasswordToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(50, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'GantiPasswordToolStripMenuItem
        '
        Me.GantiPasswordToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray
        Me.GantiPasswordToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GantiPasswordToolStripMenuItem.Name = "GantiPasswordToolStripMenuItem"
        Me.GantiPasswordToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.GantiPasswordToolStripMenuItem.Text = "Ganti Password"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LogoutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray
        Me.KeluarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PetugasToolStripMenuItem, Me.KelasToolStripMenuItem, Me.SPPToolStripMenuItem, Me.SiswaToolStripMenuItem})
        Me.MasterToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(78, 29)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'PetugasToolStripMenuItem
        '
        Me.PetugasToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PetugasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PetugasToolStripMenuItem.Name = "PetugasToolStripMenuItem"
        Me.PetugasToolStripMenuItem.Size = New System.Drawing.Size(158, 30)
        Me.PetugasToolStripMenuItem.Text = "Petugas"
        '
        'KelasToolStripMenuItem
        '
        Me.KelasToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray
        Me.KelasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.KelasToolStripMenuItem.Name = "KelasToolStripMenuItem"
        Me.KelasToolStripMenuItem.Size = New System.Drawing.Size(158, 30)
        Me.KelasToolStripMenuItem.Text = "Kelas"
        '
        'SPPToolStripMenuItem
        '
        Me.SPPToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray
        Me.SPPToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SPPToolStripMenuItem.Name = "SPPToolStripMenuItem"
        Me.SPPToolStripMenuItem.Size = New System.Drawing.Size(158, 30)
        Me.SPPToolStripMenuItem.Text = "SPP"
        '
        'SiswaToolStripMenuItem
        '
        Me.SiswaToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray
        Me.SiswaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SiswaToolStripMenuItem.Name = "SiswaToolStripMenuItem"
        Me.SiswaToolStripMenuItem.Size = New System.Drawing.Size(158, 30)
        Me.SiswaToolStripMenuItem.Text = "Siswa"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PembayaranToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(94, 29)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PembayaranToolStripMenuItem
        '
        Me.PembayaranToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PembayaranToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PembayaranToolStripMenuItem.Name = "PembayaranToolStripMenuItem"
        Me.PembayaranToolStripMenuItem.Size = New System.Drawing.Size(193, 30)
        Me.PembayaranToolStripMenuItem.Text = "Pembayaran"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistoriPembayaranToolStripMenuItem, Me.RekapitulasiPembayaranToolStripMenuItem})
        Me.LaporanToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(88, 29)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'HistoriPembayaranToolStripMenuItem
        '
        Me.HistoriPembayaranToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray
        Me.HistoriPembayaranToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.HistoriPembayaranToolStripMenuItem.Name = "HistoriPembayaranToolStripMenuItem"
        Me.HistoriPembayaranToolStripMenuItem.Size = New System.Drawing.Size(291, 30)
        Me.HistoriPembayaranToolStripMenuItem.Text = "Histori Pembayaran"
        '
        'RekapitulasiPembayaranToolStripMenuItem
        '
        Me.RekapitulasiPembayaranToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray
        Me.RekapitulasiPembayaranToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RekapitulasiPembayaranToolStripMenuItem.Name = "RekapitulasiPembayaranToolStripMenuItem"
        Me.RekapitulasiPembayaranToolStripMenuItem.Size = New System.Drawing.Size(291, 30)
        Me.RekapitulasiPembayaranToolStripMenuItem.Text = "Rekapitulasi Pembayaran"
        '
        'PengaturanToolStripMenuItem
        '
        Me.PengaturanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KonfigurasiServerToolStripMenuItem, Me.KonfigurasiSistemToolStripMenuItem, Me.TentangAplikasiToolStripMenuItem})
        Me.PengaturanToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PengaturanToolStripMenuItem.Name = "PengaturanToolStripMenuItem"
        Me.PengaturanToolStripMenuItem.Size = New System.Drawing.Size(113, 29)
        Me.PengaturanToolStripMenuItem.Text = "Pengaturan"
        '
        'KonfigurasiServerToolStripMenuItem
        '
        Me.KonfigurasiServerToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray
        Me.KonfigurasiServerToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.KonfigurasiServerToolStripMenuItem.Name = "KonfigurasiServerToolStripMenuItem"
        Me.KonfigurasiServerToolStripMenuItem.Size = New System.Drawing.Size(243, 30)
        Me.KonfigurasiServerToolStripMenuItem.Text = "Konfigurasi Server"
        '
        'KonfigurasiSistemToolStripMenuItem
        '
        Me.KonfigurasiSistemToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray
        Me.KonfigurasiSistemToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.KonfigurasiSistemToolStripMenuItem.Name = "KonfigurasiSistemToolStripMenuItem"
        Me.KonfigurasiSistemToolStripMenuItem.Size = New System.Drawing.Size(243, 30)
        Me.KonfigurasiSistemToolStripMenuItem.Text = "Konfigurasi Sistem"
        '
        'TentangAplikasiToolStripMenuItem
        '
        Me.TentangAplikasiToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray
        Me.TentangAplikasiToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TentangAplikasiToolStripMenuItem.Name = "TentangAplikasiToolStripMenuItem"
        Me.TentangAplikasiToolStripMenuItem.Size = New System.Drawing.Size(243, 30)
        Me.TentangAplikasiToolStripMenuItem.Text = "Tentang Aplikasi"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 617)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1022, 30)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(60, 25)
        Me.ToolStripStatusLabel1.Text = "Ready"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(217, 25)
        Me.ToolStripStatusLabel2.Text = "Akses: ??? | Pengguna: ???"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(275, 25)
        Me.ToolStripStatusLabel3.Text = "Jam 08:06, Rabu, 20 Januari 2021"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1022, 647)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuUtama"
        Me.Text = "Aplikasi Pembayaran SPP"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengaturanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents KonfigurasiServerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PembayaranToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PetugasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KelasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SPPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SiswaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoriPembayaranToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GantiPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RekapitulasiPembayaranToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KonfigurasiSistemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TentangAplikasiToolStripMenuItem As ToolStripMenuItem
End Class
