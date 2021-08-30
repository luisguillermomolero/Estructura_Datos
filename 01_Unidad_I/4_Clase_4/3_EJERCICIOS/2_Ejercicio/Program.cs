using System;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
			int LONGITUD_VECTOR = 3;
			
			int[] valorPosicion = new int[LONGITUD_VECTOR];

			for (int i = 0; i < LONGITUD_VECTOR; i++)
			{
				Console.Write($"Introduce un valor para la posición {i}: ");
				valorPosicion[i] = int.Parse(System.Console.ReadLine());
			}
			
			foreach (int j in valorPosicion)
				Console.Write($"| {j}  |");
		}
    }
}
