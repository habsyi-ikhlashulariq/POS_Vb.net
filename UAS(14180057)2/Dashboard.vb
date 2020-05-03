Public Class Dashboard

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseClick
        If e.Clicks Then
            Form1.Panel5.BackColor = Color.Silver
            Form1.Panel6.BackColor = Color.Gray
            Form1.Panel7.BackColor = Color.Silver
            Form1.Panel8.BackColor = Color.Silver
            Form1.Panel9.BackColor = Color.Silver
            Form1.Panel10.BackColor = Color.Silver
        End If
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Maroon
        Button1.ForeColor = Color.Silver
    End Sub

    Private Sub Button1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseMove
        Button1.BackColor = Color.Silver
        Button1.ForeColor = Color.Maroon
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.Maroon
        Button2.ForeColor = Color.Silver
    End Sub

    Private Sub Button2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseMove
        Button2.BackColor = Color.Silver
        Button2.ForeColor = Color.Maroon
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Close()
    End Sub

    Private Sub Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        buka()
        If Form1.Label8.Text = "Admin" Then
            Panel1.Visible = True
            Panel3.Visible = True
            Panel4.Visible = True
            Panel5.Visible = True
            Panel6.Visible = True
            Panel7.Visible = True
        ElseIf Form1.Label8.Text = "Kasir" Then
            Panel1.Visible = True
            Panel3.Visible = True
            Panel4.Visible = True
            Panel5.Visible = False
            Panel6.Visible = False
            Panel7.Visible = False
        End If
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Button3.BackColor = Color.Maroon
        Button3.ForeColor = Color.Silver
    End Sub

    Private Sub Button3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseMove
        Button3.BackColor = Color.Silver
        Button3.ForeColor = Color.Maroon
    End Sub

    Private Sub Button4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseLeave
        Button4.BackColor = Color.Maroon
        Button4.ForeColor = Color.Silver
    End Sub

    Private Sub Button4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button4.MouseMove
        Button4.BackColor = Color.Silver
        Button4.ForeColor = Color.Maroon
    End Sub

    Private Sub Button5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.MouseLeave
        Button5.BackColor = Color.Maroon
        Button5.ForeColor = Color.Silver
    End Sub

    Private Sub Button5_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button5.MouseMove
        Button5.BackColor = Color.Silver
        Button5.ForeColor = Color.Maroon
    End Sub

    Private Sub Button6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseLeave
        Button6.BackColor = Color.Maroon
        Button6.ForeColor = Color.Silver
    End Sub

    Private Sub Button6_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button6.MouseMove
        Button6.BackColor = Color.Silver
        Button6.ForeColor = Color.Maroon
    End Sub

    Private Sub Panel8_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub
End Class