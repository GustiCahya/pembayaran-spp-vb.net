<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TransaksiForm
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransaksiForm))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_petugas = New System.Windows.Forms.ComboBox()
        Me.dtp_tanggal = New System.Windows.Forms.DateTimePicker()
        Me.lbl_nama_siswa = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_petugas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nisn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bulan_dibayar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tahun_dibayar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_spp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah_bayar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl_bayar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_send = New System.Windows.Forms.Button()
        Me.num_jumlah_bayar = New System.Windows.Forms.NumericUpDown()
        Me.btn_tutup = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_nama_kelas = New System.Windows.Forms.Label()
        Me.tb_nisn = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_refresh = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_jumlah_bayar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 164)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 20)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Pilih Bulan dan Tahun"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(327, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 20)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "NISN Siswa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 96)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Petugas"
        '
        'btn_add
        '
        Me.btn_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_add.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.FlatAppearance.BorderSize = 0
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btn_add.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_add.Location = New System.Drawing.Point(13, 491)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(175, 54)
        Me.btn_add.TabIndex = 45
        Me.btn_add.Text = "➕Tambah"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(327, 163)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 20)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Jumlah Bayar"
        '
        'cmb_petugas
        '
        Me.cmb_petugas.Cursor = System.Windows.Forms.Cursors.No
        Me.cmb_petugas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_petugas.Enabled = False
        Me.cmb_petugas.FormattingEnabled = True
        Me.cmb_petugas.Location = New System.Drawing.Point(17, 125)
        Me.cmb_petugas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmb_petugas.Name = "cmb_petugas"
        Me.cmb_petugas.Size = New System.Drawing.Size(302, 28)
        Me.cmb_petugas.TabIndex = 42
        '
        'dtp_tanggal
        '
        Me.dtp_tanggal.CustomFormat = "MMMM yyyy"
        Me.dtp_tanggal.Location = New System.Drawing.Point(17, 190)
        Me.dtp_tanggal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtp_tanggal.Name = "dtp_tanggal"
        Me.dtp_tanggal.Size = New System.Drawing.Size(302, 26)
        Me.dtp_tanggal.TabIndex = 44
        '
        'lbl_nama_siswa
        '
        Me.lbl_nama_siswa.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.lbl_nama_siswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_nama_siswa.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_nama_siswa.Location = New System.Drawing.Point(636, 124)
        Me.lbl_nama_siswa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nama_siswa.Name = "lbl_nama_siswa"
        Me.lbl_nama_siswa.Padding = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.lbl_nama_siswa.Size = New System.Drawing.Size(210, 32)
        Me.lbl_nama_siswa.TabIndex = 48
        Me.lbl_nama_siswa.Text = "Nama"
        Me.lbl_nama_siswa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.id_petugas, Me.nisn, Me.bulan_dibayar, Me.tahun_dibayar, Me.id_spp, Me.jumlah_bayar, Me.tgl_bayar})
        Me.DataGridView1.Location = New System.Drawing.Point(-15, 233)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 25
        Me.DataGridView1.Size = New System.Drawing.Size(903, 247)
        Me.DataGridView1.TabIndex = 49
        '
        'no
        '
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 30
        '
        'id_petugas
        '
        Me.id_petugas.HeaderText = "id_petugas"
        Me.id_petugas.Name = "id_petugas"
        Me.id_petugas.ReadOnly = True
        Me.id_petugas.Visible = False
        '
        'nisn
        '
        Me.nisn.HeaderText = "NISN"
        Me.nisn.Name = "nisn"
        Me.nisn.ReadOnly = True
        '
        'bulan_dibayar
        '
        Me.bulan_dibayar.HeaderText = "Bulan"
        Me.bulan_dibayar.Name = "bulan_dibayar"
        Me.bulan_dibayar.ReadOnly = True
        '
        'tahun_dibayar
        '
        Me.tahun_dibayar.HeaderText = "Tahun"
        Me.tahun_dibayar.Name = "tahun_dibayar"
        Me.tahun_dibayar.ReadOnly = True
        '
        'id_spp
        '
        Me.id_spp.HeaderText = "id_spp"
        Me.id_spp.Name = "id_spp"
        Me.id_spp.ReadOnly = True
        Me.id_spp.Visible = False
        '
        'jumlah_bayar
        '
        Me.jumlah_bayar.HeaderText = "Jumlah Bayar"
        Me.jumlah_bayar.Name = "jumlah_bayar"
        Me.jumlah_bayar.ReadOnly = True
        '
        'tgl_bayar
        '
        Me.tgl_bayar.HeaderText = "Tanggal Bayar"
        Me.tgl_bayar.Name = "tgl_bayar"
        Me.tgl_bayar.ReadOnly = True
        '
        'btn_send
        '
        Me.btn_send.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_send.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_send.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_send.FlatAppearance.BorderSize = 0
        Me.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_send.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btn_send.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_send.Image = CType(resources.GetObject("btn_send.Image"), System.Drawing.Image)
        Me.btn_send.Location = New System.Drawing.Point(201, 493)
        Me.btn_send.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(137, 53)
        Me.btn_send.TabIndex = 50
        Me.btn_send.Text = "Kirim"
        Me.btn_send.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_send.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_send.UseVisualStyleBackColor = False
        '
        'num_jumlah_bayar
        '
        Me.num_jumlah_bayar.Cursor = System.Windows.Forms.Cursors.No
        Me.num_jumlah_bayar.Enabled = False
        Me.num_jumlah_bayar.InterceptArrowKeys = False
        Me.num_jumlah_bayar.Location = New System.Drawing.Point(332, 190)
        Me.num_jumlah_bayar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.num_jumlah_bayar.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.num_jumlah_bayar.Name = "num_jumlah_bayar"
        Me.num_jumlah_bayar.ReadOnly = True
        Me.num_jumlah_bayar.Size = New System.Drawing.Size(296, 26)
        Me.num_jumlah_bayar.TabIndex = 53
        '
        'btn_tutup
        '
        Me.btn_tutup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_tutup.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_tutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_tutup.FlatAppearance.BorderSize = 0
        Me.btn_tutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tutup.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_tutup.Image = CType(resources.GetObject("btn_tutup.Image"), System.Drawing.Image)
        Me.btn_tutup.Location = New System.Drawing.Point(649, 490)
        Me.btn_tutup.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_tutup.Name = "btn_tutup"
        Me.btn_tutup.Size = New System.Drawing.Size(147, 54)
        Me.btn_tutup.TabIndex = 58
        Me.btn_tutup.Text = "Tutup"
        Me.btn_tutup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_tutup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_tutup.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_delete.BackColor = System.Drawing.Color.Crimson
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.FlatAppearance.BorderSize = 0
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btn_delete.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_delete.Image = CType(resources.GetObject("btn_delete.Image"), System.Drawing.Image)
        Me.btn_delete.Location = New System.Drawing.Point(504, 490)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(137, 53)
        Me.btn_delete.TabIndex = 57
        Me.btn_delete.Text = "Hapus"
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(93, 24)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(561, 58)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Transaksi Pembayaran"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_nama_kelas
        '
        Me.lbl_nama_kelas.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.lbl_nama_kelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_nama_kelas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_nama_kelas.Location = New System.Drawing.Point(636, 184)
        Me.lbl_nama_kelas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nama_kelas.Name = "lbl_nama_kelas"
        Me.lbl_nama_kelas.Padding = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.lbl_nama_kelas.Size = New System.Drawing.Size(210, 32)
        Me.lbl_nama_kelas.TabIndex = 61
        Me.lbl_nama_kelas.Text = "Kelas"
        Me.lbl_nama_kelas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_nisn
        '
        Me.tb_nisn.Location = New System.Drawing.Point(331, 127)
        Me.tb_nisn.Name = "tb_nisn"
        Me.tb_nisn.Size = New System.Drawing.Size(188, 26)
        Me.tb_nisn.TabIndex = 62
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.Color.DarkOrange
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnCari.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCari.Image = CType(resources.GetObject("btnCari.Image"), System.Drawing.Image)
        Me.btnCari.Location = New System.Drawing.Point(525, 110)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(104, 50)
        Me.btnCari.TabIndex = 63
        Me.btnCari.Text = "Cari"
        Me.btnCari.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(636, 98)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 20)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Nama Siswa"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(636, 160)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 20)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Kelas"
        '
        'btn_refresh
        '
        Me.btn_refresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_refresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_refresh.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_refresh.FlatAppearance.BorderSize = 0
        Me.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_refresh.Image = CType(resources.GetObject("btn_refresh.Image"), System.Drawing.Image)
        Me.btn_refresh.Location = New System.Drawing.Point(349, 490)
        Me.btn_refresh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(147, 54)
        Me.btn_refresh.TabIndex = 66
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'TransaksiForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(876, 560)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.tb_nisn)
        Me.Controls.Add(Me.lbl_nama_kelas)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_tutup)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.num_jumlah_bayar)
        Me.Controls.Add(Me.btn_send)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lbl_nama_siswa)
        Me.Controls.Add(Me.dtp_tanggal)
        Me.Controls.Add(Me.cmb_petugas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_add)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "TransaksiForm"
        Me.ShowIcon = False
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_jumlah_bayar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_add As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_petugas As ComboBox
    Friend WithEvents dtp_tanggal As DateTimePicker
    Friend WithEvents lbl_nama_siswa As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_send As Button
    Friend WithEvents num_jumlah_bayar As NumericUpDown
    Friend WithEvents btn_tutup As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents id_petugas As DataGridViewTextBoxColumn
    Friend WithEvents nisn As DataGridViewTextBoxColumn
    Friend WithEvents bulan_dibayar As DataGridViewTextBoxColumn
    Friend WithEvents tahun_dibayar As DataGridViewTextBoxColumn
    Friend WithEvents id_spp As DataGridViewTextBoxColumn
    Friend WithEvents jumlah_bayar As DataGridViewTextBoxColumn
    Friend WithEvents tgl_bayar As DataGridViewTextBoxColumn
    Friend WithEvents lbl_nama_kelas As Label
    Friend WithEvents tb_nisn As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_refresh As Button
End Class
