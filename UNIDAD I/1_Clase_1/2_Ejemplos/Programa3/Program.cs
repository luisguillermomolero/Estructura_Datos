using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AplicacionBase
{
    //Capturar datos por teclado
    /* Método ReadLine(): Captura una cadena. Para variables numericas se
     * debe convertir la cadena en valor numerico, para ellos se utiliza
     * el método Convert.ToInt32 o Convert.Tosingle dependiendo de como 
     * se declare la la variable (Entera o flotante)*/
    class Program
    {
        // Programa que permite sumar dos números introducidos por teclado

        static void Main(string[] args)
        {
            /*Aplicación que me permite solicitar mi nombre y sumar dos
             * números introducidos por teclado*/

            /*Cual de las variables son explicitas en el ejercicio?
             * Cual de ellas son implicitas? */

            string entrada = "";
            int a = 0;
            int b = 0, resultado = 0;

            Console.WriteLine("Escribe tu nombre)");
            entrada = Console.ReadLine(); //Instanciar
            Console.WriteLine("** Hola {0} como estas? **", entrada);
            Console.WriteLine("");

            Console.WriteLine("Regalame un numero entero");
            entrada = Console.ReadLine();
            a = Convert.ToInt32(entrada);

            Console.WriteLine("Regalame otro número");
            entrada = Console.ReadLine();
            b = Convert.ToInt32(entrada);

            resultado = a + b;

            Console.WriteLine("** El resultado de {0} + {1} es {2} **", a, b, resultado);
            Console.WriteLine("");


            // Ahora, calculamos el área de una circunferencia

            float PI = 3.14f;
            float Radio = 0.0F;
            float Area = 0.0f;

            Console.WriteLine("Ahora, calculamos el área de una circunferencia");
            Console.WriteLine("");
            Console.WriteLine("Regalame el valor del radio");
            entrada = Console.ReadLine();
            Radio = Convert.ToSingle(entrada);

            Area = PI * (Radio * Radio);
            Console.WriteLine("** El radio es {0} por ende, El área de una circunferencia es {1} **", Radio, Area);

        }
    }
}
