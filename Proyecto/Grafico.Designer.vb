<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grafico
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Reiniciar_grafico = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChartDiagnosticos = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Mostrar_grafico = New Guna.UI2.WinForms.Guna2Button()
        Me.ComboDato = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.ComboTabla = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2GroupBox3 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.CANTI_FACTURAS = New System.Windows.Forms.Label()
        Me.Guna2GroupBox5 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.EMPLEADOS_ACTIVOS = New System.Windows.Forms.Label()
        Me.Guna2GroupBox4 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.CANTI_CONSULTAS = New System.Windows.Forms.Label()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.PacientesActivos = New System.Windows.Forms.Label()
        Me.Pacientes = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.ChartDiagnosticos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox3.SuspendLayout()
        Me.Guna2GroupBox5.SuspendLayout()
        Me.Guna2GroupBox4.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox1.Controls.Add(Me.Reiniciar_grafico)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.ChartDiagnosticos)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button2)
        Me.Guna2GroupBox1.Controls.Add(Me.Mostrar_grafico)
        Me.Guna2GroupBox1.Controls.Add(Me.ComboDato)
        Me.Guna2GroupBox1.Controls.Add(Me.ComboTabla)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2GroupBox3)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2GroupBox5)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2GroupBox4)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2GroupBox2)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, -1)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(994, 686)
        Me.Guna2GroupBox1.TabIndex = 11
        Me.Guna2GroupBox1.Text = "Reportes"
        '
        'Reiniciar_grafico
        '
        Me.Reiniciar_grafico.BackColor = System.Drawing.Color.Transparent
        Me.Reiniciar_grafico.BorderRadius = 5
        Me.Reiniciar_grafico.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Reiniciar_grafico.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Reiniciar_grafico.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Reiniciar_grafico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Reiniciar_grafico.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Reiniciar_grafico.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Reiniciar_grafico.ForeColor = System.Drawing.Color.White
        Me.Reiniciar_grafico.Location = New System.Drawing.Point(490, 513)
        Me.Reiniciar_grafico.Name = "Reiniciar_grafico"
        Me.Reiniciar_grafico.Size = New System.Drawing.Size(148, 59)
        Me.Reiniciar_grafico.TabIndex = 11
        Me.Reiniciar_grafico.Text = "Reiniciar Grafico"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(623, 390)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 32)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Datos de:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(623, 275)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 32)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Buscar en:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChartDiagnosticos
        '
        Me.ChartDiagnosticos.BackColor = System.Drawing.Color.Transparent
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.ChartDiagnosticos.ChartAreas.Add(ChartArea1)
        Legend1.BackColor = System.Drawing.Color.Transparent
        Legend1.Name = "Legend1"
        Me.ChartDiagnosticos.Legends.Add(Legend1)
        Me.ChartDiagnosticos.Location = New System.Drawing.Point(45, 248)
        Me.ChartDiagnosticos.Name = "ChartDiagnosticos"
        Me.ChartDiagnosticos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.IsXValueIndexed = True
        Series1.LabelBackColor = System.Drawing.Color.Transparent
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.ChartDiagnosticos.Series.Add(Series1)
        Me.ChartDiagnosticos.Size = New System.Drawing.Size(465, 394)
        Me.ChartDiagnosticos.TabIndex = 8
        Me.ChartDiagnosticos.Text = "Chart1"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.BorderRadius = 5
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(824, 513)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(148, 59)
        Me.Guna2Button2.TabIndex = 7
        Me.Guna2Button2.Text = "Imprimir Reporte"
        '
        'Mostrar_grafico
        '
        Me.Mostrar_grafico.BackColor = System.Drawing.Color.Transparent
        Me.Mostrar_grafico.BorderRadius = 5
        Me.Mostrar_grafico.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Mostrar_grafico.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Mostrar_grafico.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Mostrar_grafico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Mostrar_grafico.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Mostrar_grafico.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Mostrar_grafico.ForeColor = System.Drawing.Color.White
        Me.Mostrar_grafico.Location = New System.Drawing.Point(658, 513)
        Me.Mostrar_grafico.Name = "Mostrar_grafico"
        Me.Mostrar_grafico.Size = New System.Drawing.Size(148, 59)
        Me.Mostrar_grafico.TabIndex = 6
        Me.Mostrar_grafico.Text = "Mostrar Grafico"
        '
        'ComboDato
        '
        Me.ComboDato.BackColor = System.Drawing.Color.Transparent
        Me.ComboDato.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboDato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboDato.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboDato.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboDato.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ComboDato.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ComboDato.ItemHeight = 30
        Me.ComboDato.Location = New System.Drawing.Point(629, 425)
        Me.ComboDato.Name = "ComboDato"
        Me.ComboDato.Size = New System.Drawing.Size(235, 36)
        Me.ComboDato.TabIndex = 5
        '
        'ComboTabla
        '
        Me.ComboTabla.BackColor = System.Drawing.Color.Transparent
        Me.ComboTabla.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboTabla.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboTabla.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboTabla.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ComboTabla.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ComboTabla.ItemHeight = 30
        Me.ComboTabla.Items.AddRange(New Object() {"Paciente", "Atencion", "Facturas", "Empleado"})
        Me.ComboTabla.Location = New System.Drawing.Point(629, 310)
        Me.ComboTabla.Name = "ComboTabla"
        Me.ComboTabla.Size = New System.Drawing.Size(235, 36)
        Me.ComboTabla.TabIndex = 4
        '
        'Guna2GroupBox3
        '
        Me.Guna2GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox3.BorderRadius = 5
        Me.Guna2GroupBox3.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.Guna2GroupBox3.BorderThickness = 4
        Me.Guna2GroupBox3.Controls.Add(Me.CANTI_FACTURAS)
        Me.Guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox3.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox3.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox3.Location = New System.Drawing.Point(727, 76)
        Me.Guna2GroupBox3.Name = "Guna2GroupBox3"
        Me.Guna2GroupBox3.Size = New System.Drawing.Size(176, 107)
        Me.Guna2GroupBox3.TabIndex = 3
        Me.Guna2GroupBox3.Text = "Cantidad de facturas"
        '
        'CANTI_FACTURAS
        '
        Me.CANTI_FACTURAS.AutoSize = True
        Me.CANTI_FACTURAS.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANTI_FACTURAS.ForeColor = System.Drawing.Color.White
        Me.CANTI_FACTURAS.Location = New System.Drawing.Point(51, 53)
        Me.CANTI_FACTURAS.Name = "CANTI_FACTURAS"
        Me.CANTI_FACTURAS.Size = New System.Drawing.Size(84, 32)
        Me.CANTI_FACTURAS.TabIndex = 4
        Me.CANTI_FACTURAS.Text = "Label1"
        Me.CANTI_FACTURAS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2GroupBox5
        '
        Me.Guna2GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox5.BorderRadius = 5
        Me.Guna2GroupBox5.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.Guna2GroupBox5.BorderThickness = 4
        Me.Guna2GroupBox5.Controls.Add(Me.EMPLEADOS_ACTIVOS)
        Me.Guna2GroupBox5.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox5.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2GroupBox5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox5.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox5.Location = New System.Drawing.Point(509, 76)
        Me.Guna2GroupBox5.Name = "Guna2GroupBox5"
        Me.Guna2GroupBox5.Size = New System.Drawing.Size(176, 107)
        Me.Guna2GroupBox5.TabIndex = 3
        Me.Guna2GroupBox5.Text = "Empleados activos"
        '
        'EMPLEADOS_ACTIVOS
        '
        Me.EMPLEADOS_ACTIVOS.AutoSize = True
        Me.EMPLEADOS_ACTIVOS.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMPLEADOS_ACTIVOS.ForeColor = System.Drawing.Color.White
        Me.EMPLEADOS_ACTIVOS.Location = New System.Drawing.Point(48, 54)
        Me.EMPLEADOS_ACTIVOS.Name = "EMPLEADOS_ACTIVOS"
        Me.EMPLEADOS_ACTIVOS.Size = New System.Drawing.Size(84, 32)
        Me.EMPLEADOS_ACTIVOS.TabIndex = 3
        Me.EMPLEADOS_ACTIVOS.Text = "Label1"
        Me.EMPLEADOS_ACTIVOS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2GroupBox4
        '
        Me.Guna2GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox4.BorderRadius = 5
        Me.Guna2GroupBox4.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.Guna2GroupBox4.BorderThickness = 4
        Me.Guna2GroupBox4.Controls.Add(Me.CANTI_CONSULTAS)
        Me.Guna2GroupBox4.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox4.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox4.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox4.Location = New System.Drawing.Point(293, 76)
        Me.Guna2GroupBox4.Name = "Guna2GroupBox4"
        Me.Guna2GroupBox4.Size = New System.Drawing.Size(176, 107)
        Me.Guna2GroupBox4.TabIndex = 3
        Me.Guna2GroupBox4.Text = "Cantidad de consultas"
        '
        'CANTI_CONSULTAS
        '
        Me.CANTI_CONSULTAS.AutoSize = True
        Me.CANTI_CONSULTAS.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CANTI_CONSULTAS.ForeColor = System.Drawing.Color.White
        Me.CANTI_CONSULTAS.Location = New System.Drawing.Point(47, 54)
        Me.CANTI_CONSULTAS.Name = "CANTI_CONSULTAS"
        Me.CANTI_CONSULTAS.Size = New System.Drawing.Size(84, 32)
        Me.CANTI_CONSULTAS.TabIndex = 2
        Me.CANTI_CONSULTAS.Text = "Label1"
        Me.CANTI_CONSULTAS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox2.BorderRadius = 5
        Me.Guna2GroupBox2.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.Guna2GroupBox2.BorderThickness = 4
        Me.Guna2GroupBox2.Controls.Add(Me.PacientesActivos)
        Me.Guna2GroupBox2.Controls.Add(Me.Pacientes)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(76, 76)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(176, 107)
        Me.Guna2GroupBox2.TabIndex = 2
        Me.Guna2GroupBox2.Text = "Pacientes activos"
        '
        'PacientesActivos
        '
        Me.PacientesActivos.AutoSize = True
        Me.PacientesActivos.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacientesActivos.ForeColor = System.Drawing.Color.White
        Me.PacientesActivos.Location = New System.Drawing.Point(44, 54)
        Me.PacientesActivos.Name = "PacientesActivos"
        Me.PacientesActivos.Size = New System.Drawing.Size(84, 32)
        Me.PacientesActivos.TabIndex = 1
        Me.PacientesActivos.Text = "Label1"
        Me.PacientesActivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pacientes
        '
        Me.Pacientes.AutoSize = True
        Me.Pacientes.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pacientes.Location = New System.Drawing.Point(22, 53)
        Me.Pacientes.Name = "Pacientes"
        Me.Pacientes.Size = New System.Drawing.Size(0, 25)
        Me.Pacientes.TabIndex = 0
        '
        'Grafico
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(994, 686)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Grafico"
        Me.Text = "Grafico"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.ChartDiagnosticos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox3.ResumeLayout(False)
        Me.Guna2GroupBox3.PerformLayout()
        Me.Guna2GroupBox5.ResumeLayout(False)
        Me.Guna2GroupBox5.PerformLayout()
        Me.Guna2GroupBox4.ResumeLayout(False)
        Me.Guna2GroupBox4.PerformLayout()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Mostrar_grafico As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ComboDato As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents ComboTabla As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2GroupBox3 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2GroupBox5 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2GroupBox4 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents ChartDiagnosticos As DataVisualization.Charting.Chart
    Friend WithEvents Pacientes As Label
    Friend WithEvents PacientesActivos As Label
    Friend WithEvents CANTI_FACTURAS As Label
    Friend WithEvents EMPLEADOS_ACTIVOS As Label
    Friend WithEvents CANTI_CONSULTAS As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Reiniciar_grafico As Guna.UI2.WinForms.Guna2Button
End Class
