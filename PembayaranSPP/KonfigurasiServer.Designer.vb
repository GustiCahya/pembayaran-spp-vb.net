<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KonfigurasiServer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KonfigurasiServer))
        Me.lbl_connect = New System.Windows.Forms.Label()
        Me.btn_connect = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_database = New System.Windows.Forms.TextBox()
        Me.tb_password = New System.Windows.Forms.TextBox()
        Me.tb_userid = New System.Windows.Forms.TextBox()
        Me.tb_server = New System.Windows.Forms.TextBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_tutup = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_connect
        '
        Me.lbl_connect.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_connect.BackColor = System.Drawing.Color.Teal
        Me.lbl_connect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_connect.ForeColor = System.Drawing.Color.Salmon
        Me.lbl_connect.Location = New System.Drawing.Point(318, 79)
        Me.lbl_connect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_connect.Name = "lbl_connect"
        Me.lbl_connect.Size = New System.Drawing.Size(233, 32)
        Me.lbl_connect.TabIndex = 21
        Me.lbl_connect.Text = "✘ Not Connected"
        Me.lbl_connect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_connect
        '
        Me.btn_connect.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_connect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_connect.FlatAppearance.BorderSize = 0
        Me.btn_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_connect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_connect.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_connect.Location = New System.Drawing.Point(155, 599)
        Me.btn_connect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_connect.Name = "btn_connect"
        Me.btn_connect.Size = New System.Drawing.Size(180, 52)
        Me.btn_connect.TabIndex = 20
        Me.btn_connect.Text = "Test Koneksi"
        Me.btn_connect.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(870, 76)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Konfigurasi Server"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(150, 495)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 29)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Database"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(150, 399)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 29)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(148, 307)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 29)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "User id"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(148, 218)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 29)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Server"
        '
        'tb_database
        '
        Me.tb_database.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_database.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.tb_database.Location = New System.Drawing.Point(155, 529)
        Me.tb_database.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tb_database.Name = "tb_database"
        Me.tb_database.Size = New System.Drawing.Size(525, 44)
        Me.tb_database.TabIndex = 14
        '
        'tb_password
        '
        Me.tb_password.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.tb_password.Location = New System.Drawing.Point(155, 433)
        Me.tb_password.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tb_password.Name = "tb_password"
        Me.tb_password.Size = New System.Drawing.Size(525, 44)
        Me.tb_password.TabIndex = 13
        Me.tb_password.UseSystemPasswordChar = True
        '
        'tb_userid
        '
        Me.tb_userid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_userid.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.tb_userid.Location = New System.Drawing.Point(153, 341)
        Me.tb_userid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tb_userid.Name = "tb_userid"
        Me.tb_userid.Size = New System.Drawing.Size(525, 44)
        Me.tb_userid.TabIndex = 12
        '
        'tb_server
        '
        Me.tb_server.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tb_server.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_server.Location = New System.Drawing.Point(153, 252)
        Me.tb_server.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tb_server.Name = "tb_server"
        Me.tb_server.Size = New System.Drawing.Size(525, 44)
        Me.tb_server.TabIndex = 11
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_simpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_simpan.FlatAppearance.BorderSize = 0
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_simpan.Location = New System.Drawing.Point(343, 599)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(169, 52)
        Me.btn_simpan.TabIndex = 22
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'btn_tutup
        '
        Me.btn_tutup.BackColor = System.Drawing.Color.IndianRed
        Me.btn_tutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_tutup.FlatAppearance.BorderSize = 0
        Me.btn_tutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tutup.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_tutup.Location = New System.Drawing.Point(520, 599)
        Me.btn_tutup.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_tutup.Name = "btn_tutup"
        Me.btn_tutup.Size = New System.Drawing.Size(158, 52)
        Me.btn_tutup.TabIndex = 23
        Me.btn_tutup.Text = "Tutup"
        Me.btn_tutup.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btn_tutup)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btn_simpan)
        Me.Panel1.Controls.Add(Me.lbl_connect)
        Me.Panel1.Controls.Add(Me.btn_connect)
        Me.Panel1.Controls.Add(Me.tb_database)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.tb_server)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tb_userid)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tb_password)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(870, 703)
        Me.Panel1.TabIndex = 24
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(356, 122)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 65
        Me.PictureBox1.TabStop = False
        '
        'KonfigurasiServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(870, 703)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "KonfigurasiServer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_connect As Label
    Friend WithEvents btn_connect As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_database As TextBox
    Friend WithEvents tb_password As TextBox
    Friend WithEvents tb_userid As TextBox
    Friend WithEvents tb_server As TextBox
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_tutup As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
