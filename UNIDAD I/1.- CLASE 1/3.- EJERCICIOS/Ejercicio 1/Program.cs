using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int bas = 0;
            int alt = 0;
            int altmi = 0;
            int sup = 0;

            string Entrada = "";

            Console.WriteLine("vamos a calcular la superficie de un triangulo");
            Console.WriteLine("");

            Console.WriteLine("escribe la base del triangulo");
            Entrada = Console.ReadLine();
            bas = Convert.ToInt32(Entrada);

            Console.WriteLine("escribe la altura del triangulo");
            Entrada = Console.ReadLine();
            alt = Convert.ToInt32(Entrada);

            altmi = alt / 2;

            sup = bas * altmi;

            Console.WriteLine("la superficie del triangulo es " + sup);
        }
    }
}
