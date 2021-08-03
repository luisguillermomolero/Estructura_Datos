using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaVector
{

    /* Realizar un programa que permita ingresar los nombres de 5 operarios y sus sueldos respectivos. 
     * Mostrar el sueldo mayor y el nombre del operario */

    class PruebaVector
    {
        //Declaramos un vector de tipo string para los nombres
        private string[] nombres;

        //Declaramos un vector de tipo float para los sueldos
        private float[] sueldos; 

        public void Cargar()
        {
            nombres = new string[5];
            sueldos = new float[5];
            
            // Ciclo For para llenar el vector "nombres" hasta su longitud final = 5, incrementando en 1

            for (int f = 0; f < nombres.Length; f++)
            {
                Console.Write("Ingrese el nombre del empleado " + (f + 1) + ": ");
                nombres[f] = Console.ReadLine();

                Console.Write("Ingrese el sueldo " + (f + 1) + ": ");
                string linea;
                linea = Console.ReadLine();
                sueldos[f] = float.Parse(linea);
            }
        }

        public void MayorSueldo()
        {
            float mayor;
            int posicion;
            mayor = sueldos[0];
            posicion = 0;
            for (int f = 1; f < nombres.Length; f++)
            {
                if (sueldos[f] > mayor)
                {
                    mayor = sueldos[f];
                    posicion = f;
                }
            }
            Console.WriteLine("El empleado con sueldo mayor es :" + nombres[posicion]);
            Console.WriteLine("Tiene un sueldo de: " + mayor);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            PruebaVector pv = new PruebaVector();
            pv.Cargar();
            pv.MayorSueldo();
        } 
    }
}