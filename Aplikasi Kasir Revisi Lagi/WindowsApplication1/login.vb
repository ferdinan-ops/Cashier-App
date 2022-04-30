Imports System.Data.OleDb
Public Class login
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

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Username atau Password Anda Masih Kosong")
        Else
            Call koneksi()
            Cmd = New OleDbCommand("select * from tbl_user where Username = '" & txtUsername.Text & "' and pwd = '" & txtPassword.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows = True Then
                dashboard.txtLogin.Text = Rd.Item("NamaUser") + " / " + Rd.Item("Lvl")
                Me.Hide()
                dashboard.Show()
            Else
                MessageBox.Show("Password atau Username Anda Salah")
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub linkDaftar_Click(sender As Object, e As EventArgs) Handles linkDaftar.Click
        Me.Hide()
        register.Show()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
    End Sub
End Class