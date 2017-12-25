Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing And TextBox2.Text = Nothing And TextBox3.Text = Nothing Then
            MsgBox("E necessario o preenchimento de todos os campos!", MsgBoxStyle.Exclamation)
        Else
            Shell("netsh int ip set address name=" & Chr(34) & "Conexão Local" & Chr(34) & " source=static " & TextBox1.Text & " " & TextBox2.Text & " " & TextBox3.Text)
        End If
    End Sub
End Class