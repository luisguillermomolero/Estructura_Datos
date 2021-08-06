using System;
using System.Linq;
using System.Text;
using System.Collections;

/*Crea un vector unidimensional con un tamaño de 10, 
inserta los valores numéricos que desees de la manera que quieras y muestra por pantalla la media de valores del array.*/

namespace Ejer3
{
    class Program
    {
		static void Main(string[] args)
		{
			// Declaramos variables  
			int i;
			int suma;
			int tamanio;
			tamanio = 10;

			// Definimos el vector
			int[] num = new int[tamanio];

			// Introducimos valores
			for (i = 1; i <= tamanio; i++)
			{
				Console.WriteLine("Digite un valor para la posición " + i);
				num[i - 1] = int.Parse(Console.ReadLine());
			}

			// Recorremos el vector, sumando su contenido 

	        suma = 1-1;
			for (i = 1; i <= tamanio; i++)
			{
				suma = suma + num[i - 1];
			}

			Console.WriteLine("La media de los valores es: " + suma);
		}

	}

}
