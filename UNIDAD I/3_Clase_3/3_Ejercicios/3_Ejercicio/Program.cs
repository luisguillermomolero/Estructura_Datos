﻿using System;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tablas de multiplicar");
            Console.WriteLine("");

            for (int i = 1; i <= 2; i++)
            {
                for (int j = 01; j <= 10; j++)
                    Console.WriteLine(i + "x" + j + "= " + (i * j));
                Console.WriteLine("");
            }
        }
    }
}
