Public Class Agregar_atencion
    Dim DiagnosticoAux As String
    Dim DiagnosticoCont As String = ""
    Friend Sub LIMPIAR()
        LLENAR_SIN_CONDICION(COMBO_ENFERMEDADES, "ENFERMEDADES", "ENFERMEDADES")
        CONSULTA_NOMBRE_PACIENTE.Clear()
        NOMBRE_MEDICO.Clear()
        CEDULA.Clear()
        EDAD.ResetText()
        C_AREA.Items.Clear()
        DIAGNOSTICO.Clear()
        L_ENFERMEDADES_DIAGNOSTICO.Items.Clear()
        DiagnosticoCont = ""
        DiagnosticoAux = ""
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

        For I = 0 To L_ENFERMEDADES_DIAGNOSTICO.Items.Count - 1
            DiagnosticoAux = L_ENFERMEDADES_DIAGNOSTICO.Items(I).SubItems(0).Text & ","
            DiagnosticoCont = DiagnosticoCont & DiagnosticoAux
        Next

        SQL = "UPDATE ATENCION SET NOMBRE_PACIENTE='" & CONSULTA_NOMBRE_PACIENTE.Text & "', CEDULA_PACIENTE='" & CEDULA.Text & "', EDAD=" & Convert.ToInt32(EDAD.Value) & ", RESULTADO_DIAGNOSTICO='" & DiagnosticoCont & "', RECETA='" & DIAGNOSTICO.Text & "', MEDICO_REMITENTE='" & NOMBRE_MEDICO.Text & "', FECHA='" & FECHA.Value & "', HORA='" & HoraConsulta.ToString("HH:mm") & "', AREA_ATENCION='" & C_AREA.Text & "' WHERE ID=" & ID & ""
        EJECUTAR(SQL)
        'REFRESCAR_AREA()
        LIMPIAR()
        MsgBox("Informacion actualizada correctamente", vbInformation + vbOKOnly, "Guardando")
    End Sub

    Friend Sub REGISTRAR_ATENCION()
        Dim HoraConsulta As DateTime = HORA_CONSULTA.Text + ":" + MINUTOS_CONSULTA.Text
        Dim DiagnosticoAux As String
        Dim DiagnosticoCont As String = ""

        For I = 0 To L_ENFERMEDADES_DIAGNOSTICO.Items.Count - 1
            DiagnosticoAux = L_ENFERMEDADES_DIAGNOSTICO.Items(I).SubItems(0).Text & ","
            DiagnosticoCont = DiagnosticoCont & DiagnosticoAux 'Obtiene todos las enfermedades agregadas al ListView separadas por coma
        Next


        Dim Delimitador() As String = {","}
        'CANCER, SIDA, 
        Dim Prueba As String = DiagnosticoCont
        Dim VectorAux() As String
        VectorAux = Prueba.Split(Delimitador, StringSplitOptions.None)

        For Each item As String In VectorAux
            Console.WriteLine("'{0}'", item)
        Next

        SQL = "INSERT INTO ATENCION (ID, NOMBRE_PACIENTE, CEDULA_PACIENTE, EDAD, ENFERMEDADES, RESULTADO_DIAGNOSTICO, RECETA, MEDICO_REMITENTE, FECHA, HORA, AREA_ATENCION) VALUES(" & PK("ATENCION", "ID") & ", '" & CONSULTA_NOMBRE_PACIENTE.Text & "', '" & CEDULA.Text & "', " & Convert.ToInt32(EDAD.Value) & ", '" & DiagnosticoCont & "', '" & DIAGNOSTICO.Text & "', '" & RECETA_MEDICA.Text & "','" & NOMBRE_MEDICO.Text & "', '" & FECHA.Value & "', '" & HoraConsulta.ToString("HH:mm") & "', '" & C_AREA.Text & "')"
        EJECUTAR(SQL)
        'IMPRIMIR()
        LIMPIAR()
        MsgBox("Informacion enviada", vbInformation + vbOKOnly, "Guardando")
    End Sub
    Private Sub BTN_REGISTRAR_CONSULTA_Click(sender As Object, e As EventArgs) Handles BTN_REGISTRAR_CONSULTA.Click
        REGISTRAR_ATENCION()
    End Sub

    Private Sub AgregarEnfermedadAlSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarEnfermedadAlSistemaToolStripMenuItem.Click
        AgregarEnfermedad.Show()
    End Sub

    Private Sub Agregar_atencion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LIMPIAR()
    End Sub

    Private Sub AGREGAR_ENFERMEDAD_Click(sender As Object, e As EventArgs) Handles AGREGAR_ENFERMEDAD.Click
        L_ENFERMEDADES_DIAGNOSTICO.Items.Add(COMBO_ENFERMEDADES.Text)
    End Sub

    Private Sub EliminarLaEnfermedadDelDiagnosticoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarLaEnfermedadDelDiagnosticoToolStripMenuItem.Click
        If L_ENFERMEDADES_DIAGNOSTICO.SelectedItems.Count > 0 Then
            L_ENFERMEDADES_DIAGNOSTICO.Items.RemoveAt(L_ENFERMEDADES_DIAGNOSTICO.SelectedItems(0).Index)
            If L_ENFERMEDADES_DIAGNOSTICO.Items.Count > 0 Then
                EliminarLaEnfermedadDelDiagnosticoToolStripMenuItem.Enabled = True
            Else
                EliminarLaEnfermedadDelDiagnosticoToolStripMenuItem.Enabled = False
            End If
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        LLENAR_SIN_CONDICION(COMBO_ENFERMEDADES, "ENFERMEDAD", "ENFERMEDADES")
    End Sub

End Class