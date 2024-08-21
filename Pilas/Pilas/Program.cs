using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilas pila = new Pilas(10);
            if (pila.EstaVacia())
            {
                Console.WriteLine("Pila Vacia");

            }
            else { Console.WriteLine("Pila No Vacia"); }


            pila.Añadir(1);
            pila.Añadir(15); 
            object primero = pila.Primero();
            Console.WriteLine("el primero es " + primero);
            pila.Añadir(20);
            object extraido = pila.Extraer();
            Console.WriteLine("el extraido es " + extraido);
            pila.Añadir(25);
            pila.Añadir(30);
            object primero2 = pila.Primero();
            Console.WriteLine("el primero es " + primero2);


            if (pila.EstaVacia())
            {
                Console.WriteLine("Pila Vacia");

            }
        else { Console.WriteLine("Pila No Vacia"); }
                
                
        }




    }
}