<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KelasForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_create = New System.Windows.Forms.Button()
        Me.tb_kompetensi_keahlian = New System.Windows.Forms.TextBox()
        Me.tb_nama_kelas = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.lbl_id_spp = New System.Windows.Forms.Label()
        Me.tb_id_kelas = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(430, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 39)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Kelas"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Kompetensi Keahlian"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Nama Kelas"
        '
        'btn_create
        '
        Me.btn_create.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_create.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_create.FlatAppearance.BorderSize = 0
        Me.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_create.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btn_create.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_create.Location = New System.Drawing.Point(408, 64)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(152, 52)
        Me.btn_create.TabIndex = 44
        Me.btn_create.Text = "Create"
        Me.btn_create.UseVisualStyleBackColor = False
        '
        'tb_kompetensi_keahlian
        '
        Me.tb_kompetensi_keahlian.Location = New System.Drawing.Point(13, 107)
        Me.tb_kompetensi_keahlian.Name = "tb_kompetensi_keahlian"
        Me.tb_kompetensi_keahlian.Size = New System.Drawing.Size(304, 20)
        Me.tb_kompetensi_keahlian.TabIndex = 43
        '
        'tb_nama_kelas
        '
        Me.tb_nama_kelas.Location = New System.Drawing.Point(13, 68)
        Me.tb_nama_kelas.Name = "tb_nama_kelas"
        Me.tb_nama_kelas.Size = New System.Drawing.Size(304, 20)
        Me.tb_nama_kelas.TabIndex = 42
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
        Me.DataGridView1.Location = New System.Drawing.Point(0, 145)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 25
        Me.DataGridView1.Size = New System.Drawing.Size(584, 211)
        Me.DataGridView1.TabIndex = 41
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btn_back.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_back.Location = New System.Drawing.Point(363, 12)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(34, 32)
        Me.btn_back.TabIndex = 50
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
        Me.btn_delete.Location = New System.Drawing.Point(408, 106)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(152, 35)
        Me.btn_delete.TabIndex = 49
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
        Me.btn_update.Location = New System.Drawing.Point(408, 68)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(152, 35)
        Me.btn_update.TabIndex = 48
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        Me.btn_update.Visible = False
        '
        'lbl_id_spp
        '
        Me.lbl_id_spp.AutoSize = True
        Me.lbl_id_spp.Location = New System.Drawing.Point(10, 13)
        Me.lbl_id_spp.Name = "lbl_id_spp"
        Me.lbl_id_spp.Size = New System.Drawing.Size(47, 13)
        Me.lbl_id_spp.TabIndex = 52
        Me.lbl_id_spp.Text = "ID Kelas"
        '
        'tb_id_kelas
        '
        Me.tb_id_kelas.Cursor = System.Windows.Forms.Cursors.No
        Me.tb_id_kelas.Location = New System.Drawing.Point(13, 29)
        Me.tb_id_kelas.Name = "tb_id_kelas"
        Me.tb_id_kelas.ReadOnly = True
        Me.tb_id_kelas.Size = New System.Drawing.Size(304, 20)
        Me.tb_id_kelas.TabIndex = 51
        '
        'KelasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 364)
        Me.Controls.Add(Me.lbl_id_spp)
        Me.Controls.Add(Me.tb_id_kelas)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_create)
        Me.Controls.Add(Me.tb_kompetensi_keahlian)
        Me.Controls.Add(Me.tb_nama_kelas)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "KelasForm"
        Me.Text = "KelasForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_create As Button
    Friend WithEvents tb_kompetensi_keahlian As TextBox
    Friend WithEvents tb_nama_kelas As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents lbl_id_spp As Label
    Friend WithEvents tb_id_kelas As TextBox
End Class
