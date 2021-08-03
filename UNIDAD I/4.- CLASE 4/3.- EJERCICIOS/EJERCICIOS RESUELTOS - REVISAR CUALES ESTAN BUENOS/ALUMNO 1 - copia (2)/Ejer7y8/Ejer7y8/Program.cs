using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Ejer7y8
{
    class Program
    {
		static double buscarelementos(string[] algebra, string[] analisis, ref string[] comunes, double tamanio)
		{
        
		
			int i;
			int j;
			int contador = 1;

			for (i = 1; i <= tamanio; i++)
			{
				contador = contador + 1;

				for (j = 1; j <= tamanio; j++)
				{
					if (algebra[i - 1] == analisis[j - 1])
					{
						comunes[contador - 1] = algebra[i - 1];
						
					}
				}
			}
			return contador;
		}

		static void rellenararreglo(string[] arreglo,double tamanio, string materia)
		{
			int i;
			for (i = 1; i <= tamanio; i++)
			{
				Console.WriteLine("Inserta el ID del alumno de la materia " + materia + " en la posicion " + i);
				arreglo[i-1] = Console.ReadLine();
			
			}
		}

		static void Main(string[] args)
		{
			int i;
			double num_alumnos_comu;
			int tamanio;
			tamanio = 4;


			string[] algebra = new string[tamanio];
			string[] analisis = new string[tamanio];
			string[] comunes = new string[tamanio];

			num_alumnos_comu = buscarelementos(algebra, analisis,ref comunes, tamanio - 1);

			rellenararreglo(algebra, tamanio - 1, "Algebra");
			rellenararreglo(analisis, tamanio - 1, "Analisis");

			Console.WriteLine("Hay " + num_alumnos_comu + " alumnos repetidos");

			for (i = 1; i <= num_alumnos_comu; i++)
			{
				Console.WriteLine(comunes[i-1]);
			}
		}

	}

}
