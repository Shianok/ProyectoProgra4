<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REGISTRO_FACTURAS
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
        Me.BtnCerrarInterfaz = New Guna.UI2.WinForms.Guna2Button()
        Me.Buscar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.L = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox1.Controls.Add(Me.L)
        Me.Guna2GroupBox1.Controls.Add(Me.BtnCerrarInterfaz)
        Me.Guna2GroupBox1.Controls.Add(Me.Buscar)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(693, 470)
        Me.Guna2GroupBox1.TabIndex = 3
        Me.Guna2GroupBox1.Text = "Buscar factura"
        '
        'BtnCerrarInterfaz
        '
        Me.BtnCerrarInterfaz.BackColor = System.Drawing.Color.Transparent
        Me.BtnCerrarInterfaz.BorderRadius = 2
        Me.BtnCerrarInterfaz.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnCerrarInterfaz.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnCerrarInterfaz.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnCerrarInterfaz.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnCerrarInterfaz.FillColor = System.Drawing.Color.Red
        Me.BtnCerrarInterfaz.FocusedColor = System.Drawing.Color.Maroon
        Me.BtnCerrarInterfaz.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnCerrarInterfaz.ForeColor = System.Drawing.Color.White
        Me.BtnCerrarInterfaz.Location = New System.Drawing.Point(651, 3)
        Me.BtnCerrarInterfaz.Name = "BtnCerrarInterfaz"
        Me.BtnCerrarInterfaz.Size = New System.Drawing.Size(38, 35)
        Me.BtnCerrarInterfaz.TabIndex = 14
        Me.BtnCerrarInterfaz.Text = "X"
        '
        'Buscar
        '
        Me.Buscar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Buscar.DefaultText = ""
        Me.Buscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Buscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Buscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Buscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Buscar.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Buscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Buscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Buscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Buscar.Location = New System.Drawing.Point(198, 55)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Buscar.PlaceholderText = ""
        Me.Buscar.SelectedText = ""
        Me.Buscar.Size = New System.Drawing.Size(283, 33)
        Me.Buscar.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(52, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Numero de factura"
        '
        'L
        '
        Me.L.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.L.FullRowSelect = True
        Me.L.GridLines = True
        Me.L.HideSelection = False
        Me.L.Location = New System.Drawing.Point(12, 122)
        Me.L.MultiSelect = False
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(667, 331)
        Me.L.TabIndex = 15
        Me.L.UseCompatibleStateImageBehavior = False
        Me.L.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Numero de factura"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre de paciente"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Cedula"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Monto"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Fecha de pago"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Nombre de remitente"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Area de atencion"
        '
        'REGISTRO_FACTURAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 465)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "REGISTRO_FACTURAS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTRO_FACTURAS"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents L As ListView
    Friend WithEvents BtnCerrarInterfaz As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Buscar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
End Class
