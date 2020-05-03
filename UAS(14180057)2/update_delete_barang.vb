Public Class update_delete_barang

    Private Sub update_delete_barang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label9.Visible = False
        TextBox4.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        buka()
        Dim a As String

        a = "INSERT INTO tbl_detail_brg VALUES('','" & Label9.Text & "','" & TextBox2.Text & "')"
        con.Execute(a)
        MsgBox("Berhasil Update Data", MsgBoxStyle.Information, "Pemberitahuan")
        tutup()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        buka()
        Dim a As String

        a = "DELETE FROM tbl_brg WHERE kd_brg='" & Label9.Text & "' "
        con.Execute(a)
        MsgBox("Berhasil Hapus Data", MsgBoxStyle.Information, "Pemberitahuan")
        tutup()
        Me.Close()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox4.Focus()
        End If
    End Sub

    Private Sub ComboBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ComboBox1.MouseClick
        buka()

        ComboBox1.Items.Clear()

        rek.Open("SELECT * FROM tbl_jb", con, 3, 2)

        Do While Not rek.EOF
            ComboBox1.Items.Add(rek.Fields("nm_jb").Value.ToString())
            rek.MoveNext()
        Loop


        tutup()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        buka()
        rek.Open("SELECT * FROM tbl_jb WHERE nm_jb ='" & ComboBox1.Text & "'", con, 3, 2)

        If Not rek.EOF Then
            TextBox4.Text = rek.Fields("satuan_jual").Value
        Else
            TextBox4.Text = ""
        End If


        tutup()
    End Sub

    Private Sub TextBox4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.Focus()
        End If
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBox1.Focus()
        End If
    End Sub

    Private Sub Button1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button1.KeyDown
        If e.KeyCode = Keys.Tab Then
            Button2.Focus()
        End If
    End Sub
End Class