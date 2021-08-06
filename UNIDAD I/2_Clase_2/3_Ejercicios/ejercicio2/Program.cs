using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, c;
            c = 0;
            Console.WriteLine("ingrese numero: ");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    c = c + 1;
                }
            }
            if (c > 2)
            {

                Console.WriteLine("{0} no es primo", n);
            }
            else
            {
                Console.WriteLine("{0} es primo", n);
            }


            Console.ReadLine();
        }
    }
}
