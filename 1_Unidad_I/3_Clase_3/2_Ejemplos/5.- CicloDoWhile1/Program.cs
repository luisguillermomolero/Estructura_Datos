using System;

namespace AplicacionBase
{
    //Programa que permite resolver operaciones aritmeticas

    class Program
    {
        static void Main(string[] args)
        {
            float primerValor = 0.0f;
            float segundoValor = 0.0f;
            float Resultado = 0.0f;
            int Opcion = 0;

            do
            {
                Console.WriteLine("1 - Suma");
                Console.WriteLine("2 - Resta");
                Console.WriteLine("3 - División");
                Console.WriteLine("4 - Multiplicación");
                Console.WriteLine("5 - Salir");

                Console.Write("Que operación deseas realizar : ");
                Opcion = int.Parse(System.Console.ReadLine());
                    
                if (Opcion != 5)
                {
                    Console.Write("Ingrese el primer número : ");
                    primerValor = int.Parse(System.Console.ReadLine());

                    Console.Write("Ingrese el segundo número : ");
                    segundoValor = int.Parse(System.Console.ReadLine());
    
                    switch (Opcion)
                    {
                        case   1:
                            Resultado = primerValor + segundoValor;
                            break;
                        case   2:
                            Resultado = primerValor - segundoValor;
                            break;
                        case   3:
                            if (segundoValor != 0)
                                Resultado = primerValor/segundoValor;
                            else
                                Console.WriteLine("Divisor no válido");
                            break;
                        case   4:
                            Resultado = primerValor * segundoValor;
                            break;
                        default:
                            Console.WriteLine("Opción no válida");
                            break;
                    }
                Console.WriteLine($"El resultado es: {Resultado}");
                }
            }while(Opcion !=  5);
    }
}
}
