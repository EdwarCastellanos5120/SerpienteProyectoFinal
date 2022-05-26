        //convertirlo en un programa orietado a objetos (LISTO)
        //emitir beep cuando coma la comida (LISTO)
        //incrementar la velocidad conforme vaya avanzando(LISTO)
        //modificar el uso de queue y reemplazarlo con la estructura de cola vista en clase
        //colalinal arreglo(LISTO)
		//colaCircular(LISTO)
        //cola arraylist (LISTO)
        //cola lista enlazada(LISTO)
        // explicar qué pasa al alterar cada una de las lineas marcadas con las preguntas(LISTO)
        // se aprecia si pueden cambiar las reglas del juego o si le agrega cosas extra(AGREGADO Y LISTO)

		
        Modificar var velocidad:
		Al modificar esta variable controlaremos la velocidad con la que se mueve la serpiente al inicio del
		juego si el valor es mayor se va comportar de manera mas lenta y si es menor se va comportar de manera mas rapida.
		
		Modificar var longitudCulebras:
		Al modificar esta variable controlaremos la longitud de la serpiente que se crea al inicio del juego.
		
		Modificar PosicionActual:
		Modificaremos las coordenadas de inicio de la serpiente.
		
		Modificar var direccion:
		Modificaremos la orientacion de inicio de la serpiente.

		Modificar longitudculebra++:
		Si modificamos esta linea aumentaremos el tamano de la serpiente o la haremos mas pequena cada vez que coma.
		
		Modificar Punteo:
		Vamos a modificar la cantidad de puntos que da comer.
		
		(posiciónComida == Point.Empty):
		Si la posición de la comida es igual a Point.Empty significa que no hay comida en el tablero Y llama la funcion
		mostrarcomida para colocar una nueva comida en el tablero.