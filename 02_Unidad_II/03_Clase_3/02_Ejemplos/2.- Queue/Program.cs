using System;
using System.Collections;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando un nuevo objeto Queue(Cola)

            Queue cola = new Queue();

            //agrego elementos a la cola

            cola.Enqueue("Perro");
            cola.Enqueue("Gato");
            cola.Enqueue("Loro");
            cola.Enqueue("Tigre");
            cola.Enqueue("Leon");
            cola.Enqueue("Lobo");
            cola.Enqueue("Zorro");
            cola.Enqueue("Conejo");


            //itera 3 veces para ir retirando elementos de la cola

            for (int i = 0; i < 3; i++)
            {
                //.count cuenta la cantidad de elementos en la cola

                Console.WriteLine("Elementos totales que se encuentran en la cola: " + cola.Count);

                //.dequeue() retira un elemento de la cola

                Console.WriteLine("Elemento retirado de la cola: " + cola.Dequeue());

                //.peek() muestra el proximo elemento de la cola, sin retirarlo

                Console.WriteLine("el proximo elemento que queda en la cola es: " + cola.Peek());
            }

            Console.WriteLine("Elementos totales que se encuentran en la cola: " + cola.Count);
            Console.ReadKey();
        }
    }
}