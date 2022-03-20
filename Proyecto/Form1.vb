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
        Dim usuario_txt As String
        Dim contrasena_txt As String
        T.Tables.Clear() 'Limpiando el contenido de toda la tabla temporal
        SQL = "SELECT USUARIO, CONTRASENA FROM EMPLEADO"
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For FILA As Integer = 0 To T.Tables(0).Rows.Count - 1 'se;ala el inicio de la tabla en 0,0
                usuario_txt = T.Tables(0).Rows(FILA).ItemArray(0).ToString
                contrasena_txt = T.Tables(0).Rows(FILA).ItemArray(1).ToString
                If usuario_txt = USERNAME.Text And contrasena_txt = PASSWORD.Text Then
                    Interfaz.Show()
                    Me.Hide()
                Else
                    MsgBox("El nombre de usuario o contraseña son incorrecto...Por favor intenta de nuevo")
                End If

            Next
        End If

    End Sub
End Class
