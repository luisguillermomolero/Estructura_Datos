using System;

namespace Ejer9
{
    class Program
    {
		static void Main(string[] args)
		{
			//Declaracion de variable
			double elemento;
			bool elemento_no_repetido;
			int i;
			int numero_elementos;
			int tamanio;

			// Indicamos el tamaño del vector
			Console.WriteLine("Introduce el tamaño del arreglo");
			tamanio = int.Parse(Console.ReadLine());
			double[] numeros_no_repetidos = new double[tamanio];

			// Variables usadas
			numero_elementos = 1;
			elemento = 1;
			elemento_no_repetido = true;

			// No salimos hasta que el numero de elementos sea igual al del tamaño
			while (numero_elementos < tamanio)
			{
				// Pedimos un valor numerico
				Console.WriteLine("Escribe un valor numerico, no repetido");
				elemento = Double.Parse(Console.ReadLine());

				// Recorro de nuevo el arreglo
				for (i = 1; i <= numero_elementos; i++)
				{
					// Comprobamos que el numero existe
					if (elemento == numeros_no_repetidos[i - 1])
					{
						elemento_no_repetido = false;
					}
				}
				// Si no entra en el anterior Si .. entonces
				// Quiere decir que no esta en el arreglo
				if (elemento_no_repetido)
				{
					// Asigno el valor no repetido
					numeros_no_repetidos[numero_elementos - 1] = elemento;
					// Aumento el numero de elementos
					numero_elementos = numero_elementos + 1;
				}
				else
				{
					Console.WriteLine("Este elemento existe en el arreglo");
				}
				// Reinicio la variable
				elemento_no_repetido = true;
			}
			// Muestro el arreglo
			for (i = 1; i <= tamanio; i++)
			{
				Console.WriteLine("Los numeros del arreglo son: " + numeros_no_repetidos[i - 1]);
			}
		}

	}

}