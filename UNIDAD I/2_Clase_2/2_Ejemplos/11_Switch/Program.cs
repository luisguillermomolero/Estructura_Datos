using System;

namespace AplicacionBase
{
    class Program
    {
        /* Programa que permite desplegar un menú de opcione para ejecutar 
         * operaciones aritmeticas, haciendo uso de Switch */


        static void Main(string[] args)
        {
            int Numero_1, Numero_2, Opc =0;
            int Resultado = 0;

            Console.WriteLine("1 - Suma"); 
            Console.WriteLine("2 - Resta"); 
            Console.WriteLine("3 - División"); 
            Console.WriteLine("4 - Multiplicación"); 

            Console.Write("Que operación deseas hacer: ");
            Opc = int.Parse(System.Console.ReadLine());

            Console.Write("Dame el primer numero por favor: ");
            Numero_1 = int.Parse(System.Console.ReadLine());

            Console.Write("Dame el segundo numero por favor: "); 
            Numero_2 = int.Parse(System.Console.ReadLine());

            switch (Opc)
            { 
                case   1:
                    Resultado = Numero_1 + Numero_2;
                    break;
                case   2:
                    Resultado= Numero_1 - Numero_2;
                    break;
                case   3:
                    if (Numero_2 != 0)
                        Resultado = Numero_1 / Numero_2;
                    else
                        Console.WriteLine("Divisor no es valido");
                    break;
                case   4:
                    Resultado = Numero_1 * Numero_2;
                    break;
                default:
                    Console.WriteLine("Opción  no  valida");
                    break;
            }
            Console.WriteLine("El resultado  es:  {0}", Resultado);
        }
    }
}