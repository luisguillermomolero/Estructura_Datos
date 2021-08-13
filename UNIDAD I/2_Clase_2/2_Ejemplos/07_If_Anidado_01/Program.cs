using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;


namespace AplicacionBase
{
    class Program
    {
        /* Programa que permite desplegar un menú de opcione para ejecutar
         operaciones aritmeticas, haciendo uso de IF */

        static void   Main(string[] args)
        {

            int Numero_1, Numero_2;
            int Opc = 0;
            int Resultado = 0;


            Console.WriteLine("1.-  Suma"); 
            Console.WriteLine("2.-  Resta"); 
            Console.WriteLine("3.-  División"); 
            Console.WriteLine("4.-  Multiplicación");
            Console.WriteLine("");

            Console.WriteLine("Que operación deseas realizar: ");
            Opc = int.Parse(System.Console.ReadLine()) ;

            Console.WriteLine("\nDame el primer numero entero por favor: ");
            Numero_1 = int.Parse(System.Console.ReadLine());

            Console.Write("Dame el segundo numero por favor: ");
            Numero_2 = int.Parse(System.Console.ReadLine());

            if (Opc == 1)
                Resultado =  Numero_1  +  Numero_2;
            if (Opc == 2)
                Resultado =  Numero_1 - Numero_2;
            if (Opc == 3){
                if (Numero_2 == 0){
                    Console.WriteLine("Número invalido, divisor igual a cero");
                }else{
                    Resultado = Numero_1/Numero_2;
                }
            }
            if (Opc == 4)
                Resultado =  Numero_1 * Numero_2;
            Console.WriteLine($"El Resultado  es: {Resultado}");
        }
    }
}
