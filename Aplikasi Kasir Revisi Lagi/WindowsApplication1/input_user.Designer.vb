<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class input_user
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(input_user))
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKodeUser = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtNama = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtUsername = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtPassword = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLineTextBox4 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSimpan = New Guna.UI.WinForms.GunaButton()
        Me.btnHapus = New Guna.UI.WinForms.GunaButton()
        Me.cbLevel = New Guna.UI.WinForms.GunaComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Poppins", 18.32727!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(23, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(278, 42)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "CRUD Pengguna"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Poppins SemiBold", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(26, 325)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 27)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Level :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Poppins SemiBold", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Location = New System.Drawing.Point(26, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 27)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Password :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Poppins SemiBold", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(26, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 27)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Nama User :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Poppins SemiBold", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(26, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 27)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Username :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins SemiBold", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(26, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 27)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Kode User :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtKodeUser
        '
        Me.txtKodeUser.BackColor = System.Drawing.Color.White
        Me.txtKodeUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKodeUser.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.txtKodeUser.Font = New System.Drawing.Font("Poppins", 11.12727!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeUser.LineColor = System.Drawing.Color.Black
        Me.txtKodeUser.LineSize = 2
        Me.txtKodeUser.Location = New System.Drawing.Point(177, 132)
        Me.txtKodeUser.Name = "txtKodeUser"
        Me.txtKodeUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKodeUser.SelectedText = ""
        Me.txtKodeUser.Size = New System.Drawing.Size(300, 36)
        Me.txtKodeUser.TabIndex = 66
        '
        'txtNama
        '
        Me.txtNama.BackColor = System.Drawing.Color.White
        Me.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNama.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.txtNama.Font = New System.Drawing.Font("Poppins", 11.12727!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.LineColor = System.Drawing.Color.Black
        Me.txtNama.LineSize = 2
        Me.txtNama.Location = New System.Drawing.Point(177, 178)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNama.SelectedText = ""
        Me.txtNama.Size = New System.Drawing.Size(300, 36)
        Me.txtNama.TabIndex = 67
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.txtUsername.Font = New System.Drawing.Font("Poppins", 11.12727!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.LineColor = System.Drawing.Color.Black
        Me.txtUsername.LineSize = 2
        Me.txtUsername.Location = New System.Drawing.Point(177, 224)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(300, 36)
        Me.txtUsername.TabIndex = 68
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Poppins", 11.12727!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.LineColor = System.Drawing.Color.Black
        Me.txtPassword.LineSize = 2
        Me.txtPassword.Location = New System.Drawing.Point(177, 270)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(300, 36)
        Me.txtPassword.TabIndex = 69
        '
        'GunaLineTextBox4
        '
        Me.GunaLineTextBox4.BackColor = System.Drawing.Color.White
        Me.GunaLineTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox4.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.GunaLineTextBox4.Font = New System.Drawing.Font("Poppins", 11.12727!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLineTextBox4.LineColor = System.Drawing.Color.Black
        Me.GunaLineTextBox4.LineSize = 2
        Me.GunaLineTextBox4.Location = New System.Drawing.Point(177, 316)
        Me.GunaLineTextBox4.Name = "GunaLineTextBox4"
        Me.GunaLineTextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox4.SelectedText = ""
        Me.GunaLineTextBox4.Size = New System.Drawing.Size(300, 36)
        Me.GunaLineTextBox4.TabIndex = 70
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(489, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.TabIndex = 71
        Me.PictureBox1.TabStop = False
        '
        'btnSimpan
        '
        Me.btnSimpan.Animated = True
        Me.btnSimpan.AnimationHoverSpeed = 0.07!
        Me.btnSimpan.AnimationSpeed = 0.03!
        Me.btnSimpan.BackColor = System.Drawing.Color.Transparent
        Me.btnSimpan.BaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnSimpan.BorderColor = System.Drawing.Color.White
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpan.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSimpan.FocusedColor = System.Drawing.Color.Empty
        Me.btnSimpan.Font = New System.Drawing.Font("Poppins", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Image = Nothing
        Me.btnSimpan.ImageOffsetX = 10
        Me.btnSimpan.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnSimpan.Location = New System.Drawing.Point(237, 397)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnSimpan.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnSimpan.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSimpan.OnHoverImage = Nothing
        Me.btnSimpan.OnPressedColor = System.Drawing.Color.Black
        Me.btnSimpan.Radius = 5
        Me.btnSimpan.Size = New System.Drawing.Size(100, 50)
        Me.btnSimpan.TabIndex = 72
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnHapus
        '
        Me.btnHapus.Animated = True
        Me.btnHapus.AnimationHoverSpeed = 0.07!
        Me.btnHapus.AnimationSpeed = 0.03!
        Me.btnHapus.BackColor = System.Drawing.Color.Transparent
        Me.btnHapus.BaseColor = System.Drawing.Color.White
        Me.btnHapus.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnHapus.BorderSize = 1
        Me.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapus.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnHapus.FocusedColor = System.Drawing.Color.Empty
        Me.btnHapus.Font = New System.Drawing.Font("Poppins", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnHapus.Image = Nothing
        Me.btnHapus.ImageOffsetX = 10
        Me.btnHapus.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnHapus.Location = New System.Drawing.Point(377, 397)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnHapus.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnHapus.OnHoverForeColor = System.Drawing.Color.White
        Me.btnHapus.OnHoverImage = Nothing
        Me.btnHapus.OnPressedColor = System.Drawing.Color.Black
        Me.btnHapus.Radius = 5
        Me.btnHapus.Size = New System.Drawing.Size(100, 50)
        Me.btnHapus.TabIndex = 73
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbLevel
        '
        Me.cbLevel.BackColor = System.Drawing.Color.Transparent
        Me.cbLevel.BaseColor = System.Drawing.Color.White
        Me.cbLevel.BorderColor = System.Drawing.Color.Black
        Me.cbLevel.BorderSize = 0
        Me.cbLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLevel.FocusedColor = System.Drawing.Color.Empty
        Me.cbLevel.Font = New System.Drawing.Font("Poppins", 11.12727!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLevel.ForeColor = System.Drawing.Color.Black
        Me.cbLevel.FormattingEnabled = True
        Me.cbLevel.Items.AddRange(New Object() {"Admin", "Karyawan"})
        Me.cbLevel.Location = New System.Drawing.Point(177, 315)
        Me.cbLevel.Name = "cbLevel"
        Me.cbLevel.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.cbLevel.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbLevel.Radius = 5
        Me.cbLevel.Size = New System.Drawing.Size(300, 34)
        Me.cbLevel.TabIndex = 74
        '
        'input_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(525, 482)
        Me.Controls.Add(Me.cbLevel)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GunaLineTextBox4)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtKodeUser)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "input_user"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "crudUser"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKodeUser As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtNama As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtUsername As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtPassword As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLineTextBox4 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSimpan As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnHapus As Guna.UI.WinForms.GunaButton
    Friend WithEvents cbLevel As Guna.UI.WinForms.GunaComboBox
End Class
