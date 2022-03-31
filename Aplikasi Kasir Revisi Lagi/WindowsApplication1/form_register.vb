Imports System.Data.OleDb
Public Class form_register
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
    Private Sub form_register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
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
                                       "','" & TextBox5.Text & _
                                       "')", Conn)
                Cmd.ExecuteNonQuery()
                Call koneksi()
            End If
        End If
        Form_Menu.Show()

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Clear()

    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        TextBox2.Clear()

    End Sub

    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBox3.Click
        TextBox3.Clear()

    End Sub

    Private Sub TextBox4_Click(sender As Object, e As EventArgs) Handles TextBox4.Click
        TextBox4.Clear()

    End Sub

    Private Sub TextBox5_Click(sender As Object, e As EventArgs) Handles TextBox5.Click
        TextBox5.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form_login.ShowDialog()

    End Sub
End Class