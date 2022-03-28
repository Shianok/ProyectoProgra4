<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultar_empleado
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
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTN_ABRIR_REGISTRAR_EMPLEADO = New Guna.UI2.WinForms.Guna2Button()
        Me.CUNSULTA_PACIENTE = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.BTN_BUSCAR_EMPLEADO = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CEDULA_EMPLEADO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CONSULTA_INFO = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.BORRAR = New Guna.UI2.WinForms.Guna2Button()
        Me.ACTUALIZAR = New Guna.UI2.WinForms.Guna2Button()
        Me.IMG_CONSULTA_EMPLEADO = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.AREA_EMPLEADO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TIPO_EMPLEADO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CONSULTA_RESIDENCIA_EMPLEADO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CONSULTA_NUMERO_CARNET = New Guna.UI2.WinForms.Guna2TextBox()
        Me.USUARIO_EMPLEADO = New System.Windows.Forms.Label()
        Me.CONSULTA_NUMERO_EMPLEADO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CONSULTA_NOMBRE_EMPLEADO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.CUNSULTA_PACIENTE.SuspendLayout()
        Me.CONSULTA_INFO.SuspendLayout()
        CType(Me.IMG_CONSULTA_EMPLEADO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2GroupBox2)
        Me.Guna2GroupBox1.Controls.Add(Me.CUNSULTA_PACIENTE)
        Me.Guna2GroupBox1.Controls.Add(Me.CONSULTA_INFO)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(996, 686)
        Me.Guna2GroupBox1.TabIndex = 3
        Me.Guna2GroupBox1.Text = "Consultar empleado"
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox2.BorderRadius = 5
        Me.Guna2GroupBox2.BorderThickness = 2
        Me.Guna2GroupBox2.Controls.Add(Me.Label3)
        Me.Guna2GroupBox2.Controls.Add(Me.BTN_ABRIR_REGISTRAR_EMPLEADO)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(44, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 21)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Registrar empleado:"
        '
        'BTN_ABRIR_REGISTRAR_EMPLEADO
        '
        Me.BTN_ABRIR_REGISTRAR_EMPLEADO.BorderRadius = 5
        Me.BTN_ABRIR_REGISTRAR_EMPLEADO.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ABRIR_REGISTRAR_EMPLEADO.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ABRIR_REGISTRAR_EMPLEADO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_ABRIR_REGISTRAR_EMPLEADO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_ABRIR_REGISTRAR_EMPLEADO.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BTN_ABRIR_REGISTRAR_EMPLEADO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_ABRIR_REGISTRAR_EMPLEADO.ForeColor = System.Drawing.Color.White
        Me.BTN_ABRIR_REGISTRAR_EMPLEADO.Location = New System.Drawing.Point(199, 53)
        Me.BTN_ABRIR_REGISTRAR_EMPLEADO.Name = "BTN_ABRIR_REGISTRAR_EMPLEADO"
        Me.BTN_ABRIR_REGISTRAR_EMPLEADO.Size = New System.Drawing.Size(163, 33)
        Me.BTN_ABRIR_REGISTRAR_EMPLEADO.TabIndex = 24
        Me.BTN_ABRIR_REGISTRAR_EMPLEADO.Text = "Registrar "
        '
        'CUNSULTA_PACIENTE
        '
        Me.CUNSULTA_PACIENTE.BackColor = System.Drawing.Color.Transparent
        Me.CUNSULTA_PACIENTE.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CUNSULTA_PACIENTE.BorderRadius = 5
        Me.CUNSULTA_PACIENTE.BorderThickness = 2
        Me.CUNSULTA_PACIENTE.Controls.Add(Me.BTN_BUSCAR_EMPLEADO)
        Me.CUNSULTA_PACIENTE.Controls.Add(Me.Label1)
        Me.CUNSULTA_PACIENTE.Controls.Add(Me.CEDULA_EMPLEADO)
        Me.CUNSULTA_PACIENTE.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CUNSULTA_PACIENTE.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.CUNSULTA_PACIENTE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CUNSULTA_PACIENTE.ForeColor = System.Drawing.Color.White
        Me.CUNSULTA_PACIENTE.Location = New System.Drawing.Point(471, 54)
        Me.CUNSULTA_PACIENTE.Name = "CUNSULTA_PACIENTE"
        Me.CUNSULTA_PACIENTE.Size = New System.Drawing.Size(490, 99)
        Me.CUNSULTA_PACIENTE.TabIndex = 26
        Me.CUNSULTA_PACIENTE.Text = "Buscar paciente"
        '
        'BTN_BUSCAR_EMPLEADO
        '
        Me.BTN_BUSCAR_EMPLEADO.BorderRadius = 5
        Me.BTN_BUSCAR_EMPLEADO.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_BUSCAR_EMPLEADO.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_BUSCAR_EMPLEADO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_BUSCAR_EMPLEADO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_BUSCAR_EMPLEADO.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BTN_BUSCAR_EMPLEADO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_BUSCAR_EMPLEADO.ForeColor = System.Drawing.Color.White
        Me.BTN_BUSCAR_EMPLEADO.Location = New System.Drawing.Point(319, 53)
        Me.BTN_BUSCAR_EMPLEADO.Name = "BTN_BUSCAR_EMPLEADO"
        Me.BTN_BUSCAR_EMPLEADO.Size = New System.Drawing.Size(163, 33)
        Me.BTN_BUSCAR_EMPLEADO.TabIndex = 24
        Me.BTN_BUSCAR_EMPLEADO.Text = "Buscar empleado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Carnet:"
        '
        'CEDULA_EMPLEADO
        '
        Me.CEDULA_EMPLEADO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CEDULA_EMPLEADO.DefaultText = ""
        Me.CEDULA_EMPLEADO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CEDULA_EMPLEADO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CEDULA_EMPLEADO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CEDULA_EMPLEADO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CEDULA_EMPLEADO.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CEDULA_EMPLEADO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CEDULA_EMPLEADO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CEDULA_EMPLEADO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CEDULA_EMPLEADO.Location = New System.Drawing.Point(72, 53)
        Me.CEDULA_EMPLEADO.Name = "CEDULA_EMPLEADO"
        Me.CEDULA_EMPLEADO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CEDULA_EMPLEADO.PlaceholderText = ""
        Me.CEDULA_EMPLEADO.SelectedText = ""
        Me.CEDULA_EMPLEADO.Size = New System.Drawing.Size(211, 33)
        Me.CEDULA_EMPLEADO.TabIndex = 2
        '
        'CONSULTA_INFO
        '
        Me.CONSULTA_INFO.BackColor = System.Drawing.Color.Transparent
        Me.CONSULTA_INFO.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CONSULTA_INFO.BorderRadius = 5
        Me.CONSULTA_INFO.BorderThickness = 2
        Me.CONSULTA_INFO.Controls.Add(Me.BORRAR)
        Me.CONSULTA_INFO.Controls.Add(Me.ACTUALIZAR)
        Me.CONSULTA_INFO.Controls.Add(Me.IMG_CONSULTA_EMPLEADO)
        Me.CONSULTA_INFO.Controls.Add(Me.AREA_EMPLEADO)
        Me.CONSULTA_INFO.Controls.Add(Me.Label5)
        Me.CONSULTA_INFO.Controls.Add(Me.TIPO_EMPLEADO)
        Me.CONSULTA_INFO.Controls.Add(Me.Label2)
        Me.CONSULTA_INFO.Controls.Add(Me.CONSULTA_RESIDENCIA_EMPLEADO)
        Me.CONSULTA_INFO.Controls.Add(Me.Label9)
        Me.CONSULTA_INFO.Controls.Add(Me.CONSULTA_NUMERO_CARNET)
        Me.CONSULTA_INFO.Controls.Add(Me.USUARIO_EMPLEADO)
        Me.CONSULTA_INFO.Controls.Add(Me.CONSULTA_NUMERO_EMPLEADO)
        Me.CONSULTA_INFO.Controls.Add(Me.Label6)
        Me.CONSULTA_INFO.Controls.Add(Me.CONSULTA_NOMBRE_EMPLEADO)
        Me.CONSULTA_INFO.Controls.Add(Me.Label4)
        Me.CONSULTA_INFO.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CONSULTA_INFO.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.CONSULTA_INFO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CONSULTA_INFO.ForeColor = System.Drawing.Color.White
        Me.CONSULTA_INFO.Location = New System.Drawing.Point(27, 172)
        Me.CONSULTA_INFO.Name = "CONSULTA_INFO"
        Me.CONSULTA_INFO.Size = New System.Drawing.Size(934, 500)
        Me.CONSULTA_INFO.TabIndex = 25
        Me.CONSULTA_INFO.Text = "Informacion de empleado"
        '
        'BORRAR
        '
        Me.BORRAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BORRAR.BorderRadius = 5
        Me.BORRAR.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BORRAR.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BORRAR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BORRAR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BORRAR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BORRAR.Enabled = False
        Me.BORRAR.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BORRAR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BORRAR.ForeColor = System.Drawing.Color.White
        Me.BORRAR.Location = New System.Drawing.Point(795, 2)
        Me.BORRAR.Margin = New System.Windows.Forms.Padding(2)
        Me.BORRAR.Name = "BORRAR"
        Me.BORRAR.Size = New System.Drawing.Size(131, 35)
        Me.BORRAR.TabIndex = 66
        Me.BORRAR.Text = "Eliminar paciente"
        '
        'ACTUALIZAR
        '
        Me.ACTUALIZAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ACTUALIZAR.BorderRadius = 5
        Me.ACTUALIZAR.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ACTUALIZAR.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ACTUALIZAR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ACTUALIZAR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ACTUALIZAR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ACTUALIZAR.Enabled = False
        Me.ACTUALIZAR.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.ACTUALIZAR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ACTUALIZAR.ForeColor = System.Drawing.Color.White
        Me.ACTUALIZAR.Location = New System.Drawing.Point(660, 2)
        Me.ACTUALIZAR.Margin = New System.Windows.Forms.Padding(2)
        Me.ACTUALIZAR.Name = "ACTUALIZAR"
        Me.ACTUALIZAR.Size = New System.Drawing.Size(129, 35)
        Me.ACTUALIZAR.TabIndex = 65
        Me.ACTUALIZAR.Text = "Actualizar paciente"
        '
        'IMG_CONSULTA_EMPLEADO
        '
        Me.IMG_CONSULTA_EMPLEADO.BackColor = System.Drawing.Color.Transparent
        Me.IMG_CONSULTA_EMPLEADO.Image = Global.Proyecto.My.Resources.Resources.user
        Me.IMG_CONSULTA_EMPLEADO.ImageRotate = 0!
        Me.IMG_CONSULTA_EMPLEADO.Location = New System.Drawing.Point(391, 47)
        Me.IMG_CONSULTA_EMPLEADO.Name = "IMG_CONSULTA_EMPLEADO"
        Me.IMG_CONSULTA_EMPLEADO.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.IMG_CONSULTA_EMPLEADO.Size = New System.Drawing.Size(147, 144)
        Me.IMG_CONSULTA_EMPLEADO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IMG_CONSULTA_EMPLEADO.TabIndex = 67
        Me.IMG_CONSULTA_EMPLEADO.TabStop = False
        Me.IMG_CONSULTA_EMPLEADO.UseTransparentBackground = True
        '
        'AREA_EMPLEADO
        '
        Me.AREA_EMPLEADO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AREA_EMPLEADO.DefaultText = ""
        Me.AREA_EMPLEADO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.AREA_EMPLEADO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.AREA_EMPLEADO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AREA_EMPLEADO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AREA_EMPLEADO.Enabled = False
        Me.AREA_EMPLEADO.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.AREA_EMPLEADO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AREA_EMPLEADO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AREA_EMPLEADO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AREA_EMPLEADO.Location = New System.Drawing.Point(650, 434)
        Me.AREA_EMPLEADO.Name = "AREA_EMPLEADO"
        Me.AREA_EMPLEADO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AREA_EMPLEADO.PlaceholderText = ""
        Me.AREA_EMPLEADO.SelectedText = ""
        Me.AREA_EMPLEADO.Size = New System.Drawing.Size(211, 33)
        Me.AREA_EMPLEADO.TabIndex = 66
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(599, 438)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 21)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Area:"
        '
        'TIPO_EMPLEADO
        '
        Me.TIPO_EMPLEADO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TIPO_EMPLEADO.DefaultText = ""
        Me.TIPO_EMPLEADO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TIPO_EMPLEADO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TIPO_EMPLEADO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TIPO_EMPLEADO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TIPO_EMPLEADO.Enabled = False
        Me.TIPO_EMPLEADO.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TIPO_EMPLEADO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TIPO_EMPLEADO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TIPO_EMPLEADO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TIPO_EMPLEADO.Location = New System.Drawing.Point(209, 434)
        Me.TIPO_EMPLEADO.Name = "TIPO_EMPLEADO"
        Me.TIPO_EMPLEADO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TIPO_EMPLEADO.PlaceholderText = ""
        Me.TIPO_EMPLEADO.SelectedText = ""
        Me.TIPO_EMPLEADO.Size = New System.Drawing.Size(211, 33)
        Me.TIPO_EMPLEADO.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(63, 440)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 21)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Tipo de empleado:"
        Me.Label2.Visible = False
        '
        'CONSULTA_RESIDENCIA_EMPLEADO
        '
        Me.CONSULTA_RESIDENCIA_EMPLEADO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CONSULTA_RESIDENCIA_EMPLEADO.DefaultText = ""
        Me.CONSULTA_RESIDENCIA_EMPLEADO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CONSULTA_RESIDENCIA_EMPLEADO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CONSULTA_RESIDENCIA_EMPLEADO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CONSULTA_RESIDENCIA_EMPLEADO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CONSULTA_RESIDENCIA_EMPLEADO.Enabled = False
        Me.CONSULTA_RESIDENCIA_EMPLEADO.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CONSULTA_RESIDENCIA_EMPLEADO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CONSULTA_RESIDENCIA_EMPLEADO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CONSULTA_RESIDENCIA_EMPLEADO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CONSULTA_RESIDENCIA_EMPLEADO.Location = New System.Drawing.Point(650, 320)
        Me.CONSULTA_RESIDENCIA_EMPLEADO.Name = "CONSULTA_RESIDENCIA_EMPLEADO"
        Me.CONSULTA_RESIDENCIA_EMPLEADO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CONSULTA_RESIDENCIA_EMPLEADO.PlaceholderText = ""
        Me.CONSULTA_RESIDENCIA_EMPLEADO.SelectedText = ""
        Me.CONSULTA_RESIDENCIA_EMPLEADO.Size = New System.Drawing.Size(211, 33)
        Me.CONSULTA_RESIDENCIA_EMPLEADO.TabIndex = 62
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(496, 323)
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
        Me.CONSULTA_NUMERO_CARNET.Location = New System.Drawing.Point(650, 210)
        Me.CONSULTA_NUMERO_CARNET.Name = "CONSULTA_NUMERO_CARNET"
        Me.CONSULTA_NUMERO_CARNET.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CONSULTA_NUMERO_CARNET.PlaceholderText = ""
        Me.CONSULTA_NUMERO_CARNET.SelectedText = ""
        Me.CONSULTA_NUMERO_CARNET.Size = New System.Drawing.Size(211, 33)
        Me.CONSULTA_NUMERO_CARNET.TabIndex = 60
        '
        'USUARIO_EMPLEADO
        '
        Me.USUARIO_EMPLEADO.AutoSize = True
        Me.USUARIO_EMPLEADO.BackColor = System.Drawing.Color.Transparent
        Me.USUARIO_EMPLEADO.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USUARIO_EMPLEADO.ForeColor = System.Drawing.Color.Black
        Me.USUARIO_EMPLEADO.Location = New System.Drawing.Point(577, 213)
        Me.USUARIO_EMPLEADO.Name = "USUARIO_EMPLEADO"
        Me.USUARIO_EMPLEADO.Size = New System.Drawing.Size(61, 21)
        Me.USUARIO_EMPLEADO.TabIndex = 59
        Me.USUARIO_EMPLEADO.Text = "Cedula:"
        '
        'CONSULTA_NUMERO_EMPLEADO
        '
        Me.CONSULTA_NUMERO_EMPLEADO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CONSULTA_NUMERO_EMPLEADO.DefaultText = ""
        Me.CONSULTA_NUMERO_EMPLEADO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CONSULTA_NUMERO_EMPLEADO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CONSULTA_NUMERO_EMPLEADO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CONSULTA_NUMERO_EMPLEADO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CONSULTA_NUMERO_EMPLEADO.Enabled = False
        Me.CONSULTA_NUMERO_EMPLEADO.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CONSULTA_NUMERO_EMPLEADO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CONSULTA_NUMERO_EMPLEADO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CONSULTA_NUMERO_EMPLEADO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CONSULTA_NUMERO_EMPLEADO.Location = New System.Drawing.Point(209, 321)
        Me.CONSULTA_NUMERO_EMPLEADO.Name = "CONSULTA_NUMERO_EMPLEADO"
        Me.CONSULTA_NUMERO_EMPLEADO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CONSULTA_NUMERO_EMPLEADO.PlaceholderText = ""
        Me.CONSULTA_NUMERO_EMPLEADO.SelectedText = ""
        Me.CONSULTA_NUMERO_EMPLEADO.Size = New System.Drawing.Size(211, 33)
        Me.CONSULTA_NUMERO_EMPLEADO.TabIndex = 54
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(50, 325)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 21)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Número de teléfono:"
        Me.Label6.Visible = False
        '
        'CONSULTA_NOMBRE_EMPLEADO
        '
        Me.CONSULTA_NOMBRE_EMPLEADO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CONSULTA_NOMBRE_EMPLEADO.DefaultText = ""
        Me.CONSULTA_NOMBRE_EMPLEADO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CONSULTA_NOMBRE_EMPLEADO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CONSULTA_NOMBRE_EMPLEADO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CONSULTA_NOMBRE_EMPLEADO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CONSULTA_NOMBRE_EMPLEADO.Enabled = False
        Me.CONSULTA_NOMBRE_EMPLEADO.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CONSULTA_NOMBRE_EMPLEADO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CONSULTA_NOMBRE_EMPLEADO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CONSULTA_NOMBRE_EMPLEADO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CONSULTA_NOMBRE_EMPLEADO.Location = New System.Drawing.Point(209, 210)
        Me.CONSULTA_NOMBRE_EMPLEADO.Name = "CONSULTA_NOMBRE_EMPLEADO"
        Me.CONSULTA_NOMBRE_EMPLEADO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CONSULTA_NOMBRE_EMPLEADO.PlaceholderText = ""
        Me.CONSULTA_NOMBRE_EMPLEADO.SelectedText = ""
        Me.CONSULTA_NOMBRE_EMPLEADO.Size = New System.Drawing.Size(211, 33)
        Me.CONSULTA_NOMBRE_EMPLEADO.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(63, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 21)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Nombre completo:"
        Me.Label4.Visible = False
        '
        'Consultar_empleado
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(994, 686)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Consultar_empleado"
        Me.Text = "Consultar_empleado"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.CUNSULTA_PACIENTE.ResumeLayout(False)
        Me.CUNSULTA_PACIENTE.PerformLayout()
        Me.CONSULTA_INFO.ResumeLayout(False)
        Me.CONSULTA_INFO.PerformLayout()
        CType(Me.IMG_CONSULTA_EMPLEADO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BTN_ABRIR_REGISTRAR_EMPLEADO As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CUNSULTA_PACIENTE As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents BTN_BUSCAR_EMPLEADO As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CEDULA_EMPLEADO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CONSULTA_INFO As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents CONSULTA_RESIDENCIA_EMPLEADO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CONSULTA_NUMERO_CARNET As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents USUARIO_EMPLEADO As Label
    Friend WithEvents CONSULTA_NUMERO_EMPLEADO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CONSULTA_NOMBRE_EMPLEADO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents AREA_EMPLEADO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TIPO_EMPLEADO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents IMG_CONSULTA_EMPLEADO As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents BORRAR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ACTUALIZAR As Guna.UI2.WinForms.Guna2Button
End Class
