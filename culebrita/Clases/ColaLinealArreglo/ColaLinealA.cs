using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SerpienteProyecto.Clases.ColaLinealArreglo
{
    internal class ColaLinealA
    {
        protected int fin;
        protected int frente;
        public int tamanio;
        private static int MAX_TAM = 100000;
        protected Object[] arreglo;

        public ColaLinealA()
        {
            frente = 0;
            fin = -1;
            arreglo = new Object[MAX_TAM];
        }

        //Devuelve si la cola esta vacia
        public bool ColaVacia()
        {
            return frente > fin;
        }

        //Devuelve si la cola esta llena
        public bool ColaLlena()
        {
            if (fin == MAX_TAM - 1) return true;
            else
            {
                return false;
            }
        }
        //Limpia la Cola
        public void LimpiarCola()
        {
            frente = 0;
            fin = -1;
        }

        //Devuelve el tamanio de la cola
        public int TamanioCola()
        {
            return tamanio;
        }

        //Inserta un elemento en la cola de Arreglo
        public void insertarValor(Object elemento)
        {
            if (!ColaLlena())
            {
                arreglo[++fin] = elemento;
                tamanio++;
            }
            else
            {
                throw new Exception("Overflow en la Cola");
            }

        }

        //Remueve frente de la cola de Arreglo
        public Object quitarValor()
        {
            if (!ColaVacia())
            {
                tamanio--;
                return arreglo[frente++];
            }
            else
            {
                throw new Exception("Cola Vacia");
            }
        }

        //Devuelve el elemento frente de la cola de Arreglo
        public Object frenteCola()
        {
            if (!ColaVacia())
            {
                return arreglo[frente++];
            }
            else
            {
                throw new Exception("Cola Vacia");
            }
        }

        //Devuelve el elemento fin de la cola de Arreglo
        public Object finalCola()
        {
            if (!ColaVacia())
            {
                return arreglo[fin];
            }
            else
            {
                throw new Exception("Cola Vacia");
            }
        }


    }
}
