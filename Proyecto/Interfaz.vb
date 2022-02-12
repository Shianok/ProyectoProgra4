Public Class Interfaz
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnCerrarInterfaz.Click
        Me.Close()
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

    Private Sub btn_opciones_Click(sender As Object, e As EventArgs) Handles btn_opciones.Click
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
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.Panel_opciones.Controls.Add(fh)
        Me.Panel_opciones.Tag = fh
        fh.Show()

    End Sub

    Private Sub btn_Registrar_paciente_Click(sender As Object, e As EventArgs) Handles btn_Registrar_paciente.Click
        MostrarOpcion(Registrar_paciente)
    End Sub
End Class