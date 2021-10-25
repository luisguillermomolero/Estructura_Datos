using System;

namespace Aplicacionbase
{

    /* Plantear una clase llamada Alumno y definir como atributos su nombre y su edad. 
     * En el constructor se realizará la carga de datos. 
     * Definir otros dos métodos para imprimir los datos ingresados y un mensaje si es 
     * mayor de edad o no (edad >=18) */


    class Alumno
    {
        private string nombre;
        private int edad;

        // Definir el método constructor "Alumno"

        public Alumno()
        {
            Console.Write("Ingrese nombre:");
            nombre = Console.ReadLine();

            Console.Write("Ingrese edad:");
            string linea = Console.ReadLine();
            edad = int.Parse(linea);
        }

        // Definir el método "Visualizador" "Imprimir"

        public void Imprimir()
        {
            Console.WriteLine("Nombre:" + nombre);
            Console.WriteLine("Edad:" + edad);
        }

        // Definir el método "Operador" "EsMayorEdad"

        public void EsMayorEdad()
        {
            if (edad >= 18)
            {
                Console.Write(nombre + " es mayor de edad.");
            }
            else
            {
                Console.Write(nombre + " no es mayor de edad.");
            }
        }

        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            alumno1.Imprimir();
            alumno1.EsMayorEdad();
            Console.ReadKey();

        }
    }
}