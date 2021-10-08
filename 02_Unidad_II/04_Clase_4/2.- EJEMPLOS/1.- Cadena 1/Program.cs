using System;

namespace Aplicacionbase
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre1, nombre2;

            Console.Write("Ingrese primer nombre: ");
            nombre1 = Console.ReadLine();

            Console.Write("Ingrese segundo nombre: ");
            nombre2 = Console.ReadLine();


            if (nombre1 == nombre2)
            {
                Console.Write("Los nombres son iguales");
            }
            else
            {
                Console.Write("Los nombres son distintos");
            }
            Console.ReadKey();
        }
    }
}