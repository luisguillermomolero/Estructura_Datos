using System;
using System.Linq;
using System.Text;
using System.Collections;

/*Crea un vector unidimensional con un tamaño de 5, asígnale los valores numéricos manualmente (los que tú quieras) y muéstralos por pantalla.*/

namespace Ejer1
{
    class Program
    {
		static void Main(string[] args)
		{
			// Declaramos variables
			int i;
			int tamanio;
			tamanio = 5;

			// Definimos el vector
			int[] num = new int[tamanio];

			// Asignamos valores 
			num[0] = 1;
			num[1] = 2;
			num[2] = 3;
			num[3] = 4;
			num[4] = 5;

			// Recorremos el vector y mostramos su contenido
			for (i = 1; i <= tamanio; i++)
			{
				Console.WriteLine(num[i - 1]);
			}
		}

	}

}