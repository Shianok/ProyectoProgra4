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
        Me.Btn_agregar_tipo_empleado = New Guna.UI2.WinForms.Guna2Button()
        Me.NUMERO_CARNET = New System.Windows.Forms.MaskedTextBox()
        Me.NUMERO_TELEFONO = New System.Windows.Forms.MaskedTextBox()
        Me.CEDULA = New System.Windows.Forms.MaskedTextBox()
        Me.RESIDENCIA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BTN_CerrarInterfaz = New Guna.UI2.WinForms.Guna2Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.IMG_EMPLEADO = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.COREO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Btn_agregar_empleado = New Guna.UI2.WinForms.Guna2Button()
        Me.TIPO_EMPLEADO = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TIPO_AREA = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.FECHA_NACIMIENTO = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CONTRASENA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NOMBRE_COMPLETO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Abrir = New System.Windows.Forms.OpenFileDialog()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.IMG_EMPLEADO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.Btn_agregar_tipo_empleado)
        Me.Guna2GroupBox1.Controls.Add(Me.NUMERO_CARNET)
        Me.Guna2GroupBox1.Controls.Add(Me.NUMERO_TELEFONO)
        Me.Guna2GroupBox1.Controls.Add(Me.CEDULA)
        Me.Guna2GroupBox1.Controls.Add(Me.RESIDENCIA)
        Me.Guna2GroupBox1.Controls.Add(Me.Label12)
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_CerrarInterfaz)
        Me.Guna2GroupBox1.Controls.Add(Me.Label9)
        Me.Guna2GroupBox1.Controls.Add(Me.IMG_EMPLEADO)
        Me.Guna2GroupBox1.Controls.Add(Me.COREO)
        Me.Guna2GroupBox1.Controls.Add(Me.Label11)
        Me.Guna2GroupBox1.Controls.Add(Me.Btn_agregar_empleado)
        Me.Guna2GroupBox1.Controls.Add(Me.TIPO_EMPLEADO)
        Me.Guna2GroupBox1.Controls.Add(Me.TIPO_AREA)
        Me.Guna2GroupBox1.Controls.Add(Me.FECHA_NACIMIENTO)
        Me.Guna2GroupBox1.Controls.Add(Me.Label10)
        Me.Guna2GroupBox1.Controls.Add(Me.Label7)
        Me.Guna2GroupBox1.Controls.Add(Me.Label8)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.Label6)
        Me.Guna2GroupBox1.Controls.Add(Me.CONTRASENA)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.NOMBRE_COMPLETO)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(-1, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(995, 690)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "Agregar empleados"
        '
        'Btn_agregar_tipo_empleado
        '
        Me.Btn_agregar_tipo_empleado.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_agregar_tipo_empleado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_agregar_tipo_empleado.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_agregar_tipo_empleado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_agregar_tipo_empleado.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Btn_agregar_tipo_empleado.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btn_agregar_tipo_empleado.ForeColor = System.Drawing.Color.White
        Me.Btn_agregar_tipo_empleado.Location = New System.Drawing.Point(234, 569)
        Me.Btn_agregar_tipo_empleado.Name = "Btn_agregar_tipo_empleado"
        Me.Btn_agregar_tipo_empleado.Size = New System.Drawing.Size(180, 26)
        Me.Btn_agregar_tipo_empleado.TabIndex = 34
        Me.Btn_agregar_tipo_empleado.Text = "Agregar_tipo_empleado"
        '
        'NUMERO_CARNET
        '
        Me.NUMERO_CARNET.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.NUMERO_CARNET.Location = New System.Drawing.Point(675, 470)
        Me.NUMERO_CARNET.Mask = "9999999999"
        Me.NUMERO_CARNET.Name = "NUMERO_CARNET"
        Me.NUMERO_CARNET.Size = New System.Drawing.Size(211, 23)
        Me.NUMERO_CARNET.TabIndex = 33
        Me.NUMERO_CARNET.ValidatingType = GetType(Integer)
        '
        'NUMERO_TELEFONO
        '
        Me.NUMERO_TELEFONO.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.NUMERO_TELEFONO.Location = New System.Drawing.Point(234, 415)
        Me.NUMERO_TELEFONO.Mask = "99999999"
        Me.NUMERO_TELEFONO.Name = "NUMERO_TELEFONO"
        Me.NUMERO_TELEFONO.Size = New System.Drawing.Size(211, 23)
        Me.NUMERO_TELEFONO.TabIndex = 32
        Me.NUMERO_TELEFONO.ValidatingType = GetType(Integer)
        '
        'CEDULA
        '
        Me.CEDULA.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CEDULA.Location = New System.Drawing.Point(234, 313)
        Me.CEDULA.Mask = "00-0000-0000"
        Me.CEDULA.Name = "CEDULA"
        Me.CEDULA.Size = New System.Drawing.Size(211, 23)
        Me.CEDULA.TabIndex = 31
        '
        'RESIDENCIA
        '
        Me.RESIDENCIA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RESIDENCIA.DefaultText = ""
        Me.RESIDENCIA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.RESIDENCIA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.RESIDENCIA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.RESIDENCIA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.RESIDENCIA.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.RESIDENCIA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RESIDENCIA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RESIDENCIA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RESIDENCIA.Location = New System.Drawing.Point(675, 307)
        Me.RESIDENCIA.Name = "RESIDENCIA"
        Me.RESIDENCIA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RESIDENCIA.PlaceholderText = ""
        Me.RESIDENCIA.SelectedText = ""
        Me.RESIDENCIA.Size = New System.Drawing.Size(211, 29)
        Me.RESIDENCIA.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(521, 309)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(148, 21)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Lugar de residencia:"
        '
        'BTN_CerrarInterfaz
        '
        Me.BTN_CerrarInterfaz.BackColor = System.Drawing.Color.Transparent
        Me.BTN_CerrarInterfaz.BorderRadius = 2
        Me.BTN_CerrarInterfaz.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_CerrarInterfaz.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_CerrarInterfaz.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_CerrarInterfaz.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_CerrarInterfaz.FillColor = System.Drawing.Color.Red
        Me.BTN_CerrarInterfaz.FocusedColor = System.Drawing.Color.Maroon
        Me.BTN_CerrarInterfaz.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_CerrarInterfaz.ForeColor = System.Drawing.Color.White
        Me.BTN_CerrarInterfaz.Location = New System.Drawing.Point(948, 2)
        Me.BTN_CerrarInterfaz.Name = "BTN_CerrarInterfaz"
        Me.BTN_CerrarInterfaz.Size = New System.Drawing.Size(38, 35)
        Me.BTN_CerrarInterfaz.TabIndex = 15
        Me.BTN_CerrarInterfaz.Text = "X"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Gray
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(406, 255)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(189, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Click para agregar o cambiar imagen"
        '
        'IMG_EMPLEADO
        '
        Me.IMG_EMPLEADO.BackColor = System.Drawing.Color.Transparent
        Me.IMG_EMPLEADO.Image = Global.Proyecto.My.Resources.Resources.user
        Me.IMG_EMPLEADO.ImageRotate = 0!
        Me.IMG_EMPLEADO.Location = New System.Drawing.Point(388, 55)
        Me.IMG_EMPLEADO.Name = "IMG_EMPLEADO"
        Me.IMG_EMPLEADO.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.IMG_EMPLEADO.Size = New System.Drawing.Size(224, 213)
        Me.IMG_EMPLEADO.TabIndex = 27
        Me.IMG_EMPLEADO.TabStop = False
        Me.IMG_EMPLEADO.UseTransparentBackground = True
        '
        'COREO
        '
        Me.COREO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.COREO.DefaultText = ""
        Me.COREO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.COREO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.COREO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.COREO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.COREO.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.COREO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.COREO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.COREO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.COREO.Location = New System.Drawing.Point(675, 411)
        Me.COREO.Name = "COREO"
        Me.COREO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.COREO.PlaceholderText = ""
        Me.COREO.SelectedText = ""
        Me.COREO.Size = New System.Drawing.Size(211, 29)
        Me.COREO.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(608, 412)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 21)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Correo:"
        '
        'Btn_agregar_empleado
        '
        Me.Btn_agregar_empleado.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_agregar_empleado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_agregar_empleado.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_agregar_empleado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_agregar_empleado.Enabled = False
        Me.Btn_agregar_empleado.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Btn_agregar_empleado.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btn_agregar_empleado.ForeColor = System.Drawing.Color.White
        Me.Btn_agregar_empleado.Location = New System.Drawing.Point(450, 584)
        Me.Btn_agregar_empleado.Name = "Btn_agregar_empleado"
        Me.Btn_agregar_empleado.Size = New System.Drawing.Size(244, 47)
        Me.Btn_agregar_empleado.TabIndex = 24
        Me.Btn_agregar_empleado.Text = "Agregar empleado"
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
        Me.TIPO_EMPLEADO.Items.AddRange(New Object() {"Puto"})
        Me.TIPO_EMPLEADO.Location = New System.Drawing.Point(234, 526)
        Me.TIPO_EMPLEADO.Name = "TIPO_EMPLEADO"
        Me.TIPO_EMPLEADO.Size = New System.Drawing.Size(211, 36)
        Me.TIPO_EMPLEADO.TabIndex = 23
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
        Me.TIPO_AREA.Items.AddRange(New Object() {""})
        Me.TIPO_AREA.Location = New System.Drawing.Point(675, 526)
        Me.TIPO_AREA.Name = "TIPO_AREA"
        Me.TIPO_AREA.Size = New System.Drawing.Size(211, 36)
        Me.TIPO_AREA.TabIndex = 22
        '
        'FECHA_NACIMIENTO
        '
        Me.FECHA_NACIMIENTO.Checked = True
        Me.FECHA_NACIMIENTO.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.FECHA_NACIMIENTO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FECHA_NACIMIENTO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FECHA_NACIMIENTO.Location = New System.Drawing.Point(234, 469)
        Me.FECHA_NACIMIENTO.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.FECHA_NACIMIENTO.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.FECHA_NACIMIENTO.Name = "FECHA_NACIMIENTO"
        Me.FECHA_NACIMIENTO.Size = New System.Drawing.Size(211, 29)
        Me.FECHA_NACIMIENTO.TabIndex = 21
        Me.FECHA_NACIMIENTO.Value = New Date(2022, 3, 8, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(73, 470)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(155, 21)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Fecha de nacimiento:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(624, 533)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 21)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Área:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(92, 534)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 21)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Tipo de empleado:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(530, 469)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 21)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Número de carnet:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(75, 413)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 21)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Número de teléfono:"
        '
        'CONTRASENA
        '
        Me.CONTRASENA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CONTRASENA.DefaultText = ""
        Me.CONTRASENA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CONTRASENA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CONTRASENA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CONTRASENA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CONTRASENA.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CONTRASENA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CONTRASENA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CONTRASENA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CONTRASENA.Location = New System.Drawing.Point(675, 359)
        Me.CONTRASENA.Name = "CONTRASENA"
        Me.CONTRASENA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.CONTRASENA.PlaceholderText = ""
        Me.CONTRASENA.SelectedText = ""
        Me.CONTRASENA.Size = New System.Drawing.Size(211, 29)
        Me.CONTRASENA.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(577, 360)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 21)
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
        Me.NOMBRE_COMPLETO.Location = New System.Drawing.Point(234, 359)
        Me.NOMBRE_COMPLETO.Name = "NOMBRE_COMPLETO"
        Me.NOMBRE_COMPLETO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NOMBRE_COMPLETO.PlaceholderText = ""
        Me.NOMBRE_COMPLETO.SelectedText = ""
        Me.NOMBRE_COMPLETO.Size = New System.Drawing.Size(211, 29)
        Me.NOMBRE_COMPLETO.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(88, 361)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nombre completo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(167, 312)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cédula:"
        '
        'Abrir
        '
        Me.Abrir.FileName = "OpenFileDialog1"
        '
        'Agregar_empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(989, 686)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Agregar_empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar_empleados"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.IMG_EMPLEADO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents TIPO_EMPLEADO As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TIPO_AREA As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents FECHA_NACIMIENTO As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CONTRASENA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NOMBRE_COMPLETO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Btn_agregar_empleado As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents COREO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents IMG_EMPLEADO As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents BTN_CerrarInterfaz As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RESIDENCIA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Abrir As OpenFileDialog
    Friend WithEvents CEDULA As MaskedTextBox
    Friend WithEvents NUMERO_CARNET As MaskedTextBox
    Friend WithEvents NUMERO_TELEFONO As MaskedTextBox
    Friend WithEvents Btn_agregar_tipo_empleado As Guna.UI2.WinForms.Guna2Button
End Class
