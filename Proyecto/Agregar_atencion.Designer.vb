<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_atencion
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
        Me.BTN_VER_CONSULTAS = New Guna.UI2.WinForms.Guna2Button()
        Me.AREA_GROUP = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.BTN_REGISTRAR_CONSULTA = New Guna.UI2.WinForms.Guna2Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FECHA = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RECETA_MEDICA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NOMBRE_MEDICO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CORREO_PACIENTE = New System.Windows.Forms.Label()
        Me.CONSULTA_TXT_DIAGNOSTICO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CEDULA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CONSULTA_NOMBRE_PACIENTE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.C_AREA = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.EDAD = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MINUTOS_CONSULTA = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.HORA_CONSULTA = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.AREA_GROUP.SuspendLayout()
        CType(Me.EDAD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_VER_CONSULTAS)
        Me.Guna2GroupBox1.Controls.Add(Me.AREA_GROUP)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(-1, -1)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(996, 689)
        Me.Guna2GroupBox1.TabIndex = 3
        Me.Guna2GroupBox1.Text = "Consultas de pacientes"
        '
        'BTN_VER_CONSULTAS
        '
        Me.BTN_VER_CONSULTAS.BackColor = System.Drawing.Color.Transparent
        Me.BTN_VER_CONSULTAS.BorderRadius = 5
        Me.BTN_VER_CONSULTAS.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_VER_CONSULTAS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_VER_CONSULTAS.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_VER_CONSULTAS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_VER_CONSULTAS.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BTN_VER_CONSULTAS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_VER_CONSULTAS.ForeColor = System.Drawing.Color.White
        Me.BTN_VER_CONSULTAS.Location = New System.Drawing.Point(805, 46)
        Me.BTN_VER_CONSULTAS.Name = "BTN_VER_CONSULTAS"
        Me.BTN_VER_CONSULTAS.Size = New System.Drawing.Size(172, 42)
        Me.BTN_VER_CONSULTAS.TabIndex = 26
        Me.BTN_VER_CONSULTAS.Text = "Ver historial de consultas"
        '
        'AREA_GROUP
        '
        Me.AREA_GROUP.BackColor = System.Drawing.Color.Transparent
        Me.AREA_GROUP.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.AREA_GROUP.BorderRadius = 5
        Me.AREA_GROUP.BorderThickness = 2
        Me.AREA_GROUP.Controls.Add(Me.Label5)
        Me.AREA_GROUP.Controls.Add(Me.MINUTOS_CONSULTA)
        Me.AREA_GROUP.Controls.Add(Me.Label8)
        Me.AREA_GROUP.Controls.Add(Me.HORA_CONSULTA)
        Me.AREA_GROUP.Controls.Add(Me.Label10)
        Me.AREA_GROUP.Controls.Add(Me.EDAD)
        Me.AREA_GROUP.Controls.Add(Me.C_AREA)
        Me.AREA_GROUP.Controls.Add(Me.BTN_REGISTRAR_CONSULTA)
        Me.AREA_GROUP.Controls.Add(Me.Label7)
        Me.AREA_GROUP.Controls.Add(Me.FECHA)
        Me.AREA_GROUP.Controls.Add(Me.Label3)
        Me.AREA_GROUP.Controls.Add(Me.RECETA_MEDICA)
        Me.AREA_GROUP.Controls.Add(Me.Label1)
        Me.AREA_GROUP.Controls.Add(Me.Label9)
        Me.AREA_GROUP.Controls.Add(Me.NOMBRE_MEDICO)
        Me.AREA_GROUP.Controls.Add(Me.CORREO_PACIENTE)
        Me.AREA_GROUP.Controls.Add(Me.CONSULTA_TXT_DIAGNOSTICO)
        Me.AREA_GROUP.Controls.Add(Me.Label2)
        Me.AREA_GROUP.Controls.Add(Me.CEDULA)
        Me.AREA_GROUP.Controls.Add(Me.Label6)
        Me.AREA_GROUP.Controls.Add(Me.CONSULTA_NOMBRE_PACIENTE)
        Me.AREA_GROUP.Controls.Add(Me.Label4)
        Me.AREA_GROUP.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.AREA_GROUP.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.AREA_GROUP.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AREA_GROUP.ForeColor = System.Drawing.Color.White
        Me.AREA_GROUP.Location = New System.Drawing.Point(18, 93)
        Me.AREA_GROUP.Name = "AREA_GROUP"
        Me.AREA_GROUP.Size = New System.Drawing.Size(959, 579)
        Me.AREA_GROUP.TabIndex = 25
        Me.AREA_GROUP.Text = "Informacion de la consulta"
        '
        'BTN_REGISTRAR_CONSULTA
        '
        Me.BTN_REGISTRAR_CONSULTA.BackColor = System.Drawing.Color.Transparent
        Me.BTN_REGISTRAR_CONSULTA.BorderRadius = 5
        Me.BTN_REGISTRAR_CONSULTA.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_REGISTRAR_CONSULTA.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_REGISTRAR_CONSULTA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_REGISTRAR_CONSULTA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_REGISTRAR_CONSULTA.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BTN_REGISTRAR_CONSULTA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_REGISTRAR_CONSULTA.ForeColor = System.Drawing.Color.White
        Me.BTN_REGISTRAR_CONSULTA.Location = New System.Drawing.Point(367, 507)
        Me.BTN_REGISTRAR_CONSULTA.Name = "BTN_REGISTRAR_CONSULTA"
        Me.BTN_REGISTRAR_CONSULTA.Size = New System.Drawing.Size(264, 51)
        Me.BTN_REGISTRAR_CONSULTA.TabIndex = 24
        Me.BTN_REGISTRAR_CONSULTA.Text = "Finalizar consulta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(69, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 21)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Área de atencion:"
        '
        'FECHA
        '
        Me.FECHA.Checked = True
        Me.FECHA.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.FECHA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FECHA.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.FECHA.Location = New System.Drawing.Point(208, 432)
        Me.FECHA.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.FECHA.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.FECHA.Name = "FECHA"
        Me.FECHA.Size = New System.Drawing.Size(211, 33)
        Me.FECHA.TabIndex = 66
        Me.FECHA.Value = New Date(2022, 3, 8, 18, 42, 13, 222)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(66, 437)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 21)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Fecha de consulta:"
        '
        'RECETA_MEDICA
        '
        Me.RECETA_MEDICA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RECETA_MEDICA.DefaultText = ""
        Me.RECETA_MEDICA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.RECETA_MEDICA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.RECETA_MEDICA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.RECETA_MEDICA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.RECETA_MEDICA.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.RECETA_MEDICA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RECETA_MEDICA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RECETA_MEDICA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RECETA_MEDICA.Location = New System.Drawing.Point(208, 344)
        Me.RECETA_MEDICA.Name = "RECETA_MEDICA"
        Me.RECETA_MEDICA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RECETA_MEDICA.PlaceholderText = ""
        Me.RECETA_MEDICA.SelectedText = ""
        Me.RECETA_MEDICA.Size = New System.Drawing.Size(657, 59)
        Me.RECETA_MEDICA.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(89, 361)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 21)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Receta medica:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(511, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 21)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Edad del paciente:"
        '
        'NOMBRE_MEDICO
        '
        Me.NOMBRE_MEDICO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NOMBRE_MEDICO.DefaultText = ""
        Me.NOMBRE_MEDICO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NOMBRE_MEDICO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NOMBRE_MEDICO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NOMBRE_MEDICO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NOMBRE_MEDICO.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.NOMBRE_MEDICO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NOMBRE_MEDICO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NOMBRE_MEDICO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NOMBRE_MEDICO.Location = New System.Drawing.Point(654, 61)
        Me.NOMBRE_MEDICO.Name = "NOMBRE_MEDICO"
        Me.NOMBRE_MEDICO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NOMBRE_MEDICO.PlaceholderText = ""
        Me.NOMBRE_MEDICO.SelectedText = ""
        Me.NOMBRE_MEDICO.Size = New System.Drawing.Size(211, 33)
        Me.NOMBRE_MEDICO.TabIndex = 60
        '
        'CORREO_PACIENTE
        '
        Me.CORREO_PACIENTE.AutoSize = True
        Me.CORREO_PACIENTE.BackColor = System.Drawing.Color.Transparent
        Me.CORREO_PACIENTE.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CORREO_PACIENTE.ForeColor = System.Drawing.Color.Black
        Me.CORREO_PACIENTE.Location = New System.Drawing.Point(497, 65)
        Me.CORREO_PACIENTE.Name = "CORREO_PACIENTE"
        Me.CORREO_PACIENTE.Size = New System.Drawing.Size(151, 21)
        Me.CORREO_PACIENTE.TabIndex = 59
        Me.CORREO_PACIENTE.Text = "Nombre del medico:"
        '
        'CONSULTA_TXT_DIAGNOSTICO
        '
        Me.CONSULTA_TXT_DIAGNOSTICO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CONSULTA_TXT_DIAGNOSTICO.DefaultText = ""
        Me.CONSULTA_TXT_DIAGNOSTICO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CONSULTA_TXT_DIAGNOSTICO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CONSULTA_TXT_DIAGNOSTICO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CONSULTA_TXT_DIAGNOSTICO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CONSULTA_TXT_DIAGNOSTICO.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CONSULTA_TXT_DIAGNOSTICO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CONSULTA_TXT_DIAGNOSTICO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CONSULTA_TXT_DIAGNOSTICO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CONSULTA_TXT_DIAGNOSTICO.Location = New System.Drawing.Point(208, 255)
        Me.CONSULTA_TXT_DIAGNOSTICO.Name = "CONSULTA_TXT_DIAGNOSTICO"
        Me.CONSULTA_TXT_DIAGNOSTICO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CONSULTA_TXT_DIAGNOSTICO.PlaceholderText = ""
        Me.CONSULTA_TXT_DIAGNOSTICO.SelectedText = ""
        Me.CONSULTA_TXT_DIAGNOSTICO.Size = New System.Drawing.Size(657, 59)
        Me.CONSULTA_TXT_DIAGNOSTICO.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 21)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Resultado de diagnóstico:"
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
        Me.CEDULA.Location = New System.Drawing.Point(208, 124)
        Me.CEDULA.Name = "CEDULA"
        Me.CEDULA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CEDULA.PlaceholderText = ""
        Me.CEDULA.SelectedText = ""
        Me.CEDULA.Size = New System.Drawing.Size(211, 33)
        Me.CEDULA.TabIndex = 54
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(51, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 21)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Cedula del paciente:"
        '
        'CONSULTA_NOMBRE_PACIENTE
        '
        Me.CONSULTA_NOMBRE_PACIENTE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CONSULTA_NOMBRE_PACIENTE.DefaultText = ""
        Me.CONSULTA_NOMBRE_PACIENTE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CONSULTA_NOMBRE_PACIENTE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CONSULTA_NOMBRE_PACIENTE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CONSULTA_NOMBRE_PACIENTE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
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
        Me.Label4.Location = New System.Drawing.Point(49, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 21)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Nombre de paciente:"
        '
        'C_AREA
        '
        Me.C_AREA.BackColor = System.Drawing.Color.Transparent
        Me.C_AREA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.C_AREA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C_AREA.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.C_AREA.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C_AREA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C_AREA.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.C_AREA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.C_AREA.ItemHeight = 30
        Me.C_AREA.Location = New System.Drawing.Point(204, 191)
        Me.C_AREA.Name = "C_AREA"
        Me.C_AREA.Size = New System.Drawing.Size(211, 36)
        Me.C_AREA.TabIndex = 71
        '
        'EDAD
        '
        Me.EDAD.BackColor = System.Drawing.Color.Transparent
        Me.EDAD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EDAD.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.EDAD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.EDAD.ForeColor = System.Drawing.Color.Black
        Me.EDAD.Location = New System.Drawing.Point(654, 125)
        Me.EDAD.Name = "EDAD"
        Me.EDAD.Size = New System.Drawing.Size(211, 33)
        Me.EDAD.TabIndex = 72
        Me.EDAD.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(799, 440)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 21)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = ":Minutos"
        '
        'MINUTOS_CONSULTA
        '
        Me.MINUTOS_CONSULTA.FormattingEnabled = True
        Me.MINUTOS_CONSULTA.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.MINUTOS_CONSULTA.Location = New System.Drawing.Point(745, 440)
        Me.MINUTOS_CONSULTA.Name = "MINUTOS_CONSULTA"
        Me.MINUTOS_CONSULTA.Size = New System.Drawing.Size(53, 23)
        Me.MINUTOS_CONSULTA.TabIndex = 76
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(685, 439)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 21)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = ":Horas"
        '
        'HORA_CONSULTA
        '
        Me.HORA_CONSULTA.FormattingEnabled = True
        Me.HORA_CONSULTA.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.HORA_CONSULTA.Location = New System.Drawing.Point(631, 439)
        Me.HORA_CONSULTA.Name = "HORA_CONSULTA"
        Me.HORA_CONSULTA.Size = New System.Drawing.Size(53, 23)
        Me.HORA_CONSULTA.TabIndex = 74
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(500, 438)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 21)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Hora de consulta:"
        '
        'Agregar_atencion
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(994, 686)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Agregar_atencion"
        Me.Text = "Agregar_atencion"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.AREA_GROUP.ResumeLayout(False)
        Me.AREA_GROUP.PerformLayout()
        CType(Me.EDAD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents BTN_REGISTRAR_CONSULTA As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AREA_GROUP As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents NOMBRE_MEDICO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CORREO_PACIENTE As Label
    Friend WithEvents CONSULTA_TXT_DIAGNOSTICO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CEDULA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CONSULTA_NOMBRE_PACIENTE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BTN_VER_CONSULTAS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label7 As Label
    Friend WithEvents FECHA As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents RECETA_MEDICA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents EDAD As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents C_AREA As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents MINUTOS_CONSULTA As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents HORA_CONSULTA As ComboBox
    Friend WithEvents Label10 As Label
End Class
