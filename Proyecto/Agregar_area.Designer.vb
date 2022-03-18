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
        Me.CANTIDAD_EMPLEADOS = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Btn_agregar_area = New Guna.UI2.WinForms.Guna2Button()
        Me.HORA_SALIDA = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NIVEL = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NOMBRE_AREA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Informacion_area = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.List_infoAreas = New System.Windows.Forms.ListView()
        Me.ColumnHeader0 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Info_areas = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.HORA_ENTRADA = New Guna.UI2.WinForms.Guna2DateTimePicker()
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
        Me.AgregarArea.Controls.Add(Me.CANTIDAD_EMPLEADOS)
        Me.AgregarArea.Controls.Add(Me.Btn_agregar_area)
        Me.AgregarArea.Controls.Add(Me.HORA_SALIDA)
        Me.AgregarArea.Controls.Add(Me.Label5)
        Me.AgregarArea.Controls.Add(Me.HORA_ENTRADA)
        Me.AgregarArea.Controls.Add(Me.Label3)
        Me.AgregarArea.Controls.Add(Me.Label4)
        Me.AgregarArea.Controls.Add(Me.NIVEL)
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
        'HORA_SALIDA
        '
        Me.HORA_SALIDA.Checked = True
        Me.HORA_SALIDA.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.HORA_SALIDA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.HORA_SALIDA.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.HORA_SALIDA.Location = New System.Drawing.Point(634, 181)
        Me.HORA_SALIDA.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.HORA_SALIDA.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.HORA_SALIDA.Name = "HORA_SALIDA"
        Me.HORA_SALIDA.Size = New System.Drawing.Size(211, 33)
        Me.HORA_SALIDA.TabIndex = 24
        Me.HORA_SALIDA.Value = New Date(2022, 3, 8, 18, 42, 13, 222)
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
        Me.Label4.Location = New System.Drawing.Point(51, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Cantidad de empleados:"
        '
        'NIVEL
        '
        Me.NIVEL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NIVEL.DefaultText = ""
        Me.NIVEL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NIVEL.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NIVEL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NIVEL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NIVEL.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.NIVEL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NIVEL.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NIVEL.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NIVEL.Location = New System.Drawing.Point(634, 62)
        Me.NIVEL.Name = "NIVEL"
        Me.NIVEL.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NIVEL.PlaceholderText = ""
        Me.NIVEL.SelectedText = ""
        Me.NIVEL.Size = New System.Drawing.Size(211, 33)
        Me.NIVEL.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(579, 74)
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
        Me.Label1.Location = New System.Drawing.Point(101, 74)
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
        Me.Informacion_area.Controls.Add(Me.List_infoAreas)
        Me.Informacion_area.Controls.Add(Me.Guna2Button1)
        Me.Informacion_area.Controls.Add(Me.Info_areas)
        Me.Informacion_area.Controls.Add(Me.Label10)
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
        'List_infoAreas
        '
        Me.List_infoAreas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.List_infoAreas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader0, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.List_infoAreas.GridLines = True
        Me.List_infoAreas.HideSelection = False
        Me.List_infoAreas.Location = New System.Drawing.Point(32, 133)
        Me.List_infoAreas.Name = "List_infoAreas"
        Me.List_infoAreas.Size = New System.Drawing.Size(916, 171)
        Me.List_infoAreas.TabIndex = 26
        Me.List_infoAreas.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader0
        '
        Me.ColumnHeader0.Text = "ID"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "AREA"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "NIVEL"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "CANTIDAD DE EMPLEADOS"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "HORARIO"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(806, 69)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(121, 33)
        Me.Guna2Button1.TabIndex = 25
        Me.Guna2Button1.Text = "Buscar área"
        '
        'Info_areas
        '
        Me.Info_areas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Info_areas.DefaultText = ""
        Me.Info_areas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Info_areas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Info_areas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Info_areas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Info_areas.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Info_areas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Info_areas.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Info_areas.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Info_areas.Location = New System.Drawing.Point(532, 69)
        Me.Info_areas.Name = "Info_areas"
        Me.Info_areas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Info_areas.PlaceholderText = ""
        Me.Info_areas.SelectedText = ""
        Me.Info_areas.Size = New System.Drawing.Size(211, 33)
        Me.Info_areas.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(433, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 21)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Buscar área:"
        '
        'HORA_ENTRADA
        '
        Me.HORA_ENTRADA.Checked = True
        Me.HORA_ENTRADA.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.HORA_ENTRADA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.HORA_ENTRADA.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.HORA_ENTRADA.Location = New System.Drawing.Point(634, 117)
        Me.HORA_ENTRADA.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.HORA_ENTRADA.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.HORA_ENTRADA.Name = "HORA_ENTRADA"
        Me.HORA_ENTRADA.Size = New System.Drawing.Size(211, 33)
        Me.HORA_ENTRADA.TabIndex = 22
        Me.HORA_ENTRADA.Value = New Date(2022, 3, 8, 18, 42, 13, 222)
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
    Friend WithEvents NIVEL As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NOMBRE_AREA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents HORA_SALIDA As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Btn_agregar_area As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CANTIDAD_EMPLEADOS As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Informacion_area As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Info_areas As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents List_infoAreas As ListView
    Friend WithEvents ColumnHeader0 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents HORA_ENTRADA As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
