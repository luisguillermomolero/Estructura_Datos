using System;
using System.Collections.Generic;
using System.Text;


namespace AplicacionBase
{
    //programa para sacar el Promedio de las calificaciones para tres alumnos.

    class Program
    {
        static void   Main(string[] args)
        {
            float Calificacion1 = 0.0f;
            float Calificacion2 = 0.0f;
            float Calificacion3 = 0.0f;
            float Promedio = 0.0f;
            string Valor = "";

            Console.WriteLine("Ingrese la primera calificación:");
            Valor = Console.ReadLine();
            Calificacion1 = Convert.ToSingle(Valor);

            Console.WriteLine("Ingrese la segunda calificación:");
            Valor = Console.ReadLine();
            Calificacion2 = Convert.ToSingle(Valor);

            Console.WriteLine("Ingrese la tercera calificación:");
            Valor = Console.ReadLine();
            Calificacion3 = Convert.ToSingle(Valor);

            Promedio = (Calificacion1 + Calificacion2 + Calificacion3) / 3;

            Console.WriteLine("El Promedio es {0}",  Promedio);

            
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
