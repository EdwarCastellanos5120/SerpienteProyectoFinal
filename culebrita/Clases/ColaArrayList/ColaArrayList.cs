using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SerpienteProyecto.Clases.ColaArrayList
{
    internal class ColaArrayList
    {
        protected int fin;
        protected int frente;
        protected ArrayList array;

        public ColaArrayList()
        {
            fin = -1;
            frente = 0;
            array = new ArrayList();
        }

        //Devuelve si la cola de ArrayList esta vacia
        public bool ColaVacia()
        {
            return frente > fin;
        }
        //Devuelve si la cola de ArrayList esta llena
        public bool colaLLena()
        {
            return array.Count == array.Capacity;
        }

        //Devuelve el tamano de la cola de ArrayList
        public int TamanioCola()
        {
            return array.Count;
        }

        //Inserta un elemento en la cola de ArrayList
        public void insertarValor(Object elemento)
        {
            array.Add(elemento);
            ++fin;
        }

        //Remueve frente de la cola de ArrayList
        public Object quitarValor()
        {
            Object auxiliar;
            if (!ColaVacia())
            {
                auxiliar = array[frente];
                array.RemoveAt(frente);
                fin--;
                return auxiliar;
            }
            else
            {
                throw new Exception("Cola Vacia");
            }
        }

        //Devuelve el elemento fin de la cola de ArrayList
        public Object finalCola()
        {
            if (!ColaVacia())
            {
                return array[fin];
            }
            else
            {
                throw new Exception("Cola Vacia");
            }
        }
    }
}