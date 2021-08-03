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
         * operaciones aritmeticas, haciendo uso de Switch */


        static void Main(string[] args)
        {
            float a = 0.0f;
            float b = 0.0f;
            float resultado = 0.0f;
            string valor = "";
            int opcion = 0;

            Console.WriteLine("1 - Suma"); 
            Console.WriteLine("2 - Resta"); 
            Console.WriteLine("3 - División"); 
            Console.WriteLine("4 - Multiplicación"); 
            Console.Write("Que operación deseas hacer: ");

            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            Console.Write("Dame el primer numero:");

            valor = Console.ReadLine();
            a = Convert.ToSingle(valor);

            Console.Write("Dame el segundo numero:"); 

            valor =  Console.ReadLine();
            b = Convert.ToSingle(valor);

            switch (opcion)
            { 
                case   1:
                    resultado = a + b;
                    break;
                case   2:
                    resultado = a - b;
                    break;
                case   3:
                    if (b != 0)
                        resultado = a / b;
                    else
                        Console.WriteLine("Divisor no es valido");
                    break;
                case   4:
                    resultado = a * b;
                    break;
                default:
                    Console.WriteLine("Opción  no  valida");
                    break;
            }
            Console.WriteLine("El resultado  es:  {0}", resultado);
        }
    }
}