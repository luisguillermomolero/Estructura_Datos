using System;

namespace AplicacionBase
{
    class Program
    { 
        static void Main(string[] args)
        {
            int n = 0;
            int Contador = 0;
            int Acumulador = 0;
            int LIMITE_CICLO = 4;
            
            Console.WriteLine("** Antes del ciclo ***");

            for (n = LIMITE_CICLO; n >= 1; n --)
            {
                Contador += 1;
                Acumulador += n;
                Console.WriteLine($"Contador {Contador}, Acumulador {Acumulador}");

            }
            Console.WriteLine("*** Después del ciclo ***");
        }
    }
}
