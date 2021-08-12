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

            float a  =  0.0f;
            float b = 0.0f;
            float resultado = 0.0f;
            string valor =  "";
            int opcion = 0;


            Console.WriteLine("1.-  Suma"); 
            Console.WriteLine("2.-  Resta"); 
            Console.WriteLine("3.-  División"); 
            Console.WriteLine("4.-  Multiplicación");
            Console.WriteLine("");

            Console.Write("Que operación deseas realizar: "); 

            valor = Console.ReadLine();
            opcion   =  Convert.ToInt32(valor);

            Console.WriteLine("");
            Console.Write("Dame el primer numero:");
            
            valor =  Console.ReadLine();
            a  =  Convert.ToSingle(valor);

            Console.Write("Dame el segundo numero:"); 

            valor =  Console.ReadLine();
            b  =  Convert.ToSingle(valor);

            if (opcion == 1)
                resultado =  a  +  b;
            if (opcion == 2)
                resultado =  a  - b;
            if (opcion == 3)
                if (b  !=  0) // Si el divisor es diferente de 0
                    resultado =  a  / b;
                else 
                    Console.WriteLine("El divisor no es valido");
            if (opcion == 4)
                resultado =  a* b;
            Console.WriteLine("El resultado  es:  {0}", resultado);
        }
    }
}
