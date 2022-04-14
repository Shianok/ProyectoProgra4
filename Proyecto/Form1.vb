﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LIMPIAR_UPDATE()
        FOTO.Image = My.Resources.doctor
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        End
    End Sub

    Private Sub USERNAME_Click(sender As Object, e As EventArgs)
        Cedula.Text = ""
    End Sub

    Private Sub PASSWORD_Click(sender As Object, e As EventArgs) Handles PASSWORD.Click
        PASSWORD.Text = ""
    End Sub

    Private Sub BTN_CREAR_Click(sender As Object, e As EventArgs)
        Me.Hide()

    End Sub

    Friend Sub Cargar_Datos(ByRef Cedula As String)
        T.Tables.Clear() 'Limpiando el contenido de toda la tabla temporal
        SQL = "SELECT CONTRASENA, NOMBRE_COMPLETO, CORREO, FOTO, NUMERO_TELEFONO, ID FROM EMPLEADO WHERE CEDULA= '" & Cedula & "'"
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For FILA As Integer = 0 To T.Tables(0).Rows.Count - 1 'se;ala el inicio de la tabla en 0,0
                contrasena = T.Tables(0).Rows(FILA).ItemArray(0).ToString
                NombreCompleto = T.Tables(0).Rows(FILA).ItemArray(1).ToString
                Cedula = Cedula
                correo_conexion = T.Tables(0).Rows(FILA).ItemArray(2).ToString
                foto_usuario = T.Tables(0).Rows(FILA).ItemArray(3).ToString
                telefono = T.Tables(0).Rows(FILA).ItemArray(4).ToString
                ID = Convert.ToInt32(T.Tables(0).Rows(FILA).ItemArray(5).ToString)
            Next
        End If
    End Sub

    Private Sub BTN_INICIAR_SECCION_Click(sender As Object, e As EventArgs) Handles BTN_INICIAR_SECCION.Click
        Dim cedula_txt As String
        Dim cedula_parametro As String
        Dim bandera As Integer = 0 'Esta bandera es para que el mensaje de error no se repita cada vez que no encuentre un dato que coincida con el que el usuario digitó
        Dim contrasena_txt As String
        T.Tables.Clear() 'Limpiando el contenido de toda la tabla temporal
        SQL = "SELECT CEDULA, CONTRASENA FROM EMPLEADO"
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For FILA As Integer = 0 To T.Tables(0).Rows.Count - 1 'se;ala el inicio de la tabla en 0,0
                cedula_txt = T.Tables(0).Rows(FILA).ItemArray(0).ToString
                contrasena_txt = T.Tables(0).Rows(FILA).ItemArray(1).ToString
                If cedula_txt = Cedula.Text And contrasena_txt = PASSWORD.Text Then
                    bandera = 1
                    cedula_parametro = T.Tables(0).Rows(FILA).ItemArray(0).ToString
                Else

                    If bandera <> 1 Then
                        bandera = 0
                    End If

                End If
            Next

            If bandera = 1 Then 'Con este if logro que el mensaje de error se muestre unicamente cuando recorrió toda la tabla y no encontró ningun dato que coincidiera con lo que el usuario ingresó
                Cargar_Datos(cedula_parametro)
                Interfaz.Show()
                Me.Hide()
            Else
                MsgBox("El nombre de usuario o contraseña son incorrecto...Por favor intenta de nuevo")
            End If

        End If

    End Sub
End Class
