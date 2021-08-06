using System;

//Crea dos vectores unidimensionales que tengan el mismo tamaño (lo pedirá por
//teclado), en uno de ellos almacenaras nombres de personas como cadenas, en el
//otro vector ira almacenando la longitud de los nombres. Muestra por pantalla el
//nombre y la longitud que tiene. Puedes usar funciones si lo deseas.
namespace Ejercicio_5
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            int a = 0;
            int b;
            Console.WriteLine("Cuantos nombres va agregar: ");
            a = Convert.ToInt32(Console.ReadLine());

            //declaramos un arreglo tipo string para hacer el listado
            string[] Nombres = new string[a];
            for (int i = 0; i < Nombres.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre de la persona " + (i + 1) + " : ");
                Nombres[i] = Console.ReadLine();

                //otro arreglo para guardar la longitud
                int[] Longitud = new int[i];
                Console.WriteLine("");
                Console.WriteLine("Su longitud es de: ");

                //Le asignamos el vaor a b y lo mandamos por pantalla
                b = Nombres[i].Length;
                Console.WriteLine(b);
                Console.WriteLine("");
            }
        }
    }
}