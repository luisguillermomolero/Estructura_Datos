using System;

namespace ejercicio3
{
    class Program
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
            Entrada = Console.ReadLine();
            Superficie = Convert.ToInt32(Entrada);
            Console.WriteLine("");

            Console.WriteLine("Digite la altura del triangulo");
            Entrada = Console.ReadLine();
            Altura = Convert.ToInt32(Entrada);
            Console.WriteLine("");

            Base = (2 * Superficie) / Altura;

            Console.WriteLine("la base del triangulo es " + Base);

        }
    }
}
