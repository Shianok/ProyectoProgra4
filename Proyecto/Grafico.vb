Public Class Grafico
    Public i As Integer = 0

    Private Sub GraDiagnostico()

        Dim Diagnostico As ArrayList = New ArrayList()
        Dim CantDiag As ArrayList = New ArrayList()
        Dim dt As New DataTable

        T2.Tables.Clear()
        SQL = "Select ENFERMEDADES, COUNT(ENFERMEDADES) AS CANT
               FROM ATENCION AS P
               GROUP BY ENFERMEDADES"
        CARGAR_TABLA(T2, SQL)


        For i = 0 To T2.Tables(0).Rows.Count - 1
            Diagnostico.Add(T2.Tables(0).Rows(i).ItemArray(0))
            CantDiag.Add(T2.Tables(0).Rows(i).ItemArray(1))
        Next

        ChartDiagnosticos.Series(0).Points.DataBindXY(Diagnostico, CantDiag)

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
            For I = 0 To T.Tables(0).Rows.Count - 1
                CANTIDAD.Add(T.Tables(0).Rows(I).ItemArray(0))
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
            For I = 0 To T.Tables(0).Rows.Count - 1
                CANTIDAD.Add(T.Tables(0).Rows(I).ItemArray(0))
            Next
            DATOS.Text = T.Tables(0).Rows(0).ItemArray(0).ToString
        End If

    End Sub


    Private Sub CargarGraDiagnostico(ByVal CAMPO As String, ByVal TABLA As String)


        Dim Diagnostico As ArrayList = New ArrayList()
        Dim CantDiag As ArrayList = New ArrayList()
        Dim i As Integer = 0
        Dim dt As New DataTable
        T3.Tables.Clear()

        SQL = "Select " & CAMPO & ", COUNT(" & CAMPO & ") AS CANT
               FROM " & TABLA & " AS P
               GROUP BY " & CAMPO & ""
        CARGAR_TABLA(T3, SQL)


        For i = 0 To T3.Tables(0).Rows.Count - 1
            Diagnostico.Add(T3.Tables(0).Rows(i).ItemArray(0))
            CantDiag.Add(T3.Tables(0).Rows(i).ItemArray(1))
        Next

        ChartDiagnosticos.Series(0).Points.DataBindXY(Diagnostico, CantDiag)

    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        CargarGraDiagnostico(ComboDato.Text, ComboTabla.Text)
    End Sub

    Friend Sub LLENAR(ByRef COMBO As ComboBox, ByVal CAMPO As String, ByVal TABLA As String, ByVal CAMPO_CONDICION As String, ByVal VALOR_CONDICION As Integer)
        T.Tables.Clear()
        COMBO.Items.Clear()
        SQL = "SELECT DISTINCT(" & CAMPO & ") FROM " & TABLA & " WHERE " & CAMPO_CONDICION & " = " & VALOR_CONDICION & ""
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                COMBO.Items.Add(T.Tables(0).Rows(I).Item(0))
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
            ComboDato.Items.Add("Lugar de residencia")

        Else
            If Seleccion = "Atencion" Then
                ComboDato.ResetText()
                ComboDato.Items.Clear()
                ComboDato.Items.Add("Edad")
                ComboDato.Items.Add("Enfermedades")
                ComboDato.Items.Add("Area de atencion")

            Else
                If Seleccion = "Consulta" Then
                    ComboDato.ResetText()
                    ComboDato.Items.Clear()
                    ComboDato.Items.Add("Lugar de residencia")

                Else
                    If Seleccion = "Empleado" Then
                        ComboDato.ResetText()
                        ComboDato.Items.Clear()
                        ComboDato.Items.Add("Lugar de residencia")

                    Else
                        If Seleccion = "Facturas" Then
                            ComboDato.ResetText()
                            ComboDato.Items.Clear()
                            ComboDato.Items.Add("Monto")
                            ComboDato.Items.Add("Area de atencion")
                        End If
                    End If

                End If
            End If
        End If

    End Sub

    Private Sub LIMPIAR()
        ComboTabla.ResetText()
        ChartDiagnosticos.Series.Clear()
    End Sub

End Class