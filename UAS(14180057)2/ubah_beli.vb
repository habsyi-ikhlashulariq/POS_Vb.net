Public Class ubah_beli

    Private Sub ubah_beli_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        buka()
        Dim a As String

        a = "UPDATE tbl_detail_pembelian SET jml_beli='" & TextBox2.Text & "', harga_beli='" & TextBox3.Text & "' WHERE kd_jb='" & Label4.Text & "' "
        con.Execute(a)
        MsgBox("Berhasil Update Data", MsgBoxStyle.Information, "Pemberitahuan")
        tutup()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        buka()
        Dim a As String

        a = "DELETE FROM tbl_detail_pembelian WHERE kd_jb='" & Label4.Text & "' "
        con.Execute(a)
        MsgBox("Berhasil Hapus Data", MsgBoxStyle.Information, "Pemberitahuan")
        tutup()
        Me.Close()
    End Sub
End Class