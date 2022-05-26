using System;
using System.Collections.Generic;
using System.Text;

namespace SerpienteProyecto.Clases.ColaCircular
{
    internal class ColaCircular
    {
        protected int fin;
        protected int frente;
        public int tamanio;
        private static int MAX_TAM = 100000;
        protected Object[] colaCircular;

        private int siguiente(int r)
        {
            return (r + 1) % MAX_TAM;
        }

        public ColaCircular()
        {
            fin = -1;
            frente = 0;
            colaCircular = new Object[MAX_TAM];
        }

        //Devuelve si la cola esta vacia
        public bool ColaVacia()
        {
            return frente == siguiente(fin);
        }

        //Devuelve si la cola esta llena
        public bool ColaLlena()
        {
            return fin == siguiente(siguiente(fin));
        }

        //Borrar Cola
        public void BorrarCola()
        {
            fin = MAX_TAM - 1;
            frente = 0;
        }
        //Devuelve el tamanio de la cola
        public int TamanioCola()
        {
            return tamanio;
        }

        //Inserta un elemento en la cola de Circular
        public void insertarValor(Object elemento)
        {
            if (!ColaLlena())
            {
                fin = siguiente(fin);
                colaCircular[fin] = elemento;
                tamanio++;
            }
            else
            {
                throw new Exception("Overflow en la Cola");
            }
        }

        //Remueve frente de la cola 
        public Object quitarValor()
        {

            if (!ColaVacia())
            {
                Object elemento = colaCircular[frente];
                frente = siguiente(frente);
                tamanio--;
                return elemento;
            }
            else
            {
                throw new Exception("Cola Vacia");
            }
        }

        //Devuelve el elemento frente de la cola 
        public Object frenteCola()
        {
            if (!ColaVacia())
            {
                return colaCircular[frente];
            }
            else
            {
                throw new Exception("Cola Vacia");
            }
        }

        //Devuelve el elemento fin de la cola 
        public Object finalCola()
        {
            if (!ColaVacia())
            {
                return colaCircular[fin];
            }
            else
            {
                throw new Exception("Cola Vacia");
            }
        }






    }
}
