using System;
using System.Collections;

//Escriba un programa que calcule la sumatoria de los cuadrados de los elementos de una lista/pila/cola de números enteros

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Elementos = new ArrayList();

            Console.WriteLine("La lista es: ");
            Elementos.Add(100);
            Elementos.Add(50);
            Elementos.Add(20);
            Elementos.Add(500);
            Elementos.Add(30);
            Elementos.Add(400);
            Elementos.Add(1);
            Elementos.Add(70);
            ImprimirElementosLista(Elementos);

            Console.WriteLine("Los valores elevados al cuadrado son: ");
            CuadradosElementosLista(Elementos);

            Console.WriteLine("La suma de todos los valores elevados al cuadrado es de: ");
            SumatoriaElementosLista(Elementos);
        }
        static void ImprimirElementosLista(ArrayList arreglo){
            foreach (int n in arreglo)
                Console.Write($" {n}");
            Console.WriteLine("\n-----------");
        }
        
        static void CuadradosElementosLista(ArrayList arreglo)
        {
            foreach (int n in arreglo)
                Console.Write(" {0},", n * n);
            Console.WriteLine("\n-----------");
        }

        static void SumatoriaElementosLista(ArrayList arreglo)
        {
            int Elementos = 0;
            foreach (int n in arreglo)
                Elementos = Elementos + (n * n);
            Console.WriteLine(" {0}", Elementos);
            Console.WriteLine("\n-----------");
        }
    }
}
