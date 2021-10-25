using System;

namespace AplicacionBase
{
    public class Persona
    {
        // Protección de los datos a traves del modificador "protected"

        protected string nombre;
        protected int edad;

        /* Cambio en las propiedades de los datos a traves de los métodos Set y Get.
         * Estas propiedades son públicas */

        /* El método relacionado con la lectura se conoce como "get" y el 
         * relacionado con la escritura es "set" */

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public int Edad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Nombre:" + Nombre);
            Console.WriteLine("Edad:" + Edad);
        }
    }

    public class Empleado : Persona
    {
        protected float sueldo;

        public float Sueldo
        {
            set
            {
                sueldo = value;
            }
            get
            {
                return sueldo;
            }
        }

        new public void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("Sueldo:" + Sueldo);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.Nombre = "Juan";
            persona1.Edad = 25;
            Console.WriteLine("Los datos de la persona son:");
            persona1.Imprimir();

            Empleado empleado1 = new Empleado();
            empleado1.Nombre = "Ana";
            empleado1.Edad = 42;
            empleado1.Sueldo = 2524;
            Console.WriteLine("Los datos del empleado son:");
            empleado1.Imprimir();

            Console.ReadKey();
        }
    }
}