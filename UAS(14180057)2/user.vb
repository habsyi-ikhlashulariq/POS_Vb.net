Public Class user

    Private Sub user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With gri
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Silver
        End With
        Form1.Panel13.Visible = False
        tampil()
        isi()
    End Sub

    Private Sub TextBox7_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.GotFocus
        TextBox7.BackColor = Color.White
        TextBox7.ForeColor = Color.Maroon
    End Sub

    Private Sub TextBox7_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.LostFocus
        TextBox7.BackColor = Color.LightGray
        TextBox7.ForeColor = Color.Maroon
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        tmbh_user.Show()
    End Sub
    Private Sub tampil()
        Dim judul() As String = {"No", "Kode User", "Nama User", "Tanggal Lahir", "Alamat", "No. Hp", "Username", "Password", "Hak Akses"}
        Dim lebar() As String = {40, 40, 110, 100, 285, 100, 90, 70, 90}
        Dim i As Integer
        gri.RowHeadersVisible = False
        gri.ColumnCount = 9
        gri.RowCount = 1
        gri.SelectionMode = DataGridViewSelectionMode.CellSelect
        gri.ColumnHeadersDefaultCellStyle.Font = New Font("Cambria", 10)

        For i = 0 To gri.ColumnCount - 1
            gri.Columns(i).HeaderText = judul(i)
            gri.Columns(i).Width = lebar(i)
            gri.Columns(i).DefaultCellStyle.Font = New Font("Cambria", 9)
            gri.Columns(i).DefaultCellStyle.BackColor = Color.AliceBlue
        Next
    End Sub

    Private Sub isi()
        buka()
        Dim no As Integer
        Me.gri.Rows.Clear()
        rek.Open("select * from tbl_user", con, 3, 2)
        no = 1
        Do While Not rek.EOF

            Me.gri.Rows.Add(no, rek.Fields("id_user").Value, rek.Fields("nm_user").Value, rek.Fields("tgl_lahir").Value,
                            rek.Fields("alamat").Value, rek.Fields("nohp").Value, rek.Fields("username").Value, rek.Fields("password").Value,
                            rek.Fields("lvl_user").Value)
            rek.MoveNext()
            no = no + 1
        Loop
        tutup()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Close()
    End Sub

    Private Sub gri_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles gri.CellMouseClick
        update_delete_user.Show()
        update_delete_user.Label10.Text = gri.Rows(e.ColumnIndex).Cells(1).Value
        update_delete_user.TextBox1.Text = gri.Rows(e.ColumnIndex).Cells(2).Value
        update_delete_user.tgl.Text = gri.Rows(e.ColumnIndex).Cells(3).Value
        update_delete_user.TextBox3.Text = gri.Rows(e.ColumnIndex).Cells(4).Value
        update_delete_user.TextBox4.Text = gri.Rows(e.ColumnIndex).Cells(5).Value
        update_delete_user.TextBox6.Text = gri.Rows(e.ColumnIndex).Cells(6).Value
        update_delete_user.TextBox5.Text = gri.Rows(e.ColumnIndex).Cells(7).Value
        update_delete_user.ComboBox1.Text = gri.Rows(e.ColumnIndex).Cells(8).Value
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tampil()
        isi()
    End Sub

    Private Sub gri_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gri.CellContentClick

    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        buka()
        Dim no As Integer
        Me.gri.Rows.Clear()
        rek.Open("select * from tbl_user where id_user like '%" & TextBox7.Text & "%' or nm_user like '%" & TextBox7.Text & "%' ", con, 3, 2)
        no = 1
        Do While Not rek.EOF

            Me.gri.Rows.Add(no, rek.Fields("id_user").Value, rek.Fields("nm_user").Value, rek.Fields("tgl_lahir").Value, rek.Fields("alamat").Value, rek.Fields("nohp").Value, rek.Fields("username").Value, rek.Fields("password").Value, rek.Fields("lvl_user").Value)
            rek.MoveNext()
            no = no + 1
        Loop
        tutup()
    End Sub
End Class