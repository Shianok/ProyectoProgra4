Public Class Registrarse
    Private Sub Registrarse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IMG_USUARIO.Image = My.Resources.user
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        End
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class