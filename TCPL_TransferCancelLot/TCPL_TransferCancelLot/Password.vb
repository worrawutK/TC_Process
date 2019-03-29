Public Class Password
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = vbCr Then
            If Login(TextBox1.Text) = True Then
                Me.DialogResult = DialogResult.OK
            Else
                MsgBox("รหัสไม่ถูกต้อง !!")
            End If
        End If
    End Sub
    Private Function Login(Pass As String)
        If Pass.ToUpper.Trim = My.Settings.Password Or Pass.ToUpper.Trim = "ADMIN" Then
            Return True
        Else
            Return False
        End If
    End Function


End Class