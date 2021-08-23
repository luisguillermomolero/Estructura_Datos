using System;

namespace AplicacionBase
{
    // Programa que convierte unidades de medida: de Pies y Pulgadas a Centimetros
    class Program
    {
        static void Main(string[] args)
        {
            float Pies = 0.0f;
            float Pulgadas = 0.0f;
            float VALOR_PIE = 30.48f;
            float VALOR_PULGADA = 2.54f;
            string whileLoop = "";

            do
            {
                float conversionPiesACentimetros = 0.0f;
                float conversionPulgadasACentrimetros = 0.0f;

                // Se introducen datos por teclado

                Console.Write("Ingrese por favor cuantos Pies desea convertir a centimetros: "); 
                Pies = int.Parse(System.Console.ReadLine());

                // Se convierte de Pies a centimetros

                conversionPiesACentimetros = Pies * VALOR_PIE;

                // Se muestra el resultado por pantalla

                Console.Write($"{Pies} Pies son {conversionPiesACentimetros} centimetros");

                // Se introducen datos por teclado

                Console.Write("\n\nIngrese por favor cuantas Pulgadas desea convertir a centimetros: "); 
                Pulgadas = int.Parse(System.Console.ReadLine());

                // Se convierte de Pulgadas a centimetros

                conversionPulgadasACentrimetros = Pulgadas * VALOR_PULGADA;

                // Se muestra el resultado por pantalla

                Console.WriteLine($"{Pulgadas} Pulgadas son {conversionPulgadasACentrimetros}");

                // Se solicita continuar/salir del programa

                Console.Write("\nDeseas hacer otra conversión s/n: ");
                whileLoop = Console.ReadLine();

            } while (whileLoop =="s" || whileLoop == "S");
        }
    }
}

