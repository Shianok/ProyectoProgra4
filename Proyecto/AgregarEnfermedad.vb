Public Class AgregarEnfermedad

    Private Sub AgregarEnfermedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REFRESCAR(L_ENFERMEDADES, "ENFERMEDADES", "ID, ENFERMEDAD")
        BUSQUEDA(L_ENFERMEDADES, "ENFERMEDADES", "ID, ENFERMEDAD", "ENFERMEDAD", BUSCAR_ENFERMEDAD.Text, False, 0)
    End Sub

    Friend Sub LIMPIAR()
        TXT_ENFERMEDAD.Text = ""
        TXT_ENFERMEDAD.Tag = ""
    End Sub

    Friend Sub Guardar()
        Dim textoList As String
        Dim Bandera As Integer = 1
        If L_ENFERMEDADES.Items.Count > 0 Then
            For I = 0 To L_ENFERMEDADES.Items.Count - 1
                textoList = L_ENFERMEDADES.Items(I).SubItems(1).Text
                If TXT_ENFERMEDAD.Text.ToLower = textoList.ToLower Then
                    Bandera = 0
                ElseIf Bandera <> 0 Then
                    Bandera = 1
                End If
            Next
        End If

        If Bandera = 1 Then
            SQL = "INSERT INTO ENFERMEDADES (ID, ENFERMEDAD) VALUES(" & PK("ENFERMEDADES", "ID") & ", '" & TXT_ENFERMEDAD.Text & "')"
            EJECUTAR(SQL)
            LIMPIAR()
            MsgBox("Enfermedad registrada en el sistema", vbInformation + vbOKOnly, "Guardando")
        ElseIf Bandera = 0 Then
            MsgBox("Esta enfermedad ya está registrada", vbInformation + vbOKOnly, "Verifique la información")
        End If

    End Sub

    Private Sub BTN_AGREGAR_ENFERMEDAD_Click(sender As Object, e As EventArgs) Handles BTN_AGREGAR_ENFERMEDAD.Click
        Guardar()
        REFRESCAR(L_ENFERMEDADES, "ENFERMEDADES", "ID, ENFERMEDAD")
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Private Sub Editar_Registro_Click(sender As Object, e As EventArgs) Handles Editar_Registro.Click
        Editar.Enabled = True
        Eliminar.Enabled = True
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        SQL = "DELETE ENFERMEDADES WHERE ID = " & Convert.ToInt32(TXT_ENFERMEDAD.Tag) & ""
        EJECUTAR(SQL)
        LIMPIAR()
        REFRESCAR(L_ENFERMEDADES, "ENFERMEDADES", "ID, ENFERMEDAD")
        MsgBox("Los datos que han eliminado correctamente", vbInformation + vbOKOnly, "Eliminando")
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        SQL = "UPDATE ENFERMEDADES SET ENFERMEDAD = '" & TXT_ENFERMEDAD.Text & "' WHERE ID = " & Convert.ToInt32(TXT_ENFERMEDAD.Tag) & ""
        EJECUTAR(SQL)
        LIMPIAR()
        REFRESCAR(L_ENFERMEDADES, "ENFERMEDADES", "ID, ENFERMEDAD")
        MsgBox("Los datos que han actualizado correctamente", vbInformation + vbOKOnly, "Actualizando")
    End Sub

    Private Sub L_ENFERMEDADES_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L_ENFERMEDADES.SelectedIndexChanged
        If L_ENFERMEDADES.SelectedItems.Count > 0 Then
            TXT_ENFERMEDAD.Tag = L_ENFERMEDADES.SelectedItems(0).SubItems(0).Text
            TXT_ENFERMEDAD.Text = L_ENFERMEDADES.SelectedItems(0).SubItems(1).Text
        End If
    End Sub

    Private Sub BUSCAR_ENFERMEDAD_TextChanged(sender As Object, e As EventArgs) Handles BUSCAR_ENFERMEDAD.TextChanged
        BUSQUEDA(L_ENFERMEDADES, "ENFERMEDADES", "ID, ENFERMEDAD", "ENFERMEDAD", BUSCAR_ENFERMEDAD.Text, False, 0)
    End Sub
End Class