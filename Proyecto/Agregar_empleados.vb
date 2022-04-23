Public Class Agregar_empleados

    Dim ID As Integer

    Private Sub Agregar_empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LLENAR(TIPO_AREA, "NOMBRE_AREA", "AREAS", "ESTADO", 1)
        LLENAR_SIN_CONDICION(TIPO_EMPLEADO, "TIPO_EMPLEADO", "TIPOS_EMPLEADOS")
    End Sub

    Friend Sub Validar()
        If CEDULA.Text <> "  -    -" And RESIDENCIA.Text <> "" And NOMBRE_COMPLETO.Text <> "" And CONTRASENA.Text <> "" And NUMERO_TELEFONO.Text <> "" And COREO.Text <> "" And
        NUMERO_CARNET.Text <> "" Then
            Btn_agregar_empleado.Enabled = True
        End If
    End Sub

    Private Sub BtnCerrarInterfaz_Click(sender As Object, e As EventArgs) Handles BTN_CerrarInterfaz.Click
        Me.Close()
    End Sub

    Friend Sub Actualizar()
        SQL = "UPDATE EMPLEADO SET CEDULA='" & CEDULA.Text & "', NOMBRE_COMPLETO='" & NOMBRE_COMPLETO.Text & "', CONTRASENA='" & CONTRASENA.Text & "', CORREO='" & COREO.Text & "', NUMERO_TELEFONO='" & NUMERO_TELEFONO.Text & "', NUMERO_CARNET='" & NUMERO_CARNET.Text & "', TIPO_EMPLEADO='" & TIPO_EMPLEADO.Text & "', AREA='" & TIPO_AREA.Text & "', FECHA_NACIMIENTO='" & FECHA_NACIMIENTO.Value & "', LUGAR_RESIDENCIA='" & RESIDENCIA.Text & "', FOTO='" & IMG_EMPLEADO.Tag & "' WHERE ID=" & ID & ""
        EJECUTAR(SQL)
        LIMPIAR()
        MsgBox("Informacion actualizada correctamente", vbInformation + vbOKOnly, "Guardando")
    End Sub

    Friend Sub Borrar()
        SQL = "DELETE FROM EMPLEADO WHERE ID=" & ID & ""
        EJECUTAR(SQL)
        LIMPIAR()
        MsgBox("Informacion eliminada correctamente", vbInformation + vbOKOnly, "Guardando")
    End Sub

    Friend Sub LIMPIAR()
        CEDULA.Clear()
        NOMBRE_COMPLETO.Clear()
        CONTRASENA.Clear()
        COREO.Clear()
        NUMERO_TELEFONO.Clear()
        NUMERO_CARNET.Clear()
        TIPO_EMPLEADO.ResetText()
        TIPO_AREA.ResetText()
        FECHA_NACIMIENTO.ResetText()
        RESIDENCIA.Clear()
        IMG_EMPLEADO.Tag = ""
        IMG_EMPLEADO.Image = My.Resources.user
    End Sub

    Private Sub Btn_agregar_empleado_Click(sender As Object, e As EventArgs) Handles Btn_agregar_empleado.Click
        SQL = "INSERT INTO EMPLEADO (ID, CEDULA, NOMBRE_COMPLETO, CONTRASENA, CORREO, NUMERO_TELEFONO, NUMERO_CARNET, TIPO_EMPLEADO, AREA, FECHA_NACIMIENTO, LUGAR_RESIDENCIA, FOTO) VALUES(" & PK("EMPLEADO", "ID") & ", '" & CEDULA.Text & "', '" & NOMBRE_COMPLETO.Text & "', '" & CONTRASENA.Text & "', '" & COREO.Text & "', '" & NUMERO_TELEFONO.Text & "', '" & NUMERO_CARNET.Text & "', '" & TIPO_EMPLEADO.Text & "', '" & TIPO_AREA.Text & "', '" & FECHA_NACIMIENTO.Value & "', '" & RESIDENCIA.Text & "', '" & IMG_EMPLEADO.Tag & "')"
        EJECUTAR(SQL)
        LIMPIAR()
        MsgBox("Informacion enviada", vbInformation + vbOKOnly, "Guardando")
    End Sub

    Private Sub IMG_EMPLEADO_Click(sender As Object, e As EventArgs) Handles IMG_EMPLEADO.Click
        If Abrir.ShowDialog = DialogResult.OK Then
            IMG_EMPLEADO.Image = Image.FromFile(Abrir.FileName)
            IMG_EMPLEADO.Tag = Abrir.FileName 'Almacena la ruta de la imagen
        Else
            IMG_EMPLEADO.Tag = "."
        End If
    End Sub

    Friend Sub cargarComboArea()
        T4.Clear()
        SQL = "SELECT ID FROM AREAS"
        CARGAR_TABLA(T4, SQL)

        If T4.Tables(0).Rows.Count > 0 Then
            For FILA As Integer = 0 To T4.Tables(0).Rows.Count - 1 'se;ala el inicio de la tabla en 0,0
                Dim Prueba As String
                Prueba = T4.Tables(0).Rows(FILA).ItemArray(0)
                TIPO_AREA.Items.Add(T4.Tables(0).Rows(FILA).ItemArray(0))
            Next
        End If
    End Sub

    Private Sub CEDULA_TextChanged(sender As Object, e As EventArgs) Handles CEDULA.TextChanged
        Validar()
    End Sub

    Private Sub RESIDENCIA_TextChanged(sender As Object, e As EventArgs) Handles RESIDENCIA.TextChanged
        Validar()
    End Sub

    Private Sub NOMBRE_COMPLETO_TextChanged(sender As Object, e As EventArgs) Handles NOMBRE_COMPLETO.TextChanged
        Validar()
    End Sub

    Private Sub CONTRASENA_TextChanged(sender As Object, e As EventArgs) Handles CONTRASENA.TextChanged
        Validar()
    End Sub

    Private Sub NUMERO_TELEFONO_TextChanged(sender As Object, e As EventArgs) Handles NUMERO_TELEFONO.TextChanged
        Validar()
    End Sub

    Private Sub COREO_TextChanged(sender As Object, e As EventArgs) Handles COREO.TextChanged
        Validar()
    End Sub

    Private Sub NUMERO_CARNET_TextChanged(sender As Object, e As EventArgs) Handles NUMERO_CARNET.TextChanged
        Validar()
    End Sub

    Private Sub Btn_agregar_tipo_empleado_Click(sender As Object, e As EventArgs) Handles Btn_agregar_tipo_empleado.Click
        Agregar_tipo_empleado.Show()
    End Sub
End Class