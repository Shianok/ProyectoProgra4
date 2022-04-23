Public Class Agregar_area

    Dim ID As Integer
    Private Sub Agregar_area_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'REFRESCAR_AREA()
        BUSQUEDA(L_AREAS, "AREAS", "ID, NOMBRE_AREA, NIVEL, CANTIDAD_EMPLEADOS, HORA_ENTRADA, HORA_SALIDA, ESTADO", "NOMBRE_AREA", BUSQUEDA_AREA.Text, False, 0)
    End Sub

    Friend Sub Actualizar()
        Dim HoraInicial As DateTime = HORA_INICIO.Text + ":" + MINUTOS_INICIO.Text
        Dim HoraFinal As DateTime = HORA_FINAL.Text + ":" + MINUTOS_FINAL.Text

        SQL = "UPDATE AREAS SET NOMBRE_AREA='" & NOMBRE_AREA.Text & "', NIVEL=" & Convert.ToInt32(NIVEL.Text) & ", CANTIDAD_EMPLEADOS=" & Convert.ToInt32(CANTIDAD_EMPLEADOS.Value) & ", HORA_ENTRADA='" & HoraInicial.ToString("HH:mm") & "', HORA_SALIDA='" & HoraFinal.ToString("HH:mm") & "' WHERE ID=" & ID & ""
        EJECUTAR(SQL)
        BUSQUEDA(L_AREAS, "AREAS", "ID, NOMBRE_AREA, NIVEL, CANTIDAD_EMPLEADOS, HORA_ENTRADA, HORA_SALIDA, ESTADO", "NOMBRE_AREA", BUSQUEDA_AREA.Text, False, 0)
        LIMPIAR()
        MsgBox("Informacion actualizada correctamente", vbInformation + vbOKOnly, "Guardando")
    End Sub

    Friend Sub BORRAR()
        SQL = "UPDATE AREAS SET ESTADO=" & 0 & " WHERE ID=" & ID & ""
        EJECUTAR(SQL)
        BUSQUEDA(L_AREAS, "AREAS", "ID, NOMBRE_AREA, NIVEL, CANTIDAD_EMPLEADOS, HORA_ENTRADA, HORA_SALIDA, ESTADO", "NOMBRE_AREA", BUSQUEDA_AREA.Text, False, 0)
        LIMPIAR()
        MsgBox("Informacion eliminada correctamente", vbInformation + vbOKOnly, "Guardando")
    End Sub

    Friend Sub LIMPIAR()
        NOMBRE_AREA.Clear()
        NIVEL.Clear()
        CANTIDAD_EMPLEADOS.Value = 0
        HORA_INICIO.Text = ""
        HORA_FINAL.Text = ""
        MINUTOS_INICIO.Text = ""
        MINUTOS_FINAL.Text = ""
    End Sub

    Private Sub Btn_agregar_area_Click(sender As Object, e As EventArgs) Handles Btn_agregar_area.Click
        Dim HoraInicial As DateTime = HORA_INICIO.Text + ":" + MINUTOS_INICIO.Text
        Dim HoraFinal As DateTime = HORA_FINAL.Text + ":" + MINUTOS_FINAL.Text

        SQL = "INSERT INTO AREAS (ID, NOMBRE_AREA, NIVEL, CANTIDAD_EMPLEADOS, HORA_ENTRADA, HORA_SALIDA, ESTADO) VALUES(" & PK("AREAS", "ID") & ", '" & NOMBRE_AREA.Text & "', " & Convert.ToInt32(NIVEL.Text) & ", " & Convert.ToInt32(CANTIDAD_EMPLEADOS.Value) & ", '" & HoraInicial.ToString("HH:mm") & "', '" & HoraFinal.ToString("HH:mm") & "', " & 1 & ")"
        EJECUTAR(SQL)
        BUSQUEDA(L_AREAS, "AREAS", "ID, NOMBRE_AREA, NIVEL, CANTIDAD_EMPLEADOS, HORA_ENTRADA, HORA_SALIDA, ESTADO", "NOMBRE_AREA", BUSQUEDA_AREA.Text, False, 0)
        LIMPIAR()
        MsgBox("Informacion enviada", vbInformation + vbOKOnly, "Guardando")
    End Sub

    Private Sub L_AREAS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L_AREAS.SelectedIndexChanged
        Dim hora_inicio_txt As String
        Dim hora_inicio_split() As String
        Dim hora_final_txt As String
        Dim hora_final_split() As String

        If L_AREAS.SelectedItems.Count > 0 Then
            ID = Convert.ToInt32(L_AREAS.SelectedItems(0).SubItems(0).Text)
            NOMBRE_AREA.Text = L_AREAS.SelectedItems(0).SubItems(1).Text
            NIVEL.Text = L_AREAS.SelectedItems(0).SubItems(2).Text
            CANTIDAD_EMPLEADOS.Value = L_AREAS.SelectedItems(0).SubItems(3).Text
            hora_inicio_txt = L_AREAS.SelectedItems(0).SubItems(4).Text
            hora_inicio_split = Split(hora_inicio_txt, ":")
            HORA_INICIO.Text = hora_inicio_split(0).ToString
            MINUTOS_INICIO.Text = hora_inicio_split(1).ToString
            hora_final_txt = L_AREAS.SelectedItems(0).SubItems(5).Text
            hora_final_split = Split(hora_final_txt, ":")
            HORA_FINAL.Text = hora_final_split(0).ToString
            MINUTOS_FINAL.Text = hora_final_split(1).ToString
            If L_AREAS.SelectedItems(0).SubItems(6).Text = 0 Then
                ACTIVAR_AREA.Visible = True
            Else
                ACTIVAR_AREA.Visible = False
            End If
        End If
    End Sub

    Private Sub BTN_ACTUALIZAR_AREA_Click(sender As Object, e As EventArgs) Handles BTN_ACTUALIZAR_AREA.Click
        Actualizar()
    End Sub

    Private Sub BTN_BORRAR_AREA_Click(sender As Object, e As EventArgs) Handles BTN_BORRAR_AREA.Click
        BORRAR()
    End Sub

    Private Sub BUSQUEDA_AREA_TextChanged(sender As Object, e As EventArgs) Handles BUSQUEDA_AREA.TextChanged
        BUSQUEDA(L_AREAS, "AREAS", "ID, NOMBRE_AREA, NIVEL, CANTIDAD_EMPLEADOS, HORA_ENTRADA, HORA_SALIDA, ESTADO", "NOMBRE_AREA", BUSQUEDA_AREA.Text, False, 0)
    End Sub

    Private Sub ACTIVAR_AREA_Click(sender As Object, e As EventArgs) Handles ACTIVAR_AREA.Click
        SQL = "UPDATE AREAS SET ESTADO=" & 1 & " WHERE ID=" & ID & ""
        EJECUTAR(SQL)
        BUSQUEDA(L_AREAS, "AREAS", "ID, NOMBRE_AREA, NIVEL, CANTIDAD_EMPLEADOS, HORA_ENTRADA, HORA_SALIDA, ESTADO", "NOMBRE_AREA", BUSQUEDA_AREA.Text, False, 0)
        LIMPIAR()
        MsgBox("Informacion activada correctamente", vbInformation + vbOKOnly, "Se ha activado el campo seleccionado")
    End Sub
End Class