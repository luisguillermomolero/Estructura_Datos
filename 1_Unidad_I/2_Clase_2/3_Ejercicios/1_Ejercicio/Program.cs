//Aplicacio que permite conocer el número mayor de 4 ingresados
using System;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable de entrada
            double Numero_1, Numero_2, Numero_3, Numero_4;
            //variable de salida
            double Mayor;
            //leer variable desde el teclado
            Console.Write("ingrese el numero 1: ");
            Numero_1 = double.Parse(Console.ReadLine());
            Console.Write("ingrese el numero 2: ");
            Numero_2 = double.Parse(Console.ReadLine());
            Console.Write("ingrese el numero 3: ");
            Numero_3 = double.Parse(Console.ReadLine());
            Console.Write("ingrese el numero 4: ");
            Numero_4 = double.Parse(Console.ReadLine());
            //determinar el Mayor
            Mayor = Numero_1;
            if (Numero_2 > Mayor)
            {
                Mayor = Numero_2;
            }
            if (Numero_3 > Mayor)
            {
                Mayor = Numero_3;
            }
            if (Numero_4 > Mayor)
            {
                Mayor = Numero_4;
            }
            //mostrar en pantalla el numeo Mayor
            Console.WriteLine($"\nEl numero Mayor es {Mayor}");
        }
    }
}
