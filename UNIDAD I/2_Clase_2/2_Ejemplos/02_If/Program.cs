using System;

namespace AplicacionBase
{
    // Uso del ELSE

    /* Aplicación que permite saber si un número 
     * introducido por teclado es positivo ó negativo*/
    class Program
    {
        static void Main(string[] args)
        {  
            int Numero = 0;
            string valor = "";

            Console.Write("Regalame un número entero: ");
            Numero = int.Parse(System.Console.ReadLine());

            if (Numero >= 0)
                Console.WriteLine("El número {0} es positivo", Numero);
            else
                Console.WriteLine("El número {0} es negativo", Numero);

            //Uso del ELSE con bloque de código

            /* Aplicación que permite realizar una división siempre y cuando
             * el divisor sea diferente de cero*/

            float Dividendo = 0.0f;
            float Divisor = 1.0F;
            float Resultado = 0.0f;

            Console.WriteLine("");
            Console.WriteLine("Aplicación que permite realizar una división siempre y cuando el divisor sea diferente de cero");
            Console.WriteLine("");

            Console.WriteLine("Regalame el dividendo ");
            Dividendo = float.Parse(System.Console.ReadLine());

            Console.WriteLine("Regalame el divisor ");
            Divisor = float.Parse(System.Console.ReadLine());

            if (Divisor == 0)
                Console.WriteLine("La división no es valida, Divisor es 0");
            else
            {
                Resultado = Dividendo/Divisor;
                Console.WriteLine("El resultado de la división de {0} entre {1} es = {2}", Dividendo, Divisor, Resultado);
            }
        }
    }
}
