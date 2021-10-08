using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        string palabra;

        Queue miCola = new Queue();
        miCola.Enqueue("Hola,");
        miCola.Enqueue("soy");
        miCola.Enqueue("yo");

        for (byte i = 0; i < 3; i++)
        {
            palabra = (string)miCola.Dequeue();
            Console.WriteLine(palabra);
        }
    }
}