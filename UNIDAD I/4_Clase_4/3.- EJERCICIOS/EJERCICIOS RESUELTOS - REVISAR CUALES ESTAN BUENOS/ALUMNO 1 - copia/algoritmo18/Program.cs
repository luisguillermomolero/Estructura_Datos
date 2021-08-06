using System;

namespace algoritmo18
{
    class Program
    {
        private static string entrada;

        static void Main(string[] args)
        {
            // declaracion de variables 
            int c = 0;
            int i;
            
            
            Console.WriteLine("Hello World!");//programa para saber si un numero entero digitado es multiplo de 7
            Console.WriteLine("por favor digita cuantos enteros vas a ingresar");// entrada para saber cuantos numeros se van a analizar
            entrada = Console.ReadLine();
            c = Convert.ToInt32(entrada);
            for (i = 0; i < c; i++)// ciclo para la entrada de datos de numeros enteros
            {
                Console.WriteLine("digita un entero");
                entrada = Console.ReadLine();
                int m = Convert.ToInt32(entrada);
                if ((m%7) == 0)// ciclo para saber si es multiplo de 7
                {
                    Console.WriteLine("es multiplo de 7");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("no es multiplo de 7");
                }

                
            }
        }
    }
}
