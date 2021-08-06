using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
			int i;
			int num_multiplo;
			int tamanio;
			int suma;

			Console.WriteLine("Introduce el tamaño del vector");
			tamanio = int.Parse(Console.ReadLine());

			int[] num = new int[tamanio];

			Console.WriteLine("Introduce el numero con el que rellenar");
			num_multiplo = int.Parse(Console.ReadLine());
			for (i = 1; i <= tamanio; i++)
			{
				num[i - 1] = num_multiplo * i;
			}
			Console.WriteLine();
		}
    }
}
