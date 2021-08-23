using System;
using System.Collections.Generic;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int hombreMenos = 0;
            int Masculino = 0;
            int hombreEntre = 0;
            int hombreMas = 0;
            int mujerEntre = 0;
            int Femenino = 0;
            int estadoCivil;
            int Salario;
            int CANTIDAD_EMPLEADOS = 20;
            int Promedio = 0;
            int acumuladorSexoHombre = 0;
            int acomulador = 0;

            for (int i = 0; i < CANTIDAD_EMPLEADOS; i++)
            {

                Console.WriteLine(" Seleccione el sexo hombre/mujer");
                string sexo = Console.ReadLine();
                Console.WriteLine("");
                switch (sexo)
                {
                    case ("hombre"):

                        Masculino++;
                        Console.WriteLine("digite su edad");
                        acumuladorSexoHombre = Convert.ToInt32(Console.ReadLine());

                        acomulador = acomulador + acumuladorSexoHombre;

                        Console.WriteLine("");
                        Console.WriteLine("elija su estado civil (1:soltero, 2:casado, 3:viudo)");
                        estadoCivil = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("");
                        switch (estadoCivil)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("elija su Salario (1:menos de 600 Bs.F., 2:entre 600 y 1000Bs.F., 3:Mas de 1000Bs)");
                                Salario = Convert.ToInt16(Console.ReadLine());
                                Console.WriteLine("");
                                switch (Salario)
                                {
                                    case 1:
                                        Console.WriteLine("usted a digitado menos de 600 Bs.F.");
                                        break;
                                    case 2:
                                        Console.WriteLine("Usted digito entre 600 y 1000Bs.F.");
                                        break;
                                    case 3:
                                        Console.WriteLine("Usted digito Mas de 1000Bs");
                                        break;
                                }
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("elija su Salario (1:menos de 600 Bs.F., 2:entre 600 y 1000Bs.F., 3:Mas de 1000Bs)");
                                Salario = Convert.ToInt16(Console.ReadLine());
                                Console.WriteLine("");
                                switch (Salario)
                                {
                                    case 1:
                                        Console.WriteLine("usted a digitado menos de 600 Bs.F.");
                                        hombreMenos++;
                                        break;
                                    case 2:
                                        Console.WriteLine("Usted digito entre 600 y 1000Bs.F.");
                                        hombreEntre++;
                                        break;
                                    case 3:
                                        Console.WriteLine("Usted digito Mas de 1000Bs");
                                        hombreMas++;
                                        break;
                                }
                                break;
                            case 3:
                                Console.WriteLine("");
                                Console.WriteLine("elija su Salario (1:menos de 600 Bs.F., 2:entre 600 y 1000Bs.F., 3:Mas de 1000Bs)");
                                Salario = Convert.ToInt16(Console.ReadLine());
                                Console.WriteLine("");
                                switch (Salario)
                                {
                                    case 1:
                                        Console.WriteLine("usted a digitado menos de 600 Bs.F.");
                                        break;
                                    case 2:
                                        Console.WriteLine("Usted digito entre 600 y 1000Bs.F.");
                                        break;
                                    case 3:
                                        Console.WriteLine("Usted digito Mas de 1000Bs");
                                        break;
                                }
                                break;
                        }
                        break;
                    case ("mujer"):
                        Femenino++;
                        Console.WriteLine("digite su edad");
                        int mujeedad = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("elija su estado civil (1:soltera, 2:casada, 3:viuda)");
                        estadoCivil = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("");
                        switch (estadoCivil)
                        {
                            case 1:
                                Console.WriteLine("");
                                Console.WriteLine("elija su Salario (1:menos de 600 Bs.F., 2:entre 600 y 1000Bs.F., 3:Mas de 1000Bs)");
                                Salario = Convert.ToInt16(Console.ReadLine());
                                Console.WriteLine("");
                                switch (Salario)
                                {
                                    case 1:
                                        Console.WriteLine("usted a digitado menos de 600 Bs.F.");
                                        break;
                                    case 2:
                                        Console.WriteLine("Usted digito entre 600 y 1000Bs.F.");
                                        break;
                                    case 3:
                                        Console.WriteLine("Usted digito Mas de 1000Bs");
                                        break;
                                }
                                break;
                            case 2:
                                Console.WriteLine("");
                                Console.WriteLine("elija su Salario (1:menos de 600 Bs.F., 2:entre 600 y 1000Bs.F., 3:Mas de 1000Bs)");
                                Salario = Convert.ToInt16(Console.ReadLine());
                                Console.WriteLine("");
                                switch (Salario)
                                {
                                    case 1:
                                        Console.WriteLine("usted a digitado menos de 600 Bs.F.");
                                        break;
                                    case 2:
                                        Console.WriteLine("Usted digito entre 600 y 1000Bs.F.");
                                        break;
                                    case 3:
                                        Console.WriteLine("Usted digito Mas de 1000Bs");
                                        break;
                                }
                                break;
                            case 3:
                                Console.WriteLine("");
                                Console.WriteLine("elija su Salario (1:menos de 600 Bs.F., 2:entre 600 y 1000Bs.F., 3:Mas de 1000Bs)");
                                Salario = Convert.ToInt16(Console.ReadLine());
                                Console.WriteLine("");
                                switch (Salario)
                                {
                                    case 1:
                                        Console.WriteLine("usted a digitado menos de 600 Bs.F.");
                                        break;
                                    case 2:
                                        Console.WriteLine("Usted digito entre 600 y 1000Bs.F.");
                                        mujerEntre++;
                                        break;
                                    case 3:
                                        Console.WriteLine("Usted digito Mas de 1000Bs");
                                        break;
                                }
                                break;
                        }
                        break;
                }

                

            }
            Promedio = acomulador / Masculino;


            Console.WriteLine("");

            Console.WriteLine("El total de personas del sexo Femenino son: " + Femenino);
            Console.WriteLine("");
            Console.WriteLine("Total de hombres casados que ganan más de 1000 Bs.F. : " + hombreMas);
            Console.WriteLine("");
            Console.WriteLine("Total de mujeres viudas que ganan más de 600 Bs: " + mujerEntre);
            Console.WriteLine("");
            Console.WriteLine("El Promedioedio de edad de los hombre es de: " + Promedio);



        }
    }
}
