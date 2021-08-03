using System;
using System.Collections.Generic;
using System.Text;


namespace AplicacionBase
{
    class Program
    {
        /* Programa que permite calcular la nota de estudiantes de una sección utilizando un vector
         * y determinar cual es la calificaciòn menor y la calificaciòn mayor*/

        static void Main(string[] args)
        {
            int cantidad = 0;
            int n = 0;
            string valor =  "";
            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 10.0f;
            float maxima = 0.0f;


            Console.WriteLine("Ingrese la cantidad de alumnos");
            valor = Console.ReadLine();
            cantidad = Convert.ToInt32(valor);

            // Declaracion del vector
            float[] calif = new float[cantidad];

            // Ciclo para llenar el vetor

            for (n = 0; n < cantidad; n++)
            {
                Console.Write("Dame la calificación "+ (n+1)+ ": ");
                valor = Console.ReadLine();
                calif[n] = Convert.ToSingle(valor);
            }

            // Ciclo para sumar los valores del vector

            for (n = 0; n < cantidad; n++)
            {
                suma += calif[n];
            }

            promedio = suma / cantidad;

            for (n = 0; n < cantidad; n++)
            {
                if (calif[n] < minima)
                    minima = calif[n];
            }

            for (n = 0; n < cantidad; n++)
            {
                if (calif[n] > maxima)
                    maxima = calif[n];
            }
            
            Console.WriteLine("El promedio es {0}",  promedio); 
            Console.WriteLine("La calificación mínima es {0}", minima);
            Console.WriteLine("La calificación máxima es {0}", maxima);
        }
    }
}
