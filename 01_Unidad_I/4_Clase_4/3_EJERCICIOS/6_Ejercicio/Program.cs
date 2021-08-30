using System;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
			int LONGITUD_VECTOR = 2;

			int[] primerVector = new int[LONGITUD_VECTOR];
			int[] segundoVector = new int[LONGITUD_VECTOR];
			int[] tercerVector = new int[LONGITUD_VECTOR];

			for (int i = 0; i < LONGITUD_VECTOR ; i++)
			{
				Console.Write($"Introduzca el valor {i+1} del primer vector: ");
				primerVector[i] = int.Parse(System.Console.ReadLine());
				Console.Write($"Introduzca el valor {i+1} del segundo vector: ");
				segundoVector[i] = int.Parse(System.Console.ReadLine());
				tercerVector[i] = primerVector[i] + segundoVector[i];
			}
			
			for (int j = 0; j < LONGITUD_VECTOR; j++){
				Console.WriteLine($"La suma del valor {primerVector[j]} del primer vector + el valor {segundoVector[j]} del segundo vector es igual a: {tercerVector[j]}");
			}
		}
    }
}
