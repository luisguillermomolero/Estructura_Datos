using System;
using System.Collections.Generic;
using System.Text;


namespace AplicacionBase
{
    //Programa que permite resolver operaciones aritmeticas

    class Program
    {
        static void Main(string[] args)
        {
            float a = 0.0f;
            float b = 0.0f;
            float resultado = 0.0f;
            string valor = "";
            int opcion = 0;

            do
            {
                Console.WriteLine("1 - Suma");
                Console.WriteLine("2 - Resta");
                Console.WriteLine("3 - División");
                Console.WriteLine("4 - Multiplicación");
                Console.WriteLine("5 - Salir");

                Console.Write("Que operación deseas realizar : ");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);
                    
                if (opcion != 5)
                {
                    Console.Write("Ingrese el primer número : ");
                    valor = Console.ReadLine();
                    a = Convert.ToSingle(valor);

                    Console.Write("Ingrese el segundo número : ");
                    valor = Console.ReadLine();
                    b = Convert.ToSingle(valor);
    
                    switch (opcion)
                    {
                        case   1:
                            resultado = a + b;
                            break;
                        case   2:
                            resultado = a - b;
                            break;
                        case   3:
                            if (b != 0)
                                resultado = a  / b;
                            else
                                Console.WriteLine("Divisor no  válido");
                            break;
                        case   4:
                            resultado = a * b;
                            break;
                        default:
                            Console.WriteLine("Opción no válida");
                            break;
                    }
                Console.WriteLine("El resultado es: {0}", resultado);
                }
            } while   (opcion !=  5);
    }
}
}
