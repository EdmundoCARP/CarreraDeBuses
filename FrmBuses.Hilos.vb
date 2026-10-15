Imports System.Threading

Partial Class FrmBuses

    ' Un hilo por bus. Se crean de nuevo en cada carrera.
    Private hilosBuses(2) As Thread

    ' Crea los tres hilos y los arranca. No bloquea la ventana.
    Friend Sub IniciarCarrera()
        ' Si ya hay una carrera en curso, no hacemos nada
        For Each h As Thread In hilosBuses
            If h IsNot Nothing AndAlso h.IsAlive Then Return
        Next

        For i As Integer = 0 To 2
            Dim hilo As New Thread(AddressOf Viajar)
            hilo.Name = "Bus " & (i + 1).ToString()   ' Name se asigna una sola vez
            hilo.IsBackground = True                   ' debe ir antes de Start
            hilosBuses(i) = hilo
        Next

        For Each hilo As Thread In hilosBuses
            hilo.Start()
        Next
    End Sub

    ' Método que ejecutan los tres buses
    Private Sub Viajar()
        Dim nombre As String = Thread.CurrentThread.Name
        Dim barra As ProgressBar = ObtenerBarra(nombre)
        If barra Is Nothing Then Return

        ' Random propio de este hilo
        Dim rnd As New Random(Environment.TickCount Xor Thread.CurrentThread.ManagedThreadId)

        For km As Integer = 5 To 150 Step 5
            ' Cierre seguro: si el formulario se está cerrando, salimos sin tocar la interfaz
            If cerrando OrElse Me.IsDisposed Then Return

            Dim valor As Integer = km   ' copia local para la lambda
            Try
                Me.Invoke(New MethodInvoker(Sub() barra.Value = valor))
            Catch ex As ObjectDisposedException
                Return
            Catch ex As InvalidOperationException
                Return
            End Try

            Thread.Sleep(rnd.Next(50, 201))   ' 50 a 200 ms, fuera del Invoke
        Next

        ' Sección crítica: solo el primero que llega se registra como ganador
        Dim soyGanador As Boolean = False
        SyncLock candado
            If String.IsNullOrEmpty(ganador) Then
                ganador = nombre
                soyGanador = True
            End If
        End SyncLock

        ' Fuera del SyncLock, mostramos el ganador en la interfaz
        If soyGanador AndAlso Not cerrando AndAlso Not Me.IsDisposed Then
            Try
                Me.Invoke(New MethodInvoker(Sub() lblGanador.Text = "Ganador: " & nombre))
            Catch ex As ObjectDisposedException
            Catch ex As InvalidOperationException
            End Try
        End If
    End Sub

    ' Devuelve la barra que corresponde al nombre del hilo
    Private Function ObtenerBarra(nombre As String) As ProgressBar
        Select Case nombre
            Case "Bus 1" : Return pbBus1
            Case "Bus 2" : Return pbBus2
            Case "Bus 3" : Return pbBus3
            Case Else : Return Nothing
        End Select
    End Function

End Class