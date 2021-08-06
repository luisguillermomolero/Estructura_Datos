using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            string introducir;
            int i, numnotas, defi=0, regul=0,buen=0,excel=0;
            //Generar aleatoriamente y mostrar las 20 notas
            int[] vnotas;
            vnotas = new int[20];
            Random aleo = new Random();

            Console.WriteLine("¿Cuantas notas de estudiantes quiere generar aleatoriamente?");
            introducir = Console.ReadLine();
            numnotas = Convert.ToInt32(introducir);
            Console.WriteLine("\nAqui estan sus {0} notas generadas aleatoriamente",numnotas);
            Console.WriteLine("\n");
            for (i = 0; i < numnotas; i++)
            {
                vnotas[i] = Convert.ToInt32(aleo.Next(20));
                Console.WriteLine("["+vnotas[i]+"]");
            }

            for (i = 0; i < numnotas; i++) 
            {
                if (vnotas[i] <= 5)
                {
                    defi = defi + 1;
                }
                else if (vnotas[i] >=6 && vnotas[i] <= 10)
                {
                    regul = regul + 1;
                }
                else if(vnotas[i] >=11 && vnotas[i] <= 15)
                {
                    buen = buen + 1;
                }else if(vnotas[i] >= 16 && vnotas[i] <= 20)
                {
                    excel = excel + 1;
                }
            }
            Console.WriteLine("\n\n[{0}] estudiantes son deficientes,\n[{1}] estudiantes son regulares,\n[{2}] estudiantes son buenos\n[{3}] estudiantes son excelentes",defi,regul,buen,excel);
        }
    }
}
