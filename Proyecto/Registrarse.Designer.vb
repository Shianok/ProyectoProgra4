<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrarse
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CEDULA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_REGISTRARSE = New Guna.UI2.WinForms.Guna2Button()
        Me.IMG_USUARIO = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PASSWORD = New Guna.UI2.WinForms.Guna2TextBox()
        Me.USERNAME = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.IMG_USUARIO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.CEDULA)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button2)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button1)
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_REGISTRARSE)
        Me.Guna2GroupBox1.Controls.Add(Me.IMG_USUARIO)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2TextBox1)
        Me.Guna2GroupBox1.Controls.Add(Me.PASSWORD)
        Me.Guna2GroupBox1.Controls.Add(Me.USERNAME)
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(256, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "CEDULA:"
        '
        'CEDULA
        '
        Me.CEDULA.BackColor = System.Drawing.Color.Transparent
        Me.CEDULA.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CEDULA.BorderRadius = 5
        Me.CEDULA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CEDULA.DefaultText = ""
        Me.CEDULA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CEDULA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CEDULA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CEDULA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CEDULA.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CEDULA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CEDULA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CEDULA.ForeColor = System.Drawing.Color.Black
        Me.CEDULA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CEDULA.Location = New System.Drawing.Point(395, 285)
        Me.CEDULA.Name = "CEDULA"
        Me.CEDULA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CEDULA.PlaceholderText = ""
        Me.CEDULA.SelectedText = ""
        Me.CEDULA.Size = New System.Drawing.Size(232, 36)
        Me.CEDULA.TabIndex = 18
        Me.CEDULA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.Guna2Button2.Text = "Volver al login"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(256, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "CONTRASEÑA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(256, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "TELÉFONO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "NOMBRE DE USUARIO:"
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
        Me.Guna2Button1.Location = New System.Drawing.Point(589, 3)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(38, 35)
        Me.Guna2Button1.TabIndex = 13
        Me.Guna2Button1.Text = "X"
        '
        'BTN_REGISTRARSE
        '
        Me.BTN_REGISTRARSE.BorderColor = System.Drawing.Color.Transparent
        Me.BTN_REGISTRARSE.BorderRadius = 5
        Me.BTN_REGISTRARSE.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_REGISTRARSE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_REGISTRARSE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_REGISTRARSE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_REGISTRARSE.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BTN_REGISTRARSE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_REGISTRARSE.ForeColor = System.Drawing.Color.White
        Me.BTN_REGISTRARSE.Location = New System.Drawing.Point(441, 345)
        Me.BTN_REGISTRARSE.Name = "BTN_REGISTRARSE"
        Me.BTN_REGISTRARSE.Size = New System.Drawing.Size(142, 38)
        Me.BTN_REGISTRARSE.TabIndex = 12
        Me.BTN_REGISTRARSE.Text = "REGISTRARSE"
        '
        'IMG_USUARIO
        '
        Me.IMG_USUARIO.ImageRotate = 0!
        Me.IMG_USUARIO.Location = New System.Drawing.Point(13, 123)
        Me.IMG_USUARIO.Name = "IMG_USUARIO"
        Me.IMG_USUARIO.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.IMG_USUARIO.Size = New System.Drawing.Size(224, 213)
        Me.IMG_USUARIO.TabIndex = 11
        Me.IMG_USUARIO.TabStop = False
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2TextBox1.BorderRadius = 5
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(395, 201)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(232, 36)
        Me.Guna2TextBox1.TabIndex = 10
        Me.Guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PASSWORD
        '
        Me.PASSWORD.BackColor = System.Drawing.Color.Transparent
        Me.PASSWORD.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.PASSWORD.BorderRadius = 5
        Me.PASSWORD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PASSWORD.DefaultText = ""
        Me.PASSWORD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PASSWORD.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PASSWORD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PASSWORD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PASSWORD.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PASSWORD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PASSWORD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PASSWORD.ForeColor = System.Drawing.Color.Black
        Me.PASSWORD.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PASSWORD.Location = New System.Drawing.Point(395, 243)
        Me.PASSWORD.Name = "PASSWORD"
        Me.PASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PASSWORD.PlaceholderText = ""
        Me.PASSWORD.SelectedText = ""
        Me.PASSWORD.Size = New System.Drawing.Size(232, 36)
        Me.PASSWORD.TabIndex = 9
        Me.PASSWORD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'USERNAME
        '
        Me.USERNAME.BackColor = System.Drawing.Color.Transparent
        Me.USERNAME.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.USERNAME.BorderRadius = 5
        Me.USERNAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.USERNAME.DefaultText = ""
        Me.USERNAME.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.USERNAME.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.USERNAME.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.USERNAME.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.USERNAME.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.USERNAME.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.USERNAME.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.USERNAME.ForeColor = System.Drawing.Color.Black
        Me.USERNAME.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.USERNAME.Location = New System.Drawing.Point(395, 159)
        Me.USERNAME.Name = "USERNAME"
        Me.USERNAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.USERNAME.PlaceholderText = ""
        Me.USERNAME.SelectedText = ""
        Me.USERNAME.Size = New System.Drawing.Size(232, 36)
        Me.USERNAME.TabIndex = 8
        Me.USERNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'Registrarse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 418)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registrarse"
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
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_REGISTRARSE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents IMG_USUARIO As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PASSWORD As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents USERNAME As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CEDULA As Guna.UI2.WinForms.Guna2TextBox
End Class
