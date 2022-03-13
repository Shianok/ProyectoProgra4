<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Interfaz
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Interfaz))
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Panel_opciones = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel_menu = New Guna.UI2.WinForms.Guna2Panel()
        Me.Btn_consultas = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn_ver_facturas = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn_facturas = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn_areas = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn_agregar_atencion = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn_empleado = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn_paciente = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Btn_opciones = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnCerrarInterfaz = New Guna.UI2.WinForms.Guna2Button()
        Me.Mostrar_opciones = New System.Windows.Forms.Timer(Me.components)
        Me.Ocultar_opciones = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2GroupBox2.SuspendLayout()
        Me.Panel_menu.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_opciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox2.Controls.Add(Me.Panel_opciones)
        Me.Guna2GroupBox2.Controls.Add(Me.Panel_menu)
        Me.Guna2GroupBox2.Controls.Add(Me.btnCerrarInterfaz)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(-1, -1)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(1261, 735)
        Me.Guna2GroupBox2.TabIndex = 3
        Me.Guna2GroupBox2.Text = "Bienvenido"
        '
        'Panel_opciones
        '
        Me.Panel_opciones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel_opciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel_opciones.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel_opciones.BorderThickness = 2
        Me.Panel_opciones.Location = New System.Drawing.Point(264, 42)
        Me.Panel_opciones.Name = "Panel_opciones"
        Me.Panel_opciones.Size = New System.Drawing.Size(989, 684)
        Me.Panel_opciones.TabIndex = 15
        '
        'Panel_menu
        '
        Me.Panel_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Panel_menu.BorderColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Panel_menu.BorderRadius = 5
        Me.Panel_menu.BorderThickness = 1
        Me.Panel_menu.Controls.Add(Me.Btn_consultas)
        Me.Panel_menu.Controls.Add(Me.Btn_ver_facturas)
        Me.Panel_menu.Controls.Add(Me.Guna2Button5)
        Me.Panel_menu.Controls.Add(Me.Btn_facturas)
        Me.Panel_menu.Controls.Add(Me.Btn_areas)
        Me.Panel_menu.Controls.Add(Me.Btn_agregar_atencion)
        Me.Panel_menu.Controls.Add(Me.Btn_empleado)
        Me.Panel_menu.Controls.Add(Me.Btn_paciente)
        Me.Panel_menu.Controls.Add(Me.Label1)
        Me.Panel_menu.Controls.Add(Me.Label2)
        Me.Panel_menu.Controls.Add(Me.Guna2PictureBox1)
        Me.Panel_menu.Controls.Add(Me.Btn_opciones)
        Me.Panel_menu.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Panel_menu.Location = New System.Drawing.Point(8, 42)
        Me.Panel_menu.Name = "Panel_menu"
        Me.Panel_menu.Size = New System.Drawing.Size(250, 684)
        Me.Panel_menu.TabIndex = 14
        '
        'Btn_consultas
        '
        Me.Btn_consultas.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Btn_consultas.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_consultas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_consultas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_consultas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_consultas.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Btn_consultas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_consultas.ForeColor = System.Drawing.Color.Black
        Me.Btn_consultas.Image = CType(resources.GetObject("Btn_consultas.Image"), System.Drawing.Image)
        Me.Btn_consultas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Btn_consultas.ImageSize = New System.Drawing.Size(50, 50)
        Me.Btn_consultas.Location = New System.Drawing.Point(2, 225)
        Me.Btn_consultas.Name = "Btn_consultas"
        Me.Btn_consultas.Size = New System.Drawing.Size(244, 55)
        Me.Btn_consultas.TabIndex = 30
        Me.Btn_consultas.Text = "Consultas"
        Me.Btn_consultas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Btn_ver_facturas
        '
        Me.Btn_ver_facturas.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Btn_ver_facturas.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_ver_facturas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_ver_facturas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_ver_facturas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_ver_facturas.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Btn_ver_facturas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ver_facturas.ForeColor = System.Drawing.Color.Black
        Me.Btn_ver_facturas.Image = CType(resources.GetObject("Btn_ver_facturas.Image"), System.Drawing.Image)
        Me.Btn_ver_facturas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Btn_ver_facturas.ImageSize = New System.Drawing.Size(50, 50)
        Me.Btn_ver_facturas.Location = New System.Drawing.Point(1, 535)
        Me.Btn_ver_facturas.Name = "Btn_ver_facturas"
        Me.Btn_ver_facturas.Size = New System.Drawing.Size(244, 55)
        Me.Btn_ver_facturas.TabIndex = 29
        Me.Btn_ver_facturas.Text = "Ver facturas"
        Me.Btn_ver_facturas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Guna2Button5
        '
        Me.Guna2Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button5.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2Button5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button5.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button5.Image = CType(resources.GetObject("Guna2Button5.Image"), System.Drawing.Image)
        Me.Guna2Button5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button5.ImageSize = New System.Drawing.Size(50, 50)
        Me.Guna2Button5.Location = New System.Drawing.Point(2, 621)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.Size = New System.Drawing.Size(244, 55)
        Me.Guna2Button5.TabIndex = 28
        Me.Guna2Button5.Text = "Cerrar sesion"
        Me.Guna2Button5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Btn_facturas
        '
        Me.Btn_facturas.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Btn_facturas.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_facturas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_facturas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_facturas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_facturas.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Btn_facturas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_facturas.ForeColor = System.Drawing.Color.Black
        Me.Btn_facturas.Image = CType(resources.GetObject("Btn_facturas.Image"), System.Drawing.Image)
        Me.Btn_facturas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Btn_facturas.ImageSize = New System.Drawing.Size(50, 50)
        Me.Btn_facturas.Location = New System.Drawing.Point(1, 472)
        Me.Btn_facturas.Name = "Btn_facturas"
        Me.Btn_facturas.Size = New System.Drawing.Size(244, 55)
        Me.Btn_facturas.TabIndex = 27
        Me.Btn_facturas.Text = "Registrar facturas"
        Me.Btn_facturas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Btn_areas
        '
        Me.Btn_areas.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Btn_areas.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_areas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_areas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_areas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_areas.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Btn_areas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_areas.ForeColor = System.Drawing.Color.Black
        Me.Btn_areas.Image = CType(resources.GetObject("Btn_areas.Image"), System.Drawing.Image)
        Me.Btn_areas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Btn_areas.ImageSize = New System.Drawing.Size(50, 50)
        Me.Btn_areas.Location = New System.Drawing.Point(1, 409)
        Me.Btn_areas.Name = "Btn_areas"
        Me.Btn_areas.Size = New System.Drawing.Size(244, 55)
        Me.Btn_areas.TabIndex = 26
        Me.Btn_areas.Text = "Areas"
        Me.Btn_areas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Btn_agregar_atencion
        '
        Me.Btn_agregar_atencion.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Btn_agregar_atencion.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_agregar_atencion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_agregar_atencion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_agregar_atencion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_agregar_atencion.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Btn_agregar_atencion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_agregar_atencion.ForeColor = System.Drawing.Color.Black
        Me.Btn_agregar_atencion.Image = CType(resources.GetObject("Btn_agregar_atencion.Image"), System.Drawing.Image)
        Me.Btn_agregar_atencion.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Btn_agregar_atencion.ImageSize = New System.Drawing.Size(50, 50)
        Me.Btn_agregar_atencion.Location = New System.Drawing.Point(2, 286)
        Me.Btn_agregar_atencion.Name = "Btn_agregar_atencion"
        Me.Btn_agregar_atencion.Size = New System.Drawing.Size(244, 55)
        Me.Btn_agregar_atencion.TabIndex = 25
        Me.Btn_agregar_atencion.Text = "Agregar atencion"
        Me.Btn_agregar_atencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Btn_empleado
        '
        Me.Btn_empleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Btn_empleado.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_empleado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_empleado.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_empleado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_empleado.FillColor = System.Drawing.Color.Transparent
        Me.Btn_empleado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_empleado.ForeColor = System.Drawing.Color.Black
        Me.Btn_empleado.Image = CType(resources.GetObject("Btn_empleado.Image"), System.Drawing.Image)
        Me.Btn_empleado.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Btn_empleado.ImageSize = New System.Drawing.Size(50, 50)
        Me.Btn_empleado.Location = New System.Drawing.Point(1, 347)
        Me.Btn_empleado.Name = "Btn_empleado"
        Me.Btn_empleado.Size = New System.Drawing.Size(244, 55)
        Me.Btn_empleado.TabIndex = 24
        Me.Btn_empleado.Text = "Empleado"
        Me.Btn_empleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Btn_paciente
        '
        Me.Btn_paciente.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Btn_paciente.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_paciente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_paciente.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_paciente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_paciente.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Btn_paciente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_paciente.ForeColor = System.Drawing.Color.Black
        Me.Btn_paciente.Image = CType(resources.GetObject("Btn_paciente.Image"), System.Drawing.Image)
        Me.Btn_paciente.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Btn_paciente.ImageSize = New System.Drawing.Size(50, 50)
        Me.Btn_paciente.Location = New System.Drawing.Point(3, 162)
        Me.Btn_paciente.Name = "Btn_paciente"
        Me.Btn_paciente.Size = New System.Drawing.Size(244, 55)
        Me.Btn_paciente.TabIndex = 23
        Me.Btn_paciente.Text = "Paciente"
        Me.Btn_paciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 32)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Sistema"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 32)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Hospitalario"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(6, 67)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(59, 73)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 17
        Me.Guna2PictureBox1.TabStop = False
        '
        'Btn_opciones
        '
        Me.Btn_opciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_opciones.Image = CType(resources.GetObject("Btn_opciones.Image"), System.Drawing.Image)
        Me.Btn_opciones.ImageRotate = 0!
        Me.Btn_opciones.Location = New System.Drawing.Point(188, 4)
        Me.Btn_opciones.Name = "Btn_opciones"
        Me.Btn_opciones.Size = New System.Drawing.Size(52, 53)
        Me.Btn_opciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Btn_opciones.TabIndex = 2
        Me.Btn_opciones.TabStop = False
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
        Me.btnCerrarInterfaz.Location = New System.Drawing.Point(1219, 3)
        Me.btnCerrarInterfaz.Name = "btnCerrarInterfaz"
        Me.btnCerrarInterfaz.Size = New System.Drawing.Size(38, 35)
        Me.btnCerrarInterfaz.TabIndex = 13
        Me.btnCerrarInterfaz.Text = "X"
        '
        'Mostrar_opciones
        '
        Me.Mostrar_opciones.Interval = 10
        '
        'Ocultar_opciones
        '
        Me.Ocultar_opciones.Interval = 10
        '
        'Interfaz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1258, 732)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Interfaz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Interfaz"
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Panel_menu.ResumeLayout(False)
        Me.Panel_menu.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_opciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Mostrar_opciones As Timer
    Friend WithEvents Ocultar_opciones As Timer
    Friend WithEvents Panel_opciones As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel_menu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_facturas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_areas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_agregar_atencion As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_empleado As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_paciente As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Btn_opciones As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Btn_consultas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_ver_facturas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCerrarInterfaz As Guna.UI2.WinForms.Guna2Button
End Class
