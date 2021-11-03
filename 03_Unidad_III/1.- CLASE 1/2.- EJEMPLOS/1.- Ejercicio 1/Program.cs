using System;

namespace Aplicacionbase
{

    /* Problema: Se desea guardar los sueldos de 5 operarios en un vector. 
     * Realizar la creación y carga del vector en el constructor. */

    class Operarios
    {
        private int[] sueldos;

        // Constructor operarios
        public Operarios()
        {
            sueldos = new int[5];
            for (int f = 0; f < sueldos.Length; f++)
            {
                Console.Write("Ingrese el sueldo:");
                string linea = Console.ReadLine();
                sueldos[f] = int.Parse(linea);
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < sueldos.Length; f++)
            {
                Console.WriteLine(sueldos[f]);
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            // Llamada al método constructor Operarios

            Operarios op = new Operarios();
            op.Imprimir();

            Operarios segundoOperario = new Operarios();
            segundoOperario.Imprimir();            
        }
    }
}