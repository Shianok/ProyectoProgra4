Public Class Empleado_perfil

    Friend Sub REFRESCAR()
        T.Tables.Clear() 'Limpiando el contenido de toda la tabla temporal
        SQL = "SELECT CONTRASENA, USUARIO, CORREO, FOTO, NUMERO_TELEFONO FROM EMPLEADO WHERE CEDULA= '" & cedula & "'"
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For FILA As Integer = 0 To T.Tables(0).Rows.Count - 1 'se;ala el inicio de la tabla en 0,0
                CONTRASENA_USUARIO.Text = T.Tables(0).Rows(FILA).ItemArray(0).ToString
                NOMBRE.Text = T.Tables(0).Rows(FILA).ItemArray(1).ToString
                CORREO_USUARIO.Text = T.Tables(0).Rows(FILA).ItemArray(2).ToString
                foto_usuario = T.Tables(0).Rows(FILA).ItemArray(3).ToString
                TELEFONO_USUARIO.Text = T.Tables(0).Rows(FILA).ItemArray(4).ToString
            Next
        End If
    End Sub
    Private Sub Registrarse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NOMBRE.Text = NombreCompleto
        CORREO_USUARIO.Text = correo_conexion
        CONTRASENA_USUARIO.Text = contrasena
        TELEFONO_USUARIO.Text = telefono
        IMG_USUARIO.Image = Image.FromFile(foto_usuario)
        IMG_USUARIO.Tag = foto_usuario

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
        Interfaz.Show()
    End Sub

    Private Sub BTN_ACTUALIZAR_Click(sender As Object, e As EventArgs) Handles BTN_ACTUALIZAR.Click
        SQL = "UPDATE EMPLEADO SET NOMBRE_COMPLETO='" & NOMBRE.Text & "', CORREO='" & CORREO_USUARIO.Text & "', CONTRASENA='" & CONTRASENA_USUARIO.Text & "', FOTO='" & IMG_USUARIO.Tag & "', NUMERO_TELEFONO='" & TELEFONO_USUARIO.Text & "' WHERE ID=" & ID & ""
        EJECUTAR(SQL)
        LIMPIAR_UPDATE()
        REFRESCAR()
        MsgBox("Informacion actualizada correctamente", vbInformation + vbOKOnly, "Guardando")
        'ActualizarUsuario(NombreCompleto, correo, contrasena, foto_usuario, telefono)
    End Sub

    Private Sub BTN_BORRAR_Click(sender As Object, e As EventArgs) Handles BTN_BORRAR.Click

    End Sub
End Class