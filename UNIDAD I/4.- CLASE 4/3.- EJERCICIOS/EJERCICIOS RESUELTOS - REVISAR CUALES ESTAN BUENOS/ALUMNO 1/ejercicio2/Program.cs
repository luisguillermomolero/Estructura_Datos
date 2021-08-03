using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
			int i;
			int tamanio;
			tamanio = 5;
			int[] num = new int[tamanio];
			for (i = 1; i <= tamanio; i++)
			{
				Console.WriteLine("Introduce un valor para la posición " + i);
				num[i - 1] = int.Parse(Console.ReadLine());
			}
			for (i = 1; i <= tamanio; i++)
			{
				Console.WriteLine(num[i - 1]);
			}
		}
    }
}
