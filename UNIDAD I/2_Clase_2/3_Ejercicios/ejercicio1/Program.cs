//Aplicacio que permite conocer el número mayor de 4 ingresados
using System;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable de entrada
            double n1, n2, n3, n4;
            //variable de salida
            double mayor;
            //leer variable de entrada 
            Console.WriteLine("ingrese el numero 1");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numero 2");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numero 3");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numero 4");
            n4 = double.Parse(Console.ReadLine());
            //determinar el mayor
            mayor = n1;
            if (n2 > mayor)
            {
                mayor = n2;
            }
            if (n3 > mayor)
            {
                mayor = n3;
            }
            if (n4 > mayor)
            {
                mayor = n4;
            }
            //mostrar en pantalla el numeo mayor
            Console.WriteLine("el numero mayor es " + mayor);
        }
    }
}
