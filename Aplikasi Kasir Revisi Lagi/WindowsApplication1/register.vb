Imports System.Data.OleDb
Public Class register
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
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btndaftar_Click(sender As Object, e As EventArgs) Handles btndaftar.Click
        If txtNama.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Or cbLevel.Text = "" Or kodeUser.Text = "" Then
            MsgBox("Pastikan Semua Data Terisi !!")
        Else
            Call koneksi()
            Cmd = New OleDbCommand("select * from tbl_user where KodeUser='" & kodeUser.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows = False Then
                Cmd = New OleDbCommand("insert into tbl_user values('" & kodeUser.Text & _
                                       "','" & txtNama.Text & _
                                       "','" & txtUsername.Text & _
                                       "','" & txtPassword.Text & _
                                       "','" & cbLevel.Text & _
                                       "')", Conn)
                Cmd.ExecuteNonQuery()
                Call koneksi()
            End If
        End If
        Form_Menu.Show()
    End Sub
End Class