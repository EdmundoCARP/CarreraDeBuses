<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBuses
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblTitulo = New Label()
        pbBus1 = New ProgressBar()
        lblBus2 = New Label()
        lblBus1 = New Label()
        lblBus3 = New Label()
        lblEstado1 = New Label()
        lblEstado2 = New Label()
        lblEstado3 = New Label()
        lblGanador = New Label()
        pbBus2 = New ProgressBar()
        pbBus3 = New ProgressBar()
        btnIniciar = New Button()
        btnSalir = New Button()
        tmrEstados = New Timer(components)
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitulo.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        lblTitulo.Location = New Point(13, 9)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(285, 30)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Managua -- Esteli -- 150 km"
        ' 
        ' pbBus1
        ' 
        pbBus1.Location = New Point(77, 51)
        pbBus1.Maximum = 150
        pbBus1.Name = "pbBus1"
        pbBus1.Size = New Size(387, 53)
        pbBus1.Step = 5
        pbBus1.TabIndex = 1
        ' 
        ' lblBus2
        ' 
        lblBus2.AutoSize = True
        lblBus2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBus2.Location = New Point(13, 145)
        lblBus2.Name = "lblBus2"
        lblBus2.Size = New Size(37, 15)
        lblBus2.TabIndex = 2
        lblBus2.Text = "Bus 2"
        ' 
        ' lblBus1
        ' 
        lblBus1.AutoSize = True
        lblBus1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBus1.Location = New Point(13, 68)
        lblBus1.Name = "lblBus1"
        lblBus1.Size = New Size(37, 15)
        lblBus1.TabIndex = 3
        lblBus1.Text = "Bus 1"
        ' 
        ' lblBus3
        ' 
        lblBus3.AutoSize = True
        lblBus3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBus3.Location = New Point(13, 236)
        lblBus3.Name = "lblBus3"
        lblBus3.Size = New Size(37, 15)
        lblBus3.TabIndex = 4
        lblBus3.Text = "Bus 3"
        ' 
        ' lblEstado1
        ' 
        lblEstado1.AutoSize = True
        lblEstado1.Location = New Point(499, 68)
        lblEstado1.Name = "lblEstado1"
        lblEstado1.Size = New Size(58, 15)
        lblEstado1.TabIndex = 30
        lblEstado1.Text = "Sin iniciar"
        ' 
        ' lblEstado2
        ' 
        lblEstado2.AutoSize = True
        lblEstado2.Location = New Point(499, 145)
        lblEstado2.Name = "lblEstado2"
        lblEstado2.Size = New Size(58, 15)
        lblEstado2.TabIndex = 6
        lblEstado2.Text = "Sin iniciar"
        ' 
        ' lblEstado3
        ' 
        lblEstado3.AutoSize = True
        lblEstado3.Location = New Point(499, 236)
        lblEstado3.Name = "lblEstado3"
        lblEstado3.Size = New Size(58, 15)
        lblEstado3.TabIndex = 7
        lblEstado3.Text = "Sin iniciar"
        ' 
        ' lblGanador
        ' 
        lblGanador.BackColor = SystemColors.Info
        lblGanador.BorderStyle = BorderStyle.FixedSingle
        lblGanador.Font = New Font("Segoe UI", 14F)
        lblGanador.ForeColor = Color.Green
        lblGanador.Location = New Point(34, 300)
        lblGanador.Name = "lblGanador"
        lblGanador.Size = New Size(734, 40)
        lblGanador.TabIndex = 8
        lblGanador.Text = "Ganador : -"
        lblGanador.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pbBus2
        ' 
        pbBus2.Location = New Point(77, 217)
        pbBus2.Maximum = 150
        pbBus2.Name = "pbBus2"
        pbBus2.Size = New Size(387, 52)
        pbBus2.Step = 5
        pbBus2.TabIndex = 9
        ' 
        ' pbBus3
        ' 
        pbBus3.Location = New Point(77, 130)
        pbBus3.Maximum = 150
        pbBus3.Name = "pbBus3"
        pbBus3.Size = New Size(387, 52)
        pbBus3.Step = 5
        pbBus3.TabIndex = 10
        ' 
        ' btnIniciar
        ' 
        btnIniciar.Location = New Point(360, 373)
        btnIniciar.Name = "btnIniciar"
        btnIniciar.Size = New Size(166, 39)
        btnIniciar.TabIndex = 11
        btnIniciar.Text = "Inicar Carrera"
        btnIniciar.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(613, 373)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(140, 39)
        btnSalir.TabIndex = 12
        btnSalir.Text = "Salir "
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' FrmBuses
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(807, 450)
        Controls.Add(btnSalir)
        Controls.Add(btnIniciar)
        Controls.Add(pbBus3)
        Controls.Add(pbBus2)
        Controls.Add(lblGanador)
        Controls.Add(lblEstado3)
        Controls.Add(lblEstado2)
        Controls.Add(lblEstado1)
        Controls.Add(lblBus3)
        Controls.Add(lblBus1)
        Controls.Add(lblBus2)
        Controls.Add(pbBus1)
        Controls.Add(lblTitulo)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmBuses"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Carrera de Buses Managua - Esteli "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents pbBus1 As ProgressBar
    Friend WithEvents lblBus2 As Label
    Friend WithEvents lblBus1 As Label
    Friend WithEvents lblBus3 As Label
    Friend WithEvents lblEstado1 As Label
    Friend WithEvents lblEstado2 As Label
    Friend WithEvents lblEstado3 As Label
    Friend WithEvents lblGanador As Label
    Friend WithEvents pbBus2 As ProgressBar
    Friend WithEvents pbBus3 As ProgressBar
    Friend WithEvents btnIniciar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents tmrEstados As Timer

End Class
