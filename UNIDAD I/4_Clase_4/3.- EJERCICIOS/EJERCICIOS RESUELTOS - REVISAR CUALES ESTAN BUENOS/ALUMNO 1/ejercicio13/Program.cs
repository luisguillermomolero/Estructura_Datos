using System;

namespace ejercicio13
{
    class Program
    {
       
			static void Main(string[] args)
			{
				bool arreglo_a_rellenado;
				bool arreglo_b_rellenado;
				double forma_1;
				double forma_2;
				int longitud_arreglos;
				int maximo;
				int minimo;
				int opcion_menu;
				int opcion_submenu;
				bool salir;
				bool salir_submenu;
				// Constantes usadas
				minimo = -100;
				maximo = 100;
				forma_1 = 1;
				forma_2 = 2;
				// Pedimos la longitud de los arreglos
				Console.WriteLine("Escribe una longitud");
				longitud_arreglos = int.Parse(Console.ReadLine());
				// Dimensiones de los arreglos
				string[] a = new string[longitud_arreglos];
				string[] b = new string[longitud_arreglos];
				string[] c = new string[longitud_arreglos];
				arreglo_a_rellenado = false;
				arreglo_b_rellenado = false;
				opcion_menu = 0;
				do
				{
					// Menu
					Console.WriteLine("1. Llenar Vector A de forma aleatoria");
					Console.WriteLine("2. Llenar Vector B de forma aleatoria");
					Console.WriteLine("3. Realizar C = A + B");
					Console.WriteLine("4. Realizar C = B - A");
					Console.WriteLine("5. Mostrar arreglo");
					Console.WriteLine("6. Salir");
					// elijo una opcion del menu
					Console.WriteLine("Elige una opcion");
					opcion_menu = int.Parse(Console.ReadLine());
					salir = false;
					switch (opcion_menu)
					{
						case 1:
							// relleno el arreglo A
							llenararreglo(a, longitud_arreglos, minimo, maximo);
							arreglo_a_rellenado = true;
							Console.WriteLine("el arreglo A ha sido rellenado");
							break;
						case 2:
							// relleno el arreglo B
							llenararreglo(b, longitud_arreglos, minimo, maximo);
							arreglo_b_rellenado = true;
							Console.WriteLine("el arreglo B ha sido rellenado");
							break;
						case 3:
							if (arreglo_a_rellenado && arreglo_b_rellenado)
							{
								// relleno el arreglo C
								rellenarc(a, b, c, longitud_arreglos, forma_1);
								Console.WriteLine("el arreglo C ha sido rellenado");
							}
							else
							{
								if (!arreglo_a_rellenado)
								{
									Console.WriteLine("Tienes que rellenar el arreglo A");
								}
								if (!arreglo_b_rellenado)
								{
									Console.WriteLine("Tienes que rellenar el arreglo B");
								}
							}
							break;
						case 4:
							if (arreglo_a_rellenado && arreglo_b_rellenado)
							{
								// relleno el arreglo C
								rellenarc(a, b, c, longitud_arreglos, forma_2);
								Console.WriteLine("el arreglo C ha sido rellenado");
							}
							else
							{
								if (!arreglo_a_rellenado)
								{
									Console.WriteLine("Tienes que rellenar el arreglo A");
								}
								if (!arreglo_b_rellenado)
								{
									Console.WriteLine("Tienes que rellenar el arreglo B");
								}
							}
							break;
						case 5:
							// Submenu
							opcion_submenu = 0;
							do
							{
								Console.WriteLine("Escribe que arreglo quieres mostrar");
								Console.WriteLine("1. A");
								Console.WriteLine("2. B");
								Console.WriteLine("3. C");
								Console.WriteLine("4. Salir");
								opcion_submenu = int.Parse(Console.ReadLine());
								salir_submenu = false;
								// mostrar arreglos
								switch (opcion_submenu)
								{
									case 1:
										Console.WriteLine(a, longitud_arreglos);
										break;
									case 2:
										Console.WriteLine(b, longitud_arreglos);
										break;
									case 3:
										Console.WriteLine(c, longitud_arreglos);
										break;
									case 4:
										salir_submenu = true;
										break;
									default:
										Console.WriteLine("Elige alguna de las opciones");
									break;

								}
							} while (!salir_submenu);
							break;
						case 6:
							salir = true;
							break;
						default:
							Console.WriteLine("Escribe una opcion entre 1 y 6");
						break;
					}
				} while (!salir);
			}

			// rellena el arreglo
			static void llenararreglo(ref int[] arreglo, double longitud_arreglos, int min, int max)
			{
				Random aleatorio = new Random();

				int i;
				for (i = 0; i <= longitud_arreglos - 1; i++)
				{
					arreglo[i] = aleatorio.Next(min, max);
				}
			}

			// Muestra un arreglo concreto
			static void mostrararreglo(ref string[] arreglo, double longitud_arreglos)
			{
				int i;
				for (i = 0; i <= longitud_arreglos - 1; i++)
				{
					Console.Write(arreglo[i] + " ");
				}
				Console.WriteLine("");
			}

			// Rellena el arreglo C 
			static void rellenarc(ref double[] arregloa, ref double[] arreglob, ref double[] arregloc, double longitud_arreglos, double tipo)
			{
				int i;
				if (tipo == 1)
				{
					// punto 3
					for (i = 0; i <= longitud_arreglos - 1; i++)
					{
						arregloc[i] = arregloa[i] + arreglob[i];
					}
				}
				else
				{
					// punto 4
					for (i = 0; i <= longitud_arreglos - 1; i++)
					{
						arregloc[i] = arreglob[i] - arregloa[i];
					}
				}
			}
    }
}
