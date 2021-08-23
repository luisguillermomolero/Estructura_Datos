using System;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
			int i;
			int LONGITUD = 5;
			
			int[] valorPosicion = new int[LONGITUD];

			for (i = 0; i < LONGITUD; i++)
			{
				Console.Write($"Introduce un valor para la posición {i}: ");
				valorPosicion[i] = int.Parse(System.Console.ReadLine());
			}
			
			foreach (int j in valorPosicion)
				Console.WriteLine($"{j} ");
		}
    }
}
