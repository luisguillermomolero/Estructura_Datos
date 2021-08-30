using System;

namespace AplicacionBase
{
	/* Aplicación que permite guardar en un vector un nombre y en otro vector la longitud
	 * en caracteres de ese nombre
	 */
	 
    class Program
    {
        static void Main(string[] args)
        {
			int longitudVector;

			Console.Write("Introduce la longitud del vector: ");
			longitudVector = int.Parse(System.Console.ReadLine());

			string[] vectorNombre = new string[longitudVector];
			int[] longitudNombre = new int[longitudVector];
			
			for (int i = 0; i < longitudVector; i++)
			{
				Console.Write($"Introduce un nombre para la posicion {i+1} del vector: ");
				vectorNombre[i] = Console.ReadLine();
				longitudNombre[i] = vectorNombre[i].Length;
			}
			for (int i = 0; i < longitudVector; i++)
				Console.WriteLine($"La longitud del nombre {vectorNombre[i]} es de -> {longitudNombre[i]} caracteres");
		}
	}
}
