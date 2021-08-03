using System;
using System.Collections.Generic;
using System.Text;


namespace AplicacionBase
{
    //Programa para el calculo de notas de N alumnos
    class Program
    {
        static void Main(string[] args)
        {

            int n = 0;
            int cantidad;
            float calif = 0.0f;
            float suma = 0.0f;
            float promedio = 0.0f;
            string valor = "";

            Console.Write("Ingrese la cantidad de alumnos a registrar : ");
            valor = Console.ReadLine();
            cantidad = Convert.ToInt32(valor);

            for (n = 1; n <= cantidad; n++)
            {
                Console.Write("Ingrese por favor la calificación del alumno {0} de {1} : ", n, cantidad);
                valor = Console.ReadLine();
                calif = Convert.ToSingle(valor);
                suma += calif;
            }
            promedio = suma / cantidad;
            Console.Write("El promedio de calificaciones de {0} almunos es : {1} ", cantidad, promedio);
        }
    }
}
