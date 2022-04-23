Imports System.ComponentModel
Public Class Grafico
    Public i As Integer = 0

    Dim final As Long
    Dim Diagnostico As ArrayList = New ArrayList()
    Dim CantDiag As ArrayList = New ArrayList()
    Dim TextoCombo As String

    Private Sub GraDiagnostico()

        Dim Diagnostico As ArrayList = New ArrayList()
        Dim CantDiag As ArrayList = New ArrayList()

        T2.Tables.Clear()

        SQL = "Select ENFERMEDADES, COUNT(ENFERMEDADES) AS CANT
               FROM ATENCION AS P
               GROUP BY ENFERMEDADES"
        CARGAR_TABLA(T2, SQL)

        If T2.Tables(0).Rows.Count > 0 Then

            For i = 0 To T2.Tables(0).Rows.Count - 1
                Diagnostico.Add(T2.Tables(0).Rows(i).ItemArray(0))
                CantDiag.Add(T2.Tables(0).Rows(i).ItemArray(1))
            Next
            ChartDiagnosticos.Series(0).Points.DataBindXY(Diagnostico, CantDiag)
        Else
            Diagnostico.Add("No hay datos")
            CantDiag.Add(1)
            ChartDiagnosticos.Series(0).Points.DataBindXY(Diagnostico, CantDiag)
        End If

    End Sub
    Private Sub Reiniciar_grafico_Click(sender As Object, e As EventArgs) Handles Reiniciar_grafico.Click
        GraDiagnostico()
    End Sub

    Private Sub Graficos_Load(sender As Object, e As EventArgs) Handles Me.Load
        GraDiagnostico()
        CargarTotalesActivos(PacientesActivos, "ID", "PACIENTE")
        CargarTotales(CANTI_CONSULTAS, "ID", "CONSULTA")
        CargarTotalesActivos(EMPLEADOS_ACTIVOS, "ID", "EMPLEADO")
        CargarTotales(CANTI_FACTURAS, "ID", "FACTURAS")
    End Sub

    Private Sub CargarTotalesActivos(ByRef DATOS As Label, ByVal CAMPO As String, ByVal TABLA As String)
        T.Tables.Clear()
        Dim CANTIDAD As ArrayList = New ArrayList
        SQL = "Select COUNT(" & CAMPO & ") FROM " & TABLA & " WHERE ESTADO = 1"

        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For i = 0 To T.Tables(0).Rows.Count - 1
                CANTIDAD.Add(T.Tables(0).Rows(i).ItemArray(0))
            Next
            DATOS.Text = T.Tables(0).Rows(0).ItemArray(0).ToString
        End If

    End Sub


    Private Sub CargarTotales(ByRef DATOS As Label, ByVal CAMPO As String, ByVal TABLA As String)
        T.Tables.Clear()
        Dim CANTIDAD As ArrayList = New ArrayList
        SQL = "Select COUNT(" & CAMPO & ") FROM " & TABLA & ""

        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For i = 0 To T.Tables(0).Rows.Count - 1
                CANTIDAD.Add(T.Tables(0).Rows(i).ItemArray(0))
            Next
            DATOS.Text = T.Tables(0).Rows(0).ItemArray(0).ToString
        End If

    End Sub


    Private Sub CargarGraDiagnostico(ByVal CAMPO As String, ByVal TABLA As String)

        Diagnostico.Clear()
        CantDiag.Clear()
        Dim i As Integer = 0
        T3.Tables.Clear()

        SQL = "Select " & CAMPO & ", COUNT(" & CAMPO & ") AS CANT
               FROM " & TABLA & " AS P
               GROUP BY " & CAMPO & ""
        CARGAR_TABLA(T3, SQL)

        If T3.Tables(0).Rows.Count > 0 Then
            For i = 0 To T3.Tables(0).Rows.Count - 1
                Diagnostico.Add(T3.Tables(0).Rows(i).ItemArray(0))
                CantDiag.Add(T3.Tables(0).Rows(i).ItemArray(1))
            Next
            ChartDiagnosticos.Series(0).Points.DataBindXY(Diagnostico, CantDiag)
        Else
            Diagnostico.Add("No hay datos")
            CantDiag.Add(1)
            ChartDiagnosticos.Series(0).Points.DataBindXY(Diagnostico, CantDiag)
        End If
    End Sub




    Friend Sub LLENAR(ByRef COMBO As ComboBox, ByVal CAMPO As String, ByVal TABLA As String, ByVal CAMPO_CONDICION As String, ByVal VALOR_CONDICION As Integer)
        T.Tables.Clear()
        COMBO.Items.Clear()
        SQL = "SELECT DISTINCT(" & CAMPO & ") FROM " & TABLA & " WHERE " & CAMPO_CONDICION & " = " & VALOR_CONDICION & ""
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For i = 0 To T.Tables(0).Rows.Count - 1
                COMBO.Items.Add(T.Tables(0).Rows(i).Item(0))
            Next
        End If
    End Sub

    Private Sub ComboTabla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTabla.SelectedIndexChanged
        Dim Seleccion = ComboTabla.Text
        ComboDato.Text = ""

        If Seleccion = "Paciente" Then
            ComboDato.ResetText()
            ComboDato.Items.Clear()
            ComboDato.Items.Add("Padecimientos")
            ComboDato.Items.Add("Lugar_residencia")

        Else
            If Seleccion = "Atencion" Then
                ComboDato.ResetText()
                ComboDato.Items.Clear()
                ComboDato.Items.Add("Edad")
                ComboDato.Items.Add("Enfermedades")
                ComboDato.Items.Add("Area_atencion")
                ComboDato.Items.Add("Resultado_diagnostico")

            Else
                If Seleccion = "Facturas" Then
                    ComboDato.ResetText()
                    ComboDato.Items.Clear()
                    ComboDato.Items.Add("Monto")
                    ComboDato.Items.Add("AREA_ATENCION")
                Else
                    If Seleccion = "Empleado" Then
                        ComboDato.ResetText()
                        ComboDato.Items.Clear()
                        ComboDato.Items.Add("LUGAR_RESIDENCIA")
                    End If
                End If
            End If

        End If

    End Sub

    Private Sub LIMPIAR()
        ComboTabla.ResetText()
        ChartDiagnosticos.Series.Clear()
    End Sub

    Friend Sub CrearExcel()
        Dim ExcelApp = New Microsoft.Office.Interop.Excel.Application
        Dim Libro = ExcelApp.Workbooks.Add

        Dim Fila As Integer = 2
        Dim Columna As Integer = 1
        Dim RowCount = T2.Tables(0).Rows.Count - 1
        Dim ColumnCount = T2.Tables(0).Columns.Count - 1

        Try
            For nColumna As Integer = 0 To ColumnCount

                Libro.Worksheets("Hoja1").Cells(1, Columna) = T2.Tables(0).Columns(nColumna).ToString
                Libro.Worksheets("Hoja1").Cells(1, Columna).Font.bold = True

                For nFila As Integer = 0 To RowCount
                    Libro.Worksheets("Hoja1").Cells(Fila, Columna) = T2.Tables(0).Rows(nFila).ItemArray(nColumna).ToString
                    Fila = Fila + 1
                Next
                Columna = Columna + 1
                Fila = 2
            Next

            For i = 0 To T2.Tables(0).Rows.Count - 1
                Diagnostico.Add(T2.Tables(0).Rows(i).ItemArray(0))
                CantDiag.Add(T2.Tables(0).Rows(i).ItemArray(1))
            Next


            SaveFileDialog1.DefaultExt = "*.xlsx"
            SaveFileDialog1.FileName = "datos"
            SaveFileDialog1.Filter = "Libro de excel (*.xlsx) | *.xlsx"

            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                Libro.SaveAs(SaveFileDialog1.FileName)
                MsgBox("Los registros se exportaron con exito")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Libro.Saved() = True
            ExcelApp.Quit()
            Libro = Nothing
            ExcelApp = Nothing
        End Try



    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Mostrar_grafico.Click
        If ComboDato.Text <> "" And ComboTabla.Text <> "" Then
            If TextoCombo <> ComboDato.Text Then
                CargarGraDiagnostico(ComboDato.Text, ComboTabla.Text)
            Else
                MsgBox("Grafico ya cargado", vbInformation + vbOK)
            End If
        Else
            MsgBox("Seleccione datos para el grafico", vbInformation + vbOK)
        End If
        TextoCombo = ComboDato.Text
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        CrearExcel()
        ENVIAR_CORREO("Registro de sistema hospitalario", "Su reporte fue guardado y enviado con exito", Correo.Text, "C:\REPORTES\datos.xlsx", "SistemaHospitalario@outlook.es", "Sistema2022") 'Traemos el metodo del módulo de conexion para enviar la factura del pdf por correo
    End Sub

End Class