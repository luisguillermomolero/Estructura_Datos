using System;

/* Aplicacion que permite crear un vector unidimensional con una longitud igual a 10.
 * Posteriormente, se carga el vector con valores.
 * Finalmente, se calcula la media (promedio) de valores del vector.
*/
namespace AplicacionBase
{
    class Program
    {
		static void Main(string[] args)
		{
			// Declarar variables  
			int Sumatoria =0;
			int Promedio;
			int LONGITUD_VECTOR = 3;

			// Definir vector
			int[] Vector = new int[LONGITUD_VECTOR];

			// Cargar vector
			for (int i = 0; i < LONGITUD_VECTOR; i++)
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
