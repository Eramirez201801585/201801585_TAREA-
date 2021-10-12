<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbTaller = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbRegistro = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbGenero = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Registro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Taller = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Deducible = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aseguradora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLestadisticas = New System.Windows.Forms.Button()
        Me.btnEstadisticas = New System.Windows.Forms.Button()
        Me.btnLvectores = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblE6 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblE5 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblE4 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblE3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblE2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblE1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(745, 148)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese Datos"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbTaller)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtMonto)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(389, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(251, 119)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos del Accidente"
        '
        'cmbTaller
        '
        Me.cmbTaller.FormattingEnabled = True
        Me.cmbTaller.Items.AddRange(New Object() {"Aseguradora", "Personal"})
        Me.cmbTaller.Location = New System.Drawing.Point(119, 56)
        Me.cmbTaller.Name = "cmbTaller"
        Me.cmbTaller.Size = New System.Drawing.Size(121, 23)
        Me.cmbTaller.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(78, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Taller"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(119, 22)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(121, 23)
        Me.txtMonto.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Monto de daños Q"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbRegistro)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cmbGenero)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtEdad)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(130, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(252, 119)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del asegurado"
        '
        'cmbRegistro
        '
        Me.cmbRegistro.FormattingEnabled = True
        Me.cmbRegistro.Items.AddRange(New Object() {"1", "0"})
        Me.cmbRegistro.Location = New System.Drawing.Point(119, 84)
        Me.cmbRegistro.Name = "cmbRegistro"
        Me.cmbRegistro.Size = New System.Drawing.Size(121, 23)
        Me.cmbRegistro.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Código de Registro"
        '
        'cmbGenero
        '
        Me.cmbGenero.FormattingEnabled = True
        Me.cmbGenero.Items.AddRange(New Object() {"M", "F"})
        Me.cmbGenero.Location = New System.Drawing.Point(119, 51)
        Me.cmbGenero.Name = "cmbGenero"
        Me.cmbGenero.Size = New System.Drawing.Size(121, 23)
        Me.cmbGenero.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Género"
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(119, 22)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(121, 23)
        Me.txtEdad.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Edad"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Edad, Me.Genero, Me.Registro, Me.Monto, Me.Taller, Me.Deducible, Me.Aseguradora})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(12, 233)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(746, 188)
        Me.DataGridView1.TabIndex = 1
        '
        'Edad
        '
        Me.Edad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Edad.HeaderText = "Edad"
        Me.Edad.Name = "Edad"
        Me.Edad.ReadOnly = True
        '
        'Genero
        '
        Me.Genero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Genero.HeaderText = "Género"
        Me.Genero.Name = "Genero"
        Me.Genero.ReadOnly = True
        '
        'Registro
        '
        Me.Registro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Registro.HeaderText = "Registro"
        Me.Registro.Name = "Registro"
        Me.Registro.ReadOnly = True
        '
        'Monto
        '
        Me.Monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Monto.HeaderText = "Monto de daños Q"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        '
        'Taller
        '
        Me.Taller.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Taller.HeaderText = "Taller"
        Me.Taller.Name = "Taller"
        Me.Taller.ReadOnly = True
        '
        'Deducible
        '
        Me.Deducible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Deducible.HeaderText = "Deducible Q"
        Me.Deducible.Name = "Deducible"
        Me.Deducible.ReadOnly = True
        '
        'Aseguradora
        '
        Me.Aseguradora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Aseguradora.HeaderText = "Aseguradora Q"
        Me.Aseguradora.Name = "Aseguradora"
        Me.Aseguradora.ReadOnly = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnSalir)
        Me.GroupBox4.Controls.Add(Me.btnLestadisticas)
        Me.GroupBox4.Controls.Add(Me.btnEstadisticas)
        Me.GroupBox4.Controls.Add(Me.btnLvectores)
        Me.GroupBox4.Controls.Add(Me.btnMostrar)
        Me.GroupBox4.Controls.Add(Me.btnAgregar)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 168)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(746, 59)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(591, 22)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(125, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLestadisticas
        '
        Me.btnLestadisticas.Location = New System.Drawing.Point(444, 22)
        Me.btnLestadisticas.Name = "btnLestadisticas"
        Me.btnLestadisticas.Size = New System.Drawing.Size(141, 23)
        Me.btnLestadisticas.TabIndex = 4
        Me.btnLestadisticas.Text = "Limpiar Estadísticas"
        Me.btnLestadisticas.UseVisualStyleBackColor = True
        '
        'btnEstadisticas
        '
        Me.btnEstadisticas.Location = New System.Drawing.Point(325, 21)
        Me.btnEstadisticas.Name = "btnEstadisticas"
        Me.btnEstadisticas.Size = New System.Drawing.Size(113, 23)
        Me.btnEstadisticas.TabIndex = 3
        Me.btnEstadisticas.Text = "Estadísticas"
        Me.btnEstadisticas.UseVisualStyleBackColor = True
        '
        'btnLvectores
        '
        Me.btnLvectores.Location = New System.Drawing.Point(206, 21)
        Me.btnLvectores.Name = "btnLvectores"
        Me.btnLvectores.Size = New System.Drawing.Size(113, 23)
        Me.btnLvectores.TabIndex = 2
        Me.btnLvectores.Text = "Limpiar Memoria"
        Me.btnLvectores.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(125, 22)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrar.TabIndex = 1
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(44, 22)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblE6)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.lblE5)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.lblE4)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.lblE3)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.lblE2)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.lblE1)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 427)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(743, 193)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Estadísticas"
        '
        'lblE6
        '
        Me.lblE6.AutoSize = True
        Me.lblE6.Location = New System.Drawing.Point(156, 166)
        Me.lblE6.Name = "lblE6"
        Me.lblE6.Size = New System.Drawing.Size(0, 15)
        Me.lblE6.TabIndex = 11
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 166)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(144, 15)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Total en monto por daños"
        '
        'lblE5
        '
        Me.lblE5.AutoSize = True
        Me.lblE5.Location = New System.Drawing.Point(130, 139)
        Me.lblE5.Name = "lblE5"
        Me.lblE5.Size = New System.Drawing.Size(0, 15)
        Me.lblE5.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 139)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 15)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Total de conductores"
        '
        'lblE4
        '
        Me.lblE4.AutoSize = True
        Me.lblE4.Location = New System.Drawing.Point(208, 111)
        Me.lblE4.Name = "lblE4"
        Me.lblE4.Size = New System.Drawing.Size(0, 15)
        Me.lblE4.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 111)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(196, 15)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Conductores con registro extranjero"
        '
        'lblE3
        '
        Me.lblE3.AutoSize = True
        Me.lblE3.Location = New System.Drawing.Point(282, 83)
        Me.lblE3.Name = "lblE3"
        Me.lblE3.Size = New System.Drawing.Size(0, 15)
        Me.lblE3.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(270, 15)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Conductores género masculino entre 18 y 25 años"
        '
        'lblE2
        '
        Me.lblE2.AutoSize = True
        Me.lblE2.Location = New System.Drawing.Point(181, 54)
        Me.lblE2.Name = "lblE2"
        Me.lblE2.Size = New System.Drawing.Size(0, 15)
        Me.lblE2.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(169, 15)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Conductores género femenino"
        '
        'lblE1
        '
        Me.lblE1.AutoSize = True
        Me.lblE1.Location = New System.Drawing.Point(196, 29)
        Me.lblE1.Name = "lblE1"
        Me.lblE1.Size = New System.Drawing.Size(0, 15)
        Me.lblE1.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Conductores menores de 25 años"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(768, 632)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accidentes de Tránsito"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbTaller As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbRegistro As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbGenero As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLestadisticas As Button
    Friend WithEvents btnEstadisticas As Button
    Friend WithEvents btnLvectores As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lblE6 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblE5 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblE4 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblE3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblE2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblE1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Edad As DataGridViewTextBoxColumn
    Friend WithEvents Genero As DataGridViewTextBoxColumn
    Friend WithEvents Registro As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents Taller As DataGridViewTextBoxColumn
    Friend WithEvents Deducible As DataGridViewTextBoxColumn
    Friend WithEvents Aseguradora As DataGridViewTextBoxColumn
End Class
