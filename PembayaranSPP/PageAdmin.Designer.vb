<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PageAdmin
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PageAdmin))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btn_riwayat = New System.Windows.Forms.Button()
        Me.btn_transaksi = New System.Windows.Forms.Button()
        Me.btn_spp = New System.Windows.Forms.Button()
        Me.btn_kelas = New System.Windows.Forms.Button()
        Me.btn_petugas = New System.Windows.Forms.Button()
        Me.btn_siswa = New System.Windows.Forms.Button()
        Me.PanelMenuHeader = New System.Windows.Forms.Panel()
        Me.lbl_role = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelShow = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelMenu.SuspendLayout()
        Me.PanelMenuHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btn_riwayat)
        Me.PanelMenu.Controls.Add(Me.btn_transaksi)
        Me.PanelMenu.Controls.Add(Me.btn_spp)
        Me.PanelMenu.Controls.Add(Me.btn_kelas)
        Me.PanelMenu.Controls.Add(Me.btn_petugas)
        Me.PanelMenu.Controls.Add(Me.btn_siswa)
        Me.PanelMenu.Controls.Add(Me.PanelMenuHeader)
        Me.PanelMenu.Location = New System.Drawing.Point(0, 3)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(200, 453)
        Me.PanelMenu.TabIndex = 0
        '
        'btn_riwayat
        '
        Me.btn_riwayat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_riwayat.FlatAppearance.BorderSize = 0
        Me.btn_riwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_riwayat.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btn_riwayat.ForeColor = System.Drawing.Color.White
        Me.btn_riwayat.Location = New System.Drawing.Point(0, 165)
        Me.btn_riwayat.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_riwayat.Name = "btn_riwayat"
        Me.btn_riwayat.Size = New System.Drawing.Size(200, 50)
        Me.btn_riwayat.TabIndex = 9
        Me.btn_riwayat.Text = "Riwayat"
        Me.btn_riwayat.UseVisualStyleBackColor = True
        '
        'btn_transaksi
        '
        Me.btn_transaksi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_transaksi.FlatAppearance.BorderSize = 0
        Me.btn_transaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_transaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btn_transaksi.ForeColor = System.Drawing.Color.White
        Me.btn_transaksi.Location = New System.Drawing.Point(0, 115)
        Me.btn_transaksi.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_transaksi.Name = "btn_transaksi"
        Me.btn_transaksi.Size = New System.Drawing.Size(200, 50)
        Me.btn_transaksi.TabIndex = 8
        Me.btn_transaksi.Text = "Transaksi"
        Me.btn_transaksi.UseVisualStyleBackColor = True
        '
        'btn_spp
        '
        Me.btn_spp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_spp.FlatAppearance.BorderSize = 0
        Me.btn_spp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_spp.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btn_spp.ForeColor = System.Drawing.Color.White
        Me.btn_spp.Location = New System.Drawing.Point(0, 362)
        Me.btn_spp.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_spp.Name = "btn_spp"
        Me.btn_spp.Size = New System.Drawing.Size(200, 50)
        Me.btn_spp.TabIndex = 5
        Me.btn_spp.Text = "SPP"
        Me.btn_spp.UseVisualStyleBackColor = True
        '
        'btn_kelas
        '
        Me.btn_kelas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_kelas.FlatAppearance.BorderSize = 0
        Me.btn_kelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_kelas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btn_kelas.ForeColor = System.Drawing.Color.White
        Me.btn_kelas.Location = New System.Drawing.Point(0, 312)
        Me.btn_kelas.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_kelas.Name = "btn_kelas"
        Me.btn_kelas.Size = New System.Drawing.Size(200, 50)
        Me.btn_kelas.TabIndex = 4
        Me.btn_kelas.Text = "Kelas"
        Me.btn_kelas.UseVisualStyleBackColor = True
        '
        'btn_petugas
        '
        Me.btn_petugas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_petugas.FlatAppearance.BorderSize = 0
        Me.btn_petugas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_petugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btn_petugas.ForeColor = System.Drawing.Color.White
        Me.btn_petugas.Location = New System.Drawing.Point(0, 265)
        Me.btn_petugas.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_petugas.Name = "btn_petugas"
        Me.btn_petugas.Size = New System.Drawing.Size(200, 50)
        Me.btn_petugas.TabIndex = 3
        Me.btn_petugas.Text = "Petugas"
        Me.btn_petugas.UseVisualStyleBackColor = True
        '
        'btn_siswa
        '
        Me.btn_siswa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_siswa.FlatAppearance.BorderSize = 0
        Me.btn_siswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_siswa.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btn_siswa.ForeColor = System.Drawing.Color.White
        Me.btn_siswa.Location = New System.Drawing.Point(0, 215)
        Me.btn_siswa.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_siswa.Name = "btn_siswa"
        Me.btn_siswa.Size = New System.Drawing.Size(200, 50)
        Me.btn_siswa.TabIndex = 2
        Me.btn_siswa.Text = "Siswa"
        Me.btn_siswa.UseVisualStyleBackColor = True
        '
        'PanelMenuHeader
        '
        Me.PanelMenuHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelMenuHeader.Controls.Add(Me.lbl_role)
        Me.PanelMenuHeader.Controls.Add(Me.lbl_name)
        Me.PanelMenuHeader.Controls.Add(Me.PictureBox1)
        Me.PanelMenuHeader.ForeColor = System.Drawing.Color.White
        Me.PanelMenuHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenuHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelMenuHeader.Name = "PanelMenuHeader"
        Me.PanelMenuHeader.Size = New System.Drawing.Size(200, 109)
        Me.PanelMenuHeader.TabIndex = 2
        '
        'lbl_role
        '
        Me.lbl_role.AutoSize = True
        Me.lbl_role.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_role.Location = New System.Drawing.Point(64, 60)
        Me.lbl_role.Name = "lbl_role"
        Me.lbl_role.Size = New System.Drawing.Size(93, 17)
        Me.lbl_role.TabIndex = 1
        Me.lbl_role.Text = "Role: ______"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lbl_name.Location = New System.Drawing.Point(61, 39)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(135, 22)
        Me.lbl_name.TabIndex = 0
        Me.lbl_name.Text = "______ ______"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelShow
        '
        Me.PanelShow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelShow.Location = New System.Drawing.Point(200, 42)
        Me.PanelShow.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelShow.Name = "PanelShow"
        Me.PanelShow.Size = New System.Drawing.Size(600, 414)
        Me.PanelShow.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Crimson
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(206, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PageAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PanelShow)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "PageAdmin"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenuHeader.ResumeLayout(False)
        Me.PanelMenuHeader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btn_siswa As Button
    Friend WithEvents PanelMenuHeader As Panel
    Friend WithEvents PanelShow As Panel
    Friend WithEvents btn_spp As Button
    Friend WithEvents btn_kelas As Button
    Friend WithEvents btn_petugas As Button
    Friend WithEvents btn_riwayat As Button
    Friend WithEvents btn_transaksi As Button
    Friend WithEvents lbl_role As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
