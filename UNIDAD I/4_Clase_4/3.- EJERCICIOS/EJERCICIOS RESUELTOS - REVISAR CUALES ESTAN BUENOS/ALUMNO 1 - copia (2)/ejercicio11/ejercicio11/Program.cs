using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int i=0, conta=0,contdes=0, numnotas;
            float sumaa=0, sumades=0, proma, promdes;
            Console.WriteLine("///Para este ejercicio supondremos que la nota inima para aprobar el curso es 11///\n");

           Console.WriteLine("¿Cuantas notas de estudiantes va a introducir?");
            entrada = Console.ReadLine();
            numnotas = Convert.ToInt32(entrada);
            float[] calif = new float[numnotas];

            Console.WriteLine("\n");
            for (i = 0; i < numnotas; i++)
            {
                Console.WriteLine("Digite por favor la calificacion del alumno {0} (La nota debe ir de 0 a 20 como lo indica la guia)", i + 1);
                entrada = Console.ReadLine();
                calif[i] = Convert.ToSingle(entrada);
            }

            for (i = 0; i < numnotas; i++)
            {
                if (calif[i] >= 11 )
                {
                    conta = conta + 1;
                    sumaa = sumaa + calif[i];
                }
                else
                {
                    contdes = contdes + 1;
                    sumades = sumades + calif[i];
                }
            }
            proma = sumaa / conta;
            promdes = sumades / contdes;

            Console.WriteLine("\nEl promedio de los alumnos aprobados es de {0} y el de los desaprobades es de {1}",proma, promdes);
            Console.WriteLine("\nEn total hay {0} alunmos aprobados y {1} alumnos desaprobados", conta, contdes);
        }
    }
}
