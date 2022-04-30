Imports System.Data.OleDb
Module Module1
    Public Conn As OleDbConnection
    Public Da As OleDbDataAdapter
    Public Ds As DataSet
    Public Rd As OleDbDataReader
    Public Cmd As OleDbCommand
    Public LokasiData As String
    Public Sub konekdb()
        LokasiData = "provider=microsoft.jet.oledb.4.0;data source=db_aplikasi_revisi.mdb"
        Conn = New OleDbConnection(LokasiData)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
End Module
