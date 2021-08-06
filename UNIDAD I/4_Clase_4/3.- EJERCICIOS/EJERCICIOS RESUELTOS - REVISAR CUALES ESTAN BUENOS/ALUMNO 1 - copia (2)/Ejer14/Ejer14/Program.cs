using System;

namespace Ejer14
{
    class Program
    {
		static void Main(string[] args)
		{
			double cantidad;
			int cantidad_decimal;
			int cantidad_entera;
			int i;
			int indice_billetes;
			int indice_monedas;
			int numero_billetes;
			int numero_monedas;
			int total;

			// Constantes usadas
			numero_billetes = 7;
			numero_monedas = 8;
			total = numero_billetes + numero_monedas;

			// arreglo de billetes
			double[] billetes = new double[numero_billetes];
			billetes[0] = 500;
			billetes[1] = 200;
			billetes[2] = 100;
			billetes[3] = 50;
			billetes[4] = 20;
			billetes[5] = 10;
			billetes[6] = 5;

			// arreglo de monedas
			double[] monedas = new double[numero_monedas];

			// las cantidades estan en centimos
			monedas[0] = 200;
			monedas[1] = 100;
			monedas[2] = 50;
			monedas[3] = 20;
			monedas[4] = 10;
			monedas[5] = 5;
			monedas[6] = 2;
			monedas[7] = 1;
			int[] cantidad_bill_mon = new int[total];

			// Indices para los arreglos de billetes y monedas
			indice_billetes = 1;
			indice_monedas = 1;

			// Pedimos la cantidad
			Console.WriteLine("Dame una cantidad mayor que 0");
			cantidad = Double.Parse(Console.ReadLine());

			// Comprobamos si la cantidad es mayor que 0
			if (cantidad >= 1)
			{
				// Saco la parte decimal y la entera
				cantidad_entera = (int)Math.Truncate(cantidad);
				cantidad_decimal = (int)Math.Truncate(((cantidad - cantidad_entera) * 100) + 0.1);

				// Recorro la cantidad_bill_mon
				for (i = 1; i <= total; i++)
				{
					// Si la i esta entre 0 y 6 en este caso, tocamos los billetes
					if (i <= numero_billetes)
					{
						// Ponemos la cantidad de billetes diviendo entre su numero y truncamos
						cantidad_bill_mon[i - 1] = (int)Math.Truncate(cantidad_entera / billetes[indice_billetes - 1]);

						// Actualizamos la cantidad entera usando el modulo (lo que sobra)
						cantidad_entera = (int)(cantidad_entera % billetes[indice_billetes - 1]);

						// Aumentamos el indice de los billetes
						indice_billetes = indice_billetes + 1;
					}
					else
					{
						// Solo para monedas de 1 y 2 euros (caso especial)
						if (indice_monedas >= 1 && indice_monedas <= 1)
						{
							// Ponemos la cantidad de monedas diviendo entre su numero y truncamos
							cantidad_bill_mon[i - 1] = (int)Math.Truncate(cantidad_entera / (monedas[indice_monedas - 1] / 100));

							// Actualizamos la cantidad entera usando el modulo (lo que sobra)
							cantidad_entera = (int)(cantidad_entera % (monedas[indice_monedas - 1] / 100));
						}
						else
						{
							// Ponemos la cantidad de monedas diviendo entre su numero y truncamos (parte decimla)
							cantidad_bill_mon[i - 1] = (int)Math.Truncate(cantidad_decimal / monedas[indice_monedas - 1]);

							// Actualizamos la cantidad entera usando el modulo (lo que sobra)
							cantidad_decimal = (int)(cantidad_decimal % monedas[indice_monedas - 1]);
						}
						// Aumentamos el indice de las monedas
						indice_monedas = indice_monedas + 1;
					}
				}
				// reiniciamos los indices
				indice_billetes = 1;
				indice_monedas = 1;

				// Recorremos de nuevo
				for (i = 1; i <= total; i++)
				{
					// Si la i esta entre 1 y 7 en este caso, tocamos los billetes
					if (i < numero_billetes)
					{
						// Si hemos rellenado una cantidad, la mostramos
						if (cantidad_bill_mon[i - 1] >= 1)
						{
							Console.WriteLine("Cantidad de " + billetes[indice_billetes - 1] + "€ es de: " + cantidad_bill_mon[i - 1]);
						}
						// Aumentamos el indice de las billetes
						indice_billetes = indice_billetes + 1;
					}
					else
					{
						// Si hemos rellenado una cantidad, la mostramos
						if (cantidad_bill_mon[i - 1] > 1)
						{
							// En este caso, llo volvemos a pasar a su valor original
							Console.WriteLine("Cantidad de " + (monedas[indice_monedas - 1] / 100) + "€ es de: " + cantidad_bill_mon[i - 1]);
						}
						// Aumentamos el indice de las monedas
						indice_monedas = indice_monedas + 1;
					}
				}
			}
			else
			{
				Console.WriteLine("La cantidad debe ser mayor que 0");
			}
		}

	}

}

