Public Class beli_brg

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        buka()
        Dim a As String

        a = "DELETE FROM tbl_detail_pembelian WHERE kd_brg='" & TextBox1.Text & "'"
        con.Execute(a)
        MsgBox("Berhasil Delete Data", MsgBoxStyle.Information, "Pemberitahuan")
        tutup()
        Me.Close()
    End Sub

    Private Sub beli_brg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Close()
    End Sub
End Class