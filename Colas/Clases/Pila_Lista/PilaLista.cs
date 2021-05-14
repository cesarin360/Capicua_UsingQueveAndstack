using System;
using System.Collections.Generic;
using System.Text;

namespace Colas.Clases.Pila_Lista
{
    class PilaLista
    {
        private static int INICIAL = 19;
        private int cima;
        private List<Object> listaPila;

        public PilaLista()
        {
            cima = -1;
            listaPila = new List<object>();
        }

        public void insertar(Object elemento)
        {
            cima++;
            listaPila.Add(elemento);
            int pausa;
            pausa = 0;
        }

        public Object quitar()
        {
            object aux;
            if (pilaVacia())
            {
                throw new Exception("Pila vacia");
            }
            int pausa;
            pausa = 0;
            aux = listaPila[cima];
            listaPila.RemoveAt(cima);
            cima--;
            pausa = 0;
            return aux;
        }

        public Object cimaPila()
        {
            if (pilaVacia())
            {
                throw new Exception("Pila Vacia");
            }
            return listaPila[cima];
        }

        public void limpiarPila()
        {
            while (!pilaVacia())
            {
                quitar();
            }
        }

        public bool pilaVacia()
        {
            return cima == -1;
        }
    }
}
