using System;
using System.Net.Http.Headers;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
                        
            float media, i, num, sumapar = 0, contp = 0, sumimpar = 0;
            int impar = 0;

            string entrada;
            for (i = 1; i <= 10; i++)
            {
                Console.Write("   Por favor introduzca el numero {0} : ", i);
                entrada = Console.ReadLine();
                num = Convert.ToInt32(entrada);

                if (num % 2 == 0)
                {
                    sumapar = sumapar + num;
                    contp = contp + 1;
                }
                else
                {
                    sumimpar = sumimpar + num;
                    impar = impar + 1;
                }
            }

            media = sumimpar / impar;

            Console.WriteLine("    La suma de los numeros pares de su lista es: {0}", sumapar);
            Console.WriteLine("    Usted digito un total de {0} numeros pares", contp);
            Console.WriteLine("    El promedio de los numeros impares de su lista es: {0}", media);
        }
    }
}
