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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tb_nisn = New System.Windows.Forms.TextBox()
        Me.tb_nis = New System.Windows.Forms.TextBox()
        Me.tb_nama = New System.Windows.Forms.TextBox()
        Me.tb_telepon = New System.Windows.Forms.TextBox()
        Me.btn_create = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_kelas = New System.Windows.Forms.ComboBox()
        Me.cmb_spp = New System.Windows.Forms.ComboBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.tb_alamat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 153)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 25
        Me.DataGridView1.Size = New System.Drawing.Size(584, 211)
        Me.DataGridView1.TabIndex = 0
        '
        'tb_nisn
        '
        Me.tb_nisn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_nisn.Location = New System.Drawing.Point(12, 32)
        Me.tb_nisn.Name = "tb_nisn"
        Me.tb_nisn.Size = New System.Drawing.Size(182, 20)
        Me.tb_nisn.TabIndex = 1
        '
        'tb_nis
        '
        Me.tb_nis.Location = New System.Drawing.Point(210, 32)
        Me.tb_nis.Name = "tb_nis"
        Me.tb_nis.Size = New System.Drawing.Size(150, 20)
        Me.tb_nis.TabIndex = 2
        '
        'tb_nama
        '
        Me.tb_nama.Location = New System.Drawing.Point(12, 71)
        Me.tb_nama.Name = "tb_nama"
        Me.tb_nama.Size = New System.Drawing.Size(182, 20)
        Me.tb_nama.TabIndex = 3
        '
        'tb_telepon
        '
        Me.tb_telepon.Location = New System.Drawing.Point(12, 112)
        Me.tb_telepon.Name = "tb_telepon"
        Me.tb_telepon.Size = New System.Drawing.Size(182, 20)
        Me.tb_telepon.TabIndex = 5
        '
        'btn_create
        '
        Me.btn_create.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_create.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_create.FlatAppearance.BorderSize = 0
        Me.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_create.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btn_create.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_create.Location = New System.Drawing.Point(411, 79)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(152, 52)
        Me.btn_create.TabIndex = 7
        Me.btn_create.Text = "Create"
        Me.btn_create.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "NISN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "NIS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "No. Telepon"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(207, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Kelas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(282, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Tahun SPP"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(430, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 39)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Siswa"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb_kelas
        '
        Me.cmb_kelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_kelas.FormattingEnabled = True
        Me.cmb_kelas.Location = New System.Drawing.Point(210, 70)
        Me.cmb_kelas.Name = "cmb_kelas"
        Me.cmb_kelas.Size = New System.Drawing.Size(69, 21)
        Me.cmb_kelas.TabIndex = 15
        '
        'cmb_spp
        '
        Me.cmb_spp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_spp.FormattingEnabled = True
        Me.cmb_spp.Location = New System.Drawing.Point(285, 71)
        Me.cmb_spp.Name = "cmb_spp"
        Me.cmb_spp.Size = New System.Drawing.Size(75, 21)
        Me.cmb_spp.TabIndex = 16
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btn_back.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_back.Location = New System.Drawing.Point(377, 24)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(34, 32)
        Me.btn_back.TabIndex = 46
        Me.btn_back.Text = "<"
        Me.btn_back.UseVisualStyleBackColor = False
        Me.btn_back.Visible = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Crimson
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.FlatAppearance.BorderSize = 0
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btn_delete.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_delete.Location = New System.Drawing.Point(411, 109)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(152, 35)
        Me.btn_delete.TabIndex = 45
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        Me.btn_delete.Visible = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.FlatAppearance.BorderSize = 0
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btn_update.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_update.Location = New System.Drawing.Point(411, 71)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(152, 35)
        Me.btn_update.TabIndex = 44
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        Me.btn_update.Visible = False
        '
        'tb_alamat
        '
        Me.tb_alamat.Location = New System.Drawing.Point(210, 112)
        Me.tb_alamat.Name = "tb_alamat"
        Me.tb_alamat.Size = New System.Drawing.Size(150, 20)
        Me.tb_alamat.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(207, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Alamat"
        '
        'SiswaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(584, 364)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tb_alamat)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.cmb_spp)
        Me.Controls.Add(Me.cmb_kelas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_create)
        Me.Controls.Add(Me.tb_telepon)
        Me.Controls.Add(Me.tb_nama)
        Me.Controls.Add(Me.tb_nis)
        Me.Controls.Add(Me.tb_nisn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "SiswaForm"
        Me.Text = "SiswaForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tb_nisn As TextBox
    Friend WithEvents tb_nis As TextBox
    Friend WithEvents tb_nama As TextBox
    Friend WithEvents tb_telepon As TextBox
    Friend WithEvents btn_create As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb_kelas As ComboBox
    Friend WithEvents cmb_spp As ComboBox
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents tb_alamat As TextBox
    Friend WithEvents Label8 As Label
End Class
