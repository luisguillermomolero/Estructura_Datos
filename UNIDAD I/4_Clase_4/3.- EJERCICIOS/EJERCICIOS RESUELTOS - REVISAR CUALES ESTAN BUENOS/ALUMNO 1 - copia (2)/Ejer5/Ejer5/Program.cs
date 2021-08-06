using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

/*Crea  dos  vectores  unidimensionales  que  tengan  el  mismo  tamaño  (lo  pedirá  por teclado), 
en  uno  de  ellos  almacenaras  nombres  de  personas  como  cadenas,  en  el otro  vector  ira  almacenando  la  longitud  de  los  nombres. 
Muestra  por  pantalla  el nombre y la longitud que tiene.*/



namespace Ejer5
{
	class Program
	{
		static void mostrarvectores(string[] longitud_nombres, string[] nombres, double tamanio)
		{
			double i;
	
		}

		static void Main(string[] args)
		{
			// Declaramos variables  
			int i;
			int tamaño;

			// Definimos el tamaño del vector por teclado 
			Console.WriteLine("Digite el tamaño de los Vectores");
			tamaño = int.Parse(Console.ReadLine());

			// Definicion del vector   
			int[] longitud_nombres = new int[tamaño];
			string[] nombres = new string[tamaño];

			// Introduccion de los nombres y la longitud de los mismos
			for (i = 1; i <= tamaño; i++)
			{
				Console.WriteLine("Asigne un nombre para la posicion " + i);
				nombres[i - 1] = Console.ReadLine();
				longitud_nombres[i - 1] = nombres[i - 1].Length;
			}
			
			//Ciclo para la ejecucion del vector
			for (i=1; i<=tamaño; i++)
            {

				Console.WriteLine("La longitud del nombre " + nombres[i-1] + " es de " + longitud_nombres[i-1]);

			}


		}

	}

}







