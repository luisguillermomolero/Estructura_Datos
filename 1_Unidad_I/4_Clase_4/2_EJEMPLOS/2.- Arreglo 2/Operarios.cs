using System;

namespace AplicacionBase
{
    /* Programa que permite ingresar los nombres de 5 operarios y sus salarios respectivos. 
     * Mostrar el sueldo mayor y el nombre del operario.
     */

    class Operarios
    {
        //Declaramos un vector de tipo string para los nombres
        private string[] nombreOperario;

        //Declaramos un vector de tipo float para los sueldos
        private float[] sueldoOperarios; 

        public void CargarVectores()
        {
            nombreOperario = new string[2];
            sueldoOperarios = new float[2];

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
            float MAYOR_SUELDO = 10;

            for (int f = 1; f < nombreOperario.Length; f++)
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
            Operarios operarios = new Operarios();
            operarios.CargarVectores();
            operarios.MayorSueldo();
        } 
    }
}