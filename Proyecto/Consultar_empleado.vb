Public Class Consultar_empleado
    Dim ID As Integer
    Private Sub BTN_ABRIR_REGISTRAR_EMPLEADO_Click(sender As Object, e As EventArgs) Handles BTN_ABRIR_REGISTRAR_EMPLEADO.Click
        Agregar_empleados.Show()
    End Sub

    Friend Sub CONSULTA_EMPLEADO()
        T.Tables.Clear()
        Try
            SQL = "SELECT ID, NOMBRE_COMPLETO, CEDULA, NUMERO_TELEFONO, LUGAR_RESIDENCIA, TIPO_EMPLEADO, AREA FROM EMPLEADO WHERE CEDULA='" & CEDULA_EMPLEADO.Text & "'"
            CARGAR_TABLA(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                For FILA As Integer = 0 To T.Tables(0).Rows.Count - 1 'se;ala el inicio de la tabla en 0,0
                    ID = Convert.ToInt32(T.Tables(0).Rows(FILA).ItemArray(1))
                    CONSULTA_NOMBRE_EMPLEADO.Text = T.Tables(0).Rows(FILA).ItemArray(1)
                    CONSULTA_NUMERO_CARNET.Text = T.Tables(0).Rows(FILA).ItemArray(2)
                    CONSULTA_NUMERO_EMPLEADO.Text = T.Tables(0).Rows(FILA).ItemArray(3)
                    CONSULTA_RESIDENCIA_EMPLEADO.Text = T.Tables(0).Rows(FILA).ItemArray(4)
                    TIPO_EMPLEADO.Text = T.Tables(0).Rows(FILA).ItemArray(5)
                    AREA_EMPLEADO.Text = T.Tables(0).Rows(FILA).ItemArray(6)
                Next
            End If
            ACTUALIZAR.Enabled = True
            BORRAR.Enabled = True
        Catch ex As Exception
            MsgBox("No se ha encontrado ningún empleado con número de cédula digitado")
            ACTUALIZAR.Enabled = False
            BORRAR.Enabled = False
        End Try
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
        TIPO_EMPLEADO.Text = ""
        ID = Nothing
        AREA_EMPLEADO.Text = ""
    End Sub

    Private Sub ACTUALIZAR_Click(sender As Object, e As EventArgs) Handles ACTUALIZAR.Click
        SQL = "UPDATE EMPLEADO SET NOMBRE_COMPLETO='" & CONSULTA_NOMBRE_EMPLEADO.Text & "', CEDULA='" & CONSULTA_NUMERO_CARNET.Text & "', NUMERO_TELEFONO='" & CONSULTA_NUMERO_EMPLEADO.Text & "', LUGAR_RESIDENCIA='" & CONSULTA_RESIDENCIA_EMPLEADO.Text & "', TIPO_EMPLEADO='" & TIPO_EMPLEADO.Text & "', AREA='" & AREA_EMPLEADO.Text & "' WHERE ID=" & ID & ""
        EJECUTAR(SQL)
        LIMPIAR()
        MsgBox("Informacion actualizada correctamente", vbInformation + vbOKOnly, "Guardando")
    End Sub

    Private Sub BORRAR_Click(sender As Object, e As EventArgs) Handles BORRAR.Click
        If MsgBox(“¿Desea eliminar al empleado?", vbQuestion + vbYesNo, “Verifique") = vbYes Then
            SQL = "UPDATE EMPLEADO SET ESTADO=" & 0 & " WHERE ID = '" & ID & "'"
            EJECUTAR(SQL)
            LIMPIAR()
            MsgBox("Información eliminada satisfactoriamente.", vbInformation + vbOKOnly, "Eliminando")
        End If
    End Sub

End Class