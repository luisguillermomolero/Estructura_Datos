using System;

namespace ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "HOLA MUNDO";

            Console.WriteLine("TRABAJO CON CADENAS");

            Console.WriteLine("Nuestra cadena es: " + cadena);

            Console.WriteLine("La cadena en minusculas es:{0}", cadena.ToLower());

            string otracadena = cadena.ToLower();

            Console.WriteLine("La cadena en minusculas es: " + otracadena);

            Console.ReadKey();
        }
    }
}
