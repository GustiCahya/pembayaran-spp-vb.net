<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl_login_siswa = New System.Windows.Forms.LinkLabel()
        Me.tb_password = New MetroFramework.Controls.MetroTextBox()
        Me.tb_username = New MetroFramework.Controls.MetroTextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.cb_showpassword = New MetroFramework.Controls.MetroCheckBox()
        Me.lbl_password = New MetroFramework.Controls.MetroLabel()
        Me.lbl_username = New MetroFramework.Controls.MetroLabel()
        Me.lbl_login = New System.Windows.Forms.Label()
        Me.lbl_role = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.lbl_login_siswa)
        Me.Panel1.Controls.Add(Me.tb_password)
        Me.Panel1.Controls.Add(Me.tb_username)
        Me.Panel1.Controls.Add(Me.btn_login)
        Me.Panel1.Controls.Add(Me.cb_showpassword)
        Me.Panel1.Controls.Add(Me.lbl_password)
        Me.Panel1.Controls.Add(Me.lbl_username)
        Me.Panel1.Location = New System.Drawing.Point(-8, 295)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1212, 406)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(495, -95)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(226, 182)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'lbl_login_siswa
        '
        Me.lbl_login_siswa.ActiveLinkColor = System.Drawing.Color.DodgerBlue
        Me.lbl_login_siswa.AutoSize = True
        Me.lbl_login_siswa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_login_siswa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbl_login_siswa.LinkColor = System.Drawing.Color.SkyBlue
        Me.lbl_login_siswa.Location = New System.Drawing.Point(273, 303)
        Me.lbl_login_siswa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_login_siswa.Name = "lbl_login_siswa"
        Me.lbl_login_siswa.Size = New System.Drawing.Size(196, 25)
        Me.lbl_login_siswa.TabIndex = 11
        Me.lbl_login_siswa.TabStop = True
        Me.lbl_login_siswa.Text = "Login Sebagai Siswa"
        '
        'tb_password
        '
        '
        '
        '
        Me.tb_password.CustomButton.Image = Nothing
        Me.tb_password.CustomButton.Location = New System.Drawing.Point(650, 1)
        Me.tb_password.CustomButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tb_password.CustomButton.Name = ""
        Me.tb_password.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.tb_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tb_password.CustomButton.TabIndex = 1
        Me.tb_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tb_password.CustomButton.UseSelectable = True
        Me.tb_password.CustomButton.Visible = False
        Me.tb_password.Lines = New String(-1) {}
        Me.tb_password.Location = New System.Drawing.Point(276, 214)
        Me.tb_password.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tb_password.MaxLength = 32767
        Me.tb_password.Name = "tb_password"
        Me.tb_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.tb_password.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tb_password.SelectedText = ""
        Me.tb_password.SelectionLength = 0
        Me.tb_password.SelectionStart = 0
        Me.tb_password.ShortcutsEnabled = True
        Me.tb_password.Size = New System.Drawing.Size(684, 35)
        Me.tb_password.Style = MetroFramework.MetroColorStyle.White
        Me.tb_password.TabIndex = 10
        Me.tb_password.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tb_password.UseSelectable = True
        Me.tb_password.UseStyleColors = True
        Me.tb_password.UseSystemPasswordChar = True
        Me.tb_password.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tb_password.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tb_username
        '
        '
        '
        '
        Me.tb_username.CustomButton.Image = Nothing
        Me.tb_username.CustomButton.Location = New System.Drawing.Point(650, 1)
        Me.tb_username.CustomButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tb_username.CustomButton.Name = ""
        Me.tb_username.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.tb_username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tb_username.CustomButton.TabIndex = 1
        Me.tb_username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tb_username.CustomButton.UseSelectable = True
        Me.tb_username.CustomButton.Visible = False
        Me.tb_username.Lines = New String(-1) {}
        Me.tb_username.Location = New System.Drawing.Point(276, 131)
        Me.tb_username.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tb_username.MaxLength = 32767
        Me.tb_username.Name = "tb_username"
        Me.tb_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_username.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tb_username.SelectedText = ""
        Me.tb_username.SelectionLength = 0
        Me.tb_username.SelectionStart = 0
        Me.tb_username.ShortcutsEnabled = True
        Me.tb_username.Size = New System.Drawing.Size(684, 35)
        Me.tb_username.Style = MetroFramework.MetroColorStyle.White
        Me.tb_username.TabIndex = 9
        Me.tb_username.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tb_username.UseSelectable = True
        Me.tb_username.UseStyleColors = True
        Me.tb_username.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tb_username.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login.FlatAppearance.BorderSize = 0
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(734, 286)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(226, 48)
        Me.btn_login.TabIndex = 8
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'cb_showpassword
        '
        Me.cb_showpassword.AutoSize = True
        Me.cb_showpassword.BackColor = System.Drawing.Color.Transparent
        Me.cb_showpassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_showpassword.ForeColor = System.Drawing.Color.White
        Me.cb_showpassword.Location = New System.Drawing.Point(276, 263)
        Me.cb_showpassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cb_showpassword.Name = "cb_showpassword"
        Me.cb_showpassword.Size = New System.Drawing.Size(105, 15)
        Me.cb_showpassword.Style = MetroFramework.MetroColorStyle.White
        Me.cb_showpassword.TabIndex = 7
        Me.cb_showpassword.Text = "Show Password"
        Me.cb_showpassword.Theme = MetroFramework.MetroThemeStyle.Light
        Me.cb_showpassword.UseCustomBackColor = True
        Me.cb_showpassword.UseCustomForeColor = True
        Me.cb_showpassword.UseSelectable = True
        Me.cb_showpassword.UseStyleColors = True
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbl_password.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lbl_password.ForeColor = System.Drawing.Color.White
        Me.lbl_password.Location = New System.Drawing.Point(268, 171)
        Me.lbl_password.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(92, 25)
        Me.lbl_password.TabIndex = 5
        Me.lbl_password.Text = "Password"
        Me.lbl_password.UseCustomBackColor = True
        Me.lbl_password.UseCustomForeColor = True
        Me.lbl_password.UseStyleColors = True
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbl_username.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lbl_username.ForeColor = System.Drawing.Color.White
        Me.lbl_username.Location = New System.Drawing.Point(268, 88)
        Me.lbl_username.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(97, 25)
        Me.lbl_username.TabIndex = 3
        Me.lbl_username.Text = "Username"
        Me.lbl_username.UseCustomBackColor = True
        Me.lbl_username.UseCustomForeColor = True
        Me.lbl_username.UseStyleColors = True
        '
        'lbl_login
        '
        Me.lbl_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_login.Location = New System.Drawing.Point(-8, 54)
        Me.lbl_login.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(1212, 65)
        Me.lbl_login.TabIndex = 3
        Me.lbl_login.Text = "LOGIN"
        Me.lbl_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_role
        '
        Me.lbl_role.BackColor = System.Drawing.Color.Transparent
        Me.lbl_role.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_role.Location = New System.Drawing.Point(-4, 114)
        Me.lbl_role.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_role.Name = "lbl_role"
        Me.lbl_role.Size = New System.Drawing.Size(1212, 68)
        Me.lbl_role.TabIndex = 4
        Me.lbl_role.Text = "PETUGAS"
        Me.lbl_role.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(487, 200)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(226, 182)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.lbl_role)
        Me.Controls.Add(Me.lbl_login)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.Padding = New System.Windows.Forms.Padding(30, 92, 30, 31)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Style = MetroFramework.MetroColorStyle.Black
        Me.Text = "  "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_login As Label
    Friend WithEvents lbl_role As Label
    Friend WithEvents lbl_username As MetroFramework.Controls.MetroLabel
    Friend WithEvents cb_showpassword As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents lbl_password As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_login As Button
    Friend WithEvents tb_password As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tb_username As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lbl_login_siswa As LinkLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
