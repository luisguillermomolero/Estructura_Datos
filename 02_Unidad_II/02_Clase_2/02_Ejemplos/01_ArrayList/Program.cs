using System;
using System.Collections;
namespace Aplicacionbase
{
    /* Programa que permite utilizar los métodos iniciales para crear un
     * ArrayList, agregar datos e imprimirlos a traves del Foreach desde el método "imprime"*/
    class Program
    {
        static void ImprimirArrayList(ArrayList arreglo){
            foreach (int n in arreglo)
                Console.Write($"  {n} ");

            Console.WriteLine("\n—————————————");
        }
        static void Main(string[] args)
        {
            ArrayList datos = new ArrayList();

            datos.Add(7);
            datos.Add(5);
            datos.Add(1);

            Console.WriteLine("Tenemos inicialmente los datos:");
            ImprimirArrayList(datos);

            /* Ahora, haremos crecer al arreglo insertando tres nuevos valores. Para 
             * el último valor obtendremos el índice donde fue colocado. Esto
             * lo logramos, a traves del método Add() y obtendremos el indice final del
             * ArrayLits*/

            datos.Add(4);
            datos.Add(5);

            int INDICE = datos.Add(10);
            int CANTIDAD = datos.Count;

            Console.WriteLine("Despues de hacerlo crecer:");
            ImprimirArrayList(datos);


            Console.WriteLine($"El ultimo elemento tiene el indice {CANTIDAD-1}");
            Console.WriteLine("\n—————————————");

            /* Ahora utilizaremos el índice para leer el valor de un elemento 
             * y modificar el valor de otro.*/

            Console.WriteLine($"El valor en el indice 2 es {datos[2]}"); 
            Console.WriteLine("\n—————————————");

            datos[3] = 55;
            Console.WriteLine("Despues de la modificacion:"); 
            ImprimirArrayList(datos);

            /* Ahora, obtendremos la cantidad de elementos que contiene el arreglo 
             * y la desplegaremos en la pantalla.*/


            Console.WriteLine($"La cantidad de elementos es {CANTIDAD} "); 
            Console.WriteLine("\n—————————————");

            // Ahora, insertamos el valor 88 en la posición 2 del ArrayList

            datos.Insert(2,88);
            Console.WriteLine("Despues de la insercion:"); 
            ImprimirArrayList(datos);

            /* Ahora, eliminamos el valor que se encuentra en la posicion 4 del 
             * ArrayList */

            datos.RemoveAt(4);
            Console.WriteLine("Despues de la eliminacion:"); 
            ImprimirArrayList(datos);

            // Ahora, encontraremos el índice del primer valor 5 que consiga

            INDICE = datos.IndexOf(5); 
            Console.WriteLine($"El primer 5 se encuentra en el indice {INDICE}");
            Console.WriteLine("\n—————————————");
        }
    }
}
