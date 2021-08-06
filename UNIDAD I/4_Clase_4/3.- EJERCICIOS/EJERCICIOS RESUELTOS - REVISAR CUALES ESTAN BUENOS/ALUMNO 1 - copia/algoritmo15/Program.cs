using System;

namespace algoritmo15
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaracion de variables 
                int ma = 0, me = 0, num = 0;
                int suma = 0;
                int prom = 0;
                Console.WriteLine("Cuantos numeros va ingresar");
                int numeros = int.Parse(Console.ReadLine());// digitar cuantos numeros va a ingresar para asi saber el mayor menor y promedio
                for (int i = 1; i <= numeros; i++)//ciclo for
                {
                    Console.WriteLine("Digite un numero: ");// el usuario digite los numeros a analizar
                    num = int.Parse(Console.ReadLine());
                    suma = suma + num;
                    prom = suma / numeros;
                //ciclo if para saber cual es el mayor menor y promedio
                    if (i == 1)
                    {
                        ma = num;
                        me = num;
                    }
                    if (num > ma) { ma = num; }
                    if (num < me) { me = num; }



                    num = 0;
                }
                //impreson de las imagenes
                Console.WriteLine(" numero mayor es: " + ma);
                Console.WriteLine(" numero menor es: " + me);
                Console.WriteLine("el promedio es : " + prom);

            
        }
    }
}
    

