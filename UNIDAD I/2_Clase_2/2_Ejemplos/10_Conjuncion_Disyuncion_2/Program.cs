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
         * que tenga más de 15 ó 18 años y que tenga Permiso de sus 
         * padres. Usando la Disyunción (Operador O) */

        static void Main(string[] args)
        {
            int Edad = 0;
            string Permiso = "";

            Console.Write("Dame la Edad: ");
            Edad = int.Parse(System.Console.ReadLine());

            Console.Write("Tiene Permiso de los padres (true/false): ");
            Permiso = Console.ReadLine();

            if(Edad <= 15 && Permiso == "s" || Permiso == "S"){
                Console.WriteLine("Es posible conducir");
            }else if(Edad >= 18){
                Console.WriteLine("Es posible conducir");
            }else{
                Console.WriteLine("No es posible conducir");
            }
        }
    }
}