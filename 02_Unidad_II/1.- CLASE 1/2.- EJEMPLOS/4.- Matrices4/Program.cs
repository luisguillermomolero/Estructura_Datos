using System;

namespace AplicacionBase
{
    /* Programa que permite ingresar el sueldo de 5 empleados en un trimestre, luego totalizar los sueldos de los empleados  y decir cual de los 5 gano durante el trimestre */

    class MatrizEmpleados
    {
        // Declaramos dos vectores y una matriz
        string[] Empleados = new string[4];
        int[,] SueldoEmpleado = new int[4,3];
        private int[] TotalizacionSueldos;

        public void CargarMatriz()
        {
            for (int f = 0; f < Empleados.Length; f++){
                
                // Cargar el vector "Empleados"
                Console.Write($"Ingrese el nombre del empleado {f+1}: ");
                Empleados[f] = Console.ReadLine();

                // Ciclo para solicitar el sueldo de cada mes del empleado
                for (int c = 0; c < SueldoEmpleado.GetLength(1); c++){
                    Console.Write($"Ingrese sueldo del mes {c+1}: ");
                    SueldoEmpleado[f,c] = int.Parse(System.Console.ReadLine());
                }
            }
        }

        public void CalcularSumatoriaSueldos()
        {
            TotalizacionSueldos = new int[4];

            for (int f = 0; f < SueldoEmpleado.GetLength(0); f++){
                int sumatoriaSueldos = 0;
                for (int c = 0; c < SueldoEmpleado.GetLength(1); c++){
                    sumatoriaSueldos += SueldoEmpleado[f, c];
                }
                TotalizacionSueldos[f] = sumatoriaSueldos;
            }
        }

        public void ImprimirTotalPagado()
        {
            Console.WriteLine("Total de sueldos pagados por empleado es: ");

            for (int f = 0; f < TotalizacionSueldos.Length; f++){
                Console.WriteLine("         Total trimestral del Empleado " + Empleados[f] + " es: " + TotalizacionSueldos[f]);
            }
        }

        public void EmpleadoMayorSueldo()
        {
            int mayorSalario = TotalizacionSueldos[0];
            string nombreEmpleado = Empleados[0];

            for (int f = 0; f < TotalizacionSueldos.Length; f++){
                if (TotalizacionSueldos[f] > mayorSalario){
                    mayorSalario = TotalizacionSueldos[f];
                    nombreEmpleado = Empleados[f];
                }
            }
            Console.WriteLine("   El empleado con mayor sueldo fue " + nombreEmpleado + ", que tiene un sueldo de " + mayorSalario);
        }

        static void Main(string[] args)
        {
            MatrizEmpleados matrizEmpleados = new MatrizEmpleados();
            matrizEmpleados.CargarMatriz();
            matrizEmpleados.CalcularSumatoriaSueldos();
            matrizEmpleados.ImprimirTotalPagado();
            matrizEmpleados.EmpleadoMayorSueldo();
        }
    }
}