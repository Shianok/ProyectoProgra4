﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.ChartDiagnosticos = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ComboBox2 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2GroupBox3 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2GroupBox5 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2GroupBox4 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.PacientesActivos = New System.Windows.Forms.Label()
        Me.Pacientes = New System.Windows.Forms.Label()
        Me.CANTI_CONSULTAS = New System.Windows.Forms.Label()
        Me.EMPLEADOS_ACTIVOS = New System.Windows.Forms.Label()
        Me.CANTI_FACTURAS = New System.Windows.Forms.Label()
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
        Me.Guna2GroupBox1.Controls.Add(Me.ChartDiagnosticos)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button2)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button1)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2ComboBox2)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2ComboBox1)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2GroupBox3)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2GroupBox5)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2GroupBox4)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2GroupBox2)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, -1)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(994, 686)
        Me.Guna2GroupBox1.TabIndex = 11
        Me.Guna2GroupBox1.Text = "Reportes"
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
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(768, 507)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(148, 59)
        Me.Guna2Button2.TabIndex = 7
        Me.Guna2Button2.Text = "Imprimir Reporte"
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
        Me.Guna2Button1.Location = New System.Drawing.Point(594, 507)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(148, 59)
        Me.Guna2Button1.TabIndex = 6
        Me.Guna2Button1.Text = "Mostrar Grafico"
        '
        'Guna2ComboBox2
        '
        Me.Guna2ComboBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox2.ItemHeight = 30
        Me.Guna2ComboBox2.Location = New System.Drawing.Point(629, 425)
        Me.Guna2ComboBox2.Name = "Guna2ComboBox2"
        Me.Guna2ComboBox2.Size = New System.Drawing.Size(235, 36)
        Me.Guna2ComboBox2.TabIndex = 5
        '
        'Guna2ComboBox1
        '
        Me.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox1.ItemHeight = 30
        Me.Guna2ComboBox1.Location = New System.Drawing.Point(629, 310)
        Me.Guna2ComboBox1.Name = "Guna2ComboBox1"
        Me.Guna2ComboBox1.Size = New System.Drawing.Size(235, 36)
        Me.Guna2ComboBox1.TabIndex = 4
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
        Me.Guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox3.Location = New System.Drawing.Point(727, 76)
        Me.Guna2GroupBox3.Name = "Guna2GroupBox3"
        Me.Guna2GroupBox3.Size = New System.Drawing.Size(176, 107)
        Me.Guna2GroupBox3.TabIndex = 3
        Me.Guna2GroupBox3.Text = "Cantidad de facturas"
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
        Me.Guna2GroupBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox5.Location = New System.Drawing.Point(509, 76)
        Me.Guna2GroupBox5.Name = "Guna2GroupBox5"
        Me.Guna2GroupBox5.Size = New System.Drawing.Size(176, 107)
        Me.Guna2GroupBox5.TabIndex = 3
        Me.Guna2GroupBox5.Text = "Empleados activos"
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
        Me.Guna2GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox4.Location = New System.Drawing.Point(293, 76)
        Me.Guna2GroupBox4.Name = "Guna2GroupBox4"
        Me.Guna2GroupBox4.Size = New System.Drawing.Size(176, 107)
        Me.Guna2GroupBox4.TabIndex = 3
        Me.Guna2GroupBox4.Text = "Cantidad de consultas"
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
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
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
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ComboBox2 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
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
End Class