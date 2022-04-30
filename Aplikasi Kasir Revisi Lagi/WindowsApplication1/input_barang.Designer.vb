<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class input_barang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(input_barang))
        Me.btnHapus = New Guna.UI.WinForms.GunaButton()
        Me.btnSimpan = New Guna.UI.WinForms.GunaButton()
        Me.txtHargaBeli = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtSatuan = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtJenis = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtNama = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtKodeBarang = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtStok = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtHargaJual = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbJenis = New Guna.UI.WinForms.GunaComboBox()
        Me.cbSatuan = New Guna.UI.WinForms.GunaComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btnHapus.Location = New System.Drawing.Point(416, 476)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnHapus.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnHapus.OnHoverForeColor = System.Drawing.Color.White
        Me.btnHapus.OnHoverImage = Nothing
        Me.btnHapus.OnPressedColor = System.Drawing.Color.Black
        Me.btnHapus.Radius = 5
        Me.btnHapus.Size = New System.Drawing.Size(100, 50)
        Me.btnHapus.TabIndex = 88
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnSimpan.Location = New System.Drawing.Point(276, 476)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnSimpan.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnSimpan.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSimpan.OnHoverImage = Nothing
        Me.btnSimpan.OnPressedColor = System.Drawing.Color.Black
        Me.btnSimpan.Radius = 5
        Me.btnSimpan.Size = New System.Drawing.Size(100, 50)
        Me.btnSimpan.TabIndex = 87
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHargaBeli
        '
        Me.txtHargaBeli.BackColor = System.Drawing.Color.White
        Me.txtHargaBeli.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHargaBeli.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.txtHargaBeli.Font = New System.Drawing.Font("Poppins", 11.12727!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHargaBeli.LineColor = System.Drawing.Color.Black
        Me.txtHargaBeli.LineSize = 2
        Me.txtHargaBeli.Location = New System.Drawing.Point(216, 301)
        Me.txtHargaBeli.Name = "txtHargaBeli"
        Me.txtHargaBeli.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHargaBeli.SelectedText = ""
        Me.txtHargaBeli.Size = New System.Drawing.Size(300, 36)
        Me.txtHargaBeli.TabIndex = 85
        '
        'txtSatuan
        '
        Me.txtSatuan.BackColor = System.Drawing.Color.White
        Me.txtSatuan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSatuan.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.txtSatuan.Font = New System.Drawing.Font("Poppins", 11.12727!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSatuan.LineColor = System.Drawing.Color.Black
        Me.txtSatuan.LineSize = 2
        Me.txtSatuan.Location = New System.Drawing.Point(216, 255)
        Me.txtSatuan.Name = "txtSatuan"
        Me.txtSatuan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSatuan.SelectedText = ""
        Me.txtSatuan.Size = New System.Drawing.Size(300, 36)
        Me.txtSatuan.TabIndex = 84
        '
        'txtJenis
        '
        Me.txtJenis.BackColor = System.Drawing.Color.White
        Me.txtJenis.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtJenis.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.txtJenis.Font = New System.Drawing.Font("Poppins", 11.12727!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJenis.LineColor = System.Drawing.Color.Black
        Me.txtJenis.LineSize = 2
        Me.txtJenis.Location = New System.Drawing.Point(216, 209)
        Me.txtJenis.Name = "txtJenis"
        Me.txtJenis.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJenis.SelectedText = ""
        Me.txtJenis.Size = New System.Drawing.Size(300, 36)
        Me.txtJenis.TabIndex = 83
        '
        'txtNama
        '
        Me.txtNama.BackColor = System.Drawing.Color.White
        Me.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNama.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.txtNama.Font = New System.Drawing.Font("Poppins", 11.12727!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.LineColor = System.Drawing.Color.Black
        Me.txtNama.LineSize = 2
        Me.txtNama.Location = New System.Drawing.Point(216, 163)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNama.SelectedText = ""
        Me.txtNama.Size = New System.Drawing.Size(300, 36)
        Me.txtNama.TabIndex = 82
        '
        'txtKodeBarang
        '
        Me.txtKodeBarang.BackColor = System.Drawing.Color.White
        Me.txtKodeBarang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKodeBarang.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.txtKodeBarang.Font = New System.Drawing.Font("Poppins", 11.12727!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeBarang.LineColor = System.Drawing.Color.Black
        Me.txtKodeBarang.LineSize = 2
        Me.txtKodeBarang.Location = New System.Drawing.Point(216, 117)
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKodeBarang.SelectedText = ""
        Me.txtKodeBarang.Size = New System.Drawing.Size(300, 36)
        Me.txtKodeBarang.TabIndex = 81
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Poppins SemiBold", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(65, 310)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 27)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Harga Beli :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Poppins SemiBold", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Location = New System.Drawing.Point(32, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 27)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Satuan Barang :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Poppins SemiBold", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(36, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 27)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Nama Barang :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Poppins SemiBold", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(55, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 27)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Jenis Barang :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins SemiBold", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(49, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 27)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Kode Barang :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Poppins", 18.32727!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(33, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(278, 42)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "CRUD Barang"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(528, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.TabIndex = 86
        Me.PictureBox1.TabStop = False
        '
        'txtStok
        '
        Me.txtStok.BackColor = System.Drawing.Color.White
        Me.txtStok.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStok.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.txtStok.Font = New System.Drawing.Font("Poppins", 11.12727!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStok.LineColor = System.Drawing.Color.Black
        Me.txtStok.LineSize = 2
        Me.txtStok.Location = New System.Drawing.Point(216, 389)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStok.SelectedText = ""
        Me.txtStok.Size = New System.Drawing.Size(300, 36)
        Me.txtStok.TabIndex = 92
        '
        'txtHargaJual
        '
        Me.txtHargaJual.BackColor = System.Drawing.Color.White
        Me.txtHargaJual.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHargaJual.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.txtHargaJual.Font = New System.Drawing.Font("Poppins", 11.12727!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHargaJual.LineColor = System.Drawing.Color.Black
        Me.txtHargaJual.LineSize = 2
        Me.txtHargaJual.Location = New System.Drawing.Point(216, 343)
        Me.txtHargaJual.Name = "txtHargaJual"
        Me.txtHargaJual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHargaJual.SelectedText = ""
        Me.txtHargaJual.Size = New System.Drawing.Size(300, 36)
        Me.txtHargaJual.TabIndex = 91
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Poppins SemiBold", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(65, 398)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 27)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Stok Barang :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Poppins SemiBold", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Location = New System.Drawing.Point(32, 352)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(178, 27)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "Harga Jual :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbJenis
        '
        Me.cbJenis.BackColor = System.Drawing.Color.Transparent
        Me.cbJenis.BaseColor = System.Drawing.Color.White
        Me.cbJenis.BorderColor = System.Drawing.Color.Black
        Me.cbJenis.BorderSize = 0
        Me.cbJenis.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbJenis.FocusedColor = System.Drawing.Color.Empty
        Me.cbJenis.Font = New System.Drawing.Font("Poppins", 11.12727!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbJenis.ForeColor = System.Drawing.Color.Black
        Me.cbJenis.FormattingEnabled = True
        Me.cbJenis.Items.AddRange(New Object() {"Hanphone", "Aksesoris"})
        Me.cbJenis.Location = New System.Drawing.Point(216, 209)
        Me.cbJenis.Name = "cbJenis"
        Me.cbJenis.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.cbJenis.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbJenis.Radius = 5
        Me.cbJenis.Size = New System.Drawing.Size(300, 34)
        Me.cbJenis.TabIndex = 93
        '
        'cbSatuan
        '
        Me.cbSatuan.BackColor = System.Drawing.Color.Transparent
        Me.cbSatuan.BaseColor = System.Drawing.Color.White
        Me.cbSatuan.BorderColor = System.Drawing.Color.Black
        Me.cbSatuan.BorderSize = 0
        Me.cbSatuan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSatuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSatuan.FocusedColor = System.Drawing.Color.Empty
        Me.cbSatuan.Font = New System.Drawing.Font("Poppins", 11.12727!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSatuan.ForeColor = System.Drawing.Color.Black
        Me.cbSatuan.FormattingEnabled = True
        Me.cbSatuan.Items.AddRange(New Object() {"pcs", "Lusin", "Bungkus", "Pack"})
        Me.cbSatuan.Location = New System.Drawing.Point(216, 255)
        Me.cbSatuan.Name = "cbSatuan"
        Me.cbSatuan.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.cbSatuan.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbSatuan.Radius = 5
        Me.cbSatuan.Size = New System.Drawing.Size(300, 34)
        Me.cbSatuan.TabIndex = 94
        '
        'input_barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(564, 572)
        Me.Controls.Add(Me.cbSatuan)
        Me.Controls.Add(Me.cbJenis)
        Me.Controls.Add(Me.txtStok)
        Me.Controls.Add(Me.txtHargaJual)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtHargaBeli)
        Me.Controls.Add(Me.txtSatuan)
        Me.Controls.Add(Me.txtJenis)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtKodeBarang)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "input_barang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "input_barang"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnHapus As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnSimpan As Guna.UI.WinForms.GunaButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtHargaBeli As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtSatuan As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtJenis As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtNama As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtKodeBarang As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtStok As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtHargaJual As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbJenis As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cbSatuan As Guna.UI.WinForms.GunaComboBox
End Class
