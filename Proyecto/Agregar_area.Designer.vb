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
        Me.AgregarArea = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.NIVEL = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MINUTOS_FINAL = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.HORA_FINAL = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MINUTOS_INICIO = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.HORA_INICIO = New System.Windows.Forms.ComboBox()
        Me.CANTIDAD_EMPLEADOS = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Btn_agregar_area = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NOMBRE_AREA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Informacion_area = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.BUSQUEDA_AREA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BTN_BORRAR_AREA = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_ACTUALIZAR_AREA = New Guna.UI2.WinForms.Guna2Button()
        Me.L_AREAS = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ACTIVAR_AREA = New Guna.UI2.WinForms.Guna2Button()
        Me.AgregarArea.SuspendLayout()
        CType(Me.CANTIDAD_EMPLEADOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Informacion_area.SuspendLayout()
        Me.SuspendLayout()
        '
        'AgregarArea
        '
        Me.AgregarArea.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.AgregarArea.BorderRadius = 4
        Me.AgregarArea.BorderThickness = 2
        Me.AgregarArea.Controls.Add(Me.NIVEL)
        Me.AgregarArea.Controls.Add(Me.Label8)
        Me.AgregarArea.Controls.Add(Me.MINUTOS_FINAL)
        Me.AgregarArea.Controls.Add(Me.Label9)
        Me.AgregarArea.Controls.Add(Me.HORA_FINAL)
        Me.AgregarArea.Controls.Add(Me.Label7)
        Me.AgregarArea.Controls.Add(Me.MINUTOS_INICIO)
        Me.AgregarArea.Controls.Add(Me.Label6)
        Me.AgregarArea.Controls.Add(Me.HORA_INICIO)
        Me.AgregarArea.Controls.Add(Me.CANTIDAD_EMPLEADOS)
        Me.AgregarArea.Controls.Add(Me.Btn_agregar_area)
        Me.AgregarArea.Controls.Add(Me.Label5)
        Me.AgregarArea.Controls.Add(Me.Label3)
        Me.AgregarArea.Controls.Add(Me.Label4)
        Me.AgregarArea.Controls.Add(Me.Label2)
        Me.AgregarArea.Controls.Add(Me.NOMBRE_AREA)
        Me.AgregarArea.Controls.Add(Me.Label1)
        Me.AgregarArea.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.AgregarArea.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.AgregarArea.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AgregarArea.ForeColor = System.Drawing.Color.White
        Me.AgregarArea.Location = New System.Drawing.Point(3, 342)
        Me.AgregarArea.Name = "AgregarArea"
        Me.AgregarArea.Size = New System.Drawing.Size(984, 341)
        Me.AgregarArea.TabIndex = 0
        Me.AgregarArea.Text = "Agregar área"
        '
        'NIVEL
        '
        Me.NIVEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.NIVEL.Location = New System.Drawing.Point(634, 67)
        Me.NIVEL.Mask = "99999"
        Me.NIVEL.Name = "NIVEL"
        Me.NIVEL.Size = New System.Drawing.Size(201, 23)
        Me.NIVEL.TabIndex = 35
        Me.NIVEL.ValidatingType = GetType(Integer)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(802, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 21)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = ":Minutos"
        '
        'MINUTOS_FINAL
        '
        Me.MINUTOS_FINAL.FormattingEnabled = True
        Me.MINUTOS_FINAL.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.MINUTOS_FINAL.Location = New System.Drawing.Point(748, 195)
        Me.MINUTOS_FINAL.Name = "MINUTOS_FINAL"
        Me.MINUTOS_FINAL.Size = New System.Drawing.Size(53, 23)
        Me.MINUTOS_FINAL.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(688, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 21)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = ":Horas"
        '
        'HORA_FINAL
        '
        Me.HORA_FINAL.FormattingEnabled = True
        Me.HORA_FINAL.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.HORA_FINAL.Location = New System.Drawing.Point(634, 194)
        Me.HORA_FINAL.Name = "HORA_FINAL"
        Me.HORA_FINAL.Size = New System.Drawing.Size(53, 23)
        Me.HORA_FINAL.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(802, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 21)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = ":Minutos"
        '
        'MINUTOS_INICIO
        '
        Me.MINUTOS_INICIO.FormattingEnabled = True
        Me.MINUTOS_INICIO.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.MINUTOS_INICIO.Location = New System.Drawing.Point(748, 131)
        Me.MINUTOS_INICIO.Name = "MINUTOS_INICIO"
        Me.MINUTOS_INICIO.Size = New System.Drawing.Size(53, 23)
        Me.MINUTOS_INICIO.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(688, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 21)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = ":Horas"
        '
        'HORA_INICIO
        '
        Me.HORA_INICIO.FormattingEnabled = True
        Me.HORA_INICIO.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.HORA_INICIO.Location = New System.Drawing.Point(634, 130)
        Me.HORA_INICIO.Name = "HORA_INICIO"
        Me.HORA_INICIO.Size = New System.Drawing.Size(53, 23)
        Me.HORA_INICIO.TabIndex = 27
        '
        'CANTIDAD_EMPLEADOS
        '
        Me.CANTIDAD_EMPLEADOS.BackColor = System.Drawing.Color.Transparent
        Me.CANTIDAD_EMPLEADOS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CANTIDAD_EMPLEADOS.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CANTIDAD_EMPLEADOS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CANTIDAD_EMPLEADOS.ForeColor = System.Drawing.Color.Black
        Me.CANTIDAD_EMPLEADOS.Location = New System.Drawing.Point(233, 129)
        Me.CANTIDAD_EMPLEADOS.Name = "CANTIDAD_EMPLEADOS"
        Me.CANTIDAD_EMPLEADOS.Size = New System.Drawing.Size(211, 33)
        Me.CANTIDAD_EMPLEADOS.TabIndex = 26
        Me.CANTIDAD_EMPLEADOS.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
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
        Me.Btn_agregar_area.Location = New System.Drawing.Point(315, 247)
        Me.Btn_agregar_area.Name = "Btn_agregar_area"
        Me.Btn_agregar_area.Size = New System.Drawing.Size(302, 63)
        Me.Btn_agregar_area.TabIndex = 25
        Me.Btn_agregar_area.Text = "Agregar área"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(516, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 21)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Hora de salida:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(503, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 21)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Hora de entrada:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(51, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Cantidad de empleados:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(579, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 21)
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
        Me.NOMBRE_AREA.Location = New System.Drawing.Point(233, 62)
        Me.NOMBRE_AREA.Name = "NOMBRE_AREA"
        Me.NOMBRE_AREA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NOMBRE_AREA.PlaceholderText = ""
        Me.NOMBRE_AREA.SelectedText = ""
        Me.NOMBRE_AREA.Size = New System.Drawing.Size(211, 33)
        Me.NOMBRE_AREA.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(101, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nombre de área:"
        '
        'Informacion_area
        '
        Me.Informacion_area.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Informacion_area.BorderRadius = 4
        Me.Informacion_area.BorderThickness = 2
        Me.Informacion_area.Controls.Add(Me.ACTIVAR_AREA)
        Me.Informacion_area.Controls.Add(Me.BUSQUEDA_AREA)
        Me.Informacion_area.Controls.Add(Me.Label10)
        Me.Informacion_area.Controls.Add(Me.BTN_BORRAR_AREA)
        Me.Informacion_area.Controls.Add(Me.BTN_ACTUALIZAR_AREA)
        Me.Informacion_area.Controls.Add(Me.L_AREAS)
        Me.Informacion_area.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Informacion_area.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Informacion_area.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Informacion_area.ForeColor = System.Drawing.Color.White
        Me.Informacion_area.Location = New System.Drawing.Point(3, 1)
        Me.Informacion_area.Name = "Informacion_area"
        Me.Informacion_area.Size = New System.Drawing.Size(984, 337)
        Me.Informacion_area.TabIndex = 1
        Me.Informacion_area.Text = "Informacion de áreas"
        '
        'BUSQUEDA_AREA
        '
        Me.BUSQUEDA_AREA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BUSQUEDA_AREA.DefaultText = ""
        Me.BUSQUEDA_AREA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.BUSQUEDA_AREA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BUSQUEDA_AREA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BUSQUEDA_AREA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BUSQUEDA_AREA.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BUSQUEDA_AREA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BUSQUEDA_AREA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BUSQUEDA_AREA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BUSQUEDA_AREA.Location = New System.Drawing.Point(280, 78)
        Me.BUSQUEDA_AREA.Name = "BUSQUEDA_AREA"
        Me.BUSQUEDA_AREA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BUSQUEDA_AREA.PlaceholderText = ""
        Me.BUSQUEDA_AREA.SelectedText = ""
        Me.BUSQUEDA_AREA.Size = New System.Drawing.Size(200, 25)
        Me.BUSQUEDA_AREA.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(176, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 15)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Nombre del área:"
        '
        'BTN_BORRAR_AREA
        '
        Me.BTN_BORRAR_AREA.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_BORRAR_AREA.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_BORRAR_AREA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_BORRAR_AREA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_BORRAR_AREA.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BTN_BORRAR_AREA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_BORRAR_AREA.ForeColor = System.Drawing.Color.White
        Me.BTN_BORRAR_AREA.Location = New System.Drawing.Point(692, 270)
        Me.BTN_BORRAR_AREA.Name = "BTN_BORRAR_AREA"
        Me.BTN_BORRAR_AREA.Size = New System.Drawing.Size(179, 38)
        Me.BTN_BORRAR_AREA.TabIndex = 36
        Me.BTN_BORRAR_AREA.Text = "Borrar área"
        '
        'BTN_ACTUALIZAR_AREA
        '
        Me.BTN_ACTUALIZAR_AREA.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ACTUALIZAR_AREA.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ACTUALIZAR_AREA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_ACTUALIZAR_AREA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_ACTUALIZAR_AREA.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BTN_ACTUALIZAR_AREA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_ACTUALIZAR_AREA.ForeColor = System.Drawing.Color.White
        Me.BTN_ACTUALIZAR_AREA.Location = New System.Drawing.Point(692, 222)
        Me.BTN_ACTUALIZAR_AREA.Name = "BTN_ACTUALIZAR_AREA"
        Me.BTN_ACTUALIZAR_AREA.Size = New System.Drawing.Size(179, 38)
        Me.BTN_ACTUALIZAR_AREA.TabIndex = 35
        Me.BTN_ACTUALIZAR_AREA.Text = "Actualizar área"
        '
        'L_AREAS
        '
        Me.L_AREAS.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.L_AREAS.FullRowSelect = True
        Me.L_AREAS.GridLines = True
        Me.L_AREAS.HideSelection = False
        Me.L_AREAS.Location = New System.Drawing.Point(176, 128)
        Me.L_AREAS.MultiSelect = False
        Me.L_AREAS.Name = "L_AREAS"
        Me.L_AREAS.Size = New System.Drawing.Size(482, 180)
        Me.L_AREAS.TabIndex = 26
        Me.L_AREAS.UseCompatibleStateImageBehavior = False
        Me.L_AREAS.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre área"
        Me.ColumnHeader2.Width = 92
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nivel"
        Me.ColumnHeader3.Width = 67
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Cantidad empleados"
        Me.ColumnHeader4.Width = 129
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Hora entrada"
        Me.ColumnHeader5.Width = 96
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Hora salida"
        Me.ColumnHeader6.Width = 95
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ESTADO"
        Me.ColumnHeader7.Width = 30
        '
        'ACTIVAR_AREA
        '
        Me.ACTIVAR_AREA.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ACTIVAR_AREA.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ACTIVAR_AREA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ACTIVAR_AREA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ACTIVAR_AREA.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ACTIVAR_AREA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ACTIVAR_AREA.ForeColor = System.Drawing.Color.White
        Me.ACTIVAR_AREA.Location = New System.Drawing.Point(692, 191)
        Me.ACTIVAR_AREA.Name = "ACTIVAR_AREA"
        Me.ACTIVAR_AREA.Size = New System.Drawing.Size(179, 25)
        Me.ACTIVAR_AREA.TabIndex = 39
        Me.ACTIVAR_AREA.Text = "Activar área seleccionada"
        Me.ACTIVAR_AREA.Visible = False
        '
        'Agregar_area
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(991, 685)
        Me.ControlBox = False
        Me.Controls.Add(Me.Informacion_area)
        Me.Controls.Add(Me.AgregarArea)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Agregar_area"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar_area"
        Me.AgregarArea.ResumeLayout(False)
        Me.AgregarArea.PerformLayout()
        CType(Me.CANTIDAD_EMPLEADOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Informacion_area.ResumeLayout(False)
        Me.Informacion_area.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AgregarArea As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NOMBRE_AREA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Btn_agregar_area As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CANTIDAD_EMPLEADOS As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Informacion_area As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents MINUTOS_FINAL As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents HORA_FINAL As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents MINUTOS_INICIO As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents HORA_INICIO As ComboBox
    Friend WithEvents L_AREAS As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents BTN_BORRAR_AREA As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_ACTUALIZAR_AREA As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents NIVEL As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents BUSQUEDA_AREA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ACTIVAR_AREA As Guna.UI2.WinForms.Guna2Button
End Class
