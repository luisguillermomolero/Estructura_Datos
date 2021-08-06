using System;

namespace ejercicio11
{
    class Program
    { 

        static void Main(string[] args)
        {
            int est;
            int prom_reprobados = 0;
            int prom_aprobados = 0;
            int i;
            int sumar_aprobados = 0;
            int sumar_reprobados = 0;
            int aprobados = 0;
            int desaprobados = 0;
            int tot_aprobados = 0;
            int tot_reprobados = 0;

            Console.WriteLine("hola profesor hoy vamos a ver cuantos estudiantes aprobaron y cunatos no");
            Console.WriteLine("");
            Console.WriteLine("primero digite cuantos estudiantes son");
            est = Convert.ToInt32(Console.ReadLine());

            int[] nota = new int[est];



            for ( i = 0; i < est; i++)
            {
                Console.WriteLine("porfavor digitame las notas de cada estudiante; recuerde que el maximo es 20 y el minimo es 0");
                nota[i] = Convert.ToInt32(Console.ReadLine());

                if (nota[i] >= 15)
                {
                    aprobados += nota[i];
                    tot_aprobados = tot_aprobados+1;
                }
                else
                {
                    desaprobados += nota[i];
                    tot_reprobados = tot_reprobados+1;
                }
            }

            for (i = 0; i < est; i++)
            {
                sumar_aprobados += aprobados;
                sumar_reprobados += desaprobados;
            }

            
            prom_aprobados = sumar_aprobados / est;
            prom_reprobados = sumar_reprobados / est;

            Console.WriteLine("el promedio de aprobados es de: " + prom_aprobados + "%");
            Console.WriteLine("");
            Console.WriteLine("el promedio de aprobados es de: " + prom_reprobados + "%");
            Console.WriteLine("");
            Console.WriteLine("la cantidad de aprovados es de "+tot_aprobados);
            Console.WriteLine("");
            Console.WriteLine("la cantidad de reprovados es de " + tot_reprobados);


        }
    }
}
