using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int contpar = 0; 
            int contimpar = 0;
            int sumpar = 0;
            int sumimpar = 0;
            int arit = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("digita cualquier número: ");
                num = int.Parse(Console.ReadLine());

                if ((num % 2) == 0)
                {
                    contpar = contpar + 1;
                    sumpar = sumpar + num;
                }
                else
                {
                    contimpar = contimpar + 1;
                    sumimpar = sumimpar + num;
                }
            }

            arit = sumimpar / contimpar;
            Console.WriteLine("");
            Console.WriteLine("La cantidad de números pares digitados son: "+contpar+", por ello la suma de los pares es: " + sumpar);
            Console.WriteLine("");
            Console.WriteLine("La media aritmetica de los números impares es:"+ arit);
        }
    }
}
