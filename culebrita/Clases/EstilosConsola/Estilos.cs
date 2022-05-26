using culebrita;
using SerpienteProyecto.Clases.BasedeDatos;
using SerpienteProyecto.Clases.Menu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;

namespace SerpienteProyecto.Clases.EstilosConsola
{
    internal class Estilos
    {
        public void margenes(Size size, string title)
        {
            Console.Title = title;
            Console.WindowHeight = size.Height + 2;
            Console.WindowWidth = size.Width + 2;
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Black;
            for (int row = 0; row < size.Height; row++)
            {
                for (int col = 0; col < size.Width; col++)
                {
                    Console.SetCursorPosition(col + 1, row + 1);
                    Console.Write(" ");
                }
            }
        }
        public void EstilosPrincipal(Size size)
        {
            margenes(size, "MENU PRINCIPAL");
        }

        public void EstilosFinales(Size size)
        {
            margenes(size, "MEJORES JUGADORES");
            Console.SetCursorPosition(15, 2);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("--TOP 10 MEJORES PUNTUACIONES--");
            FuncionesJugador jugador = new FuncionesJugador();
            DataTable tabla = new DataTable();
            tabla = jugador.ConsultarCampeones();
            int posicionConsola = 0, posicion = 0;
            foreach (DataRow row in tabla.Rows)
            {
                if (posicion < 10)
                {
                    Console.SetCursorPosition(10, 4 + posicionConsola);
                    if (!(posicion % 2 == 0))
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    posicion++;
                    Console.WriteLine($"{posicion}. Nombre:{row[1]} - Puntos:{row[2]}");
                    posicionConsola += 2;
                }
            }
            Console.SetCursorPosition(25, 25);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("!GAME OVER!");
            Console.SetCursorPosition(10, 28);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("PRESIONA CUALQUIER TECLA, PARA VOLVER A JUGAR");
            Thread.Sleep(1000);
            Console.ReadKey();
            MenuPrincipal main = new MenuPrincipal();
            main.menuInicio();

        }
    }
}
