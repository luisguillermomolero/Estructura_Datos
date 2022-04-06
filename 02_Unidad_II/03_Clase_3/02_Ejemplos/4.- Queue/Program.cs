using System;
using System.Collections.Generic;

namespace AplicacionBase
{
    class Program
    {
        public static void Main()
        {
            // Declaramos una cola

            Queue<string> numbers = new Queue<string>();

            // Llenamos la cola

            numbers.Enqueue("Uno");
            numbers.Enqueue("Dos");
            numbers.Enqueue("Tres");
            numbers.Enqueue("Cuatro");
            numbers.Enqueue("Cinco");

            // Muestra el contenido de una cola

            Console.WriteLine("   Los valores de la cola actual son:");


            foreach (string number in numbers)
            {
                Console.WriteLine("     {0}", number);
            }

            // Muestra y elimina el primer valor de la cola

            Console.WriteLine($"\n   Mostrar y eliminar el \"{numbers.Dequeue()}\" de la cola con \"Dequeuing\" ");
            
            // Muestra el siguiente valor de la cola

            Console.WriteLine($"\n   El siguiente elemento a mostrar y eliminar de la cola es el \"{numbers.Peek()}\" ");
            
            // Muestra y elimina el segundo valor de la cola
            
            Console.WriteLine($"\n   Ahora mostrar y eliminar el \"{numbers.Dequeue()}\" de la cola con \"Dequeuing\" ");

            // Crea una copia de la cola, usando el método "ToArray"

           Queue<string> queueCopy = new Queue<string>(numbers.ToArray());

            Console.Write("\n    *** La cola se ha copiado en un nuevo arreglo ***");
            Console.WriteLine("\n        El contenido del arreglo es:");

            foreach (string number in queueCopy)
            {
                Console.WriteLine("     {0}", number);
            }

            /*Crea un arreglo dos veces el tamaño de la cola y copia los 
             * elementos de la cola, comenzando en el medio del arreglo. */
                        
            string[] array2 = new string[numbers.Count * 2];
            numbers.CopyTo(array2, numbers.Count);

            // Crea una segunda cola, usando el constructor.

            Queue<string> queueCopy2 = new Queue<string>(array2);

            Console.WriteLine("\n    Contenido de la segunda copia, con valores duplicados y los nulos:");
            foreach (string number in queueCopy2)
            {
                Console.WriteLine("     {0}", number);
            }

            Console.WriteLine("\n   Se encuentra el valor \"Cuatro\" en la cola \"queueCopy\" ?: {0}", queueCopy.Contains("Cuatro"));

            Console.WriteLine("\n   *** Ahora se borrara toda la cola \"queueCopy\" ***");
            
            queueCopy.Clear();

            Console.WriteLine($"\n   Cuantos valores tiene la cola \"queueCopy\" ahora : {queueCopy.Count}");
            
            Console.ReadKey();
        }
    }
}
