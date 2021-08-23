using System;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
			int i, j;
			int longitudVector = 2;
			int[] primerVector = new int[longitudVector];
			int[] segundoVector = new int[longitudVector];
			int[] tercerVector = new int[longitudVector];
			for (i = 0; i < longitudVector ; i++)
			{
				Console.Write($"Introduzca el valor {i+1} del primer vector: ");
				primerVector[i] = int.Parse(System.Console.ReadLine());
				Console.Write($"Introduzca el valor {i+1} del segundo vector: ");
				segundoVector[i] = int.Parse(System.Console.ReadLine());
				tercerVector[i] = primerVector[i] + segundoVector[i];
			}
			for (j = 0; j < longitudVector; j++)
				Console.WriteLine($"La suma del valor {primerVector[j]} del primer vector + el valor {segundoVector[j]} del segundo vector es igual a: {tercerVector[j]}");
		}
    }
}
