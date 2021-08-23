using System;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadNumeros;
            int Numero;
            int Mayor = 0;
            int numeroMayor = 0;
            int whileLoop = 0;

                do{
                    Console.Write("   Introduzca la cantidad de numeros a digitar ");
                    cantidadNumeros = int.Parse(Console.ReadLine());
                    for (int i = 0; i < cantidadNumeros; i++)
                    {
                        Console.Write("   Escriba un numero ");
                        Numero = int.Parse(Console.ReadLine());

                        if (i == 0)
                        {
                            Mayor = Numero;
                            numeroMayor = Numero;
                        }
                        else if (i != 0)
                        {
                            if (Numero < numeroMayor)
                                numeroMayor = Numero;
                            if (Numero > Mayor)
                                Mayor = Numero;
                        }
                    }
                    Console.WriteLine("");
                    Console.Write("   El numero Mayor es " + Mayor);
                    
                    Console.WriteLine("\n\nDesea continuar? -99 para salir");
                    whileLoop = int.Parse(Console.ReadLine());

                }while(whileLoop != -99);
        }
    }
}
