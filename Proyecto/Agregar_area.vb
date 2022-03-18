Public Class Agregar_area

    Dim ID As Integer
    Private Sub Agregar_area_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend Sub Actualizar()
        SQL = "UPDATE AREAS SET NOMBRE_AREA='" & NOMBRE_AREA.Text & "', NIVEL=" & Convert.ToInt32(NIVEL) & ", CANTIDAD_EMPLEADOS=" & Convert.ToInt32(CANTIDAD_EMPLEADOS) & ", HORA_ENTRADA='" & HORA_ENTRADA.Value & "', HORA_SALIDA='" & HORA_SALIDA.Value & "' WHERE ID=" & ID & ""
        EJECUTAR(SQL)
        LIMPIAR()
        MsgBox("Informacion actualizada correctamente", vbInformation + vbOKOnly, "Guardando")
    End Sub

    Friend Sub BORRAR()
        SQL = "DELETE FROM AREAS WHERE ID=" & ID & ""
        EJECUTAR(SQL)
        LIMPIAR()
        MsgBox("Informacion eliminada correctamente", vbInformation + vbOKOnly, "Guardando")
    End Sub

    Friend Sub LIMPIAR()
        NOMBRE_AREA.Clear()
        NIVEL.Clear()
        CANTIDAD_EMPLEADOS.Value = 0
        HORA_ENTRADA.ResetText()
        HORA_SALIDA.ResetText()
    End Sub

    Private Sub Btn_agregar_area_Click(sender As Object, e As EventArgs) Handles Btn_agregar_area.Click
        SQL = "INSERT INTO AREAS (ID, NOMBRE_AREA, NIVEL, CANTIDAD_EMPLEADOS, HORA_ENTRADA, HORA_SALIDA) VALUES(" & PK("AREAS", "ID") & ", '" & NOMBRE_AREA.Text & "', " & Convert.ToInt32(NIVEL) & ", " & Convert.ToInt32(CANTIDAD_EMPLEADOS) & ", '" & HORA_ENTRADA.Value & "', '" & HORA_SALIDA.Value & "')"
        EJECUTAR(SQL)
        LIMPIAR()
        MsgBox("Informacion enviada", vbInformation + vbOKOnly, "Guardando")
    End Sub

End Class