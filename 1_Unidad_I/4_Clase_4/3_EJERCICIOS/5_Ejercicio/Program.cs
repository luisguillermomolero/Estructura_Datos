using System;

namespace AplicacionBase
{
	/* Aplicación que permite guardar en un arreglo un nombre y en otro arreglo la longitud
	 * en caracteres de ese nombre
	 */
	 
    class Program
    {
        static void Main(string[] args)
        {
			int i;
			int longitudVector;
			Console.Write("Introduce la longitud del vector: ");
			longitudVector = int.Parse(System.Console.ReadLine());

			int[] longitudNombre = new int[longitudVector];
			string[] vectorNombre = new string[longitudVector];
			for (i = 0; i < longitudVector; i++)
			{
				Console.Write($"Introduce un nombre para la posicion {i+1} del vector: ");
				vectorNombre[i] = Console.ReadLine();
				longitudNombre[i] = vectorNombre[i].Length;
			}
			for (i = 0; i < longitudVector; i++)
				Console.WriteLine($"La longitud del nombre {vectorNombre[i]} es de {longitudNombre[i]} caracteres");
		}
	}
}
