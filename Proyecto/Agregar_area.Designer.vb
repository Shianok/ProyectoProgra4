<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_area
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Btn_agregar_area = New Guna.UI2.WinForms.Guna2Button()
        Me.HORA_SALIDA = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.HORA_ENTRADA = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NIVEL = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NOMBRE_AREA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CANTIDAD_EMPLEADOS = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.CANTIDAD_EMPLEADOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.CANTIDAD_EMPLEADOS)
        Me.Guna2GroupBox1.Controls.Add(Me.Btn_agregar_area)
        Me.Guna2GroupBox1.Controls.Add(Me.HORA_SALIDA)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.HORA_ENTRADA)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.NIVEL)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.NOMBRE_AREA)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(1, 1)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(756, 380)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "Agregar área"
        '
        'Btn_agregar_area
        '
        Me.Btn_agregar_area.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_agregar_area.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_agregar_area.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_agregar_area.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_agregar_area.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Btn_agregar_area.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btn_agregar_area.ForeColor = System.Drawing.Color.White
        Me.Btn_agregar_area.Location = New System.Drawing.Point(173, 248)
        Me.Btn_agregar_area.Name = "Btn_agregar_area"
        Me.Btn_agregar_area.Size = New System.Drawing.Size(200, 45)
        Me.Btn_agregar_area.TabIndex = 25
        Me.Btn_agregar_area.Text = "Agregar área"
        '
        'HORA_SALIDA
        '
        Me.HORA_SALIDA.Checked = True
        Me.HORA_SALIDA.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.HORA_SALIDA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.HORA_SALIDA.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.HORA_SALIDA.Location = New System.Drawing.Point(496, 257)
        Me.HORA_SALIDA.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.HORA_SALIDA.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.HORA_SALIDA.Name = "HORA_SALIDA"
        Me.HORA_SALIDA.Size = New System.Drawing.Size(200, 26)
        Me.HORA_SALIDA.TabIndex = 24
        Me.HORA_SALIDA.Value = New Date(2022, 3, 8, 18, 42, 13, 222)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(399, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 15)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Hora de salida:"
        '
        'HORA_ENTRADA
        '
        Me.HORA_ENTRADA.Checked = True
        Me.HORA_ENTRADA.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.HORA_ENTRADA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.HORA_ENTRADA.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.HORA_ENTRADA.Location = New System.Drawing.Point(496, 181)
        Me.HORA_ENTRADA.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.HORA_ENTRADA.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.HORA_ENTRADA.Name = "HORA_ENTRADA"
        Me.HORA_ENTRADA.Size = New System.Drawing.Size(200, 26)
        Me.HORA_ENTRADA.TabIndex = 22
        Me.HORA_ENTRADA.Value = New Date(2022, 3, 8, 18, 42, 13, 222)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(395, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Hora de entrada:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(28, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Cantidad de empleados:"
        '
        'NIVEL
        '
        Me.NIVEL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NIVEL.DefaultText = ""
        Me.NIVEL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NIVEL.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NIVEL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NIVEL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NIVEL.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.NIVEL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NIVEL.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NIVEL.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NIVEL.Location = New System.Drawing.Point(496, 94)
        Me.NIVEL.Name = "NIVEL"
        Me.NIVEL.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NIVEL.PlaceholderText = ""
        Me.NIVEL.SelectedText = ""
        Me.NIVEL.Size = New System.Drawing.Size(200, 26)
        Me.NIVEL.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(453, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nivel:"
        '
        'NOMBRE_AREA
        '
        Me.NOMBRE_AREA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NOMBRE_AREA.DefaultText = ""
        Me.NOMBRE_AREA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NOMBRE_AREA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NOMBRE_AREA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NOMBRE_AREA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NOMBRE_AREA.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.NOMBRE_AREA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NOMBRE_AREA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NOMBRE_AREA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NOMBRE_AREA.Location = New System.Drawing.Point(173, 95)
        Me.NOMBRE_AREA.Name = "NOMBRE_AREA"
        Me.NOMBRE_AREA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NOMBRE_AREA.PlaceholderText = ""
        Me.NOMBRE_AREA.SelectedText = ""
        Me.NOMBRE_AREA.Size = New System.Drawing.Size(200, 25)
        Me.NOMBRE_AREA.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(72, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nombre de área:"
        '
        'CANTIDAD_EMPLEADOS
        '
        Me.CANTIDAD_EMPLEADOS.BackColor = System.Drawing.Color.Transparent
        Me.CANTIDAD_EMPLEADOS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CANTIDAD_EMPLEADOS.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CANTIDAD_EMPLEADOS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CANTIDAD_EMPLEADOS.ForeColor = System.Drawing.Color.Black
        Me.CANTIDAD_EMPLEADOS.Location = New System.Drawing.Point(173, 181)
        Me.CANTIDAD_EMPLEADOS.Name = "CANTIDAD_EMPLEADOS"
        Me.CANTIDAD_EMPLEADOS.Size = New System.Drawing.Size(200, 25)
        Me.CANTIDAD_EMPLEADOS.TabIndex = 26
        Me.CANTIDAD_EMPLEADOS.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        '
        'Agregar_area
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 380)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Agregar_area"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar_area"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.CANTIDAD_EMPLEADOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NIVEL As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NOMBRE_AREA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents HORA_SALIDA As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents HORA_ENTRADA As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Btn_agregar_area As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CANTIDAD_EMPLEADOS As Guna.UI2.WinForms.Guna2NumericUpDown
End Class
