<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SppForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SppForm))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lbl_id_spp = New System.Windows.Forms.Label()
        Me.tb_id_spp = New System.Windows.Forms.TextBox()
        Me.num_nominal = New System.Windows.Forms.NumericUpDown()
        Me.btn_tutup = New System.Windows.Forms.Button()
        Me.btn_cetak = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_create = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.num_tahun = New System.Windows.Forms.NumericUpDown()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_nominal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_tahun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(92, 20)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 58)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "SPP"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(446, 148)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Nominal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 148)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Tahun"
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
        Me.DataGridView1.Location = New System.Drawing.Point(-2, 214)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 25
        Me.DataGridView1.Size = New System.Drawing.Size(876, 274)
        Me.DataGridView1.TabIndex = 30
        '
        'lbl_id_spp
        '
        Me.lbl_id_spp.AutoSize = True
        Me.lbl_id_spp.ForeColor = System.Drawing.Color.White
        Me.lbl_id_spp.Location = New System.Drawing.Point(16, 91)
        Me.lbl_id_spp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_id_spp.Name = "lbl_id_spp"
        Me.lbl_id_spp.Size = New System.Drawing.Size(61, 20)
        Me.lbl_id_spp.TabIndex = 45
        Me.lbl_id_spp.Text = "ID SPP"
        '
        'tb_id_spp
        '
        Me.tb_id_spp.Cursor = System.Windows.Forms.Cursors.No
        Me.tb_id_spp.Location = New System.Drawing.Point(20, 116)
        Me.tb_id_spp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tb_id_spp.Name = "tb_id_spp"
        Me.tb_id_spp.ReadOnly = True
        Me.tb_id_spp.Size = New System.Drawing.Size(409, 26)
        Me.tb_id_spp.TabIndex = 44
        '
        'num_nominal
        '
        Me.num_nominal.Location = New System.Drawing.Point(450, 172)
        Me.num_nominal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.num_nominal.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.num_nominal.Name = "num_nominal"
        Me.num_nominal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.num_nominal.Size = New System.Drawing.Size(400, 26)
        Me.num_nominal.TabIndex = 64
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
        Me.btn_tutup.Location = New System.Drawing.Point(741, 498)
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
        Me.btn_cetak.Location = New System.Drawing.Point(599, 498)
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
        Me.btn_back.Location = New System.Drawing.Point(153, 498)
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
        Me.btn_delete.Location = New System.Drawing.Point(450, 498)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(141, 54)
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
        Me.btn_update.Location = New System.Drawing.Point(309, 498)
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
        Me.btn_create.Location = New System.Drawing.Point(12, 498)
        Me.btn_create.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(132, 54)
        Me.btn_create.TabIndex = 57
        Me.btn_create.Text = "Save"
        Me.btn_create.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_create.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_create.UseVisualStyleBackColor = False
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
        'num_tahun
        '
        Me.num_tahun.Location = New System.Drawing.Point(20, 172)
        Me.num_tahun.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.num_tahun.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.num_tahun.Name = "num_tahun"
        Me.num_tahun.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.num_tahun.Size = New System.Drawing.Size(409, 26)
        Me.num_tahun.TabIndex = 63
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'SppForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(876, 560)
        Me.Controls.Add(Me.num_nominal)
        Me.Controls.Add(Me.num_tahun)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_tutup)
        Me.Controls.Add(Me.btn_cetak)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_create)
        Me.Controls.Add(Me.lbl_id_spp)
        Me.Controls.Add(Me.tb_id_spp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "SppForm"
        Me.ShowIcon = False
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_nominal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_tahun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lbl_id_spp As Label
    Friend WithEvents tb_id_spp As TextBox
    Friend WithEvents num_tahun As NumericUpDown
    Friend WithEvents num_nominal As NumericUpDown
    Friend WithEvents btn_tutup As Button
    Friend WithEvents btn_cetak As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_create As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PictureBox1 As PictureBox
End Class
