using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/* Variables: 
 * Los nombres de las variables deben empezar con letra.
 * Se puede colocar números en los nombres de las variables, pero no empezar el nombre con ellos.
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

            /* Diferencia entre declaración de variables o constantes
             * int costo = 50;
             * float punto = 0;
             * string valor ="";
             * */

            int costo;
            int valor;
            int impuesto;

            /* Tambien se puede declarar como:
             * int costo, valor, impuesto;
             * int costo = 0;
             * int valor = 0;
             * int impuesto = 0; */

            // Mostrar los valores de las variables por consola

            int libra = 453;
            int kilo = 1000;
            int tonelada = 1016;
            int peso = 0;

            Console.WriteLine("Una libra son {0} gramos", libra);
            Console.WriteLine("Un kilo son {0} gramos o dos libras", kilo);
            Console.WriteLine("Una tonelada son {0} kilos", tonelada);
            Console.WriteLine("");
            Console.WriteLine("Tambien una libra son {0} gramos, un kilo son {1} gramos y una tonelada son {2} kilos", libra, kilo, tonelada);

            /* Que tipo de error tiene la siguiente sentencia?
             * Console.WriteLine(" Tambien una libra son {1} gramos, un kilo {2} gramos o una tonelada {3} kilos", libra, kilo, tonelada);
            */

            // Uso de operaciones aritmeticas

            Console.WriteLine("");
            Console.WriteLine("Calcular cuanto son dos libras de queso");
            peso = libra * 2;
            Console.WriteLine("Dos libras de queso son {0} gramos", peso);

            /*Realice un programa que permita calcular la suma, resta
             * multiplicación y división de dos numeros, utilizando las constantes
             * "a" y "b" y la variable "resultado". Finalmente, mostrar por
             * pantalla cada resultado*/

            //Precedencia de operaciones aritmeticas, uso de parentesis ()

            int valor1 = 10;
            int valor2 = 2;
            int valor3 = 10;
            int resultado = 0;

            resultado = valor1 + valor2;
            Console.WriteLine(""); 
            Console.WriteLine("la suma de {0} mas {1}, es igual a {2}", valor1, valor2, resultado);

            resultado = (valor1 * valor2) + valor3;
            Console.WriteLine(""); 
            Console.WriteLine("La multiplicación de ({0} * {1}) + {2} = {3}", valor1, valor2, valor3, resultado);
        }
    }
}



