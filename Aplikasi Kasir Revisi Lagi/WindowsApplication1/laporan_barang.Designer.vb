<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class laporan_barang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(laporan_barang))
        Me.panelHeader = New System.Windows.Forms.Panel()
        Me.btnMin = New System.Windows.Forms.PictureBox()
        Me.btnMax = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnCari = New Guna.UI.WinForms.GunaButton()
        Me.btnPrint = New Guna.UI.WinForms.GunaButton()
        Me.btnEkspor = New Guna.UI.WinForms.GunaButton()
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
        Me.panelHeader.TabIndex = 52
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins SemiBold", 18.32727!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(63, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(328, 50)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Laporan Data Barang"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(271, 345)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1379, 655)
        Me.CrystalReportViewer1.TabIndex = 53
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
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
        Me.btnCari.Location = New System.Drawing.Point(1310, 269)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnCari.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnCari.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCari.OnHoverImage = Nothing
        Me.btnCari.OnPressedColor = System.Drawing.Color.Black
        Me.btnCari.Radius = 5
        Me.btnCari.Size = New System.Drawing.Size(100, 40)
        Me.btnCari.TabIndex = 73
        Me.btnCari.Text = "Cari"
        Me.btnCari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnPrint.Location = New System.Drawing.Point(1430, 269)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.OnHoverBaseColor = System.Drawing.Color.White
        Me.btnPrint.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnPrint.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnPrint.OnHoverImage = Nothing
        Me.btnPrint.OnPressedColor = System.Drawing.Color.Black
        Me.btnPrint.Radius = 5
        Me.btnPrint.Size = New System.Drawing.Size(100, 40)
        Me.btnPrint.TabIndex = 74
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnEkspor.Location = New System.Drawing.Point(1550, 269)
        Me.btnEkspor.Name = "btnEkspor"
        Me.btnEkspor.OnHoverBaseColor = System.Drawing.Color.White
        Me.btnEkspor.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnEkspor.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnEkspor.OnHoverImage = Nothing
        Me.btnEkspor.OnPressedColor = System.Drawing.Color.Black
        Me.btnEkspor.Radius = 5
        Me.btnEkspor.Size = New System.Drawing.Size(100, 40)
        Me.btnEkspor.TabIndex = 75
        Me.btnEkspor.Text = "Export"
        Me.btnEkspor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'laporan_barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.btnEkspor)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.panelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "laporan_barang"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "laporan_barang"
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
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnMin As System.Windows.Forms.PictureBox
    Friend WithEvents btnMax As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnCari As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnPrint As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnEkspor As Guna.UI.WinForms.GunaButton
End Class
