using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/* Variables: 
 * Los nombres de las variables deben empezar con letra.
 * Se puede colocar números en los nombres de las variables, pero no empezar el nombre con ellos.
 *
 * MiPrimeraVariable
 *
 * miPrimeraVariable
 *
 * CEDULA_EMPLEADO = 123456
 * cedulaEmpleado
 * CedulaEmpleado
 *
 * Los nombres de las variables no pueden llevar signos a excepción del guión bajo _ .
 * Las variables no pueden llevar acentos en sus nombres.
 * C# es case sensitivity: la variable "costo" no es igual a "COSTO" ó "Costo" */

// Errores de sintaxis ó errores de lógica

namespace AplicacionBase
{
    //clas program, Donde esta el error? que tipo de error es?
    class Program
    {
        // Programa que permite mostrar unidades de medida de masa

        static void Main(string[] args)
        {
            // Declaración de variables "tipo" "NombreVariable" = valor
            /* Tipos de datos en C#: bool, float, byte, int, sbyte, char, 
             * decimal, double, uint, long, ulong, short, ushort, string */

            // Diferencia entre declaración de variables o constantes
            // int COSTO = 50;
            // float Punto = 0;
            // string Valor = "";
            

            int Costo;
            int Valor;
            int Impuesto;

            //Tambien se puede declarar como:
            // int Costo, Valor, Impuesto;
            // int costo = 0;
            // int valor = 0;
            // int impuesto = 0;

            // Mostrar los valores de las variables por consola

            int LIBRAS = 453;
            int KILO = 1000;
            int TONELADA = 1016;
            int Peso = 0;

            Console.WriteLine("Hola Mundo");
            Console.WriteLine("Una libra son {0} {1} {2} {3}", LIBRAS, KILO, TONELADA, Peso);

            Console.WriteLine("Una libra son {0} gramos", LIBRAS);
            Console.WriteLine("Un kilo son {0} gramos o dos libras", KILO);
            Console.WriteLine("Una tonelada son {0} kilos", TONELADA);
            Console.WriteLine("");
            Console.WriteLine("Tambien una libra son {0} gramos, un kilo son {1} gramos y una tonelada son {2} kilos", LIBRAS, KILO, TONELADA);

            /* Que tipo de error tiene la siguiente sentencia?
             * Console.WriteLine(" Tambien una libra son {1} gramos, un kilo {2} gramos o una tonelada {3} kilos", libra, kilo, tonelada);
            */

            // Uso de operaciones aritmeticas

            Console.WriteLine("\n");
            Console.WriteLine("Calcular cuanto son dos libras de queso");
            Peso = LIBRAS * 2;
            Console.WriteLine("Dos libras de queso son {0} gramos", Peso);

            /*Realice un programa que permita calcular la suma, resta
             * multiplicación y división de dos numeros, utilizando las constantes
             * "a" y "b" y la variable "resultado". Finalmente, mostrar por
             * pantalla cada resultado*/

            //Precedencia de operaciones aritmeticas, uso de parentesis ()

            int VALOR1 = 10;
            int VALOR2 = 2;
            int VALOR3 = 23;
            int Resultado = 0;

            Resultado = VALOR1 + VALOR2;
            Console.WriteLine(""); 
            Console.WriteLine("la suma de {0} mas {1}, es igual a {2}", VALOR1, VALOR2, Resultado);

            Resultado = (VALOR1 * VALOR2) + VALOR3;
            Console.WriteLine(""); 
            Console.WriteLine("La multiplicación de ({0} * {1}) + {2} = {3}", VALOR1, VALOR2, VALOR3, Resultado);
        }
    }
}



