using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            Double Radio, Area;
            const Double PI = 3.1416;

            //Entrada
            System.Console.Write("valor del radio");
            Radio = double.Parse(System.Console.ReadLine());

            //proceso
            Area = PI * Math.Pow(Radio, 2);

            //salida
            System.Console.Write("el area es de : " + Area);
            System.Console.ReadKey();
        }
    }
}
