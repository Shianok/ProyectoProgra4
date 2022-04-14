<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_facturas
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
        Me.Telefono = New System.Windows.Forms.MaskedTextBox()
        Me.Cedula = New System.Windows.Forms.MaskedTextBox()
        Me.BORRAR_FILA = New Guna.UI2.WinForms.Guna2Button()
        Me.AGREGAR_LIST = New Guna.UI2.WinForms.Guna2Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.AGREGAR = New Guna.UI2.WinForms.Guna2TextBox()
        Me.L = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.COMBO_AREA = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NOMBRE_PACIENTE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Fecha_de_pago = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MONTO_TOTAL = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Nombre_remitente = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Correo_usuario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_realizar_factura = New Guna.UI2.WinForms.Guna2Button()
        Me.MONTO = New System.Windows.Forms.MaskedTextBox()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.MONTO)
        Me.Guna2GroupBox1.Controls.Add(Me.Telefono)
        Me.Guna2GroupBox1.Controls.Add(Me.Cedula)
        Me.Guna2GroupBox1.Controls.Add(Me.BORRAR_FILA)
        Me.Guna2GroupBox1.Controls.Add(Me.AGREGAR_LIST)
        Me.Guna2GroupBox1.Controls.Add(Me.Label11)
        Me.Guna2GroupBox1.Controls.Add(Me.Label10)
        Me.Guna2GroupBox1.Controls.Add(Me.AGREGAR)
        Me.Guna2GroupBox1.Controls.Add(Me.L)
        Me.Guna2GroupBox1.Controls.Add(Me.COMBO_AREA)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.NOMBRE_PACIENTE)
        Me.Guna2GroupBox1.Controls.Add(Me.Fecha_de_pago)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.Label7)
        Me.Guna2GroupBox1.Controls.Add(Me.MONTO_TOTAL)
        Me.Guna2GroupBox1.Controls.Add(Me.Label8)
        Me.Guna2GroupBox1.Controls.Add(Me.Nombre_remitente)
        Me.Guna2GroupBox1.Controls.Add(Me.Label9)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.Label6)
        Me.Guna2GroupBox1.Controls.Add(Me.Correo_usuario)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.Btn_realizar_factura)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(-2, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(997, 688)
        Me.Guna2GroupBox1.TabIndex = 0
        '
        'Telefono
        '
        Me.Telefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Telefono.Location = New System.Drawing.Point(599, 79)
        Me.Telefono.Mask = "99999999"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Size = New System.Drawing.Size(201, 23)
        Me.Telefono.TabIndex = 33
        Me.Telefono.ValidatingType = GetType(Integer)
        '
        'Cedula
        '
        Me.Cedula.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Cedula.Location = New System.Drawing.Point(184, 75)
        Me.Cedula.Mask = "00-0000-0000"
        Me.Cedula.Name = "Cedula"
        Me.Cedula.Size = New System.Drawing.Size(211, 23)
        Me.Cedula.TabIndex = 32
        '
        'BORRAR_FILA
        '
        Me.BORRAR_FILA.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BORRAR_FILA.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BORRAR_FILA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BORRAR_FILA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BORRAR_FILA.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BORRAR_FILA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BORRAR_FILA.ForeColor = System.Drawing.Color.White
        Me.BORRAR_FILA.Location = New System.Drawing.Point(599, 553)
        Me.BORRAR_FILA.Name = "BORRAR_FILA"
        Me.BORRAR_FILA.Size = New System.Drawing.Size(118, 38)
        Me.BORRAR_FILA.TabIndex = 31
        Me.BORRAR_FILA.Text = "Borrar última fila"
        '
        'AGREGAR_LIST
        '
        Me.AGREGAR_LIST.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AGREGAR_LIST.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AGREGAR_LIST.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AGREGAR_LIST.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AGREGAR_LIST.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.AGREGAR_LIST.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AGREGAR_LIST.ForeColor = System.Drawing.Color.White
        Me.AGREGAR_LIST.Location = New System.Drawing.Point(600, 337)
        Me.AGREGAR_LIST.Name = "AGREGAR_LIST"
        Me.AGREGAR_LIST.Size = New System.Drawing.Size(177, 38)
        Me.AGREGAR_LIST.TabIndex = 30
        Me.AGREGAR_LIST.Text = "Agregar al desglose"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(802, 283)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 21)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Monto:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(416, 283)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(178, 21)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Medicamento o servicio:"
        '
        'AGREGAR
        '
        Me.AGREGAR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AGREGAR.DefaultText = ""
        Me.AGREGAR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.AGREGAR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.AGREGAR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AGREGAR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AGREGAR.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.AGREGAR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AGREGAR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AGREGAR.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AGREGAR.Location = New System.Drawing.Point(600, 280)
        Me.AGREGAR.Name = "AGREGAR"
        Me.AGREGAR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AGREGAR.PlaceholderText = ""
        Me.AGREGAR.SelectedText = ""
        Me.AGREGAR.Size = New System.Drawing.Size(196, 31)
        Me.AGREGAR.TabIndex = 26
        '
        'L
        '
        Me.L.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.L.FullRowSelect = True
        Me.L.GridLines = True
        Me.L.HideSelection = False
        Me.L.Location = New System.Drawing.Point(600, 399)
        Me.L.MultiSelect = False
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(376, 136)
        Me.L.TabIndex = 25
        Me.L.UseCompatibleStateImageBehavior = False
        Me.L.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "MEDICAMENTE O SERVICIO"
        Me.ColumnHeader1.Width = 248
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "MONTO"
        Me.ColumnHeader2.Width = 133
        '
        'COMBO_AREA
        '
        Me.COMBO_AREA.BackColor = System.Drawing.Color.Transparent
        Me.COMBO_AREA.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.COMBO_AREA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.COMBO_AREA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COMBO_AREA.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.COMBO_AREA.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.COMBO_AREA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.COMBO_AREA.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.COMBO_AREA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.COMBO_AREA.ItemHeight = 30
        Me.COMBO_AREA.Location = New System.Drawing.Point(184, 371)
        Me.COMBO_AREA.Name = "COMBO_AREA"
        Me.COMBO_AREA.Size = New System.Drawing.Size(200, 36)
        Me.COMBO_AREA.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(436, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 21)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Nombre del paciente:"
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
        Me.NOMBRE_PACIENTE.Location = New System.Drawing.Point(600, 161)
        Me.NOMBRE_PACIENTE.Name = "NOMBRE_PACIENTE"
        Me.NOMBRE_PACIENTE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NOMBRE_PACIENTE.PlaceholderText = ""
        Me.NOMBRE_PACIENTE.SelectedText = ""
        Me.NOMBRE_PACIENTE.Size = New System.Drawing.Size(200, 31)
        Me.NOMBRE_PACIENTE.TabIndex = 22
        '
        'Fecha_de_pago
        '
        Me.Fecha_de_pago.Checked = True
        Me.Fecha_de_pago.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Fecha_de_pago.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Fecha_de_pago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_de_pago.Location = New System.Drawing.Point(184, 271)
        Me.Fecha_de_pago.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Fecha_de_pago.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Fecha_de_pago.Name = "Fecha_de_pago"
        Me.Fecha_de_pago.Size = New System.Drawing.Size(200, 33)
        Me.Fecha_de_pago.TabIndex = 21
        Me.Fecha_de_pago.Value = New Date(2022, 3, 4, 15, 25, 39, 978)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(49, 376)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 21)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Área de atención:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(733, 560)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 21)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Monto total:"
        '
        'MONTO_TOTAL
        '
        Me.MONTO_TOTAL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MONTO_TOTAL.DefaultText = ""
        Me.MONTO_TOTAL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.MONTO_TOTAL.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MONTO_TOTAL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.MONTO_TOTAL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.MONTO_TOTAL.Enabled = False
        Me.MONTO_TOTAL.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.MONTO_TOTAL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MONTO_TOTAL.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MONTO_TOTAL.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MONTO_TOTAL.Location = New System.Drawing.Point(833, 556)
        Me.MONTO_TOTAL.Name = "MONTO_TOTAL"
        Me.MONTO_TOTAL.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MONTO_TOTAL.PlaceholderText = ""
        Me.MONTO_TOTAL.SelectedText = ""
        Me.MONTO_TOTAL.Size = New System.Drawing.Size(143, 31)
        Me.MONTO_TOTAL.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(11, 489)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(167, 21)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Nombre del remitente:"
        '
        'Nombre_remitente
        '
        Me.Nombre_remitente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Nombre_remitente.DefaultText = ""
        Me.Nombre_remitente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Nombre_remitente.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Nombre_remitente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Nombre_remitente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Nombre_remitente.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Nombre_remitente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Nombre_remitente.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Nombre_remitente.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Nombre_remitente.Location = New System.Drawing.Point(184, 485)
        Me.Nombre_remitente.Name = "Nombre_remitente"
        Me.Nombre_remitente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Nombre_remitente.PlaceholderText = ""
        Me.Nombre_remitente.SelectedText = ""
        Me.Nombre_remitente.Size = New System.Drawing.Size(200, 31)
        Me.Nombre_remitente.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(65, 275)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 21)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Fecha de pago:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(483, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Descripción de factura:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(117, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 21)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Correo:"
        '
        'Correo_usuario
        '
        Me.Correo_usuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Correo_usuario.DefaultText = ""
        Me.Correo_usuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Correo_usuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Correo_usuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Correo_usuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Correo_usuario.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Correo_usuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Correo_usuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Correo_usuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Correo_usuario.Location = New System.Drawing.Point(184, 161)
        Me.Correo_usuario.Name = "Correo_usuario"
        Me.Correo_usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Correo_usuario.PlaceholderText = ""
        Me.Correo_usuario.SelectedText = ""
        Me.Correo_usuario.Size = New System.Drawing.Size(200, 31)
        Me.Correo_usuario.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(523, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Teléfono:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(117, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cédula:"
        '
        'Btn_realizar_factura
        '
        Me.Btn_realizar_factura.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_realizar_factura.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_realizar_factura.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_realizar_factura.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_realizar_factura.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Btn_realizar_factura.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btn_realizar_factura.ForeColor = System.Drawing.Color.White
        Me.Btn_realizar_factura.Location = New System.Drawing.Point(383, 621)
        Me.Btn_realizar_factura.Name = "Btn_realizar_factura"
        Me.Btn_realizar_factura.Size = New System.Drawing.Size(267, 44)
        Me.Btn_realizar_factura.TabIndex = 0
        Me.Btn_realizar_factura.Text = "Realizar factura"
        '
        'MONTO
        '
        Me.MONTO.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.MONTO.Location = New System.Drawing.Point(864, 284)
        Me.MONTO.Mask = "99999999999"
        Me.MONTO.Name = "MONTO"
        Me.MONTO.Size = New System.Drawing.Size(109, 23)
        Me.MONTO.TabIndex = 34
        Me.MONTO.ValidatingType = GetType(Integer)
        '
        'Registrar_facturas
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(993, 686)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registrar_facturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar_facturas"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Fecha_de_pago As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents MONTO_TOTAL As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Nombre_remitente As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Correo_usuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_realizar_factura As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents NOMBRE_PACIENTE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents COMBO_AREA As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents L As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents AGREGAR_LIST As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents AGREGAR As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BORRAR_FILA As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Cedula As MaskedTextBox
    Friend WithEvents Telefono As MaskedTextBox
    Friend WithEvents MONTO As MaskedTextBox
End Class
