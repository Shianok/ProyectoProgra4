<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_paciente
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
        Me.btnCerrarInterfaz = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_PADECIMIENTOS = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_agregar_paciente = New Guna.UI2.WinForms.Guna2Button()
        Me.NACIMIENTO_PACIENTE = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.RESIDENCIA_PACIENTE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CORREO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CORREO_PACIENTE = New System.Windows.Forms.Label()
        Me.NUMERO_PACIENTE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NOMBRE_PACIENTE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CEDULA_PACIENTE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox1.Controls.Add(Me.btnCerrarInterfaz)
        Me.Guna2GroupBox1.Controls.Add(Me.TXT_PADECIMIENTOS)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.Btn_agregar_paciente)
        Me.Guna2GroupBox1.Controls.Add(Me.NACIMIENTO_PACIENTE)
        Me.Guna2GroupBox1.Controls.Add(Me.RESIDENCIA_PACIENTE)
        Me.Guna2GroupBox1.Controls.Add(Me.Label9)
        Me.Guna2GroupBox1.Controls.Add(Me.Label10)
        Me.Guna2GroupBox1.Controls.Add(Me.CORREO)
        Me.Guna2GroupBox1.Controls.Add(Me.CORREO_PACIENTE)
        Me.Guna2GroupBox1.Controls.Add(Me.NUMERO_PACIENTE)
        Me.Guna2GroupBox1.Controls.Add(Me.Label6)
        Me.Guna2GroupBox1.Controls.Add(Me.NOMBRE_PACIENTE)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.CEDULA_PACIENTE)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(994, 527)
        Me.Guna2GroupBox1.TabIndex = 1
        Me.Guna2GroupBox1.Text = "Agregar paciente"
        '
        'btnCerrarInterfaz
        '
        Me.btnCerrarInterfaz.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrarInterfaz.BorderRadius = 2
        Me.btnCerrarInterfaz.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCerrarInterfaz.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCerrarInterfaz.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCerrarInterfaz.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCerrarInterfaz.FillColor = System.Drawing.Color.Red
        Me.btnCerrarInterfaz.FocusedColor = System.Drawing.Color.Maroon
        Me.btnCerrarInterfaz.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCerrarInterfaz.ForeColor = System.Drawing.Color.White
        Me.btnCerrarInterfaz.Location = New System.Drawing.Point(951, 3)
        Me.btnCerrarInterfaz.Name = "btnCerrarInterfaz"
        Me.btnCerrarInterfaz.Size = New System.Drawing.Size(38, 35)
        Me.btnCerrarInterfaz.TabIndex = 14
        Me.btnCerrarInterfaz.Text = "X"
        '
        'TXT_PADECIMIENTOS
        '
        Me.TXT_PADECIMIENTOS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_PADECIMIENTOS.DefaultText = ""
        Me.TXT_PADECIMIENTOS.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_PADECIMIENTOS.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_PADECIMIENTOS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_PADECIMIENTOS.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_PADECIMIENTOS.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TXT_PADECIMIENTOS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_PADECIMIENTOS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_PADECIMIENTOS.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_PADECIMIENTOS.Location = New System.Drawing.Point(234, 322)
        Me.TXT_PADECIMIENTOS.Name = "TXT_PADECIMIENTOS"
        Me.TXT_PADECIMIENTOS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_PADECIMIENTOS.PlaceholderText = ""
        Me.TXT_PADECIMIENTOS.SelectedText = ""
        Me.TXT_PADECIMIENTOS.Size = New System.Drawing.Size(623, 59)
        Me.TXT_PADECIMIENTOS.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(115, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 21)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Padesimientos:"
        '
        'Btn_agregar_paciente
        '
        Me.Btn_agregar_paciente.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_agregar_paciente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_agregar_paciente.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_agregar_paciente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_agregar_paciente.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Btn_agregar_paciente.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btn_agregar_paciente.ForeColor = System.Drawing.Color.White
        Me.Btn_agregar_paciente.Location = New System.Drawing.Point(340, 433)
        Me.Btn_agregar_paciente.Name = "Btn_agregar_paciente"
        Me.Btn_agregar_paciente.Size = New System.Drawing.Size(302, 63)
        Me.Btn_agregar_paciente.TabIndex = 24
        Me.Btn_agregar_paciente.Text = "Agregar paciente"
        '
        'NACIMIENTO_PACIENTE
        '
        Me.NACIMIENTO_PACIENTE.Checked = True
        Me.NACIMIENTO_PACIENTE.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.NACIMIENTO_PACIENTE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NACIMIENTO_PACIENTE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.NACIMIENTO_PACIENTE.Location = New System.Drawing.Point(234, 249)
        Me.NACIMIENTO_PACIENTE.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.NACIMIENTO_PACIENTE.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.NACIMIENTO_PACIENTE.Name = "NACIMIENTO_PACIENTE"
        Me.NACIMIENTO_PACIENTE.Size = New System.Drawing.Size(211, 33)
        Me.NACIMIENTO_PACIENTE.TabIndex = 21
        Me.NACIMIENTO_PACIENTE.Value = New Date(2022, 3, 8, 18, 42, 13, 222)
        '
        'RESIDENCIA_PACIENTE
        '
        Me.RESIDENCIA_PACIENTE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RESIDENCIA_PACIENTE.DefaultText = ""
        Me.RESIDENCIA_PACIENTE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.RESIDENCIA_PACIENTE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.RESIDENCIA_PACIENTE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.RESIDENCIA_PACIENTE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.RESIDENCIA_PACIENTE.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.RESIDENCIA_PACIENTE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RESIDENCIA_PACIENTE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RESIDENCIA_PACIENTE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RESIDENCIA_PACIENTE.Location = New System.Drawing.Point(676, 249)
        Me.RESIDENCIA_PACIENTE.Name = "RESIDENCIA_PACIENTE"
        Me.RESIDENCIA_PACIENTE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RESIDENCIA_PACIENTE.PlaceholderText = ""
        Me.RESIDENCIA_PACIENTE.SelectedText = ""
        Me.RESIDENCIA_PACIENTE.Size = New System.Drawing.Size(211, 33)
        Me.RESIDENCIA_PACIENTE.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(522, 261)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(148, 21)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Lugar de residencia:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(73, 261)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(155, 21)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Fecha de nacimiento:"
        '
        'CORREO
        '
        Me.CORREO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CORREO.DefaultText = ""
        Me.CORREO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CORREO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CORREO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CORREO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CORREO.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CORREO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CORREO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CORREO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CORREO.Location = New System.Drawing.Point(676, 176)
        Me.CORREO.Name = "CORREO"
        Me.CORREO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CORREO.PlaceholderText = ""
        Me.CORREO.SelectedText = ""
        Me.CORREO.Size = New System.Drawing.Size(211, 33)
        Me.CORREO.TabIndex = 12
        '
        'CORREO_PACIENTE
        '
        Me.CORREO_PACIENTE.AutoSize = True
        Me.CORREO_PACIENTE.BackColor = System.Drawing.Color.Transparent
        Me.CORREO_PACIENTE.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CORREO_PACIENTE.ForeColor = System.Drawing.Color.Black
        Me.CORREO_PACIENTE.Location = New System.Drawing.Point(609, 188)
        Me.CORREO_PACIENTE.Name = "CORREO_PACIENTE"
        Me.CORREO_PACIENTE.Size = New System.Drawing.Size(61, 21)
        Me.CORREO_PACIENTE.TabIndex = 11
        Me.CORREO_PACIENTE.Text = "Correo:"
        '
        'NUMERO_PACIENTE
        '
        Me.NUMERO_PACIENTE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUMERO_PACIENTE.DefaultText = ""
        Me.NUMERO_PACIENTE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NUMERO_PACIENTE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NUMERO_PACIENTE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NUMERO_PACIENTE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NUMERO_PACIENTE.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.NUMERO_PACIENTE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NUMERO_PACIENTE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUMERO_PACIENTE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NUMERO_PACIENTE.Location = New System.Drawing.Point(234, 176)
        Me.NUMERO_PACIENTE.Name = "NUMERO_PACIENTE"
        Me.NUMERO_PACIENTE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NUMERO_PACIENTE.PlaceholderText = ""
        Me.NUMERO_PACIENTE.SelectedText = ""
        Me.NUMERO_PACIENTE.Size = New System.Drawing.Size(211, 33)
        Me.NUMERO_PACIENTE.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(75, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 21)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Número de teléfono:"
        '
        'NOMBRE_PACIENTE
        '
        Me.NOMBRE_PACIENTE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NOMBRE_PACIENTE.DefaultText = ""
        Me.NOMBRE_PACIENTE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NOMBRE_PACIENTE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NOMBRE_PACIENTE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NOMBRE_PACIENTE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NOMBRE_PACIENTE.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.NOMBRE_PACIENTE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NOMBRE_PACIENTE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NOMBRE_PACIENTE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NOMBRE_PACIENTE.Location = New System.Drawing.Point(234, 97)
        Me.NOMBRE_PACIENTE.Name = "NOMBRE_PACIENTE"
        Me.NOMBRE_PACIENTE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NOMBRE_PACIENTE.PlaceholderText = ""
        Me.NOMBRE_PACIENTE.SelectedText = ""
        Me.NOMBRE_PACIENTE.Size = New System.Drawing.Size(211, 33)
        Me.NOMBRE_PACIENTE.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(88, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nombre completo:"
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
        Me.CEDULA_PACIENTE.Location = New System.Drawing.Point(676, 97)
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
        Me.Label1.Location = New System.Drawing.Point(609, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cédula:"
        '
        'Registrar_paciente
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(994, 527)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registrar_paciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar_paciente"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents TXT_PADECIMIENTOS As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_agregar_paciente As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents NACIMIENTO_PACIENTE As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents RESIDENCIA_PACIENTE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents CORREO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CORREO_PACIENTE As Label
    Friend WithEvents NUMERO_PACIENTE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents NOMBRE_PACIENTE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CEDULA_PACIENTE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCerrarInterfaz As Guna.UI2.WinForms.Guna2Button
End Class
