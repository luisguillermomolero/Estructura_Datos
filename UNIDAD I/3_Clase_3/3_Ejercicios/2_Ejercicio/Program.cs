using System;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero;
            int contadorPar = 0; 
            int contadorImpar = 0;
            int acumuladorPar = 0;
            int acumuladorImpar = 0;
            int CANTIDAD_LIMITE = 2;

            for (int i = 1; i <= CANTIDAD_LIMITE; i++)
            {
                Console.Write($"Por favor, digite el número {i} de {CANTIDAD_LIMITE} solicitados: ");
                Numero = int.Parse(System.Console.ReadLine());

                if ((Numero % 2) == 0)
                {
                    contadorPar += 1;
                    acumuladorPar += Numero;
                }
                else
                {
                    contadorImpar += 1;
                    acumuladorImpar += Numero;
                }
            }
            Console.WriteLine($"\nLa cantidad de números pares digitados fueron: {contadorPar} y su sumatoria de {acumuladorPar}");
            Console.WriteLine($"La cantidad de números impares digitados fueron: {contadorImpar} y su sumatoria de {acumuladorImpar}");
        }
    }
}
