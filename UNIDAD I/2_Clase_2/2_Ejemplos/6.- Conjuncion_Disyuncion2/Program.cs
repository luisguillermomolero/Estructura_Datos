using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace AplicacionBase
{
    class Program
    {
        /* Programa que nos indique si una persona puede conducir 
         * un automóvil, y las condiciones para que lo conduzca son 
         * que tenga más de 15 ó 18 años y que tenga permiso de sus 
         * padres. Usando la Disyunción (Operador O) */

        static void Main(string[] args)
        {
            int edad = 0;
            bool permiso = false;
            string valor = "";

            Console.Write("Dame la edad: ");
            valor = Console.ReadLine();
            edad = Convert.ToInt32(valor);

            Console.Write("Tiene permiso de los padres (true/false): ");
            valor = Console.ReadLine();
            permiso = Convert.ToBoolean(valor);

            if (edad > 18 || (edad > 15 && permiso == true)) 
                Console.WriteLine("Es posible conducir");
            else
                Console.WriteLine("No puedes conducir");

        }
    }
}