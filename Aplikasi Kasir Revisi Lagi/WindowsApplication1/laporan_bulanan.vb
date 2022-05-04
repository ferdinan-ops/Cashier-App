﻿Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class laporan_bulanan
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
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
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        CrystalReportViewer1.PrintReport()
    End Sub

    Private Sub btnEkspor_Click(sender As Object, e As EventArgs) Handles btnEkspor.Click
        CrystalReportViewer1.ExportReport()
    End Sub
End Class