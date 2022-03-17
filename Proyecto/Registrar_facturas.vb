Public Class Registrar_facturas
    Friend Sub LIMPIAR()
        Cedula.Clear()
        Telefono.Clear()
        Correo.Clear()
        NOMBRE_PACIENTE.Clear()
        Fecha_de_pago.ResetText()
        Descripion.Clear()
        Fecha_de_pago.ResetText()
        Nombre_remitente.Clear()
        Monto.Clear()
    End Sub

    Private Sub Btn_realizar_factura_Click(sender As Object, e As EventArgs) Handles Btn_realizar_factura.Click
        SQL = "INSERT INTO RECINTO (ID, NOMBRE_PACIENTE, CEDULA, MONTO, FECHA_PAGO, NOMBRE_REMITENTE, AREA_ATENCION) VALUES(" & PK("RECINTO", "ID") & ", " & NOMBRE_PACIENTE.Text & ", '" & Cedula.Text & "', '" & Monto.Text & "', '" & Fecha_de_pago.Value & "', '" & Nombre_remitente.Text & "', '" & COMBO_AREA.Text & "')"
        EJECUTAR(SQL)
        LIMPIAR()
        MsgBox("Informacion enviada", vbInformation + vbOKOnly, "Guardando")
    End Sub
End Class