using System;
using System.Linq;
using System.Text;
using System.Collections;

/*Modifica    el    ejercicio    anterior    para    que    insertes    los    valores    numéricos conleermediante unbucle y los muestre por pantalla.*/

namespace Ejer2
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

			// Introducimos valores
			for (i = 1; i <= tamanio; i++)
			{
				Console.WriteLine("Digite un valor para la posición " + i);
				num[i - 1] = int.Parse(Console.ReadLine());
			}
			// Recorremos el vector y mostramos su contenido
			for (i = 1; i <= tamanio; i++)
			{
				Console.WriteLine(num[i - 1]);
			}
		}

	}

}