<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SiswaForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SiswaForm))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tb_nisn = New System.Windows.Forms.TextBox()
        Me.tb_nis = New System.Windows.Forms.TextBox()
        Me.tb_nama = New System.Windows.Forms.TextBox()
        Me.tb_telepon = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_kelas = New System.Windows.Forms.ComboBox()
        Me.cmb_spp = New System.Windows.Forms.ComboBox()
        Me.tb_alamat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_tutup = New System.Windows.Forms.Button()
        Me.btn_cetak = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_create = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.DataGridView1.Location = New System.Drawing.Point(0, 229)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 25
        Me.DataGridView1.Size = New System.Drawing.Size(876, 257)
        Me.DataGridView1.TabIndex = 0
        '
        'tb_nisn
        '
        Me.tb_nisn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_nisn.Location = New System.Drawing.Point(22, 123)
        Me.tb_nisn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tb_nisn.Name = "tb_nisn"
        Me.tb_nisn.Size = New System.Drawing.Size(271, 26)
        Me.tb_nisn.TabIndex = 1
        '
        'tb_nis
        '
        Me.tb_nis.Location = New System.Drawing.Point(319, 123)
        Me.tb_nis.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tb_nis.Name = "tb_nis"
        Me.tb_nis.Size = New System.Drawing.Size(223, 26)
        Me.tb_nis.TabIndex = 2
        '
        'tb_nama
        '
        Me.tb_nama.Location = New System.Drawing.Point(571, 123)
        Me.tb_nama.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tb_nama.Name = "tb_nama"
        Me.tb_nama.Size = New System.Drawing.Size(271, 26)
        Me.tb_nama.TabIndex = 3
        '
        'tb_telepon
        '
        Me.tb_telepon.Location = New System.Drawing.Point(22, 181)
        Me.tb_telepon.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tb_telepon.Name = "tb_telepon"
        Me.tb_telepon.Size = New System.Drawing.Size(271, 26)
        Me.tb_telepon.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(17, 98)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "NISN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(315, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "NIS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(567, 98)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(17, 155)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "No. Telepon"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(315, 160)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Kelas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(427, 158)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Tahun SPP"
        '
        'cmb_kelas
        '
        Me.cmb_kelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_kelas.FormattingEnabled = True
        Me.cmb_kelas.Location = New System.Drawing.Point(319, 181)
        Me.cmb_kelas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmb_kelas.Name = "cmb_kelas"
        Me.cmb_kelas.Size = New System.Drawing.Size(102, 28)
        Me.cmb_kelas.TabIndex = 15
        '
        'cmb_spp
        '
        Me.cmb_spp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_spp.FormattingEnabled = True
        Me.cmb_spp.Location = New System.Drawing.Point(431, 181)
        Me.cmb_spp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmb_spp.Name = "cmb_spp"
        Me.cmb_spp.Size = New System.Drawing.Size(110, 28)
        Me.cmb_spp.TabIndex = 16
        '
        'tb_alamat
        '
        Me.tb_alamat.Location = New System.Drawing.Point(571, 184)
        Me.tb_alamat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tb_alamat.Name = "tb_alamat"
        Me.tb_alamat.Size = New System.Drawing.Size(271, 26)
        Me.tb_alamat.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(567, 160)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 20)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Alamat"
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
        Me.btn_tutup.Location = New System.Drawing.Point(738, 499)
        Me.btn_tutup.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_tutup.Name = "btn_tutup"
        Me.btn_tutup.Size = New System.Drawing.Size(147, 54)
        Me.btn_tutup.TabIndex = 62
        Me.btn_tutup.Text = "Tutup"
        Me.btn_tutup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_tutup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_tutup.UseVisualStyleBackColor = False
        '
        'btn_cetak
        '
        Me.btn_cetak.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_cetak.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btn_cetak.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cetak.FlatAppearance.BorderSize = 0
        Me.btn_cetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cetak.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_cetak.Image = CType(resources.GetObject("btn_cetak.Image"), System.Drawing.Image)
        Me.btn_cetak.Location = New System.Drawing.Point(595, 499)
        Me.btn_cetak.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_cetak.Name = "btn_cetak"
        Me.btn_cetak.Size = New System.Drawing.Size(134, 54)
        Me.btn_cetak.TabIndex = 61
        Me.btn_cetak.Text = "Cetak"
        Me.btn_cetak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cetak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cetak.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_back.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_back.FlatAppearance.BorderSize = 0
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_back.Image = CType(resources.GetObject("btn_back.Image"), System.Drawing.Image)
        Me.btn_back.Location = New System.Drawing.Point(150, 499)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(147, 54)
        Me.btn_back.TabIndex = 60
        Me.btn_back.Text = "Refresh"
        Me.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_back.UseVisualStyleBackColor = False
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
        Me.btn_delete.Location = New System.Drawing.Point(447, 499)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(140, 54)
        Me.btn_delete.TabIndex = 59
        Me.btn_delete.Text = "Hapus"
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.FlatAppearance.BorderSize = 0
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btn_update.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_update.Image = CType(resources.GetObject("btn_update.Image"), System.Drawing.Image)
        Me.btn_update.Location = New System.Drawing.Point(306, 499)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(132, 54)
        Me.btn_update.TabIndex = 58
        Me.btn_update.Text = "Ubah"
        Me.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_create
        '
        Me.btn_create.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_create.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_create.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_create.FlatAppearance.BorderSize = 0
        Me.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_create.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btn_create.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_create.Image = CType(resources.GetObject("btn_create.Image"), System.Drawing.Image)
        Me.btn_create.Location = New System.Drawing.Point(9, 499)
        Me.btn_create.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(132, 54)
        Me.btn_create.TabIndex = 57
        Me.btn_create.Text = "Save"
        Me.btn_create.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_create.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_create.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(88, 32)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 58)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Siswa"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(81, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 63
        Me.PictureBox1.TabStop = False
        '
        'SiswaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(876, 560)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_tutup)
        Me.Controls.Add(Me.btn_cetak)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_create)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tb_alamat)
        Me.Controls.Add(Me.cmb_spp)
        Me.Controls.Add(Me.cmb_kelas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_telepon)
        Me.Controls.Add(Me.tb_nama)
        Me.Controls.Add(Me.tb_nis)
        Me.Controls.Add(Me.tb_nisn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "SiswaForm"
        Me.ShowIcon = False
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tb_nisn As TextBox
    Friend WithEvents tb_nis As TextBox
    Friend WithEvents tb_nama As TextBox
    Friend WithEvents tb_telepon As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_kelas As ComboBox
    Friend WithEvents cmb_spp As ComboBox
    Friend WithEvents tb_alamat As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_tutup As Button
    Friend WithEvents btn_cetak As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_create As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PictureBox1 As PictureBox
End Class
