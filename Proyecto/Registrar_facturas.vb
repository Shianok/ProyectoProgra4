Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word
Imports System.IO

Public Class Registrar_facturas
    Dim ID As Integer
    Dim TOTAL_NETO As Integer

    'Private Sub Registrar_facturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'Fecha_de_pago.Format = DateFormat.LongDate
    'End Sub

    Friend Sub SUMA_TOTAL()
        Dim Suma As Integer = Convert.ToInt32(MONTO.Text)
        TOTAL_NETO = TOTAL_NETO + Suma
        MONTO_TOTAL.Text = TOTAL_NETO.ToString
    End Sub
    Friend Sub IMPRIMIR()
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

        INSERTAR_REGLON(False, P13, "- Se extiende la siguiente factura del servicio hospitalario al paciente: " & NOMBRE_PACIENTE.Text & ", con el siguiente correo: " & Correo.Text, False, False, 8, "Century Gothic", "I", 0)


        CREAR_DIRECTORIO()

        GUARDAR_DOCUMENTO_PDF("factura")

        CERRAR_DOCUMENTO_WORD()

        MsgBox("Factura creada correctamente")

    End Sub
    Friend Sub LIMPIAR()
        Cedula.Clear()
        Telefono.Clear()
        Correo.Clear()
        NOMBRE_PACIENTE.Clear()
        Fecha_de_pago.ResetText()
        L.Clear()
        Fecha_de_pago.ResetText()
        Nombre_remitente.Clear()
        MONTO_TOTAL.Clear()
    End Sub

    Friend Sub AGREGAR_AL_LIST()
        'L.Items.Clear()
        L.Items.Add(AGREGAR.Text)
        L.Items(L.Items.Count - 1).SubItems.Add(MONTO.Text)
    End Sub

    Friend Sub Actualizar()
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
        LIMPIAR()
        MsgBox("Informacion enviada", vbInformation + vbOKOnly, "Guardando")
    End Sub

    Private Sub AGREGAR_LIST_Click(sender As Object, e As EventArgs) Handles AGREGAR_LIST.Click
        SUMA_TOTAL()
        AGREGAR_AL_LIST()
        AGREGAR.Clear()
        MONTO.Clear()
    End Sub

    Private Sub BORRAR_FILA_Click(sender As Object, e As EventArgs) Handles BORRAR_FILA.Click
        Dim Contador As Double

        If L.Items.Count > 0 Then
            L.Items.RemoveAt(Contador)
            Contador = (Contador - 1)
        End If

    End Sub

End Class