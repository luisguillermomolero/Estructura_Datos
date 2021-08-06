using System;
using System.Collections.Generic;
using System.Text;


namespace AplicacionBase
{
    // Programa que convierte unidades de medida: de Pies y Pulgadas a Centimetros
    class Program
    {
        static void   Main(string[] args)
        {
            float pies = 0.0f;
            float pulgadas = 0.0f;
            float valorpie = 30.48f;
            float valorpulgada = 2.54f;
            string respuesta = ""; 
            string  valor =  "";

            do
            {
                // Se inicializan las funciones


                float conversion1 = 0.0f;
                float conversion2 = 0.0f;

                // Se introducen datos por teclado

                Console.WriteLine("Ingrese por favor cuantos pies desea convertir a centimetros: "); 
                valor =  Console.ReadLine();
                pies = Convert.ToSingle(valor);


                // Se convierte de pies a centimetros

                conversion1 = pies * valorpie;


                // Se muestra el resultado por pantalla

                Console.Write("{0} pies son {1} centimetros", pies, conversion1);
                Console.WriteLine("");


                // Se introducen datos por teclado

                Console.WriteLine("");
                Console.WriteLine("Ingrese por favor cuantas pulgadas quiere convertir a centimetros: "); 
                valor =  Console.ReadLine();
                pulgadas = Convert.ToSingle(valor);


                // Se convierte de pulgadas a centimetros

                conversion2 = pulgadas * valorpulgada;


                // Se muestra el resultado por pantalla

                Console.WriteLine("{0} pulgadas son {1} centimetros", pulgadas, conversion2);


                // Se solicita continuar/salir del programa

                Console.WriteLine("");
                Console.Write("Deseas hacer otra conversión (si / no) ?");
                Console.WriteLine("");
                respuesta = Console.ReadLine();

            } while (respuesta =="si");
        }
    }
}
