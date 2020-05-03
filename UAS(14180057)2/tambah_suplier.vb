Public Class tambah_suplier

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        buka()
        Dim a As String

        a = "INSERT INTO tbl_suplier VALUES('','" & TextBox1.Text & "','" & TextBox2.Text & ",'" & TextBox3.Text & "')"
        con.Execute(a)
        MsgBox("Berhasil Tambah Data", MsgBoxStyle.Information, "Pemberitahuan")
        tutup()
        Me.Close()
    End Sub

    Private Sub tambah_suplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox3.Focus()
        End If
    End Sub

    Private Sub TextBox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.Focus()
        End If
    End Sub
End Class