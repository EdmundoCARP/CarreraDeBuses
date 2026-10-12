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

    ' Se completa en el siguiente paso
    Private Sub Viajar()
    End Sub

End Class
