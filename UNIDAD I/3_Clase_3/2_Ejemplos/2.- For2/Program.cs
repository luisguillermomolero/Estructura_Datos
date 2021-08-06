using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionBase
{
    class Program
    { 
        static void   Main(string[] args)
        {
            int n = 0;
            int contador = 0;
            int acumulador = 0;
            
            Console.WriteLine("** Antes del ciclo ***");

            for (n = 10; n >= 1; n = n - 1)
            {
                contador = contador + 1;
                acumulador = acumulador + n;
                Console.WriteLine("Contador {0}, Acumulador {1}", contador, acumulador);

            }
            Console.WriteLine("*** Después del ciclo ***");
        }
    }
}
