using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
			int i;
			int suma;
			int tamanio;

			tamanio = 10;

			int[] num = new int[tamanio];

			for (i = 1; i <= tamanio; i++)
			{
				Console.WriteLine("Introduce un valor para la posición " + i);
				num[i - 1] = int.Parse(Console.ReadLine());
			}
			suma = 1 - 1;
			for (i = 1; i <= tamanio; i++)
			{
				suma = suma + num[i - 1];
			}
			Console.WriteLine("el resultado de los valores es:" + suma);
		}
    }
}
