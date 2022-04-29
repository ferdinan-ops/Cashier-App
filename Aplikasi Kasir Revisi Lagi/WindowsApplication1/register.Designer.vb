<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(register))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.linkDaftar = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPassword = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtNama = New Guna.UI.WinForms.GunaLineTextBox()
        Me.btndaftar = New Guna.UI.WinForms.GunaButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMin = New System.Windows.Forms.PictureBox()
        Me.btnMax = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.txtUsername = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbLevel = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLineTextBox2 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.kodeUser = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(960, 1080)
        Me.Panel1.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(150, 300)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(659, 480)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 28.14545!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(60, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 76)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOGO"
        '
        'linkDaftar
        '
        Me.linkDaftar.AutoSize = True
        Me.linkDaftar.BackColor = System.Drawing.Color.Transparent
        Me.linkDaftar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linkDaftar.Font = New System.Drawing.Font("Poppins", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkDaftar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.linkDaftar.Location = New System.Drawing.Point(1568, 884)
        Me.linkDaftar.Name = "linkDaftar"
        Me.linkDaftar.Size = New System.Drawing.Size(68, 34)
        Me.linkDaftar.TabIndex = 22
        Me.linkDaftar.Text = "Login" & Global.Microsoft.VisualBasic.ChrW(13)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(1303, 884)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(274, 34)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Already Have an Account?"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Poppins", 20.29091!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.LineColor = System.Drawing.Color.Black
        Me.txtPassword.LineSize = 5
        Me.txtPassword.Location = New System.Drawing.Point(1118, 599)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(302, 57)
        Me.txtPassword.TabIndex = 20
        '
        'txtNama
        '
        Me.txtNama.BackColor = System.Drawing.Color.White
        Me.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNama.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.txtNama.Font = New System.Drawing.Font("Poppins", 13.74545!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.LineColor = System.Drawing.Color.Black
        Me.txtNama.LineSize = 5
        Me.txtNama.Location = New System.Drawing.Point(1120, 390)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNama.SelectedText = ""
        Me.txtNama.Size = New System.Drawing.Size(300, 57)
        Me.txtNama.TabIndex = 19
        '
        'btndaftar
        '
        Me.btndaftar.Animated = True
        Me.btndaftar.AnimationHoverSpeed = 0.07!
        Me.btndaftar.AnimationSpeed = 0.03!
        Me.btndaftar.BackColor = System.Drawing.Color.Transparent
        Me.btndaftar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btndaftar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btndaftar.BorderSize = 2
        Me.btndaftar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndaftar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btndaftar.FocusedColor = System.Drawing.Color.Empty
        Me.btndaftar.Font = New System.Drawing.Font("Poppins", 15.70909!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndaftar.ForeColor = System.Drawing.Color.White
        Me.btndaftar.Image = Nothing
        Me.btndaftar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btndaftar.Location = New System.Drawing.Point(1118, 763)
        Me.btndaftar.Name = "btndaftar"
        Me.btndaftar.OnHoverBaseColor = System.Drawing.Color.White
        Me.btndaftar.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btndaftar.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btndaftar.OnHoverImage = Nothing
        Me.btndaftar.OnPressedColor = System.Drawing.Color.Black
        Me.btndaftar.Radius = 10
        Me.btndaftar.Size = New System.Drawing.Size(700, 70)
        Me.btndaftar.TabIndex = 18
        Me.btndaftar.Text = "Register"
        Me.btndaftar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 18.32727!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(1109, 526)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 50)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 18.32727!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(1109, 317)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 50)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(1095, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(274, 96)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Register"
        '
        'btnMin
        '
        Me.btnMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMin.Image = CType(resources.GetObject("btnMin.Image"), System.Drawing.Image)
        Me.btnMin.Location = New System.Drawing.Point(1810, 20)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(20, 20)
        Me.btnMin.TabIndex = 25
        Me.btnMin.TabStop = False
        '
        'btnMax
        '
        Me.btnMax.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMax.Image = CType(resources.GetObject("btnMax.Image"), System.Drawing.Image)
        Me.btnMax.Location = New System.Drawing.Point(1850, 20)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(20, 20)
        Me.btnMax.TabIndex = 24
        Me.btnMax.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(1890, 20)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(20, 20)
        Me.btnClose.TabIndex = 23
        Me.btnClose.TabStop = False
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.txtUsername.Font = New System.Drawing.Font("Poppins", 13.74545!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.LineColor = System.Drawing.Color.Black
        Me.txtUsername.LineSize = 5
        Me.txtUsername.Location = New System.Drawing.Point(1516, 390)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(300, 57)
        Me.txtUsername.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 18.32727!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(1505, 317)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 50)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Username"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 18.32727!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(1505, 526)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 50)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Level"
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
        Me.cbLevel.Font = New System.Drawing.Font("Poppins", 18.32727!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLevel.ForeColor = System.Drawing.Color.Black
        Me.cbLevel.FormattingEnabled = True
        Me.cbLevel.Location = New System.Drawing.Point(1516, 606)
        Me.cbLevel.Name = "cbLevel"
        Me.cbLevel.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.cbLevel.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbLevel.Radius = 5
        Me.cbLevel.Size = New System.Drawing.Size(300, 50)
        Me.cbLevel.TabIndex = 30
        '
        'GunaLineTextBox2
        '
        Me.GunaLineTextBox2.BackColor = System.Drawing.Color.White
        Me.GunaLineTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaLineTextBox2.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.GunaLineTextBox2.Font = New System.Drawing.Font("Poppins", 20.29091!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLineTextBox2.LineColor = System.Drawing.Color.Black
        Me.GunaLineTextBox2.LineSize = 5
        Me.GunaLineTextBox2.Location = New System.Drawing.Point(1514, 606)
        Me.GunaLineTextBox2.Name = "GunaLineTextBox2"
        Me.GunaLineTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox2.SelectedText = ""
        Me.GunaLineTextBox2.Size = New System.Drawing.Size(302, 57)
        Me.GunaLineTextBox2.TabIndex = 31
        '
        'kodeUser
        '
        Me.kodeUser.AutoSize = True
        Me.kodeUser.Location = New System.Drawing.Point(1445, 95)
        Me.kodeUser.Name = "kodeUser"
        Me.kodeUser.Size = New System.Drawing.Size(57, 13)
        Me.kodeUser.TabIndex = 32
        Me.kodeUser.Text = "Kode User"
        Me.kodeUser.Visible = False
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.kodeUser)
        Me.Controls.Add(Me.cbLevel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnMin)
        Me.Controls.Add(Me.btnMax)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.linkDaftar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.btndaftar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GunaLineTextBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "register"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "register"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMin As System.Windows.Forms.PictureBox
    Friend WithEvents btnMax As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As System.Windows.Forms.PictureBox
    Friend WithEvents linkDaftar As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtNama As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents btndaftar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbLevel As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLineTextBox2 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents kodeUser As System.Windows.Forms.Label
End Class
