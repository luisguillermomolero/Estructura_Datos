using System;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicación que suma los números pares e impares comprendidos del 1 al 200");

            int i =0;
            int acumuladorPar = 0;
            int acumuladorImpar = 0;
            int CANTIDAD_LIMITE = 200;

            for (i = 1; i <= CANTIDAD_LIMITE; i++)
            {
                if (i % 2 == 0)
                {
                    acumuladorPar += i;
                }
                else if (i % 2 != 0)
                {
                    acumuladorImpar += i;
                }
            }
            Console.WriteLine($"La suma de todos los pares es {acumuladorPar}");
            Console.WriteLine($"La suma de todos los impares es {acumuladorImpar}");
        }
    }
}
