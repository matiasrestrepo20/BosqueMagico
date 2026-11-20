Bosque Mágico
Proyecto 4 — Lenguajes de Programación
Universidad EAFIT · 2026

Bosque Mágico es un juego de plataformas 2D creado en Unity 6.3 con C#. El jugador recorre dos escenarios, recoge monedas y pociones, evita enemigos y busca las llaves que permiten avanzar y completar el juego.
Niveles
- Nivel 1: Bosque Encantado. Un bosque nocturno de tonos azules. El objetivo es superar las plataformas y conseguir la llave para pasar al siguiente escenario.
- Nivel 2: Bosque Carmesí. Un bosque de tonos rojizos con otro recorrido de plataformas y enemigos. Al encontrar la llave final, aparece la pantalla de victoria.
Controles
Acción	Control
Moverse	A / D o flechas izquierda / derecha
Saltar	Espacio
Pausar y continuar	Botones de la interfaz
Navegar por los menús	Mouse


Mecánicas del juego
- Movimiento horizontal, salto, gravedad y colisiones 2D.
- Escenarios construidos con Tilemaps y plataformas con colliders.
- Animaciones del personaje: quieto, correr, saltar y caer.
- Monedas: 10 puntos cada una.
- Pociones: 25 puntos cada una.
- HUD con puntuación, cantidad de coleccionables y vidas restantes.
- Tres vidas. Al recibir daño de un enemigo, el personaje pierde una vida y obtiene un breve período de invulnerabilidad.
- Pantalla de derrota con opción para reintentar el nivel.
- Llaves para avanzar al Nivel 2 y finalizar el juego.
- Música de fondo en cada nivel y efectos de sonido para objetos y daño.
Tres características adicionales
1. Puntos de control (checkpoints)
Agregamos checkpoints para que el jugador no tenga que repetir todo el recorrido cuando cae al vacío. Al pasar por un punto de control, el juego guarda su posición de reaparición. Si toca la zona de muerte, vuelve a esa ubicación; si no ha activado ningún checkpoint, regresa al inicio.

La lógica está en Muerte.cs y utiliza OnTriggerEnter2D, colliders configurados como Trigger y las etiquetas Checkpoint y Muerte.
2. Dos enemigos con comportamientos diferentes
El caracol patrulla horizontalmente una parte de la plataforma y cambia de dirección al llegar al límite de su recorrido (Caracol.cs). La abeja detecta al jugador dentro de un rango y lo persigue horizontalmente, manteniendo su altura de vuelo para que sea posible esquivarla saltando (Abeja.cs).

Los dos interactúan con VidaJugador.cs, que controla el daño, las vidas y la invulnerabilidad temporal. De esta manera, cada enemigo obliga a superar un obstáculo distinto.
3. Progresión entre niveles
La llave del primer bosque carga la escena Nivel2 mediante SceneManager (LlaveFinal.cs). En el segundo nivel, la llave muestra el panel de victoria y pausa el juego (VictoriaNivel2.cs). Desde esa pantalla se puede volver a jugar desde el principio o regresar al menú principal.

También se implemento la opción de reintentar el nivel actual después de perder las tres vidas. Para esta navegación utilizamos BotonReinicio.cs y MenuPausa.cs.
Menús e interfaz
El juego incluye un menú principal con Jugar, Créditos, Configuración y Salir. Antes de empezar el primer nivel aparece un panel con los controles y el objetivo del juego. Ese panel mantiene la partida en pausa hasta pulsar Continuar.

Durante la partida hay un botón de pausa que abre las opciones Continuar, Configuración y Volver al menú. La configuración es visual, como se solicita en la actividad: los controles del panel no cambian los ajustes reales del juego.

En caso de derrota aparece Game Over con el botón Reintentar. Al superar el segundo nivel se muestra la victoria, con opciones para Volver a jugar o Ir al menú principal.
Herramientas utilizadas
- Unity 6.3 y C#.
- Visual Studio para los scripts.
- Git y GitHub Desktop para control de versiones.
- Componentes de Unity: Tilemap, Rigidbody2D, Collider2D, Animator, AudioSource, TextMeshPro y SceneManager.
Recursos
- Gráficos: Legacy Fantasy – High Forest, paquete de arte pixel art obtenido en itch.io.
- Música: Forest Whisper Theme para el primer nivel y una pista ambiental distinta para el segundo.
- Efectos: sonidos de monedas, pociones y daño.
Cómo ejecutar
1. Descargar el archivo BosqueMagico_Entrega.zip entregado junto al proyecto.
2. Extraer su contenido completo.
3. Abrir BosqueMagico.exe en Windows.
4. Seleccionar Jugar en el menú principal.
El ejecutable debe mantenerse junto a la carpeta BosqueMagico_Data y los demás archivos generados por Unity.

Para abrir el proyecto desde el código fuente, clonar este repositorio en Unity Hub con una versión compatible de Unity 6.3 y abrir la escena MenuPrincipal.
Autor
Matías Restrepo
Universidad EAFIT — Lenguajes de Programación, 2026
