Public Class Grafico

    Private Sub GraDiagnostico()

        Dim Diagnostico As ArrayList = New ArrayList()
        Dim CantDiag As ArrayList = New ArrayList()
        Dim i As Integer = 0
        Dim dt As New DataTable

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

End Class