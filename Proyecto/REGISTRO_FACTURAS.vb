Public Class REGISTRO_FACTURAS




    'recarga los datos
    Friend Sub Recarga()
        L.Items.Clear() 'LIMPIANDO LA LISTA (LISTVIEW)
        T.Tables.Clear() 'LIMPIANDO EL CONTENIDO DE TODA LA TABLA TEMPORAL
        SQL = "SELECT ID, NOMBRE_PACIENTE, CEDULA, MONTO, FECHA_PAGO, NOMBRE_REMITENTE, AREA_ATENCION FROM FACTURAS"
        CARGAR_TABLA(T, SQL)

        'verificacion de datos de DB
        If T.Tables(0).Rows.Count > 0 Then
            For FILA As Integer = 0 To T.Tables(0).Rows.Count - 1
                L.Items.Add(T.Tables(0).Rows(FILA).ItemArray(0)) ' ID
                L.Items(L.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(FILA).ItemArray(1)) ' 
                L.Items(L.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(FILA).ItemArray(2)) ' 
                L.Items(L.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(FILA).ItemArray(3)) ' 
                L.Items(L.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(FILA).ItemArray(4)) ' 
                L.Items(L.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(FILA).ItemArray(5)) ' 
                L.Items(L.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(FILA).ItemArray(6)) ' 
            Next
            VECTOR_COLUMNA_OCULTAR(0) = 0
            AJUSTAR_COLUMNA(L, VECTOR_COLUMNA_OCULTAR, 1)
        End If
    End Sub

    Friend Sub AJUSTAR_COLUMNA(ByRef LISTA As ListView, ByVal VECTOR_COLUMNA_OCULTAR() As Integer, ByVal CANTIDAD_COLUMNAS_OCULTAR As Integer)
        LISTA.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        LISTA.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        For I As Integer = 0 To CANTIDAD_COLUMNAS_OCULTAR - 1
            LISTA.Columns(VECTOR_COLUMNA_OCULTAR(I)).Width = 0
        Next
    End Sub

    'Busqueda de factura no alterables
    Private Sub Buscar_TextChanged(sender As Object, e As EventArgs) Handles Buscar.TextChanged
        If Buscar.Text <> "" Then
            L.Items.Clear() 'LIMPIANDO LA LISTA (LISTVIEW)
            T.Tables.Clear() 'LIMPIANDO EL CONTENIDO DE TODA LA TABLA TEMPORAL
            SQL = "SELECT ID, NOMBRE_PACIENTE, CEDULA, MONTO, FECHA_PAGO, NOMBRE_REMITENTE, AREA_ATENCION FROM FACTURAS WHERE ID LIKE  '" & Buscar.Text & "%'"
            CARGAR_TABLA(T, SQL)

            If T.Tables(0).Rows.Count = 0 Then
                L.Items.Clear() 'LIMPIANDO LA LISTA (LISTVIEW)
                T.Tables.Clear() 'LIMPIANDO EL CONTENIDO DE TODA LA TABLA TEMPORAL
                SQL = "SELECT ID, NOMBRE_PACIENTE, CEDULA, MONTO, FECHA_PAGO, NOMBRE_REMITENTE, AREA_ATENCION FROM FACTURAS"
                CARGAR_TABLA(T, SQL)
            End If

            'verificacion de datos de DB
            If T.Tables(0).Rows.Count > 0 Then
                For FILA As Integer = 0 To T.Tables(0).Rows.Count - 1
                    L.Items.Add(T.Tables(0).Rows(FILA).ItemArray(0)) ' ID
                    L.Items(L.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(FILA).ItemArray(1)) ' 
                    L.Items(L.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(FILA).ItemArray(2)) ' 
                    L.Items(L.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(FILA).ItemArray(3)) ' 
                    L.Items(L.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(FILA).ItemArray(4)) ' 
                    L.Items(L.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(FILA).ItemArray(5)) ' 
                    L.Items(L.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(FILA).ItemArray(6)) ' 
                Next
            End If
            VECTOR_COLUMNA_OCULTAR(0) = 0
            VECTOR_COLUMNA_OCULTAR(1) = 3
            AJUSTAR_COLUMNA(L, VECTOR_COLUMNA_OCULTAR, 2)
        End If
    End Sub

    Private Sub BtnCerrarInterfaz_Click(sender As Object, e As EventArgs) Handles BtnCerrarInterfaz.Click
        Me.Close()
    End Sub

    Private Sub REGISTRO_FACTURAS_Load(sender As Object, e As EventArgs) Handles Me.Load
        Recarga()
    End Sub
End Class