
using System;

//Pedir por teclado el tamaño de un vector de números y pedir los valores numéricos
//con los que se rellena. Los valores no se pueden repetir. Mostrar el vector con los
//valores al final.
namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("¿Cuantos números va a poner?");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int[] b = new int[a];

            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine("digite #" + (i + 1) + ": ");
                b[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
//No pude hallar alguina forma para saber como hacer para que no se puedan repetir, perdon profe :(((