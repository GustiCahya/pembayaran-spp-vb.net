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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_petugas = New System.Windows.Forms.ComboBox()
        Me.cmb_nisn = New System.Windows.Forms.ComboBox()
        Me.dtp_tanggal = New System.Windows.Forms.DateTimePicker()
        Me.tb_jumlah_bayar = New System.Windows.Forms.TextBox()
        Me.lbl_nama_siswa = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_pembayaran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_petugas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nisn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl_bayar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bulan_dibayar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tahun_dibayar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_spp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah_bayar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_send = New System.Windows.Forms.Button()
        Me.lbl_minimum = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(402, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 64)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Transaksi Pembayaran"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Tanggal Bayar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "NISN Siswa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Petugas"
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.FlatAppearance.BorderSize = 0
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btn_add.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_add.Location = New System.Drawing.Point(416, 84)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(142, 43)
        Me.btn_add.TabIndex = 34
        Me.btn_add.Text = "Tambah"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Jumlah Bayar"
        '
        'cmb_petugas
        '
        Me.cmb_petugas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_petugas.FormattingEnabled = True
        Me.cmb_petugas.Location = New System.Drawing.Point(22, 28)
        Me.cmb_petugas.Name = "cmb_petugas"
        Me.cmb_petugas.Size = New System.Drawing.Size(366, 21)
        Me.cmb_petugas.TabIndex = 42
        '
        'cmb_nisn
        '
        Me.cmb_nisn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_nisn.DisplayMember = "nisn"
        Me.cmb_nisn.FormattingEnabled = True
        Me.cmb_nisn.Location = New System.Drawing.Point(22, 67)
        Me.cmb_nisn.Name = "cmb_nisn"
        Me.cmb_nisn.Size = New System.Drawing.Size(263, 21)
        Me.cmb_nisn.TabIndex = 43
        Me.cmb_nisn.ValueMember = "nisn"
        '
        'dtp_tanggal
        '
        Me.dtp_tanggal.Location = New System.Drawing.Point(22, 108)
        Me.dtp_tanggal.Name = "dtp_tanggal"
        Me.dtp_tanggal.Size = New System.Drawing.Size(366, 20)
        Me.dtp_tanggal.TabIndex = 45
        '
        'tb_jumlah_bayar
        '
        Me.tb_jumlah_bayar.Location = New System.Drawing.Point(22, 145)
        Me.tb_jumlah_bayar.Name = "tb_jumlah_bayar"
        Me.tb_jumlah_bayar.Size = New System.Drawing.Size(263, 20)
        Me.tb_jumlah_bayar.TabIndex = 47
        '
        'lbl_nama_siswa
        '
        Me.lbl_nama_siswa.AutoSize = True
        Me.lbl_nama_siswa.BackColor = System.Drawing.Color.Teal
        Me.lbl_nama_siswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_nama_siswa.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_nama_siswa.Location = New System.Drawing.Point(291, 67)
        Me.lbl_nama_siswa.Name = "lbl_nama_siswa"
        Me.lbl_nama_siswa.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.lbl_nama_siswa.Size = New System.Drawing.Size(43, 21)
        Me.lbl_nama_siswa.TabIndex = 48
        Me.lbl_nama_siswa.Text = "name"
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
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.id_pembayaran, Me.id_petugas, Me.nisn, Me.tgl_bayar, Me.bulan_dibayar, Me.tahun_dibayar, Me.id_spp, Me.jumlah_bayar})
        Me.DataGridView1.Location = New System.Drawing.Point(-10, 178)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 25
        Me.DataGridView1.Size = New System.Drawing.Size(602, 183)
        Me.DataGridView1.TabIndex = 49
        '
        'no
        '
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 30
        '
        'id_pembayaran
        '
        Me.id_pembayaran.HeaderText = "id_pembayaran"
        Me.id_pembayaran.Name = "id_pembayaran"
        Me.id_pembayaran.ReadOnly = True
        '
        'id_petugas
        '
        Me.id_petugas.HeaderText = "id_petugas"
        Me.id_petugas.Name = "id_petugas"
        Me.id_petugas.ReadOnly = True
        '
        'nisn
        '
        Me.nisn.HeaderText = "nisn"
        Me.nisn.Name = "nisn"
        Me.nisn.ReadOnly = True
        '
        'tgl_bayar
        '
        Me.tgl_bayar.HeaderText = "tgl_bayar"
        Me.tgl_bayar.Name = "tgl_bayar"
        Me.tgl_bayar.ReadOnly = True
        '
        'bulan_dibayar
        '
        Me.bulan_dibayar.HeaderText = "bulan_dibayar"
        Me.bulan_dibayar.Name = "bulan_dibayar"
        Me.bulan_dibayar.ReadOnly = True
        Me.bulan_dibayar.Visible = False
        '
        'tahun_dibayar
        '
        Me.tahun_dibayar.HeaderText = "tahun_dibayar"
        Me.tahun_dibayar.Name = "tahun_dibayar"
        Me.tahun_dibayar.ReadOnly = True
        Me.tahun_dibayar.Visible = False
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
        Me.jumlah_bayar.HeaderText = "jumlah_bayar"
        Me.jumlah_bayar.Name = "jumlah_bayar"
        Me.jumlah_bayar.ReadOnly = True
        '
        'btn_send
        '
        Me.btn_send.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_send.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_send.FlatAppearance.BorderSize = 0
        Me.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_send.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btn_send.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_send.Image = CType(resources.GetObject("btn_send.Image"), System.Drawing.Image)
        Me.btn_send.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_send.Location = New System.Drawing.Point(514, 150)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(58, 22)
        Me.btn_send.TabIndex = 50
        Me.btn_send.Text = "Kirim"
        Me.btn_send.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_send.UseVisualStyleBackColor = False
        '
        'lbl_minimum
        '
        Me.lbl_minimum.AutoSize = True
        Me.lbl_minimum.BackColor = System.Drawing.Color.Firebrick
        Me.lbl_minimum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_minimum.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_minimum.Location = New System.Drawing.Point(291, 145)
        Me.lbl_minimum.Name = "lbl_minimum"
        Me.lbl_minimum.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.lbl_minimum.Size = New System.Drawing.Size(118, 21)
        Me.lbl_minimum.TabIndex = 51
        Me.lbl_minimum.Text = "Biaya SPP : ######"
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Crimson
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.FlatAppearance.BorderSize = 0
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btn_delete.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_delete.Location = New System.Drawing.Point(450, 150)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(58, 22)
        Me.btn_delete.TabIndex = 52
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        Me.btn_delete.Visible = False
        '
        'TransaksiForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 364)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.lbl_minimum)
        Me.Controls.Add(Me.btn_send)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lbl_nama_siswa)
        Me.Controls.Add(Me.tb_jumlah_bayar)
        Me.Controls.Add(Me.dtp_tanggal)
        Me.Controls.Add(Me.cmb_nisn)
        Me.Controls.Add(Me.cmb_petugas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_add)
        Me.Name = "TransaksiForm"
        Me.Text = "TransaksiForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_add As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_petugas As ComboBox
    Friend WithEvents cmb_nisn As ComboBox
    Friend WithEvents dtp_tanggal As DateTimePicker
    Friend WithEvents tb_jumlah_bayar As TextBox
    Friend WithEvents lbl_nama_siswa As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_send As Button
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents id_pembayaran As DataGridViewTextBoxColumn
    Friend WithEvents id_petugas As DataGridViewTextBoxColumn
    Friend WithEvents nisn As DataGridViewTextBoxColumn
    Friend WithEvents tgl_bayar As DataGridViewTextBoxColumn
    Friend WithEvents bulan_dibayar As DataGridViewTextBoxColumn
    Friend WithEvents tahun_dibayar As DataGridViewTextBoxColumn
    Friend WithEvents id_spp As DataGridViewTextBoxColumn
    Friend WithEvents jumlah_bayar As DataGridViewTextBoxColumn
    Friend WithEvents lbl_minimum As Label
    Friend WithEvents btn_delete As Button
End Class
