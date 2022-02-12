<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Interfaz
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Interfaz))
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Panel_opciones = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel_menu = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_Registrar_paciente = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btn_opciones = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnCerrarInterfaz = New Guna.UI2.WinForms.Guna2Button()
        Me.Mostrar_opciones = New System.Windows.Forms.Timer(Me.components)
        Me.Ocultar_opciones = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2GroupBox2.SuspendLayout()
        Me.Panel_menu.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_opciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox2.Controls.Add(Me.Panel_opciones)
        Me.Guna2GroupBox2.Controls.Add(Me.Panel_menu)
        Me.Guna2GroupBox2.Controls.Add(Me.btnCerrarInterfaz)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(1064, 579)
        Me.Guna2GroupBox2.TabIndex = 3
        Me.Guna2GroupBox2.Text = "Bienvenido"
        '
        'Panel_opciones
        '
        Me.Panel_opciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_opciones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel_opciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel_opciones.BorderColor = System.Drawing.Color.SlateBlue
        Me.Panel_opciones.BorderThickness = 2
        Me.Panel_opciones.Location = New System.Drawing.Point(254, 42)
        Me.Panel_opciones.Name = "Panel_opciones"
        Me.Panel_opciones.Size = New System.Drawing.Size(807, 534)
        Me.Panel_opciones.TabIndex = 15
        '
        'Panel_menu
        '
        Me.Panel_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel_menu.BorderColor = System.Drawing.Color.SlateBlue
        Me.Panel_menu.BorderRadius = 5
        Me.Panel_menu.BorderThickness = 1
        Me.Panel_menu.Controls.Add(Me.Guna2Button5)
        Me.Panel_menu.Controls.Add(Me.Guna2Button4)
        Me.Panel_menu.Controls.Add(Me.Guna2Button3)
        Me.Panel_menu.Controls.Add(Me.Guna2Button2)
        Me.Panel_menu.Controls.Add(Me.Guna2Button1)
        Me.Panel_menu.Controls.Add(Me.btn_Registrar_paciente)
        Me.Panel_menu.Controls.Add(Me.Panel7)
        Me.Panel_menu.Controls.Add(Me.Panel6)
        Me.Panel_menu.Controls.Add(Me.Label1)
        Me.Panel_menu.Controls.Add(Me.Label2)
        Me.Panel_menu.Controls.Add(Me.Guna2PictureBox1)
        Me.Panel_menu.Controls.Add(Me.btn_opciones)
        Me.Panel_menu.Location = New System.Drawing.Point(3, 42)
        Me.Panel_menu.Name = "Panel_menu"
        Me.Panel_menu.Size = New System.Drawing.Size(250, 534)
        Me.Panel_menu.TabIndex = 14
        '
        'Guna2Button5
        '
        Me.Guna2Button5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button5.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button5.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button5.Image = CType(resources.GetObject("Guna2Button5.Image"), System.Drawing.Image)
        Me.Guna2Button5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button5.ImageSize = New System.Drawing.Size(50, 50)
        Me.Guna2Button5.Location = New System.Drawing.Point(3, 460)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.Size = New System.Drawing.Size(244, 57)
        Me.Guna2Button5.TabIndex = 28
        Me.Guna2Button5.Text = "Cerrar sesion"
        Me.Guna2Button5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Guna2Button4
        '
        Me.Guna2Button4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button4.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button4.Image = CType(resources.GetObject("Guna2Button4.Image"), System.Drawing.Image)
        Me.Guna2Button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button4.ImageSize = New System.Drawing.Size(50, 50)
        Me.Guna2Button4.Location = New System.Drawing.Point(3, 397)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(244, 57)
        Me.Guna2Button4.TabIndex = 27
        Me.Guna2Button4.Text = "Registrar facturas"
        Me.Guna2Button4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Guna2Button3
        '
        Me.Guna2Button3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button3.Image = CType(resources.GetObject("Guna2Button3.Image"), System.Drawing.Image)
        Me.Guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button3.ImageSize = New System.Drawing.Size(50, 50)
        Me.Guna2Button3.Location = New System.Drawing.Point(1, 334)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(244, 57)
        Me.Guna2Button3.TabIndex = 26
        Me.Guna2Button3.Text = "Registrar areas"
        Me.Guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button2.Image = CType(resources.GetObject("Guna2Button2.Image"), System.Drawing.Image)
        Me.Guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button2.ImageSize = New System.Drawing.Size(50, 50)
        Me.Guna2Button2.Location = New System.Drawing.Point(3, 208)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(244, 57)
        Me.Guna2Button2.TabIndex = 25
        Me.Guna2Button2.Text = "Registrar consultas"
        Me.Guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(50, 50)
        Me.Guna2Button1.Location = New System.Drawing.Point(1, 271)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(244, 57)
        Me.Guna2Button1.TabIndex = 24
        Me.Guna2Button1.Text = "Registrar Empleado"
        Me.Guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_Registrar_paciente
        '
        Me.btn_Registrar_paciente.BackColor = System.Drawing.Color.Transparent
        Me.btn_Registrar_paciente.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Registrar_paciente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Registrar_paciente.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Registrar_paciente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Registrar_paciente.FillColor = System.Drawing.Color.Transparent
        Me.btn_Registrar_paciente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Registrar_paciente.ForeColor = System.Drawing.Color.Black
        Me.btn_Registrar_paciente.Image = CType(resources.GetObject("btn_Registrar_paciente.Image"), System.Drawing.Image)
        Me.btn_Registrar_paciente.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_Registrar_paciente.ImageSize = New System.Drawing.Size(50, 50)
        Me.btn_Registrar_paciente.Location = New System.Drawing.Point(3, 145)
        Me.btn_Registrar_paciente.Name = "btn_Registrar_paciente"
        Me.btn_Registrar_paciente.Size = New System.Drawing.Size(244, 57)
        Me.btn_Registrar_paciente.TabIndex = 23
        Me.btn_Registrar_paciente.Text = "Registrar paciente"
        Me.btn_Registrar_paciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel7
        '
        Me.Panel7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Panel7.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel7.Location = New System.Drawing.Point(1, 72)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(248, 3)
        Me.Panel7.TabIndex = 21
        '
        'Panel6
        '
        Me.Panel6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Panel6.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel6.Location = New System.Drawing.Point(1, 130)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(248, 3)
        Me.Panel6.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 32)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Sistema"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 32)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Hospitalario"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(6, 67)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(59, 73)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 17
        Me.Guna2PictureBox1.TabStop = False
        '
        'btn_opciones
        '
        Me.btn_opciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_opciones.Image = CType(resources.GetObject("btn_opciones.Image"), System.Drawing.Image)
        Me.btn_opciones.ImageRotate = 0!
        Me.btn_opciones.Location = New System.Drawing.Point(188, 4)
        Me.btn_opciones.Name = "btn_opciones"
        Me.btn_opciones.Size = New System.Drawing.Size(52, 53)
        Me.btn_opciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_opciones.TabIndex = 2
        Me.btn_opciones.TabStop = False
        '
        'btnCerrarInterfaz
        '
        Me.btnCerrarInterfaz.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrarInterfaz.BorderRadius = 2
        Me.btnCerrarInterfaz.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCerrarInterfaz.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCerrarInterfaz.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCerrarInterfaz.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCerrarInterfaz.FillColor = System.Drawing.Color.Red
        Me.btnCerrarInterfaz.FocusedColor = System.Drawing.Color.Maroon
        Me.btnCerrarInterfaz.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCerrarInterfaz.ForeColor = System.Drawing.Color.White
        Me.btnCerrarInterfaz.Location = New System.Drawing.Point(1014, 3)
        Me.btnCerrarInterfaz.Name = "btnCerrarInterfaz"
        Me.btnCerrarInterfaz.Size = New System.Drawing.Size(38, 35)
        Me.btnCerrarInterfaz.TabIndex = 13
        Me.btnCerrarInterfaz.Text = "X"
        '
        'Mostrar_opciones
        '
        Me.Mostrar_opciones.Interval = 10
        '
        'Ocultar_opciones
        '
        Me.Ocultar_opciones.Interval = 10
        '
        'Interfaz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 577)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Interfaz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Interfaz"
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Panel_menu.ResumeLayout(False)
        Me.Panel_menu.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_opciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Panel_opciones As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel_menu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_Registrar_paciente As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btn_opciones As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnCerrarInterfaz As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Mostrar_opciones As Timer
    Friend WithEvents Ocultar_opciones As Timer
End Class
