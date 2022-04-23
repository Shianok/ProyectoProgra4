Public Class REGISTRAR_CONSULTAS
    Friend Sub LIMPIAR()
        FECHA_CONSULTA.ResetText()
        HORA_CONSULTA.ResetText()
        AREA_CONSULTA.Clear()
        NUMERO_CONSULTA.Clear()
        NUMERO_CONSULTORIO.Clear()
        CEDULA_CONSULTA.Clear()
        CORREO_CONSULTA.Clear()
    End Sub

    Friend Sub AGREGAR_CONSULTA()
        Dim HoraConsulta As DateTime = HORA_CONSULTA.Text + ":" + MINUTOS_CONSULTA.Text
        Dim fecha As Date = FECHA_CONSULTA.Value
        SQL = "INSERT INTO CONSULTA (ID, FECHA, HORA, AREA, TELEFONO_PACIENTE, NUMERO_CONSULTORIO, CEDULA_PACIENTE, CORREO, ESTADO) VALUES(" & PK("CONSULTA", "ID") & ", '" & fecha & "', '" & HoraConsulta.ToString("HH:mm") & "', " & AREA_CONSULTA.Text & ", '" & NUMERO_CONSULTA.Text & "', '" & NUMERO_CONSULTORIO.Text & "', '" & CEDULA_CONSULTA.Text & "', '" & CORREO_CONSULTA.Text & "', '1')"
        EJECUTAR(SQL)
        LIMPIAR()
        MsgBox("Informacion enviada", vbInformation + vbOKOnly, "Guardando")
    End Sub

    Private Sub Btn_agregar_consulta_Click(sender As Object, e As EventArgs) Handles Btn_agregar_consulta.Click
        AGREGAR_CONSULTA()
    End Sub
End Class