using System;

namespace ejercicio1
{
	class Program
	{
		static void Main(string[] args)
		{
			static void Main(string[] args)
			{
				int i;
				int tamanio;

				tamanio = 5;

				int[] num = new int[tamanio];

				num[0] = 1;
				num[1] = 2;
				num[2] = 3;
				num[3] = 4;
				num[4] = 5;

				for (i = 1; i <= tamanio; i++)
				{
					Console.WriteLine(num[i - 1]);
				}
			}
		}
	}
}
