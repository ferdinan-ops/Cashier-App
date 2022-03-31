Imports System.Data.OleDb
Public Class Form_user
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
    Sub tampil_user()
        Cmd = New OleDbCommand("select * from tbl_user", Conn)
        Rd = Cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While Rd.Read = True
            DataGridView1.Rows.Add(Rd(0), Rd(1), Rd(2), Rd(3), Rd(4))
        Loop
    End Sub
    Sub bersih()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox1.Text = ""
        TextBox1.Focus()
    End Sub
    Private Sub Form_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampil_user()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call bersih()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Pastikan Semua Data Terisi !!")
        Else
            Call koneksi()
            Cmd = New OleDbCommand("select * from tbl_user where KodeUser='" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows = False Then
                Cmd = New OleDbCommand("insert into tbl_user values('" & TextBox1.Text & _
                                       "','" & TextBox2.Text & _
                                       "','" & TextBox3.Text & _
                                       "','" & TextBox4.Text & _
                                       "','" & ComboBox1.Text & _
                                       "')", Conn)
                Cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Di Tambahkan")
                Call koneksi()
                Call bersih()
                Call tampil_user()
            Else
                Cmd = New OleDbCommand("update tbl_user set NamaUser = '" & TextBox2.Text & _
                                       "', UserName = '" & TextBox3.Text & _
                                       "', pwd = '" & TextBox4.Text & _
                                       "', lvl = '" & ComboBox1.Text & _
                                       "' where KodeUser = '" & TextBox1.Text & "'", Conn)
                Cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Di Edit")
                Call koneksi()
                Call bersih()
                Call tampil_user()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call koneksi()
        If MessageBox.Show("Apakah Anda Ingin Menghapus Data..??", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Cmd = New OleDbCommand("delete from tbl_user where KodeUser= '" & TextBox1.Text & "'", Conn)
            Cmd.ExecuteNonQuery()
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Di Hapus")
            Call Form_databarang.koneksi()
            Call bersih()
            Call tampil_user()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call koneksi()
        Cmd = New OleDbCommand("select * from tbl_user where KodeUser = '" & TextBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows = True Then
            TextBox2.Text = Rd(1)
            TextBox3.Text = Rd(2)
            TextBox4.Text = Rd(3)
            ComboBox1.Text = Rd(4)
        Else
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            ComboBox1.Text = ""
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class