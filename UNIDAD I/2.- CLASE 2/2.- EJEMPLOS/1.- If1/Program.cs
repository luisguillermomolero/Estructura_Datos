using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AplicacionBase
{
    class Porogram
    {
        // Aplicación que permite conocer si un número ingresado por teclado es positivo

        static void Main(string [] args)
        {
            int numero = 0;
            string valor = "";

            Console.WriteLine("Regalame un número entero ");
            valor = Console.ReadLine();
            numero = Convert.ToInt32(valor);

            if (numero >= 0)
            {
                Console.WriteLine("");
                Console.WriteLine("el número {0} es positivo", numero);
            }


            if (numero <= 0)
                Console.WriteLine("El número {0} es negativo", numero);

            // Bloque de código con "if"

            /*programa que le pregunte al usuario el dividendo y el 
             * divisor, pero que cuando el divisor sea cero no lleve 
             * a cabo la división. */

            float dividendo = 0.0F;  // Número que se va a dividir
            float divisor = 1.0f;    // Número quien divide
            float resultado = 0.0f;

            Console.WriteLine("");
            Console.WriteLine("Regalame el dividendo:"); 
            valor = Console.ReadLine();
            dividendo = Convert.ToSingle(valor);
            
            
            Console.WriteLine("Regalame el divisor:"); 
            valor =  Console.ReadLine();
            divisor = Convert.ToSingle(valor);

            if (divisor != 0.0f)
            {
                resultado = dividendo / divisor;
                Console.WriteLine("El resultado de la división de {0} entre {1} es = {2}", dividendo,divisor, resultado);
            }


        }
    }
}