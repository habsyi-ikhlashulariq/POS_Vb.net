Imports System.Data.Odbc
Module Module1
    Public con As New ADODB.Connection
    Public rek As New ADODB.Recordset

    Public Sub buka()
        con.Open("DSN=uas")
    End Sub

    Public Sub tutup()
        con.Close()
    End Sub

    Public Sub awal()
        Form1.Label5.Text = Today
        Form1.Label3.Text = Chr(169)
        Form1.Label7.Visible = False
        Form1.Label8.Visible = False
        Form1.Button2.Visible = True
        Form1.Button3.Visible = False
        Form1.Button4.Visible = False
        Form1.Button5.Visible = False
        Form1.Button6.Visible = False
        Form1.Button7.Visible = False
        Form1.Button8.Visible = False
        Form1.Button9.Visible = False
        Form1.Button10.Visible = False
        Form1.Button11.Visible = False
        Form1.Button14.Visible = False
        Form1.PictureBox5.Visible = False
        Form1.PictureBox6.Visible = False
        Form1.PictureBox3.Visible = False
        Form1.PictureBox4.Visible = True
        Form1.Panel2.Visible = False
        Form1.Panel5.Visible = False
        Form1.Panel6.Visible = False
        Form1.Panel7.Visible = False
        Form1.Panel8.Visible = False
        Form1.Panel9.Visible = False
        Form1.Panel10.Visible = False
        Form1.Panel11.Visible = False
        Form1.Panel12.Visible = False
        Form1.Panel13.Visible = False
    End Sub
    Public Sub admin()
        MsgBox("Selamat Datang Admin", MsgBoxStyle.Information, "Pemberitahuan")
        Form1.Panel5.BackColor = Color.Gray
        Form1.Button3.Visible = True
        Form1.Button4.Visible = True
        Form1.Button5.Visible = True
        Form1.Button6.Visible = True
        Form1.Button7.Visible = True
        Form1.Button8.Visible = True
        Form1.Panel2.Visible = True
        Form1.Panel5.Visible = True
        Form1.Panel6.Visible = True
        Form1.Panel7.Visible = True
        Form1.Panel8.Visible = True
        Form1.Panel9.Visible = True
        Form1.Panel12.Visible = True
        Form1.Button9.Visible = True
        Form1.Panel10.Visible = True
        Form1.Panel11.Visible = True
        Form1.Button10.Visible = True
        Form1.Button11.Visible = True
        Form1.Button14.Visible = True
        Form1.Button11.Text = rek.Fields("username").Value
        Form1.lbl_nokar.Text = rek.Fields("id_user").Value
        Form1.Label8.Text = "Admin"
        Form1.Label7.Visible = True
        Form1.Label8.Visible = True
        Form1.Button2.Visible = False
        Form1.PictureBox4.Visible = False
        Form1.PictureBox3.Visible = True
        Form1.PictureBox5.Visible = True
        Form1.PictureBox6.Visible = True

        'admin
        tambah_barang.Button1.Enabled = True
        tambah_barang.TextBox2.Enabled = True
        update_delete_barang.Button1.Enabled = True
        update_delete_barang.Button2.Enabled = True
        Form1.PPjl.Enabled = True
        Form1.Panel7.Enabled = True
        Form1.Button5.Enabled = True

        Form1.Panel13.Visible = True
        Form1.PBrg.Visible = True
        Form1.PPjl.Visible = True
        Form1.PPl.Visible = True
        Form1.PSp.Visible = True
        Form1.PKr.Visible = True
        Form1.PLn.Visible = True
        Form1.Pusr.Visible = True
    End Sub
    Public Sub kasir()
        Form1.Panel5.BackColor = Color.Gray
        MsgBox("Selamat Datang Kasir", MsgBoxStyle.Information, "Pemberitahuan")
        Form1.Button3.Visible = True
        Form1.Button4.Visible = True
        Form1.Button5.Visible = True
        Form1.Button6.Visible = False
        Form1.Button7.Visible = False
        Form1.Button8.Visible = False
        Form1.Panel2.Visible = True
        Form1.Panel5.Visible = True
        Form1.Panel6.Visible = True
        Form1.Panel7.Visible = True
        Form1.Panel8.Visible = False
        Form1.Panel9.Visible = False
        Form1.Panel10.Visible = False
        Form1.Panel11.Visible = False
        Form1.Panel12.Visible = False
        Form1.Button10.Visible = True
        Form1.Button9.Visible = False
        Form1.Button14.Visible = False
        Form1.Button11.Visible = True
        Form1.Button11.Text = rek.Fields("username").Value
        Form1.lbl_nokar.Text = rek.Fields("id_user").Value
        Form1.Label8.Text = "Kasir"
        Form1.Label7.Visible = True
        Form1.Label8.Visible = True
        Form1.Button2.Visible = False
        Form1.PictureBox3.Visible = True
        Form1.PictureBox4.Visible = False
        Form1.PictureBox5.Visible = True
        Form1.PictureBox6.Visible = True

        Form1.Panel13.Visible = True
        Form1.PBrg.Visible = True
        Form1.PPjl.Visible = True
        Form1.PPl.Visible = False
        Form1.PSp.Visible = False
        Form1.PKr.Visible = False
        Form1.PLn.Visible = False
        Form1.Pusr.Visible = False

        'kasir
        tambah_barang.Button1.Enabled = False
        update_delete_barang.Button1.Enabled = False
        update_delete_barang.Button2.Enabled = False
        Form1.PPjl.Enabled = True
        Form1.Panel7.Enabled = True
        Form1.Button5.Enabled = True


        'Dashboard.Panel5.Visible = False
        'Dashboard.Panel6.Visible = False
        'Dashboard.Panel7.Visible = False
    End Sub

    Public Sub gudang()
        Form1.Panel5.BackColor = Color.Gray
        MsgBox("Selamat Datang Staf Gudang", MsgBoxStyle.Information, "Pemberitahuan")
        Form1.Button3.Visible = True
        Form1.Button4.Visible = True
        Form1.Button5.Visible = True
        Form1.Button5.Enabled = False
        Form1.Button6.Visible = False
        Form1.Button7.Visible = True
        Form1.Button8.Visible = False
        Form1.Panel2.Visible = True
        Form1.Panel5.Visible = True
        Form1.Panel6.Visible = True
        Form1.Panel7.Visible = True
        Form1.Panel8.Visible = False
        Form1.Panel9.Visible = True
        Form1.Panel10.Visible = False
        Form1.Panel11.Visible = True
        Form1.Panel12.Visible = False
        Form1.Button10.Visible = True
        Form1.Button9.Visible = True
        Form1.Button14.Visible = False
        Form1.Button11.Visible = True
        Form1.Button11.Text = rek.Fields("username").Value
        Form1.lbl_nokar.Text = rek.Fields("id_user").Value
        Form1.Label8.Text = "Staf Gudang"
        Form1.Label7.Visible = True
        Form1.Label8.Visible = True
        Form1.Button2.Visible = False
        Form1.PictureBox3.Visible = True
        Form1.PictureBox4.Visible = False
        Form1.PictureBox5.Visible = True
        Form1.PictureBox6.Visible = True

        Form1.Panel13.Visible = True
        Form1.PBrg.Visible = True
        Form1.PPjl.Visible = True
        'gudang
        Form1.PPjl.Enabled = False
        Form1.Panel7.Enabled = False
        Form1.Button5.Enabled = False

        Form1.PPl.Visible = True
        Form1.PSp.Visible = False
        Form1.PKr.Visible = True
        Form1.Pusr.Visible = False
        Form1.PLn.Visible = False

        'gudang
        tambah_barang.Button1.Enabled = True
        tambah_barang.TextBox2.Enabled = False
        update_delete_barang.Button1.Enabled = True
        update_delete_barang.Button2.Enabled = True

        'Dashboard.Panel5.Visible = False
        'Dashboard.Panel6.Visible = False
        'Dashboard.Panel7.Visible = False
    End Sub

End Module
