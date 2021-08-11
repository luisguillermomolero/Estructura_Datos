using System;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este programa permite calcular de forma independiente\n la suma de los números pares e impares comprendidos del 1 al 200");

            float i, acump = 0, acumi = 0;

            for (i = 1; i <= 200; i++)
            {
                if (i % 2 == 0)
                {
                    acump = acump + i;
                }
                else if (i % 2 != 0)
                {
                    acumi = acumi + i;
                }
            }

            Console.WriteLine("\n\n la suma total de los numeros pares comprendidos entre 1 y 200 es {0}", acump);
            Console.WriteLine("la suma total de los numeros impares comprendidos entre 1 y 200 es {0}", acumi);
        }
    }
}
