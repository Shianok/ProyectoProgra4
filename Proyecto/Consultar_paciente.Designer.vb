<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Consultar_paciente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.BTN_BUSCAR_PACIENTE = New Guna.UI2.WinForms.Guna2Button()
        Me.CEDULA_PACIENTE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CONSULTA_INFO = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.CONSULTA_RESIDENCIA_PACIENTE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CONSULTA_NUMERO_CARNET = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CORREO_PACIENTE = New System.Windows.Forms.Label()
        Me.CONSULTA_TXT_PADECIMIENTOS = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NACIMIENTO_PACIENTE = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CONSULTA_NUMERO_PACIENTE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CONSULTA_NOMBRE_PACIENTE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CUNSULTA_PACIENTE = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.BTN_ABRIR_REGISTRAR_PACIENTE = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.CONSULTA_INFO.SuspendLayout()
        Me.CUNSULTA_PACIENTE.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2GroupBox2)
        Me.Guna2GroupBox1.Controls.Add(Me.CUNSULTA_PACIENTE)
        Me.Guna2GroupBox1.Controls.Add(Me.CONSULTA_INFO)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(994, 686)
        Me.Guna2GroupBox1.TabIndex = 2
        Me.Guna2GroupBox1.Text = "Consultar paciente"
        '
        'BTN_BUSCAR_PACIENTE
        '
        Me.BTN_BUSCAR_PACIENTE.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_BUSCAR_PACIENTE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_BUSCAR_PACIENTE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_BUSCAR_PACIENTE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_BUSCAR_PACIENTE.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BTN_BUSCAR_PACIENTE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_BUSCAR_PACIENTE.ForeColor = System.Drawing.Color.White
        Me.BTN_BUSCAR_PACIENTE.Location = New System.Drawing.Point(319, 53)
        Me.BTN_BUSCAR_PACIENTE.Name = "BTN_BUSCAR_PACIENTE"
        Me.BTN_BUSCAR_PACIENTE.Size = New System.Drawing.Size(163, 33)
        Me.BTN_BUSCAR_PACIENTE.TabIndex = 24
        Me.BTN_BUSCAR_PACIENTE.Text = "Buscar paciente"
        '
        'CEDULA_PACIENTE
        '
        Me.CEDULA_PACIENTE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CEDULA_PACIENTE.DefaultText = ""
        Me.CEDULA_PACIENTE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CEDULA_PACIENTE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CEDULA_PACIENTE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CEDULA_PACIENTE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CEDULA_PACIENTE.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CEDULA_PACIENTE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CEDULA_PACIENTE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CEDULA_PACIENTE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CEDULA_PACIENTE.Location = New System.Drawing.Point(72, 53)
        Me.CEDULA_PACIENTE.Name = "CEDULA_PACIENTE"
        Me.CEDULA_PACIENTE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CEDULA_PACIENTE.PlaceholderText = ""
        Me.CEDULA_PACIENTE.SelectedText = ""
        Me.CEDULA_PACIENTE.Size = New System.Drawing.Size(211, 33)
        Me.CEDULA_PACIENTE.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cédula:"
        '
        'CONSULTA_INFO
        '
        Me.CONSULTA_INFO.BackColor = System.Drawing.Color.Transparent
        Me.CONSULTA_INFO.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CONSULTA_INFO.BorderRadius = 5
        Me.CONSULTA_INFO.BorderThickness = 2
        Me.CONSULTA_INFO.Controls.Add(Me.CONSULTA_RESIDENCIA_PACIENTE)
        Me.CONSULTA_INFO.Controls.Add(Me.Label9)
        Me.CONSULTA_INFO.Controls.Add(Me.CONSULTA_NUMERO_CARNET)
        Me.CONSULTA_INFO.Controls.Add(Me.CORREO_PACIENTE)
        Me.CONSULTA_INFO.Controls.Add(Me.CONSULTA_TXT_PADECIMIENTOS)
        Me.CONSULTA_INFO.Controls.Add(Me.Label2)
        Me.CONSULTA_INFO.Controls.Add(Me.NACIMIENTO_PACIENTE)
        Me.CONSULTA_INFO.Controls.Add(Me.Label10)
        Me.CONSULTA_INFO.Controls.Add(Me.CONSULTA_NUMERO_PACIENTE)
        Me.CONSULTA_INFO.Controls.Add(Me.Label6)
        Me.CONSULTA_INFO.Controls.Add(Me.CONSULTA_NOMBRE_PACIENTE)
        Me.CONSULTA_INFO.Controls.Add(Me.Label4)
        Me.CONSULTA_INFO.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CONSULTA_INFO.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.CONSULTA_INFO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CONSULTA_INFO.ForeColor = System.Drawing.Color.White
        Me.CONSULTA_INFO.Location = New System.Drawing.Point(27, 172)
        Me.CONSULTA_INFO.Name = "CONSULTA_INFO"
        Me.CONSULTA_INFO.Size = New System.Drawing.Size(934, 500)
        Me.CONSULTA_INFO.TabIndex = 25
        Me.CONSULTA_INFO.Text = "Informacion de consulta"
        '
        'CONSULTA_RESIDENCIA_PACIENTE
        '
        Me.CONSULTA_RESIDENCIA_PACIENTE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CONSULTA_RESIDENCIA_PACIENTE.DefaultText = ""
        Me.CONSULTA_RESIDENCIA_PACIENTE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CONSULTA_RESIDENCIA_PACIENTE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CONSULTA_RESIDENCIA_PACIENTE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CONSULTA_RESIDENCIA_PACIENTE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CONSULTA_RESIDENCIA_PACIENTE.Enabled = False
        Me.CONSULTA_RESIDENCIA_PACIENTE.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CONSULTA_RESIDENCIA_PACIENTE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CONSULTA_RESIDENCIA_PACIENTE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CONSULTA_RESIDENCIA_PACIENTE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CONSULTA_RESIDENCIA_PACIENTE.Location = New System.Drawing.Point(669, 282)
        Me.CONSULTA_RESIDENCIA_PACIENTE.Name = "CONSULTA_RESIDENCIA_PACIENTE"
        Me.CONSULTA_RESIDENCIA_PACIENTE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CONSULTA_RESIDENCIA_PACIENTE.PlaceholderText = ""
        Me.CONSULTA_RESIDENCIA_PACIENTE.SelectedText = ""
        Me.CONSULTA_RESIDENCIA_PACIENTE.Size = New System.Drawing.Size(211, 33)
        Me.CONSULTA_RESIDENCIA_PACIENTE.TabIndex = 62
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(515, 294)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(148, 21)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Lugar de residencia:"
        '
        'CONSULTA_NUMERO_CARNET
        '
        Me.CONSULTA_NUMERO_CARNET.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CONSULTA_NUMERO_CARNET.DefaultText = ""
        Me.CONSULTA_NUMERO_CARNET.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CONSULTA_NUMERO_CARNET.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CONSULTA_NUMERO_CARNET.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CONSULTA_NUMERO_CARNET.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CONSULTA_NUMERO_CARNET.Enabled = False
        Me.CONSULTA_NUMERO_CARNET.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CONSULTA_NUMERO_CARNET.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CONSULTA_NUMERO_CARNET.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CONSULTA_NUMERO_CARNET.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CONSULTA_NUMERO_CARNET.Location = New System.Drawing.Point(669, 172)
        Me.CONSULTA_NUMERO_CARNET.Name = "CONSULTA_NUMERO_CARNET"
        Me.CONSULTA_NUMERO_CARNET.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CONSULTA_NUMERO_CARNET.PlaceholderText = ""
        Me.CONSULTA_NUMERO_CARNET.SelectedText = ""
        Me.CONSULTA_NUMERO_CARNET.Size = New System.Drawing.Size(211, 33)
        Me.CONSULTA_NUMERO_CARNET.TabIndex = 60
        '
        'CORREO_PACIENTE
        '
        Me.CORREO_PACIENTE.AutoSize = True
        Me.CORREO_PACIENTE.BackColor = System.Drawing.Color.Transparent
        Me.CORREO_PACIENTE.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CORREO_PACIENTE.ForeColor = System.Drawing.Color.Black
        Me.CORREO_PACIENTE.Location = New System.Drawing.Point(602, 184)
        Me.CORREO_PACIENTE.Name = "CORREO_PACIENTE"
        Me.CORREO_PACIENTE.Size = New System.Drawing.Size(61, 21)
        Me.CORREO_PACIENTE.TabIndex = 59
        Me.CORREO_PACIENTE.Text = "Correo:"
        '
        'CONSULTA_TXT_PADECIMIENTOS
        '
        Me.CONSULTA_TXT_PADECIMIENTOS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CONSULTA_TXT_PADECIMIENTOS.DefaultText = ""
        Me.CONSULTA_TXT_PADECIMIENTOS.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CONSULTA_TXT_PADECIMIENTOS.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CONSULTA_TXT_PADECIMIENTOS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CONSULTA_TXT_PADECIMIENTOS.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CONSULTA_TXT_PADECIMIENTOS.Enabled = False
        Me.CONSULTA_TXT_PADECIMIENTOS.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CONSULTA_TXT_PADECIMIENTOS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CONSULTA_TXT_PADECIMIENTOS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CONSULTA_TXT_PADECIMIENTOS.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CONSULTA_TXT_PADECIMIENTOS.Location = New System.Drawing.Point(208, 386)
        Me.CONSULTA_TXT_PADECIMIENTOS.Name = "CONSULTA_TXT_PADECIMIENTOS"
        Me.CONSULTA_TXT_PADECIMIENTOS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CONSULTA_TXT_PADECIMIENTOS.PlaceholderText = ""
        Me.CONSULTA_TXT_PADECIMIENTOS.SelectedText = ""
        Me.CONSULTA_TXT_PADECIMIENTOS.Size = New System.Drawing.Size(623, 59)
        Me.CONSULTA_TXT_PADECIMIENTOS.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(89, 400)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 21)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Padesimientos:"
        '
        'NACIMIENTO_PACIENTE
        '
        Me.NACIMIENTO_PACIENTE.Checked = True
        Me.NACIMIENTO_PACIENTE.Enabled = False
        Me.NACIMIENTO_PACIENTE.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.NACIMIENTO_PACIENTE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NACIMIENTO_PACIENTE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.NACIMIENTO_PACIENTE.Location = New System.Drawing.Point(208, 282)
        Me.NACIMIENTO_PACIENTE.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.NACIMIENTO_PACIENTE.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.NACIMIENTO_PACIENTE.Name = "NACIMIENTO_PACIENTE"
        Me.NACIMIENTO_PACIENTE.Size = New System.Drawing.Size(211, 33)
        Me.NACIMIENTO_PACIENTE.TabIndex = 56
        Me.NACIMIENTO_PACIENTE.Value = New Date(2022, 3, 8, 18, 42, 13, 222)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(47, 294)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(155, 21)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Fecha de nacimiento:"
        '
        'CONSULTA_NUMERO_PACIENTE
        '
        Me.CONSULTA_NUMERO_PACIENTE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CONSULTA_NUMERO_PACIENTE.DefaultText = ""
        Me.CONSULTA_NUMERO_PACIENTE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CONSULTA_NUMERO_PACIENTE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CONSULTA_NUMERO_PACIENTE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CONSULTA_NUMERO_PACIENTE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CONSULTA_NUMERO_PACIENTE.Enabled = False
        Me.CONSULTA_NUMERO_PACIENTE.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CONSULTA_NUMERO_PACIENTE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CONSULTA_NUMERO_PACIENTE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CONSULTA_NUMERO_PACIENTE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CONSULTA_NUMERO_PACIENTE.Location = New System.Drawing.Point(208, 172)
        Me.CONSULTA_NUMERO_PACIENTE.Name = "CONSULTA_NUMERO_PACIENTE"
        Me.CONSULTA_NUMERO_PACIENTE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CONSULTA_NUMERO_PACIENTE.PlaceholderText = ""
        Me.CONSULTA_NUMERO_PACIENTE.SelectedText = ""
        Me.CONSULTA_NUMERO_PACIENTE.Size = New System.Drawing.Size(211, 33)
        Me.CONSULTA_NUMERO_PACIENTE.TabIndex = 54
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(49, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 21)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Número de teléfono:"
        '
        'CONSULTA_NOMBRE_PACIENTE
        '
        Me.CONSULTA_NOMBRE_PACIENTE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CONSULTA_NOMBRE_PACIENTE.DefaultText = ""
        Me.CONSULTA_NOMBRE_PACIENTE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CONSULTA_NOMBRE_PACIENTE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CONSULTA_NOMBRE_PACIENTE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CONSULTA_NOMBRE_PACIENTE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CONSULTA_NOMBRE_PACIENTE.Enabled = False
        Me.CONSULTA_NOMBRE_PACIENTE.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CONSULTA_NOMBRE_PACIENTE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CONSULTA_NOMBRE_PACIENTE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CONSULTA_NOMBRE_PACIENTE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CONSULTA_NOMBRE_PACIENTE.Location = New System.Drawing.Point(208, 61)
        Me.CONSULTA_NOMBRE_PACIENTE.Name = "CONSULTA_NOMBRE_PACIENTE"
        Me.CONSULTA_NOMBRE_PACIENTE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CONSULTA_NOMBRE_PACIENTE.PlaceholderText = ""
        Me.CONSULTA_NOMBRE_PACIENTE.SelectedText = ""
        Me.CONSULTA_NOMBRE_PACIENTE.Size = New System.Drawing.Size(211, 33)
        Me.CONSULTA_NOMBRE_PACIENTE.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(62, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 21)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Nombre completo:"
        '
        'CUNSULTA_PACIENTE
        '
        Me.CUNSULTA_PACIENTE.BackColor = System.Drawing.Color.Transparent
        Me.CUNSULTA_PACIENTE.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CUNSULTA_PACIENTE.BorderRadius = 5
        Me.CUNSULTA_PACIENTE.BorderThickness = 2
        Me.CUNSULTA_PACIENTE.Controls.Add(Me.BTN_BUSCAR_PACIENTE)
        Me.CUNSULTA_PACIENTE.Controls.Add(Me.Label1)
        Me.CUNSULTA_PACIENTE.Controls.Add(Me.CEDULA_PACIENTE)
        Me.CUNSULTA_PACIENTE.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CUNSULTA_PACIENTE.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.CUNSULTA_PACIENTE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CUNSULTA_PACIENTE.ForeColor = System.Drawing.Color.White
        Me.CUNSULTA_PACIENTE.Location = New System.Drawing.Point(471, 54)
        Me.CUNSULTA_PACIENTE.Name = "CUNSULTA_PACIENTE"
        Me.CUNSULTA_PACIENTE.Size = New System.Drawing.Size(490, 99)
        Me.CUNSULTA_PACIENTE.TabIndex = 26
        Me.CUNSULTA_PACIENTE.Text = "Guna2GroupBox2"
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox2.BorderRadius = 5
        Me.Guna2GroupBox2.BorderThickness = 2
        Me.Guna2GroupBox2.Controls.Add(Me.Label3)
        Me.Guna2GroupBox2.Controls.Add(Me.BTN_ABRIR_REGISTRAR_PACIENTE)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(27, 54)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(438, 99)
        Me.Guna2GroupBox2.TabIndex = 27
        Me.Guna2GroupBox2.Text = "Registrar nuevo"
        '
        'BTN_ABRIR_REGISTRAR_PACIENTE
        '
        Me.BTN_ABRIR_REGISTRAR_PACIENTE.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ABRIR_REGISTRAR_PACIENTE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ABRIR_REGISTRAR_PACIENTE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_ABRIR_REGISTRAR_PACIENTE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_ABRIR_REGISTRAR_PACIENTE.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BTN_ABRIR_REGISTRAR_PACIENTE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_ABRIR_REGISTRAR_PACIENTE.ForeColor = System.Drawing.Color.White
        Me.BTN_ABRIR_REGISTRAR_PACIENTE.Location = New System.Drawing.Point(199, 53)
        Me.BTN_ABRIR_REGISTRAR_PACIENTE.Name = "BTN_ABRIR_REGISTRAR_PACIENTE"
        Me.BTN_ABRIR_REGISTRAR_PACIENTE.Size = New System.Drawing.Size(163, 33)
        Me.BTN_ABRIR_REGISTRAR_PACIENTE.TabIndex = 24
        Me.BTN_ABRIR_REGISTRAR_PACIENTE.Text = "Registrar paciente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(58, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 21)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Registrar paciente:"
        '
        'Consultar_paciente
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(992, 684)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Consultar_paciente"
        Me.Text = "Consultar_paciente"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.CONSULTA_INFO.ResumeLayout(False)
        Me.CONSULTA_INFO.PerformLayout()
        Me.CUNSULTA_PACIENTE.ResumeLayout(False)
        Me.CUNSULTA_PACIENTE.PerformLayout()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents BTN_BUSCAR_PACIENTE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CEDULA_PACIENTE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BTN_ABRIR_REGISTRAR_PACIENTE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CUNSULTA_PACIENTE As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents CONSULTA_INFO As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents CONSULTA_RESIDENCIA_PACIENTE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CONSULTA_NUMERO_CARNET As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CORREO_PACIENTE As Label
    Friend WithEvents CONSULTA_TXT_PADECIMIENTOS As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NACIMIENTO_PACIENTE As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents CONSULTA_NUMERO_PACIENTE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CONSULTA_NOMBRE_PACIENTE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
End Class
