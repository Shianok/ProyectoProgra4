<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarEnfermedad
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
        Me.Editar = New Guna.UI2.WinForms.Guna2Button()
        Me.Eliminar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_AGREGAR_ENFERMEDAD = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_ENFERMEDAD = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.L_ENFERMEDADES = New System.Windows.Forms.ListView()
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
        Me.Guna2GroupBox1.Controls.Add(Me.Editar)
        Me.Guna2GroupBox1.Controls.Add(Me.Eliminar)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button1)
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_AGREGAR_ENFERMEDAD)
        Me.Guna2GroupBox1.Controls.Add(Me.TXT_ENFERMEDAD)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.L_ENFERMEDADES)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(543, 323)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "Agregar enfermedad"
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
        'BTN_AGREGAR_ENFERMEDAD
        '
        Me.BTN_AGREGAR_ENFERMEDAD.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AGREGAR_ENFERMEDAD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_AGREGAR_ENFERMEDAD.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_AGREGAR_ENFERMEDAD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_AGREGAR_ENFERMEDAD.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BTN_AGREGAR_ENFERMEDAD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_AGREGAR_ENFERMEDAD.ForeColor = System.Drawing.Color.White
        Me.BTN_AGREGAR_ENFERMEDAD.Location = New System.Drawing.Point(41, 189)
        Me.BTN_AGREGAR_ENFERMEDAD.Name = "BTN_AGREGAR_ENFERMEDAD"
        Me.BTN_AGREGAR_ENFERMEDAD.Size = New System.Drawing.Size(145, 33)
        Me.BTN_AGREGAR_ENFERMEDAD.TabIndex = 30
        Me.BTN_AGREGAR_ENFERMEDAD.Text = "Registrar"
        '
        'TXT_ENFERMEDAD
        '
        Me.TXT_ENFERMEDAD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_ENFERMEDAD.DefaultText = ""
        Me.TXT_ENFERMEDAD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_ENFERMEDAD.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_ENFERMEDAD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_ENFERMEDAD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_ENFERMEDAD.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TXT_ENFERMEDAD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_ENFERMEDAD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_ENFERMEDAD.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_ENFERMEDAD.Location = New System.Drawing.Point(15, 150)
        Me.TXT_ENFERMEDAD.Name = "TXT_ENFERMEDAD"
        Me.TXT_ENFERMEDAD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_ENFERMEDAD.PlaceholderText = ""
        Me.TXT_ENFERMEDAD.SelectedText = ""
        Me.TXT_ENFERMEDAD.Size = New System.Drawing.Size(200, 29)
        Me.TXT_ENFERMEDAD.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 15)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Agregar enfermedad:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(285, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 21)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Enfermedades registradas"
        '
        'L_ENFERMEDADES
        '
        Me.L_ENFERMEDADES.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.L_ENFERMEDADES.ContextMenuStrip = Me.Opciones
        Me.L_ENFERMEDADES.FullRowSelect = True
        Me.L_ENFERMEDADES.GridLines = True
        Me.L_ENFERMEDADES.HideSelection = False
        Me.L_ENFERMEDADES.Location = New System.Drawing.Point(271, 75)
        Me.L_ENFERMEDADES.MultiSelect = False
        Me.L_ENFERMEDADES.Name = "L_ENFERMEDADES"
        Me.L_ENFERMEDADES.Size = New System.Drawing.Size(232, 216)
        Me.L_ENFERMEDADES.TabIndex = 26
        Me.L_ENFERMEDADES.UseCompatibleStateImageBehavior = False
        Me.L_ENFERMEDADES.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ENFERMEDADES"
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
        Me.Editar_Registro.Size = New System.Drawing.Size(171, 22)
        Me.Editar_Registro.Text = "Editar este registro"
        '
        'AgregarEnfermedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 322)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AgregarEnfermedad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgregarEnfermedad"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Opciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents TXT_ENFERMEDAD As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents L_ENFERMEDADES As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents BTN_AGREGAR_ENFERMEDAD As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Editar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Eliminar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Opciones As ContextMenuStrip
    Friend WithEvents Editar_Registro As ToolStripMenuItem
End Class
