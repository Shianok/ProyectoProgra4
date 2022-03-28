Public Class Consultar_paciente
    Private Sub BTN_ABRIR_REGISTRAR_PACIENTE_Click(sender As Object, e As EventArgs) Handles BTN_ABRIR_REGISTRAR_PACIENTE.Click
        Registrar_paciente.Show()
    End Sub

    Friend Sub BORRAR_PACIENTE()
        SQL = "DELETE FROM PACIENTE WHERE ID='" & BUSCAR_CEDULA_PACIENTE.Text & "'"
        EJECUTAR(SQL)
        LIMPIAR()
        MsgBox("Informacion eliminada correctamente", vbInformation + vbOKOnly, "Guardando")
    End Sub



    Friend Sub LIMPIAR()
        CONSULTA_NOMBRE_PACIENTE.Text = ""
        CONSULTA_RESIDENCIA_PACIENTE.Text = ""
        NACIMIENTO_PACIENTE.ResetText()
        CONSULTA_CORREO.Text = ""
        CONSULTA_NUMERO_PACIENTE.Text = ""
        CONSULTA_TXT_PADECIMIENTOS.Text = ""
        BUSCAR_CEDULA_PACIENTE.Text = ""
    End Sub

    Private Sub BTN_BUSCAR_PACIENTE_Click(sender As Object, e As EventArgs) Handles BTN_BUSCAR_PACIENTE.Click
        If BUSCAR_CEDULA_PACIENTE.Text <> "" Then
            T4.Tables.Clear() 'LIMPIANDO EL CONTENIDO DE TODA LA TABLA TEMPORAL
            SQL = "SELECT ID, NOMBRE_COMPLETO, CEDULA, LUGAR_RESIDENCIA, FECHA_NACIMIENTO, CORREO, TELEFONO, PADECIMIENTOS FROM PACIENTE WHERE CEDULA LIKE  '" & BUSCAR_CEDULA_PACIENTE.Text & "%'"
            CARGAR_TABLA(T4, SQL)
            Dim ID As String

            If T4.Tables(0).Rows.Count = 0 Then
                T4.Tables.Clear() 'LIMPIANDO EL CONTENIDO DE TODA LA TABLA TEMPORAL
                SQL = "SELECT ID, NOMBRE_COMPLETO, CEDULA, LUGAR_RESIDENCIA, FECHA_NACIMIENTO, CORREO, TELEFONO, PADECIMIENTOS FROM PACIENTE"
                CARGAR_TABLA(T4, SQL)
            End If

            'VERIFICA SU TRAIGO INFORMACION DE LA BD
            Try
                If T4.Tables(0).Rows.Count > 0 Then
                    For FILA As Integer = 0 To T4.Tables(0).Rows.Count - 1
                        CONSULTA_NOMBRE_PACIENTE.Text = T4.Tables(0).Rows(FILA).ItemArray(1)
                        ID = T4.Tables(0).Rows(FILA).ItemArray(2)
                        CONSULTA_RESIDENCIA_PACIENTE.Text = T4.Tables(0).Rows(FILA).ItemArray(3)
                        NACIMIENTO_PACIENTE.Value = T4.Tables(0).Rows(FILA).ItemArray(4)
                        CONSULTA_CORREO.Text = T4.Tables(0).Rows(FILA).ItemArray(5)
                        CONSULTA_NUMERO_PACIENTE.Text = T4.Tables(0).Rows(FILA).ItemArray(6)
                        CONSULTA_TXT_PADECIMIENTOS.Text = T4.Tables(0).Rows(FILA).ItemArray(7)
                    Next
                    ACTUALIZAR.Enabled = True
                    BORRAR.Enabled = True
                Else
                    ACTUALIZAR.Enabled = False
                    BORRAR.Enabled = False
                End If
            Catch ex As Exception
                MsgBox("No se ha encontrado ningún paciente con número de cédula digitado")
            End Try
        End If

    End Sub

    Private Sub ACTIVAR_ACTUALIZAR()
        If CONSULTA_NOMBRE_PACIENTE.Text <> "" Then
            ACTUALIZAR.Enabled = True
        Else
            ACTUALIZAR.Enabled = False
        End If

    End Sub

    Private Sub ACTIVAR_BORRADO()
        If CONSULTA_NOMBRE_PACIENTE.Text <> "" Then
            BORRAR.Enabled = True
        Else
            BORRAR.Enabled = False
        End If

    End Sub

    Private Sub ACTUALIZAR_Click(sender As Object, e As EventArgs) Handles ACTUALIZAR.Click
        ACTUALIZAR_PACIENTE.Show()
        LIMPIAR()
    End Sub

    Private Sub CONSULTA_NOMBRE_PACIENTE_TextChanged(sender As Object, e As EventArgs) Handles CONSULTA_NOMBRE_PACIENTE.TextChanged
        ACTIVAR_ACTUALIZAR()
        ACTIVAR_BORRADO()
    End Sub

    Private Sub BORRAR_Click(sender As Object, e As EventArgs) Handles BORRAR.Click
        If MsgBox(“¿Desea eliminar al paciente?", vbQuestion + vbYesNo, “Verifique") = vbYes Then
            SQL = "DELETE FROM PACIENTE WHERE ID = '" & ID & "'"
            EJECUTAR(SQL)
            LIMPIAR()
            MsgBox("Información eliminada satisfactoriamente.", vbInformation + vbOKOnly, "Eliminando")
        End If
    End Sub


End Class