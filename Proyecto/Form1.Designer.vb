<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Cedula = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BTN_INICIAR_SECCION = New Guna.UI2.WinForms.Guna2Button()
        Me.PASSWORD = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FOTO = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.FOTO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderThickness = 0
        Me.Guna2GroupBox1.Controls.Add(Me.Cedula)
        Me.Guna2GroupBox1.Controls.Add(Me.Label6)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_INICIAR_SECCION)
        Me.Guna2GroupBox1.Controls.Add(Me.PASSWORD)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button1)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.FOTO)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(626, 417)
        Me.Guna2GroupBox1.TabIndex = 2
        Me.Guna2GroupBox1.Text = "Área de registros"
        '
        'Cedula
        '
        Me.Cedula.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Cedula.Location = New System.Drawing.Point(435, 205)
        Me.Cedula.Mask = "00-0000-0000"
        Me.Cedula.Name = "Cedula"
        Me.Cedula.Size = New System.Drawing.Size(149, 23)
        Me.Cedula.TabIndex = 33
        Me.Cedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(342, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "CONTRASEÑA:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(375, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "CÉDULA:"
        '
        'BTN_INICIAR_SECCION
        '
        Me.BTN_INICIAR_SECCION.BorderRadius = 5
        Me.BTN_INICIAR_SECCION.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_INICIAR_SECCION.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_INICIAR_SECCION.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_INICIAR_SECCION.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_INICIAR_SECCION.FillColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BTN_INICIAR_SECCION.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_INICIAR_SECCION.ForeColor = System.Drawing.Color.White
        Me.BTN_INICIAR_SECCION.Location = New System.Drawing.Point(435, 282)
        Me.BTN_INICIAR_SECCION.Name = "BTN_INICIAR_SECCION"
        Me.BTN_INICIAR_SECCION.Size = New System.Drawing.Size(142, 38)
        Me.BTN_INICIAR_SECCION.TabIndex = 9
        Me.BTN_INICIAR_SECCION.Text = "INICIAR SECCION"
        '
        'PASSWORD
        '
        Me.PASSWORD.BackColor = System.Drawing.Color.Transparent
        Me.PASSWORD.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.PASSWORD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PASSWORD.DefaultText = ""
        Me.PASSWORD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PASSWORD.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PASSWORD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PASSWORD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PASSWORD.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PASSWORD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PASSWORD.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PASSWORD.ForeColor = System.Drawing.Color.Black
        Me.PASSWORD.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PASSWORD.Location = New System.Drawing.Point(435, 247)
        Me.PASSWORD.Name = "PASSWORD"
        Me.PASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PASSWORD.PlaceholderText = ""
        Me.PASSWORD.SelectedText = ""
        Me.PASSWORD.Size = New System.Drawing.Size(149, 27)
        Me.PASSWORD.TabIndex = 8
        Me.PASSWORD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.Guna2Button1.Location = New System.Drawing.Point(583, 3)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(38, 33)
        Me.Guna2Button1.TabIndex = 6
        Me.Guna2Button1.Text = "X"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bernard MT Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(358, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(254, 31)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "LOGIN ADMINISTRATIVO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bernard MT Condensed", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 328)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(320, 41)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SISTEMA HOSPITALARIO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(67, 287)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BIENVENIDO AL"
        '
        'FOTO
        '
        Me.FOTO.BackColor = System.Drawing.Color.Transparent
        Me.FOTO.ImageRotate = 0!
        Me.FOTO.Location = New System.Drawing.Point(23, 84)
        Me.FOTO.Name = "FOTO"
        Me.FOTO.Size = New System.Drawing.Size(300, 200)
        Me.FOTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FOTO.TabIndex = 0
        Me.FOTO.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 417)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.FOTO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents BTN_INICIAR_SECCION As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PASSWORD As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FOTO As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Cedula As MaskedTextBox
End Class
