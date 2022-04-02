<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class REGISTRAR_CONSULTAS
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
        Me.Registrar_consulta = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.AREA_CONSULTA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NUMERO_CONSULTORIO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_agregar_consulta = New Guna.UI2.WinForms.Guna2Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CORREO_CONSULTA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CORREO_PACIENTE = New System.Windows.Forms.Label()
        Me.NUMERO_CONSULTA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NOMBRE_CONSULTA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CEDULA_CONSULTA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FECHA_CONSULTA = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MINUTOS_CONSULTA = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.HORA_CONSULTA = New System.Windows.Forms.ComboBox()
        Me.Registrar_consulta.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Registrar_consulta
        '
        Me.Registrar_consulta.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Registrar_consulta.Controls.Add(Me.Label7)
        Me.Registrar_consulta.Controls.Add(Me.MINUTOS_CONSULTA)
        Me.Registrar_consulta.Controls.Add(Me.Label8)
        Me.Registrar_consulta.Controls.Add(Me.HORA_CONSULTA)
        Me.Registrar_consulta.Controls.Add(Me.FECHA_CONSULTA)
        Me.Registrar_consulta.Controls.Add(Me.Guna2PictureBox1)
        Me.Registrar_consulta.Controls.Add(Me.AREA_CONSULTA)
        Me.Registrar_consulta.Controls.Add(Me.Label5)
        Me.Registrar_consulta.Controls.Add(Me.NUMERO_CONSULTORIO)
        Me.Registrar_consulta.Controls.Add(Me.Label2)
        Me.Registrar_consulta.Controls.Add(Me.Label3)
        Me.Registrar_consulta.Controls.Add(Me.Btn_agregar_consulta)
        Me.Registrar_consulta.Controls.Add(Me.Label10)
        Me.Registrar_consulta.Controls.Add(Me.CORREO_CONSULTA)
        Me.Registrar_consulta.Controls.Add(Me.CORREO_PACIENTE)
        Me.Registrar_consulta.Controls.Add(Me.NUMERO_CONSULTA)
        Me.Registrar_consulta.Controls.Add(Me.Label6)
        Me.Registrar_consulta.Controls.Add(Me.NOMBRE_CONSULTA)
        Me.Registrar_consulta.Controls.Add(Me.Label4)
        Me.Registrar_consulta.Controls.Add(Me.CEDULA_CONSULTA)
        Me.Registrar_consulta.Controls.Add(Me.Label1)
        Me.Registrar_consulta.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Registrar_consulta.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Registrar_consulta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Registrar_consulta.ForeColor = System.Drawing.Color.White
        Me.Registrar_consulta.Location = New System.Drawing.Point(0, 0)
        Me.Registrar_consulta.Name = "Registrar_consulta"
        Me.Registrar_consulta.Size = New System.Drawing.Size(993, 686)
        Me.Registrar_consulta.TabIndex = 0
        Me.Registrar_consulta.Text = "Registrar nueva consulta"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.Proyecto.My.Resources.Resources.Registro_consulta
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(400, 50)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(188, 169)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 48
        Me.Guna2PictureBox1.TabStop = False
        '
        'AREA_CONSULTA
        '
        Me.AREA_CONSULTA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AREA_CONSULTA.DefaultText = ""
        Me.AREA_CONSULTA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.AREA_CONSULTA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.AREA_CONSULTA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AREA_CONSULTA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AREA_CONSULTA.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.AREA_CONSULTA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AREA_CONSULTA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AREA_CONSULTA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AREA_CONSULTA.Location = New System.Drawing.Point(683, 475)
        Me.AREA_CONSULTA.Name = "AREA_CONSULTA"
        Me.AREA_CONSULTA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AREA_CONSULTA.PlaceholderText = ""
        Me.AREA_CONSULTA.SelectedText = ""
        Me.AREA_CONSULTA.Size = New System.Drawing.Size(211, 33)
        Me.AREA_CONSULTA.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(635, 487)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 21)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Area:"
        '
        'NUMERO_CONSULTORIO
        '
        Me.NUMERO_CONSULTORIO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUMERO_CONSULTORIO.DefaultText = ""
        Me.NUMERO_CONSULTORIO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NUMERO_CONSULTORIO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NUMERO_CONSULTORIO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NUMERO_CONSULTORIO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NUMERO_CONSULTORIO.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.NUMERO_CONSULTORIO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NUMERO_CONSULTORIO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUMERO_CONSULTORIO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NUMERO_CONSULTORIO.Location = New System.Drawing.Point(241, 475)
        Me.NUMERO_CONSULTORIO.Name = "NUMERO_CONSULTORIO"
        Me.NUMERO_CONSULTORIO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NUMERO_CONSULTORIO.PlaceholderText = ""
        Me.NUMERO_CONSULTORIO.SelectedText = ""
        Me.NUMERO_CONSULTORIO.Size = New System.Drawing.Size(211, 33)
        Me.NUMERO_CONSULTORIO.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(61, 487)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 21)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Numero de consultorio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(531, 414)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 21)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Hora de la consulta:"
        '
        'Btn_agregar_consulta
        '
        Me.Btn_agregar_consulta.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_agregar_consulta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_agregar_consulta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_agregar_consulta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_agregar_consulta.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Btn_agregar_consulta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btn_agregar_consulta.ForeColor = System.Drawing.Color.White
        Me.Btn_agregar_consulta.Location = New System.Drawing.Point(314, 578)
        Me.Btn_agregar_consulta.Name = "Btn_agregar_consulta"
        Me.Btn_agregar_consulta.Size = New System.Drawing.Size(302, 63)
        Me.Btn_agregar_consulta.TabIndex = 39
        Me.Btn_agregar_consulta.Text = "Agregar consulta"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(83, 414)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 21)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Fecha de la consulta:"
        '
        'CORREO_CONSULTA
        '
        Me.CORREO_CONSULTA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CORREO_CONSULTA.DefaultText = ""
        Me.CORREO_CONSULTA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CORREO_CONSULTA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CORREO_CONSULTA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CORREO_CONSULTA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CORREO_CONSULTA.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CORREO_CONSULTA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CORREO_CONSULTA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CORREO_CONSULTA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CORREO_CONSULTA.Location = New System.Drawing.Point(683, 329)
        Me.CORREO_CONSULTA.Name = "CORREO_CONSULTA"
        Me.CORREO_CONSULTA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CORREO_CONSULTA.PlaceholderText = ""
        Me.CORREO_CONSULTA.SelectedText = ""
        Me.CORREO_CONSULTA.Size = New System.Drawing.Size(211, 33)
        Me.CORREO_CONSULTA.TabIndex = 34
        '
        'CORREO_PACIENTE
        '
        Me.CORREO_PACIENTE.AutoSize = True
        Me.CORREO_PACIENTE.BackColor = System.Drawing.Color.Transparent
        Me.CORREO_PACIENTE.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CORREO_PACIENTE.ForeColor = System.Drawing.Color.Black
        Me.CORREO_PACIENTE.Location = New System.Drawing.Point(616, 341)
        Me.CORREO_PACIENTE.Name = "CORREO_PACIENTE"
        Me.CORREO_PACIENTE.Size = New System.Drawing.Size(61, 21)
        Me.CORREO_PACIENTE.TabIndex = 33
        Me.CORREO_PACIENTE.Text = "Correo:"
        '
        'NUMERO_CONSULTA
        '
        Me.NUMERO_CONSULTA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NUMERO_CONSULTA.DefaultText = ""
        Me.NUMERO_CONSULTA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NUMERO_CONSULTA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NUMERO_CONSULTA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NUMERO_CONSULTA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NUMERO_CONSULTA.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.NUMERO_CONSULTA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NUMERO_CONSULTA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NUMERO_CONSULTA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NUMERO_CONSULTA.Location = New System.Drawing.Point(241, 329)
        Me.NUMERO_CONSULTA.Name = "NUMERO_CONSULTA"
        Me.NUMERO_CONSULTA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NUMERO_CONSULTA.PlaceholderText = ""
        Me.NUMERO_CONSULTA.SelectedText = ""
        Me.NUMERO_CONSULTA.Size = New System.Drawing.Size(211, 33)
        Me.NUMERO_CONSULTA.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(82, 341)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 21)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Número de teléfono:"
        '
        'NOMBRE_CONSULTA
        '
        Me.NOMBRE_CONSULTA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NOMBRE_CONSULTA.DefaultText = ""
        Me.NOMBRE_CONSULTA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NOMBRE_CONSULTA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NOMBRE_CONSULTA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NOMBRE_CONSULTA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NOMBRE_CONSULTA.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.NOMBRE_CONSULTA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NOMBRE_CONSULTA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NOMBRE_CONSULTA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NOMBRE_CONSULTA.Location = New System.Drawing.Point(241, 250)
        Me.NOMBRE_CONSULTA.Name = "NOMBRE_CONSULTA"
        Me.NOMBRE_CONSULTA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NOMBRE_CONSULTA.PlaceholderText = ""
        Me.NOMBRE_CONSULTA.SelectedText = ""
        Me.NOMBRE_CONSULTA.Size = New System.Drawing.Size(211, 33)
        Me.NOMBRE_CONSULTA.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(95, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 21)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Nombre completo:"
        '
        'CEDULA_CONSULTA
        '
        Me.CEDULA_CONSULTA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CEDULA_CONSULTA.DefaultText = ""
        Me.CEDULA_CONSULTA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CEDULA_CONSULTA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CEDULA_CONSULTA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CEDULA_CONSULTA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CEDULA_CONSULTA.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CEDULA_CONSULTA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CEDULA_CONSULTA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CEDULA_CONSULTA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CEDULA_CONSULTA.Location = New System.Drawing.Point(683, 250)
        Me.CEDULA_CONSULTA.Name = "CEDULA_CONSULTA"
        Me.CEDULA_CONSULTA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CEDULA_CONSULTA.PlaceholderText = ""
        Me.CEDULA_CONSULTA.SelectedText = ""
        Me.CEDULA_CONSULTA.Size = New System.Drawing.Size(211, 33)
        Me.CEDULA_CONSULTA.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(616, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 21)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Cédula:"
        '
        'FECHA_CONSULTA
        '
        Me.FECHA_CONSULTA.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FECHA_CONSULTA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FECHA_CONSULTA.Location = New System.Drawing.Point(241, 402)
        Me.FECHA_CONSULTA.Name = "FECHA_CONSULTA"
        Me.FECHA_CONSULTA.Size = New System.Drawing.Size(211, 33)
        Me.FECHA_CONSULTA.TabIndex = 49
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(853, 411)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 21)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = ":Minutos"
        '
        'MINUTOS_CONSULTA
        '
        Me.MINUTOS_CONSULTA.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MINUTOS_CONSULTA.FormattingEnabled = True
        Me.MINUTOS_CONSULTA.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.MINUTOS_CONSULTA.Location = New System.Drawing.Point(798, 401)
        Me.MINUTOS_CONSULTA.Name = "MINUTOS_CONSULTA"
        Me.MINUTOS_CONSULTA.Size = New System.Drawing.Size(53, 33)
        Me.MINUTOS_CONSULTA.TabIndex = 80
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(738, 411)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 21)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = ":Horas"
        '
        'HORA_CONSULTA
        '
        Me.HORA_CONSULTA.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HORA_CONSULTA.FormattingEnabled = True
        Me.HORA_CONSULTA.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.HORA_CONSULTA.Location = New System.Drawing.Point(683, 402)
        Me.HORA_CONSULTA.Name = "HORA_CONSULTA"
        Me.HORA_CONSULTA.Size = New System.Drawing.Size(53, 33)
        Me.HORA_CONSULTA.TabIndex = 78
        '
        'REGISTRAR_CONSULTAS
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(993, 686)
        Me.ControlBox = False
        Me.Controls.Add(Me.Registrar_consulta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "REGISTRAR_CONSULTAS"
        Me.Text = "REGISTRAR_CONSULTAS"
        Me.Registrar_consulta.ResumeLayout(False)
        Me.Registrar_consulta.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Registrar_consulta As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Btn_agregar_consulta As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label10 As Label
    Friend WithEvents CORREO_CONSULTA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CORREO_PACIENTE As Label
    Friend WithEvents NUMERO_CONSULTA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents NOMBRE_CONSULTA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CEDULA_CONSULTA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AREA_CONSULTA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NUMERO_CONSULTORIO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents FECHA_CONSULTA As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents MINUTOS_CONSULTA As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents HORA_CONSULTA As ComboBox
End Class
