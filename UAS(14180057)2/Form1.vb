Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label6.Text = TimeOfDay
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        awal()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Panel2.Visible Then
            Panel2.Visible = False
        Else
            Panel2.Visible = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Panel13.Visible Then
            Panel13.Visible = False
        Else
            Panel13.Visible = True
            penjualan.Close()
            Suplier.Close()
            Barang.Close()
            user.Close()
            Jenis_Barang.Close()
            pembelian.Close()

        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If MsgBox("Apakah Anda Ingin Keluar ? ", MsgBoxStyle.Question + vbYesNo, "Pemberitahuan") = vbYes Then
            If Button2.Visible Then
                Me.Close()
            Else
                awal()
            End If
        End If
    End Sub

    Private Sub Button3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button3.KeyDown
        If e.KeyCode = Keys.Down Then
            Button4.Focus()
        End If
    End Sub


    Private Sub Button3_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseClick
        If e.Clicks Then
            Panel5.BackColor = Color.Gray
            Panel6.BackColor = Color.Silver
            Panel7.BackColor = Color.Silver
            Panel8.BackColor = Color.Silver
            Panel9.BackColor = Color.Silver
            Panel10.BackColor = Color.Silver
            Panel12.BackColor = Color.Silver
        End If
    End Sub

    Private Sub Button4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button4.KeyDown
        If e.KeyCode = Keys.Down Then
            Button5.Focus()
        End If
    End Sub

    Private Sub Button4_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button4.MouseClick
        If e.Clicks Then
            Panel5.BackColor = Color.Silver
            Panel6.BackColor = Color.Gray
            Panel7.BackColor = Color.Silver
            Panel8.BackColor = Color.Silver
            Panel9.BackColor = Color.Silver
            Panel10.BackColor = Color.Silver
            Panel11.BackColor = Color.Silver
            Panel12.BackColor = Color.Silver
        End If

    End Sub

    Private Sub Button5_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button5.MouseClick
        If e.Clicks Then
            Panel5.BackColor = Color.Silver
            Panel6.BackColor = Color.Silver
            Panel7.BackColor = Color.Gray
            Panel8.BackColor = Color.Silver
            Panel9.BackColor = Color.Silver
            Panel10.BackColor = Color.Silver
            Panel11.BackColor = Color.Silver
            Panel12.BackColor = Color.Silver
        End If

    End Sub

    Private Sub Button6_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button6.MouseClick
        If e.Clicks Then
            Panel5.BackColor = Color.Silver
            Panel6.BackColor = Color.Silver
            Panel7.BackColor = Color.Silver
            Panel8.BackColor = Color.Gray
            Panel9.BackColor = Color.Silver
            Panel10.BackColor = Color.Silver
            Panel11.BackColor = Color.Silver
            Panel12.BackColor = Color.Silver

          
        End If
    End Sub

    Private Sub Button7_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button7.MouseClick
        If e.Clicks Then
            Panel5.BackColor = Color.Silver
            Panel6.BackColor = Color.Silver
            Panel7.BackColor = Color.Silver
            Panel8.BackColor = Color.Silver
            Panel9.BackColor = Color.Gray
            Panel10.BackColor = Color.Silver
            Panel11.BackColor = Color.Silver
            Panel12.BackColor = Color.Silver
        End If
    End Sub

    Private Sub Button8_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button8.MouseClick
        If e.Clicks Then
            Panel5.BackColor = Color.Silver
            Panel6.BackColor = Color.Silver
            Panel7.BackColor = Color.Silver
            Panel8.BackColor = Color.Silver
            Panel9.BackColor = Color.Silver
            Panel10.BackColor = Color.Gray
            Panel11.BackColor = Color.Silver
            Panel12.BackColor = Color.Silver
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        awal()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim frm2 As Login = New Login
        frm2.Owner = Me
        frm2.MdiParent = Me
        frm2.Show()

        Panel2.Visible = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim frm5 As Barang = New Barang
        frm5.Owner = Me
        frm5.MdiParent = Me
        frm5.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim frm7 As Suplier = New Suplier
        frm7.Owner = Me
        frm7.MdiParent = Me
        frm7.Show()
    End Sub

    Private Sub Button9_MouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button9.MouseClick
        If e.Clicks Then
            Panel5.BackColor = Color.Silver
            Panel6.BackColor = Color.Silver
            Panel7.BackColor = Color.Silver
            Panel8.BackColor = Color.Silver
            Panel9.BackColor = Color.Silver
            Panel10.BackColor = Color.Silver
            Panel11.BackColor = Color.Gray
            Panel12.BackColor = Color.Silver
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim frm6 As Jenis_Barang = New Jenis_Barang
        frm6.Owner = Me
        frm6.MdiParent = Me
        frm6.Show()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim frm8 As user = New user
        frm8.Owner = Me
        frm8.MdiParent = Me
        frm8.Show()
    End Sub

    Private Sub Button14_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button14.MouseClick
        If e.Clicks Then
            Panel5.BackColor = Color.Silver
            Panel6.BackColor = Color.Silver
            Panel7.BackColor = Color.Silver
            Panel8.BackColor = Color.Silver
            Panel9.BackColor = Color.Silver
            Panel10.BackColor = Color.Silver
            Panel11.BackColor = Color.Silver
            Panel12.BackColor = Color.Gray

        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim frm9 As pembelian = New pembelian
        frm9.Owner = Me
        frm9.MdiParent = Me
        frm9.Show()
    End Sub

    Private Sub Panel13_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel13.Paint

    End Sub

    Private Sub btnBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBarang.Click

    End Sub

    Private Sub btnBarang_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnBarang.MouseClick
        If e.Clicks Then
            Panel5.BackColor = Color.Silver
            Panel6.BackColor = Color.Gray
            Panel7.BackColor = Color.Silver
            Panel8.BackColor = Color.Silver
            Panel9.BackColor = Color.Silver
            Panel10.BackColor = Color.Silver

            Dim frm5 As Barang = New Barang
            frm5.Owner = Me
            frm5.MdiParent = Me
            frm5.Show()

        End If
    End Sub

    Private Sub btnBarang_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBarang.MouseLeave
        btnBarang.BackColor = Color.Maroon
        btnBarang.ForeColor = Color.Silver
    End Sub

    Private Sub btnBarang_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnBarang.MouseMove
        btnBarang.BackColor = Color.Silver
        btnBarang.ForeColor = Color.Maroon
    End Sub
    Private Sub btnPenjualan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPenjualan.Click

    End Sub

    Private Sub btnPenjualan_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnPenjualan.MouseClick
        If e.Clicks Then
            Panel5.BackColor = Color.Silver
            Panel6.BackColor = Color.Silver
            Panel7.BackColor = Color.Gray
            Panel8.BackColor = Color.Silver
            Panel9.BackColor = Color.Silver
            Panel10.BackColor = Color.Silver
            Panel11.BackColor = Color.Silver
            Panel12.BackColor = Color.Silver

            Dim frm_jual As penjualan = New penjualan
            frm_jual.Owner = Me
            frm_jual.MdiParent = Me
            frm_jual.Show()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim frm_jual As penjualan = New penjualan
        frm_jual.Owner = Me
        frm_jual.MdiParent = Me
        frm_jual.Show()
    End Sub

    Private Sub btnPembelian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPembelian.Click

    End Sub

    Private Sub btnPembelian_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnPembelian.MouseClick
        If e.Clicks Then
            Panel5.BackColor = Color.Silver
            Panel6.BackColor = Color.Silver
            Panel7.BackColor = Color.Silver
            Panel8.BackColor = Color.Silver
            Panel9.BackColor = Color.Gray
            Panel10.BackColor = Color.Silver
            Panel11.BackColor = Color.Silver
            Panel12.BackColor = Color.Silver

            Dim frm9 As pembelian = New pembelian
            frm9.Owner = Me
            frm9.MdiParent = Me
            frm9.Show()
        End If
    End Sub

    Private Sub btnJb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJb.Click

    End Sub

    Private Sub btnJb_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnJb.MouseClick
        If e.Clicks Then
            Panel5.BackColor = Color.Silver
            Panel6.BackColor = Color.Silver
            Panel7.BackColor = Color.Silver
            Panel8.BackColor = Color.Silver
            Panel9.BackColor = Color.Silver
            Panel10.BackColor = Color.Silver
            Panel11.BackColor = Color.Gray
            Panel12.BackColor = Color.Silver

            Dim frm6 As Jenis_Barang = New Jenis_Barang
            frm6.Owner = Me
            frm6.MdiParent = Me
            frm6.Show()
        End If
    End Sub

    Private Sub tbnSuplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnSuplier.Click

    End Sub

    Private Sub tbnSuplier_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbnSuplier.MouseClick
        If e.Clicks Then
            Panel5.BackColor = Color.Silver
            Panel6.BackColor = Color.Silver
            Panel7.BackColor = Color.Silver
            Panel8.BackColor = Color.Silver
            Panel9.BackColor = Color.Silver
            Panel10.BackColor = Color.Gray
            Panel11.BackColor = Color.Silver
            Panel12.BackColor = Color.Silver


            Dim frm7 As Suplier = New Suplier
            frm7.Owner = Me
            frm7.MdiParent = Me
            frm7.Show()
        End If

    End Sub

    Private Sub BtnUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUser.Click

    End Sub

    Private Sub BtnUser_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnUser.MouseClick
        If e.Clicks Then
            Panel5.BackColor = Color.Silver
            Panel6.BackColor = Color.Silver
            Panel7.BackColor = Color.Silver
            Panel8.BackColor = Color.Silver
            Panel9.BackColor = Color.Silver
            Panel10.BackColor = Color.Silver
            Panel11.BackColor = Color.Silver
            Panel12.BackColor = Color.Gray

            Dim frm8 As user = New user
            frm8.Owner = Me
            frm8.MdiParent = Me
            frm8.Show()

        End If
    End Sub

    Private Sub btnPenjualan_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPenjualan.MouseLeave
        btnPenjualan.BackColor = Color.Maroon
        btnPenjualan.ForeColor = Color.Silver
    End Sub

    Private Sub btnPenjualan_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnPenjualan.MouseMove
        btnPenjualan.BackColor = Color.Silver
        btnPenjualan.ForeColor = Color.Maroon
    End Sub

    Private Sub btnLaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLaporan.Click

    End Sub

    Private Sub btnLaporan_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnLaporan.MouseClick
        If e.Clicks Then
            Panel5.BackColor = Color.Silver
            Panel6.BackColor = Color.Silver
            Panel7.BackColor = Color.Silver
            Panel8.BackColor = Color.Gray
            Panel9.BackColor = Color.Silver
            Panel10.BackColor = Color.Silver
            Panel11.BackColor = Color.Silver
            Panel12.BackColor = Color.Silver

        End If
    End Sub

    Private Sub btnLaporan_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLaporan.MouseLeave
        btnLaporan.BackColor = Color.Maroon
        btnLaporan.ForeColor = Color.Silver
    End Sub

    Private Sub btnLaporan_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnLaporan.MouseMove
        btnLaporan.BackColor = Color.Silver
        btnLaporan.ForeColor = Color.Maroon
    End Sub

    Private Sub btnPembelian_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPembelian.MouseLeave
        btnPembelian.BackColor = Color.Maroon
        btnPembelian.ForeColor = Color.Silver
    End Sub

    Private Sub btnPembelian_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnPembelian.MouseMove
        btnPembelian.BackColor = Color.Silver
        btnPembelian.ForeColor = Color.Maroon
    End Sub

    Private Sub btnJb_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnJb.MouseLeave
        btnJb.BackColor = Color.Maroon
        btnJb.ForeColor = Color.Silver
    End Sub

    Private Sub btnJb_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnJb.MouseMove
        btnJb.BackColor = Color.Silver
        btnJb.ForeColor = Color.Maroon
    End Sub

    Private Sub tbnSuplier_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbnSuplier.MouseLeave
        tbnSuplier.BackColor = Color.Maroon
        tbnSuplier.ForeColor = Color.Silver
    End Sub

    Private Sub tbnSuplier_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbnSuplier.MouseMove
        tbnSuplier.BackColor = Color.Silver
        tbnSuplier.ForeColor = Color.Maroon
    End Sub

    Private Sub BtnUser_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnUser.MouseLeave
        BtnUser.BackColor = Color.Maroon
        BtnUser.ForeColor = Color.Silver
    End Sub

    Private Sub BtnUser_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnUser.MouseMove
        BtnUser.BackColor = Color.Silver
        BtnUser.ForeColor = Color.Maroon
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

    End Sub


End Class
