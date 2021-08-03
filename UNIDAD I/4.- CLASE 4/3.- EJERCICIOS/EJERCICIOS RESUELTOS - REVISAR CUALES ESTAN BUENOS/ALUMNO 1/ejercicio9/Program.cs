using System;

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
			double elemento;
			bool elemento_no_repetido;
			int i;
			int numero_elementos;
			int tamanio;
			Console.WriteLine("Introduce el tamaño del vector");
			tamanio = int.Parse(Console.ReadLine());
			double[] numeros_no_repetidos = new double[tamanio];
			numero_elementos = 0;
			elemento = 0;
			elemento_no_repetido = true;
			while (numero_elementos < tamanio)
			{
				Console.WriteLine("Escribe un valor numerico, no repetido");
				elemento = Double.Parse(Console.ReadLine());
				for (i = 0; i <= numero_elementos - 1; i++)
				{
					{
						elemento_no_repetido = false;
					}
				}
				if (elemento_no_repetido)
				{
					numero_elementos = numero_elementos + 1;
				}
				else
				{
					Console.WriteLine("Este elemento existe en el arreglo");
				}
				elemento_no_repetido = true;
			}
			// Muestro el arreglo
			for (i = 0; i <= tamanio - 1; i++)
			{
				Console.WriteLine(numeros_no_repetidos[i - 1]);
			}
		}
    }
}
