using System;

namespace AplicacionBase
{

    /* Realizar un programa que permita ingresar los nombres de 5 operarios y sus salarios respectivos. 
     * Mostrar el sueldo mayor y el nombre del operario 
     */

    class PruebaVector
    {
        //Declaramos un vector de tipo string para los nombres
        private string[] nombreOperario;

        //Declaramos un vector de tipo float para los sueldos
        private float[] sueldoOperarios; 

        public void CargarVectores()
        {
            nombreOperario = new string[5];
            sueldoOperarios = new float[5];

            // Ciclo For para cargar el vector "nombreOperario" y "sueldoOperarios"

            for (int f = 0; f < nombreOperario.Length; f++)
            {
                Console.Write($"Ingrese el nombre del operario {f+1} : ");
                nombreOperario[f] = Console.ReadLine();

                Console.Write($"Ingrese el sueldo del operario {nombreOperario[f]} : ");
                sueldoOperarios[f] = float.Parse(System.Console.ReadLine());
            }
        }

        public void MayorSueldo()
        {
            float MayorSueldo = 0;
            int PosicionOperario = 0;
            float MAYOR_SUELDO = sueldoOperarios[0];

            for (int f = 0; f < nombreOperario.Length; f++)
            {
                if (sueldoOperarios[f] > MAYOR_SUELDO)
                {
                    MAYOR_SUELDO = sueldoOperarios[f];
                    MayorSueldo = MAYOR_SUELDO;
                    PosicionOperario = f;
                }
            }
            Console.WriteLine("El empleado con sueldo mayor es :" + nombreOperario[PosicionOperario]);
            Console.WriteLine($"Tiene un sueldo de: {MayorSueldo}");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            PruebaVector pv = new PruebaVector();
            pv.CargarVectores();
            pv.MayorSueldo();
        } 
    }
}