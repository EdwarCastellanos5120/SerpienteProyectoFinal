using SerpienteProyecto.Clases.ColaArrayList;
using SerpienteProyecto.Clases.ColaCircular;
using SerpienteProyecto.Clases.ColaLinealArreglo;
using SerpienteProyecto.Clases.ColaListaEnlazada;
using SerpienteProyecto.Clases.EstilosConsola;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SerpienteProyecto.Clases.Menu
{
    internal class MenuPrincipal
    {
        public void menuInicio()
        {
            bool repetir = true;
            do
            {
                Estilos estilos = new Estilos();
                estilos.EstilosPrincipal(new Size(60, 30));
                Console.SetCursorPosition(11, 2);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("--BIENVENIDO AL JUEGO DE LA SERPIENTE--");
                Console.SetCursorPosition(15, 3);
                Console.WriteLine("Ingrese el nombre del jugador:");
                Console.SetCursorPosition(25, 4);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                string nombre = Console.ReadLine();
                Console.SetCursorPosition(15, 6);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Selecciona el modo de juego");
                Console.SetCursorPosition(15, 7);
                Console.WriteLine("1. Serpiente Arreglo");
                Console.SetCursorPosition(15, 8);
                Console.WriteLine("2. Serpiente ArrayList");
                Console.SetCursorPosition(15, 9);
                Console.WriteLine("3. Serpiente Lista Enlazada");
                Console.SetCursorPosition(15, 10);
                Console.WriteLine("4. Serpiente ColaCircular");
                Console.SetCursorPosition(15, 11);
                Console.WriteLine("5. ABANDONAR");
                Console.SetCursorPosition(15, 12);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("-----> ");
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        SerpienteArreglo _arreglo = new SerpienteArreglo();
                        _arreglo.serpienteArreglo(nombre);
                        break;

                    case 2:
                        SerpienteArray _arrayList = new SerpienteArray();
                        _arrayList.serpienteArray(nombre);
                        break;

                    case 3:
                        SerpienteListaEnlazada _listaEnlazada = new SerpienteListaEnlazada();
                        _listaEnlazada.serpienteListaEnlazada(nombre);
                        break;
                    case 4:
                        SerpienteCircular _colaCircular = new SerpienteCircular();
                        _colaCircular.serpienteCircular(nombre);
                        break;

                    case 5:
                        repetir = false;
                        break;

                    default:
                        Console.SetCursorPosition(15, 12);
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            } while (repetir);
        }
    }
}
