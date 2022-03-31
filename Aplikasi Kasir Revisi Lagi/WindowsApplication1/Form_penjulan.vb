Imports System.Data.OleDb
Public Class Form_penjulan
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
    Sub no_faktur()
        Cmd = New OleDbCommand("select * from tbl_jual where FakturJual in(select max(FakturJual) from  tbl_jual) order by FakturJual DESC", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            v0nomorfaktur.Text = Format(Now, "yyMMdd") + "0001"
        Else
            If Microsoft.VisualBasic.Left(Rd.GetString(0), 6) <> Format(Now, "yyMMdd") Then
                v0nomorfaktur.Text = Format(Now, "yyMMdd") + "0001"
            Else
                v0nomorfaktur.Text = Rd.Item("FakturJual") + 1
            End If
        End If
    End Sub
    Sub grand_total()
        Dim jumlah As Decimal = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            jumlah = jumlah + DataGridView1.Rows(i).Cells(6).Value
            v0grandtotal.Text = jumlah
        Next
        If v0grandtotal.Text = "" Then
            v0grandtotal.Text = "0"
        End If
    End Sub
    Sub bersih_barang()
        v0kodebarang.Text = ""
        v0namabarang.Text = ""
        v0satuanbarang.Text = ""
        v0jenisbarang.Text = ""
        v0hargabarang.Text = ""
        v0jumlah.Text = ""
        v0totalharga.Text = ""
        v0kodebarang.Focus()
    End Sub
    Private Sub Form_penjulan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call no_faktur()
        v0kodebarang.Focus()
        v0dibayar.Text = "0"
        v0kembalian.Text = "0"
        Call grand_total()
        v0kasir.Text = Form_Menu.lbl_nama.Text
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        v0tanggal.Text = Format(Now, "dd/MM/yyyy")
        v0jam.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub v0kodebarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v0kodebarang.KeyPress
        If e.KeyChar = Chr(13) Then
            Cmd = New OleDbCommand("select * from tbl_barang where KodeBarang='" & v0kodebarang.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows = True Then
                v0namabarang.Text = Rd.Item("NamaBarang")
                v0satuanbarang.Text = Rd.Item("SatuanBarang")
                v0jenisbarang.Text = Rd.Item("JenisBarang")
                v0hargabarang.Text = Rd.Item("HargaJual")
                v0jumlah.Focus()
            Else
                v0namabarang.Text = ""
                v0satuanbarang.Text = ""
                v0jenisbarang.Text = ""
                v0hargabarang.Text = ""
                v0kodebarang.Focus()
                MessageBox.Show("Barang Ini Tidak Ditemukan atau Tidak Terdaftar di Database !!")
            End If
        End If
    End Sub

    Private Sub v0kodebarang_TextChanged(sender As Object, e As EventArgs) Handles v0kodebarang.TextChanged

    End Sub

    Private Sub v0jumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles v0jumlah.KeyPress
        If e.KeyChar = Chr(13) Then
            DataGridView1.Rows.Add(v0kodebarang.Text, v0namabarang.Text, v0jenisbarang.Text, v0satuanbarang.Text, v0hargabarang.Text, v0jumlah.Text, v0totalharga.Text)
            Call bersih_barang()
            Call grand_total()
        End If
    End Sub

    Private Sub v0jumlah_TextChanged(sender As Object, e As EventArgs) Handles v0jumlah.TextChanged
        Try
            v0totalharga.Text = Val(v0hargabarang.Text) * Val(v0jumlah.Text)
        Catch ex As Exception
            v0totalharga.Text = ""
        End Try
    End Sub

    Private Sub v0dibayar_TextChanged(sender As Object, e As EventArgs) Handles v0dibayar.TextChanged
        Try
            v0kembalian.Text = Val(v0dibayar.Text) - Val(v0grandtotal.Text)
        Catch ex As Exception
            v0kembalian.Text = "0"
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If v0grandtotal.Text = "0" Then
            MessageBox.Show("Belum Ada Barang Yang Di Masukkan !!")
        ElseIf Val(v0dibayar.Text) < Val(v0grandtotal.Text) Then
            MessageBox.Show("Pembayaran Masih Kurang !!")
        Else
            Call koneksi()
            Cmd = New OleDbCommand("insert into tbl_jual(FakturJual,tgljual,Jam,GrandTotal,Dibayar,Kembalian,Kasir)values('" & v0nomorfaktur.Text & _
                                       "','" & v0tanggal.Text & _
                                       "','" & v0jam.Text & _
                                       "','" & v0grandtotal.Text & _
                                       "','" & v0dibayar.Text & _
                                       "','" & v0kembalian.Text & _
                                       "','" & v0kasir.Text & _
                                       "')", Conn)
            Cmd.ExecuteNonQuery()
            For baris As Integer = 0 To DataGridView1.Rows.Count - 2
                Cmd = New OleDbCommand("insert into tbl_rinci_jual values('" & v0nomorfaktur.Text & _
                                       "','" & DataGridView1.Rows(baris).Cells(0).Value & _
                                       "','" & DataGridView1.Rows(baris).Cells(5).Value & _
                                       "','" & DataGridView1.Rows(baris).Cells(6).Value & _
                                       "')", Conn)
                Cmd.ExecuteNonQuery()
                Cmd = New OleDbCommand("select * from tbl_barang where KodeBarang = '" & DataGridView1.Rows(baris).Cells(0).Value & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows = True Then
                    Cmd = New OleDbCommand("update tbl_barang set StokBarang = '" & Rd.Item("StokBarang") - Val(DataGridView1.Rows(baris).Cells(5).Value) & "' where kodeBarang = '" & DataGridView1.Rows(baris).Cells(0).Value & "'", Conn)
                    Cmd.ExecuteNonQuery()
                End If
            Next
            MessageBox.Show("Transaksi Penjualan Berhasil Di Simpan !!")
            DataGridView1.Rows.Clear()
            v0grandtotal.Text = "0"
            v0dibayar.Text = "0"
            v0kembalian.Text = "0"
            Call bersih_barang()
            Call koneksi()
            Call no_faktur()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class