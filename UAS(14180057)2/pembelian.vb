Public Class pembelian

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Close()
    End Sub
    Private Sub pembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With gri
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Silver
        End With
        Label6.Visible = False
        Form1.Panel13.Visible = False
        tampil()
        isi()
        'no()
    End Sub
    Private Sub tampil()
        Dim judul() As String = {"NO", "Kode Barang", "Jumlah Beli", "Harga Beli", "Sub total"}
        Dim lebar() As String = {40, 200, 250, 250, 170}
        Dim i As Integer
        gri.RowHeadersVisible = False
        gri.ColumnCount = 5
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
        rek.Open("select * from tbl_detail_pembelian WHERE no_faktur ='" & TextBox2.Text & "' ", con, 3, 2)
        no = 1
        Do While Not rek.EOF

            Me.gri.Rows.Add(no, rek.Fields("kd_brg").Value, rek.Fields("jml_beli").Value,
                            rek.Fields("harga_beli").Value, rek.Fields("total").Value)
            rek.MoveNext()
            no = no + 1
        Loop
        tutup()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tampil()
        isi()
    End Sub

    Private Sub ComboBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ComboBox1.MouseClick
        buka()

        ComboBox1.Items.Clear()

        rek.Open("SELECT * FROM tbl_suplier", con, 3, 2)

        Do While Not rek.EOF
            ComboBox1.Items.Add(rek.Fields("nm_suplier").Value.ToString())
            rek.MoveNext()
        Loop


        tutup()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        buka()
        rek.Open("SELECT * FROM tbl_suplier WHERE nm_suplier ='" & ComboBox1.Text & "'", con, 3, 2)

        If Not rek.EOF Then
            Label6.Text = rek.Fields("kd_suplier").Value
        Else
            Label6.Text = ""
        End If


        tutup()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        buka()
        Dim a As String

        a = "INSERT INTO tbl_pembelian VALUES('" & TextBox2.Text & "','" & tgl.Text & "','" & Val(Label8.Text) & "','" & Label6.Text & "','" & Form1.lbl_nokar.Text & "','" & tgl2.Text & "')"
        con.Execute(a)
        MsgBox("Berhasil Tambah Data", MsgBoxStyle.Information, "Pemberitahuan")
        tutup()
        Label8.Text = 0
        TextBox2.Text = ""
        ComboBox1.Text = ""
        gri.Rows.Clear()

    End Sub

    Private Sub gri_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gri.CellContentClick

    End Sub

    Private Sub Button1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        buka()
        Dim a As String

        a = "INSERT INTO tbl_detail_pembelian VALUES('','" & TextBox2.Text & "','" & TextBox1.Text & "','" & TextBox5.Text & "','" & TextBox4.Text & "','" & Val(TextBox5.Text) * Val(TextBox4.Text) & "')"
        con.Execute(a)
        MsgBox("Berhasil Tambah Data", MsgBoxStyle.Information, "Pemberitahuan")
        tutup()
        isi()
        subtotal()
        TextBox1.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = 0
        TextBox5.Text = 0
    End Sub

    Private Sub gri_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles gri.CellMouseClick
        beli_brg.Show()
        beli_brg.TextBox1.Text = gri.Rows(e.ColumnIndex).Cells(1).Value
        beli_brg.TextBox2.Text = gri.Rows(e.ColumnIndex).Cells(2).Value
        beli_brg.TextBox4.Text = gri.Rows(e.ColumnIndex).Cells(3).Value
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tampil()
        isi()
    End Sub
    Public Sub subtotal()
        Dim hitung As Integer = 0
        For i As Integer = 0 To gri.Rows.Count - 1
            hitung = hitung + gri.Rows(i).Cells(4).Value
            Label8.Text = hitung
        Next
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            buka()
            rek.Open("select * from tbl_brg WHERE kd_brg = '" & TextBox1.Text & "'", con, 3, 2)
            If Not rek.EOF Then
                TextBox3.Text = rek.Fields("nm_brg").Value
                TextBox5.Focus()
            Else
                MsgBox("Barang Belum Tersedia", MsgBoxStyle.Information, "Pemberitahuan")
            End If
            tutup()
        End If
        
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        
    End Sub
    Public Sub no()
        buka()
        rek.Open("select * from tbl_detail_pembelian where id_pembelian in (select max(id_pembelian) from tbl_detail_pembelian)", con, 3, 2)
        Dim urutan As String
        Dim hitung As Long

        If Not rek.EOF Then


            urutan = "J" + Format(Now, "yyMMdd") + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(rek.GetString(0), 3) + 1
            urutan = "J" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        TextBox2.Text = urutan
        tutup()
    End Sub
    Private Sub TextBox5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox5.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox4.Focus()
        End If
    End Sub

    Private Sub TextBox4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button5.Focus()
        End If
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBox1.Focus()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        TextBox7.Text = Val(TextBox6.Text) - Val(Label8.Text)
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tampil()
        isi()
    End Sub
End Class