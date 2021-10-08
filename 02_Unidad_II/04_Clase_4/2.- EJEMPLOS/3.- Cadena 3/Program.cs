using System;

namespace Aplicacionbase
{

    class Program
    {
        public static void Main(string[] args)
        {
            string nombre1, nombre2;

            Console.Write("Ingrese primer nombre: ");
            nombre1 = Console.ReadLine();

            Console.Write("Ingrese segundo nombre: ");
            nombre2 = Console.ReadLine();

            // El método Equals () devuelve verdadero/falso

            bool compare = nombre1.Equals(nombre2);

            if (compare == false)
            {
                Console.WriteLine("Ambas palabras son diferentes");
            }
            else
            {
                Console.WriteLine("Ambas palabras son iguales");
            }
            Console.ReadKey();
        }
    }
}
