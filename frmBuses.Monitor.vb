Partial Class FrmBuses



    Private Sub tmrEstados_Tick(
        sender As Object,
        e As EventArgs
    ) Handles tmrEstados.Tick

        If hilosBuses Is Nothing Then Return

        Dim estados As Label() = {
            lblEstado1,
            lblEstado2,
            lblEstado3
        }

        Dim todosDetenidos As Boolean = True

        For i As Integer = 0 To 2
            If hilosBuses(i) Is Nothing Then
                estados(i).Text = "Sin iniciar"
                todosDetenidos = False
            Else
                estados(i).Text = hilosBuses(i).ThreadState.ToString()

                If Not hilosBuses(i).IsAlive Then
                    ' El hilo ya terminó.
                Else
                    todosDetenidos = False
                End If
            End If
        Next

        If todosDetenidos Then
            tmrEstados.Stop()

            For i As Integer = 0 To 2
                estados(i).Text = "Finalizado"
            Next

            btnIniciar.Enabled = True
        End If

    End Sub

End Class
