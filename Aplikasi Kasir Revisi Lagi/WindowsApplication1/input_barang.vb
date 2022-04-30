Imports System.Data.OleDb
Public Class input_barang
    Sub otomatis()
        Call konekdb()
        Dim hitung As Long
        Dim urutan As String
        Cmd = New OleDbCommand("select KodeUser from tbl_barang order by KodeBarang desc", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows = True Then
            urutan = "U" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            urutan = "U" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        txtKodeBarang.Text = urutan

    End Sub
    Sub Clear()
        txtNama.Clear()
        cbJenis.Text = ""
        cbSatuan.Text = ""
        txtHargaBeli.Clear()
        txtHargaJual.Clear()
        txtStok.Clear
    End Sub
    Private Sub input_barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call konekdb()
        Call otomatis()
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtKodeBarang.Text = "" Or txtNama.Text = "" Or cbJenis.Text = "" Or cbSatuan.Text = "" Or txtHargaBeli.Text = "" Or txtHargaJual.Text = "" Or txtStok.Text = "" Then
            MsgBox("Pastikan Semua Data Terisi !!")
        Else
            Call konekdb()
            Cmd = New OleDbCommand("select * from tbl_barang where KodeBarang='" & txtKodeBarang.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows = False Then
                Cmd = New OleDbCommand("insert into tbl_barang values('" & txtKodeBarang.Text & _
                                       "','" & txtNama.Text & _
                                       "','" & cbJenis.Text & _
                                       "','" & cbSatuan.Text & _
                                       "','" & txtHargaBeli.Text & _
                                       "','" & txtHargaJual.Text & _
                                       "','" & txtStok.Text & _
                                       "')", Conn)
                Cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Di Tambahkan")
                Call konekdb()
                Call Clear()
                Call dashboard.MunculData()
                Call dashboard.tampil_barang()
            Else
                Cmd = New OleDbCommand("update tbl_barang set NamaBarang = '" & txtNama.Text & _
                                       "', JenisBarang = '" & cbJenis.Text & _
                                       "', SatuanBarang = '" & cbSatuan.Text & _
                                       "', HargaBeli = '" & txtHargaBeli.Text & _
                                       "', HargaJual = '" & txtHargaJual.Text & _
                                       "', StokBarang = '" & txtStok.Text & _
                                       "' where KodeBarang = '" & txtKodeBarang.Text & "'", Conn)
                Cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Di Edit")
                Call konekdb()
                Call Clear()
                Call dashboard.MunculData()
                Call dashboard.tampil_barang()
            End If
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call konekdb()
        If MessageBox.Show("Apakah Anda Ingin Menghapus Data..??", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Cmd = New OleDbCommand("delete from tbl_barang where KodeBarang= '" & txtKodeBarang.Text & "'", Conn)
            Cmd.ExecuteNonQuery()
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Di Hapus")
            Call konekdb()
            Call Clear()
            Call dashboard.MunculData()
            Call dashboard.tampil_barang()
        End If
    End Sub

    Private Sub txtKodeBarang_TextChanged(sender As Object, e As EventArgs) Handles txtKodeBarang.TextChanged
        Call konekdb()
        Cmd = New OleDbCommand("select * from tbl_barang where KodeBarang = '" & txtKodeBarang.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows = True Then
            txtNama.Text = Rd(1)
            cbJenis.Text = Rd(2)
            cbSatuan.Text = Rd(3)
            txtHargaBeli.Text = Rd(4)
            txtHargaJual.Text = Rd(5)
            txtStok.Text = Rd(6)
        Else
            Call Clear()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class