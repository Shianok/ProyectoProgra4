Public Class Agregar_atencion

    Friend Sub LIMPIAR()
        CONSULTA_NOMBRE_PACIENTE.Clear()
        NOMBRE_MEDICO.Clear()
        CEDULA.Clear()
        EDAD.ResetText()
        C_AREA.Items.Clear()
        RECETA_MEDICA.Clear()
        CONSULTA_TXT_DIAGNOSTICO.Clear()
        FECHA.ResetText()
        HORA_CONSULTA.ResetText()
        MINUTOS_CONSULTA.ResetText()
    End Sub

    Friend Sub BORRAR_ATENCION()
        SQL = "DELETE FROM ATENCION WHERE ID=" & ID & ""
        EJECUTAR(SQL)
        'REFRESCAR_AREA()
        LIMPIAR()
        MsgBox("Informacion eliminada correctamente", vbInformation + vbOKOnly, "Guardando")
    End Sub

    Friend Sub ACTUALIZAR_ATENCION()
        Dim HoraConsulta As DateTime = HORA_CONSULTA.Text + ":" + MINUTOS_CONSULTA.Text

        SQL = "UPDATE ATENCION SET NOMBRE_PACIENTE='" & CONSULTA_NOMBRE_PACIENTE.Text & "', CEDULA_PACIENTE='" & CEDULA.Text & "', EDAD_PACIENTE=" & Convert.ToInt32(EDAD.Value) & ", RESULTADO_DIAGNOSTICO='" & CONSULTA_TXT_DIAGNOSTICO.Text & "', RECETA='" & RECETA_MEDICA.Text & "', MEDICO_REMITENTE='" & NOMBRE_MEDICO.Text & "', FECHA='" & FECHA.Value & "', HORA='" & HoraConsulta.ToString("HH:mm") & "', AREA_ATENCION='" & C_AREA.Text & "' WHERE ID=" & ID & ""
        EJECUTAR(SQL)
        'REFRESCAR_AREA()
        LIMPIAR()
        MsgBox("Informacion actualizada correctamente", vbInformation + vbOKOnly, "Guardando")
    End Sub

    Friend Sub REGISTRAR_ATENCION()
        Dim HoraConsulta As DateTime = HORA_CONSULTA.Text + ":" + MINUTOS_CONSULTA.Text

        SQL = "INSERT INTO ATENCION (ID, NOMBRE_PACIENTE, CEDULA_PACIENTE, EDAD_PACIENTE, RESULTADO_DIAGNOSTICO, RECETA, MEDICO_REMITENTE, FECHA, HORA, AREA_ATENCION) VALUES(" & PK("ATENCION", "ID") & ", '" & CONSULTA_NOMBRE_PACIENTE.Text & "', '" & CEDULA.Text & "', " & Convert.ToInt32(EDAD.Value) & ", '" & CONSULTA_TXT_DIAGNOSTICO.Text & "', '" & RECETA_MEDICA.Text & "', '" & NOMBRE_MEDICO.Text & "', '" & FECHA.Value & "', '" & HoraConsulta.ToString("HH:mm") & "', '" & C_AREA.Text & "')"
        EJECUTAR(SQL)
        'IMPRIMIR()
        LIMPIAR()
        MsgBox("Informacion enviada", vbInformation + vbOKOnly, "Guardando")
    End Sub
    Private Sub BTN_REGISTRAR_CONSULTA_Click(sender As Object, e As EventArgs) Handles BTN_REGISTRAR_CONSULTA.Click
        REGISTRAR_ATENCION()
    End Sub
End Class