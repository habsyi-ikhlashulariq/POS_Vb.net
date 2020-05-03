Public Class Jenis_Barang

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        tmbah_jenis_barang.Show()
    End Sub

    Private Sub Jenis_Barang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With gri
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Silver
        End With
        Form1.Panel13.Visible = False
        tampil()
        isi()
    End Sub

    Private Sub gri_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles gri.CellMouseClick
        update_delete_jenis_barang.Show()
        update_delete_jenis_barang.Label4.Text = gri.Rows(e.ColumnIndex).Cells(1).Value
        update_delete_jenis_barang.TextBox1.Text = gri.Rows(e.ColumnIndex).Cells(2).Value
        update_delete_jenis_barang.TextBox2.Text = gri.Rows(e.ColumnIndex).Cells(3).Value
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tampil()
        isi()
    End Sub




    Private Sub tampil()
        Dim judul() As String = {"NO", "Kode Jenis barang", "Nama Jenis Barang", "Satuan"}
        Dim lebar() As String = {40, 230, 320, 320}
        Dim i As Integer
        gri.RowHeadersVisible = False
        gri.ColumnCount = 4
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
        rek.Open("select * from tbl_jb", con, 3, 2)
        no = 1
        Do While Not rek.EOF

            Me.gri.Rows.Add(no, rek.Fields("kd_jb").Value, rek.Fields("nm_jb").Value, rek.Fields("satuan_jual").Value)
            rek.MoveNext()
            no = no + 1
        Loop
        tutup()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Close()
    End Sub

    Private Sub TextBox7_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.GotFocus
        TextBox7.BackColor = Color.White
        TextBox7.ForeColor = Color.Maroon
    End Sub

    Private Sub TextBox7_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox7.LostFocus
        TextBox7.BackColor = Color.LightGray
        TextBox7.ForeColor = Color.Maroon
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        buka()
        Dim no As Integer
        Me.gri.Rows.Clear()
        rek.Open("select * from tbl_jb where kd_jb like '%" & TextBox7.Text & "%' or nm_jb like '%" & TextBox7.Text & "%' ", con, 3, 2)
        no = 1
        Do While Not rek.EOF

            Me.gri.Rows.Add(no, rek.Fields("kd_jb").Value, rek.Fields("nm_jb").Value, rek.Fields("satuan_jual").Value)
            rek.MoveNext()
            no = no + 1
        Loop
        tutup()
    End Sub

End Class