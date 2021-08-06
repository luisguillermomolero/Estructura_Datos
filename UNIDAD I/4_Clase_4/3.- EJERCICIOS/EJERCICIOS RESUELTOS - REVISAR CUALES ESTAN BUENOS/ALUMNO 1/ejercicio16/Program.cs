using System;

namespace ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
			bool encontrado;
			int i;
			double numerobuscado;
			int tamanio;

			// Tamaño del arreglom se puede cambiar
			tamanio = 5;
			double[] a1 = new double[tamanio];
			a1[0] = 2;
			a1[1] = 5;
			a1[2] = 4;
			a1[3] = 3;
			a1[4] = 2;

			// Introducimos el numero a buscar
			Console.WriteLine("Porfavor digite el elemento a buscar");
			numerobuscado = Convert.ToInt32(Console.ReadLine());

			// Usado para marcar si existe o no el elemento buscado
			encontrado = false;

			// Recorremos el arreglo buscando los elementos
			for (i = 0; i <= tamanio - 1; i++)
			{
				if (numerobuscado == a1[i])
				{
					Console.WriteLine("Usuario se ha encontrado el numero " + numerobuscado + " en la posicion " + i);
					// Ya existe algun elemento
					encontrado = true;
				}
			}

			// Sino encuentro nada, muestro un mensaje
			if (!encontrado)
			{
				Console.WriteLine("lamentamos decirle que no se ha encontrado ningun elemento");
			}
		}
    }
}
