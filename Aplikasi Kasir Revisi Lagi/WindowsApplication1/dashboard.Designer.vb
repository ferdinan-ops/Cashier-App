<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Me.panelSide = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMin = New System.Windows.Forms.PictureBox()
        Me.btnMax = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.btndaftar = New Guna.UI.WinForms.GunaButton()
        Me.panelHeader = New System.Windows.Forms.Panel()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton4 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton5 = New Guna.UI.WinForms.GunaButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.linkDaftar = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLogin = New System.Windows.Forms.Label()
        Me.panelSide.SuspendLayout()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelSide
        '
        Me.panelSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.panelSide.Controls.Add(Me.GunaButton4)
        Me.panelSide.Controls.Add(Me.GunaButton5)
        Me.panelSide.Controls.Add(Me.GunaButton2)
        Me.panelSide.Controls.Add(Me.GunaButton3)
        Me.panelSide.Controls.Add(Me.GunaButton1)
        Me.panelSide.Controls.Add(Me.Label1)
        Me.panelSide.Controls.Add(Me.btndaftar)
        Me.panelSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelSide.Location = New System.Drawing.Point(0, 0)
        Me.panelSide.Name = "panelSide"
        Me.panelSide.Size = New System.Drawing.Size(450, 1080)
        Me.panelSide.TabIndex = 33
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
        'btnMin
        '
        Me.btnMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMin.Image = CType(resources.GetObject("btnMin.Image"), System.Drawing.Image)
        Me.btnMin.Location = New System.Drawing.Point(1799, 20)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(20, 20)
        Me.btnMin.TabIndex = 44
        Me.btnMin.TabStop = False
        '
        'btnMax
        '
        Me.btnMax.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnMax.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMax.Image = CType(resources.GetObject("btnMax.Image"), System.Drawing.Image)
        Me.btnMax.Location = New System.Drawing.Point(1839, 20)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(20, 20)
        Me.btnMax.TabIndex = 43
        Me.btnMax.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(1879, 20)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(20, 20)
        Me.btnClose.TabIndex = 42
        Me.btnClose.TabStop = False
        '
        'btndaftar
        '
        Me.btndaftar.Animated = True
        Me.btndaftar.AnimationHoverSpeed = 0.07!
        Me.btndaftar.AnimationSpeed = 0.03!
        Me.btndaftar.BackColor = System.Drawing.Color.Transparent
        Me.btndaftar.BaseColor = System.Drawing.Color.White
        Me.btndaftar.BorderColor = System.Drawing.Color.White
        Me.btndaftar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndaftar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btndaftar.FocusedColor = System.Drawing.Color.Empty
        Me.btndaftar.Font = New System.Drawing.Font("Poppins", 15.70909!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndaftar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btndaftar.Image = CType(resources.GetObject("btndaftar.Image"), System.Drawing.Image)
        Me.btndaftar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btndaftar.Location = New System.Drawing.Point(54, 209)
        Me.btndaftar.Name = "btndaftar"
        Me.btndaftar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btndaftar.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btndaftar.OnHoverForeColor = System.Drawing.Color.White
        Me.btndaftar.OnHoverImage = CType(resources.GetObject("btndaftar.OnHoverImage"), System.Drawing.Image)
        Me.btndaftar.OnPressedColor = System.Drawing.Color.Black
        Me.btndaftar.Radius = 10
        Me.btndaftar.Size = New System.Drawing.Size(300, 70)
        Me.btndaftar.TabIndex = 37
        Me.btndaftar.Text = "Dashboard"
        Me.btndaftar.TextOffsetX = 20
        '
        'panelHeader
        '
        Me.panelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.panelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeader.Location = New System.Drawing.Point(450, 0)
        Me.panelHeader.Name = "panelHeader"
        Me.panelHeader.Size = New System.Drawing.Size(1470, 60)
        Me.panelHeader.TabIndex = 51
        '
        'GunaButton1
        '
        Me.GunaButton1.Animated = True
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.White
        Me.GunaButton1.BorderColor = System.Drawing.Color.White
        Me.GunaButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Poppins", 15.70909!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.GunaButton1.Image = CType(resources.GetObject("GunaButton1.Image"), System.Drawing.Image)
        Me.GunaButton1.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton1.Location = New System.Drawing.Point(54, 317)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = CType(resources.GetObject("GunaButton1.OnHoverImage"), System.Drawing.Image)
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 10
        Me.GunaButton1.Size = New System.Drawing.Size(300, 70)
        Me.GunaButton1.TabIndex = 38
        Me.GunaButton1.Text = "Pengguna"
        Me.GunaButton1.TextOffsetX = 20
        '
        'GunaButton2
        '
        Me.GunaButton2.Animated = True
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BaseColor = System.Drawing.Color.White
        Me.GunaButton2.BorderColor = System.Drawing.Color.White
        Me.GunaButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Poppins", 15.70909!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.GunaButton2.Image = CType(resources.GetObject("GunaButton2.Image"), System.Drawing.Image)
        Me.GunaButton2.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton2.Location = New System.Drawing.Point(54, 533)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = CType(resources.GetObject("GunaButton2.OnHoverImage"), System.Drawing.Image)
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Radius = 10
        Me.GunaButton2.Size = New System.Drawing.Size(300, 70)
        Me.GunaButton2.TabIndex = 40
        Me.GunaButton2.Text = "Penjualan"
        Me.GunaButton2.TextOffsetX = 20
        '
        'GunaButton3
        '
        Me.GunaButton3.Animated = True
        Me.GunaButton3.AnimationHoverSpeed = 0.07!
        Me.GunaButton3.AnimationSpeed = 0.03!
        Me.GunaButton3.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton3.BaseColor = System.Drawing.Color.White
        Me.GunaButton3.BorderColor = System.Drawing.Color.White
        Me.GunaButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton3.Font = New System.Drawing.Font("Poppins", 15.70909!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.GunaButton3.Image = CType(resources.GetObject("GunaButton3.Image"), System.Drawing.Image)
        Me.GunaButton3.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton3.Location = New System.Drawing.Point(54, 425)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverImage = CType(resources.GetObject("GunaButton3.OnHoverImage"), System.Drawing.Image)
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton3.Radius = 10
        Me.GunaButton3.Size = New System.Drawing.Size(300, 70)
        Me.GunaButton3.TabIndex = 39
        Me.GunaButton3.Text = "Barang"
        Me.GunaButton3.TextOffsetX = 20
        '
        'GunaButton4
        '
        Me.GunaButton4.Animated = True
        Me.GunaButton4.AnimationHoverSpeed = 0.07!
        Me.GunaButton4.AnimationSpeed = 0.03!
        Me.GunaButton4.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton4.BaseColor = System.Drawing.Color.White
        Me.GunaButton4.BorderColor = System.Drawing.Color.White
        Me.GunaButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton4.Font = New System.Drawing.Font("Poppins", 15.70909!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.GunaButton4.Image = CType(resources.GetObject("GunaButton4.Image"), System.Drawing.Image)
        Me.GunaButton4.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton4.Location = New System.Drawing.Point(54, 749)
        Me.GunaButton4.Name = "GunaButton4"
        Me.GunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.GunaButton4.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.GunaButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton4.OnHoverImage = CType(resources.GetObject("GunaButton4.OnHoverImage"), System.Drawing.Image)
        Me.GunaButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton4.Radius = 10
        Me.GunaButton4.Size = New System.Drawing.Size(300, 70)
        Me.GunaButton4.TabIndex = 42
        Me.GunaButton4.Text = "Logout"
        Me.GunaButton4.TextOffsetX = 20
        '
        'GunaButton5
        '
        Me.GunaButton5.Animated = True
        Me.GunaButton5.AnimationHoverSpeed = 0.07!
        Me.GunaButton5.AnimationSpeed = 0.03!
        Me.GunaButton5.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton5.BaseColor = System.Drawing.Color.White
        Me.GunaButton5.BorderColor = System.Drawing.Color.White
        Me.GunaButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton5.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton5.Font = New System.Drawing.Font("Poppins", 15.70909!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.GunaButton5.Image = CType(resources.GetObject("GunaButton5.Image"), System.Drawing.Image)
        Me.GunaButton5.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton5.Location = New System.Drawing.Point(54, 641)
        Me.GunaButton5.Name = "GunaButton5"
        Me.GunaButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.GunaButton5.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.GunaButton5.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton5.OnHoverImage = CType(resources.GetObject("GunaButton5.OnHoverImage"), System.Drawing.Image)
        Me.GunaButton5.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton5.Radius = 10
        Me.GunaButton5.Size = New System.Drawing.Size(300, 70)
        Me.GunaButton5.TabIndex = 41
        Me.GunaButton5.Text = "Laporan"
        Me.GunaButton5.TextOffsetX = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(1308, 884)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(274, 34)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Already Have an Account?"
        '
        'linkDaftar
        '
        Me.linkDaftar.AutoSize = True
        Me.linkDaftar.BackColor = System.Drawing.Color.Transparent
        Me.linkDaftar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linkDaftar.Font = New System.Drawing.Font("Poppins", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkDaftar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.linkDaftar.Location = New System.Drawing.Point(1573, 884)
        Me.linkDaftar.Name = "linkDaftar"
        Me.linkDaftar.Size = New System.Drawing.Size(68, 34)
        Me.linkDaftar.TabIndex = 41
        Me.linkDaftar.Text = "Login" & Global.Microsoft.VisualBasic.ChrW(13)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtLogin)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(450, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1470, 1020)
        Me.Panel1.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(50, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(516, 96)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Selamat Datang,"
        '
        'txtLogin
        '
        Me.txtLogin.AutoSize = True
        Me.txtLogin.Font = New System.Drawing.Font("Poppins", 18.32727!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogin.ForeColor = System.Drawing.Color.Black
        Me.txtLogin.Location = New System.Drawing.Point(58, 129)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(557, 50)
        Me.txtLogin.TabIndex = 37
        Me.txtLogin.Text = "Ferdinan Imanuel Tumanggor / Admin"
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnMin)
        Me.Controls.Add(Me.btnMax)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.linkDaftar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.panelHeader)
        Me.Controls.Add(Me.panelSide)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelSide.ResumeLayout(False)
        Me.panelSide.PerformLayout()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelSide As System.Windows.Forms.Panel
    Friend WithEvents GunaButton4 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton5 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btndaftar As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnMin As System.Windows.Forms.PictureBox
    Friend WithEvents btnMax As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As System.Windows.Forms.PictureBox
    Friend WithEvents panelHeader As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents linkDaftar As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtLogin As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
