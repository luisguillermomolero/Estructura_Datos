using System;

namespace AplicacionBase
{
    class Porogram
    {
        // Aplicación que permite conocer si un número ingresado por teclado es positivo

        static void Main(string [] args)
        {
            int Numero = 0;

            System.Console.WriteLine("Regalame un número entero ");
            Numero = int.Parse(System.Console.ReadLine());
            //Numero = Convert.ToInt32(valor);

            if (Numero >= 0)
            {
                Console.WriteLine("");
                Console.WriteLine("el número {0} es positivo", Numero);
            }else
                Console.WriteLine("El número {0} es negativo", Numero);

            // Bloque de código con "if"

            /*programa que le pregunte al usuario el Dividendo y el 
             * divisor, pero que cuando el divisor sea cero no lleve 
             * a cabo la división. */

            float Dividendo = 0.0F;  // Número que se va a dividir
            float Divisor = 1.0f;    // Número quien divide
            float Resultado = 0.0f;

            Console.WriteLine("");
            Console.WriteLine("Regalame el Dividendo:"); 
            Dividendo = float.Parse(System.Console.ReadLine());
            
            Console.WriteLine("Regalame el Divisor:"); 
            Divisor = float.Parse(System.Console.ReadLine());

            if (Divisor != 0.0f)
            {
                Resultado = Dividendo / Divisor;
                Console.WriteLine("El Resultado de la división de {0} entre {1} es = {2}", Dividendo,Divisor, Resultado);
            }


        }
    }
}