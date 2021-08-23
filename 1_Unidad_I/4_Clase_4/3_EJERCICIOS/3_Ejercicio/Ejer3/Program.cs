using System;

/* Crear un vector unidimensional con una longitud igual a 10.
 * Cargar el vector con valores
 * Calcular la media de valores del vector.
*/

namespace AplicacionBase
{
    class Program
    {
		static void Main(string[] args)
		{
			// Declarar variables  
			int i;
			int Sumatoria =0;
			int Promedio;
			int LONGITUD_VECTOR = 3;

			// Definir vector
			int[] Vector = new int[LONGITUD_VECTOR];

			// Cargar vector
			for (i = 0; i < LONGITUD_VECTOR; i++)
			{
				Console.Write($"Digite el valor para la posición {i}: ");
				Vector[i] = int.Parse(System.Console.ReadLine());
			}

			// Recorrer vector sumando su contenido 

			foreach (int j in Vector){
				Sumatoria += j;
			}
				
			Promedio = Sumatoria/LONGITUD_VECTOR;
			Console.WriteLine($"La media del vector es: {Promedio}");
		}

	}

}
