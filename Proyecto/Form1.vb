Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FOTO.Image = My.Resources.doctor
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        End
    End Sub

    Private Sub USERNAME_Click(sender As Object, e As EventArgs) Handles USERNAME.Click
        USERNAME.Text = ""
    End Sub

    Private Sub PASSWORD_Click(sender As Object, e As EventArgs) Handles PASSWORD.Click
        PASSWORD.Text = ""
    End Sub

    Private Sub BTN_CREAR_Click(sender As Object, e As EventArgs) Handles BTN_CREAR.Click
        Me.Hide()
        Registrarse.Show()
    End Sub

    Private Sub BTN_INICIAR_SECCION_Click(sender As Object, e As EventArgs) Handles BTN_INICIAR_SECCION.Click
        Interfaz.Show()
    End Sub
End Class
