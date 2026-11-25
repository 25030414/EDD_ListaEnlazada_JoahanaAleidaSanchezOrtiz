using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEnlazada.Logica
{
    public class Nodo
    {
         public int Dato { get; set; }
         public Nodo Siguiente { get; set; }

        public Nodo(int dato, Nodo siguiente = null)
        {
            Dato = dato;
            Siguiente = siguiente;
        }


    }
}
