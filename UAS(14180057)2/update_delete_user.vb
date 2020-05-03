Public Class update_delete_user

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        buka()
        Dim a As String

        a = "UPDATE tbl_user SET nm_user='" & TextBox1.Text & "',tgl_lahir='" & tgl.Text & "',alamat='" & TextBox3.Text & "',nohp='" & TextBox4.Text & "', username='" & TextBox6.Text & "',password='" & TextBox5.Text & "',lvl_user='" & ComboBox1.Text & "' WHERE id_user='" & Label10.Text & "' "
        con.Execute(a)
        MsgBox("Berhasil Update Data", MsgBoxStyle.Information, "Pemberitahuan")
        tutup()
        Me.Close()
    End Sub

    Private Sub update_delete_user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label10.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        buka()
        Dim a As String

        a = "DELETE FROM tbl_user WHERE id_user='" & Label10.Text & "' "
        con.Execute(a)
        MsgBox("Berhasil Hapus Data", MsgBoxStyle.Information, "Pemberitahuan")
        tutup()
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            tgl.Focus()
        End If
    End Sub

    Private Sub tgl_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tgl.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox3.Focus()
        End If
    End Sub

    Private Sub TextBox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox4.Focus()
        End If
    End Sub

    Private Sub TextBox4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox6.Focus()
        End If
    End Sub

    Private Sub TextBox6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox6.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox5.Focus()
        End If
    End Sub

    Private Sub TextBox5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox5.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.Focus()
        End If
    End Sub

    Private Sub Button1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button1.KeyDown
        If e.KeyCode = Keys.Tab Then
            Button2.Focus()
        End If
    End Sub
End Class