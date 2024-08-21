using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas
{
    public class Pilas : IColeccion
    {

         private object[] elementos;
         private int contador;


         // Constructor que inicializa la pila con una capacidad inicial
         public Pilas(int tamaño )
         {
             elementos = new object[tamaño];
             contador = 0;

         }

         // Verifica si la pila está vacía
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

         // Extrae y elimina el primer elemento de la pila
         public object Extraer()
         {
             if (EstaVacia())
             {
                 return null; 
             }

             object item = elementos[--contador];
             return item;



        }

         // Devuelve el primer elemento de la pila sin eliminarlo
         public object Primero()
         {
             if (EstaVacia())
             {
                 return null; 
             }

             return elementos[contador-1];
         }

         // Añade un objeto al final de la pila
         public bool Añadir(object elemento)
         {
            if (contador >= elementos.Length)
            {
                return false; 
            }

            elementos[contador++] = elemento;
            return true;
        }

 


    }
}
