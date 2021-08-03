using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            Double r, a;
            const Double PI = 3.1416;

            //Entrada
            System.Console.Write("valor del radio");
            r = double.Parse(System.Console.ReadLine());

            //proceso
            a = PI * Math.Pow(r, 2);

            //salida
            System.Console.Write("el area es de : " + a);
            System.Console.ReadKey();
        }
    }
}
