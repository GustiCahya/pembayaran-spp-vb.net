﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PetugasForm
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
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_create = New System.Windows.Forms.Button()
        Me.tb_nama_petugas = New System.Windows.Forms.TextBox()
        Me.tb_password = New System.Windows.Forms.TextBox()
        Me.tb_username = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.cmb_level = New System.Windows.Forms.ComboBox()
        Me.lbl_id_spp = New System.Windows.Forms.Label()
        Me.tb_id_petugas = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(414, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 39)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Petugas"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(206, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Level"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Nama Lengkap Petugas"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Location = New System.Drawing.Point(206, 53)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(53, 13)
        Me.lbl_password.TabIndex = 24
        Me.lbl_password.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Username"
        '
        'btn_create
        '
        Me.btn_create.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_create.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_create.FlatAppearance.BorderSize = 0
        Me.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_create.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btn_create.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_create.Location = New System.Drawing.Point(411, 71)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(152, 52)
        Me.btn_create.TabIndex = 22
        Me.btn_create.Text = "Create"
        Me.btn_create.UseVisualStyleBackColor = False
        '
        'tb_nama_petugas
        '
        Me.tb_nama_petugas.Location = New System.Drawing.Point(12, 111)
        Me.tb_nama_petugas.Name = "tb_nama_petugas"
        Me.tb_nama_petugas.Size = New System.Drawing.Size(180, 20)
        Me.tb_nama_petugas.TabIndex = 18
        '
        'tb_password
        '
        Me.tb_password.Location = New System.Drawing.Point(209, 68)
        Me.tb_password.Name = "tb_password"
        Me.tb_password.Size = New System.Drawing.Size(128, 20)
        Me.tb_password.TabIndex = 17
        Me.tb_password.UseSystemPasswordChar = True
        '
        'tb_username
        '
        Me.tb_username.Location = New System.Drawing.Point(12, 68)
        Me.tb_username.Name = "tb_username"
        Me.tb_username.Size = New System.Drawing.Size(180, 20)
        Me.tb_username.TabIndex = 16
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
        Me.DataGridView1.Location = New System.Drawing.Point(0, 161)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 25
        Me.DataGridView1.Size = New System.Drawing.Size(584, 195)
        Me.DataGridView1.TabIndex = 15
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btn_back.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_back.Location = New System.Drawing.Point(366, 17)
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
        Me.btn_delete.Location = New System.Drawing.Point(411, 111)
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
        Me.btn_update.Location = New System.Drawing.Point(411, 73)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(152, 35)
        Me.btn_update.TabIndex = 44
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        Me.btn_update.Visible = False
        '
        'cmb_level
        '
        Me.cmb_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_level.FormattingEnabled = True
        Me.cmb_level.Items.AddRange(New Object() {"admin", "petugas"})
        Me.cmb_level.Location = New System.Drawing.Point(209, 112)
        Me.cmb_level.Name = "cmb_level"
        Me.cmb_level.Size = New System.Drawing.Size(128, 21)
        Me.cmb_level.TabIndex = 48
        '
        'lbl_id_spp
        '
        Me.lbl_id_spp.AutoSize = True
        Me.lbl_id_spp.Location = New System.Drawing.Point(9, 13)
        Me.lbl_id_spp.Name = "lbl_id_spp"
        Me.lbl_id_spp.Size = New System.Drawing.Size(60, 13)
        Me.lbl_id_spp.TabIndex = 54
        Me.lbl_id_spp.Text = "ID Petugas"
        '
        'tb_id_petugas
        '
        Me.tb_id_petugas.Cursor = System.Windows.Forms.Cursors.No
        Me.tb_id_petugas.Location = New System.Drawing.Point(12, 29)
        Me.tb_id_petugas.Name = "tb_id_petugas"
        Me.tb_id_petugas.ReadOnly = True
        Me.tb_id_petugas.Size = New System.Drawing.Size(325, 20)
        Me.tb_id_petugas.TabIndex = 53
        '
        'PetugasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 364)
        Me.Controls.Add(Me.lbl_id_spp)
        Me.Controls.Add(Me.tb_id_petugas)
        Me.Controls.Add(Me.cmb_level)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_create)
        Me.Controls.Add(Me.tb_nama_petugas)
        Me.Controls.Add(Me.tb_password)
        Me.Controls.Add(Me.tb_username)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "PetugasForm"
        Me.Text = "PetugasForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_password As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_create As Button
    Friend WithEvents tb_nama_petugas As TextBox
    Friend WithEvents tb_password As TextBox
    Friend WithEvents tb_username As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents cmb_level As ComboBox
    Friend WithEvents lbl_id_spp As Label
    Friend WithEvents tb_id_petugas As TextBox
End Class
