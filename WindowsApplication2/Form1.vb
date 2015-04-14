
Public Class Form1
   
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If txt1.Text = "admin" And txt2.Text = "admin" Then
            MessageBox.Show("Đăng nhập thành công")
            Form2.Show()
        Else
            MessageBox.Show("Sai mật khẩu")
        End If
    End Sub
End Class
