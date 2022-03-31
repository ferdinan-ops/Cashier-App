<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_penjulan
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.v0kembalian = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.v0jumlah = New System.Windows.Forms.TextBox()
        Me.v0hargabarang = New System.Windows.Forms.TextBox()
        Me.v0satuanbarang = New System.Windows.Forms.TextBox()
        Me.v0jenisbarang = New System.Windows.Forms.TextBox()
        Me.v0namabarang = New System.Windows.Forms.TextBox()
        Me.v0kodebarang = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.v0dibayar = New System.Windows.Forms.TextBox()
        Me.v0totalharga = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.v0kasir = New System.Windows.Forms.TextBox()
        Me.v0tanggal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.v0jam = New System.Windows.Forms.TextBox()
        Me.v0nomorfaktur = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.v0grandtotal = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.DataGridView1.Location = New System.Drawing.Point(10, 254)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1346, 366)
        Me.DataGridView1.TabIndex = 45
        '
        'Column1
        '
        Me.Column1.HeaderText = "Kode Barang"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 170
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama Barang"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 395
        '
        'Column3
        '
        Me.Column3.HeaderText = "Jenis Barang"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 138
        '
        'Column4
        '
        Me.Column4.HeaderText = "Satuan Barang"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 154
        '
        'Column5
        '
        Me.Column5.HeaderText = "Harga Barang"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "Banyak"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 150
        '
        'Column7
        '
        Me.Column7.HeaderText = "Total Harga"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 140
        '
        'v0kembalian
        '
        Me.v0kembalian.BackColor = System.Drawing.Color.Black
        Me.v0kembalian.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.v0kembalian.Font = New System.Drawing.Font("Digital-7 Mono", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0kembalian.ForeColor = System.Drawing.Color.Yellow
        Me.v0kembalian.Location = New System.Drawing.Point(417, 53)
        Me.v0kembalian.Name = "v0kembalian"
        Me.v0kembalian.ReadOnly = True
        Me.v0kembalian.Size = New System.Drawing.Size(368, 64)
        Me.v0kembalian.TabIndex = 44
        Me.v0kembalian.Text = "2.000"
        Me.v0kembalian.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources.icons8_power_off_button_48
        Me.Button1.Location = New System.Drawing.Point(1097, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(261, 62)
        Me.Button1.TabIndex = 42
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Navy
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Image = Global.WindowsApplication1.My.Resources.Resources.icons8_save_48
        Me.Button6.Location = New System.Drawing.Point(811, 53)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(269, 62)
        Me.Button6.TabIndex = 41
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(413, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 24)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Kembalian"
        '
        'v0jumlah
        '
        Me.v0jumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0jumlah.Location = New System.Drawing.Point(1057, 230)
        Me.v0jumlah.Name = "v0jumlah"
        Me.v0jumlah.Size = New System.Drawing.Size(153, 26)
        Me.v0jumlah.TabIndex = 51
        Me.v0jumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'v0hargabarang
        '
        Me.v0hargabarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0hargabarang.Location = New System.Drawing.Point(908, 230)
        Me.v0hargabarang.Name = "v0hargabarang"
        Me.v0hargabarang.ReadOnly = True
        Me.v0hargabarang.Size = New System.Drawing.Size(149, 26)
        Me.v0hargabarang.TabIndex = 50
        Me.v0hargabarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'v0satuanbarang
        '
        Me.v0satuanbarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0satuanbarang.Location = New System.Drawing.Point(754, 230)
        Me.v0satuanbarang.Name = "v0satuanbarang"
        Me.v0satuanbarang.ReadOnly = True
        Me.v0satuanbarang.Size = New System.Drawing.Size(154, 26)
        Me.v0satuanbarang.TabIndex = 49
        '
        'v0jenisbarang
        '
        Me.v0jenisbarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0jenisbarang.Location = New System.Drawing.Point(617, 230)
        Me.v0jenisbarang.Name = "v0jenisbarang"
        Me.v0jenisbarang.ReadOnly = True
        Me.v0jenisbarang.Size = New System.Drawing.Size(137, 26)
        Me.v0jenisbarang.TabIndex = 48
        '
        'v0namabarang
        '
        Me.v0namabarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0namabarang.Location = New System.Drawing.Point(222, 230)
        Me.v0namabarang.Name = "v0namabarang"
        Me.v0namabarang.ReadOnly = True
        Me.v0namabarang.Size = New System.Drawing.Size(395, 26)
        Me.v0namabarang.TabIndex = 47
        '
        'v0kodebarang
        '
        Me.v0kodebarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0kodebarang.Location = New System.Drawing.Point(50, 230)
        Me.v0kodebarang.Name = "v0kodebarang"
        Me.v0kodebarang.Size = New System.Drawing.Size(172, 26)
        Me.v0kodebarang.TabIndex = 46
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'v0dibayar
        '
        Me.v0dibayar.BackColor = System.Drawing.Color.Black
        Me.v0dibayar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.v0dibayar.Font = New System.Drawing.Font("Digital-7 Mono", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0dibayar.ForeColor = System.Drawing.Color.Cyan
        Me.v0dibayar.Location = New System.Drawing.Point(16, 53)
        Me.v0dibayar.Name = "v0dibayar"
        Me.v0dibayar.Size = New System.Drawing.Size(368, 64)
        Me.v0dibayar.TabIndex = 38
        Me.v0dibayar.Text = "20.000"
        Me.v0dibayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'v0totalharga
        '
        Me.v0totalharga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0totalharga.Location = New System.Drawing.Point(1210, 230)
        Me.v0totalharga.Name = "v0totalharga"
        Me.v0totalharga.ReadOnly = True
        Me.v0totalharga.Size = New System.Drawing.Size(136, 26)
        Me.v0totalharga.TabIndex = 52
        Me.v0totalharga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.v0kembalian)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.Button6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.v0dibayar)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(0, 626)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1354, 140)
        Me.GroupBox4.TabIndex = 44
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pembayaran"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 24)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Dibayar"
        '
        'v0kasir
        '
        Me.v0kasir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0kasir.Location = New System.Drawing.Point(273, 138)
        Me.v0kasir.Name = "v0kasir"
        Me.v0kasir.ReadOnly = True
        Me.v0kasir.Size = New System.Drawing.Size(219, 26)
        Me.v0kasir.TabIndex = 41
        Me.v0kasir.Text = "Kimimaro"
        '
        'v0tanggal
        '
        Me.v0tanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0tanggal.Location = New System.Drawing.Point(273, 67)
        Me.v0tanggal.Name = "v0tanggal"
        Me.v0tanggal.ReadOnly = True
        Me.v0tanggal.Size = New System.Drawing.Size(219, 26)
        Me.v0tanggal.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(269, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Kasir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(269, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Tanggal"
        '
        'v0jam
        '
        Me.v0jam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0jam.Location = New System.Drawing.Point(13, 138)
        Me.v0jam.Name = "v0jam"
        Me.v0jam.ReadOnly = True
        Me.v0jam.Size = New System.Drawing.Size(219, 26)
        Me.v0jam.TabIndex = 35
        '
        'v0nomorfaktur
        '
        Me.v0nomorfaktur.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0nomorfaktur.Location = New System.Drawing.Point(13, 67)
        Me.v0nomorfaktur.Name = "v0nomorfaktur"
        Me.v0nomorfaktur.ReadOnly = True
        Me.v0nomorfaktur.Size = New System.Drawing.Size(219, 26)
        Me.v0nomorfaktur.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Jam"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Nomor Faktur"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.v0kasir)
        Me.GroupBox2.Controls.Add(Me.v0tanggal)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.v0jam)
        Me.GroupBox2.Controls.Add(Me.v0nomorfaktur)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(3, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(518, 186)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaksi"
        '
        'v0grandtotal
        '
        Me.v0grandtotal.BackColor = System.Drawing.Color.Black
        Me.v0grandtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.v0grandtotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.v0grandtotal.Font = New System.Drawing.Font("Digital-7 Mono", 80.24999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v0grandtotal.ForeColor = System.Drawing.Color.Lime
        Me.v0grandtotal.Location = New System.Drawing.Point(3, 25)
        Me.v0grandtotal.Multiline = True
        Me.v0grandtotal.Name = "v0grandtotal"
        Me.v0grandtotal.ReadOnly = True
        Me.v0grandtotal.Size = New System.Drawing.Size(824, 158)
        Me.v0grandtotal.TabIndex = 41
        Me.v0grandtotal.Text = "2.000.000"
        Me.v0grandtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.v0grandtotal)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(521, 25)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(830, 186)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Grand Total"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1354, 214)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        '
        'Form_penjulan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.photo_1601370690183_1c7796ecec61
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1354, 766)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.v0jumlah)
        Me.Controls.Add(Me.v0hargabarang)
        Me.Controls.Add(Me.v0satuanbarang)
        Me.Controls.Add(Me.v0jenisbarang)
        Me.Controls.Add(Me.v0namabarang)
        Me.Controls.Add(Me.v0kodebarang)
        Me.Controls.Add(Me.v0totalharga)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_penjulan"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_penjulan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents v0kembalian As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents v0jumlah As System.Windows.Forms.TextBox
    Friend WithEvents v0hargabarang As System.Windows.Forms.TextBox
    Friend WithEvents v0satuanbarang As System.Windows.Forms.TextBox
    Friend WithEvents v0jenisbarang As System.Windows.Forms.TextBox
    Friend WithEvents v0namabarang As System.Windows.Forms.TextBox
    Friend WithEvents v0kodebarang As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents v0dibayar As System.Windows.Forms.TextBox
    Friend WithEvents v0totalharga As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents v0kasir As System.Windows.Forms.TextBox
    Friend WithEvents v0tanggal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents v0jam As System.Windows.Forms.TextBox
    Friend WithEvents v0nomorfaktur As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents v0grandtotal As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
