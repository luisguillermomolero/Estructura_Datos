using System;
using System.Collections.Generic;
using System.Text;


namespace AplicacionBase
{
    //programa para sacar el promedio de las calificaciones para tres alumnos.

    class Program
    {
        static void   Main(string[] args)
        {
            float cal1 = 0.0f;
            float cal2 = 0.0f;
            float cal3 = 0.0f;
            float promedio = 0.0f;
            string valor = "";

            Console.WriteLine("Ingrese la primera calificación:");
            valor = Console.ReadLine();
            cal1 = Convert.ToSingle(valor);

            Console.WriteLine("Ingrese la segunda calificación:");
            valor = Console.ReadLine();
            cal2 = Convert.ToSingle(valor);

            Console.WriteLine("Ingrese la tercera calificación:");
            valor = Console.ReadLine();
            cal3 = Convert.ToSingle(valor);

            promedio = (cal1 + cal2 + cal3) / 3;

            Console.WriteLine("El promedio es {0}",  promedio);

            
            //Usando el FOR

            int n = 0;     // variable de  control

            Console.WriteLine("Usando inicialmente el ciclo FOR para mostrar números por consola");
            Console.WriteLine("*** Antes del ciclo ***");


            for (n = 1; n <= 10; n = n + 1)
                Console.WriteLine(" Ingrese la calificación {0} de 10",  n);

            Console.WriteLine("*** Después del ciclo ***");

        }

    }
}
