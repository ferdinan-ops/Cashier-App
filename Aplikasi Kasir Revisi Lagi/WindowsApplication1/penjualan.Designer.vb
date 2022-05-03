<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class penjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(penjualan))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelHeader = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnMin = New System.Windows.Forms.PictureBox()
        Me.btnMax = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.btnLogin = New Guna.UI.WinForms.GunaButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.v0nomorfaktur = New Guna.UI.WinForms.GunaTextBox()
        Me.v0jam = New Guna.UI.WinForms.GunaTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.v0kasir = New Guna.UI.WinForms.GunaTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.v0tanggal = New Guna.UI.WinForms.GunaTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.v0grandtotal = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.v0jumlah = New System.Windows.Forms.TextBox()
        Me.v0hargabarang = New System.Windows.Forms.TextBox()
        Me.v0satuanbarang = New System.Windows.Forms.TextBox()
        Me.v0jenisbarang = New System.Windows.Forms.TextBox()
        Me.v0namabarang = New System.Windows.Forms.TextBox()
        Me.v0kodebarang = New System.Windows.Forms.TextBox()
        Me.v0totalharga = New System.Windows.Forms.TextBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.v0dibayar = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GunaElipsePanel3 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.v0kembalian = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.panelHeader.SuspendLayout()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaElipsePanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaElipsePanel2.SuspendLayout()
        Me.GunaElipsePanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelHeader
        '
        Me.panelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.panelHeader.Controls.Add(Me.Label1)
        Me.panelHeader.Controls.Add(Me.btnMin)
        Me.panelHeader.Controls.Add(Me.btnMax)
        Me.panelHeader.Controls.Add(Me.btnClose)
        Me.panelHeader.Controls.Add(Me.Label11)
        Me.panelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeader.Location = New System.Drawing.Point(0, 0)
        Me.panelHeader.Name = "panelHeader"
        Me.panelHeader.Size = New System.Drawing.Size(1920, 60)
        Me.panelHeader.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Poppins", 26.18182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(60, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 60)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "LOGO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Poppins", 13.74545!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(703, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 37)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "12.45 PM"
        '
        'btnMin
        '
        Me.btnMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMin.Image = CType(resources.GetObject("btnMin.Image"), System.Drawing.Image)
        Me.btnMin.Location = New System.Drawing.Point(1799, 20)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(20, 20)
        Me.btnMin.TabIndex = 47
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
        Me.btnMax.TabIndex = 46
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
        Me.btnClose.TabIndex = 45
        Me.btnClose.TabStop = False
        '
        'btnLogin
        '
        Me.btnLogin.Animated = True
        Me.btnLogin.AnimationHoverSpeed = 0.07!
        Me.btnLogin.AnimationSpeed = 0.03!
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.BaseColor = System.Drawing.Color.White
        Me.btnLogin.BorderColor = System.Drawing.Color.Black
        Me.btnLogin.BorderSize = 1
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLogin.FocusedColor = System.Drawing.Color.Empty
        Me.btnLogin.Font = New System.Drawing.Font("Poppins", 15.70909!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Image = Nothing
        Me.btnLogin.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnLogin.Location = New System.Drawing.Point(73, 88)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.OnHoverBaseColor = System.Drawing.Color.White
        Me.btnLogin.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnLogin.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnLogin.OnHoverImage = Nothing
        Me.btnLogin.OnPressedColor = System.Drawing.Color.Black
        Me.btnLogin.Radius = 10
        Me.btnLogin.Size = New System.Drawing.Size(469, 259)
        Me.btnLogin.TabIndex = 54
        Me.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Poppins", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(88, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(432, 37)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Transaksi"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Poppins SemiBold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(83, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 28)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Nomor Faktur"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'v0nomorfaktur
        '
        Me.v0nomorfaktur.BackColor = System.Drawing.Color.Transparent
        Me.v0nomorfaktur.BaseColor = System.Drawing.Color.White
        Me.v0nomorfaktur.BorderColor = System.Drawing.Color.Black
        Me.v0nomorfaktur.BorderSize = 1
        Me.v0nomorfaktur.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.v0nomorfaktur.FocusedBaseColor = System.Drawing.Color.White
        Me.v0nomorfaktur.FocusedBorderColor = System.Drawing.Color.Black
        Me.v0nomorfaktur.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.v0nomorfaktur.Font = New System.Drawing.Font("Poppins", 9.163636!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0nomorfaktur.Location = New System.Drawing.Point(88, 207)
        Me.v0nomorfaktur.Name = "v0nomorfaktur"
        Me.v0nomorfaktur.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.v0nomorfaktur.Radius = 5
        Me.v0nomorfaktur.SelectedText = ""
        Me.v0nomorfaktur.Size = New System.Drawing.Size(194, 31)
        Me.v0nomorfaktur.TabIndex = 57
        '
        'v0jam
        '
        Me.v0jam.BackColor = System.Drawing.Color.Transparent
        Me.v0jam.BaseColor = System.Drawing.Color.White
        Me.v0jam.BorderColor = System.Drawing.Color.Black
        Me.v0jam.BorderSize = 1
        Me.v0jam.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.v0jam.FocusedBaseColor = System.Drawing.Color.White
        Me.v0jam.FocusedBorderColor = System.Drawing.Color.Black
        Me.v0jam.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.v0jam.Font = New System.Drawing.Font("Poppins", 9.163636!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0jam.Location = New System.Drawing.Point(90, 291)
        Me.v0jam.Name = "v0jam"
        Me.v0jam.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.v0jam.Radius = 5
        Me.v0jam.SelectedText = ""
        Me.v0jam.Size = New System.Drawing.Size(192, 31)
        Me.v0jam.TabIndex = 59
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Poppins SemiBold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(85, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 28)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Jam"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'v0kasir
        '
        Me.v0kasir.BackColor = System.Drawing.Color.Transparent
        Me.v0kasir.BaseColor = System.Drawing.Color.White
        Me.v0kasir.BorderColor = System.Drawing.Color.Black
        Me.v0kasir.BorderSize = 1
        Me.v0kasir.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.v0kasir.FocusedBaseColor = System.Drawing.Color.White
        Me.v0kasir.FocusedBorderColor = System.Drawing.Color.Black
        Me.v0kasir.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.v0kasir.Font = New System.Drawing.Font("Poppins", 9.163636!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0kasir.Location = New System.Drawing.Point(328, 291)
        Me.v0kasir.Name = "v0kasir"
        Me.v0kasir.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.v0kasir.Radius = 5
        Me.v0kasir.SelectedText = ""
        Me.v0kasir.Size = New System.Drawing.Size(192, 31)
        Me.v0kasir.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Poppins SemiBold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(323, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 28)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Kasir"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'v0tanggal
        '
        Me.v0tanggal.BackColor = System.Drawing.Color.Transparent
        Me.v0tanggal.BaseColor = System.Drawing.Color.White
        Me.v0tanggal.BorderColor = System.Drawing.Color.Black
        Me.v0tanggal.BorderSize = 1
        Me.v0tanggal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.v0tanggal.FocusedBaseColor = System.Drawing.Color.White
        Me.v0tanggal.FocusedBorderColor = System.Drawing.Color.Black
        Me.v0tanggal.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.v0tanggal.Font = New System.Drawing.Font("Poppins", 9.163636!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0tanggal.Location = New System.Drawing.Point(326, 207)
        Me.v0tanggal.Name = "v0tanggal"
        Me.v0tanggal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.v0tanggal.Radius = 5
        Me.v0tanggal.SelectedText = ""
        Me.v0tanggal.Size = New System.Drawing.Size(194, 31)
        Me.v0tanggal.TabIndex = 61
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Poppins SemiBold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(321, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 28)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Tanggal"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.Black
        Me.GunaElipsePanel1.Controls.Add(Me.v0grandtotal)
        Me.GunaElipsePanel1.Controls.Add(Me.Label8)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(610, 88)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 10
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(1216, 259)
        Me.GunaElipsePanel1.TabIndex = 64
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Poppins", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(1001, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(432, 37)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Grand Total"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins", 47.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(62, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(166, 130)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Rp."
        '
        'v0grandtotal
        '
        Me.v0grandtotal.Font = New System.Drawing.Font("Poppins", 47.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0grandtotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.v0grandtotal.Location = New System.Drawing.Point(234, 80)
        Me.v0grandtotal.Name = "v0grandtotal"
        Me.v0grandtotal.Size = New System.Drawing.Size(909, 130)
        Me.v0grandtotal.TabIndex = 67
        Me.v0grandtotal.Text = "2.000.000"
        Me.v0grandtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(73, 407)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1753, 366)
        Me.DataGridView1.TabIndex = 66
        '
        'v0jumlah
        '
        Me.v0jumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0jumlah.Location = New System.Drawing.Point(1452, 378)
        Me.v0jumlah.Name = "v0jumlah"
        Me.v0jumlah.Size = New System.Drawing.Size(153, 28)
        Me.v0jumlah.TabIndex = 72
        Me.v0jumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'v0hargabarang
        '
        Me.v0hargabarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0hargabarang.Location = New System.Drawing.Point(1252, 378)
        Me.v0hargabarang.Name = "v0hargabarang"
        Me.v0hargabarang.ReadOnly = True
        Me.v0hargabarang.Size = New System.Drawing.Size(203, 28)
        Me.v0hargabarang.TabIndex = 71
        Me.v0hargabarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'v0satuanbarang
        '
        Me.v0satuanbarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0satuanbarang.Location = New System.Drawing.Point(1052, 378)
        Me.v0satuanbarang.Name = "v0satuanbarang"
        Me.v0satuanbarang.ReadOnly = True
        Me.v0satuanbarang.Size = New System.Drawing.Size(203, 28)
        Me.v0satuanbarang.TabIndex = 70
        '
        'v0jenisbarang
        '
        Me.v0jenisbarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0jenisbarang.Location = New System.Drawing.Point(849, 378)
        Me.v0jenisbarang.Name = "v0jenisbarang"
        Me.v0jenisbarang.ReadOnly = True
        Me.v0jenisbarang.Size = New System.Drawing.Size(206, 28)
        Me.v0jenisbarang.TabIndex = 69
        '
        'v0namabarang
        '
        Me.v0namabarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0namabarang.Location = New System.Drawing.Point(313, 378)
        Me.v0namabarang.Name = "v0namabarang"
        Me.v0namabarang.ReadOnly = True
        Me.v0namabarang.Size = New System.Drawing.Size(540, 28)
        Me.v0namabarang.TabIndex = 68
        '
        'v0kodebarang
        '
        Me.v0kodebarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0kodebarang.Location = New System.Drawing.Point(113, 378)
        Me.v0kodebarang.Name = "v0kodebarang"
        Me.v0kodebarang.Size = New System.Drawing.Size(204, 28)
        Me.v0kodebarang.TabIndex = 67
        '
        'v0totalharga
        '
        Me.v0totalharga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0totalharga.Location = New System.Drawing.Point(1604, 378)
        Me.v0totalharga.Name = "v0totalharga"
        Me.v0totalharga.ReadOnly = True
        Me.v0totalharga.Size = New System.Drawing.Size(220, 28)
        Me.v0totalharga.TabIndex = 73
        Me.v0totalharga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Column1
        '
        Me.Column1.HeaderText = "Kode Barang"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 200
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama Barang"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 540
        '
        'Column3
        '
        Me.Column3.HeaderText = "Jenis Barang"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.HeaderText = "Satuan Barang"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 200
        '
        'Column5
        '
        Me.Column5.HeaderText = "Harga Barang"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 200
        '
        'Column6
        '
        Me.Column6.HeaderText = "QTY"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 150
        '
        'Column7
        '
        Me.Column7.HeaderText = "Total Harga"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 220
        '
        'GunaButton1
        '
        Me.GunaButton1.Animated = True
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.White
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.BorderSize = 1
        Me.GunaButton1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Poppins", 15.70909!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(73, 809)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 10
        Me.GunaButton1.Size = New System.Drawing.Size(1753, 233)
        Me.GunaButton1.TabIndex = 74
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel2.BaseColor = System.Drawing.Color.Black
        Me.GunaElipsePanel2.Controls.Add(Me.v0dibayar)
        Me.GunaElipsePanel2.Controls.Add(Me.Label12)
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(94, 847)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Radius = 10
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(716, 182)
        Me.GunaElipsePanel2.TabIndex = 75
        '
        'v0dibayar
        '
        Me.v0dibayar.Font = New System.Drawing.Font("Poppins", 28.14545!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0dibayar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.v0dibayar.Location = New System.Drawing.Point(216, 67)
        Me.v0dibayar.Name = "v0dibayar"
        Me.v0dibayar.Size = New System.Drawing.Size(497, 76)
        Me.v0dibayar.TabIndex = 67
        Me.v0dibayar.Text = "2.000.000"
        Me.v0dibayar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Poppins", 28.14545!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(13, 67)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 76)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Rp."
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Poppins", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(346, 825)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(210, 37)
        Me.Label13.TabIndex = 76
        Me.Label13.Text = "Dibayar"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Poppins", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(1085, 825)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(210, 37)
        Me.Label14.TabIndex = 78
        Me.Label14.Text = "Kembalian"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaElipsePanel3
        '
        Me.GunaElipsePanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel3.BaseColor = System.Drawing.Color.Black
        Me.GunaElipsePanel3.Controls.Add(Me.v0kembalian)
        Me.GunaElipsePanel3.Controls.Add(Me.Label16)
        Me.GunaElipsePanel3.Location = New System.Drawing.Point(833, 847)
        Me.GunaElipsePanel3.Name = "GunaElipsePanel3"
        Me.GunaElipsePanel3.Radius = 10
        Me.GunaElipsePanel3.Size = New System.Drawing.Size(716, 182)
        Me.GunaElipsePanel3.TabIndex = 77
        '
        'v0kembalian
        '
        Me.v0kembalian.Font = New System.Drawing.Font("Poppins", 28.14545!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0kembalian.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.v0kembalian.Location = New System.Drawing.Point(216, 67)
        Me.v0kembalian.Name = "v0kembalian"
        Me.v0kembalian.Size = New System.Drawing.Size(497, 76)
        Me.v0kembalian.TabIndex = 67
        Me.v0kembalian.Text = "2.000.000"
        Me.v0kembalian.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Poppins", 28.14545!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(13, 67)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 76)
        Me.Label16.TabIndex = 66
        Me.Label16.Text = "Rp."
        '
        'GunaButton2
        '
        Me.GunaButton2.Animated = True
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.GunaButton2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.GunaButton2.BorderSize = 2
        Me.GunaButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Poppins", 15.70909!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton2.ForeColor = System.Drawing.Color.White
        Me.GunaButton2.Image = Nothing
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(1592, 900)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Radius = 10
        Me.GunaButton2.Size = New System.Drawing.Size(186, 70)
        Me.GunaButton2.TabIndex = 79
        Me.GunaButton2.Text = "Simpan"
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.GunaButton2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GunaElipsePanel3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GunaElipsePanel2)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.v0jumlah)
        Me.Controls.Add(Me.v0hargabarang)
        Me.Controls.Add(Me.v0satuanbarang)
        Me.Controls.Add(Me.v0jenisbarang)
        Me.Controls.Add(Me.v0namabarang)
        Me.Controls.Add(Me.v0kodebarang)
        Me.Controls.Add(Me.v0totalharga)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.v0kasir)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.v0tanggal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.v0jam)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.v0nomorfaktur)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.panelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "penjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "penjualan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelHeader.ResumeLayout(False)
        Me.panelHeader.PerformLayout()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaElipsePanel2.ResumeLayout(False)
        Me.GunaElipsePanel2.PerformLayout()
        Me.GunaElipsePanel3.ResumeLayout(False)
        Me.GunaElipsePanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelHeader As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMin As System.Windows.Forms.PictureBox
    Friend WithEvents btnMax As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnLogin As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents v0nomorfaktur As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents v0jam As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents v0kasir As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents v0tanggal As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents v0grandtotal As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents v0jumlah As System.Windows.Forms.TextBox
    Friend WithEvents v0hargabarang As System.Windows.Forms.TextBox
    Friend WithEvents v0satuanbarang As System.Windows.Forms.TextBox
    Friend WithEvents v0jenisbarang As System.Windows.Forms.TextBox
    Friend WithEvents v0namabarang As System.Windows.Forms.TextBox
    Friend WithEvents v0kodebarang As System.Windows.Forms.TextBox
    Friend WithEvents v0totalharga As System.Windows.Forms.TextBox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents v0dibayar As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GunaElipsePanel3 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents v0kembalian As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
End Class
