using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
			int i;
			int tamanio;
			Console.WriteLine("Introduce el tamaño de la longitud");
			tamanio = int.Parse(Console.ReadLine());
			int[] longitud_nombres = new int[tamanio];
			string[] nombres = new string[tamanio];
			for (i = 1; i <= tamanio; i++)
			{
				Console.WriteLine("Introduce un nombre para la posicion " + i);
				nombres[i - 1] = Console.ReadLine();
				longitud_nombres[i - 1] = nombres[i - 1].Length;
			}
			for (i = 1; i <= tamanio; i++)
			{
				Console.WriteLine("La longitud del nombre " + nombres[i - 1] + " es de " + longitud_nombres[i - 1]);
			}
		}
    }
}
