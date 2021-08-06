using System;


//Crea un vector unidimensional con un tamaño de 5, asígnale los valores numéricos
//manualmente(los que tú quieras) y muéstralos por pantalla.
namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // este arrary pide los 6 números para seleccionarlos mas adelante
            int[] Numero = new int[] { 1, 2, 3, 4, 5,6 };
            // De aqui en adelnate los 5 numeros deseados y los llamanos para que aparezca en pantalla
            Numero[1] = 50;
            Console.WriteLine(Numero[1]);
            Numero[2] = 1000;
            Console.WriteLine(Numero[2]);
            Numero[3] = 2;
            Console.WriteLine(Numero[3]);
            Numero[4] = 30;
            Console.WriteLine(Numero[4]);
            Numero[5] = 3000;
            Console.WriteLine(Numero[5]);

        }
    }
}