Imports System.Threading

Partial Class FrmBuses

    Private hilos As Thread()

    Private Sub IniciarHilos()
        hilos = New Thread(2) {}

        Dim barras As ProgressBar() = {
            pbBus1, pbBus2, pbBus3
        }

        For i As Integer = 0 To 2
            Dim indice As Integer = i

            hilos(i) = New Thread(
                Sub()
                    Viajar(indice, barras(indice))
                End Sub
            )

            hilos(i).Name = "Bus " & (i + 1).ToString()
            hilos(i).IsBackground = True
        Next

        For i As Integer = 0 To 2
            hilos(i).Start()
        Next
    End Sub

    Private Sub Viajar(indice As Integer, barra As ProgressBar)
        Dim aleatorio As New Random(
            Environment.TickCount + indice * 1000
        )

        For km As Integer = 5 To 150 Step 5
            If cerrando OrElse IsDisposed Then Return

            Thread.Sleep(aleatorio.Next(50, 201))

            If cerrando OrElse IsDisposed Then Return

            Try
                Me.Invoke(New MethodInvoker(
                    Sub()
                        barra.Value = km
                    End Sub
                ))
            Catch ex As InvalidOperationException
                Return
            Catch ex As ObjectDisposedException
                Return
            End Try
        Next

        Dim soyGanador As Boolean = False
        Dim nombreBus As String = Thread.CurrentThread.Name

        SyncLock candado
            If String.IsNullOrEmpty(ganador) Then
                ganador = nombreBus
                soyGanador = True
            End If
        End SyncLock

        If soyGanador AndAlso Not cerrando AndAlso Not IsDisposed Then
            Try
                Me.Invoke(New MethodInvoker(
                    Sub()
                        lblGanador.Text = "Ganador: " & nombreBus
                    End Sub
                ))
            Catch ex As InvalidOperationException
                Return
            Catch ex As ObjectDisposedException
                Return
            End Try
        End If
    End Sub

End Class