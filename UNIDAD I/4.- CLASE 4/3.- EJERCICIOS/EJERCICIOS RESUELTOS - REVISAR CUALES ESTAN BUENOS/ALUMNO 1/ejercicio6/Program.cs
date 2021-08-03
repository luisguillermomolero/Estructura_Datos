using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
			nt i;
			int tamanio;
			tamanio = 5;
			string[] a1 = new string[tamanio];
			string[] a2 = new string[tamanio];
			string[] a3 = new string[tamanio];
			for (i = 0; i <= tamanio - 1; i++)
			{
				Console.WriteLine("Introduce el valor del arreglo a1 en la posicion " + i);
				a1[i - 1] = Console.ReadLine();
				Console.WriteLine("Introduce el valor del arreglo a2 en la posicion " + i);
				a2[i - 1] = Console.ReadLine();
				a3[i - 1] = a1[i - 1] + a2[i - 1];
			}
			for (i = 0; i <= tamanio - 1; i++)
			{
				Console.WriteLine(a1[i - 1] + " + " + a2[i - 1] + " = " + a3[i - 1]);

			}
		}
    }
}
