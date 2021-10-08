using System;

namespace ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "Hola Mundo";

            Console.WriteLine("TRABAJO CON CADENAS");

            Console.WriteLine("Nuestra cadena es: " + cadena);

            Console.WriteLine("La cadena en mayusculas es: {0}", cadena.ToUpper());

            string otracadena = cadena.ToUpper();

            Console.WriteLine("La cadena en mayusculas es: " + otracadena);

            Console.ReadKey();
        }
    }
}
