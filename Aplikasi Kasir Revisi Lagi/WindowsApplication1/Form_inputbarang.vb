Imports System.Data.OleDb
Public Class Form_inputbarang
    Dim Conn As OleDbConnection
    Dim Da As OleDbDataAdapter
    Dim Ds As DataSet
    Dim Cmd As OleDbCommand
    Dim Rd As OleDbDataReader
    Dim LokasiData As String

    Sub koneksi()
        LokasiData = "provider=microsoft.jet.oledb.4.0;data source=db_aplikasi_revisi.mdb"
        Conn = New OleDbConnection(LokasiData)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
    Sub Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox1.Focus()
    End Sub
    Private Sub Form_inputbarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            MsgBox("Pastikan Semua Data Terisi !!")
        Else
            Call koneksi()
            Cmd = New OleDbCommand("select * from tbl_barang where KodeBarang='" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows = False Then
                Cmd = New OleDbCommand("insert into tbl_barang values('" & TextBox1.Text & _
                                       "','" & TextBox2.Text & _
                                       "','" & ComboBox1.Text & _
                                       "','" & ComboBox2.Text & _
                                       "','" & TextBox3.Text & _
                                       "','" & TextBox4.Text & _
                                       "','" & TextBox5.Text & _
                                       "')", Conn)
                Cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Di Tambahkan")
                Call Form_databarang.koneksi()
                Call Clear()
                Call Form_databarang.MunculData()
            Else
                Cmd = New OleDbCommand("update tbl_barang set NamaBarang = '" & TextBox2.Text & _
                                       "', JenisBarang = '" & ComboBox1.Text & _
                                       "', SatuanBarang = '" & ComboBox2.Text & _
                                       "', HargaBeli = '" & TextBox3.Text & _
                                       "', HargaJual = '" & TextBox4.Text & _
                                       "', StokBarang = '" & TextBox5.Text & _
                                       "' where KodeBarang = '" & TextBox1.Text & "'", Conn)
                Cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Di Edit")
                Call Clear()
                Call Form_databarang.MunculData()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Clear()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call koneksi()
        Cmd = New OleDbCommand("select * from tbl_barang where KodeBarang = '" & TextBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows = True Then
            TextBox2.Text = Rd(1)
            ComboBox1.Text = Rd(2)
            ComboBox2.Text = Rd(3)
            TextBox3.Text = Rd(4)
            TextBox4.Text = Rd(5)
            TextBox5.Text = Rd(6)
        Else
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            ComboBox1.Text = ""
            ComboBox2.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call koneksi()
        If MessageBox.Show("Apakah Anda Ingin Menghapus Data..??", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Cmd = New OleDbCommand("delete from tbl_barang where KodeBarang= '" & TextBox1.Text & "'", Conn)
            Cmd.ExecuteNonQuery()
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Di Hapus")
            Call Form_databarang.koneksi()
            Call Clear()
            Call Form_databarang.MunculData()
        End If
    End Sub
End Class