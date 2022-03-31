Imports System.Data.OleDb
Public Class Form_databarang
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
    Sub MunculData()
        Cmd = New OleDbCommand("select * from tbl_barang", Conn)
        Rd = Cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While Rd.Read = True
            DataGridView1.Rows.Add(Rd(0), Rd(1), Rd(2), Rd(3), Rd(4), Rd(5), Rd(6))
        Loop
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form_databarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call MunculData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call koneksi()
        Cmd = New OleDbCommand("select * from tbl_barang where NamaBarang Like '%" & TextBox1.Text & "%'", Conn)
        Rd = Cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While Rd.Read = True
            DataGridView1.Rows.Add(Rd(0), Rd(1), Rd(2), Rd(3), Rd(4), Rd(5), Rd(6))
        Loop
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form_inputbarang.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class