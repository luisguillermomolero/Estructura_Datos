using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantnums,i,videntif,cont=0;
            string ingresar;
            Console.WriteLine("¿Cuántos numeros va a tener su listade enteros?");
            ingresar = Console.ReadLine();
            cantnums = Convert.ToInt32(ingresar);

            Console.WriteLine("\n¿Cuál va a ser el valor a identificar en su lista?");
            ingresar = Console.ReadLine();
            videntif = Convert.ToInt32(ingresar);

            Console.WriteLine("\n\n");
            int [] nums = new int[cantnums];
            for (i = 0; i < cantnums; i++)
            {
                Console.WriteLine("Digite el valor {0} de su lista",i+1);
                ingresar = Console.ReadLine();
                nums[i] = Convert.ToInt32(ingresar);
            }
            Console.WriteLine("\n\nEsta es la lista de enteros que usted digito");
            for (i = 0; i < cantnums; i++)
            {
                if (nums[i] == videntif)
                {
                    cont = cont + 1;
                    Console.WriteLine("(" + nums[i] + ")");
                }
                else
                    Console.WriteLine("["+nums[i]+"]");  
            }
            Console.WriteLine("\nEl numero que decidio identificar es el {0}, que aparece {1} veces en su lista esta encerrado entre parentesis",videntif,cont);
        }
    }
}
