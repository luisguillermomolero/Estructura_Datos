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
            double mayor;
            //leer variable de entrada 
            Console.WriteLine("ingrese el numero 1");
            Numero_1 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numero 2");
            Numero_2 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numero 3");
            Numero_3 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numero 4");
            Numero_4 = double.Parse(Console.ReadLine());
            //determinar el mayor
            mayor = Numero_1;
            if (Numero_2 > mayor)
            {
                mayor = Numero_2;
            }
            if (Numero_3 > mayor)
            {
                mayor = Numero_3;
            }
            if (Numero_4 > mayor)
            {
                mayor = Numero_4;
            }
            //mostrar en pantalla el numeo mayor
            Console.WriteLine("el numero mayor es " + mayor);
        }
    }
}
