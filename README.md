# Proyecto_VR
Repo para el proyecto de realidad virtual de la práctica de Interfaces Inteligentes




Cuestiones importantes para el uso
Hitos de programación logrados relacionándolos con los contenidos que se han impartido
Aspectos que destacarías en la aplicación. Especificar si se han incluido sensores de los que se han trabajado en interfaces multimodales.
## Interactuación con el juego

La interactuación con el juego es bastante sencilla, el jugador se encontrará en
una sala que representa una casilla del mapa. Esta sala tendrá 4 puertas, Norte,
Sur, Este y Oeste. Cuando el jugador mire a una de las puertas encima de esta
aparecerá un letrero que le indica la dirección a la que le llevaría el camino si
eligiese avanzar por dicha puerta.


Para realizar un movimiento de una sala a otra, en el lado derecho de cada
puerta habrá un botón, si el jugador hace click o pulsa el botón mientras está
apuntando hacia el este abrirá la puerta mediante el uso de un evento y el jugador
avanzará a la casilla siguiente.


El jugador dispone de dos sensores, un sensor de viento y un sensor de hedor.
Estos sensores mostrarán la información en la parte superior izquierda de la
pantalla y funcionan de la siguiente manera:


* Si el jugador detecta viento, existe al menos un agujero en una de las
casillas adyacentes a la del jugador (no diagonales).
* Si el jugador detecta un hedor, el Wumpus se encuentra en una de las
casillas adyacentes a la del jugador (no diagonales).


De forma adicional el jugador dispone de un mapa donde se irá representando la
información que este tiene en cada momento sobre el mundo Wumpus, es decir, en
el mapa aparecerán marcadas con una "W" las casillas en las que haya detectado
viento, aparecerán marcadas con una "S" las casillas en las que haya detectado un
hedor. En caso de que haya detectado viento y hedor en esa casilla en el mapa
aparecerá representado con una "X". Por último, la posición actual del jugador
además de mostrarse en la zona de los sensores, se representa con una "P" en el
mapa de conocimiento.

## Ejecución

## Acta de los acuerdos del grupo

La mayor parte de las tareas se han llevado de forma conjunta mediante el uso de
Discord como herramienta de comunicación u otras como documentos de Google o
presentaciones para generar este tipo de documentación. Además, se ha hecho uso
de la plataforma GitHub para alojar el código y poder trabajar en paralelo mediante el
control de versiones que esta proporciona.

Tareas llevadas de forma individual:

* Testeo del paquete de Google VR (Todos).
* Ideas a implementar en el proyecto final (Adrián).
* Resolución de dudas para la correcta importación del paquete (Adrián y Óscar).
* Búsqueda de texturas (Aram y Óscar).

Tareas llevadas a cabo de forma conjunta:

* Implementación del juego en Unity.
* Testeo del juego tanto en ordenador como en un dispositivo móvil.
* Informe y presentación del proyecto.
* Redacción del informe.
* Preparación de la presentación.
