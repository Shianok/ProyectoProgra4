Module Conexion
    Public Db As New OleDb.OleDbConnection
    Public SQL As String
    Public NombreUsuario, correo, cedula, contrasena, foto_usuario As String
    Public T, T2, T3 As New DataSet
    Public VECTOR_COLUMNA_OCULTAR(100) As Integer
    Friend Sub CONECTAR()
        Dim Ruta As String
        Ruta = "File Name=" & Application.StartupPath & "\ruta.udl"
        Db.ConnectionString = Ruta
        Db.Open()
    End Sub

    Friend Sub LIMPIAR_UPDATE()
        NombreUsuario = ""
        correo = ""
        cedula = ""
        contrasena = ""
        foto_usuario = ""
    End Sub

    Friend Sub ActualizarUsuario(ByRef Nombre_Usuario As String, ByRef Correo_Usuario As String, ByRef Cedula_Usuario As String, ByRef Contrasena_Usuario As String, ByRef Foto_Usuario As String)
        SQL = "UPDATE EMPLEADO SET USUARIO='" & Nombre_Usuario & "', CORRREO=" & Correo_Usuario & ", CEDULA=" & Cedula_Usuario & ", CONTRASENA='" & Contrasena_Usuario & "', FOTO='" & Foto_Usuario & "' WHERE ID=" & Cedula_Usuario & ""
        EJECUTAR(SQL)
        LIMPIAR_UPDATE()
        MsgBox("Informacion actualizada correctamente", vbInformation + vbOKOnly, "Guardando")
    End Sub

    Friend Sub DESCONECTAR()
        Db.Close()
    End Sub

    Friend Sub CARGAR_TABLA(ByRef Tabla_Temporal As DataSet, ByVal Sql As String)
        CONECTAR()
        Dim Consulta As New OleDb.OleDbDataAdapter(Sql, Db)
        Consulta.Fill(Tabla_Temporal)
        DESCONECTAR()
    End Sub



    Friend Sub EJECUTAR(ByVal Sql As String)
        CONECTAR()
        Dim Comando As New OleDb.OleDbCommand(Sql, Db)
        Comando.ExecuteNonQuery()
        DESCONECTAR()
    End Sub



    Friend Function PK(ByVal TABLA As String, ByVal LLAVE_PRIMARIA As String) As Integer
        Dim T As New DataSet
        Dim SQL As String



        T.Tables.Clear()
        SQL = "SELECT " & LLAVE_PRIMARIA & " FROM " & TABLA
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count = 0 Then
            PK = 1
        Else
            T.Tables.Clear()
            SQL = "SELECT MAX(" & LLAVE_PRIMARIA & ") FROM " & TABLA
            CARGAR_TABLA(T, SQL)
            PK = T.Tables(0).Rows(0).Item(0) + 1
        End If
    End Function
End Module
