using System;
using System.Collections;


namespace AplicacionBase
{

    public class Program
    {
        public static void Main()
        {
            string palabra;

            Queue miCola = new Queue();  // Creamos una cola

            //  Llenamos la cola

            miCola.Enqueue("Hola,");
            miCola.Enqueue("soy");
            miCola.Enqueue("yo");

            //  Imprimir la cola

            for (byte i = 0; i < 3; i++)
            {
                palabra = (string)miCola.Dequeue();  // Dequeue: Muestra y luego elimina el primer elemento de la cola
                Console.WriteLine(palabra);
            }
            Console.ReadKey();
        }
    }
}
