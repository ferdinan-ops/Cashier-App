Imports System.Data.OleDb
Module Module1
    Public Conn As OleDbConnection
    Public Da As OleDbDataAdapter
    Public Ds As DataSet
    Public Rd As OleDbDataReader
    Public Cmd As OleDbCommand
    Public LokasiData As String
    Public Sub konekdb()
        LokasiData = "Data Source=localhost;user id=root;database=rumah_sakit;"
        Conn = New OleDbConnection(LokasiData)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
End Module
