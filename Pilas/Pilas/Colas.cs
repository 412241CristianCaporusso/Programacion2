using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas
{
    public class Colas : IColeccion
    {
        private object[] elementos;
        private int contador;


        // Constructor que inicializa la pila con una capacidad inicial
        public Colas(int tamaño)
        {
            elementos = new object[tamaño];
            contador = 0;
        }
        public bool EstaVacia()
        {
            if (contador == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object Extraer()
        { return false; }

        public object Primero()
        {
            {
                if (EstaVacia())
                {
                    return null;
                }

                return elementos[1];
            }
        }
        public bool Añadir(object elemento)
        { return false; }

    }
}

