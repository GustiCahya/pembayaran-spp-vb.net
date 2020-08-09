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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_create = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_petugas = New System.Windows.Forms.ComboBox()
        Me.cmb_nisn = New System.Windows.Forms.ComboBox()
        Me.dtp_tanggal = New System.Windows.Forms.DateTimePicker()
        Me.cmb_spp = New System.Windows.Forms.ComboBox()
        Me.tb_jumlah_bayar = New System.Windows.Forms.TextBox()
        Me.lbl_nama_siswa = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(93, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(387, 39)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Transaksi Pembayaran"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(97, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Tahun SPP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(97, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Tanggal Bayar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "NISN Siswa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Petugas"
        '
        'btn_create
        '
        Me.btn_create.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_create.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_create.FlatAppearance.BorderSize = 0
        Me.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_create.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btn_create.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_create.Location = New System.Drawing.Point(324, 304)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(142, 43)
        Me.btn_create.TabIndex = 34
        Me.btn_create.Text = "Create"
        Me.btn_create.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(97, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Jumlah Bayar"
        '
        'cmb_petugas
        '
        Me.cmb_petugas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_petugas.FormattingEnabled = True
        Me.cmb_petugas.Location = New System.Drawing.Point(100, 102)
        Me.cmb_petugas.Name = "cmb_petugas"
        Me.cmb_petugas.Size = New System.Drawing.Size(366, 21)
        Me.cmb_petugas.TabIndex = 42
        '
        'cmb_nisn
        '
        Me.cmb_nisn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_nisn.DisplayMember = "nisn"
        Me.cmb_nisn.FormattingEnabled = True
        Me.cmb_nisn.Location = New System.Drawing.Point(100, 143)
        Me.cmb_nisn.Name = "cmb_nisn"
        Me.cmb_nisn.Size = New System.Drawing.Size(263, 21)
        Me.cmb_nisn.TabIndex = 43
        Me.cmb_nisn.ValueMember = "nisn"
        '
        'dtp_tanggal
        '
        Me.dtp_tanggal.Location = New System.Drawing.Point(100, 183)
        Me.dtp_tanggal.Name = "dtp_tanggal"
        Me.dtp_tanggal.Size = New System.Drawing.Size(366, 20)
        Me.dtp_tanggal.TabIndex = 45
        '
        'cmb_spp
        '
        Me.cmb_spp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_spp.FormattingEnabled = True
        Me.cmb_spp.Location = New System.Drawing.Point(100, 222)
        Me.cmb_spp.Name = "cmb_spp"
        Me.cmb_spp.Size = New System.Drawing.Size(366, 21)
        Me.cmb_spp.TabIndex = 46
        '
        'tb_jumlah_bayar
        '
        Me.tb_jumlah_bayar.Location = New System.Drawing.Point(100, 263)
        Me.tb_jumlah_bayar.Name = "tb_jumlah_bayar"
        Me.tb_jumlah_bayar.Size = New System.Drawing.Size(366, 20)
        Me.tb_jumlah_bayar.TabIndex = 47
        '
        'lbl_nama_siswa
        '
        Me.lbl_nama_siswa.AutoSize = True
        Me.lbl_nama_siswa.BackColor = System.Drawing.Color.Teal
        Me.lbl_nama_siswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_nama_siswa.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_nama_siswa.Location = New System.Drawing.Point(369, 143)
        Me.lbl_nama_siswa.Name = "lbl_nama_siswa"
        Me.lbl_nama_siswa.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.lbl_nama_siswa.Size = New System.Drawing.Size(43, 21)
        Me.lbl_nama_siswa.TabIndex = 48
        Me.lbl_nama_siswa.Text = "name"
        '
        'TransaksiForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 364)
        Me.Controls.Add(Me.lbl_nama_siswa)
        Me.Controls.Add(Me.tb_jumlah_bayar)
        Me.Controls.Add(Me.cmb_spp)
        Me.Controls.Add(Me.dtp_tanggal)
        Me.Controls.Add(Me.cmb_nisn)
        Me.Controls.Add(Me.cmb_petugas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_create)
        Me.Name = "TransaksiForm"
        Me.Text = "TransaksiForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_create As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_petugas As ComboBox
    Friend WithEvents cmb_nisn As ComboBox
    Friend WithEvents dtp_tanggal As DateTimePicker
    Friend WithEvents cmb_spp As ComboBox
    Friend WithEvents tb_jumlah_bayar As TextBox
    Friend WithEvents lbl_nama_siswa As Label
End Class
