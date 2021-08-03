using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/*Pedir  valores  numéricos  en  dos  vectores  distintos  y  almacenar  el  resultado  de  los valores de cada posición 
 * (posición 0 del arreglo 1 + posición 0 del arreglo 2) y mostrar el  contenido  de  los  3  vectores  de  esta  forma.
 * valor  pos  0  arreglo  1  + valor  pos  0 arreglo 2 = valor pos 0 arreglo 3 valor pos 1 vector 1 + valor pos 1 arreglo 2 = valor pos 1 arreglo 3 ...*/

namespace Ejer6
{
    class Program
    {
		static void Main(string[] args)
		{
			int i;
			int tamaño;

			// Tamaño del arreglo, se puede cambiar
			tamaño = 5;
			string[] a1 = new string[tamaño];
			string[] a2 = new string[tamaño];
			string[] a3 = new string[tamaño];

			// Recorremos de 1 a Tamaño-1
			// Podemos rellenar el arreglo a1, a2 y a3

			for (i = 1; i <= tamaño - 1; i++)
			{

				Console.WriteLine("Introduce el valor del arreglo a1 en la posicion ");
				a1[i] = Console.ReadLine();
				Console.WriteLine("Introduce el valor del arreglo a2 en la posicion ");
				a2[i] = Console.ReadLine();

				a3[i]=(a1[i]+a2[i]);

			}

			

			// Mostramos los datos en el formato dicho

			for (i = 1; i <= tamaño - 1; i++)
			{
				
				Console.WriteLine(a1[i] + " + " + a2[i] + " = " + a3[i]);
			}
		}

	}

}


