using System;

namespace AplicacionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int opt;
            string entrada1;

            do
            {

                
                Console.WriteLine("Del ejercicio #9 al ejercicio #11 ¿Cuál desea ejecutar?\n (Por favor digitar el numero del ejercicio),\n(si ya no desea ejecutar ningun otro ejercicio por favor digite 0)");
                entrada1= Console.ReadLine();
                opt = Convert.ToInt32(entrada1);

                switch (opt)
                {

                    case 9:
                        string entrada2;
                        Console.WriteLine("Ejercicio 9).\n\n Leer una serie de números distintos de cero,\n (el último número de la lista debe ser el –99),\n obtener el número mayor.\n");
                        int num, may = 0;
                        Console.WriteLine("Ejecucion:\n\n Digite un numero distinto a cero\n\n...Cuando termine de insertar todos los numeros,\n escriba -99 para mostrar el numero mayor ingresado en pantalla");
                        entrada2 = Console.ReadLine();
                        num = Convert.ToInt32(entrada2);

                        do
                        {
                            Console.WriteLine("inserte otro numero distinto a cero");
                            entrada2 = Console.ReadLine();
                            num = Convert.ToInt32(entrada2);

                            if (num > may)
                            {
                                may = num;
                            }
                        } while (num != -99) ;

                        Console.WriteLine("\n el numero mayor es el {0}\n", may);
                        Console.WriteLine("Fin del ejercicio.\n\n\n\n");
                        break;


                    case 10:
                        string entrada3;
                        Console.WriteLine("Ejercicio 10).\n\nDado el siguiente conjunto de datos relativos a 20 empleados de una empresa:\n" +
                        "a.Edad de la persona\n" +
                        "b.Estadocivil\n" +
                        "   i.Soltero(a)\n" +
                        "   ii.Casado(a)\n" +
                        "   iii.Viudo(a)\n" +
                        "c.Sexo\n" +
                        "   i.Femenino\n" +
                        "   ii.Masculino\n" +
                        "d.Salario\n" +
                        "   i.Menos de 600 Bs.F.\n" +
                        "   ii.Entre 600 y 1000 Bs.F.\n" +
                        "   iii.Más de 1000Bs.\n\n" +
                        "Se pide desarrollar un algoritmo para determinar:\n" +
                        "  1.Total de empleados del sexo femenino\n" +
                        "  2.Total de hombres casados que ganan más de 1000 Bs.F.\n" +
                        "  3.Total de mujeres viudas que ganan másde 600 Bs.\n" +
                        "4.Edad promedio de los hombres.\n");

                        int nume, i, edad, escvl, sx, sal, cont1 = 0, cont2 = 0, cont3 = 0, cont4 = 0;
                        double edadtotalh = 0, edadpromh = 0;


                        Console.WriteLine("Ejecucion:\n\n ¿Para cuántos empleados desea hacer las estadisticas?");
                        entrada3 = Console.ReadLine();
                        nume = Convert.ToInt32(entrada3);

                        for (i = 1; i <= nume; i++)
                        {
                            Console.WriteLine("digite la edad del empleado " + i);
                            entrada3 = Console.ReadLine();
                            edad = Convert.ToInt32(entrada3);

                            Console.WriteLine("indique el estado civil del empleado " + i + " donde:\n 1= soltero\n 2= casado \n 3= viudo");
                            entrada3 = Console.ReadLine();
                            escvl = Convert.ToInt32(entrada3);

                            Console.WriteLine("indique el sexo del empleado " + i + " donde:\n 1= femenino\n 2= masculino");
                            entrada3 = Console.ReadLine();
                            sx = Convert.ToInt32(entrada3);
                            if (sx == 1)
                            {
                                cont1 = cont1 + 1;
                            }
                            if (sx == 2)
                            {
                                cont2 = cont2 + 1;
                            }
                            if (sx == 2)
                            {
                                edadtotalh = edadtotalh + edad;
                            }
                            Console.WriteLine("indique el rango de salario del empleado " + i + " donde:\n 1= menos de 600 Bs.F.\n 2= Entre 600 y 1000 Bs.F. \n 3= Mas de 1000Bs.F.");
                            entrada3 = Console.ReadLine();
                            sal = Convert.ToInt32(entrada3);

                            if (sx == 2 && escvl == 2 && sal == 3)
                            {
                                cont3 = cont3 + 1;
                            }
                            else if (sx == 1 && escvl == 3 && sal == 2)
                            {
                                cont4 = cont4 + 1;
                            }

                        }
                        if (edadtotalh > 1)
                        {
                            edadpromh = edadtotalh / cont2;
                        }

                        Console.WriteLine("\n en total hay {0} empleados de sexo femenino", cont1);
                        Console.WriteLine("en total hay {0} hombres casados que ganan mas de 1000Bs.F.", cont3);
                        Console.WriteLine("en total hay {0} mujeres viudas que ganan mas de 600Bs.F", cont4);
                        Console.WriteLine("la edad promedio de los hombres es de {0} años\n", edadpromh);
                        Console.WriteLine("Fin del ejericio\n\n\n");
                        break;


                    case 11:
                        string entrada4;

                        Console.WriteLine("Ejercicio 11).\n\n Se desea realizar una estadística de los pesos\n de los alumnos de un colegio,de acuerdo a la siguiente tabla:" +
                        "  a.Alumnos de menos de 40Kg.\n" +
                        "  b.Alumnos entre 40 y 50 Kg.\n" +
                        "  c.Alumnos de más de 50 y menos de 60Kg.\n" +
                        "  d.Alumnos de más o igual a 60 Kg.\n\n");


                        int p, cont10 = 0, cont20 = 0, cont30 = 0, cont40 = 0;

                        Console.WriteLine("Ejecucion:\n\n Digite el peso de un estudiante.\n\n ...Cuando el peso de todos los estudiantes ya este registrado,\n porfavor digite -99, para mostrar las estadisticas en pantalla");
                        entrada4 = Console.ReadLine();
                        p = Convert.ToInt32(entrada4);

                        do
                        {
                            Console.WriteLine("digite el peso del siguiente estudiante");
                            entrada4 = Console.ReadLine();
                            p = Convert.ToInt32(entrada4);

                            if (p < 40)
                            {
                                cont10 = cont10 + 1;
                            }
                            else if (p >= 40 && p <= 50)
                            {
                                cont20 = cont20 + 1;
                            }
                            else if (p > 50 && p < 60)
                            {
                                cont30 = cont30 + 1;
                            }
                            else
                            {
                                cont40 = cont40 + 1;
                            }
                        } while (p != -99);

                        Console.WriteLine("\n En el colegio hay {0} estudiantes con un peso menor a 40 kg", cont10);
                        Console.WriteLine("En el colegio hay {0} estudiantes con un peso entre 40 y 50 kg", cont20);
                        Console.WriteLine("En el colegio hay {0} estudiantes con un peso mayor a 50 y menor a 60 kg", cont30);
                        Console.WriteLine("En el colegio hay {0} estudiantes con un peso mayor o igual a 60 kg", cont40);
                        Console.WriteLine("Fin del ejercicio\n\n\n");
                        break;
                }

            } while (opt != 0);
        }
    }
}
