<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_tipo_empleado
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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.BUSCAR_TIPO_EMPLEADO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Editar = New Guna.UI2.WinForms.Guna2Button()
        Me.Eliminar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_AGREGAR_TIPO_EMPLEADO = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_TIPO_EMPLEADO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.L_TIPO_EMPLEADO = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Opciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Editar_Registro = New System.Windows.Forms.ToolStripMenuItem()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Opciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.BUSCAR_TIPO_EMPLEADO)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.Editar)
        Me.Guna2GroupBox1.Controls.Add(Me.Eliminar)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button1)
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_AGREGAR_TIPO_EMPLEADO)
        Me.Guna2GroupBox1.Controls.Add(Me.TXT_TIPO_EMPLEADO)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.L_TIPO_EMPLEADO)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(-1, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(543, 323)
        Me.Guna2GroupBox1.TabIndex = 1
        Me.Guna2GroupBox1.Text = "Agregar tipo empleado"
        '
        'BUSCAR_TIPO_EMPLEADO
        '
        Me.BUSCAR_TIPO_EMPLEADO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BUSCAR_TIPO_EMPLEADO.DefaultText = ""
        Me.BUSCAR_TIPO_EMPLEADO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.BUSCAR_TIPO_EMPLEADO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BUSCAR_TIPO_EMPLEADO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BUSCAR_TIPO_EMPLEADO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BUSCAR_TIPO_EMPLEADO.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BUSCAR_TIPO_EMPLEADO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BUSCAR_TIPO_EMPLEADO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BUSCAR_TIPO_EMPLEADO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BUSCAR_TIPO_EMPLEADO.Location = New System.Drawing.Point(271, 77)
        Me.BUSCAR_TIPO_EMPLEADO.Name = "BUSCAR_TIPO_EMPLEADO"
        Me.BUSCAR_TIPO_EMPLEADO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BUSCAR_TIPO_EMPLEADO.PlaceholderText = ""
        Me.BUSCAR_TIPO_EMPLEADO.SelectedText = ""
        Me.BUSCAR_TIPO_EMPLEADO.Size = New System.Drawing.Size(232, 29)
        Me.BUSCAR_TIPO_EMPLEADO.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(225, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Buscar:"
        '
        'Editar
        '
        Me.Editar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Editar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Editar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Editar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Editar.Enabled = False
        Me.Editar.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Editar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Editar.ForeColor = System.Drawing.Color.White
        Me.Editar.Location = New System.Drawing.Point(41, 228)
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(69, 33)
        Me.Editar.TabIndex = 33
        Me.Editar.Text = "Editar"
        '
        'Eliminar
        '
        Me.Eliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Eliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Eliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Eliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Eliminar.Enabled = False
        Me.Eliminar.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Eliminar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Eliminar.ForeColor = System.Drawing.Color.White
        Me.Eliminar.Location = New System.Drawing.Point(116, 228)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(70, 33)
        Me.Eliminar.TabIndex = 32
        Me.Eliminar.Text = "Eliminar"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 2
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Red
        Me.Guna2Button1.FocusedColor = System.Drawing.Color.Maroon
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(490, 3)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(38, 33)
        Me.Guna2Button1.TabIndex = 31
        Me.Guna2Button1.Text = "X"
        '
        'BTN_AGREGAR_TIPO_EMPLEADO
        '
        Me.BTN_AGREGAR_TIPO_EMPLEADO.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AGREGAR_TIPO_EMPLEADO.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AGREGAR_TIPO_EMPLEADO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_AGREGAR_TIPO_EMPLEADO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_AGREGAR_TIPO_EMPLEADO.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BTN_AGREGAR_TIPO_EMPLEADO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_AGREGAR_TIPO_EMPLEADO.ForeColor = System.Drawing.Color.White
        Me.BTN_AGREGAR_TIPO_EMPLEADO.Location = New System.Drawing.Point(41, 189)
        Me.BTN_AGREGAR_TIPO_EMPLEADO.Name = "BTN_AGREGAR_TIPO_EMPLEADO"
        Me.BTN_AGREGAR_TIPO_EMPLEADO.Size = New System.Drawing.Size(145, 33)
        Me.BTN_AGREGAR_TIPO_EMPLEADO.TabIndex = 30
        Me.BTN_AGREGAR_TIPO_EMPLEADO.Text = "Registrar"
        '
        'TXT_TIPO_EMPLEADO
        '
        Me.TXT_TIPO_EMPLEADO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_TIPO_EMPLEADO.DefaultText = ""
        Me.TXT_TIPO_EMPLEADO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_TIPO_EMPLEADO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_TIPO_EMPLEADO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_TIPO_EMPLEADO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_TIPO_EMPLEADO.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TXT_TIPO_EMPLEADO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_TIPO_EMPLEADO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_TIPO_EMPLEADO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_TIPO_EMPLEADO.Location = New System.Drawing.Point(15, 150)
        Me.TXT_TIPO_EMPLEADO.Name = "TXT_TIPO_EMPLEADO"
        Me.TXT_TIPO_EMPLEADO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_TIPO_EMPLEADO.PlaceholderText = ""
        Me.TXT_TIPO_EMPLEADO.SelectedText = ""
        Me.TXT_TIPO_EMPLEADO.Size = New System.Drawing.Size(200, 29)
        Me.TXT_TIPO_EMPLEADO.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 15)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Agregar tipo empleado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(272, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 21)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Tipos empleados registrados"
        '
        'L_TIPO_EMPLEADO
        '
        Me.L_TIPO_EMPLEADO.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.L_TIPO_EMPLEADO.ContextMenuStrip = Me.Opciones
        Me.L_TIPO_EMPLEADO.FullRowSelect = True
        Me.L_TIPO_EMPLEADO.GridLines = True
        Me.L_TIPO_EMPLEADO.HideSelection = False
        Me.L_TIPO_EMPLEADO.Location = New System.Drawing.Point(271, 112)
        Me.L_TIPO_EMPLEADO.MultiSelect = False
        Me.L_TIPO_EMPLEADO.Name = "L_TIPO_EMPLEADO"
        Me.L_TIPO_EMPLEADO.Size = New System.Drawing.Size(232, 179)
        Me.L_TIPO_EMPLEADO.TabIndex = 26
        Me.L_TIPO_EMPLEADO.UseCompatibleStateImageBehavior = False
        Me.L_TIPO_EMPLEADO.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "TIPO_EMPLEADO"
        Me.ColumnHeader2.Width = 229
        '
        'Opciones
        '
        Me.Opciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Editar_Registro})
        Me.Opciones.Name = "Opciones"
        Me.Opciones.Size = New System.Drawing.Size(172, 26)
        '
        'Editar_Registro
        '
        Me.Editar_Registro.Name = "Editar_Registro"
        Me.Editar_Registro.Size = New System.Drawing.Size(180, 22)
        Me.Editar_Registro.Text = "Editar este registro"
        '
        'Agregar_tipo_empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 319)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Agregar_tipo_empleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar_tipo_empleado"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Opciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents BUSCAR_TIPO_EMPLEADO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Editar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Eliminar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_AGREGAR_TIPO_EMPLEADO As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_TIPO_EMPLEADO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents L_TIPO_EMPLEADO As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Opciones As ContextMenuStrip
    Friend WithEvents Editar_Registro As ToolStripMenuItem
End Class
