using System;
using System.Collections;

/*
Programa que reciba una Cola "C" de números enteros y mueva sus elementos a una nueva "Pila". Al finalizar la Cola "C" no debe contener elementos.
*/

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se instancia una nueva cola y pila
            Queue ColaC = new Queue();
            Stack Pila = new Stack();

            // Se carga la cola con valores
            ColaC.Enqueue(2);
            ColaC.Enqueue(3);
            ColaC.Enqueue(4);
            ColaC.Enqueue(5);
            ColaC.Enqueue(6);
            ColaC.Enqueue(7);

            //Imprimir la cola inicial
            Console.WriteLine("la cola inicial es: ");

            while (ColaC.Count > 0)
            {
                //Cargar la pila con los valores de la cola
                int Co = 0;
                Co = (int)ColaC.Dequeue();
                Console.WriteLine($"  Cola: {Co}");
                Pila.Push(Co); //Carga la pila con cada elemento "Co" de la cola
            }
            //aqui mostramos por pantalla la pila
            Console.WriteLine("La pila creada: ");
            while (Pila.Count > 0)
            {
                Console.WriteLine($"  Pila: {Pila.Pop()}"); //Muestra el último elemento de la pila y borra
            }
            Console.WriteLine("ya no existe elementos en la cola.");
        }
    }
}