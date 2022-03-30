Module Conexion
    Public Db As New OleDb.OleDbConnection
    Public SQL As String
    Public NombreCompleto, correo_conexion, cedula, contrasena, foto_usuario, telefono As String
    Public ID As Integer
    Public T, T2, T3, T4 As New DataSet
    Public VECTOR_COLUMNA_OCULTAR(100) As Integer
    Friend Sub CONECTAR()
        Dim Ruta As String
        Ruta = "File Name=" & Application.StartupPath & "\ruta.udl"
        Db.ConnectionString = Ruta
        Db.Open()
    End Sub

    Friend Sub LIMPIAR_UPDATE()
        NombreCompleto = ""
        correo_conexion = ""
        cedula = ""
        contrasena = ""
        foto_usuario = ""
        telefono = ""
    End Sub

    Friend Sub ActualizarUsuario(ByRef Nombre_Completo As String, ByRef Correo_Usuario As String, ByRef Contrasena_Usuario As String, ByRef Foto_Usuario As String, ByRef Telefono_Usuario As String)
        SQL = "UPDATE EMPLEADO SET NOMBRE_COMPLETO='" & Nombre_Completo & "', CORREO='" & Correo_Usuario & "', CONTRASENA='" & Contrasena_Usuario & "', FOTO='" & Foto_Usuario & "', NUMERO_TELEFONO='" & Telefono_Usuario & "' WHERE ID=" & ID & ""
        EJECUTAR(SQL)
        MsgBox("Informacion actualizada correctamente", vbInformation + vbOKOnly, "Guardando")
        LIMPIAR_UPDATE()
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
