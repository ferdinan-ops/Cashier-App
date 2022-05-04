<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lapor_harian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lapor_harian))
        Me.panelHeader = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMin = New System.Windows.Forms.PictureBox()
        Me.btnMax = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnEkspor = New Guna.UI.WinForms.GunaButton()
        Me.btnPrint = New Guna.UI.WinForms.GunaButton()
        Me.btnCari = New Guna.UI.WinForms.GunaButton()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.panelHeader.SuspendLayout()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panelHeader.TabIndex = 77
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
        'btnEkspor
        '
        Me.btnEkspor.Animated = True
        Me.btnEkspor.AnimationHoverSpeed = 0.07!
        Me.btnEkspor.AnimationSpeed = 0.03!
        Me.btnEkspor.BackColor = System.Drawing.Color.Transparent
        Me.btnEkspor.BaseColor = System.Drawing.Color.White
        Me.btnEkspor.BorderColor = System.Drawing.Color.Black
        Me.btnEkspor.BorderSize = 2
        Me.btnEkspor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEkspor.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEkspor.FocusedColor = System.Drawing.Color.Empty
        Me.btnEkspor.Font = New System.Drawing.Font("Poppins", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEkspor.ForeColor = System.Drawing.Color.Black
        Me.btnEkspor.Image = Nothing
        Me.btnEkspor.ImageOffsetX = 10
        Me.btnEkspor.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnEkspor.Location = New System.Drawing.Point(1550, 309)
        Me.btnEkspor.Name = "btnEkspor"
        Me.btnEkspor.OnHoverBaseColor = System.Drawing.Color.White
        Me.btnEkspor.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnEkspor.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnEkspor.OnHoverImage = Nothing
        Me.btnEkspor.OnPressedColor = System.Drawing.Color.Black
        Me.btnEkspor.Radius = 5
        Me.btnEkspor.Size = New System.Drawing.Size(100, 40)
        Me.btnEkspor.TabIndex = 81
        Me.btnEkspor.Text = "Export"
        Me.btnEkspor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnPrint
        '
        Me.btnPrint.Animated = True
        Me.btnPrint.AnimationHoverSpeed = 0.07!
        Me.btnPrint.AnimationSpeed = 0.03!
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.BaseColor = System.Drawing.Color.White
        Me.btnPrint.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnPrint.BorderSize = 2
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPrint.FocusedColor = System.Drawing.Color.Empty
        Me.btnPrint.Font = New System.Drawing.Font("Poppins", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnPrint.Image = Nothing
        Me.btnPrint.ImageOffsetX = 10
        Me.btnPrint.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnPrint.Location = New System.Drawing.Point(1430, 309)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.OnHoverBaseColor = System.Drawing.Color.White
        Me.btnPrint.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnPrint.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnPrint.OnHoverImage = Nothing
        Me.btnPrint.OnPressedColor = System.Drawing.Color.Black
        Me.btnPrint.Radius = 5
        Me.btnPrint.Size = New System.Drawing.Size(100, 40)
        Me.btnPrint.TabIndex = 80
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCari
        '
        Me.btnCari.Animated = True
        Me.btnCari.AnimationHoverSpeed = 0.07!
        Me.btnCari.AnimationSpeed = 0.03!
        Me.btnCari.BackColor = System.Drawing.Color.Transparent
        Me.btnCari.BaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnCari.BorderColor = System.Drawing.Color.White
        Me.btnCari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCari.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCari.FocusedColor = System.Drawing.Color.Empty
        Me.btnCari.Font = New System.Drawing.Font("Poppins", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCari.ForeColor = System.Drawing.Color.White
        Me.btnCari.Image = Nothing
        Me.btnCari.ImageOffsetX = 10
        Me.btnCari.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnCari.Location = New System.Drawing.Point(1310, 309)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnCari.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnCari.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCari.OnHoverImage = Nothing
        Me.btnCari.OnPressedColor = System.Drawing.Color.Black
        Me.btnCari.Radius = 5
        Me.btnCari.Size = New System.Drawing.Size(100, 40)
        Me.btnCari.TabIndex = 79
        Me.btnCari.Text = "Cari"
        Me.btnCari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(271, 385)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1379, 655)
        Me.CrystalReportViewer1.TabIndex = 78
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins SemiBold", 18.32727!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(63, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(243, 50)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Laporan Harian"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins Medium", 13.74545!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(264, 309)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 37)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Tanggal"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.BackColor = System.Drawing.Color.Transparent
        Me.DateTimePicker1.BaseColor = System.Drawing.Color.White
        Me.DateTimePicker1.BorderColor = System.Drawing.Color.Black
        Me.DateTimePicker1.CustomFormat = "MM/dd/yyy"
        Me.DateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DateTimePicker1.ForeColor = System.Drawing.Color.Black
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(384, 313)
        Me.DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White
        Me.DateTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.DateTimePicker1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.DateTimePicker1.OnPressedColor = System.Drawing.Color.Black
        Me.DateTimePicker1.Radius = 5
        Me.DateTimePicker1.Size = New System.Drawing.Size(215, 30)
        Me.DateTimePicker1.TabIndex = 84
        Me.DateTimePicker1.Text = "05/03/2022"
        Me.DateTimePicker1.Value = New Date(2022, 5, 3, 0, 0, 0, 0)
        '
        'lapor_harian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.panelHeader)
        Me.Controls.Add(Me.btnEkspor)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "lapor_harian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "lapor_harian"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelHeader.ResumeLayout(False)
        Me.panelHeader.PerformLayout()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelHeader As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMin As System.Windows.Forms.PictureBox
    Friend WithEvents btnMax As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnEkspor As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnPrint As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnCari As Guna.UI.WinForms.GunaButton
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As Guna.UI.WinForms.GunaDateTimePicker
End Class
