Public Class Consultar_empleado
    Private Sub BTN_ABRIR_REGISTRAR_EMPLEADO_Click(sender As Object, e As EventArgs) Handles BTN_ABRIR_REGISTRAR_EMPLEADO.Click
        Agregar_empleados.Show()
    End Sub

    Friend Sub CONSULTA_EMPLEADO()
        T.Tables.Clear()
        Try
            SQL = "SELECT NOMBRE_COMPLETO, CEDULA, NUMERO_TELEFONO, LUGAR_RESIDENCIA, TIPO_EMPLEADO, AREA FROM EMPLEADO WHERE CEDULA='" & CEDULA_PACIENTE.Text & "'"
            CARGAR_TABLA(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                For FILA As Integer = 0 To T.Tables(0).Rows.Count - 1 'se;ala el inicio de la tabla en 0,0
                    CONSULTA_NOMBRE_EMPLEADO.Text = T.Tables(0).Rows(FILA).ItemArray(0)
                    CONSULTA_NUMERO_CARNET.Text = T.Tables(0).Rows(FILA).ItemArray(1)
                    CONSULTA_NUMERO_EMPLEADO.Text = T.Tables(0).Rows(FILA).ItemArray(2)
                    CONSULTA_RESIDENCIA_EMPLEADO.Text = T.Tables(0).Rows(FILA).ItemArray(3)
                    TIPO_EMPLEADO.Text = T.Tables(0).Rows(FILA).ItemArray(4)
                    AREA_EMPLEADO.Text = T.Tables(0).Rows(FILA).ItemArray(5)
                Next
            End If
        Catch ex As Exception
            MsgBox("No se ha encontrado ningún empleado con número de cédula digitado")
        End Try

    End Sub

    Private Sub BTN_BUSCAR_PACIENTE_Click(sender As Object, e As EventArgs) Handles BTN_BUSCAR_PACIENTE.Click
        CONSULTA_EMPLEADO()
    End Sub
End Class