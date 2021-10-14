using System;
using System.Collections;

/*
Escriba una rutina que reciba dos Colas "C1" y "C2" de números enteros y devuelva una nueva Cola con los elementos concatenados en el orden de las colas "C1" y "C2". 
*/

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se instancian las nuevas colas
            Queue ColaC1 = new Queue();
            Queue ColaC2 = new Queue();
            Queue ColaC3 = new Queue();

            // Se cargan las colas "C1" y "C2" con valores
            ColaC1.Enqueue(1);
            ColaC1.Enqueue(2);
            ColaC1.Enqueue(3);
            ColaC1.Enqueue(4);

            ColaC2.Enqueue(5);
            ColaC2.Enqueue(6);
            ColaC2.Enqueue(7);
            ColaC2.Enqueue(8);

            // Se imprimen las colas "C1" y "C2" y se carga la cola resultante
            Console.WriteLine("Cola 1");
            Console.WriteLine();
            while (ColaC1.Count > 0)
            {
                int Co = 0;
                Co = (int)ColaC1.Dequeue();
                Console.Write(" ["+Co+"] ");
                ColaC3.Enqueue(Co);
                Console.WriteLine();

            }
            Console.WriteLine();

            Console.WriteLine("Cola 2");
            Console.WriteLine();
            while (ColaC2.Count > 0)
            {
                int Co = 0;
                Co = (int)ColaC2.Dequeue();
                Console.Write(" [" + Co + "] ");
                ColaC3.Enqueue(Co);
                Console.WriteLine();
            }
            Console.WriteLine();

            // Se imprime la cola resultante
            Console.WriteLine("Union de las dos colas");
            Console.WriteLine();
            while (ColaC3.Count > 0)
            {
                int Co = 0;
                Co = (int)ColaC3.Dequeue();
                Console.WriteLine(" [" + Co + "] ");
            }
            Console.WriteLine();
        }
    }
}