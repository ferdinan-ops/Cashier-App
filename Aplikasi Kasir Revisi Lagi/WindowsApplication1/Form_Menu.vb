Public Class Form_Menu

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        End
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form_databarang.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form_penjulan.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_user.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form_laporandatabarang.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form_Lap_Harian.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form_Lap_Jual_Bulanan.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form_Lap_Tahunan.ShowDialog()
    End Sub

    Private Sub Form_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lbl_level.Text = "Kasir" Then
            Button1.Enabled = False
            Button6.Enabled = False
            Button4.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button7.Enabled = False
        End If
    End Sub
End Class