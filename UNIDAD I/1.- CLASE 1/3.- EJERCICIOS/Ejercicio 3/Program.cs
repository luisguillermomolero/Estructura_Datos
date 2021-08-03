using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            string Entrada = "";
            int dos = 2;
            int bas = 0;
            int sup = 0;
            int alt = 0;

            Console.WriteLine("vamos a calcular la base de un triangulo");
            Console.WriteLine("");

            Console.WriteLine("digite la superficie del triangulo");
            Entrada = Console.ReadLine();
            sup = Convert.ToInt32(Entrada);
            Console.WriteLine("");

            Console.WriteLine("digite la altura del triangulo");
            Entrada = Console.ReadLine();
            alt = Convert.ToInt32(Entrada);
            Console.WriteLine("");

            bas = (dos * sup) / alt;

            Console.WriteLine("la base del triangulo es " + bas);

        }
    }
}
