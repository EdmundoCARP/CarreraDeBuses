Public Class FrmBuses

    Private cerrando As Boolean = False
    Private ganador As String = String.Empty
    Private ReadOnly candado As New Object()

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        If cerrando Then Return

        pbBus1.Value = 0
        pbBus2.Value = 0
        pbBus3.Value = 0

        lblEstado1.Text = "Sin iniciar"
        lblEstado2.Text = "Sin iniciar"
        lblEstado3.Text = "Sin iniciar"
        lblGanador.Text = "Ganador: —"

        SyncLock candado
            ganador = String.Empty
        End SyncLock

        btnIniciar.Enabled = False
        IniciarHilos()
        tmrEstados.Start()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmBuses_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        cerrando = True
        tmrEstados.Stop()
    End Sub

End Class
