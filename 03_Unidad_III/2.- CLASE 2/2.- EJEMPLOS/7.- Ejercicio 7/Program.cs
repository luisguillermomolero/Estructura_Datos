using System;

namespace AplicacionBase
{
    // Aplicación que permite sumar o restar dos números

    public class Operacion
    {
        // Protección de los datos a traves del modificador "protected"

        protected int valor1;
        protected int valor2;
        protected int resultado;

        /* Cambio en las propiedades de los datos a traves de los métodos Set y Get.
         * Estas propiedades son públicas */

        /* El método relacionado con la lectura se conoce como "get" y el 
         * relacionado con la escritura es "set" */

        public int Valor1
        {
            set
            {
                valor1 = value;
            }
            get
            {
                return valor1;
            }
        }

        public int Valor2
        {
            set
            {
                valor2 = value;
            }
            get
            {
                return valor2;
            }
        }

        public int Resultado
        {
            protected set
            {
                resultado = value;
            }
            get
            {
                return resultado;
            }
        }
    }

    /* Luego de los dos puntos, seguidamente el nombre de la clase padre;
     * con esto estamos indicando que todas las propiedades de la clase 
     * Operación son también propiedades de la clase Suma. */

        public class Suma : Operacion
    {
        public void Operar()
        {
            Resultado = Valor1 + Valor2;
        }
    }


    public class Resta : Operacion
    {
        public void Operar()
        {
            Resultado = Valor1 - Valor2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Suma suma1 = new Suma();
            suma1.Valor1 = 10;
            suma1.Valor2 = 7;
            suma1.Operar();
            Console.WriteLine("La suma de " + suma1.Valor1 + " y " + suma1.Valor2 + " es " + suma1.Resultado);

            Resta resta1 = new Resta();
            resta1.Valor1 = 8;
            resta1.Valor2 = 4;
            resta1.Operar();
            Console.WriteLine("La resta de " + resta1.Valor1 + " y " + resta1.Valor2 + " es " + resta1.Resultado);

            Console.ReadKey();
        }
    }
}