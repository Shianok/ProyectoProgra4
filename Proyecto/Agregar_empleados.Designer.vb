<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_empleados
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CEDULA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.USUARIO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CONTRASEÑA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NOMBRE_COMPLETO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NUMERO_CARNET = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NUMERO_TELEFONO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LUGAR_RESIDENCIA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FECHA_NACIMIENTO = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.TIPO_AREA = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TIPO_EMPLEADO = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Btn_agregar_empleado = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.Btn_agregar_empleado)
        Me.Guna2GroupBox1.Controls.Add(Me.TIPO_EMPLEADO)
        Me.Guna2GroupBox1.Controls.Add(Me.TIPO_AREA)
        Me.Guna2GroupBox1.Controls.Add(Me.FECHA_NACIMIENTO)
        Me.Guna2GroupBox1.Controls.Add(Me.LUGAR_RESIDENCIA)
        Me.Guna2GroupBox1.Controls.Add(Me.Label9)
        Me.Guna2GroupBox1.Controls.Add(Me.Label10)
        Me.Guna2GroupBox1.Controls.Add(Me.Label7)
        Me.Guna2GroupBox1.Controls.Add(Me.Label8)
        Me.Guna2GroupBox1.Controls.Add(Me.NUMERO_CARNET)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.NUMERO_TELEFONO)
        Me.Guna2GroupBox1.Controls.Add(Me.Label6)
        Me.Guna2GroupBox1.Controls.Add(Me.CONTRASEÑA)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.NOMBRE_COMPLETO)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.USUARIO)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.CEDULA)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(-1, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(803, 489)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "Agregar empleados"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(102, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cédula:"
        '
        'CEDULA
        '
        Me.CEDULA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CEDULA.DefaultText = ""
        Me.CEDULA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CEDULA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CEDULA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CEDULA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CEDULA.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CEDULA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CEDULA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CEDULA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CEDULA.Location = New System.Drawing.Point(157, 68)
        Me.CEDULA.Name = "CEDULA"
        Me.CEDULA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CEDULA.PlaceholderText = ""
        Me.CEDULA.SelectedText = ""
        Me.CEDULA.Size = New System.Drawing.Size(200, 26)
        Me.CEDULA.TabIndex = 2
        '
        'USUARIO
        '
        Me.USUARIO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.USUARIO.DefaultText = ""
        Me.USUARIO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.USUARIO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.USUARIO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.USUARIO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.USUARIO.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.USUARIO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.USUARIO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.USUARIO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.USUARIO.Location = New System.Drawing.Point(512, 75)
        Me.USUARIO.Name = "USUARIO"
        Me.USUARIO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.USUARIO.PlaceholderText = ""
        Me.USUARIO.SelectedText = ""
        Me.USUARIO.Size = New System.Drawing.Size(200, 26)
        Me.USUARIO.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(457, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Usuario:"
        '
        'CONTRASEÑA
        '
        Me.CONTRASEÑA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CONTRASEÑA.DefaultText = ""
        Me.CONTRASEÑA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CONTRASEÑA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CONTRASEÑA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CONTRASEÑA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CONTRASEÑA.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CONTRASEÑA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CONTRASEÑA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CONTRASEÑA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CONTRASEÑA.Location = New System.Drawing.Point(512, 135)
        Me.CONTRASEÑA.Name = "CONTRASEÑA"
        Me.CONTRASEÑA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CONTRASEÑA.PlaceholderText = ""
        Me.CONTRASEÑA.SelectedText = ""
        Me.CONTRASEÑA.Size = New System.Drawing.Size(200, 26)
        Me.CONTRASEÑA.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(435, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Contraseña:"
        '
        'NOMBRE_COMPLETO
        '
        Me.NOMBRE_COMPLETO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NOMBRE_COMPLETO.DefaultText = ""
        Me.NOMBRE_COMPLETO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NOMBRE_COMPLETO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NOMBRE_COMPLETO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NOMBRE_COMPLETO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NOMBRE_COMPLETO.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.NOMBRE_COMPLETO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NOMBRE_COMPLETO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NOMBRE_COMPLETO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NOMBRE_COMPLETO.Location = New System.Drawing.Point(157, 135)
        Me.NOMBRE_COMPLETO.Name = "NOMBRE_COMPLETO"
        Me.NOMBRE_COMPLETO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NOMBRE_COMPLETO.PlaceholderText = ""
        Me.NOMBRE_COMPLETO.SelectedText = ""
        Me.NOMBRE_COMPLETO.Size = New System.Drawing.Size(200, 26)
        Me.NOMBRE_COMPLETO.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(41, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nombre completo:"
        '
        'NUMERO_CARNET
        '
        Me.NUMERO_CARNET.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUMERO_CARNET.DefaultText = ""
        Me.NUMERO_CARNET.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NUMERO_CARNET.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NUMERO_CARNET.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NUMERO_CARNET.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NUMERO_CARNET.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.NUMERO_CARNET.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NUMERO_CARNET.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUMERO_CARNET.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NUMERO_CARNET.Location = New System.Drawing.Point(512, 207)
        Me.NUMERO_CARNET.Name = "NUMERO_CARNET"
        Me.NUMERO_CARNET.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NUMERO_CARNET.PlaceholderText = ""
        Me.NUMERO_CARNET.SelectedText = ""
        Me.NUMERO_CARNET.Size = New System.Drawing.Size(200, 26)
        Me.NUMERO_CARNET.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(398, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Número de carnet:"
        '
        'NUMERO_TELEFONO
        '
        Me.NUMERO_TELEFONO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUMERO_TELEFONO.DefaultText = ""
        Me.NUMERO_TELEFONO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NUMERO_TELEFONO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NUMERO_TELEFONO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NUMERO_TELEFONO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NUMERO_TELEFONO.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.NUMERO_TELEFONO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NUMERO_TELEFONO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUMERO_TELEFONO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NUMERO_TELEFONO.Location = New System.Drawing.Point(157, 207)
        Me.NUMERO_TELEFONO.Name = "NUMERO_TELEFONO"
        Me.NUMERO_TELEFONO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NUMERO_TELEFONO.PlaceholderText = ""
        Me.NUMERO_TELEFONO.SelectedText = ""
        Me.NUMERO_TELEFONO.Size = New System.Drawing.Size(200, 26)
        Me.NUMERO_TELEFONO.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(34, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Número de teléfono:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(467, 291)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Área:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(45, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Tipe de empleado:"
        '
        'LUGAR_RESIDENCIA
        '
        Me.LUGAR_RESIDENCIA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LUGAR_RESIDENCIA.DefaultText = ""
        Me.LUGAR_RESIDENCIA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.LUGAR_RESIDENCIA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.LUGAR_RESIDENCIA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LUGAR_RESIDENCIA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LUGAR_RESIDENCIA.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.LUGAR_RESIDENCIA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LUGAR_RESIDENCIA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LUGAR_RESIDENCIA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LUGAR_RESIDENCIA.Location = New System.Drawing.Point(512, 356)
        Me.LUGAR_RESIDENCIA.Name = "LUGAR_RESIDENCIA"
        Me.LUGAR_RESIDENCIA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LUGAR_RESIDENCIA.PlaceholderText = ""
        Me.LUGAR_RESIDENCIA.SelectedText = ""
        Me.LUGAR_RESIDENCIA.Size = New System.Drawing.Size(200, 26)
        Me.LUGAR_RESIDENCIA.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(389, 361)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 15)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Lugar de residencia:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(27, 361)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 15)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Fecha de nacimiento:"
        '
        'FECHA_NACIMIENTO
        '
        Me.FECHA_NACIMIENTO.Checked = True
        Me.FECHA_NACIMIENTO.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.FECHA_NACIMIENTO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FECHA_NACIMIENTO.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.FECHA_NACIMIENTO.Location = New System.Drawing.Point(157, 356)
        Me.FECHA_NACIMIENTO.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.FECHA_NACIMIENTO.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.FECHA_NACIMIENTO.Name = "FECHA_NACIMIENTO"
        Me.FECHA_NACIMIENTO.Size = New System.Drawing.Size(200, 26)
        Me.FECHA_NACIMIENTO.TabIndex = 21
        Me.FECHA_NACIMIENTO.Value = New Date(2022, 3, 8, 18, 42, 13, 222)
        '
        'TIPO_AREA
        '
        Me.TIPO_AREA.BackColor = System.Drawing.Color.Transparent
        Me.TIPO_AREA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.TIPO_AREA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TIPO_AREA.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TIPO_AREA.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TIPO_AREA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TIPO_AREA.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TIPO_AREA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TIPO_AREA.ItemHeight = 30
        Me.TIPO_AREA.Location = New System.Drawing.Point(512, 280)
        Me.TIPO_AREA.Name = "TIPO_AREA"
        Me.TIPO_AREA.Size = New System.Drawing.Size(200, 36)
        Me.TIPO_AREA.TabIndex = 22
        '
        'TIPO_EMPLEADO
        '
        Me.TIPO_EMPLEADO.BackColor = System.Drawing.Color.Transparent
        Me.TIPO_EMPLEADO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.TIPO_EMPLEADO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TIPO_EMPLEADO.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TIPO_EMPLEADO.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TIPO_EMPLEADO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TIPO_EMPLEADO.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TIPO_EMPLEADO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TIPO_EMPLEADO.ItemHeight = 30
        Me.TIPO_EMPLEADO.Location = New System.Drawing.Point(157, 280)
        Me.TIPO_EMPLEADO.Name = "TIPO_EMPLEADO"
        Me.TIPO_EMPLEADO.Size = New System.Drawing.Size(200, 36)
        Me.TIPO_EMPLEADO.TabIndex = 23
        '
        'Btn_agregar_empleado
        '
        Me.Btn_agregar_empleado.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_agregar_empleado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_agregar_empleado.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_agregar_empleado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_agregar_empleado.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Btn_agregar_empleado.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btn_agregar_empleado.ForeColor = System.Drawing.Color.White
        Me.Btn_agregar_empleado.Location = New System.Drawing.Point(288, 419)
        Me.Btn_agregar_empleado.Name = "Btn_agregar_empleado"
        Me.Btn_agregar_empleado.Size = New System.Drawing.Size(275, 45)
        Me.Btn_agregar_empleado.TabIndex = 24
        Me.Btn_agregar_empleado.Text = "Agregar empleado"
        '
        'Agregar_empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 489)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Agregar_empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar_empleados"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TIPO_EMPLEADO As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TIPO_AREA As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents FECHA_NACIMIENTO As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents LUGAR_RESIDENCIA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents NUMERO_CARNET As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NUMERO_TELEFONO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CONTRASEÑA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NOMBRE_COMPLETO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents USUARIO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CEDULA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Btn_agregar_empleado As Guna.UI2.WinForms.Guna2Button
End Class
