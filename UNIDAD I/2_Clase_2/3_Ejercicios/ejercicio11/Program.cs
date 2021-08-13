using System;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int Alumno = 0;
            int Peso = 0;
            int Menos_4 = 0;
            int Mas_4 = 0;
            int Mas_5 = 0;
            int MAs_6 = 0;
            int whileLoop = 0;

            Console.WriteLine("  *** Estadisticas de Peso de un grupo de Alumnos *** ");

            do{
                Console.WriteLine("      ** Digite -99 para salir del sistema ** ");
                whileLoop = int.Parse(System.Console.ReadLine());
                
                if (whileLoop != -99){
                    Console.WriteLine("      Por favor, digite la cantidad de alumnos: ");
                    Alumno = int.Parse(System.Console.ReadLine());

                    for (int i = 1; i <= Alumno; i++){

                        Console.WriteLine("      1: Peso menor de 40kg");
                        Console.WriteLine("      2: Peso entre 40 y 50kg");
                        Console.WriteLine("      3: Peso entre 50 y 59kg");
                        Console.WriteLine("      4: Peso igual o mayor a 60kg");

                        Console.WriteLine("");
                        Console.Write("                     Seleccione el peso del estudiante {0} : ", i);
                        Peso = int.Parse(System.Console.ReadLine());

                        Console.WriteLine("");
                        switch (Peso)
                        {
                            case 1:
                                Console.WriteLine("          Seleccionó un Peso menor de 40kg");
                                Menos_4++;
                                break;
                            case 2:
                                Console.WriteLine("          Seleccionó un Peso entre 40 y 49kg");
                                Mas_4++;
                                break;
                            case 3:
                                Console.WriteLine("          Seleccionó un Peso entre 50 y menos de 59kg");
                                Mas_5++;
                                break;
                            case 4:
                                Console.WriteLine("          Seleccionó un Peso mayor a 60kg");
                                MAs_6++;
                                break;
                        }

                    }

                }

                }while (whileLoop != -99);

            Console.WriteLine("la cantidad de alumnos que pesan menos de 40kg son: " + Menos_4);
            Console.WriteLine("la cantidad de alumnos que pesan entre 40 y 50kg: " + Mas_4);
            Console.WriteLine("la cantidad de alumnos que pesan mas de 50 y menos de 60kg: " + Mas_5);
            Console.WriteLine("la cantidad de alumnos que pesan mas o igual a 60kg: " + MAs_6);
        }
    }
}
    