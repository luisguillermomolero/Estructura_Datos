using System;
using System.Collections;

namespace Aplicacionbase
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList miLista = new ArrayList();

            // Añadimos valores a nuestra ArrayList en orden

            miLista.Add("Hola,");
            miLista.Add("soy");
            miLista.Add("yo");

            // Mostramos el contenido del ArrayList por pantalla

            Console.WriteLine("Paso 1");
            Console.WriteLine("Contenido actual:");
            
            foreach (string frase in miLista)
                Console.WriteLine(frase);

            // Accedemos a una posición

            Console.WriteLine("");
            Console.WriteLine("Paso 2");
            Console.WriteLine($"La segunda palabra es: {miLista[1]} ");

            // Insertamos en la segunda posicion

            miLista.Insert(1, "Como estas?");

            // Mostramos de otra forma lo que contiene

            Console.WriteLine("");
            Console.WriteLine("Paso 3");
            Console.WriteLine("Contenido tras insertar:");
            
            for (int i = 0; i < miLista.Count; i++)
                Console.WriteLine(miLista[i]);

            // Buscamos un elemento

            Console.WriteLine("");
            Console.WriteLine("Paso 4");
            Console.WriteLine("La palabra \"yo\" está en la posición {0}", miLista.IndexOf("yo"));   //InexOf método de busqueda lento

            // Ordenamos
            miLista.Sort();

            // Mostramos lo que contiene

            Console.WriteLine("");
            Console.WriteLine("Paso 5");
            Console.WriteLine("Contenido tras ordenar");
            
            foreach (string frase in miLista)
                Console.WriteLine(frase);

            // Buscamos con búsqueda binaria

            Console.WriteLine("");
            Console.WriteLine("Paso 6");
            Console.WriteLine("Ahora \"yo\" está en la posición {0}",
                miLista.BinarySearch("yo"));  //Método de busqueda rapido

            // Invertimos la lista

            miLista.Reverse();

            // Borramos el segundo dato y la palabra "yo"

            miLista.RemoveAt(1);
            miLista.Remove("yo");

            // Mostramos nuevamente lo que contiene

            Console.WriteLine("");
            Console.WriteLine("Paso 7");
            Console.WriteLine("Contenido dar la vuelta y tras eliminar dos:");

            foreach (string frase in miLista)
                Console.WriteLine(frase);

            // Ordenamos y vemos dónde iría un nuevo dato

            miLista.Sort();
            Console.WriteLine("");
            Console.WriteLine("Paso 8");
            Console.WriteLine("La frase \"Hasta Luego\"...");

            int posicion = miLista.BinarySearch("Hasta Luego");

            if (posicion >= 0)
                Console.WriteLine($"Está en la posición {posicion}");
            else
                Console.WriteLine($"No está. El dato inmediatamente mayor es el {~posicion}: {miLista[~posicion]}");
        }
    }
}