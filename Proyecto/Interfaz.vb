Public Class Interfaz
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnCerrarInterfaz.Click
        Me.Close()
        Form1.Show()
    End Sub
    Private Sub Limpiar()
        Registrar_paciente.Close()
        REGISTRAR_CONSULTAS.Close()
        Registrar_facturas.Close()
    End Sub

    Private Sub Ocultar_opciones_Tick(sender As Object, e As EventArgs) Handles Ocultar_opciones.Tick
        If Panel_menu.Width <= 77 Then
            Me.Ocultar_opciones.Enabled = False
        Else
            Me.Panel_menu.Width = Panel_menu.Width - 10
        End If
    End Sub

    Private Sub Mostrar_opciones_Tick(sender As Object, e As EventArgs) Handles Mostrar_opciones.Tick
        If Panel_menu.Width >= 250 Then
            Me.Mostrar_opciones.Enabled = False
        Else
            Me.Panel_menu.Width = Panel_menu.Width + 10
        End If
    End Sub

    Private Sub Btn_opciones_Click(sender As Object, e As EventArgs) Handles Btn_opciones.Click
        If Panel_menu.Width >= 250 Then
            Ocultar_opciones.Enabled = True
        ElseIf Panel_menu.Width <= 77 Then
            Mostrar_opciones.Enabled = True
        End If

    End Sub

    Private Sub MostrarOpcion(ByVal Formhijo As Object)
        If Panel_opciones.Controls.Count > 0 Then
            Me.Panel_opciones.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.BackColor = Color.FromArgb(239, 206, 250)
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.Panel_opciones.Controls.Add(fh)
        Me.Panel_opciones.Tag = fh
        fh.Show()

    End Sub

    'Abre form de registrar paciente
    Private Sub Btn_Registrar_paciente_Click(sender As Object, e As EventArgs) Handles Btn_paciente.Click
        Limpiar()
        MostrarOpcion(Consultar_paciente)
    End Sub

    'Abre form de Agregar atencion
    Private Sub Btn_agregar_atencion_Click(sender As Object, e As EventArgs) Handles Btn_agregar_atencion.Click
        Limpiar()
        MostrarOpcion(Agregar_atencion)
    End Sub

    'Abre form de registrar facturas
    Private Sub Btn_facturas_Click(sender As Object, e As EventArgs) Handles Btn_facturas.Click
        Limpiar()
        MostrarOpcion(Registrar_facturas)
    End Sub

    'Abre el form agregar area
    Private Sub Btn_areas_Click(sender As Object, e As EventArgs) Handles Btn_areas.Click
        Limpiar()
        MostrarOpcion(Agregar_area)
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Btn_consultas_Click(sender As Object, e As EventArgs) Handles Btn_consultas.Click
        Limpiar()
        MostrarOpcion(REGISTRAR_CONSULTAS)
    End Sub

    Private Sub Btn_empleado_Click(sender As Object, e As EventArgs) Handles Btn_empleado.Click
        Limpiar()
        MostrarOpcion(Consultar_empleado)
    End Sub

    Private Sub Interfaz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = NombreCompleto
        FOTO_EMPLEADO.Image = Image.FromFile(foto_usuario)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Hide()
        Empleado_perfil.Show()
    End Sub
End Class