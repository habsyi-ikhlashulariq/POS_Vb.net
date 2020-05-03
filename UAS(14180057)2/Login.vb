Public Class Login

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Focus()
    End Sub
    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Maroon
        Button1.ForeColor = Color.Silver
    End Sub

    Private Sub Button1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseMove
        Button1.BackColor = Color.Silver
        Button1.ForeColor = Color.Maroon
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        buka()
        rek.Open("select * from tbl_user WHERE username = '" & TextBox1.Text & "' and password='" & TextBox2.Text & "'", con, 3, 2)
        If Not rek.EOF Then

            If rek.Fields("lvl_user").Value = "admin" Then
                admin()
                Me.Hide()
            ElseIf rek.Fields("lvl_user").Value = "kasir" Then
                kasir()
                Me.Hide()
            ElseIf rek.Fields("lvl_user").Value = "gudang" Then
                gudang()
                Me.Hide()
            End If
        Else
            MsgBox("Username Atau Password Salah")
        End If
        tutup()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Close()
    End Sub

    Private Sub TextBox2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.GotFocus
 
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.Focus()
            Button1.BackColor = Color.Silver
            Button1.ForeColor = Color.Maroon
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class