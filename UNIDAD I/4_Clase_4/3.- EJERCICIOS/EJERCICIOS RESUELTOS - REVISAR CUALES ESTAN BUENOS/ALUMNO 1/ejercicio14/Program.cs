using System;

namespace ejercicio14
{
    class Program
    {
		static void Main(string[] args)
		{
			int cantidad;
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
			int[] billetes = new int[numero_billetes];
			billetes[0] = 500;
			billetes[1] = 200;
			billetes[2] = 100;
			billetes[3] = 50;
			billetes[4] = 20;
			billetes[5] = 10;
			billetes[6] = 5;


			// arreglo de monedas
			int[] monedas = new int[numero_monedas];


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


			// arreglos de billetes y monedas
			indice_billetes = 0;
			indice_monedas = 0;


			// Pedimos la cantidad
			Console.WriteLine("Dame una cantidad mayor que 0");
			cantidad = Convert.ToInt32(Console.ReadLine());


			// Comprobamos si la cantidad es mayor que 0
			if (cantidad > 0)
			{
				// Saco la parte entera
				cantidad_entera = (cantidad);
				cantidad_decimal = (((cantidad - cantidad_entera) * 100) + 1);


				// Recorro la cantidad_bill_mon
				for (i = 0; i <= total - 1; i++)
				{
					// Si la i esta entre 0 y 6 en este caso, se usan los billetes
					if (i < numero_billetes)
					{
						// Ponemos la cantidad de billetes diviendo entre su numero 
						cantidad_bill_mon[i] = (cantidad_entera / billetes[indice_billetes]);

						// Actualizamos la cantidad entera usando el modulo (lo que sobra)
						cantidad_entera = cantidad_entera % billetes[indice_billetes];

						// Aumentamos el indice de los billetes
						indice_billetes = indice_billetes + 1;
					}
					else
					{
						// Solo para monedas de 1 y 2 euros (caso especial)
						if (indice_monedas >= 0 && indice_monedas <= 1)
						{
							// Ponemos la cantidad de monedas diviendo entre su numero
							cantidad_bill_mon[i] = (cantidad_entera / (monedas[indice_monedas] / 100));

							// Actualizamos la cantidad entera usando el modulo (lo que sobra)
							cantidad_entera = cantidad_entera % (monedas[indice_monedas] / 100);
						}
						else
						{
							// Ponemos la cantidad de monedas diviendo entre su numero
							cantidad_bill_mon[i] = (cantidad_decimal / monedas[indice_monedas]);

							// Actualizamos la cantidad entera usando el modulo (lo que sobra)
							cantidad_decimal = cantidad_decimal % monedas[indice_monedas];
						}
						// Aumentamos el indice de las monedas
						indice_monedas = indice_monedas + 1;
					}
				}


				// se reinician los indices
				indice_billetes = 0;
				indice_monedas = 0;


				// y otraves lo recorremos
				for (i = 0; i <= total - 1; i++)
				{
					// Si la i esta entre 0 y 6 en este caso, tocamos los billetes
					if (i < numero_billetes)
					{
						// Si hemos rellenado una cantidad, la mostramos
						if (cantidad_bill_mon[i] > 0)
						{
							Console.WriteLine("La cantidad de " + billetes[indice_billetes] + "€ que se necesitara es de: " + cantidad_bill_mon[i]);
						}
						// Aumentamos el indice de las billetes
						indice_billetes = indice_billetes + 1;
					}
					else
					{
						// Si hemos rellenado una cantidad, la mostramos
						if (cantidad_bill_mon[i] > 0)
						{
							// En este caso, llo volvemos a pasar a su valor original
							Console.WriteLine("La cantidad de " + (monedas[indice_monedas] / 100) + "€ que se necesitara es de: " + cantidad_bill_mon[i]);
						}
						// Aumentamos el indice de las monedas
						indice_monedas = indice_monedas + 1;
					}
				}
			}
			else
			{
				Console.WriteLine("La cantidad debe se mayor que 0");
			}
		}
	}
}
