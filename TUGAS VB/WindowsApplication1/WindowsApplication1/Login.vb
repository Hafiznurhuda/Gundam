Public Class Login

    Private Sub BTLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTLogin.Click
        If TBUser.Text = "" And TBpw.Text = "" Then
            MsgBox("anda tidak bisa login Lengkapi Username dan Password dulu")
        Else
            Sql = "Select Username,Password from Login where Username= '" & TBUser.Text & "' and Password='" & TBpw.Text & "'"
            OPENCONN()
            read(Sql)

            rdx.Read()
            If rdx.HasRows Then

                Me.Hide()
                Form1.Show()
            Else
                MsgBox("data hilang", vbCritical, "Pesan Singkat")
            End If

            closeConn()

        End If
    End Sub
End Class