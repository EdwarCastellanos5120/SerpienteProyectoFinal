using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SerpienteProyecto.Clases.ColaListaEnlazada
{
    internal class ColaListaE
    {
        public Nodo _primero;
        public Nodo _ultimo;
        int tamanio;

        public ColaListaE()
        {
            _primero = null;
            _ultimo = null;
        }

        //Devuelve si la Cola esta vacia
        public bool ColaVacia()
        {
            return _primero == null;
        }

        // Devuelve el tamaño de la Cola
        public int TamanioCola()
        {
            return tamanio;
        }

        // Devuelve el frende de la Cola
        public Object frenteCola()
        {
            if (ColaVacia())
            {
                throw new Exception("Cola Vacia");
            }
            return (_primero.elemento);
        }

        // Devuelve el fin de la Cola
        public Object finalCola()
        {
            if (ColaVacia())
            {
                throw new Exception("Cola Vacia");
            }
            return (_ultimo.elemento);
        }

        //Inserta un elemento en la cola de ListaEnlazada
        public void insertarValor(Object elemento)
        {
            Nodo nuevo = new Nodo(elemento);
            if (!ColaVacia())
            {
                _ultimo.siguiente = nuevo;
            }
            else
            {
                _primero = nuevo;
            }
            _ultimo = nuevo;
            tamanio++;
        }

        //Quita un valor de la Cola ListaEnlazada
        public Object quitarValor()
        {
            Object auxiliar;
            if (!ColaVacia())
            {
                auxiliar = _primero.elemento;
                _primero = _primero.siguiente;
                tamanio--;
            }
            else
            {
                throw new Exception("Cola Vacia");
            }

            return auxiliar;
        }

        //Devuelve el Numero de Elementos de la Lista
        public int numeroElementosLista()
        {
            int numero;
            Nodo nodo = _primero;
            if (!ColaVacia())
            {
                numero = 1;
                while (nodo != _ultimo)
                {
                    numero++;
                    nodo = nodo.siguiente;
                }
            }
            else
            {
                numero = 0;
            }
            return numero;
        }
    }
}
