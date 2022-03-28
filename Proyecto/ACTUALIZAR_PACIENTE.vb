Public Class ACTUALIZAR_PACIENTE

    Private Sub ACTUALIZAR_PACIENTE_Load(sender As Object, e As EventArgs) Handles Me.Load
        If T4.Tables(0).Rows.Count = 0 Then
            T4.Tables.Clear() 'LIMPIANDO EL CONTENIDO DE TODA LA TABLA TEMPORAL
            SQL = "SELECT ID, NOMBRE_COMPLETO, CEDULA, LUGAR_RESIDENCIA, FECHA_NACIMIENTO, CORREO, TELEFONO, PADECIMIENTOS FROM PACIENTE"
            CARGAR_TABLA(T4, SQL)
        End If

        'VERIFICA SU TRAIGO INFORMACION DE LA BD
        If T4.Tables(0).Rows.Count > 0 Then
            For FILA As Integer = 0 To T4.Tables(0).Rows.Count - 1
                NOMBRE_PACIENTE.Text = T4.Tables(0).Rows(FILA).ItemArray(1)
                CEDULA_PACIENTE.Text = T4.Tables(0).Rows(FILA).ItemArray(2)
                RESIDENCIA_PACIENTE.Text = T4.Tables(0).Rows(FILA).ItemArray(3)
                NACIMIENTO_PACIENTE.Value = T4.Tables(0).Rows(FILA).ItemArray(4)
                CORREO.Text = T4.Tables(0).Rows(FILA).ItemArray(5)
                NUMERO_PACIENTE.Text = T4.Tables(0).Rows(FILA).ItemArray(6)
                TXT_PADECIMIENTOS.Text = T4.Tables(0).Rows(FILA).ItemArray(7)
            Next
        End If
    End Sub

    Private Sub Btn_agregar_paciente_Click(sender As Object, e As EventArgs) Handles Btn_agregar_paciente.Click
        SQL = "UPDATE PACIENTE SET NOMBRE_COMPLETO='" & NOMBRE_PACIENTE.Text & "', CEDULA='" & CEDULA_PACIENTE.Text & "', LUGAR_RESIDENCIA='" & RESIDENCIA_PACIENTE.Text & "', FECHA_NACIMIENTO='" & NACIMIENTO_PACIENTE.Value & "', CORREO='" & CORREO.Text & "', TELEFONO='" & NUMERO_PACIENTE.Text & "', PADECIMIENTOS='" & TXT_PADECIMIENTOS.Text & "' WHERE ID='" & ID & "'"
        EJECUTAR(SQL)
        MsgBox("Informacion actualizada correctamente", vbInformation + vbOKOnly, "Guardando")
        Me.Close()
    End Sub

    Private Sub BtnCerrarInterfaz_Click(sender As Object, e As EventArgs) Handles BtnCerrarInterfaz.Click
        Me.Close()
    End Sub


End Class