using System;

namespace AplicacionBase
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] Vector = {0, 1, 2, 3, 4, 5};

			foreach (int i in Vector)
				Console.Write($"{i} ");
		
			int[,] Numero2D = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };

			Console.WriteLine("");
			foreach (int i in Numero2D)
	    		Console.Write($"{i} ");
		}
	}
}
