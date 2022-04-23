Public Class Agregar_tipo_empleado
    Private Sub AgregarEnfermedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REFRESCAR(L_TIPO_EMPLEADO, "TIPOS_EMPLEADOS", "ID, TIPO_EMPLEADO")
        BUSQUEDA(L_TIPO_EMPLEADO, "TIPOS_EMPLEADOS", "ID, TIPO_EMPLEADO", "TIPO_EMPLEADO", BUSCAR_TIPO_EMPLEADO.Text, False, 0)
    End Sub

    Friend Sub LIMPIAR()
        TXT_TIPO_EMPLEADO.Text = ""
        TXT_TIPO_EMPLEADO.Tag = ""
    End Sub

    Friend Sub Guardar()
        Dim textoList As String
        Dim Bandera As Integer = 1
        If L_TIPO_EMPLEADO.Items.Count > 0 Then
            For I = 0 To L_TIPO_EMPLEADO.Items.Count - 1
                textoList = L_TIPO_EMPLEADO.Items(I).SubItems(1).Text
                If TXT_TIPO_EMPLEADO.Text.ToLower = textoList.ToLower Then
                    Bandera = 0
                ElseIf Bandera <> 0 Then
                    Bandera = 1
                End If
            Next
        End If

        If Bandera = 1 Then
            SQL = "INSERT INTO TIPOS_EMPLEADOS (ID, TIPO_EMPLEADO) VALUES(" & PK("TIPOS_EMPLEADOS", "ID") & ", '" & TXT_TIPO_EMPLEADO.Text & "')"
            EJECUTAR(SQL)
            LIMPIAR()
            MsgBox("Enfermedad registrada en el sistema", vbInformation + vbOKOnly, "Guardando")
        ElseIf Bandera = 0 Then
            MsgBox("Esta enfermedad ya está registrada", vbInformation + vbOKOnly, "Verifique la información")
        End If

    End Sub

    Private Sub BTN_AGREGAR_ENFERMEDAD_Click(sender As Object, e As EventArgs) Handles BTN_AGREGAR_TIPO_EMPLEADO.Click
        Guardar()
        REFRESCAR(L_TIPO_EMPLEADO, "TIPOS_EMPLEADOS", "ID, TIPO_EMPLEADO")
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Private Sub Editar_Registro_Click(sender As Object, e As EventArgs) Handles Editar_Registro.Click
        Editar.Enabled = True
        Eliminar.Enabled = True
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        SQL = "DELETE TIPOS_EMPLEADOS WHERE ID = " & Convert.ToInt32(TXT_TIPO_EMPLEADO.Tag) & ""
        EJECUTAR(SQL)
        LIMPIAR()
        REFRESCAR(L_TIPO_EMPLEADO, "TIPOS_EMPLEADOS", "ID, TIPO_EMPLEADO")
        MsgBox("Los datos que han eliminado correctamente", vbInformation + vbOKOnly, "Eliminando")
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        SQL = "UPDATE TIPOS_EMPLEADOS SET TIPO_EMPLEADO = '" & TXT_TIPO_EMPLEADO.Text & "' WHERE ID = " & Convert.ToInt32(TXT_TIPO_EMPLEADO.Tag) & ""
        EJECUTAR(SQL)
        LIMPIAR()
        REFRESCAR(L_TIPO_EMPLEADO, "TIPOS_EMPLEADOS", "ID, TIPO_EMPLEADO")
        MsgBox("Los datos que han actualizado correctamente", vbInformation + vbOKOnly, "Actualizando")
    End Sub

    Private Sub L_ENFERMEDADES_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L_TIPO_EMPLEADO.SelectedIndexChanged
        If L_TIPO_EMPLEADO.SelectedItems.Count > 0 Then
            TXT_TIPO_EMPLEADO.Tag = L_TIPO_EMPLEADO.SelectedItems(0).SubItems(0).Text
            TXT_TIPO_EMPLEADO.Text = L_TIPO_EMPLEADO.SelectedItems(0).SubItems(1).Text
        End If
    End Sub

    Private Sub BUSCAR_ENFERMEDAD_TextChanged(sender As Object, e As EventArgs) Handles BUSCAR_TIPO_EMPLEADO.TextChanged
        BUSQUEDA(L_TIPO_EMPLEADO, "TIPOS_EMPLEADOS", "ID, TIPO_EMPLEADO", "TIPO_EMPLEADO", BUSCAR_TIPO_EMPLEADO.Text, False, 0)
    End Sub
End Class