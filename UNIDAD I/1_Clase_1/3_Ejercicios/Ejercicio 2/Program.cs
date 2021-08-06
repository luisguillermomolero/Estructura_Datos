using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float pi = 3.14f;
            int rad = 0;
            int radi = 0;
            float area = 0;

            string entrada = "";

            Console.WriteLine("vamos a calcular el area de un circulo");
            Console.WriteLine("");

            Console.WriteLine("digita el radio del circulo");
            entrada = Console.ReadLine();
            rad = Convert.ToInt32(entrada);

            radi = rad * rad;
            area = pi * radi;

            Console.WriteLine("el area del circulo es "+ area);
        }
    }
}
