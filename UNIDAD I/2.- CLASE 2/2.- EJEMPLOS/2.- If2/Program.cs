using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AplicacionBase
{
    // Uso del ELSE

    /* Aplicación que permite saber si un número 
     * introducido por teclado es positivo ó negativo*/
    class Program
    {
        static void Main(string[] args)
        {  
            int numero = 0;
            string valor = "";

            Console.Write("Regalame un número entero: ");

            valor = Console.ReadLine();
            numero = Convert.ToInt32(valor);

            if (numero >= 0)
                Console.WriteLine("El número es {0} es positivo", numero);
            else
                Console.WriteLine("El número {0} es negativo", numero);

            //Uso del ELSE con bloque de código

            /* Aplicación que permite realizar una división siempre y cuando
             * el divisor sea diferente de cero*/

            float dividendo = 0.0f;
            float divisor = 1.0F;
            float resultado = 0.0f;

            Console.WriteLine("");
            Console.WriteLine("Aplicación que permite realizar una división siempre y cuando el divisor sea diferente de cero");
            Console.WriteLine("");
            Console.Write("Regalame el dividendo ");

            valor = Console.ReadLine();
            dividendo = Convert.ToSingle(valor);

            Console.Write("Regalame el divisor "); 

            valor =  Console.ReadLine();
            divisor = Convert.ToSingle(valor);

            if (divisor == 0)
                Console.WriteLine("La división no es valida");
            else
            {
                resultado = dividendo / divisor;
                Console.WriteLine("El resultado de la división de {0} entre {1} es = {2}", dividendo, divisor, resultado);
            }
        }
    }
}
