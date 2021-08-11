using System;
using System.Globalization;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            Console.WriteLine("Digite la tabla hasta la que quiere llegar");
            N = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j <= 10; j++)
                    Console.WriteLine(i + "x" + j + "= " + (i * j));
                    Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
