Imports System.Data.OleDb
Public Class Form_login
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
    Private Sub Form_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button3.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Username atau Password Anda Masih Kosong")
        Else
            Call koneksi()
            Cmd = New OleDbCommand("select * from tbl_user where Username = '" & TextBox1.Text & "' and pwd = '" & TextBox2.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows = True Then
                Form_Menu.lbl_level.Text = Rd.Item("Lvl")
                Form_Menu.lbl_nama.Text = Rd.Item("NamaUser")
                Me.Hide()
                Form_Menu.Show()
            Else
                MessageBox.Show("Password atau Username Anda Salah")
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub TextBox1_Click_1(sender As Object, e As EventArgs) Handles TextBox1.Click
        panel_username.ForeColor = Color.FromArgb(0, 0, 0)
        TextBox1.Clear()

    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        panel_password.ForeColor = Color.FromArgb(0, 0, 0)
        TextBox2.Clear()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        form_register.ShowDialog()


    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        End

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub panel_password_Paint(sender As Object, e As PaintEventArgs) Handles panel_password.Paint

    End Sub
End Class