//Aplicación que permite conocer si un número es primo
using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            int Numero, i;
            int Contador = 0;
            
            Console.WriteLine("ingrese un numero: ");
            Numero = int.Parse(Console.ReadLine());

            for (i = 1; i <= Numero; i++)
            {
                if (Numero % i == 0)
                {
                    Contador = Contador + 1;
                }
            }
            if (Contador > 2){
                Console.WriteLine("{0} no es primo", Numero);
            }else
                Console.WriteLine("{0} es primo", Numero);

            Console.ReadLine();
        }
    }
}
