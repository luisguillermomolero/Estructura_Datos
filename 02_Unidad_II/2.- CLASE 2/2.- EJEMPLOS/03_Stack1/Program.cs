using System;
using System.Collections;

namespace AplicacionBase
{
    class program
    {
        static void Main(string [] arg)
        {
            // Programa que permite manupular un Stack a traves de sus métodos

            int Opcion = 0; 
            string Valor = "";
            
            int Numero = 0;
            bool Encontrado = false;

            Stack miPila = new Stack(); // Estructura tipo LIFO (Last In First Out)

            do
            {
                Console.WriteLine("1.- Push");          // Introducir elementos al stack
                Console.WriteLine("2.- Pop");           // Obtener informacion del stack
                Console.WriteLine("3.- Clear");         // Limpiar el stack
                Console.WriteLine("4.- Contains");      // Saber si el stack tiene elementos
                Console.WriteLine("5.- Mostrar todos los elementos");
                Console.WriteLine("6.- Salir");
                Console.WriteLine("Dame tu Opcion"); 

                Valor=Console.ReadLine(); 
                Opcion=Convert.ToInt32(Valor);

                if (Opcion == 1)
                {
                    Console.WriteLine("Por favor, introduce un número cualquiera");
                    Valor = Console.ReadLine();
                    Numero = Convert.ToInt32(Valor);
                    miPila.Push(Numero);
                }

                if (Opcion == 2)
                {
                    //Numero = (int) miPila.Pop();
                    Console.WriteLine("El valor obtenido es: {0}",miPila.Pop());
                }

                if (Opcion == 3)
                {
                    miPila.Clear();
                }

                if (Opcion == 4)
                {
                    Console.WriteLine("Dame el Valor a encontrar");
                    Valor = Console.ReadLine();
                    Numero = Convert.ToInt32(Valor);

                    Encontrado = miPila.Contains(Numero);

                    Console.WriteLine("Encontrado - {0}", Encontrado);
                }

                if (Opcion==5)
                {
                    Console.WriteLine("El stack tiene {0} elementos", miPila.Count);
                    foreach (int n in miPila)
                        Console.Write("  {0}", n);

                    Console.WriteLine("");
                    Console.WriteLine("————");
                }

            } while (Opcion != 6);
        }
    }
}

