using System;

namespace ejercico9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int numer;
            int mayor = 0;
            int a = 0;
            int ejer = 0;


            switch (ejer)
            {
                case 0:
                    Console.WriteLine("   Para salir, teclee -99");
                    Console.WriteLine("");
                    Console.Write("   Introduzca la cantidad de numeros a digitar ");
                    num = int.Parse(Console.ReadLine());
                    for (int i = 0; i < num; i++)
                    {
                        Console.Write("   Escriba un numero ");
                        numer = int.Parse(Console.ReadLine());

                        if (i == 0)
                        {
                            mayor = numer;
                            a = numer;
                        }
                        else if (i != 0)
                        {
                            if (numer < a)
                            
                                a = numer;
                            
                            if (numer > mayor)
                            
                                mayor = numer;
                            
                        }
                    }
                    Console.WriteLine("");
                    Console.Write("   El numero mayor es " + mayor);
                    break;
            }
        }
    }
}
