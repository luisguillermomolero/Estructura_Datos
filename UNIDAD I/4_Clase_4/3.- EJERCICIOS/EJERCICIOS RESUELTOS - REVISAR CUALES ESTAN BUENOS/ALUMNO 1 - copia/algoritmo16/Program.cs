using System;
using System.Numerics;

namespace algoritmo16
{
    class Program
    {
        private static string entrada;
        private static int menor;

        public static int[] Vector { get; private set; }

        static void Main(string[] args)
        {
            // declaracion de variables
            int n = 0;
            int cant = 0;
            int x = 0;
            Console.WriteLine("Hello World!");

            Console.WriteLine("por favro digite la cantidad de datos que va a ingresar");//la cantidad de datos de la asi generar una lista para despues saber si x se repite
            entrada = Console.ReadLine();
            n = Convert.ToInt32(entrada);
            // declaracion del vector
            Vector = new int[n];
            for(int f=0; f<Vector.Length; f++)
            {
                Console.WriteLine("ingrese un numero entero ");
                entrada = Console.ReadLine();
                Vector[f] = int.Parse(entrada);

                

            }
            //entrada para saber si el numero x se repite 
            Console.WriteLine("por favor digite el numero que desea saber si se repite ");
            entrada = Console.ReadLine();
            x = Convert.ToInt32(entrada);

            
            //ciclo for para segun los datos ya ingresados saber si se repite un numero 
            for(int f=0; f < Vector.Length;f++)
            {
                if (Vector[f] == x)
                {
                    cant ++ ;
                    
                }
                if (cant > 1)
                {
                    Console.WriteLine("el numero se repite", cant);
                }
               
            }
            
        }
    }
}
