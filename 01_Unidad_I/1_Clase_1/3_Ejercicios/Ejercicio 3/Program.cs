using System;

namespace ejercicio3
{
    class AplicacionBase
    {
        static void Main(string[] args)
        {

            string Entrada = "";
            int Base = 0;
            int Superficie = 0;
            int Altura = 0;

            Console.WriteLine("Vamos a calcular la base de un triangulo");
            Console.WriteLine("");

            Console.WriteLine("Digite la superficie del triangulo");
            Superficie = int.Parse(System.Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Digite la altura del triangulo");
            Altura = int.Parse(System.Console.ReadLine());
            Console.WriteLine("");

            Base = (2 * Superficie) / Altura;

            Console.WriteLine("la base del triangulo es " + Base);

        }
    }
}
