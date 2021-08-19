using System;

namespace AplicacionBase
{
    /* Programa que permite desplegar un menú de opcione para ejecutar 
     * operaciones aritmeticas, haciendo uso ELSE Bloque/Anidado y 
     * la conjunción (Operador lógico Y (AND) )*/

    class program
    {
        static void Main(string [] args)
        {
            int Numero_1 = 0;
            int Numero_2 = 0;
            int Resultado = 0;
            int Opcion = 0;

            Console.WriteLine("1 - Suma"); 
            Console.WriteLine("2 - Resta"); 
            Console.WriteLine("3 - División"); 
            Console.WriteLine("4 - Multiplicación");

            Console.Write("\nQue operación deseas hacer: "); 
            Opcion = int.Parse(System.Console.ReadLine());

            Console.Write("Dame el primer numero por favor: ");
            Numero_1 = int.Parse(System.Console.ReadLine());

            Console.Write("Dame el segundo numero por favor: ");
            Numero_2 = int.Parse(System.Console.ReadLine());

            if (Opcion == 1)
                Resultado = Numero_1 + Numero_2;
            else if (Opcion == 2)
                Resultado= Numero_1 - Numero_2;
            else 
                if (Opcion == 3 && Numero_2 == 0)
                    Console.WriteLine("Divisor igual a cero, no se puede ejecutar la división");
            else 
                if (Opcion == 3 && Numero_2 != 0)
                    Resultado = Numero_1 / Numero_2;
            else 
                if (Opcion == 4)
                    Resultado = Numero_1 * Numero_2;
            Console.WriteLine($"El resultado  es:  {Resultado}");
        }
    }
}
