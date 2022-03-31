Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Form_Lap_Jual_Bulanan
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
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim crypt As New ReportDocument
            Dim crtablelogoninfos As New TableLogOnInfos
            Dim crtablelogoninfo As New TableLogOnInfo
            Dim crconnectioninfo As New ConnectionInfo
            Dim crtables As Tables
            Dim crtable As Table
            Dim laporan As New Lap_bulanan

            crypt = laporan

            With crconnectioninfo
                .ServerName = Application.StartupPath & "\db_aplikasi_revisi.mdb"
                .DatabaseName = Application.StartupPath & "\db_aplikasi_revisi.mdb"
                .UserID = ""
                .Password = ""
            End With
            crtables = crypt.Database.Tables
            For Each crtable In crtables
                crtablelogoninfo = crtable.LogOnInfo
                crtablelogoninfo.ConnectionInfo = crconnectioninfo
                crtable.ApplyLogOnInfo(crtablelogoninfo)
            Next
            CrystalReportViewer1.SelectionFormula = "Month({tbl_jual.tgljual})=" & Val(ComboBox1.Text) & " and Year({tbl_jual.tgljual})=" & Val(ComboBox2.Text)
            CrystalReportViewer1.ReportSource = crypt
            CrystalReportViewer1.Refresh()
            CrystalReportViewer1.RefreshReport()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CrystalReportViewer1.PrintReport()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CrystalReportViewer1.ExportReport()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Private Sub Form_Lap_Jual_Bulanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class