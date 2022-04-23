
Public Class Registrar_paciente
    Private Sub BtnCerrarInterfaz_Click(sender As Object, e As EventArgs) Handles btnCerrarInterfaz.Click
        Me.Close()
    End Sub


    Friend Sub REGISTRAR_PACIENTE() 'SQL para registrar un paciente
        SQL = "INSERT INTO PACIENTE (ID, NOMBRE_COMPLETO, CEDULA, LUGAR_RESIDENCIA, FECHA_NACIMIENTO, CORREO, TELEFONO, PADECIMIENTOS) VALUES(" & PK("PACIENTE", "ID") & ", '" & NOMBRE_PACIENTE.Text & "', '" & CEDULA_PACIENTE.Text & "', '" & RESIDENCIA_PACIENTE.Text & "', '" & NACIMIENTO_PACIENTE.Text & "', '" & CORREO.Text & "', '" & NUMERO_PACIENTE.Text & "', '" & TXT_PADECIMIENTOS.Text & "')"
        EJECUTAR(SQL)
        LIMPIAR()
        MsgBox("Informacion enviada", vbInformation + vbOKOnly, "Guardando")
    End Sub

    Friend Sub LIMPIAR() 'Limpieza de todos los campos
        NOMBRE_PACIENTE.Clear()
        CEDULA_PACIENTE.Clear()
        RESIDENCIA_PACIENTE.Clear()
        NACIMIENTO_PACIENTE.ResetText()
        CORREO.Clear()
        NUMERO_PACIENTE.Clear()
        TXT_PADECIMIENTOS.Clear()
    End Sub

    Private Sub Btn_agregar_paciente_Click(sender As Object, e As EventArgs) Handles Btn_agregar_paciente.Click
        REGISTRAR_PACIENTE()
        Me.Close()
    End Sub

End Class