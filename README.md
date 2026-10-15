# CarreraDeBuses

yo me encargué de la parte de hilos: creé los tres hilos de los buses (Bus 1, Bus 2 y Bus 3) en segundo plano, implementé el método Viajar() que hace avanzar cada bus de 5 en 5 km con pausas aleatorias, actualicé las barras de forma segura con Invoke y agregué el cierre seguro para que los hilos no toquen la interfaz al cerrar. Mi compañero se encargó de la interfaz del formulario, el botón Iniciar, el cierre de la ventana, el temporizador que muestra los estados de los hilos, el candado y la variable que registra al ganador con SyncLocv

Se abre el proyecto con Visual Studio 2026 (carga de trabajo de escritorio de .NET), clonando el repositorio o abriendo la carpeta `CarreraDeBuses`. Abre la solución, compila con Reconstruir solución y ejecuta con F5. El formulario de inicio es FrmBuses y el proyecto usa .NET 10 con Windows Forms en Visual Basic.


Captura de la carrera en curso
<img width="1174" height="694" alt="image" src="https://github.com/user-attachments/assets/c962daa1-5e3f-4aba-9bc7-c64a4c03cd20" />

Captura de la carrera al finalizar
<img width="1174" height="697" alt="image" src="https://github.com/user-attachments/assets/e8931f40-0c7c-4e56-9802-9fe847b3f5c8" />


La ventana no se congela porque la carrera corre en tres hilos aparte, uno por bus, y el hilo de la interfaz queda libre para atender clics y mover la ventana. En las etiquetas vimos sobre todo WaitSleepJoin, porque cada bus pasa casi todo el tiempo durmiendo entre pasos, y Background, porque son hilos de segundo plano; al llegar a Estelí aparece Stopped. Solo hay un ganador porque el primer bus que llega toma un candado y registra su nombre; los demás tienen que esperar, y cuando les toca el nombre ya está ocupado, así que no se anotan.

