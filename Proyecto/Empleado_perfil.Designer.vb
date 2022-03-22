<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleado_perfil
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
        Me.BTN_BORRAR = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TELEFONO_USUARIO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_ACTUALIZAR = New Guna.UI2.WinForms.Guna2Button()
        Me.IMG_USUARIO = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.CORREO_USUARIO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CONTRASENA_USUARIO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.NOMBRE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.IMG_USUARIO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_BORRAR)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.TELEFONO_USUARIO)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button2)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_ACTUALIZAR)
        Me.Guna2GroupBox1.Controls.Add(Me.IMG_USUARIO)
        Me.Guna2GroupBox1.Controls.Add(Me.CORREO_USUARIO)
        Me.Guna2GroupBox1.Controls.Add(Me.CONTRASENA_USUARIO)
        Me.Guna2GroupBox1.Controls.Add(Me.NOMBRE)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(-1, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(638, 417)
        Me.Guna2GroupBox1.TabIndex = 2
        Me.Guna2GroupBox1.Text = " Registrarse"
        '
        'BTN_BORRAR
        '
        Me.BTN_BORRAR.BorderColor = System.Drawing.Color.Transparent
        Me.BTN_BORRAR.BorderRadius = 5
        Me.BTN_BORRAR.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_BORRAR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_BORRAR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_BORRAR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_BORRAR.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BTN_BORRAR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_BORRAR.ForeColor = System.Drawing.Color.White
        Me.BTN_BORRAR.Location = New System.Drawing.Point(516, 345)
        Me.BTN_BORRAR.Name = "BTN_BORRAR"
        Me.BTN_BORRAR.Size = New System.Drawing.Size(111, 38)
        Me.BTN_BORRAR.TabIndex = 20
        Me.BTN_BORRAR.Text = "BORRAR USUARIO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(300, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "TELEFONO:"
        '
        'TELEFONO_USUARIO
        '
        Me.TELEFONO_USUARIO.BackColor = System.Drawing.Color.Transparent
        Me.TELEFONO_USUARIO.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TELEFONO_USUARIO.BorderRadius = 5
        Me.TELEFONO_USUARIO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TELEFONO_USUARIO.DefaultText = ""
        Me.TELEFONO_USUARIO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TELEFONO_USUARIO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TELEFONO_USUARIO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TELEFONO_USUARIO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TELEFONO_USUARIO.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TELEFONO_USUARIO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TELEFONO_USUARIO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TELEFONO_USUARIO.ForeColor = System.Drawing.Color.Black
        Me.TELEFONO_USUARIO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TELEFONO_USUARIO.Location = New System.Drawing.Point(395, 285)
        Me.TELEFONO_USUARIO.Name = "TELEFONO_USUARIO"
        Me.TELEFONO_USUARIO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TELEFONO_USUARIO.PlaceholderText = ""
        Me.TELEFONO_USUARIO.SelectedText = ""
        Me.TELEFONO_USUARIO.Size = New System.Drawing.Size(232, 36)
        Me.TELEFONO_USUARIO.TabIndex = 18
        Me.TELEFONO_USUARIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.BorderRadius = 5
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(13, 44)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(111, 35)
        Me.Guna2Button2.TabIndex = 17
        Me.Guna2Button2.Text = "Volver "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(287, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "CONTRASEÑA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(317, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "CORREO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "NOMBRE COMPLETO:"
        '
        'BTN_ACTUALIZAR
        '
        Me.BTN_ACTUALIZAR.BorderColor = System.Drawing.Color.Transparent
        Me.BTN_ACTUALIZAR.BorderRadius = 5
        Me.BTN_ACTUALIZAR.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ACTUALIZAR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ACTUALIZAR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_ACTUALIZAR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_ACTUALIZAR.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BTN_ACTUALIZAR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_ACTUALIZAR.ForeColor = System.Drawing.Color.White
        Me.BTN_ACTUALIZAR.Location = New System.Drawing.Point(395, 345)
        Me.BTN_ACTUALIZAR.Name = "BTN_ACTUALIZAR"
        Me.BTN_ACTUALIZAR.Size = New System.Drawing.Size(111, 38)
        Me.BTN_ACTUALIZAR.TabIndex = 12
        Me.BTN_ACTUALIZAR.Text = "ACTUALIZAR"
        '
        'IMG_USUARIO
        '
        Me.IMG_USUARIO.ImageRotate = 0!
        Me.IMG_USUARIO.Location = New System.Drawing.Point(13, 123)
        Me.IMG_USUARIO.Name = "IMG_USUARIO"
        Me.IMG_USUARIO.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.IMG_USUARIO.Size = New System.Drawing.Size(224, 213)
        Me.IMG_USUARIO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IMG_USUARIO.TabIndex = 11
        Me.IMG_USUARIO.TabStop = False
        '
        'CORREO_USUARIO
        '
        Me.CORREO_USUARIO.BackColor = System.Drawing.Color.Transparent
        Me.CORREO_USUARIO.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CORREO_USUARIO.BorderRadius = 5
        Me.CORREO_USUARIO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CORREO_USUARIO.DefaultText = ""
        Me.CORREO_USUARIO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CORREO_USUARIO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CORREO_USUARIO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CORREO_USUARIO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CORREO_USUARIO.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CORREO_USUARIO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CORREO_USUARIO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CORREO_USUARIO.ForeColor = System.Drawing.Color.Black
        Me.CORREO_USUARIO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CORREO_USUARIO.Location = New System.Drawing.Point(395, 201)
        Me.CORREO_USUARIO.Name = "CORREO_USUARIO"
        Me.CORREO_USUARIO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CORREO_USUARIO.PlaceholderText = ""
        Me.CORREO_USUARIO.SelectedText = ""
        Me.CORREO_USUARIO.Size = New System.Drawing.Size(232, 36)
        Me.CORREO_USUARIO.TabIndex = 10
        Me.CORREO_USUARIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CONTRASENA_USUARIO
        '
        Me.CONTRASENA_USUARIO.BackColor = System.Drawing.Color.Transparent
        Me.CONTRASENA_USUARIO.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CONTRASENA_USUARIO.BorderRadius = 5
        Me.CONTRASENA_USUARIO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CONTRASENA_USUARIO.DefaultText = ""
        Me.CONTRASENA_USUARIO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CONTRASENA_USUARIO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CONTRASENA_USUARIO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CONTRASENA_USUARIO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CONTRASENA_USUARIO.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CONTRASENA_USUARIO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CONTRASENA_USUARIO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CONTRASENA_USUARIO.ForeColor = System.Drawing.Color.Black
        Me.CONTRASENA_USUARIO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CONTRASENA_USUARIO.Location = New System.Drawing.Point(395, 243)
        Me.CONTRASENA_USUARIO.Name = "CONTRASENA_USUARIO"
        Me.CONTRASENA_USUARIO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CONTRASENA_USUARIO.PlaceholderText = ""
        Me.CONTRASENA_USUARIO.SelectedText = ""
        Me.CONTRASENA_USUARIO.Size = New System.Drawing.Size(232, 36)
        Me.CONTRASENA_USUARIO.TabIndex = 9
        Me.CONTRASENA_USUARIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NOMBRE
        '
        Me.NOMBRE.BackColor = System.Drawing.Color.Transparent
        Me.NOMBRE.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.NOMBRE.BorderRadius = 5
        Me.NOMBRE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NOMBRE.DefaultText = ""
        Me.NOMBRE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NOMBRE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NOMBRE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NOMBRE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NOMBRE.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.NOMBRE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NOMBRE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NOMBRE.ForeColor = System.Drawing.Color.Black
        Me.NOMBRE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NOMBRE.Location = New System.Drawing.Point(395, 159)
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NOMBRE.PlaceholderText = ""
        Me.NOMBRE.SelectedText = ""
        Me.NOMBRE.Size = New System.Drawing.Size(232, 36)
        Me.NOMBRE.TabIndex = 8
        Me.NOMBRE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bernard MT Condensed", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(212, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(225, 41)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CREA TU CUENTA"
        '
        'Empleado_perfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 418)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Empleado_perfil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrarse"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.IMG_USUARIO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_ACTUALIZAR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents IMG_USUARIO As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents CORREO_USUARIO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CONTRASENA_USUARIO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents NOMBRE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TELEFONO_USUARIO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTN_BORRAR As Guna.UI2.WinForms.Guna2Button
End Class
