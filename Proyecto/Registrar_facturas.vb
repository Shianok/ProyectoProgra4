Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word
Imports System.IO

Public Class Registrar_facturas
    Dim ID As Integer
    Dim TOTAL_NETO As Integer
    Private Sub Registrar_facturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LLENAR(COMBO_AREA, "NOMBRE_AREA", "AREAS", "ESTADO", 1)
        'cargarComboArea()
    End Sub

    Friend Sub SUMA_TOTAL(ByVal Restar As Integer) 'Este metodo suma los montos de los medicamente agregados al listview
        'TOTAL_NETO = 0
        Dim Suma As Integer
        If L.Items.Count > 0 Then

            If Restar = 0 Then
                For I = 0 To L.Items.Count - 1
                    Suma = Convert.ToInt32(L.Items(I).SubItems(1).Text)
                Next
            Else
                TOTAL_NETO = TOTAL_NETO - Restar
            End If

        Else
            MONTO_TOTAL.Text = 0
        End If

        TOTAL_NETO = TOTAL_NETO + Suma
        MONTO_TOTAL.Text = TOTAL_NETO.ToString
    End Sub
    Friend Sub IMPRIMIR() 'Creamos el pdf para la factura
        Dim P0, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10, P11, P12, P13 As Word.Paragraph

        Dim T1, T2 As Word.Paragraph
        Dim ARREGLO(100, 100) As String
        Dim I As Integer

        OWORD.Visible = False
        DOCUMENTO = OWORD.Documents.Add

        'Insertando la primera línea de texto
        INSERTAR_REGLON(True, P0, "SISTEMA HOSPITALARIO", True, False, 20, "Times New Roman", "C", 0)

        INSERTAR_LINEA_BLANCO(P0, 1)
        'Insertando la segunda línea de texto
        INSERTAR_REGLON(False, P1, "ID Factura: 1", False, False, 10, "Century Gothic", "I", 0)
        INSERTAR_REGLON(False, P2, "Fecha: " & Fecha_de_pago.Value, False, False, 10, "Century Gothic", "I", 0)
        INSERTAR_REGLON(False, P3, "Hora: " & DateTime.Now.ToString("HH:mm:ss"), False, False, 10, "Century Gothic", "I", 0)
        INSERTAR_REGLON(False, P4, "Cédula: " & Cedula.Text, False, False, 10, "Century Gothic", "I", 0)
        INSERTAR_REGLON(False, P5, "Teléfono: " & Telefono.Text, False, False, 10, "Century Gothic", "I", 0)
        INSERTAR_LINEA_BLANCO(P5, 1)
        INSERTAR_REGLON(False, P6, "--------------------------------------------------------------------------------------------------------------", False, False, 12, "Century Gothic", "I", 0)
        INSERTAR_REGLON(False, P7, "DESGLOSE DE FACTURA", True, False, 18, "Century Gothic", "C", 0)
        INSERTAR_REGLON(False, P8, "--------------------------------------------------------------------------------------------------------------", False, False, 12, "Century Gothic", "I", 0)

        INSERTAR_LINEA_BLANCO(P8, 1)

        ARREGLO(0, 0) = "MEDICAMENTE O SERVICIO"
        ARREGLO(0, 1) = "MONTO"

        For I = 0 To L.Items.Count - 1
            ARREGLO(I + 1, 0) = L.Items(I).SubItems(0).Text
            ARREGLO(I + 1, 1) = L.Items(I).SubItems(1).Text
        Next

        INSERTAR_TABLA(ARREGLO, I + 1, 2, 0, 12, "Century Gothic", 5, 3, "J", False, False, 0,
False, 0, False, T1, 0, False, False)

        INSERTAR_REGLON(False, P9, "Monto total: " & MONTO_TOTAL.Text, False, False, 10, "Century Gothic", "I", 0)
        INSERTAR_REGLON(False, P10, "Nombre de remitente: " & Nombre_remitente.Text, False, False, 10, "Century Gothic", "I", 0)

        INSERTAR_REGLON(False, P11, "--------------------------------------------------------------------------------------------------------------", False, False, 12, "Century Gothic", "I", 0)

        INSERTAR_LINEA_BLANCO(P11, 1)

        INSERTAR_REGLON(False, P12, "Área de atención: " & COMBO_AREA.Text, False, False, 10, "Century Gothic", "I", 0)

        INSERTAR_LINEA_BLANCO(P12, 1)

        INSERTAR_REGLON(False, P13, "- Se extiende la siguiente factura del servicio hospitalario al paciente: " & NOMBRE_PACIENTE.Text & ", con el siguiente correo: " & Correo_usuario.Text, False, False, 8, "Century Gothic", "I", 0)


        CREAR_DIRECTORIO()

        GUARDAR_DOCUMENTO_PDF("factura")

        CERRAR_DOCUMENTO_WORD()

        MsgBox("Factura creada correctamente")

    End Sub
    Friend Sub LIMPIAR()
        Cedula.Clear()
        Telefono.Clear()
        Correo_usuario.Clear()
        NOMBRE_PACIENTE.Clear()
        Fecha_de_pago.ResetText()
        L.Clear()
        Fecha_de_pago.ResetText()
        Nombre_remitente.Clear()
        MONTO_TOTAL.Clear()
    End Sub

    Friend Sub AGREGAR_AL_LIST() 'Este metodo es para agregar los el medicamento y su monto al listview
        L.Items.Add(AGREGAR.Text)
        L.Items(L.Items.Count - 1).SubItems.Add(MONTO.Text)
    End Sub

    Friend Sub Actualizar() 'Actualiza 
        SQL = "UPDATE FACTURAS SET NOMBRE_PACIENTE='" & NOMBRE_PACIENTE.Text & "', CEDULA='" & Cedula.Text & "', MONTO='" & MONTO_TOTAL.Text & "', FECHA_PAGO='" & Fecha_de_pago.Value & "', NOMBRE_REMITENTE ='" & NOMBRE_PACIENTE.Text & "', AREA_ATENCION='" & COMBO_AREA.Text & "' WHERE ID=" & ID & ""
        EJECUTAR(SQL)
        LIMPIAR()
        MsgBox("Informacion actualizada correctamente", vbInformation + vbOKOnly, "Guardando")
    End Sub

    Friend Sub Borrar()
        SQL = "DELETE FROM FACTURAS WHERE ID=" & ID & ""
        EJECUTAR(SQL)
        LIMPIAR()
        MsgBox("Informacion eliminada correctamente", vbInformation + vbOKOnly, "Guardando")
    End Sub

    Private Sub Btn_realizar_factura_Click(sender As Object, e As EventArgs) Handles Btn_realizar_factura.Click
        SQL = "INSERT INTO FACTURAS (ID, NOMBRE_PACIENTE, CEDULA, MONTO, FECHA_PAGO, NOMBRE_REMITENTE, AREA_ATENCION) VALUES(" & PK("FACTURAS", "ID") & ", '" & NOMBRE_PACIENTE.Text & "', '" & Cedula.Text & "', '" & MONTO_TOTAL.Text & "', '" & Fecha_de_pago.Value & "', '" & Nombre_remitente.Text & "', '" & COMBO_AREA.Text & "')"
        EJECUTAR(SQL)
        IMPRIMIR()
        ENVIAR_CORREO("FACTURA DEL SISTEMA HOSPITALARIO", "POR ESTE MEDIO LE ADJUNTAMOS SU FACTURA DEL SISTEMA HOSPITALARIO, DESDE ESTE ARCHIVO PDF: ", Correo_usuario.Text, "C:\REPORTES\factura.pdf", "SistemaHospitalario@outlook.es", "Sistema2022") 'Traemos el metodo del módulo de conexion para enviar la factura del pdf por correo
        LIMPIAR()
        MsgBox("Informacion enviada", vbInformation + vbOKOnly, "Guardando")
    End Sub

    Private Sub AGREGAR_LIST_Click(sender As Object, e As EventArgs) Handles AGREGAR_LIST.Click 'Aqui llamamos al metodo para agregar los datos al listview y sumar los montos
        AGREGAR_AL_LIST()
        SUMA_TOTAL(0)
        AGREGAR.Clear()
        MONTO.Clear()
    End Sub

    Private Sub BORRAR_FILA_Click(sender As Object, e As EventArgs) Handles BORRAR_FILA.Click
        Dim Contador As Double

        If L.Items.Count > 0 Then 'Aqui se remueve la última fila de los datos agregados al listview
            L.Items.RemoveAt(Contador)

            Contador = (Contador - 1)
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
                COMBO_AREA.Items.Add(T4.Tables(0).Rows(FILA).ItemArray(0))
            Next
        End If
    End Sub

    Private Sub EliminarLaEnfermedadDelDiagnosticoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarLaEnfermedadDelDiagnosticoToolStripMenuItem.Click
        Dim Restar As Integer
        If L.SelectedItems.Count > 0 Then
            Restar = Convert.ToInt32(L.SelectedItems(0).SubItems(1).Text)
            Dim Valor As Integer = Convert.ToInt32(MONTO_TOTAL.Text)
            Valor = Valor - Restar
            MONTO_TOTAL.Text = Valor
            L.Items.RemoveAt(L.SelectedItems(0).Index)
            SUMA_TOTAL(Restar)
            If L.Items.Count > 0 Then
                EliminarLaEnfermedadDelDiagnosticoToolStripMenuItem.Enabled = True
            Else
                EliminarLaEnfermedadDelDiagnosticoToolStripMenuItem.Enabled = False
            End If
        End If
    End Sub
End Class