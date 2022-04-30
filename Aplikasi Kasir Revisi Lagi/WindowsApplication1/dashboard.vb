Imports System.Data.OleDb
Public Class dashboard
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    'Dashboard
    Private Sub btndaftar_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        btnHome.BaseColor = Color.FromArgb(3, 172, 14)
        btnHome.ForeColor = Color.White
        btnHome.Image = WindowsApplication1.My.Resources.Resources.dashboard2
        user.Hide()
        home.Show()

        btnpengguna.BaseColor = Color.White
        btnpengguna.ForeColor = Color.FromArgb(3, 172, 14)
        btnpengguna.Image = WindowsApplication1.My.Resources.Resources.pengguna1

        btnBarang.BaseColor = Color.White
        btnBarang.ForeColor = Color.FromArgb(3, 172, 14)
        btnBarang.Image = WindowsApplication1.My.Resources.Resources.barang1

        btnJual.BaseColor = Color.White
        btnJual.ForeColor = Color.FromArgb(3, 172, 14)
        btnJual.Image = WindowsApplication1.My.Resources.Resources.penjualan1

        btnLapor.BaseColor = Color.White
        btnLapor.ForeColor = Color.FromArgb(3, 172, 14)
        btnLapor.Image = WindowsApplication1.My.Resources.Resources.laporan1
    End Sub
    Sub MunculData()
        Cmd = New OleDbCommand("select * from tbl_barang", Conn)
        Rd = Cmd.ExecuteReader
        dgvBarang.Rows.Clear()
        Do While Rd.Read = True
            dgvBarang.Rows.Add(Rd(0), Rd(1), Rd(2), Rd(3), Rd(4), Rd(5), Rd(6))
        Loop
    End Sub
    Sub jlh_barang()
        Dim jumlah_data As Integer = 0
        For t As Integer = 0 To dgvBarang.RowCount - 1
            jumlah_data = jumlah_data + Val(dgvBarang.Rows(t).Cells(6).Value)
        Next
        totalBarang.Text = jumlah_data
    End Sub
    'Akhir Dashboard

    'Pengguna
    Private Sub btnpengguna_Click(sender As Object, e As EventArgs) Handles btnpengguna.Click
        btnpengguna.BaseColor = Color.FromArgb(3, 172, 14)
        btnpengguna.ForeColor = Color.White
        btnpengguna.Image = WindowsApplication1.My.Resources.Resources.pengguna2
        home.Hide()
        user.Show()

        btnHome.BaseColor = Color.White
        btnHome.ForeColor = Color.FromArgb(3, 172, 14)
        btnHome.Image = WindowsApplication1.My.Resources.Resources.Category

        btnBarang.BaseColor = Color.White
        btnBarang.ForeColor = Color.FromArgb(3, 172, 14)
        btnBarang.Image = WindowsApplication1.My.Resources.Resources.barang1

        btnJual.BaseColor = Color.White
        btnJual.ForeColor = Color.FromArgb(3, 172, 14)
        btnJual.Image = WindowsApplication1.My.Resources.Resources.penjualan1

        btnLapor.BaseColor = Color.White
        btnLapor.ForeColor = Color.FromArgb(3, 172, 14)
        btnLapor.Image = WindowsApplication1.My.Resources.Resources.laporan1
    End Sub
    Sub tampil_user()
        Cmd = New OleDbCommand("select * from tbl_user", Conn)
        Rd = Cmd.ExecuteReader
        dgv_user.Rows.Clear()
        Do While Rd.Read = True
            dgv_user.Rows.Add(Rd(0), Rd(1), Rd(2), Rd(3), Rd(4))
        Loop
    End Sub

    Private Sub crudUser_Click(sender As Object, e As EventArgs) Handles crudUser.Click
        input_user.ShowDialog()
    End Sub

    Private Sub GunaTextBox1_TextChanged(sender As Object, e As EventArgs) Handles searchUser.TextChanged
        Call konekdb()
        Cmd = New OleDbCommand("select * from tbl_user where Namauser Like '%" & searchUser.Text & "%'", Conn)
        Rd = Cmd.ExecuteReader
        dgv_user.Rows.Clear()
        Do While Rd.Read = True
            dgv_user.Rows.Add(Rd(0), Rd(1), Rd(2), Rd(3), Rd(4))
        Loop
    End Sub
    'Akhir Pengguna

    Private Sub btnBarang_Click(sender As Object, e As EventArgs) Handles btnBarang.Click
        btnBarang.BaseColor = Color.FromArgb(3, 172, 14)
        btnBarang.ForeColor = Color.White
        btnBarang.Image = WindowsApplication1.My.Resources.Resources.barang2

        btnpengguna.BaseColor = Color.White
        btnpengguna.ForeColor = Color.FromArgb(3, 172, 14)
        btnpengguna.Image = WindowsApplication1.My.Resources.Resources.pengguna1

        btnHome.BaseColor = Color.White
        btnHome.ForeColor = Color.FromArgb(3, 172, 14)
        btnHome.Image = WindowsApplication1.My.Resources.Resources.Category

        btnJual.BaseColor = Color.White
        btnJual.ForeColor = Color.FromArgb(3, 172, 14)
        btnJual.Image = WindowsApplication1.My.Resources.Resources.penjualan1

        btnLapor.BaseColor = Color.White
        btnLapor.ForeColor = Color.FromArgb(3, 172, 14)
        btnLapor.Image = WindowsApplication1.My.Resources.Resources.laporan1
    End Sub

    Private Sub btnJual_Click(sender As Object, e As EventArgs) Handles btnJual.Click
        btnJual.BaseColor = Color.FromArgb(3, 172, 14)
        btnJual.ForeColor = Color.White
        btnJual.Image = WindowsApplication1.My.Resources.Resources.penjualan2

        btnpengguna.BaseColor = Color.White
        btnpengguna.ForeColor = Color.FromArgb(3, 172, 14)
        btnpengguna.Image = WindowsApplication1.My.Resources.Resources.pengguna1

        btnBarang.BaseColor = Color.White
        btnBarang.ForeColor = Color.FromArgb(3, 172, 14)
        btnBarang.Image = WindowsApplication1.My.Resources.Resources.barang1

        btnHome.BaseColor = Color.White
        btnHome.ForeColor = Color.FromArgb(3, 172, 14)
        btnHome.Image = WindowsApplication1.My.Resources.Resources.Category

        btnLapor.BaseColor = Color.White
        btnLapor.ForeColor = Color.FromArgb(3, 172, 14)
        btnLapor.Image = WindowsApplication1.My.Resources.Resources.laporan1
    End Sub

    Private Sub btnLapor_Click(sender As Object, e As EventArgs) Handles btnLapor.Click
        btnLapor.BaseColor = Color.FromArgb(3, 172, 14)
        btnLapor.ForeColor = Color.White
        btnLapor.Image = WindowsApplication1.My.Resources.Resources.laporan2

        btnpengguna.BaseColor = Color.White
        btnpengguna.ForeColor = Color.FromArgb(3, 172, 14)
        btnpengguna.Image = WindowsApplication1.My.Resources.Resources.pengguna1

        btnBarang.BaseColor = Color.White
        btnBarang.ForeColor = Color.FromArgb(3, 172, 14)
        btnBarang.Image = WindowsApplication1.My.Resources.Resources.barang1

        btnJual.BaseColor = Color.White
        btnJual.ForeColor = Color.FromArgb(3, 172, 14)
        btnJual.Image = WindowsApplication1.My.Resources.Resources.penjualan1

        btnHome.BaseColor = Color.White
        btnHome.ForeColor = Color.FromArgb(3, 172, 14)
        btnHome.Image = WindowsApplication1.My.Resources.Resources.Category
    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnHome.BaseColor = Color.FromArgb(3, 172, 14)
        btnHome.ForeColor = Color.White
        btnHome.Image = WindowsApplication1.My.Resources.Resources.dashboard2
        user.Hide()
        home.Show()

        'Dashboard
        Call konekdb()
        Call MunculData()
        Call jlh_barang()
        'Akhir dashboard

        'pengguna
        Call tampil_user()
        'Akhir pengguna
    End Sub
End Class