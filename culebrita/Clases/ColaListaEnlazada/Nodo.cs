using System;
using System.Collections.Generic;
using System.Text;

namespace SerpienteProyecto.Clases.ColaListaEnlazada
{
    internal class Nodo
    {
        public Object elemento;
        public Nodo siguiente;

        public Nodo(Object elemento)
        {
            this.elemento = elemento;
            this.siguiente = null;
        }
    }
}
