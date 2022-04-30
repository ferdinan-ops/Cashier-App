Imports System.Data.OleDb
Public Class input_user

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub crudUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call konekdb()
        Call otomatis()
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub
    Sub bersih()
        txtNama.Clear()
        txtUsername.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        cbLevel.Text = ""
        txtNama.Focus()
    End Sub
    Sub otomatis()
        Call konekdb()
        Dim hitung As Long
        Dim urutan As String
        Cmd = New OleDbCommand("select KodeUser from tbl_user order by KodeUser desc", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows = True Then
            urutan = "U" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            urutan = "U" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        txtKodeUser.Text = urutan

    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtKodeUser.Text = "" Or txtNama.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Or cbLevel.Text = "" Then
            MsgBox("Pastikan Semua Data Terisi !!")
        Else
            Call konekdb()
            Cmd = New OleDbCommand("select * from tbl_user where KodeUser='" & txtKodeUser.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows = False Then
                Cmd = New OleDbCommand("insert into tbl_user values('" & txtKodeUser.Text & _
                                       "','" & txtNama.Text & _
                                       "','" & txtUsername.Text & _
                                       "','" & txtPassword.Text & _
                                       "','" & cbLevel.Text & _
                                       "')", Conn)
                Cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Di Tambahkan")
                Call konekdb()
                Call bersih()
                Call dashboard.tampil_user()
            Else
                Cmd = New OleDbCommand("update tbl_user set NamaUser = '" & txtNama.Text & _
                                       "', UserName = '" & txtUsername.Text & _
                                       "', pwd = '" & txtPassword.Text & _
                                       "', lvl = '" & cbLevel.Text & _
                                       "' where KodeUser = '" & txtKodeUser.Text & "'", Conn)
                Cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Di Edit")
                Call konekdb()
                Call bersih()
                Call dashboard.tampil_user()
            End If
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call konekdb()
        If MessageBox.Show("Apakah Anda Ingin Menghapus Data..??", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Cmd = New OleDbCommand("delete from tbl_user where KodeUser= '" & txtKodeUser.Text & "'", Conn)
            Cmd.ExecuteNonQuery()
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Di Hapus")
            Call Form_databarang.koneksi()
            Call bersih()
            Call dashboard.tampil_user()
        End If
    End Sub

    Private Sub txtKodeUser_TextChanged(sender As Object, e As EventArgs) Handles txtKodeUser.TextChanged
        Call konekdb()
        Cmd = New OleDbCommand("select * from tbl_user where KodeUser = '" & txtKodeUser.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows = True Then
            txtNama.Text = Rd(1)
            txtUsername.Text = Rd(2)
            txtPassword.Text = Rd(3)
            cbLevel.Text = Rd(4)
        Else
            txtNama.Clear()
            txtUsername.Clear()
            txtPassword.Clear()
            cbLevel.Text = ""
        End If
    End Sub
End Class