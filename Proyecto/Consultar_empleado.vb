Public Class Consultar_empleado
    Dim ID As Integer
    Private Sub BTN_ABRIR_REGISTRAR_EMPLEADO_Click(sender As Object, e As EventArgs) Handles BTN_ABRIR_REGISTRAR_EMPLEADO.Click
        Agregar_empleados.Show()
    End Sub

    Friend Sub CONSULTA_EMPLEADO()
        If CEDULA_EMPLEADO.Text <> "" Then
            T.Tables.Clear() 'LIMPIANDO EL CONTENIDO DE TODA LA TABLA TEMPORAL
            SQL = "SELECT ID, NOMBRE_COMPLETO, CEDULA, NUMERO_TELEFONO, LUGAR_RESIDENCIA, CORREO, ESTADO, FOTO FROM EMPLEADO WHERE CEDULA LIKE  '" & CEDULA_EMPLEADO.Text & "%'"
            CARGAR_TABLA(T, SQL)
            Dim ID As String

            If T.Tables(0).Rows.Count = 0 Then
                T.Tables.Clear() 'LIMPIANDO EL CONTENIDO DE TODA LA TABLA TEMPORAL
                SQL = "SELECT ID, NOMBRE_COMPLETO, CEDULA, NUMERO_TELEFONO, LUGAR_RESIDENCIA, CORREO, ESTADO, FOTO FROM EMPLEADO WHERE ESTADO = 1"
                CARGAR_TABLA(T, SQL)
            End If

            Try
                SQL = "SELECT ID, NOMBRE_COMPLETO, CEDULA, NUMERO_TELEFONO, LUGAR_RESIDENCIA, CORREO, ESTADO, FOTO FROM EMPLEADO WHERE CEDULA='" & CEDULA_EMPLEADO.Text & "'"
                CARGAR_TABLA(T, SQL)
                If T.Tables(0).Rows.Count > 0 Then
                    For FILA As Integer = 0 To T.Tables(0).Rows.Count - 1 'se;ala el inicio de la tabla en 0,0
                        ID = Convert.ToInt32(T.Tables(0).Rows(FILA).ItemArray(0))
                        CONSULTA_NOMBRE_EMPLEADO.Text = T.Tables(0).Rows(FILA).ItemArray(1)
                        CONSULTA_NUMERO_CARNET.Text = T.Tables(0).Rows(FILA).ItemArray(2)
                        CONSULTA_NUMERO_EMPLEADO.Text = T.Tables(0).Rows(FILA).ItemArray(3)
                        CONSULTA_RESIDENCIA_EMPLEADO.Text = T.Tables(0).Rows(FILA).ItemArray(4)
                        Correo_empleado.Text = T.Tables(0).Rows(FILA).ItemArray(5)
                        Dim resultado_estado As Integer = T.Tables(0).Rows(FILA).ItemArray(6)
                        If resultado_estado = 1 Then
                            Estado.Text = "Activo"
                        Else
                            Estado.Text = "Inactivo"
                        End If

                        Dim foto As String = T.Tables(0).Rows(FILA).ItemArray(7)

                        If foto = "." Then
                            IMG_CONSULTA_EMPLEADO.Image = My.Resources.user
                        Else
                            IMG_CONSULTA_EMPLEADO.Image = Image.FromFile(T.Tables(0).Rows(FILA).ItemArray(7))
                        End If

                    Next
                    ACTUALIZAR.Enabled = True
                    BORRAR.Enabled = True
                Else
                    ACTUALIZAR.Enabled = False
                    BORRAR.Enabled = False
                End If
            Catch ex As Exception
                MsgBox("No se ha encontrado ningún empleado con número de cédula digitado")
            End Try
        End If
    End Sub


    Private Sub BTN_BUSCAR_EMPLEADO_Click(sender As Object, e As EventArgs) Handles BTN_BUSCAR_EMPLEADO.Click
        CONSULTA_EMPLEADO()
    End Sub


    Private Sub ACTIVAR_ACTUALIZAR()
        If CONSULTA_NOMBRE_EMPLEADO.Text <> "" Then
            ACTUALIZAR.Enabled = True
        Else
            ACTUALIZAR.Enabled = False
        End If

    End Sub

    Private Sub ACTIVAR_BORRADO()
        If CONSULTA_NOMBRE_EMPLEADO.Text <> "" Then
            BORRAR.Enabled = True
        Else
            BORRAR.Enabled = False
        End If

    End Sub

    Friend Sub LIMPIAR()
        CONSULTA_NOMBRE_EMPLEADO.Text = ""
        CONSULTA_NUMERO_CARNET.Text = ""
        CONSULTA_NUMERO_EMPLEADO.Text = ""
        CONSULTA_RESIDENCIA_EMPLEADO.Text = ""
        CEDULA_EMPLEADO.Text = ""
        Correo_empleado.Text = ""
        ID = Nothing
        Estado.Text = ""
    End Sub

    Private Sub ACTUALIZAR_Click(sender As Object, e As EventArgs) Handles ACTUALIZAR.Click
        Dim estado_empleado As Integer = 1
        If Estado.Text = "Inactivo" Then
            If MsgBox(“Este usuario está inactivo ¿Desea cambiar su estado a Activo?", vbQuestion + vbYesNo, “Usuario inactivo") = vbYes Then
                estado_empleado = 1
            Else
                estado_empleado = 0
            End If
        End If
        SQL = "UPDATE EMPLEADO SET NOMBRE_COMPLETO='" & CONSULTA_NOMBRE_EMPLEADO.Text & "', CEDULA='" & CONSULTA_NUMERO_CARNET.Text & "', NUMERO_TELEFONO='" & CONSULTA_NUMERO_EMPLEADO.Text & "', LUGAR_RESIDENCIA='" & CONSULTA_RESIDENCIA_EMPLEADO.Text & "', CORREO='" & Correo_empleado.Text & "', ESTADO='" & estado_empleado & "', FOTO='" & IMG_CONSULTA_EMPLEADO.Tag & "' WHERE ID=" & ID & ""
        EJECUTAR(SQL)
        LIMPIAR()
        MsgBox("Informacion actualizada correctamente", vbInformation + vbOKOnly, "Guardando")
    End Sub

    Private Sub BORRAR_Click(sender As Object, e As EventArgs) Handles BORRAR.Click
        SQL = "UPDATE EMPLEADO SET ESTADO=" & 0 & " WHERE ID = '" & ID & "'"
        EJECUTAR(SQL)
        LIMPIAR()
        MsgBox("Información eliminada satisfactoriamente.", vbInformation + vbOKOnly, "Eliminando")
    End Sub

    Private Sub IMG_CONSULTA_EMPLEADO_Click(sender As Object, e As EventArgs) Handles IMG_CONSULTA_EMPLEADO.Click
        If Abrir.ShowDialog = DialogResult.OK Then
            IMG_CONSULTA_EMPLEADO.Image = Image.FromFile(Abrir.FileName)
            IMG_CONSULTA_EMPLEADO.Tag = Abrir.FileName 'Almacena la ruta de la imagen
        Else
            IMG_CONSULTA_EMPLEADO.Tag = "."
        End If
    End Sub
End Class