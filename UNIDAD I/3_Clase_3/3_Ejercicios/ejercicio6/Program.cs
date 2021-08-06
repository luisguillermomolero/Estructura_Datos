using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = null;
            do
            {
                int hombremenos = 0;
                int masculino = 0;
                int hombreentre = 0;
                int hombremas = 0;
                int mujerentre = 0;
                int femenino = 0;
                int Estaciv;
                int salario;
                int emplea = 5;
                int prom = 0;
                int homedad = 0;
                int acomulador = 0;

                for (int i = 0; i < emplea; i++)
                {

                    Console.WriteLine("elija su sexo hombre, mujer");
                    string sexo = Console.ReadLine();
                    Console.WriteLine("");
                    switch (sexo)
                    {
                        case ("hombre"):

                            masculino++;
                            Console.WriteLine("digite su edad");
                            homedad = Convert.ToInt32(Console.ReadLine());

                            acomulador = acomulador + homedad;

                            Console.WriteLine("");
                            Console.WriteLine("elija su estado civil (1:soltero, 2:casado, 3:viudo)");
                            Estaciv = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("");
                            switch (Estaciv)
                            {
                                case 1:
                                    Console.WriteLine("");
                                    Console.WriteLine("elija su salario (1:menos de 600 Bs.F., 2:entre 600 y 1000Bs.F., 3:Mas de 1000Bs)");
                                    salario = Convert.ToInt16(Console.ReadLine());
                                    Console.WriteLine("");
                                    switch (salario)
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
                                    Console.WriteLine("elija su salario (1:menos de 600 Bs.F., 2:entre 600 y 1000Bs.F., 3:Mas de 1000Bs)");
                                    salario = Convert.ToInt16(Console.ReadLine());
                                    Console.WriteLine("");
                                    switch (salario)
                                    {
                                        case 1:
                                            Console.WriteLine("usted a digitado menos de 600 Bs.F.");
                                            hombremenos++;
                                            break;
                                        case 2:
                                            Console.WriteLine("Usted digito entre 600 y 1000Bs.F.");
                                            hombreentre++;
                                            break;
                                        case 3:
                                            Console.WriteLine("Usted digito Mas de 1000Bs");
                                            hombremas++;
                                            break;
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("");
                                    Console.WriteLine("elija su salario (1:menos de 600 Bs.F., 2:entre 600 y 1000Bs.F., 3:Mas de 1000Bs)");
                                    salario = Convert.ToInt16(Console.ReadLine());
                                    Console.WriteLine("");
                                    switch (salario)
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
                            femenino++;
                            Console.WriteLine("digite su edad");
                            int mujeedad = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("");
                            Console.WriteLine("elija su estado civil (1:soltera, 2:casada, 3:viuda)");
                            Estaciv = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("");
                            switch (Estaciv)
                            {
                                case 1:
                                    Console.WriteLine("");
                                    Console.WriteLine("elija su salario (1:menos de 600 Bs.F., 2:entre 600 y 1000Bs.F., 3:Mas de 1000Bs)");
                                    salario = Convert.ToInt16(Console.ReadLine());
                                    Console.WriteLine("");
                                    switch (salario)
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
                                    Console.WriteLine("elija su salario (1:menos de 600 Bs.F., 2:entre 600 y 1000Bs.F., 3:Mas de 1000Bs)");
                                    salario = Convert.ToInt16(Console.ReadLine());
                                    Console.WriteLine("");
                                    switch (salario)
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
                                    Console.WriteLine("elija su salario (1:menos de 600 Bs.F., 2:entre 600 y 1000Bs.F., 3:Mas de 1000Bs)");
                                    salario = Convert.ToInt16(Console.ReadLine());
                                    Console.WriteLine("");
                                    switch (salario)
                                    {
                                        case 1:
                                            Console.WriteLine("usted a digitado menos de 600 Bs.F.");
                                            break;
                                        case 2:
                                            Console.WriteLine("Usted digito entre 600 y 1000Bs.F.");
                                            mujerentre++;
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
                prom = acomulador / masculino;

                Console.WriteLine("El total de personas del sexo femnino son: " + femenino);
                Console.WriteLine("");
                Console.WriteLine("Total de hombres casados que ganan más de 1000 Bs.F. : " + hombremas);
                Console.WriteLine("");
                Console.WriteLine("Total de mujeres viudas que ganan más de 600 Bs: " + mujerentre);
                Console.WriteLine("");
                Console.WriteLine("el promedio de edad de los hombre es de: " + prom);


                Console.WriteLine("deseas continual ejecutando la aplicacion? (s/n)");
                s1 = Console.ReadLine();

            } while (s1 == "s");

            Console.WriteLine();

        }
    }
}
